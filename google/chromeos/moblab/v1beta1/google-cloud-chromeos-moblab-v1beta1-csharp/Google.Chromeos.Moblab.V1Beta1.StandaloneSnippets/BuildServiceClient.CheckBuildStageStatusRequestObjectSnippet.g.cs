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
    public sealed partial class GeneratedBuildServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CheckBuildStageStatus</summary>
        public void CheckBuildStageStatusRequestObject()
        {
            // Snippet: CheckBuildStageStatus(CheckBuildStageStatusRequest, CallSettings)
            // Create client
            BuildServiceClient buildServiceClient = BuildServiceClient.Create();
            // Initialize request argument(s)
            CheckBuildStageStatusRequest request = new CheckBuildStageStatusRequest
            {
                BuildArtifactName = BuildArtifactName.FromBuildTargetModelBuildArtifact("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]"),
            };
            // Make the request
            CheckBuildStageStatusResponse response = buildServiceClient.CheckBuildStageStatus(request);
            // End snippet
        }
    }
}
