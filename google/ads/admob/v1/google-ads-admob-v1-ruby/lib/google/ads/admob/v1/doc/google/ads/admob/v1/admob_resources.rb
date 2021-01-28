# Copyright 2020 Google LLC
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

module Google
  module Ads
    module Admob
      module V1
        # A publisher account contains information relevant to the use of this API,
        # such as the time zone used for the reports.
        # @!attribute [rw] name
        #   @return [String]
        #     Resource name of this account.
        #     Format is accounts/{publisher_id}.
        # @!attribute [rw] publisher_id
        #   @return [String]
        #     The unique ID by which this publisher account can be identified
        #     in the API requests (for example, pub-1234567890).
        # @!attribute [rw] reporting_time_zone
        #   @return [String]
        #     The time zone that is used in reports that are generated for this account.
        #     The value is a time-zone ID as specified by the CLDR project,
        #     for example, "America/Los_Angeles".
        # @!attribute [rw] currency_code
        #   @return [String]
        #     Currency code of the earning-related metrics, which is the 3-letter code
        #     defined in ISO 4217. The daily average rate is used for the currency
        #     conversion.
        class PublisherAccount; end

        # The specification for generating an AdMob Network report.
        # For example, the specification to get clicks and estimated earnings for only
        # the 'US' and 'CN' countries can look like the following example:
        #
        #     {
        #       'date_range': {
        #         'start_date': {'year': 2018, 'month': 9, 'day': 1},
        #         'end_date': {'year': 2018, 'month': 9, 'day': 30}
        #       },
        #       'dimensions': ['DATE', 'APP', 'COUNTRY'],
        #       'metrics': ['CLICKS', 'ESTIMATED_EARNINGS'],
        #       'dimension_filters': [
        #         {
        #           'dimension': 'COUNTRY',
        #           'matches_any': {'values': [{'value': 'US', 'value': 'CN'}]}
        #         }
        #       ],
        #       'sort_conditions': [
        #         {'dimension':'APP', order: 'ASCENDING'},
        #         {'metric':'CLICKS', order: 'DESCENDING'}
        #       ],
        #       'localization_settings': {
        #         'currency_code': 'USD',
        #         'language_code': 'en-US'
        #       }
        #     }
        #
        # For a better understanding, you can treat the preceding specification like
        # the following pseudo SQL:
        #
        #     SELECT DATE, APP, COUNTRY, CLICKS, ESTIMATED_EARNINGS
        #     FROM NETWORK_REPORT
        #     WHERE DATE >= '2018-09-01' AND DATE <= '2018-09-30'
        #         AND COUNTRY IN ('US', 'CN')
        #     GROUP BY DATE, APP, COUNTRY
        #     ORDER BY APP ASC, CLICKS DESC;
        # @!attribute [rw] date_range
        #   @return [Google::Ads::Admob::V1::DateRange]
        #     The date range for which the report is generated.
        # @!attribute [rw] dimensions
        #   @return [Array<Google::Ads::Admob::V1::NetworkReportSpec::Dimension>]
        #     List of dimensions of the report. The value combination of these dimensions
        #     determines the row of the report. If no dimensions are specified, the
        #     report returns a single row of requested metrics for the entire account.
        # @!attribute [rw] metrics
        #   @return [Array<Google::Ads::Admob::V1::NetworkReportSpec::Metric>]
        #     List of metrics of the report. A report must specify at least one metric.
        # @!attribute [rw] dimension_filters
        #   @return [Array<Google::Ads::Admob::V1::NetworkReportSpec::DimensionFilter>]
        #     Describes which report rows to match based on their dimension values.
        # @!attribute [rw] sort_conditions
        #   @return [Array<Google::Ads::Admob::V1::NetworkReportSpec::SortCondition>]
        #     Describes the sorting of report rows. The order of the condition in the
        #     list defines its precedence; the earlier the condition, the higher its
        #     precedence. If no sort conditions are specified, the row ordering is
        #     undefined.
        # @!attribute [rw] localization_settings
        #   @return [Google::Ads::Admob::V1::LocalizationSettings]
        #     Localization settings of the report.
        # @!attribute [rw] max_report_rows
        #   @return [Integer]
        #     Maximum number of report data rows to return. If the value is not set, the
        #     API returns as many rows as possible, up to 100000. Acceptable values are
        #     1-100000, inclusive. Any other values are treated as 100000.
        # @!attribute [rw] time_zone
        #   @return [String]
        #     A report time zone. Accepts an IANA TZ name values, such as
        #     "America/Los_Angeles."  If no time zone is defined, the account default
        #     takes effect. Check default value by the get account action.
        #
        #     **Warning:** The "America/Los_Angeles" is the only supported value at
        #     the moment.
        class NetworkReportSpec
          # Describes which report rows to match based on their dimension values.
          # @!attribute [rw] matches_any
          #   @return [Google::Ads::Admob::V1::StringList]
          #     Matches a row if its value for the specified dimension is in one of the
          #     values specified in this condition.
          # @!attribute [rw] dimension
          #   @return [Google::Ads::Admob::V1::NetworkReportSpec::Dimension]
          #     Applies the filter criterion to the specified dimension.
          class DimensionFilter; end

          # Sorting direction to be applied on a dimension or a metric.
          # @!attribute [rw] dimension
          #   @return [Google::Ads::Admob::V1::NetworkReportSpec::Dimension]
          #     Sort by the specified dimension.
          # @!attribute [rw] metric
          #   @return [Google::Ads::Admob::V1::NetworkReportSpec::Metric]
          #     Sort by the specified metric.
          # @!attribute [rw] order
          #   @return [Google::Ads::Admob::V1::SortOrder]
          #     Sorting order of the dimension or metric.
          class SortCondition; end

          # The dimensions of the network report. Dimensions are data attributes to
          # break down or refine the quantitative measurements (metrics) by certain
          # attributes, such as the ad format or the platform an ad was viewed on.
          module Dimension
            # Default value for an unset field. Do not use.
            DIMENSION_UNSPECIFIED = 0

            # A date in the YYYY-MM-DD format (for example, "2018-12-21"). Requests can
            # specify at most one time dimension.
            DATE = 1

            # A month in the YYYY-MM format (for example, "2018-12"). Requests can
            # specify at most one time dimension.
            MONTH = 2

            # The date of the first day of a week in the YYYY-MM-DD format
            # (for example, "2018-12-21"). Requests can specify at most one time
            # dimension.
            WEEK = 3

            # The unique ID of the ad unit (for example, "ca-app-pub-1234/1234").
            # If AD_UNIT dimension is specified, then APP is included automatically.
            AD_UNIT = 4

            # The unique ID of the mobile application (for example,
            # "ca-app-pub-1234~1234").
            APP = 5

            # Type of the ad (for example, "text" or "image"), an ad delivery
            # dimension.
            #
            # **Warning:** The dimension is incompatible with
            # [AD_REQUESTS](https://cloud.google.com#Metric.ENUM_VALUES.AD_REQUESTS),
            # [MATCH_RATE](https://cloud.google.com#Metric.ENUM_VALUES.MATCH_RATE) and
            # [IMPRESSION_RPM](https://cloud.google.com#Metric.ENUM_VALUES.IMPRESSION_RPM) metrics.
            AD_TYPE = 6

            # CLDR country code of the place where the ad views/clicks occur (for
            # example, "US" or "FR"). This is a geography dimension.
            COUNTRY = 7

            # Format of the ad unit (for example, "banner", "native"), an ad delivery
            # dimension.
            FORMAT = 8

            # Mobile OS platform of the app (for example, "Android" or "iOS").
            PLATFORM = 9
          end

          # The metrics of the network report. Metrics are quantitative measurements
          # indicating how the publisher business is performing. They are aggregated
          # from the individual ad events and grouped by the report dimensions. The
          # metric value is either integer, or decimal (without rounding).
          module Metric
            # Default value for an unset field. Do not use.
            METRIC_UNSPECIFIED = 0

            # The number of ad requests. The value is an integer.
            #
            # **Warning:** The metric is incompatible with
            # [AD_TYPE](https://cloud.google.com#Dimension.ENUM_VALUES.AD_TYPE) dimension.
            AD_REQUESTS = 1

            # The number of times a user clicks an ad. The value is an integer.
            CLICKS = 2

            # The estimated earnings of the AdMob publisher. The currency unit (USD,
            # EUR, or other) of the earning metrics are determined by the localization
            # setting for currency. The amount is in micros. For example, $6.50 would
            # be represented as 6500000.
            ESTIMATED_EARNINGS = 3

            # The total number of ads shown to users. The value is an integer.
            IMPRESSIONS = 4

            # The ratio of clicks over impressions. The value is a double precision
            # (approximate) decimal value.
            IMPRESSION_CTR = 5

            # The estimated earnings per thousand ad impressions. The value is in
            # micros. For example, $1.03 would be represented as 1030000.
            #
            # **Warning:** The metric is incompatible with
            # [AD_TYPE](https://cloud.google.com#Dimension.ENUM_VALUES.AD_TYPE) dimension.
            IMPRESSION_RPM = 6

            # The number of times ads are returned in response to a request. The value
            # is an integer.
            MATCHED_REQUESTS = 7

            # The ratio of matched ad requests over the total ad requests. The value is
            # a double precision (approximate) decimal value.
            #
            # **Warning:** The metric is incompatible with
            # [AD_TYPE](https://cloud.google.com#Dimension.ENUM_VALUES.AD_TYPE) dimension.
            MATCH_RATE = 8

            # The ratio of ads that are displayed over ads that are returned, defined
            # as impressions / matched requests. The value is a double precision
            # (approximate) decimal value.
            SHOW_RATE = 9
          end
        end

        # The specification for generating an AdMob Mediation report.
        # For example, the specification to get observed ECPM sliced by ad source and
        # app for the 'US' and 'CN' countries can look like the following example:
        #
        #     {
        #       "date_range": {
        #         "start_date": {"year": 2018, "month": 9, "day": 1},
        #         "end_date": {"year": 2018, "month": 9, "day": 30}
        #       },
        #       "dimensions": ["AD_SOURCE", "APP", "COUNTRY"],
        #       "metrics": ["OBSERVED_ECPM"],
        #       "dimension_filters": [
        #         {
        #           "dimension": "COUNTRY",
        #           "matches_any": {"values": [{"value": "US", "value": "CN"}]}
        #         }
        #       ],
        #       "sort_conditions": [
        #         {"dimension":"APP", order: "ASCENDING"}
        #       ],
        #       "localization_settings": {
        #         "currency_code": "USD",
        #         "language_code": "en-US"
        #       }
        #     }
        #
        # For a better understanding, you can treat the preceding specification like
        # the following pseudo SQL:
        #
        #     SELECT AD_SOURCE, APP, COUNTRY, OBSERVED_ECPM
        #     FROM MEDIATION_REPORT
        #     WHERE DATE >= '2018-09-01' AND DATE <= '2018-09-30'
        #         AND COUNTRY IN ('US', 'CN')
        #     GROUP BY AD_SOURCE, APP, COUNTRY
        #     ORDER BY APP ASC;
        # @!attribute [rw] date_range
        #   @return [Google::Ads::Admob::V1::DateRange]
        #     The date range for which the report is generated.
        # @!attribute [rw] dimensions
        #   @return [Array<Google::Ads::Admob::V1::MediationReportSpec::Dimension>]
        #     List of dimensions of the report. The value combination of these dimensions
        #     determines the row of the report. If no dimensions are specified, the
        #     report returns a single row of requested metrics for the entire account.
        # @!attribute [rw] metrics
        #   @return [Array<Google::Ads::Admob::V1::MediationReportSpec::Metric>]
        #     List of metrics of the report. A report must specify at least one metric.
        # @!attribute [rw] dimension_filters
        #   @return [Array<Google::Ads::Admob::V1::MediationReportSpec::DimensionFilter>]
        #     Describes which report rows to match based on their dimension values.
        # @!attribute [rw] sort_conditions
        #   @return [Array<Google::Ads::Admob::V1::MediationReportSpec::SortCondition>]
        #     Describes the sorting of report rows. The order of the condition in the
        #     list defines its precedence; the earlier the condition, the higher its
        #     precedence. If no sort conditions are specified, the row ordering is
        #     undefined.
        # @!attribute [rw] localization_settings
        #   @return [Google::Ads::Admob::V1::LocalizationSettings]
        #     Localization settings of the report.
        # @!attribute [rw] max_report_rows
        #   @return [Integer]
        #     Maximum number of report data rows to return. If the value is not set, the
        #     API returns as many rows as possible, up to 100000. Acceptable values are
        #     1-100000, inclusive. Any other values are treated as 100000.
        # @!attribute [rw] time_zone
        #   @return [String]
        #     A report time zone. Accepts an IANA TZ name values, such as
        #     "America/Los_Angeles."  If no time zone is defined, the account default
        #     takes effect. Check default value by the get account action.
        #
        #     **Warning:** The "America/Los_Angeles" is the only supported value at
        #     the moment.
        class MediationReportSpec
          # Describes which report rows to match based on their dimension values.
          # @!attribute [rw] matches_any
          #   @return [Google::Ads::Admob::V1::StringList]
          #     Matches a row if its value for the specified dimension is in one of the
          #     values specified in this condition.
          # @!attribute [rw] dimension
          #   @return [Google::Ads::Admob::V1::MediationReportSpec::Dimension]
          #     Applies the filter criterion to the specified dimension.
          class DimensionFilter; end

          # Sorting direction to be applied on a dimension or a metric.
          # @!attribute [rw] dimension
          #   @return [Google::Ads::Admob::V1::MediationReportSpec::Dimension]
          #     Sort by the specified dimension.
          # @!attribute [rw] metric
          #   @return [Google::Ads::Admob::V1::MediationReportSpec::Metric]
          #     Sort by the specified metric.
          # @!attribute [rw] order
          #   @return [Google::Ads::Admob::V1::SortOrder]
          #     Sorting order of the dimension or metric.
          class SortCondition; end

          # The dimensions of the mediation report. Dimensions are data attributes to
          # break down or refine the quantitative measurements (metrics) by certain
          # attributes, such as the ad format or the platform an ad was viewed on.
          module Dimension
            # Default value for an unset field. Do not use.
            DIMENSION_UNSPECIFIED = 0

            # A date in the YYYY-MM-DD format (for example, "2018-12-21"). Requests can
            # specify at most one time dimension.
            DATE = 1

            # A month in the YYYY-MM format (for example, "2018-12"). Requests can
            # specify at most one time dimension.
            MONTH = 2

            # The date of the first day of a week in the YYYY-MM-DD format
            # (for example, "2018-12-21"). Requests can specify at most one time
            # dimension.
            WEEK = 3

            # The [unique ID of the ad source](https://cloud.google.com/admob/api/v1/ad_sources) (for example,
            # "5450213213286189855" and "AdMob Network" as label value).
            AD_SOURCE = 4

            # The unique ID of the ad source instance (for example,
            # "ca-app-pub-1234#5678" and "AdMob (default)" as label value).
            AD_SOURCE_INSTANCE = 5

            # The unique ID of the ad unit (for example, "ca-app-pub-1234/8790").
            # If AD_UNIT dimension is specified, then APP is included automatically.
            AD_UNIT = 6

            # The unique ID of the mobile application (for example,
            # "ca-app-pub-1234~1234").
            APP = 7

            # The unique ID of the mediation group (for example,
            # "ca-app-pub-1234:mg:1234" and "AdMob (default)" as label value).
            MEDIATION_GROUP = 11

            # CLDR country code of the place where the ad views/clicks occur (for
            # example, "US" or "FR"). This is a geography dimension.
            COUNTRY = 8

            # Format of the ad unit (for example, "banner", "native"), an ad delivery
            # dimension.
            FORMAT = 9

            # Mobile OS platform of the app (for example, "Android" or "iOS").
            PLATFORM = 10
          end

          # The metrics of the mediation report. Metrics are quantitative measurements
          # indicating how the publisher business is performing. They are aggregated
          # from the individual ad events and grouped by the report dimensions. The
          # metric value is either integer, or decimal (without rounding).
          module Metric
            # Default value for an unset field. Do not use.
            METRIC_UNSPECIFIED = 0

            # The number of requests. The value is an integer.
            AD_REQUESTS = 1

            # The number of times a user clicks an ad. The value is an integer.
            CLICKS = 2

            # The estimated earnings of the AdMob publisher. The currency unit (USD,
            # EUR, or other) of the earning metrics are determined by the localization
            # setting for currency. The amount is in micros. For example, $6.50 would
            # be represented as 6500000.
            #
            # Estimated earnings per mediation group and per ad source instance level
            # is supported dating back to October 20, 2019. Third-party estimated
            # earnings will show 0 for dates prior to October 20, 2019.
            ESTIMATED_EARNINGS = 3

            # The total number of ads shown to users. The value is an integer.
            IMPRESSIONS = 4

            # The ratio of clicks over impressions. The value is a double precision
            # (approximate) decimal value.
            IMPRESSION_CTR = 5

            # The number of times ads are returned in response to a request. The value
            # is an integer.
            MATCHED_REQUESTS = 6

            # The ratio of matched ad requests over the total ad requests. The value is
            # a double precision (approximate) decimal value.
            MATCH_RATE = 7

            # The third-party ad network's estimated average eCPM. The currency unit
            # (USD, EUR, or other) of the earning metrics are determined by the
            # localization setting for currency. The amount is in micros. For example,
            # $2.30 would be represented as 2300000.
            #
            # The estimated average eCPM per mediation group and per ad source instance
            # level is supported dating back to October 20, 2019. Third-party estimated
            # average eCPM will show 0 for dates prior to October 20, 2019.
            OBSERVED_ECPM = 8
          end
        end

        # A row of the returning report.
        # @!attribute [rw] dimension_values
        #   @return [Hash{String => Google::Ads::Admob::V1::ReportRow::DimensionValue}]
        #     Map of dimension values in a row, with keys as enum name of the dimensions.
        # @!attribute [rw] metric_values
        #   @return [Hash{String => Google::Ads::Admob::V1::ReportRow::MetricValue}]
        #     Map of metric values in a row, with keys as enum name of the metrics. If
        #     a metric being requested has no value returned, the map will not include
        #     it.
        class ReportRow
          # Representation of a dimension value.
          # @!attribute [rw] value
          #   @return [String]
          #     Dimension value in the format specified in the report's spec Dimension
          #     enum.
          # @!attribute [rw] display_label
          #   @return [String]
          #     The localized string representation of the value. If unspecified, the
          #     display label should be derived from the value.
          class DimensionValue; end

          # Representation of a metric value.
          # @!attribute [rw] integer_value
          #   @return [Integer]
          #     Metric integer value.
          # @!attribute [rw] double_value
          #   @return [Float]
          #     Double precision (approximate) decimal values. Rates are from 0 to 1.
          # @!attribute [rw] micros_value
          #   @return [Integer]
          #     Amount in micros. One million is equivalent to one unit. Currency value
          #     is in the unit (USD, EUR or other) specified by the request.
          #     For example, $6.50 whould be represented as 6500000 micros.
          class MetricValue; end
        end

        # Warnings associated with generation of the report.
        # @!attribute [rw] type
        #   @return [Google::Ads::Admob::V1::ReportWarning::Type]
        #     Type of the warning.
        # @!attribute [rw] description
        #   @return [String]
        #     Describes the details of the warning message, in English.
        class ReportWarning
          # Warning type.
          module Type
            # Default value for an unset field. Do not use.
            TYPE_UNSPECIFIED = 0

            # Some data in this report is aggregated based on a time zone different
            # from the requested time zone. This could happen if a local time-zone
            # report has the start time before the last time this time zone changed.
            # The description field will contain the date of the last time zone
            # change.
            DATA_BEFORE_ACCOUNT_TIMEZONE_CHANGE = 1

            # There is an unusual delay in processing the source data for the
            # requested date range. The report results might be less up to date than
            # usual. AdMob is aware of the issue and is actively working to resolve
            # it.
            DATA_DELAYED = 2

            # Warnings that are exposed without a specific type. Useful when new
            # warning types are added but the API is not changed yet.
            OTHER = 3

            # The currency being requested is not the account currency. The earning
            # metrics will be based on the requested currency, and thus not a good
            # estimation of the final payment anymore, due to the currency rate
            # fluctuation.
            REPORT_CURRENCY_NOT_ACCOUNT_CURRENCY = 4
          end
        end

        # Groups data helps to treat the generated report. Always sent as a first
        # message in the stream response.
        # @!attribute [rw] date_range
        #   @return [Google::Ads::Admob::V1::DateRange]
        #     The date range for which the report is generated. This is identical to the
        #     range specified in the report request.
        # @!attribute [rw] localization_settings
        #   @return [Google::Ads::Admob::V1::LocalizationSettings]
        #     Localization settings of the report. This is identical to the settings
        #     in the report request.
        # @!attribute [rw] reporting_time_zone
        #   @return [String]
        #     The report time zone. The value is a time-zone ID as specified by the CLDR
        #     project, for example, "America/Los_Angeles".
        class ReportHeader; end

        # Groups data available after report generation, for example, warnings and row
        # counts. Always sent as the last message in the stream response.
        # @!attribute [rw] warnings
        #   @return [Array<Google::Ads::Admob::V1::ReportWarning>]
        #     Warnings associated with generation of the report.
        # @!attribute [rw] matching_row_count
        #   @return [Integer]
        #     Total number of rows that matched the request.
        #
        #     Warning: This count does NOT always match the number of rows in the
        #     response. Do not make that assumption when processing the response.
        class ReportFooter; end

        # Specification of a single date range. Both dates are inclusive.
        # @!attribute [rw] start_date
        #   @return [Google::Type::Date]
        #     Start date of the date range, inclusive. Must be less than or equal to the
        #     end date.
        # @!attribute [rw] end_date
        #   @return [Google::Type::Date]
        #     End date of the date range, inclusive. Must be greater than or equal to the
        #     start date.
        class DateRange; end

        # Localization settings for reports, such as currency and language. It affects
        # how metrics are calculated.
        # @!attribute [rw] currency_code
        #   @return [String]
        #     Currency code of the earning related metrics, which is the 3-letter code
        #     defined in ISO 4217. The daily average rate is used for the currency
        #     conversion. Defaults to the account currency code if unspecified.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Language used for any localized text, such as some dimension value display
        #     labels. The language tag defined in the IETF BCP47. Defaults to 'en-US' if
        #     unspecified.
        class LocalizationSettings; end

        # List of string values.
        # @!attribute [rw] values
        #   @return [Array<String>]
        #     The string values.
        class StringList; end

        # The sorting order.
        module SortOrder
          # Default value for an unset field. Do not use.
          SORT_ORDER_UNSPECIFIED = 0

          # Sort dimension value or metric value in ascending order.
          ASCENDING = 1

          # Sort dimension value or metric value in descending order.
          DESCENDING = 2
        end
      end
    end
  end
end