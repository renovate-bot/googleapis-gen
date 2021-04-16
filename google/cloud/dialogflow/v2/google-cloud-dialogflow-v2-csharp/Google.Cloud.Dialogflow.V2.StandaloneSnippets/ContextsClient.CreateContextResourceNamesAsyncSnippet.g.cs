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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedContextsClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextResourceNamesAsync()
        {
            // Snippet: CreateContextAsync(SessionName, Context, CallSettings)
            // Additional: CreateContextAsync(SessionName, Context, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            Context context = new Context();
            // Make the request
            Context response = await contextsClient.CreateContextAsync(parent, context);
            // End snippet
        }
    }
}
