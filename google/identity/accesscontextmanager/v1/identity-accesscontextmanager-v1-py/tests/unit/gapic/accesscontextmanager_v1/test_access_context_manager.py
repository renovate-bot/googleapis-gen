# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
import os
import mock

import grpc
from grpc.experimental import aio
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule


from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.identity.accesscontextmanager.type import device_resources_pb2  # type: ignore
from google.identity.accesscontextmanager_v1.services.access_context_manager import AccessContextManagerAsyncClient
from google.identity.accesscontextmanager_v1.services.access_context_manager import AccessContextManagerClient
from google.identity.accesscontextmanager_v1.services.access_context_manager import pagers
from google.identity.accesscontextmanager_v1.services.access_context_manager import transports
from google.identity.accesscontextmanager_v1.types import access_context_manager
from google.identity.accesscontextmanager_v1.types import access_level
from google.identity.accesscontextmanager_v1.types import access_level as gia_access_level
from google.identity.accesscontextmanager_v1.types import access_policy
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding as gia_gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import service_perimeter
from google.identity.accesscontextmanager_v1.types import service_perimeter as gia_service_perimeter
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.type import expr_pb2  # type: ignore
import google.auth


def client_cert_source_callback():
    return b"cert bytes", b"key bytes"


# If default endpoint is localhost, then default mtls endpoint will be the same.
# This method modifies the default endpoint so the client can produce a different
# mtls endpoint for endpoint testing purposes.
def modify_default_endpoint(client):
    return "foo.googleapis.com" if ("localhost" in client.DEFAULT_ENDPOINT) else client.DEFAULT_ENDPOINT


def test__get_default_mtls_endpoint():
    api_endpoint = "example.googleapis.com"
    api_mtls_endpoint = "example.mtls.googleapis.com"
    sandbox_endpoint = "example.sandbox.googleapis.com"
    sandbox_mtls_endpoint = "example.mtls.sandbox.googleapis.com"
    non_googleapi = "api.example.com"

    assert AccessContextManagerClient._get_default_mtls_endpoint(None) is None
    assert AccessContextManagerClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert AccessContextManagerClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert AccessContextManagerClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert AccessContextManagerClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert AccessContextManagerClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    AccessContextManagerClient,
    AccessContextManagerAsyncClient,
])
def test_access_context_manager_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'accesscontextmanager.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.AccessContextManagerGrpcTransport, "grpc"),
    (transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_access_context_manager_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    AccessContextManagerClient,
    AccessContextManagerAsyncClient,
])
def test_access_context_manager_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'accesscontextmanager.googleapis.com:443'


def test_access_context_manager_client_get_transport_class():
    transport = AccessContextManagerClient.get_transport_class()
    available_transports = [
        transports.AccessContextManagerGrpcTransport,
    ]
    assert transport in available_transports

    transport = AccessContextManagerClient.get_transport_class("grpc")
    assert transport == transports.AccessContextManagerGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AccessContextManagerClient, transports.AccessContextManagerGrpcTransport, "grpc"),
    (AccessContextManagerAsyncClient, transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(AccessContextManagerClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AccessContextManagerClient))
@mock.patch.object(AccessContextManagerAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AccessContextManagerAsyncClient))
def test_access_context_manager_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(AccessContextManagerClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(AccessContextManagerClient, 'get_transport_class') as gtc:
        client = client_class(transport=transport_name)
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host="squid.clam.whelk",
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name)
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
                always_use_jwt_access=True,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name)
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_MTLS_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
                always_use_jwt_access=True,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT has
    # unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "Unsupported"}):
        with pytest.raises(MutualTLSChannelError):
            client = client_class()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = client_class()

    # Check the case quota_project_id is provided
    options = client_options.ClientOptions(quota_project_id="octopus")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id="octopus",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name,use_client_cert_env", [
    (AccessContextManagerClient, transports.AccessContextManagerGrpcTransport, "grpc", "true"),
    (AccessContextManagerAsyncClient, transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (AccessContextManagerClient, transports.AccessContextManagerGrpcTransport, "grpc", "false"),
    (AccessContextManagerAsyncClient, transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(AccessContextManagerClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AccessContextManagerClient))
@mock.patch.object(AccessContextManagerAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AccessContextManagerAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_access_context_manager_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name, client_options=options)

            if use_client_cert_env == "false":
                expected_client_cert_source = None
                expected_host = client.DEFAULT_ENDPOINT
            else:
                expected_client_cert_source = client_cert_source_callback
                expected_host = client.DEFAULT_MTLS_ENDPOINT

            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=expected_host,
                scopes=None,
                client_cert_source_for_mtls=expected_client_cert_source,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
                always_use_jwt_access=True,
            )

    # Check the case ADC client cert is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch.object(transport_class, '__init__') as patched:
            with mock.patch('google.auth.transport.mtls.has_default_client_cert_source', return_value=True):
                with mock.patch('google.auth.transport.mtls.default_client_cert_source', return_value=client_cert_source_callback):
                    if use_client_cert_env == "false":
                        expected_host = client.DEFAULT_ENDPOINT
                        expected_client_cert_source = None
                    else:
                        expected_host = client.DEFAULT_MTLS_ENDPOINT
                        expected_client_cert_source = client_cert_source_callback

                    patched.return_value = None
                    client = client_class(transport=transport_name)
                    patched.assert_called_once_with(
                        credentials=None,
                        credentials_file=None,
                        host=expected_host,
                        scopes=None,
                        client_cert_source_for_mtls=expected_client_cert_source,
                        quota_project_id=None,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                        always_use_jwt_access=True,
                    )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch.object(transport_class, '__init__') as patched:
            with mock.patch("google.auth.transport.mtls.has_default_client_cert_source", return_value=False):
                patched.return_value = None
                client = client_class(transport=transport_name)
                patched.assert_called_once_with(
                    credentials=None,
                    credentials_file=None,
                    host=client.DEFAULT_ENDPOINT,
                    scopes=None,
                    client_cert_source_for_mtls=None,
                    quota_project_id=None,
                    client_info=transports.base.DEFAULT_CLIENT_INFO,
                    always_use_jwt_access=True,
                )


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AccessContextManagerClient, transports.AccessContextManagerGrpcTransport, "grpc"),
    (AccessContextManagerAsyncClient, transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_access_context_manager_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=["1", "2"],
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AccessContextManagerClient, transports.AccessContextManagerGrpcTransport, "grpc"),
    (AccessContextManagerAsyncClient, transports.AccessContextManagerGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_access_context_manager_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file="credentials.json",
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )


def test_access_context_manager_client_client_options_from_dict():
    with mock.patch('google.identity.accesscontextmanager_v1.services.access_context_manager.transports.AccessContextManagerGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = AccessContextManagerClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host="squid.clam.whelk",
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )


def test_list_access_policies(transport: str = 'grpc', request_type=access_context_manager.ListAccessPoliciesRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListAccessPoliciesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_access_policies(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessPoliciesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAccessPoliciesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_access_policies_from_dict():
    test_list_access_policies(request_type=dict)


def test_list_access_policies_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__') as call:
        client.list_access_policies()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessPoliciesRequest()


@pytest.mark.asyncio
async def test_list_access_policies_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ListAccessPoliciesRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListAccessPoliciesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_access_policies(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessPoliciesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAccessPoliciesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_access_policies_async_from_dict():
    await test_list_access_policies_async(request_type=dict)


def test_list_access_policies_pager():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_access_policies(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, access_policy.AccessPolicy)
                   for i in results)

def test_list_access_policies_pages():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_access_policies(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_access_policies_async_pager():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_access_policies(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, access_policy.AccessPolicy)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_access_policies_async_pages():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_policies),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessPoliciesResponse(
                access_policies=[
                    access_policy.AccessPolicy(),
                    access_policy.AccessPolicy(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_access_policies(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_access_policy(transport: str = 'grpc', request_type=access_context_manager.GetAccessPolicyRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_policy.AccessPolicy(
            name='name_value',
            parent='parent_value',
            title='title_value',
            etag='etag_value',
        )
        response = client.get_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, access_policy.AccessPolicy)
    assert response.name == 'name_value'
    assert response.parent == 'parent_value'
    assert response.title == 'title_value'
    assert response.etag == 'etag_value'


def test_get_access_policy_from_dict():
    test_get_access_policy(request_type=dict)


def test_get_access_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        client.get_access_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessPolicyRequest()


@pytest.mark.asyncio
async def test_get_access_policy_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.GetAccessPolicyRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_policy.AccessPolicy(
            name='name_value',
            parent='parent_value',
            title='title_value',
            etag='etag_value',
        ))
        response = await client.get_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, access_policy.AccessPolicy)
    assert response.name == 'name_value'
    assert response.parent == 'parent_value'
    assert response.title == 'title_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_get_access_policy_async_from_dict():
    await test_get_access_policy_async(request_type=dict)


def test_get_access_policy_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetAccessPolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        call.return_value = access_policy.AccessPolicy()
        client.get_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_access_policy_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetAccessPolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_policy.AccessPolicy())
        await client.get_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_access_policy_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_policy.AccessPolicy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_access_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_access_policy_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_access_policy(
            access_context_manager.GetAccessPolicyRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_access_policy_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_policy.AccessPolicy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_policy.AccessPolicy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_access_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_get_access_policy_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_access_policy(
            access_context_manager.GetAccessPolicyRequest(),
            name='name_value',
        )


def test_create_access_policy(transport: str = 'grpc', request_type=access_policy.AccessPolicy):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_policy.AccessPolicy()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_access_policy_from_dict():
    test_create_access_policy(request_type=dict)


def test_create_access_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_policy),
            '__call__') as call:
        client.create_access_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_policy.AccessPolicy()


@pytest.mark.asyncio
async def test_create_access_policy_async(transport: str = 'grpc_asyncio', request_type=access_policy.AccessPolicy):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_policy.AccessPolicy()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_access_policy_async_from_dict():
    await test_create_access_policy_async(request_type=dict)


def test_update_access_policy(transport: str = 'grpc', request_type=access_context_manager.UpdateAccessPolicyRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_access_policy_from_dict():
    test_update_access_policy(request_type=dict)


def test_update_access_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        client.update_access_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessPolicyRequest()


@pytest.mark.asyncio
async def test_update_access_policy_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.UpdateAccessPolicyRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_access_policy_async_from_dict():
    await test_update_access_policy_async(request_type=dict)


def test_update_access_policy_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateAccessPolicyRequest()

    request.policy.name = 'policy.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'policy.name=policy.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_access_policy_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateAccessPolicyRequest()

    request.policy.name = 'policy.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'policy.name=policy.name/value',
    ) in kw['metadata']


def test_update_access_policy_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_access_policy(
            policy=access_policy.AccessPolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].policy
        mock_val = access_policy.AccessPolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_access_policy_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_access_policy(
            access_context_manager.UpdateAccessPolicyRequest(),
            policy=access_policy.AccessPolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_access_policy_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_access_policy(
            policy=access_policy.AccessPolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].policy
        mock_val = access_policy.AccessPolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_access_policy_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_access_policy(
            access_context_manager.UpdateAccessPolicyRequest(),
            policy=access_policy.AccessPolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_delete_access_policy(transport: str = 'grpc', request_type=access_context_manager.DeleteAccessPolicyRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_access_policy_from_dict():
    test_delete_access_policy(request_type=dict)


def test_delete_access_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        client.delete_access_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessPolicyRequest()


@pytest.mark.asyncio
async def test_delete_access_policy_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.DeleteAccessPolicyRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_access_policy_async_from_dict():
    await test_delete_access_policy_async(request_type=dict)


def test_delete_access_policy_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteAccessPolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_access_policy_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteAccessPolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_access_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_access_policy_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_access_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_access_policy_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_access_policy(
            access_context_manager.DeleteAccessPolicyRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_access_policy_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_access_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_delete_access_policy_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_access_policy(
            access_context_manager.DeleteAccessPolicyRequest(),
            name='name_value',
        )


def test_list_access_levels(transport: str = 'grpc', request_type=access_context_manager.ListAccessLevelsRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListAccessLevelsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessLevelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAccessLevelsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_access_levels_from_dict():
    test_list_access_levels(request_type=dict)


def test_list_access_levels_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        client.list_access_levels()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessLevelsRequest()


@pytest.mark.asyncio
async def test_list_access_levels_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ListAccessLevelsRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListAccessLevelsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListAccessLevelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAccessLevelsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_access_levels_async_from_dict():
    await test_list_access_levels_async(request_type=dict)


def test_list_access_levels_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListAccessLevelsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        call.return_value = access_context_manager.ListAccessLevelsResponse()
        client.list_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_list_access_levels_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListAccessLevelsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListAccessLevelsResponse())
        await client.list_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_access_levels_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListAccessLevelsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_access_levels(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_access_levels_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_access_levels(
            access_context_manager.ListAccessLevelsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_access_levels_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListAccessLevelsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListAccessLevelsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_access_levels(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_list_access_levels_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_access_levels(
            access_context_manager.ListAccessLevelsRequest(),
            parent='parent_value',
        )


def test_list_access_levels_pager():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', ''),
            )),
        )
        pager = client.list_access_levels(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, access_level.AccessLevel)
                   for i in results)

def test_list_access_levels_pages():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_access_levels(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_access_levels_async_pager():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_access_levels(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, access_level.AccessLevel)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_access_levels_async_pages():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_access_levels),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[],
                next_page_token='def',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListAccessLevelsResponse(
                access_levels=[
                    access_level.AccessLevel(),
                    access_level.AccessLevel(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_access_levels(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_access_level(transport: str = 'grpc', request_type=access_context_manager.GetAccessLevelRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_level.AccessLevel(
            name='name_value',
            title='title_value',
            description='description_value',
            basic=access_level.BasicLevel(conditions=[access_level.Condition(ip_subnetworks=['ip_subnetworks_value'])]),
        )
        response = client.get_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, access_level.AccessLevel)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'


def test_get_access_level_from_dict():
    test_get_access_level(request_type=dict)


def test_get_access_level_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        client.get_access_level()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessLevelRequest()


@pytest.mark.asyncio
async def test_get_access_level_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.GetAccessLevelRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_level.AccessLevel(
            name='name_value',
            title='title_value',
            description='description_value',
        ))
        response = await client.get_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, access_level.AccessLevel)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_get_access_level_async_from_dict():
    await test_get_access_level_async(request_type=dict)


def test_get_access_level_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetAccessLevelRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        call.return_value = access_level.AccessLevel()
        client.get_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_access_level_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetAccessLevelRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_level.AccessLevel())
        await client.get_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_access_level_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_level.AccessLevel()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_access_level(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_access_level_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_access_level(
            access_context_manager.GetAccessLevelRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_access_level_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_level.AccessLevel()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_level.AccessLevel())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_access_level(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_get_access_level_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_access_level(
            access_context_manager.GetAccessLevelRequest(),
            name='name_value',
        )


def test_create_access_level(transport: str = 'grpc', request_type=access_context_manager.CreateAccessLevelRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_access_level_from_dict():
    test_create_access_level(request_type=dict)


def test_create_access_level_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        client.create_access_level()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateAccessLevelRequest()


@pytest.mark.asyncio
async def test_create_access_level_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.CreateAccessLevelRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_access_level_async_from_dict():
    await test_create_access_level_async(request_type=dict)


def test_create_access_level_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateAccessLevelRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_access_level_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateAccessLevelRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_create_access_level_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_access_level(
            parent='parent_value',
            access_level=gia_access_level.AccessLevel(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].access_level
        mock_val = gia_access_level.AccessLevel(name='name_value')
        assert arg == mock_val


def test_create_access_level_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_access_level(
            access_context_manager.CreateAccessLevelRequest(),
            parent='parent_value',
            access_level=gia_access_level.AccessLevel(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_access_level_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_access_level(
            parent='parent_value',
            access_level=gia_access_level.AccessLevel(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].access_level
        mock_val = gia_access_level.AccessLevel(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_access_level_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_access_level(
            access_context_manager.CreateAccessLevelRequest(),
            parent='parent_value',
            access_level=gia_access_level.AccessLevel(name='name_value'),
        )


def test_update_access_level(transport: str = 'grpc', request_type=access_context_manager.UpdateAccessLevelRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_access_level_from_dict():
    test_update_access_level(request_type=dict)


def test_update_access_level_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        client.update_access_level()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessLevelRequest()


@pytest.mark.asyncio
async def test_update_access_level_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.UpdateAccessLevelRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_access_level_async_from_dict():
    await test_update_access_level_async(request_type=dict)


def test_update_access_level_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateAccessLevelRequest()

    request.access_level.name = 'access_level.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'access_level.name=access_level.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_access_level_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateAccessLevelRequest()

    request.access_level.name = 'access_level.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'access_level.name=access_level.name/value',
    ) in kw['metadata']


def test_update_access_level_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_access_level(
            access_level=gia_access_level.AccessLevel(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].access_level
        mock_val = gia_access_level.AccessLevel(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_access_level_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_access_level(
            access_context_manager.UpdateAccessLevelRequest(),
            access_level=gia_access_level.AccessLevel(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_access_level_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_access_level(
            access_level=gia_access_level.AccessLevel(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].access_level
        mock_val = gia_access_level.AccessLevel(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_access_level_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_access_level(
            access_context_manager.UpdateAccessLevelRequest(),
            access_level=gia_access_level.AccessLevel(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_delete_access_level(transport: str = 'grpc', request_type=access_context_manager.DeleteAccessLevelRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_access_level_from_dict():
    test_delete_access_level(request_type=dict)


def test_delete_access_level_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        client.delete_access_level()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessLevelRequest()


@pytest.mark.asyncio
async def test_delete_access_level_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.DeleteAccessLevelRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteAccessLevelRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_access_level_async_from_dict():
    await test_delete_access_level_async(request_type=dict)


def test_delete_access_level_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteAccessLevelRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_access_level_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteAccessLevelRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_access_level(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_access_level_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_access_level(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_access_level_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_access_level(
            access_context_manager.DeleteAccessLevelRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_access_level_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_access_level),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_access_level(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_delete_access_level_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_access_level(
            access_context_manager.DeleteAccessLevelRequest(),
            name='name_value',
        )


def test_replace_access_levels(transport: str = 'grpc', request_type=access_context_manager.ReplaceAccessLevelsRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.replace_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceAccessLevelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_replace_access_levels_from_dict():
    test_replace_access_levels(request_type=dict)


def test_replace_access_levels_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_access_levels),
            '__call__') as call:
        client.replace_access_levels()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceAccessLevelsRequest()


@pytest.mark.asyncio
async def test_replace_access_levels_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ReplaceAccessLevelsRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_access_levels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.replace_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceAccessLevelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_replace_access_levels_async_from_dict():
    await test_replace_access_levels_async(request_type=dict)


def test_replace_access_levels_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ReplaceAccessLevelsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_access_levels),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.replace_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_replace_access_levels_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ReplaceAccessLevelsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_access_levels),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.replace_access_levels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_service_perimeters(transport: str = 'grpc', request_type=access_context_manager.ListServicePerimetersRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListServicePerimetersResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServicePerimetersPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_service_perimeters_from_dict():
    test_list_service_perimeters(request_type=dict)


def test_list_service_perimeters_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        client.list_service_perimeters()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListServicePerimetersRequest()


@pytest.mark.asyncio
async def test_list_service_perimeters_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ListServicePerimetersRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListServicePerimetersResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServicePerimetersAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_service_perimeters_async_from_dict():
    await test_list_service_perimeters_async(request_type=dict)


def test_list_service_perimeters_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        call.return_value = access_context_manager.ListServicePerimetersResponse()
        client.list_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_list_service_perimeters_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListServicePerimetersResponse())
        await client.list_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_service_perimeters_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListServicePerimetersResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_service_perimeters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_service_perimeters_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_service_perimeters(
            access_context_manager.ListServicePerimetersRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_service_perimeters_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListServicePerimetersResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListServicePerimetersResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_service_perimeters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_list_service_perimeters_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_service_perimeters(
            access_context_manager.ListServicePerimetersRequest(),
            parent='parent_value',
        )


def test_list_service_perimeters_pager():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[],
                next_page_token='def',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', ''),
            )),
        )
        pager = client.list_service_perimeters(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, service_perimeter.ServicePerimeter)
                   for i in results)

def test_list_service_perimeters_pages():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[],
                next_page_token='def',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_service_perimeters(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_service_perimeters_async_pager():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[],
                next_page_token='def',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_service_perimeters(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, service_perimeter.ServicePerimeter)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_service_perimeters_async_pages():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_perimeters),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[],
                next_page_token='def',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListServicePerimetersResponse(
                service_perimeters=[
                    service_perimeter.ServicePerimeter(),
                    service_perimeter.ServicePerimeter(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_service_perimeters(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_service_perimeter(transport: str = 'grpc', request_type=access_context_manager.GetServicePerimeterRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = service_perimeter.ServicePerimeter(
            name='name_value',
            title='title_value',
            description='description_value',
            perimeter_type=service_perimeter.ServicePerimeter.PerimeterType.PERIMETER_TYPE_BRIDGE,
            use_explicit_dry_run_spec=True,
        )
        response = client.get_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, service_perimeter.ServicePerimeter)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.perimeter_type == service_perimeter.ServicePerimeter.PerimeterType.PERIMETER_TYPE_BRIDGE
    assert response.use_explicit_dry_run_spec is True


def test_get_service_perimeter_from_dict():
    test_get_service_perimeter(request_type=dict)


def test_get_service_perimeter_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        client.get_service_perimeter()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetServicePerimeterRequest()


@pytest.mark.asyncio
async def test_get_service_perimeter_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.GetServicePerimeterRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(service_perimeter.ServicePerimeter(
            name='name_value',
            title='title_value',
            description='description_value',
            perimeter_type=service_perimeter.ServicePerimeter.PerimeterType.PERIMETER_TYPE_BRIDGE,
            use_explicit_dry_run_spec=True,
        ))
        response = await client.get_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, service_perimeter.ServicePerimeter)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.perimeter_type == service_perimeter.ServicePerimeter.PerimeterType.PERIMETER_TYPE_BRIDGE
    assert response.use_explicit_dry_run_spec is True


@pytest.mark.asyncio
async def test_get_service_perimeter_async_from_dict():
    await test_get_service_perimeter_async(request_type=dict)


def test_get_service_perimeter_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetServicePerimeterRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        call.return_value = service_perimeter.ServicePerimeter()
        client.get_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_service_perimeter_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetServicePerimeterRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(service_perimeter.ServicePerimeter())
        await client.get_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_service_perimeter_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = service_perimeter.ServicePerimeter()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_service_perimeter(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_service_perimeter_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_service_perimeter(
            access_context_manager.GetServicePerimeterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_service_perimeter_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = service_perimeter.ServicePerimeter()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(service_perimeter.ServicePerimeter())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_service_perimeter(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_get_service_perimeter_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_service_perimeter(
            access_context_manager.GetServicePerimeterRequest(),
            name='name_value',
        )


def test_create_service_perimeter(transport: str = 'grpc', request_type=access_context_manager.CreateServicePerimeterRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_service_perimeter_from_dict():
    test_create_service_perimeter(request_type=dict)


def test_create_service_perimeter_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        client.create_service_perimeter()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateServicePerimeterRequest()


@pytest.mark.asyncio
async def test_create_service_perimeter_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.CreateServicePerimeterRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_service_perimeter_async_from_dict():
    await test_create_service_perimeter_async(request_type=dict)


def test_create_service_perimeter_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateServicePerimeterRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_service_perimeter_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateServicePerimeterRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_create_service_perimeter_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_service_perimeter(
            parent='parent_value',
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].service_perimeter
        mock_val = gia_service_perimeter.ServicePerimeter(name='name_value')
        assert arg == mock_val


def test_create_service_perimeter_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_service_perimeter(
            access_context_manager.CreateServicePerimeterRequest(),
            parent='parent_value',
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_service_perimeter_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_service_perimeter(
            parent='parent_value',
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].service_perimeter
        mock_val = gia_service_perimeter.ServicePerimeter(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_service_perimeter_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_service_perimeter(
            access_context_manager.CreateServicePerimeterRequest(),
            parent='parent_value',
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
        )


def test_update_service_perimeter(transport: str = 'grpc', request_type=access_context_manager.UpdateServicePerimeterRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_service_perimeter_from_dict():
    test_update_service_perimeter(request_type=dict)


def test_update_service_perimeter_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        client.update_service_perimeter()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateServicePerimeterRequest()


@pytest.mark.asyncio
async def test_update_service_perimeter_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.UpdateServicePerimeterRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_service_perimeter_async_from_dict():
    await test_update_service_perimeter_async(request_type=dict)


def test_update_service_perimeter_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateServicePerimeterRequest()

    request.service_perimeter.name = 'service_perimeter.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'service_perimeter.name=service_perimeter.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_service_perimeter_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateServicePerimeterRequest()

    request.service_perimeter.name = 'service_perimeter.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'service_perimeter.name=service_perimeter.name/value',
    ) in kw['metadata']


def test_update_service_perimeter_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_service_perimeter(
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].service_perimeter
        mock_val = gia_service_perimeter.ServicePerimeter(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_service_perimeter_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_service_perimeter(
            access_context_manager.UpdateServicePerimeterRequest(),
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_service_perimeter_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_service_perimeter(
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].service_perimeter
        mock_val = gia_service_perimeter.ServicePerimeter(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_service_perimeter_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_service_perimeter(
            access_context_manager.UpdateServicePerimeterRequest(),
            service_perimeter=gia_service_perimeter.ServicePerimeter(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_delete_service_perimeter(transport: str = 'grpc', request_type=access_context_manager.DeleteServicePerimeterRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_service_perimeter_from_dict():
    test_delete_service_perimeter(request_type=dict)


def test_delete_service_perimeter_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        client.delete_service_perimeter()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteServicePerimeterRequest()


@pytest.mark.asyncio
async def test_delete_service_perimeter_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.DeleteServicePerimeterRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteServicePerimeterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_service_perimeter_async_from_dict():
    await test_delete_service_perimeter_async(request_type=dict)


def test_delete_service_perimeter_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteServicePerimeterRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_service_perimeter_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteServicePerimeterRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_service_perimeter(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_service_perimeter_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_service_perimeter(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_service_perimeter_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_service_perimeter(
            access_context_manager.DeleteServicePerimeterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_service_perimeter_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_perimeter),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_service_perimeter(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_delete_service_perimeter_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_service_perimeter(
            access_context_manager.DeleteServicePerimeterRequest(),
            name='name_value',
        )


def test_replace_service_perimeters(transport: str = 'grpc', request_type=access_context_manager.ReplaceServicePerimetersRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.replace_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_replace_service_perimeters_from_dict():
    test_replace_service_perimeters(request_type=dict)


def test_replace_service_perimeters_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_service_perimeters),
            '__call__') as call:
        client.replace_service_perimeters()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceServicePerimetersRequest()


@pytest.mark.asyncio
async def test_replace_service_perimeters_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ReplaceServicePerimetersRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.replace_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ReplaceServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_replace_service_perimeters_async_from_dict():
    await test_replace_service_perimeters_async(request_type=dict)


def test_replace_service_perimeters_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ReplaceServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_service_perimeters),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.replace_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_replace_service_perimeters_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ReplaceServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.replace_service_perimeters),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.replace_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_commit_service_perimeters(transport: str = 'grpc', request_type=access_context_manager.CommitServicePerimetersRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.commit_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.commit_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CommitServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_commit_service_perimeters_from_dict():
    test_commit_service_perimeters(request_type=dict)


def test_commit_service_perimeters_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.commit_service_perimeters),
            '__call__') as call:
        client.commit_service_perimeters()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CommitServicePerimetersRequest()


@pytest.mark.asyncio
async def test_commit_service_perimeters_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.CommitServicePerimetersRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.commit_service_perimeters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.commit_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CommitServicePerimetersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_commit_service_perimeters_async_from_dict():
    await test_commit_service_perimeters_async(request_type=dict)


def test_commit_service_perimeters_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CommitServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.commit_service_perimeters),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.commit_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_commit_service_perimeters_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CommitServicePerimetersRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.commit_service_perimeters),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.commit_service_perimeters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_gcp_user_access_bindings(transport: str = 'grpc', request_type=access_context_manager.ListGcpUserAccessBindingsRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListGcpUserAccessBindingsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_gcp_user_access_bindings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListGcpUserAccessBindingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListGcpUserAccessBindingsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_gcp_user_access_bindings_from_dict():
    test_list_gcp_user_access_bindings(request_type=dict)


def test_list_gcp_user_access_bindings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        client.list_gcp_user_access_bindings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListGcpUserAccessBindingsRequest()


@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.ListGcpUserAccessBindingsRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListGcpUserAccessBindingsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_gcp_user_access_bindings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.ListGcpUserAccessBindingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListGcpUserAccessBindingsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_async_from_dict():
    await test_list_gcp_user_access_bindings_async(request_type=dict)


def test_list_gcp_user_access_bindings_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListGcpUserAccessBindingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        call.return_value = access_context_manager.ListGcpUserAccessBindingsResponse()
        client.list_gcp_user_access_bindings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.ListGcpUserAccessBindingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListGcpUserAccessBindingsResponse())
        await client.list_gcp_user_access_bindings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_gcp_user_access_bindings_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListGcpUserAccessBindingsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_gcp_user_access_bindings(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_gcp_user_access_bindings_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_gcp_user_access_bindings(
            access_context_manager.ListGcpUserAccessBindingsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = access_context_manager.ListGcpUserAccessBindingsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(access_context_manager.ListGcpUserAccessBindingsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_gcp_user_access_bindings(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_gcp_user_access_bindings(
            access_context_manager.ListGcpUserAccessBindingsRequest(),
            parent='parent_value',
        )


def test_list_gcp_user_access_bindings_pager():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[],
                next_page_token='def',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', ''),
            )),
        )
        pager = client.list_gcp_user_access_bindings(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, gcp_user_access_binding.GcpUserAccessBinding)
                   for i in results)

def test_list_gcp_user_access_bindings_pages():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[],
                next_page_token='def',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_gcp_user_access_bindings(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_async_pager():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[],
                next_page_token='def',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_gcp_user_access_bindings(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, gcp_user_access_binding.GcpUserAccessBinding)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_gcp_user_access_bindings_async_pages():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_gcp_user_access_bindings),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='abc',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[],
                next_page_token='def',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
                next_page_token='ghi',
            ),
            access_context_manager.ListGcpUserAccessBindingsResponse(
                gcp_user_access_bindings=[
                    gcp_user_access_binding.GcpUserAccessBinding(),
                    gcp_user_access_binding.GcpUserAccessBinding(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_gcp_user_access_bindings(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_gcp_user_access_binding(transport: str = 'grpc', request_type=access_context_manager.GetGcpUserAccessBindingRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcp_user_access_binding.GcpUserAccessBinding(
            name='name_value',
            group_key='group_key_value',
            access_levels=['access_levels_value'],
        )
        response = client.get_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcp_user_access_binding.GcpUserAccessBinding)
    assert response.name == 'name_value'
    assert response.group_key == 'group_key_value'
    assert response.access_levels == ['access_levels_value']


def test_get_gcp_user_access_binding_from_dict():
    test_get_gcp_user_access_binding(request_type=dict)


def test_get_gcp_user_access_binding_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        client.get_gcp_user_access_binding()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetGcpUserAccessBindingRequest()


@pytest.mark.asyncio
async def test_get_gcp_user_access_binding_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.GetGcpUserAccessBindingRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(gcp_user_access_binding.GcpUserAccessBinding(
            name='name_value',
            group_key='group_key_value',
            access_levels=['access_levels_value'],
        ))
        response = await client.get_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.GetGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcp_user_access_binding.GcpUserAccessBinding)
    assert response.name == 'name_value'
    assert response.group_key == 'group_key_value'
    assert response.access_levels == ['access_levels_value']


@pytest.mark.asyncio
async def test_get_gcp_user_access_binding_async_from_dict():
    await test_get_gcp_user_access_binding_async(request_type=dict)


def test_get_gcp_user_access_binding_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetGcpUserAccessBindingRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = gcp_user_access_binding.GcpUserAccessBinding()
        client.get_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_gcp_user_access_binding_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.GetGcpUserAccessBindingRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcp_user_access_binding.GcpUserAccessBinding())
        await client.get_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_gcp_user_access_binding_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcp_user_access_binding.GcpUserAccessBinding()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_gcp_user_access_binding(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_gcp_user_access_binding_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_gcp_user_access_binding(
            access_context_manager.GetGcpUserAccessBindingRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_gcp_user_access_binding_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcp_user_access_binding.GcpUserAccessBinding()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcp_user_access_binding.GcpUserAccessBinding())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_gcp_user_access_binding(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_get_gcp_user_access_binding_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_gcp_user_access_binding(
            access_context_manager.GetGcpUserAccessBindingRequest(),
            name='name_value',
        )


def test_create_gcp_user_access_binding(transport: str = 'grpc', request_type=access_context_manager.CreateGcpUserAccessBindingRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_gcp_user_access_binding_from_dict():
    test_create_gcp_user_access_binding(request_type=dict)


def test_create_gcp_user_access_binding_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        client.create_gcp_user_access_binding()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateGcpUserAccessBindingRequest()


@pytest.mark.asyncio
async def test_create_gcp_user_access_binding_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.CreateGcpUserAccessBindingRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.CreateGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_gcp_user_access_binding_async_from_dict():
    await test_create_gcp_user_access_binding_async(request_type=dict)


def test_create_gcp_user_access_binding_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateGcpUserAccessBindingRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_gcp_user_access_binding_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.CreateGcpUserAccessBindingRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_create_gcp_user_access_binding_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_gcp_user_access_binding(
            parent='parent_value',
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].gcp_user_access_binding
        mock_val = gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value')
        assert arg == mock_val


def test_create_gcp_user_access_binding_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_gcp_user_access_binding(
            access_context_manager.CreateGcpUserAccessBindingRequest(),
            parent='parent_value',
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_gcp_user_access_binding_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_gcp_user_access_binding(
            parent='parent_value',
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].gcp_user_access_binding
        mock_val = gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_gcp_user_access_binding_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_gcp_user_access_binding(
            access_context_manager.CreateGcpUserAccessBindingRequest(),
            parent='parent_value',
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
        )


def test_update_gcp_user_access_binding(transport: str = 'grpc', request_type=access_context_manager.UpdateGcpUserAccessBindingRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_gcp_user_access_binding_from_dict():
    test_update_gcp_user_access_binding(request_type=dict)


def test_update_gcp_user_access_binding_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        client.update_gcp_user_access_binding()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateGcpUserAccessBindingRequest()


@pytest.mark.asyncio
async def test_update_gcp_user_access_binding_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.UpdateGcpUserAccessBindingRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.UpdateGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_gcp_user_access_binding_async_from_dict():
    await test_update_gcp_user_access_binding_async(request_type=dict)


def test_update_gcp_user_access_binding_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateGcpUserAccessBindingRequest()

    request.gcp_user_access_binding.name = 'gcp_user_access_binding.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'gcp_user_access_binding.name=gcp_user_access_binding.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_gcp_user_access_binding_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.UpdateGcpUserAccessBindingRequest()

    request.gcp_user_access_binding.name = 'gcp_user_access_binding.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'gcp_user_access_binding.name=gcp_user_access_binding.name/value',
    ) in kw['metadata']


def test_update_gcp_user_access_binding_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_gcp_user_access_binding(
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].gcp_user_access_binding
        mock_val = gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_gcp_user_access_binding_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_gcp_user_access_binding(
            access_context_manager.UpdateGcpUserAccessBindingRequest(),
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_gcp_user_access_binding_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_gcp_user_access_binding(
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].gcp_user_access_binding
        mock_val = gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_gcp_user_access_binding_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_gcp_user_access_binding(
            access_context_manager.UpdateGcpUserAccessBindingRequest(),
            gcp_user_access_binding=gia_gcp_user_access_binding.GcpUserAccessBinding(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_delete_gcp_user_access_binding(transport: str = 'grpc', request_type=access_context_manager.DeleteGcpUserAccessBindingRequest):
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_gcp_user_access_binding_from_dict():
    test_delete_gcp_user_access_binding(request_type=dict)


def test_delete_gcp_user_access_binding_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        client.delete_gcp_user_access_binding()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteGcpUserAccessBindingRequest()


@pytest.mark.asyncio
async def test_delete_gcp_user_access_binding_async(transport: str = 'grpc_asyncio', request_type=access_context_manager.DeleteGcpUserAccessBindingRequest):
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == access_context_manager.DeleteGcpUserAccessBindingRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_gcp_user_access_binding_async_from_dict():
    await test_delete_gcp_user_access_binding_async(request_type=dict)


def test_delete_gcp_user_access_binding_field_headers():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteGcpUserAccessBindingRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_gcp_user_access_binding_field_headers_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = access_context_manager.DeleteGcpUserAccessBindingRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_gcp_user_access_binding(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_gcp_user_access_binding_flattened():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_gcp_user_access_binding(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_gcp_user_access_binding_flattened_error():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_gcp_user_access_binding(
            access_context_manager.DeleteGcpUserAccessBindingRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_gcp_user_access_binding_flattened_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_gcp_user_access_binding),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_gcp_user_access_binding(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_delete_gcp_user_access_binding_flattened_error_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_gcp_user_access_binding(
            access_context_manager.DeleteGcpUserAccessBindingRequest(),
            name='name_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.AccessContextManagerGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AccessContextManagerClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.AccessContextManagerGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AccessContextManagerClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.AccessContextManagerGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AccessContextManagerClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AccessContextManagerGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = AccessContextManagerClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AccessContextManagerGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.AccessContextManagerGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.AccessContextManagerGrpcTransport,
    transports.AccessContextManagerGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.AccessContextManagerGrpcTransport,
    )

def test_access_context_manager_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.AccessContextManagerTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_access_context_manager_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.identity.accesscontextmanager_v1.services.access_context_manager.transports.AccessContextManagerTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.AccessContextManagerTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'list_access_policies',
        'get_access_policy',
        'create_access_policy',
        'update_access_policy',
        'delete_access_policy',
        'list_access_levels',
        'get_access_level',
        'create_access_level',
        'update_access_level',
        'delete_access_level',
        'replace_access_levels',
        'list_service_perimeters',
        'get_service_perimeter',
        'create_service_perimeter',
        'update_service_perimeter',
        'delete_service_perimeter',
        'replace_service_perimeters',
        'commit_service_perimeters',
        'list_gcp_user_access_bindings',
        'get_gcp_user_access_binding',
        'create_gcp_user_access_binding',
        'update_gcp_user_access_binding',
        'delete_gcp_user_access_binding',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_access_context_manager_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.identity.accesscontextmanager_v1.services.access_context_manager.transports.AccessContextManagerTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.AccessContextManagerTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id="octopus",
        )


def test_access_context_manager_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.identity.accesscontextmanager_v1.services.access_context_manager.transports.AccessContextManagerTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.AccessContextManagerTransport()
        adc.assert_called_once()


def test_access_context_manager_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        AccessContextManagerClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.AccessContextManagerGrpcTransport,
        transports.AccessContextManagerGrpcAsyncIOTransport,
    ],
)
def test_access_context_manager_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.AccessContextManagerGrpcTransport, grpc_helpers),
        (transports.AccessContextManagerGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_access_context_manager_transport_create_channel(transport_class, grpc_helpers):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc, mock.patch.object(
        grpc_helpers, "create_channel", autospec=True
    ) as create_channel:
        creds = ga_credentials.AnonymousCredentials()
        adc.return_value = (creds, None)
        transport_class(
            quota_project_id="octopus",
            scopes=["1", "2"]
        )

        create_channel.assert_called_with(
            "accesscontextmanager.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="accesscontextmanager.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.AccessContextManagerGrpcTransport, transports.AccessContextManagerGrpcAsyncIOTransport])
def test_access_context_manager_grpc_transport_client_cert_source_for_mtls(
    transport_class
):
    cred = ga_credentials.AnonymousCredentials()

    # Check ssl_channel_credentials is used if provided.
    with mock.patch.object(transport_class, "create_channel") as mock_create_channel:
        mock_ssl_channel_creds = mock.Mock()
        transport_class(
            host="squid.clam.whelk",
            credentials=cred,
            ssl_channel_credentials=mock_ssl_channel_creds
        )
        mock_create_channel.assert_called_once_with(
            "squid.clam.whelk:443",
            credentials=cred,
            credentials_file=None,
            scopes=None,
            ssl_credentials=mock_ssl_channel_creds,
            quota_project_id=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )

    # Check if ssl_channel_credentials is not provided, then client_cert_source_for_mtls
    # is used.
    with mock.patch.object(transport_class, "create_channel", return_value=mock.Mock()):
        with mock.patch("grpc.ssl_channel_credentials") as mock_ssl_cred:
            transport_class(
                credentials=cred,
                client_cert_source_for_mtls=client_cert_source_callback
            )
            expected_cert, expected_key = client_cert_source_callback()
            mock_ssl_cred.assert_called_once_with(
                certificate_chain=expected_cert,
                private_key=expected_key
            )


def test_access_context_manager_host_no_port():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='accesscontextmanager.googleapis.com'),
    )
    assert client.transport._host == 'accesscontextmanager.googleapis.com:443'


def test_access_context_manager_host_with_port():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='accesscontextmanager.googleapis.com:8000'),
    )
    assert client.transport._host == 'accesscontextmanager.googleapis.com:8000'

def test_access_context_manager_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AccessContextManagerGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_access_context_manager_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AccessContextManagerGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.AccessContextManagerGrpcTransport, transports.AccessContextManagerGrpcAsyncIOTransport])
def test_access_context_manager_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_ssl_cred = mock.Mock()
            grpc_ssl_channel_cred.return_value = mock_ssl_cred

            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel

            cred = ga_credentials.AnonymousCredentials()
            with pytest.warns(DeprecationWarning):
                with mock.patch.object(google.auth, 'default') as adc:
                    adc.return_value = (cred, None)
                    transport = transport_class(
                        host="squid.clam.whelk",
                        api_mtls_endpoint="mtls.squid.clam.whelk",
                        client_cert_source=client_cert_source_callback,
                    )
                    adc.assert_called_once()

            grpc_ssl_channel_cred.assert_called_once_with(
                certificate_chain=b"cert bytes", private_key=b"key bytes"
            )
            grpc_create_channel.assert_called_once_with(
                "mtls.squid.clam.whelk:443",
                credentials=cred,
                credentials_file=None,
                scopes=None,
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel
            assert transport._ssl_channel_credentials == mock_ssl_cred


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.AccessContextManagerGrpcTransport, transports.AccessContextManagerGrpcAsyncIOTransport])
def test_access_context_manager_transport_channel_mtls_with_adc(
    transport_class
):
    mock_ssl_cred = mock.Mock()
    with mock.patch.multiple(
        "google.auth.transport.grpc.SslCredentials",
        __init__=mock.Mock(return_value=None),
        ssl_credentials=mock.PropertyMock(return_value=mock_ssl_cred),
    ):
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel
            mock_cred = mock.Mock()

            with pytest.warns(DeprecationWarning):
                transport = transport_class(
                    host="squid.clam.whelk",
                    credentials=mock_cred,
                    api_mtls_endpoint="mtls.squid.clam.whelk",
                    client_cert_source=None,
                )

            grpc_create_channel.assert_called_once_with(
                "mtls.squid.clam.whelk:443",
                credentials=mock_cred,
                credentials_file=None,
                scopes=None,
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_access_context_manager_grpc_lro_client():
    client = AccessContextManagerClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )
    transport = client.transport

    # Ensure that we have a api-core operations client.
    assert isinstance(
        transport.operations_client,
        operations_v1.OperationsClient,
    )

    # Ensure that subsequent calls to the property send the exact same object.
    assert transport.operations_client is transport.operations_client


def test_access_context_manager_grpc_lro_async_client():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc_asyncio',
    )
    transport = client.transport

    # Ensure that we have a api-core operations client.
    assert isinstance(
        transport.operations_client,
        operations_v1.OperationsAsyncClient,
    )

    # Ensure that subsequent calls to the property send the exact same object.
    assert transport.operations_client is transport.operations_client


def test_access_level_path():
    access_policy = "squid"
    access_level = "clam"
    expected = "accessPolicies/{access_policy}/accessLevels/{access_level}".format(access_policy=access_policy, access_level=access_level, )
    actual = AccessContextManagerClient.access_level_path(access_policy, access_level)
    assert expected == actual


def test_parse_access_level_path():
    expected = {
        "access_policy": "whelk",
        "access_level": "octopus",
    }
    path = AccessContextManagerClient.access_level_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_access_level_path(path)
    assert expected == actual

def test_access_policy_path():
    access_policy = "oyster"
    expected = "accessPolicies/{access_policy}".format(access_policy=access_policy, )
    actual = AccessContextManagerClient.access_policy_path(access_policy)
    assert expected == actual


def test_parse_access_policy_path():
    expected = {
        "access_policy": "nudibranch",
    }
    path = AccessContextManagerClient.access_policy_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_access_policy_path(path)
    assert expected == actual

def test_gcp_user_access_binding_path():
    organization = "cuttlefish"
    gcp_user_access_binding = "mussel"
    expected = "organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}".format(organization=organization, gcp_user_access_binding=gcp_user_access_binding, )
    actual = AccessContextManagerClient.gcp_user_access_binding_path(organization, gcp_user_access_binding)
    assert expected == actual


def test_parse_gcp_user_access_binding_path():
    expected = {
        "organization": "winkle",
        "gcp_user_access_binding": "nautilus",
    }
    path = AccessContextManagerClient.gcp_user_access_binding_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_gcp_user_access_binding_path(path)
    assert expected == actual

def test_service_perimeter_path():
    access_policy = "scallop"
    service_perimeter = "abalone"
    expected = "accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}".format(access_policy=access_policy, service_perimeter=service_perimeter, )
    actual = AccessContextManagerClient.service_perimeter_path(access_policy, service_perimeter)
    assert expected == actual


def test_parse_service_perimeter_path():
    expected = {
        "access_policy": "squid",
        "service_perimeter": "clam",
    }
    path = AccessContextManagerClient.service_perimeter_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_service_perimeter_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = AccessContextManagerClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "octopus",
    }
    path = AccessContextManagerClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"
    expected = "folders/{folder}".format(folder=folder, )
    actual = AccessContextManagerClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nudibranch",
    }
    path = AccessContextManagerClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = AccessContextManagerClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "mussel",
    }
    path = AccessContextManagerClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"
    expected = "projects/{project}".format(project=project, )
    actual = AccessContextManagerClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nautilus",
    }
    path = AccessContextManagerClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = AccessContextManagerClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "squid",
        "location": "clam",
    }
    path = AccessContextManagerClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = AccessContextManagerClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.AccessContextManagerTransport, '_prep_wrapped_messages') as prep:
        client = AccessContextManagerClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.AccessContextManagerTransport, '_prep_wrapped_messages') as prep:
        transport_class = AccessContextManagerClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = AccessContextManagerAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport="grpc_asyncio",
    )
    with mock.patch.object(type(getattr(client.transport, "grpc_channel")), "close") as close:
        async with client:
            close.assert_not_called()
        close.assert_called_once()

def test_transport_close():
    transports = {
        "grpc": "_grpc_channel",
    }

    for transport, close_name in transports.items():
        client = AccessContextManagerClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        with mock.patch.object(type(getattr(client.transport, close_name)), "close") as close:
            with client:
                close.assert_not_called()
            close.assert_called_once()

def test_client_ctx():
    transports = [
        'grpc',
    ]
    for transport in transports:
        client = AccessContextManagerClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
