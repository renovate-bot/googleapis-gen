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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBatchJobServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperations1Async()
        {
            // Snippet: AddBatchJobOperationsAsync(string, string, IEnumerable<MutateOperation>, CallSettings)
            // Additional: AddBatchJobOperationsAsync(string, string, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            string sequenceToken = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(resourceName, sequenceToken, mutateOperations);
            // End snippet
        }
    }
}
