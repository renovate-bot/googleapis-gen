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

namespace Google.Iam.V1Beta.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedWorkloadIdentityPoolsClientStandaloneSnippets
    {
        /// <summary>Snippet for GetWorkloadIdentityPoolAsync</summary>
        public async Task GetWorkloadIdentityPoolAsync()
        {
            // Snippet: GetWorkloadIdentityPoolAsync(string, CallSettings)
            // Additional: GetWorkloadIdentityPoolAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            WorkloadIdentityPool response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolAsync(name);
            // End snippet
        }
    }
}
