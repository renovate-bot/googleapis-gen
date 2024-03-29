<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/intent.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1;

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
�
/google/cloud/dialogflow/cx/v3beta1/intent.proto"google.cloud.dialogflow.cx.v3beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"�
Intent
name (	
display_name (	B�AS
training_phrases (29.google.cloud.dialogflow.cx.v3beta1.Intent.TrainingPhraseH

parameters (24.google.cloud.dialogflow.cx.v3beta1.Intent.Parameter
priority (
is_fallback (F
labels (26.google.cloud.dialogflow.cx.v3beta1.Intent.LabelsEntry
description (	�
TrainingPhrase

id (	R
parts (2>.google.cloud.dialogflow.cx.v3beta1.Intent.TrainingPhrase.PartB�A
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
language_code (	C
intent_view (2..google.cloud.dialogflow.cx.v3beta1.IntentView
	page_size (

page_token (	"k
ListIntentsResponse;
intents (2*.google.cloud.dialogflow.cx.v3beta1.Intent
next_page_token (	"a
GetIntentRequest6
name (	B(�A�A"
 dialogflow.googleapis.com/Intent
language_code (	"�
CreateIntentRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent?
intent (2*.google.cloud.dialogflow.cx.v3beta1.IntentB�A
language_code (	"�
UpdateIntentRequest?
intent (2*.google.cloud.dialogflow.cx.v3beta1.IntentB�A
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
ListIntents6.google.cloud.dialogflow.cx.v3beta1.ListIntentsRequest7.google.cloud.dialogflow.cx.v3beta1.ListIntentsResponse"J���;9/v3beta1/{parent=projects/*/locations/*/agents/*}/intents�Aparent�
	GetIntent4.google.cloud.dialogflow.cx.v3beta1.GetIntentRequest*.google.cloud.dialogflow.cx.v3beta1.Intent"H���;9/v3beta1/{name=projects/*/locations/*/agents/*/intents/*}�Aname�
CreateIntent7.google.cloud.dialogflow.cx.v3beta1.CreateIntentRequest*.google.cloud.dialogflow.cx.v3beta1.Intent"Y���C"9/v3beta1/{parent=projects/*/locations/*/agents/*}/intents:intent�Aparent,intent�
UpdateIntent7.google.cloud.dialogflow.cx.v3beta1.UpdateIntentRequest*.google.cloud.dialogflow.cx.v3beta1.Intent"e���J2@/v3beta1/{intent.name=projects/*/locations/*/agents/*/intents/*}:intent�Aintent,update_mask�
DeleteIntent7.google.cloud.dialogflow.cx.v3beta1.DeleteIntentRequest.google.protobuf.Empty"H���;*9/v3beta1/{name=projects/*/locations/*/agents/*/intents/*}�Anamex�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
&com.google.cloud.dialogflow.cx.v3beta1BIntentProtoPZDgoogle.golang.org/genproto/googleapis/cloud/dialogflow/cx/v3beta1;cx��DF�"Google.Cloud.Dialogflow.Cx.V3Beta1�&Google::Cloud::Dialogflow::CX::V3beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

