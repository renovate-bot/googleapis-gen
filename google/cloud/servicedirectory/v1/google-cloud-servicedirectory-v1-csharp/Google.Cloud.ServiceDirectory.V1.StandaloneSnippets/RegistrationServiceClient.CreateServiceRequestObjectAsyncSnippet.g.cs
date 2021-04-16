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

namespace Google.Cloud.ServiceDirectory.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedRegistrationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "",
                Service = new Service(),
            };
            // Make the request
            Service response = await registrationServiceClient.CreateServiceAsync(request);
            // End snippet
        }
    }
}
