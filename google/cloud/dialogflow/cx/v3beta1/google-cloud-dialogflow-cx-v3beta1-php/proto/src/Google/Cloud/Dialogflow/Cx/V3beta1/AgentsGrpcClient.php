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
 * Service for managing [Agents][google.cloud.dialogflow.cx.v3beta1.Agent].
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
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListAgentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListAgents(\Google\Cloud\Dialogflow\Cx\V3beta1\ListAgentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/ListAgents',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListAgentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\GetAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/GetAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an agent in the specified location.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/CreateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified agent.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/UpdateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Agent', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/DeleteAgent',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports the specified agent to a binary file.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ExportAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\ExportAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/ExportAgent',
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
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\RestoreAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RestoreAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\RestoreAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/RestoreAgent',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Validates the specified agent and creates or updates validation results.
     * The agent in draft version is validated. Please call this API after the
     * training is completed to get the complete validation results.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ValidateAgentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ValidateAgent(\Google\Cloud\Dialogflow\Cx\V3beta1\ValidateAgentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/ValidateAgent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\AgentValidationResult', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the latest agent validation result. Agent validation is performed
     * when ValidateAgent is called.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetAgentValidationResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetAgentValidationResult(\Google\Cloud\Dialogflow\Cx\V3beta1\GetAgentValidationResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Agents/GetAgentValidationResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\AgentValidationResult', 'decode'],
        $metadata, $options);
    }

}
