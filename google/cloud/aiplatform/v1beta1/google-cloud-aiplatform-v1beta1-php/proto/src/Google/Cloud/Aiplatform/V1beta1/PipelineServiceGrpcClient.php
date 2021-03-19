<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
namespace Google\Cloud\Aiplatform\V1beta1;

/**
 * A service for creating and managing AI Platform's pipelines.
 */
class PipelineServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a TrainingPipeline. A created TrainingPipeline right away will be
     * attempted to be run.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTrainingPipelineRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTrainingPipeline(\Google\Cloud\Aiplatform\V1beta1\CreateTrainingPipelineRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.PipelineService/CreateTrainingPipeline',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TrainingPipeline', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a TrainingPipeline.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTrainingPipelineRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTrainingPipeline(\Google\Cloud\Aiplatform\V1beta1\GetTrainingPipelineRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.PipelineService/GetTrainingPipeline',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TrainingPipeline', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists TrainingPipelines in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTrainingPipelinesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTrainingPipelines(\Google\Cloud\Aiplatform\V1beta1\ListTrainingPipelinesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.PipelineService/ListTrainingPipelines',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTrainingPipelinesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a TrainingPipeline.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTrainingPipelineRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTrainingPipeline(\Google\Cloud\Aiplatform\V1beta1\DeleteTrainingPipelineRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.PipelineService/DeleteTrainingPipeline',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Cancels a TrainingPipeline.
     * Starts asynchronous cancellation on the TrainingPipeline. The server
     * makes a best effort to cancel the pipeline, but success is not
     * guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1beta1.PipelineService.GetTrainingPipeline] or
     * other methods to check whether the cancellation succeeded or whether the
     * pipeline completed despite cancellation. On successful cancellation,
     * the TrainingPipeline is not deleted; instead it becomes a pipeline with
     * a [TrainingPipeline.error][google.cloud.aiplatform.v1beta1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
     * corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1beta1.TrainingPipeline.state] is set to
     * `CANCELLED`.
     * @param \Google\Cloud\Aiplatform\V1beta1\CancelTrainingPipelineRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CancelTrainingPipeline(\Google\Cloud\Aiplatform\V1beta1\CancelTrainingPipelineRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.PipelineService/CancelTrainingPipeline',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
