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

namespace Google.Cloud.SecretManager.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecretManagerServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateSecretAsync</summary>
        public async Task CreateSecretResourceNamesAsync()
        {
            // Snippet: CreateSecretAsync(ProjectName, string, Secret, CallSettings)
            // Additional: CreateSecretAsync(ProjectName, string, Secret, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string secretId = "";
            Secret secret = new Secret();
            // Make the request
            Secret response = await secretManagerServiceClient.CreateSecretAsync(parent, secretId, secret);
            // End snippet
        }
    }
}
