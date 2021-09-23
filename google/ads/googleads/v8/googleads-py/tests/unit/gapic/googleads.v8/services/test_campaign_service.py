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

from google.ads.googleads.v8.common.types import bidding
from google.ads.googleads.v8.common.types import custom_parameter
from google.ads.googleads.v8.common.types import frequency_cap
from google.ads.googleads.v8.common.types import real_time_bidding_setting
from google.ads.googleads.v8.common.types import targeting_setting
from google.ads.googleads.v8.enums.types import ad_serving_optimization_status
from google.ads.googleads.v8.enums.types import advertising_channel_sub_type
from google.ads.googleads.v8.enums.types import advertising_channel_type
from google.ads.googleads.v8.enums.types import app_campaign_app_store
from google.ads.googleads.v8.enums.types import app_campaign_bidding_strategy_goal_type
from google.ads.googleads.v8.enums.types import asset_field_type
from google.ads.googleads.v8.enums.types import bidding_strategy_type
from google.ads.googleads.v8.enums.types import brand_safety_suitability
from google.ads.googleads.v8.enums.types import campaign_experiment_type
from google.ads.googleads.v8.enums.types import campaign_serving_status
from google.ads.googleads.v8.enums.types import campaign_status
from google.ads.googleads.v8.enums.types import frequency_cap_event_type
from google.ads.googleads.v8.enums.types import frequency_cap_level
from google.ads.googleads.v8.enums.types import frequency_cap_time_unit
from google.ads.googleads.v8.enums.types import location_source_type
from google.ads.googleads.v8.enums.types import negative_geo_target_type
from google.ads.googleads.v8.enums.types import optimization_goal_type
from google.ads.googleads.v8.enums.types import payment_mode
from google.ads.googleads.v8.enums.types import positive_geo_target_type
from google.ads.googleads.v8.enums.types import response_content_type
from google.ads.googleads.v8.enums.types import target_impression_share_location
from google.ads.googleads.v8.enums.types import targeting_dimension
from google.ads.googleads.v8.enums.types import vanity_pharma_display_url_mode
from google.ads.googleads.v8.enums.types import vanity_pharma_text
from google.ads.googleads.v8.resources.types import campaign
from google.ads.googleads.v8.services.services.campaign_service import CampaignServiceClient
from google.ads.googleads.v8.services.services.campaign_service import transports
from google.ads.googleads.v8.services.types import campaign_service
from google.api_core import client_options
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore
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

    assert CampaignServiceClient._get_default_mtls_endpoint(None) is None
    assert CampaignServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert CampaignServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert CampaignServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert CampaignServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert CampaignServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_campaign_service_client_from_service_account_info():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = CampaignServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_campaign_service_client_from_service_account_file():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = CampaignServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = CampaignServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_campaign_service_client_get_transport_class():
    transport = CampaignServiceClient.get_transport_class()
    assert transport == transports.CampaignServiceGrpcTransport

    transport = CampaignServiceClient.get_transport_class("grpc")
    assert transport == transports.CampaignServiceGrpcTransport


@mock.patch.object(CampaignServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CampaignServiceClient))
def test_campaign_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v8.services.services.campaign_service.CampaignServiceClient.get_transport_class') as gtc:
        transport = transports.CampaignServiceGrpcTransport(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = CampaignServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v8.services.services.campaign_service.CampaignServiceClient.get_transport_class') as gtc:
        client = CampaignServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = CampaignServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = CampaignServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = CampaignServiceClient()
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
            client = CampaignServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = CampaignServiceClient()


@mock.patch.object(CampaignServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CampaignServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_campaign_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = CampaignServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = CampaignServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = CampaignServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_campaign_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = CampaignServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_get_campaign(transport: str = 'grpc', request_type=campaign_service.GetCampaignRequest):
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign.Campaign(
            resource_name='resource_name_value',
            id=205,
            name='name_value',
            status=campaign_status.CampaignStatusEnum.CampaignStatus.UNKNOWN,
            serving_status=campaign_serving_status.CampaignServingStatusEnum.CampaignServingStatus.UNKNOWN,
            ad_serving_optimization_status=ad_serving_optimization_status.AdServingOptimizationStatusEnum.AdServingOptimizationStatus.UNKNOWN,
            advertising_channel_type=advertising_channel_type.AdvertisingChannelTypeEnum.AdvertisingChannelType.UNKNOWN,
            advertising_channel_sub_type=advertising_channel_sub_type.AdvertisingChannelSubTypeEnum.AdvertisingChannelSubType.UNKNOWN,
            tracking_url_template='tracking_url_template_value',
            labels=['labels_value'],
            experiment_type=campaign_experiment_type.CampaignExperimentTypeEnum.CampaignExperimentType.UNKNOWN,
            base_campaign='base_campaign_value',
            campaign_budget='campaign_budget_value',
            bidding_strategy_type=bidding_strategy_type.BiddingStrategyTypeEnum.BiddingStrategyType.UNKNOWN,
            accessible_bidding_strategy='accessible_bidding_strategy_value',
            start_date='start_date_value',
            end_date='end_date_value',
            final_url_suffix='final_url_suffix_value',
            video_brand_safety_suitability=brand_safety_suitability.BrandSafetySuitabilityEnum.BrandSafetySuitability.UNKNOWN,
            payment_mode=payment_mode.PaymentModeEnum.PaymentMode.UNKNOWN,
            optimization_score=0.19540000000000002,
            excluded_parent_asset_field_types=[asset_field_type.AssetFieldTypeEnum.AssetFieldType.UNKNOWN],
            bidding_strategy='bidding_strategy_value',
        )
        response = client.get_campaign(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_service.GetCampaignRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, campaign.Campaign)
    assert response.resource_name == 'resource_name_value'
    assert response.id == 205
    assert response.name == 'name_value'
    assert response.status == campaign_status.CampaignStatusEnum.CampaignStatus.UNKNOWN
    assert response.serving_status == campaign_serving_status.CampaignServingStatusEnum.CampaignServingStatus.UNKNOWN
    assert response.ad_serving_optimization_status == ad_serving_optimization_status.AdServingOptimizationStatusEnum.AdServingOptimizationStatus.UNKNOWN
    assert response.advertising_channel_type == advertising_channel_type.AdvertisingChannelTypeEnum.AdvertisingChannelType.UNKNOWN
    assert response.advertising_channel_sub_type == advertising_channel_sub_type.AdvertisingChannelSubTypeEnum.AdvertisingChannelSubType.UNKNOWN
    assert response.tracking_url_template == 'tracking_url_template_value'
    assert response.labels == ['labels_value']
    assert response.experiment_type == campaign_experiment_type.CampaignExperimentTypeEnum.CampaignExperimentType.UNKNOWN
    assert response.base_campaign == 'base_campaign_value'
    assert response.campaign_budget == 'campaign_budget_value'
    assert response.bidding_strategy_type == bidding_strategy_type.BiddingStrategyTypeEnum.BiddingStrategyType.UNKNOWN
    assert response.accessible_bidding_strategy == 'accessible_bidding_strategy_value'
    assert response.start_date == 'start_date_value'
    assert response.end_date == 'end_date_value'
    assert response.final_url_suffix == 'final_url_suffix_value'
    assert response.video_brand_safety_suitability == brand_safety_suitability.BrandSafetySuitabilityEnum.BrandSafetySuitability.UNKNOWN
    assert response.payment_mode == payment_mode.PaymentModeEnum.PaymentMode.UNKNOWN
    assert math.isclose(response.optimization_score, 0.19540000000000002, rel_tol=1e-6)
    assert response.excluded_parent_asset_field_types == [asset_field_type.AssetFieldTypeEnum.AssetFieldType.UNKNOWN]


def test_get_campaign_from_dict():
    test_get_campaign(request_type=dict)


def test_get_campaign_field_headers():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_service.GetCampaignRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign),
            '__call__') as call:
        call.return_value = campaign.Campaign()
        client.get_campaign(request)

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


def test_get_campaign_flattened():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign.Campaign()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_campaign(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_get_campaign_flattened_error():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_campaign(
            campaign_service.GetCampaignRequest(),
            resource_name='resource_name_value',
        )


def test_mutate_campaigns(transport: str = 'grpc', request_type=campaign_service.MutateCampaignsRequest):
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaigns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_service.MutateCampaignsResponse(
        )
        response = client.mutate_campaigns(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_service.MutateCampaignsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, campaign_service.MutateCampaignsResponse)


def test_mutate_campaigns_from_dict():
    test_mutate_campaigns(request_type=dict)


def test_mutate_campaigns_field_headers():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_service.MutateCampaignsRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaigns),
            '__call__') as call:
        call.return_value = campaign_service.MutateCampaignsResponse()
        client.mutate_campaigns(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'customer_id=customer_id/value',
    ) in kw['metadata']


def test_mutate_campaigns_flattened():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaigns),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_service.MutateCampaignsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_campaigns(
            customer_id='customer_id_value',
            operations=[campaign_service.CampaignOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].customer_id == 'customer_id_value'
        assert args[0].operations == [campaign_service.CampaignOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))]


def test_mutate_campaigns_flattened_error():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_campaigns(
            campaign_service.MutateCampaignsRequest(),
            customer_id='customer_id_value',
            operations=[campaign_service.CampaignOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.CampaignServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = CampaignServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CampaignServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = CampaignServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CampaignServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.CampaignServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.CampaignServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_campaign_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.CampaignServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_campaign',
        'mutate_campaigns',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


def test_campaign_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default') as adc, mock.patch('google.ads.googleads.v8.services.services.campaign_service.transports.CampaignServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.CampaignServiceTransport()
        adc.assert_called_once()


def test_campaign_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        CampaignServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_campaign_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transports.CampaignServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_campaign_service_host_no_port():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_campaign_service_host_with_port():
    client = CampaignServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_campaign_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.CampaignServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.CampaignServiceGrpcTransport])
def test_campaign_service_transport_channel_mtls_with_client_cert_source(
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


@pytest.mark.parametrize("transport_class", [transports.CampaignServiceGrpcTransport,])
def test_campaign_service_transport_channel_mtls_with_adc(
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


def test_accessible_bidding_strategy_path():
    customer_id = "squid"
    bidding_strategy_id = "clam"
    expected = "customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = CampaignServiceClient.accessible_bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_accessible_bidding_strategy_path():
    expected = {
        "customer_id": "whelk",
        "bidding_strategy_id": "octopus",
    }
    path = CampaignServiceClient.accessible_bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_accessible_bidding_strategy_path(path)
    assert expected == actual

def test_bidding_strategy_path():
    customer_id = "oyster"
    bidding_strategy_id = "nudibranch"
    expected = "customers/{customer_id}/biddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = CampaignServiceClient.bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_bidding_strategy_path():
    expected = {
        "customer_id": "cuttlefish",
        "bidding_strategy_id": "mussel",
    }
    path = CampaignServiceClient.bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_bidding_strategy_path(path)
    assert expected == actual

def test_campaign_path():
    customer_id = "winkle"
    campaign_id = "nautilus"
    expected = "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = CampaignServiceClient.campaign_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
        "customer_id": "scallop",
        "campaign_id": "abalone",
    }
    path = CampaignServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_budget_path():
    customer_id = "squid"
    campaign_budget_id = "clam"
    expected = "customers/{customer_id}/campaignBudgets/{campaign_budget_id}".format(customer_id=customer_id, campaign_budget_id=campaign_budget_id, )
    actual = CampaignServiceClient.campaign_budget_path(customer_id, campaign_budget_id)
    assert expected == actual


def test_parse_campaign_budget_path():
    expected = {
        "customer_id": "whelk",
        "campaign_budget_id": "octopus",
    }
    path = CampaignServiceClient.campaign_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_campaign_budget_path(path)
    assert expected == actual

def test_campaign_label_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    label_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}".format(customer_id=customer_id, campaign_id=campaign_id, label_id=label_id, )
    actual = CampaignServiceClient.campaign_label_path(customer_id, campaign_id, label_id)
    assert expected == actual


def test_parse_campaign_label_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "label_id": "nautilus",
    }
    path = CampaignServiceClient.campaign_label_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_campaign_label_path(path)
    assert expected == actual

def test_conversion_action_path():
    customer_id = "scallop"
    conversion_action_id = "abalone"
    expected = "customers/{customer_id}/conversionActions/{conversion_action_id}".format(customer_id=customer_id, conversion_action_id=conversion_action_id, )
    actual = CampaignServiceClient.conversion_action_path(customer_id, conversion_action_id)
    assert expected == actual


def test_parse_conversion_action_path():
    expected = {
        "customer_id": "squid",
        "conversion_action_id": "clam",
    }
    path = CampaignServiceClient.conversion_action_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_conversion_action_path(path)
    assert expected == actual

def test_feed_path():
    customer_id = "whelk"
    feed_id = "octopus"
    expected = "customers/{customer_id}/feeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = CampaignServiceClient.feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_feed_path():
    expected = {
        "customer_id": "oyster",
        "feed_id": "nudibranch",
    }
    path = CampaignServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_feed_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "cuttlefish"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = CampaignServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "mussel",
    }
    path = CampaignServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "winkle"
    expected = "folders/{folder}".format(folder=folder, )
    actual = CampaignServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nautilus",
    }
    path = CampaignServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "scallop"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = CampaignServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "abalone",
    }
    path = CampaignServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "squid"
    expected = "projects/{project}".format(project=project, )
    actual = CampaignServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "clam",
    }
    path = CampaignServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "whelk"
    location = "octopus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = CampaignServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "oyster",
        "location": "nudibranch",
    }
    path = CampaignServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.CampaignServiceTransport, '_prep_wrapped_messages') as prep:
        client = CampaignServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.CampaignServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = CampaignServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
