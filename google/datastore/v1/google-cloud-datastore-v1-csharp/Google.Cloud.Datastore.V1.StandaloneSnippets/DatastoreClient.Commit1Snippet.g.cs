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
    using Google.Protobuf;
    using System.Collections.Generic;

    public sealed partial class GeneratedDatastoreClientStandaloneSnippets
    {
        /// <summary>Snippet for Commit</summary>
        public void Commit1()
        {
            // Snippet: Commit(string, CommitRequest.Types.Mode, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = datastoreClient.Commit(projectId, mode, transaction, mutations);
            // End snippet
        }
    }
}
