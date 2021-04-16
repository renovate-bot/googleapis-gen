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

namespace Google.Cloud.Iam.Credentials.V1.Snippets
{
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIAMCredentialsClientStandaloneSnippets
    {
        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobResourceNamesAsync()
        {
            // Snippet: SignBlobAsync(ServiceAccountName, IEnumerable<string>, ByteString, CallSettings)
            // Additional: SignBlobAsync(ServiceAccountName, IEnumerable<string>, ByteString, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            ByteString payload = ByteString.Empty;
            // Make the request
            SignBlobResponse response = await iAMCredentialsClient.SignBlobAsync(name, delegates, payload);
            // End snippet
        }
    }
}
