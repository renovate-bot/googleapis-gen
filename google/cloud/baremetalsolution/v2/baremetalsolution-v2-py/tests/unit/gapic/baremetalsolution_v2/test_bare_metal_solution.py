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
from google.cloud.baremetalsolution_v2.services.bare_metal_solution import BareMetalSolutionAsyncClient
from google.cloud.baremetalsolution_v2.services.bare_metal_solution import BareMetalSolutionClient
from google.cloud.baremetalsolution_v2.services.bare_metal_solution import pagers
from google.cloud.baremetalsolution_v2.services.bare_metal_solution import transports
from google.cloud.baremetalsolution_v2.types import baremetalsolution
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
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

    assert BareMetalSolutionClient._get_default_mtls_endpoint(None) is None
    assert BareMetalSolutionClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert BareMetalSolutionClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert BareMetalSolutionClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert BareMetalSolutionClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert BareMetalSolutionClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    BareMetalSolutionClient,
    BareMetalSolutionAsyncClient,
])
def test_bare_metal_solution_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'baremetalsolution.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.BareMetalSolutionGrpcTransport, "grpc"),
    (transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_bare_metal_solution_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    BareMetalSolutionClient,
    BareMetalSolutionAsyncClient,
])
def test_bare_metal_solution_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'baremetalsolution.googleapis.com:443'


def test_bare_metal_solution_client_get_transport_class():
    transport = BareMetalSolutionClient.get_transport_class()
    available_transports = [
        transports.BareMetalSolutionGrpcTransport,
    ]
    assert transport in available_transports

    transport = BareMetalSolutionClient.get_transport_class("grpc")
    assert transport == transports.BareMetalSolutionGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (BareMetalSolutionClient, transports.BareMetalSolutionGrpcTransport, "grpc"),
    (BareMetalSolutionAsyncClient, transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(BareMetalSolutionClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BareMetalSolutionClient))
@mock.patch.object(BareMetalSolutionAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BareMetalSolutionAsyncClient))
def test_bare_metal_solution_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(BareMetalSolutionClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(BareMetalSolutionClient, 'get_transport_class') as gtc:
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
            client = client_class(transport=transport_name)

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = client_class(transport=transport_name)

    # Check the case quota_project_id is provided
    options = client_options.ClientOptions(quota_project_id="octopus")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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
    (BareMetalSolutionClient, transports.BareMetalSolutionGrpcTransport, "grpc", "true"),
    (BareMetalSolutionAsyncClient, transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (BareMetalSolutionClient, transports.BareMetalSolutionGrpcTransport, "grpc", "false"),
    (BareMetalSolutionAsyncClient, transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(BareMetalSolutionClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BareMetalSolutionClient))
@mock.patch.object(BareMetalSolutionAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BareMetalSolutionAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_bare_metal_solution_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(client_options=options, transport=transport_name)

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
    (BareMetalSolutionClient, transports.BareMetalSolutionGrpcTransport, "grpc"),
    (BareMetalSolutionAsyncClient, transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_bare_metal_solution_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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
    (BareMetalSolutionClient, transports.BareMetalSolutionGrpcTransport, "grpc"),
    (BareMetalSolutionAsyncClient, transports.BareMetalSolutionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_bare_metal_solution_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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

def test_bare_metal_solution_client_client_options_from_dict():
    with mock.patch('google.cloud.baremetalsolution_v2.services.bare_metal_solution.transports.BareMetalSolutionGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BareMetalSolutionClient(
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


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListInstancesRequest,
  dict,
])
def test_list_instances(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListInstancesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListInstancesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListInstancesPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_instances_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        client.list_instances()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListInstancesRequest()


@pytest.mark.asyncio
async def test_list_instances_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListInstancesRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListInstancesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListInstancesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListInstancesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_instances_async_from_dict():
    await test_list_instances_async(request_type=dict)


def test_list_instances_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListInstancesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = baremetalsolution.ListInstancesResponse()
        client.list_instances(request)

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
async def test_list_instances_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListInstancesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListInstancesResponse())
        await client.list_instances(request)

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


def test_list_instances_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListInstancesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_instances(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_instances_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_instances(
            baremetalsolution.ListInstancesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_instances_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListInstancesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListInstancesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_instances(
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
async def test_list_instances_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_instances(
            baremetalsolution.ListInstancesRequest(),
            parent='parent_value',
        )


def test_list_instances_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
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
        pager = client.list_instances(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.Instance)
                   for i in results)
def test_list_instances_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_instances(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_instances_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_instances(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.Instance)
                for i in responses)


@pytest.mark.asyncio
async def test_list_instances_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListInstancesResponse(
                instances=[
                    baremetalsolution.Instance(),
                    baremetalsolution.Instance(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_instances(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetInstanceRequest,
  dict,
])
def test_get_instance(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Instance(
            name='name_value',
            machine_type='machine_type_value',
            state=baremetalsolution.Instance.State.PROVISIONING,
            hyperthreading_enabled=True,
            interactive_serial_console_enabled=True,
        )
        response = client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Instance)
    assert response.name == 'name_value'
    assert response.machine_type == 'machine_type_value'
    assert response.state == baremetalsolution.Instance.State.PROVISIONING
    assert response.hyperthreading_enabled is True
    assert response.interactive_serial_console_enabled is True


def test_get_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        client.get_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetInstanceRequest()


@pytest.mark.asyncio
async def test_get_instance_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetInstanceRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Instance(
            name='name_value',
            machine_type='machine_type_value',
            state=baremetalsolution.Instance.State.PROVISIONING,
            hyperthreading_enabled=True,
            interactive_serial_console_enabled=True,
        ))
        response = await client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Instance)
    assert response.name == 'name_value'
    assert response.machine_type == 'machine_type_value'
    assert response.state == baremetalsolution.Instance.State.PROVISIONING
    assert response.hyperthreading_enabled is True
    assert response.interactive_serial_console_enabled is True


@pytest.mark.asyncio
async def test_get_instance_async_from_dict():
    await test_get_instance_async(request_type=dict)


def test_get_instance_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = baremetalsolution.Instance()
        client.get_instance(request)

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
async def test_get_instance_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Instance())
        await client.get_instance(request)

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


def test_get_instance_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Instance()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_instance_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_instance(
            baremetalsolution.GetInstanceRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_instance_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Instance()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Instance())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_instance(
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
async def test_get_instance_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_instance(
            baremetalsolution.GetInstanceRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ResetInstanceRequest,
  dict,
])
def test_reset_instance(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.reset_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ResetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_reset_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        client.reset_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ResetInstanceRequest()


@pytest.mark.asyncio
async def test_reset_instance_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ResetInstanceRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.reset_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ResetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_reset_instance_async_from_dict():
    await test_reset_instance_async(request_type=dict)


def test_reset_instance_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ResetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.reset_instance(request)

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
async def test_reset_instance_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ResetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.reset_instance(request)

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


def test_reset_instance_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.reset_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_reset_instance_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.reset_instance(
            baremetalsolution.ResetInstanceRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_reset_instance_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.reset_instance(
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
async def test_reset_instance_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.reset_instance(
            baremetalsolution.ResetInstanceRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListVolumesRequest,
  dict,
])
def test_list_volumes(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_volumes(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVolumesPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_volumes_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        client.list_volumes()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumesRequest()


@pytest.mark.asyncio
async def test_list_volumes_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListVolumesRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_volumes(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVolumesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_volumes_async_from_dict():
    await test_list_volumes_async(request_type=dict)


def test_list_volumes_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListVolumesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        call.return_value = baremetalsolution.ListVolumesResponse()
        client.list_volumes(request)

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
async def test_list_volumes_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListVolumesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumesResponse())
        await client.list_volumes(request)

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


def test_list_volumes_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_volumes(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_volumes_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_volumes(
            baremetalsolution.ListVolumesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_volumes_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_volumes(
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
async def test_list_volumes_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_volumes(
            baremetalsolution.ListVolumesRequest(),
            parent='parent_value',
        )


def test_list_volumes_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
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
        pager = client.list_volumes(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.Volume)
                   for i in results)
def test_list_volumes_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_volumes(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_volumes_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_volumes(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.Volume)
                for i in responses)


@pytest.mark.asyncio
async def test_list_volumes_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volumes),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumesResponse(
                volumes=[
                    baremetalsolution.Volume(),
                    baremetalsolution.Volume(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_volumes(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetVolumeRequest,
  dict,
])
def test_get_volume(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Volume(
            name='name_value',
            storage_type=baremetalsolution.Volume.StorageType.SSD,
            state=baremetalsolution.Volume.State.CREATING,
            requested_size_gib=1917,
            current_size_gib=1710,
            auto_grown_size_gib=2032,
            remaining_space_gib=1974,
            snapshot_auto_delete_behavior=baremetalsolution.Volume.SnapshotAutoDeleteBehavior.DISABLED,
            snapshot_schedule_policy='snapshot_schedule_policy_value',
        )
        response = client.get_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Volume)
    assert response.name == 'name_value'
    assert response.storage_type == baremetalsolution.Volume.StorageType.SSD
    assert response.state == baremetalsolution.Volume.State.CREATING
    assert response.requested_size_gib == 1917
    assert response.current_size_gib == 1710
    assert response.auto_grown_size_gib == 2032
    assert response.remaining_space_gib == 1974
    assert response.snapshot_auto_delete_behavior == baremetalsolution.Volume.SnapshotAutoDeleteBehavior.DISABLED
    assert response.snapshot_schedule_policy == 'snapshot_schedule_policy_value'


def test_get_volume_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        client.get_volume()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeRequest()


@pytest.mark.asyncio
async def test_get_volume_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetVolumeRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Volume(
            name='name_value',
            storage_type=baremetalsolution.Volume.StorageType.SSD,
            state=baremetalsolution.Volume.State.CREATING,
            requested_size_gib=1917,
            current_size_gib=1710,
            auto_grown_size_gib=2032,
            remaining_space_gib=1974,
            snapshot_auto_delete_behavior=baremetalsolution.Volume.SnapshotAutoDeleteBehavior.DISABLED,
            snapshot_schedule_policy='snapshot_schedule_policy_value',
        ))
        response = await client.get_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Volume)
    assert response.name == 'name_value'
    assert response.storage_type == baremetalsolution.Volume.StorageType.SSD
    assert response.state == baremetalsolution.Volume.State.CREATING
    assert response.requested_size_gib == 1917
    assert response.current_size_gib == 1710
    assert response.auto_grown_size_gib == 2032
    assert response.remaining_space_gib == 1974
    assert response.snapshot_auto_delete_behavior == baremetalsolution.Volume.SnapshotAutoDeleteBehavior.DISABLED
    assert response.snapshot_schedule_policy == 'snapshot_schedule_policy_value'


@pytest.mark.asyncio
async def test_get_volume_async_from_dict():
    await test_get_volume_async(request_type=dict)


def test_get_volume_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetVolumeRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        call.return_value = baremetalsolution.Volume()
        client.get_volume(request)

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
async def test_get_volume_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetVolumeRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Volume())
        await client.get_volume(request)

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


def test_get_volume_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Volume()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_volume(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_volume_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_volume(
            baremetalsolution.GetVolumeRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_volume_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Volume()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Volume())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_volume(
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
async def test_get_volume_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_volume(
            baremetalsolution.GetVolumeRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.UpdateVolumeRequest,
  dict,
])
def test_update_volume(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateVolumeRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_volume_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        client.update_volume()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateVolumeRequest()


@pytest.mark.asyncio
async def test_update_volume_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.UpdateVolumeRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateVolumeRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_volume_async_from_dict():
    await test_update_volume_async(request_type=dict)


def test_update_volume_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.UpdateVolumeRequest()

    request.volume.name = 'volume.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'volume.name=volume.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_volume_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.UpdateVolumeRequest()

    request.volume.name = 'volume.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_volume(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'volume.name=volume.name/value',
    ) in kw['metadata']


def test_update_volume_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_volume(
            volume=baremetalsolution.Volume(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].volume
        mock_val = baremetalsolution.Volume(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_volume_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_volume(
            baremetalsolution.UpdateVolumeRequest(),
            volume=baremetalsolution.Volume(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_volume_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_volume),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_volume(
            volume=baremetalsolution.Volume(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].volume
        mock_val = baremetalsolution.Volume(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_volume_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_volume(
            baremetalsolution.UpdateVolumeRequest(),
            volume=baremetalsolution.Volume(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListNetworksRequest,
  dict,
])
def test_list_networks(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListNetworksResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_networks(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListNetworksRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListNetworksPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_networks_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        client.list_networks()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListNetworksRequest()


@pytest.mark.asyncio
async def test_list_networks_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListNetworksRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListNetworksResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_networks(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListNetworksRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListNetworksAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_networks_async_from_dict():
    await test_list_networks_async(request_type=dict)


def test_list_networks_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListNetworksRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        call.return_value = baremetalsolution.ListNetworksResponse()
        client.list_networks(request)

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
async def test_list_networks_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListNetworksRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListNetworksResponse())
        await client.list_networks(request)

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


def test_list_networks_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListNetworksResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_networks(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_networks_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_networks(
            baremetalsolution.ListNetworksRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_networks_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListNetworksResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListNetworksResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_networks(
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
async def test_list_networks_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_networks(
            baremetalsolution.ListNetworksRequest(),
            parent='parent_value',
        )


def test_list_networks_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[],
                next_page_token='def',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
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
        pager = client.list_networks(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.Network)
                   for i in results)
def test_list_networks_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[],
                next_page_token='def',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_networks(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_networks_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[],
                next_page_token='def',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_networks(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.Network)
                for i in responses)


@pytest.mark.asyncio
async def test_list_networks_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_networks),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[],
                next_page_token='def',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListNetworksResponse(
                networks=[
                    baremetalsolution.Network(),
                    baremetalsolution.Network(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_networks(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetNetworkRequest,
  dict,
])
def test_get_network(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Network(
            name='name_value',
            network='network_value',
            type_=baremetalsolution.Network.Type.CLIENT,
            ip_address='ip_address_value',
            mac_address=['mac_address_value'],
            state=baremetalsolution.Network.State.PROVISIONING,
            vlan_id='vlan_id_value',
            cidr='cidr_value',
        )
        response = client.get_network(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetNetworkRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Network)
    assert response.name == 'name_value'
    assert response.network == 'network_value'
    assert response.type_ == baremetalsolution.Network.Type.CLIENT
    assert response.ip_address == 'ip_address_value'
    assert response.mac_address == ['mac_address_value']
    assert response.state == baremetalsolution.Network.State.PROVISIONING
    assert response.vlan_id == 'vlan_id_value'
    assert response.cidr == 'cidr_value'


def test_get_network_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        client.get_network()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetNetworkRequest()


@pytest.mark.asyncio
async def test_get_network_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetNetworkRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Network(
            name='name_value',
            network='network_value',
            type_=baremetalsolution.Network.Type.CLIENT,
            ip_address='ip_address_value',
            mac_address=['mac_address_value'],
            state=baremetalsolution.Network.State.PROVISIONING,
            vlan_id='vlan_id_value',
            cidr='cidr_value',
        ))
        response = await client.get_network(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetNetworkRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Network)
    assert response.name == 'name_value'
    assert response.network == 'network_value'
    assert response.type_ == baremetalsolution.Network.Type.CLIENT
    assert response.ip_address == 'ip_address_value'
    assert response.mac_address == ['mac_address_value']
    assert response.state == baremetalsolution.Network.State.PROVISIONING
    assert response.vlan_id == 'vlan_id_value'
    assert response.cidr == 'cidr_value'


@pytest.mark.asyncio
async def test_get_network_async_from_dict():
    await test_get_network_async(request_type=dict)


def test_get_network_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetNetworkRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        call.return_value = baremetalsolution.Network()
        client.get_network(request)

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
async def test_get_network_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetNetworkRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Network())
        await client.get_network(request)

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


def test_get_network_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Network()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_network(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_network_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_network(
            baremetalsolution.GetNetworkRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_network_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_network),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Network()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Network())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_network(
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
async def test_get_network_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_network(
            baremetalsolution.GetNetworkRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListSnapshotSchedulePoliciesRequest,
  dict,
])
def test_list_snapshot_schedule_policies(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListSnapshotSchedulePoliciesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_snapshot_schedule_policies(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListSnapshotSchedulePoliciesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListSnapshotSchedulePoliciesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_snapshot_schedule_policies_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        client.list_snapshot_schedule_policies()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListSnapshotSchedulePoliciesRequest()


@pytest.mark.asyncio
async def test_list_snapshot_schedule_policies_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListSnapshotSchedulePoliciesRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListSnapshotSchedulePoliciesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_snapshot_schedule_policies(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListSnapshotSchedulePoliciesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListSnapshotSchedulePoliciesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_snapshot_schedule_policies_async_from_dict():
    await test_list_snapshot_schedule_policies_async(request_type=dict)


def test_list_snapshot_schedule_policies_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListSnapshotSchedulePoliciesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        call.return_value = baremetalsolution.ListSnapshotSchedulePoliciesResponse()
        client.list_snapshot_schedule_policies(request)

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
async def test_list_snapshot_schedule_policies_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListSnapshotSchedulePoliciesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListSnapshotSchedulePoliciesResponse())
        await client.list_snapshot_schedule_policies(request)

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


def test_list_snapshot_schedule_policies_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListSnapshotSchedulePoliciesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_snapshot_schedule_policies(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_snapshot_schedule_policies_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_snapshot_schedule_policies(
            baremetalsolution.ListSnapshotSchedulePoliciesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_snapshot_schedule_policies_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListSnapshotSchedulePoliciesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListSnapshotSchedulePoliciesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_snapshot_schedule_policies(
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
async def test_list_snapshot_schedule_policies_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_snapshot_schedule_policies(
            baremetalsolution.ListSnapshotSchedulePoliciesRequest(),
            parent='parent_value',
        )


def test_list_snapshot_schedule_policies_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[],
                next_page_token='def',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
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
        pager = client.list_snapshot_schedule_policies(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.SnapshotSchedulePolicy)
                   for i in results)
def test_list_snapshot_schedule_policies_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[],
                next_page_token='def',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_snapshot_schedule_policies(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_snapshot_schedule_policies_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[],
                next_page_token='def',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_snapshot_schedule_policies(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.SnapshotSchedulePolicy)
                for i in responses)


@pytest.mark.asyncio
async def test_list_snapshot_schedule_policies_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_snapshot_schedule_policies),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[],
                next_page_token='def',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListSnapshotSchedulePoliciesResponse(
                snapshot_schedule_policies=[
                    baremetalsolution.SnapshotSchedulePolicy(),
                    baremetalsolution.SnapshotSchedulePolicy(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_snapshot_schedule_policies(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetSnapshotSchedulePolicyRequest,
  dict,
])
def test_get_snapshot_schedule_policy(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        )
        response = client.get_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


def test_get_snapshot_schedule_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        client.get_snapshot_schedule_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetSnapshotSchedulePolicyRequest()


@pytest.mark.asyncio
async def test_get_snapshot_schedule_policy_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetSnapshotSchedulePolicyRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        ))
        response = await client.get_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_get_snapshot_schedule_policy_async_from_dict():
    await test_get_snapshot_schedule_policy_async(request_type=dict)


def test_get_snapshot_schedule_policy_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetSnapshotSchedulePolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        client.get_snapshot_schedule_policy(request)

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
async def test_get_snapshot_schedule_policy_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetSnapshotSchedulePolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        await client.get_snapshot_schedule_policy(request)

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


def test_get_snapshot_schedule_policy_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_snapshot_schedule_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_snapshot_schedule_policy_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_snapshot_schedule_policy(
            baremetalsolution.GetSnapshotSchedulePolicyRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_snapshot_schedule_policy_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_snapshot_schedule_policy(
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
async def test_get_snapshot_schedule_policy_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_snapshot_schedule_policy(
            baremetalsolution.GetSnapshotSchedulePolicyRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.CreateSnapshotSchedulePolicyRequest,
  dict,
])
def test_create_snapshot_schedule_policy(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        )
        response = client.create_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


def test_create_snapshot_schedule_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        client.create_snapshot_schedule_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateSnapshotSchedulePolicyRequest()


@pytest.mark.asyncio
async def test_create_snapshot_schedule_policy_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.CreateSnapshotSchedulePolicyRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        ))
        response = await client.create_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_create_snapshot_schedule_policy_async_from_dict():
    await test_create_snapshot_schedule_policy_async(request_type=dict)


def test_create_snapshot_schedule_policy_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.CreateSnapshotSchedulePolicyRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        client.create_snapshot_schedule_policy(request)

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
async def test_create_snapshot_schedule_policy_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.CreateSnapshotSchedulePolicyRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        await client.create_snapshot_schedule_policy(request)

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


def test_create_snapshot_schedule_policy_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_snapshot_schedule_policy(
            parent='parent_value',
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            snapshot_schedule_policy_id='snapshot_schedule_policy_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].snapshot_schedule_policy
        mock_val = baremetalsolution.SnapshotSchedulePolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].snapshot_schedule_policy_id
        mock_val = 'snapshot_schedule_policy_id_value'
        assert arg == mock_val


def test_create_snapshot_schedule_policy_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_snapshot_schedule_policy(
            baremetalsolution.CreateSnapshotSchedulePolicyRequest(),
            parent='parent_value',
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            snapshot_schedule_policy_id='snapshot_schedule_policy_id_value',
        )


@pytest.mark.asyncio
async def test_create_snapshot_schedule_policy_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_snapshot_schedule_policy(
            parent='parent_value',
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            snapshot_schedule_policy_id='snapshot_schedule_policy_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].snapshot_schedule_policy
        mock_val = baremetalsolution.SnapshotSchedulePolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].snapshot_schedule_policy_id
        mock_val = 'snapshot_schedule_policy_id_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_snapshot_schedule_policy_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_snapshot_schedule_policy(
            baremetalsolution.CreateSnapshotSchedulePolicyRequest(),
            parent='parent_value',
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            snapshot_schedule_policy_id='snapshot_schedule_policy_id_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.UpdateSnapshotSchedulePolicyRequest,
  dict,
])
def test_update_snapshot_schedule_policy(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        )
        response = client.update_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


def test_update_snapshot_schedule_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        client.update_snapshot_schedule_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateSnapshotSchedulePolicyRequest()


@pytest.mark.asyncio
async def test_update_snapshot_schedule_policy_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.UpdateSnapshotSchedulePolicyRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy(
            name='name_value',
            description='description_value',
        ))
        response = await client.update_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.UpdateSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.SnapshotSchedulePolicy)
    assert response.name == 'name_value'
    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_update_snapshot_schedule_policy_async_from_dict():
    await test_update_snapshot_schedule_policy_async(request_type=dict)


def test_update_snapshot_schedule_policy_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.UpdateSnapshotSchedulePolicyRequest()

    request.snapshot_schedule_policy.name = 'snapshot_schedule_policy.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        client.update_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'snapshot_schedule_policy.name=snapshot_schedule_policy.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_snapshot_schedule_policy_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.UpdateSnapshotSchedulePolicyRequest()

    request.snapshot_schedule_policy.name = 'snapshot_schedule_policy.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        await client.update_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'snapshot_schedule_policy.name=snapshot_schedule_policy.name/value',
    ) in kw['metadata']


def test_update_snapshot_schedule_policy_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_snapshot_schedule_policy(
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].snapshot_schedule_policy
        mock_val = baremetalsolution.SnapshotSchedulePolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_snapshot_schedule_policy_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_snapshot_schedule_policy(
            baremetalsolution.UpdateSnapshotSchedulePolicyRequest(),
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_snapshot_schedule_policy_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.SnapshotSchedulePolicy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.SnapshotSchedulePolicy())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_snapshot_schedule_policy(
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].snapshot_schedule_policy
        mock_val = baremetalsolution.SnapshotSchedulePolicy(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_snapshot_schedule_policy_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_snapshot_schedule_policy(
            baremetalsolution.UpdateSnapshotSchedulePolicyRequest(),
            snapshot_schedule_policy=baremetalsolution.SnapshotSchedulePolicy(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.DeleteSnapshotSchedulePolicyRequest,
  dict,
])
def test_delete_snapshot_schedule_policy(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_snapshot_schedule_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        client.delete_snapshot_schedule_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteSnapshotSchedulePolicyRequest()


@pytest.mark.asyncio
async def test_delete_snapshot_schedule_policy_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.DeleteSnapshotSchedulePolicyRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_snapshot_schedule_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteSnapshotSchedulePolicyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_snapshot_schedule_policy_async_from_dict():
    await test_delete_snapshot_schedule_policy_async(request_type=dict)


def test_delete_snapshot_schedule_policy_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.DeleteSnapshotSchedulePolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = None
        client.delete_snapshot_schedule_policy(request)

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
async def test_delete_snapshot_schedule_policy_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.DeleteSnapshotSchedulePolicyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_snapshot_schedule_policy(request)

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


def test_delete_snapshot_schedule_policy_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_snapshot_schedule_policy(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_snapshot_schedule_policy_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_snapshot_schedule_policy(
            baremetalsolution.DeleteSnapshotSchedulePolicyRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_snapshot_schedule_policy_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_snapshot_schedule_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_snapshot_schedule_policy(
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
async def test_delete_snapshot_schedule_policy_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_snapshot_schedule_policy(
            baremetalsolution.DeleteSnapshotSchedulePolicyRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.CreateVolumeSnapshotRequest,
  dict,
])
def test_create_volume_snapshot(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot(
            name='name_value',
            description='description_value',
            size_bytes=1089,
            storage_volume='storage_volume_value',
        )
        response = client.create_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.VolumeSnapshot)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.size_bytes == 1089
    assert response.storage_volume == 'storage_volume_value'


def test_create_volume_snapshot_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        client.create_volume_snapshot()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateVolumeSnapshotRequest()


@pytest.mark.asyncio
async def test_create_volume_snapshot_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.CreateVolumeSnapshotRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot(
            name='name_value',
            description='description_value',
            size_bytes=1089,
            storage_volume='storage_volume_value',
        ))
        response = await client.create_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.CreateVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.VolumeSnapshot)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.size_bytes == 1089
    assert response.storage_volume == 'storage_volume_value'


@pytest.mark.asyncio
async def test_create_volume_snapshot_async_from_dict():
    await test_create_volume_snapshot_async(request_type=dict)


def test_create_volume_snapshot_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.CreateVolumeSnapshotRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        call.return_value = baremetalsolution.VolumeSnapshot()
        client.create_volume_snapshot(request)

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
async def test_create_volume_snapshot_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.CreateVolumeSnapshotRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot())
        await client.create_volume_snapshot(request)

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


def test_create_volume_snapshot_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_volume_snapshot(
            parent='parent_value',
            volume_snapshot=baremetalsolution.VolumeSnapshot(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].volume_snapshot
        mock_val = baremetalsolution.VolumeSnapshot(name='name_value')
        assert arg == mock_val


def test_create_volume_snapshot_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_volume_snapshot(
            baremetalsolution.CreateVolumeSnapshotRequest(),
            parent='parent_value',
            volume_snapshot=baremetalsolution.VolumeSnapshot(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_volume_snapshot_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_volume_snapshot(
            parent='parent_value',
            volume_snapshot=baremetalsolution.VolumeSnapshot(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].volume_snapshot
        mock_val = baremetalsolution.VolumeSnapshot(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_volume_snapshot_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_volume_snapshot(
            baremetalsolution.CreateVolumeSnapshotRequest(),
            parent='parent_value',
            volume_snapshot=baremetalsolution.VolumeSnapshot(name='name_value'),
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.RestoreVolumeSnapshotRequest,
  dict,
])
def test_restore_volume_snapshot(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.restore_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.RestoreVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_restore_volume_snapshot_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        client.restore_volume_snapshot()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.RestoreVolumeSnapshotRequest()


@pytest.mark.asyncio
async def test_restore_volume_snapshot_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.RestoreVolumeSnapshotRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.restore_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.RestoreVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_restore_volume_snapshot_async_from_dict():
    await test_restore_volume_snapshot_async(request_type=dict)


def test_restore_volume_snapshot_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.RestoreVolumeSnapshotRequest()

    request.volume_snapshot = 'volume_snapshot/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.restore_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'volume_snapshot=volume_snapshot/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_restore_volume_snapshot_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.RestoreVolumeSnapshotRequest()

    request.volume_snapshot = 'volume_snapshot/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.restore_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'volume_snapshot=volume_snapshot/value',
    ) in kw['metadata']


def test_restore_volume_snapshot_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.restore_volume_snapshot(
            volume_snapshot='volume_snapshot_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].volume_snapshot
        mock_val = 'volume_snapshot_value'
        assert arg == mock_val


def test_restore_volume_snapshot_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.restore_volume_snapshot(
            baremetalsolution.RestoreVolumeSnapshotRequest(),
            volume_snapshot='volume_snapshot_value',
        )


@pytest.mark.asyncio
async def test_restore_volume_snapshot_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restore_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.restore_volume_snapshot(
            volume_snapshot='volume_snapshot_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].volume_snapshot
        mock_val = 'volume_snapshot_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_restore_volume_snapshot_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.restore_volume_snapshot(
            baremetalsolution.RestoreVolumeSnapshotRequest(),
            volume_snapshot='volume_snapshot_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.DeleteVolumeSnapshotRequest,
  dict,
])
def test_delete_volume_snapshot(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_volume_snapshot_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        client.delete_volume_snapshot()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteVolumeSnapshotRequest()


@pytest.mark.asyncio
async def test_delete_volume_snapshot_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.DeleteVolumeSnapshotRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.DeleteVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_volume_snapshot_async_from_dict():
    await test_delete_volume_snapshot_async(request_type=dict)


def test_delete_volume_snapshot_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.DeleteVolumeSnapshotRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        call.return_value = None
        client.delete_volume_snapshot(request)

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
async def test_delete_volume_snapshot_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.DeleteVolumeSnapshotRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_volume_snapshot(request)

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


def test_delete_volume_snapshot_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_volume_snapshot(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_delete_volume_snapshot_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_volume_snapshot(
            baremetalsolution.DeleteVolumeSnapshotRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_volume_snapshot_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_volume_snapshot(
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
async def test_delete_volume_snapshot_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_volume_snapshot(
            baremetalsolution.DeleteVolumeSnapshotRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetVolumeSnapshotRequest,
  dict,
])
def test_get_volume_snapshot(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot(
            name='name_value',
            description='description_value',
            size_bytes=1089,
            storage_volume='storage_volume_value',
        )
        response = client.get_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.VolumeSnapshot)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.size_bytes == 1089
    assert response.storage_volume == 'storage_volume_value'


def test_get_volume_snapshot_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        client.get_volume_snapshot()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeSnapshotRequest()


@pytest.mark.asyncio
async def test_get_volume_snapshot_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetVolumeSnapshotRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot(
            name='name_value',
            description='description_value',
            size_bytes=1089,
            storage_volume='storage_volume_value',
        ))
        response = await client.get_volume_snapshot(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetVolumeSnapshotRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.VolumeSnapshot)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.size_bytes == 1089
    assert response.storage_volume == 'storage_volume_value'


@pytest.mark.asyncio
async def test_get_volume_snapshot_async_from_dict():
    await test_get_volume_snapshot_async(request_type=dict)


def test_get_volume_snapshot_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetVolumeSnapshotRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        call.return_value = baremetalsolution.VolumeSnapshot()
        client.get_volume_snapshot(request)

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
async def test_get_volume_snapshot_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetVolumeSnapshotRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot())
        await client.get_volume_snapshot(request)

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


def test_get_volume_snapshot_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_volume_snapshot(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_volume_snapshot_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_volume_snapshot(
            baremetalsolution.GetVolumeSnapshotRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_volume_snapshot_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_volume_snapshot),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.VolumeSnapshot()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.VolumeSnapshot())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_volume_snapshot(
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
async def test_get_volume_snapshot_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_volume_snapshot(
            baremetalsolution.GetVolumeSnapshotRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListVolumeSnapshotsRequest,
  dict,
])
def test_list_volume_snapshots(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumeSnapshotsResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_volume_snapshots(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumeSnapshotsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVolumeSnapshotsPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_volume_snapshots_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        client.list_volume_snapshots()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumeSnapshotsRequest()


@pytest.mark.asyncio
async def test_list_volume_snapshots_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListVolumeSnapshotsRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumeSnapshotsResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_volume_snapshots(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListVolumeSnapshotsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVolumeSnapshotsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_volume_snapshots_async_from_dict():
    await test_list_volume_snapshots_async(request_type=dict)


def test_list_volume_snapshots_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListVolumeSnapshotsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        call.return_value = baremetalsolution.ListVolumeSnapshotsResponse()
        client.list_volume_snapshots(request)

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
async def test_list_volume_snapshots_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListVolumeSnapshotsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumeSnapshotsResponse())
        await client.list_volume_snapshots(request)

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


def test_list_volume_snapshots_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumeSnapshotsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_volume_snapshots(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_volume_snapshots_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_volume_snapshots(
            baremetalsolution.ListVolumeSnapshotsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_volume_snapshots_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListVolumeSnapshotsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListVolumeSnapshotsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_volume_snapshots(
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
async def test_list_volume_snapshots_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_volume_snapshots(
            baremetalsolution.ListVolumeSnapshotsRequest(),
            parent='parent_value',
        )


def test_list_volume_snapshots_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
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
        pager = client.list_volume_snapshots(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.VolumeSnapshot)
                   for i in results)
def test_list_volume_snapshots_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_volume_snapshots(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_volume_snapshots_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_volume_snapshots(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.VolumeSnapshot)
                for i in responses)


@pytest.mark.asyncio
async def test_list_volume_snapshots_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_volume_snapshots),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[],
                next_page_token='def',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListVolumeSnapshotsResponse(
                volume_snapshots=[
                    baremetalsolution.VolumeSnapshot(),
                    baremetalsolution.VolumeSnapshot(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_volume_snapshots(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  baremetalsolution.GetLunRequest,
  dict,
])
def test_get_lun(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Lun(
            name='name_value',
            state=baremetalsolution.Lun.State.CREATING,
            size_gb=739,
            multiprotocol_type=baremetalsolution.Lun.MultiprotocolType.LINUX,
            storage_volume='storage_volume_value',
            shareable=True,
            boot_lun=True,
            storage_type=baremetalsolution.Lun.StorageType.SSD,
            wwid='wwid_value',
        )
        response = client.get_lun(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetLunRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Lun)
    assert response.name == 'name_value'
    assert response.state == baremetalsolution.Lun.State.CREATING
    assert response.size_gb == 739
    assert response.multiprotocol_type == baremetalsolution.Lun.MultiprotocolType.LINUX
    assert response.storage_volume == 'storage_volume_value'
    assert response.shareable is True
    assert response.boot_lun is True
    assert response.storage_type == baremetalsolution.Lun.StorageType.SSD
    assert response.wwid == 'wwid_value'


def test_get_lun_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        client.get_lun()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetLunRequest()


@pytest.mark.asyncio
async def test_get_lun_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.GetLunRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Lun(
            name='name_value',
            state=baremetalsolution.Lun.State.CREATING,
            size_gb=739,
            multiprotocol_type=baremetalsolution.Lun.MultiprotocolType.LINUX,
            storage_volume='storage_volume_value',
            shareable=True,
            boot_lun=True,
            storage_type=baremetalsolution.Lun.StorageType.SSD,
            wwid='wwid_value',
        ))
        response = await client.get_lun(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.GetLunRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, baremetalsolution.Lun)
    assert response.name == 'name_value'
    assert response.state == baremetalsolution.Lun.State.CREATING
    assert response.size_gb == 739
    assert response.multiprotocol_type == baremetalsolution.Lun.MultiprotocolType.LINUX
    assert response.storage_volume == 'storage_volume_value'
    assert response.shareable is True
    assert response.boot_lun is True
    assert response.storage_type == baremetalsolution.Lun.StorageType.SSD
    assert response.wwid == 'wwid_value'


@pytest.mark.asyncio
async def test_get_lun_async_from_dict():
    await test_get_lun_async(request_type=dict)


def test_get_lun_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetLunRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        call.return_value = baremetalsolution.Lun()
        client.get_lun(request)

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
async def test_get_lun_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.GetLunRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Lun())
        await client.get_lun(request)

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


def test_get_lun_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Lun()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_lun(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_lun_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_lun(
            baremetalsolution.GetLunRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_lun_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_lun),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.Lun()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.Lun())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_lun(
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
async def test_get_lun_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_lun(
            baremetalsolution.GetLunRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  baremetalsolution.ListLunsRequest,
  dict,
])
def test_list_luns(request_type, transport: str = 'grpc'):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListLunsResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_luns(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListLunsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListLunsPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_luns_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        client.list_luns()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListLunsRequest()


@pytest.mark.asyncio
async def test_list_luns_async(transport: str = 'grpc_asyncio', request_type=baremetalsolution.ListLunsRequest):
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListLunsResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_luns(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == baremetalsolution.ListLunsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListLunsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_luns_async_from_dict():
    await test_list_luns_async(request_type=dict)


def test_list_luns_field_headers():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListLunsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        call.return_value = baremetalsolution.ListLunsResponse()
        client.list_luns(request)

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
async def test_list_luns_field_headers_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = baremetalsolution.ListLunsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListLunsResponse())
        await client.list_luns(request)

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


def test_list_luns_flattened():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListLunsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_luns(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_luns_flattened_error():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_luns(
            baremetalsolution.ListLunsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_luns_flattened_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = baremetalsolution.ListLunsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(baremetalsolution.ListLunsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_luns(
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
async def test_list_luns_flattened_error_async():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_luns(
            baremetalsolution.ListLunsRequest(),
            parent='parent_value',
        )


def test_list_luns_pager(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[],
                next_page_token='def',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
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
        pager = client.list_luns(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, baremetalsolution.Lun)
                   for i in results)
def test_list_luns_pages(transport_name: str = "grpc"):
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[],
                next_page_token='def',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_luns(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_luns_async_pager():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[],
                next_page_token='def',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_luns(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, baremetalsolution.Lun)
                for i in responses)


@pytest.mark.asyncio
async def test_list_luns_async_pages():
    client = BareMetalSolutionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_luns),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
                next_page_token='abc',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[],
                next_page_token='def',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                ],
                next_page_token='ghi',
            ),
            baremetalsolution.ListLunsResponse(
                luns=[
                    baremetalsolution.Lun(),
                    baremetalsolution.Lun(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_luns(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.BareMetalSolutionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BareMetalSolutionClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.BareMetalSolutionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BareMetalSolutionClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.BareMetalSolutionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BareMetalSolutionClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BareMetalSolutionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = BareMetalSolutionClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BareMetalSolutionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.BareMetalSolutionGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.BareMetalSolutionGrpcTransport,
    transports.BareMetalSolutionGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.BareMetalSolutionGrpcTransport,
    )

def test_bare_metal_solution_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.BareMetalSolutionTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_bare_metal_solution_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.baremetalsolution_v2.services.bare_metal_solution.transports.BareMetalSolutionTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.BareMetalSolutionTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'list_instances',
        'get_instance',
        'reset_instance',
        'list_volumes',
        'get_volume',
        'update_volume',
        'list_networks',
        'get_network',
        'list_snapshot_schedule_policies',
        'get_snapshot_schedule_policy',
        'create_snapshot_schedule_policy',
        'update_snapshot_schedule_policy',
        'delete_snapshot_schedule_policy',
        'create_volume_snapshot',
        'restore_volume_snapshot',
        'delete_volume_snapshot',
        'get_volume_snapshot',
        'list_volume_snapshots',
        'get_lun',
        'list_luns',
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


def test_bare_metal_solution_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.baremetalsolution_v2.services.bare_metal_solution.transports.BareMetalSolutionTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BareMetalSolutionTransport(
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


def test_bare_metal_solution_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.cloud.baremetalsolution_v2.services.bare_metal_solution.transports.BareMetalSolutionTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BareMetalSolutionTransport()
        adc.assert_called_once()


def test_bare_metal_solution_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        BareMetalSolutionClient()
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
        transports.BareMetalSolutionGrpcTransport,
        transports.BareMetalSolutionGrpcAsyncIOTransport,
    ],
)
def test_bare_metal_solution_transport_auth_adc(transport_class):
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
        (transports.BareMetalSolutionGrpcTransport, grpc_helpers),
        (transports.BareMetalSolutionGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_bare_metal_solution_transport_create_channel(transport_class, grpc_helpers):
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
            "baremetalsolution.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="baremetalsolution.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.BareMetalSolutionGrpcTransport, transports.BareMetalSolutionGrpcAsyncIOTransport])
def test_bare_metal_solution_grpc_transport_client_cert_source_for_mtls(
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


def test_bare_metal_solution_host_no_port():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='baremetalsolution.googleapis.com'),
    )
    assert client.transport._host == 'baremetalsolution.googleapis.com:443'


def test_bare_metal_solution_host_with_port():
    client = BareMetalSolutionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='baremetalsolution.googleapis.com:8000'),
    )
    assert client.transport._host == 'baremetalsolution.googleapis.com:8000'

def test_bare_metal_solution_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BareMetalSolutionGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_bare_metal_solution_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BareMetalSolutionGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.BareMetalSolutionGrpcTransport, transports.BareMetalSolutionGrpcAsyncIOTransport])
def test_bare_metal_solution_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.BareMetalSolutionGrpcTransport, transports.BareMetalSolutionGrpcAsyncIOTransport])
def test_bare_metal_solution_transport_channel_mtls_with_adc(
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


def test_bare_metal_solution_grpc_lro_client():
    client = BareMetalSolutionClient(
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


def test_bare_metal_solution_grpc_lro_async_client():
    client = BareMetalSolutionAsyncClient(
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


def test_instance_path():
    project = "squid"
    location = "clam"
    instance = "whelk"
    expected = "projects/{project}/locations/{location}/instances/{instance}".format(project=project, location=location, instance=instance, )
    actual = BareMetalSolutionClient.instance_path(project, location, instance)
    assert expected == actual


def test_parse_instance_path():
    expected = {
        "project": "octopus",
        "location": "oyster",
        "instance": "nudibranch",
    }
    path = BareMetalSolutionClient.instance_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_instance_path(path)
    assert expected == actual

def test_lun_path():
    project = "cuttlefish"
    location = "mussel"
    volume = "winkle"
    lun = "nautilus"
    expected = "projects/{project}/locations/{location}/volumes/{volume}/luns/{lun}".format(project=project, location=location, volume=volume, lun=lun, )
    actual = BareMetalSolutionClient.lun_path(project, location, volume, lun)
    assert expected == actual


def test_parse_lun_path():
    expected = {
        "project": "scallop",
        "location": "abalone",
        "volume": "squid",
        "lun": "clam",
    }
    path = BareMetalSolutionClient.lun_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_lun_path(path)
    assert expected == actual

def test_network_path():
    project = "whelk"
    location = "octopus"
    network = "oyster"
    expected = "projects/{project}/locations/{location}/networks/{network}".format(project=project, location=location, network=network, )
    actual = BareMetalSolutionClient.network_path(project, location, network)
    assert expected == actual


def test_parse_network_path():
    expected = {
        "project": "nudibranch",
        "location": "cuttlefish",
        "network": "mussel",
    }
    path = BareMetalSolutionClient.network_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_network_path(path)
    assert expected == actual

def test_snapshot_schedule_policy_path():
    project = "winkle"
    location = "nautilus"
    snapshot_schedule_policy = "scallop"
    expected = "projects/{project}/locations/{location}/snapshotSchedulePolicies/{snapshot_schedule_policy}".format(project=project, location=location, snapshot_schedule_policy=snapshot_schedule_policy, )
    actual = BareMetalSolutionClient.snapshot_schedule_policy_path(project, location, snapshot_schedule_policy)
    assert expected == actual


def test_parse_snapshot_schedule_policy_path():
    expected = {
        "project": "abalone",
        "location": "squid",
        "snapshot_schedule_policy": "clam",
    }
    path = BareMetalSolutionClient.snapshot_schedule_policy_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_snapshot_schedule_policy_path(path)
    assert expected == actual

def test_volume_path():
    project = "whelk"
    location = "octopus"
    volume = "oyster"
    expected = "projects/{project}/locations/{location}/volumes/{volume}".format(project=project, location=location, volume=volume, )
    actual = BareMetalSolutionClient.volume_path(project, location, volume)
    assert expected == actual


def test_parse_volume_path():
    expected = {
        "project": "nudibranch",
        "location": "cuttlefish",
        "volume": "mussel",
    }
    path = BareMetalSolutionClient.volume_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_volume_path(path)
    assert expected == actual

def test_volume_snapshot_path():
    project = "winkle"
    location = "nautilus"
    volume = "scallop"
    snapshot = "abalone"
    expected = "projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}".format(project=project, location=location, volume=volume, snapshot=snapshot, )
    actual = BareMetalSolutionClient.volume_snapshot_path(project, location, volume, snapshot)
    assert expected == actual


def test_parse_volume_snapshot_path():
    expected = {
        "project": "squid",
        "location": "clam",
        "volume": "whelk",
        "snapshot": "octopus",
    }
    path = BareMetalSolutionClient.volume_snapshot_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_volume_snapshot_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = BareMetalSolutionClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nudibranch",
    }
    path = BareMetalSolutionClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"
    expected = "folders/{folder}".format(folder=folder, )
    actual = BareMetalSolutionClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "mussel",
    }
    path = BareMetalSolutionClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = BareMetalSolutionClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nautilus",
    }
    path = BareMetalSolutionClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"
    expected = "projects/{project}".format(project=project, )
    actual = BareMetalSolutionClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "abalone",
    }
    path = BareMetalSolutionClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = BareMetalSolutionClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "whelk",
        "location": "octopus",
    }
    path = BareMetalSolutionClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = BareMetalSolutionClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.BareMetalSolutionTransport, '_prep_wrapped_messages') as prep:
        client = BareMetalSolutionClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.BareMetalSolutionTransport, '_prep_wrapped_messages') as prep:
        transport_class = BareMetalSolutionClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = BareMetalSolutionAsyncClient(
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
        client = BareMetalSolutionClient(
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
        client = BareMetalSolutionClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
