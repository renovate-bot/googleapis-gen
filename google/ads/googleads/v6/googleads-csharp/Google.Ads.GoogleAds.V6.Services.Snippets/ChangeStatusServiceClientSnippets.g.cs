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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedChangeStatusServiceClientSnippets
    {
        /// <summary>Snippet for GetChangeStatus</summary>
        public void GetChangeStatusRequestObject()
        {
            // Snippet: GetChangeStatus(GetChangeStatusRequest, CallSettings)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = ChangeStatusServiceClient.Create();
            // Initialize request argument(s)
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            // Make the request
            ChangeStatus response = changeStatusServiceClient.GetChangeStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeStatusAsync</summary>
        public async Task GetChangeStatusRequestObjectAsync()
        {
            // Snippet: GetChangeStatusAsync(GetChangeStatusRequest, CallSettings)
            // Additional: GetChangeStatusAsync(GetChangeStatusRequest, CancellationToken)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = await ChangeStatusServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            // Make the request
            ChangeStatus response = await changeStatusServiceClient.GetChangeStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeStatus</summary>
        public void GetChangeStatus()
        {
            // Snippet: GetChangeStatus(string, CallSettings)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = ChangeStatusServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/changeStatus/[CHANGE_STATUS_ID]";
            // Make the request
            ChangeStatus response = changeStatusServiceClient.GetChangeStatus(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetChangeStatusAsync</summary>
        public async Task GetChangeStatusAsync()
        {
            // Snippet: GetChangeStatusAsync(string, CallSettings)
            // Additional: GetChangeStatusAsync(string, CancellationToken)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = await ChangeStatusServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/changeStatus/[CHANGE_STATUS_ID]";
            // Make the request
            ChangeStatus response = await changeStatusServiceClient.GetChangeStatusAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetChangeStatus</summary>
        public void GetChangeStatusResourceNames()
        {
            // Snippet: GetChangeStatus(ChangeStatusName, CallSettings)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = ChangeStatusServiceClient.Create();
            // Initialize request argument(s)
            ChangeStatusName resourceName = ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]");
            // Make the request
            ChangeStatus response = changeStatusServiceClient.GetChangeStatus(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetChangeStatusAsync</summary>
        public async Task GetChangeStatusResourceNamesAsync()
        {
            // Snippet: GetChangeStatusAsync(ChangeStatusName, CallSettings)
            // Additional: GetChangeStatusAsync(ChangeStatusName, CancellationToken)
            // Create client
            ChangeStatusServiceClient changeStatusServiceClient = await ChangeStatusServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangeStatusName resourceName = ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]");
            // Make the request
            ChangeStatus response = await changeStatusServiceClient.GetChangeStatusAsync(resourceName);
            // End snippet
        }
    }
}
