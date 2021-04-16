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

namespace Google.Cloud.Osconfig.V1Beta.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsConfigServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateGuestPolicyAsync</summary>
        public async Task CreateGuestPolicyRequestObjectAsync()
        {
            // Snippet: CreateGuestPolicyAsync(CreateGuestPolicyRequest, CallSettings)
            // Additional: CreateGuestPolicyAsync(CreateGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GuestPolicyId = "",
                GuestPolicy = new GuestPolicy(),
            };
            // Make the request
            GuestPolicy response = await osConfigServiceClient.CreateGuestPolicyAsync(request);
            // End snippet
        }
    }
}
