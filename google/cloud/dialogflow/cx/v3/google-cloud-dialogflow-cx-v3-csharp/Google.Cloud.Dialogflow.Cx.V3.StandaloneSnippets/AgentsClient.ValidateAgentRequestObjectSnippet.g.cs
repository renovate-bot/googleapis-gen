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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    public sealed partial class GeneratedAgentsClientStandaloneSnippets
    {
        /// <summary>Snippet for ValidateAgent</summary>
        public void ValidateAgentRequestObject()
        {
            // Snippet: ValidateAgent(ValidateAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ValidateAgentRequest request = new ValidateAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            AgentValidationResult response = agentsClient.ValidateAgent(request);
            // End snippet
        }
    }
}
