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

namespace Google.Cloud.OsConfig.V1.Snippets
{
    public sealed partial class GeneratedOsConfigServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CancelPatchJob</summary>
        public void CancelPatchJobRequestObject()
        {
            // Snippet: CancelPatchJob(CancelPatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            // Make the request
            PatchJob response = osConfigServiceClient.CancelPatchJob(request);
            // End snippet
        }
    }
}
