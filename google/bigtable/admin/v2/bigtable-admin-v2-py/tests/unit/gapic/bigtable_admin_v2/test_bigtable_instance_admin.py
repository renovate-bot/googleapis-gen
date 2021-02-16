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

from google import auth
from google.api_core import client_options
from google.api_core import exceptions
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.auth import credentials
from google.auth.exceptions import MutualTLSChannelError
from google.cloud.bigtable_admin_v2.services.bigtable_instance_admin import BigtableInstanceAdminAsyncClient
from google.cloud.bigtable_admin_v2.services.bigtable_instance_admin import BigtableInstanceAdminClient
from google.cloud.bigtable_admin_v2.services.bigtable_instance_admin import pagers
from google.cloud.bigtable_admin_v2.services.bigtable_instance_admin import transports
from google.cloud.bigtable_admin_v2.types import bigtable_instance_admin
from google.cloud.bigtable_admin_v2.types import common
from google.cloud.bigtable_admin_v2.types import instance
from google.cloud.bigtable_admin_v2.types import instance as gba_instance
from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import options_pb2 as options  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.type import expr_pb2 as expr  # type: ignore


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

    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(None) is None
    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert BigtableInstanceAdminClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_bigtable_instance_admin_client_from_service_account_info():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = BigtableInstanceAdminClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'bigtableadmin.googleapis.com:443'


@pytest.mark.parametrize("client_class", [
    BigtableInstanceAdminClient,
    BigtableInstanceAdminAsyncClient,
])
def test_bigtable_instance_admin_client_from_service_account_file(client_class):
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'bigtableadmin.googleapis.com:443'


def test_bigtable_instance_admin_client_get_transport_class():
    transport = BigtableInstanceAdminClient.get_transport_class()
    available_transports = [
        transports.BigtableInstanceAdminGrpcTransport,
    ]
    assert transport in available_transports

    transport = BigtableInstanceAdminClient.get_transport_class("grpc")
    assert transport == transports.BigtableInstanceAdminGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (BigtableInstanceAdminClient, transports.BigtableInstanceAdminGrpcTransport, "grpc"),
    (BigtableInstanceAdminAsyncClient, transports.BigtableInstanceAdminGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(BigtableInstanceAdminClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigtableInstanceAdminClient))
@mock.patch.object(BigtableInstanceAdminAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigtableInstanceAdminAsyncClient))
def test_bigtable_instance_admin_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(BigtableInstanceAdminClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(BigtableInstanceAdminClient, 'get_transport_class') as gtc:
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

    (BigtableInstanceAdminClient, transports.BigtableInstanceAdminGrpcTransport, "grpc", "true"),
    (BigtableInstanceAdminAsyncClient, transports.BigtableInstanceAdminGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (BigtableInstanceAdminClient, transports.BigtableInstanceAdminGrpcTransport, "grpc", "false"),
    (BigtableInstanceAdminAsyncClient, transports.BigtableInstanceAdminGrpcAsyncIOTransport, "grpc_asyncio", "false"),

])
@mock.patch.object(BigtableInstanceAdminClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigtableInstanceAdminClient))
@mock.patch.object(BigtableInstanceAdminAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BigtableInstanceAdminAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_bigtable_instance_admin_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (BigtableInstanceAdminClient, transports.BigtableInstanceAdminGrpcTransport, "grpc"),
    (BigtableInstanceAdminAsyncClient, transports.BigtableInstanceAdminGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_bigtable_instance_admin_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (BigtableInstanceAdminClient, transports.BigtableInstanceAdminGrpcTransport, "grpc"),
    (BigtableInstanceAdminAsyncClient, transports.BigtableInstanceAdminGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_bigtable_instance_admin_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_bigtable_instance_admin_client_client_options_from_dict():
    with mock.patch('google.cloud.bigtable_admin_v2.services.bigtable_instance_admin.transports.BigtableInstanceAdminGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BigtableInstanceAdminClient(
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


def test_create_instance(transport: str = 'grpc', request_type=bigtable_instance_admin.CreateInstanceRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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

        assert args[0] == bigtable_instance_admin.CreateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_instance_from_dict():
    test_create_instance(request_type=dict)


@pytest.mark.asyncio
async def test_create_instance_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.CreateInstanceRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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

        assert args[0] == bigtable_instance_admin.CreateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_instance_async_from_dict():
    await test_create_instance_async(request_type=dict)


def test_create_instance_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateInstanceRequest()
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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateInstanceRequest()
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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
            instance_id='instance_id_value',
            instance=gba_instance.Instance(name='name_value'),
            clusters={'key_value': gba_instance.Cluster(name='name_value')},
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].instance_id == 'instance_id_value'

        assert args[0].instance == gba_instance.Instance(name='name_value')

        assert args[0].clusters == {'key_value': gba_instance.Cluster(name='name_value')}


def test_create_instance_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_instance(
            bigtable_instance_admin.CreateInstanceRequest(),
            parent='parent_value',
            instance_id='instance_id_value',
            instance=gba_instance.Instance(name='name_value'),
            clusters={'key_value': gba_instance.Cluster(name='name_value')},
        )


@pytest.mark.asyncio
async def test_create_instance_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
            instance_id='instance_id_value',
            instance=gba_instance.Instance(name='name_value'),
            clusters={'key_value': gba_instance.Cluster(name='name_value')},
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].instance_id == 'instance_id_value'

        assert args[0].instance == gba_instance.Instance(name='name_value')

        assert args[0].clusters == {'key_value': gba_instance.Cluster(name='name_value')}


@pytest.mark.asyncio
async def test_create_instance_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_instance(
            bigtable_instance_admin.CreateInstanceRequest(),
            parent='parent_value',
            instance_id='instance_id_value',
            instance=gba_instance.Instance(name='name_value'),
            clusters={'key_value': gba_instance.Cluster(name='name_value')},
        )


def test_get_instance(transport: str = 'grpc', request_type=bigtable_instance_admin.GetInstanceRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = instance.Instance(
            name='name_value',

            display_name='display_name_value',

            state=instance.Instance.State.READY,

            type_=instance.Instance.Type.PRODUCTION,

        )

        response = client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetInstanceRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, instance.Instance)

    assert response.name == 'name_value'

    assert response.display_name == 'display_name_value'

    assert response.state == instance.Instance.State.READY

    assert response.type_ == instance.Instance.Type.PRODUCTION


def test_get_instance_from_dict():
    test_get_instance(request_type=dict)


@pytest.mark.asyncio
async def test_get_instance_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.GetInstanceRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Instance(
            name='name_value',
            display_name='display_name_value',
            state=instance.Instance.State.READY,
            type_=instance.Instance.Type.PRODUCTION,
        ))

        response = await client.get_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, instance.Instance)

    assert response.name == 'name_value'

    assert response.display_name == 'display_name_value'

    assert response.state == instance.Instance.State.READY

    assert response.type_ == instance.Instance.Type.PRODUCTION


@pytest.mark.asyncio
async def test_get_instance_async_from_dict():
    await test_get_instance_async(request_type=dict)


def test_get_instance_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetInstanceRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = instance.Instance()

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetInstanceRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Instance())

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.Instance()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_get_instance_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_instance(
            bigtable_instance_admin.GetInstanceRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_instance_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.Instance()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Instance())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_instance(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_instance_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_instance(
            bigtable_instance_admin.GetInstanceRequest(),
            name='name_value',
        )


def test_list_instances(transport: str = 'grpc', request_type=bigtable_instance_admin.ListInstancesRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = bigtable_instance_admin.ListInstancesResponse(
            failed_locations=['failed_locations_value'],

            next_page_token='next_page_token_value',

        )

        response = client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListInstancesRequest()

    # Establish that the response is the type that we expect.

    assert response.raw_page is response

    assert isinstance(response, bigtable_instance_admin.ListInstancesResponse)

    assert response.failed_locations == ['failed_locations_value']

    assert response.next_page_token == 'next_page_token_value'


def test_list_instances_from_dict():
    test_list_instances(request_type=dict)


@pytest.mark.asyncio
async def test_list_instances_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.ListInstancesRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListInstancesResponse(
            failed_locations=['failed_locations_value'],
            next_page_token='next_page_token_value',
        ))

        response = await client.list_instances(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListInstancesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, bigtable_instance_admin.ListInstancesResponse)

    assert response.failed_locations == ['failed_locations_value']

    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_instances_async_from_dict():
    await test_list_instances_async(request_type=dict)


def test_list_instances_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListInstancesRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = bigtable_instance_admin.ListInstancesResponse()

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListInstancesRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListInstancesResponse())

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListInstancesResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_instances(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


def test_list_instances_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_instances(
            bigtable_instance_admin.ListInstancesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_instances_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_instances),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListInstancesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListInstancesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_instances(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_instances_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_instances(
            bigtable_instance_admin.ListInstancesRequest(),
            parent='parent_value',
        )


def test_update_instance(transport: str = 'grpc', request_type=instance.Instance):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = instance.Instance(
            name='name_value',

            display_name='display_name_value',

            state=instance.Instance.State.READY,

            type_=instance.Instance.Type.PRODUCTION,

        )

        response = client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == instance.Instance()

    # Establish that the response is the type that we expect.

    assert isinstance(response, instance.Instance)

    assert response.name == 'name_value'

    assert response.display_name == 'display_name_value'

    assert response.state == instance.Instance.State.READY

    assert response.type_ == instance.Instance.Type.PRODUCTION


def test_update_instance_from_dict():
    test_update_instance(request_type=dict)


@pytest.mark.asyncio
async def test_update_instance_async(transport: str = 'grpc_asyncio', request_type=instance.Instance):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Instance(
            name='name_value',
            display_name='display_name_value',
            state=instance.Instance.State.READY,
            type_=instance.Instance.Type.PRODUCTION,
        ))

        response = await client.update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == instance.Instance()

    # Establish that the response is the type that we expect.
    assert isinstance(response, instance.Instance)

    assert response.name == 'name_value'

    assert response.display_name == 'display_name_value'

    assert response.state == instance.Instance.State.READY

    assert response.type_ == instance.Instance.Type.PRODUCTION


@pytest.mark.asyncio
async def test_update_instance_async_from_dict():
    await test_update_instance_async(request_type=dict)


def test_update_instance_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = instance.Instance()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        call.return_value = instance.Instance()

        client.update_instance(request)

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
async def test_update_instance_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = instance.Instance()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Instance())

        await client.update_instance(request)

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


def test_partial_update_instance(transport: str = 'grpc', request_type=bigtable_instance_admin.PartialUpdateInstanceRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.partial_update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.PartialUpdateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_partial_update_instance_from_dict():
    test_partial_update_instance(request_type=dict)


@pytest.mark.asyncio
async def test_partial_update_instance_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.PartialUpdateInstanceRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.partial_update_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.PartialUpdateInstanceRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_partial_update_instance_async_from_dict():
    await test_partial_update_instance_async(request_type=dict)


def test_partial_update_instance_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.PartialUpdateInstanceRequest()
    request.instance.name = 'instance.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.partial_update_instance(request)

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
async def test_partial_update_instance_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.PartialUpdateInstanceRequest()
    request.instance.name = 'instance.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.partial_update_instance(request)

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


def test_partial_update_instance_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.partial_update_instance(
            instance=gba_instance.Instance(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].instance == gba_instance.Instance(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


def test_partial_update_instance_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.partial_update_instance(
            bigtable_instance_admin.PartialUpdateInstanceRequest(),
            instance=gba_instance.Instance(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_partial_update_instance_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.partial_update_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.partial_update_instance(
            instance=gba_instance.Instance(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].instance == gba_instance.Instance(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_partial_update_instance_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.partial_update_instance(
            bigtable_instance_admin.PartialUpdateInstanceRequest(),
            instance=gba_instance.Instance(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


def test_delete_instance(transport: str = 'grpc', request_type=bigtable_instance_admin.DeleteInstanceRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = None

        response = client.delete_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteInstanceRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_instance_from_dict():
    test_delete_instance(request_type=dict)


@pytest.mark.asyncio
async def test_delete_instance_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.DeleteInstanceRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

        response = await client.delete_instance(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteInstanceRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_instance_async_from_dict():
    await test_delete_instance_async(request_type=dict)


def test_delete_instance_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteInstanceRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        call.return_value = None

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteInstanceRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_instance(
            bigtable_instance_admin.DeleteInstanceRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_instance_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_instance),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_instance(
            bigtable_instance_admin.DeleteInstanceRequest(),
            name='name_value',
        )


def test_create_cluster(transport: str = 'grpc', request_type=bigtable_instance_admin.CreateClusterRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.CreateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_cluster_from_dict():
    test_create_cluster(request_type=dict)


@pytest.mark.asyncio
async def test_create_cluster_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.CreateClusterRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.CreateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_cluster_async_from_dict():
    await test_create_cluster_async(request_type=dict)


def test_create_cluster_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateClusterRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.create_cluster(request)

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
async def test_create_cluster_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateClusterRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.create_cluster(request)

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


def test_create_cluster_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_cluster(
            parent='parent_value',
            cluster_id='cluster_id_value',
            cluster=instance.Cluster(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].cluster_id == 'cluster_id_value'

        assert args[0].cluster == instance.Cluster(name='name_value')


def test_create_cluster_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_cluster(
            bigtable_instance_admin.CreateClusterRequest(),
            parent='parent_value',
            cluster_id='cluster_id_value',
            cluster=instance.Cluster(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_cluster_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_cluster(
            parent='parent_value',
            cluster_id='cluster_id_value',
            cluster=instance.Cluster(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].cluster_id == 'cluster_id_value'

        assert args[0].cluster == instance.Cluster(name='name_value')


@pytest.mark.asyncio
async def test_create_cluster_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_cluster(
            bigtable_instance_admin.CreateClusterRequest(),
            parent='parent_value',
            cluster_id='cluster_id_value',
            cluster=instance.Cluster(name='name_value'),
        )


def test_get_cluster(transport: str = 'grpc', request_type=bigtable_instance_admin.GetClusterRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.Cluster(
            name='name_value',

            location='location_value',

            state=instance.Cluster.State.READY,

            serve_nodes=1181,

            default_storage_type=common.StorageType.SSD,

        )

        response = client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetClusterRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, instance.Cluster)

    assert response.name == 'name_value'

    assert response.location == 'location_value'

    assert response.state == instance.Cluster.State.READY

    assert response.serve_nodes == 1181

    assert response.default_storage_type == common.StorageType.SSD


def test_get_cluster_from_dict():
    test_get_cluster(request_type=dict)


@pytest.mark.asyncio
async def test_get_cluster_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.GetClusterRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Cluster(
            name='name_value',
            location='location_value',
            state=instance.Cluster.State.READY,
            serve_nodes=1181,
            default_storage_type=common.StorageType.SSD,
        ))

        response = await client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, instance.Cluster)

    assert response.name == 'name_value'

    assert response.location == 'location_value'

    assert response.state == instance.Cluster.State.READY

    assert response.serve_nodes == 1181

    assert response.default_storage_type == common.StorageType.SSD


@pytest.mark.asyncio
async def test_get_cluster_async_from_dict():
    await test_get_cluster_async(request_type=dict)


def test_get_cluster_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        call.return_value = instance.Cluster()

        client.get_cluster(request)

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
async def test_get_cluster_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Cluster())

        await client.get_cluster(request)

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


def test_get_cluster_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.Cluster()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_get_cluster_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_cluster(
            bigtable_instance_admin.GetClusterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_cluster_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.Cluster()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.Cluster())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_cluster_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_cluster(
            bigtable_instance_admin.GetClusterRequest(),
            name='name_value',
        )


def test_list_clusters(transport: str = 'grpc', request_type=bigtable_instance_admin.ListClustersRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListClustersResponse(
            failed_locations=['failed_locations_value'],

            next_page_token='next_page_token_value',

        )

        response = client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListClustersRequest()

    # Establish that the response is the type that we expect.

    assert response.raw_page is response

    assert isinstance(response, bigtable_instance_admin.ListClustersResponse)

    assert response.failed_locations == ['failed_locations_value']

    assert response.next_page_token == 'next_page_token_value'


def test_list_clusters_from_dict():
    test_list_clusters(request_type=dict)


@pytest.mark.asyncio
async def test_list_clusters_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.ListClustersRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListClustersResponse(
            failed_locations=['failed_locations_value'],
            next_page_token='next_page_token_value',
        ))

        response = await client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListClustersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, bigtable_instance_admin.ListClustersResponse)

    assert response.failed_locations == ['failed_locations_value']

    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_clusters_async_from_dict():
    await test_list_clusters_async(request_type=dict)


def test_list_clusters_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListClustersRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        call.return_value = bigtable_instance_admin.ListClustersResponse()

        client.list_clusters(request)

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
async def test_list_clusters_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListClustersRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListClustersResponse())

        await client.list_clusters(request)

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


def test_list_clusters_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListClustersResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_clusters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


def test_list_clusters_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_clusters(
            bigtable_instance_admin.ListClustersRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_clusters_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListClustersResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListClustersResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_clusters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_clusters_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_clusters(
            bigtable_instance_admin.ListClustersRequest(),
            parent='parent_value',
        )


def test_update_cluster(transport: str = 'grpc', request_type=instance.Cluster):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == instance.Cluster()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_cluster_from_dict():
    test_update_cluster(request_type=dict)


@pytest.mark.asyncio
async def test_update_cluster_async(transport: str = 'grpc_asyncio', request_type=instance.Cluster):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == instance.Cluster()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_cluster_async_from_dict():
    await test_update_cluster_async(request_type=dict)


def test_update_cluster_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = instance.Cluster()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.update_cluster(request)

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
async def test_update_cluster_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = instance.Cluster()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.update_cluster(request)

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


def test_delete_cluster(transport: str = 'grpc', request_type=bigtable_instance_admin.DeleteClusterRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        response = client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteClusterRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_cluster_from_dict():
    test_delete_cluster(request_type=dict)


@pytest.mark.asyncio
async def test_delete_cluster_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.DeleteClusterRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

        response = await client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteClusterRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_cluster_async_from_dict():
    await test_delete_cluster_async(request_type=dict)


def test_delete_cluster_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        call.return_value = None

        client.delete_cluster(request)

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
async def test_delete_cluster_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

        await client.delete_cluster(request)

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


def test_delete_cluster_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_delete_cluster_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_cluster(
            bigtable_instance_admin.DeleteClusterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_cluster_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_cluster_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_cluster(
            bigtable_instance_admin.DeleteClusterRequest(),
            name='name_value',
        )


def test_create_app_profile(transport: str = 'grpc', request_type=bigtable_instance_admin.CreateAppProfileRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile(
            name='name_value',

            etag='etag_value',

            description='description_value',

            multi_cluster_routing_use_any=None,
        )

        response = client.create_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.CreateAppProfileRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, instance.AppProfile)

    assert response.name == 'name_value'

    assert response.etag == 'etag_value'

    assert response.description == 'description_value'


def test_create_app_profile_from_dict():
    test_create_app_profile(request_type=dict)


@pytest.mark.asyncio
async def test_create_app_profile_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.CreateAppProfileRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile(
            name='name_value',
            etag='etag_value',
            description='description_value',
        ))

        response = await client.create_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.CreateAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, instance.AppProfile)

    assert response.name == 'name_value'

    assert response.etag == 'etag_value'

    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_create_app_profile_async_from_dict():
    await test_create_app_profile_async(request_type=dict)


def test_create_app_profile_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateAppProfileRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        call.return_value = instance.AppProfile()

        client.create_app_profile(request)

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
async def test_create_app_profile_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.CreateAppProfileRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile())

        await client.create_app_profile(request)

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


def test_create_app_profile_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_app_profile(
            parent='parent_value',
            app_profile_id='app_profile_id_value',
            app_profile=instance.AppProfile(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].app_profile_id == 'app_profile_id_value'

        assert args[0].app_profile == instance.AppProfile(name='name_value')


def test_create_app_profile_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_app_profile(
            bigtable_instance_admin.CreateAppProfileRequest(),
            parent='parent_value',
            app_profile_id='app_profile_id_value',
            app_profile=instance.AppProfile(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_app_profile_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_app_profile(
            parent='parent_value',
            app_profile_id='app_profile_id_value',
            app_profile=instance.AppProfile(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].app_profile_id == 'app_profile_id_value'

        assert args[0].app_profile == instance.AppProfile(name='name_value')


@pytest.mark.asyncio
async def test_create_app_profile_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_app_profile(
            bigtable_instance_admin.CreateAppProfileRequest(),
            parent='parent_value',
            app_profile_id='app_profile_id_value',
            app_profile=instance.AppProfile(name='name_value'),
        )


def test_get_app_profile(transport: str = 'grpc', request_type=bigtable_instance_admin.GetAppProfileRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile(
            name='name_value',

            etag='etag_value',

            description='description_value',

            multi_cluster_routing_use_any=None,
        )

        response = client.get_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetAppProfileRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, instance.AppProfile)

    assert response.name == 'name_value'

    assert response.etag == 'etag_value'

    assert response.description == 'description_value'


def test_get_app_profile_from_dict():
    test_get_app_profile(request_type=dict)


@pytest.mark.asyncio
async def test_get_app_profile_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.GetAppProfileRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile(
            name='name_value',
            etag='etag_value',
            description='description_value',
        ))

        response = await client.get_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.GetAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, instance.AppProfile)

    assert response.name == 'name_value'

    assert response.etag == 'etag_value'

    assert response.description == 'description_value'


@pytest.mark.asyncio
async def test_get_app_profile_async_from_dict():
    await test_get_app_profile_async(request_type=dict)


def test_get_app_profile_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetAppProfileRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        call.return_value = instance.AppProfile()

        client.get_app_profile(request)

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
async def test_get_app_profile_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.GetAppProfileRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile())

        await client.get_app_profile(request)

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


def test_get_app_profile_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_app_profile(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_get_app_profile_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_app_profile(
            bigtable_instance_admin.GetAppProfileRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_app_profile_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = instance.AppProfile()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(instance.AppProfile())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_app_profile(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_app_profile_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_app_profile(
            bigtable_instance_admin.GetAppProfileRequest(),
            name='name_value',
        )


def test_list_app_profiles(transport: str = 'grpc', request_type=bigtable_instance_admin.ListAppProfilesRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListAppProfilesResponse(
            next_page_token='next_page_token_value',

            failed_locations=['failed_locations_value'],

        )

        response = client.list_app_profiles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListAppProfilesRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, pagers.ListAppProfilesPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.failed_locations == ['failed_locations_value']


def test_list_app_profiles_from_dict():
    test_list_app_profiles(request_type=dict)


@pytest.mark.asyncio
async def test_list_app_profiles_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.ListAppProfilesRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListAppProfilesResponse(
            next_page_token='next_page_token_value',
            failed_locations=['failed_locations_value'],
        ))

        response = await client.list_app_profiles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.ListAppProfilesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListAppProfilesAsyncPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.failed_locations == ['failed_locations_value']


@pytest.mark.asyncio
async def test_list_app_profiles_async_from_dict():
    await test_list_app_profiles_async(request_type=dict)


def test_list_app_profiles_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListAppProfilesRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        call.return_value = bigtable_instance_admin.ListAppProfilesResponse()

        client.list_app_profiles(request)

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
async def test_list_app_profiles_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.ListAppProfilesRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListAppProfilesResponse())

        await client.list_app_profiles(request)

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


def test_list_app_profiles_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListAppProfilesResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_app_profiles(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


def test_list_app_profiles_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_app_profiles(
            bigtable_instance_admin.ListAppProfilesRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_app_profiles_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = bigtable_instance_admin.ListAppProfilesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(bigtable_instance_admin.ListAppProfilesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_app_profiles(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_app_profiles_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_app_profiles(
            bigtable_instance_admin.ListAppProfilesRequest(),
            parent='parent_value',
        )


def test_list_app_profiles_pager():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
                next_page_token='abc',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[],
                next_page_token='def',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                ],
                next_page_token='ghi',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
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
        pager = client.list_app_profiles(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, instance.AppProfile)
                   for i in results)

def test_list_app_profiles_pages():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
                next_page_token='abc',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[],
                next_page_token='def',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                ],
                next_page_token='ghi',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_app_profiles(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_app_profiles_async_pager():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
                next_page_token='abc',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[],
                next_page_token='def',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                ],
                next_page_token='ghi',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_app_profiles(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, instance.AppProfile)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_app_profiles_async_pages():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_app_profiles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
                next_page_token='abc',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[],
                next_page_token='def',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                ],
                next_page_token='ghi',
            ),
            bigtable_instance_admin.ListAppProfilesResponse(
                app_profiles=[
                    instance.AppProfile(),
                    instance.AppProfile(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_app_profiles(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_update_app_profile(transport: str = 'grpc', request_type=bigtable_instance_admin.UpdateAppProfileRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.update_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.UpdateAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_app_profile_from_dict():
    test_update_app_profile(request_type=dict)


@pytest.mark.asyncio
async def test_update_app_profile_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.UpdateAppProfileRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.update_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.UpdateAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_app_profile_async_from_dict():
    await test_update_app_profile_async(request_type=dict)


def test_update_app_profile_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.UpdateAppProfileRequest()
    request.app_profile.name = 'app_profile.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.update_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'app_profile.name=app_profile.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_app_profile_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.UpdateAppProfileRequest()
    request.app_profile.name = 'app_profile.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.update_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'app_profile.name=app_profile.name/value',
    ) in kw['metadata']


def test_update_app_profile_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_app_profile(
            app_profile=instance.AppProfile(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].app_profile == instance.AppProfile(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


def test_update_app_profile_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_app_profile(
            bigtable_instance_admin.UpdateAppProfileRequest(),
            app_profile=instance.AppProfile(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_app_profile_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_app_profile(
            app_profile=instance.AppProfile(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].app_profile == instance.AppProfile(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_update_app_profile_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_app_profile(
            bigtable_instance_admin.UpdateAppProfileRequest(),
            app_profile=instance.AppProfile(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


def test_delete_app_profile(transport: str = 'grpc', request_type=bigtable_instance_admin.DeleteAppProfileRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        response = client.delete_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_app_profile_from_dict():
    test_delete_app_profile(request_type=dict)


@pytest.mark.asyncio
async def test_delete_app_profile_async(transport: str = 'grpc_asyncio', request_type=bigtable_instance_admin.DeleteAppProfileRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

        response = await client.delete_app_profile(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == bigtable_instance_admin.DeleteAppProfileRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_app_profile_async_from_dict():
    await test_delete_app_profile_async(request_type=dict)


def test_delete_app_profile_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteAppProfileRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        call.return_value = None

        client.delete_app_profile(request)

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
async def test_delete_app_profile_field_headers_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = bigtable_instance_admin.DeleteAppProfileRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)

        await client.delete_app_profile(request)

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


def test_delete_app_profile_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_app_profile(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_delete_app_profile_flattened_error():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_app_profile(
            bigtable_instance_admin.DeleteAppProfileRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_app_profile_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_app_profile),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_app_profile(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_app_profile_flattened_error_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_app_profile(
            bigtable_instance_admin.DeleteAppProfileRequest(),
            name='name_value',
        )


def test_get_iam_policy(transport: str = 'grpc', request_type=iam_policy.GetIamPolicyRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = policy.Policy(
            version=774,

            etag=b'etag_blob',

        )

        response = client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, policy.Policy)

    assert response.version == 774

    assert response.etag == b'etag_blob'


def test_get_iam_policy_from_dict():
    test_get_iam_policy(request_type=dict)


@pytest.mark.asyncio
async def test_get_iam_policy_async(transport: str = 'grpc_asyncio', request_type=iam_policy.GetIamPolicyRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy(
            version=774,
            etag=b'etag_blob',
        ))

        response = await client.get_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.GetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy.Policy)

    assert response.version == 774

    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_get_iam_policy_async_from_dict():
    await test_get_iam_policy_async(request_type=dict)


def test_get_iam_policy_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.GetIamPolicyRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        call.return_value = policy.Policy()

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.GetIamPolicyRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy())

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

        response = client.get_iam_policy(request={
            'resource': 'resource_value',
            'options': options.GetPolicyOptions(requested_policy_version=2598),
            }
        )
        call.assert_called()


def test_get_iam_policy_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_iam_policy(
            iam_policy.GetIamPolicyRequest(),
            resource='resource_value',
        )


@pytest.mark.asyncio
async def test_get_iam_policy_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy())
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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_iam_policy(
            iam_policy.GetIamPolicyRequest(),
            resource='resource_value',
        )


def test_set_iam_policy(transport: str = 'grpc', request_type=iam_policy.SetIamPolicyRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = policy.Policy(
            version=774,

            etag=b'etag_blob',

        )

        response = client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, policy.Policy)

    assert response.version == 774

    assert response.etag == b'etag_blob'


def test_set_iam_policy_from_dict():
    test_set_iam_policy(request_type=dict)


@pytest.mark.asyncio
async def test_set_iam_policy_async(transport: str = 'grpc_asyncio', request_type=iam_policy.SetIamPolicyRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy(
            version=774,
            etag=b'etag_blob',
        ))

        response = await client.set_iam_policy(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.SetIamPolicyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, policy.Policy)

    assert response.version == 774

    assert response.etag == b'etag_blob'


@pytest.mark.asyncio
async def test_set_iam_policy_async_from_dict():
    await test_set_iam_policy_async(request_type=dict)


def test_set_iam_policy_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.SetIamPolicyRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        call.return_value = policy.Policy()

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.SetIamPolicyRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy())

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

        response = client.set_iam_policy(request={
            'resource': 'resource_value',
            'policy': policy.Policy(version=774),
            }
        )
        call.assert_called()


def test_set_iam_policy_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.set_iam_policy(
            iam_policy.SetIamPolicyRequest(),
            resource='resource_value',
        )


@pytest.mark.asyncio
async def test_set_iam_policy_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.set_iam_policy),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = policy.Policy()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(policy.Policy())
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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.set_iam_policy(
            iam_policy.SetIamPolicyRequest(),
            resource='resource_value',
        )


def test_test_iam_permissions(transport: str = 'grpc', request_type=iam_policy.TestIamPermissionsRequest):
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = iam_policy.TestIamPermissionsResponse(
            permissions=['permissions_value'],

        )

        response = client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, iam_policy.TestIamPermissionsResponse)

    assert response.permissions == ['permissions_value']


def test_test_iam_permissions_from_dict():
    test_test_iam_permissions(request_type=dict)


@pytest.mark.asyncio
async def test_test_iam_permissions_async(transport: str = 'grpc_asyncio', request_type=iam_policy.TestIamPermissionsRequest):
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam_policy.TestIamPermissionsResponse(
            permissions=['permissions_value'],
        ))

        response = await client.test_iam_permissions(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == iam_policy.TestIamPermissionsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, iam_policy.TestIamPermissionsResponse)

    assert response.permissions == ['permissions_value']


@pytest.mark.asyncio
async def test_test_iam_permissions_async_from_dict():
    await test_test_iam_permissions_async(request_type=dict)


def test_test_iam_permissions_field_headers():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.TestIamPermissionsRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        call.return_value = iam_policy.TestIamPermissionsResponse()

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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = iam_policy.TestIamPermissionsRequest()
    request.resource = 'resource/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam_policy.TestIamPermissionsResponse())

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )
    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy.TestIamPermissionsResponse()

        response = client.test_iam_permissions(request={
            'resource': 'resource_value',
            'permissions': ['permissions_value'],
            }
        )
        call.assert_called()


def test_test_iam_permissions_flattened():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy.TestIamPermissionsResponse()

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
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.test_iam_permissions(
            iam_policy.TestIamPermissionsRequest(),
            resource='resource_value',
            permissions=['permissions_value'],
        )


@pytest.mark.asyncio
async def test_test_iam_permissions_flattened_async():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.test_iam_permissions),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iam_policy.TestIamPermissionsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(iam_policy.TestIamPermissionsResponse())
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
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.test_iam_permissions(
            iam_policy.TestIamPermissionsRequest(),
            resource='resource_value',
            permissions=['permissions_value'],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigtableInstanceAdminClient(
            credentials=credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigtableInstanceAdminClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BigtableInstanceAdminClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    client = BigtableInstanceAdminClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.BigtableInstanceAdminGrpcAsyncIOTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


@pytest.mark.parametrize("transport_class", [
    transports.BigtableInstanceAdminGrpcTransport,
    transports.BigtableInstanceAdminGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.BigtableInstanceAdminGrpcTransport,
    )


def test_bigtable_instance_admin_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(exceptions.DuplicateCredentialArgs):
        transport = transports.BigtableInstanceAdminTransport(
            credentials=credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_bigtable_instance_admin_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.bigtable_admin_v2.services.bigtable_instance_admin.transports.BigtableInstanceAdminTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.BigtableInstanceAdminTransport(
            credentials=credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_instance',
        'get_instance',
        'list_instances',
        'update_instance',
        'partial_update_instance',
        'delete_instance',
        'create_cluster',
        'get_cluster',
        'list_clusters',
        'update_cluster',
        'delete_cluster',
        'create_app_profile',
        'get_app_profile',
        'list_app_profiles',
        'update_app_profile',
        'delete_app_profile',
        'get_iam_policy',
        'set_iam_policy',
        'test_iam_permissions',
        )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_bigtable_instance_admin_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(auth, 'load_credentials_from_file') as load_creds, mock.patch('google.cloud.bigtable_admin_v2.services.bigtable_instance_admin.transports.BigtableInstanceAdminTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.BigtableInstanceAdminTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/bigtable.admin',
            'https://www.googleapis.com/auth/bigtable.admin.cluster',
            'https://www.googleapis.com/auth/bigtable.admin.instance',
            'https://www.googleapis.com/auth/cloud-bigtable.admin',
            'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',
            ),
            quota_project_id="octopus",
        )


def test_bigtable_instance_admin_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(auth, 'default') as adc, mock.patch('google.cloud.bigtable_admin_v2.services.bigtable_instance_admin.transports.BigtableInstanceAdminTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.BigtableInstanceAdminTransport()
        adc.assert_called_once()


def test_bigtable_instance_admin_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        BigtableInstanceAdminClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/bigtable.admin',
            'https://www.googleapis.com/auth/bigtable.admin.cluster',
            'https://www.googleapis.com/auth/bigtable.admin.instance',
            'https://www.googleapis.com/auth/cloud-bigtable.admin',
            'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',),
            quota_project_id=None,
        )


def test_bigtable_instance_admin_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transports.BigtableInstanceAdminGrpcTransport(host="squid.clam.whelk", quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/bigtable.admin',
            'https://www.googleapis.com/auth/bigtable.admin.cluster',
            'https://www.googleapis.com/auth/bigtable.admin.instance',
            'https://www.googleapis.com/auth/cloud-bigtable.admin',
            'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
            'https://www.googleapis.com/auth/cloud-platform',
            'https://www.googleapis.com/auth/cloud-platform.read-only',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize("transport_class", [transports.BigtableInstanceAdminGrpcTransport, transports.BigtableInstanceAdminGrpcAsyncIOTransport])
def test_bigtable_instance_admin_grpc_transport_client_cert_source_for_mtls(
    transport_class
):
    cred = credentials.AnonymousCredentials()

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
                'https://www.googleapis.com/auth/bigtable.admin',
                'https://www.googleapis.com/auth/bigtable.admin.cluster',
                'https://www.googleapis.com/auth/bigtable.admin.instance',
                'https://www.googleapis.com/auth/cloud-bigtable.admin',
                'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
                'https://www.googleapis.com/auth/cloud-platform',
                'https://www.googleapis.com/auth/cloud-platform.read-only',
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


def test_bigtable_instance_admin_host_no_port():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='bigtableadmin.googleapis.com'),
    )
    assert client.transport._host == 'bigtableadmin.googleapis.com:443'


def test_bigtable_instance_admin_host_with_port():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='bigtableadmin.googleapis.com:8000'),
    )
    assert client.transport._host == 'bigtableadmin.googleapis.com:8000'


def test_bigtable_instance_admin_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BigtableInstanceAdminGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_bigtable_instance_admin_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BigtableInstanceAdminGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.BigtableInstanceAdminGrpcTransport, transports.BigtableInstanceAdminGrpcAsyncIOTransport])
def test_bigtable_instance_admin_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_ssl_cred = mock.Mock()
            grpc_ssl_channel_cred.return_value = mock_ssl_cred

            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel

            cred = credentials.AnonymousCredentials()
            with pytest.warns(DeprecationWarning):
                with mock.patch.object(auth, 'default') as adc:
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
                    'https://www.googleapis.com/auth/bigtable.admin',
                    'https://www.googleapis.com/auth/bigtable.admin.cluster',
                    'https://www.googleapis.com/auth/bigtable.admin.instance',
                    'https://www.googleapis.com/auth/cloud-bigtable.admin',
                    'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
                    'https://www.googleapis.com/auth/cloud-platform',
                    'https://www.googleapis.com/auth/cloud-platform.read-only',
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
@pytest.mark.parametrize("transport_class", [transports.BigtableInstanceAdminGrpcTransport, transports.BigtableInstanceAdminGrpcAsyncIOTransport])
def test_bigtable_instance_admin_transport_channel_mtls_with_adc(
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
                    'https://www.googleapis.com/auth/bigtable.admin',
                    'https://www.googleapis.com/auth/bigtable.admin.cluster',
                    'https://www.googleapis.com/auth/bigtable.admin.instance',
                    'https://www.googleapis.com/auth/cloud-bigtable.admin',
                    'https://www.googleapis.com/auth/cloud-bigtable.admin.cluster',
                    'https://www.googleapis.com/auth/cloud-platform',
                    'https://www.googleapis.com/auth/cloud-platform.read-only',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_bigtable_instance_admin_grpc_lro_client():
    client = BigtableInstanceAdminClient(
        credentials=credentials.AnonymousCredentials(),
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


def test_bigtable_instance_admin_grpc_lro_async_client():
    client = BigtableInstanceAdminAsyncClient(
        credentials=credentials.AnonymousCredentials(),
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


def test_app_profile_path():
    project = "squid"
    instance = "clam"
    app_profile = "whelk"

    expected = "projects/{project}/instances/{instance}/appProfiles/{app_profile}".format(project=project, instance=instance, app_profile=app_profile, )
    actual = BigtableInstanceAdminClient.app_profile_path(project, instance, app_profile)
    assert expected == actual


def test_parse_app_profile_path():
    expected = {
    "project": "octopus",
    "instance": "oyster",
    "app_profile": "nudibranch",

    }
    path = BigtableInstanceAdminClient.app_profile_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_app_profile_path(path)
    assert expected == actual

def test_cluster_path():
    project = "cuttlefish"
    instance = "mussel"
    cluster = "winkle"

    expected = "projects/{project}/instances/{instance}/clusters/{cluster}".format(project=project, instance=instance, cluster=cluster, )
    actual = BigtableInstanceAdminClient.cluster_path(project, instance, cluster)
    assert expected == actual


def test_parse_cluster_path():
    expected = {
    "project": "nautilus",
    "instance": "scallop",
    "cluster": "abalone",

    }
    path = BigtableInstanceAdminClient.cluster_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_cluster_path(path)
    assert expected == actual

def test_instance_path():
    project = "squid"
    instance = "clam"

    expected = "projects/{project}/instances/{instance}".format(project=project, instance=instance, )
    actual = BigtableInstanceAdminClient.instance_path(project, instance)
    assert expected == actual


def test_parse_instance_path():
    expected = {
    "project": "whelk",
    "instance": "octopus",

    }
    path = BigtableInstanceAdminClient.instance_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_instance_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"

    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = BigtableInstanceAdminClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
    "billing_account": "nudibranch",

    }
    path = BigtableInstanceAdminClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"

    expected = "folders/{folder}".format(folder=folder, )
    actual = BigtableInstanceAdminClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
    "folder": "mussel",

    }
    path = BigtableInstanceAdminClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"

    expected = "organizations/{organization}".format(organization=organization, )
    actual = BigtableInstanceAdminClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
    "organization": "nautilus",

    }
    path = BigtableInstanceAdminClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"

    expected = "projects/{project}".format(project=project, )
    actual = BigtableInstanceAdminClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
    "project": "abalone",

    }
    path = BigtableInstanceAdminClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"

    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = BigtableInstanceAdminClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
    "project": "whelk",
    "location": "octopus",

    }
    path = BigtableInstanceAdminClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = BigtableInstanceAdminClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.BigtableInstanceAdminTransport, '_prep_wrapped_messages') as prep:
        client = BigtableInstanceAdminClient(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.BigtableInstanceAdminTransport, '_prep_wrapped_messages') as prep:
        transport_class = BigtableInstanceAdminClient.get_transport_class()
        transport = transport_class(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)