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

namespace Google.DevTools.RemoteWorkers.V1Test2.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBotsClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateBotSessionAsync</summary>
        public async Task UpdateBotSessionAsync()
        {
            // Snippet: UpdateBotSessionAsync(string, BotSession, FieldMask, CallSettings)
            // Additional: UpdateBotSessionAsync(string, BotSession, FieldMask, CancellationToken)
            // Create client
            BotsClient botsClient = await BotsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "[UNKNOWN_PATH]/botSessions/[BOT_SESSION]";
            BotSession botSession = new BotSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BotSession response = await botsClient.UpdateBotSessionAsync(name, botSession, updateMask);
            // End snippet
        }
    }
}
