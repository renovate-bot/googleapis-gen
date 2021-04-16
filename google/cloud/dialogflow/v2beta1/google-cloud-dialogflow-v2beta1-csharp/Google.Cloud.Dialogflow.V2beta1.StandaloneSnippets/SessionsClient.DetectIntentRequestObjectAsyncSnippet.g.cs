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
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSessionsClientStandaloneSnippets
    {
        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentRequestObjectAsync()
        {
            // Snippet: DetectIntentAsync(DetectIntentRequest, CallSettings)
            // Additional: DetectIntentAsync(DetectIntentRequest, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
                InputAudio = ByteString.Empty,
                OutputAudioConfigMask = new FieldMask(),
            };
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(request);
            // End snippet
        }
    }
}
