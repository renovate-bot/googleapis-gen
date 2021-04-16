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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUptimeCheckServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigRequestObjectAsync()
        {
            // Snippet: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(request);
            // End snippet
        }
    }
}
