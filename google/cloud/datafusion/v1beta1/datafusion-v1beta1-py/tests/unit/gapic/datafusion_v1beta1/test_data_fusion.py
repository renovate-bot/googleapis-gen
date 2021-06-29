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
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.cloud.datafusion_v1beta1.services.data_fusion import DataFusionAsyncClient
from google.cloud.datafusion_v1beta1.services.data_fusion import DataFusionClient
from google.cloud.datafusion_v1beta1.services.data_fusion import pagers
from google.cloud.datafusion_v1beta1.services.data_fusion import transports
from google.cloud.datafusion_v1beta1.services.data_fusion.transports.base import _GOOGLE_AUTH_VERSION
from google.cloud.datafusion_v1beta1.types import v1beta1
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
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

    assert DataFusionClient._get_default_mtls_endpoint(None) is None
    assert DataFusionClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert DataFusionClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert DataFusionClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert DataFusionClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert DataFusionClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    DataFusionClient,
    DataFusionAsyncClient,
])
def test_data_fusion_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'datafusion.googleapis.com:443'


@pytest.mark.parametrize("client_class", [
    DataFusionClient,
    DataFusionAsyncClient,
])
def test_data_fusion_client_service_account_always_use_jwt(client_class):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        client = client_class(credentials=creds)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.DataFusionGrpcTransport, "grpc"),
    (transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_data_fusion_client_service_account_always_use_jwt_true(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)


@pytest.mark.parametrize("client_class", [
    DataFusionClient,
    DataFusionAsyncClient,
])
def test_data_fusion_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'datafusion.googleapis.com:443'


def test_data_fusion_client_get_transport_class():
    transport = DataFusionClient.get_transport_class()
    available_transports = [
        transports.DataFusionGrpcTransport,
    ]
    assert transport in available_transports

    transport = DataFusionClient.get_transport_class("grpc")
    assert transport == transports.DataFusionGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (DataFusionClient, transports.DataFusionGrpcTransport, "grpc"),
    (DataFusionAsyncClient, transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(DataFusionClient, "DEFAULT_ENDPOINT", modify_default_endpoint(DataFusionClient))
@mock.patch.object(DataFusionAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(DataFusionAsyncClient))
def test_data_fusion_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(DataFusionClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(DataFusionClient, 'get_transport_class') as gtc:
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
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name,use_client_cert_env", [
    (DataFusionClient, transports.DataFusionGrpcTransport, "grpc", "true"),
    (DataFusionAsyncClient, transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (DataFusionClient, transports.DataFusionGrpcTransport, "grpc", "false"),
    (DataFusionAsyncClient, transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(DataFusionClient, "DEFAULT_ENDPOINT", modify_default_endpoint(DataFusionClient))
@mock.patch.object(DataFusionAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(DataFusionAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_data_fusion_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
                )


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (DataFusionClient, transports.DataFusionGrpcTransport, "grpc"),
    (DataFusionAsyncClient, transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_data_fusion_client_client_options_scopes(client_class, transport_class, transport_name):
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
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (DataFusionClient, transports.DataFusionGrpcTransport, "grpc"),
    (DataFusionAsyncClient, transports.DataFusionGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_data_fusion_client_client_options_credentials_file(client_class, transport_class, transport_name):
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
        )


def test_data_fusion_client_client_options_from_dict():
    with mock.patch('google.cloud.datafusion_v1beta1.services.data_fusion.transports.DataFusionGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = DataFusionClient(
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
        )


def test_list_available_versions(transport: str = 'grpc', request_type=v1beta1.ListAvailableVersionsRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListAvailableVersionsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_available_versions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListAvailableVersionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAvailableVersionsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_available_versions_from_dict():
    test_list_available_versions(request_type=dict)


def test_list_available_versions_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        client.list_available_versions()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListAvailableVersionsRequest()


@pytest.mark.asyncio
async def test_list_available_versions_async(transport: str = 'grpc_asyncio', request_type=v1beta1.ListAvailableVersionsRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListAvailableVersionsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_available_versions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListAvailableVersionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAvailableVersionsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_available_versions_async_from_dict():
    await test_list_available_versions_async(request_type=dict)


def test_list_available_versions_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListAvailableVersionsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        call.return_value = v1beta1.ListAvailableVersionsResponse()
        client.list_available_versions(request)

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
async def test_list_available_versions_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListAvailableVersionsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListAvailableVersionsResponse())
        await client.list_available_versions(request)

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


def test_list_available_versions_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListAvailableVersionsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_available_versions(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_list_available_versions_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_available_versions(
            v1beta1.ListAvailableVersionsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_available_versions_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListAvailableVersionsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListAvailableVersionsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_available_versions(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_available_versions_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_available_versions(
            v1beta1.ListAvailableVersionsRequest(),
            parent='parent_value',
        )


def test_list_available_versions_pager():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[],
                next_page_token='def',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
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
        pager = client.list_available_versions(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, v1beta1.Version)
                   for i in results)

def test_list_available_versions_pages():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[],
                next_page_token='def',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_available_versions(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_available_versions_async_pager():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[],
                next_page_token='def',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_available_versions(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, v1beta1.Version)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_available_versions_async_pages():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_available_versions),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[],
                next_page_token='def',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListAvailableVersionsResponse(
                available_versions=[
                    v1beta1.Version(),
                    v1beta1.Version(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_available_versions(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_list_instances(transport: str = 'grpc', request_type=v1beta1.ListInstancesRequest):
    client = DataFusionClient(
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
        call.return_value = v1beta1.ListInstancesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        )
        response = client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListInstancesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListInstancesPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


def test_list_instances_from_dict():
    test_list_instances(request_type=dict)


def test_list_instances_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
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
        assert args[0] == v1beta1.ListInstancesRequest()


@pytest.mark.asyncio
async def test_list_instances_async(transport: str = 'grpc_asyncio', request_type=v1beta1.ListInstancesRequest):
    client = DataFusionAsyncClient(
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
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListInstancesResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))
        response = await client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListInstancesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListInstancesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_instances_async_from_dict():
    await test_list_instances_async(request_type=dict)


def test_list_instances_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListInstancesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = v1beta1.ListInstancesResponse()
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
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListInstancesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListInstancesResponse())
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


def test_list_instances_pager():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
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
        assert all(isinstance(i, v1beta1.Instance)
                   for i in results)

def test_list_instances_pages():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_instances(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_instances_async_pager():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
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
        assert all(isinstance(i, v1beta1.Instance)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_instances_async_pages():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListInstancesResponse(
                instances=[],
                next_page_token='def',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListInstancesResponse(
                instances=[
                    v1beta1.Instance(),
                    v1beta1.Instance(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_instances(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_instance(transport: str = 'grpc', request_type=v1beta1.GetInstanceRequest):
    client = DataFusionClient(
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
        call.return_value = v1beta1.Instance(
            name='name_value',
            description='description_value',
            type_=v1beta1.Instance.Type.BASIC,
            enable_stackdriver_logging=True,
            enable_stackdriver_monitoring=True,
            private_instance=True,
            state=v1beta1.Instance.State.CREATING,
            state_message='state_message_value',
            service_endpoint='service_endpoint_value',
            zone='zone_value',
            version='version_value',
            service_account='service_account_value',
            display_name='display_name_value',
            api_endpoint='api_endpoint_value',
            gcs_bucket='gcs_bucket_value',
            p4_service_account='p4_service_account_value',
            tenant_project_id='tenant_project_id_value',
            dataproc_service_account='dataproc_service_account_value',
            enable_rbac=True,
        )
        response = client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.GetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.Instance)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.type_ == v1beta1.Instance.Type.BASIC
    assert response.enable_stackdriver_logging is True
    assert response.enable_stackdriver_monitoring is True
    assert response.private_instance is True
    assert response.state == v1beta1.Instance.State.CREATING
    assert response.state_message == 'state_message_value'
    assert response.service_endpoint == 'service_endpoint_value'
    assert response.zone == 'zone_value'
    assert response.version == 'version_value'
    assert response.service_account == 'service_account_value'
    assert response.display_name == 'display_name_value'
    assert response.api_endpoint == 'api_endpoint_value'
    assert response.gcs_bucket == 'gcs_bucket_value'
    assert response.p4_service_account == 'p4_service_account_value'
    assert response.tenant_project_id == 'tenant_project_id_value'
    assert response.dataproc_service_account == 'dataproc_service_account_value'
    assert response.enable_rbac is True


def test_get_instance_from_dict():
    test_get_instance(request_type=dict)


def test_get_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
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
        assert args[0] == v1beta1.GetInstanceRequest()


@pytest.mark.asyncio
async def test_get_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.GetInstanceRequest):
    client = DataFusionAsyncClient(
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
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.Instance(
            name='name_value',
            description='description_value',
            type_=v1beta1.Instance.Type.BASIC,
            enable_stackdriver_logging=True,
            enable_stackdriver_monitoring=True,
            private_instance=True,
            state=v1beta1.Instance.State.CREATING,
            state_message='state_message_value',
            service_endpoint='service_endpoint_value',
            zone='zone_value',
            version='version_value',
            service_account='service_account_value',
            display_name='display_name_value',
            api_endpoint='api_endpoint_value',
            gcs_bucket='gcs_bucket_value',
            p4_service_account='p4_service_account_value',
            tenant_project_id='tenant_project_id_value',
            dataproc_service_account='dataproc_service_account_value',
            enable_rbac=True,
        ))
        response = await client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.GetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.Instance)
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.type_ == v1beta1.Instance.Type.BASIC
    assert response.enable_stackdriver_logging is True
    assert response.enable_stackdriver_monitoring is True
    assert response.private_instance is True
    assert response.state == v1beta1.Instance.State.CREATING
    assert response.state_message == 'state_message_value'
    assert response.service_endpoint == 'service_endpoint_value'
    assert response.zone == 'zone_value'
    assert response.version == 'version_value'
    assert response.service_account == 'service_account_value'
    assert response.display_name == 'display_name_value'
    assert response.api_endpoint == 'api_endpoint_value'
    assert response.gcs_bucket == 'gcs_bucket_value'
    assert response.p4_service_account == 'p4_service_account_value'
    assert response.tenant_project_id == 'tenant_project_id_value'
    assert response.dataproc_service_account == 'dataproc_service_account_value'
    assert response.enable_rbac is True


@pytest.mark.asyncio
async def test_get_instance_async_from_dict():
    await test_get_instance_async(request_type=dict)


def test_get_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.GetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = v1beta1.Instance()
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
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.GetInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.Instance())
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


def test_create_instance(transport: str = 'grpc', request_type=v1beta1.CreateInstanceRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.CreateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_instance_from_dict():
    test_create_instance(request_type=dict)


def test_create_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        client.create_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.CreateInstanceRequest()


@pytest.mark.asyncio
async def test_create_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.CreateInstanceRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.CreateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_instance_async_from_dict():
    await test_create_instance_async(request_type=dict)


def test_create_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.CreateInstanceRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_instance(request)

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
async def test_create_instance_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.CreateInstanceRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_instance(request)

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


def test_create_instance_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_instance(
            parent='parent_value',
            instance=v1beta1.Instance(name='name_value'),
            instance_id='instance_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'
        assert args[0].instance == v1beta1.Instance(name='name_value')
        assert args[0].instance_id == 'instance_id_value'


def test_create_instance_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_instance(
            v1beta1.CreateInstanceRequest(),
            parent='parent_value',
            instance=v1beta1.Instance(name='name_value'),
            instance_id='instance_id_value',
        )


@pytest.mark.asyncio
async def test_create_instance_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_instance(
            parent='parent_value',
            instance=v1beta1.Instance(name='name_value'),
            instance_id='instance_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'
        assert args[0].instance == v1beta1.Instance(name='name_value')
        assert args[0].instance_id == 'instance_id_value'


@pytest.mark.asyncio
async def test_create_instance_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_instance(
            v1beta1.CreateInstanceRequest(),
            parent='parent_value',
            instance=v1beta1.Instance(name='name_value'),
            instance_id='instance_id_value',
        )


def test_delete_instance(transport: str = 'grpc', request_type=v1beta1.DeleteInstanceRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.DeleteInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_instance_from_dict():
    test_delete_instance(request_type=dict)


def test_delete_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        client.delete_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.DeleteInstanceRequest()


@pytest.mark.asyncio
async def test_delete_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.DeleteInstanceRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.DeleteInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_instance_async_from_dict():
    await test_delete_instance_async(request_type=dict)


def test_delete_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.DeleteInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_instance(request)

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
async def test_delete_instance_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.DeleteInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_instance(request)

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


def test_delete_instance_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_delete_instance_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_instance(
            v1beta1.DeleteInstanceRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_instance_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_instance_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_instance(
            v1beta1.DeleteInstanceRequest(),
            name='name_value',
        )


def test_update_instance(transport: str = 'grpc', request_type=v1beta1.UpdateInstanceRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpdateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_instance_from_dict():
    test_update_instance(request_type=dict)


def test_update_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        client.update_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpdateInstanceRequest()


@pytest.mark.asyncio
async def test_update_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.UpdateInstanceRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpdateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_instance_async_from_dict():
    await test_update_instance_async(request_type=dict)


def test_update_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.UpdateInstanceRequest()

    request.instance.name = 'instance.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'instance.name=instance.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_instance_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.UpdateInstanceRequest()

    request.instance.name = 'instance.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'instance.name=instance.name/value',
    ) in kw['metadata']


def test_update_instance_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_instance(
            instance=v1beta1.Instance(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].instance == v1beta1.Instance(name='name_value')
        assert args[0].update_mask == field_mask_pb2.FieldMask(paths=['paths_value'])


def test_update_instance_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_instance(
            v1beta1.UpdateInstanceRequest(),
            instance=v1beta1.Instance(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_instance_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_instance(
            instance=v1beta1.Instance(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].instance == v1beta1.Instance(name='name_value')
        assert args[0].update_mask == field_mask_pb2.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_update_instance_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_instance(
            v1beta1.UpdateInstanceRequest(),
            instance=v1beta1.Instance(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_restart_instance(transport: str = 'grpc', request_type=v1beta1.RestartInstanceRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restart_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.restart_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RestartInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_restart_instance_from_dict():
    test_restart_instance(request_type=dict)


def test_restart_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restart_instance),
            '__call__') as call:
        client.restart_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RestartInstanceRequest()


@pytest.mark.asyncio
async def test_restart_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.RestartInstanceRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restart_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.restart_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RestartInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_restart_instance_async_from_dict():
    await test_restart_instance_async(request_type=dict)


def test_restart_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RestartInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restart_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.restart_instance(request)

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
async def test_restart_instance_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RestartInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.restart_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.restart_instance(request)

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


def test_upgrade_instance(transport: str = 'grpc', request_type=v1beta1.UpgradeInstanceRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upgrade_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.upgrade_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpgradeInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_upgrade_instance_from_dict():
    test_upgrade_instance(request_type=dict)


def test_upgrade_instance_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upgrade_instance),
            '__call__') as call:
        client.upgrade_instance()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpgradeInstanceRequest()


@pytest.mark.asyncio
async def test_upgrade_instance_async(transport: str = 'grpc_asyncio', request_type=v1beta1.UpgradeInstanceRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upgrade_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.upgrade_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.UpgradeInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_upgrade_instance_async_from_dict():
    await test_upgrade_instance_async(request_type=dict)


def test_upgrade_instance_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.UpgradeInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upgrade_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.upgrade_instance(request)

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
async def test_upgrade_instance_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.UpgradeInstanceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.upgrade_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.upgrade_instance(request)

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


def test_remove_iam_policy(transport: str = 'grpc', request_type=v1beta1.RemoveIamPolicyRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.RemoveIamPolicyResponse(
        )
        response = client.remove_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.RemoveIamPolicyResponse)


def test_remove_iam_policy_from_dict():
    test_remove_iam_policy(request_type=dict)


def test_remove_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_iam_policy),
            '__call__') as call:
        client.remove_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveIamPolicyRequest()


@pytest.mark.asyncio
async def test_remove_iam_policy_async(transport: str = 'grpc_asyncio', request_type=v1beta1.RemoveIamPolicyRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.RemoveIamPolicyResponse(
        ))
        response = await client.remove_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.RemoveIamPolicyResponse)


@pytest.mark.asyncio
async def test_remove_iam_policy_async_from_dict():
    await test_remove_iam_policy_async(request_type=dict)


def test_remove_iam_policy_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RemoveIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_iam_policy),
            '__call__') as call:
        call.return_value = v1beta1.RemoveIamPolicyResponse()
        client.remove_iam_policy(request)

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
async def test_remove_iam_policy_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RemoveIamPolicyRequest()

    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_iam_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.RemoveIamPolicyResponse())
        await client.remove_iam_policy(request)

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


def test_list_namespaces(transport: str = 'grpc', request_type=v1beta1.ListNamespacesRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListNamespacesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_namespaces(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListNamespacesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListNamespacesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_namespaces_from_dict():
    test_list_namespaces(request_type=dict)


def test_list_namespaces_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        client.list_namespaces()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListNamespacesRequest()


@pytest.mark.asyncio
async def test_list_namespaces_async(transport: str = 'grpc_asyncio', request_type=v1beta1.ListNamespacesRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListNamespacesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_namespaces(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListNamespacesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListNamespacesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_namespaces_async_from_dict():
    await test_list_namespaces_async(request_type=dict)


def test_list_namespaces_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListNamespacesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        call.return_value = v1beta1.ListNamespacesResponse()
        client.list_namespaces(request)

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
async def test_list_namespaces_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListNamespacesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListNamespacesResponse())
        await client.list_namespaces(request)

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


def test_list_namespaces_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListNamespacesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_namespaces(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_list_namespaces_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_namespaces(
            v1beta1.ListNamespacesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_namespaces_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListNamespacesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListNamespacesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_namespaces(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_namespaces_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_namespaces(
            v1beta1.ListNamespacesRequest(),
            parent='parent_value',
        )


def test_list_namespaces_pager():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[],
                next_page_token='def',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
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
        pager = client.list_namespaces(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, v1beta1.Namespace)
                   for i in results)

def test_list_namespaces_pages():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[],
                next_page_token='def',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_namespaces(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_namespaces_async_pager():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[],
                next_page_token='def',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_namespaces(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, v1beta1.Namespace)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_namespaces_async_pages():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_namespaces),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[],
                next_page_token='def',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListNamespacesResponse(
                namespaces=[
                    v1beta1.Namespace(),
                    v1beta1.Namespace(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_namespaces(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_add_dns_peering(transport: str = 'grpc', request_type=v1beta1.AddDnsPeeringRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.AddDnsPeeringResponse(
        )
        response = client.add_dns_peering(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.AddDnsPeeringRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.AddDnsPeeringResponse)


def test_add_dns_peering_from_dict():
    test_add_dns_peering(request_type=dict)


def test_add_dns_peering_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        client.add_dns_peering()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.AddDnsPeeringRequest()


@pytest.mark.asyncio
async def test_add_dns_peering_async(transport: str = 'grpc_asyncio', request_type=v1beta1.AddDnsPeeringRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.AddDnsPeeringResponse(
        ))
        response = await client.add_dns_peering(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.AddDnsPeeringRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.AddDnsPeeringResponse)


@pytest.mark.asyncio
async def test_add_dns_peering_async_from_dict():
    await test_add_dns_peering_async(request_type=dict)


def test_add_dns_peering_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.AddDnsPeeringRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        call.return_value = v1beta1.AddDnsPeeringResponse()
        client.add_dns_peering(request)

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
async def test_add_dns_peering_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.AddDnsPeeringRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.AddDnsPeeringResponse())
        await client.add_dns_peering(request)

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


def test_add_dns_peering_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.AddDnsPeeringResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.add_dns_peering(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_add_dns_peering_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.add_dns_peering(
            v1beta1.AddDnsPeeringRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_add_dns_peering_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.AddDnsPeeringResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.AddDnsPeeringResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.add_dns_peering(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_add_dns_peering_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.add_dns_peering(
            v1beta1.AddDnsPeeringRequest(),
            parent='parent_value',
        )


def test_remove_dns_peering(transport: str = 'grpc', request_type=v1beta1.RemoveDnsPeeringRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.RemoveDnsPeeringResponse(
        )
        response = client.remove_dns_peering(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveDnsPeeringRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.RemoveDnsPeeringResponse)


def test_remove_dns_peering_from_dict():
    test_remove_dns_peering(request_type=dict)


def test_remove_dns_peering_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        client.remove_dns_peering()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveDnsPeeringRequest()


@pytest.mark.asyncio
async def test_remove_dns_peering_async(transport: str = 'grpc_asyncio', request_type=v1beta1.RemoveDnsPeeringRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.RemoveDnsPeeringResponse(
        ))
        response = await client.remove_dns_peering(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.RemoveDnsPeeringRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, v1beta1.RemoveDnsPeeringResponse)


@pytest.mark.asyncio
async def test_remove_dns_peering_async_from_dict():
    await test_remove_dns_peering_async(request_type=dict)


def test_remove_dns_peering_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RemoveDnsPeeringRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        call.return_value = v1beta1.RemoveDnsPeeringResponse()
        client.remove_dns_peering(request)

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
async def test_remove_dns_peering_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.RemoveDnsPeeringRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.RemoveDnsPeeringResponse())
        await client.remove_dns_peering(request)

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


def test_remove_dns_peering_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.RemoveDnsPeeringResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.remove_dns_peering(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_remove_dns_peering_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.remove_dns_peering(
            v1beta1.RemoveDnsPeeringRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_remove_dns_peering_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.remove_dns_peering),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.RemoveDnsPeeringResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.RemoveDnsPeeringResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.remove_dns_peering(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_remove_dns_peering_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.remove_dns_peering(
            v1beta1.RemoveDnsPeeringRequest(),
            parent='parent_value',
        )


def test_list_dns_peerings(transport: str = 'grpc', request_type=v1beta1.ListDnsPeeringsRequest):
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListDnsPeeringsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_dns_peerings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListDnsPeeringsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListDnsPeeringsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_dns_peerings_from_dict():
    test_list_dns_peerings(request_type=dict)


def test_list_dns_peerings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        client.list_dns_peerings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListDnsPeeringsRequest()


@pytest.mark.asyncio
async def test_list_dns_peerings_async(transport: str = 'grpc_asyncio', request_type=v1beta1.ListDnsPeeringsRequest):
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListDnsPeeringsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_dns_peerings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == v1beta1.ListDnsPeeringsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListDnsPeeringsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_dns_peerings_async_from_dict():
    await test_list_dns_peerings_async(request_type=dict)


def test_list_dns_peerings_field_headers():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListDnsPeeringsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        call.return_value = v1beta1.ListDnsPeeringsResponse()
        client.list_dns_peerings(request)

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
async def test_list_dns_peerings_field_headers_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = v1beta1.ListDnsPeeringsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListDnsPeeringsResponse())
        await client.list_dns_peerings(request)

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


def test_list_dns_peerings_flattened():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListDnsPeeringsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_dns_peerings(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_list_dns_peerings_flattened_error():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_dns_peerings(
            v1beta1.ListDnsPeeringsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_dns_peerings_flattened_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = v1beta1.ListDnsPeeringsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(v1beta1.ListDnsPeeringsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_dns_peerings(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_dns_peerings_flattened_error_async():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_dns_peerings(
            v1beta1.ListDnsPeeringsRequest(),
            parent='parent_value',
        )


def test_list_dns_peerings_pager():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[],
                next_page_token='def',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
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
        pager = client.list_dns_peerings(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, v1beta1.DnsPeering)
                   for i in results)

def test_list_dns_peerings_pages():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[],
                next_page_token='def',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_dns_peerings(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_dns_peerings_async_pager():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[],
                next_page_token='def',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_dns_peerings(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, v1beta1.DnsPeering)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_dns_peerings_async_pages():
    client = DataFusionAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_dns_peerings),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
                next_page_token='abc',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[],
                next_page_token='def',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                ],
                next_page_token='ghi',
            ),
            v1beta1.ListDnsPeeringsResponse(
                dns_peerings=[
                    v1beta1.DnsPeering(),
                    v1beta1.DnsPeering(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_dns_peerings(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.DataFusionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = DataFusionClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.DataFusionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = DataFusionClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.DataFusionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = DataFusionClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.DataFusionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = DataFusionClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.DataFusionGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.DataFusionGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.DataFusionGrpcTransport,
    transports.DataFusionGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.DataFusionGrpcTransport,
    )

def test_data_fusion_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.DataFusionTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_data_fusion_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.datafusion_v1beta1.services.data_fusion.transports.DataFusionTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.DataFusionTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'list_available_versions',
        'list_instances',
        'get_instance',
        'create_instance',
        'delete_instance',
        'update_instance',
        'restart_instance',
        'upgrade_instance',
        'remove_iam_policy',
        'list_namespaces',
        'add_dns_peering',
        'remove_dns_peering',
        'list_dns_peerings',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


@requires_google_auth_gte_1_25_0
def test_data_fusion_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.datafusion_v1beta1.services.data_fusion.transports.DataFusionTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.DataFusionTransport(
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
def test_data_fusion_base_transport_with_credentials_file_old_google_auth():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.datafusion_v1beta1.services.data_fusion.transports.DataFusionTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.DataFusionTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            ),
            quota_project_id="octopus",
        )


def test_data_fusion_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.cloud.datafusion_v1beta1.services.data_fusion.transports.DataFusionTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.DataFusionTransport()
        adc.assert_called_once()


@requires_google_auth_gte_1_25_0
def test_data_fusion_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        DataFusionClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id=None,
        )


@requires_google_auth_lt_1_25_0
def test_data_fusion_auth_adc_old_google_auth():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        DataFusionClient()
        adc.assert_called_once_with(
            scopes=(                'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.DataFusionGrpcTransport,
        transports.DataFusionGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_gte_1_25_0
def test_data_fusion_transport_auth_adc(transport_class):
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
        transports.DataFusionGrpcTransport,
        transports.DataFusionGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_lt_1_25_0
def test_data_fusion_transport_auth_adc_old_google_auth(transport_class):
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
        (transports.DataFusionGrpcTransport, grpc_helpers),
        (transports.DataFusionGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_data_fusion_transport_create_channel(transport_class, grpc_helpers):
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
            "datafusion.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="datafusion.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.DataFusionGrpcTransport, transports.DataFusionGrpcAsyncIOTransport])
def test_data_fusion_grpc_transport_client_cert_source_for_mtls(
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


def test_data_fusion_host_no_port():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='datafusion.googleapis.com'),
    )
    assert client.transport._host == 'datafusion.googleapis.com:443'


def test_data_fusion_host_with_port():
    client = DataFusionClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='datafusion.googleapis.com:8000'),
    )
    assert client.transport._host == 'datafusion.googleapis.com:8000'

def test_data_fusion_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.DataFusionGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_data_fusion_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.DataFusionGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.DataFusionGrpcTransport, transports.DataFusionGrpcAsyncIOTransport])
def test_data_fusion_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.DataFusionGrpcTransport, transports.DataFusionGrpcAsyncIOTransport])
def test_data_fusion_transport_channel_mtls_with_adc(
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


def test_data_fusion_grpc_lro_client():
    client = DataFusionClient(
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


def test_data_fusion_grpc_lro_async_client():
    client = DataFusionAsyncClient(
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
    actual = DataFusionClient.instance_path(project, location, instance)
    assert expected == actual


def test_parse_instance_path():
    expected = {
        "project": "octopus",
        "location": "oyster",
        "instance": "nudibranch",
    }
    path = DataFusionClient.instance_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_instance_path(path)
    assert expected == actual

def test_namespace_path():
    project = "cuttlefish"
    location = "mussel"
    instance = "winkle"
    namespace = "nautilus"
    expected = "projects/{project}/locations/{location}/instances/{instance}/namespaces/{namespace}".format(project=project, location=location, instance=instance, namespace=namespace, )
    actual = DataFusionClient.namespace_path(project, location, instance, namespace)
    assert expected == actual


def test_parse_namespace_path():
    expected = {
        "project": "scallop",
        "location": "abalone",
        "instance": "squid",
        "namespace": "clam",
    }
    path = DataFusionClient.namespace_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_namespace_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = DataFusionClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "octopus",
    }
    path = DataFusionClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"
    expected = "folders/{folder}".format(folder=folder, )
    actual = DataFusionClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nudibranch",
    }
    path = DataFusionClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = DataFusionClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "mussel",
    }
    path = DataFusionClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"
    expected = "projects/{project}".format(project=project, )
    actual = DataFusionClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nautilus",
    }
    path = DataFusionClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = DataFusionClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "squid",
        "location": "clam",
    }
    path = DataFusionClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = DataFusionClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.DataFusionTransport, '_prep_wrapped_messages') as prep:
        client = DataFusionClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.DataFusionTransport, '_prep_wrapped_messages') as prep:
        transport_class = DataFusionClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
