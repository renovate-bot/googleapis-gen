# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Cloud
    module Pubsublite
      module V1
        # Request for CreateTopic.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent location in which to create the topic.
        #     Structured like `projects/{project_number}/locations/{location}`.
        # @!attribute [rw] topic
        #   @return [Google::Cloud::Pubsublite::V1::Topic]
        #     Required. Configuration of the topic to create. Its `name` field is ignored.
        # @!attribute [rw] topic_id
        #   @return [String]
        #     Required. The ID to use for the topic, which will become the final component of
        #     the topic's name.
        #
        #     This value is structured like: `my-topic-name`.
        class CreateTopicRequest; end

        # Request for GetTopic.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the topic whose configuration to return.
        class GetTopicRequest; end

        # Request for GetTopicPartitions.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The topic whose partition information to return.
        class GetTopicPartitionsRequest; end

        # Response for GetTopicPartitions.
        # @!attribute [rw] partition_count
        #   @return [Integer]
        #     The number of partitions in the topic.
        class TopicPartitions; end

        # Request for ListTopics.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent whose topics are to be listed.
        #     Structured like `projects/{project_number}/locations/{location}`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of topics to return. The service may return fewer than
        #     this value.
        #     If unset or zero, all topics for the parent will be returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListTopics` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListTopics` must match
        #     the call that provided the page token.
        class ListTopicsRequest; end

        # Response for ListTopics.
        # @!attribute [rw] topics
        #   @return [Array<Google::Cloud::Pubsublite::V1::Topic>]
        #     The list of topic in the requested parent. The order of the topics is
        #     unspecified.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token that can be sent as `page_token` to retrieve the next page of
        #     results. If this field is omitted, there are no more results.
        class ListTopicsResponse; end

        # Request for UpdateTopic.
        # @!attribute [rw] topic
        #   @return [Google::Cloud::Pubsublite::V1::Topic]
        #     Required. The topic to update. Its `name` field must be populated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. A mask specifying the topic fields to change.
        class UpdateTopicRequest; end

        # Request for DeleteTopic.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the topic to delete.
        class DeleteTopicRequest; end

        # Request for ListTopicSubscriptions.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the topic whose subscriptions to list.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of subscriptions to return. The service may return fewer
        #     than this value.
        #     If unset or zero, all subscriptions for the given topic will be returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListTopicSubscriptions` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListTopicSubscriptions`
        #     must match the call that provided the page token.
        class ListTopicSubscriptionsRequest; end

        # Response for ListTopicSubscriptions.
        # @!attribute [rw] subscriptions
        #   @return [Array<String>]
        #     The names of subscriptions attached to the topic. The order of the
        #     subscriptions is unspecified.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token that can be sent as `page_token` to retrieve the next page of
        #     results. If this field is omitted, there are no more results.
        class ListTopicSubscriptionsResponse; end

        # Request for CreateSubscription.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent location in which to create the subscription.
        #     Structured like `projects/{project_number}/locations/{location}`.
        # @!attribute [rw] subscription
        #   @return [Google::Cloud::Pubsublite::V1::Subscription]
        #     Required. Configuration of the subscription to create. Its `name` field is ignored.
        # @!attribute [rw] subscription_id
        #   @return [String]
        #     Required. The ID to use for the subscription, which will become the final component
        #     of the subscription's name.
        #
        #     This value is structured like: `my-sub-name`.
        # @!attribute [rw] skip_backlog
        #   @return [true, false]
        #     If true, the newly created subscription will only receive messages
        #     published after the subscription was created. Otherwise, the entire
        #     message backlog will be received on the subscription. Defaults to false.
        class CreateSubscriptionRequest; end

        # Request for GetSubscription.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the subscription whose configuration to return.
        class GetSubscriptionRequest; end

        # Request for ListSubscriptions.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent whose subscriptions are to be listed.
        #     Structured like `projects/{project_number}/locations/{location}`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of subscriptions to return. The service may return fewer
        #     than this value.
        #     If unset or zero, all subscriptions for the parent will be returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A page token, received from a previous `ListSubscriptions` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListSubscriptions` must
        #     match the call that provided the page token.
        class ListSubscriptionsRequest; end

        # Response for ListSubscriptions.
        # @!attribute [rw] subscriptions
        #   @return [Array<Google::Cloud::Pubsublite::V1::Subscription>]
        #     The list of subscriptions in the requested parent. The order of the
        #     subscriptions is unspecified.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token that can be sent as `page_token` to retrieve the next page of
        #     results. If this field is omitted, there are no more results.
        class ListSubscriptionsResponse; end

        # Request for UpdateSubscription.
        # @!attribute [rw] subscription
        #   @return [Google::Cloud::Pubsublite::V1::Subscription]
        #     Required. The subscription to update. Its `name` field must be populated.
        #     Topic field must not be populated.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. A mask specifying the subscription fields to change.
        class UpdateSubscriptionRequest; end

        # Request for DeleteSubscription.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the subscription to delete.
        class DeleteSubscriptionRequest; end
      end
    end
  end
end