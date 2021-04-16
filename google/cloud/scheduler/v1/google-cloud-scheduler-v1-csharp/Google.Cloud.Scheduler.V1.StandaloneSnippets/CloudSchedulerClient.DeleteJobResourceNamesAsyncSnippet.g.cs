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

namespace Google.Cloud.Scheduler.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudSchedulerClientStandaloneSnippets
    {
        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobResourceNamesAsync()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            await cloudSchedulerClient.DeleteJobAsync(name);
            // End snippet
        }
    }
}
