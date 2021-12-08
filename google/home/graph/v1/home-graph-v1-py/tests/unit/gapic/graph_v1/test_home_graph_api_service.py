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
import json
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
from google.home.graph_v1.services.home_graph_api_service import HomeGraphApiServiceAsyncClient
from google.home.graph_v1.services.home_graph_api_service import HomeGraphApiServiceClient
from google.home.graph_v1.services.home_graph_api_service import transports
from google.home.graph_v1.types import homegraph
from google.oauth2 import service_account
from google.protobuf import struct_pb2  # type: ignore
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

    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(None) is None
    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert HomeGraphApiServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    HomeGraphApiServiceClient,
    HomeGraphApiServiceAsyncClient,
])
def test_home_graph_api_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'homegraph.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.HomeGraphApiServiceGrpcTransport, "grpc"),
    (transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_home_graph_api_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    HomeGraphApiServiceClient,
    HomeGraphApiServiceAsyncClient,
])
def test_home_graph_api_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'homegraph.googleapis.com:443'


def test_home_graph_api_service_client_get_transport_class():
    transport = HomeGraphApiServiceClient.get_transport_class()
    available_transports = [
        transports.HomeGraphApiServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = HomeGraphApiServiceClient.get_transport_class("grpc")
    assert transport == transports.HomeGraphApiServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (HomeGraphApiServiceClient, transports.HomeGraphApiServiceGrpcTransport, "grpc"),
    (HomeGraphApiServiceAsyncClient, transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(HomeGraphApiServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(HomeGraphApiServiceClient))
@mock.patch.object(HomeGraphApiServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(HomeGraphApiServiceAsyncClient))
def test_home_graph_api_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(HomeGraphApiServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(HomeGraphApiServiceClient, 'get_transport_class') as gtc:
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
    (HomeGraphApiServiceClient, transports.HomeGraphApiServiceGrpcTransport, "grpc", "true"),
    (HomeGraphApiServiceAsyncClient, transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (HomeGraphApiServiceClient, transports.HomeGraphApiServiceGrpcTransport, "grpc", "false"),
    (HomeGraphApiServiceAsyncClient, transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(HomeGraphApiServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(HomeGraphApiServiceClient))
@mock.patch.object(HomeGraphApiServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(HomeGraphApiServiceAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_home_graph_api_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (HomeGraphApiServiceClient, transports.HomeGraphApiServiceGrpcTransport, "grpc"),
    (HomeGraphApiServiceAsyncClient, transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_home_graph_api_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (HomeGraphApiServiceClient, transports.HomeGraphApiServiceGrpcTransport, "grpc"),
    (HomeGraphApiServiceAsyncClient, transports.HomeGraphApiServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_home_graph_api_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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


def test_home_graph_api_service_client_client_options_from_dict():
    with mock.patch('google.home.graph_v1.services.home_graph_api_service.transports.HomeGraphApiServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = HomeGraphApiServiceClient(
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


def test_request_sync_devices(transport: str = 'grpc', request_type=homegraph.RequestSyncDevicesRequest):
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.request_sync_devices),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.RequestSyncDevicesResponse(
        )
        response = client.request_sync_devices(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.RequestSyncDevicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.RequestSyncDevicesResponse)


def test_request_sync_devices_from_dict():
    test_request_sync_devices(request_type=dict)


def test_request_sync_devices_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.request_sync_devices),
            '__call__') as call:
        client.request_sync_devices()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.RequestSyncDevicesRequest()


@pytest.mark.asyncio
async def test_request_sync_devices_async(transport: str = 'grpc_asyncio', request_type=homegraph.RequestSyncDevicesRequest):
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.request_sync_devices),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(homegraph.RequestSyncDevicesResponse(
        ))
        response = await client.request_sync_devices(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.RequestSyncDevicesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.RequestSyncDevicesResponse)


@pytest.mark.asyncio
async def test_request_sync_devices_async_from_dict():
    await test_request_sync_devices_async(request_type=dict)


def test_request_sync_devices_flattened():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.request_sync_devices),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.RequestSyncDevicesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.request_sync_devices(
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


def test_request_sync_devices_flattened_error():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.request_sync_devices(
            homegraph.RequestSyncDevicesRequest(),
            agent_user_id='agent_user_id_value',
        )


@pytest.mark.asyncio
async def test_request_sync_devices_flattened_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.request_sync_devices),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.RequestSyncDevicesResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(homegraph.RequestSyncDevicesResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.request_sync_devices(
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_request_sync_devices_flattened_error_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.request_sync_devices(
            homegraph.RequestSyncDevicesRequest(),
            agent_user_id='agent_user_id_value',
        )


def test_report_state_and_notification(transport: str = 'grpc', request_type=homegraph.ReportStateAndNotificationRequest):
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.report_state_and_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.ReportStateAndNotificationResponse(
            request_id='request_id_value',
        )
        response = client.report_state_and_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.ReportStateAndNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.ReportStateAndNotificationResponse)
    assert response.request_id == 'request_id_value'


def test_report_state_and_notification_from_dict():
    test_report_state_and_notification(request_type=dict)


def test_report_state_and_notification_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.report_state_and_notification),
            '__call__') as call:
        client.report_state_and_notification()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.ReportStateAndNotificationRequest()


@pytest.mark.asyncio
async def test_report_state_and_notification_async(transport: str = 'grpc_asyncio', request_type=homegraph.ReportStateAndNotificationRequest):
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.report_state_and_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(homegraph.ReportStateAndNotificationResponse(
            request_id='request_id_value',
        ))
        response = await client.report_state_and_notification(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.ReportStateAndNotificationRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.ReportStateAndNotificationResponse)
    assert response.request_id == 'request_id_value'


@pytest.mark.asyncio
async def test_report_state_and_notification_async_from_dict():
    await test_report_state_and_notification_async(request_type=dict)


def test_report_state_and_notification_flattened():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.report_state_and_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.ReportStateAndNotificationResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.report_state_and_notification(
            request_id='request_id_value',
            event_id='event_id_value',
            agent_user_id='agent_user_id_value',
            payload=homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)}))),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].event_id
        mock_val = 'event_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val
        arg = args[0].payload
        mock_val = homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)})))
        assert arg == mock_val


def test_report_state_and_notification_flattened_error():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.report_state_and_notification(
            homegraph.ReportStateAndNotificationRequest(),
            request_id='request_id_value',
            event_id='event_id_value',
            agent_user_id='agent_user_id_value',
            payload=homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)}))),
        )


@pytest.mark.asyncio
async def test_report_state_and_notification_flattened_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.report_state_and_notification),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.ReportStateAndNotificationResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(homegraph.ReportStateAndNotificationResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.report_state_and_notification(
            request_id='request_id_value',
            event_id='event_id_value',
            agent_user_id='agent_user_id_value',
            payload=homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)}))),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].event_id
        mock_val = 'event_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val
        arg = args[0].payload
        mock_val = homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)})))
        assert arg == mock_val


@pytest.mark.asyncio
async def test_report_state_and_notification_flattened_error_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.report_state_and_notification(
            homegraph.ReportStateAndNotificationRequest(),
            request_id='request_id_value',
            event_id='event_id_value',
            agent_user_id='agent_user_id_value',
            payload=homegraph.StateAndNotificationPayload(devices=homegraph.ReportStateAndNotificationDevice(states=struct_pb2.Struct(fields={'key_value': struct_pb2.Value(null_value=struct_pb2.NullValue.NULL_VALUE)}))),
        )


def test_delete_agent_user(transport: str = 'grpc', request_type=homegraph.DeleteAgentUserRequest):
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_agent_user(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.DeleteAgentUserRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_agent_user_from_dict():
    test_delete_agent_user(request_type=dict)


def test_delete_agent_user_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        client.delete_agent_user()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.DeleteAgentUserRequest()


@pytest.mark.asyncio
async def test_delete_agent_user_async(transport: str = 'grpc_asyncio', request_type=homegraph.DeleteAgentUserRequest):
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_agent_user(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.DeleteAgentUserRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_agent_user_async_from_dict():
    await test_delete_agent_user_async(request_type=dict)


def test_delete_agent_user_field_headers():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = homegraph.DeleteAgentUserRequest()

    request.agent_user_id = 'agent_user_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        call.return_value = None
        client.delete_agent_user(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'agent_user_id=agent_user_id/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_agent_user_field_headers_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = homegraph.DeleteAgentUserRequest()

    request.agent_user_id = 'agent_user_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_agent_user(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'agent_user_id=agent_user_id/value',
    ) in kw['metadata']


def test_delete_agent_user_flattened():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_agent_user(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


def test_delete_agent_user_flattened_error():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_agent_user(
            homegraph.DeleteAgentUserRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )


@pytest.mark.asyncio
async def test_delete_agent_user_flattened_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_agent_user),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_agent_user(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_delete_agent_user_flattened_error_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_agent_user(
            homegraph.DeleteAgentUserRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )


def test_query(transport: str = 'grpc', request_type=homegraph.QueryRequest):
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.QueryResponse(
            request_id='request_id_value',
        )
        response = client.query(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.QueryRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.QueryResponse)
    assert response.request_id == 'request_id_value'


def test_query_from_dict():
    test_query(request_type=dict)


def test_query_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query),
            '__call__') as call:
        client.query()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.QueryRequest()


@pytest.mark.asyncio
async def test_query_async(transport: str = 'grpc_asyncio', request_type=homegraph.QueryRequest):
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(homegraph.QueryResponse(
            request_id='request_id_value',
        ))
        response = await client.query(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.QueryRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.QueryResponse)
    assert response.request_id == 'request_id_value'


@pytest.mark.asyncio
async def test_query_async_from_dict():
    await test_query_async(request_type=dict)


def test_query_flattened():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.QueryResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.query(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
            inputs=[homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val
        arg = args[0].inputs
        mock_val = [homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))]
        assert arg == mock_val


def test_query_flattened_error():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.query(
            homegraph.QueryRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
            inputs=[homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))],
        )


@pytest.mark.asyncio
async def test_query_flattened_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.query),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.QueryResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(homegraph.QueryResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.query(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
            inputs=[homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val
        arg = args[0].inputs
        mock_val = [homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))]
        assert arg == mock_val


@pytest.mark.asyncio
async def test_query_flattened_error_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.query(
            homegraph.QueryRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
            inputs=[homegraph.QueryRequestInput(payload=homegraph.QueryRequestPayload(devices=[homegraph.AgentDeviceId(id='id_value')]))],
        )


def test_sync(transport: str = 'grpc', request_type=homegraph.SyncRequest):
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sync),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.SyncResponse(
            request_id='request_id_value',
        )
        response = client.sync(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.SyncRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.SyncResponse)
    assert response.request_id == 'request_id_value'


def test_sync_from_dict():
    test_sync(request_type=dict)


def test_sync_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sync),
            '__call__') as call:
        client.sync()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.SyncRequest()


@pytest.mark.asyncio
async def test_sync_async(transport: str = 'grpc_asyncio', request_type=homegraph.SyncRequest):
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sync),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(homegraph.SyncResponse(
            request_id='request_id_value',
        ))
        response = await client.sync(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == homegraph.SyncRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, homegraph.SyncResponse)
    assert response.request_id == 'request_id_value'


@pytest.mark.asyncio
async def test_sync_async_from_dict():
    await test_sync_async(request_type=dict)


def test_sync_flattened():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sync),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.SyncResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.sync(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


def test_sync_flattened_error():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.sync(
            homegraph.SyncRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )


@pytest.mark.asyncio
async def test_sync_flattened_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.sync),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = homegraph.SyncResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(homegraph.SyncResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.sync(
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].request_id
        mock_val = 'request_id_value'
        assert arg == mock_val
        arg = args[0].agent_user_id
        mock_val = 'agent_user_id_value'
        assert arg == mock_val


@pytest.mark.asyncio
async def test_sync_flattened_error_async():
    client = HomeGraphApiServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.sync(
            homegraph.SyncRequest(),
            request_id='request_id_value',
            agent_user_id='agent_user_id_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = HomeGraphApiServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = HomeGraphApiServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = HomeGraphApiServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = HomeGraphApiServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.HomeGraphApiServiceGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.HomeGraphApiServiceGrpcTransport,
    transports.HomeGraphApiServiceGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.HomeGraphApiServiceGrpcTransport,
    )

def test_home_graph_api_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.HomeGraphApiServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_home_graph_api_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.home.graph_v1.services.home_graph_api_service.transports.HomeGraphApiServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.HomeGraphApiServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'request_sync_devices',
        'report_state_and_notification',
        'delete_agent_user',
        'query',
        'sync',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_home_graph_api_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.home.graph_v1.services.home_graph_api_service.transports.HomeGraphApiServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.HomeGraphApiServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
),
            quota_project_id="octopus",
        )


def test_home_graph_api_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.home.graph_v1.services.home_graph_api_service.transports.HomeGraphApiServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.HomeGraphApiServiceTransport()
        adc.assert_called_once()


def test_home_graph_api_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        HomeGraphApiServiceClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.HomeGraphApiServiceGrpcTransport,
        transports.HomeGraphApiServiceGrpcAsyncIOTransport,
    ],
)
def test_home_graph_api_service_transport_auth_adc(transport_class):
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
        (transports.HomeGraphApiServiceGrpcTransport, grpc_helpers),
        (transports.HomeGraphApiServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_home_graph_api_service_transport_create_channel(transport_class, grpc_helpers):
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
            "homegraph.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
),
            scopes=["1", "2"],
            default_host="homegraph.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.HomeGraphApiServiceGrpcTransport, transports.HomeGraphApiServiceGrpcAsyncIOTransport])
def test_home_graph_api_service_grpc_transport_client_cert_source_for_mtls(
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


def test_home_graph_api_service_host_no_port():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='homegraph.googleapis.com'),
    )
    assert client.transport._host == 'homegraph.googleapis.com:443'


def test_home_graph_api_service_host_with_port():
    client = HomeGraphApiServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='homegraph.googleapis.com:8000'),
    )
    assert client.transport._host == 'homegraph.googleapis.com:8000'

def test_home_graph_api_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.HomeGraphApiServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_home_graph_api_service_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.HomeGraphApiServiceGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.HomeGraphApiServiceGrpcTransport, transports.HomeGraphApiServiceGrpcAsyncIOTransport])
def test_home_graph_api_service_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.HomeGraphApiServiceGrpcTransport, transports.HomeGraphApiServiceGrpcAsyncIOTransport])
def test_home_graph_api_service_transport_channel_mtls_with_adc(
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


def test_agent_user_path_path():
    agent_user_path = "squid"
    expected = "agentUsers/{agent_user_path=**}".format(agent_user_path=agent_user_path, )
    actual = HomeGraphApiServiceClient.agent_user_path_path(agent_user_path)
    assert expected == actual


def test_parse_agent_user_path_path():
    expected = {
        "agent_user_path": "clam",
    }
    path = HomeGraphApiServiceClient.agent_user_path_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_agent_user_path_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = HomeGraphApiServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "octopus",
    }
    path = HomeGraphApiServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"
    expected = "folders/{folder}".format(folder=folder, )
    actual = HomeGraphApiServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nudibranch",
    }
    path = HomeGraphApiServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = HomeGraphApiServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "mussel",
    }
    path = HomeGraphApiServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"
    expected = "projects/{project}".format(project=project, )
    actual = HomeGraphApiServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nautilus",
    }
    path = HomeGraphApiServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = HomeGraphApiServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "squid",
        "location": "clam",
    }
    path = HomeGraphApiServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = HomeGraphApiServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.HomeGraphApiServiceTransport, '_prep_wrapped_messages') as prep:
        client = HomeGraphApiServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.HomeGraphApiServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = HomeGraphApiServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = HomeGraphApiServiceAsyncClient(
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
        client = HomeGraphApiServiceClient(
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
        client = HomeGraphApiServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
