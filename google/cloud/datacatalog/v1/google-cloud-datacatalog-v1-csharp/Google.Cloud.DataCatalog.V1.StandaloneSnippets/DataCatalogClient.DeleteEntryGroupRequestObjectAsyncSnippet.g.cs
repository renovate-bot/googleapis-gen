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

namespace Google.Cloud.DataCatalog.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataCatalogClientStandaloneSnippets
    {
        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupRequestObjectAsync()
        {
            // Snippet: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CallSettings)
            // Additional: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Force = false,
            };
            // Make the request
            await dataCatalogClient.DeleteEntryGroupAsync(request);
            // End snippet
        }
    }
}
