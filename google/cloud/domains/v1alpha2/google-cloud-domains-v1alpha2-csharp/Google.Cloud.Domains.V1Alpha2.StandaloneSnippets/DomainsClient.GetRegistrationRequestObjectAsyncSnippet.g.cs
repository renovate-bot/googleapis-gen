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

namespace Google.Cloud.Domains.V1Alpha2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDomainsClientStandaloneSnippets
    {
        /// <summary>Snippet for GetRegistrationAsync</summary>
        public async Task GetRegistrationRequestObjectAsync()
        {
            // Snippet: GetRegistrationAsync(GetRegistrationRequest, CallSettings)
            // Additional: GetRegistrationAsync(GetRegistrationRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Registration response = await domainsClient.GetRegistrationAsync(request);
            // End snippet
        }
    }
}
