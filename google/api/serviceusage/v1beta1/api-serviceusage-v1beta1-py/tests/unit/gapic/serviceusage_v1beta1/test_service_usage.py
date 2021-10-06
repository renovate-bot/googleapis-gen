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


from google.api.serviceusage_v1beta1.services.service_usage import ServiceUsageAsyncClient
from google.api.serviceusage_v1beta1.services.service_usage import ServiceUsageClient
from google.api.serviceusage_v1beta1.services.service_usage import pagers
from google.api.serviceusage_v1beta1.services.service_usage import transports
from google.api.serviceusage_v1beta1.services.service_usage.transports.base import _GOOGLE_AUTH_VERSION
from google.api.serviceusage_v1beta1.types import resources
from google.api.serviceusage_v1beta1.types import serviceusage
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
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
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

    assert ServiceUsageClient._get_default_mtls_endpoint(None) is None
    assert ServiceUsageClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert ServiceUsageClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert ServiceUsageClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert ServiceUsageClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert ServiceUsageClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    ServiceUsageClient,
    ServiceUsageAsyncClient,
])
def test_service_usage_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'serviceusage.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.ServiceUsageGrpcTransport, "grpc"),
    (transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_service_usage_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    ServiceUsageClient,
    ServiceUsageAsyncClient,
])
def test_service_usage_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'serviceusage.googleapis.com:443'


def test_service_usage_client_get_transport_class():
    transport = ServiceUsageClient.get_transport_class()
    available_transports = [
        transports.ServiceUsageGrpcTransport,
    ]
    assert transport in available_transports

    transport = ServiceUsageClient.get_transport_class("grpc")
    assert transport == transports.ServiceUsageGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (ServiceUsageClient, transports.ServiceUsageGrpcTransport, "grpc"),
    (ServiceUsageAsyncClient, transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(ServiceUsageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ServiceUsageClient))
@mock.patch.object(ServiceUsageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ServiceUsageAsyncClient))
def test_service_usage_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(ServiceUsageClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(ServiceUsageClient, 'get_transport_class') as gtc:
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
    (ServiceUsageClient, transports.ServiceUsageGrpcTransport, "grpc", "true"),
    (ServiceUsageAsyncClient, transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (ServiceUsageClient, transports.ServiceUsageGrpcTransport, "grpc", "false"),
    (ServiceUsageAsyncClient, transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(ServiceUsageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ServiceUsageClient))
@mock.patch.object(ServiceUsageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ServiceUsageAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_service_usage_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (ServiceUsageClient, transports.ServiceUsageGrpcTransport, "grpc"),
    (ServiceUsageAsyncClient, transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_service_usage_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (ServiceUsageClient, transports.ServiceUsageGrpcTransport, "grpc"),
    (ServiceUsageAsyncClient, transports.ServiceUsageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_service_usage_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_service_usage_client_client_options_from_dict():
    with mock.patch('google.api.serviceusage_v1beta1.services.service_usage.transports.ServiceUsageGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = ServiceUsageClient(
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


def test_enable_service(transport: str = 'grpc', request_type=serviceusage.EnableServiceRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.enable_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.EnableServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_enable_service_from_dict():
    test_enable_service(request_type=dict)


def test_enable_service_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service),
            '__call__') as call:
        client.enable_service()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.EnableServiceRequest()


@pytest.mark.asyncio
async def test_enable_service_async(transport: str = 'grpc_asyncio', request_type=serviceusage.EnableServiceRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.enable_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.EnableServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_enable_service_async_from_dict():
    await test_enable_service_async(request_type=dict)


def test_enable_service_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.EnableServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.enable_service(request)

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
async def test_enable_service_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.EnableServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.enable_service),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.enable_service(request)

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


def test_disable_service(transport: str = 'grpc', request_type=serviceusage.DisableServiceRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.disable_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DisableServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_disable_service_from_dict():
    test_disable_service(request_type=dict)


def test_disable_service_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service),
            '__call__') as call:
        client.disable_service()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DisableServiceRequest()


@pytest.mark.asyncio
async def test_disable_service_async(transport: str = 'grpc_asyncio', request_type=serviceusage.DisableServiceRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.disable_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DisableServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_disable_service_async_from_dict():
    await test_disable_service_async(request_type=dict)


def test_disable_service_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DisableServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.disable_service(request)

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
async def test_disable_service_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DisableServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.disable_service),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.disable_service(request)

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


def test_get_service(transport: str = 'grpc', request_type=serviceusage.GetServiceRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = resources.Service(
            name='name_value',
            parent='parent_value',
            state=resources.State.DISABLED,
        )
        response = client.get_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.Service)
    assert response.name == 'name_value'
    assert response.parent == 'parent_value'
    assert response.state == resources.State.DISABLED


def test_get_service_from_dict():
    test_get_service(request_type=dict)


def test_get_service_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service),
            '__call__') as call:
        client.get_service()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetServiceRequest()


@pytest.mark.asyncio
async def test_get_service_async(transport: str = 'grpc_asyncio', request_type=serviceusage.GetServiceRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(resources.Service(
            name='name_value',
            parent='parent_value',
            state=resources.State.DISABLED,
        ))
        response = await client.get_service(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetServiceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.Service)
    assert response.name == 'name_value'
    assert response.parent == 'parent_value'
    assert response.state == resources.State.DISABLED


@pytest.mark.asyncio
async def test_get_service_async_from_dict():
    await test_get_service_async(request_type=dict)


def test_get_service_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service),
            '__call__') as call:
        call.return_value = resources.Service()
        client.get_service(request)

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
async def test_get_service_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetServiceRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(resources.Service())
        await client.get_service(request)

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


def test_list_services(transport: str = 'grpc', request_type=serviceusage.ListServicesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = serviceusage.ListServicesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServicesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_services_from_dict():
    test_list_services(request_type=dict)


def test_list_services_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        client.list_services()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListServicesRequest()


@pytest.mark.asyncio
async def test_list_services_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ListServicesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListServicesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListServicesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_services_async_from_dict():
    await test_list_services_async(request_type=dict)


def test_list_services_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListServicesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        call.return_value = serviceusage.ListServicesResponse()
        client.list_services(request)

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
async def test_list_services_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListServicesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListServicesResponse())
        await client.list_services(request)

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


def test_list_services_pager():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                    resources.Service(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListServicesResponse(
                services=[],
                next_page_token='def',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
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
        pager = client.list_services(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, resources.Service)
                   for i in results)

def test_list_services_pages():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                    resources.Service(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListServicesResponse(
                services=[],
                next_page_token='def',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_services(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_services_async_pager():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                    resources.Service(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListServicesResponse(
                services=[],
                next_page_token='def',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_services(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, resources.Service)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_services_async_pages():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_services),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                    resources.Service(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListServicesResponse(
                services=[],
                next_page_token='def',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListServicesResponse(
                services=[
                    resources.Service(),
                    resources.Service(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_services(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_batch_enable_services(transport: str = 'grpc', request_type=serviceusage.BatchEnableServicesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_enable_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.batch_enable_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.BatchEnableServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_batch_enable_services_from_dict():
    test_batch_enable_services(request_type=dict)


def test_batch_enable_services_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_enable_services),
            '__call__') as call:
        client.batch_enable_services()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.BatchEnableServicesRequest()


@pytest.mark.asyncio
async def test_batch_enable_services_async(transport: str = 'grpc_asyncio', request_type=serviceusage.BatchEnableServicesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_enable_services),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.batch_enable_services(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.BatchEnableServicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_batch_enable_services_async_from_dict():
    await test_batch_enable_services_async(request_type=dict)


def test_batch_enable_services_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.BatchEnableServicesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_enable_services),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.batch_enable_services(request)

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
async def test_batch_enable_services_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.BatchEnableServicesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_enable_services),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.batch_enable_services(request)

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


def test_list_consumer_quota_metrics(transport: str = 'grpc', request_type=serviceusage.ListConsumerQuotaMetricsRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = serviceusage.ListConsumerQuotaMetricsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_consumer_quota_metrics(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerQuotaMetricsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListConsumerQuotaMetricsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_consumer_quota_metrics_from_dict():
    test_list_consumer_quota_metrics(request_type=dict)


def test_list_consumer_quota_metrics_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        client.list_consumer_quota_metrics()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerQuotaMetricsRequest()


@pytest.mark.asyncio
async def test_list_consumer_quota_metrics_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ListConsumerQuotaMetricsRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListConsumerQuotaMetricsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_consumer_quota_metrics(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerQuotaMetricsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListConsumerQuotaMetricsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_consumer_quota_metrics_async_from_dict():
    await test_list_consumer_quota_metrics_async(request_type=dict)


def test_list_consumer_quota_metrics_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListConsumerQuotaMetricsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        call.return_value = serviceusage.ListConsumerQuotaMetricsResponse()
        client.list_consumer_quota_metrics(request)

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
async def test_list_consumer_quota_metrics_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListConsumerQuotaMetricsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListConsumerQuotaMetricsResponse())
        await client.list_consumer_quota_metrics(request)

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


def test_list_consumer_quota_metrics_pager():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
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
        pager = client.list_consumer_quota_metrics(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, resources.ConsumerQuotaMetric)
                   for i in results)

def test_list_consumer_quota_metrics_pages():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_consumer_quota_metrics(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_consumer_quota_metrics_async_pager():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_consumer_quota_metrics(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, resources.ConsumerQuotaMetric)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_consumer_quota_metrics_async_pages():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_quota_metrics),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerQuotaMetricsResponse(
                metrics=[
                    resources.ConsumerQuotaMetric(),
                    resources.ConsumerQuotaMetric(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_consumer_quota_metrics(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_consumer_quota_metric(transport: str = 'grpc', request_type=serviceusage.GetConsumerQuotaMetricRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_metric),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = resources.ConsumerQuotaMetric(
            name='name_value',
            metric='metric_value',
            display_name='display_name_value',
            unit='unit_value',
        )
        response = client.get_consumer_quota_metric(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaMetricRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.ConsumerQuotaMetric)
    assert response.name == 'name_value'
    assert response.metric == 'metric_value'
    assert response.display_name == 'display_name_value'
    assert response.unit == 'unit_value'


def test_get_consumer_quota_metric_from_dict():
    test_get_consumer_quota_metric(request_type=dict)


def test_get_consumer_quota_metric_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_metric),
            '__call__') as call:
        client.get_consumer_quota_metric()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaMetricRequest()


@pytest.mark.asyncio
async def test_get_consumer_quota_metric_async(transport: str = 'grpc_asyncio', request_type=serviceusage.GetConsumerQuotaMetricRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_metric),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(resources.ConsumerQuotaMetric(
            name='name_value',
            metric='metric_value',
            display_name='display_name_value',
            unit='unit_value',
        ))
        response = await client.get_consumer_quota_metric(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaMetricRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.ConsumerQuotaMetric)
    assert response.name == 'name_value'
    assert response.metric == 'metric_value'
    assert response.display_name == 'display_name_value'
    assert response.unit == 'unit_value'


@pytest.mark.asyncio
async def test_get_consumer_quota_metric_async_from_dict():
    await test_get_consumer_quota_metric_async(request_type=dict)


def test_get_consumer_quota_metric_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetConsumerQuotaMetricRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_metric),
            '__call__') as call:
        call.return_value = resources.ConsumerQuotaMetric()
        client.get_consumer_quota_metric(request)

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
async def test_get_consumer_quota_metric_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetConsumerQuotaMetricRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_metric),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(resources.ConsumerQuotaMetric())
        await client.get_consumer_quota_metric(request)

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


def test_get_consumer_quota_limit(transport: str = 'grpc', request_type=serviceusage.GetConsumerQuotaLimitRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_limit),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = resources.ConsumerQuotaLimit(
            name='name_value',
            metric='metric_value',
            unit='unit_value',
            is_precise=True,
            allows_admin_overrides=True,
        )
        response = client.get_consumer_quota_limit(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaLimitRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.ConsumerQuotaLimit)
    assert response.name == 'name_value'
    assert response.metric == 'metric_value'
    assert response.unit == 'unit_value'
    assert response.is_precise is True
    assert response.allows_admin_overrides is True


def test_get_consumer_quota_limit_from_dict():
    test_get_consumer_quota_limit(request_type=dict)


def test_get_consumer_quota_limit_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_limit),
            '__call__') as call:
        client.get_consumer_quota_limit()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaLimitRequest()


@pytest.mark.asyncio
async def test_get_consumer_quota_limit_async(transport: str = 'grpc_asyncio', request_type=serviceusage.GetConsumerQuotaLimitRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_limit),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(resources.ConsumerQuotaLimit(
            name='name_value',
            metric='metric_value',
            unit='unit_value',
            is_precise=True,
            allows_admin_overrides=True,
        ))
        response = await client.get_consumer_quota_limit(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GetConsumerQuotaLimitRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, resources.ConsumerQuotaLimit)
    assert response.name == 'name_value'
    assert response.metric == 'metric_value'
    assert response.unit == 'unit_value'
    assert response.is_precise is True
    assert response.allows_admin_overrides is True


@pytest.mark.asyncio
async def test_get_consumer_quota_limit_async_from_dict():
    await test_get_consumer_quota_limit_async(request_type=dict)


def test_get_consumer_quota_limit_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetConsumerQuotaLimitRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_limit),
            '__call__') as call:
        call.return_value = resources.ConsumerQuotaLimit()
        client.get_consumer_quota_limit(request)

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
async def test_get_consumer_quota_limit_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GetConsumerQuotaLimitRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_consumer_quota_limit),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(resources.ConsumerQuotaLimit())
        await client.get_consumer_quota_limit(request)

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


def test_create_admin_override(transport: str = 'grpc', request_type=serviceusage.CreateAdminOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_admin_override_from_dict():
    test_create_admin_override(request_type=dict)


def test_create_admin_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_admin_override),
            '__call__') as call:
        client.create_admin_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateAdminOverrideRequest()


@pytest.mark.asyncio
async def test_create_admin_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.CreateAdminOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_admin_override_async_from_dict():
    await test_create_admin_override_async(request_type=dict)


def test_create_admin_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.CreateAdminOverrideRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_admin_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_admin_override(request)

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
async def test_create_admin_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.CreateAdminOverrideRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_admin_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_admin_override(request)

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


def test_update_admin_override(transport: str = 'grpc', request_type=serviceusage.UpdateAdminOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_admin_override_from_dict():
    test_update_admin_override(request_type=dict)


def test_update_admin_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_admin_override),
            '__call__') as call:
        client.update_admin_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateAdminOverrideRequest()


@pytest.mark.asyncio
async def test_update_admin_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.UpdateAdminOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_admin_override_async_from_dict():
    await test_update_admin_override_async(request_type=dict)


def test_update_admin_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.UpdateAdminOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_admin_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_admin_override(request)

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
async def test_update_admin_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.UpdateAdminOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_admin_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_admin_override(request)

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


def test_delete_admin_override(transport: str = 'grpc', request_type=serviceusage.DeleteAdminOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_admin_override_from_dict():
    test_delete_admin_override(request_type=dict)


def test_delete_admin_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_admin_override),
            '__call__') as call:
        client.delete_admin_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteAdminOverrideRequest()


@pytest.mark.asyncio
async def test_delete_admin_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.DeleteAdminOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_admin_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_admin_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteAdminOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_admin_override_async_from_dict():
    await test_delete_admin_override_async(request_type=dict)


def test_delete_admin_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DeleteAdminOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_admin_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_admin_override(request)

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
async def test_delete_admin_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DeleteAdminOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_admin_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_admin_override(request)

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


def test_list_admin_overrides(transport: str = 'grpc', request_type=serviceusage.ListAdminOverridesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = serviceusage.ListAdminOverridesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_admin_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListAdminOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAdminOverridesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_admin_overrides_from_dict():
    test_list_admin_overrides(request_type=dict)


def test_list_admin_overrides_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        client.list_admin_overrides()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListAdminOverridesRequest()


@pytest.mark.asyncio
async def test_list_admin_overrides_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ListAdminOverridesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListAdminOverridesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_admin_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListAdminOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAdminOverridesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_admin_overrides_async_from_dict():
    await test_list_admin_overrides_async(request_type=dict)


def test_list_admin_overrides_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListAdminOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        call.return_value = serviceusage.ListAdminOverridesResponse()
        client.list_admin_overrides(request)

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
async def test_list_admin_overrides_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListAdminOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListAdminOverridesResponse())
        await client.list_admin_overrides(request)

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


def test_list_admin_overrides_pager():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
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
        pager = client.list_admin_overrides(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, resources.QuotaOverride)
                   for i in results)

def test_list_admin_overrides_pages():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_admin_overrides(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_admin_overrides_async_pager():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_admin_overrides(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, resources.QuotaOverride)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_admin_overrides_async_pages():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_admin_overrides),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListAdminOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_admin_overrides(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_import_admin_overrides(transport: str = 'grpc', request_type=serviceusage.ImportAdminOverridesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_admin_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.import_admin_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportAdminOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_import_admin_overrides_from_dict():
    test_import_admin_overrides(request_type=dict)


def test_import_admin_overrides_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_admin_overrides),
            '__call__') as call:
        client.import_admin_overrides()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportAdminOverridesRequest()


@pytest.mark.asyncio
async def test_import_admin_overrides_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ImportAdminOverridesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_admin_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.import_admin_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportAdminOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_import_admin_overrides_async_from_dict():
    await test_import_admin_overrides_async(request_type=dict)


def test_import_admin_overrides_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ImportAdminOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_admin_overrides),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.import_admin_overrides(request)

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
async def test_import_admin_overrides_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ImportAdminOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_admin_overrides),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.import_admin_overrides(request)

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


def test_create_consumer_override(transport: str = 'grpc', request_type=serviceusage.CreateConsumerOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_consumer_override_from_dict():
    test_create_consumer_override(request_type=dict)


def test_create_consumer_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_consumer_override),
            '__call__') as call:
        client.create_consumer_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateConsumerOverrideRequest()


@pytest.mark.asyncio
async def test_create_consumer_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.CreateConsumerOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.create_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.CreateConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_consumer_override_async_from_dict():
    await test_create_consumer_override_async(request_type=dict)


def test_create_consumer_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.CreateConsumerOverrideRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_consumer_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_consumer_override(request)

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
async def test_create_consumer_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.CreateConsumerOverrideRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_consumer_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.create_consumer_override(request)

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


def test_update_consumer_override(transport: str = 'grpc', request_type=serviceusage.UpdateConsumerOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.update_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_consumer_override_from_dict():
    test_update_consumer_override(request_type=dict)


def test_update_consumer_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_consumer_override),
            '__call__') as call:
        client.update_consumer_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateConsumerOverrideRequest()


@pytest.mark.asyncio
async def test_update_consumer_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.UpdateConsumerOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.update_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.UpdateConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_consumer_override_async_from_dict():
    await test_update_consumer_override_async(request_type=dict)


def test_update_consumer_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.UpdateConsumerOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_consumer_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.update_consumer_override(request)

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
async def test_update_consumer_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.UpdateConsumerOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_consumer_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.update_consumer_override(request)

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


def test_delete_consumer_override(transport: str = 'grpc', request_type=serviceusage.DeleteConsumerOverrideRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.delete_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_consumer_override_from_dict():
    test_delete_consumer_override(request_type=dict)


def test_delete_consumer_override_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_consumer_override),
            '__call__') as call:
        client.delete_consumer_override()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteConsumerOverrideRequest()


@pytest.mark.asyncio
async def test_delete_consumer_override_async(transport: str = 'grpc_asyncio', request_type=serviceusage.DeleteConsumerOverrideRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_consumer_override),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.delete_consumer_override(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.DeleteConsumerOverrideRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_consumer_override_async_from_dict():
    await test_delete_consumer_override_async(request_type=dict)


def test_delete_consumer_override_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DeleteConsumerOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_consumer_override),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.delete_consumer_override(request)

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
async def test_delete_consumer_override_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.DeleteConsumerOverrideRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_consumer_override),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.delete_consumer_override(request)

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


def test_list_consumer_overrides(transport: str = 'grpc', request_type=serviceusage.ListConsumerOverridesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = serviceusage.ListConsumerOverridesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_consumer_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListConsumerOverridesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_consumer_overrides_from_dict():
    test_list_consumer_overrides(request_type=dict)


def test_list_consumer_overrides_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        client.list_consumer_overrides()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerOverridesRequest()


@pytest.mark.asyncio
async def test_list_consumer_overrides_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ListConsumerOverridesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListConsumerOverridesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_consumer_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ListConsumerOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListConsumerOverridesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_consumer_overrides_async_from_dict():
    await test_list_consumer_overrides_async(request_type=dict)


def test_list_consumer_overrides_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListConsumerOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        call.return_value = serviceusage.ListConsumerOverridesResponse()
        client.list_consumer_overrides(request)

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
async def test_list_consumer_overrides_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ListConsumerOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(serviceusage.ListConsumerOverridesResponse())
        await client.list_consumer_overrides(request)

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


def test_list_consumer_overrides_pager():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
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
        pager = client.list_consumer_overrides(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, resources.QuotaOverride)
                   for i in results)

def test_list_consumer_overrides_pages():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_consumer_overrides(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_consumer_overrides_async_pager():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_consumer_overrides(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, resources.QuotaOverride)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_consumer_overrides_async_pages():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_consumer_overrides),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
                next_page_token='abc',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[],
                next_page_token='def',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                ],
                next_page_token='ghi',
            ),
            serviceusage.ListConsumerOverridesResponse(
                overrides=[
                    resources.QuotaOverride(),
                    resources.QuotaOverride(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_consumer_overrides(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_import_consumer_overrides(transport: str = 'grpc', request_type=serviceusage.ImportConsumerOverridesRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_consumer_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.import_consumer_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportConsumerOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_import_consumer_overrides_from_dict():
    test_import_consumer_overrides(request_type=dict)


def test_import_consumer_overrides_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_consumer_overrides),
            '__call__') as call:
        client.import_consumer_overrides()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportConsumerOverridesRequest()


@pytest.mark.asyncio
async def test_import_consumer_overrides_async(transport: str = 'grpc_asyncio', request_type=serviceusage.ImportConsumerOverridesRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_consumer_overrides),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.import_consumer_overrides(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.ImportConsumerOverridesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_import_consumer_overrides_async_from_dict():
    await test_import_consumer_overrides_async(request_type=dict)


def test_import_consumer_overrides_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ImportConsumerOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_consumer_overrides),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.import_consumer_overrides(request)

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
async def test_import_consumer_overrides_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.ImportConsumerOverridesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.import_consumer_overrides),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.import_consumer_overrides(request)

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


def test_generate_service_identity(transport: str = 'grpc', request_type=serviceusage.GenerateServiceIdentityRequest):
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_service_identity),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.generate_service_identity(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GenerateServiceIdentityRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_generate_service_identity_from_dict():
    test_generate_service_identity(request_type=dict)


def test_generate_service_identity_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_service_identity),
            '__call__') as call:
        client.generate_service_identity()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GenerateServiceIdentityRequest()


@pytest.mark.asyncio
async def test_generate_service_identity_async(transport: str = 'grpc_asyncio', request_type=serviceusage.GenerateServiceIdentityRequest):
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_service_identity),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        response = await client.generate_service_identity(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == serviceusage.GenerateServiceIdentityRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_generate_service_identity_async_from_dict():
    await test_generate_service_identity_async(request_type=dict)


def test_generate_service_identity_field_headers():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GenerateServiceIdentityRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_service_identity),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.generate_service_identity(request)

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
async def test_generate_service_identity_field_headers_async():
    client = ServiceUsageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = serviceusage.GenerateServiceIdentityRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_service_identity),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))
        await client.generate_service_identity(request)

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


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.ServiceUsageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = ServiceUsageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.ServiceUsageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = ServiceUsageClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.ServiceUsageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = ServiceUsageClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ServiceUsageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = ServiceUsageClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ServiceUsageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.ServiceUsageGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.ServiceUsageGrpcTransport,
    transports.ServiceUsageGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.ServiceUsageGrpcTransport,
    )

def test_service_usage_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.ServiceUsageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_service_usage_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.api.serviceusage_v1beta1.services.service_usage.transports.ServiceUsageTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.ServiceUsageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'enable_service',
        'disable_service',
        'get_service',
        'list_services',
        'batch_enable_services',
        'list_consumer_quota_metrics',
        'get_consumer_quota_metric',
        'get_consumer_quota_limit',
        'create_admin_override',
        'update_admin_override',
        'delete_admin_override',
        'list_admin_overrides',
        'import_admin_overrides',
        'create_consumer_override',
        'update_consumer_override',
        'delete_consumer_override',
        'list_consumer_overrides',
        'import_consumer_overrides',
        'generate_service_identity',
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


@requires_google_auth_gte_1_25_0
def test_service_usage_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.api.serviceusage_v1beta1.services.service_usage.transports.ServiceUsageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.ServiceUsageTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/service.management',
),
            quota_project_id="octopus",
        )


@requires_google_auth_lt_1_25_0
def test_service_usage_base_transport_with_credentials_file_old_google_auth():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.api.serviceusage_v1beta1.services.service_usage.transports.ServiceUsageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.ServiceUsageTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/service.management',
            ),
            quota_project_id="octopus",
        )


def test_service_usage_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.api.serviceusage_v1beta1.services.service_usage.transports.ServiceUsageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.ServiceUsageTransport()
        adc.assert_called_once()


@requires_google_auth_gte_1_25_0
def test_service_usage_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        ServiceUsageClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/service.management',
),
            quota_project_id=None,
        )


@requires_google_auth_lt_1_25_0
def test_service_usage_auth_adc_old_google_auth():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        ServiceUsageClient()
        adc.assert_called_once_with(
            scopes=(                'https://www.googleapis.com/auth/cloud-platform',                'https://www.googleapis.com/auth/cloud-platform.read-only',                'https://www.googleapis.com/auth/service.management',),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.ServiceUsageGrpcTransport,
        transports.ServiceUsageGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_gte_1_25_0
def test_service_usage_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/cloud-platform',                'https://www.googleapis.com/auth/cloud-platform.read-only',                'https://www.googleapis.com/auth/service.management',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.ServiceUsageGrpcTransport,
        transports.ServiceUsageGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_lt_1_25_0
def test_service_usage_transport_auth_adc_old_google_auth(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/service.management',
),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.ServiceUsageGrpcTransport, grpc_helpers),
        (transports.ServiceUsageGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_service_usage_transport_create_channel(transport_class, grpc_helpers):
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
            "serviceusage.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
                'https://www.googleapis.com/auth/cloud-platform.read-only',
                'https://www.googleapis.com/auth/service.management',
),
            scopes=["1", "2"],
            default_host="serviceusage.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.ServiceUsageGrpcTransport, transports.ServiceUsageGrpcAsyncIOTransport])
def test_service_usage_grpc_transport_client_cert_source_for_mtls(
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


def test_service_usage_host_no_port():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='serviceusage.googleapis.com'),
    )
    assert client.transport._host == 'serviceusage.googleapis.com:443'


def test_service_usage_host_with_port():
    client = ServiceUsageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='serviceusage.googleapis.com:8000'),
    )
    assert client.transport._host == 'serviceusage.googleapis.com:8000'

def test_service_usage_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.ServiceUsageGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_service_usage_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.ServiceUsageGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.ServiceUsageGrpcTransport, transports.ServiceUsageGrpcAsyncIOTransport])
def test_service_usage_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.ServiceUsageGrpcTransport, transports.ServiceUsageGrpcAsyncIOTransport])
def test_service_usage_transport_channel_mtls_with_adc(
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


def test_service_usage_grpc_lro_client():
    client = ServiceUsageClient(
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


def test_service_usage_grpc_lro_async_client():
    client = ServiceUsageAsyncClient(
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


def test_common_billing_account_path():
    billing_account = "squid"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = ServiceUsageClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "clam",
    }
    path = ServiceUsageClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = ServiceUsageClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "whelk"
    expected = "folders/{folder}".format(folder=folder, )
    actual = ServiceUsageClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "octopus",
    }
    path = ServiceUsageClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = ServiceUsageClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "oyster"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = ServiceUsageClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nudibranch",
    }
    path = ServiceUsageClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = ServiceUsageClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "cuttlefish"
    expected = "projects/{project}".format(project=project, )
    actual = ServiceUsageClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "mussel",
    }
    path = ServiceUsageClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = ServiceUsageClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "winkle"
    location = "nautilus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = ServiceUsageClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "scallop",
        "location": "abalone",
    }
    path = ServiceUsageClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = ServiceUsageClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.ServiceUsageTransport, '_prep_wrapped_messages') as prep:
        client = ServiceUsageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.ServiceUsageTransport, '_prep_wrapped_messages') as prep:
        transport_class = ServiceUsageClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = ServiceUsageAsyncClient(
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
        client = ServiceUsageClient(
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
        client = ServiceUsageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
