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
from google.oauth2 import service_account
from google.protobuf import duration_pb2  # type: ignore
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore
from maps.fleetengine_v1.services.vehicle_service import VehicleServiceAsyncClient
from maps.fleetengine_v1.services.vehicle_service import VehicleServiceClient
from maps.fleetengine_v1.services.vehicle_service import pagers
from maps.fleetengine_v1.services.vehicle_service import transports
from maps.fleetengine_v1.types import fleetengine
from maps.fleetengine_v1.types import header
from maps.fleetengine_v1.types import traffic
from maps.fleetengine_v1.types import vehicle_api
from maps.fleetengine_v1.types import vehicles
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

    assert VehicleServiceClient._get_default_mtls_endpoint(None) is None
    assert VehicleServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert VehicleServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert VehicleServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert VehicleServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert VehicleServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    VehicleServiceClient,
    VehicleServiceAsyncClient,
])
def test_vehicle_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'fleetengine.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.VehicleServiceGrpcTransport, "grpc"),
    (transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_vehicle_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    VehicleServiceClient,
    VehicleServiceAsyncClient,
])
def test_vehicle_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'fleetengine.googleapis.com:443'


def test_vehicle_service_client_get_transport_class():
    transport = VehicleServiceClient.get_transport_class()
    available_transports = [
        transports.VehicleServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = VehicleServiceClient.get_transport_class("grpc")
    assert transport == transports.VehicleServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (VehicleServiceClient, transports.VehicleServiceGrpcTransport, "grpc"),
    (VehicleServiceAsyncClient, transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(VehicleServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(VehicleServiceClient))
@mock.patch.object(VehicleServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(VehicleServiceAsyncClient))
def test_vehicle_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(VehicleServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(VehicleServiceClient, 'get_transport_class') as gtc:
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
    (VehicleServiceClient, transports.VehicleServiceGrpcTransport, "grpc", "true"),
    (VehicleServiceAsyncClient, transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (VehicleServiceClient, transports.VehicleServiceGrpcTransport, "grpc", "false"),
    (VehicleServiceAsyncClient, transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(VehicleServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(VehicleServiceClient))
@mock.patch.object(VehicleServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(VehicleServiceAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_vehicle_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (VehicleServiceClient, transports.VehicleServiceGrpcTransport, "grpc"),
    (VehicleServiceAsyncClient, transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_vehicle_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (VehicleServiceClient, transports.VehicleServiceGrpcTransport, "grpc"),
    (VehicleServiceAsyncClient, transports.VehicleServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_vehicle_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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

def test_vehicle_service_client_client_options_from_dict():
    with mock.patch('maps.fleetengine_v1.services.vehicle_service.transports.VehicleServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = VehicleServiceClient(
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
  vehicle_api.CreateVehicleRequest,
  dict,
])
def test_create_vehicle(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        )
        response = client.create_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.CreateVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


def test_create_vehicle_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_vehicle),
            '__call__') as call:
        client.create_vehicle()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.CreateVehicleRequest()


@pytest.mark.asyncio
async def test_create_vehicle_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.CreateVehicleRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        ))
        response = await client.create_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.CreateVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


@pytest.mark.asyncio
async def test_create_vehicle_async_from_dict():
    await test_create_vehicle_async(request_type=dict)


def test_create_vehicle_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.CreateVehicleRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_vehicle),
            '__call__') as call:
        call.return_value = vehicles.Vehicle()
        client.create_vehicle(request)

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
async def test_create_vehicle_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.CreateVehicleRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_vehicle),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle())
        await client.create_vehicle(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.GetVehicleRequest,
  dict,
])
def test_get_vehicle(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        )
        response = client.get_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.GetVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


def test_get_vehicle_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_vehicle),
            '__call__') as call:
        client.get_vehicle()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.GetVehicleRequest()


@pytest.mark.asyncio
async def test_get_vehicle_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.GetVehicleRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        ))
        response = await client.get_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.GetVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


@pytest.mark.asyncio
async def test_get_vehicle_async_from_dict():
    await test_get_vehicle_async(request_type=dict)


def test_get_vehicle_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.GetVehicleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_vehicle),
            '__call__') as call:
        call.return_value = vehicles.Vehicle()
        client.get_vehicle(request)

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
async def test_get_vehicle_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.GetVehicleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_vehicle),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle())
        await client.get_vehicle(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.UpdateVehicleRequest,
  dict,
])
def test_update_vehicle(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        )
        response = client.update_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


def test_update_vehicle_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle),
            '__call__') as call:
        client.update_vehicle()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleRequest()


@pytest.mark.asyncio
async def test_update_vehicle_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.UpdateVehicleRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle(
            name='name_value',
            vehicle_state=vehicles.VehicleState.OFFLINE,
            supported_trip_types=[fleetengine.TripType.SHARED],
            current_trips=['current_trips_value'],
            maximum_capacity=1707,
            current_route_segment='current_route_segment_value',
            back_to_back_enabled=True,
            navigation_status=fleetengine.NavigationStatus.NO_GUIDANCE,
        ))
        response = await client.update_vehicle(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicles.Vehicle)
    assert response.name == 'name_value'
    assert response.vehicle_state == vehicles.VehicleState.OFFLINE
    assert response.supported_trip_types == [fleetengine.TripType.SHARED]
    assert response.current_trips == ['current_trips_value']
    assert response.maximum_capacity == 1707
    assert response.current_route_segment == 'current_route_segment_value'
    assert response.back_to_back_enabled is True
    assert response.navigation_status == fleetengine.NavigationStatus.NO_GUIDANCE


@pytest.mark.asyncio
async def test_update_vehicle_async_from_dict():
    await test_update_vehicle_async(request_type=dict)


def test_update_vehicle_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle),
            '__call__') as call:
        call.return_value = vehicles.Vehicle()
        client.update_vehicle(request)

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
async def test_update_vehicle_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicles.Vehicle())
        await client.update_vehicle(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.UpdateVehicleLocationRequest,
  dict,
])
def test_update_vehicle_location(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_location),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = fleetengine.VehicleLocation(
            location_sensor=fleetengine.LocationSensor.GPS,
            raw_location_sensor=fleetengine.LocationSensor.GPS,
            supplemental_location_sensor=fleetengine.LocationSensor.GPS,
            road_snapped=True,
        )
        response = client.update_vehicle_location(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleLocationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, fleetengine.VehicleLocation)
    assert response.location_sensor == fleetengine.LocationSensor.GPS
    assert response.raw_location_sensor == fleetengine.LocationSensor.GPS
    assert response.supplemental_location_sensor == fleetengine.LocationSensor.GPS
    assert response.road_snapped is True


def test_update_vehicle_location_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_location),
            '__call__') as call:
        client.update_vehicle_location()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleLocationRequest()


@pytest.mark.asyncio
async def test_update_vehicle_location_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.UpdateVehicleLocationRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_location),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(fleetengine.VehicleLocation(
            location_sensor=fleetengine.LocationSensor.GPS,
            raw_location_sensor=fleetengine.LocationSensor.GPS,
            supplemental_location_sensor=fleetengine.LocationSensor.GPS,
            road_snapped=True,
        ))
        response = await client.update_vehicle_location(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleLocationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, fleetengine.VehicleLocation)
    assert response.location_sensor == fleetengine.LocationSensor.GPS
    assert response.raw_location_sensor == fleetengine.LocationSensor.GPS
    assert response.supplemental_location_sensor == fleetengine.LocationSensor.GPS
    assert response.road_snapped is True


@pytest.mark.asyncio
async def test_update_vehicle_location_async_from_dict():
    await test_update_vehicle_location_async(request_type=dict)


def test_update_vehicle_location_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleLocationRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_location),
            '__call__') as call:
        call.return_value = fleetengine.VehicleLocation()
        client.update_vehicle_location(request)

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
async def test_update_vehicle_location_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleLocationRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_location),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(fleetengine.VehicleLocation())
        await client.update_vehicle_location(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.UpdateVehicleAttributesRequest,
  dict,
])
def test_update_vehicle_attributes(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_attributes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicle_api.UpdateVehicleAttributesResponse(
        )
        response = client.update_vehicle_attributes(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleAttributesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.UpdateVehicleAttributesResponse)


def test_update_vehicle_attributes_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_attributes),
            '__call__') as call:
        client.update_vehicle_attributes()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleAttributesRequest()


@pytest.mark.asyncio
async def test_update_vehicle_attributes_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.UpdateVehicleAttributesRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_attributes),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.UpdateVehicleAttributesResponse(
        ))
        response = await client.update_vehicle_attributes(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.UpdateVehicleAttributesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.UpdateVehicleAttributesResponse)


@pytest.mark.asyncio
async def test_update_vehicle_attributes_async_from_dict():
    await test_update_vehicle_attributes_async(request_type=dict)


def test_update_vehicle_attributes_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleAttributesRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_attributes),
            '__call__') as call:
        call.return_value = vehicle_api.UpdateVehicleAttributesResponse()
        client.update_vehicle_attributes(request)

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
async def test_update_vehicle_attributes_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.UpdateVehicleAttributesRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_vehicle_attributes),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.UpdateVehicleAttributesResponse())
        await client.update_vehicle_attributes(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.ListVehiclesRequest,
  dict,
])
def test_list_vehicles(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicle_api.ListVehiclesResponse(
            next_page_token='next_page_token_value',
            total_size=1086,
        )
        response = client.list_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.ListVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVehiclesPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.total_size == 1086


def test_list_vehicles_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        client.list_vehicles()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.ListVehiclesRequest()


@pytest.mark.asyncio
async def test_list_vehicles_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.ListVehiclesRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.ListVehiclesResponse(
            next_page_token='next_page_token_value',
            total_size=1086,
        ))
        response = await client.list_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.ListVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListVehiclesAsyncPager)
    assert response.next_page_token == 'next_page_token_value'
    assert response.total_size == 1086


@pytest.mark.asyncio
async def test_list_vehicles_async_from_dict():
    await test_list_vehicles_async(request_type=dict)


def test_list_vehicles_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.ListVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        call.return_value = vehicle_api.ListVehiclesResponse()
        client.list_vehicles(request)

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
async def test_list_vehicles_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.ListVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.ListVehiclesResponse())
        await client.list_vehicles(request)

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


def test_list_vehicles_pager(transport_name: str = "grpc"):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
                next_page_token='abc',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[],
                next_page_token='def',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                ],
                next_page_token='ghi',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
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
        pager = client.list_vehicles(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, vehicles.Vehicle)
                   for i in results)
def test_list_vehicles_pages(transport_name: str = "grpc"):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
                next_page_token='abc',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[],
                next_page_token='def',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                ],
                next_page_token='ghi',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_vehicles(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_vehicles_async_pager():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
                next_page_token='abc',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[],
                next_page_token='def',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                ],
                next_page_token='ghi',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_vehicles(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, vehicles.Vehicle)
                for i in responses)


@pytest.mark.asyncio
async def test_list_vehicles_async_pages():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_vehicles),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
                next_page_token='abc',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[],
                next_page_token='def',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                ],
                next_page_token='ghi',
            ),
            vehicle_api.ListVehiclesResponse(
                vehicles=[
                    vehicles.Vehicle(),
                    vehicles.Vehicle(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_vehicles(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  vehicle_api.SearchVehiclesRequest,
  dict,
])
def test_search_vehicles(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicle_api.SearchVehiclesResponse(
        )
        response = client.search_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.SearchVehiclesResponse)


def test_search_vehicles_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_vehicles),
            '__call__') as call:
        client.search_vehicles()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()


@pytest.mark.asyncio
async def test_search_vehicles_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.SearchVehiclesRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.SearchVehiclesResponse(
        ))
        response = await client.search_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.SearchVehiclesResponse)


@pytest.mark.asyncio
async def test_search_vehicles_async_from_dict():
    await test_search_vehicles_async(request_type=dict)


def test_search_vehicles_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.SearchVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_vehicles),
            '__call__') as call:
        call.return_value = vehicle_api.SearchVehiclesResponse()
        client.search_vehicles(request)

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
async def test_search_vehicles_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.SearchVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_vehicles),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.SearchVehiclesResponse())
        await client.search_vehicles(request)

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


@pytest.mark.parametrize("request_type", [
  vehicle_api.SearchVehiclesRequest,
  dict,
])
def test_search_fuzzed_vehicles(request_type, transport: str = 'grpc'):
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_fuzzed_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = vehicle_api.SearchVehiclesResponse(
        )
        response = client.search_fuzzed_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.SearchVehiclesResponse)


def test_search_fuzzed_vehicles_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_fuzzed_vehicles),
            '__call__') as call:
        client.search_fuzzed_vehicles()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()


@pytest.mark.asyncio
async def test_search_fuzzed_vehicles_async(transport: str = 'grpc_asyncio', request_type=vehicle_api.SearchVehiclesRequest):
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_fuzzed_vehicles),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.SearchVehiclesResponse(
        ))
        response = await client.search_fuzzed_vehicles(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == vehicle_api.SearchVehiclesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, vehicle_api.SearchVehiclesResponse)


@pytest.mark.asyncio
async def test_search_fuzzed_vehicles_async_from_dict():
    await test_search_fuzzed_vehicles_async(request_type=dict)


def test_search_fuzzed_vehicles_field_headers():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.SearchVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_fuzzed_vehicles),
            '__call__') as call:
        call.return_value = vehicle_api.SearchVehiclesResponse()
        client.search_fuzzed_vehicles(request)

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
async def test_search_fuzzed_vehicles_field_headers_async():
    client = VehicleServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = vehicle_api.SearchVehiclesRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_fuzzed_vehicles),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(vehicle_api.SearchVehiclesResponse())
        await client.search_fuzzed_vehicles(request)

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
    transport = transports.VehicleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = VehicleServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.VehicleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = VehicleServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.VehicleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = VehicleServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.VehicleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = VehicleServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.VehicleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.VehicleServiceGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.VehicleServiceGrpcTransport,
    transports.VehicleServiceGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.VehicleServiceGrpcTransport,
    )

def test_vehicle_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.VehicleServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_vehicle_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('maps.fleetengine_v1.services.vehicle_service.transports.VehicleServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.VehicleServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_vehicle',
        'get_vehicle',
        'update_vehicle',
        'update_vehicle_location',
        'update_vehicle_attributes',
        'list_vehicles',
        'search_vehicles',
        'search_fuzzed_vehicles',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_vehicle_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('maps.fleetengine_v1.services.vehicle_service.transports.VehicleServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.VehicleServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
),
            quota_project_id="octopus",
        )


def test_vehicle_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('maps.fleetengine_v1.services.vehicle_service.transports.VehicleServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.VehicleServiceTransport()
        adc.assert_called_once()


def test_vehicle_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        VehicleServiceClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.VehicleServiceGrpcTransport,
        transports.VehicleServiceGrpcAsyncIOTransport,
    ],
)
def test_vehicle_service_transport_auth_adc(transport_class):
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
    "transport_class,grpc_helpers",
    [
        (transports.VehicleServiceGrpcTransport, grpc_helpers),
        (transports.VehicleServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_vehicle_service_transport_create_channel(transport_class, grpc_helpers):
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
            "fleetengine.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
),
            scopes=["1", "2"],
            default_host="fleetengine.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.VehicleServiceGrpcTransport, transports.VehicleServiceGrpcAsyncIOTransport])
def test_vehicle_service_grpc_transport_client_cert_source_for_mtls(
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


def test_vehicle_service_host_no_port():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='fleetengine.googleapis.com'),
    )
    assert client.transport._host == 'fleetengine.googleapis.com:443'


def test_vehicle_service_host_with_port():
    client = VehicleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='fleetengine.googleapis.com:8000'),
    )
    assert client.transport._host == 'fleetengine.googleapis.com:8000'

def test_vehicle_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.VehicleServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_vehicle_service_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.VehicleServiceGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.VehicleServiceGrpcTransport, transports.VehicleServiceGrpcAsyncIOTransport])
def test_vehicle_service_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.VehicleServiceGrpcTransport, transports.VehicleServiceGrpcAsyncIOTransport])
def test_vehicle_service_transport_channel_mtls_with_adc(
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


def test_vehicle_path():
    provider = "squid"
    vehicle = "clam"
    expected = "providers/{provider}/vehicles/{vehicle}".format(provider=provider, vehicle=vehicle, )
    actual = VehicleServiceClient.vehicle_path(provider, vehicle)
    assert expected == actual


def test_parse_vehicle_path():
    expected = {
        "provider": "whelk",
        "vehicle": "octopus",
    }
    path = VehicleServiceClient.vehicle_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_vehicle_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = VehicleServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nudibranch",
    }
    path = VehicleServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"
    expected = "folders/{folder}".format(folder=folder, )
    actual = VehicleServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "mussel",
    }
    path = VehicleServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = VehicleServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nautilus",
    }
    path = VehicleServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"
    expected = "projects/{project}".format(project=project, )
    actual = VehicleServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "abalone",
    }
    path = VehicleServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = VehicleServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "whelk",
        "location": "octopus",
    }
    path = VehicleServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = VehicleServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.VehicleServiceTransport, '_prep_wrapped_messages') as prep:
        client = VehicleServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.VehicleServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = VehicleServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = VehicleServiceAsyncClient(
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
        client = VehicleServiceClient(
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
        client = VehicleServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
