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

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for GetModel</summary>
        public void GetModelRequestObject()
        {
            // Snippet: GetModel(GetModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
            };
            // Make the request
            Model response = modelServiceClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelRequestObjectAsync()
        {
            // Snippet: GetModelAsync(GetModelRequest, CallSettings)
            // Additional: GetModelAsync(GetModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
            };
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(string, string, string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            // Make the request
            Model response = modelServiceClient.GetModel(projectId, datasetId, modelId);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(string, string, string, CallSettings)
            // Additional: GetModelAsync(string, string, string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(projectId, datasetId, modelId);
            // End snippet
        }

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

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsRequestObjectAsync()
        {
            // Snippet: ListModelsAsync(ListModelsRequest, CallSettings)
            // Additional: ListModelsAsync(ListModelsRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ProjectId = "",
                DatasetId = "",
                MaxResults = 0U,
                PageToken = "",
            };
            // Make the request
            ListModelsResponse response = await modelServiceClient.ListModelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(string, string, uint?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            uint? maxResults = 0U;
            // Make the request
            ListModelsResponse response = modelServiceClient.ListModels(projectId, datasetId, maxResults);
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(string, string, uint?, CallSettings)
            // Additional: ListModelsAsync(string, string, uint?, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            uint? maxResults = 0U;
            // Make the request
            ListModelsResponse response = await modelServiceClient.ListModelsAsync(projectId, datasetId, maxResults);
            // End snippet
        }

        /// <summary>Snippet for PatchModel</summary>
        public void PatchModelRequestObject()
        {
            // Snippet: PatchModel(PatchModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
                Model = new Model(),
            };
            // Make the request
            Model response = modelServiceClient.PatchModel(request);
            // End snippet
        }

        /// <summary>Snippet for PatchModelAsync</summary>
        public async Task PatchModelRequestObjectAsync()
        {
            // Snippet: PatchModelAsync(PatchModelRequest, CallSettings)
            // Additional: PatchModelAsync(PatchModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchModelRequest request = new PatchModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
                Model = new Model(),
            };
            // Make the request
            Model response = await modelServiceClient.PatchModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PatchModel</summary>
        public void PatchModel()
        {
            // Snippet: PatchModel(string, string, string, Model, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            Model model = new Model();
            // Make the request
            Model response = modelServiceClient.PatchModel(projectId, datasetId, modelId, model);
            // End snippet
        }

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

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelRequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
            };
            // Make the request
            modelServiceClient.DeleteModel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelRequestObjectAsync()
        {
            // Snippet: DeleteModelAsync(DeleteModelRequest, CallSettings)
            // Additional: DeleteModelAsync(DeleteModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ProjectId = "",
                DatasetId = "",
                ModelId = "",
            };
            // Make the request
            await modelServiceClient.DeleteModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(string, string, string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            // Make the request
            modelServiceClient.DeleteModel(projectId, datasetId, modelId);
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync()
        {
            // Snippet: DeleteModelAsync(string, string, string, CallSettings)
            // Additional: DeleteModelAsync(string, string, string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string datasetId = "";
            string modelId = "";
            // Make the request
            await modelServiceClient.DeleteModelAsync(projectId, datasetId, modelId);
            // End snippet
        }
    }
}
