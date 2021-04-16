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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedKeywordPlanServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GenerateForecastCurveAsync</summary>
        public async Task GenerateForecastCurveResourceNamesAsync()
        {
            // Snippet: GenerateForecastCurveAsync(KeywordPlanName, CallSettings)
            // Additional: GenerateForecastCurveAsync(KeywordPlanName, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateForecastCurveResponse response = await keywordPlanServiceClient.GenerateForecastCurveAsync(keywordPlan);
            // End snippet
        }
    }
}
