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

namespace Google.Cloud.Automl.V1Beta1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAutoMlClientStandaloneSnippets
    {
        /// <summary>Snippet for GetColumnSpecAsync</summary>
        public async Task GetColumnSpecRequestObjectAsync()
        {
            // Snippet: GetColumnSpecAsync(GetColumnSpecRequest, CallSettings)
            // Additional: GetColumnSpecAsync(GetColumnSpecRequest, CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            GetColumnSpecRequest request = new GetColumnSpecRequest
            {
                ColumnSpecName = ColumnSpecName.FromProjectLocationDatasetTableSpecColumnSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[TABLE_SPEC]", "[COLUMN_SPEC]"),
                FieldMask = new FieldMask(),
            };
            // Make the request
            ColumnSpec response = await autoMlClient.GetColumnSpecAsync(request);
            // End snippet
        }
    }
}
