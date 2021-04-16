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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedKeywordPlanServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordPlan</summary>
        public void GetKeywordPlanRequestObject()
        {
            // Snippet: GetKeywordPlan(GetKeywordPlanRequest, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            KeywordPlan response = keywordPlanServiceClient.GetKeywordPlan(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAsync</summary>
        public async Task GetKeywordPlanRequestObjectAsync()
        {
            // Snippet: GetKeywordPlanAsync(GetKeywordPlanRequest, CallSettings)
            // Additional: GetKeywordPlanAsync(GetKeywordPlanRequest, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            KeywordPlan response = await keywordPlanServiceClient.GetKeywordPlanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlan</summary>
        public void GetKeywordPlan()
        {
            // Snippet: GetKeywordPlan(string, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            KeywordPlan response = keywordPlanServiceClient.GetKeywordPlan(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAsync</summary>
        public async Task GetKeywordPlanAsync()
        {
            // Snippet: GetKeywordPlanAsync(string, CallSettings)
            // Additional: GetKeywordPlanAsync(string, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            KeywordPlan response = await keywordPlanServiceClient.GetKeywordPlanAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlan</summary>
        public void GetKeywordPlanResourceNames()
        {
            // Snippet: GetKeywordPlan(KeywordPlanName, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanName resourceName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            KeywordPlan response = keywordPlanServiceClient.GetKeywordPlan(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAsync</summary>
        public async Task GetKeywordPlanResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanAsync(KeywordPlanName, CallSettings)
            // Additional: GetKeywordPlanAsync(KeywordPlanName, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanName resourceName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            KeywordPlan response = await keywordPlanServiceClient.GetKeywordPlanAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlans</summary>
        public void MutateKeywordPlansRequestObject()
        {
            // Snippet: MutateKeywordPlans(MutateKeywordPlansRequest, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlansResponse response = keywordPlanServiceClient.MutateKeywordPlans(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlansAsync</summary>
        public async Task MutateKeywordPlansRequestObjectAsync()
        {
            // Snippet: MutateKeywordPlansAsync(MutateKeywordPlansRequest, CallSettings)
            // Additional: MutateKeywordPlansAsync(MutateKeywordPlansRequest, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlansResponse response = await keywordPlanServiceClient.MutateKeywordPlansAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlans</summary>
        public void MutateKeywordPlans()
        {
            // Snippet: MutateKeywordPlans(string, IEnumerable<KeywordPlanOperation>, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanOperation> operations = new KeywordPlanOperation[]
            {
                new KeywordPlanOperation(),
            };
            // Make the request
            MutateKeywordPlansResponse response = keywordPlanServiceClient.MutateKeywordPlans(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlansAsync</summary>
        public async Task MutateKeywordPlansAsync()
        {
            // Snippet: MutateKeywordPlansAsync(string, IEnumerable<KeywordPlanOperation>, CallSettings)
            // Additional: MutateKeywordPlansAsync(string, IEnumerable<KeywordPlanOperation>, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanOperation> operations = new KeywordPlanOperation[]
            {
                new KeywordPlanOperation(),
            };
            // Make the request
            MutateKeywordPlansResponse response = await keywordPlanServiceClient.MutateKeywordPlansAsync(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastCurve</summary>
        public void GenerateForecastCurveRequestObject()
        {
            // Snippet: GenerateForecastCurve(GenerateForecastCurveRequest, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateForecastCurveResponse response = keywordPlanServiceClient.GenerateForecastCurve(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastCurveAsync</summary>
        public async Task GenerateForecastCurveRequestObjectAsync()
        {
            // Snippet: GenerateForecastCurveAsync(GenerateForecastCurveRequest, CallSettings)
            // Additional: GenerateForecastCurveAsync(GenerateForecastCurveRequest, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateForecastCurveResponse response = await keywordPlanServiceClient.GenerateForecastCurveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastCurve</summary>
        public void GenerateForecastCurve()
        {
            // Snippet: GenerateForecastCurve(string, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateForecastCurveResponse response = keywordPlanServiceClient.GenerateForecastCurve(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastCurveAsync</summary>
        public async Task GenerateForecastCurveAsync()
        {
            // Snippet: GenerateForecastCurveAsync(string, CallSettings)
            // Additional: GenerateForecastCurveAsync(string, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateForecastCurveResponse response = await keywordPlanServiceClient.GenerateForecastCurveAsync(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastCurve</summary>
        public void GenerateForecastCurveResourceNames()
        {
            // Snippet: GenerateForecastCurve(KeywordPlanName, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateForecastCurveResponse response = keywordPlanServiceClient.GenerateForecastCurve(keywordPlan);
            // End snippet
        }

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

        /// <summary>Snippet for GenerateForecastMetrics</summary>
        public void GenerateForecastMetricsRequestObject()
        {
            // Snippet: GenerateForecastMetrics(GenerateForecastMetricsRequest, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateForecastMetricsResponse response = keywordPlanServiceClient.GenerateForecastMetrics(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastMetricsAsync</summary>
        public async Task GenerateForecastMetricsRequestObjectAsync()
        {
            // Snippet: GenerateForecastMetricsAsync(GenerateForecastMetricsRequest, CallSettings)
            // Additional: GenerateForecastMetricsAsync(GenerateForecastMetricsRequest, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateForecastMetricsResponse response = await keywordPlanServiceClient.GenerateForecastMetricsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastMetrics</summary>
        public void GenerateForecastMetrics()
        {
            // Snippet: GenerateForecastMetrics(string, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateForecastMetricsResponse response = keywordPlanServiceClient.GenerateForecastMetrics(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastMetricsAsync</summary>
        public async Task GenerateForecastMetricsAsync()
        {
            // Snippet: GenerateForecastMetricsAsync(string, CallSettings)
            // Additional: GenerateForecastMetricsAsync(string, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateForecastMetricsResponse response = await keywordPlanServiceClient.GenerateForecastMetricsAsync(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastMetrics</summary>
        public void GenerateForecastMetricsResourceNames()
        {
            // Snippet: GenerateForecastMetrics(KeywordPlanName, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateForecastMetricsResponse response = keywordPlanServiceClient.GenerateForecastMetrics(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateForecastMetricsAsync</summary>
        public async Task GenerateForecastMetricsResourceNamesAsync()
        {
            // Snippet: GenerateForecastMetricsAsync(KeywordPlanName, CallSettings)
            // Additional: GenerateForecastMetricsAsync(KeywordPlanName, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateForecastMetricsResponse response = await keywordPlanServiceClient.GenerateForecastMetricsAsync(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetrics</summary>
        public void GenerateHistoricalMetricsRequestObject()
        {
            // Snippet: GenerateHistoricalMetrics(GenerateHistoricalMetricsRequest, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateHistoricalMetricsResponse response = keywordPlanServiceClient.GenerateHistoricalMetrics(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetricsAsync</summary>
        public async Task GenerateHistoricalMetricsRequestObjectAsync()
        {
            // Snippet: GenerateHistoricalMetricsAsync(GenerateHistoricalMetricsRequest, CallSettings)
            // Additional: GenerateHistoricalMetricsAsync(GenerateHistoricalMetricsRequest, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            // Make the request
            GenerateHistoricalMetricsResponse response = await keywordPlanServiceClient.GenerateHistoricalMetricsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetrics</summary>
        public void GenerateHistoricalMetrics()
        {
            // Snippet: GenerateHistoricalMetrics(string, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateHistoricalMetricsResponse response = keywordPlanServiceClient.GenerateHistoricalMetrics(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetricsAsync</summary>
        public async Task GenerateHistoricalMetricsAsync()
        {
            // Snippet: GenerateHistoricalMetricsAsync(string, CallSettings)
            // Additional: GenerateHistoricalMetricsAsync(string, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string keywordPlan = "customers/[CUSTOMER]/keywordPlans/[KEYWORD_PLAN]";
            // Make the request
            GenerateHistoricalMetricsResponse response = await keywordPlanServiceClient.GenerateHistoricalMetricsAsync(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetrics</summary>
        public void GenerateHistoricalMetricsResourceNames()
        {
            // Snippet: GenerateHistoricalMetrics(KeywordPlanName, CallSettings)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = KeywordPlanServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateHistoricalMetricsResponse response = keywordPlanServiceClient.GenerateHistoricalMetrics(keywordPlan);
            // End snippet
        }

        /// <summary>Snippet for GenerateHistoricalMetricsAsync</summary>
        public async Task GenerateHistoricalMetricsResourceNamesAsync()
        {
            // Snippet: GenerateHistoricalMetricsAsync(KeywordPlanName, CallSettings)
            // Additional: GenerateHistoricalMetricsAsync(KeywordPlanName, CancellationToken)
            // Create client
            KeywordPlanServiceClient keywordPlanServiceClient = await KeywordPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanName keywordPlan = KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]");
            // Make the request
            GenerateHistoricalMetricsResponse response = await keywordPlanServiceClient.GenerateHistoricalMetricsAsync(keywordPlan);
            // End snippet
        }
    }
}
