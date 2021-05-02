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

namespace Google.Partner.Aistreams.V1Alpha1.Snippets
{
    using Google.Partner.Aistreams.V1Alpha1;

    public sealed partial class GeneratedAIStreamsClientStandaloneSnippets
    {
        /// <summary>Snippet for GetStream</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetStreamRequestObject()
        {
            // Create client
            AIStreamsClient aIStreamsClient = AIStreamsClient.Create();
            // Initialize request argument(s)
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            // Make the request
            Stream response = aIStreamsClient.GetStream(request);
        }
    }
}
