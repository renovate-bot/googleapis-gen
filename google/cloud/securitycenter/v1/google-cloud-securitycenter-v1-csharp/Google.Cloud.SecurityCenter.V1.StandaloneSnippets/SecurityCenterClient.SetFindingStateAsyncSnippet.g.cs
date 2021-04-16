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

namespace Google.Cloud.SecurityCenter.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecurityCenterClientStandaloneSnippets
    {
        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateAsync()
        {
            // Snippet: SetFindingStateAsync(string, Finding.Types.State, Timestamp, CallSettings)
            // Additional: SetFindingStateAsync(string, Finding.Types.State, Timestamp, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(name, state, startTime);
            // End snippet
        }
    }
}
