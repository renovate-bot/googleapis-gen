<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/conversation.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\V2Beta1;

class Conversation
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
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Gcs::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Participant::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Session::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�2
2google/cloud/dialogflow/v2beta1/conversation.protogoogle.cloud.dialogflow.v2beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto)google/cloud/dialogflow/v2beta1/gcs.proto1google/cloud/dialogflow/v2beta1/participant.proto-google/cloud/dialogflow/v2beta1/session.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.protogoogle/rpc/status.proto"�
Conversation
name (	B�AZ
lifecycle_state (2<.google.cloud.dialogflow.v2beta1.Conversation.LifecycleStateB�AS
conversation_profile (	B5�A�A/
-dialogflow.googleapis.com/ConversationProfileS
phone_number (28.google.cloud.dialogflow.v2beta1.ConversationPhoneNumberB�A[
conversation_stage (2?.google.cloud.dialogflow.v2beta1.Conversation.ConversationStage3

start_time (2.google.protobuf.TimestampB�A1
end_time (2.google.protobuf.TimestampB�A"Q
LifecycleState
LIFECYCLE_STATE_UNSPECIFIED 
IN_PROGRESS
	COMPLETED"h
ConversationStage"
CONVERSATION_STAGE_UNSPECIFIED 
VIRTUAL_AGENT_STAGE
HUMAN_ASSIST_STAGE:��A�
&dialogflow.googleapis.com/Conversation/projects/{project}/conversations/{conversation}Dprojects/{project}/locations/{location}/conversations/{conversation}"4
ConversationPhoneNumber
phone_number (	B�A"�
CallMatcher
name (	B�A
	to_header (	
from_header (	
call_id_header (	R
custom_headers (2:.google.cloud.dialogflow.v2beta1.CallMatcher.CustomHeaders#
CustomHeaders

cisco_guid (	:��A�
%dialogflow.googleapis.com/CallMatcherKprojects/{project}/conversations/{conversation}/callMatchers/{call_matcher}`projects/{project}/locations/{location}/conversations/{conversation}/callMatchers/{call_matcher}"�
CreateConversationRequest>
parent (	B.�A�A(&dialogflow.googleapis.com/ConversationH
conversation (2-.google.cloud.dialogflow.v2beta1.ConversationB�A
conversation_id (	B�A"�
ListConversationsRequest>
parent (	B.�A�A(&dialogflow.googleapis.com/Conversation
	page_size (

page_token (	
filter (	"z
ListConversationsResponseD
conversations (2-.google.cloud.dialogflow.v2beta1.Conversation
next_page_token (	"V
GetConversationRequest<
name (	B.�A�A(
&dialogflow.googleapis.com/Conversation"[
CompleteConversationRequest<
name (	B.�A�A(
&dialogflow.googleapis.com/Conversation"�
CreateCallMatcherRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/CallMatcherB
call_matcher (2,.google.cloud.dialogflow.v2beta1.CallMatcher"
ListCallMatchersRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/CallMatcher
	page_size (

page_token (	"x
ListCallMatchersResponseC
call_matchers (2,.google.cloud.dialogflow.v2beta1.CallMatcher
next_page_token (	"W
DeleteCallMatcherRequest;
name (	B-�A�A\'
%dialogflow.googleapis.com/CallMatcher"�
CreateMessageRequest>
parent (	B.�A�A(
&dialogflow.googleapis.com/Conversation>
message (2(.google.cloud.dialogflow.v2beta1.MessageB�A"�
BatchCreateMessagesRequest>
parent (	B.�A�A(
&dialogflow.googleapis.com/ConversationL
requests (25.google.cloud.dialogflow.v2beta1.CreateMessageRequestB�A"Y
BatchCreateMessagesResponse:
messages (2(.google.cloud.dialogflow.v2beta1.Message"�
ListMessagesRequest9
parent (	B)�A�A#!dialogflow.googleapis.com/Message
filter (	
	page_size (

page_token (	"k
ListMessagesResponse:
messages (2(.google.cloud.dialogflow.v2beta1.Message
next_page_token (	2�
Conversations�
CreateConversation:.google.cloud.dialogflow.v2beta1.CreateConversationRequest-.google.cloud.dialogflow.v2beta1.Conversation"�����"*/v2beta1/{parent=projects/*}/conversations:conversationZF"6/v2beta1/{parent=projects/*/locations/*}/conversations:conversation�Aparent,conversation�
ListConversations9.google.cloud.dialogflow.v2beta1.ListConversationsRequest:.google.cloud.dialogflow.v2beta1.ListConversationsResponse"u���f*/v2beta1/{parent=projects/*}/conversationsZ86/v2beta1/{parent=projects/*/locations/*}/conversations�Aparent�
GetConversation7.google.cloud.dialogflow.v2beta1.GetConversationRequest-.google.cloud.dialogflow.v2beta1.Conversation"s���f*/v2beta1/{name=projects/*/conversations/*}Z86/v2beta1/{name=projects/*/locations/*/conversations/*}�Aname�
CompleteConversation<.google.cloud.dialogflow.v2beta1.CompleteConversationRequest-.google.cloud.dialogflow.v2beta1.Conversation"����~"3/v2beta1/{name=projects/*/conversations/*}:complete:*ZD"?/v2beta1/{name=projects/*/locations/*/conversations/*}:complete:*�Aname�
CreateCallMatcher9.google.cloud.dialogflow.v2beta1.CreateCallMatcherRequest,.google.cloud.dialogflow.v2beta1.CallMatcher"�����"9/v2beta1/{parent=projects/*/conversations/*}/callMatchers:call_matcherZJ"E/v2beta1/{parent=projects/*/locations/*/conversations/*}/callMatchers:*�Aparent,call_matcher�
ListCallMatchers8.google.cloud.dialogflow.v2beta1.ListCallMatchersRequest9.google.cloud.dialogflow.v2beta1.ListCallMatchersResponse"�����9/v2beta1/{parent=projects/*/conversations/*}/callMatchersZGE/v2beta1/{parent=projects/*/locations/*/conversations/*}/callMatchers�Aparent�
DeleteCallMatcher9.google.cloud.dialogflow.v2beta1.DeleteCallMatcherRequest.google.protobuf.Empty"�����*9/v2beta1/{name=projects/*/conversations/*/callMatchers/*}ZG*E/v2beta1/{name=projects/*/locations/*/conversations/*/callMatchers/*}�Aname�
BatchCreateMessages;.google.cloud.dialogflow.v2beta1.BatchCreateMessagesRequest<.google.cloud.dialogflow.v2beta1.BatchCreateMessagesResponse"�����"A/v2beta1/{parent=projects/*/conversations/*}/messages:batchCreate:*ZR"M/v2beta1/{parent=projects/*/locations/*/conversations/*}/messages:batchCreate:*�Aparent�
ListMessages4.google.cloud.dialogflow.v2beta1.ListMessagesRequest5.google.cloud.dialogflow.v2beta1.ListMessagesResponse"����|5/v2beta1/{parent=projects/*/conversations/*}/messagesZCA/v2beta1/{parent=projects/*/locations/*/conversations/*}/messages�Aparentx�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
#com.google.cloud.dialogflow.v2beta1BConversationProtoPZIgoogle.golang.org/genproto/googleapis/cloud/dialogflow/v2beta1;dialogflow��DF�Google.Cloud.Dialogflow.V2beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

