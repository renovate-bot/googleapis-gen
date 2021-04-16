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

namespace Google.Cloud.Bigquery.Storage.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigQueryStorageClientStandaloneSnippets
    {
        /// <summary>Snippet for FinalizeStreamAsync</summary>
        public async Task FinalizeStreamRequestObjectAsync()
        {
            // Snippet: FinalizeStreamAsync(FinalizeStreamRequest, CallSettings)
            // Additional: FinalizeStreamAsync(FinalizeStreamRequest, CancellationToken)
            // Create client
            BigQueryStorageClient bigQueryStorageClient = await BigQueryStorageClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeStreamRequest request = new FinalizeStreamRequest
            {
                Stream = new Stream(),
            };
            // Make the request
            await bigQueryStorageClient.FinalizeStreamAsync(request);
            // End snippet
        }
    }
}
