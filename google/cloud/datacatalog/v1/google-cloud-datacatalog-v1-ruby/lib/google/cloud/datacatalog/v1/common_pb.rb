# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1/common.proto

require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/datacatalog/v1/common.proto", :syntax => :proto3) do
    add_enum "google.cloud.datacatalog.v1.IntegratedSystem" do
      value :INTEGRATED_SYSTEM_UNSPECIFIED, 0
      value :BIGQUERY, 1
      value :CLOUD_PUBSUB, 2
      value :DATAPROC_METASTORE, 3
    end
  end
end

module Google
  module Cloud
    module DataCatalog
      module V1
        IntegratedSystem = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.datacatalog.v1.IntegratedSystem").enummodule
      end
    end
  end
end
