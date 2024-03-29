# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/pubsublite/v1/topic_stats.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/pubsublite/v1/common_pb'
require 'google/protobuf/timestamp_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/pubsublite/v1/topic_stats.proto", :syntax => :proto3) do
    add_message "google.cloud.pubsublite.v1.ComputeMessageStatsRequest" do
      optional :topic, :string, 1
      optional :partition, :int64, 2
      optional :start_cursor, :message, 3, "google.cloud.pubsublite.v1.Cursor"
      optional :end_cursor, :message, 4, "google.cloud.pubsublite.v1.Cursor"
    end
    add_message "google.cloud.pubsublite.v1.ComputeMessageStatsResponse" do
      optional :message_count, :int64, 1
      optional :message_bytes, :int64, 2
      optional :minimum_publish_time, :message, 3, "google.protobuf.Timestamp"
      optional :minimum_event_time, :message, 4, "google.protobuf.Timestamp"
    end
    add_message "google.cloud.pubsublite.v1.ComputeHeadCursorRequest" do
      optional :topic, :string, 1
      optional :partition, :int64, 2
    end
    add_message "google.cloud.pubsublite.v1.ComputeHeadCursorResponse" do
      optional :head_cursor, :message, 1, "google.cloud.pubsublite.v1.Cursor"
    end
    add_message "google.cloud.pubsublite.v1.ComputeTimeCursorRequest" do
      optional :topic, :string, 1
      optional :partition, :int64, 2
      optional :target, :message, 3, "google.cloud.pubsublite.v1.TimeTarget"
    end
    add_message "google.cloud.pubsublite.v1.ComputeTimeCursorResponse" do
      optional :cursor, :message, 1, "google.cloud.pubsublite.v1.Cursor"
    end
  end
end

module Google
  module Cloud
    module PubSubLite
      module V1
        ComputeMessageStatsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeMessageStatsRequest").msgclass
        ComputeMessageStatsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeMessageStatsResponse").msgclass
        ComputeHeadCursorRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeHeadCursorRequest").msgclass
        ComputeHeadCursorResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeHeadCursorResponse").msgclass
        ComputeTimeCursorRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeTimeCursorRequest").msgclass
        ComputeTimeCursorResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.pubsublite.v1.ComputeTimeCursorResponse").msgclass
      end
    end
  end
end
