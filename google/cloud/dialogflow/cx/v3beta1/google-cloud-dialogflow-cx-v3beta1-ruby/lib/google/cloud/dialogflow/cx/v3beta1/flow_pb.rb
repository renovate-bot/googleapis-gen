# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/flow.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/dialogflow/cx/v3beta1/advanced_settings_pb'
require 'google/cloud/dialogflow/cx/v3beta1/page_pb'
require 'google/cloud/dialogflow/cx/v3beta1/validation_message_pb'
require 'google/longrunning/operations_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/dialogflow/cx/v3beta1/flow.proto", :syntax => :proto3) do
    add_message "google.cloud.dialogflow.cx.v3beta1.NluSettings" do
      optional :model_type, :enum, 1, "google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelType"
      optional :classification_threshold, :float, 3
      optional :model_training_mode, :enum, 4, "google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelTrainingMode"
    end
    add_enum "google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelType" do
      value :MODEL_TYPE_UNSPECIFIED, 0
      value :MODEL_TYPE_STANDARD, 1
      value :MODEL_TYPE_ADVANCED, 3
    end
    add_enum "google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelTrainingMode" do
      value :MODEL_TRAINING_MODE_UNSPECIFIED, 0
      value :MODEL_TRAINING_MODE_AUTOMATIC, 1
      value :MODEL_TRAINING_MODE_MANUAL, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.Flow" do
      optional :name, :string, 1
      optional :display_name, :string, 2
      optional :description, :string, 3
      repeated :transition_routes, :message, 4, "google.cloud.dialogflow.cx.v3beta1.TransitionRoute"
      repeated :event_handlers, :message, 10, "google.cloud.dialogflow.cx.v3beta1.EventHandler"
      repeated :transition_route_groups, :string, 15
      optional :nlu_settings, :message, 11, "google.cloud.dialogflow.cx.v3beta1.NluSettings"
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.CreateFlowRequest" do
      optional :parent, :string, 1
      optional :flow, :message, 2, "google.cloud.dialogflow.cx.v3beta1.Flow"
      optional :language_code, :string, 3
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.DeleteFlowRequest" do
      optional :name, :string, 1
      optional :force, :bool, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ListFlowsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :language_code, :string, 4
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ListFlowsResponse" do
      repeated :flows, :message, 1, "google.cloud.dialogflow.cx.v3beta1.Flow"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.GetFlowRequest" do
      optional :name, :string, 1
      optional :language_code, :string, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.UpdateFlowRequest" do
      optional :flow, :message, 1, "google.cloud.dialogflow.cx.v3beta1.Flow"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
      optional :language_code, :string, 3
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.TrainFlowRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ValidateFlowRequest" do
      optional :name, :string, 1
      optional :language_code, :string, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.GetFlowValidationResultRequest" do
      optional :name, :string, 1
      optional :language_code, :string, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.FlowValidationResult" do
      optional :name, :string, 1
      repeated :validation_messages, :message, 2, "google.cloud.dialogflow.cx.v3beta1.ValidationMessage"
      optional :update_time, :message, 3, "google.protobuf.Timestamp"
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ImportFlowRequest" do
      optional :parent, :string, 1
      optional :import_option, :enum, 4, "google.cloud.dialogflow.cx.v3beta1.ImportFlowRequest.ImportOption"
      oneof :flow do
        optional :flow_uri, :string, 2
        optional :flow_content, :bytes, 3
      end
    end
    add_enum "google.cloud.dialogflow.cx.v3beta1.ImportFlowRequest.ImportOption" do
      value :IMPORT_OPTION_UNSPECIFIED, 0
      value :KEEP, 1
      value :FALLBACK, 2
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ImportFlowResponse" do
      optional :flow, :string, 1
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ExportFlowRequest" do
      optional :name, :string, 1
      optional :flow_uri, :string, 2
      optional :include_referenced_flows, :bool, 4
    end
    add_message "google.cloud.dialogflow.cx.v3beta1.ExportFlowResponse" do
      oneof :flow do
        optional :flow_uri, :string, 1
        optional :flow_content, :bytes, 2
      end
    end
  end
end

module Google
  module Cloud
    module Dialogflow
      module CX
        module V3beta1
          NluSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.NluSettings").msgclass
          NluSettings::ModelType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelType").enummodule
          NluSettings::ModelTrainingMode = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.NluSettings.ModelTrainingMode").enummodule
          Flow = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.Flow").msgclass
          CreateFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.CreateFlowRequest").msgclass
          DeleteFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.DeleteFlowRequest").msgclass
          ListFlowsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ListFlowsRequest").msgclass
          ListFlowsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ListFlowsResponse").msgclass
          GetFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.GetFlowRequest").msgclass
          UpdateFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.UpdateFlowRequest").msgclass
          TrainFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.TrainFlowRequest").msgclass
          ValidateFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ValidateFlowRequest").msgclass
          GetFlowValidationResultRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.GetFlowValidationResultRequest").msgclass
          FlowValidationResult = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.FlowValidationResult").msgclass
          ImportFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ImportFlowRequest").msgclass
          ImportFlowRequest::ImportOption = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ImportFlowRequest.ImportOption").enummodule
          ImportFlowResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ImportFlowResponse").msgclass
          ExportFlowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ExportFlowRequest").msgclass
          ExportFlowResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.cx.v3beta1.ExportFlowResponse").msgclass
        end
      end
    end
  end
end
