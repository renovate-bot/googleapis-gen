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
import proto  # type: ignore

from google.type import date_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.ads.admob.v1',
    manifest={
        'SortOrder',
        'PublisherAccount',
        'NetworkReportSpec',
        'MediationReportSpec',
        'ReportRow',
        'ReportWarning',
        'ReportHeader',
        'ReportFooter',
        'DateRange',
        'LocalizationSettings',
        'StringList',
    },
)


class SortOrder(proto.Enum):
    r"""The sorting order."""
    SORT_ORDER_UNSPECIFIED = 0
    ASCENDING = 1
    DESCENDING = 2


class PublisherAccount(proto.Message):
    r"""A publisher account contains information relevant to the use
    of this API, such as the time zone used for the reports.

    Attributes:
        name (str):
            Resource name of this account. Format is
            accounts/{publisher_id}.
        publisher_id (str):
            The unique ID by which this publisher account
            can be identified in the API requests (for
            example, pub-1234567890).
        reporting_time_zone (str):
            The time zone that is used in reports that are generated for
            this account. The value is a time-zone ID as specified by
            the CLDR project, for example, "America/Los_Angeles".
        currency_code (str):
            Currency code of the earning-related metrics,
            which is the 3-letter code defined in ISO 4217.
            The daily average rate is used for the currency
            conversion.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    publisher_id = proto.Field(
        proto.STRING,
        number=2,
    )
    reporting_time_zone = proto.Field(
        proto.STRING,
        number=3,
    )
    currency_code = proto.Field(
        proto.STRING,
        number=4,
    )


class NetworkReportSpec(proto.Message):
    r"""The specification for generating an AdMob Network report. For
    example, the specification to get clicks and estimated earnings for
    only the 'US' and 'CN' countries can look like the following
    example:

    ::

        {
          'date_range': {
            'start_date': {'year': 2018, 'month': 9, 'day': 1},
            'end_date': {'year': 2018, 'month': 9, 'day': 30}
          },
          'dimensions': ['DATE', 'APP', 'COUNTRY'],
          'metrics': ['CLICKS', 'ESTIMATED_EARNINGS'],
          'dimension_filters': [
            {
              'dimension': 'COUNTRY',
              'matches_any': {'values': [{'value': 'US', 'value': 'CN'}]}
            }
          ],
          'sort_conditions': [
            {'dimension':'APP', order: 'ASCENDING'},
            {'metric':'CLICKS', order: 'DESCENDING'}
          ],
          'localization_settings': {
            'currency_code': 'USD',
            'language_code': 'en-US'
          }
        }

    For a better understanding, you can treat the preceding
    specification like the following pseudo SQL:

    ::

        SELECT DATE, APP, COUNTRY, CLICKS, ESTIMATED_EARNINGS
        FROM NETWORK_REPORT
        WHERE DATE >= '2018-09-01' AND DATE <= '2018-09-30'
            AND COUNTRY IN ('US', 'CN')
        GROUP BY DATE, APP, COUNTRY
        ORDER BY APP ASC, CLICKS DESC;

    Attributes:
        date_range (google.ads.admob_v1.types.DateRange):
            The date range for which the report is
            generated.
        dimensions (Sequence[google.ads.admob_v1.types.NetworkReportSpec.Dimension]):
            List of dimensions of the report. The value
            combination of these dimensions determines the
            row of the report. If no dimensions are
            specified, the report returns a single row of
            requested metrics for the entire account.
        metrics (Sequence[google.ads.admob_v1.types.NetworkReportSpec.Metric]):
            List of metrics of the report. A report must
            specify at least one metric.
        dimension_filters (Sequence[google.ads.admob_v1.types.NetworkReportSpec.DimensionFilter]):
            Describes which report rows to match based on
            their dimension values.
        sort_conditions (Sequence[google.ads.admob_v1.types.NetworkReportSpec.SortCondition]):
            Describes the sorting of report rows. The
            order of the condition in the list defines its
            precedence; the earlier the condition, the
            higher its precedence. If no sort conditions are
            specified, the row ordering is undefined.
        localization_settings (google.ads.admob_v1.types.LocalizationSettings):
            Localization settings of the report.
        max_report_rows (int):
            Maximum number of report data rows to return.
            If the value is not set, the API returns as many
            rows as possible, up to 100000. Acceptable
            values are 1-100000, inclusive. Any other values
            are treated as 100000.
        time_zone (str):
            A report time zone. Accepts an IANA TZ name values, such as
            "America/Los_Angeles." If no time zone is defined, the
            account default takes effect. Check default value by the get
            account action.

            **Warning:** The "America/Los_Angeles" is the only supported
            value at the moment.
    """
    class Dimension(proto.Enum):
        r"""The dimensions of the network report. Dimensions are data
        attributes to break down or refine the quantitative measurements
        (metrics) by certain attributes, such as the ad format or the
        platform an ad was viewed on.
        """
        DIMENSION_UNSPECIFIED = 0
        DATE = 1
        MONTH = 2
        WEEK = 3
        AD_UNIT = 4
        APP = 5
        AD_TYPE = 6
        COUNTRY = 7
        FORMAT = 8
        PLATFORM = 9

    class Metric(proto.Enum):
        r"""The metrics of the network report. Metrics are quantitative
        measurements indicating how the publisher business is
        performing. They are aggregated from the individual ad events
        and grouped by the report dimensions. The metric value is either
        integer, or decimal (without rounding).
        """
        METRIC_UNSPECIFIED = 0
        AD_REQUESTS = 1
        CLICKS = 2
        ESTIMATED_EARNINGS = 3
        IMPRESSIONS = 4
        IMPRESSION_CTR = 5
        IMPRESSION_RPM = 6
        MATCHED_REQUESTS = 7
        MATCH_RATE = 8
        SHOW_RATE = 9

    class DimensionFilter(proto.Message):
        r"""Describes which report rows to match based on their dimension
        values.

        Attributes:
            matches_any (google.ads.admob_v1.types.StringList):
                Matches a row if its value for the specified
                dimension is in one of the values specified in
                this condition.
            dimension (google.ads.admob_v1.types.NetworkReportSpec.Dimension):
                Applies the filter criterion to the specified
                dimension.
        """

        matches_any = proto.Field(
            proto.MESSAGE,
            number=2,
            oneof='operator',
            message='StringList',
        )
        dimension = proto.Field(
            proto.ENUM,
            number=1,
            enum='NetworkReportSpec.Dimension',
        )

    class SortCondition(proto.Message):
        r"""Sorting direction to be applied on a dimension or a metric.

        Attributes:
            dimension (google.ads.admob_v1.types.NetworkReportSpec.Dimension):
                Sort by the specified dimension.
            metric (google.ads.admob_v1.types.NetworkReportSpec.Metric):
                Sort by the specified metric.
            order (google.ads.admob_v1.types.SortOrder):
                Sorting order of the dimension or metric.
        """

        dimension = proto.Field(
            proto.ENUM,
            number=1,
            oneof='sort_on',
            enum='NetworkReportSpec.Dimension',
        )
        metric = proto.Field(
            proto.ENUM,
            number=2,
            oneof='sort_on',
            enum='NetworkReportSpec.Metric',
        )
        order = proto.Field(
            proto.ENUM,
            number=3,
            enum='SortOrder',
        )

    date_range = proto.Field(
        proto.MESSAGE,
        number=1,
        message='DateRange',
    )
    dimensions = proto.RepeatedField(
        proto.ENUM,
        number=2,
        enum=Dimension,
    )
    metrics = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=Metric,
    )
    dimension_filters = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=DimensionFilter,
    )
    sort_conditions = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message=SortCondition,
    )
    localization_settings = proto.Field(
        proto.MESSAGE,
        number=6,
        message='LocalizationSettings',
    )
    max_report_rows = proto.Field(
        proto.INT32,
        number=7,
    )
    time_zone = proto.Field(
        proto.STRING,
        number=8,
    )


class MediationReportSpec(proto.Message):
    r"""The specification for generating an AdMob Mediation report. For
    example, the specification to get observed ECPM sliced by ad source
    and app for the 'US' and 'CN' countries can look like the following
    example:

    ::

        {
          "date_range": {
            "start_date": {"year": 2018, "month": 9, "day": 1},
            "end_date": {"year": 2018, "month": 9, "day": 30}
          },
          "dimensions": ["AD_SOURCE", "APP", "COUNTRY"],
          "metrics": ["OBSERVED_ECPM"],
          "dimension_filters": [
            {
              "dimension": "COUNTRY",
              "matches_any": {"values": [{"value": "US", "value": "CN"}]}
            }
          ],
          "sort_conditions": [
            {"dimension":"APP", order: "ASCENDING"}
          ],
          "localization_settings": {
            "currency_code": "USD",
            "language_code": "en-US"
          }
        }

    For a better understanding, you can treat the preceding
    specification like the following pseudo SQL:

    ::

        SELECT AD_SOURCE, APP, COUNTRY, OBSERVED_ECPM
        FROM MEDIATION_REPORT
        WHERE DATE >= '2018-09-01' AND DATE <= '2018-09-30'
            AND COUNTRY IN ('US', 'CN')
        GROUP BY AD_SOURCE, APP, COUNTRY
        ORDER BY APP ASC;

    Attributes:
        date_range (google.ads.admob_v1.types.DateRange):
            The date range for which the report is
            generated.
        dimensions (Sequence[google.ads.admob_v1.types.MediationReportSpec.Dimension]):
            List of dimensions of the report. The value
            combination of these dimensions determines the
            row of the report. If no dimensions are
            specified, the report returns a single row of
            requested metrics for the entire account.
        metrics (Sequence[google.ads.admob_v1.types.MediationReportSpec.Metric]):
            List of metrics of the report. A report must
            specify at least one metric.
        dimension_filters (Sequence[google.ads.admob_v1.types.MediationReportSpec.DimensionFilter]):
            Describes which report rows to match based on
            their dimension values.
        sort_conditions (Sequence[google.ads.admob_v1.types.MediationReportSpec.SortCondition]):
            Describes the sorting of report rows. The
            order of the condition in the list defines its
            precedence; the earlier the condition, the
            higher its precedence. If no sort conditions are
            specified, the row ordering is undefined.
        localization_settings (google.ads.admob_v1.types.LocalizationSettings):
            Localization settings of the report.
        max_report_rows (int):
            Maximum number of report data rows to return.
            If the value is not set, the API returns as many
            rows as possible, up to 100000. Acceptable
            values are 1-100000, inclusive. Any other values
            are treated as 100000.
        time_zone (str):
            A report time zone. Accepts an IANA TZ name values, such as
            "America/Los_Angeles." If no time zone is defined, the
            account default takes effect. Check default value by the get
            account action.

            **Warning:** The "America/Los_Angeles" is the only supported
            value at the moment.
    """
    class Dimension(proto.Enum):
        r"""The dimensions of the mediation report. Dimensions are data
        attributes to break down or refine the quantitative measurements
        (metrics) by certain attributes, such as the ad format or the
        platform an ad was viewed on.
        """
        DIMENSION_UNSPECIFIED = 0
        DATE = 1
        MONTH = 2
        WEEK = 3
        AD_SOURCE = 4
        AD_SOURCE_INSTANCE = 5
        AD_UNIT = 6
        APP = 7
        MEDIATION_GROUP = 11
        COUNTRY = 8
        FORMAT = 9
        PLATFORM = 10

    class Metric(proto.Enum):
        r"""The metrics of the mediation report. Metrics are quantitative
        measurements indicating how the publisher business is
        performing. They are aggregated from the individual ad events
        and grouped by the report dimensions. The metric value is either
        integer, or decimal (without rounding).
        """
        METRIC_UNSPECIFIED = 0
        AD_REQUESTS = 1
        CLICKS = 2
        ESTIMATED_EARNINGS = 3
        IMPRESSIONS = 4
        IMPRESSION_CTR = 5
        MATCHED_REQUESTS = 6
        MATCH_RATE = 7
        OBSERVED_ECPM = 8

    class DimensionFilter(proto.Message):
        r"""Describes which report rows to match based on their dimension
        values.

        Attributes:
            matches_any (google.ads.admob_v1.types.StringList):
                Matches a row if its value for the specified
                dimension is in one of the values specified in
                this condition.
            dimension (google.ads.admob_v1.types.MediationReportSpec.Dimension):
                Applies the filter criterion to the specified
                dimension.
        """

        matches_any = proto.Field(
            proto.MESSAGE,
            number=2,
            oneof='operator',
            message='StringList',
        )
        dimension = proto.Field(
            proto.ENUM,
            number=1,
            enum='MediationReportSpec.Dimension',
        )

    class SortCondition(proto.Message):
        r"""Sorting direction to be applied on a dimension or a metric.

        Attributes:
            dimension (google.ads.admob_v1.types.MediationReportSpec.Dimension):
                Sort by the specified dimension.
            metric (google.ads.admob_v1.types.MediationReportSpec.Metric):
                Sort by the specified metric.
            order (google.ads.admob_v1.types.SortOrder):
                Sorting order of the dimension or metric.
        """

        dimension = proto.Field(
            proto.ENUM,
            number=1,
            oneof='sort_on',
            enum='MediationReportSpec.Dimension',
        )
        metric = proto.Field(
            proto.ENUM,
            number=2,
            oneof='sort_on',
            enum='MediationReportSpec.Metric',
        )
        order = proto.Field(
            proto.ENUM,
            number=3,
            enum='SortOrder',
        )

    date_range = proto.Field(
        proto.MESSAGE,
        number=1,
        message='DateRange',
    )
    dimensions = proto.RepeatedField(
        proto.ENUM,
        number=2,
        enum=Dimension,
    )
    metrics = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=Metric,
    )
    dimension_filters = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=DimensionFilter,
    )
    sort_conditions = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message=SortCondition,
    )
    localization_settings = proto.Field(
        proto.MESSAGE,
        number=6,
        message='LocalizationSettings',
    )
    max_report_rows = proto.Field(
        proto.INT32,
        number=7,
    )
    time_zone = proto.Field(
        proto.STRING,
        number=8,
    )


class ReportRow(proto.Message):
    r"""A row of the returning report.

    Attributes:
        dimension_values (Sequence[google.ads.admob_v1.types.ReportRow.DimensionValuesEntry]):
            Map of dimension values in a row, with keys
            as enum name of the dimensions.
        metric_values (Sequence[google.ads.admob_v1.types.ReportRow.MetricValuesEntry]):
            Map of metric values in a row, with keys as
            enum name of the metrics. If a metric being
            requested has no value returned, the map will
            not include it.
    """

    class DimensionValue(proto.Message):
        r"""Representation of a dimension value.

        Attributes:
            value (str):
                Dimension value in the format specified in
                the report's spec Dimension enum.
            display_label (str):
                The localized string representation of the
                value. If unspecified, the display label should
                be derived from the value.
        """

        value = proto.Field(
            proto.STRING,
            number=1,
        )
        display_label = proto.Field(
            proto.STRING,
            number=2,
        )

    class MetricValue(proto.Message):
        r"""Representation of a metric value.

        Attributes:
            integer_value (int):
                Metric integer value.
            double_value (float):
                Double precision (approximate) decimal
                values. Rates are from 0 to 1.
            micros_value (int):
                Amount in micros. One million is equivalent
                to one unit. Currency value is in the unit (USD,
                EUR or other) specified by the request. For
                example, $6.50 whould be represented as 6500000
                micros.
        """

        integer_value = proto.Field(
            proto.INT64,
            number=1,
            oneof='value',
        )
        double_value = proto.Field(
            proto.DOUBLE,
            number=2,
            oneof='value',
        )
        micros_value = proto.Field(
            proto.INT64,
            number=3,
            oneof='value',
        )

    dimension_values = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=1,
        message=DimensionValue,
    )
    metric_values = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=2,
        message=MetricValue,
    )


class ReportWarning(proto.Message):
    r"""Warnings associated with generation of the report.

    Attributes:
        type_ (google.ads.admob_v1.types.ReportWarning.Type):
            Type of the warning.
        description (str):
            Describes the details of the warning message,
            in English.
    """
    class Type(proto.Enum):
        r"""Warning type."""
        TYPE_UNSPECIFIED = 0
        DATA_BEFORE_ACCOUNT_TIMEZONE_CHANGE = 1
        DATA_DELAYED = 2
        OTHER = 3
        REPORT_CURRENCY_NOT_ACCOUNT_CURRENCY = 4

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )
    description = proto.Field(
        proto.STRING,
        number=2,
    )


class ReportHeader(proto.Message):
    r"""Groups data helps to treat the generated report. Always sent
    as a first message in the stream response.

    Attributes:
        date_range (google.ads.admob_v1.types.DateRange):
            The date range for which the report is
            generated. This is identical to the range
            specified in the report request.
        localization_settings (google.ads.admob_v1.types.LocalizationSettings):
            Localization settings of the report. This is
            identical to the settings in the report request.
        reporting_time_zone (str):
            The report time zone. The value is a time-zone ID as
            specified by the CLDR project, for example,
            "America/Los_Angeles".
    """

    date_range = proto.Field(
        proto.MESSAGE,
        number=1,
        message='DateRange',
    )
    localization_settings = proto.Field(
        proto.MESSAGE,
        number=2,
        message='LocalizationSettings',
    )
    reporting_time_zone = proto.Field(
        proto.STRING,
        number=3,
    )


class ReportFooter(proto.Message):
    r"""Groups data available after report generation, for example,
    warnings and row counts. Always sent as the last message in the
    stream response.

    Attributes:
        warnings (Sequence[google.ads.admob_v1.types.ReportWarning]):
            Warnings associated with generation of the
            report.
        matching_row_count (int):
            Total number of rows that matched the
            request.
            Warning: This count does NOT always match the
            number of rows in the response. Do not make that
            assumption when processing the response.
    """

    warnings = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='ReportWarning',
    )
    matching_row_count = proto.Field(
        proto.INT64,
        number=2,
    )


class DateRange(proto.Message):
    r"""Specification of a single date range. Both dates are
    inclusive.

    Attributes:
        start_date (google.type.date_pb2.Date):
            Start date of the date range, inclusive. Must
            be less than or equal to the end date.
        end_date (google.type.date_pb2.Date):
            End date of the date range, inclusive. Must
            be greater than or equal to the start date.
    """

    start_date = proto.Field(
        proto.MESSAGE,
        number=1,
        message=date_pb2.Date,
    )
    end_date = proto.Field(
        proto.MESSAGE,
        number=2,
        message=date_pb2.Date,
    )


class LocalizationSettings(proto.Message):
    r"""Localization settings for reports, such as currency and
    language. It affects how metrics are calculated.

    Attributes:
        currency_code (str):
            Currency code of the earning related metrics,
            which is the 3-letter code defined in ISO 4217.
            The daily average rate is used for the currency
            conversion. Defaults to the account currency
            code if unspecified.
        language_code (str):
            Language used for any localized text, such as
            some dimension value display labels. The
            language tag defined in the IETF BCP47. Defaults
            to 'en-US' if unspecified.
    """

    currency_code = proto.Field(
        proto.STRING,
        number=1,
    )
    language_code = proto.Field(
        proto.STRING,
        number=2,
    )


class StringList(proto.Message):
    r"""List of string values.

    Attributes:
        values (Sequence[str]):
            The string values.
    """

    values = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
