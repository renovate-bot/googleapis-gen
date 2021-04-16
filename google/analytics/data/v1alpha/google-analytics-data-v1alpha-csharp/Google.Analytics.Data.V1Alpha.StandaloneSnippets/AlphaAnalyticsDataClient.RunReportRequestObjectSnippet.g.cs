// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Analytics.Data.V1Alpha.Snippets
{
    public sealed partial class GeneratedAlphaAnalyticsDataClientStandaloneSnippets
    {
        /// <summary>Snippet for RunReport</summary>
        public void RunReportRequestObject()
        {
            // Snippet: RunReport(RunReportRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                Entity = new Entity(),
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Offset = 0L,
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                OrderBys = { new OrderBy(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunReportResponse response = alphaAnalyticsDataClient.RunReport(request);
            // End snippet
        }
    }
}
