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
from google.ads.googleads.v4.common.types import ad_asset
from google.ads.googleads.v4.common.types import ad_type_infos
from google.ads.googleads.v4.common.types import asset_types
from google.ads.googleads.v4.common.types import bidding
from google.ads.googleads.v4.common.types import criteria
from google.ads.googleads.v4.common.types import custom_parameter
from google.ads.googleads.v4.common.types import dates
from google.ads.googleads.v4.common.types import explorer_auto_optimizer_setting
from google.ads.googleads.v4.common.types import extensions
from google.ads.googleads.v4.common.types import feed_common
from google.ads.googleads.v4.common.types import final_app_url
from google.ads.googleads.v4.common.types import frequency_cap
from google.ads.googleads.v4.common.types import matching_function
from google.ads.googleads.v4.common.types import policy as gagc_policy
from google.ads.googleads.v4.common.types import real_time_bidding_setting
from google.ads.googleads.v4.common.types import tag_snippet
from google.ads.googleads.v4.common.types import targeting_setting
from google.ads.googleads.v4.common.types import text_label
from google.ads.googleads.v4.common.types import url_collection
from google.ads.googleads.v4.common.types import user_lists
from google.ads.googleads.v4.enums.types import access_reason
from google.ads.googleads.v4.enums.types import ad_customizer_placeholder_field
from google.ads.googleads.v4.enums.types import ad_group_ad_rotation_mode
from google.ads.googleads.v4.enums.types import ad_group_ad_status
from google.ads.googleads.v4.enums.types import ad_group_criterion_approval_status
from google.ads.googleads.v4.enums.types import ad_group_criterion_status
from google.ads.googleads.v4.enums.types import ad_group_status
from google.ads.googleads.v4.enums.types import ad_group_type
from google.ads.googleads.v4.enums.types import ad_serving_optimization_status
from google.ads.googleads.v4.enums.types import ad_strength
from google.ads.googleads.v4.enums.types import ad_type
from google.ads.googleads.v4.enums.types import advertising_channel_sub_type
from google.ads.googleads.v4.enums.types import advertising_channel_type
from google.ads.googleads.v4.enums.types import affiliate_location_feed_relationship_type
from google.ads.googleads.v4.enums.types import affiliate_location_placeholder_field
from google.ads.googleads.v4.enums.types import age_range_type
from google.ads.googleads.v4.enums.types import app_campaign_app_store
from google.ads.googleads.v4.enums.types import app_campaign_bidding_strategy_goal_type
from google.ads.googleads.v4.enums.types import app_payment_model_type
from google.ads.googleads.v4.enums.types import app_placeholder_field
from google.ads.googleads.v4.enums.types import app_store
from google.ads.googleads.v4.enums.types import app_url_operating_system_type
from google.ads.googleads.v4.enums.types import asset_type
from google.ads.googleads.v4.enums.types import attribution_model
from google.ads.googleads.v4.enums.types import batch_job_status
from google.ads.googleads.v4.enums.types import bid_modifier_source
from google.ads.googleads.v4.enums.types import bidding_source
from google.ads.googleads.v4.enums.types import bidding_strategy_status
from google.ads.googleads.v4.enums.types import bidding_strategy_type
from google.ads.googleads.v4.enums.types import brand_safety_suitability
from google.ads.googleads.v4.enums.types import budget_delivery_method
from google.ads.googleads.v4.enums.types import budget_period
from google.ads.googleads.v4.enums.types import budget_status
from google.ads.googleads.v4.enums.types import budget_type
from google.ads.googleads.v4.enums.types import call_conversion_reporting_state
from google.ads.googleads.v4.enums.types import call_placeholder_field
from google.ads.googleads.v4.enums.types import callout_placeholder_field
from google.ads.googleads.v4.enums.types import campaign_criterion_status
from google.ads.googleads.v4.enums.types import campaign_draft_status
from google.ads.googleads.v4.enums.types import campaign_experiment_status
from google.ads.googleads.v4.enums.types import campaign_experiment_traffic_split_type
from google.ads.googleads.v4.enums.types import campaign_experiment_type
from google.ads.googleads.v4.enums.types import campaign_serving_status
from google.ads.googleads.v4.enums.types import campaign_shared_set_status
from google.ads.googleads.v4.enums.types import campaign_status
from google.ads.googleads.v4.enums.types import content_label_type
from google.ads.googleads.v4.enums.types import conversion_action_category
from google.ads.googleads.v4.enums.types import conversion_action_counting_type
from google.ads.googleads.v4.enums.types import conversion_action_status
from google.ads.googleads.v4.enums.types import conversion_action_type
from google.ads.googleads.v4.enums.types import criterion_system_serving_status
from google.ads.googleads.v4.enums.types import criterion_type
from google.ads.googleads.v4.enums.types import custom_placeholder_field
from google.ads.googleads.v4.enums.types import customer_match_upload_key_type
from google.ads.googleads.v4.enums.types import customer_pay_per_conversion_eligibility_failure_reason
from google.ads.googleads.v4.enums.types import data_driven_model_status
from google.ads.googleads.v4.enums.types import day_of_week
from google.ads.googleads.v4.enums.types import device
from google.ads.googleads.v4.enums.types import display_ad_format_setting
from google.ads.googleads.v4.enums.types import display_upload_product_type
from google.ads.googleads.v4.enums.types import dsa_page_feed_criterion_field
from google.ads.googleads.v4.enums.types import education_placeholder_field
from google.ads.googleads.v4.enums.types import extension_setting_device
from google.ads.googleads.v4.enums.types import extension_type
from google.ads.googleads.v4.enums.types import feed_attribute_type
from google.ads.googleads.v4.enums.types import feed_item_quality_approval_status
from google.ads.googleads.v4.enums.types import feed_item_quality_disapproval_reason
from google.ads.googleads.v4.enums.types import feed_item_status
from google.ads.googleads.v4.enums.types import feed_item_target_device
from google.ads.googleads.v4.enums.types import feed_item_target_status
from google.ads.googleads.v4.enums.types import feed_item_target_type
from google.ads.googleads.v4.enums.types import feed_item_validation_status
from google.ads.googleads.v4.enums.types import feed_link_status
from google.ads.googleads.v4.enums.types import feed_mapping_criterion_type
from google.ads.googleads.v4.enums.types import feed_mapping_status
from google.ads.googleads.v4.enums.types import feed_origin
from google.ads.googleads.v4.enums.types import feed_status
from google.ads.googleads.v4.enums.types import flight_placeholder_field
from google.ads.googleads.v4.enums.types import frequency_cap_event_type
from google.ads.googleads.v4.enums.types import frequency_cap_level
from google.ads.googleads.v4.enums.types import frequency_cap_time_unit
from google.ads.googleads.v4.enums.types import gender_type
from google.ads.googleads.v4.enums.types import geo_targeting_restriction
from google.ads.googleads.v4.enums.types import hotel_date_selection_type
from google.ads.googleads.v4.enums.types import hotel_placeholder_field
from google.ads.googleads.v4.enums.types import income_range_type
from google.ads.googleads.v4.enums.types import interaction_type
from google.ads.googleads.v4.enums.types import job_placeholder_field
from google.ads.googleads.v4.enums.types import keyword_match_type
from google.ads.googleads.v4.enums.types import keyword_plan_forecast_interval
from google.ads.googleads.v4.enums.types import keyword_plan_network
from google.ads.googleads.v4.enums.types import label_status
from google.ads.googleads.v4.enums.types import legacy_app_install_ad_app_store
from google.ads.googleads.v4.enums.types import listing_group_type
from google.ads.googleads.v4.enums.types import local_placeholder_field
from google.ads.googleads.v4.enums.types import location_extension_targeting_criterion_field
from google.ads.googleads.v4.enums.types import location_group_radius_units
from google.ads.googleads.v4.enums.types import location_placeholder_field
from google.ads.googleads.v4.enums.types import location_source_type
from google.ads.googleads.v4.enums.types import matching_function_context_type
from google.ads.googleads.v4.enums.types import matching_function_operator
from google.ads.googleads.v4.enums.types import media_type
from google.ads.googleads.v4.enums.types import message_placeholder_field
from google.ads.googleads.v4.enums.types import mime_type
from google.ads.googleads.v4.enums.types import minute_of_hour
from google.ads.googleads.v4.enums.types import mobile_app_vendor
from google.ads.googleads.v4.enums.types import negative_geo_target_type
from google.ads.googleads.v4.enums.types import optimization_goal_type
from google.ads.googleads.v4.enums.types import parental_status_type
from google.ads.googleads.v4.enums.types import payment_mode
from google.ads.googleads.v4.enums.types import placeholder_type
from google.ads.googleads.v4.enums.types import policy_approval_status
from google.ads.googleads.v4.enums.types import policy_review_status
from google.ads.googleads.v4.enums.types import policy_topic_entry_type
from google.ads.googleads.v4.enums.types import policy_topic_evidence_destination_mismatch_url_type
from google.ads.googleads.v4.enums.types import policy_topic_evidence_destination_not_working_device
from google.ads.googleads.v4.enums.types import policy_topic_evidence_destination_not_working_dns_error_type
from google.ads.googleads.v4.enums.types import positive_geo_target_type
from google.ads.googleads.v4.enums.types import preferred_content_type
from google.ads.googleads.v4.enums.types import price_extension_price_qualifier
from google.ads.googleads.v4.enums.types import price_extension_price_unit
from google.ads.googleads.v4.enums.types import price_extension_type
from google.ads.googleads.v4.enums.types import price_placeholder_field
from google.ads.googleads.v4.enums.types import product_bidding_category_level
from google.ads.googleads.v4.enums.types import product_channel
from google.ads.googleads.v4.enums.types import product_channel_exclusivity
from google.ads.googleads.v4.enums.types import product_condition
from google.ads.googleads.v4.enums.types import product_custom_attribute_index
from google.ads.googleads.v4.enums.types import product_type_level
from google.ads.googleads.v4.enums.types import promotion_extension_discount_modifier
from google.ads.googleads.v4.enums.types import promotion_extension_occasion
from google.ads.googleads.v4.enums.types import promotion_placeholder_field
from google.ads.googleads.v4.enums.types import proximity_radius_units
from google.ads.googleads.v4.enums.types import quality_score_bucket
from google.ads.googleads.v4.enums.types import real_estate_placeholder_field
from google.ads.googleads.v4.enums.types import served_asset_field_type
from google.ads.googleads.v4.enums.types import shared_set_status
from google.ads.googleads.v4.enums.types import shared_set_type
from google.ads.googleads.v4.enums.types import sitelink_placeholder_field
from google.ads.googleads.v4.enums.types import structured_snippet_placeholder_field
from google.ads.googleads.v4.enums.types import system_managed_entity_source
from google.ads.googleads.v4.enums.types import target_impression_share_location
from google.ads.googleads.v4.enums.types import targeting_dimension
from google.ads.googleads.v4.enums.types import tracking_code_page_format
from google.ads.googleads.v4.enums.types import tracking_code_type
from google.ads.googleads.v4.enums.types import travel_placeholder_field
from google.ads.googleads.v4.enums.types import user_list_access_status
from google.ads.googleads.v4.enums.types import user_list_closing_reason
from google.ads.googleads.v4.enums.types import user_list_combined_rule_operator
from google.ads.googleads.v4.enums.types import user_list_crm_data_source_type
from google.ads.googleads.v4.enums.types import user_list_date_rule_item_operator
from google.ads.googleads.v4.enums.types import user_list_logical_rule_operator
from google.ads.googleads.v4.enums.types import user_list_membership_status
from google.ads.googleads.v4.enums.types import user_list_number_rule_item_operator
from google.ads.googleads.v4.enums.types import user_list_prepopulation_status
from google.ads.googleads.v4.enums.types import user_list_rule_type
from google.ads.googleads.v4.enums.types import user_list_size_range
from google.ads.googleads.v4.enums.types import user_list_string_rule_item_operator
from google.ads.googleads.v4.enums.types import user_list_type
from google.ads.googleads.v4.enums.types import vanity_pharma_display_url_mode
from google.ads.googleads.v4.enums.types import vanity_pharma_text
from google.ads.googleads.v4.enums.types import webpage_condition_operand
from google.ads.googleads.v4.enums.types import webpage_condition_operator
from google.ads.googleads.v4.errors.types import feed_item_validation_error
from google.ads.googleads.v4.resources.types import ad
from google.ads.googleads.v4.resources.types import ad_group
from google.ads.googleads.v4.resources.types import ad_group_ad
from google.ads.googleads.v4.resources.types import ad_group_ad_label
from google.ads.googleads.v4.resources.types import ad_group_bid_modifier
from google.ads.googleads.v4.resources.types import ad_group_criterion
from google.ads.googleads.v4.resources.types import ad_group_criterion_label
from google.ads.googleads.v4.resources.types import ad_group_extension_setting
from google.ads.googleads.v4.resources.types import ad_group_feed
from google.ads.googleads.v4.resources.types import ad_group_label
from google.ads.googleads.v4.resources.types import ad_parameter
from google.ads.googleads.v4.resources.types import asset
from google.ads.googleads.v4.resources.types import batch_job
from google.ads.googleads.v4.resources.types import bidding_strategy
from google.ads.googleads.v4.resources.types import campaign
from google.ads.googleads.v4.resources.types import campaign_bid_modifier
from google.ads.googleads.v4.resources.types import campaign_budget
from google.ads.googleads.v4.resources.types import campaign_criterion
from google.ads.googleads.v4.resources.types import campaign_draft
from google.ads.googleads.v4.resources.types import campaign_experiment
from google.ads.googleads.v4.resources.types import campaign_extension_setting
from google.ads.googleads.v4.resources.types import campaign_feed
from google.ads.googleads.v4.resources.types import campaign_label
from google.ads.googleads.v4.resources.types import campaign_shared_set
from google.ads.googleads.v4.resources.types import conversion_action
from google.ads.googleads.v4.resources.types import customer
from google.ads.googleads.v4.resources.types import customer_extension_setting
from google.ads.googleads.v4.resources.types import customer_feed
from google.ads.googleads.v4.resources.types import customer_label
from google.ads.googleads.v4.resources.types import customer_negative_criterion
from google.ads.googleads.v4.resources.types import extension_feed_item
from google.ads.googleads.v4.resources.types import feed
from google.ads.googleads.v4.resources.types import feed_item
from google.ads.googleads.v4.resources.types import feed_item_target
from google.ads.googleads.v4.resources.types import feed_mapping
from google.ads.googleads.v4.resources.types import keyword_plan
from google.ads.googleads.v4.resources.types import keyword_plan_ad_group
from google.ads.googleads.v4.resources.types import keyword_plan_ad_group_keyword
from google.ads.googleads.v4.resources.types import keyword_plan_campaign
from google.ads.googleads.v4.resources.types import keyword_plan_campaign_keyword
from google.ads.googleads.v4.resources.types import label
from google.ads.googleads.v4.resources.types import media_file
from google.ads.googleads.v4.resources.types import remarketing_action
from google.ads.googleads.v4.resources.types import shared_criterion
from google.ads.googleads.v4.resources.types import shared_set
from google.ads.googleads.v4.resources.types import user_list
from google.ads.googleads.v4.services.services.batch_job_service import BatchJobServiceClient
from google.ads.googleads.v4.services.services.batch_job_service import pagers
from google.ads.googleads.v4.services.services.batch_job_service import transports
from google.ads.googleads.v4.services.types import ad_group_ad_label_service
from google.ads.googleads.v4.services.types import ad_group_ad_service
from google.ads.googleads.v4.services.types import ad_group_bid_modifier_service
from google.ads.googleads.v4.services.types import ad_group_criterion_label_service
from google.ads.googleads.v4.services.types import ad_group_criterion_service
from google.ads.googleads.v4.services.types import ad_group_extension_setting_service
from google.ads.googleads.v4.services.types import ad_group_feed_service
from google.ads.googleads.v4.services.types import ad_group_label_service
from google.ads.googleads.v4.services.types import ad_group_service
from google.ads.googleads.v4.services.types import ad_parameter_service
from google.ads.googleads.v4.services.types import ad_service
from google.ads.googleads.v4.services.types import asset_service
from google.ads.googleads.v4.services.types import batch_job_service
from google.ads.googleads.v4.services.types import bidding_strategy_service
from google.ads.googleads.v4.services.types import campaign_bid_modifier_service
from google.ads.googleads.v4.services.types import campaign_budget_service
from google.ads.googleads.v4.services.types import campaign_criterion_service
from google.ads.googleads.v4.services.types import campaign_draft_service
from google.ads.googleads.v4.services.types import campaign_experiment_service
from google.ads.googleads.v4.services.types import campaign_extension_setting_service
from google.ads.googleads.v4.services.types import campaign_feed_service
from google.ads.googleads.v4.services.types import campaign_label_service
from google.ads.googleads.v4.services.types import campaign_service
from google.ads.googleads.v4.services.types import campaign_shared_set_service
from google.ads.googleads.v4.services.types import conversion_action_service
from google.ads.googleads.v4.services.types import customer_extension_setting_service
from google.ads.googleads.v4.services.types import customer_feed_service
from google.ads.googleads.v4.services.types import customer_label_service
from google.ads.googleads.v4.services.types import customer_negative_criterion_service
from google.ads.googleads.v4.services.types import customer_service
from google.ads.googleads.v4.services.types import extension_feed_item_service
from google.ads.googleads.v4.services.types import feed_item_service
from google.ads.googleads.v4.services.types import feed_item_target_service
from google.ads.googleads.v4.services.types import feed_mapping_service
from google.ads.googleads.v4.services.types import feed_service
from google.ads.googleads.v4.services.types import google_ads_service
from google.ads.googleads.v4.services.types import keyword_plan_ad_group_keyword_service
from google.ads.googleads.v4.services.types import keyword_plan_ad_group_service
from google.ads.googleads.v4.services.types import keyword_plan_campaign_keyword_service
from google.ads.googleads.v4.services.types import keyword_plan_campaign_service
from google.ads.googleads.v4.services.types import keyword_plan_service
from google.ads.googleads.v4.services.types import label_service
from google.ads.googleads.v4.services.types import media_file_service
from google.ads.googleads.v4.services.types import remarketing_action_service
from google.ads.googleads.v4.services.types import shared_criterion_service
from google.ads.googleads.v4.services.types import shared_set_service
from google.ads.googleads.v4.services.types import user_list_service
from google.api_core import client_options
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.auth import credentials
from google.auth.exceptions import MutualTLSChannelError
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore


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

    assert BatchJobServiceClient._get_default_mtls_endpoint(None) is None
    assert BatchJobServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_batch_job_service_client_from_service_account_info():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = BatchJobServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_batch_job_service_client_from_service_account_file():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = BatchJobServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = BatchJobServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_batch_job_service_client_get_transport_class():
    transport = BatchJobServiceClient.get_transport_class()
    assert transport == transports.BatchJobServiceGrpcTransport

    transport = BatchJobServiceClient.get_transport_class("grpc")
    assert transport == transports.BatchJobServiceGrpcTransport


@mock.patch.object(BatchJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BatchJobServiceClient))
def test_batch_job_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.BatchJobServiceClient.get_transport_class') as gtc:
        transport = transports.BatchJobServiceGrpcTransport(
            credentials=credentials.AnonymousCredentials()
        )
        client = BatchJobServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.BatchJobServiceClient.get_transport_class') as gtc:
        client = BatchJobServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BatchJobServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = BatchJobServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = BatchJobServiceClient()
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
            client = BatchJobServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = BatchJobServiceClient()


@mock.patch.object(BatchJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BatchJobServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_batch_job_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = BatchJobServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = BatchJobServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = BatchJobServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_batch_job_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BatchJobServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_mutate_batch_job(transport: str = 'grpc', request_type=batch_job_service.MutateBatchJobRequest):
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.MutateBatchJobResponse(
        )

        response = client.mutate_batch_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == batch_job_service.MutateBatchJobRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, batch_job_service.MutateBatchJobResponse)


def test_mutate_batch_job_from_dict():
    test_mutate_batch_job(request_type=dict)


def test_mutate_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = batch_job_service.MutateBatchJobRequest()
    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_batch_job),
            '__call__') as call:
        call.return_value = batch_job_service.MutateBatchJobResponse()

        client.mutate_batch_job(request)

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


def test_mutate_batch_job_flattened():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.MutateBatchJobResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_batch_job(
            customer_id='customer_id_value',
            operation=batch_job_service.BatchJobOperation(create=batch_job.BatchJob(resource_name='resource_name_value')),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].customer_id == 'customer_id_value'

        assert args[0].operation == batch_job_service.BatchJobOperation(create=batch_job.BatchJob(resource_name='resource_name_value'))


def test_mutate_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_batch_job(
            batch_job_service.MutateBatchJobRequest(),
            customer_id='customer_id_value',
            operation=batch_job_service.BatchJobOperation(create=batch_job.BatchJob(resource_name='resource_name_value')),
        )


def test_get_batch_job(transport: str = 'grpc', request_type=batch_job_service.GetBatchJobRequest):
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job.BatchJob(
            resource_name='resource_name_value',

            status=batch_job_status.BatchJobStatusEnum.BatchJobStatus.UNKNOWN,

        )

        response = client.get_batch_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == batch_job_service.GetBatchJobRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, batch_job.BatchJob)

    assert response.resource_name == 'resource_name_value'

    assert response.status == batch_job_status.BatchJobStatusEnum.BatchJobStatus.UNKNOWN


def test_get_batch_job_from_dict():
    test_get_batch_job(request_type=dict)


def test_get_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = batch_job_service.GetBatchJobRequest()
    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_batch_job),
            '__call__') as call:
        call.return_value = batch_job.BatchJob()

        client.get_batch_job(request)

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


def test_get_batch_job_flattened():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job.BatchJob()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_batch_job(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].resource_name == 'resource_name_value'


def test_get_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_batch_job(
            batch_job_service.GetBatchJobRequest(),
            resource_name='resource_name_value',
        )


def test_list_batch_job_results(transport: str = 'grpc', request_type=batch_job_service.ListBatchJobResultsRequest):
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.ListBatchJobResultsResponse(
            next_page_token='next_page_token_value',

        )

        response = client.list_batch_job_results(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == batch_job_service.ListBatchJobResultsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, pagers.ListBatchJobResultsPager)

    assert response.next_page_token == 'next_page_token_value'


def test_list_batch_job_results_from_dict():
    test_list_batch_job_results(request_type=dict)


def test_list_batch_job_results_field_headers():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = batch_job_service.ListBatchJobResultsRequest()
    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        call.return_value = batch_job_service.ListBatchJobResultsResponse()

        client.list_batch_job_results(request)

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


def test_list_batch_job_results_flattened():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.ListBatchJobResultsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_batch_job_results(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].resource_name == 'resource_name_value'


def test_list_batch_job_results_flattened_error():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_batch_job_results(
            batch_job_service.ListBatchJobResultsRequest(),
            resource_name='resource_name_value',
        )


def test_list_batch_job_results_pager():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                ],
                next_page_token='abc',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[],
                next_page_token='def',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                ],
                next_page_token='ghi',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('resource_name', ''),
            )),
        )
        pager = client.list_batch_job_results(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, batch_job_service.BatchJobResult)
                   for i in results)

def test_list_batch_job_results_pages():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                ],
                next_page_token='abc',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[],
                next_page_token='def',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                ],
                next_page_token='ghi',
            ),
            batch_job_service.ListBatchJobResultsResponse(
                results=[
                    batch_job_service.BatchJobResult(),
                    batch_job_service.BatchJobResult(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_batch_job_results(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_run_batch_job(transport: str = 'grpc', request_type=batch_job_service.RunBatchJobRequest):
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.run_batch_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == batch_job_service.RunBatchJobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_run_batch_job_from_dict():
    test_run_batch_job(request_type=dict)


def test_run_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = batch_job_service.RunBatchJobRequest()
    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_batch_job),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.run_batch_job(request)

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


def test_run_batch_job_flattened():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_batch_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.run_batch_job(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].resource_name == 'resource_name_value'


def test_run_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.run_batch_job(
            batch_job_service.RunBatchJobRequest(),
            resource_name='resource_name_value',
        )


def test_add_batch_job_operations(transport: str = 'grpc', request_type=batch_job_service.AddBatchJobOperationsRequest):
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_batch_job_operations),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.AddBatchJobOperationsResponse(
            total_operations=1735,

            next_sequence_token='next_sequence_token_value',

        )

        response = client.add_batch_job_operations(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == batch_job_service.AddBatchJobOperationsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, batch_job_service.AddBatchJobOperationsResponse)

    assert response.total_operations == 1735

    assert response.next_sequence_token == 'next_sequence_token_value'


def test_add_batch_job_operations_from_dict():
    test_add_batch_job_operations(request_type=dict)


def test_add_batch_job_operations_field_headers():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = batch_job_service.AddBatchJobOperationsRequest()
    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_batch_job_operations),
            '__call__') as call:
        call.return_value = batch_job_service.AddBatchJobOperationsResponse()

        client.add_batch_job_operations(request)

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


def test_add_batch_job_operations_flattened():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_batch_job_operations),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = batch_job_service.AddBatchJobOperationsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.add_batch_job_operations(
            resource_name='resource_name_value',
            sequence_token='sequence_token_value',
            mutate_operations=[google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].resource_name == 'resource_name_value'

        assert args[0].sequence_token == 'sequence_token_value'

        assert args[0].mutate_operations == [google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))]


def test_add_batch_job_operations_flattened_error():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.add_batch_job_operations(
            batch_job_service.AddBatchJobOperationsRequest(),
            resource_name='resource_name_value',
            sequence_token='sequence_token_value',
            mutate_operations=[google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BatchJobServiceClient(
            credentials=credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    client = BatchJobServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.BatchJobServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.BatchJobServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_batch_job_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.BatchJobServiceTransport(
            credentials=credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'mutate_batch_job',
        'get_batch_job',
        'list_batch_job_results',
        'run_batch_job',
        'add_batch_job_operations',
        )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_batch_job_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(auth, 'default') as adc, mock.patch('google.ads.googleads.v4.services.services.batch_job_service.transports.BatchJobServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.BatchJobServiceTransport()
        adc.assert_called_once()


def test_batch_job_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        BatchJobServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_batch_job_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transports.BatchJobServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_batch_job_service_host_no_port():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_batch_job_service_host_with_port():
    client = BatchJobServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_batch_job_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.BatchJobServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.BatchJobServiceGrpcTransport])
def test_batch_job_service_transport_channel_mtls_with_client_cert_source(
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


@pytest.mark.parametrize("transport_class", [transports.BatchJobServiceGrpcTransport,])
def test_batch_job_service_transport_channel_mtls_with_adc(
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


def test_batch_job_service_grpc_lro_client():
    client = BatchJobServiceClient(
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

def test_ad_path():
    customer = "squid"
    ad = "clam"

    expected = "customers/{customer}/ads/{ad}".format(customer=customer, ad=ad, )
    actual = BatchJobServiceClient.ad_path(customer, ad)
    assert expected == actual


def test_parse_ad_path():
    expected = {
    "customer": "whelk",
    "ad": "octopus",

    }
    path = BatchJobServiceClient.ad_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_path(path)
    assert expected == actual

def test_ad_group_path():
    customer = "oyster"
    ad_group = "nudibranch"

    expected = "customers/{customer}/adGroups/{ad_group}".format(customer=customer, ad_group=ad_group, )
    actual = BatchJobServiceClient.ad_group_path(customer, ad_group)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group": "mussel",

    }
    path = BatchJobServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_ad_path():
    customer = "winkle"
    ad_group_ad = "nautilus"

    expected = "customers/{customer}/adGroupAds/{ad_group_ad}".format(customer=customer, ad_group_ad=ad_group_ad, )
    actual = BatchJobServiceClient.ad_group_ad_path(customer, ad_group_ad)
    assert expected == actual


def test_parse_ad_group_ad_path():
    expected = {
    "customer": "scallop",
    "ad_group_ad": "abalone",

    }
    path = BatchJobServiceClient.ad_group_ad_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_ad_path(path)
    assert expected == actual

def test_ad_group_ad_label_path():
    customer = "squid"
    ad_group_ad_label = "clam"

    expected = "customers/{customer}/adGroupAdLabels/{ad_group_ad_label}".format(customer=customer, ad_group_ad_label=ad_group_ad_label, )
    actual = BatchJobServiceClient.ad_group_ad_label_path(customer, ad_group_ad_label)
    assert expected == actual


def test_parse_ad_group_ad_label_path():
    expected = {
    "customer": "whelk",
    "ad_group_ad_label": "octopus",

    }
    path = BatchJobServiceClient.ad_group_ad_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_ad_label_path(path)
    assert expected == actual

def test_ad_group_bid_modifier_path():
    customer = "oyster"
    ad_group_bid_modifier = "nudibranch"

    expected = "customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}".format(customer=customer, ad_group_bid_modifier=ad_group_bid_modifier, )
    actual = BatchJobServiceClient.ad_group_bid_modifier_path(customer, ad_group_bid_modifier)
    assert expected == actual


def test_parse_ad_group_bid_modifier_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_bid_modifier": "mussel",

    }
    path = BatchJobServiceClient.ad_group_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_bid_modifier_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer = "winkle"
    ad_group_criterion = "nautilus"

    expected = "customers/{customer}/adGroupCriteria/{ad_group_criterion}".format(customer=customer, ad_group_criterion=ad_group_criterion, )
    actual = BatchJobServiceClient.ad_group_criterion_path(customer, ad_group_criterion)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
    "customer": "scallop",
    "ad_group_criterion": "abalone",

    }
    path = BatchJobServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_criterion_label_path():
    customer = "squid"
    ad_group_criterion_label = "clam"

    expected = "customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}".format(customer=customer, ad_group_criterion_label=ad_group_criterion_label, )
    actual = BatchJobServiceClient.ad_group_criterion_label_path(customer, ad_group_criterion_label)
    assert expected == actual


def test_parse_ad_group_criterion_label_path():
    expected = {
    "customer": "whelk",
    "ad_group_criterion_label": "octopus",

    }
    path = BatchJobServiceClient.ad_group_criterion_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_criterion_label_path(path)
    assert expected == actual

def test_ad_group_extension_setting_path():
    customer = "oyster"
    ad_group_extension_setting = "nudibranch"

    expected = "customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}".format(customer=customer, ad_group_extension_setting=ad_group_extension_setting, )
    actual = BatchJobServiceClient.ad_group_extension_setting_path(customer, ad_group_extension_setting)
    assert expected == actual


def test_parse_ad_group_extension_setting_path():
    expected = {
    "customer": "cuttlefish",
    "ad_group_extension_setting": "mussel",

    }
    path = BatchJobServiceClient.ad_group_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_extension_setting_path(path)
    assert expected == actual

def test_ad_group_feed_path():
    customer = "winkle"
    ad_group_feed = "nautilus"

    expected = "customers/{customer}/adGroupFeeds/{ad_group_feed}".format(customer=customer, ad_group_feed=ad_group_feed, )
    actual = BatchJobServiceClient.ad_group_feed_path(customer, ad_group_feed)
    assert expected == actual


def test_parse_ad_group_feed_path():
    expected = {
    "customer": "scallop",
    "ad_group_feed": "abalone",

    }
    path = BatchJobServiceClient.ad_group_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_feed_path(path)
    assert expected == actual

def test_ad_group_label_path():
    customer = "squid"
    ad_group_label = "clam"

    expected = "customers/{customer}/adGroupLabels/{ad_group_label}".format(customer=customer, ad_group_label=ad_group_label, )
    actual = BatchJobServiceClient.ad_group_label_path(customer, ad_group_label)
    assert expected == actual


def test_parse_ad_group_label_path():
    expected = {
    "customer": "whelk",
    "ad_group_label": "octopus",

    }
    path = BatchJobServiceClient.ad_group_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_label_path(path)
    assert expected == actual

def test_ad_parameter_path():
    customer = "oyster"
    ad_parameter = "nudibranch"

    expected = "customers/{customer}/adParameters/{ad_parameter}".format(customer=customer, ad_parameter=ad_parameter, )
    actual = BatchJobServiceClient.ad_parameter_path(customer, ad_parameter)
    assert expected == actual


def test_parse_ad_parameter_path():
    expected = {
    "customer": "cuttlefish",
    "ad_parameter": "mussel",

    }
    path = BatchJobServiceClient.ad_parameter_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_parameter_path(path)
    assert expected == actual

def test_asset_path():
    customer = "winkle"
    asset = "nautilus"

    expected = "customers/{customer}/assets/{asset}".format(customer=customer, asset=asset, )
    actual = BatchJobServiceClient.asset_path(customer, asset)
    assert expected == actual


def test_parse_asset_path():
    expected = {
    "customer": "scallop",
    "asset": "abalone",

    }
    path = BatchJobServiceClient.asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_path(path)
    assert expected == actual

def test_batch_job_path():
    customer = "squid"
    batch_job = "clam"

    expected = "customers/{customer}/batchJobs/{batch_job}".format(customer=customer, batch_job=batch_job, )
    actual = BatchJobServiceClient.batch_job_path(customer, batch_job)
    assert expected == actual


def test_parse_batch_job_path():
    expected = {
    "customer": "whelk",
    "batch_job": "octopus",

    }
    path = BatchJobServiceClient.batch_job_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_batch_job_path(path)
    assert expected == actual

def test_bidding_strategy_path():
    customer = "oyster"
    bidding_strategy = "nudibranch"

    expected = "customers/{customer}/biddingStrategies/{bidding_strategy}".format(customer=customer, bidding_strategy=bidding_strategy, )
    actual = BatchJobServiceClient.bidding_strategy_path(customer, bidding_strategy)
    assert expected == actual


def test_parse_bidding_strategy_path():
    expected = {
    "customer": "cuttlefish",
    "bidding_strategy": "mussel",

    }
    path = BatchJobServiceClient.bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_bidding_strategy_path(path)
    assert expected == actual

def test_campaign_path():
    customer = "winkle"
    campaign = "nautilus"

    expected = "customers/{customer}/campaigns/{campaign}".format(customer=customer, campaign=campaign, )
    actual = BatchJobServiceClient.campaign_path(customer, campaign)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
    "customer": "scallop",
    "campaign": "abalone",

    }
    path = BatchJobServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_bid_modifier_path():
    customer = "squid"
    campaign_bid_modifier = "clam"

    expected = "customers/{customer}/campaignBidModifiers/{campaign_bid_modifier}".format(customer=customer, campaign_bid_modifier=campaign_bid_modifier, )
    actual = BatchJobServiceClient.campaign_bid_modifier_path(customer, campaign_bid_modifier)
    assert expected == actual


def test_parse_campaign_bid_modifier_path():
    expected = {
    "customer": "whelk",
    "campaign_bid_modifier": "octopus",

    }
    path = BatchJobServiceClient.campaign_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_bid_modifier_path(path)
    assert expected == actual

def test_campaign_budget_path():
    customer = "oyster"
    campaign_budget = "nudibranch"

    expected = "customers/{customer}/campaignBudgets/{campaign_budget}".format(customer=customer, campaign_budget=campaign_budget, )
    actual = BatchJobServiceClient.campaign_budget_path(customer, campaign_budget)
    assert expected == actual


def test_parse_campaign_budget_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_budget": "mussel",

    }
    path = BatchJobServiceClient.campaign_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_budget_path(path)
    assert expected == actual

def test_campaign_criterion_path():
    customer = "winkle"
    campaign_criterion = "nautilus"

    expected = "customers/{customer}/campaignCriteria/{campaign_criterion}".format(customer=customer, campaign_criterion=campaign_criterion, )
    actual = BatchJobServiceClient.campaign_criterion_path(customer, campaign_criterion)
    assert expected == actual


def test_parse_campaign_criterion_path():
    expected = {
    "customer": "scallop",
    "campaign_criterion": "abalone",

    }
    path = BatchJobServiceClient.campaign_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_criterion_path(path)
    assert expected == actual

def test_campaign_draft_path():
    customer = "squid"
    campaign_draft = "clam"

    expected = "customers/{customer}/campaignDrafts/{campaign_draft}".format(customer=customer, campaign_draft=campaign_draft, )
    actual = BatchJobServiceClient.campaign_draft_path(customer, campaign_draft)
    assert expected == actual


def test_parse_campaign_draft_path():
    expected = {
    "customer": "whelk",
    "campaign_draft": "octopus",

    }
    path = BatchJobServiceClient.campaign_draft_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_draft_path(path)
    assert expected == actual

def test_campaign_experiment_path():
    customer = "oyster"
    campaign_experiment = "nudibranch"

    expected = "customers/{customer}/campaignExperiments/{campaign_experiment}".format(customer=customer, campaign_experiment=campaign_experiment, )
    actual = BatchJobServiceClient.campaign_experiment_path(customer, campaign_experiment)
    assert expected == actual


def test_parse_campaign_experiment_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_experiment": "mussel",

    }
    path = BatchJobServiceClient.campaign_experiment_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_experiment_path(path)
    assert expected == actual

def test_campaign_extension_setting_path():
    customer = "winkle"
    campaign_extension_setting = "nautilus"

    expected = "customers/{customer}/campaignExtensionSettings/{campaign_extension_setting}".format(customer=customer, campaign_extension_setting=campaign_extension_setting, )
    actual = BatchJobServiceClient.campaign_extension_setting_path(customer, campaign_extension_setting)
    assert expected == actual


def test_parse_campaign_extension_setting_path():
    expected = {
    "customer": "scallop",
    "campaign_extension_setting": "abalone",

    }
    path = BatchJobServiceClient.campaign_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_extension_setting_path(path)
    assert expected == actual

def test_campaign_feed_path():
    customer = "squid"
    campaign_feed = "clam"

    expected = "customers/{customer}/campaignFeeds/{campaign_feed}".format(customer=customer, campaign_feed=campaign_feed, )
    actual = BatchJobServiceClient.campaign_feed_path(customer, campaign_feed)
    assert expected == actual


def test_parse_campaign_feed_path():
    expected = {
    "customer": "whelk",
    "campaign_feed": "octopus",

    }
    path = BatchJobServiceClient.campaign_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_feed_path(path)
    assert expected == actual

def test_campaign_label_path():
    customer = "oyster"
    campaign_label = "nudibranch"

    expected = "customers/{customer}/campaignLabels/{campaign_label}".format(customer=customer, campaign_label=campaign_label, )
    actual = BatchJobServiceClient.campaign_label_path(customer, campaign_label)
    assert expected == actual


def test_parse_campaign_label_path():
    expected = {
    "customer": "cuttlefish",
    "campaign_label": "mussel",

    }
    path = BatchJobServiceClient.campaign_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_label_path(path)
    assert expected == actual

def test_campaign_shared_set_path():
    customer = "winkle"
    campaign_shared_set = "nautilus"

    expected = "customers/{customer}/campaignSharedSets/{campaign_shared_set}".format(customer=customer, campaign_shared_set=campaign_shared_set, )
    actual = BatchJobServiceClient.campaign_shared_set_path(customer, campaign_shared_set)
    assert expected == actual


def test_parse_campaign_shared_set_path():
    expected = {
    "customer": "scallop",
    "campaign_shared_set": "abalone",

    }
    path = BatchJobServiceClient.campaign_shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_shared_set_path(path)
    assert expected == actual

def test_conversion_action_path():
    customer = "squid"
    conversion_action = "clam"

    expected = "customers/{customer}/conversionActions/{conversion_action}".format(customer=customer, conversion_action=conversion_action, )
    actual = BatchJobServiceClient.conversion_action_path(customer, conversion_action)
    assert expected == actual


def test_parse_conversion_action_path():
    expected = {
    "customer": "whelk",
    "conversion_action": "octopus",

    }
    path = BatchJobServiceClient.conversion_action_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_action_path(path)
    assert expected == actual

def test_customer_path():
    customer = "oyster"

    expected = "customers/{customer}".format(customer=customer, )
    actual = BatchJobServiceClient.customer_path(customer)
    assert expected == actual


def test_parse_customer_path():
    expected = {
    "customer": "nudibranch",

    }
    path = BatchJobServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_path(path)
    assert expected == actual

def test_customer_extension_setting_path():
    customer = "cuttlefish"
    customer_extension_setting = "mussel"

    expected = "customers/{customer}/customerExtensionSettings/{customer_extension_setting}".format(customer=customer, customer_extension_setting=customer_extension_setting, )
    actual = BatchJobServiceClient.customer_extension_setting_path(customer, customer_extension_setting)
    assert expected == actual


def test_parse_customer_extension_setting_path():
    expected = {
    "customer": "winkle",
    "customer_extension_setting": "nautilus",

    }
    path = BatchJobServiceClient.customer_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_extension_setting_path(path)
    assert expected == actual

def test_customer_feed_path():
    customer = "scallop"
    customer_feed = "abalone"

    expected = "customers/{customer}/customerFeeds/{customer_feed}".format(customer=customer, customer_feed=customer_feed, )
    actual = BatchJobServiceClient.customer_feed_path(customer, customer_feed)
    assert expected == actual


def test_parse_customer_feed_path():
    expected = {
    "customer": "squid",
    "customer_feed": "clam",

    }
    path = BatchJobServiceClient.customer_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_feed_path(path)
    assert expected == actual

def test_customer_label_path():
    customer = "whelk"
    customer_label = "octopus"

    expected = "customers/{customer}/customerLabels/{customer_label}".format(customer=customer, customer_label=customer_label, )
    actual = BatchJobServiceClient.customer_label_path(customer, customer_label)
    assert expected == actual


def test_parse_customer_label_path():
    expected = {
    "customer": "oyster",
    "customer_label": "nudibranch",

    }
    path = BatchJobServiceClient.customer_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_label_path(path)
    assert expected == actual

def test_customer_negative_criterion_path():
    customer = "cuttlefish"
    customer_negative_criterion = "mussel"

    expected = "customers/{customer}/customerNegativeCriteria/{customer_negative_criterion}".format(customer=customer, customer_negative_criterion=customer_negative_criterion, )
    actual = BatchJobServiceClient.customer_negative_criterion_path(customer, customer_negative_criterion)
    assert expected == actual


def test_parse_customer_negative_criterion_path():
    expected = {
    "customer": "winkle",
    "customer_negative_criterion": "nautilus",

    }
    path = BatchJobServiceClient.customer_negative_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_negative_criterion_path(path)
    assert expected == actual

def test_extension_feed_item_path():
    customer = "scallop"
    extension_feed_item = "abalone"

    expected = "customers/{customer}/extensionFeedItems/{extension_feed_item}".format(customer=customer, extension_feed_item=extension_feed_item, )
    actual = BatchJobServiceClient.extension_feed_item_path(customer, extension_feed_item)
    assert expected == actual


def test_parse_extension_feed_item_path():
    expected = {
    "customer": "squid",
    "extension_feed_item": "clam",

    }
    path = BatchJobServiceClient.extension_feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_extension_feed_item_path(path)
    assert expected == actual

def test_feed_path():
    customer = "whelk"
    feed = "octopus"

    expected = "customers/{customer}/feeds/{feed}".format(customer=customer, feed=feed, )
    actual = BatchJobServiceClient.feed_path(customer, feed)
    assert expected == actual


def test_parse_feed_path():
    expected = {
    "customer": "oyster",
    "feed": "nudibranch",

    }
    path = BatchJobServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_path(path)
    assert expected == actual

def test_feed_item_path():
    customer = "cuttlefish"
    feed_item = "mussel"

    expected = "customers/{customer}/feedItems/{feed_item}".format(customer=customer, feed_item=feed_item, )
    actual = BatchJobServiceClient.feed_item_path(customer, feed_item)
    assert expected == actual


def test_parse_feed_item_path():
    expected = {
    "customer": "winkle",
    "feed_item": "nautilus",

    }
    path = BatchJobServiceClient.feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_path(path)
    assert expected == actual

def test_feed_item_target_path():
    customer = "scallop"
    feed_item_target = "abalone"

    expected = "customers/{customer}/feedItemTargets/{feed_item_target}".format(customer=customer, feed_item_target=feed_item_target, )
    actual = BatchJobServiceClient.feed_item_target_path(customer, feed_item_target)
    assert expected == actual


def test_parse_feed_item_target_path():
    expected = {
    "customer": "squid",
    "feed_item_target": "clam",

    }
    path = BatchJobServiceClient.feed_item_target_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_target_path(path)
    assert expected == actual

def test_feed_mapping_path():
    customer = "whelk"
    feed_mapping = "octopus"

    expected = "customers/{customer}/feedMappings/{feed_mapping}".format(customer=customer, feed_mapping=feed_mapping, )
    actual = BatchJobServiceClient.feed_mapping_path(customer, feed_mapping)
    assert expected == actual


def test_parse_feed_mapping_path():
    expected = {
    "customer": "oyster",
    "feed_mapping": "nudibranch",

    }
    path = BatchJobServiceClient.feed_mapping_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_mapping_path(path)
    assert expected == actual

def test_geo_target_constant_path():
    geo_target_constant = "cuttlefish"

    expected = "geoTargetConstants/{geo_target_constant}".format(geo_target_constant=geo_target_constant, )
    actual = BatchJobServiceClient.geo_target_constant_path(geo_target_constant)
    assert expected == actual


def test_parse_geo_target_constant_path():
    expected = {
    "geo_target_constant": "mussel",

    }
    path = BatchJobServiceClient.geo_target_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_geo_target_constant_path(path)
    assert expected == actual

def test_keyword_plan_path():
    customer = "winkle"
    keyword_plan = "nautilus"

    expected = "customers/{customer}/keywordPlans/{keyword_plan}".format(customer=customer, keyword_plan=keyword_plan, )
    actual = BatchJobServiceClient.keyword_plan_path(customer, keyword_plan)
    assert expected == actual


def test_parse_keyword_plan_path():
    expected = {
    "customer": "scallop",
    "keyword_plan": "abalone",

    }
    path = BatchJobServiceClient.keyword_plan_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_path():
    customer = "squid"
    keyword_plan_ad_group = "clam"

    expected = "customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}".format(customer=customer, keyword_plan_ad_group=keyword_plan_ad_group, )
    actual = BatchJobServiceClient.keyword_plan_ad_group_path(customer, keyword_plan_ad_group)
    assert expected == actual


def test_parse_keyword_plan_ad_group_path():
    expected = {
    "customer": "whelk",
    "keyword_plan_ad_group": "octopus",

    }
    path = BatchJobServiceClient.keyword_plan_ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_ad_group_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_keyword_path():
    customer = "oyster"
    keyword_plan_ad_group_keyword = "nudibranch"

    expected = "customers/{customer}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword}".format(customer=customer, keyword_plan_ad_group_keyword=keyword_plan_ad_group_keyword, )
    actual = BatchJobServiceClient.keyword_plan_ad_group_keyword_path(customer, keyword_plan_ad_group_keyword)
    assert expected == actual


def test_parse_keyword_plan_ad_group_keyword_path():
    expected = {
    "customer": "cuttlefish",
    "keyword_plan_ad_group_keyword": "mussel",

    }
    path = BatchJobServiceClient.keyword_plan_ad_group_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_ad_group_keyword_path(path)
    assert expected == actual

def test_keyword_plan_campaign_path():
    customer = "winkle"
    keyword_plan_campaign = "nautilus"

    expected = "customers/{customer}/keywordPlanCampaigns/{keyword_plan_campaign}".format(customer=customer, keyword_plan_campaign=keyword_plan_campaign, )
    actual = BatchJobServiceClient.keyword_plan_campaign_path(customer, keyword_plan_campaign)
    assert expected == actual


def test_parse_keyword_plan_campaign_path():
    expected = {
    "customer": "scallop",
    "keyword_plan_campaign": "abalone",

    }
    path = BatchJobServiceClient.keyword_plan_campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_campaign_path(path)
    assert expected == actual

def test_keyword_plan_campaign_keyword_path():
    customer = "squid"
    keyword_plan_campaign_keyword = "clam"

    expected = "customers/{customer}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword}".format(customer=customer, keyword_plan_campaign_keyword=keyword_plan_campaign_keyword, )
    actual = BatchJobServiceClient.keyword_plan_campaign_keyword_path(customer, keyword_plan_campaign_keyword)
    assert expected == actual


def test_parse_keyword_plan_campaign_keyword_path():
    expected = {
    "customer": "whelk",
    "keyword_plan_campaign_keyword": "octopus",

    }
    path = BatchJobServiceClient.keyword_plan_campaign_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_campaign_keyword_path(path)
    assert expected == actual

def test_label_path():
    customer = "oyster"
    label = "nudibranch"

    expected = "customers/{customer}/labels/{label}".format(customer=customer, label=label, )
    actual = BatchJobServiceClient.label_path(customer, label)
    assert expected == actual


def test_parse_label_path():
    expected = {
    "customer": "cuttlefish",
    "label": "mussel",

    }
    path = BatchJobServiceClient.label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_label_path(path)
    assert expected == actual

def test_language_constant_path():
    language_constant = "winkle"

    expected = "languageConstants/{language_constant}".format(language_constant=language_constant, )
    actual = BatchJobServiceClient.language_constant_path(language_constant)
    assert expected == actual


def test_parse_language_constant_path():
    expected = {
    "language_constant": "nautilus",

    }
    path = BatchJobServiceClient.language_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_language_constant_path(path)
    assert expected == actual

def test_media_file_path():
    customer = "scallop"
    media_file = "abalone"

    expected = "customers/{customer}/mediaFiles/{media_file}".format(customer=customer, media_file=media_file, )
    actual = BatchJobServiceClient.media_file_path(customer, media_file)
    assert expected == actual


def test_parse_media_file_path():
    expected = {
    "customer": "squid",
    "media_file": "clam",

    }
    path = BatchJobServiceClient.media_file_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_media_file_path(path)
    assert expected == actual

def test_remarketing_action_path():
    customer = "whelk"
    remarketing_action = "octopus"

    expected = "customers/{customer}/remarketingActions/{remarketing_action}".format(customer=customer, remarketing_action=remarketing_action, )
    actual = BatchJobServiceClient.remarketing_action_path(customer, remarketing_action)
    assert expected == actual


def test_parse_remarketing_action_path():
    expected = {
    "customer": "oyster",
    "remarketing_action": "nudibranch",

    }
    path = BatchJobServiceClient.remarketing_action_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_remarketing_action_path(path)
    assert expected == actual

def test_shared_criterion_path():
    customer = "cuttlefish"
    shared_criterion = "mussel"

    expected = "customers/{customer}/sharedCriteria/{shared_criterion}".format(customer=customer, shared_criterion=shared_criterion, )
    actual = BatchJobServiceClient.shared_criterion_path(customer, shared_criterion)
    assert expected == actual


def test_parse_shared_criterion_path():
    expected = {
    "customer": "winkle",
    "shared_criterion": "nautilus",

    }
    path = BatchJobServiceClient.shared_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_shared_criterion_path(path)
    assert expected == actual

def test_shared_set_path():
    customer = "scallop"
    shared_set = "abalone"

    expected = "customers/{customer}/sharedSets/{shared_set}".format(customer=customer, shared_set=shared_set, )
    actual = BatchJobServiceClient.shared_set_path(customer, shared_set)
    assert expected == actual


def test_parse_shared_set_path():
    expected = {
    "customer": "squid",
    "shared_set": "clam",

    }
    path = BatchJobServiceClient.shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_shared_set_path(path)
    assert expected == actual

def test_user_list_path():
    customer = "whelk"
    user_list = "octopus"

    expected = "customers/{customer}/userLists/{user_list}".format(customer=customer, user_list=user_list, )
    actual = BatchJobServiceClient.user_list_path(customer, user_list)
    assert expected == actual


def test_parse_user_list_path():
    expected = {
    "customer": "oyster",
    "user_list": "nudibranch",

    }
    path = BatchJobServiceClient.user_list_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_user_list_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "cuttlefish"

    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = BatchJobServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
    "billing_account": "mussel",

    }
    path = BatchJobServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "winkle"

    expected = "folders/{folder}".format(folder=folder, )
    actual = BatchJobServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
    "folder": "nautilus",

    }
    path = BatchJobServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "scallop"

    expected = "organizations/{organization}".format(organization=organization, )
    actual = BatchJobServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
    "organization": "abalone",

    }
    path = BatchJobServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "squid"

    expected = "projects/{project}".format(project=project, )
    actual = BatchJobServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
    "project": "clam",

    }
    path = BatchJobServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "whelk"
    location = "octopus"

    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = BatchJobServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
    "project": "oyster",
    "location": "nudibranch",

    }
    path = BatchJobServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.BatchJobServiceTransport, '_prep_wrapped_messages') as prep:
        client = BatchJobServiceClient(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.BatchJobServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = BatchJobServiceClient.get_transport_class()
        transport = transport_class(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
