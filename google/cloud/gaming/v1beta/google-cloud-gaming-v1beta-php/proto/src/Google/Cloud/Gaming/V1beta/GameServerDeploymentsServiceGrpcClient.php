<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2020 Google LLC
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
namespace Google\Cloud\Gaming\V1beta;

/**
 * The game server deployment is used to control the deployment of Agones
 * fleets.
 */
class GameServerDeploymentsServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists game server deployments in a given project and location.
     * @param \Google\Cloud\Gaming\V1beta\ListGameServerDeploymentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListGameServerDeployments(\Google\Cloud\Gaming\V1beta\ListGameServerDeploymentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/ListGameServerDeployments',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\ListGameServerDeploymentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single game server deployment.
     * @param \Google\Cloud\Gaming\V1beta\GetGameServerDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGameServerDeployment(\Google\Cloud\Gaming\V1beta\GetGameServerDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/GetGameServerDeployment',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\GameServerDeployment', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new game server deployment in a given project and location.
     * @param \Google\Cloud\Gaming\V1beta\CreateGameServerDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateGameServerDeployment(\Google\Cloud\Gaming\V1beta\CreateGameServerDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/CreateGameServerDeployment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single game server deployment.
     * @param \Google\Cloud\Gaming\V1beta\DeleteGameServerDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteGameServerDeployment(\Google\Cloud\Gaming\V1beta\DeleteGameServerDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/DeleteGameServerDeployment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Patches a game server deployment.
     * @param \Google\Cloud\Gaming\V1beta\UpdateGameServerDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateGameServerDeployment(\Google\Cloud\Gaming\V1beta\UpdateGameServerDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/UpdateGameServerDeployment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details a single game server deployment rollout.
     * @param \Google\Cloud\Gaming\V1beta\GetGameServerDeploymentRolloutRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGameServerDeploymentRollout(\Google\Cloud\Gaming\V1beta\GetGameServerDeploymentRolloutRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/GetGameServerDeploymentRollout',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\GameServerDeploymentRollout', 'decode'],
        $metadata, $options);
    }

    /**
     * Patches a single game server deployment rollout.
     * The method will not return an error if the update does not affect any
     * existing realms. For example - if the default_game_server_config is changed
     * but all existing realms use the override, that is valid. Similarly, if a
     * non existing realm is explicitly called out in game_server_config_overrides
     * field, that will also not result in an error.
     * @param \Google\Cloud\Gaming\V1beta\UpdateGameServerDeploymentRolloutRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateGameServerDeploymentRollout(\Google\Cloud\Gaming\V1beta\UpdateGameServerDeploymentRolloutRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/UpdateGameServerDeploymentRollout',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Previews the game server deployment rollout. This API does not mutate the
     * rollout resource.
     * @param \Google\Cloud\Gaming\V1beta\PreviewGameServerDeploymentRolloutRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function PreviewGameServerDeploymentRollout(\Google\Cloud\Gaming\V1beta\PreviewGameServerDeploymentRolloutRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/PreviewGameServerDeploymentRollout',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\PreviewGameServerDeploymentRolloutResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves information about the current state of the game server
     * deployment. Gathers all the Agones fleets and Agones autoscalers,
     * including fleets running an older version of the game server deployment.
     * @param \Google\Cloud\Gaming\V1beta\FetchDeploymentStateRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FetchDeploymentState(\Google\Cloud\Gaming\V1beta\FetchDeploymentStateRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerDeploymentsService/FetchDeploymentState',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\FetchDeploymentStateResponse', 'decode'],
        $metadata, $options);
    }

}
