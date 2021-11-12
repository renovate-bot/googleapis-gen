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

namespace Google.Cloud.VMMigration.V1.Snippets
{
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedVmMigrationClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateUtilizationReport</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateUtilizationReportRequestObject()
        {
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateUtilizationReportRequest request = new CreateUtilizationReportRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                UtilizationReport = new UtilizationReport(),
                UtilizationReportId = "",
                RequestId = "",
            };
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = vmMigrationClient.CreateUtilizationReport(request);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
