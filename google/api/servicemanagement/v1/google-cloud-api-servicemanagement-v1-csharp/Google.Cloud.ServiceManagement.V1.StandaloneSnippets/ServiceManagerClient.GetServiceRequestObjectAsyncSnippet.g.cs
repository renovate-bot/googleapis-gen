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

namespace Google.Cloud.ServiceManagement.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedServiceManagerClientStandaloneSnippets
    {
        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { ServiceName = "", };
            // Make the request
            ManagedService response = await serviceManagerClient.GetServiceAsync(request);
            // End snippet
        }
    }
}
