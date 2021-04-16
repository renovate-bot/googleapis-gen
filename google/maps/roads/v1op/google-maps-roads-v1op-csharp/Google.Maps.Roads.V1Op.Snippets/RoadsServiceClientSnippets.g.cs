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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRoadsServiceClientSnippets
    {
        /// <summary>Snippet for SnapToRoads</summary>
        public void SnapToRoadsRequestObject()
        {
            // Snippet: SnapToRoads(SnapToRoadsRequest, CallSettings)
            // Create client
            RoadsServiceClient roadsServiceClient = RoadsServiceClient.Create();
            // Initialize request argument(s)
            SnapToRoadsRequest request = new SnapToRoadsRequest
            {
                Path = "",
                Interpolate = false,
                AssetId = "",
                TravelMode = TravelMode.Unspecified,
            };
            // Make the request
            SnapToRoadsResponse response = roadsServiceClient.SnapToRoads(request);
            // End snippet
        }

        /// <summary>Snippet for SnapToRoadsAsync</summary>
        public async Task SnapToRoadsRequestObjectAsync()
        {
            // Snippet: SnapToRoadsAsync(SnapToRoadsRequest, CallSettings)
            // Additional: SnapToRoadsAsync(SnapToRoadsRequest, CancellationToken)
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
            // End snippet
        }

        /// <summary>Snippet for SnapToRoads</summary>
        public void SnapToRoads()
        {
            // Snippet: SnapToRoads(string, CallSettings)
            // Create client
            RoadsServiceClient roadsServiceClient = RoadsServiceClient.Create();
            // Initialize request argument(s)
            string path = "";
            // Make the request
            SnapToRoadsResponse response = roadsServiceClient.SnapToRoads(path);
            // End snippet
        }

        /// <summary>Snippet for SnapToRoadsAsync</summary>
        public async Task SnapToRoadsAsync()
        {
            // Snippet: SnapToRoadsAsync(string, CallSettings)
            // Additional: SnapToRoadsAsync(string, CancellationToken)
            // Create client
            RoadsServiceClient roadsServiceClient = await RoadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string path = "";
            // Make the request
            SnapToRoadsResponse response = await roadsServiceClient.SnapToRoadsAsync(path);
            // End snippet
        }

        /// <summary>Snippet for ListNearestRoads</summary>
        public void ListNearestRoadsRequestObject()
        {
            // Snippet: ListNearestRoads(ListNearestRoadsRequest, CallSettings)
            // Create client
            RoadsServiceClient roadsServiceClient = RoadsServiceClient.Create();
            // Initialize request argument(s)
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "",
                TravelMode = TravelMode.Unspecified,
            };
            // Make the request
            ListNearestRoadsResponse response = roadsServiceClient.ListNearestRoads(request);
            // End snippet
        }

        /// <summary>Snippet for ListNearestRoadsAsync</summary>
        public async Task ListNearestRoadsRequestObjectAsync()
        {
            // Snippet: ListNearestRoadsAsync(ListNearestRoadsRequest, CallSettings)
            // Additional: ListNearestRoadsAsync(ListNearestRoadsRequest, CancellationToken)
            // Create client
            RoadsServiceClient roadsServiceClient = await RoadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNearestRoadsRequest request = new ListNearestRoadsRequest
            {
                Points = "",
                TravelMode = TravelMode.Unspecified,
            };
            // Make the request
            ListNearestRoadsResponse response = await roadsServiceClient.ListNearestRoadsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNearestRoads</summary>
        public void ListNearestRoads()
        {
            // Snippet: ListNearestRoads(string, CallSettings)
            // Create client
            RoadsServiceClient roadsServiceClient = RoadsServiceClient.Create();
            // Initialize request argument(s)
            string points = "";
            // Make the request
            ListNearestRoadsResponse response = roadsServiceClient.ListNearestRoads(points);
            // End snippet
        }

        /// <summary>Snippet for ListNearestRoadsAsync</summary>
        public async Task ListNearestRoadsAsync()
        {
            // Snippet: ListNearestRoadsAsync(string, CallSettings)
            // Additional: ListNearestRoadsAsync(string, CancellationToken)
            // Create client
            RoadsServiceClient roadsServiceClient = await RoadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string points = "";
            // Make the request
            ListNearestRoadsResponse response = await roadsServiceClient.ListNearestRoadsAsync(points);
            // End snippet
        }
    }
}
