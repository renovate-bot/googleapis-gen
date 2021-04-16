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

namespace Google.Api.ServiceUsage.V1Beta1.Snippets
{
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedServiceUsageClientStandaloneSnippets
    {
        /// <summary>Snippet for ImportConsumerOverridesAsync</summary>
        public async Task ImportConsumerOverridesRequestObjectAsync()
        {
            // Snippet: ImportConsumerOverridesAsync(ImportConsumerOverridesRequest, CallSettings)
            // Additional: ImportConsumerOverridesAsync(ImportConsumerOverridesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ImportConsumerOverridesRequest request = new ImportConsumerOverridesRequest
            {
                Parent = "",
                InlineSource = new OverrideInlineSource(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> response = await serviceUsageClient.ImportConsumerOverridesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportConsumerOverridesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> retrievedResponse = await serviceUsageClient.PollOnceImportConsumerOverridesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportConsumerOverridesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
