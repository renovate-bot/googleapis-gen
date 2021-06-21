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
from google.iam.v1 import iam_policy_pb2  # type: ignore
from google.iam.v1 import options_pb2  # type: ignore
from google.iam.v1 import policy_pb2  # type: ignore
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.storage_v1.services.storage import StorageAsyncClient
from google.storage_v1.services.storage import StorageClient
from google.storage_v1.services.storage import pagers
from google.storage_v1.services.storage import transports
from google.storage_v1.services.storage.transports.base import _GOOGLE_AUTH_VERSION
from google.storage_v1.types import storage
from google.storage_v1.types import storage_resources
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

    assert StorageClient._get_default_mtls_endpoint(None) is None
    assert StorageClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert StorageClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert StorageClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert StorageClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert StorageClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    StorageClient,
    StorageAsyncClient,
])
def test_storage_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'storage.googleapis.com:443'


@pytest.mark.parametrize("client_class", [
    StorageClient,
    StorageAsyncClient,
])
def test_storage_client_service_account_always_use_jwt(client_class):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        client = client_class(credentials=creds)
        use_jwt.assert_called_with(True)


@pytest.mark.parametrize("client_class", [
    StorageClient,
    StorageAsyncClient,
])
def test_storage_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'storage.googleapis.com:443'


def test_storage_client_get_transport_class():
    transport = StorageClient.get_transport_class()
    available_transports = [
        transports.StorageGrpcTransport,
    ]
    assert transport in available_transports

    transport = StorageClient.get_transport_class("grpc")
    assert transport == transports.StorageGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (StorageClient, transports.StorageGrpcTransport, "grpc"),
    (StorageAsyncClient, transports.StorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(StorageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(StorageClient))
@mock.patch.object(StorageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(StorageAsyncClient))
def test_storage_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(StorageClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(StorageClient, 'get_transport_class') as gtc:
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
    (StorageClient, transports.StorageGrpcTransport, "grpc", "true"),
    (StorageAsyncClient, transports.StorageGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (StorageClient, transports.StorageGrpcTransport, "grpc", "false"),
    (StorageAsyncClient, transports.StorageGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(StorageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(StorageClient))
@mock.patch.object(StorageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(StorageAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_storage_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (StorageClient, transports.StorageGrpcTransport, "grpc"),
    (StorageAsyncClient, transports.StorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_storage_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (StorageClient, transports.StorageGrpcTransport, "grpc"),
    (StorageAsyncClient, transports.StorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_storage_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_storage_client_client_options_from_dict():
    with mock.patch('google.storage_v1.services.storage.transports.StorageGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = StorageClient(
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


def test_delete_bucket_access_control(transport: str = 'grpc', request_type=storage.DeleteBucketAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_bucket_access_control_from_dict():
    test_delete_bucket_access_control(request_type=dict)


def test_delete_bucket_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket_access_control),
            '__call__') as call:
        client.delete_bucket_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketAccessControlRequest()


@pytest.mark.asyncio
async def test_delete_bucket_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteBucketAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_bucket_access_control_async_from_dict():
    await test_delete_bucket_access_control_async(request_type=dict)


def test_get_bucket_access_control(transport: str = 'grpc', request_type=storage.GetBucketAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.get_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_get_bucket_access_control_from_dict():
    test_get_bucket_access_control(request_type=dict)


def test_get_bucket_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_access_control),
            '__call__') as call:
        client.get_bucket_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketAccessControlRequest()


@pytest.mark.asyncio
async def test_get_bucket_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.GetBucketAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.get_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_get_bucket_access_control_async_from_dict():
    await test_get_bucket_access_control_async(request_type=dict)


def test_insert_bucket_access_control(transport: str = 'grpc', request_type=storage.InsertBucketAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.insert_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_insert_bucket_access_control_from_dict():
    test_insert_bucket_access_control(request_type=dict)


def test_insert_bucket_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket_access_control),
            '__call__') as call:
        client.insert_bucket_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketAccessControlRequest()


@pytest.mark.asyncio
async def test_insert_bucket_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.InsertBucketAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.insert_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_insert_bucket_access_control_async_from_dict():
    await test_insert_bucket_access_control_async(request_type=dict)


def test_list_bucket_access_controls(transport: str = 'grpc', request_type=storage.ListBucketAccessControlsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_bucket_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListBucketAccessControlsResponse(
        )
        response = client.list_bucket_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListBucketAccessControlsResponse)


def test_list_bucket_access_controls_from_dict():
    test_list_bucket_access_controls(request_type=dict)


def test_list_bucket_access_controls_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_bucket_access_controls),
            '__call__') as call:
        client.list_bucket_access_controls()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketAccessControlsRequest()


@pytest.mark.asyncio
async def test_list_bucket_access_controls_async(transport: str = 'grpc_asyncio', request_type=storage.ListBucketAccessControlsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_bucket_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListBucketAccessControlsResponse(
        ))
        response = await client.list_bucket_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListBucketAccessControlsResponse)


@pytest.mark.asyncio
async def test_list_bucket_access_controls_async_from_dict():
    await test_list_bucket_access_controls_async(request_type=dict)


def test_update_bucket_access_control(transport: str = 'grpc', request_type=storage.UpdateBucketAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.update_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_update_bucket_access_control_from_dict():
    test_update_bucket_access_control(request_type=dict)


def test_update_bucket_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket_access_control),
            '__call__') as call:
        client.update_bucket_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketAccessControlRequest()


@pytest.mark.asyncio
async def test_update_bucket_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateBucketAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.update_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_update_bucket_access_control_async_from_dict():
    await test_update_bucket_access_control_async(request_type=dict)


def test_patch_bucket_access_control(transport: str = 'grpc', request_type=storage.PatchBucketAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.patch_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_patch_bucket_access_control_from_dict():
    test_patch_bucket_access_control(request_type=dict)


def test_patch_bucket_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket_access_control),
            '__call__') as call:
        client.patch_bucket_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketAccessControlRequest()


@pytest.mark.asyncio
async def test_patch_bucket_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.PatchBucketAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.BucketAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.patch_bucket_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.BucketAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_patch_bucket_access_control_async_from_dict():
    await test_patch_bucket_access_control_async(request_type=dict)


def test_delete_bucket(transport: str = 'grpc', request_type=storage.DeleteBucketRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_bucket_from_dict():
    test_delete_bucket(request_type=dict)


def test_delete_bucket_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket),
            '__call__') as call:
        client.delete_bucket()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketRequest()


@pytest.mark.asyncio
async def test_delete_bucket_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteBucketRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteBucketRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_bucket_async_from_dict():
    await test_delete_bucket_async(request_type=dict)


def test_get_bucket(transport: str = 'grpc', request_type=storage.GetBucketRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        )
        response = client.get_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


def test_get_bucket_from_dict():
    test_get_bucket(request_type=dict)


def test_get_bucket_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket),
            '__call__') as call:
        client.get_bucket()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketRequest()


@pytest.mark.asyncio
async def test_get_bucket_async(transport: str = 'grpc_asyncio', request_type=storage.GetBucketRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        ))
        response = await client.get_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


@pytest.mark.asyncio
async def test_get_bucket_async_from_dict():
    await test_get_bucket_async(request_type=dict)


def test_insert_bucket(transport: str = 'grpc', request_type=storage.InsertBucketRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        )
        response = client.insert_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


def test_insert_bucket_from_dict():
    test_insert_bucket(request_type=dict)


def test_insert_bucket_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket),
            '__call__') as call:
        client.insert_bucket()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketRequest()


@pytest.mark.asyncio
async def test_insert_bucket_async(transport: str = 'grpc_asyncio', request_type=storage.InsertBucketRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        ))
        response = await client.insert_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


@pytest.mark.asyncio
async def test_insert_bucket_async_from_dict():
    await test_insert_bucket_async(request_type=dict)


def test_list_channels(transport: str = 'grpc', request_type=storage.ListChannelsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_channels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListChannelsResponse(
        )
        response = client.list_channels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListChannelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListChannelsResponse)


def test_list_channels_from_dict():
    test_list_channels(request_type=dict)


def test_list_channels_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_channels),
            '__call__') as call:
        client.list_channels()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListChannelsRequest()


@pytest.mark.asyncio
async def test_list_channels_async(transport: str = 'grpc_asyncio', request_type=storage.ListChannelsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_channels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListChannelsResponse(
        ))
        response = await client.list_channels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListChannelsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListChannelsResponse)


@pytest.mark.asyncio
async def test_list_channels_async_from_dict():
    await test_list_channels_async(request_type=dict)


def test_list_buckets(transport: str = 'grpc', request_type=storage.ListBucketsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListBucketsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_buckets(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListBucketsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_buckets_from_dict():
    test_list_buckets(request_type=dict)


def test_list_buckets_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__') as call:
        client.list_buckets()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketsRequest()


@pytest.mark.asyncio
async def test_list_buckets_async(transport: str = 'grpc_asyncio', request_type=storage.ListBucketsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListBucketsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_buckets(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListBucketsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListBucketsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_buckets_async_from_dict():
    await test_list_buckets_async(request_type=dict)


def test_list_buckets_pager():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListBucketsResponse(
                items=[],
                next_page_token='def',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_buckets(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, storage_resources.Bucket)
                   for i in results)

def test_list_buckets_pages():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListBucketsResponse(
                items=[],
                next_page_token='def',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_buckets(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_buckets_async_pager():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListBucketsResponse(
                items=[],
                next_page_token='def',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_buckets(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, storage_resources.Bucket)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_buckets_async_pages():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_buckets),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListBucketsResponse(
                items=[],
                next_page_token='def',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListBucketsResponse(
                items=[
                    storage_resources.Bucket(),
                    storage_resources.Bucket(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_buckets(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_lock_bucket_retention_policy(transport: str = 'grpc', request_type=storage.LockRetentionPolicyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lock_bucket_retention_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        )
        response = client.lock_bucket_retention_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.LockRetentionPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


def test_lock_bucket_retention_policy_from_dict():
    test_lock_bucket_retention_policy(request_type=dict)


def test_lock_bucket_retention_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lock_bucket_retention_policy),
            '__call__') as call:
        client.lock_bucket_retention_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.LockRetentionPolicyRequest()


@pytest.mark.asyncio
async def test_lock_bucket_retention_policy_async(transport: str = 'grpc_asyncio', request_type=storage.LockRetentionPolicyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.lock_bucket_retention_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        ))
        response = await client.lock_bucket_retention_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.LockRetentionPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


@pytest.mark.asyncio
async def test_lock_bucket_retention_policy_async_from_dict():
    await test_lock_bucket_retention_policy_async(request_type=dict)


def test_get_bucket_iam_policy(transport: str = 'grpc', request_type=storage.GetIamPolicyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.get_bucket_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_get_bucket_iam_policy_from_dict():
    test_get_bucket_iam_policy(request_type=dict)


def test_get_bucket_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_iam_policy),
            '__call__') as call:
        client.get_bucket_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()


@pytest.mark.asyncio
async def test_get_bucket_iam_policy_async(transport: str = 'grpc_asyncio', request_type=storage.GetIamPolicyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_bucket_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.get_bucket_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_get_bucket_iam_policy_async_from_dict():
    await test_get_bucket_iam_policy_async(request_type=dict)


def test_set_bucket_iam_policy(transport: str = 'grpc', request_type=storage.SetIamPolicyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_bucket_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.set_bucket_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_set_bucket_iam_policy_from_dict():
    test_set_bucket_iam_policy(request_type=dict)


def test_set_bucket_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_bucket_iam_policy),
            '__call__') as call:
        client.set_bucket_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()


@pytest.mark.asyncio
async def test_set_bucket_iam_policy_async(transport: str = 'grpc_asyncio', request_type=storage.SetIamPolicyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_bucket_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.set_bucket_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_set_bucket_iam_policy_async_from_dict():
    await test_set_bucket_iam_policy_async(request_type=dict)


def test_test_bucket_iam_permissions(transport: str = 'grpc', request_type=storage.TestIamPermissionsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_bucket_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        )
        response = client.test_bucket_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


def test_test_bucket_iam_permissions_from_dict():
    test_test_bucket_iam_permissions(request_type=dict)


def test_test_bucket_iam_permissions_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_bucket_iam_permissions),
            '__call__') as call:
        client.test_bucket_iam_permissions()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()


@pytest.mark.asyncio
async def test_test_bucket_iam_permissions_async(transport: str = 'grpc_asyncio', request_type=storage.TestIamPermissionsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_bucket_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        ))
        response = await client.test_bucket_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


@pytest.mark.asyncio
async def test_test_bucket_iam_permissions_async_from_dict():
    await test_test_bucket_iam_permissions_async(request_type=dict)


def test_patch_bucket(transport: str = 'grpc', request_type=storage.PatchBucketRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        )
        response = client.patch_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


def test_patch_bucket_from_dict():
    test_patch_bucket(request_type=dict)


def test_patch_bucket_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket),
            '__call__') as call:
        client.patch_bucket()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketRequest()


@pytest.mark.asyncio
async def test_patch_bucket_async(transport: str = 'grpc_asyncio', request_type=storage.PatchBucketRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        ))
        response = await client.patch_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


@pytest.mark.asyncio
async def test_patch_bucket_async_from_dict():
    await test_patch_bucket_async(request_type=dict)


def test_update_bucket(transport: str = 'grpc', request_type=storage.UpdateBucketRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        )
        response = client.update_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


def test_update_bucket_from_dict():
    test_update_bucket(request_type=dict)


def test_update_bucket_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket),
            '__call__') as call:
        client.update_bucket()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketRequest()


@pytest.mark.asyncio
async def test_update_bucket_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateBucketRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_bucket),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Bucket(
            id='id_value',
            name='name_value',
            project_number=1503,
            metageneration=1491,
            location='location_value',
            storage_class='storage_class_value',
            etag='etag_value',
            default_event_based_hold=True,
            location_type='location_type_value',
            zone_affinity=['zone_affinity_value'],
        ))
        response = await client.update_bucket(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateBucketRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Bucket)
    assert response.id == 'id_value'
    assert response.name == 'name_value'
    assert response.project_number == 1503
    assert response.metageneration == 1491
    assert response.location == 'location_value'
    assert response.storage_class == 'storage_class_value'
    assert response.etag == 'etag_value'
    assert response.default_event_based_hold is True
    assert response.location_type == 'location_type_value'
    assert response.zone_affinity == ['zone_affinity_value']


@pytest.mark.asyncio
async def test_update_bucket_async_from_dict():
    await test_update_bucket_async(request_type=dict)


def test_stop_channel(transport: str = 'grpc', request_type=storage.StopChannelRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.stop_channel),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.stop_channel(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StopChannelRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_stop_channel_from_dict():
    test_stop_channel(request_type=dict)


def test_stop_channel_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.stop_channel),
            '__call__') as call:
        client.stop_channel()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StopChannelRequest()


@pytest.mark.asyncio
async def test_stop_channel_async(transport: str = 'grpc_asyncio', request_type=storage.StopChannelRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.stop_channel),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.stop_channel(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StopChannelRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_stop_channel_async_from_dict():
    await test_stop_channel_async(request_type=dict)


def test_delete_default_object_access_control(transport: str = 'grpc', request_type=storage.DeleteDefaultObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_default_object_access_control_from_dict():
    test_delete_default_object_access_control(request_type=dict)


def test_delete_default_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_default_object_access_control),
            '__call__') as call:
        client.delete_default_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteDefaultObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_delete_default_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteDefaultObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_default_object_access_control_async_from_dict():
    await test_delete_default_object_access_control_async(request_type=dict)


def test_get_default_object_access_control(transport: str = 'grpc', request_type=storage.GetDefaultObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.get_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_get_default_object_access_control_from_dict():
    test_get_default_object_access_control(request_type=dict)


def test_get_default_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_default_object_access_control),
            '__call__') as call:
        client.get_default_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetDefaultObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_get_default_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.GetDefaultObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.get_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_get_default_object_access_control_async_from_dict():
    await test_get_default_object_access_control_async(request_type=dict)


def test_insert_default_object_access_control(transport: str = 'grpc', request_type=storage.InsertDefaultObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.insert_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_insert_default_object_access_control_from_dict():
    test_insert_default_object_access_control(request_type=dict)


def test_insert_default_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_default_object_access_control),
            '__call__') as call:
        client.insert_default_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertDefaultObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_insert_default_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.InsertDefaultObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.insert_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_insert_default_object_access_control_async_from_dict():
    await test_insert_default_object_access_control_async(request_type=dict)


def test_list_default_object_access_controls(transport: str = 'grpc', request_type=storage.ListDefaultObjectAccessControlsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_default_object_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListObjectAccessControlsResponse(
        )
        response = client.list_default_object_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListDefaultObjectAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListObjectAccessControlsResponse)


def test_list_default_object_access_controls_from_dict():
    test_list_default_object_access_controls(request_type=dict)


def test_list_default_object_access_controls_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_default_object_access_controls),
            '__call__') as call:
        client.list_default_object_access_controls()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListDefaultObjectAccessControlsRequest()


@pytest.mark.asyncio
async def test_list_default_object_access_controls_async(transport: str = 'grpc_asyncio', request_type=storage.ListDefaultObjectAccessControlsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_default_object_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListObjectAccessControlsResponse(
        ))
        response = await client.list_default_object_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListDefaultObjectAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListObjectAccessControlsResponse)


@pytest.mark.asyncio
async def test_list_default_object_access_controls_async_from_dict():
    await test_list_default_object_access_controls_async(request_type=dict)


def test_patch_default_object_access_control(transport: str = 'grpc', request_type=storage.PatchDefaultObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.patch_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_patch_default_object_access_control_from_dict():
    test_patch_default_object_access_control(request_type=dict)


def test_patch_default_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_default_object_access_control),
            '__call__') as call:
        client.patch_default_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchDefaultObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_patch_default_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.PatchDefaultObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.patch_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_patch_default_object_access_control_async_from_dict():
    await test_patch_default_object_access_control_async(request_type=dict)


def test_update_default_object_access_control(transport: str = 'grpc', request_type=storage.UpdateDefaultObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.update_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_update_default_object_access_control_from_dict():
    test_update_default_object_access_control(request_type=dict)


def test_update_default_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_default_object_access_control),
            '__call__') as call:
        client.update_default_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateDefaultObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_update_default_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateDefaultObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_default_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.update_default_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateDefaultObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_update_default_object_access_control_async_from_dict():
    await test_update_default_object_access_control_async(request_type=dict)


def test_delete_notification(transport: str = 'grpc', request_type=storage.DeleteNotificationRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteNotificationRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_notification_from_dict():
    test_delete_notification(request_type=dict)


def test_delete_notification_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_notification),
            '__call__') as call:
        client.delete_notification()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteNotificationRequest()


@pytest.mark.asyncio
async def test_delete_notification_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteNotificationRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteNotificationRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_notification_async_from_dict():
    await test_delete_notification_async(request_type=dict)


def test_get_notification(transport: str = 'grpc', request_type=storage.GetNotificationRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Notification(
            topic='topic_value',
            event_types=['event_types_value'],
            etag='etag_value',
            object_name_prefix='object_name_prefix_value',
            payload_format='payload_format_value',
            id='id_value',
        )
        response = client.get_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Notification)
    assert response.topic == 'topic_value'
    assert response.event_types == ['event_types_value']
    assert response.etag == 'etag_value'
    assert response.object_name_prefix == 'object_name_prefix_value'
    assert response.payload_format == 'payload_format_value'
    assert response.id == 'id_value'


def test_get_notification_from_dict():
    test_get_notification(request_type=dict)


def test_get_notification_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_notification),
            '__call__') as call:
        client.get_notification()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetNotificationRequest()


@pytest.mark.asyncio
async def test_get_notification_async(transport: str = 'grpc_asyncio', request_type=storage.GetNotificationRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Notification(
            topic='topic_value',
            event_types=['event_types_value'],
            etag='etag_value',
            object_name_prefix='object_name_prefix_value',
            payload_format='payload_format_value',
            id='id_value',
        ))
        response = await client.get_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Notification)
    assert response.topic == 'topic_value'
    assert response.event_types == ['event_types_value']
    assert response.etag == 'etag_value'
    assert response.object_name_prefix == 'object_name_prefix_value'
    assert response.payload_format == 'payload_format_value'
    assert response.id == 'id_value'


@pytest.mark.asyncio
async def test_get_notification_async_from_dict():
    await test_get_notification_async(request_type=dict)


def test_insert_notification(transport: str = 'grpc', request_type=storage.InsertNotificationRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Notification(
            topic='topic_value',
            event_types=['event_types_value'],
            etag='etag_value',
            object_name_prefix='object_name_prefix_value',
            payload_format='payload_format_value',
            id='id_value',
        )
        response = client.insert_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Notification)
    assert response.topic == 'topic_value'
    assert response.event_types == ['event_types_value']
    assert response.etag == 'etag_value'
    assert response.object_name_prefix == 'object_name_prefix_value'
    assert response.payload_format == 'payload_format_value'
    assert response.id == 'id_value'


def test_insert_notification_from_dict():
    test_insert_notification(request_type=dict)


def test_insert_notification_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_notification),
            '__call__') as call:
        client.insert_notification()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertNotificationRequest()


@pytest.mark.asyncio
async def test_insert_notification_async(transport: str = 'grpc_asyncio', request_type=storage.InsertNotificationRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Notification(
            topic='topic_value',
            event_types=['event_types_value'],
            etag='etag_value',
            object_name_prefix='object_name_prefix_value',
            payload_format='payload_format_value',
            id='id_value',
        ))
        response = await client.insert_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Notification)
    assert response.topic == 'topic_value'
    assert response.event_types == ['event_types_value']
    assert response.etag == 'etag_value'
    assert response.object_name_prefix == 'object_name_prefix_value'
    assert response.payload_format == 'payload_format_value'
    assert response.id == 'id_value'


@pytest.mark.asyncio
async def test_insert_notification_async_from_dict():
    await test_insert_notification_async(request_type=dict)


def test_list_notifications(transport: str = 'grpc', request_type=storage.ListNotificationsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_notifications),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListNotificationsResponse(
        )
        response = client.list_notifications(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListNotificationsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListNotificationsResponse)


def test_list_notifications_from_dict():
    test_list_notifications(request_type=dict)


def test_list_notifications_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_notifications),
            '__call__') as call:
        client.list_notifications()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListNotificationsRequest()


@pytest.mark.asyncio
async def test_list_notifications_async(transport: str = 'grpc_asyncio', request_type=storage.ListNotificationsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_notifications),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListNotificationsResponse(
        ))
        response = await client.list_notifications(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListNotificationsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListNotificationsResponse)


@pytest.mark.asyncio
async def test_list_notifications_async_from_dict():
    await test_list_notifications_async(request_type=dict)


def test_delete_object_access_control(transport: str = 'grpc', request_type=storage.DeleteObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_object_access_control_from_dict():
    test_delete_object_access_control(request_type=dict)


def test_delete_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object_access_control),
            '__call__') as call:
        client.delete_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_delete_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_object_access_control_async_from_dict():
    await test_delete_object_access_control_async(request_type=dict)


def test_get_object_access_control(transport: str = 'grpc', request_type=storage.GetObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.get_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_get_object_access_control_from_dict():
    test_get_object_access_control(request_type=dict)


def test_get_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_access_control),
            '__call__') as call:
        client.get_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_get_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.GetObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.get_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_get_object_access_control_async_from_dict():
    await test_get_object_access_control_async(request_type=dict)


def test_insert_object_access_control(transport: str = 'grpc', request_type=storage.InsertObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.insert_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_insert_object_access_control_from_dict():
    test_insert_object_access_control(request_type=dict)


def test_insert_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_object_access_control),
            '__call__') as call:
        client.insert_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_insert_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.InsertObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.insert_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.InsertObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_insert_object_access_control_async_from_dict():
    await test_insert_object_access_control_async(request_type=dict)


def test_list_object_access_controls(transport: str = 'grpc', request_type=storage.ListObjectAccessControlsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_object_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListObjectAccessControlsResponse(
        )
        response = client.list_object_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListObjectAccessControlsResponse)


def test_list_object_access_controls_from_dict():
    test_list_object_access_controls(request_type=dict)


def test_list_object_access_controls_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_object_access_controls),
            '__call__') as call:
        client.list_object_access_controls()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectAccessControlsRequest()


@pytest.mark.asyncio
async def test_list_object_access_controls_async(transport: str = 'grpc_asyncio', request_type=storage.ListObjectAccessControlsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_object_access_controls),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListObjectAccessControlsResponse(
        ))
        response = await client.list_object_access_controls(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectAccessControlsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ListObjectAccessControlsResponse)


@pytest.mark.asyncio
async def test_list_object_access_controls_async_from_dict():
    await test_list_object_access_controls_async(request_type=dict)


def test_patch_object_access_control(transport: str = 'grpc', request_type=storage.PatchObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.patch_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_patch_object_access_control_from_dict():
    test_patch_object_access_control(request_type=dict)


def test_patch_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object_access_control),
            '__call__') as call:
        client.patch_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_patch_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.PatchObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.patch_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_patch_object_access_control_async_from_dict():
    await test_patch_object_access_control_async(request_type=dict)


def test_update_object_access_control(transport: str = 'grpc', request_type=storage.UpdateObjectAccessControlRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        )
        response = client.update_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


def test_update_object_access_control_from_dict():
    test_update_object_access_control(request_type=dict)


def test_update_object_access_control_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object_access_control),
            '__call__') as call:
        client.update_object_access_control()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectAccessControlRequest()


@pytest.mark.asyncio
async def test_update_object_access_control_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateObjectAccessControlRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object_access_control),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ObjectAccessControl(
            role='role_value',
            etag='etag_value',
            id='id_value',
            bucket='bucket_value',
            object_='object__value',
            generation=1068,
            entity='entity_value',
            entity_id='entity_id_value',
            email='email_value',
            domain='domain_value',
        ))
        response = await client.update_object_access_control(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectAccessControlRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ObjectAccessControl)
    assert response.role == 'role_value'
    assert response.etag == 'etag_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.object_ == 'object__value'
    assert response.generation == 1068
    assert response.entity == 'entity_value'
    assert response.entity_id == 'entity_id_value'
    assert response.email == 'email_value'
    assert response.domain == 'domain_value'


@pytest.mark.asyncio
async def test_update_object_access_control_async_from_dict():
    await test_update_object_access_control_async(request_type=dict)


def test_compose_object(transport: str = 'grpc', request_type=storage.ComposeObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.compose_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.compose_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ComposeObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_compose_object_from_dict():
    test_compose_object(request_type=dict)


def test_compose_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.compose_object),
            '__call__') as call:
        client.compose_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ComposeObjectRequest()


@pytest.mark.asyncio
async def test_compose_object_async(transport: str = 'grpc_asyncio', request_type=storage.ComposeObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.compose_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await client.compose_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ComposeObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_compose_object_async_from_dict():
    await test_compose_object_async(request_type=dict)


def test_copy_object(transport: str = 'grpc', request_type=storage.CopyObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.copy_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.copy_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CopyObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_copy_object_from_dict():
    test_copy_object(request_type=dict)


def test_copy_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.copy_object),
            '__call__') as call:
        client.copy_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CopyObjectRequest()


@pytest.mark.asyncio
async def test_copy_object_async(transport: str = 'grpc_asyncio', request_type=storage.CopyObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.copy_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await client.copy_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CopyObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_copy_object_async_from_dict():
    await test_copy_object_async(request_type=dict)


def test_delete_object(transport: str = 'grpc', request_type=storage.DeleteObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_object_from_dict():
    test_delete_object(request_type=dict)


def test_delete_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object),
            '__call__') as call:
        client.delete_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectRequest()


@pytest.mark.asyncio
async def test_delete_object_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteObjectRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_object_async_from_dict():
    await test_delete_object_async(request_type=dict)


def test_get_object(transport: str = 'grpc', request_type=storage.GetObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.get_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_get_object_from_dict():
    test_get_object(request_type=dict)


def test_get_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object),
            '__call__') as call:
        client.get_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectRequest()


@pytest.mark.asyncio
async def test_get_object_async(transport: str = 'grpc_asyncio', request_type=storage.GetObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await client.get_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_get_object_async_from_dict():
    await test_get_object_async(request_type=dict)


def test_get_object_media(transport: str = 'grpc', request_type=storage.GetObjectMediaRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_media),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([storage.GetObjectMediaResponse()])
        response = client.get_object_media(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectMediaRequest()

    # Establish that the response is the type that we expect.
    for message in response:
        assert isinstance(message, storage.GetObjectMediaResponse)


def test_get_object_media_from_dict():
    test_get_object_media(request_type=dict)


def test_get_object_media_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_media),
            '__call__') as call:
        client.get_object_media()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectMediaRequest()


@pytest.mark.asyncio
async def test_get_object_media_async(transport: str = 'grpc_asyncio', request_type=storage.GetObjectMediaRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_media),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[storage.GetObjectMediaResponse()])
        response = await client.get_object_media(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetObjectMediaRequest()

    # Establish that the response is the type that we expect.
    message = await response.read()
    assert isinstance(message, storage.GetObjectMediaResponse)


@pytest.mark.asyncio
async def test_get_object_media_async_from_dict():
    await test_get_object_media_async(request_type=dict)


def test_insert_object(transport: str = 'grpc', request_type=storage.InsertObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()
    requests = [request]

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.insert_object(iter(requests))

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert next(args[0]) == request

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_insert_object_from_dict():
    test_insert_object(request_type=dict)


@pytest.mark.asyncio
async def test_insert_object_async(transport: str = 'grpc_asyncio', request_type=storage.InsertObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()
    requests = [request]

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.insert_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeStreamUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await (await client.insert_object(iter(requests)))

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert next(args[0]) == request

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_insert_object_async_from_dict():
    await test_insert_object_async(request_type=dict)


def test_list_objects(transport: str = 'grpc', request_type=storage.ListObjectsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.ListObjectsResponse(
            prefixes=['prefixes_value'],
            next_page_token='next_page_token_value',
        )
        response = client.list_objects(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListObjectsPager)
    assert response.prefixes == ['prefixes_value']
    assert response.next_page_token == 'next_page_token_value'


def test_list_objects_from_dict():
    test_list_objects(request_type=dict)


def test_list_objects_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__') as call:
        client.list_objects()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectsRequest()


@pytest.mark.asyncio
async def test_list_objects_async(transport: str = 'grpc_asyncio', request_type=storage.ListObjectsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ListObjectsResponse(
            prefixes=['prefixes_value'],
            next_page_token='next_page_token_value',
        ))
        response = await client.list_objects(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListObjectsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListObjectsAsyncPager)
    assert response.prefixes == ['prefixes_value']
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_objects_async_from_dict():
    await test_list_objects_async(request_type=dict)


def test_list_objects_pager():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[],
                next_page_token='def',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_objects(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, str)
                   for i in results)

def test_list_objects_pages():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[],
                next_page_token='def',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_objects(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_objects_async_pager():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[],
                next_page_token='def',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_objects(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, str)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_objects_async_pages():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_objects),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[],
                next_page_token='def',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            storage_resources.ListObjectsResponse(
                prefixes=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_objects(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_rewrite_object(transport: str = 'grpc', request_type=storage.RewriteObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.rewrite_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.RewriteResponse(
            total_bytes_rewritten=2285,
            object_size=1169,
            done=True,
            rewrite_token='rewrite_token_value',
        )
        response = client.rewrite_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.RewriteObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.RewriteResponse)
    assert response.total_bytes_rewritten == 2285
    assert response.object_size == 1169
    assert response.done is True
    assert response.rewrite_token == 'rewrite_token_value'


def test_rewrite_object_from_dict():
    test_rewrite_object(request_type=dict)


def test_rewrite_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.rewrite_object),
            '__call__') as call:
        client.rewrite_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.RewriteObjectRequest()


@pytest.mark.asyncio
async def test_rewrite_object_async(transport: str = 'grpc_asyncio', request_type=storage.RewriteObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.rewrite_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.RewriteResponse(
            total_bytes_rewritten=2285,
            object_size=1169,
            done=True,
            rewrite_token='rewrite_token_value',
        ))
        response = await client.rewrite_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.RewriteObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.RewriteResponse)
    assert response.total_bytes_rewritten == 2285
    assert response.object_size == 1169
    assert response.done is True
    assert response.rewrite_token == 'rewrite_token_value'


@pytest.mark.asyncio
async def test_rewrite_object_async_from_dict():
    await test_rewrite_object_async(request_type=dict)


def test_start_resumable_write(transport: str = 'grpc', request_type=storage.StartResumableWriteRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.start_resumable_write),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.StartResumableWriteResponse(
            upload_id='upload_id_value',
        )
        response = client.start_resumable_write(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StartResumableWriteRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.StartResumableWriteResponse)
    assert response.upload_id == 'upload_id_value'


def test_start_resumable_write_from_dict():
    test_start_resumable_write(request_type=dict)


def test_start_resumable_write_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.start_resumable_write),
            '__call__') as call:
        client.start_resumable_write()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StartResumableWriteRequest()


@pytest.mark.asyncio
async def test_start_resumable_write_async(transport: str = 'grpc_asyncio', request_type=storage.StartResumableWriteRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.start_resumable_write),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.StartResumableWriteResponse(
            upload_id='upload_id_value',
        ))
        response = await client.start_resumable_write(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.StartResumableWriteRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.StartResumableWriteResponse)
    assert response.upload_id == 'upload_id_value'


@pytest.mark.asyncio
async def test_start_resumable_write_async_from_dict():
    await test_start_resumable_write_async(request_type=dict)


def test_query_write_status(transport: str = 'grpc', request_type=storage.QueryWriteStatusRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_write_status),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.QueryWriteStatusResponse(
            committed_size=1504,
            complete=True,
        )
        response = client.query_write_status(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.QueryWriteStatusRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.QueryWriteStatusResponse)
    assert response.committed_size == 1504
    assert response.complete is True


def test_query_write_status_from_dict():
    test_query_write_status(request_type=dict)


def test_query_write_status_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_write_status),
            '__call__') as call:
        client.query_write_status()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.QueryWriteStatusRequest()


@pytest.mark.asyncio
async def test_query_write_status_async(transport: str = 'grpc_asyncio', request_type=storage.QueryWriteStatusRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query_write_status),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.QueryWriteStatusResponse(
            committed_size=1504,
            complete=True,
        ))
        response = await client.query_write_status(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.QueryWriteStatusRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.QueryWriteStatusResponse)
    assert response.committed_size == 1504
    assert response.complete is True


@pytest.mark.asyncio
async def test_query_write_status_async_from_dict():
    await test_query_write_status_async(request_type=dict)


def test_patch_object(transport: str = 'grpc', request_type=storage.PatchObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.patch_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_patch_object_from_dict():
    test_patch_object(request_type=dict)


def test_patch_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object),
            '__call__') as call:
        client.patch_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectRequest()


@pytest.mark.asyncio
async def test_patch_object_async(transport: str = 'grpc_asyncio', request_type=storage.PatchObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.patch_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await client.patch_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.PatchObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_patch_object_async_from_dict():
    await test_patch_object_async(request_type=dict)


def test_update_object(transport: str = 'grpc', request_type=storage.UpdateObjectRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        )
        response = client.update_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


def test_update_object_from_dict():
    test_update_object(request_type=dict)


def test_update_object_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object),
            '__call__') as call:
        client.update_object()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectRequest()


@pytest.mark.asyncio
async def test_update_object_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateObjectRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_object),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Object(
            content_encoding='content_encoding_value',
            content_disposition='content_disposition_value',
            cache_control='cache_control_value',
            content_language='content_language_value',
            metageneration=1491,
            content_type='content_type_value',
            size=443,
            component_count=1627,
            md5_hash='md5_hash_value',
            etag='etag_value',
            storage_class='storage_class_value',
            kms_key_name='kms_key_name_value',
            temporary_hold=True,
            name='name_value',
            id='id_value',
            bucket='bucket_value',
            generation=1068,
        ))
        response = await client.update_object(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateObjectRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Object)
    assert response.content_encoding == 'content_encoding_value'
    assert response.content_disposition == 'content_disposition_value'
    assert response.cache_control == 'cache_control_value'
    assert response.content_language == 'content_language_value'
    assert response.metageneration == 1491
    assert response.content_type == 'content_type_value'
    assert response.size == 443
    assert response.component_count == 1627
    assert response.md5_hash == 'md5_hash_value'
    assert response.etag == 'etag_value'
    assert response.storage_class == 'storage_class_value'
    assert response.kms_key_name == 'kms_key_name_value'
    assert response.temporary_hold is True
    assert response.name == 'name_value'
    assert response.id == 'id_value'
    assert response.bucket == 'bucket_value'
    assert response.generation == 1068


@pytest.mark.asyncio
async def test_update_object_async_from_dict():
    await test_update_object_async(request_type=dict)


def test_get_object_iam_policy(transport: str = 'grpc', request_type=storage.GetIamPolicyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.get_object_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_get_object_iam_policy_from_dict():
    test_get_object_iam_policy(request_type=dict)


def test_get_object_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_iam_policy),
            '__call__') as call:
        client.get_object_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()


@pytest.mark.asyncio
async def test_get_object_iam_policy_async(transport: str = 'grpc_asyncio', request_type=storage.GetIamPolicyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_object_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.get_object_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_get_object_iam_policy_async_from_dict():
    await test_get_object_iam_policy_async(request_type=dict)


def test_set_object_iam_policy(transport: str = 'grpc', request_type=storage.SetIamPolicyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_object_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        )
        response = client.set_object_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


def test_set_object_iam_policy_from_dict():
    test_set_object_iam_policy(request_type=dict)


def test_set_object_iam_policy_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_object_iam_policy),
            '__call__') as call:
        client.set_object_iam_policy()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()


@pytest.mark.asyncio
async def test_set_object_iam_policy_async(transport: str = 'grpc_asyncio', request_type=storage.SetIamPolicyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_object_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(policy_pb2.Policy(
            version=774,
            etag=b'etag_blob',
        ))
        response = await client.set_object_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy_pb2.Policy)
    assert response.version == 774
    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_set_object_iam_policy_async_from_dict():
    await test_set_object_iam_policy_async(request_type=dict)


def test_test_object_iam_permissions(transport: str = 'grpc', request_type=storage.TestIamPermissionsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_object_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        )
        response = client.test_object_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


def test_test_object_iam_permissions_from_dict():
    test_test_object_iam_permissions(request_type=dict)


def test_test_object_iam_permissions_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_object_iam_permissions),
            '__call__') as call:
        client.test_object_iam_permissions()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()


@pytest.mark.asyncio
async def test_test_object_iam_permissions_async(transport: str = 'grpc_asyncio', request_type=storage.TestIamPermissionsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_object_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(iam_policy_pb2.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        ))
        response = await client.test_object_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy_pb2.TestIamPermissionsResponse)
    assert response.permissions == ['permissions_value']


@pytest.mark.asyncio
async def test_test_object_iam_permissions_async_from_dict():
    await test_test_object_iam_permissions_async(request_type=dict)


def test_watch_all_objects(transport: str = 'grpc', request_type=storage.WatchAllObjectsRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.watch_all_objects),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.Channel(
            id='id_value',
            resource_id='resource_id_value',
            resource_uri='resource_uri_value',
            token='token_value',
            type_='type__value',
            address='address_value',
            payload=True,
        )
        response = client.watch_all_objects(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.WatchAllObjectsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Channel)
    assert response.id == 'id_value'
    assert response.resource_id == 'resource_id_value'
    assert response.resource_uri == 'resource_uri_value'
    assert response.token == 'token_value'
    assert response.type_ == 'type__value'
    assert response.address == 'address_value'
    assert response.payload is True


def test_watch_all_objects_from_dict():
    test_watch_all_objects(request_type=dict)


def test_watch_all_objects_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.watch_all_objects),
            '__call__') as call:
        client.watch_all_objects()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.WatchAllObjectsRequest()


@pytest.mark.asyncio
async def test_watch_all_objects_async(transport: str = 'grpc_asyncio', request_type=storage.WatchAllObjectsRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.watch_all_objects),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.Channel(
            id='id_value',
            resource_id='resource_id_value',
            resource_uri='resource_uri_value',
            token='token_value',
            type_='type__value',
            address='address_value',
            payload=True,
        ))
        response = await client.watch_all_objects(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.WatchAllObjectsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.Channel)
    assert response.id == 'id_value'
    assert response.resource_id == 'resource_id_value'
    assert response.resource_uri == 'resource_uri_value'
    assert response.token == 'token_value'
    assert response.type_ == 'type__value'
    assert response.address == 'address_value'
    assert response.payload is True


@pytest.mark.asyncio
async def test_watch_all_objects_async_from_dict():
    await test_watch_all_objects_async(request_type=dict)


def test_get_service_account(transport: str = 'grpc', request_type=storage.GetProjectServiceAccountRequest):
    client = StorageClient(
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
        call.return_value = storage_resources.ServiceAccount(
            email_address='email_address_value',
        )
        response = client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetProjectServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ServiceAccount)
    assert response.email_address == 'email_address_value'


def test_get_service_account_from_dict():
    test_get_service_account(request_type=dict)


def test_get_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
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
        assert args[0] == storage.GetProjectServiceAccountRequest()


@pytest.mark.asyncio
async def test_get_service_account_async(transport: str = 'grpc_asyncio', request_type=storage.GetProjectServiceAccountRequest):
    client = StorageAsyncClient(
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
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.ServiceAccount(
            email_address='email_address_value',
        ))
        response = await client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetProjectServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.ServiceAccount)
    assert response.email_address == 'email_address_value'


@pytest.mark.asyncio
async def test_get_service_account_async_from_dict():
    await test_get_service_account_async(request_type=dict)


def test_create_hmac_key(transport: str = 'grpc', request_type=storage.CreateHmacKeyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.CreateHmacKeyResponse(
            secret='secret_value',
        )
        response = client.create_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.CreateHmacKeyResponse)
    assert response.secret == 'secret_value'


def test_create_hmac_key_from_dict():
    test_create_hmac_key(request_type=dict)


def test_create_hmac_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_hmac_key),
            '__call__') as call:
        client.create_hmac_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateHmacKeyRequest()


@pytest.mark.asyncio
async def test_create_hmac_key_async(transport: str = 'grpc_asyncio', request_type=storage.CreateHmacKeyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.CreateHmacKeyResponse(
            secret='secret_value',
        ))
        response = await client.create_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.CreateHmacKeyResponse)
    assert response.secret == 'secret_value'


@pytest.mark.asyncio
async def test_create_hmac_key_async_from_dict():
    await test_create_hmac_key_async(request_type=dict)


def test_delete_hmac_key(transport: str = 'grpc', request_type=storage.DeleteHmacKeyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_hmac_key_from_dict():
    test_delete_hmac_key(request_type=dict)


def test_delete_hmac_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_hmac_key),
            '__call__') as call:
        client.delete_hmac_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteHmacKeyRequest()


@pytest.mark.asyncio
async def test_delete_hmac_key_async(transport: str = 'grpc_asyncio', request_type=storage.DeleteHmacKeyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.DeleteHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_hmac_key_async_from_dict():
    await test_delete_hmac_key_async(request_type=dict)


def test_get_hmac_key(transport: str = 'grpc', request_type=storage.GetHmacKeyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.HmacKeyMetadata(
            id='id_value',
            access_id='access_id_value',
            project_id='project_id_value',
            service_account_email='service_account_email_value',
            state='state_value',
            etag='etag_value',
        )
        response = client.get_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.HmacKeyMetadata)
    assert response.id == 'id_value'
    assert response.access_id == 'access_id_value'
    assert response.project_id == 'project_id_value'
    assert response.service_account_email == 'service_account_email_value'
    assert response.state == 'state_value'
    assert response.etag == 'etag_value'


def test_get_hmac_key_from_dict():
    test_get_hmac_key(request_type=dict)


def test_get_hmac_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_hmac_key),
            '__call__') as call:
        client.get_hmac_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetHmacKeyRequest()


@pytest.mark.asyncio
async def test_get_hmac_key_async(transport: str = 'grpc_asyncio', request_type=storage.GetHmacKeyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.HmacKeyMetadata(
            id='id_value',
            access_id='access_id_value',
            project_id='project_id_value',
            service_account_email='service_account_email_value',
            state='state_value',
            etag='etag_value',
        ))
        response = await client.get_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.GetHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.HmacKeyMetadata)
    assert response.id == 'id_value'
    assert response.access_id == 'access_id_value'
    assert response.project_id == 'project_id_value'
    assert response.service_account_email == 'service_account_email_value'
    assert response.state == 'state_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_get_hmac_key_async_from_dict():
    await test_get_hmac_key_async(request_type=dict)


def test_list_hmac_keys(transport: str = 'grpc', request_type=storage.ListHmacKeysRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.ListHmacKeysResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_hmac_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListHmacKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListHmacKeysPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_hmac_keys_from_dict():
    test_list_hmac_keys(request_type=dict)


def test_list_hmac_keys_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__') as call:
        client.list_hmac_keys()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListHmacKeysRequest()


@pytest.mark.asyncio
async def test_list_hmac_keys_async(transport: str = 'grpc_asyncio', request_type=storage.ListHmacKeysRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.ListHmacKeysResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_hmac_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ListHmacKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListHmacKeysAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_hmac_keys_async_from_dict():
    await test_list_hmac_keys_async(request_type=dict)


def test_list_hmac_keys_pager():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='abc',
            ),
            storage.ListHmacKeysResponse(
                items=[],
                next_page_token='def',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='ghi',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_hmac_keys(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, storage_resources.HmacKeyMetadata)
                   for i in results)

def test_list_hmac_keys_pages():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='abc',
            ),
            storage.ListHmacKeysResponse(
                items=[],
                next_page_token='def',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='ghi',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_hmac_keys(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_hmac_keys_async_pager():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='abc',
            ),
            storage.ListHmacKeysResponse(
                items=[],
                next_page_token='def',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='ghi',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_hmac_keys(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, storage_resources.HmacKeyMetadata)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_hmac_keys_async_pages():
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_hmac_keys),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='abc',
            ),
            storage.ListHmacKeysResponse(
                items=[],
                next_page_token='def',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                ],
                next_page_token='ghi',
            ),
            storage.ListHmacKeysResponse(
                items=[
                    storage_resources.HmacKeyMetadata(),
                    storage_resources.HmacKeyMetadata(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_hmac_keys(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_update_hmac_key(transport: str = 'grpc', request_type=storage.UpdateHmacKeyRequest):
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage_resources.HmacKeyMetadata(
            id='id_value',
            access_id='access_id_value',
            project_id='project_id_value',
            service_account_email='service_account_email_value',
            state='state_value',
            etag='etag_value',
        )
        response = client.update_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.HmacKeyMetadata)
    assert response.id == 'id_value'
    assert response.access_id == 'access_id_value'
    assert response.project_id == 'project_id_value'
    assert response.service_account_email == 'service_account_email_value'
    assert response.state == 'state_value'
    assert response.etag == 'etag_value'


def test_update_hmac_key_from_dict():
    test_update_hmac_key(request_type=dict)


def test_update_hmac_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_hmac_key),
            '__call__') as call:
        client.update_hmac_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateHmacKeyRequest()


@pytest.mark.asyncio
async def test_update_hmac_key_async(transport: str = 'grpc_asyncio', request_type=storage.UpdateHmacKeyRequest):
    client = StorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_hmac_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage_resources.HmacKeyMetadata(
            id='id_value',
            access_id='access_id_value',
            project_id='project_id_value',
            service_account_email='service_account_email_value',
            state='state_value',
            etag='etag_value',
        ))
        response = await client.update_hmac_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.UpdateHmacKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage_resources.HmacKeyMetadata)
    assert response.id == 'id_value'
    assert response.access_id == 'access_id_value'
    assert response.project_id == 'project_id_value'
    assert response.service_account_email == 'service_account_email_value'
    assert response.state == 'state_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_update_hmac_key_async_from_dict():
    await test_update_hmac_key_async(request_type=dict)


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.StorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = StorageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.StorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = StorageClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.StorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = StorageClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.StorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = StorageClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.StorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.StorageGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.StorageGrpcTransport,
    transports.StorageGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.StorageGrpcTransport,
    )

def test_storage_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.StorageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_storage_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.storage_v1.services.storage.transports.StorageTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.StorageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'delete_bucket_access_control',
        'get_bucket_access_control',
        'insert_bucket_access_control',
        'list_bucket_access_controls',
        'update_bucket_access_control',
        'patch_bucket_access_control',
        'delete_bucket',
        'get_bucket',
        'insert_bucket',
        'list_channels',
        'list_buckets',
        'lock_bucket_retention_policy',
        'get_bucket_iam_policy',
        'set_bucket_iam_policy',
        'test_bucket_iam_permissions',
        'patch_bucket',
        'update_bucket',
        'stop_channel',
        'delete_default_object_access_control',
        'get_default_object_access_control',
        'insert_default_object_access_control',
        'list_default_object_access_controls',
        'patch_default_object_access_control',
        'update_default_object_access_control',
        'delete_notification',
        'get_notification',
        'insert_notification',
        'list_notifications',
        'delete_object_access_control',
        'get_object_access_control',
        'insert_object_access_control',
        'list_object_access_controls',
        'patch_object_access_control',
        'update_object_access_control',
        'compose_object',
        'copy_object',
        'delete_object',
        'get_object',
        'get_object_media',
        'insert_object',
        'list_objects',
        'rewrite_object',
        'start_resumable_write',
        'query_write_status',
        'patch_object',
        'update_object',
        'get_object_iam_policy',
        'set_object_iam_policy',
        'test_object_iam_permissions',
        'watch_all_objects',
        'get_service_account',
        'create_hmac_key',
        'delete_hmac_key',
        'get_hmac_key',
        'list_hmac_keys',
        'update_hmac_key',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


@requires_google_auth_gte_1_25_0
def test_storage_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.storage_v1.services.storage.transports.StorageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.StorageTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/devstorage.full_control',
            'https://www.googleapis.com/auth/devstorage.read_only',
            'https://www.googleapis.com/auth/devstorage.read_write',
),
            quota_project_id="octopus",
        )


@requires_google_auth_lt_1_25_0
def test_storage_base_transport_with_credentials_file_old_google_auth():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.storage_v1.services.storage.transports.StorageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.StorageTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/devstorage.full_control',
            'https://www.googleapis.com/auth/devstorage.read_only',
            'https://www.googleapis.com/auth/devstorage.read_write',
            ),
            quota_project_id="octopus",
        )


def test_storage_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.storage_v1.services.storage.transports.StorageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.StorageTransport()
        adc.assert_called_once()


@requires_google_auth_gte_1_25_0
def test_storage_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        StorageClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/devstorage.full_control',
            'https://www.googleapis.com/auth/devstorage.read_only',
            'https://www.googleapis.com/auth/devstorage.read_write',
),
            quota_project_id=None,
        )


@requires_google_auth_lt_1_25_0
def test_storage_auth_adc_old_google_auth():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        StorageClient()
        adc.assert_called_once_with(
            scopes=(                'https://www.googleapis.com/auth/cloud-platform',                'https://www.googleapis.com/auth/cloud-platform.read-only',                'https://www.googleapis.com/auth/devstorage.full_control',                'https://www.googleapis.com/auth/devstorage.read_only',                'https://www.googleapis.com/auth/devstorage.read_write',),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.StorageGrpcTransport,
        transports.StorageGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_gte_1_25_0
def test_storage_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/cloud-platform',                'https://www.googleapis.com/auth/cloud-platform.read-only',                'https://www.googleapis.com/auth/devstorage.full_control',                'https://www.googleapis.com/auth/devstorage.read_only',                'https://www.googleapis.com/auth/devstorage.read_write',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.StorageGrpcTransport,
        transports.StorageGrpcAsyncIOTransport,
    ],
)
@requires_google_auth_lt_1_25_0
def test_storage_transport_auth_adc_old_google_auth(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            'https://www.googleapis.com/auth/devstorage.full_control',
            'https://www.googleapis.com/auth/devstorage.read_only',
            'https://www.googleapis.com/auth/devstorage.read_write',
),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.StorageGrpcTransport, grpc_helpers),
        (transports.StorageGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_storage_transport_create_channel(transport_class, grpc_helpers):
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
            "storage.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
                'https://www.googleapis.com/auth/cloud-platform.read-only',
                'https://www.googleapis.com/auth/devstorage.full_control',
                'https://www.googleapis.com/auth/devstorage.read_only',
                'https://www.googleapis.com/auth/devstorage.read_write',
),
            scopes=["1", "2"],
            default_host="storage.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.StorageGrpcTransport, transports.StorageGrpcAsyncIOTransport])
def test_storage_grpc_transport_client_cert_source_for_mtls(
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
                'https://www.googleapis.com/auth/cloud-platform',
                'https://www.googleapis.com/auth/cloud-platform.read-only',
                'https://www.googleapis.com/auth/devstorage.full_control',
                'https://www.googleapis.com/auth/devstorage.read_only',
                'https://www.googleapis.com/auth/devstorage.read_write',
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


def test_storage_host_no_port():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='storage.googleapis.com'),
    )
    assert client.transport._host == 'storage.googleapis.com:443'


def test_storage_host_with_port():
    client = StorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='storage.googleapis.com:8000'),
    )
    assert client.transport._host == 'storage.googleapis.com:8000'

def test_storage_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.StorageGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_storage_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.StorageGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.StorageGrpcTransport, transports.StorageGrpcAsyncIOTransport])
def test_storage_transport_channel_mtls_with_client_cert_source(
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
                    'https://www.googleapis.com/auth/cloud-platform',
                    'https://www.googleapis.com/auth/cloud-platform.read-only',
                    'https://www.googleapis.com/auth/devstorage.full_control',
                    'https://www.googleapis.com/auth/devstorage.read_only',
                    'https://www.googleapis.com/auth/devstorage.read_write',
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
@pytest.mark.parametrize("transport_class", [transports.StorageGrpcTransport, transports.StorageGrpcAsyncIOTransport])
def test_storage_transport_channel_mtls_with_adc(
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
                    'https://www.googleapis.com/auth/cloud-platform',
                    'https://www.googleapis.com/auth/cloud-platform.read-only',
                    'https://www.googleapis.com/auth/devstorage.full_control',
                    'https://www.googleapis.com/auth/devstorage.read_only',
                    'https://www.googleapis.com/auth/devstorage.read_write',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_common_billing_account_path():
    billing_account = "squid"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = StorageClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "clam",
    }
    path = StorageClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = StorageClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "whelk"
    expected = "folders/{folder}".format(folder=folder, )
    actual = StorageClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "octopus",
    }
    path = StorageClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = StorageClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "oyster"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = StorageClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nudibranch",
    }
    path = StorageClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = StorageClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "cuttlefish"
    expected = "projects/{project}".format(project=project, )
    actual = StorageClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "mussel",
    }
    path = StorageClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = StorageClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "winkle"
    location = "nautilus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = StorageClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "scallop",
        "location": "abalone",
    }
    path = StorageClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = StorageClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.StorageTransport, '_prep_wrapped_messages') as prep:
        client = StorageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.StorageTransport, '_prep_wrapped_messages') as prep:
        transport_class = StorageClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
