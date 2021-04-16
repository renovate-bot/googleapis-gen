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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedParticipantsClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateParticipantAsync</summary>
        public async Task UpdateParticipantRequestObjectAsync()
        {
            // Snippet: UpdateParticipantAsync(UpdateParticipantRequest, CallSettings)
            // Additional: UpdateParticipantAsync(UpdateParticipantRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Participant response = await participantsClient.UpdateParticipantAsync(request);
            // End snippet
        }
    }
}
