<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/intent.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\Cx\V3;

class Intent
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
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
*google/cloud/dialogflow/cx/v3/intent.protogoogle.cloud.dialogflow.cx.v3google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"�
Intent
name (	
display_name (	B�AN
training_phrases (24.google.cloud.dialogflow.cx.v3.Intent.TrainingPhraseC

parameters (2/.google.cloud.dialogflow.cx.v3.Intent.Parameter
priority (
is_fallback (A
labels (21.google.cloud.dialogflow.cx.v3.Intent.LabelsEntry
description (	�
TrainingPhrase

id (	M
parts (29.google.cloud.dialogflow.cx.v3.Intent.TrainingPhrase.PartB�A
repeat_count (/
Part
text (	B�A
parameter_id (	�
	Parameter
id (	B�AA
entity_type (	B,�A�A&
$dialogflow.googleapis.com/EntityType
is_list (
redact (-
LabelsEntry
key (	
value (	:8:n�Ak
 dialogflow.googleapis.com/IntentGprojects/{project}/locations/{location}/agents/{agent}/intents/{intent}"�
ListIntentsRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent
language_code (	>
intent_view (2).google.cloud.dialogflow.cx.v3.IntentView
	page_size (

page_token (	"f
ListIntentsResponse6
intents (2%.google.cloud.dialogflow.cx.v3.Intent
next_page_token (	"a
GetIntentRequest6
name (	B(�A�A"
 dialogflow.googleapis.com/Intent
language_code (	"�
CreateIntentRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent:
intent (2%.google.cloud.dialogflow.cx.v3.IntentB�A
language_code (	"�
UpdateIntentRequest:
intent (2%.google.cloud.dialogflow.cx.v3.IntentB�A
language_code (	/
update_mask (2.google.protobuf.FieldMask"M
DeleteIntentRequest6
name (	B(�A�A"
 dialogflow.googleapis.com/Intent*X

IntentView
INTENT_VIEW_UNSPECIFIED 
INTENT_VIEW_PARTIAL
INTENT_VIEW_FULL2�
Intents�
ListIntents1.google.cloud.dialogflow.cx.v3.ListIntentsRequest2.google.cloud.dialogflow.cx.v3.ListIntentsResponse"E���64/v3/{parent=projects/*/locations/*/agents/*}/intents�Aparent�
	GetIntent/.google.cloud.dialogflow.cx.v3.GetIntentRequest%.google.cloud.dialogflow.cx.v3.Intent"C���64/v3/{name=projects/*/locations/*/agents/*/intents/*}�Aname�
CreateIntent2.google.cloud.dialogflow.cx.v3.CreateIntentRequest%.google.cloud.dialogflow.cx.v3.Intent"T���>"4/v3/{parent=projects/*/locations/*/agents/*}/intents:intent�Aparent,intent�
UpdateIntent2.google.cloud.dialogflow.cx.v3.UpdateIntentRequest%.google.cloud.dialogflow.cx.v3.Intent"`���E2;/v3/{intent.name=projects/*/locations/*/agents/*/intents/*}:intent�Aintent,update_mask�
DeleteIntent2.google.cloud.dialogflow.cx.v3.DeleteIntentRequest.google.protobuf.Empty"C���6*4/v3/{name=projects/*/locations/*/agents/*/intents/*}�Anamex�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
!com.google.cloud.dialogflow.cx.v3BIntentProtoPZ?google.golang.org/genproto/googleapis/cloud/dialogflow/cx/v3;cx��DF�Google.Cloud.Dialogflow.Cx.V3�!Google::Cloud::Dialogflow::CX::V3bproto3'
        , true);

        static::$is_initialized = true;
    }
}

