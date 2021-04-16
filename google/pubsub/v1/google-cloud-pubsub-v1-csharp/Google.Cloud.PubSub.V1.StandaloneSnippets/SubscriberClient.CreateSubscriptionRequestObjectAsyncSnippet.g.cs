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

namespace Google.Cloud.PubSub.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSubscriberClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSubscriptionAsync(Subscription, CallSettings)
            // Additional: CreateSubscriptionAsync(Subscription, CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 0,
                RetainAckedMessages = false,
                MessageRetentionDuration = new Duration(),
                Labels = { { "", "" }, },
                EnableMessageOrdering = false,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
            };
            // Make the request
            Subscription response = await subscriberClient.CreateSubscriptionAsync(request);
            // End snippet
        }
    }
}
