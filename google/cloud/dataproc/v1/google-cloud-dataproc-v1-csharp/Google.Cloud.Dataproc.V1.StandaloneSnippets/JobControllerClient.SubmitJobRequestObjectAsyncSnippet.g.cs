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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedJobControllerClientStandaloneSnippets
    {
        /// <summary>Snippet for SubmitJobAsync</summary>
        public async Task SubmitJobRequestObjectAsync()
        {
            // Snippet: SubmitJobAsync(SubmitJobRequest, CallSettings)
            // Additional: SubmitJobAsync(SubmitJobRequest, CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "",
                Job = new Job(),
                Region = "",
                RequestId = "",
            };
            // Make the request
            Job response = await jobControllerClient.SubmitJobAsync(request);
            // End snippet
        }
    }
}
