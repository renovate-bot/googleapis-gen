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
from google.example.library_v1.services.library_service import LibraryServiceAsyncClient
from google.example.library_v1.services.library_service import LibraryServiceClient
from google.example.library_v1.services.library_service import pagers
from google.example.library_v1.services.library_service import transports
from google.example.library_v1.services.library_service.transports.base import _API_CORE_VERSION
from google.example.library_v1.services.library_service.transports.base import _GOOGLE_AUTH_VERSION
from google.example.library_v1.types import library
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
import google.auth


# TODO(busunkim): Once google-api-core >= 1.26.0 is required:
# - Delete all the api-core and auth "less than" test cases
# - Delete these pytest markers (Make the "greater than or equal to" tests the default).
requires_google_auth_lt_1_25_0 = pytest.mark.skipif(
    packaging.version.parse(_GOOGLE_AUTH_VERSION) >= packaging.version.parse("1.25.0"),
    reason="This test requires google-auth < 1.25.0",
)
requires_google_auth_gte_1_25_0 = pytest.mark.skipif(
    packaging.version.parse(_GOOGLE_AUTH_VERSION) < packaging.version.parse("1.25.0"),
    reason="This test requires google-auth >= 1.25.0",
)

requires_api_core_lt_1_26_0 = pytest.mark.skipif(
    packaging.version.parse(_API_CORE_VERSION) >= packaging.version.parse("1.26.0"),
    reason="This test requires google-api-core < 1.26.0",
)

requires_api_core_gte_1_26_0 = pytest.mark.skipif(
    packaging.version.parse(_API_CORE_VERSION) < packaging.version.parse("1.26.0"),
    reason="This test requires google-api-core >= 1.26.0",
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

    assert LibraryServiceClient._get_default_mtls_endpoint(None) is None
    assert LibraryServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert LibraryServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert LibraryServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert LibraryServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert LibraryServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    LibraryServiceClient,
    LibraryServiceAsyncClient,
])
def test_library_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'library-example.googleapis.com:443'


@pytest.mark.parametrize("client_class", [
    LibraryServiceClient,
    LibraryServiceAsyncClient,
])
def test_library_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'library-example.googleapis.com:443'


def test_library_service_client_get_transport_class():
    transport = LibraryServiceClient.get_transport_class()
    available_transports = [
        transports.LibraryServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = LibraryServiceClient.get_transport_class("grpc")
    assert transport == transports.LibraryServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (LibraryServiceClient, transports.LibraryServiceGrpcTransport, "grpc"),
    (LibraryServiceAsyncClient, transports.LibraryServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(LibraryServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(LibraryServiceClient))
@mock.patch.object(LibraryServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(LibraryServiceAsyncClient))
def test_library_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(LibraryServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(LibraryServiceClient, 'get_transport_class') as gtc:
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
    (LibraryServiceClient, transports.LibraryServiceGrpcTransport, "grpc", "true"),
    (LibraryServiceAsyncClient, transports.LibraryServiceGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (LibraryServiceClient, transports.LibraryServiceGrpcTransport, "grpc", "false"),
    (LibraryServiceAsyncClient, transports.LibraryServiceGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(LibraryServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(LibraryServiceClient))
@mock.patch.object(LibraryServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(LibraryServiceAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_library_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (LibraryServiceClient, transports.LibraryServiceGrpcTransport, "grpc"),
    (LibraryServiceAsyncClient, transports.LibraryServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_library_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (LibraryServiceClient, transports.LibraryServiceGrpcTransport, "grpc"),
    (LibraryServiceAsyncClient, transports.LibraryServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_library_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_library_service_client_client_options_from_dict():
    with mock.patch('google.example.library_v1.services.library_service.transports.LibraryServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = LibraryServiceClient(
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


def test_create_shelf(transport: str = 'grpc', request_type=library.CreateShelfRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf(
            name='name_value',
            theme='theme_value',
        )
        response = client.create_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateShelfRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


def test_create_shelf_from_dict():
    test_create_shelf(request_type=dict)


def test_create_shelf_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_shelf),
            '__call__') as call:
        client.create_shelf()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateShelfRequest()


@pytest.mark.asyncio
async def test_create_shelf_async(transport: str = 'grpc_asyncio', request_type=library.CreateShelfRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf(
            name='name_value',
            theme='theme_value',
        ))
        response = await client.create_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateShelfRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


@pytest.mark.asyncio
async def test_create_shelf_async_from_dict():
    await test_create_shelf_async(request_type=dict)


def test_create_shelf_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_shelf(
            shelf=library.Shelf(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].shelf == library.Shelf(name='name_value')


def test_create_shelf_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_shelf(
            library.CreateShelfRequest(),
            shelf=library.Shelf(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_shelf_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_shelf(
            shelf=library.Shelf(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].shelf == library.Shelf(name='name_value')


@pytest.mark.asyncio
async def test_create_shelf_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_shelf(
            library.CreateShelfRequest(),
            shelf=library.Shelf(name='name_value'),
        )


def test_get_shelf(transport: str = 'grpc', request_type=library.GetShelfRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf(
            name='name_value',
            theme='theme_value',
        )
        response = client.get_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetShelfRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


def test_get_shelf_from_dict():
    test_get_shelf(request_type=dict)


def test_get_shelf_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        client.get_shelf()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetShelfRequest()


@pytest.mark.asyncio
async def test_get_shelf_async(transport: str = 'grpc_asyncio', request_type=library.GetShelfRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf(
            name='name_value',
            theme='theme_value',
        ))
        response = await client.get_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetShelfRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


@pytest.mark.asyncio
async def test_get_shelf_async_from_dict():
    await test_get_shelf_async(request_type=dict)


def test_get_shelf_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.GetShelfRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        call.return_value = library.Shelf()
        client.get_shelf(request)

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
async def test_get_shelf_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.GetShelfRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf())
        await client.get_shelf(request)

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


def test_get_shelf_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_shelf(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_get_shelf_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_shelf(
            library.GetShelfRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_shelf_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_shelf(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_shelf_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_shelf(
            library.GetShelfRequest(),
            name='name_value',
        )


def test_list_shelves(transport: str = 'grpc', request_type=library.ListShelvesRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.ListShelvesResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_shelves(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListShelvesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListShelvesPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_shelves_from_dict():
    test_list_shelves(request_type=dict)


def test_list_shelves_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__') as call:
        client.list_shelves()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListShelvesRequest()


@pytest.mark.asyncio
async def test_list_shelves_async(transport: str = 'grpc_asyncio', request_type=library.ListShelvesRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.ListShelvesResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_shelves(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListShelvesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListShelvesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_shelves_async_from_dict():
    await test_list_shelves_async(request_type=dict)


def test_list_shelves_pager():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                    library.Shelf(),
                ],
                next_page_token='abc',
            ),
            library.ListShelvesResponse(
                shelves=[],
                next_page_token='def',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                ],
                next_page_token='ghi',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_shelves(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, library.Shelf)
                   for i in results)

def test_list_shelves_pages():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                    library.Shelf(),
                ],
                next_page_token='abc',
            ),
            library.ListShelvesResponse(
                shelves=[],
                next_page_token='def',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                ],
                next_page_token='ghi',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_shelves(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_shelves_async_pager():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                    library.Shelf(),
                ],
                next_page_token='abc',
            ),
            library.ListShelvesResponse(
                shelves=[],
                next_page_token='def',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                ],
                next_page_token='ghi',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_shelves(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, library.Shelf)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_shelves_async_pages():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_shelves),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                    library.Shelf(),
                ],
                next_page_token='abc',
            ),
            library.ListShelvesResponse(
                shelves=[],
                next_page_token='def',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                ],
                next_page_token='ghi',
            ),
            library.ListShelvesResponse(
                shelves=[
                    library.Shelf(),
                    library.Shelf(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_shelves(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_delete_shelf(transport: str = 'grpc', request_type=library.DeleteShelfRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteShelfRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_shelf_from_dict():
    test_delete_shelf(request_type=dict)


def test_delete_shelf_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        client.delete_shelf()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteShelfRequest()


@pytest.mark.asyncio
async def test_delete_shelf_async(transport: str = 'grpc_asyncio', request_type=library.DeleteShelfRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_shelf(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteShelfRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_shelf_async_from_dict():
    await test_delete_shelf_async(request_type=dict)


def test_delete_shelf_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.DeleteShelfRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        call.return_value = None
        client.delete_shelf(request)

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
async def test_delete_shelf_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.DeleteShelfRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_shelf(request)

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


def test_delete_shelf_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_shelf(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_delete_shelf_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_shelf(
            library.DeleteShelfRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_shelf_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_shelf),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_shelf(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_shelf_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_shelf(
            library.DeleteShelfRequest(),
            name='name_value',
        )


def test_merge_shelves(transport: str = 'grpc', request_type=library.MergeShelvesRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf(
            name='name_value',
            theme='theme_value',
        )
        response = client.merge_shelves(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MergeShelvesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


def test_merge_shelves_from_dict():
    test_merge_shelves(request_type=dict)


def test_merge_shelves_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        client.merge_shelves()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MergeShelvesRequest()


@pytest.mark.asyncio
async def test_merge_shelves_async(transport: str = 'grpc_asyncio', request_type=library.MergeShelvesRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf(
            name='name_value',
            theme='theme_value',
        ))
        response = await client.merge_shelves(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MergeShelvesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Shelf)
    assert response.name == 'name_value'
    assert response.theme == 'theme_value'


@pytest.mark.asyncio
async def test_merge_shelves_async_from_dict():
    await test_merge_shelves_async(request_type=dict)


def test_merge_shelves_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.MergeShelvesRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        call.return_value = library.Shelf()
        client.merge_shelves(request)

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
async def test_merge_shelves_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.MergeShelvesRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf())
        await client.merge_shelves(request)

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


def test_merge_shelves_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.merge_shelves(
            name='name_value',
            other_shelf='other_shelf_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].other_shelf == 'other_shelf_value'


def test_merge_shelves_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.merge_shelves(
            library.MergeShelvesRequest(),
            name='name_value',
            other_shelf='other_shelf_value',
        )


@pytest.mark.asyncio
async def test_merge_shelves_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.merge_shelves),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Shelf()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Shelf())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.merge_shelves(
            name='name_value',
            other_shelf='other_shelf_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].other_shelf == 'other_shelf_value'


@pytest.mark.asyncio
async def test_merge_shelves_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.merge_shelves(
            library.MergeShelvesRequest(),
            name='name_value',
            other_shelf='other_shelf_value',
        )


def test_create_book(transport: str = 'grpc', request_type=library.CreateBookRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        )
        response = client.create_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


def test_create_book_from_dict():
    test_create_book(request_type=dict)


def test_create_book_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        client.create_book()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateBookRequest()


@pytest.mark.asyncio
async def test_create_book_async(transport: str = 'grpc_asyncio', request_type=library.CreateBookRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        ))
        response = await client.create_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.CreateBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


@pytest.mark.asyncio
async def test_create_book_async_from_dict():
    await test_create_book_async(request_type=dict)


def test_create_book_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.CreateBookRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        call.return_value = library.Book()
        client.create_book(request)

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
async def test_create_book_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.CreateBookRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        await client.create_book(request)

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


def test_create_book_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_book(
            parent='parent_value',
            book=library.Book(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'
        assert args[0].book == library.Book(name='name_value')


def test_create_book_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_book(
            library.CreateBookRequest(),
            parent='parent_value',
            book=library.Book(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_book_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_book(
            parent='parent_value',
            book=library.Book(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'
        assert args[0].book == library.Book(name='name_value')


@pytest.mark.asyncio
async def test_create_book_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_book(
            library.CreateBookRequest(),
            parent='parent_value',
            book=library.Book(name='name_value'),
        )


def test_get_book(transport: str = 'grpc', request_type=library.GetBookRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        )
        response = client.get_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


def test_get_book_from_dict():
    test_get_book(request_type=dict)


def test_get_book_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        client.get_book()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetBookRequest()


@pytest.mark.asyncio
async def test_get_book_async(transport: str = 'grpc_asyncio', request_type=library.GetBookRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        ))
        response = await client.get_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.GetBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


@pytest.mark.asyncio
async def test_get_book_async_from_dict():
    await test_get_book_async(request_type=dict)


def test_get_book_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.GetBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        call.return_value = library.Book()
        client.get_book(request)

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
async def test_get_book_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.GetBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        await client.get_book(request)

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


def test_get_book_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_book(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_get_book_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_book(
            library.GetBookRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_book_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_book(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_book_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_book(
            library.GetBookRequest(),
            name='name_value',
        )


def test_list_books(transport: str = 'grpc', request_type=library.ListBooksRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.ListBooksResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_books(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListBooksRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListBooksPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_books_from_dict():
    test_list_books(request_type=dict)


def test_list_books_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        client.list_books()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListBooksRequest()


@pytest.mark.asyncio
async def test_list_books_async(transport: str = 'grpc_asyncio', request_type=library.ListBooksRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.ListBooksResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_books(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.ListBooksRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListBooksAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_books_async_from_dict():
    await test_list_books_async(request_type=dict)


def test_list_books_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.ListBooksRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        call.return_value = library.ListBooksResponse()
        client.list_books(request)

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
async def test_list_books_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.ListBooksRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.ListBooksResponse())
        await client.list_books(request)

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


def test_list_books_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.ListBooksResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_books(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


def test_list_books_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_books(
            library.ListBooksRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_books_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.ListBooksResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.ListBooksResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_books(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_books_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_books(
            library.ListBooksRequest(),
            parent='parent_value',
        )


def test_list_books_pager():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                    library.Book(),
                ],
                next_page_token='abc',
            ),
            library.ListBooksResponse(
                books=[],
                next_page_token='def',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                ],
                next_page_token='ghi',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
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
        pager = client.list_books(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, library.Book)
                   for i in results)

def test_list_books_pages():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                    library.Book(),
                ],
                next_page_token='abc',
            ),
            library.ListBooksResponse(
                books=[],
                next_page_token='def',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                ],
                next_page_token='ghi',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_books(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_books_async_pager():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                    library.Book(),
                ],
                next_page_token='abc',
            ),
            library.ListBooksResponse(
                books=[],
                next_page_token='def',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                ],
                next_page_token='ghi',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_books(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, library.Book)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_books_async_pages():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_books),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                    library.Book(),
                ],
                next_page_token='abc',
            ),
            library.ListBooksResponse(
                books=[],
                next_page_token='def',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                ],
                next_page_token='ghi',
            ),
            library.ListBooksResponse(
                books=[
                    library.Book(),
                    library.Book(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_books(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_delete_book(transport: str = 'grpc', request_type=library.DeleteBookRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteBookRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_book_from_dict():
    test_delete_book(request_type=dict)


def test_delete_book_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        client.delete_book()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteBookRequest()


@pytest.mark.asyncio
async def test_delete_book_async(transport: str = 'grpc_asyncio', request_type=library.DeleteBookRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.DeleteBookRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_book_async_from_dict():
    await test_delete_book_async(request_type=dict)


def test_delete_book_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.DeleteBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        call.return_value = None
        client.delete_book(request)

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
async def test_delete_book_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.DeleteBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_book(request)

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


def test_delete_book_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_book(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


def test_delete_book_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_book(
            library.DeleteBookRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_book_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_book(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_book_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_book(
            library.DeleteBookRequest(),
            name='name_value',
        )


def test_update_book(transport: str = 'grpc', request_type=library.UpdateBookRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        )
        response = client.update_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.UpdateBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


def test_update_book_from_dict():
    test_update_book(request_type=dict)


def test_update_book_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        client.update_book()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.UpdateBookRequest()


@pytest.mark.asyncio
async def test_update_book_async(transport: str = 'grpc_asyncio', request_type=library.UpdateBookRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        ))
        response = await client.update_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.UpdateBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


@pytest.mark.asyncio
async def test_update_book_async_from_dict():
    await test_update_book_async(request_type=dict)


def test_update_book_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.UpdateBookRequest()

    request.book.name = 'book.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        call.return_value = library.Book()
        client.update_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'book.name=book.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_book_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.UpdateBookRequest()

    request.book.name = 'book.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        await client.update_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'book.name=book.name/value',
    ) in kw['metadata']


def test_update_book_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_book(
            book=library.Book(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].book == library.Book(name='name_value')
        assert args[0].update_mask == field_mask_pb2.FieldMask(paths=['paths_value'])


def test_update_book_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_book(
            library.UpdateBookRequest(),
            book=library.Book(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_book_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_book(
            book=library.Book(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].book == library.Book(name='name_value')
        assert args[0].update_mask == field_mask_pb2.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_update_book_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_book(
            library.UpdateBookRequest(),
            book=library.Book(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


def test_move_book(transport: str = 'grpc', request_type=library.MoveBookRequest):
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        )
        response = client.move_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MoveBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


def test_move_book_from_dict():
    test_move_book(request_type=dict)


def test_move_book_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        client.move_book()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MoveBookRequest()


@pytest.mark.asyncio
async def test_move_book_async(transport: str = 'grpc_asyncio', request_type=library.MoveBookRequest):
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(library.Book(
            name='name_value',
            author='author_value',
            title='title_value',
            read=True,
        ))
        response = await client.move_book(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == library.MoveBookRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, library.Book)
    assert response.name == 'name_value'
    assert response.author == 'author_value'
    assert response.title == 'title_value'
    assert response.read is True


@pytest.mark.asyncio
async def test_move_book_async_from_dict():
    await test_move_book_async(request_type=dict)


def test_move_book_field_headers():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.MoveBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        call.return_value = library.Book()
        client.move_book(request)

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
async def test_move_book_field_headers_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = library.MoveBookRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        await client.move_book(request)

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


def test_move_book_flattened():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.move_book(
            name='name_value',
            other_shelf_name='other_shelf_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].other_shelf_name == 'other_shelf_name_value'


def test_move_book_flattened_error():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.move_book(
            library.MoveBookRequest(),
            name='name_value',
            other_shelf_name='other_shelf_name_value',
        )


@pytest.mark.asyncio
async def test_move_book_flattened_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.move_book),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = library.Book()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(library.Book())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.move_book(
            name='name_value',
            other_shelf_name='other_shelf_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0].name == 'name_value'
        assert args[0].other_shelf_name == 'other_shelf_name_value'


@pytest.mark.asyncio
async def test_move_book_flattened_error_async():
    client = LibraryServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.move_book(
            library.MoveBookRequest(),
            name='name_value',
            other_shelf_name='other_shelf_name_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.LibraryServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = LibraryServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.LibraryServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = LibraryServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.LibraryServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = LibraryServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.LibraryServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = LibraryServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.LibraryServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.LibraryServiceGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.LibraryServiceGrpcTransport,
    transports.LibraryServiceGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.LibraryServiceGrpcTransport,
    )

def test_library_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.LibraryServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_library_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.example.library_v1.services.library_service.transports.LibraryServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.LibraryServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_shelf',
        'get_shelf',
        'list_shelves',
        'delete_shelf',
        'merge_shelves',
        'create_book',
        'get_book',
        'list_books',
        'delete_book',
        'update_book',
        'move_book',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


@requires_google_auth_gte_1_25_0
def test_library_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.example.library_v1.services.library_service.transports.LibraryServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.LibraryServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
),
            quota_project_id="octopus",
        )


@requires_google_auth_lt_1_25_0
def test_library_service_base_transport_with_credentials_file_old_google_auth():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.example.library_v1.services.library_service.transports.LibraryServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.LibraryServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            ),
            quota_project_id="octopus",
        )


def test_library_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.example.library_v1.services.library_service.transports.LibraryServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.LibraryServiceTransport()
        adc.assert_called_once()


@requires_google_auth_gte_1_25_0
def test_library_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        LibraryServiceClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
),
            quota_project_id=None,
        )


@requires_google_auth_lt_1_25_0
def test_library_service_auth_adc_old_google_auth():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        LibraryServiceClient()
        adc.assert_called_once_with(
            scopes=(),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.LibraryServiceGrpcTransport,
        transports.LibraryServiceGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_gte_1_25_0
def test_library_service_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.LibraryServiceGrpcTransport,
        transports.LibraryServiceGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_lt_1_25_0
def test_library_service_transport_auth_adc_old_google_auth(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.LibraryServiceGrpcTransport, grpc_helpers),
        (transports.LibraryServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
@requires_api_core_gte_1_26_0
def test_library_service_transport_create_channel(transport_class, grpc_helpers):
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
            "library-example.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
),
            scopes=["1", "2"],
            default_host="library-example.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.LibraryServiceGrpcTransport, grpc_helpers),
        (transports.LibraryServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
@requires_api_core_lt_1_26_0
def test_library_service_transport_create_channel_old_api_core(transport_class, grpc_helpers):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc, mock.patch.object(
        grpc_helpers, "create_channel", autospec=True
    ) as create_channel:
        creds = ga_credentials.AnonymousCredentials()
        adc.return_value = (creds, None)
        transport_class(quota_project_id="octopus")

        create_channel.assert_called_with(
            "library-example.googleapis.com",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            scopes=(
),
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.LibraryServiceGrpcTransport, grpc_helpers),
        (transports.LibraryServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
@requires_api_core_lt_1_26_0
def test_library_service_transport_create_channel_user_scopes(transport_class, grpc_helpers):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc, mock.patch.object(
        grpc_helpers, "create_channel", autospec=True
    ) as create_channel:
        creds = ga_credentials.AnonymousCredentials()
        adc.return_value = (creds, None)

        transport_class(quota_project_id="octopus", scopes=["1", "2"])

        create_channel.assert_called_with(
            "library-example.googleapis.com",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            scopes=["1", "2"],
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.LibraryServiceGrpcTransport, transports.LibraryServiceGrpcAsyncIOTransport])
def test_library_service_grpc_transport_client_cert_source_for_mtls(
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
            scopes=(
            ),
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


def test_library_service_host_no_port():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='library-example.googleapis.com'),
    )
    assert client.transport._host == 'library-example.googleapis.com:443'


def test_library_service_host_with_port():
    client = LibraryServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='library-example.googleapis.com:8000'),
    )
    assert client.transport._host == 'library-example.googleapis.com:8000'

def test_library_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.LibraryServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_library_service_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.LibraryServiceGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.LibraryServiceGrpcTransport, transports.LibraryServiceGrpcAsyncIOTransport])
def test_library_service_transport_channel_mtls_with_client_cert_source(
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
                scopes=(
                ),
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
@pytest.mark.parametrize("transport_class", [transports.LibraryServiceGrpcTransport, transports.LibraryServiceGrpcAsyncIOTransport])
def test_library_service_transport_channel_mtls_with_adc(
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
                scopes=(
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_book_path():
    shelf = "squid"
    book = "clam"
    expected = "shelves/{shelf}/books/{book}".format(shelf=shelf, book=book, )
    actual = LibraryServiceClient.book_path(shelf, book)
    assert expected == actual


def test_parse_book_path():
    expected = {
        "shelf": "whelk",
        "book": "octopus",
    }
    path = LibraryServiceClient.book_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_book_path(path)
    assert expected == actual

def test_shelf_path():
    shelf_id = "oyster"
    expected = "shelves/{shelf_id}".format(shelf_id=shelf_id, )
    actual = LibraryServiceClient.shelf_path(shelf_id)
    assert expected == actual


def test_parse_shelf_path():
    expected = {
        "shelf_id": "nudibranch",
    }
    path = LibraryServiceClient.shelf_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_shelf_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "cuttlefish"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = LibraryServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "mussel",
    }
    path = LibraryServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "winkle"
    expected = "folders/{folder}".format(folder=folder, )
    actual = LibraryServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nautilus",
    }
    path = LibraryServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "scallop"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = LibraryServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "abalone",
    }
    path = LibraryServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "squid"
    expected = "projects/{project}".format(project=project, )
    actual = LibraryServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "clam",
    }
    path = LibraryServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "whelk"
    location = "octopus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = LibraryServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "oyster",
        "location": "nudibranch",
    }
    path = LibraryServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = LibraryServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.LibraryServiceTransport, '_prep_wrapped_messages') as prep:
        client = LibraryServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.LibraryServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = LibraryServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
