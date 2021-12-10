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
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.cloud.bigquery.storage_v1beta1.services.big_query_storage import BigQueryStorageAsyncClient
from google.cloud.bigquery.storage_v1beta1.services.big_query_storage import BigQueryStorageClient
from google.cloud.bigquery.storage_v1beta1.services.big_query_storage import transports
from google.cloud.bigquery.storage_v1beta1.types import arrow
from google.cloud.bigquery.storage_v1beta1.types import avro
from google.cloud.bigquery.storage_v1beta1.types import read_options
from google.cloud.bigquery.storage_v1beta1.types import storage
from google.cloud.bigquery.storage_v1beta1.types import table_reference
from google.cloud.bigquery.storage_v1beta1.types import table_reference as gcbs_table_reference
from google.oauth2 import service_account
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

    assert BigQueryStorageClient._get_default_mtls_endpoint(None) is None
    assert BigQueryStorageClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert BigQueryStorageClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert BigQueryStorageClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert BigQueryStorageClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert BigQueryStorageClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    BigQueryStorageClient,
    BigQueryStorageAsyncClient,
])
def test_big_query_storage_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'bigquerystorage.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.BigQueryStorageGrpcTransport, "grpc"),
    (transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_big_query_storage_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    BigQueryStorageClient,
    BigQueryStorageAsyncClient,
])
def test_big_query_storage_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'bigquerystorage.googleapis.com:443'


def test_big_query_storage_client_get_transport_class():
    transport = BigQueryStorageClient.get_transport_class()
    available_transports = [
        transports.BigQueryStorageGrpcTransport,
    ]
    assert transport in available_transports

    transport = BigQueryStorageClient.get_transport_class("grpc")
    assert transport == transports.BigQueryStorageGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (BigQueryStorageClient, transports.BigQueryStorageGrpcTransport, "grpc"),
    (BigQueryStorageAsyncClient, transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(BigQueryStorageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigQueryStorageClient))
@mock.patch.object(BigQueryStorageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigQueryStorageAsyncClient))
def test_big_query_storage_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(BigQueryStorageClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(BigQueryStorageClient, 'get_transport_class') as gtc:
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
    (BigQueryStorageClient, transports.BigQueryStorageGrpcTransport, "grpc", "true"),
    (BigQueryStorageAsyncClient, transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (BigQueryStorageClient, transports.BigQueryStorageGrpcTransport, "grpc", "false"),
    (BigQueryStorageAsyncClient, transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(BigQueryStorageClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigQueryStorageClient))
@mock.patch.object(BigQueryStorageAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigQueryStorageAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_big_query_storage_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (BigQueryStorageClient, transports.BigQueryStorageGrpcTransport, "grpc"),
    (BigQueryStorageAsyncClient, transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_big_query_storage_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (BigQueryStorageClient, transports.BigQueryStorageGrpcTransport, "grpc"),
    (BigQueryStorageAsyncClient, transports.BigQueryStorageGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_big_query_storage_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_big_query_storage_client_client_options_from_dict():
    with mock.patch('google.cloud.bigquery.storage_v1beta1.services.big_query_storage.transports.BigQueryStorageGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BigQueryStorageClient(
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


def test_create_read_session(transport: str = 'grpc', request_type=storage.CreateReadSessionRequest):
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.ReadSession(
            name='name_value',
            sharding_strategy=storage.ShardingStrategy.LIQUID,
            avro_schema=avro.AvroSchema(schema='schema_value'),
        )
        response = client.create_read_session(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateReadSessionRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.ReadSession)
    assert response.name == 'name_value'
    assert response.sharding_strategy == storage.ShardingStrategy.LIQUID


def test_create_read_session_from_dict():
    test_create_read_session(request_type=dict)


def test_create_read_session_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        client.create_read_session()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateReadSessionRequest()


@pytest.mark.asyncio
async def test_create_read_session_async(transport: str = 'grpc_asyncio', request_type=storage.CreateReadSessionRequest):
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.ReadSession(
            name='name_value',
            sharding_strategy=storage.ShardingStrategy.LIQUID,
        ))
        response = await client.create_read_session(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.CreateReadSessionRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.ReadSession)
    assert response.name == 'name_value'
    assert response.sharding_strategy == storage.ShardingStrategy.LIQUID


@pytest.mark.asyncio
async def test_create_read_session_async_from_dict():
    await test_create_read_session_async(request_type=dict)


def test_create_read_session_field_headers():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.CreateReadSessionRequest()

    request.table_reference.project_id = 'table_reference.project_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        call.return_value = storage.ReadSession()
        client.create_read_session(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'table_reference.project_id=table_reference.project_id/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_read_session_field_headers_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.CreateReadSessionRequest()

    request.table_reference.project_id = 'table_reference.project_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.ReadSession())
        await client.create_read_session(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'table_reference.project_id=table_reference.project_id/value',
    ) in kw['metadata']


def test_create_read_session_flattened():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.ReadSession()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_read_session(
            table_reference=gcbs_table_reference.TableReference(project_id='project_id_value'),
            parent='parent_value',
            requested_streams=1840,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].table_reference
        mock_val = gcbs_table_reference.TableReference(project_id='project_id_value')
        assert arg == mock_val
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].requested_streams
        mock_val = 1840
        assert arg == mock_val


def test_create_read_session_flattened_error():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_read_session(
            storage.CreateReadSessionRequest(),
            table_reference=gcbs_table_reference.TableReference(project_id='project_id_value'),
            parent='parent_value',
            requested_streams=1840,
        )


@pytest.mark.asyncio
async def test_create_read_session_flattened_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_read_session),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.ReadSession()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.ReadSession())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_read_session(
            table_reference=gcbs_table_reference.TableReference(project_id='project_id_value'),
            parent='parent_value',
            requested_streams=1840,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].table_reference
        mock_val = gcbs_table_reference.TableReference(project_id='project_id_value')
        assert arg == mock_val
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].requested_streams
        mock_val = 1840
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_read_session_flattened_error_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_read_session(
            storage.CreateReadSessionRequest(),
            table_reference=gcbs_table_reference.TableReference(project_id='project_id_value'),
            parent='parent_value',
            requested_streams=1840,
        )


def test_read_rows(transport: str = 'grpc', request_type=storage.ReadRowsRequest):
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([storage.ReadRowsResponse()])
        response = client.read_rows(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ReadRowsRequest()

    # Establish that the response is the type that we expect.
    for message in response:
        assert isinstance(message, storage.ReadRowsResponse)


def test_read_rows_from_dict():
    test_read_rows(request_type=dict)


def test_read_rows_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        client.read_rows()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ReadRowsRequest()


@pytest.mark.asyncio
async def test_read_rows_async(transport: str = 'grpc_asyncio', request_type=storage.ReadRowsRequest):
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[storage.ReadRowsResponse()])
        response = await client.read_rows(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.ReadRowsRequest()

    # Establish that the response is the type that we expect.
    message = await response.read()
    assert isinstance(message, storage.ReadRowsResponse)


@pytest.mark.asyncio
async def test_read_rows_async_from_dict():
    await test_read_rows_async(request_type=dict)


def test_read_rows_field_headers():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.ReadRowsRequest()

    request.read_position.stream.name = 'read_position.stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        call.return_value = iter([storage.ReadRowsResponse()])
        client.read_rows(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'read_position.stream.name=read_position.stream.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_read_rows_field_headers_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.ReadRowsRequest()

    request.read_position.stream.name = 'read_position.stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[storage.ReadRowsResponse()])
        await client.read_rows(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'read_position.stream.name=read_position.stream.name/value',
    ) in kw['metadata']


def test_read_rows_flattened():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([storage.ReadRowsResponse()])
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.read_rows(
            read_position=storage.StreamPosition(stream=storage.Stream(name='name_value')),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].read_position
        mock_val = storage.StreamPosition(stream=storage.Stream(name='name_value'))
        assert arg == mock_val


def test_read_rows_flattened_error():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.read_rows(
            storage.ReadRowsRequest(),
            read_position=storage.StreamPosition(stream=storage.Stream(name='name_value')),
        )


@pytest.mark.asyncio
async def test_read_rows_flattened_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.read_rows),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([storage.ReadRowsResponse()])

        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.read_rows(
            read_position=storage.StreamPosition(stream=storage.Stream(name='name_value')),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].read_position
        mock_val = storage.StreamPosition(stream=storage.Stream(name='name_value'))
        assert arg == mock_val


@pytest.mark.asyncio
async def test_read_rows_flattened_error_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.read_rows(
            storage.ReadRowsRequest(),
            read_position=storage.StreamPosition(stream=storage.Stream(name='name_value')),
        )


def test_batch_create_read_session_streams(transport: str = 'grpc', request_type=storage.BatchCreateReadSessionStreamsRequest):
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.BatchCreateReadSessionStreamsResponse(
        )
        response = client.batch_create_read_session_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.BatchCreateReadSessionStreamsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.BatchCreateReadSessionStreamsResponse)


def test_batch_create_read_session_streams_from_dict():
    test_batch_create_read_session_streams(request_type=dict)


def test_batch_create_read_session_streams_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        client.batch_create_read_session_streams()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.BatchCreateReadSessionStreamsRequest()


@pytest.mark.asyncio
async def test_batch_create_read_session_streams_async(transport: str = 'grpc_asyncio', request_type=storage.BatchCreateReadSessionStreamsRequest):
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.BatchCreateReadSessionStreamsResponse(
        ))
        response = await client.batch_create_read_session_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.BatchCreateReadSessionStreamsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.BatchCreateReadSessionStreamsResponse)


@pytest.mark.asyncio
async def test_batch_create_read_session_streams_async_from_dict():
    await test_batch_create_read_session_streams_async(request_type=dict)


def test_batch_create_read_session_streams_field_headers():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.BatchCreateReadSessionStreamsRequest()

    request.session.name = 'session.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        call.return_value = storage.BatchCreateReadSessionStreamsResponse()
        client.batch_create_read_session_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'session.name=session.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_batch_create_read_session_streams_field_headers_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.BatchCreateReadSessionStreamsRequest()

    request.session.name = 'session.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.BatchCreateReadSessionStreamsResponse())
        await client.batch_create_read_session_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'session.name=session.name/value',
    ) in kw['metadata']


def test_batch_create_read_session_streams_flattened():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.BatchCreateReadSessionStreamsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.batch_create_read_session_streams(
            session=storage.ReadSession(name='name_value'),
            requested_streams=1840,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].session
        mock_val = storage.ReadSession(name='name_value')
        assert arg == mock_val
        arg = args[0].requested_streams
        mock_val = 1840
        assert arg == mock_val


def test_batch_create_read_session_streams_flattened_error():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.batch_create_read_session_streams(
            storage.BatchCreateReadSessionStreamsRequest(),
            session=storage.ReadSession(name='name_value'),
            requested_streams=1840,
        )


@pytest.mark.asyncio
async def test_batch_create_read_session_streams_flattened_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_create_read_session_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.BatchCreateReadSessionStreamsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.BatchCreateReadSessionStreamsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.batch_create_read_session_streams(
            session=storage.ReadSession(name='name_value'),
            requested_streams=1840,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].session
        mock_val = storage.ReadSession(name='name_value')
        assert arg == mock_val
        arg = args[0].requested_streams
        mock_val = 1840
        assert arg == mock_val


@pytest.mark.asyncio
async def test_batch_create_read_session_streams_flattened_error_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.batch_create_read_session_streams(
            storage.BatchCreateReadSessionStreamsRequest(),
            session=storage.ReadSession(name='name_value'),
            requested_streams=1840,
        )


def test_finalize_stream(transport: str = 'grpc', request_type=storage.FinalizeStreamRequest):
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.finalize_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.FinalizeStreamRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_finalize_stream_from_dict():
    test_finalize_stream(request_type=dict)


def test_finalize_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        client.finalize_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.FinalizeStreamRequest()


@pytest.mark.asyncio
async def test_finalize_stream_async(transport: str = 'grpc_asyncio', request_type=storage.FinalizeStreamRequest):
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.finalize_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.FinalizeStreamRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_finalize_stream_async_from_dict():
    await test_finalize_stream_async(request_type=dict)


def test_finalize_stream_field_headers():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.FinalizeStreamRequest()

    request.stream.name = 'stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        call.return_value = None
        client.finalize_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'stream.name=stream.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_finalize_stream_field_headers_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.FinalizeStreamRequest()

    request.stream.name = 'stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.finalize_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'stream.name=stream.name/value',
    ) in kw['metadata']


def test_finalize_stream_flattened():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.finalize_stream(
            stream=storage.Stream(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].stream
        mock_val = storage.Stream(name='name_value')
        assert arg == mock_val


def test_finalize_stream_flattened_error():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.finalize_stream(
            storage.FinalizeStreamRequest(),
            stream=storage.Stream(name='name_value'),
        )


@pytest.mark.asyncio
async def test_finalize_stream_flattened_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.finalize_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.finalize_stream(
            stream=storage.Stream(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].stream
        mock_val = storage.Stream(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_finalize_stream_flattened_error_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.finalize_stream(
            storage.FinalizeStreamRequest(),
            stream=storage.Stream(name='name_value'),
        )


def test_split_read_stream(transport: str = 'grpc', request_type=storage.SplitReadStreamRequest):
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.SplitReadStreamResponse(
        )
        response = client.split_read_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SplitReadStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.SplitReadStreamResponse)


def test_split_read_stream_from_dict():
    test_split_read_stream(request_type=dict)


def test_split_read_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        client.split_read_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SplitReadStreamRequest()


@pytest.mark.asyncio
async def test_split_read_stream_async(transport: str = 'grpc_asyncio', request_type=storage.SplitReadStreamRequest):
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(storage.SplitReadStreamResponse(
        ))
        response = await client.split_read_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == storage.SplitReadStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, storage.SplitReadStreamResponse)


@pytest.mark.asyncio
async def test_split_read_stream_async_from_dict():
    await test_split_read_stream_async(request_type=dict)


def test_split_read_stream_field_headers():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.SplitReadStreamRequest()

    request.original_stream.name = 'original_stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        call.return_value = storage.SplitReadStreamResponse()
        client.split_read_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'original_stream.name=original_stream.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_split_read_stream_field_headers_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = storage.SplitReadStreamRequest()

    request.original_stream.name = 'original_stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.SplitReadStreamResponse())
        await client.split_read_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'original_stream.name=original_stream.name/value',
    ) in kw['metadata']


def test_split_read_stream_flattened():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.SplitReadStreamResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.split_read_stream(
            original_stream=storage.Stream(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].original_stream
        mock_val = storage.Stream(name='name_value')
        assert arg == mock_val


def test_split_read_stream_flattened_error():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.split_read_stream(
            storage.SplitReadStreamRequest(),
            original_stream=storage.Stream(name='name_value'),
        )


@pytest.mark.asyncio
async def test_split_read_stream_flattened_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.split_read_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = storage.SplitReadStreamResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(storage.SplitReadStreamResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.split_read_stream(
            original_stream=storage.Stream(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].original_stream
        mock_val = storage.Stream(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_split_read_stream_flattened_error_async():
    client = BigQueryStorageAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.split_read_stream(
            storage.SplitReadStreamRequest(),
            original_stream=storage.Stream(name='name_value'),
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.BigQueryStorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigQueryStorageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.BigQueryStorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigQueryStorageClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.BigQueryStorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigQueryStorageClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BigQueryStorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = BigQueryStorageClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BigQueryStorageGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.BigQueryStorageGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.BigQueryStorageGrpcTransport,
    transports.BigQueryStorageGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.BigQueryStorageGrpcTransport,
    )

def test_big_query_storage_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.BigQueryStorageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_big_query_storage_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.bigquery.storage_v1beta1.services.big_query_storage.transports.BigQueryStorageTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.BigQueryStorageTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_read_session',
        'read_rows',
        'batch_create_read_session_streams',
        'finalize_stream',
        'split_read_stream',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_big_query_storage_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.bigquery.storage_v1beta1.services.big_query_storage.transports.BigQueryStorageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BigQueryStorageTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/bigquery',
            'https://www.googleapis.com/auth/bigquery.readonly',
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id="octopus",
        )


def test_big_query_storage_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.cloud.bigquery.storage_v1beta1.services.big_query_storage.transports.BigQueryStorageTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BigQueryStorageTransport()
        adc.assert_called_once()


def test_big_query_storage_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        BigQueryStorageClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/bigquery',
            'https://www.googleapis.com/auth/bigquery.readonly',
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.BigQueryStorageGrpcTransport,
        transports.BigQueryStorageGrpcAsyncIOTransport,
    ],
)
def test_big_query_storage_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/bigquery',                'https://www.googleapis.com/auth/bigquery.readonly',                'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.BigQueryStorageGrpcTransport, grpc_helpers),
        (transports.BigQueryStorageGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_big_query_storage_transport_create_channel(transport_class, grpc_helpers):
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
            "bigquerystorage.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/bigquery',
                'https://www.googleapis.com/auth/bigquery.readonly',
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="bigquerystorage.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.BigQueryStorageGrpcTransport, transports.BigQueryStorageGrpcAsyncIOTransport])
def test_big_query_storage_grpc_transport_client_cert_source_for_mtls(
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


def test_big_query_storage_host_no_port():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='bigquerystorage.googleapis.com'),
    )
    assert client.transport._host == 'bigquerystorage.googleapis.com:443'


def test_big_query_storage_host_with_port():
    client = BigQueryStorageClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='bigquerystorage.googleapis.com:8000'),
    )
    assert client.transport._host == 'bigquerystorage.googleapis.com:8000'

def test_big_query_storage_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BigQueryStorageGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_big_query_storage_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BigQueryStorageGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.BigQueryStorageGrpcTransport, transports.BigQueryStorageGrpcAsyncIOTransport])
def test_big_query_storage_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.BigQueryStorageGrpcTransport, transports.BigQueryStorageGrpcAsyncIOTransport])
def test_big_query_storage_transport_channel_mtls_with_adc(
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


def test_read_session_path():
    project = "squid"
    location = "clam"
    session = "whelk"
    expected = "projects/{project}/locations/{location}/sessions/{session}".format(project=project, location=location, session=session, )
    actual = BigQueryStorageClient.read_session_path(project, location, session)
    assert expected == actual


def test_parse_read_session_path():
    expected = {
        "project": "octopus",
        "location": "oyster",
        "session": "nudibranch",
    }
    path = BigQueryStorageClient.read_session_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_read_session_path(path)
    assert expected == actual

def test_stream_path():
    project = "cuttlefish"
    location = "mussel"
    stream = "winkle"
    expected = "projects/{project}/locations/{location}/streams/{stream}".format(project=project, location=location, stream=stream, )
    actual = BigQueryStorageClient.stream_path(project, location, stream)
    assert expected == actual


def test_parse_stream_path():
    expected = {
        "project": "nautilus",
        "location": "scallop",
        "stream": "abalone",
    }
    path = BigQueryStorageClient.stream_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_stream_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "squid"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = BigQueryStorageClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "clam",
    }
    path = BigQueryStorageClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "whelk"
    expected = "folders/{folder}".format(folder=folder, )
    actual = BigQueryStorageClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "octopus",
    }
    path = BigQueryStorageClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "oyster"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = BigQueryStorageClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nudibranch",
    }
    path = BigQueryStorageClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "cuttlefish"
    expected = "projects/{project}".format(project=project, )
    actual = BigQueryStorageClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "mussel",
    }
    path = BigQueryStorageClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "winkle"
    location = "nautilus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = BigQueryStorageClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "scallop",
        "location": "abalone",
    }
    path = BigQueryStorageClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = BigQueryStorageClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.BigQueryStorageTransport, '_prep_wrapped_messages') as prep:
        client = BigQueryStorageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.BigQueryStorageTransport, '_prep_wrapped_messages') as prep:
        transport_class = BigQueryStorageClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = BigQueryStorageAsyncClient(
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
        client = BigQueryStorageClient(
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
        client = BigQueryStorageClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
