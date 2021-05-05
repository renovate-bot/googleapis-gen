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

from google.ads.admob_v1.types import admob_resources


__protobuf__ = proto.module(
    package='google.ads.admob.v1',
    manifest={
        'GetPublisherAccountRequest',
        'ListPublisherAccountsRequest',
        'ListPublisherAccountsResponse',
        'GenerateMediationReportRequest',
        'GenerateMediationReportResponse',
        'GenerateNetworkReportRequest',
        'GenerateNetworkReportResponse',
    },
)


class GetPublisherAccountRequest(proto.Message):
    r"""Request to retrieve the specified publisher account.
    Attributes:
        name (str):
            Resource name of the publisher account to
            retrieve. Example: accounts/pub-9876543210987654
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListPublisherAccountsRequest(proto.Message):
    r"""Request to retrieve the AdMob publisher account accessible
    with the client credential. Currently all credentials have
    access to at most 1 account.

    Attributes:
        page_size (int):
            Maximum number of accounts to return.
        page_token (str):
            The value returned by the last
            ``ListPublisherAccountsResponse``; indicates that this is a
            continuation of a prior ``ListPublisherAccounts`` call, and
            that the system should return the next page of data.
    """

    page_size = proto.Field(
        proto.INT32,
        number=1,
    )
    page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class ListPublisherAccountsResponse(proto.Message):
    r"""Response for the publisher account list request.
    Attributes:
        account (Sequence[google.ads.admob_v1.types.PublisherAccount]):
            Publisher that the client credentials can
            access.
        next_page_token (str):
            If not empty, indicates that there might be more accounts
            for the request; you must pass this value in a new
            ``ListPublisherAccountsRequest``.
    """

    @property
    def raw_page(self):
        return self

    account = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=admob_resources.PublisherAccount,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GenerateMediationReportRequest(proto.Message):
    r"""Request to generate an AdMob Mediation report.
    Attributes:
        parent (str):
            Resource name of the account to generate the
            report for. Example:
            accounts/pub-9876543210987654
        report_spec (google.ads.admob_v1.types.MediationReportSpec):
            Network report specification.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    report_spec = proto.Field(
        proto.MESSAGE,
        number=2,
        message=admob_resources.MediationReportSpec,
    )


class GenerateMediationReportResponse(proto.Message):
    r"""The streaming response for the AdMob Mediation report where the
    first response contains the report header, then a stream of row
    responses, and finally a footer as the last response message.

    For example:

    ::

        [{
          "header": {
            "date_range": {
              "start_date": {"year": 2018, "month": 9, "day": 1},
              "end_date": {"year": 2018, "month": 9, "day": 1}
            },
            "localization_settings": {
              "currency_code": "USD",
              "language_code": "en-US"
            }
          }
        },
        {
          "row": {
            "dimension_values": {
              "DATE": {"value": "20180918"},
              "APP": {
                "value": "ca-app-pub-8123415297019784~1001342552",
                 "display_label": "My app name!"
              }
            },
            "metric_values": {
              "ESTIMATED_EARNINGS": {"decimal_value": "1324746"}
            }
          }
        },
        {
          "footer": {"matching_row_count": 1}
        }]

    Attributes:
        header (google.ads.admob_v1.types.ReportHeader):
            Report generation settings that describes the
            report contents, such as the report date range
            and localization settings.
        row (google.ads.admob_v1.types.ReportRow):
            Actual report data.
        footer (google.ads.admob_v1.types.ReportFooter):
            Additional information about the generated
            report, such as warnings about the data.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='payload',
        message=admob_resources.ReportHeader,
    )
    row = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='payload',
        message=admob_resources.ReportRow,
    )
    footer = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='payload',
        message=admob_resources.ReportFooter,
    )


class GenerateNetworkReportRequest(proto.Message):
    r"""Request to generate an AdMob Network report.
    Attributes:
        parent (str):
            Resource name of the account to generate the
            report for. Example:
            accounts/pub-9876543210987654
        report_spec (google.ads.admob_v1.types.NetworkReportSpec):
            Network report specification.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    report_spec = proto.Field(
        proto.MESSAGE,
        number=2,
        message=admob_resources.NetworkReportSpec,
    )


class GenerateNetworkReportResponse(proto.Message):
    r"""The streaming response for the AdMob Network report where the first
    response contains the report header, then a stream of row responses,
    and finally a footer as the last response message.

    For example:

    ::

        [{
          "header": {
            "dateRange": {
              "startDate": {"year": 2018, "month": 9, "day": 1},
              "endDate": {"year": 2018, "month": 9, "day": 1}
            },
            "localizationSettings": {
              "currencyCode": "USD",
              "languageCode": "en-US"
            }
          }
        },
        {
          "row": {
            "dimensionValues": {
              "DATE": {"value": "20180918"},
              "APP": {
                "value": "ca-app-pub-8123415297019784~1001342552",
                 displayLabel: "My app name!"
              }
            },
            "metricValues": {
              "ESTIMATED_EARNINGS": {"microsValue": 6500000}
            }
          }
        },
        {
          "footer": {"matchingRowCount": 1}
        }]

    Attributes:
        header (google.ads.admob_v1.types.ReportHeader):
            Report generation settings that describes the
            report contents, such as the report date range
            and localization settings.
        row (google.ads.admob_v1.types.ReportRow):
            Actual report data.
        footer (google.ads.admob_v1.types.ReportFooter):
            Additional information about the generated
            report, such as warnings about the data.
    """

    header = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='payload',
        message=admob_resources.ReportHeader,
    )
    row = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='payload',
        message=admob_resources.ReportRow,
    )
    footer = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='payload',
        message=admob_resources.ReportFooter,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
