<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/participant.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\V2Beta1;

class Participant
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
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Session::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�g
1google/cloud/dialogflow/v2beta1/participant.protogoogle.cloud.dialogflow.v2beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto2google/cloud/dialogflow/v2beta1/audio_config.proto-google/cloud/dialogflow/v2beta1/session.protogoogle/protobuf/any.protogoogle/protobuf/duration.proto google/protobuf/field_mask.protogoogle/protobuf/struct.protogoogle/protobuf/timestamp.protogoogle/rpc/status.proto"�
Participant
name (	B�AD
role (21.google.cloud.dialogflow.v2beta1.Participant.RoleB�A(
obfuscated_external_user_id (	B�A"P
Role
ROLE_UNSPECIFIED 
HUMAN_AGENT
AUTOMATED_AGENT
END_USER:��A�
%dialogflow.googleapis.com/ParticipantJprojects/{project}/conversations/{conversation}/participants/{participant}_projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}"�
Message
name (	B�A
content (	B�A
language_code (	B�A
participant (	B�AP
participant_role (21.google.cloud.dialogflow.v2beta1.Participant.RoleB�A4
create_time (2.google.protobuf.TimestampB�A2
	send_time	 (2.google.protobuf.TimestampB�AS
message_annotation (22.google.cloud.dialogflow.v2beta1.MessageAnnotationB�AY
sentiment_analysis (28.google.cloud.dialogflow.v2beta1.SentimentAnalysisResultB�A:��A�
!dialogflow.googleapis.com/MessageBprojects/{project}/conversations/{conversation}/messages/{message}Wprojects/{project}/locations/{location}/conversations/{conversation}/messages/{message}"�
CreateParticipantRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/ParticipantF
participant (2,.google.cloud.dialogflow.v2beta1.ParticipantB�A"T
GetParticipantRequest;
name (	B-�A�A\'
%dialogflow.googleapis.com/Participant"�
ListParticipantsRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/Participant
	page_size (B�A

page_token (	B�A"w
ListParticipantsResponseB
participants (2,.google.cloud.dialogflow.v2beta1.Participant
next_page_token (	"�
UpdateParticipantRequestF
participant (2,.google.cloud.dialogflow.v2beta1.ParticipantB�A4
update_mask (2.google.protobuf.FieldMaskB�A"0
	InputText
text (	
language_code (	"^

InputAudioA
config (21.google.cloud.dialogflow.v2beta1.InputAudioConfig
audio ("^

AudioInputA
config (21.google.cloud.dialogflow.v2beta1.InputAudioConfig
audio ("`
OutputAudioB
config (22.google.cloud.dialogflow.v2beta1.OutputAudioConfig
audio ("�
AutomatedAgentReplyW
detect_intent_response (25.google.cloud.dialogflow.v2beta1.DetectIntentResponseH K
response_messages (20.google.cloud.dialogflow.v2beta1.ResponseMessage7
intent (	B%�A"
 dialogflow.googleapis.com/IntentH
event (	H6
cx_session_parameters (2.google.protobuf.StructB

responseB
match"�
SuggestionFeatureE
type (27.google.cloud.dialogflow.v2beta1.SuggestionFeature.Type"N
Type
TYPE_UNSPECIFIED 
ARTICLE_SUGGESTION
FAQ
SMART_REPLY"�
AnalyzeContentRequestB
participant (	B-�A�A\'
%dialogflow.googleapis.com/Participant>
text (2*.google.cloud.dialogflow.v2beta1.InputTextBH @
audio (2+.google.cloud.dialogflow.v2beta1.InputAudioBH @

text_input (2*.google.cloud.dialogflow.v2beta1.TextInputH B
audio_input (2+.google.cloud.dialogflow.v2beta1.AudioInputH B
event_input (2+.google.cloud.dialogflow.v2beta1.EventInputH N
reply_audio_config (22.google.cloud.dialogflow.v2beta1.OutputAudioConfigF
query_params	 (20.google.cloud.dialogflow.v2beta1.QueryParameters5
message_send_time
 (2.google.protobuf.Timestamp

request_id (	B
input",
DtmfParameters
accepts_dtmf_input ("�
AnalyzeContentResponse

reply_text (	A
reply_audio (2,.google.cloud.dialogflow.v2beta1.OutputAudioS
automated_agent_reply (24.google.cloud.dialogflow.v2beta1.AutomatedAgentReply9
message (2(.google.cloud.dialogflow.v2beta1.MessageY
human_agent_suggestion_results (21.google.cloud.dialogflow.v2beta1.SuggestionResultV
end_user_suggestion_results (21.google.cloud.dialogflow.v2beta1.SuggestionResultH
dtmf_parameters	 (2/.google.cloud.dialogflow.v2beta1.DtmfParameters"(
InputTextConfig
language_code (	"�
StreamingAnalyzeContentRequestB
participant (	B-�A�A\'
%dialogflow.googleapis.com/ParticipantI
audio_config (21.google.cloud.dialogflow.v2beta1.InputAudioConfigH G
text_config (20.google.cloud.dialogflow.v2beta1.InputTextConfigH N
reply_audio_config (22.google.cloud.dialogflow.v2beta1.OutputAudioConfig
input_audio (H

input_text (	HJ

input_dtmf	 (24.google.cloud.dialogflow.v2beta1.TelephonyDtmfEventsHF
query_params (20.google.cloud.dialogflow.v2beta1.QueryParameters!
enable_extended_streaming (B
configB
input"�
StreamingAnalyzeContentResponseW
recognition_result (2;.google.cloud.dialogflow.v2beta1.StreamingRecognitionResult

reply_text (	A
reply_audio (2,.google.cloud.dialogflow.v2beta1.OutputAudioS
automated_agent_reply (24.google.cloud.dialogflow.v2beta1.AutomatedAgentReply9
message (2(.google.cloud.dialogflow.v2beta1.MessageY
human_agent_suggestion_results (21.google.cloud.dialogflow.v2beta1.SuggestionResultV
end_user_suggestion_results (21.google.cloud.dialogflow.v2beta1.SuggestionResultH
dtmf_parameters
 (2/.google.cloud.dialogflow.v2beta1.DtmfParameters"j
AnnotatedMessagePart
text (	
entity_type (	/
formatted_value (2.google.protobuf.Value"s
MessageAnnotationD
parts (25.google.cloud.dialogflow.v2beta1.AnnotatedMessagePart
contain_entities ("�
ArticleAnswer
title (	
uri (	
snippets (	N
metadata (2<.google.cloud.dialogflow.v2beta1.ArticleAnswer.MetadataEntry
answer_record (	/
MetadataEntry
key (	
value (	:8"�
	FaqAnswer
answer (	

confidence (
question (	
source (	J
metadata (28.google.cloud.dialogflow.v2beta1.FaqAnswer.MetadataEntry
answer_record (	/
MetadataEntry
key (	
value (	:8"L
SmartReplyAnswer
reply (	

confidence (
answer_record (	"�
SuggestionResult#
error (2.google.rpc.StatusH ]
suggest_articles_response (28.google.cloud.dialogflow.v2beta1.SuggestArticlesResponseH b
suggest_faq_answers_response (2:.google.cloud.dialogflow.v2beta1.SuggestFaqAnswersResponseH f
suggest_smart_replies_response (2<.google.cloud.dialogflow.v2beta1.SuggestSmartRepliesResponseH B
suggestion_response"�
SuggestArticlesRequest=
parent (	B-�A�A\'
%dialogflow.googleapis.com/ParticipantA
latest_message (	B)�A�A#
!dialogflow.googleapis.com/Message
context_size (B�A"�
SuggestArticlesResponseG
article_answers (2..google.cloud.dialogflow.v2beta1.ArticleAnswer
latest_message (	
context_size ("�
SuggestFaqAnswersRequest=
parent (	B-�A�A\'
%dialogflow.googleapis.com/ParticipantA
latest_message (	B)�A�A#
!dialogflow.googleapis.com/Message
context_size (B�A"�
SuggestFaqAnswersResponse?
faq_answers (2*.google.cloud.dialogflow.v2beta1.FaqAnswer
latest_message (	
context_size ("�
SuggestSmartRepliesRequest=
parent (	B-�A�A\'
%dialogflow.googleapis.com/ParticipantF
current_text_input (2*.google.cloud.dialogflow.v2beta1.TextInput>
latest_message (	B&�A#
!dialogflow.googleapis.com/Message
context_size ("�
SuggestSmartRepliesResponseN
smart_reply_answers (21.google.cloud.dialogflow.v2beta1.SmartReplyAnswer
latest_message (	
context_size ("�

Suggestion
name (	E
articles (23.google.cloud.dialogflow.v2beta1.Suggestion.ArticleJ
faq_answers (25.google.cloud.dialogflow.v2beta1.Suggestion.FaqAnswer/
create_time (2.google.protobuf.Timestamp
latest_message (	�
Article
title (	
uri (	
snippets (	S
metadata (2A.google.cloud.dialogflow.v2beta1.Suggestion.Article.MetadataEntry
answer_record (	/
MetadataEntry
key (	
value (	:8�
	FaqAnswer
answer (	

confidence (
question (	
source (	U
metadata (2C.google.cloud.dialogflow.v2beta1.Suggestion.FaqAnswer.MetadataEntry
answer_record (	/
MetadataEntry
key (	
value (	:8:"c
ListSuggestionsRequest
parent (	
	page_size (

page_token (	
filter (	:"x
ListSuggestionsResponse@
suggestions (2+.google.cloud.dialogflow.v2beta1.Suggestion
next_page_token (	:"\\
CompileSuggestionRequest
parent (	
latest_message (	
context_size (:"�
CompileSuggestionResponse?

suggestion (2+.google.cloud.dialogflow.v2beta1.Suggestion
latest_message (	
context_size (:"�
ResponseMessageE
text (25.google.cloud.dialogflow.v2beta1.ResponseMessage.TextH *
payload (2.google.protobuf.StructH _
live_agent_handoff (2A.google.cloud.dialogflow.v2beta1.ResponseMessage.LiveAgentHandoffH Z
end_interaction (2?.google.cloud.dialogflow.v2beta1.ResponseMessage.EndInteractionH R
mixed_audio (2;.google.cloud.dialogflow.v2beta1.ResponseMessage.MixedAudioH 
Text
text (	=
LiveAgentHandoff)
metadata (2.google.protobuf.Struct
EndInteraction�

MixedAudioU
segments (2C.google.cloud.dialogflow.v2beta1.ResponseMessage.MixedAudio.SegmentY
Segment
audio (H 
uri (	H #
allow_playback_interruption (B	
contentB	
message2�
Participants�
CreateParticipant9.google.cloud.dialogflow.v2beta1.CreateParticipantRequest,.google.cloud.dialogflow.v2beta1.Participant"�����"9/v2beta1/{parent=projects/*/conversations/*}/participants:participantZT"E/v2beta1/{parent=projects/*/locations/*/conversations/*}/participants:participant�Aparent,participant�
GetParticipant6.google.cloud.dialogflow.v2beta1.GetParticipantRequest,.google.cloud.dialogflow.v2beta1.Participant"�����9/v2beta1/{name=projects/*/conversations/*/participants/*}ZGE/v2beta1/{name=projects/*/locations/*/conversations/*/participants/*}�Aname�
ListParticipants8.google.cloud.dialogflow.v2beta1.ListParticipantsRequest9.google.cloud.dialogflow.v2beta1.ListParticipantsResponse"�����9/v2beta1/{parent=projects/*/conversations/*}/participantsZGE/v2beta1/{parent=projects/*/locations/*/conversations/*}/participants�Aparent�
UpdateParticipant9.google.cloud.dialogflow.v2beta1.UpdateParticipantRequest,.google.cloud.dialogflow.v2beta1.Participant"�����2E/v2beta1/{participant.name=projects/*/conversations/*/participants/*}:participantZ`2Q/v2beta1/{participant.name=projects/*/locations/*/conversations/*/participants/*}:participant�Aparticipant,update_mask�
AnalyzeContent6.google.cloud.dialogflow.v2beta1.AnalyzeContentRequest7.google.cloud.dialogflow.v2beta1.AnalyzeContentResponse"�����"O/v2beta1/{participant=projects/*/conversations/*/participants/*}:analyzeContent:*Z`"[/v2beta1/{participant=projects/*/locations/*/conversations/*/participants/*}:analyzeContent:*�Aparticipant,text_input�Aparticipant,audio_input�Aparticipant,event_input�
StreamingAnalyzeContent?.google.cloud.dialogflow.v2beta1.StreamingAnalyzeContentRequest@.google.cloud.dialogflow.v2beta1.StreamingAnalyzeContentResponse" (0�
SuggestArticles7.google.cloud.dialogflow.v2beta1.SuggestArticlesRequest8.google.cloud.dialogflow.v2beta1.SuggestArticlesResponse"�����"W/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestArticles:*Zh"c/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestArticles:*�Aparent�
SuggestFaqAnswers9.google.cloud.dialogflow.v2beta1.SuggestFaqAnswersRequest:.google.cloud.dialogflow.v2beta1.SuggestFaqAnswersResponse"�����"Y/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestFaqAnswers:*Zj"e/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestFaqAnswers:*�Aparent�
SuggestSmartReplies;.google.cloud.dialogflow.v2beta1.SuggestSmartRepliesRequest<.google.cloud.dialogflow.v2beta1.SuggestSmartRepliesResponse"�����"[/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestSmartReplies:*Zl"g/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestSmartReplies:*�Aparent�
ListSuggestions7.google.cloud.dialogflow.v2beta1.ListSuggestionsRequest8.google.cloud.dialogflow.v2beta1.ListSuggestionsResponse"R����IG/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions�
CompileSuggestion9.google.cloud.dialogflow.v2beta1.CompileSuggestionRequest:.google.cloud.dialogflow.v2beta1.CompileSuggestionResponse"]����T"O/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:compile:*x�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
#com.google.cloud.dialogflow.v2beta1BParticipantProtoPZIgoogle.golang.org/genproto/googleapis/cloud/dialogflow/v2beta1;dialogflow��DF�Google.Cloud.Dialogflow.V2beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

