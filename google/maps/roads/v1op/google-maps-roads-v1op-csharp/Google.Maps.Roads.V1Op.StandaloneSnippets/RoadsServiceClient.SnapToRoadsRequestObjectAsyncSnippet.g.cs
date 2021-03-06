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

namespace Google.Maps.Roads.V1Op.Snippets
{
    using Google.Maps.Roads.V1Op;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRoadsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for SnapToRoadsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SnapToRoadsRequestObjectAsync()
        {
            // Create client
            RoadsServiceClient roadsServiceClient = await RoadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "",
                Interpolate = false,
                AssetId = "",
                TravelMode = TravelMode.Unspecified,
            };
            // Make the request
            SnapToRoadsResponse response = await roadsServiceClient.SnapToRoadsAsync(request);
        }
    }
}
