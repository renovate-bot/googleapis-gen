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
 * Service for managing [Flows][google.cloud.dialogflow.cx.v3beta1.Flow].
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
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/CreateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/DeleteFlow',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the list of all flows in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListFlowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListFlows(\Google\Cloud\Dialogflow\Cx\V3beta1\ListFlowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/ListFlows',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListFlowsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\GetFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/GetFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified flow.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/UpdateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Flow', 'decode'],
        $metadata, $options);
    }

    /**
     * Trains the specified flow. Note that only the flow in 'draft' environment
     * is trained.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: An [Empty
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\TrainFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function TrainFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\TrainFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/TrainFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Validates the specified flow and creates or updates validation results.
     * Please call this API after the training is completed to get the complete
     * validation results.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ValidateFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ValidateFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\ValidateFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/ValidateFlow',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\FlowValidationResult', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the latest flow validation result. Flow validation is performed
     * when ValidateFlow is called.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetFlowValidationResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFlowValidationResult(\Google\Cloud\Dialogflow\Cx\V3beta1\GetFlowValidationResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/GetFlowValidationResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\FlowValidationResult', 'decode'],
        $metadata, $options);
    }

    /**
     * Imports the specified flow to the specified agent from a binary file.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [ImportFlowResponse][google.cloud.dialogflow.cx.v3beta1.ImportFlowResponse]
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ImportFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\ImportFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/ImportFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports the specified flow to a binary file.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [ExportFlowResponse][google.cloud.dialogflow.cx.v3beta1.ExportFlowResponse]
     *
     * Note that resources (e.g. intents, entities, webhooks) that the flow
     * references will also be exported.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ExportFlowRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportFlow(\Google\Cloud\Dialogflow\Cx\V3beta1\ExportFlowRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Flows/ExportFlow',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
