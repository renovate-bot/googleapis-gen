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

namespace Google.Cloud.Iot.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDeviceManagerClientStandaloneSnippets
    {
        /// <summary>Snippet for ListDeviceConfigVersionsAsync</summary>
        public async Task ListDeviceConfigVersionsAsync()
        {
            // Snippet: ListDeviceConfigVersionsAsync(string, CallSettings)
            // Additional: ListDeviceConfigVersionsAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            ListDeviceConfigVersionsResponse response = await deviceManagerClient.ListDeviceConfigVersionsAsync(name);
            // End snippet
        }
    }
}
