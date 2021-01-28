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
 * The game server config configures the game servers in an Agones fleet.
 */
class GameServerConfigsServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists game server configs in a given project, location, and game server
     * deployment.
     * @param \Google\Cloud\Gaming\V1beta\ListGameServerConfigsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListGameServerConfigs(\Google\Cloud\Gaming\V1beta\ListGameServerConfigsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerConfigsService/ListGameServerConfigs',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\ListGameServerConfigsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single game server config.
     * @param \Google\Cloud\Gaming\V1beta\GetGameServerConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGameServerConfig(\Google\Cloud\Gaming\V1beta\GetGameServerConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerConfigsService/GetGameServerConfig',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\GameServerConfig', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new game server config in a given project, location, and game
     * server deployment. Game server configs are immutable, and are not applied
     * until referenced in the game server deployment rollout resource.
     * @param \Google\Cloud\Gaming\V1beta\CreateGameServerConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateGameServerConfig(\Google\Cloud\Gaming\V1beta\CreateGameServerConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerConfigsService/CreateGameServerConfig',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single game server config. The deletion will fail if the game
     * server config is referenced in a game server deployment rollout.
     * @param \Google\Cloud\Gaming\V1beta\DeleteGameServerConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteGameServerConfig(\Google\Cloud\Gaming\V1beta\DeleteGameServerConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerConfigsService/DeleteGameServerConfig',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
