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

namespace Google.Devtools.Build.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPublishBuildEventClientStandaloneSnippets
    {
        /// <summary>Snippet for PublishLifecycleEventAsync</summary>
        public async Task PublishLifecycleEventRequestObjectAsync()
        {
            // Snippet: PublishLifecycleEventAsync(PublishLifecycleEventRequest, CallSettings)
            // Additional: PublishLifecycleEventAsync(PublishLifecycleEventRequest, CancellationToken)
            // Create client
            PublishBuildEventClient publishBuildEventClient = await PublishBuildEventClient.CreateAsync();
            // Initialize request argument(s)
            PublishLifecycleEventRequest request = new PublishLifecycleEventRequest
            {
                ServiceLevel = PublishLifecycleEventRequest.Types.ServiceLevel.Noninteractive,
                BuildEvent = new OrderedBuildEvent(),
                StreamTimeout = new Duration(),
                NotificationKeywords = { "", },
                ProjectId = "",
            };
            // Make the request
            await publishBuildEventClient.PublishLifecycleEventAsync(request);
            // End snippet
        }
    }
}
