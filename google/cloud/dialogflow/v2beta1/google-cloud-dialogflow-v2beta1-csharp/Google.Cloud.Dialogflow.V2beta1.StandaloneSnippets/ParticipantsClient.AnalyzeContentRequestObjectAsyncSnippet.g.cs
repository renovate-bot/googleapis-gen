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

namespace Google.Cloud.Dialogflow.V2beta1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedParticipantsClientStandaloneSnippets
    {
        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContentRequestObjectAsync()
        {
            // Snippet: AnalyzeContentAsync(AnalyzeContentRequest, CallSettings)
            // Additional: AnalyzeContentAsync(AnalyzeContentRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                ReplyAudioConfig = new OutputAudioConfig(),
                TextInput = new TextInput(),
                EventInput = new EventInput(),
                QueryParams = new QueryParameters(),
                MessageSendTime = new Timestamp(),
                RequestId = "",
            };
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(request);
            // End snippet
        }
    }
}
