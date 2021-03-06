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

namespace Ccc.Hosted.Marketplace.V2.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerLicenseServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(CustomerLicenseGetRequest, CallSettings)
            // Create client
            CustomerLicenseServiceClient customerLicenseServiceClient = CustomerLicenseServiceClient.Create();
            // Initialize request argument(s)
            CustomerLicenseGetRequest request = new CustomerLicenseGetRequest
            {
                ApplicationId = "",
                CustomerId = "",
            };
            // Make the request
            CustomerLicense response = customerLicenseServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(CustomerLicenseGetRequest, CallSettings)
            // Additional: GetAsync(CustomerLicenseGetRequest, CancellationToken)
            // Create client
            CustomerLicenseServiceClient customerLicenseServiceClient = await CustomerLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerLicenseGetRequest request = new CustomerLicenseGetRequest
            {
                ApplicationId = "",
                CustomerId = "",
            };
            // Make the request
            CustomerLicense response = await customerLicenseServiceClient.GetAsync(request);
            // End snippet
        }
    }
}
