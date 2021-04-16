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

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBotsClientSnippets
    {
        /// <summary>Snippet for CreateBotSession</summary>
        public void CreateBotSessionRequestObject()
        {
            // Snippet: CreateBotSession(CreateBotSessionRequest, CallSettings)
            // Create client
            BotsClient botsClient = BotsClient.Create();
            // Initialize request argument(s)
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "",
                BotSession = new BotSession(),
            };
            // Make the request
            BotSession response = botsClient.CreateBotSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBotSessionAsync</summary>
        public async Task CreateBotSessionRequestObjectAsync()
        {
            // Snippet: CreateBotSessionAsync(CreateBotSessionRequest, CallSettings)
            // Additional: CreateBotSessionAsync(CreateBotSessionRequest, CancellationToken)
            // Create client
            BotsClient botsClient = await BotsClient.CreateAsync();
            // Initialize request argument(s)
            CreateBotSessionRequest request = new CreateBotSessionRequest
            {
                Parent = "",
                BotSession = new BotSession(),
            };
            // Make the request
            BotSession response = await botsClient.CreateBotSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBotSession</summary>
        public void CreateBotSession()
        {
            // Snippet: CreateBotSession(string, BotSession, CallSettings)
            // Create client
            BotsClient botsClient = BotsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            BotSession botSession = new BotSession();
            // Make the request
            BotSession response = botsClient.CreateBotSession(parent, botSession);
            // End snippet
        }

        /// <summary>Snippet for CreateBotSessionAsync</summary>
        public async Task CreateBotSessionAsync()
        {
            // Snippet: CreateBotSessionAsync(string, BotSession, CallSettings)
            // Additional: CreateBotSessionAsync(string, BotSession, CancellationToken)
            // Create client
            BotsClient botsClient = await BotsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            BotSession botSession = new BotSession();
            // Make the request
            BotSession response = await botsClient.CreateBotSessionAsync(parent, botSession);
            // End snippet
        }

        /// <summary>Snippet for UpdateBotSession</summary>
        public void UpdateBotSessionRequestObject()
        {
            // Snippet: UpdateBotSession(UpdateBotSessionRequest, CallSettings)
            // Create client
            BotsClient botsClient = BotsClient.Create();
            // Initialize request argument(s)
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BotSession response = botsClient.UpdateBotSession(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBotSessionAsync</summary>
        public async Task UpdateBotSessionRequestObjectAsync()
        {
            // Snippet: UpdateBotSessionAsync(UpdateBotSessionRequest, CallSettings)
            // Additional: UpdateBotSessionAsync(UpdateBotSessionRequest, CancellationToken)
            // Create client
            BotsClient botsClient = await BotsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBotSessionRequest request = new UpdateBotSessionRequest
            {
                BotSessionName = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]"),
                BotSession = new BotSession(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BotSession response = await botsClient.UpdateBotSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBotSession</summary>
        public void UpdateBotSession()
        {
            // Snippet: UpdateBotSession(string, BotSession, FieldMask, CallSettings)
            // Create client
            BotsClient botsClient = BotsClient.Create();
            // Initialize request argument(s)
            string name = "[UNKNOWN_PATH]/botSessions/[BOT_SESSION]";
            BotSession botSession = new BotSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BotSession response = botsClient.UpdateBotSession(name, botSession, updateMask);
            // End snippet
        }

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

        /// <summary>Snippet for UpdateBotSession</summary>
        public void UpdateBotSessionResourceNames()
        {
            // Snippet: UpdateBotSession(BotSessionName, BotSession, FieldMask, CallSettings)
            // Create client
            BotsClient botsClient = BotsClient.Create();
            // Initialize request argument(s)
            BotSessionName name = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]");
            BotSession botSession = new BotSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BotSession response = botsClient.UpdateBotSession(name, botSession, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBotSessionAsync</summary>
        public async Task UpdateBotSessionResourceNamesAsync()
        {
            // Snippet: UpdateBotSessionAsync(BotSessionName, BotSession, FieldMask, CallSettings)
            // Additional: UpdateBotSessionAsync(BotSessionName, BotSession, FieldMask, CancellationToken)
            // Create client
            BotsClient botsClient = await BotsClient.CreateAsync();
            // Initialize request argument(s)
            BotSessionName name = BotSessionName.FromUnknownPathBotSession("[UNKNOWN_PATH]", "[BOT_SESSION]");
            BotSession botSession = new BotSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BotSession response = await botsClient.UpdateBotSessionAsync(name, botSession, updateMask);
            // End snippet
        }
    }
}
