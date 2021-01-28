# -*- coding: utf-8 -*-
#
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

"""Wrappers for protocol buffer enum types."""

import enum


class SortOrder(enum.IntEnum):
    """
    The sorting order.

    Attributes:
      SORT_ORDER_UNSPECIFIED (int): Default value for an unset field. Do not use.
      ASCENDING (int): Sort dimension value or metric value in ascending order.
      DESCENDING (int): Sort dimension value or metric value in descending order.
    """
    SORT_ORDER_UNSPECIFIED = 0
    ASCENDING = 1
    DESCENDING = 2


class MediationReportSpec(object):
    class Dimension(enum.IntEnum):
        """
        The dimensions of the mediation report. Dimensions are data attributes to
        break down or refine the quantitative measurements (metrics) by certain
        attributes, such as the ad format or the platform an ad was viewed on.

        Attributes:
          DIMENSION_UNSPECIFIED (int): Default value for an unset field. Do not use.
          DATE (int): A date in the YYYY-MM-DD format (for example, "2018-12-21"). Requests can
          specify at most one time dimension.
          MONTH (int): A month in the YYYY-MM format (for example, "2018-12"). Requests can
          specify at most one time dimension.
          WEEK (int): The date of the first day of a week in the YYYY-MM-DD format
          (for example, "2018-12-21"). Requests can specify at most one time
          dimension.
          AD_SOURCE (int): The `unique ID of the ad
          source <https://cloud.google.com/admob/api/v1/ad_sources>`__ (for
          example, "5450213213286189855" and "AdMob Network" as label value).
          AD_SOURCE_INSTANCE (int): The unique ID of the ad source instance (for example,
          "ca-app-pub-1234#5678" and "AdMob (default)" as label value).
          AD_UNIT (int): The unique ID of the ad unit (for example, "ca-app-pub-1234/8790").
          If AD_UNIT dimension is specified, then APP is included automatically.
          APP (int): The unique ID of the mobile application (for example,
          "ca-app-pub-1234~1234").
          MEDIATION_GROUP (int): The unique ID of the mediation group (for example,
          "ca-app-pub-1234:mg:1234" and "AdMob (default)" as label value).
          COUNTRY (int): CLDR country code of the place where the ad views/clicks occur (for
          example, "US" or "FR"). This is a geography dimension.
          FORMAT (int): Format of the ad unit (for example, "banner", "native"), an ad delivery
          dimension.
          PLATFORM (int): Mobile OS platform of the app (for example, "Android" or "iOS").
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


    class Metric(enum.IntEnum):
        """
        The metrics of the mediation report. Metrics are quantitative measurements
        indicating how the publisher business is performing. They are aggregated
        from the individual ad events and grouped by the report dimensions. The
        metric value is either integer, or decimal (without rounding).

        Attributes:
          METRIC_UNSPECIFIED (int): Default value for an unset field. Do not use.
          AD_REQUESTS (int): The number of requests. The value is an integer.
          CLICKS (int): The number of times a user clicks an ad. The value is an integer.
          ESTIMATED_EARNINGS (int): The estimated earnings of the AdMob publisher. The currency unit (USD,
          EUR, or other) of the earning metrics are determined by the localization
          setting for currency. The amount is in micros. For example, $6.50 would
          be represented as 6500000.

          Estimated earnings per mediation group and per ad source instance level
          is supported dating back to October 20, 2019. Third-party estimated
          earnings will show 0 for dates prior to October 20, 2019.
          IMPRESSIONS (int): The total number of ads shown to users. The value is an integer.
          IMPRESSION_CTR (int): The ratio of clicks over impressions. The value is a double precision
          (approximate) decimal value.
          MATCHED_REQUESTS (int): The number of times ads are returned in response to a request. The value
          is an integer.
          MATCH_RATE (int): The ratio of matched ad requests over the total ad requests. The value is
          a double precision (approximate) decimal value.
          OBSERVED_ECPM (int): The third-party ad network's estimated average eCPM. The currency unit
          (USD, EUR, or other) of the earning metrics are determined by the
          localization setting for currency. The amount is in micros. For example,
          $2.30 would be represented as 2300000.

          The estimated average eCPM per mediation group and per ad source instance
          level is supported dating back to October 20, 2019. Third-party estimated
          average eCPM will show 0 for dates prior to October 20, 2019.
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


class NetworkReportSpec(object):
    class Dimension(enum.IntEnum):
        """
        The dimensions of the network report. Dimensions are data attributes to
        break down or refine the quantitative measurements (metrics) by certain
        attributes, such as the ad format or the platform an ad was viewed on.

        Attributes:
          DIMENSION_UNSPECIFIED (int): Default value for an unset field. Do not use.
          DATE (int): A date in the YYYY-MM-DD format (for example, "2018-12-21"). Requests can
          specify at most one time dimension.
          MONTH (int): A month in the YYYY-MM format (for example, "2018-12"). Requests can
          specify at most one time dimension.
          WEEK (int): The date of the first day of a week in the YYYY-MM-DD format
          (for example, "2018-12-21"). Requests can specify at most one time
          dimension.
          AD_UNIT (int): The unique ID of the ad unit (for example, "ca-app-pub-1234/1234").
          If AD_UNIT dimension is specified, then APP is included automatically.
          APP (int): The unique ID of the mobile application (for example,
          "ca-app-pub-1234~1234").
          AD_TYPE (int): Type of the ad (for example, "text" or "image"), an ad delivery
          dimension.

          **Warning:** The dimension is incompatible with
          `AD_REQUESTS <#Metric.ENUM_VALUES.AD_REQUESTS>`__,
          `MATCH_RATE <#Metric.ENUM_VALUES.MATCH_RATE>`__ and
          `IMPRESSION_RPM <#Metric.ENUM_VALUES.IMPRESSION_RPM>`__ metrics.
          COUNTRY (int): CLDR country code of the place where the ad views/clicks occur (for
          example, "US" or "FR"). This is a geography dimension.
          FORMAT (int): Format of the ad unit (for example, "banner", "native"), an ad delivery
          dimension.
          PLATFORM (int): Mobile OS platform of the app (for example, "Android" or "iOS").
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


    class Metric(enum.IntEnum):
        """
        The metrics of the network report. Metrics are quantitative measurements
        indicating how the publisher business is performing. They are aggregated
        from the individual ad events and grouped by the report dimensions. The
        metric value is either integer, or decimal (without rounding).

        Attributes:
          METRIC_UNSPECIFIED (int): Default value for an unset field. Do not use.
          AD_REQUESTS (int): The number of ad requests. The value is an integer.

          **Warning:** The metric is incompatible with
          `AD_TYPE <#Dimension.ENUM_VALUES.AD_TYPE>`__ dimension.
          CLICKS (int): The number of times a user clicks an ad. The value is an integer.
          ESTIMATED_EARNINGS (int): The estimated earnings of the AdMob publisher. The currency unit (USD,
          EUR, or other) of the earning metrics are determined by the localization
          setting for currency. The amount is in micros. For example, $6.50 would
          be represented as 6500000.
          IMPRESSIONS (int): The total number of ads shown to users. The value is an integer.
          IMPRESSION_CTR (int): The ratio of clicks over impressions. The value is a double precision
          (approximate) decimal value.
          IMPRESSION_RPM (int): The estimated earnings per thousand ad impressions. The value is in
          micros. For example, $1.03 would be represented as 1030000.

          **Warning:** The metric is incompatible with
          `AD_TYPE <#Dimension.ENUM_VALUES.AD_TYPE>`__ dimension.
          MATCHED_REQUESTS (int): The number of times ads are returned in response to a request. The value
          is an integer.
          MATCH_RATE (int): The ratio of matched ad requests over the total ad requests. The
          value is a double precision (approximate) decimal value.

          **Warning:** The metric is incompatible with
          `AD_TYPE <#Dimension.ENUM_VALUES.AD_TYPE>`__ dimension.
          SHOW_RATE (int): The ratio of ads that are displayed over ads that are returned, defined
          as impressions / matched requests. The value is a double precision
          (approximate) decimal value.
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


class ReportWarning(object):
    class Type(enum.IntEnum):
        """
        Warning type.

        Attributes:
          TYPE_UNSPECIFIED (int): Default value for an unset field. Do not use.
          DATA_BEFORE_ACCOUNT_TIMEZONE_CHANGE (int): Some data in this report is aggregated based on a time zone different
          from the requested time zone. This could happen if a local time-zone
          report has the start time before the last time this time zone changed.
          The description field will contain the date of the last time zone
          change.
          DATA_DELAYED (int): There is an unusual delay in processing the source data for the
          requested date range. The report results might be less up to date than
          usual. AdMob is aware of the issue and is actively working to resolve
          it.
          OTHER (int): Warnings that are exposed without a specific type. Useful when new
          warning types are added but the API is not changed yet.
          REPORT_CURRENCY_NOT_ACCOUNT_CURRENCY (int): The currency being requested is not the account currency. The earning
          metrics will be based on the requested currency, and thus not a good
          estimation of the final payment anymore, due to the currency rate
          fluctuation.
        """
        TYPE_UNSPECIFIED = 0
        DATA_BEFORE_ACCOUNT_TIMEZONE_CHANGE = 1
        DATA_DELAYED = 2
        OTHER = 3
        REPORT_CURRENCY_NOT_ACCOUNT_CURRENCY = 4
    