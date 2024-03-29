# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/participant.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/dialogflow/v2beta1/audio_config_pb'
require 'google/cloud/dialogflow/v2beta1/gcs_pb'
require 'google/cloud/dialogflow/v2beta1/session_pb'
require 'google/protobuf/any_pb'
require 'google/protobuf/duration_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf/struct_pb'
require 'google/protobuf/timestamp_pb'
require 'google/rpc/status_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/dialogflow/v2beta1/participant.proto", :syntax => :proto3) do
    add_message "google.cloud.dialogflow.v2beta1.Participant" do
      optional :name, :string, 1
      optional :role, :enum, 2, "google.cloud.dialogflow.v2beta1.Participant.Role"
      optional :obfuscated_external_user_id, :string, 7
      map :documents_metadata_filters, :string, :string, 8
    end
    add_enum "google.cloud.dialogflow.v2beta1.Participant.Role" do
      value :ROLE_UNSPECIFIED, 0
      value :HUMAN_AGENT, 1
      value :AUTOMATED_AGENT, 2
      value :END_USER, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.Message" do
      optional :name, :string, 1
      optional :content, :string, 2
      optional :language_code, :string, 3
      optional :participant, :string, 4
      optional :participant_role, :enum, 5, "google.cloud.dialogflow.v2beta1.Participant.Role"
      optional :create_time, :message, 6, "google.protobuf.Timestamp"
      optional :send_time, :message, 9, "google.protobuf.Timestamp"
      optional :message_annotation, :message, 7, "google.cloud.dialogflow.v2beta1.MessageAnnotation"
      optional :sentiment_analysis, :message, 8, "google.cloud.dialogflow.v2beta1.SentimentAnalysisResult"
    end
    add_message "google.cloud.dialogflow.v2beta1.CreateParticipantRequest" do
      optional :parent, :string, 1
      optional :participant, :message, 2, "google.cloud.dialogflow.v2beta1.Participant"
    end
    add_message "google.cloud.dialogflow.v2beta1.GetParticipantRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.ListParticipantsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.ListParticipantsResponse" do
      repeated :participants, :message, 1, "google.cloud.dialogflow.v2beta1.Participant"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.UpdateParticipantRequest" do
      optional :participant, :message, 1, "google.cloud.dialogflow.v2beta1.Participant"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.dialogflow.v2beta1.OutputAudio" do
      optional :config, :message, 1, "google.cloud.dialogflow.v2beta1.OutputAudioConfig"
      optional :audio, :bytes, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.AutomatedAgentReply" do
      repeated :response_messages, :message, 3, "google.cloud.dialogflow.v2beta1.ResponseMessage"
      optional :match_confidence, :float, 9
      optional :parameters, :message, 10, "google.protobuf.Struct"
      optional :cx_session_parameters, :message, 6, "google.protobuf.Struct"
      optional :automated_agent_reply_type, :enum, 7, "google.cloud.dialogflow.v2beta1.AutomatedAgentReply.AutomatedAgentReplyType"
      optional :allow_cancellation, :bool, 8
      oneof :response do
        optional :detect_intent_response, :message, 1, "google.cloud.dialogflow.v2beta1.DetectIntentResponse"
      end
      oneof :match do
        optional :intent, :string, 4
        optional :event, :string, 5
      end
    end
    add_enum "google.cloud.dialogflow.v2beta1.AutomatedAgentReply.AutomatedAgentReplyType" do
      value :AUTOMATED_AGENT_REPLY_TYPE_UNSPECIFIED, 0
      value :PARTIAL, 1
      value :FINAL, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestionFeature" do
      optional :type, :enum, 1, "google.cloud.dialogflow.v2beta1.SuggestionFeature.Type"
    end
    add_enum "google.cloud.dialogflow.v2beta1.SuggestionFeature.Type" do
      value :TYPE_UNSPECIFIED, 0
      value :ARTICLE_SUGGESTION, 1
      value :FAQ, 2
      value :SMART_REPLY, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.AssistQueryParameters" do
      map :documents_metadata_filters, :string, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.AnalyzeContentRequest" do
      optional :participant, :string, 1
      optional :reply_audio_config, :message, 5, "google.cloud.dialogflow.v2beta1.OutputAudioConfig"
      optional :query_params, :message, 9, "google.cloud.dialogflow.v2beta1.QueryParameters"
      optional :assist_query_params, :message, 14, "google.cloud.dialogflow.v2beta1.AssistQueryParameters"
      optional :message_send_time, :message, 10, "google.protobuf.Timestamp"
      optional :request_id, :string, 11
      oneof :input do
        optional :text_input, :message, 6, "google.cloud.dialogflow.v2beta1.TextInput"
        optional :event_input, :message, 8, "google.cloud.dialogflow.v2beta1.EventInput"
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.DtmfParameters" do
      optional :accepts_dtmf_input, :bool, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.AnalyzeContentResponse" do
      optional :reply_text, :string, 1
      optional :reply_audio, :message, 2, "google.cloud.dialogflow.v2beta1.OutputAudio"
      optional :automated_agent_reply, :message, 3, "google.cloud.dialogflow.v2beta1.AutomatedAgentReply"
      optional :message, :message, 5, "google.cloud.dialogflow.v2beta1.Message"
      repeated :human_agent_suggestion_results, :message, 6, "google.cloud.dialogflow.v2beta1.SuggestionResult"
      repeated :end_user_suggestion_results, :message, 7, "google.cloud.dialogflow.v2beta1.SuggestionResult"
      optional :dtmf_parameters, :message, 9, "google.cloud.dialogflow.v2beta1.DtmfParameters"
    end
    add_message "google.cloud.dialogflow.v2beta1.AnnotatedMessagePart" do
      optional :text, :string, 1
      optional :entity_type, :string, 2
      optional :formatted_value, :message, 3, "google.protobuf.Value"
    end
    add_message "google.cloud.dialogflow.v2beta1.MessageAnnotation" do
      repeated :parts, :message, 1, "google.cloud.dialogflow.v2beta1.AnnotatedMessagePart"
      optional :contain_entities, :bool, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.ArticleAnswer" do
      optional :title, :string, 1
      optional :uri, :string, 2
      repeated :snippets, :string, 3
      map :metadata, :string, :string, 5
      optional :answer_record, :string, 6
    end
    add_message "google.cloud.dialogflow.v2beta1.FaqAnswer" do
      optional :answer, :string, 1
      optional :confidence, :float, 2
      optional :question, :string, 3
      optional :source, :string, 4
      map :metadata, :string, :string, 5
      optional :answer_record, :string, 6
    end
    add_message "google.cloud.dialogflow.v2beta1.SmartReplyAnswer" do
      optional :reply, :string, 1
      optional :confidence, :float, 2
      optional :answer_record, :string, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestionResult" do
      oneof :suggestion_response do
        optional :error, :message, 1, "google.rpc.Status"
        optional :suggest_articles_response, :message, 2, "google.cloud.dialogflow.v2beta1.SuggestArticlesResponse"
        optional :suggest_faq_answers_response, :message, 3, "google.cloud.dialogflow.v2beta1.SuggestFaqAnswersResponse"
        optional :suggest_smart_replies_response, :message, 4, "google.cloud.dialogflow.v2beta1.SuggestSmartRepliesResponse"
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestArticlesRequest" do
      optional :parent, :string, 1
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
      optional :assist_query_params, :message, 4, "google.cloud.dialogflow.v2beta1.AssistQueryParameters"
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestArticlesResponse" do
      repeated :article_answers, :message, 1, "google.cloud.dialogflow.v2beta1.ArticleAnswer"
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestFaqAnswersRequest" do
      optional :parent, :string, 1
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
      optional :assist_query_params, :message, 4, "google.cloud.dialogflow.v2beta1.AssistQueryParameters"
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestFaqAnswersResponse" do
      repeated :faq_answers, :message, 1, "google.cloud.dialogflow.v2beta1.FaqAnswer"
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestSmartRepliesRequest" do
      optional :parent, :string, 1
      optional :current_text_input, :message, 4, "google.cloud.dialogflow.v2beta1.TextInput"
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.SuggestSmartRepliesResponse" do
      repeated :smart_reply_answers, :message, 1, "google.cloud.dialogflow.v2beta1.SmartReplyAnswer"
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.Suggestion" do
      optional :name, :string, 1
      repeated :articles, :message, 2, "google.cloud.dialogflow.v2beta1.Suggestion.Article"
      repeated :faq_answers, :message, 4, "google.cloud.dialogflow.v2beta1.Suggestion.FaqAnswer"
      optional :create_time, :message, 5, "google.protobuf.Timestamp"
      optional :latest_message, :string, 7
    end
    add_message "google.cloud.dialogflow.v2beta1.Suggestion.Article" do
      optional :title, :string, 1
      optional :uri, :string, 2
      repeated :snippets, :string, 3
      map :metadata, :string, :string, 5
      optional :answer_record, :string, 6
    end
    add_message "google.cloud.dialogflow.v2beta1.Suggestion.FaqAnswer" do
      optional :answer, :string, 1
      optional :confidence, :float, 2
      optional :question, :string, 3
      optional :source, :string, 4
      map :metadata, :string, :string, 5
      optional :answer_record, :string, 6
    end
    add_message "google.cloud.dialogflow.v2beta1.ListSuggestionsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :filter, :string, 4
    end
    add_message "google.cloud.dialogflow.v2beta1.ListSuggestionsResponse" do
      repeated :suggestions, :message, 1, "google.cloud.dialogflow.v2beta1.Suggestion"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.dialogflow.v2beta1.CompileSuggestionRequest" do
      optional :parent, :string, 1
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.CompileSuggestionResponse" do
      optional :suggestion, :message, 1, "google.cloud.dialogflow.v2beta1.Suggestion"
      optional :latest_message, :string, 2
      optional :context_size, :int32, 3
    end
    add_message "google.cloud.dialogflow.v2beta1.ResponseMessage" do
      oneof :message do
        optional :text, :message, 1, "google.cloud.dialogflow.v2beta1.ResponseMessage.Text"
        optional :payload, :message, 2, "google.protobuf.Struct"
        optional :live_agent_handoff, :message, 3, "google.cloud.dialogflow.v2beta1.ResponseMessage.LiveAgentHandoff"
        optional :end_interaction, :message, 4, "google.cloud.dialogflow.v2beta1.ResponseMessage.EndInteraction"
        optional :telephony_transfer_call, :message, 6, "google.cloud.dialogflow.v2beta1.ResponseMessage.TelephonyTransferCall"
      end
    end
    add_message "google.cloud.dialogflow.v2beta1.ResponseMessage.Text" do
      repeated :text, :string, 1
    end
    add_message "google.cloud.dialogflow.v2beta1.ResponseMessage.LiveAgentHandoff" do
      optional :metadata, :message, 1, "google.protobuf.Struct"
    end
    add_message "google.cloud.dialogflow.v2beta1.ResponseMessage.EndInteraction" do
    end
    add_message "google.cloud.dialogflow.v2beta1.ResponseMessage.TelephonyTransferCall" do
      oneof :endpoint do
        optional :phone_number, :string, 1
        optional :sip_uri, :string, 2
      end
    end
  end
end

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        Participant = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Participant").msgclass
        Participant::Role = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Participant.Role").enummodule
        Message = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Message").msgclass
        CreateParticipantRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.CreateParticipantRequest").msgclass
        GetParticipantRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.GetParticipantRequest").msgclass
        ListParticipantsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ListParticipantsRequest").msgclass
        ListParticipantsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ListParticipantsResponse").msgclass
        UpdateParticipantRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.UpdateParticipantRequest").msgclass
        OutputAudio = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.OutputAudio").msgclass
        AutomatedAgentReply = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AutomatedAgentReply").msgclass
        AutomatedAgentReply::AutomatedAgentReplyType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AutomatedAgentReply.AutomatedAgentReplyType").enummodule
        SuggestionFeature = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestionFeature").msgclass
        SuggestionFeature::Type = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestionFeature.Type").enummodule
        AssistQueryParameters = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AssistQueryParameters").msgclass
        AnalyzeContentRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AnalyzeContentRequest").msgclass
        DtmfParameters = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.DtmfParameters").msgclass
        AnalyzeContentResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AnalyzeContentResponse").msgclass
        AnnotatedMessagePart = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.AnnotatedMessagePart").msgclass
        MessageAnnotation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.MessageAnnotation").msgclass
        ArticleAnswer = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ArticleAnswer").msgclass
        FaqAnswer = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.FaqAnswer").msgclass
        SmartReplyAnswer = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SmartReplyAnswer").msgclass
        SuggestionResult = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestionResult").msgclass
        SuggestArticlesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestArticlesRequest").msgclass
        SuggestArticlesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestArticlesResponse").msgclass
        SuggestFaqAnswersRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestFaqAnswersRequest").msgclass
        SuggestFaqAnswersResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestFaqAnswersResponse").msgclass
        SuggestSmartRepliesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestSmartRepliesRequest").msgclass
        SuggestSmartRepliesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.SuggestSmartRepliesResponse").msgclass
        Suggestion = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Suggestion").msgclass
        Suggestion::Article = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Suggestion.Article").msgclass
        Suggestion::FaqAnswer = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.Suggestion.FaqAnswer").msgclass
        ListSuggestionsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ListSuggestionsRequest").msgclass
        ListSuggestionsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ListSuggestionsResponse").msgclass
        CompileSuggestionRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.CompileSuggestionRequest").msgclass
        CompileSuggestionResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.CompileSuggestionResponse").msgclass
        ResponseMessage = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ResponseMessage").msgclass
        ResponseMessage::Text = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ResponseMessage.Text").msgclass
        ResponseMessage::LiveAgentHandoff = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ResponseMessage.LiveAgentHandoff").msgclass
        ResponseMessage::EndInteraction = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ResponseMessage.EndInteraction").msgclass
        ResponseMessage::TelephonyTransferCall = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dialogflow.v2beta1.ResponseMessage.TelephonyTransferCall").msgclass
      end
    end
  end
end
