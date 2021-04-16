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

namespace Google.Cloud.Tpu.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedTpuClientStandaloneSnippets
    {
        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeRequestObjectAsync()
        {
            // Snippet: GetNodeAsync(GetNodeRequest, CallSettings)
            // Additional: GetNodeAsync(GetNodeRequest, CancellationToken)
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            // Make the request
            Node response = await tpuClient.GetNodeAsync(request);
            // End snippet
        }
    }
}
