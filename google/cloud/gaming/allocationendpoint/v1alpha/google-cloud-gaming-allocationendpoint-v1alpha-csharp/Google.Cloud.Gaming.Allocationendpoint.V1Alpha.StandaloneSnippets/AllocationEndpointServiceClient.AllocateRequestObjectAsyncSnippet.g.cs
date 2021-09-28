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

namespace Google.Cloud.Gaming.Allocationendpoint.V1Alpha.Snippets
{
    using Google.Cloud.Gaming.Allocationendpoint.V1Alpha;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAllocationEndpointServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AllocateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task AllocateRequestObjectAsync()
        {
            // Create client
            AllocationEndpointServiceClient allocationEndpointServiceClient = await AllocationEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            AllocationRequest request = new AllocationRequest
            {
                Realm = "",
                DefaultGameServerDeployment = "",
                GameServerSelectors =
                {
                    new GameServerSelector(),
                },
                Metadata = new MetaPatch(),
            };
            // Make the request
            AllocationResponse response = await allocationEndpointServiceClient.AllocateAsync(request);
        }
    }
}
