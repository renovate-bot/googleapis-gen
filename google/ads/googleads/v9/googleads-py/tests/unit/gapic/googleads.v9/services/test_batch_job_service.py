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
from google.ads.googleads.v9.enums.types import batch_job_status
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
from google.ads.googleads.v9.resources.types import batch_job
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
from google.ads.googleads.v9.services.services.batch_job_service import BatchJobServiceClient
from google.ads.googleads.v9.services.services.batch_job_service import pagers
from google.ads.googleads.v9.services.services.batch_job_service import transports
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
from google.ads.googleads.v9.services.types import batch_job_service
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
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
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

    assert BatchJobServiceClient._get_default_mtls_endpoint(None) is None
    assert BatchJobServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert BatchJobServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    BatchJobServiceClient,
])
def test_batch_job_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'googleads.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.BatchJobServiceGrpcTransport, "grpc"),
])
def test_batch_job_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    BatchJobServiceClient,
])
def test_batch_job_service_client_from_service_account_file(client_class):
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


def test_batch_job_service_client_get_transport_class():
    transport = BatchJobServiceClient.get_transport_class()
    available_transports = [
        transports.BatchJobServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = BatchJobServiceClient.get_transport_class("grpc")
    assert transport == transports.BatchJobServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (BatchJobServiceClient, transports.BatchJobServiceGrpcTransport, "grpc"),
])
@mock.patch.object(BatchJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BatchJobServiceClient))
def test_batch_job_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(BatchJobServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(BatchJobServiceClient, 'get_transport_class') as gtc:
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
    (BatchJobServiceClient, transports.BatchJobServiceGrpcTransport, "grpc", "true"),
    (BatchJobServiceClient, transports.BatchJobServiceGrpcTransport, "grpc", "false"),
])
@mock.patch.object(BatchJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(BatchJobServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_batch_job_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
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
    (BatchJobServiceClient, transports.BatchJobServiceGrpcTransport, "grpc"),
])
def test_batch_job_service_client_client_options_scopes(client_class, transport_class, transport_name):
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
    (BatchJobServiceClient, transports.BatchJobServiceGrpcTransport, "grpc"),
])
def test_batch_job_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
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

def test_batch_job_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v9.services.services.batch_job_service.transports.BatchJobServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = BatchJobServiceClient(
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
  batch_job_service.MutateBatchJobRequest,
  dict,
])
def test_mutate_batch_job(request_type, transport: str = 'grpc'):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_mutate_batch_job_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_batch_job),
            '__call__') as call:
        client.mutate_batch_job()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.MutateBatchJobRequest()


def test_mutate_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].operation
        mock_val = batch_job_service.BatchJobOperation(create=batch_job.BatchJob(resource_name='resource_name_value'))
        assert arg == mock_val


def test_mutate_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_batch_job(
            batch_job_service.MutateBatchJobRequest(),
            customer_id='customer_id_value',
            operation=batch_job_service.BatchJobOperation(create=batch_job.BatchJob(resource_name='resource_name_value')),
        )


@pytest.mark.parametrize("request_type", [
  batch_job_service.GetBatchJobRequest,
  dict,
])
def test_get_batch_job(request_type, transport: str = 'grpc'):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
            id=205,
            next_add_sequence_token='next_add_sequence_token_value',
            status=batch_job_status.BatchJobStatusEnum.BatchJobStatus.UNKNOWN,
            long_running_operation='long_running_operation_value',
        )
        response = client.get_batch_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.GetBatchJobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, batch_job.BatchJob)
    assert response.resource_name == 'resource_name_value'
    assert response.id == 205
    assert response.next_add_sequence_token == 'next_add_sequence_token_value'
    assert response.status == batch_job_status.BatchJobStatusEnum.BatchJobStatus.UNKNOWN
    assert response.long_running_operation == 'long_running_operation_value'


def test_get_batch_job_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_batch_job),
            '__call__') as call:
        client.get_batch_job()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.GetBatchJobRequest()


def test_get_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val


def test_get_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_batch_job(
            batch_job_service.GetBatchJobRequest(),
            resource_name='resource_name_value',
        )


@pytest.mark.parametrize("request_type", [
  batch_job_service.ListBatchJobResultsRequest,
  dict,
])
def test_list_batch_job_results(request_type, transport: str = 'grpc'):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_list_batch_job_results_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_batch_job_results),
            '__call__') as call:
        client.list_batch_job_results()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.ListBatchJobResultsRequest()


def test_list_batch_job_results_field_headers():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val


def test_list_batch_job_results_flattened_error():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_batch_job_results(
            batch_job_service.ListBatchJobResultsRequest(),
            resource_name='resource_name_value',
        )


def test_list_batch_job_results_pager(transport_name: str = "grpc"):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
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


def test_list_batch_job_results_pages(transport_name: str = "grpc"):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
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


@pytest.mark.parametrize("request_type", [
  batch_job_service.RunBatchJobRequest,
  dict,
])
def test_run_batch_job(request_type, transport: str = 'grpc'):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_run_batch_job_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_batch_job),
            '__call__') as call:
        client.run_batch_job()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.RunBatchJobRequest()


def test_run_batch_job_field_headers():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val


def test_run_batch_job_flattened_error():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.run_batch_job(
            batch_job_service.RunBatchJobRequest(),
            resource_name='resource_name_value',
        )


@pytest.mark.parametrize("request_type", [
  batch_job_service.AddBatchJobOperationsRequest,
  dict,
])
def test_add_batch_job_operations(request_type, transport: str = 'grpc'):
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_add_batch_job_operations_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_batch_job_operations),
            '__call__') as call:
        client.add_batch_job_operations()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == batch_job_service.AddBatchJobOperationsRequest()


def test_add_batch_job_operations_field_headers():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
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
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val
        arg = args[0].sequence_token
        mock_val = 'sequence_token_value'
        assert arg == mock_val
        arg = args[0].mutate_operations
        mock_val = [google_ads_service.MutateOperation(ad_group_ad_label_operation=ad_group_ad_label_service.AdGroupAdLabelOperation(create=ad_group_ad_label.AdGroupAdLabel(resource_name='resource_name_value')))]
        assert arg == mock_val


def test_add_batch_job_operations_flattened_error():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BatchJobServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BatchJobServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = BatchJobServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = BatchJobServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.BatchJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


@pytest.mark.parametrize("transport_class", [
    transports.BatchJobServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.BatchJobServiceGrpcTransport,
    )

def test_batch_job_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.BatchJobServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_batch_job_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v9.services.services.batch_job_service.transports.BatchJobServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.BatchJobServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
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

    with pytest.raises(NotImplementedError):
        transport.close()

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_batch_job_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.ads.googleads.v9.services.services.batch_job_service.transports.BatchJobServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BatchJobServiceTransport(
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


def test_batch_job_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.ads.googleads.v9.services.services.batch_job_service.transports.BatchJobServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.BatchJobServiceTransport()
        adc.assert_called_once()


def test_batch_job_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        BatchJobServiceClient()
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
        transports.BatchJobServiceGrpcTransport,
    ],
)
def test_batch_job_service_transport_auth_adc(transport_class):
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
        (transports.BatchJobServiceGrpcTransport, grpc_helpers),
    ],
)
def test_batch_job_service_transport_create_channel(transport_class, grpc_helpers):
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
      transports.BatchJobServiceGrpcTransport,
])
def test_batch_job_service_grpc_transport_client_cert_source_for_mtls(
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


def test_batch_job_service_host_no_port():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_batch_job_service_host_with_port():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'

def test_batch_job_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.BatchJobServiceGrpcTransport(
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
      transports.BatchJobServiceGrpcTransport,
    ])
def test_batch_job_service_transport_channel_mtls_with_client_cert_source(
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
      transports.BatchJobServiceGrpcTransport,
    ])
def test_batch_job_service_transport_channel_mtls_with_adc(
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


def test_batch_job_service_grpc_lro_client():
    client = BatchJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_accessible_bidding_strategy_path():
    customer_id = "squid"
    bidding_strategy_id = "clam"
    expected = "customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = BatchJobServiceClient.accessible_bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_accessible_bidding_strategy_path():
    expected = {
        "customer_id": "whelk",
        "bidding_strategy_id": "octopus",
    }
    path = BatchJobServiceClient.accessible_bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_accessible_bidding_strategy_path(path)
    assert expected == actual

def test_ad_path():
    customer_id = "oyster"
    ad_id = "nudibranch"
    expected = "customers/{customer_id}/ads/{ad_id}".format(customer_id=customer_id, ad_id=ad_id, )
    actual = BatchJobServiceClient.ad_path(customer_id, ad_id)
    assert expected == actual


def test_parse_ad_path():
    expected = {
        "customer_id": "cuttlefish",
        "ad_id": "mussel",
    }
    path = BatchJobServiceClient.ad_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_path(path)
    assert expected == actual

def test_ad_group_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    expected = "customers/{customer_id}/adGroups/{ad_group_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, )
    actual = BatchJobServiceClient.ad_group_path(customer_id, ad_group_id)
    assert expected == actual


def test_parse_ad_group_path():
    expected = {
        "customer_id": "scallop",
        "ad_group_id": "abalone",
    }
    path = BatchJobServiceClient.ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_path(path)
    assert expected == actual

def test_ad_group_ad_path():
    customer_id = "squid"
    ad_group_id = "clam"
    ad_id = "whelk"
    expected = "customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, )
    actual = BatchJobServiceClient.ad_group_ad_path(customer_id, ad_group_id, ad_id)
    assert expected == actual


def test_parse_ad_group_ad_path():
    expected = {
        "customer_id": "octopus",
        "ad_group_id": "oyster",
        "ad_id": "nudibranch",
    }
    path = BatchJobServiceClient.ad_group_ad_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_ad_path(path)
    assert expected == actual

def test_ad_group_ad_label_path():
    customer_id = "cuttlefish"
    ad_group_id = "mussel"
    ad_id = "winkle"
    label_id = "nautilus"
    expected = "customers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, ad_id=ad_id, label_id=label_id, )
    actual = BatchJobServiceClient.ad_group_ad_label_path(customer_id, ad_group_id, ad_id, label_id)
    assert expected == actual


def test_parse_ad_group_ad_label_path():
    expected = {
        "customer_id": "scallop",
        "ad_group_id": "abalone",
        "ad_id": "squid",
        "label_id": "clam",
    }
    path = BatchJobServiceClient.ad_group_ad_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_ad_label_path(path)
    assert expected == actual

def test_ad_group_asset_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    asset_id = "oyster"
    field_type = "nudibranch"
    expected = "customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}".format(customer_id=customer_id, ad_group_id=ad_group_id, asset_id=asset_id, field_type=field_type, )
    actual = BatchJobServiceClient.ad_group_asset_path(customer_id, ad_group_id, asset_id, field_type)
    assert expected == actual


def test_parse_ad_group_asset_path():
    expected = {
        "customer_id": "cuttlefish",
        "ad_group_id": "mussel",
        "asset_id": "winkle",
        "field_type": "nautilus",
    }
    path = BatchJobServiceClient.ad_group_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_asset_path(path)
    assert expected == actual

def test_ad_group_bid_modifier_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.ad_group_bid_modifier_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_bid_modifier_path():
    expected = {
        "customer_id": "clam",
        "ad_group_id": "whelk",
        "criterion_id": "octopus",
    }
    path = BatchJobServiceClient.ad_group_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_bid_modifier_path(path)
    assert expected == actual

def test_ad_group_criterion_path():
    customer_id = "oyster"
    ad_group_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.ad_group_criterion_path(customer_id, ad_group_id, criterion_id)
    assert expected == actual


def test_parse_ad_group_criterion_path():
    expected = {
        "customer_id": "mussel",
        "ad_group_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = BatchJobServiceClient.ad_group_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_criterion_path(path)
    assert expected == actual

def test_ad_group_criterion_customizer_path():
    customer_id = "scallop"
    ad_group_id = "abalone"
    criterion_id = "squid"
    customizer_attribute_id = "clam"
    expected = "customers/{customer_id}/adGroupCriterionCustomizers/{ad_group_id}~{criterion_id}~{customizer_attribute_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, customizer_attribute_id=customizer_attribute_id, )
    actual = BatchJobServiceClient.ad_group_criterion_customizer_path(customer_id, ad_group_id, criterion_id, customizer_attribute_id)
    assert expected == actual


def test_parse_ad_group_criterion_customizer_path():
    expected = {
        "customer_id": "whelk",
        "ad_group_id": "octopus",
        "criterion_id": "oyster",
        "customizer_attribute_id": "nudibranch",
    }
    path = BatchJobServiceClient.ad_group_criterion_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_criterion_customizer_path(path)
    assert expected == actual

def test_ad_group_criterion_label_path():
    customer_id = "cuttlefish"
    ad_group_id = "mussel"
    criterion_id = "winkle"
    label_id = "nautilus"
    expected = "customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, label_id=label_id, )
    actual = BatchJobServiceClient.ad_group_criterion_label_path(customer_id, ad_group_id, criterion_id, label_id)
    assert expected == actual


def test_parse_ad_group_criterion_label_path():
    expected = {
        "customer_id": "scallop",
        "ad_group_id": "abalone",
        "criterion_id": "squid",
        "label_id": "clam",
    }
    path = BatchJobServiceClient.ad_group_criterion_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_criterion_label_path(path)
    assert expected == actual

def test_ad_group_customizer_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    customizer_attribute_id = "oyster"
    expected = "customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, customizer_attribute_id=customizer_attribute_id, )
    actual = BatchJobServiceClient.ad_group_customizer_path(customer_id, ad_group_id, customizer_attribute_id)
    assert expected == actual


def test_parse_ad_group_customizer_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "customizer_attribute_id": "mussel",
    }
    path = BatchJobServiceClient.ad_group_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_customizer_path(path)
    assert expected == actual

def test_ad_group_extension_setting_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    extension_type = "scallop"
    expected = "customers/{customer_id}/adGroupExtensionSettings/{ad_group_id}~{extension_type}".format(customer_id=customer_id, ad_group_id=ad_group_id, extension_type=extension_type, )
    actual = BatchJobServiceClient.ad_group_extension_setting_path(customer_id, ad_group_id, extension_type)
    assert expected == actual


def test_parse_ad_group_extension_setting_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "extension_type": "clam",
    }
    path = BatchJobServiceClient.ad_group_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_extension_setting_path(path)
    assert expected == actual

def test_ad_group_feed_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    feed_id = "oyster"
    expected = "customers/{customer_id}/adGroupFeeds/{ad_group_id}~{feed_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, feed_id=feed_id, )
    actual = BatchJobServiceClient.ad_group_feed_path(customer_id, ad_group_id, feed_id)
    assert expected == actual


def test_parse_ad_group_feed_path():
    expected = {
        "customer_id": "nudibranch",
        "ad_group_id": "cuttlefish",
        "feed_id": "mussel",
    }
    path = BatchJobServiceClient.ad_group_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_feed_path(path)
    assert expected == actual

def test_ad_group_label_path():
    customer_id = "winkle"
    ad_group_id = "nautilus"
    label_id = "scallop"
    expected = "customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}".format(customer_id=customer_id, ad_group_id=ad_group_id, label_id=label_id, )
    actual = BatchJobServiceClient.ad_group_label_path(customer_id, ad_group_id, label_id)
    assert expected == actual


def test_parse_ad_group_label_path():
    expected = {
        "customer_id": "abalone",
        "ad_group_id": "squid",
        "label_id": "clam",
    }
    path = BatchJobServiceClient.ad_group_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_group_label_path(path)
    assert expected == actual

def test_ad_parameter_path():
    customer_id = "whelk"
    ad_group_id = "octopus"
    criterion_id = "oyster"
    parameter_index = "nudibranch"
    expected = "customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}".format(customer_id=customer_id, ad_group_id=ad_group_id, criterion_id=criterion_id, parameter_index=parameter_index, )
    actual = BatchJobServiceClient.ad_parameter_path(customer_id, ad_group_id, criterion_id, parameter_index)
    assert expected == actual


def test_parse_ad_parameter_path():
    expected = {
        "customer_id": "cuttlefish",
        "ad_group_id": "mussel",
        "criterion_id": "winkle",
        "parameter_index": "nautilus",
    }
    path = BatchJobServiceClient.ad_parameter_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_ad_parameter_path(path)
    assert expected == actual

def test_asset_path():
    customer_id = "scallop"
    asset_id = "abalone"
    expected = "customers/{customer_id}/assets/{asset_id}".format(customer_id=customer_id, asset_id=asset_id, )
    actual = BatchJobServiceClient.asset_path(customer_id, asset_id)
    assert expected == actual


def test_parse_asset_path():
    expected = {
        "customer_id": "squid",
        "asset_id": "clam",
    }
    path = BatchJobServiceClient.asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_path(path)
    assert expected == actual

def test_asset_group_path():
    customer_id = "whelk"
    asset_group_id = "octopus"
    expected = "customers/{customer_id}/assetGroups/{asset_group_id}".format(customer_id=customer_id, asset_group_id=asset_group_id, )
    actual = BatchJobServiceClient.asset_group_path(customer_id, asset_group_id)
    assert expected == actual


def test_parse_asset_group_path():
    expected = {
        "customer_id": "oyster",
        "asset_group_id": "nudibranch",
    }
    path = BatchJobServiceClient.asset_group_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_group_path(path)
    assert expected == actual

def test_asset_group_asset_path():
    customer_id = "cuttlefish"
    asset_group_id = "mussel"
    asset_id = "winkle"
    field_type = "nautilus"
    expected = "customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}".format(customer_id=customer_id, asset_group_id=asset_group_id, asset_id=asset_id, field_type=field_type, )
    actual = BatchJobServiceClient.asset_group_asset_path(customer_id, asset_group_id, asset_id, field_type)
    assert expected == actual


def test_parse_asset_group_asset_path():
    expected = {
        "customer_id": "scallop",
        "asset_group_id": "abalone",
        "asset_id": "squid",
        "field_type": "clam",
    }
    path = BatchJobServiceClient.asset_group_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_group_asset_path(path)
    assert expected == actual

def test_asset_group_listing_group_filter_path():
    customer_id = "whelk"
    asset_group_id = "octopus"
    listing_group_filter_id = "oyster"
    expected = "customers/{customer_id}/assetGroupListingGroupFilters/{asset_group_id}~{listing_group_filter_id}".format(customer_id=customer_id, asset_group_id=asset_group_id, listing_group_filter_id=listing_group_filter_id, )
    actual = BatchJobServiceClient.asset_group_listing_group_filter_path(customer_id, asset_group_id, listing_group_filter_id)
    assert expected == actual


def test_parse_asset_group_listing_group_filter_path():
    expected = {
        "customer_id": "nudibranch",
        "asset_group_id": "cuttlefish",
        "listing_group_filter_id": "mussel",
    }
    path = BatchJobServiceClient.asset_group_listing_group_filter_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_group_listing_group_filter_path(path)
    assert expected == actual

def test_asset_set_path():
    customer_id = "winkle"
    asset_set_id = "nautilus"
    expected = "customers/{customer_id}/assetSets/{asset_set_id}".format(customer_id=customer_id, asset_set_id=asset_set_id, )
    actual = BatchJobServiceClient.asset_set_path(customer_id, asset_set_id)
    assert expected == actual


def test_parse_asset_set_path():
    expected = {
        "customer_id": "scallop",
        "asset_set_id": "abalone",
    }
    path = BatchJobServiceClient.asset_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_set_path(path)
    assert expected == actual

def test_asset_set_asset_path():
    customer_id = "squid"
    asset_set_id = "clam"
    asset_id = "whelk"
    expected = "customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}".format(customer_id=customer_id, asset_set_id=asset_set_id, asset_id=asset_id, )
    actual = BatchJobServiceClient.asset_set_asset_path(customer_id, asset_set_id, asset_id)
    assert expected == actual


def test_parse_asset_set_asset_path():
    expected = {
        "customer_id": "octopus",
        "asset_set_id": "oyster",
        "asset_id": "nudibranch",
    }
    path = BatchJobServiceClient.asset_set_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_asset_set_asset_path(path)
    assert expected == actual

def test_batch_job_path():
    customer_id = "cuttlefish"
    batch_job_id = "mussel"
    expected = "customers/{customer_id}/batchJobs/{batch_job_id}".format(customer_id=customer_id, batch_job_id=batch_job_id, )
    actual = BatchJobServiceClient.batch_job_path(customer_id, batch_job_id)
    assert expected == actual


def test_parse_batch_job_path():
    expected = {
        "customer_id": "winkle",
        "batch_job_id": "nautilus",
    }
    path = BatchJobServiceClient.batch_job_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_batch_job_path(path)
    assert expected == actual

def test_bidding_data_exclusion_path():
    customer_id = "scallop"
    seasonality_event_id = "abalone"
    expected = "customers/{customer_id}/biddingDataExclusions/{seasonality_event_id}".format(customer_id=customer_id, seasonality_event_id=seasonality_event_id, )
    actual = BatchJobServiceClient.bidding_data_exclusion_path(customer_id, seasonality_event_id)
    assert expected == actual


def test_parse_bidding_data_exclusion_path():
    expected = {
        "customer_id": "squid",
        "seasonality_event_id": "clam",
    }
    path = BatchJobServiceClient.bidding_data_exclusion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_bidding_data_exclusion_path(path)
    assert expected == actual

def test_bidding_seasonality_adjustment_path():
    customer_id = "whelk"
    seasonality_event_id = "octopus"
    expected = "customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}".format(customer_id=customer_id, seasonality_event_id=seasonality_event_id, )
    actual = BatchJobServiceClient.bidding_seasonality_adjustment_path(customer_id, seasonality_event_id)
    assert expected == actual


def test_parse_bidding_seasonality_adjustment_path():
    expected = {
        "customer_id": "oyster",
        "seasonality_event_id": "nudibranch",
    }
    path = BatchJobServiceClient.bidding_seasonality_adjustment_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_bidding_seasonality_adjustment_path(path)
    assert expected == actual

def test_bidding_strategy_path():
    customer_id = "cuttlefish"
    bidding_strategy_id = "mussel"
    expected = "customers/{customer_id}/biddingStrategies/{bidding_strategy_id}".format(customer_id=customer_id, bidding_strategy_id=bidding_strategy_id, )
    actual = BatchJobServiceClient.bidding_strategy_path(customer_id, bidding_strategy_id)
    assert expected == actual


def test_parse_bidding_strategy_path():
    expected = {
        "customer_id": "winkle",
        "bidding_strategy_id": "nautilus",
    }
    path = BatchJobServiceClient.bidding_strategy_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_bidding_strategy_path(path)
    assert expected == actual

def test_campaign_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    expected = "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = BatchJobServiceClient.campaign_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
        "customer_id": "squid",
        "campaign_id": "clam",
    }
    path = BatchJobServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_asset_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    asset_id = "oyster"
    field_type = "nudibranch"
    expected = "customers/{customer_id}/campaignAssets/{campaign_id}~{asset_id}~{field_type}".format(customer_id=customer_id, campaign_id=campaign_id, asset_id=asset_id, field_type=field_type, )
    actual = BatchJobServiceClient.campaign_asset_path(customer_id, campaign_id, asset_id, field_type)
    assert expected == actual


def test_parse_campaign_asset_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
        "asset_id": "winkle",
        "field_type": "nautilus",
    }
    path = BatchJobServiceClient.campaign_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_asset_path(path)
    assert expected == actual

def test_campaign_asset_set_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    asset_set_id = "squid"
    expected = "customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}".format(customer_id=customer_id, campaign_id=campaign_id, asset_set_id=asset_set_id, )
    actual = BatchJobServiceClient.campaign_asset_set_path(customer_id, campaign_id, asset_set_id)
    assert expected == actual


def test_parse_campaign_asset_set_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "asset_set_id": "octopus",
    }
    path = BatchJobServiceClient.campaign_asset_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_asset_set_path(path)
    assert expected == actual

def test_campaign_bid_modifier_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    criterion_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.campaign_bid_modifier_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_bid_modifier_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "criterion_id": "nautilus",
    }
    path = BatchJobServiceClient.campaign_bid_modifier_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_bid_modifier_path(path)
    assert expected == actual

def test_campaign_budget_path():
    customer_id = "scallop"
    campaign_budget_id = "abalone"
    expected = "customers/{customer_id}/campaignBudgets/{campaign_budget_id}".format(customer_id=customer_id, campaign_budget_id=campaign_budget_id, )
    actual = BatchJobServiceClient.campaign_budget_path(customer_id, campaign_budget_id)
    assert expected == actual


def test_parse_campaign_budget_path():
    expected = {
        "customer_id": "squid",
        "campaign_budget_id": "clam",
    }
    path = BatchJobServiceClient.campaign_budget_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_budget_path(path)
    assert expected == actual

def test_campaign_conversion_goal_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    category = "oyster"
    source = "nudibranch"
    expected = "customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}".format(customer_id=customer_id, campaign_id=campaign_id, category=category, source=source, )
    actual = BatchJobServiceClient.campaign_conversion_goal_path(customer_id, campaign_id, category, source)
    assert expected == actual


def test_parse_campaign_conversion_goal_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
        "category": "winkle",
        "source": "nautilus",
    }
    path = BatchJobServiceClient.campaign_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_conversion_goal_path(path)
    assert expected == actual

def test_campaign_criterion_path():
    customer_id = "scallop"
    campaign_id = "abalone"
    criterion_id = "squid"
    expected = "customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}".format(customer_id=customer_id, campaign_id=campaign_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.campaign_criterion_path(customer_id, campaign_id, criterion_id)
    assert expected == actual


def test_parse_campaign_criterion_path():
    expected = {
        "customer_id": "clam",
        "campaign_id": "whelk",
        "criterion_id": "octopus",
    }
    path = BatchJobServiceClient.campaign_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_criterion_path(path)
    assert expected == actual

def test_campaign_customizer_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    customizer_attribute_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignCustomizers/{campaign_id}~{customizer_attribute_id}".format(customer_id=customer_id, campaign_id=campaign_id, customizer_attribute_id=customizer_attribute_id, )
    actual = BatchJobServiceClient.campaign_customizer_path(customer_id, campaign_id, customizer_attribute_id)
    assert expected == actual


def test_parse_campaign_customizer_path():
    expected = {
        "customer_id": "mussel",
        "campaign_id": "winkle",
        "customizer_attribute_id": "nautilus",
    }
    path = BatchJobServiceClient.campaign_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_customizer_path(path)
    assert expected == actual

def test_campaign_draft_path():
    customer_id = "scallop"
    base_campaign_id = "abalone"
    draft_id = "squid"
    expected = "customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}".format(customer_id=customer_id, base_campaign_id=base_campaign_id, draft_id=draft_id, )
    actual = BatchJobServiceClient.campaign_draft_path(customer_id, base_campaign_id, draft_id)
    assert expected == actual


def test_parse_campaign_draft_path():
    expected = {
        "customer_id": "clam",
        "base_campaign_id": "whelk",
        "draft_id": "octopus",
    }
    path = BatchJobServiceClient.campaign_draft_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_draft_path(path)
    assert expected == actual

def test_campaign_experiment_path():
    customer_id = "oyster"
    campaign_experiment_id = "nudibranch"
    expected = "customers/{customer_id}/campaignExperiments/{campaign_experiment_id}".format(customer_id=customer_id, campaign_experiment_id=campaign_experiment_id, )
    actual = BatchJobServiceClient.campaign_experiment_path(customer_id, campaign_experiment_id)
    assert expected == actual


def test_parse_campaign_experiment_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_experiment_id": "mussel",
    }
    path = BatchJobServiceClient.campaign_experiment_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_experiment_path(path)
    assert expected == actual

def test_campaign_extension_setting_path():
    customer_id = "winkle"
    campaign_id = "nautilus"
    extension_type = "scallop"
    expected = "customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}".format(customer_id=customer_id, campaign_id=campaign_id, extension_type=extension_type, )
    actual = BatchJobServiceClient.campaign_extension_setting_path(customer_id, campaign_id, extension_type)
    assert expected == actual


def test_parse_campaign_extension_setting_path():
    expected = {
        "customer_id": "abalone",
        "campaign_id": "squid",
        "extension_type": "clam",
    }
    path = BatchJobServiceClient.campaign_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_extension_setting_path(path)
    assert expected == actual

def test_campaign_feed_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    feed_id = "oyster"
    expected = "customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}".format(customer_id=customer_id, campaign_id=campaign_id, feed_id=feed_id, )
    actual = BatchJobServiceClient.campaign_feed_path(customer_id, campaign_id, feed_id)
    assert expected == actual


def test_parse_campaign_feed_path():
    expected = {
        "customer_id": "nudibranch",
        "campaign_id": "cuttlefish",
        "feed_id": "mussel",
    }
    path = BatchJobServiceClient.campaign_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_feed_path(path)
    assert expected == actual

def test_campaign_label_path():
    customer_id = "winkle"
    campaign_id = "nautilus"
    label_id = "scallop"
    expected = "customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}".format(customer_id=customer_id, campaign_id=campaign_id, label_id=label_id, )
    actual = BatchJobServiceClient.campaign_label_path(customer_id, campaign_id, label_id)
    assert expected == actual


def test_parse_campaign_label_path():
    expected = {
        "customer_id": "abalone",
        "campaign_id": "squid",
        "label_id": "clam",
    }
    path = BatchJobServiceClient.campaign_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_label_path(path)
    assert expected == actual

def test_campaign_shared_set_path():
    customer_id = "whelk"
    campaign_id = "octopus"
    shared_set_id = "oyster"
    expected = "customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}".format(customer_id=customer_id, campaign_id=campaign_id, shared_set_id=shared_set_id, )
    actual = BatchJobServiceClient.campaign_shared_set_path(customer_id, campaign_id, shared_set_id)
    assert expected == actual


def test_parse_campaign_shared_set_path():
    expected = {
        "customer_id": "nudibranch",
        "campaign_id": "cuttlefish",
        "shared_set_id": "mussel",
    }
    path = BatchJobServiceClient.campaign_shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_campaign_shared_set_path(path)
    assert expected == actual

def test_conversion_action_path():
    customer_id = "winkle"
    conversion_action_id = "nautilus"
    expected = "customers/{customer_id}/conversionActions/{conversion_action_id}".format(customer_id=customer_id, conversion_action_id=conversion_action_id, )
    actual = BatchJobServiceClient.conversion_action_path(customer_id, conversion_action_id)
    assert expected == actual


def test_parse_conversion_action_path():
    expected = {
        "customer_id": "scallop",
        "conversion_action_id": "abalone",
    }
    path = BatchJobServiceClient.conversion_action_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_action_path(path)
    assert expected == actual

def test_conversion_custom_variable_path():
    customer_id = "squid"
    conversion_custom_variable_id = "clam"
    expected = "customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}".format(customer_id=customer_id, conversion_custom_variable_id=conversion_custom_variable_id, )
    actual = BatchJobServiceClient.conversion_custom_variable_path(customer_id, conversion_custom_variable_id)
    assert expected == actual


def test_parse_conversion_custom_variable_path():
    expected = {
        "customer_id": "whelk",
        "conversion_custom_variable_id": "octopus",
    }
    path = BatchJobServiceClient.conversion_custom_variable_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_custom_variable_path(path)
    assert expected == actual

def test_conversion_goal_campaign_config_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    expected = "customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = BatchJobServiceClient.conversion_goal_campaign_config_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_conversion_goal_campaign_config_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
    }
    path = BatchJobServiceClient.conversion_goal_campaign_config_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_goal_campaign_config_path(path)
    assert expected == actual

def test_conversion_value_rule_path():
    customer_id = "winkle"
    conversion_value_rule_id = "nautilus"
    expected = "customers/{customer_id}/conversionValueRules/{conversion_value_rule_id}".format(customer_id=customer_id, conversion_value_rule_id=conversion_value_rule_id, )
    actual = BatchJobServiceClient.conversion_value_rule_path(customer_id, conversion_value_rule_id)
    assert expected == actual


def test_parse_conversion_value_rule_path():
    expected = {
        "customer_id": "scallop",
        "conversion_value_rule_id": "abalone",
    }
    path = BatchJobServiceClient.conversion_value_rule_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_value_rule_path(path)
    assert expected == actual

def test_conversion_value_rule_set_path():
    customer_id = "squid"
    conversion_value_rule_set_id = "clam"
    expected = "customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}".format(customer_id=customer_id, conversion_value_rule_set_id=conversion_value_rule_set_id, )
    actual = BatchJobServiceClient.conversion_value_rule_set_path(customer_id, conversion_value_rule_set_id)
    assert expected == actual


def test_parse_conversion_value_rule_set_path():
    expected = {
        "customer_id": "whelk",
        "conversion_value_rule_set_id": "octopus",
    }
    path = BatchJobServiceClient.conversion_value_rule_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_conversion_value_rule_set_path(path)
    assert expected == actual

def test_custom_conversion_goal_path():
    customer_id = "oyster"
    goal_id = "nudibranch"
    expected = "customers/{customer_id}/customConversionGoals/{goal_id}".format(customer_id=customer_id, goal_id=goal_id, )
    actual = BatchJobServiceClient.custom_conversion_goal_path(customer_id, goal_id)
    assert expected == actual


def test_parse_custom_conversion_goal_path():
    expected = {
        "customer_id": "cuttlefish",
        "goal_id": "mussel",
    }
    path = BatchJobServiceClient.custom_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_custom_conversion_goal_path(path)
    assert expected == actual

def test_customer_path():
    customer_id = "winkle"
    expected = "customers/{customer_id}".format(customer_id=customer_id, )
    actual = BatchJobServiceClient.customer_path(customer_id)
    assert expected == actual


def test_parse_customer_path():
    expected = {
        "customer_id": "nautilus",
    }
    path = BatchJobServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_path(path)
    assert expected == actual

def test_customer_asset_path():
    customer_id = "scallop"
    asset_id = "abalone"
    field_type = "squid"
    expected = "customers/{customer_id}/customerAssets/{asset_id}~{field_type}".format(customer_id=customer_id, asset_id=asset_id, field_type=field_type, )
    actual = BatchJobServiceClient.customer_asset_path(customer_id, asset_id, field_type)
    assert expected == actual


def test_parse_customer_asset_path():
    expected = {
        "customer_id": "clam",
        "asset_id": "whelk",
        "field_type": "octopus",
    }
    path = BatchJobServiceClient.customer_asset_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_asset_path(path)
    assert expected == actual

def test_customer_conversion_goal_path():
    customer_id = "oyster"
    category = "nudibranch"
    source = "cuttlefish"
    expected = "customers/{customer_id}/customerConversionGoals/{category}~{source}".format(customer_id=customer_id, category=category, source=source, )
    actual = BatchJobServiceClient.customer_conversion_goal_path(customer_id, category, source)
    assert expected == actual


def test_parse_customer_conversion_goal_path():
    expected = {
        "customer_id": "mussel",
        "category": "winkle",
        "source": "nautilus",
    }
    path = BatchJobServiceClient.customer_conversion_goal_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_conversion_goal_path(path)
    assert expected == actual

def test_customer_customizer_path():
    customer_id = "scallop"
    customizer_attribute_id = "abalone"
    expected = "customers/{customer_id}/customerCustomizers/{customizer_attribute_id}".format(customer_id=customer_id, customizer_attribute_id=customizer_attribute_id, )
    actual = BatchJobServiceClient.customer_customizer_path(customer_id, customizer_attribute_id)
    assert expected == actual


def test_parse_customer_customizer_path():
    expected = {
        "customer_id": "squid",
        "customizer_attribute_id": "clam",
    }
    path = BatchJobServiceClient.customer_customizer_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_customizer_path(path)
    assert expected == actual

def test_customer_extension_setting_path():
    customer_id = "whelk"
    extension_type = "octopus"
    expected = "customers/{customer_id}/customerExtensionSettings/{extension_type}".format(customer_id=customer_id, extension_type=extension_type, )
    actual = BatchJobServiceClient.customer_extension_setting_path(customer_id, extension_type)
    assert expected == actual


def test_parse_customer_extension_setting_path():
    expected = {
        "customer_id": "oyster",
        "extension_type": "nudibranch",
    }
    path = BatchJobServiceClient.customer_extension_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_extension_setting_path(path)
    assert expected == actual

def test_customer_feed_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    expected = "customers/{customer_id}/customerFeeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = BatchJobServiceClient.customer_feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_customer_feed_path():
    expected = {
        "customer_id": "winkle",
        "feed_id": "nautilus",
    }
    path = BatchJobServiceClient.customer_feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_feed_path(path)
    assert expected == actual

def test_customer_label_path():
    customer_id = "scallop"
    label_id = "abalone"
    expected = "customers/{customer_id}/customerLabels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = BatchJobServiceClient.customer_label_path(customer_id, label_id)
    assert expected == actual


def test_parse_customer_label_path():
    expected = {
        "customer_id": "squid",
        "label_id": "clam",
    }
    path = BatchJobServiceClient.customer_label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_label_path(path)
    assert expected == actual

def test_customer_negative_criterion_path():
    customer_id = "whelk"
    criterion_id = "octopus"
    expected = "customers/{customer_id}/customerNegativeCriteria/{criterion_id}".format(customer_id=customer_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.customer_negative_criterion_path(customer_id, criterion_id)
    assert expected == actual


def test_parse_customer_negative_criterion_path():
    expected = {
        "customer_id": "oyster",
        "criterion_id": "nudibranch",
    }
    path = BatchJobServiceClient.customer_negative_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customer_negative_criterion_path(path)
    assert expected == actual

def test_customizer_attribute_path():
    customer_id = "cuttlefish"
    customizer_attribute_id = "mussel"
    expected = "customers/{customer_id}/customizerAttributes/{customizer_attribute_id}".format(customer_id=customer_id, customizer_attribute_id=customizer_attribute_id, )
    actual = BatchJobServiceClient.customizer_attribute_path(customer_id, customizer_attribute_id)
    assert expected == actual


def test_parse_customizer_attribute_path():
    expected = {
        "customer_id": "winkle",
        "customizer_attribute_id": "nautilus",
    }
    path = BatchJobServiceClient.customizer_attribute_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_customizer_attribute_path(path)
    assert expected == actual

def test_extension_feed_item_path():
    customer_id = "scallop"
    feed_item_id = "abalone"
    expected = "customers/{customer_id}/extensionFeedItems/{feed_item_id}".format(customer_id=customer_id, feed_item_id=feed_item_id, )
    actual = BatchJobServiceClient.extension_feed_item_path(customer_id, feed_item_id)
    assert expected == actual


def test_parse_extension_feed_item_path():
    expected = {
        "customer_id": "squid",
        "feed_item_id": "clam",
    }
    path = BatchJobServiceClient.extension_feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_extension_feed_item_path(path)
    assert expected == actual

def test_feed_path():
    customer_id = "whelk"
    feed_id = "octopus"
    expected = "customers/{customer_id}/feeds/{feed_id}".format(customer_id=customer_id, feed_id=feed_id, )
    actual = BatchJobServiceClient.feed_path(customer_id, feed_id)
    assert expected == actual


def test_parse_feed_path():
    expected = {
        "customer_id": "oyster",
        "feed_id": "nudibranch",
    }
    path = BatchJobServiceClient.feed_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_path(path)
    assert expected == actual

def test_feed_item_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    feed_item_id = "winkle"
    expected = "customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_id=feed_item_id, )
    actual = BatchJobServiceClient.feed_item_path(customer_id, feed_id, feed_item_id)
    assert expected == actual


def test_parse_feed_item_path():
    expected = {
        "customer_id": "nautilus",
        "feed_id": "scallop",
        "feed_item_id": "abalone",
    }
    path = BatchJobServiceClient.feed_item_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_path(path)
    assert expected == actual

def test_feed_item_set_path():
    customer_id = "squid"
    feed_id = "clam"
    feed_item_set_id = "whelk"
    expected = "customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_set_id=feed_item_set_id, )
    actual = BatchJobServiceClient.feed_item_set_path(customer_id, feed_id, feed_item_set_id)
    assert expected == actual


def test_parse_feed_item_set_path():
    expected = {
        "customer_id": "octopus",
        "feed_id": "oyster",
        "feed_item_set_id": "nudibranch",
    }
    path = BatchJobServiceClient.feed_item_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_set_path(path)
    assert expected == actual

def test_feed_item_set_link_path():
    customer_id = "cuttlefish"
    feed_id = "mussel"
    feed_item_set_id = "winkle"
    feed_item_id = "nautilus"
    expected = "customers/{customer_id}/feedItemSetLinks/{feed_id}~{feed_item_set_id}~{feed_item_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_set_id=feed_item_set_id, feed_item_id=feed_item_id, )
    actual = BatchJobServiceClient.feed_item_set_link_path(customer_id, feed_id, feed_item_set_id, feed_item_id)
    assert expected == actual


def test_parse_feed_item_set_link_path():
    expected = {
        "customer_id": "scallop",
        "feed_id": "abalone",
        "feed_item_set_id": "squid",
        "feed_item_id": "clam",
    }
    path = BatchJobServiceClient.feed_item_set_link_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_set_link_path(path)
    assert expected == actual

def test_feed_item_target_path():
    customer_id = "whelk"
    feed_id = "octopus"
    feed_item_id = "oyster"
    feed_item_target_type = "nudibranch"
    feed_item_target_id = "cuttlefish"
    expected = "customers/{customer_id}/feedItemTargets/{feed_id}~{feed_item_id}~{feed_item_target_type}~{feed_item_target_id}".format(customer_id=customer_id, feed_id=feed_id, feed_item_id=feed_item_id, feed_item_target_type=feed_item_target_type, feed_item_target_id=feed_item_target_id, )
    actual = BatchJobServiceClient.feed_item_target_path(customer_id, feed_id, feed_item_id, feed_item_target_type, feed_item_target_id)
    assert expected == actual


def test_parse_feed_item_target_path():
    expected = {
        "customer_id": "mussel",
        "feed_id": "winkle",
        "feed_item_id": "nautilus",
        "feed_item_target_type": "scallop",
        "feed_item_target_id": "abalone",
    }
    path = BatchJobServiceClient.feed_item_target_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_item_target_path(path)
    assert expected == actual

def test_feed_mapping_path():
    customer_id = "squid"
    feed_id = "clam"
    feed_mapping_id = "whelk"
    expected = "customers/{customer_id}/feedMappings/{feed_id}~{feed_mapping_id}".format(customer_id=customer_id, feed_id=feed_id, feed_mapping_id=feed_mapping_id, )
    actual = BatchJobServiceClient.feed_mapping_path(customer_id, feed_id, feed_mapping_id)
    assert expected == actual


def test_parse_feed_mapping_path():
    expected = {
        "customer_id": "octopus",
        "feed_id": "oyster",
        "feed_mapping_id": "nudibranch",
    }
    path = BatchJobServiceClient.feed_mapping_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_feed_mapping_path(path)
    assert expected == actual

def test_geo_target_constant_path():
    criterion_id = "cuttlefish"
    expected = "geoTargetConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = BatchJobServiceClient.geo_target_constant_path(criterion_id)
    assert expected == actual


def test_parse_geo_target_constant_path():
    expected = {
        "criterion_id": "mussel",
    }
    path = BatchJobServiceClient.geo_target_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_geo_target_constant_path(path)
    assert expected == actual

def test_keyword_plan_path():
    customer_id = "winkle"
    keyword_plan_id = "nautilus"
    expected = "customers/{customer_id}/keywordPlans/{keyword_plan_id}".format(customer_id=customer_id, keyword_plan_id=keyword_plan_id, )
    actual = BatchJobServiceClient.keyword_plan_path(customer_id, keyword_plan_id)
    assert expected == actual


def test_parse_keyword_plan_path():
    expected = {
        "customer_id": "scallop",
        "keyword_plan_id": "abalone",
    }
    path = BatchJobServiceClient.keyword_plan_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_path():
    customer_id = "squid"
    keyword_plan_ad_group_id = "clam"
    expected = "customers/{customer_id}/keywordPlanAdGroups/{keyword_plan_ad_group_id}".format(customer_id=customer_id, keyword_plan_ad_group_id=keyword_plan_ad_group_id, )
    actual = BatchJobServiceClient.keyword_plan_ad_group_path(customer_id, keyword_plan_ad_group_id)
    assert expected == actual


def test_parse_keyword_plan_ad_group_path():
    expected = {
        "customer_id": "whelk",
        "keyword_plan_ad_group_id": "octopus",
    }
    path = BatchJobServiceClient.keyword_plan_ad_group_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_ad_group_path(path)
    assert expected == actual

def test_keyword_plan_ad_group_keyword_path():
    customer_id = "oyster"
    keyword_plan_ad_group_keyword_id = "nudibranch"
    expected = "customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}".format(customer_id=customer_id, keyword_plan_ad_group_keyword_id=keyword_plan_ad_group_keyword_id, )
    actual = BatchJobServiceClient.keyword_plan_ad_group_keyword_path(customer_id, keyword_plan_ad_group_keyword_id)
    assert expected == actual


def test_parse_keyword_plan_ad_group_keyword_path():
    expected = {
        "customer_id": "cuttlefish",
        "keyword_plan_ad_group_keyword_id": "mussel",
    }
    path = BatchJobServiceClient.keyword_plan_ad_group_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_ad_group_keyword_path(path)
    assert expected == actual

def test_keyword_plan_campaign_path():
    customer_id = "winkle"
    keyword_plan_campaign_id = "nautilus"
    expected = "customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}".format(customer_id=customer_id, keyword_plan_campaign_id=keyword_plan_campaign_id, )
    actual = BatchJobServiceClient.keyword_plan_campaign_path(customer_id, keyword_plan_campaign_id)
    assert expected == actual


def test_parse_keyword_plan_campaign_path():
    expected = {
        "customer_id": "scallop",
        "keyword_plan_campaign_id": "abalone",
    }
    path = BatchJobServiceClient.keyword_plan_campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_campaign_path(path)
    assert expected == actual

def test_keyword_plan_campaign_keyword_path():
    customer_id = "squid"
    keyword_plan_campaign_keyword_id = "clam"
    expected = "customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}".format(customer_id=customer_id, keyword_plan_campaign_keyword_id=keyword_plan_campaign_keyword_id, )
    actual = BatchJobServiceClient.keyword_plan_campaign_keyword_path(customer_id, keyword_plan_campaign_keyword_id)
    assert expected == actual


def test_parse_keyword_plan_campaign_keyword_path():
    expected = {
        "customer_id": "whelk",
        "keyword_plan_campaign_keyword_id": "octopus",
    }
    path = BatchJobServiceClient.keyword_plan_campaign_keyword_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_keyword_plan_campaign_keyword_path(path)
    assert expected == actual

def test_label_path():
    customer_id = "oyster"
    label_id = "nudibranch"
    expected = "customers/{customer_id}/labels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = BatchJobServiceClient.label_path(customer_id, label_id)
    assert expected == actual


def test_parse_label_path():
    expected = {
        "customer_id": "cuttlefish",
        "label_id": "mussel",
    }
    path = BatchJobServiceClient.label_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_label_path(path)
    assert expected == actual

def test_language_constant_path():
    criterion_id = "winkle"
    expected = "languageConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = BatchJobServiceClient.language_constant_path(criterion_id)
    assert expected == actual


def test_parse_language_constant_path():
    expected = {
        "criterion_id": "nautilus",
    }
    path = BatchJobServiceClient.language_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_language_constant_path(path)
    assert expected == actual

def test_media_file_path():
    customer_id = "scallop"
    media_file_id = "abalone"
    expected = "customers/{customer_id}/mediaFiles/{media_file_id}".format(customer_id=customer_id, media_file_id=media_file_id, )
    actual = BatchJobServiceClient.media_file_path(customer_id, media_file_id)
    assert expected == actual


def test_parse_media_file_path():
    expected = {
        "customer_id": "squid",
        "media_file_id": "clam",
    }
    path = BatchJobServiceClient.media_file_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_media_file_path(path)
    assert expected == actual

def test_remarketing_action_path():
    customer_id = "whelk"
    remarketing_action_id = "octopus"
    expected = "customers/{customer_id}/remarketingActions/{remarketing_action_id}".format(customer_id=customer_id, remarketing_action_id=remarketing_action_id, )
    actual = BatchJobServiceClient.remarketing_action_path(customer_id, remarketing_action_id)
    assert expected == actual


def test_parse_remarketing_action_path():
    expected = {
        "customer_id": "oyster",
        "remarketing_action_id": "nudibranch",
    }
    path = BatchJobServiceClient.remarketing_action_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_remarketing_action_path(path)
    assert expected == actual

def test_shared_criterion_path():
    customer_id = "cuttlefish"
    shared_set_id = "mussel"
    criterion_id = "winkle"
    expected = "customers/{customer_id}/sharedCriteria/{shared_set_id}~{criterion_id}".format(customer_id=customer_id, shared_set_id=shared_set_id, criterion_id=criterion_id, )
    actual = BatchJobServiceClient.shared_criterion_path(customer_id, shared_set_id, criterion_id)
    assert expected == actual


def test_parse_shared_criterion_path():
    expected = {
        "customer_id": "nautilus",
        "shared_set_id": "scallop",
        "criterion_id": "abalone",
    }
    path = BatchJobServiceClient.shared_criterion_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_shared_criterion_path(path)
    assert expected == actual

def test_shared_set_path():
    customer_id = "squid"
    shared_set_id = "clam"
    expected = "customers/{customer_id}/sharedSets/{shared_set_id}".format(customer_id=customer_id, shared_set_id=shared_set_id, )
    actual = BatchJobServiceClient.shared_set_path(customer_id, shared_set_id)
    assert expected == actual


def test_parse_shared_set_path():
    expected = {
        "customer_id": "whelk",
        "shared_set_id": "octopus",
    }
    path = BatchJobServiceClient.shared_set_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_shared_set_path(path)
    assert expected == actual

def test_smart_campaign_setting_path():
    customer_id = "oyster"
    campaign_id = "nudibranch"
    expected = "customers/{customer_id}/smartCampaignSettings/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = BatchJobServiceClient.smart_campaign_setting_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_smart_campaign_setting_path():
    expected = {
        "customer_id": "cuttlefish",
        "campaign_id": "mussel",
    }
    path = BatchJobServiceClient.smart_campaign_setting_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_smart_campaign_setting_path(path)
    assert expected == actual

def test_user_interest_path():
    customer_id = "winkle"
    user_interest_id = "nautilus"
    expected = "customers/{customer_id}/userInterests/{user_interest_id}".format(customer_id=customer_id, user_interest_id=user_interest_id, )
    actual = BatchJobServiceClient.user_interest_path(customer_id, user_interest_id)
    assert expected == actual


def test_parse_user_interest_path():
    expected = {
        "customer_id": "scallop",
        "user_interest_id": "abalone",
    }
    path = BatchJobServiceClient.user_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_user_interest_path(path)
    assert expected == actual

def test_user_list_path():
    customer_id = "squid"
    user_list_id = "clam"
    expected = "customers/{customer_id}/userLists/{user_list_id}".format(customer_id=customer_id, user_list_id=user_list_id, )
    actual = BatchJobServiceClient.user_list_path(customer_id, user_list_id)
    assert expected == actual


def test_parse_user_list_path():
    expected = {
        "customer_id": "whelk",
        "user_list_id": "octopus",
    }
    path = BatchJobServiceClient.user_list_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_user_list_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = BatchJobServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nudibranch",
    }
    path = BatchJobServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"
    expected = "folders/{folder}".format(folder=folder, )
    actual = BatchJobServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "mussel",
    }
    path = BatchJobServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = BatchJobServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nautilus",
    }
    path = BatchJobServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"
    expected = "projects/{project}".format(project=project, )
    actual = BatchJobServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "abalone",
    }
    path = BatchJobServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = BatchJobServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "whelk",
        "location": "octopus",
    }
    path = BatchJobServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = BatchJobServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.BatchJobServiceTransport, '_prep_wrapped_messages') as prep:
        client = BatchJobServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.BatchJobServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = BatchJobServiceClient.get_transport_class()
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
        client = BatchJobServiceClient(
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
        client = BatchJobServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
