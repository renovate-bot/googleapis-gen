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
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPublishBuildEventClientSnippets
    {
        /// <summary>Snippet for PublishLifecycleEvent</summary>
        public void PublishLifecycleEventRequestObject()
        {
            // Snippet: PublishLifecycleEvent(PublishLifecycleEventRequest, CallSettings)
            // Create client
            PublishBuildEventClient publishBuildEventClient = PublishBuildEventClient.Create();
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
            publishBuildEventClient.PublishLifecycleEvent(request);
            // End snippet
        }

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

        /// <summary>Snippet for PublishBuildToolEventStream</summary>
        public async Task PublishBuildToolEventStream()
        {
            // Snippet: PublishBuildToolEventStream(CallSettings, BidirectionalStreamingSettings)
            // Create client
            PublishBuildEventClient publishBuildEventClient = PublishBuildEventClient.Create();
            // Initialize streaming call, retrieving the stream object
            PublishBuildEventClient.PublishBuildToolEventStreamStream response = publishBuildEventClient.PublishBuildToolEventStream();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<PublishBuildToolEventStreamResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    PublishBuildToolEventStreamResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                PublishBuildToolEventStreamRequest request = new PublishBuildToolEventStreamRequest
                {
                    OrderedBuildEvent = new OrderedBuildEvent(),
                    NotificationKeywords = { "", },
                    ProjectId = "",
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
