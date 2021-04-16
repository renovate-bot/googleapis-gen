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

namespace Google.Cloud.Bigquery.Storage.V1Beta2.Snippets
{
    public sealed partial class GeneratedBigQueryReadClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSession()
        {
            // Snippet: CreateReadSession(string, ReadSession, int, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ReadSession readSession = new ReadSession();
            int maxStreamCount = 0;
            // Make the request
            ReadSession response = bigQueryReadClient.CreateReadSession(parent, readSession, maxStreamCount);
            // End snippet
        }
    }
}
