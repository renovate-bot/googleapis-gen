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
 * Service for managing [Environments][google.cloud.dialogflow.cx.v3.Environment].
 */
class EnvironmentsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all environments in the specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListEnvironmentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListEnvironments(\Google\Cloud\Dialogflow\Cx\V3\ListEnvironmentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/ListEnvironments',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListEnvironmentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetEnvironment(\Google\Cloud\Dialogflow\Cx\V3\GetEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/GetEnvironment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Environment', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateEnvironment(\Google\Cloud\Dialogflow\Cx\V3\CreateEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/CreateEnvironment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateEnvironment(\Google\Cloud\Dialogflow\Cx\V3\UpdateEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/UpdateEnvironment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteEnvironment(\Google\Cloud\Dialogflow\Cx\V3\DeleteEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/DeleteEnvironment',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Looks up the history of the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\LookupEnvironmentHistoryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LookupEnvironmentHistory(\Google\Cloud\Dialogflow\Cx\V3\LookupEnvironmentHistoryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/LookupEnvironmentHistory',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\LookupEnvironmentHistoryResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a continuous test under the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
     * - `response`: [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\RunContinuousTestRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RunContinuousTest(\Google\Cloud\Dialogflow\Cx\V3\RunContinuousTestRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/RunContinuousTest',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches a list of continuous test results for a given environment.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListContinuousTestResultsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListContinuousTestResults(\Google\Cloud\Dialogflow\Cx\V3\ListContinuousTestResultsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/ListContinuousTestResults',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListContinuousTestResultsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deploys a flow to the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
     * - `response`: [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeployFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeployFlow(\Google\Cloud\Dialogflow\Cx\V3\DeployFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Environments/DeployFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
