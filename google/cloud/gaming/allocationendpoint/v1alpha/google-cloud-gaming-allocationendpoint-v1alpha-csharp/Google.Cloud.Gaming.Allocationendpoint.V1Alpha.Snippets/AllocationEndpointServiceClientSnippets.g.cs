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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAllocationEndpointServiceClientSnippets
    {
        /// <summary>Snippet for Allocate</summary>
        public void AllocateRequestObject()
        {
            // Snippet: Allocate(AllocationRequest, CallSettings)
            // Create client
            AllocationEndpointServiceClient allocationEndpointServiceClient = AllocationEndpointServiceClient.Create();
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
            AllocationResponse response = allocationEndpointServiceClient.Allocate(request);
            // End snippet
        }

        /// <summary>Snippet for AllocateAsync</summary>
        public async Task AllocateRequestObjectAsync()
        {
            // Snippet: AllocateAsync(AllocationRequest, CallSettings)
            // Additional: AllocateAsync(AllocationRequest, CancellationToken)
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
            // End snippet
        }
    }
}
