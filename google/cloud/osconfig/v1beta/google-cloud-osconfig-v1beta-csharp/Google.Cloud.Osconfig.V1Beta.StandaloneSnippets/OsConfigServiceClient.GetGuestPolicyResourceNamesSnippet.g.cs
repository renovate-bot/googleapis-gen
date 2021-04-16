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
    public sealed partial class GeneratedOsConfigServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetGuestPolicy</summary>
        public void GetGuestPolicyResourceNames()
        {
            // Snippet: GetGuestPolicy(GuestPolicyName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GuestPolicyName name = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]");
            // Make the request
            GuestPolicy response = osConfigServiceClient.GetGuestPolicy(name);
            // End snippet
        }
    }
}
