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

namespace Google.Iam.Admin.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedIAMClientStandaloneSnippets
    {
        /// <summary>Snippet for DeleteServiceAccountKeyAsync</summary>
        public async Task DeleteServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest, CallSettings)
            // Additional: DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            await iAMClient.DeleteServiceAccountKeyAsync(request);
            // End snippet
        }
    }
}
