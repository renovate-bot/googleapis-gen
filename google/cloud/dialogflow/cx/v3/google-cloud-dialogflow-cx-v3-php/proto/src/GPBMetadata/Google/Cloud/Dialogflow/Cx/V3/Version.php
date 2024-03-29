<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/version.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\Cx\V3;

class Version
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
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\EntityType::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Flow::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Intent::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Page::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TransitionRouteGroup::initOnce();
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Webhook::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
� 
+google/cloud/dialogflow/cx/v3/version.protogoogle.cloud.dialogflow.cx.v3google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto/google/cloud/dialogflow/cx/v3/entity_type.proto(google/cloud/dialogflow/cx/v3/flow.proto*google/cloud/dialogflow/cx/v3/intent.proto(google/cloud/dialogflow/cx/v3/page.proto:google/cloud/dialogflow/cx/v3/transition_route_group.proto+google/cloud/dialogflow/cx/v3/webhook.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"Y
CreateVersionOperationMetadata7
version (	B&�A#
!dialogflow.googleapis.com/Version"�
Version
name (	
display_name (	B�A
description (	E
nlu_settings (2*.google.cloud.dialogflow.cx.v3.NluSettingsB�A4
create_time (2.google.protobuf.TimestampB�A@
state (2,.google.cloud.dialogflow.cx.v3.Version.StateB�A"F
State
STATE_UNSPECIFIED 
RUNNING
	SUCCEEDED

FAILED:~�A{
!dialogflow.googleapis.com/VersionVprojects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}"w
ListVersionsRequest9
parent (	B)�A�A#!dialogflow.googleapis.com/Version
	page_size (

page_token (	"i
ListVersionsResponse8
versions (2&.google.cloud.dialogflow.cx.v3.Version
next_page_token (	"L
GetVersionRequest7
name (	B)�A�A#
!dialogflow.googleapis.com/Version"�
CreateVersionRequest9
parent (	B)�A�A#!dialogflow.googleapis.com/Version<
version (2&.google.cloud.dialogflow.cx.v3.VersionB�A"�
UpdateVersionRequest<
version (2&.google.cloud.dialogflow.cx.v3.VersionB�A4
update_mask (2.google.protobuf.FieldMaskB�A"O
DeleteVersionRequest7
name (	B)�A�A#
!dialogflow.googleapis.com/Version"u
LoadVersionRequest7
name (	B)�A�A#
!dialogflow.googleapis.com/Version&
allow_override_agent_resources ("�
CompareVersionsRequest?
base_version (	B)�A�A#
!dialogflow.googleapis.com/VersionA
target_version (	B)�A�A#
!dialogflow.googleapis.com/Version
language_code (	"�
CompareVersionsResponse!
base_version_content_json (	#
target_version_content_json (	0
compare_time (2.google.protobuf.Timestamp2�
Versions�
ListVersions2.google.cloud.dialogflow.cx.v3.ListVersionsRequest3.google.cloud.dialogflow.cx.v3.ListVersionsResponse"N���?=/v3/{parent=projects/*/locations/*/agents/*/flows/*}/versions�Aparent�

GetVersion0.google.cloud.dialogflow.cx.v3.GetVersionRequest&.google.cloud.dialogflow.cx.v3.Version"L���?=/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}�Aname�
CreateVersion3.google.cloud.dialogflow.cx.v3.CreateVersionRequest.google.longrunning.Operation"����H"=/v3/{parent=projects/*/locations/*/agents/*/flows/*}/versions:version�Aparent,version�A)
VersionCreateVersionOperationMetadata�
UpdateVersion3.google.cloud.dialogflow.cx.v3.UpdateVersionRequest&.google.cloud.dialogflow.cx.v3.Version"l���P2E/v3/{version.name=projects/*/locations/*/agents/*/flows/*/versions/*}:version�Aversion,update_mask�
DeleteVersion3.google.cloud.dialogflow.cx.v3.DeleteVersionRequest.google.protobuf.Empty"L���?*=/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}�Aname�
LoadVersion1.google.cloud.dialogflow.cx.v3.LoadVersionRequest.google.longrunning.Operation"����G"B/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}:load:*�Aname�A/
google.protobuf.Emptygoogle.protobuf.Struct�
CompareVersions5.google.cloud.dialogflow.cx.v3.CompareVersionsRequest6.google.cloud.dialogflow.cx.v3.CompareVersionsResponse"o���Z"U/v3/{base_version=projects/*/locations/*/agents/*/flows/*/versions/*}:compareVersions:*�Abase_versionx�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
!com.google.cloud.dialogflow.cx.v3BVersionProtoPZ?google.golang.org/genproto/googleapis/cloud/dialogflow/cx/v3;cx��DF�Google.Cloud.Dialogflow.Cx.V3�!Google::Cloud::Dialogflow::CX::V3bproto3'
        , true);

        static::$is_initialized = true;
    }
}

