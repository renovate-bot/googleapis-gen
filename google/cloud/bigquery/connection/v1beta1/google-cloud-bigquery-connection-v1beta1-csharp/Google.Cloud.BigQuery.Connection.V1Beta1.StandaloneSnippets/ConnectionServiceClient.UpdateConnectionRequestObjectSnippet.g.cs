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

namespace Google.Cloud.BigQuery.Connection.V1Beta1.Snippets
{
    using Google.Cloud.BigQuery.Connection.V1Beta1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedConnectionServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateConnection</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateConnectionRequestObject()
        {
            // Create client
            ConnectionServiceClient connectionServiceClient = ConnectionServiceClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Connection response = connectionServiceClient.UpdateConnection(request);
        }
    }
}
