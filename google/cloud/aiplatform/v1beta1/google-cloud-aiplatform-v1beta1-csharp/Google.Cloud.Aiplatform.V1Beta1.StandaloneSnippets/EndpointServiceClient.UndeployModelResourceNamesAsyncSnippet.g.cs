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

namespace Google.Cloud.Aiplatform.V1Beta1.Snippets
{
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEndpointServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelResourceNamesAsync()
        {
            // Snippet: UndeployModelAsync(EndpointName, string, IDictionary<string,int>, CallSettings)
            // Additional: UndeployModelAsync(EndpointName, string, IDictionary<string,int>, CancellationToken)
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            string deployedModelId = "";
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> response = await endpointServiceClient.UndeployModelAsync(endpoint, deployedModelId, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployModelResponse, UndeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
