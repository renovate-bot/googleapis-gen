<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/environment.proto

namespace GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1;

class Environment
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
�
4google/cloud/dialogflow/cx/v3beta1/environment.proto"google.cloud.dialogflow.cx.v3beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"�
Environment
name (	
display_name (	B�A
description (	[
version_configs (2=.google.cloud.dialogflow.cx.v3beta1.Environment.VersionConfigB�A4
update_time (2.google.protobuf.TimestampB�AK

version (	B)�A�A#
!dialogflow.googleapis.com/Version:}�Az
%dialogflow.googleapis.com/EnvironmentQprojects/{project}/locations/{location}/agents/{agent}/environments/{environment}"
ListEnvironmentsRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/Environment
	page_size (

page_token (	"z
ListEnvironmentsResponseE
environments (2/.google.cloud.dialogflow.cx.v3beta1.Environment
next_page_token (	"T
GetEnvironmentRequest;
name (	B-�A�A\'
%dialogflow.googleapis.com/Environment"�
CreateEnvironmentRequest=
parent (	B-�A�A\'%dialogflow.googleapis.com/EnvironmentI
environment (2/.google.cloud.dialogflow.cx.v3beta1.EnvironmentB�A"�
UpdateEnvironmentRequestI
environment (2/.google.cloud.dialogflow.cx.v3beta1.EnvironmentB�A4
update_mask (2.google.protobuf.FieldMaskB�A"W
DeleteEnvironmentRequest;
name (	B-�A�A\'
%dialogflow.googleapis.com/Environment"�
LookupEnvironmentHistoryRequest;
name (	B-�A�A\'
%dialogflow.googleapis.com/Environment
	page_size (

page_token (	"�
 LookupEnvironmentHistoryResponseE
environments (2/.google.cloud.dialogflow.cx.v3beta1.Environment
next_page_token (	2�
Environments�
ListEnvironments;.google.cloud.dialogflow.cx.v3beta1.ListEnvironmentsRequest<.google.cloud.dialogflow.cx.v3beta1.ListEnvironmentsResponse"O���@>/v3beta1/{parent=projects/*/locations/*/agents/*}/environments�Aparent�
GetEnvironment9.google.cloud.dialogflow.cx.v3beta1.GetEnvironmentRequest/.google.cloud.dialogflow.cx.v3beta1.Environment"M���@>/v3beta1/{name=projects/*/locations/*/agents/*/environments/*}�Aname�
CreateEnvironment<.google.cloud.dialogflow.cx.v3beta1.CreateEnvironmentRequest.google.longrunning.Operation"����M">/v3beta1/{parent=projects/*/locations/*/agents/*}/environments:environment�Aparent,environment�A%
Environmentgoogle.protobuf.Struct�
UpdateEnvironment<.google.cloud.dialogflow.cx.v3beta1.UpdateEnvironmentRequest.google.longrunning.Operation"����Y2J/v3beta1/{environment.name=projects/*/locations/*/agents/*/environments/*}:environment�Aenvironment,update_mask�A%
Environmentgoogle.protobuf.Struct�
DeleteEnvironment<.google.cloud.dialogflow.cx.v3beta1.DeleteEnvironmentRequest.google.protobuf.Empty"M���@*>/v3beta1/{name=projects/*/locations/*/agents/*/environments/*}�Aname�
LookupEnvironmentHistoryC.google.cloud.dialogflow.cx.v3beta1.LookupEnvironmentHistoryRequestD.google.cloud.dialogflow.cx.v3beta1.LookupEnvironmentHistoryResponse"f���YW/v3beta1/{name=projects/*/locations/*/agents/*/environments/*}:lookupEnvironmentHistory�Anamex�Adialogflow.googleapis.com�AYhttps://www.googleapis.com/auth/cloud-platform,https://www.googleapis.com/auth/dialogflowB�
&com.google.cloud.dialogflow.cx.v3beta1BEnvironmentProtoPZDgoogle.golang.org/genproto/googleapis/cloud/dialogflow/cx/v3beta1;cx��DF�"Google.Cloud.Dialogflow.Cx.V3Beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}
