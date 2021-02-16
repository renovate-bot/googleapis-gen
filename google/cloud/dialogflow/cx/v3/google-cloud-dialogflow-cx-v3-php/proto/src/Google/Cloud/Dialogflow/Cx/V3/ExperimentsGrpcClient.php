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
namespace Google\Cloud\Dialogflow\Cx\V3;

/**
 * Service for managing [Experiments][google.cloud.dialogflow.cx.v3.Experiment].
 */
class ExperimentsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all experiments in the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListExperimentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListExperiments(\Google\Cloud\Dialogflow\Cx\V3\ListExperimentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/ListExperiments',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListExperimentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetExperiment(\Google\Cloud\Dialogflow\Cx\V3\GetExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/GetExperiment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Experiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateExperiment(\Google\Cloud\Dialogflow\Cx\V3\CreateExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/CreateExperiment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Experiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateExperiment(\Google\Cloud\Dialogflow\Cx\V3\UpdateExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/UpdateExperiment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Experiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteExperiment(\Google\Cloud\Dialogflow\Cx\V3\DeleteExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/DeleteExperiment',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Starts the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only changes the state of
     * experiment from PENDING to RUNNING.
     * @param \Google\Cloud\Dialogflow\Cx\V3\StartExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartExperiment(\Google\Cloud\Dialogflow\Cx\V3\StartExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/StartExperiment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Experiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only changes the state of
     * experiment from RUNNING to DONE.
     * @param \Google\Cloud\Dialogflow\Cx\V3\StopExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StopExperiment(\Google\Cloud\Dialogflow\Cx\V3\StopExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Experiments/StopExperiment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Experiment', 'decode'],
        $metadata, $options);
    }

}
