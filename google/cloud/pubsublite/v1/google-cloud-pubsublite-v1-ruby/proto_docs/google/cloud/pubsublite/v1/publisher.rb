# frozen_string_literal: true

# Copyright 2022 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Cloud
    module PubSubLite
      module V1
        # The first request that must be sent on a newly-opened stream.
        # @!attribute [rw] topic
        #   @return [::String]
        #     The topic to which messages will be written.
        # @!attribute [rw] partition
        #   @return [::Integer]
        #     The partition within the topic to which messages will be written.
        #     Partitions are zero indexed, so `partition` must be in the range [0,
        #     topic.num_partitions).
        class InitialPublishRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to an InitialPublishRequest.
        class InitialPublishResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to publish messages to the topic.
        # @!attribute [rw] messages
        #   @return [::Array<::Google::Cloud::PubSubLite::V1::PubSubMessage>]
        #     The messages to publish.
        class MessagePublishRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to a MessagePublishRequest.
        # @!attribute [rw] start_cursor
        #   @return [::Google::Cloud::PubSubLite::V1::Cursor]
        #     The cursor of the first published message in the batch. The cursors for any
        #     remaining messages in the batch are guaranteed to be sequential.
        class MessagePublishResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request sent from the client to the server on a stream.
        # @!attribute [rw] initial_request
        #   @return [::Google::Cloud::PubSubLite::V1::InitialPublishRequest]
        #     Initial request on the stream.
        # @!attribute [rw] message_publish_request
        #   @return [::Google::Cloud::PubSubLite::V1::MessagePublishRequest]
        #     Request to publish messages.
        class PublishRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to a PublishRequest.
        # @!attribute [rw] initial_response
        #   @return [::Google::Cloud::PubSubLite::V1::InitialPublishResponse]
        #     Initial response on the stream.
        # @!attribute [rw] message_response
        #   @return [::Google::Cloud::PubSubLite::V1::MessagePublishResponse]
        #     Response to publishing messages.
        class PublishResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
