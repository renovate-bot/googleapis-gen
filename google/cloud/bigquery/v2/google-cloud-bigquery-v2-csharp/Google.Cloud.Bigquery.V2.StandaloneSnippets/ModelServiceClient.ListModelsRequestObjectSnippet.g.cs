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
    public sealed partial class GeneratedModelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ListModels</summary>
        public void ListModelsRequestObject()
        {
            // Snippet: ListModels(ListModelsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "",
                DatasetId = "",
                MaxResults = 0U,
                PageToken = "",
            };
            // Make the request
            ListModelsResponse response = modelServiceClient.ListModels(request);
            // End snippet
        }
    }
}
