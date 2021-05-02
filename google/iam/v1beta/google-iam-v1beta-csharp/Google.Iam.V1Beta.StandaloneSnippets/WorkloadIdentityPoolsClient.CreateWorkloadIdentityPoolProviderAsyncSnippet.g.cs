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
    using Google.Iam.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedWorkloadIdentityPoolsClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateWorkloadIdentityPoolProviderAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateWorkloadIdentityPoolProviderAsync()
        {
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            string workloadIdentityPoolProviderId = "";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
