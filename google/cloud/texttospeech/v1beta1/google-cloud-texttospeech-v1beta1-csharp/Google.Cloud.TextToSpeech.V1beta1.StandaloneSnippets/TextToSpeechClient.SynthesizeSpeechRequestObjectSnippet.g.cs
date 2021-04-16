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

namespace Google.Cloud.TextToSpeech.V1beta1.Snippets
{
    public sealed partial class GeneratedTextToSpeechClientStandaloneSnippets
    {
        /// <summary>Snippet for SynthesizeSpeech</summary>
        public void SynthesizeSpeechRequestObject()
        {
            // Snippet: SynthesizeSpeech(SynthesizeSpeechRequest, CallSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize request argument(s)
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
                EnableTimePointing =
                {
                    SynthesizeSpeechRequest.Types.TimepointType.Unspecified,
                },
            };
            // Make the request
            SynthesizeSpeechResponse response = textToSpeechClient.SynthesizeSpeech(request);
            // End snippet
        }
    }
}
