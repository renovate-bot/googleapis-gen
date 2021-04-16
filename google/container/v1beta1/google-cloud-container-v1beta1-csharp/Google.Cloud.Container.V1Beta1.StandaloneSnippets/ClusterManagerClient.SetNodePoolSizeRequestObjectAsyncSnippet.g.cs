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

namespace Google.Cloud.Container.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedClusterManagerClientStandaloneSnippets
    {
        /// <summary>Snippet for SetNodePoolSizeAsync</summary>
        public async Task SetNodePoolSizeRequestObjectAsync()
        {
            // Snippet: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CallSettings)
            // Additional: SetNodePoolSizeAsync(SetNodePoolSizeRequest, CancellationToken)
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetNodePoolSizeRequest request = new SetNodePoolSizeRequest
            {
                NodeCount = 0,
                Name = "",
            };
            // Make the request
            Operation response = await clusterManagerClient.SetNodePoolSizeAsync(request);
            // End snippet
        }
    }
}
