<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/intent.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\V2Beta1;

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
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\AudioConfig::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Context::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        $pool->internalAddGeneratedFile(
            '
�s
,google/cloud/dialogflow/v2beta1/intent.protogoogle.cloud.dialogflow.v2beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto2google/cloud/dialogflow/v2beta1/audio_config.proto-google/cloud/dialogflow/v2beta1/context.proto#google/longrunning/operations.protogoogle/protobuf/duration.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/struct.proto"�N
Intent
name (	B�A
display_name (	B�AP
webhook_state (24.google.cloud.dialogflow.v2beta1.Intent.WebhookStateB�A
priority (B�A
is_fallback (B�A

ml_enabled (B�A
ml_disabled (B�A
end_interaction (B�A 
input_context_names (	B�A
events (	B�AU
training_phrases	 (26.google.cloud.dialogflow.v2beta1.Intent.TrainingPhraseB�A
action
 (	B�AF
output_contexts (2(.google.cloud.dialogflow.v2beta1.ContextB�A
reset_contexts (B�AJ

parameters (21.google.cloud.dialogflow.v2beta1.Intent.ParameterB�AA
messages (2/.google.cloud.dialogflow.v2beta1.Intent.Messagea
default_response_platforms (28.google.cloud.dialogflow.v2beta1.Intent.Message.PlatformB�A&
root_followup_intent_name (	B�A(
parent_followup_intent_name (	B�A]
followup_intent_info (2:.google.cloud.dialogflow.v2beta1.Intent.FollowupIntentInfoB�A�
TrainingPhrase
name (	N
type (2;.google.cloud.dialogflow.v2beta1.Intent.TrainingPhrase.TypeB�AO
parts (2;.google.cloud.dialogflow.v2beta1.Intent.TrainingPhrase.PartB�A
times_added_count (B�AN
Part
text (	
entity_type (	
alias (	
user_defined (";
Type
TYPE_UNSPECIFIED 
EXAMPLE
TEMPLATE�
	Parameter
name (	
display_name (	
value (	
default_value (	 
entity_type_display_name (	
	mandatory (
prompts (	
is_list (�@
MessageD
text (24.google.cloud.dialogflow.v2beta1.Intent.Message.TextH F
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.ImageH U
quick_replies (2<.google.cloud.dialogflow.v2beta1.Intent.Message.QuickRepliesH D
card (24.google.cloud.dialogflow.v2beta1.Intent.Message.CardH *
payload (2.google.protobuf.StructH [
simple_responses (2?.google.cloud.dialogflow.v2beta1.Intent.Message.SimpleResponsesH O

basic_card (29.google.cloud.dialogflow.v2beta1.Intent.Message.BasicCardH R
suggestions	 (2;.google.cloud.dialogflow.v2beta1.Intent.Message.SuggestionsH `
link_out_suggestion
 (2A.google.cloud.dialogflow.v2beta1.Intent.Message.LinkOutSuggestionH Q
list_select (2:.google.cloud.dialogflow.v2beta1.Intent.Message.ListSelectH Y
carousel_select (2>.google.cloud.dialogflow.v2beta1.Intent.Message.CarouselSelectH b
telephony_play_audio (2B.google.cloud.dialogflow.v2beta1.Intent.Message.TelephonyPlayAudioH p
telephony_synthesize_speech (2I.google.cloud.dialogflow.v2beta1.Intent.Message.TelephonySynthesizeSpeechH h
telephony_transfer_call (2E.google.cloud.dialogflow.v2beta1.Intent.Message.TelephonyTransferCallH K
rbm_text (27.google.cloud.dialogflow.v2beta1.Intent.Message.RbmTextH e
rbm_standalone_rich_card (2A.google.cloud.dialogflow.v2beta1.Intent.Message.RbmStandaloneCardH a
rbm_carousel_rich_card (2?.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCarouselCardH b
browse_carousel_card (2B.google.cloud.dialogflow.v2beta1.Intent.Message.BrowseCarouselCardH O

table_card (29.google.cloud.dialogflow.v2beta1.Intent.Message.TableCardH U
media_content (2<.google.cloud.dialogflow.v2beta1.Intent.Message.MediaContentH O
platform (28.google.cloud.dialogflow.v2beta1.Intent.Message.PlatformB�A
Text
text (	6
Image
	image_uri (	
accessibility_text (	4
QuickReplies
title (	
quick_replies (	�
Card
title (	
subtitle (	
	image_uri (	L
buttons (2;.google.cloud.dialogflow.v2beta1.Intent.Message.Card.Button(
Button
text (	
postback (	L
SimpleResponse
text_to_speech (	
ssml (	
display_text (	k
SimpleResponsesX
simple_responses (2>.google.cloud.dialogflow.v2beta1.Intent.Message.SimpleResponse�
	BasicCard
title (	
subtitle (	
formatted_text (	D
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.ImageQ
buttons (2@.google.cloud.dialogflow.v2beta1.Intent.Message.BasicCard.Button�
Button
title (	g
open_uri_action (2N.google.cloud.dialogflow.v2beta1.Intent.Message.BasicCard.Button.OpenUriAction
OpenUriAction
uri (	

Suggestion
title (	^
SuggestionsO
suggestions (2:.google.cloud.dialogflow.v2beta1.Intent.Message.Suggestion:
LinkOutSuggestion
destination_name (	
uri (	�

ListSelect
title (	N
items (2?.google.cloud.dialogflow.v2beta1.Intent.Message.ListSelect.Item
subtitle (	B�A�
ItemL
info (2>.google.cloud.dialogflow.v2beta1.Intent.Message.SelectItemInfo
title (	
description (	D
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.Image�
CarouselSelectR
items (2C.google.cloud.dialogflow.v2beta1.Intent.Message.CarouselSelect.Item�
ItemL
info (2>.google.cloud.dialogflow.v2beta1.Intent.Message.SelectItemInfo
title (	
description (	D
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.Image/
SelectItemInfo
key (	
synonyms (	\'
TelephonyPlayAudio
	audio_uri (	E
TelephonySynthesizeSpeech
text (	H 
ssml (	H B
source-
TelephonyTransferCall
phone_number (	n
RbmText
text (	U
rbm_suggestion (2=.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestion�
RbmCarouselCard]

card_width (2I.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCarouselCard.CardWidthU
card_contents (2>.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCardContent">
	CardWidth
CARD_WIDTH_UNSPECIFIED 	
SMALL

MEDIUM�
RbmStandaloneCardk
card_orientation (2Q.google.cloud.dialogflow.v2beta1.Intent.Message.RbmStandaloneCard.CardOrientation|
thumbnail_image_alignment (2Y.google.cloud.dialogflow.v2beta1.Intent.Message.RbmStandaloneCard.ThumbnailImageAlignmentT
card_content (2>.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCardContent"Q
CardOrientation 
CARD_ORIENTATION_UNSPECIFIED 

HORIZONTAL
VERTICAL"Y
ThumbnailImageAlignment)
%THUMBNAIL_IMAGE_ALIGNMENT_UNSPECIFIED 
LEFT	
RIGHT�
RbmCardContent
title (	
description (	V
media (2G.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCardContent.RbmMediaR
suggestions (2=.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestion�
RbmMedia
file_uri (	
thumbnail_uri (	^
height (2N.google.cloud.dialogflow.v2beta1.Intent.Message.RbmCardContent.RbmMedia.Height"A
Height
HEIGHT_UNSPECIFIED 	
SHORT

MEDIUM
TALL�
RbmSuggestionR
reply (2A.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestedReplyH T
action (2B.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestedActionH B

suggestion8
RbmSuggestedReply
text (	
postback_data (	�
RbmSuggestedAction
text (	
postback_data (	i
dial (2Y.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestedAction.RbmSuggestedActionDialH p
open_url (2\\.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestedAction.RbmSuggestedActionOpenUriH |
share_location (2b.google.cloud.dialogflow.v2beta1.Intent.Message.RbmSuggestedAction.RbmSuggestedActionShareLocationH .
RbmSuggestedActionDial
phone_number (	(
RbmSuggestedActionOpenUri
uri (	!
RbmSuggestedActionShareLocationB
action�
MediaContentb

media_type (2N.google.cloud.dialogflow.v2beta1.Intent.Message.MediaContent.ResponseMediaTypeg
media_objects (2P.google.cloud.dialogflow.v2beta1.Intent.Message.MediaContent.ResponseMediaObject�
ResponseMediaObject
name (	
description (	L
large_image (25.google.cloud.dialogflow.v2beta1.Intent.Message.ImageH E
icon (25.google.cloud.dialogflow.v2beta1.Intent.Message.ImageH 
content_url (	B
image"C
ResponseMediaType#
RESPONSE_MEDIA_TYPE_UNSPECIFIED 	
AUDIO�
BrowseCarouselCardh
items (2Y.google.cloud.dialogflow.v2beta1.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItemu
image_display_options (2V.google.cloud.dialogflow.v2beta1.Intent.Message.BrowseCarouselCard.ImageDisplayOptions�
BrowseCarouselCardItem�
open_uri_action (2g.google.cloud.dialogflow.v2beta1.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem.OpenUrlAction
title (	
description (	D
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.Image
footer (	�
OpenUrlAction
url (	�
url_type_hint (2s.google.cloud.dialogflow.v2beta1.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem.OpenUrlAction.UrlTypeHint"M
UrlTypeHint
URL_TYPE_HINT_UNSPECIFIED 

AMP_ACTION
AMP_CONTENT"v
ImageDisplayOptions%
!IMAGE_DISPLAY_OPTIONS_UNSPECIFIED 
GRAY	
WHITE
CROPPED
BLURRED_BACKGROUND�
	TableCard
title (	
subtitle (	D
image (25.google.cloud.dialogflow.v2beta1.Intent.Message.Image[
column_properties (2@.google.cloud.dialogflow.v2beta1.Intent.Message.ColumnPropertiesJ
rows (2<.google.cloud.dialogflow.v2beta1.Intent.Message.TableCardRowQ
buttons (2@.google.cloud.dialogflow.v2beta1.Intent.Message.BasicCard.Button�
ColumnProperties
header (	r
horizontal_alignment (2T.google.cloud.dialogflow.v2beta1.Intent.Message.ColumnProperties.HorizontalAlignment"b
HorizontalAlignment$
 HORIZONTAL_ALIGNMENT_UNSPECIFIED 
LEADING

CENTER
TRAILINGs
TableCardRowL
cells (2=.google.cloud.dialogflow.v2beta1.Intent.Message.TableCardCell
divider_after (
TableCardCell
text (	"�
Platform
PLATFORM_UNSPECIFIED 
FACEBOOK	
SLACK
TELEGRAM
KIK	
SKYPE
LINE	
VIBER
ACTIONS_ON_GOOGLE
	TELEPHONY

GOOGLE_HANGOUTSB	
messageW
FollowupIntentInfo
followup_intent_name (	#
parent_followup_intent_name (	"t
WebhookState
WEBHOOK_STATE_UNSPECIFIED 
WEBHOOK_STATE_ENABLED*
&WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING:��A�
 dialogflow.googleapis.com/Intent)projects/{project}/agent/intents/{intent}>projects/{project}/locations/{location}/agent/intents/{intent}"�
ListIntentsRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent
language_code (	B�A@
intent_view (2+.google.cloud.dialogflow.v2beta1.IntentView
	page_size (

page_token (	"h
ListIntentsResponse8
intents (2\'.google.cloud.dialogflow.v2beta1.Intent
next_page_token (	"�
GetIntentRequest6
name (	B(�A�A"
 dialogflow.googleapis.com/Intent
language_code (	B�A@
intent_view (2+.google.cloud.dialogflow.v2beta1.IntentView"�
CreateIntentRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent<
intent (2\'.google.cloud.dialogflow.v2beta1.IntentB�A
language_code (	B�A@
intent_view (2+.google.cloud.dialogflow.v2beta1.IntentView"�
UpdateIntentRequest<
intent (2\'.google.cloud.dialogflow.v2beta1.IntentB�A
language_code (	B�A/
update_mask (2.google.protobuf.FieldMask@
intent_view (2+.google.cloud.dialogflow.v2beta1.IntentView"M
DeleteIntentRequest6
name (	B(�A�A"
 dialogflow.googleapis.com/Intent"�
BatchUpdateIntentsRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent
intent_batch_uri (	H K
intent_batch_inline (2,.google.cloud.dialogflow.v2beta1.IntentBatchH 
language_code (	B�A/
update_mask (2.google.protobuf.FieldMask@
intent_view (2+.google.cloud.dialogflow.v2beta1.IntentViewB
intent_batch"V
BatchUpdateIntentsResponse8
intents (2\'.google.cloud.dialogflow.v2beta1.Intent"�
BatchDeleteIntentsRequest8
parent (	B(�A�A" dialogflow.googleapis.com/Intent=
intents (2\'.google.cloud.dialogflow.v2beta1.IntentB�A"G
IntentBatch8
intents (2\'.google.cloud.dialogflow.v2beta1.Intent*?

IntentView
INTENT_VIEW_UNSPECIFIED 
INTENT_VIEW_FULL2�
Intents�
ListIntents3.google.cloud.dialogflow.v2beta1.ListIntentsRequest4.google.cloud.dialogflow.v2beta1.ListIntentsResponse"�����*/v2beta1/{parent=projects/*/agent}/intentsZ86/v2beta1/{parent=projects/*/locations/*/agent}/intentsZ;9/v2beta1/{parent=projects/*/agent/environments/*}/intents�Aparent�Aparent,language_code�
	GetIntent1.google.cloud.dialogflow.v2beta1.GetIntentRequest\'.google.cloud.dialogflow.v2beta1.Intent"����f*/v2beta1/{name=projects/*/agent/intents/*}Z86/v2beta1/{name=projects/*/locations/*/agent/intents/*}�Aname�Aname,language_code�
CreateIntent4.google.cloud.dialogflow.v2beta1.CreateIntentRequest\'.google.cloud.dialogflow.v2beta1.Intent"����v"*/v2beta1/{parent=projects/*/agent}/intents:intentZ@"6/v2beta1/{parent=projects/*/locations/*/agent}/intents:intent�Aparent,intent�Aparent,intent,language_code�
UpdateIntent4.google.cloud.dialogflow.v2beta1.UpdateIntentRequest\'.google.cloud.dialogflow.v2beta1.Intent"�����21/v2beta1/{intent.name=projects/*/agent/intents/*}:intentZG2=/v2beta1/{intent.name=projects/*/locations/*/agent/intents/*}:intent�Aintent,update_mask�Aintent�Aintent,language_code�A intent,language_code,update_mask�
DeleteIntent4.google.cloud.dialogflow.v2beta1.DeleteIntentRequest.google.protobuf.Empty"s���f**/v2beta1/{name=projects/*/agent/intents/*}Z8*6/v2beta1/{name=projects/*/locations/*/agent/intents/*}�Aname�
BatchUpdateIntents:.google.cloud.dialogflow.v2beta1.BatchUpdateIntentsRequest.google.longrunning.Operation"�����"6/v2beta1/{parent=projects/*/agent}/intents:batchUpdate:*ZG"B/v2beta1/{parent=projects/*/locations/*/agent}/intents:batchUpdate:*�Aparent,intent_batch_uri�Aparent,intent_batch_inline�AT
:google.cloud.dialogflow.v2beta1.BatchUpdateIntentsResponsegoogle.protobuf.Struct�
BatchDeleteIntents:.google.cloud.dialogflow.v2beta1.BatchDeleteIntentsRequest.google.longrunning.Operation"�����"6/v2beta1/{parent=projects/*/agent}/intents:batchDelete:*ZG"B/v2beta1/{parent=projects/*/locations/*/agent}/intents:batchDelete:*�Aparent,intents�A/
google.protobuf.Emptygoogle.protobuf.Structx�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
#com.google.cloud.dialogflow.v2beta1BIntentProtoPZIgoogle.golang.org/genproto/googleapis/cloud/dialogflow/v2beta1;dialogflow��DF�Google.Cloud.Dialogflow.V2beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

