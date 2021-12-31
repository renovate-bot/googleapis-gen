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
from google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service import SecurityCenterSettingsServiceAsyncClient
from google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service import SecurityCenterSettingsServiceClient
from google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service import pagers
from google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service import transports
from google.cloud.securitycenter.settings_v1beta1.types import billing_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import detector
from google.cloud.securitycenter.settings_v1beta1.types import securitycenter_settings_service
from google.cloud.securitycenter.settings_v1beta1.types import settings
from google.cloud.securitycenter.settings_v1beta1.types import settings as gcss_settings
from google.cloud.securitycenter.settings_v1beta1.types import sink_settings
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

    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(None) is None
    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert SecurityCenterSettingsServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    SecurityCenterSettingsServiceClient,
    SecurityCenterSettingsServiceAsyncClient,
])
def test_security_center_settings_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'securitycenter.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.SecurityCenterSettingsServiceGrpcTransport, "grpc"),
    (transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_security_center_settings_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    SecurityCenterSettingsServiceClient,
    SecurityCenterSettingsServiceAsyncClient,
])
def test_security_center_settings_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'securitycenter.googleapis.com:443'


def test_security_center_settings_service_client_get_transport_class():
    transport = SecurityCenterSettingsServiceClient.get_transport_class()
    available_transports = [
        transports.SecurityCenterSettingsServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = SecurityCenterSettingsServiceClient.get_transport_class("grpc")
    assert transport == transports.SecurityCenterSettingsServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (SecurityCenterSettingsServiceClient, transports.SecurityCenterSettingsServiceGrpcTransport, "grpc"),
    (SecurityCenterSettingsServiceAsyncClient, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(SecurityCenterSettingsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(SecurityCenterSettingsServiceClient))
@mock.patch.object(SecurityCenterSettingsServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(SecurityCenterSettingsServiceAsyncClient))
def test_security_center_settings_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(SecurityCenterSettingsServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(SecurityCenterSettingsServiceClient, 'get_transport_class') as gtc:
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
    (SecurityCenterSettingsServiceClient, transports.SecurityCenterSettingsServiceGrpcTransport, "grpc", "true"),
    (SecurityCenterSettingsServiceAsyncClient, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (SecurityCenterSettingsServiceClient, transports.SecurityCenterSettingsServiceGrpcTransport, "grpc", "false"),
    (SecurityCenterSettingsServiceAsyncClient, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(SecurityCenterSettingsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(SecurityCenterSettingsServiceClient))
@mock.patch.object(SecurityCenterSettingsServiceAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(SecurityCenterSettingsServiceAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_security_center_settings_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (SecurityCenterSettingsServiceClient, transports.SecurityCenterSettingsServiceGrpcTransport, "grpc"),
    (SecurityCenterSettingsServiceAsyncClient, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_security_center_settings_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (SecurityCenterSettingsServiceClient, transports.SecurityCenterSettingsServiceGrpcTransport, "grpc"),
    (SecurityCenterSettingsServiceAsyncClient, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_security_center_settings_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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

def test_security_center_settings_service_client_client_options_from_dict():
    with mock.patch('google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.transports.SecurityCenterSettingsServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = SecurityCenterSettingsServiceClient(
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
  securitycenter_settings_service.GetServiceAccountRequest,
  dict,
])
def test_get_service_account(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
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
        call.return_value = securitycenter_settings_service.ServiceAccount(
            name='name_value',
            service_account='service_account_value',
        )
        response = client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.ServiceAccount)
    assert response.name == 'name_value'
    assert response.service_account == 'service_account_value'


def test_get_service_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
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
        assert args[0] == securitycenter_settings_service.GetServiceAccountRequest()


@pytest.mark.asyncio
async def test_get_service_account_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.GetServiceAccountRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
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
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ServiceAccount(
            name='name_value',
            service_account='service_account_value',
        ))
        response = await client.get_service_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetServiceAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.ServiceAccount)
    assert response.name == 'name_value'
    assert response.service_account == 'service_account_value'


@pytest.mark.asyncio
async def test_get_service_account_async_from_dict():
    await test_get_service_account_async(request_type=dict)


def test_get_service_account_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        call.return_value = securitycenter_settings_service.ServiceAccount()
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
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetServiceAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ServiceAccount())
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
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ServiceAccount()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_service_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_service_account_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_service_account(
            securitycenter_settings_service.GetServiceAccountRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_service_account_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_service_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ServiceAccount()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ServiceAccount())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_service_account(
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
async def test_get_service_account_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_service_account(
            securitycenter_settings_service.GetServiceAccountRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.GetSettingsRequest,
  dict,
])
def test_get_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings(
            name='name_value',
            state=settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        )
        response = client.get_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, settings.Settings)
    assert response.name == 'name_value'
    assert response.state == settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


def test_get_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        client.get_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetSettingsRequest()


@pytest.mark.asyncio
async def test_get_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.GetSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings(
            name='name_value',
            state=settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        ))
        response = await client.get_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, settings.Settings)
    assert response.name == 'name_value'
    assert response.state == settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_get_settings_async_from_dict():
    await test_get_settings_async(request_type=dict)


def test_get_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        call.return_value = settings.Settings()
        client.get_settings(request)

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
async def test_get_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings())
        await client.get_settings(request)

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


def test_get_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_settings(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_settings(
            securitycenter_settings_service.GetSettingsRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_settings(
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
async def test_get_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_settings(
            securitycenter_settings_service.GetSettingsRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.UpdateSettingsRequest,
  dict,
])
def test_update_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_settings.Settings(
            name='name_value',
            state=gcss_settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        )
        response = client.update_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcss_settings.Settings)
    assert response.name == 'name_value'
    assert response.state == gcss_settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


def test_update_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        client.update_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateSettingsRequest()


@pytest.mark.asyncio
async def test_update_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.UpdateSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(gcss_settings.Settings(
            name='name_value',
            state=gcss_settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        ))
        response = await client.update_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcss_settings.Settings)
    assert response.name == 'name_value'
    assert response.state == gcss_settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_update_settings_async_from_dict():
    await test_update_settings_async(request_type=dict)


def test_update_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.UpdateSettingsRequest()

    request.settings.name = 'settings.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        call.return_value = gcss_settings.Settings()
        client.update_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'settings.name=settings.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.UpdateSettingsRequest()

    request.settings.name = 'settings.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcss_settings.Settings())
        await client.update_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'settings.name=settings.name/value',
    ) in kw['metadata']


def test_update_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_settings.Settings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_settings(
            settings=gcss_settings.Settings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].settings
        mock_val = gcss_settings.Settings(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_settings(
            securitycenter_settings_service.UpdateSettingsRequest(),
            settings=gcss_settings.Settings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_settings.Settings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcss_settings.Settings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_settings(
            settings=gcss_settings.Settings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].settings
        mock_val = gcss_settings.Settings(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_settings(
            securitycenter_settings_service.UpdateSettingsRequest(),
            settings=gcss_settings.Settings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.ResetSettingsRequest,
  dict,
])
def test_reset_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.reset_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_reset_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_settings),
            '__call__') as call:
        client.reset_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetSettingsRequest()


@pytest.mark.asyncio
async def test_reset_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.ResetSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.reset_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_reset_settings_async_from_dict():
    await test_reset_settings_async(request_type=dict)


def test_reset_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ResetSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_settings),
            '__call__') as call:
        call.return_value = None
        client.reset_settings(request)

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
async def test_reset_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ResetSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.reset_settings(request)

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
  securitycenter_settings_service.BatchGetSettingsRequest,
  dict,
])
def test_batch_get_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.BatchGetSettingsResponse(
        )
        response = client.batch_get_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchGetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.BatchGetSettingsResponse)


def test_batch_get_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_get_settings),
            '__call__') as call:
        client.batch_get_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchGetSettingsRequest()


@pytest.mark.asyncio
async def test_batch_get_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.BatchGetSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_get_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.BatchGetSettingsResponse(
        ))
        response = await client.batch_get_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchGetSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.BatchGetSettingsResponse)


@pytest.mark.asyncio
async def test_batch_get_settings_async_from_dict():
    await test_batch_get_settings_async(request_type=dict)


def test_batch_get_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.BatchGetSettingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_get_settings),
            '__call__') as call:
        call.return_value = securitycenter_settings_service.BatchGetSettingsResponse()
        client.batch_get_settings(request)

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
async def test_batch_get_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.BatchGetSettingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_get_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.BatchGetSettingsResponse())
        await client.batch_get_settings(request)

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
  securitycenter_settings_service.CalculateEffectiveSettingsRequest,
  dict,
])
def test_calculate_effective_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings(
            name='name_value',
            state=settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        )
        response = client.calculate_effective_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, settings.Settings)
    assert response.name == 'name_value'
    assert response.state == settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


def test_calculate_effective_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        client.calculate_effective_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveSettingsRequest()


@pytest.mark.asyncio
async def test_calculate_effective_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.CalculateEffectiveSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings(
            name='name_value',
            state=settings.Settings.OnboardingState.ENABLED,
            org_service_account='org_service_account_value',
            etag='etag_value',
        ))
        response = await client.calculate_effective_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, settings.Settings)
    assert response.name == 'name_value'
    assert response.state == settings.Settings.OnboardingState.ENABLED
    assert response.org_service_account == 'org_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_calculate_effective_settings_async_from_dict():
    await test_calculate_effective_settings_async(request_type=dict)


def test_calculate_effective_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.CalculateEffectiveSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        call.return_value = settings.Settings()
        client.calculate_effective_settings(request)

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
async def test_calculate_effective_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.CalculateEffectiveSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings())
        await client.calculate_effective_settings(request)

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


def test_calculate_effective_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.calculate_effective_settings(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_calculate_effective_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.calculate_effective_settings(
            securitycenter_settings_service.CalculateEffectiveSettingsRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_calculate_effective_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = settings.Settings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(settings.Settings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.calculate_effective_settings(
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
async def test_calculate_effective_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.calculate_effective_settings(
            securitycenter_settings_service.CalculateEffectiveSettingsRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest,
  dict,
])
def test_batch_calculate_effective_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse(
        )
        response = client.batch_calculate_effective_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse)


def test_batch_calculate_effective_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_calculate_effective_settings),
            '__call__') as call:
        client.batch_calculate_effective_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest()


@pytest.mark.asyncio
async def test_batch_calculate_effective_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_calculate_effective_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse(
        ))
        response = await client.batch_calculate_effective_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse)


@pytest.mark.asyncio
async def test_batch_calculate_effective_settings_async_from_dict():
    await test_batch_calculate_effective_settings_async(request_type=dict)


def test_batch_calculate_effective_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_calculate_effective_settings),
            '__call__') as call:
        call.return_value = securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse()
        client.batch_calculate_effective_settings(request)

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
async def test_batch_calculate_effective_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.batch_calculate_effective_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse())
        await client.batch_calculate_effective_settings(request)

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
  securitycenter_settings_service.GetComponentSettingsRequest,
  dict,
])
def test_get_component_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings(
            name='name_value',
            state=component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
            container_threat_detection_settings=None,
        )
        response = client.get_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


def test_get_component_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        client.get_component_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetComponentSettingsRequest()


@pytest.mark.asyncio
async def test_get_component_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.GetComponentSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings(
            name='name_value',
            state=component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
        ))
        response = await client.get_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.GetComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_get_component_settings_async_from_dict():
    await test_get_component_settings_async(request_type=dict)


def test_get_component_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        call.return_value = component_settings.ComponentSettings()
        client.get_component_settings(request)

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
async def test_get_component_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.GetComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings())
        await client.get_component_settings(request)

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


def test_get_component_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_component_settings(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_component_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_component_settings(
            securitycenter_settings_service.GetComponentSettingsRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_component_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_component_settings(
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
async def test_get_component_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_component_settings(
            securitycenter_settings_service.GetComponentSettingsRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.UpdateComponentSettingsRequest,
  dict,
])
def test_update_component_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_component_settings.ComponentSettings(
            name='name_value',
            state=gcss_component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
            container_threat_detection_settings=None,
        )
        response = client.update_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcss_component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == gcss_component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


def test_update_component_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        client.update_component_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateComponentSettingsRequest()


@pytest.mark.asyncio
async def test_update_component_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.UpdateComponentSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(gcss_component_settings.ComponentSettings(
            name='name_value',
            state=gcss_component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
        ))
        response = await client.update_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.UpdateComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, gcss_component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == gcss_component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_update_component_settings_async_from_dict():
    await test_update_component_settings_async(request_type=dict)


def test_update_component_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.UpdateComponentSettingsRequest()

    request.component_settings.name = 'component_settings.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        call.return_value = gcss_component_settings.ComponentSettings()
        client.update_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'component_settings.name=component_settings.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_component_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.UpdateComponentSettingsRequest()

    request.component_settings.name = 'component_settings.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcss_component_settings.ComponentSettings())
        await client.update_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'component_settings.name=component_settings.name/value',
    ) in kw['metadata']


def test_update_component_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_component_settings.ComponentSettings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_component_settings(
            component_settings=gcss_component_settings.ComponentSettings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].component_settings
        mock_val = gcss_component_settings.ComponentSettings(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


def test_update_component_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_component_settings(
            securitycenter_settings_service.UpdateComponentSettingsRequest(),
            component_settings=gcss_component_settings.ComponentSettings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_component_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = gcss_component_settings.ComponentSettings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(gcss_component_settings.ComponentSettings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_component_settings(
            component_settings=gcss_component_settings.ComponentSettings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].component_settings
        mock_val = gcss_component_settings.ComponentSettings(name='name_value')
        assert arg == mock_val
        arg = args[0].update_mask
        mock_val = field_mask_pb2.FieldMask(paths=['paths_value'])
        assert arg == mock_val


@pytest.mark.asyncio
async def test_update_component_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_component_settings(
            securitycenter_settings_service.UpdateComponentSettingsRequest(),
            component_settings=gcss_component_settings.ComponentSettings(name='name_value'),
            update_mask=field_mask_pb2.FieldMask(paths=['paths_value']),
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.ResetComponentSettingsRequest,
  dict,
])
def test_reset_component_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.reset_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_reset_component_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_component_settings),
            '__call__') as call:
        client.reset_component_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetComponentSettingsRequest()


@pytest.mark.asyncio
async def test_reset_component_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.ResetComponentSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.reset_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ResetComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_reset_component_settings_async_from_dict():
    await test_reset_component_settings_async(request_type=dict)


def test_reset_component_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ResetComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_component_settings),
            '__call__') as call:
        call.return_value = None
        client.reset_component_settings(request)

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
async def test_reset_component_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ResetComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.reset_component_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.reset_component_settings(request)

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
  securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest,
  dict,
])
def test_calculate_effective_component_settings(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings(
            name='name_value',
            state=component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
            container_threat_detection_settings=None,
        )
        response = client.calculate_effective_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


def test_calculate_effective_component_settings_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        client.calculate_effective_component_settings()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest()


@pytest.mark.asyncio
async def test_calculate_effective_component_settings_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings(
            name='name_value',
            state=component_settings.ComponentEnablementState.DISABLE,
            project_service_account='project_service_account_value',
            etag='etag_value',
        ))
        response = await client.calculate_effective_component_settings(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, component_settings.ComponentSettings)
    assert response.name == 'name_value'
    assert response.state == component_settings.ComponentEnablementState.DISABLE
    assert response.project_service_account == 'project_service_account_value'
    assert response.etag == 'etag_value'


@pytest.mark.asyncio
async def test_calculate_effective_component_settings_async_from_dict():
    await test_calculate_effective_component_settings_async(request_type=dict)


def test_calculate_effective_component_settings_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        call.return_value = component_settings.ComponentSettings()
        client.calculate_effective_component_settings(request)

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
async def test_calculate_effective_component_settings_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings())
        await client.calculate_effective_component_settings(request)

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


def test_calculate_effective_component_settings_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.calculate_effective_component_settings(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_calculate_effective_component_settings_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.calculate_effective_component_settings(
            securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_calculate_effective_component_settings_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.calculate_effective_component_settings),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = component_settings.ComponentSettings()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(component_settings.ComponentSettings())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.calculate_effective_component_settings(
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
async def test_calculate_effective_component_settings_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.calculate_effective_component_settings(
            securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.ListDetectorsRequest,
  dict,
])
def test_list_detectors(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListDetectorsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_detectors(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListDetectorsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListDetectorsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_detectors_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        client.list_detectors()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListDetectorsRequest()


@pytest.mark.asyncio
async def test_list_detectors_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.ListDetectorsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListDetectorsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_detectors(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListDetectorsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListDetectorsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_detectors_async_from_dict():
    await test_list_detectors_async(request_type=dict)


def test_list_detectors_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ListDetectorsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        call.return_value = securitycenter_settings_service.ListDetectorsResponse()
        client.list_detectors(request)

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
async def test_list_detectors_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ListDetectorsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListDetectorsResponse())
        await client.list_detectors(request)

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


def test_list_detectors_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListDetectorsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_detectors(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_detectors_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_detectors(
            securitycenter_settings_service.ListDetectorsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_detectors_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListDetectorsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListDetectorsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_detectors(
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
async def test_list_detectors_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_detectors(
            securitycenter_settings_service.ListDetectorsRequest(),
            parent='parent_value',
        )


def test_list_detectors_pager(transport_name: str = "grpc"):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                    detector.Detector(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
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
        pager = client.list_detectors(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, detector.Detector)
                   for i in results)
def test_list_detectors_pages(transport_name: str = "grpc"):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                    detector.Detector(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_detectors(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_detectors_async_pager():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                    detector.Detector(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_detectors(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, detector.Detector)
                for i in responses)


@pytest.mark.asyncio
async def test_list_detectors_async_pages():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_detectors),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                    detector.Detector(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListDetectorsResponse(
                detectors=[
                    detector.Detector(),
                    detector.Detector(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_detectors(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  securitycenter_settings_service.ListComponentsRequest,
  dict,
])
def test_list_components(request_type, transport: str = 'grpc'):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListComponentsResponse(
            components=['components_value'],
            next_page_token='next_page_token_value',
        )
        response = client.list_components(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListComponentsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListComponentsPager)
    assert response.components == ['components_value']
    assert response.next_page_token == 'next_page_token_value'


def test_list_components_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        client.list_components()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListComponentsRequest()


@pytest.mark.asyncio
async def test_list_components_async(transport: str = 'grpc_asyncio', request_type=securitycenter_settings_service.ListComponentsRequest):
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListComponentsResponse(
            components=['components_value'],
            next_page_token='next_page_token_value',
        ))
        response = await client.list_components(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == securitycenter_settings_service.ListComponentsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListComponentsAsyncPager)
    assert response.components == ['components_value']
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_components_async_from_dict():
    await test_list_components_async(request_type=dict)


def test_list_components_field_headers():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ListComponentsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        call.return_value = securitycenter_settings_service.ListComponentsResponse()
        client.list_components(request)

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
async def test_list_components_field_headers_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = securitycenter_settings_service.ListComponentsRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListComponentsResponse())
        await client.list_components(request)

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


def test_list_components_flattened():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListComponentsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_components(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val


def test_list_components_flattened_error():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_components(
            securitycenter_settings_service.ListComponentsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_components_flattened_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = securitycenter_settings_service.ListComponentsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(securitycenter_settings_service.ListComponentsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_components(
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
async def test_list_components_flattened_error_async():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_components(
            securitycenter_settings_service.ListComponentsRequest(),
            parent='parent_value',
        )


def test_list_components_pager(transport_name: str = "grpc"):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
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
        pager = client.list_components(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, str)
                   for i in results)
def test_list_components_pages(transport_name: str = "grpc"):
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_components(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_components_async_pager():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_components(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, str)
                for i in responses)


@pytest.mark.asyncio
async def test_list_components_async_pages():
    client = SecurityCenterSettingsServiceAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_components),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                    str(),
                ],
                next_page_token='abc',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[],
                next_page_token='def',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                ],
                next_page_token='ghi',
            ),
            securitycenter_settings_service.ListComponentsResponse(
                components=[
                    str(),
                    str(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_components(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = SecurityCenterSettingsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = SecurityCenterSettingsServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = SecurityCenterSettingsServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = SecurityCenterSettingsServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.SecurityCenterSettingsServiceGrpcTransport,
    transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.SecurityCenterSettingsServiceGrpcTransport,
    )

def test_security_center_settings_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.SecurityCenterSettingsServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_security_center_settings_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.transports.SecurityCenterSettingsServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.SecurityCenterSettingsServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_service_account',
        'get_settings',
        'update_settings',
        'reset_settings',
        'batch_get_settings',
        'calculate_effective_settings',
        'batch_calculate_effective_settings',
        'get_component_settings',
        'update_component_settings',
        'reset_component_settings',
        'calculate_effective_component_settings',
        'list_detectors',
        'list_components',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_security_center_settings_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.transports.SecurityCenterSettingsServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.SecurityCenterSettingsServiceTransport(
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


def test_security_center_settings_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.transports.SecurityCenterSettingsServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.SecurityCenterSettingsServiceTransport()
        adc.assert_called_once()


def test_security_center_settings_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        SecurityCenterSettingsServiceClient()
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
        transports.SecurityCenterSettingsServiceGrpcTransport,
        transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport,
    ],
)
def test_security_center_settings_service_transport_auth_adc(transport_class):
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
        (transports.SecurityCenterSettingsServiceGrpcTransport, grpc_helpers),
        (transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_security_center_settings_service_transport_create_channel(transport_class, grpc_helpers):
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
            "securitycenter.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="securitycenter.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.SecurityCenterSettingsServiceGrpcTransport, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport])
def test_security_center_settings_service_grpc_transport_client_cert_source_for_mtls(
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


def test_security_center_settings_service_host_no_port():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='securitycenter.googleapis.com'),
    )
    assert client.transport._host == 'securitycenter.googleapis.com:443'


def test_security_center_settings_service_host_with_port():
    client = SecurityCenterSettingsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='securitycenter.googleapis.com:8000'),
    )
    assert client.transport._host == 'securitycenter.googleapis.com:8000'

def test_security_center_settings_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.SecurityCenterSettingsServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_security_center_settings_service_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.SecurityCenterSettingsServiceGrpcTransport, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport])
def test_security_center_settings_service_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.SecurityCenterSettingsServiceGrpcTransport, transports.SecurityCenterSettingsServiceGrpcAsyncIOTransport])
def test_security_center_settings_service_transport_channel_mtls_with_adc(
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


def test_component_settings_path():
    organization = "squid"
    component = "clam"
    expected = "organizations/{organization}/components/{component}/settings".format(organization=organization, component=component, )
    actual = SecurityCenterSettingsServiceClient.component_settings_path(organization, component)
    assert expected == actual


def test_parse_component_settings_path():
    expected = {
        "organization": "whelk",
        "component": "octopus",
    }
    path = SecurityCenterSettingsServiceClient.component_settings_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_component_settings_path(path)
    assert expected == actual

def test_service_account_path():
    organization = "oyster"
    expected = "organizations/{organization}/serviceAccount".format(organization=organization, )
    actual = SecurityCenterSettingsServiceClient.service_account_path(organization)
    assert expected == actual


def test_parse_service_account_path():
    expected = {
        "organization": "nudibranch",
    }
    path = SecurityCenterSettingsServiceClient.service_account_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_service_account_path(path)
    assert expected == actual

def test_settings_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}/settings".format(organization=organization, )
    actual = SecurityCenterSettingsServiceClient.settings_path(organization)
    assert expected == actual


def test_parse_settings_path():
    expected = {
        "organization": "mussel",
    }
    path = SecurityCenterSettingsServiceClient.settings_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_settings_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "winkle"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = SecurityCenterSettingsServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nautilus",
    }
    path = SecurityCenterSettingsServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "scallop"
    expected = "folders/{folder}".format(folder=folder, )
    actual = SecurityCenterSettingsServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "abalone",
    }
    path = SecurityCenterSettingsServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "squid"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = SecurityCenterSettingsServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "clam",
    }
    path = SecurityCenterSettingsServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "whelk"
    expected = "projects/{project}".format(project=project, )
    actual = SecurityCenterSettingsServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "octopus",
    }
    path = SecurityCenterSettingsServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "oyster"
    location = "nudibranch"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = SecurityCenterSettingsServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "cuttlefish",
        "location": "mussel",
    }
    path = SecurityCenterSettingsServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = SecurityCenterSettingsServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.SecurityCenterSettingsServiceTransport, '_prep_wrapped_messages') as prep:
        client = SecurityCenterSettingsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.SecurityCenterSettingsServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = SecurityCenterSettingsServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = SecurityCenterSettingsServiceAsyncClient(
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
        client = SecurityCenterSettingsServiceClient(
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
        client = SecurityCenterSettingsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
