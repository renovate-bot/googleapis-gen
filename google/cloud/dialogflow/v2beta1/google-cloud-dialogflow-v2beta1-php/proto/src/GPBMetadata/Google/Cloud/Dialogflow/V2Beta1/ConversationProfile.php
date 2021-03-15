<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/conversation_profile.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\V2Beta1;

class ConversationProfile
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\AudioConfig::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Document::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Participant::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�:
:google/cloud/dialogflow/v2beta1/conversation_profile.protogoogle.cloud.dialogflow.v2beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto2google/cloud/dialogflow/v2beta1/audio_config.proto.google/cloud/dialogflow/v2beta1/document.proto1google/cloud/dialogflow/v2beta1/participant.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"�
ConversationProfile
name (	
display_name (	B�A4
create_time (2.google.protobuf.TimestampB�A4
update_time (2.google.protobuf.TimestampB�AU
automated_agent_config (25.google.cloud.dialogflow.v2beta1.AutomatedAgentConfig`
human_agent_assistant_config (2:.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig\\
human_agent_handoff_config (28.google.cloud.dialogflow.v2beta1.HumanAgentHandoffConfigP
notification_config (23.google.cloud.dialogflow.v2beta1.NotificationConfigF
logging_config (2..google.cloud.dialogflow.v2beta1.LoggingConfigb
%new_message_event_notification_config (23.google.cloud.dialogflow.v2beta1.NotificationConfigG

stt_config	 (23.google.cloud.dialogflow.v2beta1.SpeechToTextConfig
language_code
 (	:��A�
-dialogflow.googleapis.com/ConversationProfile>projects/{project}/conversationProfiles/{conversation_profile}Sprojects/{project}/locations/{location}/conversationProfiles/{conversation_profile}"N
AutomatedAgentConfig6
agent (	B\'�A�A!
dialogflow.googleapis.com/Agent"�
HumanAgentAssistantConfigP
notification_config (23.google.cloud.dialogflow.v2beta1.NotificationConfigr
human_agent_suggestion_config (2K.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionConfigo
end_user_suggestion_config (2K.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionConfigq
message_analysis_config (2P.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.MessageAnalysisConfigI
SuggestionTriggerSettings
no_small_talk (
only_end_user (�
SuggestionFeatureConfigN
suggestion_feature (22.google.cloud.dialogflow.v2beta1.SuggestionFeature%
enable_event_based_suggestion (y
suggestion_trigger_settings
 (2T.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionTriggerSettingsf
query_config (2P.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionQueryConfigu
conversation_model_config (2R.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.ConversationModelConfig�
SuggestionConfigk
feature_configs (2R.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionFeatureConfig"
group_suggestion_responses (�
SuggestionQueryConfig�
knowledge_base_query_source (2i.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionQueryConfig.KnowledgeBaseQuerySourceH �
document_query_source (2d.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionQueryConfig.DocumentQuerySourceH �
dialogflow_query_source (2f.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionQueryConfig.DialogflowQuerySourceH 
max_results (
confidence_threshold (�
context_filter_settings (2f.google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.SuggestionQueryConfig.ContextFilterSettingsd
KnowledgeBaseQuerySourceH
knowledge_bases (	B/�A�A)
\'dialogflow.googleapis.com/KnowledgeBaseT
DocumentQuerySource=
	documents (	B*�A�A$
"dialogflow.googleapis.com/DocumentO
DialogflowQuerySource6
agent (	B\'�A�A!
dialogflow.googleapis.com/Agentv
ContextFilterSettings
drop_handoff_messages (#
drop_virtual_agent_messages (
drop_ivr_messages (B
query_source-
ConversationModelConfig
model (	B�A\\
MessageAnalysisConfig 
enable_entity_extraction (!
enable_sentiment_analysis ("�
HumanAgentHandoffConfigg
live_person_config (2I.google.cloud.dialogflow.v2beta1.HumanAgentHandoffConfig.LivePersonConfigH z
salesforce_live_agent_config (2R.google.cloud.dialogflow.v2beta1.HumanAgentHandoffConfig.SalesforceLiveAgentConfigH /
LivePersonConfig
account_number (	B�A�
SalesforceLiveAgentConfig
organization_id (	B�A
deployment_id (	B�A
	button_id (	B�A
endpoint_domain (	B�AB
agent_service"�
NotificationConfig
topic (	Y
message_format (2A.google.cloud.dialogflow.v2beta1.NotificationConfig.MessageFormat"D
MessageFormat
MESSAGE_FORMAT_UNSPECIFIED 	
PROTO
JSON"3
LoggingConfig"
enable_stackdriver_logging ("�
ListConversationProfilesRequestE
parent (	B5�A�A/-dialogflow.googleapis.com/ConversationProfile
	page_size (

page_token (	"�
 ListConversationProfilesResponseS
conversation_profiles (24.google.cloud.dialogflow.v2beta1.ConversationProfile
next_page_token (	"d
GetConversationProfileRequestC
name (	B5�A�A/
-dialogflow.googleapis.com/ConversationProfile"�
 CreateConversationProfileRequestE
parent (	B5�A�A/-dialogflow.googleapis.com/ConversationProfileW
conversation_profile (24.google.cloud.dialogflow.v2beta1.ConversationProfileB�A"�
 UpdateConversationProfileRequestW
conversation_profile (24.google.cloud.dialogflow.v2beta1.ConversationProfileB�A4
update_mask (2.google.protobuf.FieldMaskB�A"g
 DeleteConversationProfileRequestC
name (	B5�A�A/
-dialogflow.googleapis.com/ConversationProfile2�
ConversationProfiles�
ListConversationProfiles@.google.cloud.dialogflow.v2beta1.ListConversationProfilesRequestA.google.cloud.dialogflow.v2beta1.ListConversationProfilesResponse"����t1/v2beta1/{parent=projects/*}/conversationProfilesZ?=/v2beta1/{parent=projects/*/locations/*}/conversationProfiles�Aparent�
GetConversationProfile>.google.cloud.dialogflow.v2beta1.GetConversationProfileRequest4.google.cloud.dialogflow.v2beta1.ConversationProfile"����t1/v2beta1/{name=projects/*/conversationProfiles/*}Z?=/v2beta1/{name=projects/*/locations/*/conversationProfiles/*}�Aname�
CreateConversationProfileA.google.cloud.dialogflow.v2beta1.CreateConversationProfileRequest4.google.cloud.dialogflow.v2beta1.ConversationProfile"�����"1/v2beta1/{parent=projects/*}/conversationProfiles:conversation_profileZU"=/v2beta1/{parent=projects/*/locations/*}/conversationProfiles:conversation_profile�Aparent,conversation_profile�
UpdateConversationProfileA.google.cloud.dialogflow.v2beta1.UpdateConversationProfileRequest4.google.cloud.dialogflow.v2beta1.ConversationProfile"�����2F/v2beta1/{conversation_profile.name=projects/*/conversationProfiles/*}:conversation_profileZj2R/v2beta1/{conversation_profile.name=projects/*/locations/*/conversationProfiles/*}:conversation_profile�A conversation_profile,update_mask�
DeleteConversationProfileA.google.cloud.dialogflow.v2beta1.DeleteConversationProfileRequest.google.protobuf.Empty"����t*1/v2beta1/{name=projects/*/conversationProfiles/*}Z?*=/v2beta1/{name=projects/*/locations/*/conversationProfiles/*}�Anamex�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
#com.google.cloud.dialogflow.v2beta1BConversationProfileProtoPZIgoogle.golang.org/genproto/googleapis/cloud/dialogflow/v2beta1;dialogflow��DF�Google.Cloud.Dialogflow.V2beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

