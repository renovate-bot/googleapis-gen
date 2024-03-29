<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/webhook.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\Cx\V3;

class Webhook
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
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\ResponseMessage::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        $pool->internalAddGeneratedFile(
            '
�/
+google/cloud/dialogflow/cx/v3/webhook.protogoogle.cloud.dialogflow.cx.v3google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto4google/cloud/dialogflow/cx/v3/response_message.protogoogle/protobuf/duration.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/struct.proto"�
Webhook
name (	
display_name (	B�AW
generic_web_service (28.google.cloud.dialogflow.cx.v3.Webhook.GenericWebServiceH Z
service_directory (2=.google.cloud.dialogflow.cx.v3.Webhook.ServiceDirectoryConfigH *
timeout (2.google.protobuf.Duration
disabled (�
GenericWebService
uri (	B�A
username (	B
password (	Be
request_headers (2L.google.cloud.dialogflow.cx.v3.Webhook.GenericWebService.RequestHeadersEntry
allowed_ca_certs (B�A5
RequestHeadersEntry
key (	
value (	:8�
ServiceDirectoryConfig@
service (	B/�A�A)
\'servicedirectory.googleapis.com/ServiceU
generic_web_service (28.google.cloud.dialogflow.cx.v3.Webhook.GenericWebService:q�An
!dialogflow.googleapis.com/WebhookIprojects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}B	
webhook"w
ListWebhooksRequest9
parent (	B)�A�A#!dialogflow.googleapis.com/Webhook
	page_size (

page_token (	"i
ListWebhooksResponse8
webhooks (2&.google.cloud.dialogflow.cx.v3.Webhook
next_page_token (	"L
GetWebhookRequest7
name (	B)�A�A#
!dialogflow.googleapis.com/Webhook"�
CreateWebhookRequest9
parent (	B)�A�A#!dialogflow.googleapis.com/Webhook<
webhook (2&.google.cloud.dialogflow.cx.v3.WebhookB�A"�
UpdateWebhookRequest<
webhook (2&.google.cloud.dialogflow.cx.v3.WebhookB�A/
update_mask (2.google.protobuf.FieldMask"^
DeleteWebhookRequest7
name (	B)�A�A#
!dialogflow.googleapis.com/Webhook
force ("�	
WebhookRequest!
detect_intent_response_id (	
text
 (	H ?
trigger_intent (	B%�A"
 dialogflow.googleapis.com/IntentH 

transcript (	H 
trigger_event (	H 
language_code (	W
fulfillment_info (2=.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfoM
intent_info (28.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo:
	page_info (2\'.google.cloud.dialogflow.cx.v3.PageInfo@
session_info (2*.google.cloud.dialogflow.cx.v3.SessionInfo@
messages (2..google.cloud.dialogflow.cx.v3.ResponseMessage(
payload (2.google.protobuf.Structh
sentiment_analysis_result	 (2E.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult
FulfillmentInfo
tag (	�

IntentInfoB
last_matched_intent (	B%�A"
 dialogflow.googleapis.com/Intent
display_name (	\\

parameters (2H.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo.ParametersEntry

confidence (^
IntentParameterValue
original_value (	.
resolved_value (2.google.protobuf.Value�
ParametersEntry
key (	\\
value (2M.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo.IntentParameterValue:8;
SentimentAnalysisResult
score (
	magnitude (B
query"�
WebhookResponse`
fulfillment_response (2B.google.cloud.dialogflow.cx.v3.WebhookResponse.FulfillmentResponse:
	page_info (2\'.google.cloud.dialogflow.cx.v3.PageInfo@
session_info (2*.google.cloud.dialogflow.cx.v3.SessionInfo(
payload (2.google.protobuf.Struct:
target_page (	B#�A 
dialogflow.googleapis.com/PageH :
target_flow (	B#�A 
dialogflow.googleapis.com/FlowH �
FulfillmentResponse@
messages (2..google.cloud.dialogflow.cx.v3.ResponseMessageh
merge_behavior (2P.google.cloud.dialogflow.cx.v3.WebhookResponse.FulfillmentResponse.MergeBehavior"H
MergeBehavior
MERGE_BEHAVIOR_UNSPECIFIED 

APPEND
REPLACEB

transition"�
PageInfo9
current_page (	B#�A 
dialogflow.googleapis.com/Page
display_name (	C
	form_info (20.google.cloud.dialogflow.cx.v3.PageInfo.FormInfo�
FormInfoV
parameter_info (2>.google.cloud.dialogflow.cx.v3.PageInfo.FormInfo.ParameterInfo�
ParameterInfo
display_name (	
required (\\
state (2M.google.cloud.dialogflow.cx.v3.PageInfo.FormInfo.ParameterInfo.ParameterState%
value (2.google.protobuf.Value
just_collected ("U
ParameterState
PARAMETER_STATE_UNSPECIFIED 	
EMPTY
INVALID

FILLED"�
SessionInfo7
session (	B&�A#
!dialogflow.googleapis.com/SessionN

parameters (2:.google.cloud.dialogflow.cx.v3.SessionInfo.ParametersEntryI
ParametersEntry
key (	%
value (2.google.protobuf.Value:82�
Webhooks�
ListWebhooks2.google.cloud.dialogflow.cx.v3.ListWebhooksRequest3.google.cloud.dialogflow.cx.v3.ListWebhooksResponse"F���75/v3/{parent=projects/*/locations/*/agents/*}/webhooks�Aparent�

GetWebhook0.google.cloud.dialogflow.cx.v3.GetWebhookRequest&.google.cloud.dialogflow.cx.v3.Webhook"D���75/v3/{name=projects/*/locations/*/agents/*/webhooks/*}�Aname�
CreateWebhook3.google.cloud.dialogflow.cx.v3.CreateWebhookRequest&.google.cloud.dialogflow.cx.v3.Webhook"W���@"5/v3/{parent=projects/*/locations/*/agents/*}/webhooks:webhook�Aparent,webhook�
UpdateWebhook3.google.cloud.dialogflow.cx.v3.UpdateWebhookRequest&.google.cloud.dialogflow.cx.v3.Webhook"d���H2=/v3/{webhook.name=projects/*/locations/*/agents/*/webhooks/*}:webhook�Awebhook,update_mask�
DeleteWebhook3.google.cloud.dialogflow.cx.v3.DeleteWebhookRequest.google.protobuf.Empty"D���7*5/v3/{name=projects/*/locations/*/agents/*/webhooks/*}�Anamex�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
!com.google.cloud.dialogflow.cx.v3BWebhookProtoPZ?google.golang.org/genproto/googleapis/cloud/dialogflow/cx/v3;cx��DF�Google.Cloud.Dialogflow.Cx.V3�!Google::Cloud::Dialogflow::CX::V3�A|
\'servicedirectory.googleapis.com/ServiceQprojects/{project}/locations/{location}/namespaces/{namespace}/services/{service}bproto3'
        , true);

        static::$is_initialized = true;
    }
}

