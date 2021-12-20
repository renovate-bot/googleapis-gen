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

namespace Google.Cloud.BaremetalSolution.V2.Snippets
{
    using Google.Cloud.BaremetalSolution.V2;

    public sealed partial class GeneratedBareMetalSolutionClientStandaloneSnippets
    {
        /// <summary>Snippet for GetLun</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetLunRequestObject()
        {
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(request);
        }
    }
}
