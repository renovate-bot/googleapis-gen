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

namespace Google.Cloud.CloudBuild.V1.Snippets
{
    using Google.Api;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudBuildClientStandaloneSnippets
    {
        /// <summary>Snippet for ReceiveTriggerWebhookAsync</summary>
        public async Task ReceiveTriggerWebhookRequestObjectAsync()
        {
            // Snippet: ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest, CallSettings)
            // Additional: ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            ReceiveTriggerWebhookRequest request = new ReceiveTriggerWebhookRequest
            {
                Body = new HttpBody(),
                ProjectId = "",
                Trigger = "",
                Secret = "",
            };
            // Make the request
            ReceiveTriggerWebhookResponse response = await cloudBuildClient.ReceiveTriggerWebhookAsync(request);
            // End snippet
        }
    }
}
