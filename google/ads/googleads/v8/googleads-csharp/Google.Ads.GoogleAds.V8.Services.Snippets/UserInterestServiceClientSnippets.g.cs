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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedUserInterestServiceClientSnippets
    {
        /// <summary>Snippet for GetUserInterest</summary>
        public void GetUserInterestRequestObject()
        {
            // Snippet: GetUserInterest(GetUserInterestRequest, CallSettings)
            // Create client
            UserInterestServiceClient userInterestServiceClient = UserInterestServiceClient.Create();
            // Initialize request argument(s)
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = UserInterestName.FromCustomerUserInterest("[CUSTOMER_ID]", "[USER_INTEREST_ID]"),
            };
            // Make the request
            UserInterest response = userInterestServiceClient.GetUserInterest(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserInterestAsync</summary>
        public async Task GetUserInterestRequestObjectAsync()
        {
            // Snippet: GetUserInterestAsync(GetUserInterestRequest, CallSettings)
            // Additional: GetUserInterestAsync(GetUserInterestRequest, CancellationToken)
            // Create client
            UserInterestServiceClient userInterestServiceClient = await UserInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = UserInterestName.FromCustomerUserInterest("[CUSTOMER_ID]", "[USER_INTEREST_ID]"),
            };
            // Make the request
            UserInterest response = await userInterestServiceClient.GetUserInterestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserInterest</summary>
        public void GetUserInterest()
        {
            // Snippet: GetUserInterest(string, CallSettings)
            // Create client
            UserInterestServiceClient userInterestServiceClient = UserInterestServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/userInterests/[USER_INTEREST_ID]";
            // Make the request
            UserInterest response = userInterestServiceClient.GetUserInterest(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserInterestAsync</summary>
        public async Task GetUserInterestAsync()
        {
            // Snippet: GetUserInterestAsync(string, CallSettings)
            // Additional: GetUserInterestAsync(string, CancellationToken)
            // Create client
            UserInterestServiceClient userInterestServiceClient = await UserInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/userInterests/[USER_INTEREST_ID]";
            // Make the request
            UserInterest response = await userInterestServiceClient.GetUserInterestAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserInterest</summary>
        public void GetUserInterestResourceNames()
        {
            // Snippet: GetUserInterest(UserInterestName, CallSettings)
            // Create client
            UserInterestServiceClient userInterestServiceClient = UserInterestServiceClient.Create();
            // Initialize request argument(s)
            UserInterestName resourceName = UserInterestName.FromCustomerUserInterest("[CUSTOMER_ID]", "[USER_INTEREST_ID]");
            // Make the request
            UserInterest response = userInterestServiceClient.GetUserInterest(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserInterestAsync</summary>
        public async Task GetUserInterestResourceNamesAsync()
        {
            // Snippet: GetUserInterestAsync(UserInterestName, CallSettings)
            // Additional: GetUserInterestAsync(UserInterestName, CancellationToken)
            // Create client
            UserInterestServiceClient userInterestServiceClient = await UserInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserInterestName resourceName = UserInterestName.FromCustomerUserInterest("[CUSTOMER_ID]", "[USER_INTEREST_ID]");
            // Make the request
            UserInterest response = await userInterestServiceClient.GetUserInterestAsync(resourceName);
            // End snippet
        }
    }
}
