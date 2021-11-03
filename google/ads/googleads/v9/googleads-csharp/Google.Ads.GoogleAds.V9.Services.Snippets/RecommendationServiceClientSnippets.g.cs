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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRecommendationServiceClientSnippets
    {
        /// <summary>Snippet for GetRecommendation</summary>
        public void GetRecommendationRequestObject()
        {
            // Snippet: GetRecommendation(GetRecommendationRequest, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            // Make the request
            Recommendation response = recommendationServiceClient.GetRecommendation(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecommendationAsync</summary>
        public async Task GetRecommendationRequestObjectAsync()
        {
            // Snippet: GetRecommendationAsync(GetRecommendationRequest, CallSettings)
            // Additional: GetRecommendationAsync(GetRecommendationRequest, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            // Make the request
            Recommendation response = await recommendationServiceClient.GetRecommendationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecommendation</summary>
        public void GetRecommendation()
        {
            // Snippet: GetRecommendation(string, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/recommendations/[RECOMMENDATION_ID]";
            // Make the request
            Recommendation response = recommendationServiceClient.GetRecommendation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRecommendationAsync</summary>
        public async Task GetRecommendationAsync()
        {
            // Snippet: GetRecommendationAsync(string, CallSettings)
            // Additional: GetRecommendationAsync(string, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/recommendations/[RECOMMENDATION_ID]";
            // Make the request
            Recommendation response = await recommendationServiceClient.GetRecommendationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRecommendation</summary>
        public void GetRecommendationResourceNames()
        {
            // Snippet: GetRecommendation(RecommendationName, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            RecommendationName resourceName = RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]");
            // Make the request
            Recommendation response = recommendationServiceClient.GetRecommendation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetRecommendationAsync</summary>
        public async Task GetRecommendationResourceNamesAsync()
        {
            // Snippet: GetRecommendationAsync(RecommendationName, CallSettings)
            // Additional: GetRecommendationAsync(RecommendationName, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RecommendationName resourceName = RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]");
            // Make the request
            Recommendation response = await recommendationServiceClient.GetRecommendationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for ApplyRecommendation</summary>
        public void ApplyRecommendationRequestObject()
        {
            // Snippet: ApplyRecommendation(ApplyRecommendationRequest, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            // Make the request
            ApplyRecommendationResponse response = recommendationServiceClient.ApplyRecommendation(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyRecommendationAsync</summary>
        public async Task ApplyRecommendationRequestObjectAsync()
        {
            // Snippet: ApplyRecommendationAsync(ApplyRecommendationRequest, CallSettings)
            // Additional: ApplyRecommendationAsync(ApplyRecommendationRequest, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            // Make the request
            ApplyRecommendationResponse response = await recommendationServiceClient.ApplyRecommendationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyRecommendation</summary>
        public void ApplyRecommendation()
        {
            // Snippet: ApplyRecommendation(string, IEnumerable<ApplyRecommendationOperation>, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ApplyRecommendationOperation> operations = new ApplyRecommendationOperation[]
            {
                new ApplyRecommendationOperation(),
            };
            // Make the request
            ApplyRecommendationResponse response = recommendationServiceClient.ApplyRecommendation(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for ApplyRecommendationAsync</summary>
        public async Task ApplyRecommendationAsync()
        {
            // Snippet: ApplyRecommendationAsync(string, IEnumerable<ApplyRecommendationOperation>, CallSettings)
            // Additional: ApplyRecommendationAsync(string, IEnumerable<ApplyRecommendationOperation>, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ApplyRecommendationOperation> operations = new ApplyRecommendationOperation[]
            {
                new ApplyRecommendationOperation(),
            };
            // Make the request
            ApplyRecommendationResponse response = await recommendationServiceClient.ApplyRecommendationAsync(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for DismissRecommendation</summary>
        public void DismissRecommendationRequestObject()
        {
            // Snippet: DismissRecommendation(DismissRecommendationRequest, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            // Make the request
            DismissRecommendationResponse response = recommendationServiceClient.DismissRecommendation(request);
            // End snippet
        }

        /// <summary>Snippet for DismissRecommendationAsync</summary>
        public async Task DismissRecommendationRequestObjectAsync()
        {
            // Snippet: DismissRecommendationAsync(DismissRecommendationRequest, CallSettings)
            // Additional: DismissRecommendationAsync(DismissRecommendationRequest, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            // Make the request
            DismissRecommendationResponse response = await recommendationServiceClient.DismissRecommendationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DismissRecommendation</summary>
        public void DismissRecommendation()
        {
            // Snippet: DismissRecommendation(string, IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation>, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations = new DismissRecommendationRequest.Types.DismissRecommendationOperation[]
            {
                new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
            };
            // Make the request
            DismissRecommendationResponse response = recommendationServiceClient.DismissRecommendation(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for DismissRecommendationAsync</summary>
        public async Task DismissRecommendationAsync()
        {
            // Snippet: DismissRecommendationAsync(string, IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation>, CallSettings)
            // Additional: DismissRecommendationAsync(string, IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation>, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations = new DismissRecommendationRequest.Types.DismissRecommendationOperation[]
            {
                new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
            };
            // Make the request
            DismissRecommendationResponse response = await recommendationServiceClient.DismissRecommendationAsync(customerId, operations);
            // End snippet
        }
    }
}
