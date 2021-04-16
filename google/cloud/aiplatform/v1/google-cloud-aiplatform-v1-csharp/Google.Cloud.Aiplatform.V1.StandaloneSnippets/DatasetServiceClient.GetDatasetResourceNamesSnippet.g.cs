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
    public sealed partial class GeneratedDatasetServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = datasetServiceClient.GetDataset(name);
            // End snippet
        }
    }
}
