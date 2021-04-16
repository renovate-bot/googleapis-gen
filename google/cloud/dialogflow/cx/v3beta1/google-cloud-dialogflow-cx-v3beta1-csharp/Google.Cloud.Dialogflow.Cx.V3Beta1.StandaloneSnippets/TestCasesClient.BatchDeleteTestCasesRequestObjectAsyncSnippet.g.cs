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

namespace Google.Cloud.Dialogflow.Cx.V3Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedTestCasesClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchDeleteTestCasesAsync</summary>
        public async Task BatchDeleteTestCasesRequestObjectAsync()
        {
            // Snippet: BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest, CallSettings)
            // Additional: BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            // Make the request
            await testCasesClient.BatchDeleteTestCasesAsync(request);
            // End snippet
        }
    }
}
