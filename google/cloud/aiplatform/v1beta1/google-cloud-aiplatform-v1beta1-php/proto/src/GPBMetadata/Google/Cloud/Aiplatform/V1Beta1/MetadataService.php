<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/metadata_service.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1Beta1;

class MetadataService
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
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Artifact::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Context::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Event::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Execution::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\LineageSubgraph::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\MetadataSchema::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\MetadataStore::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Operation::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        $pool->internalAddGeneratedFile(
            '
�p
6google/cloud/aiplatform/v1beta1/metadata_service.protogoogle.cloud.aiplatform.v1beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto.google/cloud/aiplatform/v1beta1/artifact.proto-google/cloud/aiplatform/v1beta1/context.proto+google/cloud/aiplatform/v1beta1/event.proto/google/cloud/aiplatform/v1beta1/execution.proto6google/cloud/aiplatform/v1beta1/lineage_subgraph.proto5google/cloud/aiplatform/v1beta1/metadata_schema.proto4google/cloud/aiplatform/v1beta1/metadata_store.proto/google/cloud/aiplatform/v1beta1/operation.proto#google/longrunning/operations.proto google/protobuf/field_mask.proto"�
CreateMetadataStoreRequest9
parent (	B)�A�A#
!locations.googleapis.com/LocationK
metadata_store (2..google.cloud.aiplatform.v1beta1.MetadataStoreB�A
metadata_store_id (	"{
$CreateMetadataStoreOperationMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"X
GetMetadataStoreRequest=
name (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStore"}
ListMetadataStoresRequest9
parent (	B)�A�A#
!locations.googleapis.com/Location
	page_size (

page_token (	"~
ListMetadataStoresResponseG
metadata_stores (2..google.cloud.aiplatform.v1beta1.MetadataStore
next_page_token (	"n
DeleteMetadataStoreRequest=
name (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStore
force (B"{
$DeleteMetadataStoreOperationMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"�
CreateArtifactRequest?
parent (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStore@
artifact (2).google.cloud.aiplatform.v1beta1.ArtifactB�A
artifact_id (	"N
GetArtifactRequest8
name (	B*�A�A$
"aiplatform.googleapis.com/Artifact"�
ListArtifactsRequest:
parent (	B*�A�A$"aiplatform.googleapis.com/Artifact
	page_size (

page_token (	
filter (	"n
ListArtifactsResponse<
	artifacts (2).google.cloud.aiplatform.v1beta1.Artifact
next_page_token (	"�
UpdateArtifactRequest@
artifact (2).google.cloud.aiplatform.v1beta1.ArtifactB�A4
update_mask (2.google.protobuf.FieldMaskB�A
allow_missing ("d
DeleteArtifactRequest8
name (	B*�A�A$
"aiplatform.googleapis.com/Artifact
etag (	B�A"|
PurgeArtifactsRequest:
parent (	B*�A�A$"aiplatform.googleapis.com/Artifact
filter (	B�A
force (B�A"l
PurgeArtifactsResponse
purge_count (=
purge_sample (	B\'�A$
"aiplatform.googleapis.com/Artifact"m
PurgeArtifactsMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"�
CreateContextRequest?
parent (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStore>
context (2(.google.cloud.aiplatform.v1beta1.ContextB�A

context_id (	"L
GetContextRequest7
name (	B)�A�A#
!aiplatform.googleapis.com/Context"�
ListContextsRequest9
parent (	B)�A�A#!aiplatform.googleapis.com/Context
	page_size (

page_token (	
filter (	"k
ListContextsResponse:
contexts (2(.google.cloud.aiplatform.v1beta1.Context
next_page_token (	"�
UpdateContextRequest>
context (2(.google.cloud.aiplatform.v1beta1.ContextB�A4
update_mask (2.google.protobuf.FieldMaskB�A
allow_missing ("q
DeleteContextRequest7
name (	B)�A�A#
!aiplatform.googleapis.com/Context
force (
etag (	B�A"z
PurgeContextsRequest9
parent (	B)�A�A#!aiplatform.googleapis.com/Context
filter (	B�A
force (B�A"j
PurgeContextsResponse
purge_count (<
purge_sample (	B&�A#
!aiplatform.googleapis.com/Context"l
PurgeContextsMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"�
\'AddContextArtifactsAndExecutionsRequest:
context (	B)�A�A#
!aiplatform.googleapis.com/Context:
	artifacts (	B\'�A$
"aiplatform.googleapis.com/Artifact<

executions (	B(�A%
#aiplatform.googleapis.com/Execution"*
(AddContextArtifactsAndExecutionsResponse"�
AddContextChildrenRequest:
context (	B)�A�A#
!aiplatform.googleapis.com/Context>
child_contexts (	B&�A#
!aiplatform.googleapis.com/Context"
AddContextChildrenResponse"`
"QueryContextLineageSubgraphRequest:
context (	B)�A�A#
!aiplatform.googleapis.com/Context"�
CreateExecutionRequest?
parent (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStoreB
	execution (2*.google.cloud.aiplatform.v1beta1.ExecutionB�A
execution_id (	"P
GetExecutionRequest9
name (	B+�A�A%
#aiplatform.googleapis.com/Execution"�
ListExecutionsRequest;
parent (	B+�A�A%#aiplatform.googleapis.com/Execution
	page_size (

page_token (	
filter (	"q
ListExecutionsResponse>

executions (2*.google.cloud.aiplatform.v1beta1.Execution
next_page_token (	"�
UpdateExecutionRequestB
	execution (2*.google.cloud.aiplatform.v1beta1.ExecutionB�A4
update_mask (2.google.protobuf.FieldMaskB�A
allow_missing ("f
DeleteExecutionRequest9
name (	B+�A�A%
#aiplatform.googleapis.com/Execution
etag (	B�A"~
PurgeExecutionsRequest;
parent (	B+�A�A%#aiplatform.googleapis.com/Execution
filter (	B�A
force (B�A"n
PurgeExecutionsResponse
purge_count (>
purge_sample (	B(�A%
#aiplatform.googleapis.com/Execution"n
PurgeExecutionsMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"�
AddExecutionEventsRequest>
	execution (	B+�A�A%
#aiplatform.googleapis.com/Execution6
events (2&.google.cloud.aiplatform.v1beta1.Event"
AddExecutionEventsResponse"g
%QueryExecutionInputsAndOutputsRequest>
	execution (	B+�A�A%
#aiplatform.googleapis.com/Execution"�
CreateMetadataSchemaRequest?
parent (	B/�A�A)
\'aiplatform.googleapis.com/MetadataStoreM
metadata_schema (2/.google.cloud.aiplatform.v1beta1.MetadataSchemaB�A
metadata_schema_id (	"Z
GetMetadataSchemaRequest>
name (	B0�A�A*
(aiplatform.googleapis.com/MetadataSchema"�
ListMetadataSchemasRequest@
parent (	B0�A�A*(aiplatform.googleapis.com/MetadataSchema
	page_size (

page_token (	
filter (	"�
ListMetadataSchemasResponseI
metadata_schemas (2/.google.cloud.aiplatform.v1beta1.MetadataSchema
next_page_token (	"�
#QueryArtifactLineageSubgraphRequest<
artifact (	B*�A�A$
"aiplatform.googleapis.com/Artifact
max_hops (
filter (	2�;
MetadataService�
CreateMetadataStore;.google.cloud.aiplatform.v1beta1.CreateMetadataStoreRequest.google.longrunning.Operation"����I"7/v1beta1/{parent=projects/*/locations/*}/metadataStores:metadata_store�A\'parent,metadata_store,metadata_store_id�A5
MetadataStore$CreateMetadataStoreOperationMetadata�
GetMetadataStore8.google.cloud.aiplatform.v1beta1.GetMetadataStoreRequest..google.cloud.aiplatform.v1beta1.MetadataStore"F���97/v1beta1/{name=projects/*/locations/*/metadataStores/*}�Aname�
ListMetadataStores:.google.cloud.aiplatform.v1beta1.ListMetadataStoresRequest;.google.cloud.aiplatform.v1beta1.ListMetadataStoresResponse"H���97/v1beta1/{parent=projects/*/locations/*}/metadataStores�Aparent�
DeleteMetadataStore;.google.cloud.aiplatform.v1beta1.DeleteMetadataStoreRequest.google.longrunning.Operation"����9*7/v1beta1/{name=projects/*/locations/*/metadataStores/*}�Aname�A=
google.protobuf.Empty$DeleteMetadataStoreOperationMetadata�
CreateArtifact6.google.cloud.aiplatform.v1beta1.CreateArtifactRequest).google.cloud.aiplatform.v1beta1.Artifact"s���O"C/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/artifacts:artifact�Aparent,artifact,artifact_id�
GetArtifact3.google.cloud.aiplatform.v1beta1.GetArtifactRequest).google.cloud.aiplatform.v1beta1.Artifact"R���EC/v1beta1/{name=projects/*/locations/*/metadataStores/*/artifacts/*}�Aname�
ListArtifacts5.google.cloud.aiplatform.v1beta1.ListArtifactsRequest6.google.cloud.aiplatform.v1beta1.ListArtifactsResponse"T���EC/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/artifacts�Aparent�
UpdateArtifact6.google.cloud.aiplatform.v1beta1.UpdateArtifactRequest).google.cloud.aiplatform.v1beta1.Artifact"u���X2L/v1beta1/{artifact.name=projects/*/locations/*/metadataStores/*/artifacts/*}:artifact�Aartifact,update_mask�
DeleteArtifact6.google.cloud.aiplatform.v1beta1.DeleteArtifactRequest.google.longrunning.Operation"����E*C/v1beta1/{name=projects/*/locations/*/metadataStores/*/artifacts/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
PurgeArtifacts6.google.cloud.aiplatform.v1beta1.PurgeArtifactsRequest.google.longrunning.Operation"����N"I/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/artifacts:purge:*�Aparent�A0
PurgeArtifactsResponsePurgeArtifactsMetadata�
CreateContext5.google.cloud.aiplatform.v1beta1.CreateContextRequest(.google.cloud.aiplatform.v1beta1.Context"o���M"B/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/contexts:context�Aparent,context,context_id�

GetContext2.google.cloud.aiplatform.v1beta1.GetContextRequest(.google.cloud.aiplatform.v1beta1.Context"Q���DB/v1beta1/{name=projects/*/locations/*/metadataStores/*/contexts/*}�Aname�
ListContexts4.google.cloud.aiplatform.v1beta1.ListContextsRequest5.google.cloud.aiplatform.v1beta1.ListContextsResponse"S���DB/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/contexts�Aparent�
UpdateContext5.google.cloud.aiplatform.v1beta1.UpdateContextRequest(.google.cloud.aiplatform.v1beta1.Context"q���U2J/v1beta1/{context.name=projects/*/locations/*/metadataStores/*/contexts/*}:context�Acontext,update_mask�
DeleteContext5.google.cloud.aiplatform.v1beta1.DeleteContextRequest.google.longrunning.Operation"����D*B/v1beta1/{name=projects/*/locations/*/metadataStores/*/contexts/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
PurgeContexts5.google.cloud.aiplatform.v1beta1.PurgeContextsRequest.google.longrunning.Operation"����M"H/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/contexts:purge:*�Aparent�A.
PurgeContextsResponsePurgeContextsMetadata�
 AddContextArtifactsAndExecutionsH.google.cloud.aiplatform.v1beta1.AddContextArtifactsAndExecutionsRequestI.google.cloud.aiplatform.v1beta1.AddContextArtifactsAndExecutionsResponse"����k"f/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:addContextArtifactsAndExecutions:*�Acontext,artifacts,executions�
AddContextChildren:.google.cloud.aiplatform.v1beta1.AddContextChildrenRequest;.google.cloud.aiplatform.v1beta1.AddContextChildrenResponse"|���]"X/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:addContextChildren:*�Acontext,child_contexts�
QueryContextLineageSubgraphC.google.cloud.aiplatform.v1beta1.QueryContextLineageSubgraphRequest0.google.cloud.aiplatform.v1beta1.LineageSubgraph"s���ca/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:queryContextLineageSubgraph�Acontext�
CreateExecution7.google.cloud.aiplatform.v1beta1.CreateExecutionRequest*.google.cloud.aiplatform.v1beta1.Execution"w���Q"D/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/executions:	execution�Aparent,execution,execution_id�
GetExecution4.google.cloud.aiplatform.v1beta1.GetExecutionRequest*.google.cloud.aiplatform.v1beta1.Execution"S���FD/v1beta1/{name=projects/*/locations/*/metadataStores/*/executions/*}�Aname�
ListExecutions6.google.cloud.aiplatform.v1beta1.ListExecutionsRequest7.google.cloud.aiplatform.v1beta1.ListExecutionsResponse"U���FD/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/executions�Aparent�
UpdateExecution7.google.cloud.aiplatform.v1beta1.UpdateExecutionRequest*.google.cloud.aiplatform.v1beta1.Execution"y���[2N/v1beta1/{execution.name=projects/*/locations/*/metadataStores/*/executions/*}:	execution�Aexecution,update_mask�
DeleteExecution7.google.cloud.aiplatform.v1beta1.DeleteExecutionRequest.google.longrunning.Operation"����F*D/v1beta1/{name=projects/*/locations/*/metadataStores/*/executions/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
PurgeExecutions7.google.cloud.aiplatform.v1beta1.PurgeExecutionsRequest.google.longrunning.Operation"����O"J/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/executions:purge:*�Aparent�A2
PurgeExecutionsResponsePurgeExecutionsMetadata�
AddExecutionEvents:.google.cloud.aiplatform.v1beta1.AddExecutionEventsRequest;.google.cloud.aiplatform.v1beta1.AddExecutionEventsResponse"z���a"\\/v1beta1/{execution=projects/*/locations/*/metadataStores/*/executions/*}:addExecutionEvents:*�Aexecution,events�
QueryExecutionInputsAndOutputsF.google.cloud.aiplatform.v1beta1.QueryExecutionInputsAndOutputsRequest0.google.cloud.aiplatform.v1beta1.LineageSubgraph"|���jh/v1beta1/{execution=projects/*/locations/*/metadataStores/*/executions/*}:queryExecutionInputsAndOutputs�A	execution�
CreateMetadataSchema<.google.cloud.aiplatform.v1beta1.CreateMetadataSchemaRequest/.google.cloud.aiplatform.v1beta1.MetadataSchema"����\\"I/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/metadataSchemas:metadata_schema�A)parent,metadata_schema,metadata_schema_id�
GetMetadataSchema9.google.cloud.aiplatform.v1beta1.GetMetadataSchemaRequest/.google.cloud.aiplatform.v1beta1.MetadataSchema"X���KI/v1beta1/{name=projects/*/locations/*/metadataStores/*/metadataSchemas/*}�Aname�
ListMetadataSchemas;.google.cloud.aiplatform.v1beta1.ListMetadataSchemasRequest<.google.cloud.aiplatform.v1beta1.ListMetadataSchemasResponse"Z���KI/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/metadataSchemas�Aparent�
QueryArtifactLineageSubgraphD.google.cloud.aiplatform.v1beta1.QueryArtifactLineageSubgraphRequest0.google.cloud.aiplatform.v1beta1.LineageSubgraph"w���fd/v1beta1/{artifact=projects/*/locations/*/metadataStores/*/artifacts/*}:queryArtifactLineageSubgraph�AartifactM�Aaiplatform.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
#com.google.cloud.aiplatform.v1beta1BMetadataServiceProtoPZIgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1;aiplatform�Google.Cloud.AIPlatform.V1Beta1�Google\\Cloud\\AIPlatform\\V1beta1�"Google::Cloud::AIPlatform::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

