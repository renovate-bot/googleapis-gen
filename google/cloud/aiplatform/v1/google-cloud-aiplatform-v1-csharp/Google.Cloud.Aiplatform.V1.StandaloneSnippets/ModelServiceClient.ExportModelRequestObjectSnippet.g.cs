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
    using Google.LongRunning;

    public sealed partial class GeneratedModelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ExportModel</summary>
        public void ExportModelRequestObject()
        {
            // Snippet: ExportModel(ExportModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ExportModelRequest request = new ExportModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                OutputConfig = new ExportModelRequest.Types.OutputConfig(),
            };
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = modelServiceClient.ExportModel(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceExportModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
