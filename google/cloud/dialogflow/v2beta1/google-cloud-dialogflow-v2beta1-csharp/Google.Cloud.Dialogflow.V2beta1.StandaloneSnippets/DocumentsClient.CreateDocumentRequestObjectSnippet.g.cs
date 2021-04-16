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
    using Google.LongRunning;

    public sealed partial class GeneratedDocumentsClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentRequestObject()
        {
            // Snippet: CreateDocument(CreateDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Document = new Document(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.CreateDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceCreateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
