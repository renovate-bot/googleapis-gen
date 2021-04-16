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

namespace Google.Cloud.Debugger.V2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDebugger2ClientStandaloneSnippets
    {
        /// <summary>Snippet for ListBreakpointsAsync</summary>
        public async Task ListBreakpointsRequestObjectAsync()
        {
            // Snippet: ListBreakpointsAsync(ListBreakpointsRequest, CallSettings)
            // Additional: ListBreakpointsAsync(ListBreakpointsRequest, CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "",
                IncludeAllUsers = false,
                IncludeInactive = false,
                Action = new ListBreakpointsRequest.Types.BreakpointActionValue(),
                WaitToken = "",
                ClientVersion = "",
            };
            // Make the request
            ListBreakpointsResponse response = await debugger2Client.ListBreakpointsAsync(request);
            // End snippet
        }
    }
}
