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

namespace Google.Cloud.SecretManager.V1Beta1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecretManagerServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateSecretAsync</summary>
        public async Task UpdateSecretAsync()
        {
            // Snippet: UpdateSecretAsync(Secret, FieldMask, CallSettings)
            // Additional: UpdateSecretAsync(Secret, FieldMask, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            Secret secret = new Secret();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Secret response = await secretManagerServiceClient.UpdateSecretAsync(secret, updateMask);
            // End snippet
        }
    }
}
