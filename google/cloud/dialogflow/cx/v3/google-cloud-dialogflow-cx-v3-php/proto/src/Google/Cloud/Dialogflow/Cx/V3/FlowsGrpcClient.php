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
 * Service for managing [Flows][google.cloud.dialogflow.cx.v3.Flow].
 */
class FlowsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a flow in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateFlow(\Google\Cloud\Dialogflow\Cx\V3\CreateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/CreateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteFlow(\Google\Cloud\Dialogflow\Cx\V3\DeleteFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/DeleteFlow',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the list of all flows in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListFlowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListFlows(\Google\Cloud\Dialogflow\Cx\V3\ListFlowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/ListFlows',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListFlowsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFlow(\Google\Cloud\Dialogflow\Cx\V3\GetFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/GetFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateFlow(\Google\Cloud\Dialogflow\Cx\V3\UpdateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/UpdateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Trains the specified flow. Note that only the flow in 'draft' environment
     * is trained.
     * @param \Google\Cloud\Dialogflow\Cx\V3\TrainFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function TrainFlow(\Google\Cloud\Dialogflow\Cx\V3\TrainFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/TrainFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Validates the specified flow and creates or updates validation results.
     * Please call this API after the training is completed to get the complete
     * validation results.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ValidateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ValidateFlow(\Google\Cloud\Dialogflow\Cx\V3\ValidateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/ValidateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\FlowValidationResult', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the latest flow validation result. Flow validation is performed
     * when ValidateFlow is called.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetFlowValidationResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFlowValidationResult(\Google\Cloud\Dialogflow\Cx\V3\GetFlowValidationResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Flows/GetFlowValidationResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\FlowValidationResult', 'decode'],
        $metadata, $options);
    }

}
