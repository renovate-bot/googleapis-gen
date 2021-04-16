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

namespace Google.Cloud.Gaming.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerConfigsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetGameServerConfigAsync</summary>
        public async Task GetGameServerConfigResourceNamesAsync()
        {
            // Snippet: GetGameServerConfigAsync(GameServerConfigName, CallSettings)
            // Additional: GetGameServerConfigAsync(GameServerConfigName, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerConfigName name = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]");
            // Make the request
            GameServerConfig response = await gameServerConfigsServiceClient.GetGameServerConfigAsync(name);
            // End snippet
        }
    }
}
