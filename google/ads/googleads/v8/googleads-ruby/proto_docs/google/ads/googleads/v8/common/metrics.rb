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
        module Common
          # Metrics data.
          # @!attribute [rw] absolute_top_impression_percentage
          #   @return [::Float]
          #     The percent of your ad impressions that are shown as the very first ad
          #     above the organic search results.
          # @!attribute [rw] active_view_cpm
          #   @return [::Float]
          #     Average cost of viewable impressions (`active_view_impressions`).
          # @!attribute [rw] active_view_ctr
          #   @return [::Float]
          #     Active view measurable clicks divided by active view viewable impressions.
          #     This metric is reported only for display network.
          # @!attribute [rw] active_view_impressions
          #   @return [::Integer]
          #     A measurement of how often your ad has become viewable on a Display
          #     Network site.
          # @!attribute [rw] active_view_measurability
          #   @return [::Float]
          #     The ratio of impressions that could be measured by Active View over the
          #     number of served impressions.
          # @!attribute [rw] active_view_measurable_cost_micros
          #   @return [::Integer]
          #     The cost of the impressions you received that were measurable by Active
          #     View.
          # @!attribute [rw] active_view_measurable_impressions
          #   @return [::Integer]
          #     The number of times your ads are appearing on placements in positions
          #     where they can be seen.
          # @!attribute [rw] active_view_viewability
          #   @return [::Float]
          #     The percentage of time when your ad appeared on an Active View enabled site
          #     (measurable impressions) and was viewable (viewable impressions).
          # @!attribute [rw] all_conversions_from_interactions_rate
          #   @return [::Float]
          #     All conversions from interactions (as oppose to view through conversions)
          #     divided by the number of ad interactions.
          # @!attribute [rw] all_conversions_value
          #   @return [::Float]
          #     The value of all conversions.
          # @!attribute [rw] all_conversions_value_by_conversion_date
          #   @return [::Float]
          #     The value of all conversions. When this column is selected with date, the
          #     values in date column means the conversion date. Details for the
          #     by_conversion_date columns are available at
          #     https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] all_conversions
          #   @return [::Float]
          #     The total number of conversions. This includes all conversions regardless
          #     of the value of include_in_conversions_metric.
          # @!attribute [rw] all_conversions_by_conversion_date
          #   @return [::Float]
          #     The total number of conversions. This includes all conversions regardless
          #     of the value of include_in_conversions_metric. When this column is selected
          #     with date, the values in date column means the conversion date. Details for
          #     the by_conversion_date columns are available at
          #     https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] all_conversions_value_per_cost
          #   @return [::Float]
          #     The value of all conversions divided by the total cost of ad interactions
          #     (such as clicks for text ads or views for video ads).
          # @!attribute [rw] all_conversions_from_click_to_call
          #   @return [::Float]
          #     The number of times people clicked the "Call" button to call a store during
          #     or after clicking an ad. This number doesn't include whether or not calls
          #     were connected, or the duration of any calls.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_directions
          #   @return [::Float]
          #     The number of times people clicked a "Get directions" button to navigate to
          #     a store after clicking an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_interactions_value_per_interaction
          #   @return [::Float]
          #     The value of all conversions from interactions divided by the total number
          #     of interactions.
          # @!attribute [rw] all_conversions_from_menu
          #   @return [::Float]
          #     The number of times people clicked a link to view a store's menu after
          #     clicking an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_order
          #   @return [::Float]
          #     The number of times people placed an order at a store after clicking an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_other_engagement
          #   @return [::Float]
          #     The number of other conversions (for example, posting a review or saving a
          #     location for a store) that occurred after people clicked an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_store_visit
          #   @return [::Float]
          #     Estimated number of times people visited a store after clicking an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] all_conversions_from_store_website
          #   @return [::Float]
          #     The number of times that people were taken to a store's URL after clicking
          #     an ad.
          #     This metric applies to feed items only.
          # @!attribute [rw] average_cost
          #   @return [::Float]
          #     The average amount you pay per interaction. This amount is the total cost
          #     of your ads divided by the total number of interactions.
          # @!attribute [rw] average_cpc
          #   @return [::Float]
          #     The total cost of all clicks divided by the total number of clicks
          #     received.
          # @!attribute [rw] average_cpe
          #   @return [::Float]
          #     The average amount that you've been charged for an ad engagement. This
          #     amount is the total cost of all ad engagements divided by the total number
          #     of ad engagements.
          # @!attribute [rw] average_cpm
          #   @return [::Float]
          #     Average cost-per-thousand impressions (CPM).
          # @!attribute [rw] average_cpv
          #   @return [::Float]
          #     The average amount you pay each time someone views your ad.
          #     The average CPV is defined by the total cost of all ad views divided by
          #     the number of views.
          # @!attribute [rw] average_page_views
          #   @return [::Float]
          #     Average number of pages viewed per session.
          # @!attribute [rw] average_time_on_site
          #   @return [::Float]
          #     Total duration of all sessions (in seconds) / number of sessions. Imported
          #     from Google Analytics.
          # @!attribute [rw] benchmark_average_max_cpc
          #   @return [::Float]
          #     An indication of how other advertisers are bidding on similar products.
          # @!attribute [rw] benchmark_ctr
          #   @return [::Float]
          #     An indication on how other advertisers' Shopping ads for similar products
          #     are performing based on how often people who see their ad click on it.
          # @!attribute [rw] bounce_rate
          #   @return [::Float]
          #     Percentage of clicks where the user only visited a single page on your
          #     site. Imported from Google Analytics.
          # @!attribute [rw] clicks
          #   @return [::Integer]
          #     The number of clicks.
          # @!attribute [rw] combined_clicks
          #   @return [::Integer]
          #     The number of times your ad or your site's listing in the unpaid
          #     results was clicked. See the help page at
          #     https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] combined_clicks_per_query
          #   @return [::Float]
          #     The number of times your ad or your site's listing in the unpaid
          #     results was clicked (combined_clicks) divided by combined_queries. See the
          #     help page at https://support.google.com/google-ads/answer/3097241 for
          #     details.
          # @!attribute [rw] combined_queries
          #   @return [::Integer]
          #     The number of searches that returned pages from your site in the unpaid
          #     results or showed one of your text ads. See the help page at
          #     https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] content_budget_lost_impression_share
          #   @return [::Float]
          #     The estimated percent of times that your ad was eligible to show
          #     on the Display Network but didn't because your budget was too low.
          #     Note: Content budget lost impression share is reported in the range of 0
          #     to 0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] content_impression_share
          #   @return [::Float]
          #     The impressions you've received on the Display Network divided
          #     by the estimated number of impressions you were eligible to receive.
          #     Note: Content impression share is reported in the range of 0.1 to 1. Any
          #     value below 0.1 is reported as 0.0999.
          # @!attribute [rw] conversion_last_received_request_date_time
          #   @return [::String]
          #     The last date/time a conversion tag for this conversion action successfully
          #     fired and was seen by Google Ads. This firing event may not have been the
          #     result of an attributable conversion (e.g. because the tag was fired from a
          #     browser that did not previously click an ad from an appropriate
          #     advertiser). The date/time is in the customer's time zone.
          # @!attribute [rw] conversion_last_conversion_date
          #   @return [::String]
          #     The date of the most recent conversion for this conversion action. The date
          #     is in the customer's time zone.
          # @!attribute [rw] content_rank_lost_impression_share
          #   @return [::Float]
          #     The estimated percentage of impressions on the Display Network
          #     that your ads didn't receive due to poor Ad Rank.
          #     Note: Content rank lost impression share is reported in the range of 0
          #     to 0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] conversions_from_interactions_rate
          #   @return [::Float]
          #     Conversions from interactions divided by the number of ad interactions
          #     (such as clicks for text ads or views for video ads). This only includes
          #     conversion actions which include_in_conversions_metric attribute is set to
          #     true. If you use conversion-based bidding, your bid strategies will
          #     optimize for these conversions.
          # @!attribute [rw] conversions_value
          #   @return [::Float]
          #     The value of conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] conversions_value_by_conversion_date
          #   @return [::Float]
          #     The value of conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions. When this column is selected with date, the values in date
          #     column means the conversion date. Details for the by_conversion_date
          #     columns are available at
          #     https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] conversions_value_per_cost
          #   @return [::Float]
          #     The value of conversions divided by the cost of ad interactions. This only
          #     includes conversion actions which include_in_conversions_metric attribute
          #     is set to true. If you use conversion-based bidding, your bid strategies
          #     will optimize for these conversions.
          # @!attribute [rw] conversions_from_interactions_value_per_interaction
          #   @return [::Float]
          #     The value of conversions from interactions divided by the number of ad
          #     interactions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] conversions
          #   @return [::Float]
          #     The number of conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] conversions_by_conversion_date
          #   @return [::Float]
          #     The number of conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions. When this column is selected with date, the values in date
          #     column means the conversion date. Details for the by_conversion_date
          #     columns are available at
          #     https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] cost_micros
          #   @return [::Integer]
          #     The sum of your cost-per-click (CPC) and cost-per-thousand impressions
          #     (CPM) costs during this period.
          # @!attribute [rw] cost_per_all_conversions
          #   @return [::Float]
          #     The cost of ad interactions divided by all conversions.
          # @!attribute [rw] cost_per_conversion
          #   @return [::Float]
          #     The cost of ad interactions divided by conversions. This only includes
          #     conversion actions which include_in_conversions_metric attribute is set to
          #     true. If you use conversion-based bidding, your bid strategies will
          #     optimize for these conversions.
          # @!attribute [rw] cost_per_current_model_attributed_conversion
          #   @return [::Float]
          #     The cost of ad interactions divided by current model attributed
          #     conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] cross_device_conversions
          #   @return [::Float]
          #     Conversions from when a customer clicks on a Google Ads ad on one device,
          #     then converts on a different device or browser.
          #     Cross-device conversions are already included in all_conversions.
          # @!attribute [rw] ctr
          #   @return [::Float]
          #     The number of clicks your ad receives (Clicks) divided by the number
          #     of times your ad is shown (Impressions).
          # @!attribute [rw] current_model_attributed_conversions
          #   @return [::Float]
          #     Shows how your historic conversions data would look under the attribution
          #     model you've currently selected. This only includes conversion actions
          #     which include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] current_model_attributed_conversions_from_interactions_rate
          #   @return [::Float]
          #     Current model attributed conversions from interactions divided by the
          #     number of ad interactions (such as clicks for text ads or views for video
          #     ads). This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] current_model_attributed_conversions_from_interactions_value_per_interaction
          #   @return [::Float]
          #     The value of current model attributed conversions from interactions divided
          #     by the number of ad interactions. This only includes conversion actions
          #     which include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] current_model_attributed_conversions_value
          #   @return [::Float]
          #     The value of current model attributed conversions. This only includes
          #     conversion actions which include_in_conversions_metric attribute is set to
          #     true. If you use conversion-based bidding, your bid strategies will
          #     optimize for these conversions.
          # @!attribute [rw] current_model_attributed_conversions_value_per_cost
          #   @return [::Float]
          #     The value of current model attributed conversions divided by the cost of ad
          #     interactions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] engagement_rate
          #   @return [::Float]
          #     How often people engage with your ad after it's shown to them. This is the
          #     number of ad expansions divided by the number of times your ad is shown.
          # @!attribute [rw] engagements
          #   @return [::Integer]
          #     The number of engagements.
          #     An engagement occurs when a viewer expands your Lightbox ad. Also, in the
          #     future, other ad types may support engagement metrics.
          # @!attribute [rw] hotel_average_lead_value_micros
          #   @return [::Float]
          #     Average lead value based on clicks.
          # @!attribute [rw] hotel_price_difference_percentage
          #   @return [::Float]
          #     The average price difference between the price offered by reporting hotel
          #     advertiser and the cheapest price offered by the competing advertiser.
          # @!attribute [rw] hotel_eligible_impressions
          #   @return [::Integer]
          #     The number of impressions that hotel partners could have had given their
          #     feed performance.
          # @!attribute [rw] historical_creative_quality_score
          #   @return [::Google::Ads::GoogleAds::V8::Enums::QualityScoreBucketEnum::QualityScoreBucket]
          #     The creative historical quality score.
          # @!attribute [rw] historical_landing_page_quality_score
          #   @return [::Google::Ads::GoogleAds::V8::Enums::QualityScoreBucketEnum::QualityScoreBucket]
          #     The quality of historical landing page experience.
          # @!attribute [rw] historical_quality_score
          #   @return [::Integer]
          #     The historical quality score.
          # @!attribute [rw] historical_search_predicted_ctr
          #   @return [::Google::Ads::GoogleAds::V8::Enums::QualityScoreBucketEnum::QualityScoreBucket]
          #     The historical search predicted click through rate (CTR).
          # @!attribute [rw] gmail_forwards
          #   @return [::Integer]
          #     The number of times the ad was forwarded to someone else as a message.
          # @!attribute [rw] gmail_saves
          #   @return [::Integer]
          #     The number of times someone has saved your Gmail ad to their inbox as a
          #     message.
          # @!attribute [rw] gmail_secondary_clicks
          #   @return [::Integer]
          #     The number of clicks to the landing page on the expanded state of Gmail
          #     ads.
          # @!attribute [rw] impressions_from_store_reach
          #   @return [::Integer]
          #     The number of times a store's location-based ad was shown.
          #     This metric applies to feed items only.
          # @!attribute [rw] impressions
          #   @return [::Integer]
          #     Count of how often your ad has appeared on a search results page or
          #     website on the Google Network.
          # @!attribute [rw] interaction_rate
          #   @return [::Float]
          #     How often people interact with your ad after it is shown to them.
          #     This is the number of interactions divided by the number of times your ad
          #     is shown.
          # @!attribute [rw] interactions
          #   @return [::Integer]
          #     The number of interactions.
          #     An interaction is the main user action associated with an ad format-clicks
          #     for text and shopping ads, views for video ads, and so on.
          # @!attribute [rw] interaction_event_types
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Enums::InteractionEventTypeEnum::InteractionEventType>]
          #     The types of payable and free interactions.
          # @!attribute [rw] invalid_click_rate
          #   @return [::Float]
          #     The percentage of clicks filtered out of your total number of clicks
          #     (filtered + non-filtered clicks) during the reporting period.
          # @!attribute [rw] invalid_clicks
          #   @return [::Integer]
          #     Number of clicks Google considers illegitimate and doesn't charge you for.
          # @!attribute [rw] message_chats
          #   @return [::Integer]
          #     Number of message chats initiated for Click To Message impressions that
          #     were message tracking eligible.
          # @!attribute [rw] message_impressions
          #   @return [::Integer]
          #     Number of Click To Message impressions that were message tracking eligible.
          # @!attribute [rw] message_chat_rate
          #   @return [::Float]
          #     Number of message chats initiated (message_chats) divided by the number
          #     of message impressions (message_impressions).
          #     Rate at which a user initiates a message chat from an ad impression with
          #     a messaging option and message tracking enabled.
          #     Note that this rate can be more than 1.0 for a given message impression.
          # @!attribute [rw] mobile_friendly_clicks_percentage
          #   @return [::Float]
          #     The percentage of mobile clicks that go to a mobile-friendly page.
          # @!attribute [rw] optimization_score_uplift
          #   @return [::Float]
          #     Total optimization score uplift of all recommendations.
          # @!attribute [rw] optimization_score_url
          #   @return [::String]
          #     URL for the optimization score page in the Google Ads web interface.
          #     This metric can be selected from `customer` or `campaign`, and can be
          #     segmented by `segments.recommendation_type`. For example, `SELECT
          #     metrics.optimization_score_url, segments.recommendation_type FROM
          #     customer` will return a URL for each unique (customer, recommendation_type)
          #     combination.
          # @!attribute [rw] organic_clicks
          #   @return [::Integer]
          #     The number of times someone clicked your site's listing in the unpaid
          #     results for a particular query. See the help page at
          #     https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] organic_clicks_per_query
          #   @return [::Float]
          #     The number of times someone clicked your site's listing in the unpaid
          #     results (organic_clicks) divided by the total number of searches that
          #     returned pages from your site (organic_queries). See the help page at
          #     https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] organic_impressions
          #   @return [::Integer]
          #     The number of listings for your site in the unpaid search results. See the
          #     help page at https://support.google.com/google-ads/answer/3097241 for
          #     details.
          # @!attribute [rw] organic_impressions_per_query
          #   @return [::Float]
          #     The number of times a page from your site was listed in the unpaid search
          #     results (organic_impressions) divided by the number of searches returning
          #     your site's listing in the unpaid results (organic_queries). See the help
          #     page at https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] organic_queries
          #   @return [::Integer]
          #     The total number of searches that returned your site's listing in the
          #     unpaid results. See the help page at
          #     https://support.google.com/google-ads/answer/3097241 for details.
          # @!attribute [rw] percent_new_visitors
          #   @return [::Float]
          #     Percentage of first-time sessions (from people who had never visited your
          #     site before). Imported from Google Analytics.
          # @!attribute [rw] phone_calls
          #   @return [::Integer]
          #     Number of offline phone calls.
          # @!attribute [rw] phone_impressions
          #   @return [::Integer]
          #     Number of offline phone impressions.
          # @!attribute [rw] phone_through_rate
          #   @return [::Float]
          #     Number of phone calls received (phone_calls) divided by the number of
          #     times your phone number is shown (phone_impressions).
          # @!attribute [rw] relative_ctr
          #   @return [::Float]
          #     Your clickthrough rate (Ctr) divided by the average clickthrough rate of
          #     all advertisers on the websites that show your ads. Measures how your ads
          #     perform on Display Network sites compared to other ads on the same sites.
          # @!attribute [rw] search_absolute_top_impression_share
          #   @return [::Float]
          #     The percentage of the customer's Shopping or Search ad impressions that are
          #     shown in the most prominent Shopping position. See
          #     https://support.google.com/google-ads/answer/7501826
          #     for details. Any value below 0.1 is reported as 0.0999.
          # @!attribute [rw] search_budget_lost_absolute_top_impression_share
          #   @return [::Float]
          #     The number estimating how often your ad wasn't the very first ad above the
          #     organic search results due to a low budget. Note: Search
          #     budget lost absolute top impression share is reported in the range of 0 to
          #     0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_budget_lost_impression_share
          #   @return [::Float]
          #     The estimated percent of times that your ad was eligible to show on the
          #     Search Network but didn't because your budget was too low. Note: Search
          #     budget lost impression share is reported in the range of 0 to 0.9. Any
          #     value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_budget_lost_top_impression_share
          #   @return [::Float]
          #     The number estimating how often your ad didn't show anywhere above the
          #     organic search results due to a low budget. Note: Search
          #     budget lost top impression share is reported in the range of 0 to 0.9. Any
          #     value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_click_share
          #   @return [::Float]
          #     The number of clicks you've received on the Search Network
          #     divided by the estimated number of clicks you were eligible to receive.
          #     Note: Search click share is reported in the range of 0.1 to 1. Any value
          #     below 0.1 is reported as 0.0999.
          # @!attribute [rw] search_exact_match_impression_share
          #   @return [::Float]
          #     The impressions you've received divided by the estimated number of
          #     impressions you were eligible to receive on the Search Network for search
          #     terms that matched your keywords exactly (or were close variants of your
          #     keyword), regardless of your keyword match types. Note: Search exact match
          #     impression share is reported in the range of 0.1 to 1. Any value below 0.1
          #     is reported as 0.0999.
          # @!attribute [rw] search_impression_share
          #   @return [::Float]
          #     The impressions you've received on the Search Network divided
          #     by the estimated number of impressions you were eligible to receive.
          #     Note: Search impression share is reported in the range of 0.1 to 1. Any
          #     value below 0.1 is reported as 0.0999.
          # @!attribute [rw] search_rank_lost_absolute_top_impression_share
          #   @return [::Float]
          #     The number estimating how often your ad wasn't the very first ad above the
          #     organic search results due to poor Ad Rank.
          #     Note: Search rank lost absolute top impression share is reported in the
          #     range of 0 to 0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_rank_lost_impression_share
          #   @return [::Float]
          #     The estimated percentage of impressions on the Search Network
          #     that your ads didn't receive due to poor Ad Rank.
          #     Note: Search rank lost impression share is reported in the range of 0 to
          #     0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_rank_lost_top_impression_share
          #   @return [::Float]
          #     The number estimating how often your ad didn't show anywhere above the
          #     organic search results due to poor Ad Rank.
          #     Note: Search rank lost top impression share is reported in the range of 0
          #     to 0.9. Any value above 0.9 is reported as 0.9001.
          # @!attribute [rw] search_top_impression_share
          #   @return [::Float]
          #     The impressions you've received in the top location (anywhere above the
          #     organic search results) compared to the estimated number of impressions you
          #     were eligible to receive in the top location.
          #     Note: Search top impression share is reported in the range of 0.1 to 1. Any
          #     value below 0.1 is reported as 0.0999.
          # @!attribute [rw] speed_score
          #   @return [::Integer]
          #     A measure of how quickly your page loads after clicks on your mobile ads.
          #     The score is a range from 1 to 10, 10 being the fastest.
          # @!attribute [rw] top_impression_percentage
          #   @return [::Float]
          #     The percent of your ad impressions that are shown anywhere above the
          #     organic search results.
          # @!attribute [rw] valid_accelerated_mobile_pages_clicks_percentage
          #   @return [::Float]
          #     The percentage of ad clicks to Accelerated Mobile Pages (AMP) landing pages
          #     that reach a valid AMP page.
          # @!attribute [rw] value_per_all_conversions
          #   @return [::Float]
          #     The value of all conversions divided by the number of all conversions.
          # @!attribute [rw] value_per_all_conversions_by_conversion_date
          #   @return [::Float]
          #     The value of all conversions divided by the number of all conversions. When
          #     this column is selected with date, the values in date column means the
          #     conversion date. Details for the by_conversion_date columns are available
          #     at https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] value_per_conversion
          #   @return [::Float]
          #     The value of conversions divided by the number of conversions. This only
          #     includes conversion actions which include_in_conversions_metric attribute
          #     is set to true. If you use conversion-based bidding, your bid strategies
          #     will optimize for these conversions.
          # @!attribute [rw] value_per_conversions_by_conversion_date
          #   @return [::Float]
          #     The value of conversions divided by the number of conversions. This only
          #     includes conversion actions which include_in_conversions_metric attribute
          #     is set to true. If you use conversion-based bidding, your bid strategies
          #     will optimize for these conversions. When this column is selected with
          #     date, the values in date column means the conversion date. Details for the
          #     by_conversion_date columns are available at
          #     https://support.google.com/google-ads/answer/9549009.
          # @!attribute [rw] value_per_current_model_attributed_conversion
          #   @return [::Float]
          #     The value of current model attributed conversions divided by the number of
          #     the conversions. This only includes conversion actions which
          #     include_in_conversions_metric attribute is set to true. If you use
          #     conversion-based bidding, your bid strategies will optimize for these
          #     conversions.
          # @!attribute [rw] video_quartile_p100_rate
          #   @return [::Float]
          #     Percentage of impressions where the viewer watched all of your video.
          # @!attribute [rw] video_quartile_p25_rate
          #   @return [::Float]
          #     Percentage of impressions where the viewer watched 25% of your video.
          # @!attribute [rw] video_quartile_p50_rate
          #   @return [::Float]
          #     Percentage of impressions where the viewer watched 50% of your video.
          # @!attribute [rw] video_quartile_p75_rate
          #   @return [::Float]
          #     Percentage of impressions where the viewer watched 75% of your video.
          # @!attribute [rw] video_view_rate
          #   @return [::Float]
          #     The number of views your TrueView video ad receives divided by its number
          #     of impressions, including thumbnail impressions for TrueView in-display
          #     ads.
          # @!attribute [rw] video_views
          #   @return [::Integer]
          #     The number of times your video ads were viewed.
          # @!attribute [rw] view_through_conversions
          #   @return [::Integer]
          #     The total number of view-through conversions.
          #     These happen when a customer sees an image or rich media ad, then later
          #     completes a conversion on your site without interacting with (e.g.,
          #     clicking on) another ad.
          # @!attribute [rw] sk_ad_network_conversions
          #   @return [::Integer]
          #     The number of iOS Store Kit Ad Network conversions.
          class Metrics
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
