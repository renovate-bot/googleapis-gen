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

namespace Google.Home.Enterprise.Sdm.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedSmartDeviceManagementServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetRoomAsync</summary>
        public async Task GetRoomRequestObjectAsync()
        {
            // Snippet: GetRoomAsync(GetRoomRequest, CallSettings)
            // Additional: GetRoomAsync(GetRoomRequest, CancellationToken)
            // Create client
            SmartDeviceManagementServiceClient smartDeviceManagementServiceClient = await SmartDeviceManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRoomRequest request = new GetRoomRequest { Name = "", };
            // Make the request
            Room response = await smartDeviceManagementServiceClient.GetRoomAsync(request);
            // End snippet
        }
    }
}
