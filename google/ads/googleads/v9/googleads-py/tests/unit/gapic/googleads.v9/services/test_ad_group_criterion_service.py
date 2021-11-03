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

from google.ads.googleads.v9.common.types import criteria
from google.ads.googleads.v9.common.types import custom_parameter
from google.ads.googleads.v9.common.types import policy
from google.ads.googleads.v9.enums.types import ad_group_criterion_approval_status
from google.ads.googleads.v9.enums.types import ad_group_criterion_status
from google.ads.googleads.v9.enums.types import age_range_type
from google.ads.googleads.v9.enums.types import app_payment_model_type
from google.ads.googleads.v9.enums.types import bidding_source
from google.ads.googleads.v9.enums.types import criterion_system_serving_status
from google.ads.googleads.v9.enums.types import criterion_type
from google.ads.googleads.v9.enums.types import gender_type
from google.ads.googleads.v9.enums.types import income_range_type
from google.ads.googleads.v9.enums.types import keyword_match_type
from google.ads.googleads.v9.enums.types import listing_group_type
from google.ads.googleads.v9.enums.types import parental_status_type
from google.ads.googleads.v9.enums.types import product_bidding_category_level
from google.ads.googleads.v9.enums.types import product_channel
from google.ads.googleads.v9.enums.types import product_channel_exclusivity
from google.ads.googleads.v9.enums.types import product_condition
from google.ads.googleads.v9.enums.types import product_custom_attribute_index
from google.ads.googleads.v9.enums.types import product_type_level
from google.ads.googleads.v9.enums.types import quality_score_bucket
from google.ads.googleads.v9.enums.types import response_content_type
from google.ads.googleads.v9.enums.types import webpage_condition_operand
from google.ads.googleads.v9.enums.types import webpage_condition_operator
from google.ads.googleads.v9.resources.types import ad_group_criterion
from google.ads.googleads.v9.services.services.ad_group_criterion_service import AdGroupCriterionServiceClient
from google.ads.googleads.v9.services.services.ad_group_criterion_service import transports
from google.ads.googleads.v9.services.types import ad_group_criterion_service
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

    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(None) is None
    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert AdGroupCriterionServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_ad_group_criterion_service_client_from_service_account_info():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = AdGroupCriterionServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_ad_group_criterion_service_client_from_service_account_file():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = AdGroupCriterionServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = AdGroupCriterionServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_ad_group_criterion_service_client_get_transport_class():
    transport = AdGroupCriterionServiceClient.get_transport_class()
    assert transport == transports.AdGroupCriterionServiceGrpcTransport

    transport = AdGroupCriterionServiceClient.get_transport_class("grpc")
    assert transport == transports.AdGroupCriterionServiceGrpcTransport


@mock.patch.object(AdGroupCriterionServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdGroupCriterionServiceClient))
def test_ad_group_criterion_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.AdGroupCriterionServiceClient.get_transport_class') as gtc:
        transport = transports.AdGroupCriterionServiceGrpcTransport(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = AdGroupCriterionServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.AdGroupCriterionServiceClient.get_transport_class') as gtc:
        client = AdGroupCriterionServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = AdGroupCriterionServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = AdGroupCriterionServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = AdGroupCriterionServiceClient()
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
            client = AdGroupCriterionServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = AdGroupCriterionServiceClient()


@mock.patch.object(AdGroupCriterionServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AdGroupCriterionServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_ad_group_criterion_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = AdGroupCriterionServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = AdGroupCriterionServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = AdGroupCriterionServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_ad_group_criterion_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = AdGroupCriterionServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_get_ad_group_criterion(transport: str = 'grpc', request_type=ad_group_criterion_service.GetAdGroupCriterionRequest):
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_ad_group_criterion),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = ad_group_criterion.AdGroupCriterion(
            resource_name='resource_name_value',
            criterion_id=1275,
            display_name='display_name_value',
            status=ad_group_criterion_status.AdGroupCriterionStatusEnum.AdGroupCriterionStatus.UNKNOWN,
            ad_group='ad_group_value',
            type_=criterion_type.CriterionTypeEnum.CriterionType.UNKNOWN,
            negative=True,
            system_serving_status=criterion_system_serving_status.CriterionSystemServingStatusEnum.CriterionSystemServingStatus.UNKNOWN,
            approval_status=ad_group_criterion_approval_status.AdGroupCriterionApprovalStatusEnum.AdGroupCriterionApprovalStatus.UNKNOWN,
            disapproval_reasons=['disapproval_reasons_value'],
            labels=['labels_value'],
            bid_modifier=0.1245,
            cpc_bid_micros=1456,
            cpm_bid_micros=1466,
            cpv_bid_micros=1475,
            percent_cpc_bid_micros=2304,
            effective_cpc_bid_micros=2496,
            effective_cpm_bid_micros=2506,
            effective_cpv_bid_micros=2515,
            effective_percent_cpc_bid_micros=3344,
            effective_cpc_bid_source=bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN,
            effective_cpm_bid_source=bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN,
            effective_cpv_bid_source=bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN,
            effective_percent_cpc_bid_source=bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN,
            final_urls=['final_urls_value'],
            final_mobile_urls=['final_mobile_urls_value'],
            final_url_suffix='final_url_suffix_value',
            tracking_url_template='tracking_url_template_value',
            keyword=criteria.KeywordInfo(text='text_value'),
        )
        response = client.get_ad_group_criterion(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == ad_group_criterion_service.GetAdGroupCriterionRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, ad_group_criterion.AdGroupCriterion)
    assert response.resource_name == 'resource_name_value'
    assert response.criterion_id == 1275
    assert response.display_name == 'display_name_value'
    assert response.status == ad_group_criterion_status.AdGroupCriterionStatusEnum.AdGroupCriterionStatus.UNKNOWN
    assert response.ad_group == 'ad_group_value'
    assert response.type_ == criterion_type.CriterionTypeEnum.CriterionType.UNKNOWN
    assert response.negative is True
    assert response.system_serving_status == criterion_system_serving_status.CriterionSystemServingStatusEnum.CriterionSystemServingStatus.UNKNOWN
    assert response.approval_status == ad_group_criterion_approval_status.AdGroupCriterionApprovalStatusEnum.AdGroupCriterionApprovalStatus.UNKNOWN
    assert response.disapproval_reasons == ['disapproval_reasons_value']
    assert response.labels == ['labels_value']
    assert math.isclose(response.bid_modifier, 0.1245, rel_tol=1e-6)
    assert response.cpc_bid_micros == 1456
    assert response.cpm_bid_micros == 1466
    assert response.cpv_bid_micros == 1475
    assert response.percent_cpc_bid_micros == 2304
    assert response.effective_cpc_bid_micros == 2496
    assert response.effective_cpm_bid_micros == 2506
    assert response.effective_cpv_bid_micros == 2515
    assert response.effective_percent_cpc_bid_micros == 3344
    assert response.effective_cpc_bid_source == bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN
    assert response.effective_cpm_bid_source == bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN
    assert response.effective_cpv_bid_source == bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN
    assert response.effective_percent_cpc_bid_source == bidding_source.BiddingSourceEnum.BiddingSource.UNKNOWN
    assert response.final_urls == ['final_urls_value']
    assert response.final_mobile_urls == ['final_mobile_urls_value']
    assert response.final_url_suffix == 'final_url_suffix_value'
    assert response.tracking_url_template == 'tracking_url_template_value'


def test_get_ad_group_criterion_from_dict():
    test_get_ad_group_criterion(request_type=dict)


def test_get_ad_group_criterion_field_headers():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = ad_group_criterion_service.GetAdGroupCriterionRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_ad_group_criterion),
            '__call__') as call:
        call.return_value = ad_group_criterion.AdGroupCriterion()
        client.get_ad_group_criterion(request)

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


def test_get_ad_group_criterion_flattened():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_ad_group_criterion),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = ad_group_criterion.AdGroupCriterion()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_ad_group_criterion(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_get_ad_group_criterion_flattened_error():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_ad_group_criterion(
            ad_group_criterion_service.GetAdGroupCriterionRequest(),
            resource_name='resource_name_value',
        )


def test_mutate_ad_group_criteria(transport: str = 'grpc', request_type=ad_group_criterion_service.MutateAdGroupCriteriaRequest):
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_ad_group_criteria),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = ad_group_criterion_service.MutateAdGroupCriteriaResponse(
        )
        response = client.mutate_ad_group_criteria(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == ad_group_criterion_service.MutateAdGroupCriteriaRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, ad_group_criterion_service.MutateAdGroupCriteriaResponse)


def test_mutate_ad_group_criteria_from_dict():
    test_mutate_ad_group_criteria(request_type=dict)


def test_mutate_ad_group_criteria_field_headers():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = ad_group_criterion_service.MutateAdGroupCriteriaRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_ad_group_criteria),
            '__call__') as call:
        call.return_value = ad_group_criterion_service.MutateAdGroupCriteriaResponse()
        client.mutate_ad_group_criteria(request)

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


def test_mutate_ad_group_criteria_flattened():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_ad_group_criteria),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = ad_group_criterion_service.MutateAdGroupCriteriaResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_ad_group_criteria(
            customer_id='customer_id_value',
            operations=[ad_group_criterion_service.AdGroupCriterionOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].customer_id == 'customer_id_value'
        assert args[0].operations == [ad_group_criterion_service.AdGroupCriterionOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))]


def test_mutate_ad_group_criteria_flattened_error():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_ad_group_criteria(
            ad_group_criterion_service.MutateAdGroupCriteriaRequest(),
            customer_id='customer_id_value',
            operations=[ad_group_criterion_service.AdGroupCriterionOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.AdGroupCriterionServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AdGroupCriterionServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AdGroupCriterionServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = AdGroupCriterionServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AdGroupCriterionServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.AdGroupCriterionServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.AdGroupCriterionServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_ad_group_criterion_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.AdGroupCriterionServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_ad_group_criterion',
        'mutate_ad_group_criteria',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_ad_group_criterion_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default') as adc, mock.patch('google.ads.googleads.v9.services.services.ad_group_criterion_service.transports.AdGroupCriterionServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.AdGroupCriterionServiceTransport()
        adc.assert_called_once()


def test_ad_group_criterion_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        AdGroupCriterionServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_ad_group_criterion_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transports.AdGroupCriterionServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_ad_group_criterion_service_host_no_port():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_ad_group_criterion_service_host_with_port():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_ad_group_criterion_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.AdGroupCriterionServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.AdGroupCriterionServiceGrpcTransport])
def test_ad_group_criterion_service_transport_channel_mtls_with_client_cert_source(
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


@pytest.mark.parametrize("transport_class", [transports.AdGroupCriterionServiceGrpcTransport,])
def test_ad_group_criterion_service_transport_channel_mtls_with_adc(
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
    actual = AdGroupCriterionServiceClient.ad_group_path(customer_id, ad_group_id)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
    }
    path = AdGroupCriterionServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = AdGroupCriterionServiceClient.ad_group_criterion_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = AdGroupCriterionServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_criterion_label_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    label_id = "clam"
    expected = "customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, label_id=label_id, )
    actual = AdGroupCriterionServiceClient.ad_group_criterion_label_path(customer_id, ad_group_id, criterion_id, label_id)
    assert expected == actual


def test_parse_ad_group_criterion_label_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
        "criterion_id": "oyster",
        "label_id": "nudibranch",
    }
    path = AdGroupCriterionServiceClient.ad_group_criterion_label_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_ad_group_criterion_label_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "cuttlefish"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = AdGroupCriterionServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "mussel",
    }
    path = AdGroupCriterionServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "winkle"
    expected = "folders/{folder}".format(folder=folder, )
    actual = AdGroupCriterionServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nautilus",
    }
    path = AdGroupCriterionServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "scallop"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = AdGroupCriterionServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "abalone",
    }
    path = AdGroupCriterionServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "squid"
    expected = "projects/{project}".format(project=project, )
    actual = AdGroupCriterionServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "clam",
    }
    path = AdGroupCriterionServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "whelk"
    location = "octopus"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = AdGroupCriterionServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "oyster",
        "location": "nudibranch",
    }
    path = AdGroupCriterionServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = AdGroupCriterionServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.AdGroupCriterionServiceTransport, '_prep_wrapped_messages') as prep:
        client = AdGroupCriterionServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.AdGroupCriterionServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = AdGroupCriterionServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

def test_grpc_transport_close():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )
    with mock.patch.object(type(client.transport._grpc_channel), 'close') as chan_close:
        with client as _:
            chan_close.assert_not_called()
        chan_close.assert_called_once()

def test_grpc_client_ctx():
    client = AdGroupCriterionServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )
    # Test client calls underlying transport.
    with mock.patch.object(type(client.transport), "close") as close:
        close.assert_not_called()
        with client as _:
            pass
        close.assert_called()
