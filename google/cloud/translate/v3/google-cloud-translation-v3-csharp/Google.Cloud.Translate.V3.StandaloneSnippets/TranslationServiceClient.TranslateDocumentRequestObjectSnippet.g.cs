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
    using Google.Cloud.Translate.V3;

    public sealed partial class GeneratedTranslationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for TranslateDocument</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void TranslateDocumentRequestObject()
        {
            // Create client
            TranslationServiceClient translationServiceClient = TranslationServiceClient.Create();
            // Initialize request argument(s)
            TranslateDocumentRequest request = new TranslateDocumentRequest
            {
                Parent = "",
                SourceLanguageCode = "",
                TargetLanguageCode = "",
                DocumentInputConfig = new DocumentInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
                Model = "",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                Labels = { { "", "" }, },
            };
            // Make the request
            TranslateDocumentResponse response = translationServiceClient.TranslateDocument(request);
        }
    }
}
