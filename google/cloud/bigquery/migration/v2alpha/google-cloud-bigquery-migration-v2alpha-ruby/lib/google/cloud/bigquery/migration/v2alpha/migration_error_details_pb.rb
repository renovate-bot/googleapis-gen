# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/migration/v2alpha/migration_error_details.proto

require 'google/protobuf'

require 'google/api/field_behavior_pb'
require 'google/rpc/error_details_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/bigquery/migration/v2alpha/migration_error_details.proto", :syntax => :proto3) do
    add_message "google.cloud.bigquery.migration.v2alpha.ResourceErrorDetail" do
      optional :resource_info, :message, 1, "google.rpc.ResourceInfo"
      repeated :error_details, :message, 2, "google.cloud.bigquery.migration.v2alpha.ErrorDetail"
      optional :error_count, :int32, 3
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ErrorDetail" do
      optional :location, :message, 1, "google.cloud.bigquery.migration.v2alpha.ErrorLocation"
      optional :error_info, :message, 2, "google.rpc.ErrorInfo"
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ErrorLocation" do
      optional :line, :int32, 1
      optional :column, :int32, 2
    end
  end
end

module Google
  module Cloud
    module Bigquery
      module Migration
        module V2alpha
          ResourceErrorDetail = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ResourceErrorDetail").msgclass
          ErrorDetail = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ErrorDetail").msgclass
          ErrorLocation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ErrorLocation").msgclass
        end
      end
    end
  end
end
