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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Api.Gax;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGroupServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupResourceNames2Async()
        {
            // Snippet: DeleteGroupAsync(IResourceName, CallSettings)
            // Additional: DeleteGroupAsync(IResourceName, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await groupServiceClient.DeleteGroupAsync(name);
            // End snippet
        }
    }
}
