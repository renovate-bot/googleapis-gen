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

from google import auth
from google.ads.googleads.v5.common.types import ad_asset
from google.ads.googleads.v5.common.types import ad_type_infos
from google.ads.googleads.v5.common.types import asset_types
from google.ads.googleads.v5.common.types import bidding
from google.ads.googleads.v5.common.types import criteria
from google.ads.googleads.v5.common.types import custom_parameter
from google.ads.googleads.v5.common.types import dates
from google.ads.googleads.v5.common.types import explorer_auto_optimizer_setting
from google.ads.googleads.v5.common.types import extensions
from google.ads.googleads.v5.common.types import feed_common
from google.ads.googleads.v5.common.types import final_app_url
from google.ads.googleads.v5.common.types import frequency_cap
from google.ads.googleads.v5.common.types import matching_function
from google.ads.googleads.v5.common.types import policy
from google.ads.googleads.v5.common.types import real_time_bidding_setting
from google.ads.googleads.v5.common.types import tag_snippet
from google.ads.googleads.v5.common.types import targeting_setting
from google.ads.googleads.v5.common.types import text_label
from google.ads.googleads.v5.common.types import url_collection
from google.ads.googleads.v5.common.types import user_lists
from google.ads.googleads.v5.enums.types import access_reason
from google.ads.googleads.v5.enums.types import ad_customizer_placeholder_field
from google.ads.googleads.v5.enums.types import ad_group_ad_rotation_mode
from google.ads.googleads.v5.enums.types import ad_group_ad_status
from google.ads.googleads.v5.enums.types import ad_group_criterion_approval_status
from google.ads.googleads.v5.enums.types import ad_group_criterion_status
from google.ads.googleads.v5.enums.types import ad_group_status
from google.ads.googleads.v5.enums.types import ad_group_type
from google.ads.googleads.v5.enums.types import ad_serving_optimization_status
from google.ads.googleads.v5.enums.types import ad_strength
from google.ads.googleads.v5.enums.types import ad_type
from google.ads.googleads.v5.enums.types import advertising_channel_sub_type
from google.ads.googleads.v5.enums.types import advertising_channel_type
from google.ads.googleads.v5.enums.types import affiliate_location_feed_relationship_type
from google.ads.googleads.v5.enums.types import affiliate_location_placeholder_field
from google.ads.googleads.v5.enums.types import age_range_type
from google.ads.googleads.v5.enums.types import app_campaign_app_store
from google.ads.googleads.v5.enums.types import app_campaign_bidding_strategy_goal_type
from google.ads.googleads.v5.enums.types import app_payment_model_type
from google.ads.googleads.v5.enums.types import app_placeholder_field
from google.ads.googleads.v5.enums.types import app_store
from google.ads.googleads.v5.enums.types import app_url_operating_system_type
from google.ads.googleads.v5.enums.types import asset_field_type
from google.ads.googleads.v5.enums.types import asset_link_status
from google.ads.googleads.v5.enums.types import asset_type
from google.ads.googleads.v5.enums.types import attribution_model
from google.ads.googleads.v5.enums.types import bid_modifier_source
from google.ads.googleads.v5.enums.types import bidding_source
from google.ads.googleads.v5.enums.types import bidding_strategy_status
from google.ads.googleads.v5.enums.types import bidding_strategy_type
from google.ads.googleads.v5.enums.types import brand_safety_suitability
from google.ads.googleads.v5.enums.types import budget_delivery_method
from google.ads.googleads.v5.enums.types import budget_period
from google.ads.googleads.v5.enums.types import budget_status
from google.ads.googleads.v5.enums.types import budget_type
from google.ads.googleads.v5.enums.types import call_conversion_reporting_state
from google.ads.googleads.v5.enums.types import call_placeholder_field
from google.ads.googleads.v5.enums.types import callout_placeholder_field
from google.ads.googleads.v5.enums.types import campaign_criterion_status
from google.ads.googleads.v5.enums.types import campaign_draft_status
from google.ads.googleads.v5.enums.types import campaign_experiment_status
from google.ads.googleads.v5.enums.types import campaign_experiment_traffic_split_type
from google.ads.googleads.v5.enums.types import campaign_experiment_type
from google.ads.googleads.v5.enums.types import campaign_serving_status
from google.ads.googleads.v5.enums.types import campaign_shared_set_status
from google.ads.googleads.v5.enums.types import campaign_status
from google.ads.googleads.v5.enums.types import content_label_type
from google.ads.googleads.v5.enums.types import conversion_action_category
from google.ads.googleads.v5.enums.types import conversion_action_counting_type
from google.ads.googleads.v5.enums.types import conversion_action_status
from google.ads.googleads.v5.enums.types import conversion_action_type
from google.ads.googleads.v5.enums.types import criterion_system_serving_status
from google.ads.googleads.v5.enums.types import criterion_type
from google.ads.googleads.v5.enums.types import custom_placeholder_field
from google.ads.googleads.v5.enums.types import customer_match_upload_key_type
from google.ads.googleads.v5.enums.types import customer_pay_per_conversion_eligibility_failure_reason
from google.ads.googleads.v5.enums.types import data_driven_model_status
from google.ads.googleads.v5.enums.types import day_of_week
from google.ads.googleads.v5.enums.types import device
from google.ads.googleads.v5.enums.types import display_ad_format_setting
from google.ads.googleads.v5.enums.types import display_upload_product_type
from google.ads.googleads.v5.enums.types import dsa_page_feed_criterion_field
from google.ads.googleads.v5.enums.types import education_placeholder_field
from google.ads.googleads.v5.enums.types import extension_setting_device
from google.ads.googleads.v5.enums.types import extension_type
from google.ads.googleads.v5.enums.types import feed_attribute_type
from google.ads.googleads.v5.enums.types import feed_item_quality_approval_status
from google.ads.googleads.v5.enums.types import feed_item_quality_disapproval_reason
from google.ads.googleads.v5.enums.types import feed_item_status
from google.ads.googleads.v5.enums.types import feed_item_target_device
from google.ads.googleads.v5.enums.types import feed_item_target_status
from google.ads.googleads.v5.enums.types import feed_item_target_type
from google.ads.googleads.v5.enums.types import feed_item_validation_status
from google.ads.googleads.v5.enums.types import feed_link_status
from google.ads.googleads.v5.enums.types import feed_mapping_criterion_type
from google.ads.googleads.v5.enums.types import feed_mapping_status
from google.ads.googleads.v5.enums.types import feed_origin
from google.ads.googleads.v5.enums.types import feed_status
from google.ads.googleads.v5.enums.types import flight_placeholder_field
from google.ads.googleads.v5.enums.types import frequency_cap_event_type
from google.ads.googleads.v5.enums.types import frequency_cap_level
from google.ads.googleads.v5.enums.types import frequency_cap_time_unit
from google.ads.googleads.v5.enums.types import gender_type
from google.ads.googleads.v5.enums.types import geo_targeting_restriction
from google.ads.googleads.v5.enums.types import hotel_date_selection_type
from google.ads.googleads.v5.enums.types import hotel_placeholder_field
from google.ads.googleads.v5.enums.types import income_range_type
from google.ads.googleads.v5.enums.types import interaction_type
from google.ads.googleads.v5.enums.types import job_placeholder_field
from google.ads.googleads.v5.enums.types import keyword_match_type
from google.ads.googleads.v5.enums.types import keyword_plan_forecast_interval
from google.ads.googleads.v5.enums.types import keyword_plan_network
from google.ads.googleads.v5.enums.types import label_status
from google.ads.googleads.v5.enums.types import legacy_app_install_ad_app_store
from google.ads.googleads.v5.enums.types import listing_group_type
from google.ads.googleads.v5.enums.types import local_placeholder_field
from google.ads.googleads.v5.enums.types import location_extension_targeting_criterion_field
from google.ads.googleads.v5.enums.types import location_group_radius_units
from google.ads.googleads.v5.enums.types import location_placeholder_field
from google.ads.googleads.v5.enums.types import location_source_type
from google.ads.googleads.v5.enums.types import matching_function_context_type
from google.ads.googleads.v5.enums.types import matching_function_operator
from google.ads.googleads.v5.enums.types import media_type
from google.ads.googleads.v5.enums.types import message_placeholder_field
from google.ads.googleads.v5.enums.types import mime_type
from google.ads.googleads.v5.enums.types import minute_of_hour
from google.ads.googleads.v5.enums.types import mobile_app_vendor
from google.ads.googleads.v5.enums.types import negative_geo_target_type
from google.ads.googleads.v5.enums.types import optimization_goal_type
from google.ads.googleads.v5.enums.types import parental_status_type
from google.ads.googleads.v5.enums.types import payment_mode
from google.ads.googleads.v5.enums.types import placeholder_type
from google.ads.googleads.v5.enums.types import policy_approval_status
from google.ads.googleads.v5.enums.types import policy_review_status
from google.ads.googleads.v5.enums.types import policy_topic_entry_type
from google.ads.googleads.v5.enums.types import policy_topic_evidence_destination_mismatch_url_type
from google.ads.googleads.v5.enums.types import policy_topic_evidence_destination_not_working_device
from google.ads.googleads.v5.enums.types import policy_topic_evidence_destination_not_working_dns_error_type
from google.ads.googleads.v5.enums.types import positive_geo_target_type
from google.ads.googleads.v5.enums.types import preferred_content_type
from google.ads.googleads.v5.enums.types import price_extension_price_qualifier
from google.ads.googleads.v5.enums.types import price_extension_price_unit
from google.ads.googleads.v5.enums.types import price_extension_type
from google.ads.googleads.v5.enums.types import price_placeholder_field
from google.ads.googleads.v5.enums.types import product_bidding_category_level
from google.ads.googleads.v5.enums.types import product_channel
from google.ads.googleads.v5.enums.types import product_channel_exclusivity
from google.ads.googleads.v5.enums.types import product_condition
from google.ads.googleads.v5.enums.types import product_custom_attribute_index
from google.ads.googleads.v5.enums.types import product_type_level
from google.ads.googleads.v5.enums.types import promotion_extension_discount_modifier
from google.ads.googleads.v5.enums.types import promotion_extension_occasion
from google.ads.googleads.v5.enums.types import promotion_placeholder_field
from google.ads.googleads.v5.enums.types import proximity_radius_units
from google.ads.googleads.v5.enums.types import quality_score_bucket
from google.ads.googleads.v5.enums.types import real_estate_placeholder_field
from google.ads.googleads.v5.enums.types import response_content_type
from google.ads.googleads.v5.enums.types import served_asset_field_type
from google.ads.googleads.v5.enums.types import shared_set_status
from google.ads.googleads.v5.enums.types import shared_set_type
from google.ads.googleads.v5.enums.types import sitelink_placeholder_field
from google.ads.googleads.v5.enums.types import structured_snippet_placeholder_field
from google.ads.googleads.v5.enums.types import summary_row_setting
from google.ads.googleads.v5.enums.types import system_managed_entity_source
from google.ads.googleads.v5.enums.types import target_impression_share_location
from google.ads.googleads.v5.enums.types import targeting_dimension
from google.ads.googleads.v5.enums.types import tracking_code_page_format
from google.ads.googleads.v5.enums.types import tracking_code_type
from google.ads.googleads.v5.enums.types import travel_placeholder_field
from google.ads.googleads.v5.enums.types import user_list_access_status
from google.ads.googleads.v5.enums.types import user_list_closing_reason
from google.ads.googleads.v5.enums.types import user_list_combined_rule_operator
from google.ads.googleads.v5.enums.types import user_list_crm_data_source_type
from google.ads.googleads.v5.enums.types import user_list_date_rule_item_operator
from google.ads.googleads.v5.enums.types import user_list_logical_rule_operator
from google.ads.googleads.v5.enums.types import user_list_membership_status
from google.ads.googleads.v5.enums.types import user_list_number_rule_item_operator
from google.ads.googleads.v5.enums.types import user_list_prepopulation_status
from google.ads.googleads.v5.enums.types import user_list_rule_type
from google.ads.googleads.v5.enums.types import user_list_size_range
from google.ads.googleads.v5.enums.types import user_list_string_rule_item_operator
from google.ads.googleads.v5.enums.types import user_list_type
from google.ads.googleads.v5.enums.types import vanity_pharma_display_url_mode
from google.ads.googleads.v5.enums.types import vanity_pharma_text
from google.ads.googleads.v5.enums.types import webpage_condition_operand
from google.ads.googleads.v5.enums.types import webpage_condition_operator
from google.ads.googleads.v5.errors.types import feed_item_validation_error
from google.ads.googleads.v5.resources.types import ad
from google.ads.googleads.v5.resources.types import ad_group
from google.ads.googleads.v5.resources.types import ad_group_ad
from google.ads.googleads.v5.resources.types import ad_group_ad_label
from google.ads.googleads.v5.resources.types import ad_group_bid_modifier
from google.ads.googleads.v5.resources.types import ad_group_criterion
from google.ads.googleads.v5.resources.types import ad_group_criterion_label
from google.ads.googleads.v5.resources.types import ad_group_extension_setting
from google.ads.googleads.v5.resources.types import ad_group_feed
from google.ads.googleads.v5.resources.types import ad_group_label
from google.ads.googleads.v5.resources.types import ad_parameter
from google.ads.googleads.v5.resources.types import asset
from google.ads.googleads.v5.resources.types import bidding_strategy
from google.ads.googleads.v5.resources.types import campaign
from google.ads.googleads.v5.resources.types import campaign_asset
from google.ads.googleads.v5.resources.types import campaign_bid_modifier
from google.ads.googleads.v5.resources.types import campaign_budget
from google.ads.googleads.v5.resources.types import campaign_criterion
from google.ads.googleads.v5.resources.types import campaign_draft
from google.ads.googleads.v5.resources.types import campaign_experiment
from google.ads.googleads.v5.resources.types import campaign_extension_setting
from google.ads.googleads.v5.resources.types import campaign_feed
from google.ads.googleads.v5.resources.types import campaign_label
from google.ads.googleads.v5.resources.types import campaign_shared_set
from google.ads.googleads.v5.resources.types import conversion_action
from google.ads.googleads.v5.resources.types import customer
from google.ads.googleads.v5.resources.types import customer_extension_setting
from google.ads.googleads.v5.resources.types import customer_feed
from google.ads.googleads.v5.resources.types import customer_label
from google.ads.googleads.v5.resources.types import customer_negative_criterion
from google.ads.googleads.v5.resources.types import extension_feed_item
from google.ads.googleads.v5.resources.types import feed
from google.ads.googleads.v5.resources.types import feed_item
from google.ads.googleads.v5.resources.types import feed_item_target
from google.ads.googleads.v5.resources.types import feed_mapping
from google.ads.googleads.v5.resources.types import keyword_plan
from google.ads.googleads.v5.resources.types import keyword_plan_ad_group
from google.ads.googleads.v5.resources.types import keyword_plan_ad_group_keyword
from google.ads.googleads.v5.resources.types import keyword_plan_campaign
from google.ads.googleads.v5.resources.types import keyword_plan_campaign_keyword
from google.ads.googleads.v5.resources.types import label
from google.ads.googleads.v5.resources.types import media_file
from google.ads.googleads.v5.resources.types import remarketing_action
from google.ads.googleads.v5.resources.types import shared_criterion
from google.ads.googleads.v5.resources.types import shared_set
from google.ads.googleads.v5.resources.types import user_list
from google.ads.googleads.v5.services.services.google_ads_service import GoogleAdsServiceClient
from google.ads.googleads.v5.services.services.google_ads_service import pagers
from google.ads.googleads.v5.services.services.google_ads_service import transports
from google.ads.googleads.v5.services.types import ad_group_ad_label_service
from google.ads.googleads.v5.services.types import ad_group_ad_service
from google.ads.googleads.v5.services.types import ad_group_bid_modifier_service
from google.ads.googleads.v5.services.types import ad_group_criterion_label_service
from google.ads.googleads.v5.services.types import ad_group_criterion_service
from google.ads.googleads.v5.services.types import ad_group_extension_setting_service
from google.ads.googleads.v5.services.types import ad_group_feed_service
from google.ads.googleads.v5.services.types import ad_group_label_service
from google.ads.googleads.v5.services.types import ad_group_service
from google.ads.googleads.v5.services.types import ad_parameter_service
from google.ads.googleads.v5.services.types import ad_service
from google.ads.googleads.v5.services.types import asset_service
from google.ads.googleads.v5.services.types import bidding_strategy_service
from google.ads.googleads.v5.services.types import campaign_asset_service
from google.ads.googleads.v5.services.types import campaign_bid_modifier_service
from google.ads.googleads.v5.services.types import campaign_budget_service
from google.ads.googleads.v5.services.types import campaign_criterion_service
from google.ads.googleads.v5.services.types import campaign_draft_service
from google.ads.googleads.v5.services.types import campaign_experiment_service
from google.ads.googleads.v5.services.types import campaign_extension_setting_service
from google.ads.googleads.v5.services.types import campaign_feed_service
from google.ads.googleads.v5.services.types import campaign_label_service
from google.ads.googleads.v5.services.types import campaign_service
from google.ads.googleads.v5.services.types import campaign_shared_set_service
from google.ads.googleads.v5.services.types import conversion_action_service
from google.ads.googleads.v5.services.types import customer_extension_setting_service
from google.ads.googleads.v5.services.types import customer_feed_service
from google.ads.googleads.v5.services.types import customer_label_service
from google.ads.googleads.v5.services.types import customer_negative_criterion_service
from google.ads.googleads.v5.services.types import customer_service
from google.ads.googleads.v5.services.types import extension_feed_item_service
from google.ads.googleads.v5.services.types import feed_item_service
from google.ads.googleads.v5.services.types import feed_item_target_service
from google.ads.googleads.v5.services.types import feed_mapping_service
from google.ads.googleads.v5.services.types import feed_service
from google.ads.googleads.v5.services.types import google_ads_service
from google.ads.googleads.v5.services.types import keyword_plan_ad_group_keyword_service
from google.ads.googleads.v5.services.types import keyword_plan_ad_group_service
from google.ads.googleads.v5.services.types import keyword_plan_campaign_keyword_service
from google.ads.googleads.v5.services.types import keyword_plan_campaign_service
from google.ads.googleads.v5.services.types import keyword_plan_service
from google.ads.googleads.v5.services.types import label_service
from google.ads.googleads.v5.services.types import media_file_service
from google.ads.googleads.v5.services.types import remarketing_action_service
from google.ads.googleads.v5.services.types import shared_criterion_service
from google.ads.googleads.v5.services.types import shared_set_service
from google.ads.googleads.v5.services.types import user_list_service
from google.api_core import client_options
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.auth import credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore
from google.rpc import status_pb2 as status  # type: ignore


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

    assert GoogleAdsServiceClient._get_default_mtls_endpoint(None) is None
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_google_ads_service_client_from_service_account_info():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = GoogleAdsServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_google_ads_service_client_from_service_account_file():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = GoogleAdsServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = GoogleAdsServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_google_ads_service_client_get_transport_class():
    transport = GoogleAdsServiceClient.get_transport_class()
    assert transport == transports.GoogleAdsServiceGrpcTransport

    transport = GoogleAdsServiceClient.get_transport_class("grpc")
    assert transport == transports.GoogleAdsServiceGrpcTransport


@mock.patch.object(GoogleAdsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(GoogleAdsServiceClient))
def test_google_ads_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.GoogleAdsServiceClient.get_transport_class') as gtc:
        transport = transports.GoogleAdsServiceGrpcTransport(
            credentials=credentials.AnonymousCredentials()
        )
        client = GoogleAdsServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.GoogleAdsServiceClient.get_transport_class') as gtc:
        client = GoogleAdsServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = GoogleAdsServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = GoogleAdsServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = GoogleAdsServiceClient()
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
            client = GoogleAdsServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = GoogleAdsServiceClient()


@mock.patch.object(GoogleAdsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(GoogleAdsServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_google_ads_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = GoogleAdsServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = GoogleAdsServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = GoogleAdsServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_google_ads_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = GoogleAdsServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_search(transport: str = 'grpc', request_type=google_ads_service.SearchGoogleAdsRequest):
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = google_ads_service.SearchGoogleAdsResponse(
            next_page_token='next_page_token_value',

            total_results_count=2077,

        )

        response = client.search(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == google_ads_service.SearchGoogleAdsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, pagers.SearchPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.total_results_count == 2077


def test_search_from_dict():
    test_search(request_type=dict)


def test_search_field_headers():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = google_ads_service.SearchGoogleAdsRequest()
    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        call.return_value = google_ads_service.SearchGoogleAdsResponse()

        client.search(request)

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


def test_search_flattened():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = google_ads_service.SearchGoogleAdsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.search(
            customer_id='customer_id_value',
            query='query_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].customer_id == 'customer_id_value'

        assert args[0].query == 'query_value'


def test_search_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.search(
            google_ads_service.SearchGoogleAdsRequest(),
            customer_id='customer_id_value',
            query='query_value',
        )


def test_search_pager():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                ],
                next_page_token='abc',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[],
                next_page_token='def',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                ],
                next_page_token='ghi',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('customer_id', ''),
            )),
        )
        pager = client.search(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, google_ads_service.GoogleAdsRow)
                   for i in results)

def test_search_pages():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                ],
                next_page_token='abc',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[],
                next_page_token='def',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                ],
                next_page_token='ghi',
            ),
            google_ads_service.SearchGoogleAdsResponse(
                results=[
                    google_ads_service.GoogleAdsRow(),
                    google_ads_service.GoogleAdsRow(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.search(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_search_stream(transport: str = 'grpc', request_type=google_ads_service.SearchGoogleAdsStreamRequest):
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([google_ads_service.SearchGoogleAdsStreamResponse()])

        response = client.search_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == google_ads_service.SearchGoogleAdsStreamRequest()

    # Establish that the response is the type that we expect.
    for message in response:
        assert isinstance(message, google_ads_service.SearchGoogleAdsStreamResponse)


def test_search_stream_from_dict():
    test_search_stream(request_type=dict)


def test_search_stream_field_headers():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = google_ads_service.SearchGoogleAdsStreamRequest()
    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_stream),
            '__call__') as call:
        call.return_value = iter([google_ads_service.SearchGoogleAdsStreamResponse()])

        client.search_stream(request)

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


def test_search_stream_flattened():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = iter([google_ads_service.SearchGoogleAdsStreamResponse()])

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.search_stream(
            customer_id='customer_id_value',
            query='query_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].customer_id == 'customer_id_value'

        assert args[0].query == 'query_value'


def test_search_stream_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.search_stream(
            google_ads_service.SearchGoogleAdsStreamRequest(),
            customer_id='customer_id_value',
            query='query_value',
        )


def test_mutate(transport: str = 'grpc', request_type=google_ads_service.MutateGoogleAdsRequest):
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = google_ads_service.MutateGoogleAdsResponse(
        )

        response = client.mutate(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == google_ads_service.MutateGoogleAdsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, google_ads_service.MutateGoogleAdsResponse)


def test_mutate_from_dict():
    test_mutate(request_type=dict)


def test_mutate_field_headers():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = google_ads_service.MutateGoogleAdsRequest()
    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate),
            '__call__') as call:
        call.return_value = google_ads_service.MutateGoogleAdsResponse()

        client.mutate(request)

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


def test_mutate_flattened():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = google_ads_service.MutateGoogleAdsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate(
            customer_id='customer_id_value',
            mutate_operations=[google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].customer_id == 'customer_id_value'

        assert args[0].mutate_operations == [google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))]


def test_mutate_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate(
            google_ads_service.MutateGoogleAdsRequest(),
            customer_id='customer_id_value',
            mutate_operations=[google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = GoogleAdsServiceClient(
            credentials=credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    client = GoogleAdsServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.GoogleAdsServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.GoogleAdsServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_google_ads_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.GoogleAdsServiceTransport(
            credentials=credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'search',
        'search_stream',
        'mutate',
        )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


def test_google_ads_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(auth, 'default') as adc, mock.patch('google.ads.googleads.v5.services.services.google_ads_service.transports.GoogleAdsServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.GoogleAdsServiceTransport()
        adc.assert_called_once()


def test_google_ads_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        GoogleAdsServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_google_ads_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transports.GoogleAdsServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_google_ads_service_host_no_port():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_google_ads_service_host_with_port():
    client = GoogleAdsServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_google_ads_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.GoogleAdsServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.GoogleAdsServiceGrpcTransport])
def test_google_ads_service_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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


@pytest.mark.parametrize("transport_class", [transports.GoogleAdsServiceGrpcTransport,])
def test_google_ads_service_transport_channel_mtls_with_adc(
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


def test_account_budget_path():
    customer = "squid"
    account_budget = "clam"

    expected = "customers/{customer}/accountBudgets/{account_budget}".format(customer=customer, account_budget=account_budget, )
    actual = GoogleAdsServiceClient.account_budget_path(customer, account_budget)
    assert expected == actual


def test_parse_account_budget_path():
    expected = {
    "customer": "whelk",
    "account_budget": "octopus",

    }
    path = GoogleAdsServiceClient.account_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_budget_path(path)
    assert expected == actual

def test_account_budget_proposal_path():
    customer = "oyster"
    account_budget_proposal = "nudibranch"

    expected = "customers/{customer}/accountBudgetProposals/{account_budget_proposal}".format(customer=customer, account_budget_proposal=account_budget_proposal, )
    actual = GoogleAdsServiceClient.account_budget_proposal_path(customer, account_budget_proposal)
    assert expected == actual


def test_parse_account_budget_proposal_path():
    expected = {
    "customer": "cuttlefish",
    "account_budget_proposal": "mussel",

    }
    path = GoogleAdsServiceClient.account_budget_proposal_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_budget_proposal_path(path)
    assert expected == actual

def test_account_link_path():
    customer = "winkle"
    account_link = "nautilus"

    expected = "customers/{customer}/accountLinks/{account_link}".format(customer=customer, account_link=account_link, )
    actual = GoogleAdsServiceClient.account_link_path(customer, account_link)
    assert expected == actual


def test_parse_account_link_path():
    expected = {
    "customer": "scallop",
    "account_link": "abalone",

    }
    path = GoogleAdsServiceClient.account_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_link_path(path)
    assert expected == actual

def test_ad_path():
    customer = "squid"
    ad = "clam"

    expected = "customers/{customer}/ads/{ad}".format(customer=customer, ad=ad, )
    actual = GoogleAdsServiceClient.ad_path(customer, ad)
    assert expected == actual


def test_parse_ad_path():
    expected = {
    "customer": "whelk",
    "ad": "octopus",

    }
    path = GoogleAdsServiceClient.ad_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_path(path)
    assert expected == actual

def test_ad_group_path():
    customer = "oyster"
    ad_group = "nudibranch"

    expected = "customers/{customer}/adGroups/{ad_group}".format(customer=customer, ad_group=ad_group, )
    actual = GoogleAdsServiceClient.ad_group_path(customer, ad_group)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group": "mussel",

    }
    path = GoogleAdsServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_ad_path():
    customer = "winkle"
    ad_group_ad = "nautilus"

    expected = "customers/{customer}/adGroupAds/{ad_group_ad}".format(customer=customer, ad_group_ad=ad_group_ad, )
    actual = GoogleAdsServiceClient.ad_group_ad_path(customer, ad_group_ad)
    assert expected == actual


def test_parse_ad_group_ad_path():
    expected = {
    "customer": "scallop",
    "ad_group_ad": "abalone",

    }
    path = GoogleAdsServiceClient.ad_group_ad_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_path(path)
    assert expected == actual

def test_ad_group_ad_asset_view_path():
    customer = "squid"
    ad_group_ad_asset_view = "clam"

    expected = "customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}".format(customer=customer, ad_group_ad_asset_view=ad_group_ad_asset_view, )
    actual = GoogleAdsServiceClient.ad_group_ad_asset_view_path(customer, ad_group_ad_asset_view)
    assert expected == actual


def test_parse_ad_group_ad_asset_view_path():
    expected = {
    "customer": "whelk",
    "ad_group_ad_asset_view": "octopus",

    }
    path = GoogleAdsServiceClient.ad_group_ad_asset_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_asset_view_path(path)
    assert expected == actual

def test_ad_group_ad_label_path():
    customer = "oyster"
    ad_group_ad_label = "nudibranch"

    expected = "customers/{customer}/adGroupAdLabels/{ad_group_ad_label}".format(customer=customer, ad_group_ad_label=ad_group_ad_label, )
    actual = GoogleAdsServiceClient.ad_group_ad_label_path(customer, ad_group_ad_label)
    assert expected == actual


def test_parse_ad_group_ad_label_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_ad_label": "mussel",

    }
    path = GoogleAdsServiceClient.ad_group_ad_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_label_path(path)
    assert expected == actual

def test_ad_group_audience_view_path():
    customer = "winkle"
    ad_group_audience_view = "nautilus"

    expected = "customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}".format(customer=customer, ad_group_audience_view=ad_group_audience_view, )
    actual = GoogleAdsServiceClient.ad_group_audience_view_path(customer, ad_group_audience_view)
    assert expected == actual


def test_parse_ad_group_audience_view_path():
    expected = {
    "customer": "scallop",
    "ad_group_audience_view": "abalone",

    }
    path = GoogleAdsServiceClient.ad_group_audience_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_audience_view_path(path)
    assert expected == actual

def test_ad_group_bid_modifier_path():
    customer = "squid"
    ad_group_bid_modifier = "clam"

    expected = "customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}".format(customer=customer, ad_group_bid_modifier=ad_group_bid_modifier, )
    actual = GoogleAdsServiceClient.ad_group_bid_modifier_path(customer, ad_group_bid_modifier)
    assert expected == actual


def test_parse_ad_group_bid_modifier_path():
    expected = {
    "customer": "whelk",
    "ad_group_bid_modifier": "octopus",

    }
    path = GoogleAdsServiceClient.ad_group_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_bid_modifier_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer = "oyster"
    ad_group_criterion = "nudibranch"

    expected = "customers/{customer}/adGroupCriteria/{ad_group_criterion}".format(customer=customer, ad_group_criterion=ad_group_criterion, )
    actual = GoogleAdsServiceClient.ad_group_criterion_path(customer, ad_group_criterion)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_criterion": "mussel",

    }
    path = GoogleAdsServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_criterion_label_path():
    customer = "winkle"
    ad_group_criterion_label = "nautilus"

    expected = "customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}".format(customer=customer, ad_group_criterion_label=ad_group_criterion_label, )
    actual = GoogleAdsServiceClient.ad_group_criterion_label_path(customer, ad_group_criterion_label)
    assert expected == actual


def test_parse_ad_group_criterion_label_path():
    expected = {
    "customer": "scallop",
    "ad_group_criterion_label": "abalone",

    }
    path = GoogleAdsServiceClient.ad_group_criterion_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_label_path(path)
    assert expected == actual

def test_ad_group_criterion_simulation_path():
    customer = "squid"
    ad_group_criterion_simulation = "clam"

    expected = "customers/{customer}/adGroupCriterionSimulations/{ad_group_criterion_simulation}".format(customer=customer, ad_group_criterion_simulation=ad_group_criterion_simulation, )
    actual = GoogleAdsServiceClient.ad_group_criterion_simulation_path(customer, ad_group_criterion_simulation)
    assert expected == actual


def test_parse_ad_group_criterion_simulation_path():
    expected = {
    "customer": "whelk",
    "ad_group_criterion_simulation": "octopus",

    }
    path = GoogleAdsServiceClient.ad_group_criterion_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_simulation_path(path)
    assert expected == actual

def test_ad_group_extension_setting_path():
    customer = "oyster"
    ad_group_extension_setting = "nudibranch"

    expected = "customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}".format(customer=customer, ad_group_extension_setting=ad_group_extension_setting, )
    actual = GoogleAdsServiceClient.ad_group_extension_setting_path(customer, ad_group_extension_setting)
    assert expected == actual


def test_parse_ad_group_extension_setting_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_extension_setting": "mussel",

    }
    path = GoogleAdsServiceClient.ad_group_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_extension_setting_path(path)
    assert expected == actual

def test_ad_group_feed_path():
    customer = "winkle"
    ad_group_feed = "nautilus"

    expected = "customers/{customer}/adGroupFeeds/{ad_group_feed}".format(customer=customer, ad_group_feed=ad_group_feed, )
    actual = GoogleAdsServiceClient.ad_group_feed_path(customer, ad_group_feed)
    assert expected == actual


def test_parse_ad_group_feed_path():
    expected = {
    "customer": "scallop",
    "ad_group_feed": "abalone",

    }
    path = GoogleAdsServiceClient.ad_group_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_feed_path(path)
    assert expected == actual

def test_ad_group_label_path():
    customer = "squid"
    ad_group_label = "clam"

    expected = "customers/{customer}/adGroupLabels/{ad_group_label}".format(customer=customer, ad_group_label=ad_group_label, )
    actual = GoogleAdsServiceClient.ad_group_label_path(customer, ad_group_label)
    assert expected == actual


def test_parse_ad_group_label_path():
    expected = {
    "customer": "whelk",
    "ad_group_label": "octopus",

    }
    path = GoogleAdsServiceClient.ad_group_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_label_path(path)
    assert expected == actual

def test_ad_group_simulation_path():
    customer = "oyster"
    ad_group_simulation = "nudibranch"

    expected = "customers/{customer}/adGroupSimulations/{ad_group_simulation}".format(customer=customer, ad_group_simulation=ad_group_simulation, )
    actual = GoogleAdsServiceClient.ad_group_simulation_path(customer, ad_group_simulation)
    assert expected == actual


def test_parse_ad_group_simulation_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_simulation": "mussel",

    }
    path = GoogleAdsServiceClient.ad_group_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_simulation_path(path)
    assert expected == actual

def test_ad_parameter_path():
    customer = "winkle"
    ad_parameter = "nautilus"

    expected = "customers/{customer}/adParameters/{ad_parameter}".format(customer=customer, ad_parameter=ad_parameter, )
    actual = GoogleAdsServiceClient.ad_parameter_path(customer, ad_parameter)
    assert expected == actual


def test_parse_ad_parameter_path():
    expected = {
    "customer": "scallop",
    "ad_parameter": "abalone",

    }
    path = GoogleAdsServiceClient.ad_parameter_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_parameter_path(path)
    assert expected == actual

def test_ad_schedule_view_path():
    customer = "squid"
    ad_schedule_view = "clam"

    expected = "customers/{customer}/adScheduleViews/{ad_schedule_view}".format(customer=customer, ad_schedule_view=ad_schedule_view, )
    actual = GoogleAdsServiceClient.ad_schedule_view_path(customer, ad_schedule_view)
    assert expected == actual


def test_parse_ad_schedule_view_path():
    expected = {
    "customer": "whelk",
    "ad_schedule_view": "octopus",

    }
    path = GoogleAdsServiceClient.ad_schedule_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_schedule_view_path(path)
    assert expected == actual

def test_age_range_view_path():
    customer = "oyster"
    age_range_view = "nudibranch"

    expected = "customers/{customer}/ageRangeViews/{age_range_view}".format(customer=customer, age_range_view=age_range_view, )
    actual = GoogleAdsServiceClient.age_range_view_path(customer, age_range_view)
    assert expected == actual


def test_parse_age_range_view_path():
    expected = {
    "customer": "cuttlefish",
    "age_range_view": "mussel",

    }
    path = GoogleAdsServiceClient.age_range_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_age_range_view_path(path)
    assert expected == actual

def test_asset_path():
    customer = "winkle"
    asset = "nautilus"

    expected = "customers/{customer}/assets/{asset}".format(customer=customer, asset=asset, )
    actual = GoogleAdsServiceClient.asset_path(customer, asset)
    assert expected == actual


def test_parse_asset_path():
    expected = {
    "customer": "scallop",
    "asset": "abalone",

    }
    path = GoogleAdsServiceClient.asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_path(path)
    assert expected == actual

def test_batch_job_path():
    customer = "squid"
    batch_job = "clam"

    expected = "customers/{customer}/batchJobs/{batch_job}".format(customer=customer, batch_job=batch_job, )
    actual = GoogleAdsServiceClient.batch_job_path(customer, batch_job)
    assert expected == actual


def test_parse_batch_job_path():
    expected = {
    "customer": "whelk",
    "batch_job": "octopus",

    }
    path = GoogleAdsServiceClient.batch_job_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_batch_job_path(path)
    assert expected == actual

def test_bidding_strategy_path():
    customer = "oyster"
    bidding_strategy = "nudibranch"

    expected = "customers/{customer}/biddingStrategies/{bidding_strategy}".format(customer=customer, bidding_strategy=bidding_strategy, )
    actual = GoogleAdsServiceClient.bidding_strategy_path(customer, bidding_strategy)
    assert expected == actual


def test_parse_bidding_strategy_path():
    expected = {
    "customer": "cuttlefish",
    "bidding_strategy": "mussel",

    }
    path = GoogleAdsServiceClient.bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_bidding_strategy_path(path)
    assert expected == actual

def test_billing_setup_path():
    customer = "winkle"
    billing_setup = "nautilus"

    expected = "customers/{customer}/billingSetups/{billing_setup}".format(customer=customer, billing_setup=billing_setup, )
    actual = GoogleAdsServiceClient.billing_setup_path(customer, billing_setup)
    assert expected == actual


def test_parse_billing_setup_path():
    expected = {
    "customer": "scallop",
    "billing_setup": "abalone",

    }
    path = GoogleAdsServiceClient.billing_setup_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_billing_setup_path(path)
    assert expected == actual

def test_campaign_path():
    customer = "squid"
    campaign = "clam"

    expected = "customers/{customer}/campaigns/{campaign}".format(customer=customer, campaign=campaign, )
    actual = GoogleAdsServiceClient.campaign_path(customer, campaign)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
    "customer": "whelk",
    "campaign": "octopus",

    }
    path = GoogleAdsServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_asset_path():
    customer = "oyster"
    campaign_asset = "nudibranch"

    expected = "customers/{customer}/campaignAssets/{campaign_asset}".format(customer=customer, campaign_asset=campaign_asset, )
    actual = GoogleAdsServiceClient.campaign_asset_path(customer, campaign_asset)
    assert expected == actual


def test_parse_campaign_asset_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_asset": "mussel",

    }
    path = GoogleAdsServiceClient.campaign_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_asset_path(path)
    assert expected == actual

def test_campaign_audience_view_path():
    customer = "winkle"
    campaign_audience_view = "nautilus"

    expected = "customers/{customer}/campaignAudienceViews/{campaign_audience_view}".format(customer=customer, campaign_audience_view=campaign_audience_view, )
    actual = GoogleAdsServiceClient.campaign_audience_view_path(customer, campaign_audience_view)
    assert expected == actual


def test_parse_campaign_audience_view_path():
    expected = {
    "customer": "scallop",
    "campaign_audience_view": "abalone",

    }
    path = GoogleAdsServiceClient.campaign_audience_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_audience_view_path(path)
    assert expected == actual

def test_campaign_bid_modifier_path():
    customer = "squid"
    campaign_bid_modifier = "clam"

    expected = "customers/{customer}/campaignBidModifiers/{campaign_bid_modifier}".format(customer=customer, campaign_bid_modifier=campaign_bid_modifier, )
    actual = GoogleAdsServiceClient.campaign_bid_modifier_path(customer, campaign_bid_modifier)
    assert expected == actual


def test_parse_campaign_bid_modifier_path():
    expected = {
    "customer": "whelk",
    "campaign_bid_modifier": "octopus",

    }
    path = GoogleAdsServiceClient.campaign_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_bid_modifier_path(path)
    assert expected == actual

def test_campaign_budget_path():
    customer = "oyster"
    campaign_budget = "nudibranch"

    expected = "customers/{customer}/campaignBudgets/{campaign_budget}".format(customer=customer, campaign_budget=campaign_budget, )
    actual = GoogleAdsServiceClient.campaign_budget_path(customer, campaign_budget)
    assert expected == actual


def test_parse_campaign_budget_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_budget": "mussel",

    }
    path = GoogleAdsServiceClient.campaign_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_budget_path(path)
    assert expected == actual

def test_campaign_criterion_path():
    customer = "winkle"
    campaign_criterion = "nautilus"

    expected = "customers/{customer}/campaignCriteria/{campaign_criterion}".format(customer=customer, campaign_criterion=campaign_criterion, )
    actual = GoogleAdsServiceClient.campaign_criterion_path(customer, campaign_criterion)
    assert expected == actual


def test_parse_campaign_criterion_path():
    expected = {
    "customer": "scallop",
    "campaign_criterion": "abalone",

    }
    path = GoogleAdsServiceClient.campaign_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_criterion_path(path)
    assert expected == actual

def test_campaign_criterion_simulation_path():
    customer = "squid"
    campaign_criterion_simulation = "clam"

    expected = "customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}".format(customer=customer, campaign_criterion_simulation=campaign_criterion_simulation, )
    actual = GoogleAdsServiceClient.campaign_criterion_simulation_path(customer, campaign_criterion_simulation)
    assert expected == actual


def test_parse_campaign_criterion_simulation_path():
    expected = {
    "customer": "whelk",
    "campaign_criterion_simulation": "octopus",

    }
    path = GoogleAdsServiceClient.campaign_criterion_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_criterion_simulation_path(path)
    assert expected == actual

def test_campaign_draft_path():
    customer = "oyster"
    campaign_draft = "nudibranch"

    expected = "customers/{customer}/campaignDrafts/{campaign_draft}".format(customer=customer, campaign_draft=campaign_draft, )
    actual = GoogleAdsServiceClient.campaign_draft_path(customer, campaign_draft)
    assert expected == actual


def test_parse_campaign_draft_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_draft": "mussel",

    }
    path = GoogleAdsServiceClient.campaign_draft_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_draft_path(path)
    assert expected == actual

def test_campaign_experiment_path():
    customer = "winkle"
    campaign_experiment = "nautilus"

    expected = "customers/{customer}/campaignExperiments/{campaign_experiment}".format(customer=customer, campaign_experiment=campaign_experiment, )
    actual = GoogleAdsServiceClient.campaign_experiment_path(customer, campaign_experiment)
    assert expected == actual


def test_parse_campaign_experiment_path():
    expected = {
    "customer": "scallop",
    "campaign_experiment": "abalone",

    }
    path = GoogleAdsServiceClient.campaign_experiment_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_experiment_path(path)
    assert expected == actual

def test_campaign_extension_setting_path():
    customer = "squid"
    campaign_extension_setting = "clam"

    expected = "customers/{customer}/campaignExtensionSettings/{campaign_extension_setting}".format(customer=customer, campaign_extension_setting=campaign_extension_setting, )
    actual = GoogleAdsServiceClient.campaign_extension_setting_path(customer, campaign_extension_setting)
    assert expected == actual


def test_parse_campaign_extension_setting_path():
    expected = {
    "customer": "whelk",
    "campaign_extension_setting": "octopus",

    }
    path = GoogleAdsServiceClient.campaign_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_extension_setting_path(path)
    assert expected == actual

def test_campaign_feed_path():
    customer = "oyster"
    campaign_feed = "nudibranch"

    expected = "customers/{customer}/campaignFeeds/{campaign_feed}".format(customer=customer, campaign_feed=campaign_feed, )
    actual = GoogleAdsServiceClient.campaign_feed_path(customer, campaign_feed)
    assert expected == actual


def test_parse_campaign_feed_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_feed": "mussel",

    }
    path = GoogleAdsServiceClient.campaign_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_feed_path(path)
    assert expected == actual

def test_campaign_label_path():
    customer = "winkle"
    campaign_label = "nautilus"

    expected = "customers/{customer}/campaignLabels/{campaign_label}".format(customer=customer, campaign_label=campaign_label, )
    actual = GoogleAdsServiceClient.campaign_label_path(customer, campaign_label)
    assert expected == actual


def test_parse_campaign_label_path():
    expected = {
    "customer": "scallop",
    "campaign_label": "abalone",

    }
    path = GoogleAdsServiceClient.campaign_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_label_path(path)
    assert expected == actual

def test_campaign_shared_set_path():
    customer = "squid"
    campaign_shared_set = "clam"

    expected = "customers/{customer}/campaignSharedSets/{campaign_shared_set}".format(customer=customer, campaign_shared_set=campaign_shared_set, )
    actual = GoogleAdsServiceClient.campaign_shared_set_path(customer, campaign_shared_set)
    assert expected == actual


def test_parse_campaign_shared_set_path():
    expected = {
    "customer": "whelk",
    "campaign_shared_set": "octopus",

    }
    path = GoogleAdsServiceClient.campaign_shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_shared_set_path(path)
    assert expected == actual

def test_carrier_constant_path():
    carrier_constant = "oyster"

    expected = "carrierConstants/{carrier_constant}".format(carrier_constant=carrier_constant, )
    actual = GoogleAdsServiceClient.carrier_constant_path(carrier_constant)
    assert expected == actual


def test_parse_carrier_constant_path():
    expected = {
    "carrier_constant": "nudibranch",

    }
    path = GoogleAdsServiceClient.carrier_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_carrier_constant_path(path)
    assert expected == actual

def test_change_status_path():
    customer = "cuttlefish"
    change_status = "mussel"

    expected = "customers/{customer}/changeStatus/{change_status}".format(customer=customer, change_status=change_status, )
    actual = GoogleAdsServiceClient.change_status_path(customer, change_status)
    assert expected == actual


def test_parse_change_status_path():
    expected = {
    "customer": "winkle",
    "change_status": "nautilus",

    }
    path = GoogleAdsServiceClient.change_status_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_change_status_path(path)
    assert expected == actual

def test_click_view_path():
    customer = "scallop"
    click_view = "abalone"

    expected = "customers/{customer}/clickViews/{click_view}".format(customer=customer, click_view=click_view, )
    actual = GoogleAdsServiceClient.click_view_path(customer, click_view)
    assert expected == actual


def test_parse_click_view_path():
    expected = {
    "customer": "squid",
    "click_view": "clam",

    }
    path = GoogleAdsServiceClient.click_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_click_view_path(path)
    assert expected == actual

def test_conversion_action_path():
    customer = "whelk"
    conversion_action = "octopus"

    expected = "customers/{customer}/conversionActions/{conversion_action}".format(customer=customer, conversion_action=conversion_action, )
    actual = GoogleAdsServiceClient.conversion_action_path(customer, conversion_action)
    assert expected == actual


def test_parse_conversion_action_path():
    expected = {
    "customer": "oyster",
    "conversion_action": "nudibranch",

    }
    path = GoogleAdsServiceClient.conversion_action_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_action_path(path)
    assert expected == actual

def test_currency_constant_path():
    currency_constant = "cuttlefish"

    expected = "currencyConstants/{currency_constant}".format(currency_constant=currency_constant, )
    actual = GoogleAdsServiceClient.currency_constant_path(currency_constant)
    assert expected == actual


def test_parse_currency_constant_path():
    expected = {
    "currency_constant": "mussel",

    }
    path = GoogleAdsServiceClient.currency_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_currency_constant_path(path)
    assert expected == actual

def test_customer_path():
    customer = "winkle"

    expected = "customers/{customer}".format(customer=customer, )
    actual = GoogleAdsServiceClient.customer_path(customer)
    assert expected == actual


def test_parse_customer_path():
    expected = {
    "customer": "nautilus",

    }
    path = GoogleAdsServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_path(path)
    assert expected == actual

def test_customer_client_path():
    customer = "scallop"
    customer_client = "abalone"

    expected = "customers/{customer}/customerClients/{customer_client}".format(customer=customer, customer_client=customer_client, )
    actual = GoogleAdsServiceClient.customer_client_path(customer, customer_client)
    assert expected == actual


def test_parse_customer_client_path():
    expected = {
    "customer": "squid",
    "customer_client": "clam",

    }
    path = GoogleAdsServiceClient.customer_client_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_client_path(path)
    assert expected == actual

def test_customer_client_link_path():
    customer = "whelk"
    customer_client_link = "octopus"

    expected = "customers/{customer}/customerClientLinks/{customer_client_link}".format(customer=customer, customer_client_link=customer_client_link, )
    actual = GoogleAdsServiceClient.customer_client_link_path(customer, customer_client_link)
    assert expected == actual


def test_parse_customer_client_link_path():
    expected = {
    "customer": "oyster",
    "customer_client_link": "nudibranch",

    }
    path = GoogleAdsServiceClient.customer_client_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_client_link_path(path)
    assert expected == actual

def test_customer_extension_setting_path():
    customer = "cuttlefish"
    customer_extension_setting = "mussel"

    expected = "customers/{customer}/customerExtensionSettings/{customer_extension_setting}".format(customer=customer, customer_extension_setting=customer_extension_setting, )
    actual = GoogleAdsServiceClient.customer_extension_setting_path(customer, customer_extension_setting)
    assert expected == actual


def test_parse_customer_extension_setting_path():
    expected = {
    "customer": "winkle",
    "customer_extension_setting": "nautilus",

    }
    path = GoogleAdsServiceClient.customer_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_extension_setting_path(path)
    assert expected == actual

def test_customer_feed_path():
    customer = "scallop"
    customer_feed = "abalone"

    expected = "customers/{customer}/customerFeeds/{customer_feed}".format(customer=customer, customer_feed=customer_feed, )
    actual = GoogleAdsServiceClient.customer_feed_path(customer, customer_feed)
    assert expected == actual


def test_parse_customer_feed_path():
    expected = {
    "customer": "squid",
    "customer_feed": "clam",

    }
    path = GoogleAdsServiceClient.customer_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_feed_path(path)
    assert expected == actual

def test_customer_label_path():
    customer = "whelk"
    customer_label = "octopus"

    expected = "customers/{customer}/customerLabels/{customer_label}".format(customer=customer, customer_label=customer_label, )
    actual = GoogleAdsServiceClient.customer_label_path(customer, customer_label)
    assert expected == actual


def test_parse_customer_label_path():
    expected = {
    "customer": "oyster",
    "customer_label": "nudibranch",

    }
    path = GoogleAdsServiceClient.customer_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_label_path(path)
    assert expected == actual

def test_customer_manager_link_path():
    customer = "cuttlefish"
    customer_manager_link = "mussel"

    expected = "customers/{customer}/customerManagerLinks/{customer_manager_link}".format(customer=customer, customer_manager_link=customer_manager_link, )
    actual = GoogleAdsServiceClient.customer_manager_link_path(customer, customer_manager_link)
    assert expected == actual


def test_parse_customer_manager_link_path():
    expected = {
    "customer": "winkle",
    "customer_manager_link": "nautilus",

    }
    path = GoogleAdsServiceClient.customer_manager_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_manager_link_path(path)
    assert expected == actual

def test_customer_negative_criterion_path():
    customer = "scallop"
    customer_negative_criterion = "abalone"

    expected = "customers/{customer}/customerNegativeCriteria/{customer_negative_criterion}".format(customer=customer, customer_negative_criterion=customer_negative_criterion, )
    actual = GoogleAdsServiceClient.customer_negative_criterion_path(customer, customer_negative_criterion)
    assert expected == actual


def test_parse_customer_negative_criterion_path():
    expected = {
    "customer": "squid",
    "customer_negative_criterion": "clam",

    }
    path = GoogleAdsServiceClient.customer_negative_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_negative_criterion_path(path)
    assert expected == actual

def test_custom_interest_path():
    customer = "whelk"
    custom_interest = "octopus"

    expected = "customers/{customer}/customInterests/{custom_interest}".format(customer=customer, custom_interest=custom_interest, )
    actual = GoogleAdsServiceClient.custom_interest_path(customer, custom_interest)
    assert expected == actual


def test_parse_custom_interest_path():
    expected = {
    "customer": "oyster",
    "custom_interest": "nudibranch",

    }
    path = GoogleAdsServiceClient.custom_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_custom_interest_path(path)
    assert expected == actual

def test_detail_placement_view_path():
    customer = "cuttlefish"
    detail_placement_view = "mussel"

    expected = "customers/{customer}/detailPlacementViews/{detail_placement_view}".format(customer=customer, detail_placement_view=detail_placement_view, )
    actual = GoogleAdsServiceClient.detail_placement_view_path(customer, detail_placement_view)
    assert expected == actual


def test_parse_detail_placement_view_path():
    expected = {
    "customer": "winkle",
    "detail_placement_view": "nautilus",

    }
    path = GoogleAdsServiceClient.detail_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_detail_placement_view_path(path)
    assert expected == actual

def test_display_keyword_view_path():
    customer = "scallop"
    display_keyword_view = "abalone"

    expected = "customers/{customer}/displayKeywordViews/{display_keyword_view}".format(customer=customer, display_keyword_view=display_keyword_view, )
    actual = GoogleAdsServiceClient.display_keyword_view_path(customer, display_keyword_view)
    assert expected == actual


def test_parse_display_keyword_view_path():
    expected = {
    "customer": "squid",
    "display_keyword_view": "clam",

    }
    path = GoogleAdsServiceClient.display_keyword_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_display_keyword_view_path(path)
    assert expected == actual

def test_distance_view_path():
    customer = "whelk"
    distance_view = "octopus"

    expected = "customers/{customer}/distanceViews/{distance_view}".format(customer=customer, distance_view=distance_view, )
    actual = GoogleAdsServiceClient.distance_view_path(customer, distance_view)
    assert expected == actual


def test_parse_distance_view_path():
    expected = {
    "customer": "oyster",
    "distance_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.distance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_distance_view_path(path)
    assert expected == actual

def test_domain_category_path():
    customer = "cuttlefish"
    domain_category = "mussel"

    expected = "customers/{customer}/domainCategories/{domain_category}".format(customer=customer, domain_category=domain_category, )
    actual = GoogleAdsServiceClient.domain_category_path(customer, domain_category)
    assert expected == actual


def test_parse_domain_category_path():
    expected = {
    "customer": "winkle",
    "domain_category": "nautilus",

    }
    path = GoogleAdsServiceClient.domain_category_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_domain_category_path(path)
    assert expected == actual

def test_dynamic_search_ads_search_term_view_path():
    customer = "scallop"
    dynamic_search_ads_search_term_view = "abalone"

    expected = "customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}".format(customer=customer, dynamic_search_ads_search_term_view=dynamic_search_ads_search_term_view, )
    actual = GoogleAdsServiceClient.dynamic_search_ads_search_term_view_path(customer, dynamic_search_ads_search_term_view)
    assert expected == actual


def test_parse_dynamic_search_ads_search_term_view_path():
    expected = {
    "customer": "squid",
    "dynamic_search_ads_search_term_view": "clam",

    }
    path = GoogleAdsServiceClient.dynamic_search_ads_search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_dynamic_search_ads_search_term_view_path(path)
    assert expected == actual

def test_expanded_landing_page_view_path():
    customer = "whelk"
    expanded_landing_page_view = "octopus"

    expected = "customers/{customer}/expandedLandingPageViews/{expanded_landing_page_view}".format(customer=customer, expanded_landing_page_view=expanded_landing_page_view, )
    actual = GoogleAdsServiceClient.expanded_landing_page_view_path(customer, expanded_landing_page_view)
    assert expected == actual


def test_parse_expanded_landing_page_view_path():
    expected = {
    "customer": "oyster",
    "expanded_landing_page_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.expanded_landing_page_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_expanded_landing_page_view_path(path)
    assert expected == actual

def test_extension_feed_item_path():
    customer = "cuttlefish"
    extension_feed_item = "mussel"

    expected = "customers/{customer}/extensionFeedItems/{extension_feed_item}".format(customer=customer, extension_feed_item=extension_feed_item, )
    actual = GoogleAdsServiceClient.extension_feed_item_path(customer, extension_feed_item)
    assert expected == actual


def test_parse_extension_feed_item_path():
    expected = {
    "customer": "winkle",
    "extension_feed_item": "nautilus",

    }
    path = GoogleAdsServiceClient.extension_feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_extension_feed_item_path(path)
    assert expected == actual

def test_feed_path():
    customer = "scallop"
    feed = "abalone"

    expected = "customers/{customer}/feeds/{feed}".format(customer=customer, feed=feed, )
    actual = GoogleAdsServiceClient.feed_path(customer, feed)
    assert expected == actual


def test_parse_feed_path():
    expected = {
    "customer": "squid",
    "feed": "clam",

    }
    path = GoogleAdsServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_path(path)
    assert expected == actual

def test_feed_item_path():
    customer = "whelk"
    feed_item = "octopus"

    expected = "customers/{customer}/feedItems/{feed_item}".format(customer=customer, feed_item=feed_item, )
    actual = GoogleAdsServiceClient.feed_item_path(customer, feed_item)
    assert expected == actual


def test_parse_feed_item_path():
    expected = {
    "customer": "oyster",
    "feed_item": "nudibranch",

    }
    path = GoogleAdsServiceClient.feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_path(path)
    assert expected == actual

def test_feed_item_target_path():
    customer = "cuttlefish"
    feed_item_target = "mussel"

    expected = "customers/{customer}/feedItemTargets/{feed_item_target}".format(customer=customer, feed_item_target=feed_item_target, )
    actual = GoogleAdsServiceClient.feed_item_target_path(customer, feed_item_target)
    assert expected == actual


def test_parse_feed_item_target_path():
    expected = {
    "customer": "winkle",
    "feed_item_target": "nautilus",

    }
    path = GoogleAdsServiceClient.feed_item_target_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_target_path(path)
    assert expected == actual

def test_feed_mapping_path():
    customer = "scallop"
    feed_mapping = "abalone"

    expected = "customers/{customer}/feedMappings/{feed_mapping}".format(customer=customer, feed_mapping=feed_mapping, )
    actual = GoogleAdsServiceClient.feed_mapping_path(customer, feed_mapping)
    assert expected == actual


def test_parse_feed_mapping_path():
    expected = {
    "customer": "squid",
    "feed_mapping": "clam",

    }
    path = GoogleAdsServiceClient.feed_mapping_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_mapping_path(path)
    assert expected == actual

def test_feed_placeholder_view_path():
    customer = "whelk"
    feed_placeholder_view = "octopus"

    expected = "customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}".format(customer=customer, feed_placeholder_view=feed_placeholder_view, )
    actual = GoogleAdsServiceClient.feed_placeholder_view_path(customer, feed_placeholder_view)
    assert expected == actual


def test_parse_feed_placeholder_view_path():
    expected = {
    "customer": "oyster",
    "feed_placeholder_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.feed_placeholder_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_placeholder_view_path(path)
    assert expected == actual

def test_gender_view_path():
    customer = "cuttlefish"
    gender_view = "mussel"

    expected = "customers/{customer}/genderViews/{gender_view}".format(customer=customer, gender_view=gender_view, )
    actual = GoogleAdsServiceClient.gender_view_path(customer, gender_view)
    assert expected == actual


def test_parse_gender_view_path():
    expected = {
    "customer": "winkle",
    "gender_view": "nautilus",

    }
    path = GoogleAdsServiceClient.gender_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_gender_view_path(path)
    assert expected == actual

def test_geographic_view_path():
    customer = "scallop"
    geographic_view = "abalone"

    expected = "customers/{customer}/geographicViews/{geographic_view}".format(customer=customer, geographic_view=geographic_view, )
    actual = GoogleAdsServiceClient.geographic_view_path(customer, geographic_view)
    assert expected == actual


def test_parse_geographic_view_path():
    expected = {
    "customer": "squid",
    "geographic_view": "clam",

    }
    path = GoogleAdsServiceClient.geographic_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_geographic_view_path(path)
    assert expected == actual

def test_geo_target_constant_path():
    geo_target_constant = "whelk"

    expected = "geoTargetConstants/{geo_target_constant}".format(geo_target_constant=geo_target_constant, )
    actual = GoogleAdsServiceClient.geo_target_constant_path(geo_target_constant)
    assert expected == actual


def test_parse_geo_target_constant_path():
    expected = {
    "geo_target_constant": "octopus",

    }
    path = GoogleAdsServiceClient.geo_target_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_geo_target_constant_path(path)
    assert expected == actual

def test_group_placement_view_path():
    customer = "oyster"
    group_placement_view = "nudibranch"

    expected = "customers/{customer}/groupPlacementViews/{group_placement_view}".format(customer=customer, group_placement_view=group_placement_view, )
    actual = GoogleAdsServiceClient.group_placement_view_path(customer, group_placement_view)
    assert expected == actual


def test_parse_group_placement_view_path():
    expected = {
    "customer": "cuttlefish",
    "group_placement_view": "mussel",

    }
    path = GoogleAdsServiceClient.group_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_group_placement_view_path(path)
    assert expected == actual

def test_hotel_group_view_path():
    customer = "winkle"
    hotel_group_view = "nautilus"

    expected = "customers/{customer}/hotelGroupViews/{hotel_group_view}".format(customer=customer, hotel_group_view=hotel_group_view, )
    actual = GoogleAdsServiceClient.hotel_group_view_path(customer, hotel_group_view)
    assert expected == actual


def test_parse_hotel_group_view_path():
    expected = {
    "customer": "scallop",
    "hotel_group_view": "abalone",

    }
    path = GoogleAdsServiceClient.hotel_group_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_hotel_group_view_path(path)
    assert expected == actual

def test_hotel_performance_view_path():
    customer = "squid"

    expected = "customers/{customer}/hotelPerformanceView".format(customer=customer, )
    actual = GoogleAdsServiceClient.hotel_performance_view_path(customer)
    assert expected == actual


def test_parse_hotel_performance_view_path():
    expected = {
    "customer": "clam",

    }
    path = GoogleAdsServiceClient.hotel_performance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_hotel_performance_view_path(path)
    assert expected == actual

def test_income_range_view_path():
    customer = "whelk"
    income_range_view = "octopus"

    expected = "customers/{customer}/incomeRangeViews/{income_range_view}".format(customer=customer, income_range_view=income_range_view, )
    actual = GoogleAdsServiceClient.income_range_view_path(customer, income_range_view)
    assert expected == actual


def test_parse_income_range_view_path():
    expected = {
    "customer": "oyster",
    "income_range_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.income_range_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_income_range_view_path(path)
    assert expected == actual

def test_keyword_plan_path():
    customer = "cuttlefish"
    keyword_plan = "mussel"

    expected = "customers/{customer}/keywordPlans/{keyword_plan}".format(customer=customer, keyword_plan=keyword_plan, )
    actual = GoogleAdsServiceClient.keyword_plan_path(customer, keyword_plan)
    assert expected == actual


def test_parse_keyword_plan_path():
    expected = {
    "customer": "winkle",
    "keyword_plan": "nautilus",

    }
    path = GoogleAdsServiceClient.keyword_plan_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_path():
    customer = "scallop"
    keyword_plan_ad_group = "abalone"

    expected = "customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}".format(customer=customer, keyword_plan_ad_group=keyword_plan_ad_group, )
    actual = GoogleAdsServiceClient.keyword_plan_ad_group_path(customer, keyword_plan_ad_group)
    assert expected == actual


def test_parse_keyword_plan_ad_group_path():
    expected = {
    "customer": "squid",
    "keyword_plan_ad_group": "clam",

    }
    path = GoogleAdsServiceClient.keyword_plan_ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_ad_group_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_keyword_path():
    customer = "whelk"
    keyword_plan_ad_group_keyword = "octopus"

    expected = "customers/{customer}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword}".format(customer=customer, keyword_plan_ad_group_keyword=keyword_plan_ad_group_keyword, )
    actual = GoogleAdsServiceClient.keyword_plan_ad_group_keyword_path(customer, keyword_plan_ad_group_keyword)
    assert expected == actual


def test_parse_keyword_plan_ad_group_keyword_path():
    expected = {
    "customer": "oyster",
    "keyword_plan_ad_group_keyword": "nudibranch",

    }
    path = GoogleAdsServiceClient.keyword_plan_ad_group_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_ad_group_keyword_path(path)
    assert expected == actual

def test_keyword_plan_campaign_path():
    customer = "cuttlefish"
    keyword_plan_campaign = "mussel"

    expected = "customers/{customer}/keywordPlanCampaigns/{keyword_plan_campaign}".format(customer=customer, keyword_plan_campaign=keyword_plan_campaign, )
    actual = GoogleAdsServiceClient.keyword_plan_campaign_path(customer, keyword_plan_campaign)
    assert expected == actual


def test_parse_keyword_plan_campaign_path():
    expected = {
    "customer": "winkle",
    "keyword_plan_campaign": "nautilus",

    }
    path = GoogleAdsServiceClient.keyword_plan_campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_campaign_path(path)
    assert expected == actual

def test_keyword_plan_campaign_keyword_path():
    customer = "scallop"
    keyword_plan_campaign_keyword = "abalone"

    expected = "customers/{customer}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword}".format(customer=customer, keyword_plan_campaign_keyword=keyword_plan_campaign_keyword, )
    actual = GoogleAdsServiceClient.keyword_plan_campaign_keyword_path(customer, keyword_plan_campaign_keyword)
    assert expected == actual


def test_parse_keyword_plan_campaign_keyword_path():
    expected = {
    "customer": "squid",
    "keyword_plan_campaign_keyword": "clam",

    }
    path = GoogleAdsServiceClient.keyword_plan_campaign_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_campaign_keyword_path(path)
    assert expected == actual

def test_keyword_view_path():
    customer = "whelk"
    keyword_view = "octopus"

    expected = "customers/{customer}/keywordViews/{keyword_view}".format(customer=customer, keyword_view=keyword_view, )
    actual = GoogleAdsServiceClient.keyword_view_path(customer, keyword_view)
    assert expected == actual


def test_parse_keyword_view_path():
    expected = {
    "customer": "oyster",
    "keyword_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.keyword_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_view_path(path)
    assert expected == actual

def test_label_path():
    customer = "cuttlefish"
    label = "mussel"

    expected = "customers/{customer}/labels/{label}".format(customer=customer, label=label, )
    actual = GoogleAdsServiceClient.label_path(customer, label)
    assert expected == actual


def test_parse_label_path():
    expected = {
    "customer": "winkle",
    "label": "nautilus",

    }
    path = GoogleAdsServiceClient.label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_label_path(path)
    assert expected == actual

def test_landing_page_view_path():
    customer = "scallop"
    landing_page_view = "abalone"

    expected = "customers/{customer}/landingPageViews/{landing_page_view}".format(customer=customer, landing_page_view=landing_page_view, )
    actual = GoogleAdsServiceClient.landing_page_view_path(customer, landing_page_view)
    assert expected == actual


def test_parse_landing_page_view_path():
    expected = {
    "customer": "squid",
    "landing_page_view": "clam",

    }
    path = GoogleAdsServiceClient.landing_page_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_landing_page_view_path(path)
    assert expected == actual

def test_language_constant_path():
    language_constant = "whelk"

    expected = "languageConstants/{language_constant}".format(language_constant=language_constant, )
    actual = GoogleAdsServiceClient.language_constant_path(language_constant)
    assert expected == actual


def test_parse_language_constant_path():
    expected = {
    "language_constant": "octopus",

    }
    path = GoogleAdsServiceClient.language_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_language_constant_path(path)
    assert expected == actual

def test_location_view_path():
    customer = "oyster"
    location_view = "nudibranch"

    expected = "customers/{customer}/locationViews/{location_view}".format(customer=customer, location_view=location_view, )
    actual = GoogleAdsServiceClient.location_view_path(customer, location_view)
    assert expected == actual


def test_parse_location_view_path():
    expected = {
    "customer": "cuttlefish",
    "location_view": "mussel",

    }
    path = GoogleAdsServiceClient.location_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_location_view_path(path)
    assert expected == actual

def test_managed_placement_view_path():
    customer = "winkle"
    managed_placement_view = "nautilus"

    expected = "customers/{customer}/managedPlacementViews/{managed_placement_view}".format(customer=customer, managed_placement_view=managed_placement_view, )
    actual = GoogleAdsServiceClient.managed_placement_view_path(customer, managed_placement_view)
    assert expected == actual


def test_parse_managed_placement_view_path():
    expected = {
    "customer": "scallop",
    "managed_placement_view": "abalone",

    }
    path = GoogleAdsServiceClient.managed_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_managed_placement_view_path(path)
    assert expected == actual

def test_media_file_path():
    customer = "squid"
    media_file = "clam"

    expected = "customers/{customer}/mediaFiles/{media_file}".format(customer=customer, media_file=media_file, )
    actual = GoogleAdsServiceClient.media_file_path(customer, media_file)
    assert expected == actual


def test_parse_media_file_path():
    expected = {
    "customer": "whelk",
    "media_file": "octopus",

    }
    path = GoogleAdsServiceClient.media_file_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_media_file_path(path)
    assert expected == actual

def test_mobile_app_category_constant_path():
    mobile_app_category_constant = "oyster"

    expected = "mobileAppCategoryConstants/{mobile_app_category_constant}".format(mobile_app_category_constant=mobile_app_category_constant, )
    actual = GoogleAdsServiceClient.mobile_app_category_constant_path(mobile_app_category_constant)
    assert expected == actual


def test_parse_mobile_app_category_constant_path():
    expected = {
    "mobile_app_category_constant": "nudibranch",

    }
    path = GoogleAdsServiceClient.mobile_app_category_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_mobile_app_category_constant_path(path)
    assert expected == actual

def test_mobile_device_constant_path():
    mobile_device_constant = "cuttlefish"

    expected = "mobileDeviceConstants/{mobile_device_constant}".format(mobile_device_constant=mobile_device_constant, )
    actual = GoogleAdsServiceClient.mobile_device_constant_path(mobile_device_constant)
    assert expected == actual


def test_parse_mobile_device_constant_path():
    expected = {
    "mobile_device_constant": "mussel",

    }
    path = GoogleAdsServiceClient.mobile_device_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_mobile_device_constant_path(path)
    assert expected == actual

def test_offline_user_data_job_path():
    customer = "winkle"
    offline_user_data_job = "nautilus"

    expected = "customers/{customer}/offlineUserDataJobs/{offline_user_data_job}".format(customer=customer, offline_user_data_job=offline_user_data_job, )
    actual = GoogleAdsServiceClient.offline_user_data_job_path(customer, offline_user_data_job)
    assert expected == actual


def test_parse_offline_user_data_job_path():
    expected = {
    "customer": "scallop",
    "offline_user_data_job": "abalone",

    }
    path = GoogleAdsServiceClient.offline_user_data_job_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_offline_user_data_job_path(path)
    assert expected == actual

def test_operating_system_version_constant_path():
    operating_system_version_constant = "squid"

    expected = "operatingSystemVersionConstants/{operating_system_version_constant}".format(operating_system_version_constant=operating_system_version_constant, )
    actual = GoogleAdsServiceClient.operating_system_version_constant_path(operating_system_version_constant)
    assert expected == actual


def test_parse_operating_system_version_constant_path():
    expected = {
    "operating_system_version_constant": "clam",

    }
    path = GoogleAdsServiceClient.operating_system_version_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_operating_system_version_constant_path(path)
    assert expected == actual

def test_paid_organic_search_term_view_path():
    customer = "whelk"
    paid_organic_search_term_view = "octopus"

    expected = "customers/{customer}/paidOrganicSearchTermViews/{paid_organic_search_term_view}".format(customer=customer, paid_organic_search_term_view=paid_organic_search_term_view, )
    actual = GoogleAdsServiceClient.paid_organic_search_term_view_path(customer, paid_organic_search_term_view)
    assert expected == actual


def test_parse_paid_organic_search_term_view_path():
    expected = {
    "customer": "oyster",
    "paid_organic_search_term_view": "nudibranch",

    }
    path = GoogleAdsServiceClient.paid_organic_search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_paid_organic_search_term_view_path(path)
    assert expected == actual

def test_parental_status_view_path():
    customer = "cuttlefish"
    parental_status_view = "mussel"

    expected = "customers/{customer}/parentalStatusViews/{parental_status_view}".format(customer=customer, parental_status_view=parental_status_view, )
    actual = GoogleAdsServiceClient.parental_status_view_path(customer, parental_status_view)
    assert expected == actual


def test_parse_parental_status_view_path():
    expected = {
    "customer": "winkle",
    "parental_status_view": "nautilus",

    }
    path = GoogleAdsServiceClient.parental_status_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_parental_status_view_path(path)
    assert expected == actual

def test_payments_account_path():
    customer = "scallop"
    payments_account = "abalone"

    expected = "customers/{customer}/paymentsAccounts/{payments_account}".format(customer=customer, payments_account=payments_account, )
    actual = GoogleAdsServiceClient.payments_account_path(customer, payments_account)
    assert expected == actual


def test_parse_payments_account_path():
    expected = {
    "customer": "squid",
    "payments_account": "clam",

    }
    path = GoogleAdsServiceClient.payments_account_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_payments_account_path(path)
    assert expected == actual

def test_product_bidding_category_constant_path():
    product_bidding_category_constant = "whelk"

    expected = "productBiddingCategoryConstants/{product_bidding_category_constant}".format(product_bidding_category_constant=product_bidding_category_constant, )
    actual = GoogleAdsServiceClient.product_bidding_category_constant_path(product_bidding_category_constant)
    assert expected == actual


def test_parse_product_bidding_category_constant_path():
    expected = {
    "product_bidding_category_constant": "octopus",

    }
    path = GoogleAdsServiceClient.product_bidding_category_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_product_bidding_category_constant_path(path)
    assert expected == actual

def test_product_group_view_path():
    customer = "oyster"
    product_group_view = "nudibranch"

    expected = "customers/{customer}/productGroupViews/{product_group_view}".format(customer=customer, product_group_view=product_group_view, )
    actual = GoogleAdsServiceClient.product_group_view_path(customer, product_group_view)
    assert expected == actual


def test_parse_product_group_view_path():
    expected = {
    "customer": "cuttlefish",
    "product_group_view": "mussel",

    }
    path = GoogleAdsServiceClient.product_group_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_product_group_view_path(path)
    assert expected == actual

def test_recommendation_path():
    customer = "winkle"
    recommendation = "nautilus"

    expected = "customers/{customer}/recommendations/{recommendation}".format(customer=customer, recommendation=recommendation, )
    actual = GoogleAdsServiceClient.recommendation_path(customer, recommendation)
    assert expected == actual


def test_parse_recommendation_path():
    expected = {
    "customer": "scallop",
    "recommendation": "abalone",

    }
    path = GoogleAdsServiceClient.recommendation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_recommendation_path(path)
    assert expected == actual

def test_remarketing_action_path():
    customer = "squid"
    remarketing_action = "clam"

    expected = "customers/{customer}/remarketingActions/{remarketing_action}".format(customer=customer, remarketing_action=remarketing_action, )
    actual = GoogleAdsServiceClient.remarketing_action_path(customer, remarketing_action)
    assert expected == actual


def test_parse_remarketing_action_path():
    expected = {
    "customer": "whelk",
    "remarketing_action": "octopus",

    }
    path = GoogleAdsServiceClient.remarketing_action_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_remarketing_action_path(path)
    assert expected == actual

def test_search_term_view_path():
    customer = "oyster"
    search_term_view = "nudibranch"

    expected = "customers/{customer}/searchTermViews/{search_term_view}".format(customer=customer, search_term_view=search_term_view, )
    actual = GoogleAdsServiceClient.search_term_view_path(customer, search_term_view)
    assert expected == actual


def test_parse_search_term_view_path():
    expected = {
    "customer": "cuttlefish",
    "search_term_view": "mussel",

    }
    path = GoogleAdsServiceClient.search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_search_term_view_path(path)
    assert expected == actual

def test_shared_criterion_path():
    customer = "winkle"
    shared_criterion = "nautilus"

    expected = "customers/{customer}/sharedCriteria/{shared_criterion}".format(customer=customer, shared_criterion=shared_criterion, )
    actual = GoogleAdsServiceClient.shared_criterion_path(customer, shared_criterion)
    assert expected == actual


def test_parse_shared_criterion_path():
    expected = {
    "customer": "scallop",
    "shared_criterion": "abalone",

    }
    path = GoogleAdsServiceClient.shared_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shared_criterion_path(path)
    assert expected == actual

def test_shared_set_path():
    customer = "squid"
    shared_set = "clam"

    expected = "customers/{customer}/sharedSets/{shared_set}".format(customer=customer, shared_set=shared_set, )
    actual = GoogleAdsServiceClient.shared_set_path(customer, shared_set)
    assert expected == actual


def test_parse_shared_set_path():
    expected = {
    "customer": "whelk",
    "shared_set": "octopus",

    }
    path = GoogleAdsServiceClient.shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shared_set_path(path)
    assert expected == actual

def test_shopping_performance_view_path():
    customer = "oyster"

    expected = "customers/{customer}/shoppingPerformanceView".format(customer=customer, )
    actual = GoogleAdsServiceClient.shopping_performance_view_path(customer)
    assert expected == actual


def test_parse_shopping_performance_view_path():
    expected = {
    "customer": "nudibranch",

    }
    path = GoogleAdsServiceClient.shopping_performance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shopping_performance_view_path(path)
    assert expected == actual

def test_third_party_app_analytics_link_path():
    customer = "cuttlefish"
    third_party_app_analytics_link = "mussel"

    expected = "customers/{customer}/thirdPartyAppAnalyticsLinks/{third_party_app_analytics_link}".format(customer=customer, third_party_app_analytics_link=third_party_app_analytics_link, )
    actual = GoogleAdsServiceClient.third_party_app_analytics_link_path(customer, third_party_app_analytics_link)
    assert expected == actual


def test_parse_third_party_app_analytics_link_path():
    expected = {
    "customer": "winkle",
    "third_party_app_analytics_link": "nautilus",

    }
    path = GoogleAdsServiceClient.third_party_app_analytics_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_third_party_app_analytics_link_path(path)
    assert expected == actual

def test_topic_constant_path():
    topic_constant = "scallop"

    expected = "topicConstants/{topic_constant}".format(topic_constant=topic_constant, )
    actual = GoogleAdsServiceClient.topic_constant_path(topic_constant)
    assert expected == actual


def test_parse_topic_constant_path():
    expected = {
    "topic_constant": "abalone",

    }
    path = GoogleAdsServiceClient.topic_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_topic_constant_path(path)
    assert expected == actual

def test_topic_view_path():
    customer = "squid"
    topic_view = "clam"

    expected = "customers/{customer}/topicViews/{topic_view}".format(customer=customer, topic_view=topic_view, )
    actual = GoogleAdsServiceClient.topic_view_path(customer, topic_view)
    assert expected == actual


def test_parse_topic_view_path():
    expected = {
    "customer": "whelk",
    "topic_view": "octopus",

    }
    path = GoogleAdsServiceClient.topic_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_topic_view_path(path)
    assert expected == actual

def test_user_interest_path():
    customer = "oyster"
    user_interest = "nudibranch"

    expected = "customers/{customer}/userInterests/{user_interest}".format(customer=customer, user_interest=user_interest, )
    actual = GoogleAdsServiceClient.user_interest_path(customer, user_interest)
    assert expected == actual


def test_parse_user_interest_path():
    expected = {
    "customer": "cuttlefish",
    "user_interest": "mussel",

    }
    path = GoogleAdsServiceClient.user_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_interest_path(path)
    assert expected == actual

def test_user_list_path():
    customer = "winkle"
    user_list = "nautilus"

    expected = "customers/{customer}/userLists/{user_list}".format(customer=customer, user_list=user_list, )
    actual = GoogleAdsServiceClient.user_list_path(customer, user_list)
    assert expected == actual


def test_parse_user_list_path():
    expected = {
    "customer": "scallop",
    "user_list": "abalone",

    }
    path = GoogleAdsServiceClient.user_list_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_list_path(path)
    assert expected == actual

def test_user_location_view_path():
    customer = "squid"
    user_location_view = "clam"

    expected = "customers/{customer}/userLocationViews/{user_location_view}".format(customer=customer, user_location_view=user_location_view, )
    actual = GoogleAdsServiceClient.user_location_view_path(customer, user_location_view)
    assert expected == actual


def test_parse_user_location_view_path():
    expected = {
    "customer": "whelk",
    "user_location_view": "octopus",

    }
    path = GoogleAdsServiceClient.user_location_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_location_view_path(path)
    assert expected == actual

def test_video_path():
    customer = "oyster"
    video = "nudibranch"

    expected = "customers/{customer}/videos/{video}".format(customer=customer, video=video, )
    actual = GoogleAdsServiceClient.video_path(customer, video)
    assert expected == actual


def test_parse_video_path():
    expected = {
    "customer": "cuttlefish",
    "video": "mussel",

    }
    path = GoogleAdsServiceClient.video_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_video_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "winkle"

    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = GoogleAdsServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
    "billing_account": "nautilus",

    }
    path = GoogleAdsServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "scallop"

    expected = "folders/{folder}".format(folder=folder, )
    actual = GoogleAdsServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
    "folder": "abalone",

    }
    path = GoogleAdsServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "squid"

    expected = "organizations/{organization}".format(organization=organization, )
    actual = GoogleAdsServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
    "organization": "clam",

    }
    path = GoogleAdsServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "whelk"

    expected = "projects/{project}".format(project=project, )
    actual = GoogleAdsServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
    "project": "octopus",

    }
    path = GoogleAdsServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "oyster"
    location = "nudibranch"

    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = GoogleAdsServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
    "project": "cuttlefish",
    "location": "mussel",

    }
    path = GoogleAdsServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.GoogleAdsServiceTransport, '_prep_wrapped_messages') as prep:
        client = GoogleAdsServiceClient(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.GoogleAdsServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = GoogleAdsServiceClient.get_transport_class()
        transport = transport_class(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
