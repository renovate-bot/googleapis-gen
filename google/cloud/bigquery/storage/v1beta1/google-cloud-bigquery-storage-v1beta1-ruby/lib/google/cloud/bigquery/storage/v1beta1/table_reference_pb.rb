# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1beta1/table_reference.proto

require 'google/api/resource_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/bigquery/storage/v1beta1/table_reference.proto", :syntax => :proto3) do
    add_message "google.cloud.bigquery.storage.v1beta1.TableReference" do
      optional :project_id, :string, 1
      optional :dataset_id, :string, 2
      optional :table_id, :string, 3
    end
    add_message "google.cloud.bigquery.storage.v1beta1.TableModifiers" do
      optional :snapshot_time, :message, 1, "google.protobuf.Timestamp"
    end
  end
end

module Google
  module Cloud
    module Bigquery
      module Storage
        module V1beta1
          TableReference = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.storage.v1beta1.TableReference").msgclass
          TableModifiers = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.storage.v1beta1.TableModifiers").msgclass
        end
      end
    end
  end
end
