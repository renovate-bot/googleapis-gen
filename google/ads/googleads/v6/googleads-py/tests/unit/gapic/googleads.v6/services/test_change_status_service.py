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
from unittest import mock

import grpc
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule

from google.ads.googleads.v6.enums.types import change_status_operation
from google.ads.googleads.v6.enums.types import change_status_resource_type
from google.ads.googleads.v6.resources.types import change_status
from google.ads.googleads.v6.services.services.change_status_service import ChangeStatusServiceClient
from google.ads.googleads.v6.services.services.change_status_service import transports
from google.ads.googleads.v6.services.types import change_status_service
from google.api_core import client_options
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
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

    assert ChangeStatusServiceClient._get_default_mtls_endpoint(None) is None
    assert ChangeStatusServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert ChangeStatusServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert ChangeStatusServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert ChangeStatusServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert ChangeStatusServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_change_status_service_client_from_service_account_info():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = ChangeStatusServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_change_status_service_client_from_service_account_file():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = ChangeStatusServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = ChangeStatusServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_change_status_service_client_get_transport_class():
    transport = ChangeStatusServiceClient.get_transport_class()
    assert transport == transports.ChangeStatusServiceGrpcTransport

    transport = ChangeStatusServiceClient.get_transport_class("grpc")
    assert transport == transports.ChangeStatusServiceGrpcTransport


@mock.patch.object(ChangeStatusServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ChangeStatusServiceClient))
def test_change_status_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v6.services.services.change_status_service.ChangeStatusServiceClient.get_transport_class') as gtc:
        transport = transports.ChangeStatusServiceGrpcTransport(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = ChangeStatusServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v6.services.services.change_status_service.ChangeStatusServiceClient.get_transport_class') as gtc:
        client = ChangeStatusServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = ChangeStatusServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = ChangeStatusServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = ChangeStatusServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_MTLS_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT has
    # unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "Unsupported"}):
        with pytest.raises(MutualTLSChannelError):
            client = ChangeStatusServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = ChangeStatusServiceClient()


@mock.patch.object(ChangeStatusServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ChangeStatusServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_change_status_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = ChangeStatusServiceClient(client_options=options)

                if use_client_cert_env == "false":
                    expected_ssl_channel_creds = None
                    expected_host = client.DEFAULT_ENDPOINT
                else:
                    expected_ssl_channel_creds = ssl_channel_creds
                    expected_host = client.DEFAULT_MTLS_ENDPOINT

                grpc_transport.assert_called_once_with(
                    ssl_channel_credentials=expected_ssl_channel_creds,
                    credentials=None,
                    host=expected_host,
                    client_info=transports.base.DEFAULT_CLIENT_INFO,
                )

    # Check the case ADC client cert is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    with mock.patch('google.auth.transport.grpc.SslCredentials.ssl_credentials', new_callable=mock.PropertyMock) as ssl_credentials_mock:
                        if use_client_cert_env == "false":
                            is_mtls_mock.return_value = False
                            ssl_credentials_mock.return_value = None
                            expected_host = client.DEFAULT_ENDPOINT
                            expected_ssl_channel_creds = None
                        else:
                            is_mtls_mock.return_value = True
                            ssl_credentials_mock.return_value = mock.Mock()
                            expected_host = client.DEFAULT_MTLS_ENDPOINT
                            expected_ssl_channel_creds = ssl_credentials_mock.return_value

                        grpc_transport.return_value = None
                        client = ChangeStatusServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = ChangeStatusServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_change_status_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = ChangeStatusServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_get_change_status(transport: str = 'grpc', request_type=change_status_service.GetChangeStatusRequest):
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_change_status),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = change_status.ChangeStatus(
            resource_name='resource_name_value',
            last_change_date_time='last_change_date_time_value',
            resource_type=change_status_resource_type.ChangeStatusResourceTypeEnum.ChangeStatusResourceType.UNKNOWN,
            campaign='campaign_value',
            ad_group='ad_group_value',
            resource_status=change_status_operation.ChangeStatusOperationEnum.ChangeStatusOperation.UNKNOWN,
            ad_group_ad='ad_group_ad_value',
            ad_group_criterion='ad_group_criterion_value',
            campaign_criterion='campaign_criterion_value',
            feed='feed_value',
            feed_item='feed_item_value',
            ad_group_feed='ad_group_feed_value',
            campaign_feed='campaign_feed_value',
            ad_group_bid_modifier='ad_group_bid_modifier_value',
        )
        response = client.get_change_status(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == change_status_service.GetChangeStatusRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, change_status.ChangeStatus)
    assert response.resource_name == 'resource_name_value'
    assert response.last_change_date_time == 'last_change_date_time_value'
    assert response.resource_type == change_status_resource_type.ChangeStatusResourceTypeEnum.ChangeStatusResourceType.UNKNOWN
    assert response.campaign == 'campaign_value'
    assert response.ad_group == 'ad_group_value'
    assert response.resource_status == change_status_operation.ChangeStatusOperationEnum.ChangeStatusOperation.UNKNOWN
    assert response.ad_group_ad == 'ad_group_ad_value'
    assert response.ad_group_criterion == 'ad_group_criterion_value'
    assert response.campaign_criterion == 'campaign_criterion_value'
    assert response.feed == 'feed_value'
    assert response.feed_item == 'feed_item_value'
    assert response.ad_group_feed == 'ad_group_feed_value'
    assert response.campaign_feed == 'campaign_feed_value'
    assert response.ad_group_bid_modifier == 'ad_group_bid_modifier_value'


def test_get_change_status_from_dict():
    test_get_change_status(request_type=dict)


def test_get_change_status_field_headers():
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = change_status_service.GetChangeStatusRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_change_status),
            '__call__') as call:
        call.return_value = change_status.ChangeStatus()
        client.get_change_status(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource_name=resource_name/value',
    ) in kw['metadata']


def test_get_change_status_flattened():
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_change_status),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = change_status.ChangeStatus()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_change_status(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_get_change_status_flattened_error():
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_change_status(
            change_status_service.GetChangeStatusRequest(),
            resource_name='resource_name_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.ChangeStatusServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = ChangeStatusServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ChangeStatusServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = ChangeStatusServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ChangeStatusServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.ChangeStatusServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.ChangeStatusServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_change_status_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.ChangeStatusServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_change_status',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


def test_change_status_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default') as adc, mock.patch('google.ads.googleads.v6.services.services.change_status_service.transports.ChangeStatusServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.ChangeStatusServiceTransport()
        adc.assert_called_once()


def test_change_status_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        ChangeStatusServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_change_status_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transports.ChangeStatusServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_change_status_service_host_no_port():
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_change_status_service_host_with_port():
    client = ChangeStatusServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_change_status_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.ChangeStatusServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.ChangeStatusServiceGrpcTransport])
def test_change_status_service_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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
                    'https://www.googleapis.com/auth/adwords',
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


@pytest.mark.parametrize("transport_class", [transports.ChangeStatusServiceGrpcTransport,])
def test_change_status_service_transport_channel_mtls_with_adc(
    transport_class
):
    mock_ssl_cred = mock.Mock()
    with mock.patch.multiple(
        "google.auth.transport.grpc.SslCredentials",
        __init__=mock.Mock(return_value=None),
        ssl_credentials=mock.PropertyMock(return_value=mock_ssl_cred),
    ):
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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
                    'https://www.googleapis.com/auth/adwords',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_ad_group_path():
    customer_id = "squid"
    ad_group_id = "clam"
    expected = "customers/{customer_id}/adGroups/{ad_group_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, )
    actual = ChangeStatusServiceClient.ad_group_path(customer_id, ad_group_id)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
    }
    path = ChangeStatusServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_ad_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    ad_id = "cuttlefish"
    expected = "customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, )
    actual = ChangeStatusServiceClient.ad_group_ad_path(customer_id, ad_group_id, ad_id)
    assert expected == actual


def test_parse_ad_group_ad_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "ad_id": "nautilus",
    }
    path = ChangeStatusServiceClient.ad_group_ad_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_ad_group_ad_path(path)
    assert expected == actual

def test_ad_group_bid_modifier_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = ChangeStatusServiceClient.ad_group_bid_modifier_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_bid_modifier_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = ChangeStatusServiceClient.ad_group_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_ad_group_bid_modifier_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = ChangeStatusServiceClient.ad_group_criterion_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = ChangeStatusServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_feed_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    feed_id = "squid"
    expected = "customers/{customer_id}/adGroupFeeds/{ad_group_id}~{feed_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, feed_id=feed_id, )
    actual = ChangeStatusServiceClient.ad_group_feed_path(customer_id, ad_group_id, feed_id)
    assert expected == actual


def test_parse_ad_group_feed_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "feed_id": "octopus",
    }
    path = ChangeStatusServiceClient.ad_group_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_ad_group_feed_path(path)
    assert expected == actual

def test_campaign_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    expected = "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = ChangeStatusServiceClient.campaign_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
    }
    path = ChangeStatusServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_criterion_path():
    customer_id = "winkle"
    campaign_id = "nautilus"
    criterion_id = "scallop"
    expected = "customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = ChangeStatusServiceClient.campaign_criterion_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_criterion_path():
    expected = {
        "customer_id": "abalone",
        "campaign_id": "squid",
        "criterion_id": "clam",
    }
    path = ChangeStatusServiceClient.campaign_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_campaign_criterion_path(path)
    assert expected == actual

def test_campaign_feed_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    feed_id = "oyster"
    expected = "customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}".format(customer_id=customer_id, campaign_id=campaign_id, feed_id=feed_id, )
    actual = ChangeStatusServiceClient.campaign_feed_path(customer_id, campaign_id, feed_id)
    assert expected == actual


def test_parse_campaign_feed_path():
    expected = {
        "customer_id": "nudibranch",
        "campaign_id": "cuttlefish",
        "feed_id": "mussel",
    }
    path = ChangeStatusServiceClient.campaign_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_campaign_feed_path(path)
    assert expected == actual

def test_change_status_path():
    customer_id = "winkle"
    change_status_id = "nautilus"
    expected = "customers/{customer_id}/changeStatus/{change_status_id}".format(customer_id=customer_id, change_status_id=change_status_id, )
    actual = ChangeStatusServiceClient.change_status_path(customer_id, change_status_id)
    assert expected == actual


def test_parse_change_status_path():
    expected = {
        "customer_id": "scallop",
        "change_status_id": "abalone",
    }
    path = ChangeStatusServiceClient.change_status_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_change_status_path(path)
    assert expected == actual

def test_feed_path():
    customer_id = "squid"
    feed_id = "clam"
    expected = "customers/{customer_id}/feeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = ChangeStatusServiceClient.feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_feed_path():
    expected = {
        "customer_id": "whelk",
        "feed_id": "octopus",
    }
    path = ChangeStatusServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_feed_path(path)
    assert expected == actual

def test_feed_item_path():
    customer_id = "oyster"
    feed_id = "nudibranch"
    feed_item_id = "cuttlefish"
    expected = "customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_id=feed_item_id, )
    actual = ChangeStatusServiceClient.feed_item_path(customer_id, feed_id, feed_item_id)
    assert expected == actual


def test_parse_feed_item_path():
    expected = {
        "customer_id": "mussel",
        "feed_id": "winkle",
        "feed_item_id": "nautilus",
    }
    path = ChangeStatusServiceClient.feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_feed_item_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "scallop"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = ChangeStatusServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "abalone",
    }
    path = ChangeStatusServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "squid"
    expected = "folders/{folder}".format(folder=folder, )
    actual = ChangeStatusServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "clam",
    }
    path = ChangeStatusServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "whelk"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = ChangeStatusServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "octopus",
    }
    path = ChangeStatusServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "oyster"
    expected = "projects/{project}".format(project=project, )
    actual = ChangeStatusServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nudibranch",
    }
    path = ChangeStatusServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "cuttlefish"
    location = "mussel"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = ChangeStatusServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "winkle",
        "location": "nautilus",
    }
    path = ChangeStatusServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = ChangeStatusServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.ChangeStatusServiceTransport, '_prep_wrapped_messages') as prep:
        client = ChangeStatusServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.ChangeStatusServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = ChangeStatusServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
