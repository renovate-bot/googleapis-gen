# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/human_agent_assistant_event.proto

require 'google/protobuf'

require 'google/cloud/dialogflow/v2beta1/participant_pb'
require 'google/api/annotations_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/dialogflow/v2beta1/human_agent_assistant_event.proto", :syntax => :proto3) do
    add_message "google.cloud.dialogflow.v2beta1.HumanAgentAssistantEvent" do
      optional :conversation, :string, 1
      optional :participant, :string, 3
      repeated :suggestion_results, :message, 5, "google.cloud.dialogflow.v2beta1.SuggestionResult"
    end
  end
end

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        HumanAgentAssistantEvent = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.HumanAgentAssistantEvent").msgclass
      end
    end
  end
end
