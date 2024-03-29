<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/tensorboard_service.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1Beta1;

class TensorboardService
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
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Operation::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Tensorboard::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\TensorboardData::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\TensorboardExperiment::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\TensorboardRun::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\TensorboardTimeSeries::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        $pool->internalAddGeneratedFile(
            '
�v
9google/cloud/aiplatform/v1beta1/tensorboard_service.protogoogle.cloud.aiplatform.v1beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto/google/cloud/aiplatform/v1beta1/operation.proto1google/cloud/aiplatform/v1beta1/tensorboard.proto6google/cloud/aiplatform/v1beta1/tensorboard_data.proto<google/cloud/aiplatform/v1beta1/tensorboard_experiment.proto5google/cloud/aiplatform/v1beta1/tensorboard_run.proto=google/cloud/aiplatform/v1beta1/tensorboard_time_series.proto#google/longrunning/operations.proto google/protobuf/field_mask.proto"�
CreateTensorboardRequest=
parent (	B-�A�A\'
%aiplatform.googleapis.com/TensorboardF
tensorboard (2,.google.cloud.aiplatform.v1beta1.TensorboardB�A"T
GetTensorboardRequest;
name (	B-�A�A\'
%aiplatform.googleapis.com/Tensorboard"�
ListTensorboardsRequest=
parent (	B-�A�A\'%aiplatform.googleapis.com/Tensorboard
filter (	
	page_size (

page_token (	
order_by (	-
	read_mask (2.google.protobuf.FieldMask"w
ListTensorboardsResponseB
tensorboards (2,.google.cloud.aiplatform.v1beta1.Tensorboard
next_page_token (	"�
UpdateTensorboardRequest4
update_mask (2.google.protobuf.FieldMaskB�AF
tensorboard (2,.google.cloud.aiplatform.v1beta1.TensorboardB�A"W
DeleteTensorboardRequest;
name (	B-�A�A\'
%aiplatform.googleapis.com/Tensorboard"�
"CreateTensorboardExperimentRequestG
parent (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperimentV
tensorboard_experiment (26.google.cloud.aiplatform.v1beta1.TensorboardExperiment&
tensorboard_experiment_id (	B�A"h
GetTensorboardExperimentRequestE
name (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperiment"�
!ListTensorboardExperimentsRequestG
parent (	B7�A�A1/aiplatform.googleapis.com/TensorboardExperiment
filter (	
	page_size (

page_token (	
order_by (	-
	read_mask (2.google.protobuf.FieldMask"�
"ListTensorboardExperimentsResponseW
tensorboard_experiments (26.google.cloud.aiplatform.v1beta1.TensorboardExperiment
next_page_token (	"�
"UpdateTensorboardExperimentRequest4
update_mask (2.google.protobuf.FieldMaskB�A[
tensorboard_experiment (26.google.cloud.aiplatform.v1beta1.TensorboardExperimentB�A"k
"DeleteTensorboardExperimentRequestE
name (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperiment"�
!BatchCreateTensorboardRunsRequestG
parent (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperimentS
requests (2<.google.cloud.aiplatform.v1beta1.CreateTensorboardRunRequestB�A"o
"BatchCreateTensorboardRunsResponseI
tensorboard_runs (2/.google.cloud.aiplatform.v1beta1.TensorboardRun"�
CreateTensorboardRunRequest@
parent (	B0�A�A*
(aiplatform.googleapis.com/TensorboardRunM
tensorboard_run (2/.google.cloud.aiplatform.v1beta1.TensorboardRunB�A
tensorboard_run_id (	B�A"Z
GetTensorboardRunRequest>
name (	B0�A�A*
(aiplatform.googleapis.com/TensorboardRun"�
ReadTensorboardBlobDataRequestL
time_series (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries
blob_ids (	"b
ReadTensorboardBlobDataResponse?
blobs (20.google.cloud.aiplatform.v1beta1.TensorboardBlob"�
ListTensorboardRunsRequest@
parent (	B0�A�A*(aiplatform.googleapis.com/TensorboardRun
filter (	
	page_size (

page_token (	
order_by (	-
	read_mask (2.google.protobuf.FieldMask"�
ListTensorboardRunsResponseI
tensorboard_runs (2/.google.cloud.aiplatform.v1beta1.TensorboardRun
next_page_token (	"�
UpdateTensorboardRunRequest4
update_mask (2.google.protobuf.FieldMaskB�AM
tensorboard_run (2/.google.cloud.aiplatform.v1beta1.TensorboardRunB�A"]
DeleteTensorboardRunRequest>
name (	B0�A�A*
(aiplatform.googleapis.com/TensorboardRun"�
\'BatchCreateTensorboardTimeSeriesRequestG
parent (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperimentZ
requests (2C.google.cloud.aiplatform.v1beta1.CreateTensorboardTimeSeriesRequestB�A"�
(BatchCreateTensorboardTimeSeriesResponseW
tensorboard_time_series (26.google.cloud.aiplatform.v1beta1.TensorboardTimeSeries"�
"CreateTensorboardTimeSeriesRequestG
parent (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries\'
tensorboard_time_series_id (	B�A\\
tensorboard_time_series (26.google.cloud.aiplatform.v1beta1.TensorboardTimeSeriesB�A"h
GetTensorboardTimeSeriesRequestE
name (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries"�
 ListTensorboardTimeSeriesRequestG
parent (	B7�A�A1/aiplatform.googleapis.com/TensorboardTimeSeries
filter (	
	page_size (

page_token (	
order_by (	-
	read_mask (2.google.protobuf.FieldMask"�
!ListTensorboardTimeSeriesResponseW
tensorboard_time_series (26.google.cloud.aiplatform.v1beta1.TensorboardTimeSeries
next_page_token (	"�
"UpdateTensorboardTimeSeriesRequest4
update_mask (2.google.protobuf.FieldMaskB�A\\
tensorboard_time_series (26.google.cloud.aiplatform.v1beta1.TensorboardTimeSeriesB�A"k
"DeleteTensorboardTimeSeriesRequestE
name (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries"�
)BatchReadTensorboardTimeSeriesDataRequestB
tensorboard (	B-�A�A\'
%aiplatform.googleapis.com/TensorboardL
time_series (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries"w
*BatchReadTensorboardTimeSeriesDataResponseI
time_series_data (2/.google.cloud.aiplatform.v1beta1.TimeSeriesData"�
$ReadTensorboardTimeSeriesDataRequestX
tensorboard_time_series (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries
max_data_points (
filter (	"r
%ReadTensorboardTimeSeriesDataResponseI
time_series_data (2/.google.cloud.aiplatform.v1beta1.TimeSeriesData"�
%WriteTensorboardExperimentDataRequestW
tensorboard_experiment (	B7�A�A1
/aiplatform.googleapis.com/TensorboardExperimente
write_run_data_requests (2?.google.cloud.aiplatform.v1beta1.WriteTensorboardRunDataRequestB�A"(
&WriteTensorboardExperimentDataResponse"�
WriteTensorboardRunDataRequestI
tensorboard_run (	B0�A�A*
(aiplatform.googleapis.com/TensorboardRunN
time_series_data (2/.google.cloud.aiplatform.v1beta1.TimeSeriesDataB�A"!
WriteTensorboardRunDataResponse"�
&ExportTensorboardTimeSeriesDataRequestX
tensorboard_time_series (	B7�A�A1
/aiplatform.googleapis.com/TensorboardTimeSeries
filter (	
	page_size (

page_token (	
order_by (	"�
\'ExportTensorboardTimeSeriesDataResponseU
time_series_data_points (24.google.cloud.aiplatform.v1beta1.TimeSeriesDataPoint
next_page_token (	"y
"CreateTensorboardOperationMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata"y
"UpdateTensorboardOperationMetadataS
generic_metadata (29.google.cloud.aiplatform.v1beta1.GenericOperationMetadata2�>
TensorboardService�
CreateTensorboard9.google.cloud.aiplatform.v1beta1.CreateTensorboardRequest.google.longrunning.Operation"����D"5/v1beta1/{parent=projects/*/locations/*}/tensorboards:tensorboard�Aparent,tensorboard�A1
Tensorboard"CreateTensorboardOperationMetadata�
GetTensorboard6.google.cloud.aiplatform.v1beta1.GetTensorboardRequest,.google.cloud.aiplatform.v1beta1.Tensorboard"D���75/v1beta1/{name=projects/*/locations/*/tensorboards/*}�Aname�
UpdateTensorboard9.google.cloud.aiplatform.v1beta1.UpdateTensorboardRequest.google.longrunning.Operation"����P2A/v1beta1/{tensorboard.name=projects/*/locations/*/tensorboards/*}:tensorboard�Atensorboard,update_mask�A1
Tensorboard"UpdateTensorboardOperationMetadata�
ListTensorboards8.google.cloud.aiplatform.v1beta1.ListTensorboardsRequest9.google.cloud.aiplatform.v1beta1.ListTensorboardsResponse"F���75/v1beta1/{parent=projects/*/locations/*}/tensorboards�Aparent�
DeleteTensorboard9.google.cloud.aiplatform.v1beta1.DeleteTensorboardRequest.google.longrunning.Operation"w���7*5/v1beta1/{name=projects/*/locations/*/tensorboards/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
CreateTensorboardExperimentC.google.cloud.aiplatform.v1beta1.CreateTensorboardExperimentRequest6.google.cloud.aiplatform.v1beta1.TensorboardExperiment"����]"C/v1beta1/{parent=projects/*/locations/*/tensorboards/*}/experiments:tensorboard_experiment�A7parent,tensorboard_experiment,tensorboard_experiment_id�
GetTensorboardExperiment@.google.cloud.aiplatform.v1beta1.GetTensorboardExperimentRequest6.google.cloud.aiplatform.v1beta1.TensorboardExperiment"R���EC/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*}�Aname�
UpdateTensorboardExperimentC.google.cloud.aiplatform.v1beta1.UpdateTensorboardExperimentRequest6.google.cloud.aiplatform.v1beta1.TensorboardExperiment"����t2Z/v1beta1/{tensorboard_experiment.name=projects/*/locations/*/tensorboards/*/experiments/*}:tensorboard_experiment�A"tensorboard_experiment,update_mask�
ListTensorboardExperimentsB.google.cloud.aiplatform.v1beta1.ListTensorboardExperimentsRequestC.google.cloud.aiplatform.v1beta1.ListTensorboardExperimentsResponse"T���EC/v1beta1/{parent=projects/*/locations/*/tensorboards/*}/experiments�Aparent�
DeleteTensorboardExperimentC.google.cloud.aiplatform.v1beta1.DeleteTensorboardExperimentRequest.google.longrunning.Operation"����E*C/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
CreateTensorboardRun<.google.cloud.aiplatform.v1beta1.CreateTensorboardRunRequest/.google.cloud.aiplatform.v1beta1.TensorboardRun"����]"J/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs:tensorboard_run�A)parent,tensorboard_run,tensorboard_run_id�
BatchCreateTensorboardRunsB.google.cloud.aiplatform.v1beta1.BatchCreateTensorboardRunsRequestC.google.cloud.aiplatform.v1beta1.BatchCreateTensorboardRunsResponse"s���["V/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs:batchCreate:*�Aparent,requests�
GetTensorboardRun9.google.cloud.aiplatform.v1beta1.GetTensorboardRunRequest/.google.cloud.aiplatform.v1beta1.TensorboardRun"Y���LJ/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}�Aname�
UpdateTensorboardRun<.google.cloud.aiplatform.v1beta1.UpdateTensorboardRunRequest/.google.cloud.aiplatform.v1beta1.TensorboardRun"����m2Z/v1beta1/{tensorboard_run.name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}:tensorboard_run�Atensorboard_run,update_mask�
ListTensorboardRuns;.google.cloud.aiplatform.v1beta1.ListTensorboardRunsRequest<.google.cloud.aiplatform.v1beta1.ListTensorboardRunsResponse"[���LJ/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs�Aparent�
DeleteTensorboardRun<.google.cloud.aiplatform.v1beta1.DeleteTensorboardRunRequest.google.longrunning.Operation"����L*J/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
 BatchCreateTensorboardTimeSeriesH.google.cloud.aiplatform.v1beta1.BatchCreateTensorboardTimeSeriesRequestI.google.cloud.aiplatform.v1beta1.BatchCreateTensorboardTimeSeriesResponse"����h"c/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs/*/timeSeries:batchCreate:*�Aparent,requests�
CreateTensorboardTimeSeriesC.google.cloud.aiplatform.v1beta1.CreateTensorboardTimeSeriesRequest6.google.cloud.aiplatform.v1beta1.TensorboardTimeSeries"����r"W/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}/timeSeries:tensorboard_time_series�Aparent,tensorboard_time_series�
GetTensorboardTimeSeries@.google.cloud.aiplatform.v1beta1.GetTensorboardTimeSeriesRequest6.google.cloud.aiplatform.v1beta1.TensorboardTimeSeries"f���YW/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}�Aname�
UpdateTensorboardTimeSeriesC.google.cloud.aiplatform.v1beta1.UpdateTensorboardTimeSeriesRequest6.google.cloud.aiplatform.v1beta1.TensorboardTimeSeries"�����2o/v1beta1/{tensorboard_time_series.name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:tensorboard_time_series�A#tensorboard_time_series,update_mask�
ListTensorboardTimeSeriesA.google.cloud.aiplatform.v1beta1.ListTensorboardTimeSeriesRequestB.google.cloud.aiplatform.v1beta1.ListTensorboardTimeSeriesResponse"h���YW/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}/timeSeries�Aparent�
DeleteTensorboardTimeSeriesC.google.cloud.aiplatform.v1beta1.DeleteTensorboardTimeSeriesRequest.google.longrunning.Operation"����Y*W/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}�Aname�A0
google.protobuf.EmptyDeleteOperationMetadata�
"BatchReadTensorboardTimeSeriesDataJ.google.cloud.aiplatform.v1beta1.BatchReadTensorboardTimeSeriesDataRequestK.google.cloud.aiplatform.v1beta1.BatchReadTensorboardTimeSeriesDataResponse"|���hf/v1beta1/{tensorboard=projects/*/locations/*/tensorboards/*}/experiments/*/runs/*/timeSeries:batchRead�Atensorboard�
ReadTensorboardTimeSeriesDataE.google.cloud.aiplatform.v1beta1.ReadTensorboardTimeSeriesDataRequestF.google.cloud.aiplatform.v1beta1.ReadTensorboardTimeSeriesDataResponse"����qo/v1beta1/{tensorboard_time_series=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:read�Atensorboard_time_series�
ReadTensorboardBlobData?.google.cloud.aiplatform.v1beta1.ReadTensorboardBlobDataRequest@.google.cloud.aiplatform.v1beta1.ReadTensorboardBlobDataResponse"����mk/v1beta1/{time_series=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:readBlobData�Atime_series0�
WriteTensorboardExperimentDataF.google.cloud.aiplatform.v1beta1.WriteTensorboardExperimentDataRequestG.google.cloud.aiplatform.v1beta1.WriteTensorboardExperimentDataResponse"����`"[/v1beta1/{tensorboard_experiment=projects/*/locations/*/tensorboards/*/experiments/*}:write:*�A.tensorboard_experiment,write_run_data_requests�
WriteTensorboardRunData?.google.cloud.aiplatform.v1beta1.WriteTensorboardRunDataRequest@.google.cloud.aiplatform.v1beta1.WriteTensorboardRunDataResponse"����`"[/v1beta1/{tensorboard_run=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}:write:*�A tensorboard_run,time_series_data�
ExportTensorboardTimeSeriesDataG.google.cloud.aiplatform.v1beta1.ExportTensorboardTimeSeriesDataRequestH.google.cloud.aiplatform.v1beta1.ExportTensorboardTimeSeriesDataResponse"�����"�/v1beta1/{tensorboard_time_series=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:exportTensorboardTimeSeries:*�Atensorboard_time_seriesM�Aaiplatform.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
#com.google.cloud.aiplatform.v1beta1BTensorboardServiceProtoPZIgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1;aiplatform�Google.Cloud.AIPlatform.V1Beta1�Google\\Cloud\\AIPlatform\\V1beta1�"Google::Cloud::AIPlatform::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

