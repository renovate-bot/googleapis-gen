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

namespace Google.Chromeos.Moblab.V1Beta1.Snippets
{
    using Google.LongRunning;

    public sealed partial class GeneratedBuildServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for StageBuild</summary>
        public void StageBuildRequestObject()
        {
            // Snippet: StageBuild(StageBuildRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            StageBuildRequest request = new StageBuildRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
                Filter = "",
            };
            // Make the request
            Operation<StageBuildResponse, StageBuildMetadata> response = buildServiceClient.StageBuild(request);

            // Poll until the returned long-running operation is complete
            Operation<StageBuildResponse, StageBuildMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StageBuildResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StageBuildResponse, StageBuildMetadata> retrievedResponse = buildServiceClient.PollOnceStageBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StageBuildResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
