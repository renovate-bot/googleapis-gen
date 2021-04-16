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

namespace Google.Area120.Tables.V1Alpha1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedTablesServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchCreateRowsAsync</summary>
        public async Task BatchCreateRowsRequestObjectAsync()
        {
            // Snippet: BatchCreateRowsAsync(BatchCreateRowsRequest, CallSettings)
            // Additional: BatchCreateRowsAsync(BatchCreateRowsRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRowsRequest request = new BatchCreateRowsRequest
            {
                Parent = "",
                Requests =
                {
                    new CreateRowRequest(),
                },
            };
            // Make the request
            BatchCreateRowsResponse response = await tablesServiceClient.BatchCreateRowsAsync(request);
            // End snippet
        }
    }
}
