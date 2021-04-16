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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    using Google.Protobuf;
    using System.Collections.Generic;

    public sealed partial class GeneratedBigtableClientStandaloneSnippets
    {
        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2ResourceNames()
        {
            // Snippet: CheckAndMutateRow(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }
    }
}
