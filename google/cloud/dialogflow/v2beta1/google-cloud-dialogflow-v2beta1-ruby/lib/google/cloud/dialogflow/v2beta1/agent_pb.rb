# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/agent.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/dialogflow/v2beta1/environment_pb'
require 'google/cloud/dialogflow/v2beta1/validation_result_pb'
require 'google/longrunning/operations_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/dialogflow/v2beta1/agent.proto", :syntax => :proto3) do
    add_message "google.cloud.dialogflow.v2beta1.Agent" do
      optional :parent, :string, 1
      optional :display_name, :string, 2
      optional :default_language_code, :string, 3
      repeated :supported_language_codes, :string, 4
      optional :time_zone, :string, 5
      optional :description, :string, 6
      optional :avatar_uri, :string, 7
      optional :enable_logging, :bool, 8
      optional :match_mode, :enum, 9, "google.cloud.dialogflow.v2beta1.Agent.MatchMode"
      optional :classification_threshold, :float, 10
      optional :api_version, :enum, 14, "google.cloud.dialogflow.v2beta1.Agent.ApiVersion"
      optional :tier, :enum, 15, "google.cloud.dialogflow.v2beta1.Agent.Tier"
    end
    add_enum "google.cloud.dialogflow.v2beta1.Agent.MatchMode" do
      value :MATCH_MODE_UNSPECIFIED, 0
      value :MATCH_MODE_HYBRID, 1
      value :MATCH_MODE_ML_ONLY, 2
    end
    add_enum "google.cloud.dialogflow.v2beta1.Agent.ApiVersion" do
      value :API_VERSION_UNSPECIFIED, 0
      value :API_VERSION_V1, 1
      value :API_VERSION_V2, 2
      value :API_VERSION_V2_BETA_1, 3
    end
    add_enum "google.cloud.dialogflow.v2beta1.Agent.Tier" do
      value :TIER_UNSPECIFIED, 0
      value :TIER_STANDARD, 1
      value :TIER_ENTERPRISE, 2
      value :TIER_ENTERPRISE_PLUS, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.GetAgentRequest" do
      optional :parent, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.SetAgentRequest" do
      optional :agent, :message, 1, "google.cloud.dialogflow.v2beta1.Agent"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.dialogflow.v2beta1.DeleteAgentRequest" do
      optional :parent, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.SubAgent" do
      optional :project, :string, 1
      optional :environment, :string, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.SearchAgentsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.SearchAgentsResponse" do
      repeated :agents, :message, 1, "google.cloud.dialogflow.v2beta1.Agent"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.TrainAgentRequest" do
      optional :parent, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.ExportAgentRequest" do
      optional :parent, :string, 1
      optional :agent_uri, :string, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.ExportAgentResponse" do
      oneof :agent do
        optional :agent_uri, :string, 1
        optional :agent_content, :bytes, 2
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.ImportAgentRequest" do
      optional :parent, :string, 1
      oneof :agent do
        optional :agent_uri, :string, 2
        optional :agent_content, :bytes, 3
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.RestoreAgentRequest" do
      optional :parent, :string, 1
      oneof :agent do
        optional :agent_uri, :string, 2
        optional :agent_content, :bytes, 3
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.GetValidationResultRequest" do
      optional :parent, :string, 1
      optional :language_code, :string, 3
    end
  end
end

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        Agent = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Agent").msgclass
        Agent::MatchMode = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Agent.MatchMode").enummodule
        Agent::ApiVersion = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Agent.ApiVersion").enummodule
        Agent::Tier = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Agent.Tier").enummodule
        GetAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.GetAgentRequest").msgclass
        SetAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SetAgentRequest").msgclass
        DeleteAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.DeleteAgentRequest").msgclass
        SubAgent = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SubAgent").msgclass
        SearchAgentsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SearchAgentsRequest").msgclass
        SearchAgentsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SearchAgentsResponse").msgclass
        TrainAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.TrainAgentRequest").msgclass
        ExportAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ExportAgentRequest").msgclass
        ExportAgentResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ExportAgentResponse").msgclass
        ImportAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ImportAgentRequest").msgclass
        RestoreAgentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.RestoreAgentRequest").msgclass
        GetValidationResultRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.GetValidationResultRequest").msgclass
      end
    end
  end
end
