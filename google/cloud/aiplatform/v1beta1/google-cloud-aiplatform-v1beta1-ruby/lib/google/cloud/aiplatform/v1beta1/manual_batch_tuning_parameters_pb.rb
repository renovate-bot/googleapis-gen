# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/manual_batch_tuning_parameters.proto

require 'google/protobuf'

require 'google/api/field_behavior_pb'
require 'google/api/annotations_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/aiplatform/v1beta1/manual_batch_tuning_parameters.proto", :syntax => :proto3) do
    add_message "google.cloud.aiplatform.v1beta1.ManualBatchTuningParameters" do
      optional :batch_size, :int32, 1
    end
  end
end

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        ManualBatchTuningParameters = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.aiplatform.v1beta1.ManualBatchTuningParameters").msgclass
      end
    end
  end
end
