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
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedKnowledgeBasesClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateKnowledgeBase</summary>
        public void CreateKnowledgeBaseRequestObject()
        {
            // Snippet: CreateKnowledgeBase(CreateKnowledgeBaseRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.CreateKnowledgeBase(request);
            // End snippet
        }
    }
}
