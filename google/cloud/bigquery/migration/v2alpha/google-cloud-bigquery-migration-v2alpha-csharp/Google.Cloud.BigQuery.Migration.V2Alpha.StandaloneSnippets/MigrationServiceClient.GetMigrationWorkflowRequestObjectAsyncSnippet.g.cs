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

namespace Google.Cloud.BigQuery.Migration.V2Alpha.Snippets
{
    using Google.Cloud.BigQuery.Migration.V2Alpha;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedMigrationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetMigrationWorkflowAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetMigrationWorkflowRequestObjectAsync()
        {
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.GetMigrationWorkflowAsync(request);
        }
    }
}
