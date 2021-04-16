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

namespace Google.Iam.Admin.V1.Snippets
{
    using System.Collections.Generic;

    public sealed partial class GeneratedIAMClientStandaloneSnippets
    {
        /// <summary>Snippet for ListServiceAccountKeys</summary>
        public void ListServiceAccountKeysResourceNames()
        {
            // Snippet: ListServiceAccountKeys(ServiceAccountName, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes = new ListServiceAccountKeysRequest.Types.KeyType[]
            {
                ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
            };
            // Make the request
            ListServiceAccountKeysResponse response = iAMClient.ListServiceAccountKeys(name, keyTypes);
            // End snippet
        }
    }
}
