# frozen_string_literal: true

# Copyright 2022 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Ads
    module GoogleAds
      module V8
        module Services
          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#get_keyword_plan KeywordPlanService.GetKeywordPlan}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the plan to fetch.
          class GetKeywordPlanRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#mutate_keyword_plans KeywordPlanService.MutateKeywordPlans}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose keyword plans are being modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanOperation>]
          #     Required. The list of operations to perform on individual keyword plans.
          # @!attribute [rw] partial_failure
          #   @return [::Boolean]
          #     If true, successful operations will be carried out and invalid
          #     operations will return errors. If false, all operations will be carried
          #     out in one transaction if and only if they are all valid.
          #     Default is false.
          # @!attribute [rw] validate_only
          #   @return [::Boolean]
          #     If true, the request is validated but not executed. Only errors are
          #     returned, not results.
          class MutateKeywordPlansRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (create, update, remove) on a keyword plan.
          # @!attribute [rw] update_mask
          #   @return [::Google::Protobuf::FieldMask]
          #     The FieldMask that determines which resource fields are modified in an
          #     update.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V8::Resources::KeywordPlan]
          #     Create operation: No resource name is expected for the new keyword plan.
          # @!attribute [rw] update
          #   @return [::Google::Ads::GoogleAds::V8::Resources::KeywordPlan]
          #     Update operation: The keyword plan is expected to have a valid resource
          #     name.
          # @!attribute [rw] remove
          #   @return [::String]
          #     Remove operation: A resource name for the removed keyword plan is
          #     expected in this format:
          #
          #     `customers/{customer_id}/keywordPlans/{keyword_plan_id}`
          class KeywordPlanOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for a keyword plan mutate.
          # @!attribute [rw] partial_failure_error
          #   @return [::Google::Rpc::Status]
          #     Errors that pertain to operation failures in the partial failure mode.
          #     Returned only when partial_failure = true and all errors occur inside the
          #     operations. If any errors occur outside the operations (e.g. auth errors),
          #     we return an RPC level error.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::MutateKeywordPlansResult>]
          #     All results for the mutate.
          class MutateKeywordPlansResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the keyword plan mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          class MutateKeywordPlansResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_curve KeywordPlanService.GenerateForecastCurve}.
          # @!attribute [rw] keyword_plan
          #   @return [::String]
          #     Required. The resource name of the keyword plan to be forecasted.
          class GenerateForecastCurveRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_curve KeywordPlanService.GenerateForecastCurve}.
          # @!attribute [rw] campaign_forecast_curves
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanCampaignForecastCurve>]
          #     List of forecast curves for the keyword plan campaign.
          #     One maximum.
          class GenerateForecastCurveResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_time_series KeywordPlanService.GenerateForecastTimeSeries}.
          # @!attribute [rw] keyword_plan
          #   @return [::String]
          #     Required. The resource name of the keyword plan to be forecasted.
          class GenerateForecastTimeSeriesRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_time_series KeywordPlanService.GenerateForecastTimeSeries}.
          # @!attribute [rw] weekly_time_series_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanWeeklyTimeSeriesForecast>]
          #     List of weekly time series forecasts for the keyword plan campaign.
          #     One maximum.
          class GenerateForecastTimeSeriesResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_metrics KeywordPlanService.GenerateForecastMetrics}.
          # @!attribute [rw] keyword_plan
          #   @return [::String]
          #     Required. The resource name of the keyword plan to be forecasted.
          class GenerateForecastMetricsRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_forecast_metrics KeywordPlanService.GenerateForecastMetrics}.
          # @!attribute [rw] campaign_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanCampaignForecast>]
          #     List of campaign forecasts.
          #     One maximum.
          # @!attribute [rw] ad_group_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanAdGroupForecast>]
          #     List of ad group forecasts.
          # @!attribute [rw] keyword_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanKeywordForecast>]
          #     List of keyword forecasts.
          class GenerateForecastMetricsResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A campaign forecast.
          # @!attribute [rw] keyword_plan_campaign
          #   @return [::String]
          #     The resource name of the Keyword Plan campaign related to the forecast.
          #
          #     `customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}`
          # @!attribute [rw] campaign_forecast
          #   @return [::Google::Ads::GoogleAds::V8::Services::ForecastMetrics]
          #     The forecast for the Keyword Plan campaign.
          class KeywordPlanCampaignForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # An ad group forecast.
          # @!attribute [rw] keyword_plan_ad_group
          #   @return [::String]
          #     The resource name of the Keyword Plan ad group related to the forecast.
          #
          #     `customers/{customer_id}/keywordPlanAdGroups/{keyword_plan_ad_group_id}`
          # @!attribute [rw] ad_group_forecast
          #   @return [::Google::Ads::GoogleAds::V8::Services::ForecastMetrics]
          #     The forecast for the Keyword Plan ad group.
          class KeywordPlanAdGroupForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A keyword forecast.
          # @!attribute [rw] keyword_plan_ad_group_keyword
          #   @return [::String]
          #     The resource name of the Keyword Plan keyword related to the forecast.
          #
          #     `customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}`
          # @!attribute [rw] keyword_forecast
          #   @return [::Google::Ads::GoogleAds::V8::Services::ForecastMetrics]
          #     The forecast for the Keyword Plan keyword.
          class KeywordPlanKeywordForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The forecast curve for the campaign.
          # @!attribute [rw] keyword_plan_campaign
          #   @return [::String]
          #     The resource name of the Keyword Plan campaign related to the forecast.
          #
          #     `customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}`
          # @!attribute [rw] max_cpc_bid_forecast_curve
          #   @return [::Google::Ads::GoogleAds::V8::Services::KeywordPlanMaxCpcBidForecastCurve]
          #     The max cpc bid forecast curve for the campaign.
          class KeywordPlanCampaignForecastCurve
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The max cpc bid forecast curve.
          # @!attribute [rw] max_cpc_bid_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanMaxCpcBidForecast>]
          #     The forecasts for the Keyword Plan campaign at different max CPC bids.
          class KeywordPlanMaxCpcBidForecastCurve
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The forecast of the campaign at a specific bid.
          # @!attribute [rw] max_cpc_bid_micros
          #   @return [::Integer]
          #     The max cpc bid in micros.
          # @!attribute [rw] max_cpc_bid_forecast
          #   @return [::Google::Ads::GoogleAds::V8::Services::ForecastMetrics]
          #     The forecast for the Keyword Plan campaign at the specific bid.
          class KeywordPlanMaxCpcBidForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The weekly time series forecast for the keyword plan campaign.
          # @!attribute [rw] keyword_plan_campaign
          #   @return [::String]
          #     The resource name of the Keyword Plan campaign related to the forecast.
          #
          #     `customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}`
          # @!attribute [rw] weekly_forecasts
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanWeeklyForecast>]
          #     The forecasts for the Keyword Plan campaign at different max CPC bids.
          class KeywordPlanWeeklyTimeSeriesForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The forecast of the campaign for the week starting start_date.
          # @!attribute [rw] start_date
          #   @return [::String]
          #     The start date, in yyyy-mm-dd format. This date is inclusive.
          # @!attribute [rw] forecast
          #   @return [::Google::Ads::GoogleAds::V8::Services::ForecastMetrics]
          #     The forecast for the Keyword Plan campaign for the week.
          class KeywordPlanWeeklyForecast
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Forecast metrics.
          # @!attribute [rw] impressions
          #   @return [::Float]
          #     Impressions
          # @!attribute [rw] ctr
          #   @return [::Float]
          #     Ctr
          # @!attribute [rw] average_cpc
          #   @return [::Integer]
          #     AVG cpc
          # @!attribute [rw] clicks
          #   @return [::Float]
          #     Clicks
          # @!attribute [rw] cost_micros
          #   @return [::Integer]
          #     Cost
          class ForecastMetrics
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_historical_metrics KeywordPlanService.GenerateHistoricalMetrics}.
          # @!attribute [rw] keyword_plan
          #   @return [::String]
          #     Required. The resource name of the keyword plan of which historical metrics are
          #     requested.
          # @!attribute [rw] aggregate_metrics
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanAggregateMetrics]
          #     The aggregate fields to include in response.
          # @!attribute [rw] historical_metrics_options
          #   @return [::Google::Ads::GoogleAds::V8::Common::HistoricalMetricsOptions]
          #     The options for historical metrics data.
          class GenerateHistoricalMetricsRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanService::Client#generate_historical_metrics KeywordPlanService.GenerateHistoricalMetrics}.
          # @!attribute [rw] metrics
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::KeywordPlanKeywordHistoricalMetrics>]
          #     List of keyword historical metrics.
          # @!attribute [rw] aggregate_metric_results
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanAggregateMetricResults]
          #     The aggregate metrics for all the keywords in the keyword planner plan.
          class GenerateHistoricalMetricsResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A keyword historical metrics.
          # @!attribute [rw] search_query
          #   @return [::String]
          #     The text of the query associated with one or more ad_group_keywords in the
          #     plan.
          #
          #     Note that we de-dupe your keywords list, eliminating close variants before
          #     returning the plan's keywords as text. For example, if your plan originally
          #     contained the keywords 'car' and 'cars', the returned search query will
          #     only contain 'cars'.
          #     Starting V5, the list of de-duped queries will be included in
          #     close_variants field.
          # @!attribute [rw] close_variants
          #   @return [::Array<::String>]
          #     The list of close variant queries for search_query whose search results
          #     are combined into the search_query.
          # @!attribute [rw] keyword_metrics
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanHistoricalMetrics]
          #     The historical metrics for the query associated with one or more
          #     ad_group_keywords in the plan.
          class KeywordPlanKeywordHistoricalMetrics
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
