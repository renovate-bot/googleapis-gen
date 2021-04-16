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

namespace Google.Home.Graph.V1.Snippets
{
    using System.Collections.Generic;

    public sealed partial class GeneratedHomeGraphApiServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for Query</summary>
        public void Query()
        {
            // Snippet: Query(string, string, IEnumerable<QueryRequestInput>, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "";
            IEnumerable<QueryRequestInput> inputs = new QueryRequestInput[]
            {
                new QueryRequestInput(),
            };
            // Make the request
            QueryResponse response = homeGraphApiServiceClient.Query(requestId, agentUserId, inputs);
            // End snippet
        }
    }
}
