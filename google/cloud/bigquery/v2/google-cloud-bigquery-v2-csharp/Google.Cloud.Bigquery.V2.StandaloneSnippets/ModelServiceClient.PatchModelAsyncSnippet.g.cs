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

namespace Google.Cloud.Bigquery.V2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedModelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for PatchModelAsync</summary>
        public async Task PatchModelAsync()
        {
            // Snippet: PatchModelAsync(string, string, string, Model, CallSettings)
            // Additional: PatchModelAsync(string, string, string, Model, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            Model model = new Model();
            // Make the request
            Model response = await modelServiceClient.PatchModelAsync(projectId, datasetId, modelId, model);
            // End snippet
        }
    }
}
