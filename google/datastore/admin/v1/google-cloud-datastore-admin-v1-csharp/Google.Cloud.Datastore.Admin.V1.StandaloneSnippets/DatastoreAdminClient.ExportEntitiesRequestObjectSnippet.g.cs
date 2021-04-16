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

namespace Google.Cloud.Datastore.Admin.V1.Snippets
{
    using Google.LongRunning;

    public sealed partial class GeneratedDatastoreAdminClientStandaloneSnippets
    {
        /// <summary>Snippet for ExportEntities</summary>
        public void ExportEntitiesRequestObject()
        {
            // Snippet: ExportEntities(ExportEntitiesRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            ExportEntitiesRequest request = new ExportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                EntityFilter = new EntityFilter(),
                OutputUrlPrefix = "",
            };
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = datastoreAdminClient.ExportEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = datastoreAdminClient.PollOnceExportEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
