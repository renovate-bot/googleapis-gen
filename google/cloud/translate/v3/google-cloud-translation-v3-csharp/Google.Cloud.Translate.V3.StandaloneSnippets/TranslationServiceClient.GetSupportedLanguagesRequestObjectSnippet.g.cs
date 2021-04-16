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
        /// <summary>Snippet for GetSupportedLanguages</summary>
        public void GetSupportedLanguagesRequestObject()
        {
            // Snippet: GetSupportedLanguages(GetSupportedLanguagesRequest, CallSettings)
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "",
                Model = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SupportedLanguages response = translationServiceClient.GetSupportedLanguages(request);
            // End snippet
        }
    }
}
