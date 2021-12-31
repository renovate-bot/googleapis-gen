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


from google.ads.googleads.v9.common.types import ad_asset
from google.ads.googleads.v9.common.types import ad_type_infos
from google.ads.googleads.v9.common.types import asset_policy
from google.ads.googleads.v9.common.types import asset_types
from google.ads.googleads.v9.common.types import bidding
from google.ads.googleads.v9.common.types import criteria
from google.ads.googleads.v9.common.types import custom_parameter
from google.ads.googleads.v9.common.types import customizer_value
from google.ads.googleads.v9.common.types import dates
from google.ads.googleads.v9.common.types import explorer_auto_optimizer_setting
from google.ads.googleads.v9.common.types import extensions
from google.ads.googleads.v9.common.types import feed_common
from google.ads.googleads.v9.common.types import feed_item_set_filter_type_infos
from google.ads.googleads.v9.common.types import final_app_url
from google.ads.googleads.v9.common.types import frequency_cap
from google.ads.googleads.v9.common.types import matching_function
from google.ads.googleads.v9.common.types import policy
from google.ads.googleads.v9.common.types import policy_summary
from google.ads.googleads.v9.common.types import real_time_bidding_setting
from google.ads.googleads.v9.common.types import tag_snippet
from google.ads.googleads.v9.common.types import targeting_setting
from google.ads.googleads.v9.common.types import text_label
from google.ads.googleads.v9.common.types import url_collection
from google.ads.googleads.v9.common.types import user_lists
from google.ads.googleads.v9.enums.types import access_reason
from google.ads.googleads.v9.enums.types import ad_customizer_placeholder_field
from google.ads.googleads.v9.enums.types import ad_group_ad_rotation_mode
from google.ads.googleads.v9.enums.types import ad_group_ad_status
from google.ads.googleads.v9.enums.types import ad_group_criterion_approval_status
from google.ads.googleads.v9.enums.types import ad_group_criterion_status
from google.ads.googleads.v9.enums.types import ad_group_status
from google.ads.googleads.v9.enums.types import ad_group_type
from google.ads.googleads.v9.enums.types import ad_serving_optimization_status
from google.ads.googleads.v9.enums.types import ad_strength
from google.ads.googleads.v9.enums.types import ad_type
from google.ads.googleads.v9.enums.types import advertising_channel_sub_type
from google.ads.googleads.v9.enums.types import advertising_channel_type
from google.ads.googleads.v9.enums.types import affiliate_location_feed_relationship_type
from google.ads.googleads.v9.enums.types import affiliate_location_placeholder_field
from google.ads.googleads.v9.enums.types import age_range_type
from google.ads.googleads.v9.enums.types import app_campaign_app_store
from google.ads.googleads.v9.enums.types import app_campaign_bidding_strategy_goal_type
from google.ads.googleads.v9.enums.types import app_payment_model_type
from google.ads.googleads.v9.enums.types import app_placeholder_field
from google.ads.googleads.v9.enums.types import app_store
from google.ads.googleads.v9.enums.types import app_url_operating_system_type
from google.ads.googleads.v9.enums.types import asset_field_type
from google.ads.googleads.v9.enums.types import asset_group_status
from google.ads.googleads.v9.enums.types import asset_link_status
from google.ads.googleads.v9.enums.types import asset_performance_label
from google.ads.googleads.v9.enums.types import asset_set_asset_status
from google.ads.googleads.v9.enums.types import asset_set_link_status
from google.ads.googleads.v9.enums.types import asset_set_status
from google.ads.googleads.v9.enums.types import asset_set_type
from google.ads.googleads.v9.enums.types import asset_type
from google.ads.googleads.v9.enums.types import attribution_model
from google.ads.googleads.v9.enums.types import bid_modifier_source
from google.ads.googleads.v9.enums.types import bidding_source
from google.ads.googleads.v9.enums.types import bidding_strategy_status
from google.ads.googleads.v9.enums.types import bidding_strategy_type
from google.ads.googleads.v9.enums.types import brand_safety_suitability
from google.ads.googleads.v9.enums.types import budget_delivery_method
from google.ads.googleads.v9.enums.types import budget_period
from google.ads.googleads.v9.enums.types import budget_status
from google.ads.googleads.v9.enums.types import budget_type
from google.ads.googleads.v9.enums.types import call_conversion_reporting_state
from google.ads.googleads.v9.enums.types import call_placeholder_field
from google.ads.googleads.v9.enums.types import call_to_action_type
from google.ads.googleads.v9.enums.types import callout_placeholder_field
from google.ads.googleads.v9.enums.types import campaign_criterion_status
from google.ads.googleads.v9.enums.types import campaign_draft_status
from google.ads.googleads.v9.enums.types import campaign_experiment_status
from google.ads.googleads.v9.enums.types import campaign_experiment_traffic_split_type
from google.ads.googleads.v9.enums.types import campaign_experiment_type
from google.ads.googleads.v9.enums.types import campaign_serving_status
from google.ads.googleads.v9.enums.types import campaign_shared_set_status
from google.ads.googleads.v9.enums.types import campaign_status
from google.ads.googleads.v9.enums.types import content_label_type
from google.ads.googleads.v9.enums.types import conversion_action_category
from google.ads.googleads.v9.enums.types import conversion_action_counting_type
from google.ads.googleads.v9.enums.types import conversion_action_status
from google.ads.googleads.v9.enums.types import conversion_action_type
from google.ads.googleads.v9.enums.types import conversion_custom_variable_status
from google.ads.googleads.v9.enums.types import conversion_origin
from google.ads.googleads.v9.enums.types import conversion_value_rule_set_status
from google.ads.googleads.v9.enums.types import conversion_value_rule_status
from google.ads.googleads.v9.enums.types import criterion_system_serving_status
from google.ads.googleads.v9.enums.types import criterion_type
from google.ads.googleads.v9.enums.types import custom_conversion_goal_status
from google.ads.googleads.v9.enums.types import custom_placeholder_field
from google.ads.googleads.v9.enums.types import customer_match_upload_key_type
from google.ads.googleads.v9.enums.types import customer_pay_per_conversion_eligibility_failure_reason
from google.ads.googleads.v9.enums.types import customizer_attribute_status
from google.ads.googleads.v9.enums.types import customizer_attribute_type
from google.ads.googleads.v9.enums.types import customizer_value_status
from google.ads.googleads.v9.enums.types import data_driven_model_status
from google.ads.googleads.v9.enums.types import day_of_week
from google.ads.googleads.v9.enums.types import device
from google.ads.googleads.v9.enums.types import display_ad_format_setting
from google.ads.googleads.v9.enums.types import display_upload_product_type
from google.ads.googleads.v9.enums.types import dsa_page_feed_criterion_field
from google.ads.googleads.v9.enums.types import education_placeholder_field
from google.ads.googleads.v9.enums.types import extension_setting_device
from google.ads.googleads.v9.enums.types import extension_type
from google.ads.googleads.v9.enums.types import feed_attribute_type
from google.ads.googleads.v9.enums.types import feed_item_quality_approval_status
from google.ads.googleads.v9.enums.types import feed_item_quality_disapproval_reason
from google.ads.googleads.v9.enums.types import feed_item_set_status
from google.ads.googleads.v9.enums.types import feed_item_set_string_filter_type
from google.ads.googleads.v9.enums.types import feed_item_status
from google.ads.googleads.v9.enums.types import feed_item_target_device
from google.ads.googleads.v9.enums.types import feed_item_target_status
from google.ads.googleads.v9.enums.types import feed_item_target_type
from google.ads.googleads.v9.enums.types import feed_item_validation_status
from google.ads.googleads.v9.enums.types import feed_link_status
from google.ads.googleads.v9.enums.types import feed_mapping_criterion_type
from google.ads.googleads.v9.enums.types import feed_mapping_status
from google.ads.googleads.v9.enums.types import feed_origin
from google.ads.googleads.v9.enums.types import feed_status
from google.ads.googleads.v9.enums.types import flight_placeholder_field
from google.ads.googleads.v9.enums.types import frequency_cap_event_type
from google.ads.googleads.v9.enums.types import frequency_cap_level
from google.ads.googleads.v9.enums.types import frequency_cap_time_unit
from google.ads.googleads.v9.enums.types import gender_type
from google.ads.googleads.v9.enums.types import geo_targeting_restriction
from google.ads.googleads.v9.enums.types import goal_config_level
from google.ads.googleads.v9.enums.types import hotel_date_selection_type
from google.ads.googleads.v9.enums.types import hotel_placeholder_field
from google.ads.googleads.v9.enums.types import image_placeholder_field
from google.ads.googleads.v9.enums.types import income_range_type
from google.ads.googleads.v9.enums.types import interaction_type
from google.ads.googleads.v9.enums.types import job_placeholder_field
from google.ads.googleads.v9.enums.types import keyword_match_type
from google.ads.googleads.v9.enums.types import keyword_plan_forecast_interval
from google.ads.googleads.v9.enums.types import keyword_plan_network
from google.ads.googleads.v9.enums.types import label_status
from google.ads.googleads.v9.enums.types import lead_form_call_to_action_type
from google.ads.googleads.v9.enums.types import lead_form_desired_intent
from google.ads.googleads.v9.enums.types import lead_form_field_user_input_type
from google.ads.googleads.v9.enums.types import lead_form_post_submit_call_to_action_type
from google.ads.googleads.v9.enums.types import legacy_app_install_ad_app_store
from google.ads.googleads.v9.enums.types import listing_group_filter_bidding_category_level
from google.ads.googleads.v9.enums.types import listing_group_filter_custom_attribute_index
from google.ads.googleads.v9.enums.types import listing_group_filter_product_channel
from google.ads.googleads.v9.enums.types import listing_group_filter_product_condition
from google.ads.googleads.v9.enums.types import listing_group_filter_product_type_level
from google.ads.googleads.v9.enums.types import listing_group_filter_type_enum
from google.ads.googleads.v9.enums.types import listing_group_filter_vertical
from google.ads.googleads.v9.enums.types import listing_group_type
from google.ads.googleads.v9.enums.types import local_placeholder_field
from google.ads.googleads.v9.enums.types import location_extension_targeting_criterion_field
from google.ads.googleads.v9.enums.types import location_group_radius_units
from google.ads.googleads.v9.enums.types import location_placeholder_field
from google.ads.googleads.v9.enums.types import location_source_type
from google.ads.googleads.v9.enums.types import matching_function_context_type
from google.ads.googleads.v9.enums.types import matching_function_operator
from google.ads.googleads.v9.enums.types import media_type
from google.ads.googleads.v9.enums.types import message_placeholder_field
from google.ads.googleads.v9.enums.types import mime_type
from google.ads.googleads.v9.enums.types import minute_of_hour
from google.ads.googleads.v9.enums.types import mobile_app_vendor
from google.ads.googleads.v9.enums.types import negative_geo_target_type
from google.ads.googleads.v9.enums.types import optimization_goal_type
from google.ads.googleads.v9.enums.types import parental_status_type
from google.ads.googleads.v9.enums.types import payment_mode
from google.ads.googleads.v9.enums.types import placeholder_type
from google.ads.googleads.v9.enums.types import policy_approval_status
from google.ads.googleads.v9.enums.types import policy_review_status
from google.ads.googleads.v9.enums.types import policy_topic_entry_type
from google.ads.googleads.v9.enums.types import policy_topic_evidence_destination_mismatch_url_type
from google.ads.googleads.v9.enums.types import policy_topic_evidence_destination_not_working_device
from google.ads.googleads.v9.enums.types import policy_topic_evidence_destination_not_working_dns_error_type
from google.ads.googleads.v9.enums.types import positive_geo_target_type
from google.ads.googleads.v9.enums.types import preferred_content_type
from google.ads.googleads.v9.enums.types import price_extension_price_qualifier
from google.ads.googleads.v9.enums.types import price_extension_price_unit
from google.ads.googleads.v9.enums.types import price_extension_type
from google.ads.googleads.v9.enums.types import price_placeholder_field
from google.ads.googleads.v9.enums.types import product_bidding_category_level
from google.ads.googleads.v9.enums.types import product_channel
from google.ads.googleads.v9.enums.types import product_channel_exclusivity
from google.ads.googleads.v9.enums.types import product_condition
from google.ads.googleads.v9.enums.types import product_custom_attribute_index
from google.ads.googleads.v9.enums.types import product_type_level
from google.ads.googleads.v9.enums.types import promotion_extension_discount_modifier
from google.ads.googleads.v9.enums.types import promotion_extension_occasion
from google.ads.googleads.v9.enums.types import promotion_placeholder_field
from google.ads.googleads.v9.enums.types import proximity_radius_units
from google.ads.googleads.v9.enums.types import quality_score_bucket
from google.ads.googleads.v9.enums.types import real_estate_placeholder_field
from google.ads.googleads.v9.enums.types import response_content_type
from google.ads.googleads.v9.enums.types import seasonality_event_scope
from google.ads.googleads.v9.enums.types import seasonality_event_status
from google.ads.googleads.v9.enums.types import served_asset_field_type
from google.ads.googleads.v9.enums.types import shared_set_status
from google.ads.googleads.v9.enums.types import shared_set_type
from google.ads.googleads.v9.enums.types import sitelink_placeholder_field
from google.ads.googleads.v9.enums.types import structured_snippet_placeholder_field
from google.ads.googleads.v9.enums.types import summary_row_setting
from google.ads.googleads.v9.enums.types import system_managed_entity_source
from google.ads.googleads.v9.enums.types import target_impression_share_location
from google.ads.googleads.v9.enums.types import targeting_dimension
from google.ads.googleads.v9.enums.types import tracking_code_page_format
from google.ads.googleads.v9.enums.types import tracking_code_type
from google.ads.googleads.v9.enums.types import travel_placeholder_field
from google.ads.googleads.v9.enums.types import user_list_access_status
from google.ads.googleads.v9.enums.types import user_list_closing_reason
from google.ads.googleads.v9.enums.types import user_list_combined_rule_operator
from google.ads.googleads.v9.enums.types import user_list_crm_data_source_type
from google.ads.googleads.v9.enums.types import user_list_date_rule_item_operator
from google.ads.googleads.v9.enums.types import user_list_logical_rule_operator
from google.ads.googleads.v9.enums.types import user_list_membership_status
from google.ads.googleads.v9.enums.types import user_list_number_rule_item_operator
from google.ads.googleads.v9.enums.types import user_list_prepopulation_status
from google.ads.googleads.v9.enums.types import user_list_rule_type
from google.ads.googleads.v9.enums.types import user_list_size_range
from google.ads.googleads.v9.enums.types import user_list_string_rule_item_operator
from google.ads.googleads.v9.enums.types import user_list_type
from google.ads.googleads.v9.enums.types import value_rule_device_type
from google.ads.googleads.v9.enums.types import value_rule_geo_location_match_type
from google.ads.googleads.v9.enums.types import value_rule_operation
from google.ads.googleads.v9.enums.types import value_rule_set_attachment_type
from google.ads.googleads.v9.enums.types import value_rule_set_dimension
from google.ads.googleads.v9.enums.types import vanity_pharma_display_url_mode
from google.ads.googleads.v9.enums.types import vanity_pharma_text
from google.ads.googleads.v9.enums.types import video_thumbnail
from google.ads.googleads.v9.enums.types import webpage_condition_operand
from google.ads.googleads.v9.enums.types import webpage_condition_operator
from google.ads.googleads.v9.errors.types import feed_item_validation_error
from google.ads.googleads.v9.resources.types import ad
from google.ads.googleads.v9.resources.types import ad_group
from google.ads.googleads.v9.resources.types import ad_group_ad
from google.ads.googleads.v9.resources.types import ad_group_ad_label
from google.ads.googleads.v9.resources.types import ad_group_asset
from google.ads.googleads.v9.resources.types import ad_group_bid_modifier
from google.ads.googleads.v9.resources.types import ad_group_criterion
from google.ads.googleads.v9.resources.types import ad_group_criterion_customizer
from google.ads.googleads.v9.resources.types import ad_group_criterion_label
from google.ads.googleads.v9.resources.types import ad_group_customizer
from google.ads.googleads.v9.resources.types import ad_group_extension_setting
from google.ads.googleads.v9.resources.types import ad_group_feed
from google.ads.googleads.v9.resources.types import ad_group_label
from google.ads.googleads.v9.resources.types import ad_parameter
from google.ads.googleads.v9.resources.types import asset
from google.ads.googleads.v9.resources.types import asset_group
from google.ads.googleads.v9.resources.types import asset_group_asset
from google.ads.googleads.v9.resources.types import asset_group_listing_group_filter
from google.ads.googleads.v9.resources.types import asset_set
from google.ads.googleads.v9.resources.types import asset_set_asset
from google.ads.googleads.v9.resources.types import bidding_data_exclusion
from google.ads.googleads.v9.resources.types import bidding_seasonality_adjustment
from google.ads.googleads.v9.resources.types import bidding_strategy
from google.ads.googleads.v9.resources.types import campaign
from google.ads.googleads.v9.resources.types import campaign_asset
from google.ads.googleads.v9.resources.types import campaign_asset_set
from google.ads.googleads.v9.resources.types import campaign_bid_modifier
from google.ads.googleads.v9.resources.types import campaign_budget
from google.ads.googleads.v9.resources.types import campaign_conversion_goal
from google.ads.googleads.v9.resources.types import campaign_criterion
from google.ads.googleads.v9.resources.types import campaign_customizer
from google.ads.googleads.v9.resources.types import campaign_draft
from google.ads.googleads.v9.resources.types import campaign_experiment
from google.ads.googleads.v9.resources.types import campaign_extension_setting
from google.ads.googleads.v9.resources.types import campaign_feed
from google.ads.googleads.v9.resources.types import campaign_label
from google.ads.googleads.v9.resources.types import campaign_shared_set
from google.ads.googleads.v9.resources.types import conversion_action
from google.ads.googleads.v9.resources.types import conversion_custom_variable
from google.ads.googleads.v9.resources.types import conversion_goal_campaign_config
from google.ads.googleads.v9.resources.types import conversion_value_rule
from google.ads.googleads.v9.resources.types import conversion_value_rule_set
from google.ads.googleads.v9.resources.types import custom_conversion_goal
from google.ads.googleads.v9.resources.types import customer
from google.ads.googleads.v9.resources.types import customer_asset
from google.ads.googleads.v9.resources.types import customer_conversion_goal
from google.ads.googleads.v9.resources.types import customer_customizer
from google.ads.googleads.v9.resources.types import customer_extension_setting
from google.ads.googleads.v9.resources.types import customer_feed
from google.ads.googleads.v9.resources.types import customer_label
from google.ads.googleads.v9.resources.types import customer_negative_criterion
from google.ads.googleads.v9.resources.types import customizer_attribute
from google.ads.googleads.v9.resources.types import extension_feed_item
from google.ads.googleads.v9.resources.types import feed
from google.ads.googleads.v9.resources.types import feed_item
from google.ads.googleads.v9.resources.types import feed_item_set
from google.ads.googleads.v9.resources.types import feed_item_set_link
from google.ads.googleads.v9.resources.types import feed_item_target
from google.ads.googleads.v9.resources.types import feed_mapping
from google.ads.googleads.v9.resources.types import keyword_plan
from google.ads.googleads.v9.resources.types import keyword_plan_ad_group
from google.ads.googleads.v9.resources.types import keyword_plan_ad_group_keyword
from google.ads.googleads.v9.resources.types import keyword_plan_campaign
from google.ads.googleads.v9.resources.types import keyword_plan_campaign_keyword
from google.ads.googleads.v9.resources.types import label
from google.ads.googleads.v9.resources.types import media_file
from google.ads.googleads.v9.resources.types import remarketing_action
from google.ads.googleads.v9.resources.types import shared_criterion
from google.ads.googleads.v9.resources.types import shared_set
from google.ads.googleads.v9.resources.types import smart_campaign_setting
from google.ads.googleads.v9.resources.types import user_list
from google.ads.googleads.v9.services.services.google_ads_service import GoogleAdsServiceClient
from google.ads.googleads.v9.services.services.google_ads_service import pagers
from google.ads.googleads.v9.services.services.google_ads_service import transports
from google.ads.googleads.v9.services.types import ad_group_ad_label_service
from google.ads.googleads.v9.services.types import ad_group_ad_service
from google.ads.googleads.v9.services.types import ad_group_asset_service
from google.ads.googleads.v9.services.types import ad_group_bid_modifier_service
from google.ads.googleads.v9.services.types import ad_group_criterion_customizer_service
from google.ads.googleads.v9.services.types import ad_group_criterion_label_service
from google.ads.googleads.v9.services.types import ad_group_criterion_service
from google.ads.googleads.v9.services.types import ad_group_customizer_service
from google.ads.googleads.v9.services.types import ad_group_extension_setting_service
from google.ads.googleads.v9.services.types import ad_group_feed_service
from google.ads.googleads.v9.services.types import ad_group_label_service
from google.ads.googleads.v9.services.types import ad_group_service
from google.ads.googleads.v9.services.types import ad_parameter_service
from google.ads.googleads.v9.services.types import ad_service
from google.ads.googleads.v9.services.types import asset_group_asset_service
from google.ads.googleads.v9.services.types import asset_group_listing_group_filter_service
from google.ads.googleads.v9.services.types import asset_group_service
from google.ads.googleads.v9.services.types import asset_service
from google.ads.googleads.v9.services.types import asset_set_asset_service
from google.ads.googleads.v9.services.types import asset_set_service
from google.ads.googleads.v9.services.types import bidding_data_exclusion_service
from google.ads.googleads.v9.services.types import bidding_seasonality_adjustment_service
from google.ads.googleads.v9.services.types import bidding_strategy_service
from google.ads.googleads.v9.services.types import campaign_asset_service
from google.ads.googleads.v9.services.types import campaign_asset_set_service
from google.ads.googleads.v9.services.types import campaign_bid_modifier_service
from google.ads.googleads.v9.services.types import campaign_budget_service
from google.ads.googleads.v9.services.types import campaign_conversion_goal_service
from google.ads.googleads.v9.services.types import campaign_criterion_service
from google.ads.googleads.v9.services.types import campaign_customizer_service
from google.ads.googleads.v9.services.types import campaign_draft_service
from google.ads.googleads.v9.services.types import campaign_experiment_service
from google.ads.googleads.v9.services.types import campaign_extension_setting_service
from google.ads.googleads.v9.services.types import campaign_feed_service
from google.ads.googleads.v9.services.types import campaign_label_service
from google.ads.googleads.v9.services.types import campaign_service
from google.ads.googleads.v9.services.types import campaign_shared_set_service
from google.ads.googleads.v9.services.types import conversion_action_service
from google.ads.googleads.v9.services.types import conversion_custom_variable_service
from google.ads.googleads.v9.services.types import conversion_goal_campaign_config_service
from google.ads.googleads.v9.services.types import conversion_value_rule_service
from google.ads.googleads.v9.services.types import conversion_value_rule_set_service
from google.ads.googleads.v9.services.types import custom_conversion_goal_service
from google.ads.googleads.v9.services.types import customer_asset_service
from google.ads.googleads.v9.services.types import customer_conversion_goal_service
from google.ads.googleads.v9.services.types import customer_customizer_service
from google.ads.googleads.v9.services.types import customer_extension_setting_service
from google.ads.googleads.v9.services.types import customer_feed_service
from google.ads.googleads.v9.services.types import customer_label_service
from google.ads.googleads.v9.services.types import customer_negative_criterion_service
from google.ads.googleads.v9.services.types import customer_service
from google.ads.googleads.v9.services.types import customizer_attribute_service
from google.ads.googleads.v9.services.types import extension_feed_item_service
from google.ads.googleads.v9.services.types import feed_item_service
from google.ads.googleads.v9.services.types import feed_item_set_link_service
from google.ads.googleads.v9.services.types import feed_item_set_service
from google.ads.googleads.v9.services.types import feed_item_target_service
from google.ads.googleads.v9.services.types import feed_mapping_service
from google.ads.googleads.v9.services.types import feed_service
from google.ads.googleads.v9.services.types import google_ads_service
from google.ads.googleads.v9.services.types import keyword_plan_ad_group_keyword_service
from google.ads.googleads.v9.services.types import keyword_plan_ad_group_service
from google.ads.googleads.v9.services.types import keyword_plan_campaign_keyword_service
from google.ads.googleads.v9.services.types import keyword_plan_campaign_service
from google.ads.googleads.v9.services.types import keyword_plan_service
from google.ads.googleads.v9.services.types import label_service
from google.ads.googleads.v9.services.types import media_file_service
from google.ads.googleads.v9.services.types import remarketing_action_service
from google.ads.googleads.v9.services.types import shared_criterion_service
from google.ads.googleads.v9.services.types import shared_set_service
from google.ads.googleads.v9.services.types import smart_campaign_setting_service
from google.ads.googleads.v9.services.types import user_list_service
from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import path_template
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

    assert GoogleAdsServiceClient._get_default_mtls_endpoint(None) is None
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert GoogleAdsServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    GoogleAdsServiceClient,
])
def test_google_ads_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'googleads.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.GoogleAdsServiceGrpcTransport, "grpc"),
])
def test_google_ads_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    GoogleAdsServiceClient,
])
def test_google_ads_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_google_ads_service_client_get_transport_class():
    transport = GoogleAdsServiceClient.get_transport_class()
    available_transports = [
        transports.GoogleAdsServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = GoogleAdsServiceClient.get_transport_class("grpc")
    assert transport == transports.GoogleAdsServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (GoogleAdsServiceClient, transports.GoogleAdsServiceGrpcTransport, "grpc"),
])
@mock.patch.object(GoogleAdsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(GoogleAdsServiceClient))
def test_google_ads_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(GoogleAdsServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(GoogleAdsServiceClient, 'get_transport_class') as gtc:
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
    (GoogleAdsServiceClient, transports.GoogleAdsServiceGrpcTransport, "grpc", "true"),
    (GoogleAdsServiceClient, transports.GoogleAdsServiceGrpcTransport, "grpc", "false"),
])
@mock.patch.object(GoogleAdsServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(GoogleAdsServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_google_ads_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (GoogleAdsServiceClient, transports.GoogleAdsServiceGrpcTransport, "grpc"),
])
def test_google_ads_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (GoogleAdsServiceClient, transports.GoogleAdsServiceGrpcTransport, "grpc"),
])
def test_google_ads_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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

def test_google_ads_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v9.services.services.google_ads_service.transports.GoogleAdsServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = GoogleAdsServiceClient(
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
  google_ads_service.SearchGoogleAdsRequest,
  dict,
])
def test_search(request_type, transport: str = 'grpc'):
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_search_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search),
            '__call__') as call:
        client.search()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == google_ads_service.SearchGoogleAdsRequest()


def test_search_field_headers():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].query
        mock_val = 'query_value'
        assert arg == mock_val


def test_search_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.search(
            google_ads_service.SearchGoogleAdsRequest(),
            customer_id='customer_id_value',
            query='query_value',
        )


def test_search_pager(transport_name: str = "grpc"):
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
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


def test_search_pages(transport_name: str = "grpc"):
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
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


@pytest.mark.parametrize("request_type", [
  google_ads_service.SearchGoogleAdsStreamRequest,
  dict,
])
def test_search_stream(request_type, transport: str = 'grpc'):
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_search_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.search_stream),
            '__call__') as call:
        client.search_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == google_ads_service.SearchGoogleAdsStreamRequest()


def test_search_stream_field_headers():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].query
        mock_val = 'query_value'
        assert arg == mock_val


def test_search_stream_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.search_stream(
            google_ads_service.SearchGoogleAdsStreamRequest(),
            customer_id='customer_id_value',
            query='query_value',
        )


@pytest.mark.parametrize("request_type", [
  google_ads_service.MutateGoogleAdsRequest,
  dict,
])
def test_mutate(request_type, transport: str = 'grpc'):
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_mutate_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate),
            '__call__') as call:
        client.mutate()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == google_ads_service.MutateGoogleAdsRequest()


def test_mutate_field_headers():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].mutate_operations
        mock_val = [google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))]
        assert arg == mock_val


def test_mutate_flattened_error():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = GoogleAdsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = GoogleAdsServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = GoogleAdsServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = GoogleAdsServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.GoogleAdsServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


@pytest.mark.parametrize("transport_class", [
    transports.GoogleAdsServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.GoogleAdsServiceGrpcTransport,
    )

def test_google_ads_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.GoogleAdsServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_google_ads_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v9.services.services.google_ads_service.transports.GoogleAdsServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.GoogleAdsServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
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

    with pytest.raises(NotImplementedError):
        transport.close()


def test_google_ads_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.ads.googleads.v9.services.services.google_ads_service.transports.GoogleAdsServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.GoogleAdsServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/adwords',
),
            quota_project_id="octopus",
        )


def test_google_ads_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.ads.googleads.v9.services.services.google_ads_service.transports.GoogleAdsServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.GoogleAdsServiceTransport()
        adc.assert_called_once()


def test_google_ads_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        GoogleAdsServiceClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/adwords',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.GoogleAdsServiceGrpcTransport,
    ],
)
def test_google_ads_service_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/adwords',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.GoogleAdsServiceGrpcTransport, grpc_helpers),
    ],
)
def test_google_ads_service_transport_create_channel(transport_class, grpc_helpers):
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
            "googleads.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/adwords',
),
            scopes=["1", "2"],
            default_host="googleads.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class",
    [
      transports.GoogleAdsServiceGrpcTransport,
])
def test_google_ads_service_grpc_transport_client_cert_source_for_mtls(
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


def test_google_ads_service_host_no_port():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_google_ads_service_host_with_port():
    client = GoogleAdsServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'

def test_google_ads_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.GoogleAdsServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class",
    [
      transports.GoogleAdsServiceGrpcTransport,
    ])
def test_google_ads_service_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class",
    [
      transports.GoogleAdsServiceGrpcTransport,
    ])
def test_google_ads_service_transport_channel_mtls_with_adc(
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


def test_accessible_bidding_strategy_path():
    customer_id = "squid"
    bidding_strategy_id = "clam"
    expected = "customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = GoogleAdsServiceClient.accessible_bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_accessible_bidding_strategy_path():
    expected = {
        "customer_id": "whelk",
        "bidding_strategy_id": "octopus",
    }
    path = GoogleAdsServiceClient.accessible_bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_accessible_bidding_strategy_path(path)
    assert expected == actual

def test_account_budget_path():
    customer_id = "oyster"
    account_budget_id = "nudibranch"
    expected = "customers/{customer_id}/accountBudgets/{account_budget_id}".format(customer_id=customer_id, account_budget_id=account_budget_id, )
    actual = GoogleAdsServiceClient.account_budget_path(customer_id, account_budget_id)
    assert expected == actual


def test_parse_account_budget_path():
    expected = {
        "customer_id": "cuttlefish",
        "account_budget_id": "mussel",
    }
    path = GoogleAdsServiceClient.account_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_budget_path(path)
    assert expected == actual

def test_account_budget_proposal_path():
    customer_id = "winkle"
    account_budget_proposal_id = "nautilus"
    expected = "customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}".format(customer_id=customer_id, account_budget_proposal_id=account_budget_proposal_id, )
    actual = GoogleAdsServiceClient.account_budget_proposal_path(customer_id, account_budget_proposal_id)
    assert expected == actual


def test_parse_account_budget_proposal_path():
    expected = {
        "customer_id": "scallop",
        "account_budget_proposal_id": "abalone",
    }
    path = GoogleAdsServiceClient.account_budget_proposal_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_budget_proposal_path(path)
    assert expected == actual

def test_account_link_path():
    customer_id = "squid"
    account_link_id = "clam"
    expected = "customers/{customer_id}/accountLinks/{account_link_id}".format(customer_id=customer_id, account_link_id=account_link_id, )
    actual = GoogleAdsServiceClient.account_link_path(customer_id, account_link_id)
    assert expected == actual


def test_parse_account_link_path():
    expected = {
        "customer_id": "whelk",
        "account_link_id": "octopus",
    }
    path = GoogleAdsServiceClient.account_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_account_link_path(path)
    assert expected == actual

def test_ad_path():
    customer_id = "oyster"
    ad_id = "nudibranch"
    expected = "customers/{customer_id}/ads/{ad_id}".format(customer_id=customer_id, ad_id=ad_id, )
    actual = GoogleAdsServiceClient.ad_path(customer_id, ad_id)
    assert expected == actual


def test_parse_ad_path():
    expected = {
        "customer_id": "cuttlefish",
        "ad_id": "mussel",
    }
    path = GoogleAdsServiceClient.ad_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_path(path)
    assert expected == actual

def test_ad_group_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    expected = "customers/{customer_id}/adGroups/{ad_group_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, )
    actual = GoogleAdsServiceClient.ad_group_path(customer_id, ad_group_id)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
        "customer_id": "scallop",
        "ad_group_id": "abalone",
    }
    path = GoogleAdsServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_ad_path():
    customer_id = "squid"
    ad_group_id = "clam"
    ad_id = "whelk"
    expected = "customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, )
    actual = GoogleAdsServiceClient.ad_group_ad_path(customer_id, ad_group_id, ad_id)
    assert expected == actual


def test_parse_ad_group_ad_path():
    expected = {
        "customer_id": "octopus",
        "ad_group_id": "oyster",
        "ad_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.ad_group_ad_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_path(path)
    assert expected == actual

def test_ad_group_ad_asset_view_path():
    customer_id = "cuttlefish"
    ad_group_id = "mussel"
    ad_id = "winkle"
    asset_id = "nautilus"
    field_type = "scallop"
    expected = "customers/{customer_id}/adGroupAdAssetViews/{ad_group_id}~{ad_id}~{asset_id}~{field_type}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, asset_id=asset_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.ad_group_ad_asset_view_path(customer_id, ad_group_id, ad_id, asset_id, field_type)
    assert expected == actual


def test_parse_ad_group_ad_asset_view_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "ad_id": "clam",
        "asset_id": "whelk",
        "field_type": "octopus",
    }
    path = GoogleAdsServiceClient.ad_group_ad_asset_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_asset_view_path(path)
    assert expected == actual

def test_ad_group_ad_label_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    ad_id = "cuttlefish"
    label_id = "mussel"
    expected = "customers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.ad_group_ad_label_path(customer_id, ad_group_id, ad_id, label_id)
    assert expected == actual


def test_parse_ad_group_ad_label_path():
    expected = {
        "customer_id": "winkle",
        "ad_group_id": "nautilus",
        "ad_id": "scallop",
        "label_id": "abalone",
    }
    path = GoogleAdsServiceClient.ad_group_ad_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_ad_label_path(path)
    assert expected == actual

def test_ad_group_asset_path():
    customer_id = "squid"
    ad_group_id = "clam"
    asset_id = "whelk"
    field_type = "octopus"
    expected = "customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}".format(customer_id=customer_id, ad_group_id=ad_group_id, asset_id=asset_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.ad_group_asset_path(customer_id, ad_group_id, asset_id, field_type)
    assert expected == actual


def test_parse_ad_group_asset_path():
    expected = {
        "customer_id": "oyster",
        "ad_group_id": "nudibranch",
        "asset_id": "cuttlefish",
        "field_type": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_asset_path(path)
    assert expected == actual

def test_ad_group_audience_view_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    criterion_id = "scallop"
    expected = "customers/{customer_id}/adGroupAudienceViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.ad_group_audience_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_audience_view_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "criterion_id": "clam",
    }
    path = GoogleAdsServiceClient.ad_group_audience_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_audience_view_path(path)
    assert expected == actual

def test_ad_group_bid_modifier_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    criterion_id = "oyster"
    expected = "customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.ad_group_bid_modifier_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_bid_modifier_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_bid_modifier_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    criterion_id = "scallop"
    expected = "customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.ad_group_criterion_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "criterion_id": "clam",
    }
    path = GoogleAdsServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_criterion_customizer_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    criterion_id = "oyster"
    customizer_attribute_id = "nudibranch"
    expected = "customers/{customer_id}/adGroupCriterionCustomizers/{ad_group_id}~{criterion_id}~{customizer_attribute_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, customizer_attribute_id=customizer_attribute_id, )
    actual = GoogleAdsServiceClient.ad_group_criterion_customizer_path(customer_id, ad_group_id, criterion_id, customizer_attribute_id)
    assert expected == actual


def test_parse_ad_group_criterion_customizer_path():
    expected = {
        "customer_id": "cuttlefish",
        "ad_group_id": "mussel",
        "criterion_id": "winkle",
        "customizer_attribute_id": "nautilus",
    }
    path = GoogleAdsServiceClient.ad_group_criterion_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_customizer_path(path)
    assert expected == actual

def test_ad_group_criterion_label_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    label_id = "clam"
    expected = "customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.ad_group_criterion_label_path(customer_id, ad_group_id, criterion_id, label_id)
    assert expected == actual


def test_parse_ad_group_criterion_label_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
        "criterion_id": "oyster",
        "label_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.ad_group_criterion_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_label_path(path)
    assert expected == actual

def test_ad_group_criterion_simulation_path():
    customer_id = "cuttlefish"
    ad_group_id = "mussel"
    criterion_id = "winkle"
    type = "nautilus"
    modification_method = "scallop"
    start_date = "abalone"
    end_date = "squid"
    expected = "customers/{customer_id}/adGroupCriterionSimulations/{ad_group_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, type=type, modification_method=modification_method, start_date=start_date, end_date=end_date, )
    actual = GoogleAdsServiceClient.ad_group_criterion_simulation_path(customer_id, ad_group_id, criterion_id, type, modification_method, start_date, end_date)
    assert expected == actual


def test_parse_ad_group_criterion_simulation_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
        "type": "oyster",
        "modification_method": "nudibranch",
        "start_date": "cuttlefish",
        "end_date": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_criterion_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_criterion_simulation_path(path)
    assert expected == actual

def test_ad_group_customizer_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    customizer_attribute_id = "scallop"
    expected = "customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, customizer_attribute_id=customizer_attribute_id, )
    actual = GoogleAdsServiceClient.ad_group_customizer_path(customer_id, ad_group_id, customizer_attribute_id)
    assert expected == actual


def test_parse_ad_group_customizer_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "customizer_attribute_id": "clam",
    }
    path = GoogleAdsServiceClient.ad_group_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_customizer_path(path)
    assert expected == actual

def test_ad_group_extension_setting_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    extension_type = "oyster"
    expected = "customers/{customer_id}/adGroupExtensionSettings/{ad_group_id}~{extension_type}".format(customer_id=customer_id, ad_group_id=ad_group_id, extension_type=extension_type, )
    actual = GoogleAdsServiceClient.ad_group_extension_setting_path(customer_id, ad_group_id, extension_type)
    assert expected == actual


def test_parse_ad_group_extension_setting_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "extension_type": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_extension_setting_path(path)
    assert expected == actual

def test_ad_group_feed_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    feed_id = "scallop"
    expected = "customers/{customer_id}/adGroupFeeds/{ad_group_id}~{feed_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, feed_id=feed_id, )
    actual = GoogleAdsServiceClient.ad_group_feed_path(customer_id, ad_group_id, feed_id)
    assert expected == actual


def test_parse_ad_group_feed_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "feed_id": "clam",
    }
    path = GoogleAdsServiceClient.ad_group_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_feed_path(path)
    assert expected == actual

def test_ad_group_label_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    label_id = "oyster"
    expected = "customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.ad_group_label_path(customer_id, ad_group_id, label_id)
    assert expected == actual


def test_parse_ad_group_label_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "label_id": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_label_path(path)
    assert expected == actual

def test_ad_group_simulation_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    type = "scallop"
    modification_method = "abalone"
    start_date = "squid"
    end_date = "clam"
    expected = "customers/{customer_id}/adGroupSimulations/{ad_group_id}~{type}~{modification_method}~{start_date}~{end_date}".format(customer_id=customer_id, ad_group_id=ad_group_id, type=type, modification_method=modification_method, start_date=start_date, end_date=end_date, )
    actual = GoogleAdsServiceClient.ad_group_simulation_path(customer_id, ad_group_id, type, modification_method, start_date, end_date)
    assert expected == actual


def test_parse_ad_group_simulation_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
        "type": "oyster",
        "modification_method": "nudibranch",
        "start_date": "cuttlefish",
        "end_date": "mussel",
    }
    path = GoogleAdsServiceClient.ad_group_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_group_simulation_path(path)
    assert expected == actual

def test_ad_parameter_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    criterion_id = "scallop"
    parameter_index = "abalone"
    expected = "customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, parameter_index=parameter_index, )
    actual = GoogleAdsServiceClient.ad_parameter_path(customer_id, ad_group_id, criterion_id, parameter_index)
    assert expected == actual


def test_parse_ad_parameter_path():
    expected = {
        "customer_id": "squid",
        "ad_group_id": "clam",
        "criterion_id": "whelk",
        "parameter_index": "octopus",
    }
    path = GoogleAdsServiceClient.ad_parameter_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_parameter_path(path)
    assert expected == actual

def test_ad_schedule_view_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/adScheduleViews/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.ad_schedule_view_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_ad_schedule_view_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.ad_schedule_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_ad_schedule_view_path(path)
    assert expected == actual

def test_age_range_view_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/ageRangeViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.age_range_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_age_range_view_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.age_range_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_age_range_view_path(path)
    assert expected == actual

def test_asset_path():
    customer_id = "oyster"
    asset_id = "nudibranch"
    expected = "customers/{customer_id}/assets/{asset_id}".format(customer_id=customer_id, asset_id=asset_id, )
    actual = GoogleAdsServiceClient.asset_path(customer_id, asset_id)
    assert expected == actual


def test_parse_asset_path():
    expected = {
        "customer_id": "cuttlefish",
        "asset_id": "mussel",
    }
    path = GoogleAdsServiceClient.asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_path(path)
    assert expected == actual

def test_asset_field_type_view_path():
    customer_id = "winkle"
    field_type = "nautilus"
    expected = "customers/{customer_id}/assetFieldTypeViews/{field_type}".format(customer_id=customer_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.asset_field_type_view_path(customer_id, field_type)
    assert expected == actual


def test_parse_asset_field_type_view_path():
    expected = {
        "customer_id": "scallop",
        "field_type": "abalone",
    }
    path = GoogleAdsServiceClient.asset_field_type_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_field_type_view_path(path)
    assert expected == actual

def test_asset_group_path():
    customer_id = "squid"
    asset_group_id = "clam"
    expected = "customers/{customer_id}/assetGroups/{asset_group_id}".format(customer_id=customer_id, asset_group_id=asset_group_id, )
    actual = GoogleAdsServiceClient.asset_group_path(customer_id, asset_group_id)
    assert expected == actual


def test_parse_asset_group_path():
    expected = {
        "customer_id": "whelk",
        "asset_group_id": "octopus",
    }
    path = GoogleAdsServiceClient.asset_group_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_group_path(path)
    assert expected == actual

def test_asset_group_asset_path():
    customer_id = "oyster"
    asset_group_id = "nudibranch"
    asset_id = "cuttlefish"
    field_type = "mussel"
    expected = "customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}".format(customer_id=customer_id, asset_group_id=asset_group_id, asset_id=asset_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.asset_group_asset_path(customer_id, asset_group_id, asset_id, field_type)
    assert expected == actual


def test_parse_asset_group_asset_path():
    expected = {
        "customer_id": "winkle",
        "asset_group_id": "nautilus",
        "asset_id": "scallop",
        "field_type": "abalone",
    }
    path = GoogleAdsServiceClient.asset_group_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_group_asset_path(path)
    assert expected == actual

def test_asset_group_listing_group_filter_path():
    customer_id = "squid"
    asset_group_id = "clam"
    listing_group_filter_id = "whelk"
    expected = "customers/{customer_id}/assetGroupListingGroupFilters/{asset_group_id}~{listing_group_filter_id}".format(customer_id=customer_id, asset_group_id=asset_group_id, listing_group_filter_id=listing_group_filter_id, )
    actual = GoogleAdsServiceClient.asset_group_listing_group_filter_path(customer_id, asset_group_id, listing_group_filter_id)
    assert expected == actual


def test_parse_asset_group_listing_group_filter_path():
    expected = {
        "customer_id": "octopus",
        "asset_group_id": "oyster",
        "listing_group_filter_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.asset_group_listing_group_filter_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_group_listing_group_filter_path(path)
    assert expected == actual

def test_asset_group_product_group_view_path():
    customer_id = "cuttlefish"
    asset_group_id = "mussel"
    listing_group_filter_id = "winkle"
    expected = "customers/{customer_id}/assetGroupProductGroupViews/{asset_group_id}~{listing_group_filter_id}".format(customer_id=customer_id, asset_group_id=asset_group_id, listing_group_filter_id=listing_group_filter_id, )
    actual = GoogleAdsServiceClient.asset_group_product_group_view_path(customer_id, asset_group_id, listing_group_filter_id)
    assert expected == actual


def test_parse_asset_group_product_group_view_path():
    expected = {
        "customer_id": "nautilus",
        "asset_group_id": "scallop",
        "listing_group_filter_id": "abalone",
    }
    path = GoogleAdsServiceClient.asset_group_product_group_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_group_product_group_view_path(path)
    assert expected == actual

def test_asset_set_path():
    customer_id = "squid"
    asset_set_id = "clam"
    expected = "customers/{customer_id}/assetSets/{asset_set_id}".format(customer_id=customer_id, asset_set_id=asset_set_id, )
    actual = GoogleAdsServiceClient.asset_set_path(customer_id, asset_set_id)
    assert expected == actual


def test_parse_asset_set_path():
    expected = {
        "customer_id": "whelk",
        "asset_set_id": "octopus",
    }
    path = GoogleAdsServiceClient.asset_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_set_path(path)
    assert expected == actual

def test_asset_set_asset_path():
    customer_id = "oyster"
    asset_set_id = "nudibranch"
    asset_id = "cuttlefish"
    expected = "customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}".format(customer_id=customer_id, asset_set_id=asset_set_id, asset_id=asset_id, )
    actual = GoogleAdsServiceClient.asset_set_asset_path(customer_id, asset_set_id, asset_id)
    assert expected == actual


def test_parse_asset_set_asset_path():
    expected = {
        "customer_id": "mussel",
        "asset_set_id": "winkle",
        "asset_id": "nautilus",
    }
    path = GoogleAdsServiceClient.asset_set_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_asset_set_asset_path(path)
    assert expected == actual

def test_batch_job_path():
    customer_id = "scallop"
    batch_job_id = "abalone"
    expected = "customers/{customer_id}/batchJobs/{batch_job_id}".format(customer_id=customer_id, batch_job_id=batch_job_id, )
    actual = GoogleAdsServiceClient.batch_job_path(customer_id, batch_job_id)
    assert expected == actual


def test_parse_batch_job_path():
    expected = {
        "customer_id": "squid",
        "batch_job_id": "clam",
    }
    path = GoogleAdsServiceClient.batch_job_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_batch_job_path(path)
    assert expected == actual

def test_bidding_data_exclusion_path():
    customer_id = "whelk"
    seasonality_event_id = "octopus"
    expected = "customers/{customer_id}/biddingDataExclusions/{seasonality_event_id}".format(customer_id=customer_id, seasonality_event_id=seasonality_event_id, )
    actual = GoogleAdsServiceClient.bidding_data_exclusion_path(customer_id, seasonality_event_id)
    assert expected == actual


def test_parse_bidding_data_exclusion_path():
    expected = {
        "customer_id": "oyster",
        "seasonality_event_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.bidding_data_exclusion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_bidding_data_exclusion_path(path)
    assert expected == actual

def test_bidding_seasonality_adjustment_path():
    customer_id = "cuttlefish"
    seasonality_event_id = "mussel"
    expected = "customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}".format(customer_id=customer_id, seasonality_event_id=seasonality_event_id, )
    actual = GoogleAdsServiceClient.bidding_seasonality_adjustment_path(customer_id, seasonality_event_id)
    assert expected == actual


def test_parse_bidding_seasonality_adjustment_path():
    expected = {
        "customer_id": "winkle",
        "seasonality_event_id": "nautilus",
    }
    path = GoogleAdsServiceClient.bidding_seasonality_adjustment_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_bidding_seasonality_adjustment_path(path)
    assert expected == actual

def test_bidding_strategy_path():
    customer_id = "scallop"
    bidding_strategy_id = "abalone"
    expected = "customers/{customer_id}/biddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = GoogleAdsServiceClient.bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_bidding_strategy_path():
    expected = {
        "customer_id": "squid",
        "bidding_strategy_id": "clam",
    }
    path = GoogleAdsServiceClient.bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_bidding_strategy_path(path)
    assert expected == actual

def test_bidding_strategy_simulation_path():
    customer_id = "whelk"
    bidding_strategy_id = "octopus"
    type = "oyster"
    modification_method = "nudibranch"
    start_date = "cuttlefish"
    end_date = "mussel"
    expected = "customers/{customer_id}/biddingStrategySimulations/{bidding_strategy_id}~{type}~{modification_method}~{start_date}~{end_date}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, type=type, modification_method=modification_method, start_date=start_date, end_date=end_date, )
    actual = GoogleAdsServiceClient.bidding_strategy_simulation_path(customer_id, bidding_strategy_id, type, modification_method, start_date, end_date)
    assert expected == actual


def test_parse_bidding_strategy_simulation_path():
    expected = {
        "customer_id": "winkle",
        "bidding_strategy_id": "nautilus",
        "type": "scallop",
        "modification_method": "abalone",
        "start_date": "squid",
        "end_date": "clam",
    }
    path = GoogleAdsServiceClient.bidding_strategy_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_bidding_strategy_simulation_path(path)
    assert expected == actual

def test_billing_setup_path():
    customer_id = "whelk"
    billing_setup_id = "octopus"
    expected = "customers/{customer_id}/billingSetups/{billing_setup_id}".format(customer_id=customer_id, billing_setup_id=billing_setup_id, )
    actual = GoogleAdsServiceClient.billing_setup_path(customer_id, billing_setup_id)
    assert expected == actual


def test_parse_billing_setup_path():
    expected = {
        "customer_id": "oyster",
        "billing_setup_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.billing_setup_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_billing_setup_path(path)
    assert expected == actual

def test_call_view_path():
    customer_id = "cuttlefish"
    call_detail_id = "mussel"
    expected = "customers/{customer_id}/callViews/{call_detail_id}".format(customer_id=customer_id, call_detail_id=call_detail_id, )
    actual = GoogleAdsServiceClient.call_view_path(customer_id, call_detail_id)
    assert expected == actual


def test_parse_call_view_path():
    expected = {
        "customer_id": "winkle",
        "call_detail_id": "nautilus",
    }
    path = GoogleAdsServiceClient.call_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_call_view_path(path)
    assert expected == actual

def test_campaign_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    expected = "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = GoogleAdsServiceClient.campaign_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
        "customer_id": "squid",
        "campaign_id": "clam",
    }
    path = GoogleAdsServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_asset_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    asset_id = "oyster"
    field_type = "nudibranch"
    expected = "customers/{customer_id}/campaignAssets/{campaign_id}~{asset_id}~{field_type}".format(customer_id=customer_id, campaign_id=campaign_id, asset_id=asset_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.campaign_asset_path(customer_id, campaign_id, asset_id, field_type)
    assert expected == actual


def test_parse_campaign_asset_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
        "asset_id": "winkle",
        "field_type": "nautilus",
    }
    path = GoogleAdsServiceClient.campaign_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_asset_path(path)
    assert expected == actual

def test_campaign_asset_set_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    asset_set_id = "squid"
    expected = "customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}".format(customer_id=customer_id, campaign_id=campaign_id, asset_set_id=asset_set_id, )
    actual = GoogleAdsServiceClient.campaign_asset_set_path(customer_id, campaign_id, asset_set_id)
    assert expected == actual


def test_parse_campaign_asset_set_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "asset_set_id": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_asset_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_asset_set_path(path)
    assert expected == actual

def test_campaign_audience_view_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignAudienceViews/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.campaign_audience_view_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_audience_view_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.campaign_audience_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_audience_view_path(path)
    assert expected == actual

def test_campaign_bid_modifier_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.campaign_bid_modifier_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_bid_modifier_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_bid_modifier_path(path)
    assert expected == actual

def test_campaign_budget_path():
    customer_id = "oyster"
    campaign_budget_id = "nudibranch"
    expected = "customers/{customer_id}/campaignBudgets/{campaign_budget_id}".format(customer_id=customer_id, campaign_budget_id=campaign_budget_id, )
    actual = GoogleAdsServiceClient.campaign_budget_path(customer_id, campaign_budget_id)
    assert expected == actual


def test_parse_campaign_budget_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_budget_id": "mussel",
    }
    path = GoogleAdsServiceClient.campaign_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_budget_path(path)
    assert expected == actual

def test_campaign_conversion_goal_path():
    customer_id = "winkle"
    campaign_id = "nautilus"
    category = "scallop"
    source = "abalone"
    expected = "customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}".format(customer_id=customer_id, campaign_id=campaign_id, category=category, source=source, )
    actual = GoogleAdsServiceClient.campaign_conversion_goal_path(customer_id, campaign_id, category, source)
    assert expected == actual


def test_parse_campaign_conversion_goal_path():
    expected = {
        "customer_id": "squid",
        "campaign_id": "clam",
        "category": "whelk",
        "source": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_conversion_goal_path(path)
    assert expected == actual

def test_campaign_criterion_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.campaign_criterion_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_criterion_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.campaign_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_criterion_path(path)
    assert expected == actual

def test_campaign_criterion_simulation_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    criterion_id = "squid"
    type = "clam"
    modification_method = "whelk"
    start_date = "octopus"
    end_date = "oyster"
    expected = "customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, type=type, modification_method=modification_method, start_date=start_date, end_date=end_date, )
    actual = GoogleAdsServiceClient.campaign_criterion_simulation_path(customer_id, campaign_id, criterion_id, type, modification_method, start_date, end_date)
    assert expected == actual


def test_parse_campaign_criterion_simulation_path():
    expected = {
        "customer_id": "nudibranch",
        "campaign_id": "cuttlefish",
        "criterion_id": "mussel",
        "type": "winkle",
        "modification_method": "nautilus",
        "start_date": "scallop",
        "end_date": "abalone",
    }
    path = GoogleAdsServiceClient.campaign_criterion_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_criterion_simulation_path(path)
    assert expected == actual

def test_campaign_customizer_path():
    customer_id = "squid"
    campaign_id = "clam"
    customizer_attribute_id = "whelk"
    expected = "customers/{customer_id}/campaignCustomizers/{campaign_id}~{customizer_attribute_id}".format(customer_id=customer_id, campaign_id=campaign_id, customizer_attribute_id=customizer_attribute_id, )
    actual = GoogleAdsServiceClient.campaign_customizer_path(customer_id, campaign_id, customizer_attribute_id)
    assert expected == actual


def test_parse_campaign_customizer_path():
    expected = {
        "customer_id": "octopus",
        "campaign_id": "oyster",
        "customizer_attribute_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.campaign_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_customizer_path(path)
    assert expected == actual

def test_campaign_draft_path():
    customer_id = "cuttlefish"
    base_campaign_id = "mussel"
    draft_id = "winkle"
    expected = "customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}".format(customer_id=customer_id, base_campaign_id=base_campaign_id, draft_id=draft_id, )
    actual = GoogleAdsServiceClient.campaign_draft_path(customer_id, base_campaign_id, draft_id)
    assert expected == actual


def test_parse_campaign_draft_path():
    expected = {
        "customer_id": "nautilus",
        "base_campaign_id": "scallop",
        "draft_id": "abalone",
    }
    path = GoogleAdsServiceClient.campaign_draft_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_draft_path(path)
    assert expected == actual

def test_campaign_experiment_path():
    customer_id = "squid"
    campaign_experiment_id = "clam"
    expected = "customers/{customer_id}/campaignExperiments/{campaign_experiment_id}".format(customer_id=customer_id, campaign_experiment_id=campaign_experiment_id, )
    actual = GoogleAdsServiceClient.campaign_experiment_path(customer_id, campaign_experiment_id)
    assert expected == actual


def test_parse_campaign_experiment_path():
    expected = {
        "customer_id": "whelk",
        "campaign_experiment_id": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_experiment_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_experiment_path(path)
    assert expected == actual

def test_campaign_extension_setting_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    extension_type = "cuttlefish"
    expected = "customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}".format(customer_id=customer_id, campaign_id=campaign_id, extension_type=extension_type, )
    actual = GoogleAdsServiceClient.campaign_extension_setting_path(customer_id, campaign_id, extension_type)
    assert expected == actual


def test_parse_campaign_extension_setting_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "extension_type": "nautilus",
    }
    path = GoogleAdsServiceClient.campaign_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_extension_setting_path(path)
    assert expected == actual

def test_campaign_feed_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    feed_id = "squid"
    expected = "customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}".format(customer_id=customer_id, campaign_id=campaign_id, feed_id=feed_id, )
    actual = GoogleAdsServiceClient.campaign_feed_path(customer_id, campaign_id, feed_id)
    assert expected == actual


def test_parse_campaign_feed_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "feed_id": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_feed_path(path)
    assert expected == actual

def test_campaign_label_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    label_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}".format(customer_id=customer_id, campaign_id=campaign_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.campaign_label_path(customer_id, campaign_id, label_id)
    assert expected == actual


def test_parse_campaign_label_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "label_id": "nautilus",
    }
    path = GoogleAdsServiceClient.campaign_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_label_path(path)
    assert expected == actual

def test_campaign_shared_set_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    shared_set_id = "squid"
    expected = "customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}".format(customer_id=customer_id, campaign_id=campaign_id, shared_set_id=shared_set_id, )
    actual = GoogleAdsServiceClient.campaign_shared_set_path(customer_id, campaign_id, shared_set_id)
    assert expected == actual


def test_parse_campaign_shared_set_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "shared_set_id": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_shared_set_path(path)
    assert expected == actual

def test_campaign_simulation_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    type = "cuttlefish"
    modification_method = "mussel"
    start_date = "winkle"
    end_date = "nautilus"
    expected = "customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}".format(customer_id=customer_id, campaign_id=campaign_id, type=type, modification_method=modification_method, start_date=start_date, end_date=end_date, )
    actual = GoogleAdsServiceClient.campaign_simulation_path(customer_id, campaign_id, type, modification_method, start_date, end_date)
    assert expected == actual


def test_parse_campaign_simulation_path():
    expected = {
        "customer_id": "scallop",
        "campaign_id": "abalone",
        "type": "squid",
        "modification_method": "clam",
        "start_date": "whelk",
        "end_date": "octopus",
    }
    path = GoogleAdsServiceClient.campaign_simulation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_campaign_simulation_path(path)
    assert expected == actual

def test_carrier_constant_path():
    criterion_id = "oyster"
    expected = "carrierConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.carrier_constant_path(criterion_id)
    assert expected == actual


def test_parse_carrier_constant_path():
    expected = {
        "criterion_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.carrier_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_carrier_constant_path(path)
    assert expected == actual

def test_change_event_path():
    customer_id = "cuttlefish"
    timestamp_micros = "mussel"
    command_index = "winkle"
    mutate_index = "nautilus"
    expected = "customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}".format(customer_id=customer_id, timestamp_micros=timestamp_micros, command_index=command_index, mutate_index=mutate_index, )
    actual = GoogleAdsServiceClient.change_event_path(customer_id, timestamp_micros, command_index, mutate_index)
    assert expected == actual


def test_parse_change_event_path():
    expected = {
        "customer_id": "scallop",
        "timestamp_micros": "abalone",
        "command_index": "squid",
        "mutate_index": "clam",
    }
    path = GoogleAdsServiceClient.change_event_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_change_event_path(path)
    assert expected == actual

def test_change_status_path():
    customer_id = "whelk"
    change_status_id = "octopus"
    expected = "customers/{customer_id}/changeStatus/{change_status_id}".format(customer_id=customer_id, change_status_id=change_status_id, )
    actual = GoogleAdsServiceClient.change_status_path(customer_id, change_status_id)
    assert expected == actual


def test_parse_change_status_path():
    expected = {
        "customer_id": "oyster",
        "change_status_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.change_status_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_change_status_path(path)
    assert expected == actual

def test_click_view_path():
    customer_id = "cuttlefish"
    date = "mussel"
    gclid = "winkle"
    expected = "customers/{customer_id}/clickViews/{date}~{gclid}".format(customer_id=customer_id, date=date, gclid=gclid, )
    actual = GoogleAdsServiceClient.click_view_path(customer_id, date, gclid)
    assert expected == actual


def test_parse_click_view_path():
    expected = {
        "customer_id": "nautilus",
        "date": "scallop",
        "gclid": "abalone",
    }
    path = GoogleAdsServiceClient.click_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_click_view_path(path)
    assert expected == actual

def test_combined_audience_path():
    customer_id = "squid"
    combined_audience_id = "clam"
    expected = "customers/{customer_id}/combinedAudiences/{combined_audience_id}".format(customer_id=customer_id, combined_audience_id=combined_audience_id, )
    actual = GoogleAdsServiceClient.combined_audience_path(customer_id, combined_audience_id)
    assert expected == actual


def test_parse_combined_audience_path():
    expected = {
        "customer_id": "whelk",
        "combined_audience_id": "octopus",
    }
    path = GoogleAdsServiceClient.combined_audience_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_combined_audience_path(path)
    assert expected == actual

def test_conversion_action_path():
    customer_id = "oyster"
    conversion_action_id = "nudibranch"
    expected = "customers/{customer_id}/conversionActions/{conversion_action_id}".format(customer_id=customer_id, conversion_action_id=conversion_action_id, )
    actual = GoogleAdsServiceClient.conversion_action_path(customer_id, conversion_action_id)
    assert expected == actual


def test_parse_conversion_action_path():
    expected = {
        "customer_id": "cuttlefish",
        "conversion_action_id": "mussel",
    }
    path = GoogleAdsServiceClient.conversion_action_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_action_path(path)
    assert expected == actual

def test_conversion_custom_variable_path():
    customer_id = "winkle"
    conversion_custom_variable_id = "nautilus"
    expected = "customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}".format(customer_id=customer_id, conversion_custom_variable_id=conversion_custom_variable_id, )
    actual = GoogleAdsServiceClient.conversion_custom_variable_path(customer_id, conversion_custom_variable_id)
    assert expected == actual


def test_parse_conversion_custom_variable_path():
    expected = {
        "customer_id": "scallop",
        "conversion_custom_variable_id": "abalone",
    }
    path = GoogleAdsServiceClient.conversion_custom_variable_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_custom_variable_path(path)
    assert expected == actual

def test_conversion_goal_campaign_config_path():
    customer_id = "squid"
    campaign_id = "clam"
    expected = "customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = GoogleAdsServiceClient.conversion_goal_campaign_config_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_conversion_goal_campaign_config_path():
    expected = {
        "customer_id": "whelk",
        "campaign_id": "octopus",
    }
    path = GoogleAdsServiceClient.conversion_goal_campaign_config_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_goal_campaign_config_path(path)
    assert expected == actual

def test_conversion_value_rule_path():
    customer_id = "oyster"
    conversion_value_rule_id = "nudibranch"
    expected = "customers/{customer_id}/conversionValueRules/{conversion_value_rule_id}".format(customer_id=customer_id, conversion_value_rule_id=conversion_value_rule_id, )
    actual = GoogleAdsServiceClient.conversion_value_rule_path(customer_id, conversion_value_rule_id)
    assert expected == actual


def test_parse_conversion_value_rule_path():
    expected = {
        "customer_id": "cuttlefish",
        "conversion_value_rule_id": "mussel",
    }
    path = GoogleAdsServiceClient.conversion_value_rule_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_value_rule_path(path)
    assert expected == actual

def test_conversion_value_rule_set_path():
    customer_id = "winkle"
    conversion_value_rule_set_id = "nautilus"
    expected = "customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}".format(customer_id=customer_id, conversion_value_rule_set_id=conversion_value_rule_set_id, )
    actual = GoogleAdsServiceClient.conversion_value_rule_set_path(customer_id, conversion_value_rule_set_id)
    assert expected == actual


def test_parse_conversion_value_rule_set_path():
    expected = {
        "customer_id": "scallop",
        "conversion_value_rule_set_id": "abalone",
    }
    path = GoogleAdsServiceClient.conversion_value_rule_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_conversion_value_rule_set_path(path)
    assert expected == actual

def test_currency_constant_path():
    code = "squid"
    expected = "currencyConstants/{code}".format(code=code, )
    actual = GoogleAdsServiceClient.currency_constant_path(code)
    assert expected == actual


def test_parse_currency_constant_path():
    expected = {
        "code": "clam",
    }
    path = GoogleAdsServiceClient.currency_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_currency_constant_path(path)
    assert expected == actual

def test_custom_audience_path():
    customer_id = "whelk"
    custom_audience_id = "octopus"
    expected = "customers/{customer_id}/customAudiences/{custom_audience_id}".format(customer_id=customer_id, custom_audience_id=custom_audience_id, )
    actual = GoogleAdsServiceClient.custom_audience_path(customer_id, custom_audience_id)
    assert expected == actual


def test_parse_custom_audience_path():
    expected = {
        "customer_id": "oyster",
        "custom_audience_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.custom_audience_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_custom_audience_path(path)
    assert expected == actual

def test_custom_conversion_goal_path():
    customer_id = "cuttlefish"
    goal_id = "mussel"
    expected = "customers/{customer_id}/customConversionGoals/{goal_id}".format(customer_id=customer_id, goal_id=goal_id, )
    actual = GoogleAdsServiceClient.custom_conversion_goal_path(customer_id, goal_id)
    assert expected == actual


def test_parse_custom_conversion_goal_path():
    expected = {
        "customer_id": "winkle",
        "goal_id": "nautilus",
    }
    path = GoogleAdsServiceClient.custom_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_custom_conversion_goal_path(path)
    assert expected == actual

def test_customer_path():
    customer_id = "scallop"
    expected = "customers/{customer_id}".format(customer_id=customer_id, )
    actual = GoogleAdsServiceClient.customer_path(customer_id)
    assert expected == actual


def test_parse_customer_path():
    expected = {
        "customer_id": "abalone",
    }
    path = GoogleAdsServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_path(path)
    assert expected == actual

def test_customer_asset_path():
    customer_id = "squid"
    asset_id = "clam"
    field_type = "whelk"
    expected = "customers/{customer_id}/customerAssets/{asset_id}~{field_type}".format(customer_id=customer_id, asset_id=asset_id, field_type=field_type, )
    actual = GoogleAdsServiceClient.customer_asset_path(customer_id, asset_id, field_type)
    assert expected == actual


def test_parse_customer_asset_path():
    expected = {
        "customer_id": "octopus",
        "asset_id": "oyster",
        "field_type": "nudibranch",
    }
    path = GoogleAdsServiceClient.customer_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_asset_path(path)
    assert expected == actual

def test_customer_client_path():
    customer_id = "cuttlefish"
    client_customer_id = "mussel"
    expected = "customers/{customer_id}/customerClients/{client_customer_id}".format(customer_id=customer_id, client_customer_id=client_customer_id, )
    actual = GoogleAdsServiceClient.customer_client_path(customer_id, client_customer_id)
    assert expected == actual


def test_parse_customer_client_path():
    expected = {
        "customer_id": "winkle",
        "client_customer_id": "nautilus",
    }
    path = GoogleAdsServiceClient.customer_client_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_client_path(path)
    assert expected == actual

def test_customer_client_link_path():
    customer_id = "scallop"
    client_customer_id = "abalone"
    manager_link_id = "squid"
    expected = "customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}".format(customer_id=customer_id, client_customer_id=client_customer_id, manager_link_id=manager_link_id, )
    actual = GoogleAdsServiceClient.customer_client_link_path(customer_id, client_customer_id, manager_link_id)
    assert expected == actual


def test_parse_customer_client_link_path():
    expected = {
        "customer_id": "clam",
        "client_customer_id": "whelk",
        "manager_link_id": "octopus",
    }
    path = GoogleAdsServiceClient.customer_client_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_client_link_path(path)
    assert expected == actual

def test_customer_conversion_goal_path():
    customer_id = "oyster"
    category = "nudibranch"
    source = "cuttlefish"
    expected = "customers/{customer_id}/customerConversionGoals/{category}~{source}".format(customer_id=customer_id, category=category, source=source, )
    actual = GoogleAdsServiceClient.customer_conversion_goal_path(customer_id, category, source)
    assert expected == actual


def test_parse_customer_conversion_goal_path():
    expected = {
        "customer_id": "mussel",
        "category": "winkle",
        "source": "nautilus",
    }
    path = GoogleAdsServiceClient.customer_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_conversion_goal_path(path)
    assert expected == actual

def test_customer_customizer_path():
    customer_id = "scallop"
    customizer_attribute_id = "abalone"
    expected = "customers/{customer_id}/customerCustomizers/{customizer_attribute_id}".format(customer_id=customer_id, customizer_attribute_id=customizer_attribute_id, )
    actual = GoogleAdsServiceClient.customer_customizer_path(customer_id, customizer_attribute_id)
    assert expected == actual


def test_parse_customer_customizer_path():
    expected = {
        "customer_id": "squid",
        "customizer_attribute_id": "clam",
    }
    path = GoogleAdsServiceClient.customer_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_customizer_path(path)
    assert expected == actual

def test_customer_extension_setting_path():
    customer_id = "whelk"
    extension_type = "octopus"
    expected = "customers/{customer_id}/customerExtensionSettings/{extension_type}".format(customer_id=customer_id, extension_type=extension_type, )
    actual = GoogleAdsServiceClient.customer_extension_setting_path(customer_id, extension_type)
    assert expected == actual


def test_parse_customer_extension_setting_path():
    expected = {
        "customer_id": "oyster",
        "extension_type": "nudibranch",
    }
    path = GoogleAdsServiceClient.customer_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_extension_setting_path(path)
    assert expected == actual

def test_customer_feed_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    expected = "customers/{customer_id}/customerFeeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = GoogleAdsServiceClient.customer_feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_customer_feed_path():
    expected = {
        "customer_id": "winkle",
        "feed_id": "nautilus",
    }
    path = GoogleAdsServiceClient.customer_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_feed_path(path)
    assert expected == actual

def test_customer_label_path():
    customer_id = "scallop"
    label_id = "abalone"
    expected = "customers/{customer_id}/customerLabels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.customer_label_path(customer_id, label_id)
    assert expected == actual


def test_parse_customer_label_path():
    expected = {
        "customer_id": "squid",
        "label_id": "clam",
    }
    path = GoogleAdsServiceClient.customer_label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_label_path(path)
    assert expected == actual

def test_customer_manager_link_path():
    customer_id = "whelk"
    manager_customer_id = "octopus"
    manager_link_id = "oyster"
    expected = "customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}".format(customer_id=customer_id, manager_customer_id=manager_customer_id, manager_link_id=manager_link_id, )
    actual = GoogleAdsServiceClient.customer_manager_link_path(customer_id, manager_customer_id, manager_link_id)
    assert expected == actual


def test_parse_customer_manager_link_path():
    expected = {
        "customer_id": "nudibranch",
        "manager_customer_id": "cuttlefish",
        "manager_link_id": "mussel",
    }
    path = GoogleAdsServiceClient.customer_manager_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_manager_link_path(path)
    assert expected == actual

def test_customer_negative_criterion_path():
    customer_id = "winkle"
    criterion_id = "nautilus"
    expected = "customers/{customer_id}/customerNegativeCriteria/{criterion_id}".format(customer_id=customer_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.customer_negative_criterion_path(customer_id, criterion_id)
    assert expected == actual


def test_parse_customer_negative_criterion_path():
    expected = {
        "customer_id": "scallop",
        "criterion_id": "abalone",
    }
    path = GoogleAdsServiceClient.customer_negative_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_negative_criterion_path(path)
    assert expected == actual

def test_customer_user_access_path():
    customer_id = "squid"
    user_id = "clam"
    expected = "customers/{customer_id}/customerUserAccesses/{user_id}".format(customer_id=customer_id, user_id=user_id, )
    actual = GoogleAdsServiceClient.customer_user_access_path(customer_id, user_id)
    assert expected == actual


def test_parse_customer_user_access_path():
    expected = {
        "customer_id": "whelk",
        "user_id": "octopus",
    }
    path = GoogleAdsServiceClient.customer_user_access_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_user_access_path(path)
    assert expected == actual

def test_customer_user_access_invitation_path():
    customer_id = "oyster"
    invitation_id = "nudibranch"
    expected = "customers/{customer_id}/customerUserAccessInvitations/{invitation_id}".format(customer_id=customer_id, invitation_id=invitation_id, )
    actual = GoogleAdsServiceClient.customer_user_access_invitation_path(customer_id, invitation_id)
    assert expected == actual


def test_parse_customer_user_access_invitation_path():
    expected = {
        "customer_id": "cuttlefish",
        "invitation_id": "mussel",
    }
    path = GoogleAdsServiceClient.customer_user_access_invitation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customer_user_access_invitation_path(path)
    assert expected == actual

def test_custom_interest_path():
    customer_id = "winkle"
    custom_interest_id = "nautilus"
    expected = "customers/{customer_id}/customInterests/{custom_interest_id}".format(customer_id=customer_id, custom_interest_id=custom_interest_id, )
    actual = GoogleAdsServiceClient.custom_interest_path(customer_id, custom_interest_id)
    assert expected == actual


def test_parse_custom_interest_path():
    expected = {
        "customer_id": "scallop",
        "custom_interest_id": "abalone",
    }
    path = GoogleAdsServiceClient.custom_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_custom_interest_path(path)
    assert expected == actual

def test_customizer_attribute_path():
    customer_id = "squid"
    customizer_attribute_id = "clam"
    expected = "customers/{customer_id}/customizerAttributes/{customizer_attribute_id}".format(customer_id=customer_id, customizer_attribute_id=customizer_attribute_id, )
    actual = GoogleAdsServiceClient.customizer_attribute_path(customer_id, customizer_attribute_id)
    assert expected == actual


def test_parse_customizer_attribute_path():
    expected = {
        "customer_id": "whelk",
        "customizer_attribute_id": "octopus",
    }
    path = GoogleAdsServiceClient.customizer_attribute_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_customizer_attribute_path(path)
    assert expected == actual

def test_detailed_demographic_path():
    customer_id = "oyster"
    detailed_demographic_id = "nudibranch"
    expected = "customers/{customer_id}/detailedDemographics/{detailed_demographic_id}".format(customer_id=customer_id, detailed_demographic_id=detailed_demographic_id, )
    actual = GoogleAdsServiceClient.detailed_demographic_path(customer_id, detailed_demographic_id)
    assert expected == actual


def test_parse_detailed_demographic_path():
    expected = {
        "customer_id": "cuttlefish",
        "detailed_demographic_id": "mussel",
    }
    path = GoogleAdsServiceClient.detailed_demographic_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_detailed_demographic_path(path)
    assert expected == actual

def test_detail_placement_view_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    base64_placement = "scallop"
    expected = "customers/{customer_id}/detailPlacementViews/{ad_group_id}~{base64_placement}".format(customer_id=customer_id, ad_group_id=ad_group_id, base64_placement=base64_placement, )
    actual = GoogleAdsServiceClient.detail_placement_view_path(customer_id, ad_group_id, base64_placement)
    assert expected == actual


def test_parse_detail_placement_view_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "base64_placement": "clam",
    }
    path = GoogleAdsServiceClient.detail_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_detail_placement_view_path(path)
    assert expected == actual

def test_display_keyword_view_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    criterion_id = "oyster"
    expected = "customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.display_keyword_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_display_keyword_view_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.display_keyword_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_display_keyword_view_path(path)
    assert expected == actual

def test_distance_view_path():
    customer_id = "winkle"
    placeholder_chain_id = "nautilus"
    distance_bucket = "scallop"
    expected = "customers/{customer_id}/distanceViews/{placeholder_chain_id}~{distance_bucket}".format(customer_id=customer_id, placeholder_chain_id=placeholder_chain_id, distance_bucket=distance_bucket, )
    actual = GoogleAdsServiceClient.distance_view_path(customer_id, placeholder_chain_id, distance_bucket)
    assert expected == actual


def test_parse_distance_view_path():
    expected = {
        "customer_id": "abalone",
        "placeholder_chain_id": "squid",
        "distance_bucket": "clam",
    }
    path = GoogleAdsServiceClient.distance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_distance_view_path(path)
    assert expected == actual

def test_domain_category_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    base64_category = "oyster"
    language_code = "nudibranch"
    expected = "customers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}".format(customer_id=customer_id, campaign_id=campaign_id, base64_category=base64_category, language_code=language_code, )
    actual = GoogleAdsServiceClient.domain_category_path(customer_id, campaign_id, base64_category, language_code)
    assert expected == actual


def test_parse_domain_category_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
        "base64_category": "winkle",
        "language_code": "nautilus",
    }
    path = GoogleAdsServiceClient.domain_category_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_domain_category_path(path)
    assert expected == actual

def test_dynamic_search_ads_search_term_view_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    search_term_fingerprint = "squid"
    headline_fingerprint = "clam"
    landing_page_fingerprint = "whelk"
    page_url_fingerprint = "octopus"
    expected = "customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}".format(customer_id=customer_id, ad_group_id=ad_group_id, search_term_fingerprint=search_term_fingerprint, headline_fingerprint=headline_fingerprint, landing_page_fingerprint=landing_page_fingerprint, page_url_fingerprint=page_url_fingerprint, )
    actual = GoogleAdsServiceClient.dynamic_search_ads_search_term_view_path(customer_id, ad_group_id, search_term_fingerprint, headline_fingerprint, landing_page_fingerprint, page_url_fingerprint)
    assert expected == actual


def test_parse_dynamic_search_ads_search_term_view_path():
    expected = {
        "customer_id": "oyster",
        "ad_group_id": "nudibranch",
        "search_term_fingerprint": "cuttlefish",
        "headline_fingerprint": "mussel",
        "landing_page_fingerprint": "winkle",
        "page_url_fingerprint": "nautilus",
    }
    path = GoogleAdsServiceClient.dynamic_search_ads_search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_dynamic_search_ads_search_term_view_path(path)
    assert expected == actual

def test_expanded_landing_page_view_path():
    customer_id = "scallop"
    expanded_final_url_fingerprint = "abalone"
    expected = "customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}".format(customer_id=customer_id, expanded_final_url_fingerprint=expanded_final_url_fingerprint, )
    actual = GoogleAdsServiceClient.expanded_landing_page_view_path(customer_id, expanded_final_url_fingerprint)
    assert expected == actual


def test_parse_expanded_landing_page_view_path():
    expected = {
        "customer_id": "squid",
        "expanded_final_url_fingerprint": "clam",
    }
    path = GoogleAdsServiceClient.expanded_landing_page_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_expanded_landing_page_view_path(path)
    assert expected == actual

def test_extension_feed_item_path():
    customer_id = "whelk"
    feed_item_id = "octopus"
    expected = "customers/{customer_id}/extensionFeedItems/{feed_item_id}".format(customer_id=customer_id, feed_item_id=feed_item_id, )
    actual = GoogleAdsServiceClient.extension_feed_item_path(customer_id, feed_item_id)
    assert expected == actual


def test_parse_extension_feed_item_path():
    expected = {
        "customer_id": "oyster",
        "feed_item_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.extension_feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_extension_feed_item_path(path)
    assert expected == actual

def test_feed_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    expected = "customers/{customer_id}/feeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = GoogleAdsServiceClient.feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_feed_path():
    expected = {
        "customer_id": "winkle",
        "feed_id": "nautilus",
    }
    path = GoogleAdsServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_path(path)
    assert expected == actual

def test_feed_item_path():
    customer_id = "scallop"
    feed_id = "abalone"
    feed_item_id = "squid"
    expected = "customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_id=feed_item_id, )
    actual = GoogleAdsServiceClient.feed_item_path(customer_id, feed_id, feed_item_id)
    assert expected == actual


def test_parse_feed_item_path():
    expected = {
        "customer_id": "clam",
        "feed_id": "whelk",
        "feed_item_id": "octopus",
    }
    path = GoogleAdsServiceClient.feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_path(path)
    assert expected == actual

def test_feed_item_set_path():
    customer_id = "oyster"
    feed_id = "nudibranch"
    feed_item_set_id = "cuttlefish"
    expected = "customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_set_id=feed_item_set_id, )
    actual = GoogleAdsServiceClient.feed_item_set_path(customer_id, feed_id, feed_item_set_id)
    assert expected == actual


def test_parse_feed_item_set_path():
    expected = {
        "customer_id": "mussel",
        "feed_id": "winkle",
        "feed_item_set_id": "nautilus",
    }
    path = GoogleAdsServiceClient.feed_item_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_set_path(path)
    assert expected == actual

def test_feed_item_set_link_path():
    customer_id = "scallop"
    feed_id = "abalone"
    feed_item_set_id = "squid"
    feed_item_id = "clam"
    expected = "customers/{customer_id}/feedItemSetLinks/{feed_id}~{feed_item_set_id}~{feed_item_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_set_id=feed_item_set_id, feed_item_id=feed_item_id, )
    actual = GoogleAdsServiceClient.feed_item_set_link_path(customer_id, feed_id, feed_item_set_id, feed_item_id)
    assert expected == actual


def test_parse_feed_item_set_link_path():
    expected = {
        "customer_id": "whelk",
        "feed_id": "octopus",
        "feed_item_set_id": "oyster",
        "feed_item_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.feed_item_set_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_set_link_path(path)
    assert expected == actual

def test_feed_item_target_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    feed_item_id = "winkle"
    feed_item_target_type = "nautilus"
    feed_item_target_id = "scallop"
    expected = "customers/{customer_id}/feedItemTargets/{feed_id}~{feed_item_id}~{feed_item_target_type}~{feed_item_target_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_id=feed_item_id, feed_item_target_type=feed_item_target_type, feed_item_target_id=feed_item_target_id, )
    actual = GoogleAdsServiceClient.feed_item_target_path(customer_id, feed_id, feed_item_id, feed_item_target_type, feed_item_target_id)
    assert expected == actual


def test_parse_feed_item_target_path():
    expected = {
        "customer_id": "abalone",
        "feed_id": "squid",
        "feed_item_id": "clam",
        "feed_item_target_type": "whelk",
        "feed_item_target_id": "octopus",
    }
    path = GoogleAdsServiceClient.feed_item_target_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_item_target_path(path)
    assert expected == actual

def test_feed_mapping_path():
    customer_id = "oyster"
    feed_id = "nudibranch"
    feed_mapping_id = "cuttlefish"
    expected = "customers/{customer_id}/feedMappings/{feed_id}~{feed_mapping_id}".format(customer_id=customer_id, feed_id=feed_id, feed_mapping_id=feed_mapping_id, )
    actual = GoogleAdsServiceClient.feed_mapping_path(customer_id, feed_id, feed_mapping_id)
    assert expected == actual


def test_parse_feed_mapping_path():
    expected = {
        "customer_id": "mussel",
        "feed_id": "winkle",
        "feed_mapping_id": "nautilus",
    }
    path = GoogleAdsServiceClient.feed_mapping_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_mapping_path(path)
    assert expected == actual

def test_feed_placeholder_view_path():
    customer_id = "scallop"
    placeholder_type = "abalone"
    expected = "customers/{customer_id}/feedPlaceholderViews/{placeholder_type}".format(customer_id=customer_id, placeholder_type=placeholder_type, )
    actual = GoogleAdsServiceClient.feed_placeholder_view_path(customer_id, placeholder_type)
    assert expected == actual


def test_parse_feed_placeholder_view_path():
    expected = {
        "customer_id": "squid",
        "placeholder_type": "clam",
    }
    path = GoogleAdsServiceClient.feed_placeholder_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_feed_placeholder_view_path(path)
    assert expected == actual

def test_gender_view_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    criterion_id = "oyster"
    expected = "customers/{customer_id}/genderViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.gender_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_gender_view_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.gender_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_gender_view_path(path)
    assert expected == actual

def test_geographic_view_path():
    customer_id = "winkle"
    country_criterion_id = "nautilus"
    location_type = "scallop"
    expected = "customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}".format(customer_id=customer_id, country_criterion_id=country_criterion_id, location_type=location_type, )
    actual = GoogleAdsServiceClient.geographic_view_path(customer_id, country_criterion_id, location_type)
    assert expected == actual


def test_parse_geographic_view_path():
    expected = {
        "customer_id": "abalone",
        "country_criterion_id": "squid",
        "location_type": "clam",
    }
    path = GoogleAdsServiceClient.geographic_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_geographic_view_path(path)
    assert expected == actual

def test_geo_target_constant_path():
    criterion_id = "whelk"
    expected = "geoTargetConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.geo_target_constant_path(criterion_id)
    assert expected == actual


def test_parse_geo_target_constant_path():
    expected = {
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.geo_target_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_geo_target_constant_path(path)
    assert expected == actual

def test_group_placement_view_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    base64_placement = "cuttlefish"
    expected = "customers/{customer_id}/groupPlacementViews/{ad_group_id}~{base64_placement}".format(customer_id=customer_id, ad_group_id=ad_group_id, base64_placement=base64_placement, )
    actual = GoogleAdsServiceClient.group_placement_view_path(customer_id, ad_group_id, base64_placement)
    assert expected == actual


def test_parse_group_placement_view_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "base64_placement": "nautilus",
    }
    path = GoogleAdsServiceClient.group_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_group_placement_view_path(path)
    assert expected == actual

def test_hotel_group_view_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/hotelGroupViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.hotel_group_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_hotel_group_view_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.hotel_group_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_hotel_group_view_path(path)
    assert expected == actual

def test_hotel_performance_view_path():
    customer_id = "oyster"
    expected = "customers/{customer_id}/hotelPerformanceView".format(customer_id=customer_id, )
    actual = GoogleAdsServiceClient.hotel_performance_view_path(customer_id)
    assert expected == actual


def test_parse_hotel_performance_view_path():
    expected = {
        "customer_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.hotel_performance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_hotel_performance_view_path(path)
    assert expected == actual

def test_hotel_reconciliation_path():
    customer_id = "cuttlefish"
    commission_id = "mussel"
    expected = "customers/{customer_id}/hotelReconciliations/{commission_id}".format(customer_id=customer_id, commission_id=commission_id, )
    actual = GoogleAdsServiceClient.hotel_reconciliation_path(customer_id, commission_id)
    assert expected == actual


def test_parse_hotel_reconciliation_path():
    expected = {
        "customer_id": "winkle",
        "commission_id": "nautilus",
    }
    path = GoogleAdsServiceClient.hotel_reconciliation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_hotel_reconciliation_path(path)
    assert expected == actual

def test_income_range_view_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/incomeRangeViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.income_range_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_income_range_view_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.income_range_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_income_range_view_path(path)
    assert expected == actual

def test_keyword_plan_path():
    customer_id = "oyster"
    keyword_plan_id = "nudibranch"
    expected = "customers/{customer_id}/keywordPlans/{keyword_plan_id}".format(customer_id=customer_id, keyword_plan_id=keyword_plan_id, )
    actual = GoogleAdsServiceClient.keyword_plan_path(customer_id, keyword_plan_id)
    assert expected == actual


def test_parse_keyword_plan_path():
    expected = {
        "customer_id": "cuttlefish",
        "keyword_plan_id": "mussel",
    }
    path = GoogleAdsServiceClient.keyword_plan_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_path():
    customer_id = "winkle"
    keyword_plan_ad_group_id = "nautilus"
    expected = "customers/{customer_id}/keywordPlanAdGroups/{keyword_plan_ad_group_id}".format(customer_id=customer_id, keyword_plan_ad_group_id=keyword_plan_ad_group_id, )
    actual = GoogleAdsServiceClient.keyword_plan_ad_group_path(customer_id, keyword_plan_ad_group_id)
    assert expected == actual


def test_parse_keyword_plan_ad_group_path():
    expected = {
        "customer_id": "scallop",
        "keyword_plan_ad_group_id": "abalone",
    }
    path = GoogleAdsServiceClient.keyword_plan_ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_ad_group_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_keyword_path():
    customer_id = "squid"
    keyword_plan_ad_group_keyword_id = "clam"
    expected = "customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}".format(customer_id=customer_id, keyword_plan_ad_group_keyword_id=keyword_plan_ad_group_keyword_id, )
    actual = GoogleAdsServiceClient.keyword_plan_ad_group_keyword_path(customer_id, keyword_plan_ad_group_keyword_id)
    assert expected == actual


def test_parse_keyword_plan_ad_group_keyword_path():
    expected = {
        "customer_id": "whelk",
        "keyword_plan_ad_group_keyword_id": "octopus",
    }
    path = GoogleAdsServiceClient.keyword_plan_ad_group_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_ad_group_keyword_path(path)
    assert expected == actual

def test_keyword_plan_campaign_path():
    customer_id = "oyster"
    keyword_plan_campaign_id = "nudibranch"
    expected = "customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}".format(customer_id=customer_id, keyword_plan_campaign_id=keyword_plan_campaign_id, )
    actual = GoogleAdsServiceClient.keyword_plan_campaign_path(customer_id, keyword_plan_campaign_id)
    assert expected == actual


def test_parse_keyword_plan_campaign_path():
    expected = {
        "customer_id": "cuttlefish",
        "keyword_plan_campaign_id": "mussel",
    }
    path = GoogleAdsServiceClient.keyword_plan_campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_campaign_path(path)
    assert expected == actual

def test_keyword_plan_campaign_keyword_path():
    customer_id = "winkle"
    keyword_plan_campaign_keyword_id = "nautilus"
    expected = "customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}".format(customer_id=customer_id, keyword_plan_campaign_keyword_id=keyword_plan_campaign_keyword_id, )
    actual = GoogleAdsServiceClient.keyword_plan_campaign_keyword_path(customer_id, keyword_plan_campaign_keyword_id)
    assert expected == actual


def test_parse_keyword_plan_campaign_keyword_path():
    expected = {
        "customer_id": "scallop",
        "keyword_plan_campaign_keyword_id": "abalone",
    }
    path = GoogleAdsServiceClient.keyword_plan_campaign_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_plan_campaign_keyword_path(path)
    assert expected == actual

def test_keyword_theme_constant_path():
    express_category_id = "squid"
    express_sub_category_id = "clam"
    expected = "keywordThemeConstants/{express_category_id}~{express_sub_category_id}".format(express_category_id=express_category_id, express_sub_category_id=express_sub_category_id, )
    actual = GoogleAdsServiceClient.keyword_theme_constant_path(express_category_id, express_sub_category_id)
    assert expected == actual


def test_parse_keyword_theme_constant_path():
    expected = {
        "express_category_id": "whelk",
        "express_sub_category_id": "octopus",
    }
    path = GoogleAdsServiceClient.keyword_theme_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_theme_constant_path(path)
    assert expected == actual

def test_keyword_view_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/keywordViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.keyword_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_keyword_view_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.keyword_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_keyword_view_path(path)
    assert expected == actual

def test_label_path():
    customer_id = "scallop"
    label_id = "abalone"
    expected = "customers/{customer_id}/labels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = GoogleAdsServiceClient.label_path(customer_id, label_id)
    assert expected == actual


def test_parse_label_path():
    expected = {
        "customer_id": "squid",
        "label_id": "clam",
    }
    path = GoogleAdsServiceClient.label_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_label_path(path)
    assert expected == actual

def test_landing_page_view_path():
    customer_id = "whelk"
    unexpanded_final_url_fingerprint = "octopus"
    expected = "customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}".format(customer_id=customer_id, unexpanded_final_url_fingerprint=unexpanded_final_url_fingerprint, )
    actual = GoogleAdsServiceClient.landing_page_view_path(customer_id, unexpanded_final_url_fingerprint)
    assert expected == actual


def test_parse_landing_page_view_path():
    expected = {
        "customer_id": "oyster",
        "unexpanded_final_url_fingerprint": "nudibranch",
    }
    path = GoogleAdsServiceClient.landing_page_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_landing_page_view_path(path)
    assert expected == actual

def test_language_constant_path():
    criterion_id = "cuttlefish"
    expected = "languageConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.language_constant_path(criterion_id)
    assert expected == actual


def test_parse_language_constant_path():
    expected = {
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.language_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_language_constant_path(path)
    assert expected == actual

def test_life_event_path():
    customer_id = "winkle"
    life_event_id = "nautilus"
    expected = "customers/{customer_id}/lifeEvents/{life_event_id}".format(customer_id=customer_id, life_event_id=life_event_id, )
    actual = GoogleAdsServiceClient.life_event_path(customer_id, life_event_id)
    assert expected == actual


def test_parse_life_event_path():
    expected = {
        "customer_id": "scallop",
        "life_event_id": "abalone",
    }
    path = GoogleAdsServiceClient.life_event_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_life_event_path(path)
    assert expected == actual

def test_location_view_path():
    customer_id = "squid"
    campaign_id = "clam"
    criterion_id = "whelk"
    expected = "customers/{customer_id}/locationViews/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.location_view_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_location_view_path():
    expected = {
        "customer_id": "octopus",
        "campaign_id": "oyster",
        "criterion_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.location_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_location_view_path(path)
    assert expected == actual

def test_managed_placement_view_path():
    customer_id = "cuttlefish"
    ad_group_id = "mussel"
    criterion_id = "winkle"
    expected = "customers/{customer_id}/managedPlacementViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.managed_placement_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_managed_placement_view_path():
    expected = {
        "customer_id": "nautilus",
        "ad_group_id": "scallop",
        "criterion_id": "abalone",
    }
    path = GoogleAdsServiceClient.managed_placement_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_managed_placement_view_path(path)
    assert expected == actual

def test_media_file_path():
    customer_id = "squid"
    media_file_id = "clam"
    expected = "customers/{customer_id}/mediaFiles/{media_file_id}".format(customer_id=customer_id, media_file_id=media_file_id, )
    actual = GoogleAdsServiceClient.media_file_path(customer_id, media_file_id)
    assert expected == actual


def test_parse_media_file_path():
    expected = {
        "customer_id": "whelk",
        "media_file_id": "octopus",
    }
    path = GoogleAdsServiceClient.media_file_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_media_file_path(path)
    assert expected == actual

def test_mobile_app_category_constant_path():
    mobile_app_category_id = "oyster"
    expected = "mobileAppCategoryConstants/{mobile_app_category_id}".format(mobile_app_category_id=mobile_app_category_id, )
    actual = GoogleAdsServiceClient.mobile_app_category_constant_path(mobile_app_category_id)
    assert expected == actual


def test_parse_mobile_app_category_constant_path():
    expected = {
        "mobile_app_category_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.mobile_app_category_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_mobile_app_category_constant_path(path)
    assert expected == actual

def test_mobile_device_constant_path():
    criterion_id = "cuttlefish"
    expected = "mobileDeviceConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.mobile_device_constant_path(criterion_id)
    assert expected == actual


def test_parse_mobile_device_constant_path():
    expected = {
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.mobile_device_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_mobile_device_constant_path(path)
    assert expected == actual

def test_offline_user_data_job_path():
    customer_id = "winkle"
    offline_user_data_update_id = "nautilus"
    expected = "customers/{customer_id}/offlineUserDataJobs/{offline_user_data_update_id}".format(customer_id=customer_id, offline_user_data_update_id=offline_user_data_update_id, )
    actual = GoogleAdsServiceClient.offline_user_data_job_path(customer_id, offline_user_data_update_id)
    assert expected == actual


def test_parse_offline_user_data_job_path():
    expected = {
        "customer_id": "scallop",
        "offline_user_data_update_id": "abalone",
    }
    path = GoogleAdsServiceClient.offline_user_data_job_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_offline_user_data_job_path(path)
    assert expected == actual

def test_operating_system_version_constant_path():
    criterion_id = "squid"
    expected = "operatingSystemVersionConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.operating_system_version_constant_path(criterion_id)
    assert expected == actual


def test_parse_operating_system_version_constant_path():
    expected = {
        "criterion_id": "clam",
    }
    path = GoogleAdsServiceClient.operating_system_version_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_operating_system_version_constant_path(path)
    assert expected == actual

def test_paid_organic_search_term_view_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    ad_group_id = "oyster"
    base64_search_term = "nudibranch"
    expected = "customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}".format(customer_id=customer_id, campaign_id=campaign_id, ad_group_id=ad_group_id, base64_search_term=base64_search_term, )
    actual = GoogleAdsServiceClient.paid_organic_search_term_view_path(customer_id, campaign_id, ad_group_id, base64_search_term)
    assert expected == actual


def test_parse_paid_organic_search_term_view_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
        "ad_group_id": "winkle",
        "base64_search_term": "nautilus",
    }
    path = GoogleAdsServiceClient.paid_organic_search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_paid_organic_search_term_view_path(path)
    assert expected == actual

def test_parental_status_view_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/parentalStatusViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.parental_status_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_parental_status_view_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = GoogleAdsServiceClient.parental_status_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_parental_status_view_path(path)
    assert expected == actual

def test_payments_account_path():
    customer_id = "oyster"
    payments_account_id = "nudibranch"
    expected = "customers/{customer_id}/paymentsAccounts/{payments_account_id}".format(customer_id=customer_id, payments_account_id=payments_account_id, )
    actual = GoogleAdsServiceClient.payments_account_path(customer_id, payments_account_id)
    assert expected == actual


def test_parse_payments_account_path():
    expected = {
        "customer_id": "cuttlefish",
        "payments_account_id": "mussel",
    }
    path = GoogleAdsServiceClient.payments_account_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_payments_account_path(path)
    assert expected == actual

def test_product_bidding_category_constant_path():
    country_code = "winkle"
    level = "nautilus"
    id = "scallop"
    expected = "productBiddingCategoryConstants/{country_code}~{level}~{id}".format(country_code=country_code, level=level, id=id, )
    actual = GoogleAdsServiceClient.product_bidding_category_constant_path(country_code, level, id)
    assert expected == actual


def test_parse_product_bidding_category_constant_path():
    expected = {
        "country_code": "abalone",
        "level": "squid",
        "id": "clam",
    }
    path = GoogleAdsServiceClient.product_bidding_category_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_product_bidding_category_constant_path(path)
    assert expected == actual

def test_product_group_view_path():
    customer_id = "whelk"
    adgroup_id = "octopus"
    criterion_id = "oyster"
    expected = "customers/{customer_id}/productGroupViews/{adgroup_id}~{criterion_id}".format(customer_id=customer_id, adgroup_id=adgroup_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.product_group_view_path(customer_id, adgroup_id, criterion_id)
    assert expected == actual


def test_parse_product_group_view_path():
    expected = {
        "customer_id": "nudibranch",
        "adgroup_id": "cuttlefish",
        "criterion_id": "mussel",
    }
    path = GoogleAdsServiceClient.product_group_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_product_group_view_path(path)
    assert expected == actual

def test_recommendation_path():
    customer_id = "winkle"
    recommendation_id = "nautilus"
    expected = "customers/{customer_id}/recommendations/{recommendation_id}".format(customer_id=customer_id, recommendation_id=recommendation_id, )
    actual = GoogleAdsServiceClient.recommendation_path(customer_id, recommendation_id)
    assert expected == actual


def test_parse_recommendation_path():
    expected = {
        "customer_id": "scallop",
        "recommendation_id": "abalone",
    }
    path = GoogleAdsServiceClient.recommendation_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_recommendation_path(path)
    assert expected == actual

def test_remarketing_action_path():
    customer_id = "squid"
    remarketing_action_id = "clam"
    expected = "customers/{customer_id}/remarketingActions/{remarketing_action_id}".format(customer_id=customer_id, remarketing_action_id=remarketing_action_id, )
    actual = GoogleAdsServiceClient.remarketing_action_path(customer_id, remarketing_action_id)
    assert expected == actual


def test_parse_remarketing_action_path():
    expected = {
        "customer_id": "whelk",
        "remarketing_action_id": "octopus",
    }
    path = GoogleAdsServiceClient.remarketing_action_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_remarketing_action_path(path)
    assert expected == actual

def test_search_term_view_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    ad_group_id = "cuttlefish"
    query = "mussel"
    expected = "customers/{customer_id}/searchTermViews/{campaign_id}~{ad_group_id}~{query}".format(customer_id=customer_id, campaign_id=campaign_id, ad_group_id=ad_group_id, query=query, )
    actual = GoogleAdsServiceClient.search_term_view_path(customer_id, campaign_id, ad_group_id, query)
    assert expected == actual


def test_parse_search_term_view_path():
    expected = {
        "customer_id": "winkle",
        "campaign_id": "nautilus",
        "ad_group_id": "scallop",
        "query": "abalone",
    }
    path = GoogleAdsServiceClient.search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_search_term_view_path(path)
    assert expected == actual

def test_shared_criterion_path():
    customer_id = "squid"
    shared_set_id = "clam"
    criterion_id = "whelk"
    expected = "customers/{customer_id}/sharedCriteria/{shared_set_id}~{criterion_id}".format(customer_id=customer_id, shared_set_id=shared_set_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.shared_criterion_path(customer_id, shared_set_id, criterion_id)
    assert expected == actual


def test_parse_shared_criterion_path():
    expected = {
        "customer_id": "octopus",
        "shared_set_id": "oyster",
        "criterion_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.shared_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shared_criterion_path(path)
    assert expected == actual

def test_shared_set_path():
    customer_id = "cuttlefish"
    shared_set_id = "mussel"
    expected = "customers/{customer_id}/sharedSets/{shared_set_id}".format(customer_id=customer_id, shared_set_id=shared_set_id, )
    actual = GoogleAdsServiceClient.shared_set_path(customer_id, shared_set_id)
    assert expected == actual


def test_parse_shared_set_path():
    expected = {
        "customer_id": "winkle",
        "shared_set_id": "nautilus",
    }
    path = GoogleAdsServiceClient.shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shared_set_path(path)
    assert expected == actual

def test_shopping_performance_view_path():
    customer_id = "scallop"
    expected = "customers/{customer_id}/shoppingPerformanceView".format(customer_id=customer_id, )
    actual = GoogleAdsServiceClient.shopping_performance_view_path(customer_id)
    assert expected == actual


def test_parse_shopping_performance_view_path():
    expected = {
        "customer_id": "abalone",
    }
    path = GoogleAdsServiceClient.shopping_performance_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_shopping_performance_view_path(path)
    assert expected == actual

def test_smart_campaign_search_term_view_path():
    customer_id = "squid"
    campaign_id = "clam"
    query = "whelk"
    expected = "customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}".format(customer_id=customer_id, campaign_id=campaign_id, query=query, )
    actual = GoogleAdsServiceClient.smart_campaign_search_term_view_path(customer_id, campaign_id, query)
    assert expected == actual


def test_parse_smart_campaign_search_term_view_path():
    expected = {
        "customer_id": "octopus",
        "campaign_id": "oyster",
        "query": "nudibranch",
    }
    path = GoogleAdsServiceClient.smart_campaign_search_term_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_smart_campaign_search_term_view_path(path)
    assert expected == actual

def test_smart_campaign_setting_path():
    customer_id = "cuttlefish"
    campaign_id = "mussel"
    expected = "customers/{customer_id}/smartCampaignSettings/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = GoogleAdsServiceClient.smart_campaign_setting_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_smart_campaign_setting_path():
    expected = {
        "customer_id": "winkle",
        "campaign_id": "nautilus",
    }
    path = GoogleAdsServiceClient.smart_campaign_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_smart_campaign_setting_path(path)
    assert expected == actual

def test_third_party_app_analytics_link_path():
    customer_id = "scallop"
    customer_link_id = "abalone"
    expected = "customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}".format(customer_id=customer_id, customer_link_id=customer_link_id, )
    actual = GoogleAdsServiceClient.third_party_app_analytics_link_path(customer_id, customer_link_id)
    assert expected == actual


def test_parse_third_party_app_analytics_link_path():
    expected = {
        "customer_id": "squid",
        "customer_link_id": "clam",
    }
    path = GoogleAdsServiceClient.third_party_app_analytics_link_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_third_party_app_analytics_link_path(path)
    assert expected == actual

def test_topic_constant_path():
    topic_id = "whelk"
    expected = "topicConstants/{topic_id}".format(topic_id=topic_id, )
    actual = GoogleAdsServiceClient.topic_constant_path(topic_id)
    assert expected == actual


def test_parse_topic_constant_path():
    expected = {
        "topic_id": "octopus",
    }
    path = GoogleAdsServiceClient.topic_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_topic_constant_path(path)
    assert expected == actual

def test_topic_view_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/topicViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.topic_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_topic_view_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.topic_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_topic_view_path(path)
    assert expected == actual

def test_user_interest_path():
    customer_id = "scallop"
    user_interest_id = "abalone"
    expected = "customers/{customer_id}/userInterests/{user_interest_id}".format(customer_id=customer_id, user_interest_id=user_interest_id, )
    actual = GoogleAdsServiceClient.user_interest_path(customer_id, user_interest_id)
    assert expected == actual


def test_parse_user_interest_path():
    expected = {
        "customer_id": "squid",
        "user_interest_id": "clam",
    }
    path = GoogleAdsServiceClient.user_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_interest_path(path)
    assert expected == actual

def test_user_list_path():
    customer_id = "whelk"
    user_list_id = "octopus"
    expected = "customers/{customer_id}/userLists/{user_list_id}".format(customer_id=customer_id, user_list_id=user_list_id, )
    actual = GoogleAdsServiceClient.user_list_path(customer_id, user_list_id)
    assert expected == actual


def test_parse_user_list_path():
    expected = {
        "customer_id": "oyster",
        "user_list_id": "nudibranch",
    }
    path = GoogleAdsServiceClient.user_list_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_list_path(path)
    assert expected == actual

def test_user_location_view_path():
    customer_id = "cuttlefish"
    country_criterion_id = "mussel"
    is_targeting_location = "winkle"
    expected = "customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}".format(customer_id=customer_id, country_criterion_id=country_criterion_id, is_targeting_location=is_targeting_location, )
    actual = GoogleAdsServiceClient.user_location_view_path(customer_id, country_criterion_id, is_targeting_location)
    assert expected == actual


def test_parse_user_location_view_path():
    expected = {
        "customer_id": "nautilus",
        "country_criterion_id": "scallop",
        "is_targeting_location": "abalone",
    }
    path = GoogleAdsServiceClient.user_location_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_user_location_view_path(path)
    assert expected == actual

def test_video_path():
    customer_id = "squid"
    video_id = "clam"
    expected = "customers/{customer_id}/videos/{video_id}".format(customer_id=customer_id, video_id=video_id, )
    actual = GoogleAdsServiceClient.video_path(customer_id, video_id)
    assert expected == actual


def test_parse_video_path():
    expected = {
        "customer_id": "whelk",
        "video_id": "octopus",
    }
    path = GoogleAdsServiceClient.video_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_video_path(path)
    assert expected == actual

def test_webpage_view_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/webpageViews/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = GoogleAdsServiceClient.webpage_view_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_webpage_view_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = GoogleAdsServiceClient.webpage_view_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_webpage_view_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "scallop"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = GoogleAdsServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "abalone",
    }
    path = GoogleAdsServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "squid"
    expected = "folders/{folder}".format(folder=folder, )
    actual = GoogleAdsServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "clam",
    }
    path = GoogleAdsServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "whelk"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = GoogleAdsServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "octopus",
    }
    path = GoogleAdsServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "oyster"
    expected = "projects/{project}".format(project=project, )
    actual = GoogleAdsServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nudibranch",
    }
    path = GoogleAdsServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "cuttlefish"
    location = "mussel"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = GoogleAdsServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "winkle",
        "location": "nautilus",
    }
    path = GoogleAdsServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = GoogleAdsServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.GoogleAdsServiceTransport, '_prep_wrapped_messages') as prep:
        client = GoogleAdsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.GoogleAdsServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = GoogleAdsServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


def test_transport_close():
    transports = {
        "grpc": "_grpc_channel",
    }

    for transport, close_name in transports.items():
        client = GoogleAdsServiceClient(
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
        client = GoogleAdsServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
