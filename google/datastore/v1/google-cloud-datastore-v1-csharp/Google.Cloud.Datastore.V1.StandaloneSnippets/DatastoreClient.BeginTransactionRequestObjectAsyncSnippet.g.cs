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

namespace Google.Cloud.Datastore.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatastoreClientStandaloneSnippets
    {
        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionRequestObjectAsync()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest, CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "",
                TransactionOptions = new TransactionOptions(),
            };
            // Make the request
            BeginTransactionResponse response = await datastoreClient.BeginTransactionAsync(request);
            // End snippet
        }
    }
}
