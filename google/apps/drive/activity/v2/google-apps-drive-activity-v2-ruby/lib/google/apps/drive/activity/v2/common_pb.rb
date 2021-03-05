# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/common.proto

require 'google/protobuf'

require 'google/protobuf/timestamp_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/apps/drive/activity/v2/common.proto", :syntax => :proto3) do
    add_message "google.apps.drive.activity.v2.TimeRange" do
      optional :start_time, :message, 1, "google.protobuf.Timestamp"
      optional :end_time, :message, 2, "google.protobuf.Timestamp"
    end
    add_message "google.apps.drive.activity.v2.Group" do
      optional :email, :string, 1
      optional :title, :string, 2
    end
    add_message "google.apps.drive.activity.v2.Domain" do
      optional :name, :string, 1
      optional :legacy_id, :string, 3
    end
  end
end

module Google
  module Apps
    module Drive
      module Activity
        module V2
          TimeRange = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.apps.drive.activity.v2.TimeRange").msgclass
          Group = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.apps.drive.activity.v2.Group").msgclass
          Domain = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.apps.drive.activity.v2.Domain").msgclass
        end
      end
    end
  end
end
