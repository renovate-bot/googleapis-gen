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
    public sealed class GeneratedUserLicenseServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(UserLicenseGetRequest, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserLicenseGetRequest request = new UserLicenseGetRequest
            {
                ApplicationId = "",
                UserId = "",
            };
            // Make the request
            UserLicense response = userLicenseServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(UserLicenseGetRequest, CallSettings)
            // Additional: GetAsync(UserLicenseGetRequest, CancellationToken)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = await UserLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserLicenseGetRequest request = new UserLicenseGetRequest
            {
                ApplicationId = "",
                UserId = "",
            };
            // Make the request
            UserLicense response = await userLicenseServiceClient.GetAsync(request);
            // End snippet
        }
    }
}
