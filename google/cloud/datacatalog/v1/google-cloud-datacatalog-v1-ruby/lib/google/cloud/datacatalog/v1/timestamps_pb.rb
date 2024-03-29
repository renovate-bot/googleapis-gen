# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1/timestamps.proto

require 'google/api/field_behavior_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/datacatalog/v1/timestamps.proto", :syntax => :proto3) do
    add_message "google.cloud.datacatalog.v1.SystemTimestamps" do
      optional :create_time, :message, 1, "google.protobuf.Timestamp"
      optional :update_time, :message, 2, "google.protobuf.Timestamp"
      optional :expire_time, :message, 3, "google.protobuf.Timestamp"
    end
  end
end

module Google
  module Cloud
    module DataCatalog
      module V1
        SystemTimestamps = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.datacatalog.v1.SystemTimestamps").msgclass
      end
    end
  end
end
