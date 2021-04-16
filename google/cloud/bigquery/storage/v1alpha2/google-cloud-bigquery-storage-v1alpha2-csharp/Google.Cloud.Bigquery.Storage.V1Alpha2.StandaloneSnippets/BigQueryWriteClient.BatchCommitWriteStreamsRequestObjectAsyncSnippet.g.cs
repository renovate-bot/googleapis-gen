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

namespace Google.Cloud.Bigquery.Storage.V1Alpha2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigQueryWriteClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchCommitWriteStreamsAsync</summary>
        public async Task BatchCommitWriteStreamsRequestObjectAsync()
        {
            // Snippet: BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest, CallSettings)
            // Additional: BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStreams = { "", },
            };
            // Make the request
            BatchCommitWriteStreamsResponse response = await bigQueryWriteClient.BatchCommitWriteStreamsAsync(request);
            // End snippet
        }
    }
}
