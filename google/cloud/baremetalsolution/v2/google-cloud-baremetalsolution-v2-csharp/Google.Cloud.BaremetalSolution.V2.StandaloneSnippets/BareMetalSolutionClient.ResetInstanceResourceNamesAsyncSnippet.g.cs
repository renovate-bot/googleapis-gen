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

namespace Google.Cloud.BaremetalSolution.V2.Snippets
{
    using Google.Cloud.BaremetalSolution.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBareMetalSolutionClientStandaloneSnippets
    {
        /// <summary>Snippet for ResetInstanceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ResetInstanceResourceNamesAsync()
        {
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
