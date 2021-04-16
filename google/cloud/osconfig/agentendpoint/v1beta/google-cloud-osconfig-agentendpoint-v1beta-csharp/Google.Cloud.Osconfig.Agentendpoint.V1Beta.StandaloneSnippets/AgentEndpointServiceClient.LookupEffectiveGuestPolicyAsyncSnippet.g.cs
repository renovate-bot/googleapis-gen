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

namespace Google.Cloud.Osconfig.Agentendpoint.V1Beta.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedAgentEndpointServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for LookupEffectiveGuestPolicyAsync</summary>
        public async Task LookupEffectiveGuestPolicyAsync()
        {
            // Snippet: LookupEffectiveGuestPolicyAsync(string, string, string, string, CallSettings)
            // Additional: LookupEffectiveGuestPolicyAsync(string, string, string, string, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string osShortName = "";
            string osVersion = "";
            string osArchitecture = "";
            // Make the request
            EffectiveGuestPolicy response = await agentEndpointServiceClient.LookupEffectiveGuestPolicyAsync(instanceIdToken, osShortName, osVersion, osArchitecture);
            // End snippet
        }
    }
}
