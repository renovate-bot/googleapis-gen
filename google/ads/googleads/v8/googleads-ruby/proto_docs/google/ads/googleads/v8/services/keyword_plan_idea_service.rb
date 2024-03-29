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
          # Request message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanIdeaService::Client#generate_keyword_ideas KeywordPlanIdeaService.GenerateKeywordIdeas}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     The ID of the customer with the recommendation.
          # @!attribute [rw] language
          #   @return [::String]
          #     The resource name of the language to target.
          #     Required
          # @!attribute [rw] geo_target_constants
          #   @return [::Array<::String>]
          #     The resource names of the location to target.
          #     Max 10
          # @!attribute [rw] include_adult_keywords
          #   @return [::Boolean]
          #     If true, adult keywords will be included in response.
          #     The default value is false.
          # @!attribute [rw] page_token
          #   @return [::String]
          #     Token of the page to retrieve. If not specified, the first
          #     page of results will be returned. To request next page of results use the
          #     value obtained from `next_page_token` in the previous response.
          #     The request fields must match across pages.
          # @!attribute [rw] page_size
          #   @return [::Integer]
          #     Number of results to retrieve in a single page.
          #     A maximum of 10,000 results may be returned, if the page_size
          #     exceeds this, it is ignored.
          #     If unspecified, at most 10,000 results will be returned.
          #     The server may decide to further limit the number of returned resources.
          #     If the response contains fewer than 10,000 results it may not be assumed
          #     as last page of results.
          # @!attribute [rw] keyword_plan_network
          #   @return [::Google::Ads::GoogleAds::V8::Enums::KeywordPlanNetworkEnum::KeywordPlanNetwork]
          #     Targeting network.
          # @!attribute [rw] keyword_annotation
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Enums::KeywordPlanKeywordAnnotationEnum::KeywordPlanKeywordAnnotation>]
          #     The keyword annotations to include in response.
          # @!attribute [rw] aggregate_metrics
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanAggregateMetrics]
          #     The aggregate fields to include in response.
          # @!attribute [rw] historical_metrics_options
          #   @return [::Google::Ads::GoogleAds::V8::Common::HistoricalMetricsOptions]
          #     The options for historical metrics data.
          # @!attribute [rw] keyword_and_url_seed
          #   @return [::Google::Ads::GoogleAds::V8::Services::KeywordAndUrlSeed]
          #     A Keyword and a specific Url to generate ideas from
          #     e.g. cars, www.example.com/cars.
          # @!attribute [rw] keyword_seed
          #   @return [::Google::Ads::GoogleAds::V8::Services::KeywordSeed]
          #     A Keyword or phrase to generate ideas from, e.g. cars.
          # @!attribute [rw] url_seed
          #   @return [::Google::Ads::GoogleAds::V8::Services::UrlSeed]
          #     A specific url to generate ideas from, e.g. www.example.com/cars.
          # @!attribute [rw] site_seed
          #   @return [::Google::Ads::GoogleAds::V8::Services::SiteSeed]
          #     The site to generate ideas from, e.g. www.example.com.
          class GenerateKeywordIdeasRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Keyword And Url Seed
          # @!attribute [rw] url
          #   @return [::String]
          #     The URL to crawl in order to generate keyword ideas.
          # @!attribute [rw] keywords
          #   @return [::Array<::String>]
          #     Requires at least one keyword.
          class KeywordAndUrlSeed
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Keyword Seed
          # @!attribute [rw] keywords
          #   @return [::Array<::String>]
          #     Requires at least one keyword.
          class KeywordSeed
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Site Seed
          # @!attribute [rw] site
          #   @return [::String]
          #     The domain name of the site. If the customer requesting the ideas doesn't
          #     own the site provided only public information is returned.
          class SiteSeed
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Url Seed
          # @!attribute [rw] url
          #   @return [::String]
          #     The URL to crawl in order to generate keyword ideas.
          class UrlSeed
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V8::Services::KeywordPlanIdeaService::Client#generate_keyword_ideas KeywordPlanIdeaService.GenerateKeywordIdeas}.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::GenerateKeywordIdeaResult>]
          #     Results of generating keyword ideas.
          # @!attribute [rw] aggregate_metric_results
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanAggregateMetricResults]
          #     The aggregate metrics for all keyword ideas.
          # @!attribute [rw] next_page_token
          #   @return [::String]
          #     Pagination token used to retrieve the next page of results.
          #     Pass the content of this string as the `page_token` attribute of
          #     the next request.
          #     `next_page_token` is not returned for the last page.
          # @!attribute [rw] total_size
          #   @return [::Integer]
          #     Total number of results available.
          class GenerateKeywordIdeaResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result of generating keyword ideas.
          # @!attribute [rw] text
          #   @return [::String]
          #     Text of the keyword idea.
          #     As in Keyword Plan historical metrics, this text may not be an actual
          #     keyword, but the canonical form of multiple keywords.
          #     See KeywordPlanKeywordHistoricalMetrics message in KeywordPlanService.
          # @!attribute [rw] keyword_idea_metrics
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordPlanHistoricalMetrics]
          #     The historical metrics for the keyword.
          # @!attribute [rw] keyword_annotations
          #   @return [::Google::Ads::GoogleAds::V8::Common::KeywordAnnotations]
          #     The annotations for the keyword.
          #     The annotation data is only provided if requested.
          class GenerateKeywordIdeaResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
