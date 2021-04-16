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
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecretManagerServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for DestroySecretVersionAsync</summary>
        public async Task DestroySecretVersionAsync()
        {
            // Snippet: DestroySecretVersionAsync(string, CallSettings)
            // Additional: DestroySecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DestroySecretVersionAsync(name);
            // End snippet
        }
    }
}
