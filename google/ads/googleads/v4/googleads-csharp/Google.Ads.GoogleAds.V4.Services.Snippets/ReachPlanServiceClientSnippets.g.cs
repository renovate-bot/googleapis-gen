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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedReachPlanServiceClientSnippets
    {
        /// <summary>Snippet for ListPlannableLocations</summary>
        public void ListPlannableLocationsRequestObject()
        {
            // Snippet: ListPlannableLocations(ListPlannableLocationsRequest, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest { };
            // Make the request
            ListPlannableLocationsResponse response = reachPlanServiceClient.ListPlannableLocations(request);
            // End snippet
        }

        /// <summary>Snippet for ListPlannableLocationsAsync</summary>
        public async Task ListPlannableLocationsRequestObjectAsync()
        {
            // Snippet: ListPlannableLocationsAsync(ListPlannableLocationsRequest, CallSettings)
            // Additional: ListPlannableLocationsAsync(ListPlannableLocationsRequest, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest { };
            // Make the request
            ListPlannableLocationsResponse response = await reachPlanServiceClient.ListPlannableLocationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPlannableProducts</summary>
        public void ListPlannableProductsRequestObject()
        {
            // Snippet: ListPlannableProducts(ListPlannableProductsRequest, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "",
            };
            // Make the request
            ListPlannableProductsResponse response = reachPlanServiceClient.ListPlannableProducts(request);
            // End snippet
        }

        /// <summary>Snippet for ListPlannableProductsAsync</summary>
        public async Task ListPlannableProductsRequestObjectAsync()
        {
            // Snippet: ListPlannableProductsAsync(ListPlannableProductsRequest, CallSettings)
            // Additional: ListPlannableProductsAsync(ListPlannableProductsRequest, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "",
            };
            // Make the request
            ListPlannableProductsResponse response = await reachPlanServiceClient.ListPlannableProductsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPlannableProducts</summary>
        public void ListPlannableProducts()
        {
            // Snippet: ListPlannableProducts(string, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            string plannableLocationId = "";
            // Make the request
            ListPlannableProductsResponse response = reachPlanServiceClient.ListPlannableProducts(plannableLocationId);
            // End snippet
        }

        /// <summary>Snippet for ListPlannableProductsAsync</summary>
        public async Task ListPlannableProductsAsync()
        {
            // Snippet: ListPlannableProductsAsync(string, CallSettings)
            // Additional: ListPlannableProductsAsync(string, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string plannableLocationId = "";
            // Make the request
            ListPlannableProductsResponse response = await reachPlanServiceClient.ListPlannableProductsAsync(plannableLocationId);
            // End snippet
        }

        /// <summary>Snippet for GenerateProductMixIdeas</summary>
        public void GenerateProductMixIdeasRequestObject()
        {
            // Snippet: GenerateProductMixIdeas(GenerateProductMixIdeasRequest, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "",
                PlannableLocationId = "",
                CurrencyCode = "",
                BudgetMicros = 0L,
                Preferences = new Preferences(),
            };
            // Make the request
            GenerateProductMixIdeasResponse response = reachPlanServiceClient.GenerateProductMixIdeas(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateProductMixIdeasAsync</summary>
        public async Task GenerateProductMixIdeasRequestObjectAsync()
        {
            // Snippet: GenerateProductMixIdeasAsync(GenerateProductMixIdeasRequest, CallSettings)
            // Additional: GenerateProductMixIdeasAsync(GenerateProductMixIdeasRequest, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "",
                PlannableLocationId = "",
                CurrencyCode = "",
                BudgetMicros = 0L,
                Preferences = new Preferences(),
            };
            // Make the request
            GenerateProductMixIdeasResponse response = await reachPlanServiceClient.GenerateProductMixIdeasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateProductMixIdeas</summary>
        public void GenerateProductMixIdeas()
        {
            // Snippet: GenerateProductMixIdeas(string, string, string, long?, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            string plannableLocationId = "";
            string currencyCode = "";
            long? budgetMicros = 0L;
            // Make the request
            GenerateProductMixIdeasResponse response = reachPlanServiceClient.GenerateProductMixIdeas(customerId, plannableLocationId, currencyCode, budgetMicros);
            // End snippet
        }

        /// <summary>Snippet for GenerateProductMixIdeasAsync</summary>
        public async Task GenerateProductMixIdeasAsync()
        {
            // Snippet: GenerateProductMixIdeasAsync(string, string, string, long?, CallSettings)
            // Additional: GenerateProductMixIdeasAsync(string, string, string, long?, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            string plannableLocationId = "";
            string currencyCode = "";
            long? budgetMicros = 0L;
            // Make the request
            GenerateProductMixIdeasResponse response = await reachPlanServiceClient.GenerateProductMixIdeasAsync(customerId, plannableLocationId, currencyCode, budgetMicros);
            // End snippet
        }

        /// <summary>Snippet for GenerateReachForecast</summary>
        public void GenerateReachForecastRequestObject()
        {
            // Snippet: GenerateReachForecast(GenerateReachForecastRequest, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "",
                CurrencyCode = "",
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = 0,
                MinEffectiveFrequency = 0,
                Targeting = new Targeting(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
                CookieFrequencyCapSetting = new FrequencyCap(),
            };
            // Make the request
            GenerateReachForecastResponse response = reachPlanServiceClient.GenerateReachForecast(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateReachForecastAsync</summary>
        public async Task GenerateReachForecastRequestObjectAsync()
        {
            // Snippet: GenerateReachForecastAsync(GenerateReachForecastRequest, CallSettings)
            // Additional: GenerateReachForecastAsync(GenerateReachForecastRequest, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "",
                CurrencyCode = "",
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = 0,
                MinEffectiveFrequency = 0,
                Targeting = new Targeting(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
                CookieFrequencyCapSetting = new FrequencyCap(),
            };
            // Make the request
            GenerateReachForecastResponse response = await reachPlanServiceClient.GenerateReachForecastAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateReachForecast</summary>
        public void GenerateReachForecast()
        {
            // Snippet: GenerateReachForecast(string, CampaignDuration, IEnumerable<PlannedProduct>, CallSettings)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = ReachPlanServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CampaignDuration campaignDuration = new CampaignDuration();
            IEnumerable<PlannedProduct> plannedProducts = new PlannedProduct[]
            {
                new PlannedProduct(),
            };
            // Make the request
            GenerateReachForecastResponse response = reachPlanServiceClient.GenerateReachForecast(customerId, campaignDuration, plannedProducts);
            // End snippet
        }

        /// <summary>Snippet for GenerateReachForecastAsync</summary>
        public async Task GenerateReachForecastAsync()
        {
            // Snippet: GenerateReachForecastAsync(string, CampaignDuration, IEnumerable<PlannedProduct>, CallSettings)
            // Additional: GenerateReachForecastAsync(string, CampaignDuration, IEnumerable<PlannedProduct>, CancellationToken)
            // Create client
            ReachPlanServiceClient reachPlanServiceClient = await ReachPlanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CampaignDuration campaignDuration = new CampaignDuration();
            IEnumerable<PlannedProduct> plannedProducts = new PlannedProduct[]
            {
                new PlannedProduct(),
            };
            // Make the request
            GenerateReachForecastResponse response = await reachPlanServiceClient.GenerateReachForecastAsync(customerId, campaignDuration, plannedProducts);
            // End snippet
        }
    }
}
