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
        /// <summary>Snippet for RetrieveRegisterParametersAsync</summary>
        public async Task RetrieveRegisterParametersAsync()
        {
            // Snippet: RetrieveRegisterParametersAsync(string, string, CallSettings)
            // Additional: RetrieveRegisterParametersAsync(string, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            // Make the request
            RetrieveRegisterParametersResponse response = await domainsClient.RetrieveRegisterParametersAsync(location, domainName);
            // End snippet
        }
    }
}
