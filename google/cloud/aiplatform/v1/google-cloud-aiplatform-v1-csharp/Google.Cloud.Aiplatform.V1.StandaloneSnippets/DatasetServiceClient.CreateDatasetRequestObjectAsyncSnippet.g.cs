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

namespace Google.Cloud.Aiplatform.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatasetServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = await datasetServiceClient.CreateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
