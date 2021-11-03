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
    using Google.Ads.GoogleAds.V9.Common;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedUserDataServiceClientSnippets
    {
        /// <summary>Snippet for UploadUserData</summary>
        public void UploadUserDataRequestObject()
        {
            // Snippet: UploadUserData(UploadUserDataRequest, CallSettings)
            // Create client
            UserDataServiceClient userDataServiceClient = UserDataServiceClient.Create();
            // Initialize request argument(s)
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "",
                CustomerMatchUserListMetadata = new CustomerMatchUserListMetadata(),
                Operations =
                {
                    new UserDataOperation(),
                },
            };
            // Make the request
            UploadUserDataResponse response = userDataServiceClient.UploadUserData(request);
            // End snippet
        }

        /// <summary>Snippet for UploadUserDataAsync</summary>
        public async Task UploadUserDataRequestObjectAsync()
        {
            // Snippet: UploadUserDataAsync(UploadUserDataRequest, CallSettings)
            // Additional: UploadUserDataAsync(UploadUserDataRequest, CancellationToken)
            // Create client
            UserDataServiceClient userDataServiceClient = await UserDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "",
                CustomerMatchUserListMetadata = new CustomerMatchUserListMetadata(),
                Operations =
                {
                    new UserDataOperation(),
                },
            };
            // Make the request
            UploadUserDataResponse response = await userDataServiceClient.UploadUserDataAsync(request);
            // End snippet
        }
    }
}
