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

namespace Google.Cloud.DataCatalog.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataCatalogClientStandaloneSnippets
    {
        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryResourceNamesAsync()
        {
            // Snippet: GetEntryAsync(EntryName, CallSettings)
            // Additional: GetEntryAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            Entry response = await dataCatalogClient.GetEntryAsync(name);
            // End snippet
        }
    }
}
