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


from google.ads.admob_v1.services.ad_mob_api import AdMobApiAsyncClient
from google.ads.admob_v1.services.ad_mob_api import AdMobApiClient
from google.ads.admob_v1.services.ad_mob_api import pagers
from google.ads.admob_v1.services.ad_mob_api import transports
from google.ads.admob_v1.types import admob_api
from google.ads.admob_v1.types import admob_resources
from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
from google.type import date_pb2  # type: ignore
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

    assert AdMobApiClient._get_default_mtls_endpoint(None) is None
    assert AdMobApiClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert AdMobApiClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert AdMobApiClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert AdMobApiClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert AdMobApiClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    AdMobApiClient,
    AdMobApiAsyncClient,
])
def test_ad_mob_api_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'admob.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.AdMobApiGrpcTransport, "grpc"),
    (transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_ad_mob_api_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    AdMobApiClient,
    AdMobApiAsyncClient,
])
def test_ad_mob_api_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'admob.googleapis.com:443'


def test_ad_mob_api_client_get_transport_class():
    transport = AdMobApiClient.get_transport_class()
    available_transports = [
        transports.AdMobApiGrpcTransport,
    ]
    assert transport in available_transports

    transport = AdMobApiClient.get_transport_class("grpc")
    assert transport == transports.AdMobApiGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AdMobApiClient, transports.AdMobApiGrpcTransport, "grpc"),
    (AdMobApiAsyncClient, transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(AdMobApiClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdMobApiClient))
@mock.patch.object(AdMobApiAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdMobApiAsyncClient))
def test_ad_mob_api_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(AdMobApiClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(AdMobApiClient, 'get_transport_class') as gtc:
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
    (AdMobApiClient, transports.AdMobApiGrpcTransport, "grpc", "true"),
    (AdMobApiAsyncClient, transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (AdMobApiClient, transports.AdMobApiGrpcTransport, "grpc", "false"),
    (AdMobApiAsyncClient, transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(AdMobApiClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdMobApiClient))
@mock.patch.object(AdMobApiAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdMobApiAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_ad_mob_api_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (AdMobApiClient, transports.AdMobApiGrpcTransport, "grpc"),
    (AdMobApiAsyncClient, transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_ad_mob_api_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (AdMobApiClient, transports.AdMobApiGrpcTransport, "grpc"),
    (AdMobApiAsyncClient, transports.AdMobApiGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_ad_mob_api_client_client_options_credentials_file(client_class, transport_class, transport_name):
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

def test_ad_mob_api_client_client_options_from_dict():
    with mock.patch('google.ads.admob_v1.services.ad_mob_api.transports.AdMobApiGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = AdMobApiClient(
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
  admob_api.GetPublisherAccountRequest,
  dict,
])
def test_get_publisher_account(request_type, transport: str = 'grpc'):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = admob_resources.PublisherAccount(
            name='name_value',
            publisher_id='publisher_id_value',
            reporting_time_zone='reporting_time_zone_value',
            currency_code='currency_code_value',
        )
        response = client.get_publisher_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GetPublisherAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, admob_resources.PublisherAccount)
    assert response.name == 'name_value'
    assert response.publisher_id == 'publisher_id_value'
    assert response.reporting_time_zone == 'reporting_time_zone_value'
    assert response.currency_code == 'currency_code_value'


def test_get_publisher_account_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        client.get_publisher_account()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GetPublisherAccountRequest()


@pytest.mark.asyncio
async def test_get_publisher_account_async(transport: str = 'grpc_asyncio', request_type=admob_api.GetPublisherAccountRequest):
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(admob_resources.PublisherAccount(
            name='name_value',
            publisher_id='publisher_id_value',
            reporting_time_zone='reporting_time_zone_value',
            currency_code='currency_code_value',
        ))
        response = await client.get_publisher_account(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GetPublisherAccountRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, admob_resources.PublisherAccount)
    assert response.name == 'name_value'
    assert response.publisher_id == 'publisher_id_value'
    assert response.reporting_time_zone == 'reporting_time_zone_value'
    assert response.currency_code == 'currency_code_value'


@pytest.mark.asyncio
async def test_get_publisher_account_async_from_dict():
    await test_get_publisher_account_async(request_type=dict)


def test_get_publisher_account_field_headers():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GetPublisherAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        call.return_value = admob_resources.PublisherAccount()
        client.get_publisher_account(request)

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
async def test_get_publisher_account_field_headers_async():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GetPublisherAccountRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(admob_resources.PublisherAccount())
        await client.get_publisher_account(request)

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


def test_get_publisher_account_flattened():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = admob_resources.PublisherAccount()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_publisher_account(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val


def test_get_publisher_account_flattened_error():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_publisher_account(
            admob_api.GetPublisherAccountRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_publisher_account_flattened_async():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_publisher_account),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = admob_resources.PublisherAccount()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(admob_resources.PublisherAccount())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_publisher_account(
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
async def test_get_publisher_account_flattened_error_async():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_publisher_account(
            admob_api.GetPublisherAccountRequest(),
            name='name_value',
        )


@pytest.mark.parametrize("request_type", [
  admob_api.ListPublisherAccountsRequest,
  dict,
])
def test_list_publisher_accounts(request_type, transport: str = 'grpc'):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = admob_api.ListPublisherAccountsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_publisher_accounts(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.ListPublisherAccountsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListPublisherAccountsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_publisher_accounts_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__') as call:
        client.list_publisher_accounts()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.ListPublisherAccountsRequest()


@pytest.mark.asyncio
async def test_list_publisher_accounts_async(transport: str = 'grpc_asyncio', request_type=admob_api.ListPublisherAccountsRequest):
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(admob_api.ListPublisherAccountsResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_publisher_accounts(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.ListPublisherAccountsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListPublisherAccountsAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_publisher_accounts_async_from_dict():
    await test_list_publisher_accounts_async(request_type=dict)


def test_list_publisher_accounts_pager(transport_name: str = "grpc"):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='abc',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[],
                next_page_token='def',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='ghi',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        pager = client.list_publisher_accounts(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, admob_resources.PublisherAccount)
                   for i in results)
def test_list_publisher_accounts_pages(transport_name: str = "grpc"):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='abc',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[],
                next_page_token='def',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='ghi',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_publisher_accounts(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_publisher_accounts_async_pager():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='abc',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[],
                next_page_token='def',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='ghi',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_publisher_accounts(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, admob_resources.PublisherAccount)
                for i in responses)


@pytest.mark.asyncio
async def test_list_publisher_accounts_async_pages():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_publisher_accounts),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='abc',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[],
                next_page_token='def',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                ],
                next_page_token='ghi',
            ),
            admob_api.ListPublisherAccountsResponse(
                account=[
                    admob_resources.PublisherAccount(),
                    admob_resources.PublisherAccount(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_publisher_accounts(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.parametrize("request_type", [
  admob_api.GenerateNetworkReportRequest,
  dict,
])
def test_generate_network_report(request_type, transport: str = 'grpc'):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_network_report),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([admob_api.GenerateNetworkReportResponse()])
        response = client.generate_network_report(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateNetworkReportRequest()

    # Establish that the response is the type that we expect.
    for message in response:
        assert isinstance(message, admob_api.GenerateNetworkReportResponse)


def test_generate_network_report_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_network_report),
            '__call__') as call:
        client.generate_network_report()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateNetworkReportRequest()


@pytest.mark.asyncio
async def test_generate_network_report_async(transport: str = 'grpc_asyncio', request_type=admob_api.GenerateNetworkReportRequest):
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_network_report),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[admob_api.GenerateNetworkReportResponse()])
        response = await client.generate_network_report(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateNetworkReportRequest()

    # Establish that the response is the type that we expect.
    message = await response.read()
    assert isinstance(message, admob_api.GenerateNetworkReportResponse)


@pytest.mark.asyncio
async def test_generate_network_report_async_from_dict():
    await test_generate_network_report_async(request_type=dict)


def test_generate_network_report_field_headers():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GenerateNetworkReportRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_network_report),
            '__call__') as call:
        call.return_value = iter([admob_api.GenerateNetworkReportResponse()])
        client.generate_network_report(request)

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
async def test_generate_network_report_field_headers_async():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GenerateNetworkReportRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_network_report),
            '__call__') as call:
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[admob_api.GenerateNetworkReportResponse()])
        await client.generate_network_report(request)

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
  admob_api.GenerateMediationReportRequest,
  dict,
])
def test_generate_mediation_report(request_type, transport: str = 'grpc'):
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_mediation_report),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([admob_api.GenerateMediationReportResponse()])
        response = client.generate_mediation_report(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateMediationReportRequest()

    # Establish that the response is the type that we expect.
    for message in response:
        assert isinstance(message, admob_api.GenerateMediationReportResponse)


def test_generate_mediation_report_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_mediation_report),
            '__call__') as call:
        client.generate_mediation_report()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateMediationReportRequest()


@pytest.mark.asyncio
async def test_generate_mediation_report_async(transport: str = 'grpc_asyncio', request_type=admob_api.GenerateMediationReportRequest):
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_mediation_report),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[admob_api.GenerateMediationReportResponse()])
        response = await client.generate_mediation_report(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == admob_api.GenerateMediationReportRequest()

    # Establish that the response is the type that we expect.
    message = await response.read()
    assert isinstance(message, admob_api.GenerateMediationReportResponse)


@pytest.mark.asyncio
async def test_generate_mediation_report_async_from_dict():
    await test_generate_mediation_report_async(request_type=dict)


def test_generate_mediation_report_field_headers():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GenerateMediationReportRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_mediation_report),
            '__call__') as call:
        call.return_value = iter([admob_api.GenerateMediationReportResponse()])
        client.generate_mediation_report(request)

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
async def test_generate_mediation_report_field_headers_async():
    client = AdMobApiAsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = admob_api.GenerateMediationReportRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.generate_mediation_report),
            '__call__') as call:
        call.return_value = mock.Mock(aio.UnaryStreamCall, autospec=True)
        call.return_value.read = mock.AsyncMock(side_effect=[admob_api.GenerateMediationReportResponse()])
        await client.generate_mediation_report(request)

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
    transport = transports.AdMobApiGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AdMobApiClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.AdMobApiGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AdMobApiClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.AdMobApiGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AdMobApiClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AdMobApiGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = AdMobApiClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AdMobApiGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.AdMobApiGrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.AdMobApiGrpcTransport,
    transports.AdMobApiGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.AdMobApiGrpcTransport,
    )

def test_ad_mob_api_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.AdMobApiTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_ad_mob_api_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.admob_v1.services.ad_mob_api.transports.AdMobApiTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.AdMobApiTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_publisher_account',
        'list_publisher_accounts',
        'generate_network_report',
        'generate_mediation_report',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_ad_mob_api_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.ads.admob_v1.services.ad_mob_api.transports.AdMobApiTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.AdMobApiTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/admob.report',
),
            quota_project_id="octopus",
        )


def test_ad_mob_api_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.ads.admob_v1.services.ad_mob_api.transports.AdMobApiTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.AdMobApiTransport()
        adc.assert_called_once()


def test_ad_mob_api_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        AdMobApiClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/admob.report',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.AdMobApiGrpcTransport,
        transports.AdMobApiGrpcAsyncIOTransport,
    ],
)
def test_ad_mob_api_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/admob.report',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.AdMobApiGrpcTransport, grpc_helpers),
        (transports.AdMobApiGrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_ad_mob_api_transport_create_channel(transport_class, grpc_helpers):
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
            "admob.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/admob.report',
),
            scopes=["1", "2"],
            default_host="admob.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.AdMobApiGrpcTransport, transports.AdMobApiGrpcAsyncIOTransport])
def test_ad_mob_api_grpc_transport_client_cert_source_for_mtls(
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


def test_ad_mob_api_host_no_port():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='admob.googleapis.com'),
    )
    assert client.transport._host == 'admob.googleapis.com:443'


def test_ad_mob_api_host_with_port():
    client = AdMobApiClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='admob.googleapis.com:8000'),
    )
    assert client.transport._host == 'admob.googleapis.com:8000'

def test_ad_mob_api_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AdMobApiGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_ad_mob_api_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AdMobApiGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.AdMobApiGrpcTransport, transports.AdMobApiGrpcAsyncIOTransport])
def test_ad_mob_api_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class", [transports.AdMobApiGrpcTransport, transports.AdMobApiGrpcAsyncIOTransport])
def test_ad_mob_api_transport_channel_mtls_with_adc(
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


def test_publisher_account_path():
    publisher = "squid"
    expected = "accounts/{publisher}".format(publisher=publisher, )
    actual = AdMobApiClient.publisher_account_path(publisher)
    assert expected == actual


def test_parse_publisher_account_path():
    expected = {
        "publisher": "clam",
    }
    path = AdMobApiClient.publisher_account_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_publisher_account_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = AdMobApiClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "octopus",
    }
    path = AdMobApiClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"
    expected = "folders/{folder}".format(folder=folder, )
    actual = AdMobApiClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nudibranch",
    }
    path = AdMobApiClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = AdMobApiClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "mussel",
    }
    path = AdMobApiClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"
    expected = "projects/{project}".format(project=project, )
    actual = AdMobApiClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nautilus",
    }
    path = AdMobApiClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = AdMobApiClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "squid",
        "location": "clam",
    }
    path = AdMobApiClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = AdMobApiClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.AdMobApiTransport, '_prep_wrapped_messages') as prep:
        client = AdMobApiClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.AdMobApiTransport, '_prep_wrapped_messages') as prep:
        transport_class = AdMobApiClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = AdMobApiAsyncClient(
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
        client = AdMobApiClient(
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
        client = AdMobApiClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
