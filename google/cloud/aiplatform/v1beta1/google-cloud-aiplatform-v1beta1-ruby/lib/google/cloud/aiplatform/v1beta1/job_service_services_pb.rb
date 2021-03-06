# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/aiplatform/v1beta1/job_service.proto for package 'google.cloud.aiplatform.v1beta1'
# Original file comments:
# Copyright 2021 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

require 'grpc'
require 'google/cloud/aiplatform/v1beta1/job_service_pb'

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        module JobService
          # A service for creating and managing Vertex AI's jobs.
          class Service

            include GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.aiplatform.v1beta1.JobService'

            # Creates a CustomJob. A created CustomJob right away
            # will be attempted to be run.
            rpc :CreateCustomJob, ::Google::Cloud::Aiplatform::V1beta1::CreateCustomJobRequest, ::Google::Cloud::Aiplatform::V1beta1::CustomJob
            # Gets a CustomJob.
            rpc :GetCustomJob, ::Google::Cloud::Aiplatform::V1beta1::GetCustomJobRequest, ::Google::Cloud::Aiplatform::V1beta1::CustomJob
            # Lists CustomJobs in a Location.
            rpc :ListCustomJobs, ::Google::Cloud::Aiplatform::V1beta1::ListCustomJobsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListCustomJobsResponse
            # Deletes a CustomJob.
            rpc :DeleteCustomJob, ::Google::Cloud::Aiplatform::V1beta1::DeleteCustomJobRequest, ::Google::Longrunning::Operation
            # Cancels a CustomJob.
            # Starts asynchronous cancellation on the CustomJob. The server
            # makes a best effort to cancel the job, but success is not
            # guaranteed. Clients can use [JobService.GetCustomJob][google.cloud.aiplatform.v1beta1.JobService.GetCustomJob] or
            # other methods to check whether the cancellation succeeded or whether the
            # job completed despite cancellation. On successful cancellation,
            # the CustomJob is not deleted; instead it becomes a job with
            # a [CustomJob.error][google.cloud.aiplatform.v1beta1.CustomJob.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
            # corresponding to `Code.CANCELLED`, and [CustomJob.state][google.cloud.aiplatform.v1beta1.CustomJob.state] is set to
            # `CANCELLED`.
            rpc :CancelCustomJob, ::Google::Cloud::Aiplatform::V1beta1::CancelCustomJobRequest, ::Google::Protobuf::Empty
            # Creates a DataLabelingJob.
            rpc :CreateDataLabelingJob, ::Google::Cloud::Aiplatform::V1beta1::CreateDataLabelingJobRequest, ::Google::Cloud::Aiplatform::V1beta1::DataLabelingJob
            # Gets a DataLabelingJob.
            rpc :GetDataLabelingJob, ::Google::Cloud::Aiplatform::V1beta1::GetDataLabelingJobRequest, ::Google::Cloud::Aiplatform::V1beta1::DataLabelingJob
            # Lists DataLabelingJobs in a Location.
            rpc :ListDataLabelingJobs, ::Google::Cloud::Aiplatform::V1beta1::ListDataLabelingJobsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListDataLabelingJobsResponse
            # Deletes a DataLabelingJob.
            rpc :DeleteDataLabelingJob, ::Google::Cloud::Aiplatform::V1beta1::DeleteDataLabelingJobRequest, ::Google::Longrunning::Operation
            # Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
            rpc :CancelDataLabelingJob, ::Google::Cloud::Aiplatform::V1beta1::CancelDataLabelingJobRequest, ::Google::Protobuf::Empty
            # Creates a HyperparameterTuningJob
            rpc :CreateHyperparameterTuningJob, ::Google::Cloud::Aiplatform::V1beta1::CreateHyperparameterTuningJobRequest, ::Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob
            # Gets a HyperparameterTuningJob
            rpc :GetHyperparameterTuningJob, ::Google::Cloud::Aiplatform::V1beta1::GetHyperparameterTuningJobRequest, ::Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob
            # Lists HyperparameterTuningJobs in a Location.
            rpc :ListHyperparameterTuningJobs, ::Google::Cloud::Aiplatform::V1beta1::ListHyperparameterTuningJobsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListHyperparameterTuningJobsResponse
            # Deletes a HyperparameterTuningJob.
            rpc :DeleteHyperparameterTuningJob, ::Google::Cloud::Aiplatform::V1beta1::DeleteHyperparameterTuningJobRequest, ::Google::Longrunning::Operation
            # Cancels a HyperparameterTuningJob.
            # Starts asynchronous cancellation on the HyperparameterTuningJob. The server
            # makes a best effort to cancel the job, but success is not
            # guaranteed. Clients can use [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1beta1.JobService.GetHyperparameterTuningJob] or
            # other methods to check whether the cancellation succeeded or whether the
            # job completed despite cancellation. On successful cancellation,
            # the HyperparameterTuningJob is not deleted; instead it becomes a job with
            # a [HyperparameterTuningJob.error][google.cloud.aiplatform.v1beta1.HyperparameterTuningJob.error] value with a [google.rpc.Status.code][google.rpc.Status.code]
            # of 1, corresponding to `Code.CANCELLED`, and
            # [HyperparameterTuningJob.state][google.cloud.aiplatform.v1beta1.HyperparameterTuningJob.state] is set to `CANCELLED`.
            rpc :CancelHyperparameterTuningJob, ::Google::Cloud::Aiplatform::V1beta1::CancelHyperparameterTuningJobRequest, ::Google::Protobuf::Empty
            # Creates a BatchPredictionJob. A BatchPredictionJob once created will
            # right away be attempted to start.
            rpc :CreateBatchPredictionJob, ::Google::Cloud::Aiplatform::V1beta1::CreateBatchPredictionJobRequest, ::Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob
            # Gets a BatchPredictionJob
            rpc :GetBatchPredictionJob, ::Google::Cloud::Aiplatform::V1beta1::GetBatchPredictionJobRequest, ::Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob
            # Lists BatchPredictionJobs in a Location.
            rpc :ListBatchPredictionJobs, ::Google::Cloud::Aiplatform::V1beta1::ListBatchPredictionJobsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListBatchPredictionJobsResponse
            # Deletes a BatchPredictionJob. Can only be called on jobs that already
            # finished.
            rpc :DeleteBatchPredictionJob, ::Google::Cloud::Aiplatform::V1beta1::DeleteBatchPredictionJobRequest, ::Google::Longrunning::Operation
            # Cancels a BatchPredictionJob.
            #
            # Starts asynchronous cancellation on the BatchPredictionJob. The server
            # makes the best effort to cancel the job, but success is not
            # guaranteed. Clients can use [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1beta1.JobService.GetBatchPredictionJob] or
            # other methods to check whether the cancellation succeeded or whether the
            # job completed despite cancellation. On a successful cancellation,
            # the BatchPredictionJob is not deleted;instead its
            # [BatchPredictionJob.state][google.cloud.aiplatform.v1beta1.BatchPredictionJob.state] is set to `CANCELLED`. Any files already
            # outputted by the job are not deleted.
            rpc :CancelBatchPredictionJob, ::Google::Cloud::Aiplatform::V1beta1::CancelBatchPredictionJobRequest, ::Google::Protobuf::Empty
            # Creates a ModelDeploymentMonitoringJob. It will run periodically on a
            # configured interval.
            rpc :CreateModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::CreateModelDeploymentMonitoringJobRequest, ::Google::Cloud::Aiplatform::V1beta1::ModelDeploymentMonitoringJob
            # Searches Model Monitoring Statistics generated within a given time window.
            rpc :SearchModelDeploymentMonitoringStatsAnomalies, ::Google::Cloud::Aiplatform::V1beta1::SearchModelDeploymentMonitoringStatsAnomaliesRequest, ::Google::Cloud::Aiplatform::V1beta1::SearchModelDeploymentMonitoringStatsAnomaliesResponse
            # Gets a ModelDeploymentMonitoringJob.
            rpc :GetModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::GetModelDeploymentMonitoringJobRequest, ::Google::Cloud::Aiplatform::V1beta1::ModelDeploymentMonitoringJob
            # Lists ModelDeploymentMonitoringJobs in a Location.
            rpc :ListModelDeploymentMonitoringJobs, ::Google::Cloud::Aiplatform::V1beta1::ListModelDeploymentMonitoringJobsRequest, ::Google::Cloud::Aiplatform::V1beta1::ListModelDeploymentMonitoringJobsResponse
            # Updates a ModelDeploymentMonitoringJob.
            rpc :UpdateModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::UpdateModelDeploymentMonitoringJobRequest, ::Google::Longrunning::Operation
            # Deletes a ModelDeploymentMonitoringJob.
            rpc :DeleteModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::DeleteModelDeploymentMonitoringJobRequest, ::Google::Longrunning::Operation
            # Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
            # makes a best effort to cancel the job. Will mark
            # [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1beta1.ModelDeploymentMonitoringJob.state] to 'PAUSED'.
            rpc :PauseModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::PauseModelDeploymentMonitoringJobRequest, ::Google::Protobuf::Empty
            # Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
            # next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
            # resumed.
            rpc :ResumeModelDeploymentMonitoringJob, ::Google::Cloud::Aiplatform::V1beta1::ResumeModelDeploymentMonitoringJobRequest, ::Google::Protobuf::Empty
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
