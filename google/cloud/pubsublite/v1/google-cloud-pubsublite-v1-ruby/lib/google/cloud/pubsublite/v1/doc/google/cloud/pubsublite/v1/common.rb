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
        # The values associated with a key of an attribute.
        # @!attribute [rw] values
        #   @return [Array<String>]
        #     The list of values associated with a key.
        class AttributeValues; end

        # A message that is published by publishers and delivered to subscribers.
        # @!attribute [rw] key
        #   @return [String]
        #     The key used for routing messages to partitions or for compaction (e.g.,
        #     keep the last N messages per key). If the key is empty, the message is
        #     routed to an arbitrary partition.
        # @!attribute [rw] data
        #   @return [String]
        #     The payload of the message.
        # @!attribute [rw] attributes
        #   @return [Hash{String => Google::Cloud::Pubsublite::V1::AttributeValues}]
        #     Optional attributes that can be used for message metadata/headers.
        # @!attribute [rw] event_time
        #   @return [Google::Protobuf::Timestamp]
        #     An optional, user-specified event time.
        class PubSubMessage; end

        # A cursor that describes the position of a message within a topic partition.
        # @!attribute [rw] offset
        #   @return [Integer]
        #     The offset of a message within a topic partition. Must be greater than or
        #     equal 0.
        class Cursor; end

        # A message that has been stored and sequenced by the Pub/Sub Lite system.
        # @!attribute [rw] cursor
        #   @return [Google::Cloud::Pubsublite::V1::Cursor]
        #     The position of a message within the partition where it is stored.
        # @!attribute [rw] publish_time
        #   @return [Google::Protobuf::Timestamp]
        #     The time when the message was received by the server when it was first
        #     published.
        # @!attribute [rw] message
        #   @return [Google::Cloud::Pubsublite::V1::PubSubMessage]
        #     The user message.
        # @!attribute [rw] size_bytes
        #   @return [Integer]
        #     The size in bytes of this message for flow control and quota purposes.
        class SequencedMessage; end

        # Metadata about a topic resource.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the topic.
        #     Structured like:
        #     projects/{project_number}/locations/{location}/topics/{topic_id}
        # @!attribute [rw] partition_config
        #   @return [Google::Cloud::Pubsublite::V1::Topic::PartitionConfig]
        #     The settings for this topic's partitions.
        # @!attribute [rw] retention_config
        #   @return [Google::Cloud::Pubsublite::V1::Topic::RetentionConfig]
        #     The settings for this topic's message retention.
        class Topic
          # The settings for a topic's partitions.
          # @!attribute [rw] count
          #   @return [Integer]
          #     The number of partitions in the topic. Must be at least 1.
          # @!attribute [rw] scale
          #   @return [Integer]
          #     DEPRECATED: Use capacity instead which can express a superset of
          #     configurations.
          #
          #     Every partition in the topic is allocated throughput equivalent to
          #     `scale` times the standard partition throughput (4 MiB/s). This is also
          #     reflected in the cost of this topic; a topic with `scale` of 2 and
          #     count of 10 is charged for 20 partitions. This value must be in the
          #     range [1,4].
          # @!attribute [rw] capacity
          #   @return [Google::Cloud::Pubsublite::V1::Topic::PartitionConfig::Capacity]
          #     The capacity configuration.
          class PartitionConfig
            # The throughput capacity configuration for each partition.
            # @!attribute [rw] publish_mib_per_sec
            #   @return [Integer]
            #     Publish throughput capacity per partition in MiB/s.
            #     Must be >= 4 and <= 16.
            # @!attribute [rw] subscribe_mib_per_sec
            #   @return [Integer]
            #     Subscribe throughput capacity per partition in MiB/s.
            #     Must be >= 4 and <= 32.
            class Capacity; end
          end

          # The settings for a topic's message retention.
          # @!attribute [rw] per_partition_bytes
          #   @return [Integer]
          #     The provisioned storage, in bytes, per partition. If the number of bytes
          #     stored in any of the topic's partitions grows beyond this value, older
          #     messages will be dropped to make room for newer ones, regardless of the
          #     value of `period`.
          # @!attribute [rw] period
          #   @return [Google::Protobuf::Duration]
          #     How long a published message is retained. If unset, messages will be
          #     retained as long as the bytes retained for each partition is below
          #     `per_partition_bytes`.
          class RetentionConfig; end
        end

        # Metadata about a subscription resource.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the subscription.
        #     Structured like:
        #     projects/{project_number}/locations/{location}/subscriptions/{subscription_id}
        # @!attribute [rw] topic
        #   @return [String]
        #     The name of the topic this subscription is attached to.
        #     Structured like:
        #     projects/{project_number}/locations/{location}/topics/{topic_id}
        # @!attribute [rw] delivery_config
        #   @return [Google::Cloud::Pubsublite::V1::Subscription::DeliveryConfig]
        #     The settings for this subscription's message delivery.
        class Subscription
          # The settings for a subscription's message delivery.
          # @!attribute [rw] delivery_requirement
          #   @return [Google::Cloud::Pubsublite::V1::Subscription::DeliveryConfig::DeliveryRequirement]
          #     The DeliveryRequirement for this subscription.
          class DeliveryConfig
            # When this subscription should send messages to subscribers relative to
            # messages persistence in storage. For details, see [Creating Lite
            # subscriptions](https://cloud.google.com/pubsub/lite/docs/subscriptions#creating_lite_subscriptions).
            module DeliveryRequirement
              # Default value. This value is unused.
              DELIVERY_REQUIREMENT_UNSPECIFIED = 0

              # The server does not wait for a published message to be successfully
              # written to storage before delivering it to subscribers.
              DELIVER_IMMEDIATELY = 1

              # The server will not deliver a published message to subscribers until
              # the message has been successfully written to storage. This will result
              # in higher end-to-end latency, but consistent delivery.
              DELIVER_AFTER_STORED = 2
            end
          end
        end
      end
    end
  end
end