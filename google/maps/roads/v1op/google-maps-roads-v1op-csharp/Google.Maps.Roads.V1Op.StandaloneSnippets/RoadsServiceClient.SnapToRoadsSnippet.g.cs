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
    public sealed partial class GeneratedRoadsServiceClientStandaloneSnippets
    {
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
    }
}
