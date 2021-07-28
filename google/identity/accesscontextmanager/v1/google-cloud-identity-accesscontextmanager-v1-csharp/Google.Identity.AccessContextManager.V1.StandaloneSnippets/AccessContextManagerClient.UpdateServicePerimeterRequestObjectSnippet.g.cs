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

namespace Google.Identity.AccessContextManager.V1.Snippets
{
    using Google.Identity.AccessContextManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedAccessContextManagerClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateServicePerimeter</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateServicePerimeterRequestObject()
        {
            // Create client
            AccessContextManagerClient accessContextManagerClient = AccessContextManagerClient.Create();
            // Initialize request argument(s)
            UpdateServicePerimeterRequest request = new UpdateServicePerimeterRequest
            {
                ServicePerimeter = new ServicePerimeter(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> response = accessContextManagerClient.UpdateServicePerimeter(request);

            // Poll until the returned long-running operation is complete
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServicePerimeter result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServicePerimeter, AccessContextManagerOperationMetadata> retrievedResponse = accessContextManagerClient.PollOnceUpdateServicePerimeter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServicePerimeter retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
