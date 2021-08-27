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
 * Service for managing [Agents][google.cloud.dialogflow.cx.v3.Agent].
 */
class AgentsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all agents in the specified location.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListAgentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListAgents(\Google\Cloud\Dialogflow\Cx\V3\ListAgentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/ListAgents',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListAgentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetAgent(\Google\Cloud\Dialogflow\Cx\V3\GetAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/GetAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an agent in the specified location.
     *
     * Note: You should always train flows prior to sending them queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateAgent(\Google\Cloud\Dialogflow\Cx\V3\CreateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/CreateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified agent.
     *
     * Note: You should always train flows prior to sending them queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateAgent(\Google\Cloud\Dialogflow\Cx\V3\UpdateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/UpdateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteAgent(\Google\Cloud\Dialogflow\Cx\V3\DeleteAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/DeleteAgent',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports the specified agent to a binary file.
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3.ExportAgentResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\ExportAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportAgent(\Google\Cloud\Dialogflow\Cx\V3\ExportAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/ExportAgent',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Restores the specified agent from a binary file.
     *
     * Replaces the current agent with a new one. Note that all existing resources
     * in agent (e.g. intents, entity types, flows) will be removed.
     *
     *
     * Note: You should always train flows prior to sending them queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3\RestoreAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RestoreAgent(\Google\Cloud\Dialogflow\Cx\V3\RestoreAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/RestoreAgent',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Validates the specified agent and creates or updates validation results.
     * The agent in draft version is validated. Please call this API after the
     * training is completed to get the complete validation results.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ValidateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ValidateAgent(\Google\Cloud\Dialogflow\Cx\V3\ValidateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/ValidateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\AgentValidationResult', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the latest agent validation result. Agent validation is performed
     * when ValidateAgent is called.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetAgentValidationResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetAgentValidationResult(\Google\Cloud\Dialogflow\Cx\V3\GetAgentValidationResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Agents/GetAgentValidationResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\AgentValidationResult', 'decode'],
        $metadata, $options);
    }

}
