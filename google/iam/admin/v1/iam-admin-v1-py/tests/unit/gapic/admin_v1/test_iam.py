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
import packaging.version

import grpc
from grpc.experimental import aio
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule


from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.iam.admin_v1.services.iam import IAMAsyncClient
from google.iam.admin_v1.services.iam import IAMClient
from google.iam.admin_v1.services.iam import pagers
from google.iam.admin_v1.services.iam import transports
from google.iam.admin_v1.services.iam.transports.base import _GOOGLE_AUTH_VERSION
from google.iam.admin_v1.types import iam
from google.iam.v1 import iam_policy_pb2  # type: ignore
from google.iam.v1 import options_pb2  # type: ignore
from google.iam.v1 import policy_pb2  # type: ignore
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.type import expr_pb2  # type: ignore
import google.auth


# TODO(busunkim): Once google-auth >= 1.25.0 is required transitively
# through google-api-core:
# - Delete the auth "less than" test cases
# - Delete these pytest markers (Make the "greater than or equal to" tests the default).
requires_google_auth_lt_1_25_0 = pytest.mark.skipif(
    packaging.version.parse(_GOOGLE_AUTH_VERSION) >= packaging.version.parse("1.25.0"),
    reason="This test requires google-auth < 1.25.0",
)
requires_google_auth_gte_1_25_0 = pytest.mark.skipif(
    packaging.version.parse(_GOOGLE_AUTH_VERSION) < packaging.version.parse("1.25.0"),
    reason="This test requires google-auth >= 1.25.0",
)

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

    assert IAMClient._get_default_mtls_endpoint(None) is None
    assert IAMClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert IAMClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert IAMClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert IAMClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert IAMClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    IAMClient,
    IAMAsyncClient,
])
def test_iam_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'iam.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.IAMGrpcTransport, "grpc"),
    (transports.IAMGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_iam_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    IAMClient,
    IAMAsyncClient,
])
def test_iam_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'iam.googleapis.com:443'


def test_iam_client_get_transport_class():
    transport = IAMClient.get_transport_class()
    available_transports = [
        transports.IAMGrpcTransport,
    ]
    assert transport in available_transports

    transport = IAMClient.get_transport_class("grpc")
    assert transport == transports.IAMGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (IAMClient, transports.IAMGrpcTransport, "grpc"),
    (IAMAsyncClient, transports.IAMGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(IAMClient, "DEFAULT_ENDPOINT", modify_default_endpoint(IAMClient))
@mock.patch.object(IAMAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(IAMAsyncClient))
def test_iam_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(IAMClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(IAMClient, 'get_transport_class') as gtc:
        client = client_class(transport=transport_name)
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
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
            client = client_class()
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
            client = client_class()
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
        client = client_class(client_options=options)
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
    (IAMClient, transports.IAMGrpcTransport, "grpc", "true"),
    (IAMAsyncClient, transports.IAMGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (IAMClient, transports.IAMGrpcTransport, "grpc", "false"),
    (IAMAsyncClient, transports.IAMGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(IAMClient, "DEFAULT_ENDPOINT", modify_default_endpoint(IAMClient))
@mock.patch.object(IAMAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(IAMAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_iam_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(client_options=options)

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
                    client = client_class()
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
                client = client_class()
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
    (IAMClient, transports.IAMGrpcTransport, "grpc"),
    (IAMAsyncClient, transports.IAMGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_iam_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
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
    (IAMClient, transports.IAMGrpcTransport, "grpc"),
    (IAMAsyncClient, transports.IAMGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_iam_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
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


def test_iam_client_client_options_from_dict():
    with mock.patch('google.iam.admin_v1.services.iam.transports.IAMGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = IAMClient(
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


def test_list_service_accounts(transport: str = 'grpc', request_type=iam.ListServiceAccountsRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_service_accounts(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServiceAccountsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_service_accounts_from_dict():
    test_list_service_accounts(request_type=dict)


def test_list_service_accounts_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        client.list_service_accounts()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountsRequest()


@pytest.mark.asyncio
async def test_list_service_accounts_async(transport: str = 'grpc_asyncio', request_type=iam.ListServiceAccountsRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_service_accounts(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServiceAccountsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_service_accounts_async_from_dict():
    await test_list_service_accounts_async(request_type=dict)


def test_list_service_accounts_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ListServiceAccountsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        call.return_value = iam.ListServiceAccountsResponse()
        client.list_service_accounts(request)

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
async def test_list_service_accounts_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ListServiceAccountsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountsResponse())
        await client.list_service_accounts(request)

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


def test_list_service_accounts_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_service_accounts(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_list_service_accounts_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_service_accounts(
            iam.ListServiceAccountsRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_list_service_accounts_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_service_accounts(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_list_service_accounts_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_service_accounts(
            iam.ListServiceAccountsRequest(),
            name='name_value',
        )


def test_list_service_accounts_pager():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
                next_page_token='abc',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[],
                next_page_token='def',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                ],
                next_page_token='ghi',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', ''),
            )),
        )
        pager = client.list_service_accounts(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, iam.ServiceAccount)
                   for i in results)

def test_list_service_accounts_pages():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
                next_page_token='abc',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[],
                next_page_token='def',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                ],
                next_page_token='ghi',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_service_accounts(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_service_accounts_async_pager():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
                next_page_token='abc',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[],
                next_page_token='def',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                ],
                next_page_token='ghi',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_service_accounts(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, iam.ServiceAccount)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_service_accounts_async_pages():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_accounts),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
                next_page_token='abc',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[],
                next_page_token='def',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                ],
                next_page_token='ghi',
            ),
            iam.ListServiceAccountsResponse(
                accounts=[
                    iam.ServiceAccount(),
                    iam.ServiceAccount(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_service_accounts(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_service_account(transport: str = 'grpc', request_type=iam.GetServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        )
        response = client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


def test_get_service_account_from_dict():
    test_get_service_account(request_type=dict)


def test_get_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        client.get_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountRequest()


@pytest.mark.asyncio
async def test_get_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.GetServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        ))
        response = await client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


@pytest.mark.asyncio
async def test_get_service_account_async_from_dict():
    await test_get_service_account_async(request_type=dict)


def test_get_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        call.return_value = iam.ServiceAccount()
        client.get_service_account(request)

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
async def test_get_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        await client.get_service_account(request)

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


def test_get_service_account_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_service_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_get_service_account_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_service_account(
            iam.GetServiceAccountRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_service_account_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_service_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_service_account_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_service_account(
            iam.GetServiceAccountRequest(),
            name='name_value',
        )


def test_create_service_account(transport: str = 'grpc', request_type=iam.CreateServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        )
        response = client.create_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


def test_create_service_account_from_dict():
    test_create_service_account(request_type=dict)


def test_create_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        client.create_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountRequest()


@pytest.mark.asyncio
async def test_create_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.CreateServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        ))
        response = await client.create_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


@pytest.mark.asyncio
async def test_create_service_account_async_from_dict():
    await test_create_service_account_async(request_type=dict)


def test_create_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        call.return_value = iam.ServiceAccount()
        client.create_service_account(request)

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
async def test_create_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        await client.create_service_account(request)

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


def test_create_service_account_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_service_account(
            name='name_value',
            account_id='account_id_value',
            service_account=iam.ServiceAccount(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].account_id == 'account_id_value'
        assert args[0].service_account == iam.ServiceAccount(name='name_value')


def test_create_service_account_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_service_account(
            iam.CreateServiceAccountRequest(),
            name='name_value',
            account_id='account_id_value',
            service_account=iam.ServiceAccount(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_service_account_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_service_account(
            name='name_value',
            account_id='account_id_value',
            service_account=iam.ServiceAccount(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].account_id == 'account_id_value'
        assert args[0].service_account == iam.ServiceAccount(name='name_value')


@pytest.mark.asyncio
async def test_create_service_account_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_service_account(
            iam.CreateServiceAccountRequest(),
            name='name_value',
            account_id='account_id_value',
            service_account=iam.ServiceAccount(name='name_value'),
        )


def test_update_service_account(transport: str = 'grpc', request_type=iam.ServiceAccount):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        )
        response = client.update_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ServiceAccount()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


def test_update_service_account_from_dict():
    test_update_service_account(request_type=dict)


def test_update_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_account),
            '__call__') as call:
        client.update_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ServiceAccount()


@pytest.mark.asyncio
async def test_update_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.ServiceAccount):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        ))
        response = await client.update_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ServiceAccount()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


@pytest.mark.asyncio
async def test_update_service_account_async_from_dict():
    await test_update_service_account_async(request_type=dict)


def test_update_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ServiceAccount()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_account),
            '__call__') as call:
        call.return_value = iam.ServiceAccount()
        client.update_service_account(request)

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
async def test_update_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ServiceAccount()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        await client.update_service_account(request)

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


def test_patch_service_account(transport: str = 'grpc', request_type=iam.PatchServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        )
        response = client.patch_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.PatchServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


def test_patch_service_account_from_dict():
    test_patch_service_account(request_type=dict)


def test_patch_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_service_account),
            '__call__') as call:
        client.patch_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.PatchServiceAccountRequest()


@pytest.mark.asyncio
async def test_patch_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.PatchServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount(
            name='name_value',
            project_id='project_id_value',
            unique_id='unique_id_value',
            email='email_value',
            display_name='display_name_value',
            etag=b'etag_blob',
            description='description_value',
            oauth2_client_id='oauth2_client_id_value',
            disabled=True,
        ))
        response = await client.patch_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.PatchServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccount)
    assert response.name == 'name_value'
    assert response.project_id == 'project_id_value'
    assert response.unique_id == 'unique_id_value'
    assert response.email == 'email_value'
    assert response.display_name == 'display_name_value'
    assert response.etag == b'etag_blob'
    assert response.description == 'description_value'
    assert response.oauth2_client_id == 'oauth2_client_id_value'
    assert response.disabled is True


@pytest.mark.asyncio
async def test_patch_service_account_async_from_dict():
    await test_patch_service_account_async(request_type=dict)


def test_patch_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.PatchServiceAccountRequest()

    request.service_account.name = 'service_account.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_service_account),
            '__call__') as call:
        call.return_value = iam.ServiceAccount()
        client.patch_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'service_account.name=service_account.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_patch_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.PatchServiceAccountRequest()

    request.service_account.name = 'service_account.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccount())
        await client.patch_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'service_account.name=service_account.name/value',
    ) in kw['metadata']


def test_delete_service_account(transport: str = 'grpc', request_type=iam.DeleteServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_service_account_from_dict():
    test_delete_service_account(request_type=dict)


def test_delete_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        client.delete_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountRequest()


@pytest.mark.asyncio
async def test_delete_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.DeleteServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_service_account_async_from_dict():
    await test_delete_service_account_async(request_type=dict)


def test_delete_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        call.return_value = None
        client.delete_service_account(request)

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
async def test_delete_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_service_account(request)

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


def test_delete_service_account_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_service_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_delete_service_account_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_service_account(
            iam.DeleteServiceAccountRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_service_account_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_service_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_service_account_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_service_account(
            iam.DeleteServiceAccountRequest(),
            name='name_value',
        )


def test_undelete_service_account(transport: str = 'grpc', request_type=iam.UndeleteServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.UndeleteServiceAccountResponse(
        )
        response = client.undelete_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.UndeleteServiceAccountResponse)


def test_undelete_service_account_from_dict():
    test_undelete_service_account(request_type=dict)


def test_undelete_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_service_account),
            '__call__') as call:
        client.undelete_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteServiceAccountRequest()


@pytest.mark.asyncio
async def test_undelete_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.UndeleteServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.UndeleteServiceAccountResponse(
        ))
        response = await client.undelete_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.UndeleteServiceAccountResponse)


@pytest.mark.asyncio
async def test_undelete_service_account_async_from_dict():
    await test_undelete_service_account_async(request_type=dict)


def test_undelete_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UndeleteServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_service_account),
            '__call__') as call:
        call.return_value = iam.UndeleteServiceAccountResponse()
        client.undelete_service_account(request)

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
async def test_undelete_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UndeleteServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.UndeleteServiceAccountResponse())
        await client.undelete_service_account(request)

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


def test_enable_service_account(transport: str = 'grpc', request_type=iam.EnableServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.enable_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.EnableServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_enable_service_account_from_dict():
    test_enable_service_account(request_type=dict)


def test_enable_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service_account),
            '__call__') as call:
        client.enable_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.EnableServiceAccountRequest()


@pytest.mark.asyncio
async def test_enable_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.EnableServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.enable_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.EnableServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_enable_service_account_async_from_dict():
    await test_enable_service_account_async(request_type=dict)


def test_enable_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.EnableServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service_account),
            '__call__') as call:
        call.return_value = None
        client.enable_service_account(request)

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
async def test_enable_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.EnableServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.enable_service_account(request)

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


def test_disable_service_account(transport: str = 'grpc', request_type=iam.DisableServiceAccountRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.disable_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DisableServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_disable_service_account_from_dict():
    test_disable_service_account(request_type=dict)


def test_disable_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service_account),
            '__call__') as call:
        client.disable_service_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DisableServiceAccountRequest()


@pytest.mark.asyncio
async def test_disable_service_account_async(transport: str = 'grpc_asyncio', request_type=iam.DisableServiceAccountRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.disable_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DisableServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_disable_service_account_async_from_dict():
    await test_disable_service_account_async(request_type=dict)


def test_disable_service_account_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DisableServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service_account),
            '__call__') as call:
        call.return_value = None
        client.disable_service_account(request)

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
async def test_disable_service_account_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DisableServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.disable_service_account(request)

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


def test_list_service_account_keys(transport: str = 'grpc', request_type=iam.ListServiceAccountKeysRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountKeysResponse(
        )
        response = client.list_service_account_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ListServiceAccountKeysResponse)


def test_list_service_account_keys_from_dict():
    test_list_service_account_keys(request_type=dict)


def test_list_service_account_keys_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        client.list_service_account_keys()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountKeysRequest()


@pytest.mark.asyncio
async def test_list_service_account_keys_async(transport: str = 'grpc_asyncio', request_type=iam.ListServiceAccountKeysRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountKeysResponse(
        ))
        response = await client.list_service_account_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListServiceAccountKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ListServiceAccountKeysResponse)


@pytest.mark.asyncio
async def test_list_service_account_keys_async_from_dict():
    await test_list_service_account_keys_async(request_type=dict)


def test_list_service_account_keys_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ListServiceAccountKeysRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        call.return_value = iam.ListServiceAccountKeysResponse()
        client.list_service_account_keys(request)

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
async def test_list_service_account_keys_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.ListServiceAccountKeysRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountKeysResponse())
        await client.list_service_account_keys(request)

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


def test_list_service_account_keys_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountKeysResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_service_account_keys(
            name='name_value',
            key_types=[iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].key_types == [iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED]


def test_list_service_account_keys_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_service_account_keys(
            iam.ListServiceAccountKeysRequest(),
            name='name_value',
            key_types=[iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED],
        )


@pytest.mark.asyncio
async def test_list_service_account_keys_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_service_account_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListServiceAccountKeysResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ListServiceAccountKeysResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_service_account_keys(
            name='name_value',
            key_types=[iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].key_types == [iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED]


@pytest.mark.asyncio
async def test_list_service_account_keys_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_service_account_keys(
            iam.ListServiceAccountKeysRequest(),
            name='name_value',
            key_types=[iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED],
        )


def test_get_service_account_key(transport: str = 'grpc', request_type=iam.GetServiceAccountKeyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        )
        response = client.get_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


def test_get_service_account_key_from_dict():
    test_get_service_account_key(request_type=dict)


def test_get_service_account_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        client.get_service_account_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountKeyRequest()


@pytest.mark.asyncio
async def test_get_service_account_key_async(transport: str = 'grpc_asyncio', request_type=iam.GetServiceAccountKeyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        ))
        response = await client.get_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


@pytest.mark.asyncio
async def test_get_service_account_key_async_from_dict():
    await test_get_service_account_key_async(request_type=dict)


def test_get_service_account_key_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        call.return_value = iam.ServiceAccountKey()
        client.get_service_account_key(request)

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
async def test_get_service_account_key_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey())
        await client.get_service_account_key(request)

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


def test_get_service_account_key_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_service_account_key(
            name='name_value',
            public_key_type=iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].public_key_type == iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE


def test_get_service_account_key_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_service_account_key(
            iam.GetServiceAccountKeyRequest(),
            name='name_value',
            public_key_type=iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE,
        )


@pytest.mark.asyncio
async def test_get_service_account_key_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_service_account_key(
            name='name_value',
            public_key_type=iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].public_key_type == iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE


@pytest.mark.asyncio
async def test_get_service_account_key_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_service_account_key(
            iam.GetServiceAccountKeyRequest(),
            name='name_value',
            public_key_type=iam.ServiceAccountPublicKeyType.TYPE_X509_PEM_FILE,
        )


def test_create_service_account_key(transport: str = 'grpc', request_type=iam.CreateServiceAccountKeyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        )
        response = client.create_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


def test_create_service_account_key_from_dict():
    test_create_service_account_key(request_type=dict)


def test_create_service_account_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        client.create_service_account_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountKeyRequest()


@pytest.mark.asyncio
async def test_create_service_account_key_async(transport: str = 'grpc_asyncio', request_type=iam.CreateServiceAccountKeyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        ))
        response = await client.create_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


@pytest.mark.asyncio
async def test_create_service_account_key_async_from_dict():
    await test_create_service_account_key_async(request_type=dict)


def test_create_service_account_key_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        call.return_value = iam.ServiceAccountKey()
        client.create_service_account_key(request)

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
async def test_create_service_account_key_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey())
        await client.create_service_account_key(request)

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


def test_create_service_account_key_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_service_account_key(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
        assert args[0].key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024


def test_create_service_account_key_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_service_account_key(
            iam.CreateServiceAccountKeyRequest(),
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
        )


@pytest.mark.asyncio
async def test_create_service_account_key_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_service_account_key(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
        assert args[0].key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024


@pytest.mark.asyncio
async def test_create_service_account_key_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_service_account_key(
            iam.CreateServiceAccountKeyRequest(),
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
        )


def test_upload_service_account_key(transport: str = 'grpc', request_type=iam.UploadServiceAccountKeyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upload_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        )
        response = client.upload_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UploadServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


def test_upload_service_account_key_from_dict():
    test_upload_service_account_key(request_type=dict)


def test_upload_service_account_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upload_service_account_key),
            '__call__') as call:
        client.upload_service_account_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UploadServiceAccountKeyRequest()


@pytest.mark.asyncio
async def test_upload_service_account_key_async(transport: str = 'grpc_asyncio', request_type=iam.UploadServiceAccountKeyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upload_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey(
            name='name_value',
            private_key_type=iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE,
            key_algorithm=iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024,
            private_key_data=b'private_key_data_blob',
            public_key_data=b'public_key_data_blob',
            key_origin=iam.ServiceAccountKeyOrigin.USER_PROVIDED,
            key_type=iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED,
        ))
        response = await client.upload_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UploadServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.ServiceAccountKey)
    assert response.name == 'name_value'
    assert response.private_key_type == iam.ServiceAccountPrivateKeyType.TYPE_PKCS12_FILE
    assert response.key_algorithm == iam.ServiceAccountKeyAlgorithm.KEY_ALG_RSA_1024
    assert response.private_key_data == b'private_key_data_blob'
    assert response.public_key_data == b'public_key_data_blob'
    assert response.key_origin == iam.ServiceAccountKeyOrigin.USER_PROVIDED
    assert response.key_type == iam.ListServiceAccountKeysRequest.KeyType.USER_MANAGED


@pytest.mark.asyncio
async def test_upload_service_account_key_async_from_dict():
    await test_upload_service_account_key_async(request_type=dict)


def test_upload_service_account_key_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UploadServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upload_service_account_key),
            '__call__') as call:
        call.return_value = iam.ServiceAccountKey()
        client.upload_service_account_key(request)

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
async def test_upload_service_account_key_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UploadServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upload_service_account_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.ServiceAccountKey())
        await client.upload_service_account_key(request)

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


def test_delete_service_account_key(transport: str = 'grpc', request_type=iam.DeleteServiceAccountKeyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_service_account_key_from_dict():
    test_delete_service_account_key(request_type=dict)


def test_delete_service_account_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        client.delete_service_account_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountKeyRequest()


@pytest.mark.asyncio
async def test_delete_service_account_key_async(transport: str = 'grpc_asyncio', request_type=iam.DeleteServiceAccountKeyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_service_account_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteServiceAccountKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_service_account_key_async_from_dict():
    await test_delete_service_account_key_async(request_type=dict)


def test_delete_service_account_key_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        call.return_value = None
        client.delete_service_account_key(request)

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
async def test_delete_service_account_key_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteServiceAccountKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_service_account_key(request)

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


def test_delete_service_account_key_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_service_account_key(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_delete_service_account_key_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_service_account_key(
            iam.DeleteServiceAccountKeyRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_service_account_key_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_service_account_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_service_account_key(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_service_account_key_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_service_account_key(
            iam.DeleteServiceAccountKeyRequest(),
            name='name_value',
        )


def test_sign_blob(transport: str = 'grpc', request_type=iam.SignBlobRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignBlobResponse(
            key_id='key_id_value',
            signature=b'signature_blob',
        )
        response = client.sign_blob(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignBlobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.SignBlobResponse)
    assert response.key_id == 'key_id_value'
    assert response.signature == b'signature_blob'


def test_sign_blob_from_dict():
    test_sign_blob(request_type=dict)


def test_sign_blob_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        client.sign_blob()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignBlobRequest()


@pytest.mark.asyncio
async def test_sign_blob_async(transport: str = 'grpc_asyncio', request_type=iam.SignBlobRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.SignBlobResponse(
            key_id='key_id_value',
            signature=b'signature_blob',
        ))
        response = await client.sign_blob(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignBlobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.SignBlobResponse)
    assert response.key_id == 'key_id_value'
    assert response.signature == b'signature_blob'


@pytest.mark.asyncio
async def test_sign_blob_async_from_dict():
    await test_sign_blob_async(request_type=dict)


def test_sign_blob_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.SignBlobRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        call.return_value = iam.SignBlobResponse()
        client.sign_blob(request)

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
async def test_sign_blob_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.SignBlobRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.SignBlobResponse())
        await client.sign_blob(request)

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


def test_sign_blob_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignBlobResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.sign_blob(
            name='name_value',
            bytes_to_sign=b'bytes_to_sign_blob',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].bytes_to_sign == b'bytes_to_sign_blob'


def test_sign_blob_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.sign_blob(
            iam.SignBlobRequest(),
            name='name_value',
            bytes_to_sign=b'bytes_to_sign_blob',
        )


@pytest.mark.asyncio
async def test_sign_blob_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_blob),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignBlobResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.SignBlobResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.sign_blob(
            name='name_value',
            bytes_to_sign=b'bytes_to_sign_blob',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].bytes_to_sign == b'bytes_to_sign_blob'


@pytest.mark.asyncio
async def test_sign_blob_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.sign_blob(
            iam.SignBlobRequest(),
            name='name_value',
            bytes_to_sign=b'bytes_to_sign_blob',
        )


def test_sign_jwt(transport: str = 'grpc', request_type=iam.SignJwtRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignJwtResponse(
            key_id='key_id_value',
            signed_jwt='signed_jwt_value',
        )
        response = client.sign_jwt(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignJwtRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.SignJwtResponse)
    assert response.key_id == 'key_id_value'
    assert response.signed_jwt == 'signed_jwt_value'


def test_sign_jwt_from_dict():
    test_sign_jwt(request_type=dict)


def test_sign_jwt_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        client.sign_jwt()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignJwtRequest()


@pytest.mark.asyncio
async def test_sign_jwt_async(transport: str = 'grpc_asyncio', request_type=iam.SignJwtRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.SignJwtResponse(
            key_id='key_id_value',
            signed_jwt='signed_jwt_value',
        ))
        response = await client.sign_jwt(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.SignJwtRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.SignJwtResponse)
    assert response.key_id == 'key_id_value'
    assert response.signed_jwt == 'signed_jwt_value'


@pytest.mark.asyncio
async def test_sign_jwt_async_from_dict():
    await test_sign_jwt_async(request_type=dict)


def test_sign_jwt_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.SignJwtRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        call.return_value = iam.SignJwtResponse()
        client.sign_jwt(request)

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
async def test_sign_jwt_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.SignJwtRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.SignJwtResponse())
        await client.sign_jwt(request)

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


def test_sign_jwt_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignJwtResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.sign_jwt(
            name='name_value',
            payload='payload_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].payload == 'payload_value'


def test_sign_jwt_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.sign_jwt(
            iam.SignJwtRequest(),
            name='name_value',
            payload='payload_value',
        )


@pytest.mark.asyncio
async def test_sign_jwt_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sign_jwt),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.SignJwtResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.SignJwtResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.sign_jwt(
            name='name_value',
            payload='payload_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].payload == 'payload_value'


@pytest.mark.asyncio
async def test_sign_jwt_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.sign_jwt(
            iam.SignJwtRequest(),
            name='name_value',
            payload='payload_value',
        )


def test_get_iam_policy(transport: str = 'grpc', request_type=iam_policy_pb2.GetIamPolicyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_get_iam_policy_from_dict():
    test_get_iam_policy(request_type=dict)


def test_get_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        client.get_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.GetIamPolicyRequest()


@pytest.mark.asyncio
async def test_get_iam_policy_async(transport: str = 'grpc_asyncio', request_type=iam_policy_pb2.GetIamPolicyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_get_iam_policy_async_from_dict():
    await test_get_iam_policy_async(request_type=dict)


def test_get_iam_policy_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.GetIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        call.return_value = policy_pb2.Policy()
        client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_iam_policy_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.GetIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy())
        await client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']

def test_get_iam_policy_from_dict_foreign():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()
        response = client.get_iam_policy(request={
            'resource': 'resource_value',
            'options': options_pb2.GetPolicyOptions(requested_policy_version=2598),
            }
        )
        call.assert_called()


def test_get_iam_policy_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_iam_policy(
            resource='resource_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'


def test_get_iam_policy_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_iam_policy(
            iam_policy_pb2.GetIamPolicyRequest(),
            resource='resource_value',
        )


@pytest.mark.asyncio
async def test_get_iam_policy_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_iam_policy(
            resource='resource_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'


@pytest.mark.asyncio
async def test_get_iam_policy_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_iam_policy(
            iam_policy_pb2.GetIamPolicyRequest(),
            resource='resource_value',
        )


def test_set_iam_policy(transport: str = 'grpc', request_type=iam_policy_pb2.SetIamPolicyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_set_iam_policy_from_dict():
    test_set_iam_policy(request_type=dict)


def test_set_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        client.set_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.SetIamPolicyRequest()


@pytest.mark.asyncio
async def test_set_iam_policy_async(transport: str = 'grpc_asyncio', request_type=iam_policy_pb2.SetIamPolicyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_set_iam_policy_async_from_dict():
    await test_set_iam_policy_async(request_type=dict)


def test_set_iam_policy_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.SetIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        call.return_value = policy_pb2.Policy()
        client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_set_iam_policy_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.SetIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy())
        await client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']

def test_set_iam_policy_from_dict_foreign():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()
        response = client.set_iam_policy(request={
            'resource': 'resource_value',
            'policy': policy_pb2.Policy(version=774),
            }
        )
        call.assert_called()


def test_set_iam_policy_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.set_iam_policy(
            resource='resource_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'


def test_set_iam_policy_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.set_iam_policy(
            iam_policy_pb2.SetIamPolicyRequest(),
            resource='resource_value',
        )


@pytest.mark.asyncio
async def test_set_iam_policy_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.set_iam_policy(
            resource='resource_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'


@pytest.mark.asyncio
async def test_set_iam_policy_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.set_iam_policy(
            iam_policy_pb2.SetIamPolicyRequest(),
            resource='resource_value',
        )


def test_test_iam_permissions(transport: str = 'grpc', request_type=iam_policy_pb2.TestIamPermissionsRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        )
        response = client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


def test_test_iam_permissions_from_dict():
    test_test_iam_permissions(request_type=dict)


def test_test_iam_permissions_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        client.test_iam_permissions()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.TestIamPermissionsRequest()


@pytest.mark.asyncio
async def test_test_iam_permissions_async(transport: str = 'grpc_asyncio', request_type=iam_policy_pb2.TestIamPermissionsRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        ))
        response = await client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam_policy_pb2.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


@pytest.mark.asyncio
async def test_test_iam_permissions_async_from_dict():
    await test_test_iam_permissions_async(request_type=dict)


def test_test_iam_permissions_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.TestIamPermissionsRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse()
        client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_test_iam_permissions_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy_pb2.TestIamPermissionsRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam_policy_pb2.TestIamPermissionsResponse())
        await client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource=resource/value',
    ) in kw['metadata']

def test_test_iam_permissions_from_dict_foreign():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse()
        response = client.test_iam_permissions(request={
            'resource': 'resource_value',
            'permissions': ['permissions_value'],
            }
        )
        call.assert_called()


def test_test_iam_permissions_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.test_iam_permissions(
            resource='resource_value',
            permissions=['permissions_value'],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'
        assert args[0].permissions == ['permissions_value']


def test_test_iam_permissions_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.test_iam_permissions(
            iam_policy_pb2.TestIamPermissionsRequest(),
            resource='resource_value',
            permissions=['permissions_value'],
        )


@pytest.mark.asyncio
async def test_test_iam_permissions_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam_policy_pb2.TestIamPermissionsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.test_iam_permissions(
            resource='resource_value',
            permissions=['permissions_value'],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].resource == 'resource_value'
        assert args[0].permissions == ['permissions_value']


@pytest.mark.asyncio
async def test_test_iam_permissions_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.test_iam_permissions(
            iam_policy_pb2.TestIamPermissionsRequest(),
            resource='resource_value',
            permissions=['permissions_value'],
        )


def test_query_grantable_roles(transport: str = 'grpc', request_type=iam.QueryGrantableRolesRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.QueryGrantableRolesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.query_grantable_roles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryGrantableRolesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.QueryGrantableRolesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_query_grantable_roles_from_dict():
    test_query_grantable_roles(request_type=dict)


def test_query_grantable_roles_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        client.query_grantable_roles()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryGrantableRolesRequest()


@pytest.mark.asyncio
async def test_query_grantable_roles_async(transport: str = 'grpc_asyncio', request_type=iam.QueryGrantableRolesRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.QueryGrantableRolesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.query_grantable_roles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryGrantableRolesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.QueryGrantableRolesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_query_grantable_roles_async_from_dict():
    await test_query_grantable_roles_async(request_type=dict)


def test_query_grantable_roles_flattened():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.QueryGrantableRolesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.query_grantable_roles(
            full_resource_name='full_resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].full_resource_name == 'full_resource_name_value'


def test_query_grantable_roles_flattened_error():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.query_grantable_roles(
            iam.QueryGrantableRolesRequest(),
            full_resource_name='full_resource_name_value',
        )


@pytest.mark.asyncio
async def test_query_grantable_roles_flattened_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.QueryGrantableRolesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.QueryGrantableRolesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.query_grantable_roles(
            full_resource_name='full_resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].full_resource_name == 'full_resource_name_value'


@pytest.mark.asyncio
async def test_query_grantable_roles_flattened_error_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.query_grantable_roles(
            iam.QueryGrantableRolesRequest(),
            full_resource_name='full_resource_name_value',
        )


def test_query_grantable_roles_pager():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.query_grantable_roles(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, iam.Role)
                   for i in results)

def test_query_grantable_roles_pages():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.query_grantable_roles(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_query_grantable_roles_async_pager():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.query_grantable_roles(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, iam.Role)
                   for i in responses)

@pytest.mark.asyncio
async def test_query_grantable_roles_async_pages():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_grantable_roles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryGrantableRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.query_grantable_roles(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_list_roles(transport: str = 'grpc', request_type=iam.ListRolesRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.ListRolesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_roles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListRolesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListRolesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_roles_from_dict():
    test_list_roles(request_type=dict)


def test_list_roles_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__') as call:
        client.list_roles()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListRolesRequest()


@pytest.mark.asyncio
async def test_list_roles_async(transport: str = 'grpc_asyncio', request_type=iam.ListRolesRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.ListRolesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_roles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.ListRolesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListRolesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_roles_async_from_dict():
    await test_list_roles_async(request_type=dict)


def test_list_roles_pager():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.ListRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_roles(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, iam.Role)
                   for i in results)

def test_list_roles_pages():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.ListRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_roles(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_roles_async_pager():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.ListRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_roles(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, iam.Role)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_roles_async_pages():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_roles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                    iam.Role(),
                ],
                next_page_token='abc',
            ),
            iam.ListRolesResponse(
                roles=[],
                next_page_token='def',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                ],
                next_page_token='ghi',
            ),
            iam.ListRolesResponse(
                roles=[
                    iam.Role(),
                    iam.Role(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_roles(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_role(transport: str = 'grpc', request_type=iam.GetRoleRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        )
        response = client.get_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


def test_get_role_from_dict():
    test_get_role(request_type=dict)


def test_get_role_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_role),
            '__call__') as call:
        client.get_role()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetRoleRequest()


@pytest.mark.asyncio
async def test_get_role_async(transport: str = 'grpc_asyncio', request_type=iam.GetRoleRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        ))
        response = await client.get_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.GetRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


@pytest.mark.asyncio
async def test_get_role_async_from_dict():
    await test_get_role_async(request_type=dict)


def test_get_role_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_role),
            '__call__') as call:
        call.return_value = iam.Role()
        client.get_role(request)

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
async def test_get_role_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.GetRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_role),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.Role())
        await client.get_role(request)

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


def test_create_role(transport: str = 'grpc', request_type=iam.CreateRoleRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        )
        response = client.create_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


def test_create_role_from_dict():
    test_create_role(request_type=dict)


def test_create_role_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_role),
            '__call__') as call:
        client.create_role()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateRoleRequest()


@pytest.mark.asyncio
async def test_create_role_async(transport: str = 'grpc_asyncio', request_type=iam.CreateRoleRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        ))
        response = await client.create_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.CreateRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


@pytest.mark.asyncio
async def test_create_role_async_from_dict():
    await test_create_role_async(request_type=dict)


def test_create_role_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateRoleRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_role),
            '__call__') as call:
        call.return_value = iam.Role()
        client.create_role(request)

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
async def test_create_role_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.CreateRoleRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_role),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.Role())
        await client.create_role(request)

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


def test_update_role(transport: str = 'grpc', request_type=iam.UpdateRoleRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        )
        response = client.update_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UpdateRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


def test_update_role_from_dict():
    test_update_role(request_type=dict)


def test_update_role_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_role),
            '__call__') as call:
        client.update_role()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UpdateRoleRequest()


@pytest.mark.asyncio
async def test_update_role_async(transport: str = 'grpc_asyncio', request_type=iam.UpdateRoleRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        ))
        response = await client.update_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UpdateRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


@pytest.mark.asyncio
async def test_update_role_async_from_dict():
    await test_update_role_async(request_type=dict)


def test_update_role_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UpdateRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_role),
            '__call__') as call:
        call.return_value = iam.Role()
        client.update_role(request)

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
async def test_update_role_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UpdateRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_role),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.Role())
        await client.update_role(request)

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


def test_delete_role(transport: str = 'grpc', request_type=iam.DeleteRoleRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        )
        response = client.delete_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


def test_delete_role_from_dict():
    test_delete_role(request_type=dict)


def test_delete_role_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_role),
            '__call__') as call:
        client.delete_role()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteRoleRequest()


@pytest.mark.asyncio
async def test_delete_role_async(transport: str = 'grpc_asyncio', request_type=iam.DeleteRoleRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        ))
        response = await client.delete_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.DeleteRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


@pytest.mark.asyncio
async def test_delete_role_async_from_dict():
    await test_delete_role_async(request_type=dict)


def test_delete_role_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_role),
            '__call__') as call:
        call.return_value = iam.Role()
        client.delete_role(request)

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
async def test_delete_role_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.DeleteRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_role),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.Role())
        await client.delete_role(request)

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


def test_undelete_role(transport: str = 'grpc', request_type=iam.UndeleteRoleRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        )
        response = client.undelete_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


def test_undelete_role_from_dict():
    test_undelete_role(request_type=dict)


def test_undelete_role_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_role),
            '__call__') as call:
        client.undelete_role()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteRoleRequest()


@pytest.mark.asyncio
async def test_undelete_role_async(transport: str = 'grpc_asyncio', request_type=iam.UndeleteRoleRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_role),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.Role(
            name='name_value',
            title='title_value',
            description='description_value',
            included_permissions=['included_permissions_value'],
            stage=iam.Role.RoleLaunchStage.BETA,
            etag=b'etag_blob',
            deleted=True,
        ))
        response = await client.undelete_role(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.UndeleteRoleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.Role)
    assert response.name == 'name_value'
    assert response.title == 'title_value'
    assert response.description == 'description_value'
    assert response.included_permissions == ['included_permissions_value']
    assert response.stage == iam.Role.RoleLaunchStage.BETA
    assert response.etag == b'etag_blob'
    assert response.deleted is True


@pytest.mark.asyncio
async def test_undelete_role_async_from_dict():
    await test_undelete_role_async(request_type=dict)


def test_undelete_role_field_headers():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UndeleteRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_role),
            '__call__') as call:
        call.return_value = iam.Role()
        client.undelete_role(request)

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
async def test_undelete_role_field_headers_async():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam.UndeleteRoleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.undelete_role),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam.Role())
        await client.undelete_role(request)

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


def test_query_testable_permissions(transport: str = 'grpc', request_type=iam.QueryTestablePermissionsRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.QueryTestablePermissionsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.query_testable_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryTestablePermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.QueryTestablePermissionsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_query_testable_permissions_from_dict():
    test_query_testable_permissions(request_type=dict)


def test_query_testable_permissions_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__') as call:
        client.query_testable_permissions()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryTestablePermissionsRequest()


@pytest.mark.asyncio
async def test_query_testable_permissions_async(transport: str = 'grpc_asyncio', request_type=iam.QueryTestablePermissionsRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.QueryTestablePermissionsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.query_testable_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryTestablePermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.QueryTestablePermissionsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_query_testable_permissions_async_from_dict():
    await test_query_testable_permissions_async(request_type=dict)


def test_query_testable_permissions_pager():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                    iam.Permission(),
                ],
                next_page_token='abc',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[],
                next_page_token='def',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.query_testable_permissions(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, iam.Permission)
                   for i in results)

def test_query_testable_permissions_pages():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                    iam.Permission(),
                ],
                next_page_token='abc',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[],
                next_page_token='def',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.query_testable_permissions(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_query_testable_permissions_async_pager():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                    iam.Permission(),
                ],
                next_page_token='abc',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[],
                next_page_token='def',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.query_testable_permissions(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, iam.Permission)
                   for i in responses)

@pytest.mark.asyncio
async def test_query_testable_permissions_async_pages():
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_testable_permissions),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                    iam.Permission(),
                ],
                next_page_token='abc',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[],
                next_page_token='def',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                ],
                next_page_token='ghi',
            ),
            iam.QueryTestablePermissionsResponse(
                permissions=[
                    iam.Permission(),
                    iam.Permission(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.query_testable_permissions(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_query_auditable_services(transport: str = 'grpc', request_type=iam.QueryAuditableServicesRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_auditable_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.QueryAuditableServicesResponse(
        )
        response = client.query_auditable_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryAuditableServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.QueryAuditableServicesResponse)


def test_query_auditable_services_from_dict():
    test_query_auditable_services(request_type=dict)


def test_query_auditable_services_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_auditable_services),
            '__call__') as call:
        client.query_auditable_services()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryAuditableServicesRequest()


@pytest.mark.asyncio
async def test_query_auditable_services_async(transport: str = 'grpc_asyncio', request_type=iam.QueryAuditableServicesRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_auditable_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.QueryAuditableServicesResponse(
        ))
        response = await client.query_auditable_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.QueryAuditableServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.QueryAuditableServicesResponse)


@pytest.mark.asyncio
async def test_query_auditable_services_async_from_dict():
    await test_query_auditable_services_async(request_type=dict)


def test_lint_policy(transport: str = 'grpc', request_type=iam.LintPolicyRequest):
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lint_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam.LintPolicyResponse(
        )
        response = client.lint_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.LintPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.LintPolicyResponse)


def test_lint_policy_from_dict():
    test_lint_policy(request_type=dict)


def test_lint_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lint_policy),
            '__call__') as call:
        client.lint_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.LintPolicyRequest()


@pytest.mark.asyncio
async def test_lint_policy_async(transport: str = 'grpc_asyncio', request_type=iam.LintPolicyRequest):
    client = IAMAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lint_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam.LintPolicyResponse(
        ))
        response = await client.lint_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == iam.LintPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam.LintPolicyResponse)


@pytest.mark.asyncio
async def test_lint_policy_async_from_dict():
    await test_lint_policy_async(request_type=dict)


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.IAMGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = IAMClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.IAMGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = IAMClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.IAMGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = IAMClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.IAMGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = IAMClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.IAMGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.IAMGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.IAMGrpcTransport,
    transports.IAMGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.IAMGrpcTransport,
    )

def test_iam_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.IAMTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_iam_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.iam.admin_v1.services.iam.transports.IAMTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.IAMTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'list_service_accounts',
        'get_service_account',
        'create_service_account',
        'update_service_account',
        'patch_service_account',
        'delete_service_account',
        'undelete_service_account',
        'enable_service_account',
        'disable_service_account',
        'list_service_account_keys',
        'get_service_account_key',
        'create_service_account_key',
        'upload_service_account_key',
        'delete_service_account_key',
        'sign_blob',
        'sign_jwt',
        'get_iam_policy',
        'set_iam_policy',
        'test_iam_permissions',
        'query_grantable_roles',
        'list_roles',
        'get_role',
        'create_role',
        'update_role',
        'delete_role',
        'undelete_role',
        'query_testable_permissions',
        'query_auditable_services',
        'lint_policy',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


@requires_google_auth_gte_1_25_0
def test_iam_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.iam.admin_v1.services.iam.transports.IAMTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.IAMTransport(
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


@requires_google_auth_lt_1_25_0
def test_iam_base_transport_with_credentials_file_old_google_auth():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.iam.admin_v1.services.iam.transports.IAMTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.IAMTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            ),
            quota_project_id="octopus",
        )


def test_iam_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.iam.admin_v1.services.iam.transports.IAMTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.IAMTransport()
        adc.assert_called_once()


@requires_google_auth_gte_1_25_0
def test_iam_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        IAMClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id=None,
        )


@requires_google_auth_lt_1_25_0
def test_iam_auth_adc_old_google_auth():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        IAMClient()
        adc.assert_called_once_with(
            scopes=(                'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.IAMGrpcTransport,
        transports.IAMGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_gte_1_25_0
def test_iam_transport_auth_adc(transport_class):
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
    "transport_class",
    [
        transports.IAMGrpcTransport,
        transports.IAMGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_lt_1_25_0
def test_iam_transport_auth_adc_old_google_auth(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.IAMGrpcTransport, grpc_helpers),
        (transports.IAMGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_iam_transport_create_channel(transport_class, grpc_helpers):
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
            "iam.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="iam.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.IAMGrpcTransport, transports.IAMGrpcAsyncIOTransport])
def test_iam_grpc_transport_client_cert_source_for_mtls(
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


def test_iam_host_no_port():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='iam.googleapis.com'),
    )
    assert client.transport._host == 'iam.googleapis.com:443'


def test_iam_host_with_port():
    client = IAMClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='iam.googleapis.com:8000'),
    )
    assert client.transport._host == 'iam.googleapis.com:8000'

def test_iam_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.IAMGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_iam_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.IAMGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.IAMGrpcTransport, transports.IAMGrpcAsyncIOTransport])
def test_iam_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.IAMGrpcTransport, transports.IAMGrpcAsyncIOTransport])
def test_iam_transport_channel_mtls_with_adc(
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


def test_key_path():
    project = "squid"
    service_account = "clam"
    key = "whelk"
    expected = "projects/{project}/serviceAccounts/{service_account}/keys/{key}".format(project=project, service_account=service_account, key=key, )
    actual = IAMClient.key_path(project, service_account, key)
    assert expected == actual


def test_parse_key_path():
    expected = {
        "project": "octopus",
        "service_account": "oyster",
        "key": "nudibranch",
    }
    path = IAMClient.key_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_key_path(path)
    assert expected == actual

def test_service_account_path():
    project = "cuttlefish"
    service_account = "mussel"
    expected = "projects/{project}/serviceAccounts/{service_account}".format(project=project, service_account=service_account, )
    actual = IAMClient.service_account_path(project, service_account)
    assert expected == actual


def test_parse_service_account_path():
    expected = {
        "project": "winkle",
        "service_account": "nautilus",
    }
    path = IAMClient.service_account_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_service_account_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "scallop"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = IAMClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "abalone",
    }
    path = IAMClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "squid"
    expected = "folders/{folder}".format(folder=folder, )
    actual = IAMClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "clam",
    }
    path = IAMClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "whelk"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = IAMClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "octopus",
    }
    path = IAMClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "oyster"
    expected = "projects/{project}".format(project=project, )
    actual = IAMClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nudibranch",
    }
    path = IAMClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "cuttlefish"
    location = "mussel"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = IAMClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "winkle",
        "location": "nautilus",
    }
    path = IAMClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = IAMClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.IAMTransport, '_prep_wrapped_messages') as prep:
        client = IAMClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.IAMTransport, '_prep_wrapped_messages') as prep:
        transport_class = IAMClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
