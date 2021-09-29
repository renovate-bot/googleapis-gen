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
namespace Google\Cloud\Dialogflow\Cx\V3beta1;

/**
 * Service for managing [Environments][google.cloud.dialogflow.cx.v3beta1.Environment].
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
     * Returns the list of all environments in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListEnvironmentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListEnvironments(\Google\Cloud\Dialogflow\Cx\V3beta1\ListEnvironmentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/ListEnvironments',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListEnvironmentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetEnvironment(\Google\Cloud\Dialogflow\Cx\V3beta1\GetEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/GetEnvironment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Environment', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [Environment][google.cloud.dialogflow.cx.v3beta1.Environment]
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateEnvironment(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/CreateEnvironment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [Environment][google.cloud.dialogflow.cx.v3beta1.Environment]
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateEnvironment(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/UpdateEnvironment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteEnvironmentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteEnvironment(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteEnvironmentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/DeleteEnvironment',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Looks up the history of the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\LookupEnvironmentHistoryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LookupEnvironmentHistory(\Google\Cloud\Dialogflow\Cx\V3beta1\LookupEnvironmentHistoryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/LookupEnvironmentHistory',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\LookupEnvironmentHistoryResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a continuous test under the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3beta1.RunContinuousTestMetadata]
     * - `response`: [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3beta1.RunContinuousTestResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\RunContinuousTestRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RunContinuousTest(\Google\Cloud\Dialogflow\Cx\V3beta1\RunContinuousTestRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/RunContinuousTest',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches a list of continuous test results for a given environment.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListContinuousTestResultsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListContinuousTestResults(\Google\Cloud\Dialogflow\Cx\V3beta1\ListContinuousTestResultsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/ListContinuousTestResults',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListContinuousTestResultsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deploys a flow to the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [DeployFlowMetadata][google.cloud.dialogflow.cx.v3beta1.DeployFlowMetadata]
     * - `response`: [DeployFlowResponse][google.cloud.dialogflow.cx.v3beta1.DeployFlowResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeployFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeployFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\DeployFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Environments/DeployFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
