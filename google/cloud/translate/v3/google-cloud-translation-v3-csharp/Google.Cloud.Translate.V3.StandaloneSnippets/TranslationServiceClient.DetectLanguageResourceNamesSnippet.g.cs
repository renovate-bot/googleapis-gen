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

namespace Google.Cloud.Translate.V3.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedTranslationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for DetectLanguage</summary>
        public void DetectLanguageResourceNames()
        {
            // Snippet: DetectLanguage(LocationName, string, string, string, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string model = "";
            string mimeType = "";
            string content = "";
            // Make the request
            DetectLanguageResponse response = translationServiceClient.DetectLanguage(parent, model, mimeType, content);
            // End snippet
        }
    }
}
