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

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableTableAdminClientStandaloneSnippets
    {
        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableRequestObjectAsync()
        {
            // Snippet: GetTableAsync(GetTableRequest, CallSettings)
            // Additional: GetTableAsync(GetTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = Table.Types.View.Unspecified,
            };
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(request);
            // End snippet
        }
    }
}
