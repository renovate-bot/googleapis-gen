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
 * The game server cluster maps to Kubernetes clusters running Agones and is
 * used to manage fleets within clusters.
 */
class GameServerClustersServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists game server clusters in a given project and location.
     * @param \Google\Cloud\Gaming\V1beta\ListGameServerClustersRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListGameServerClusters(\Google\Cloud\Gaming\V1beta\ListGameServerClustersRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/ListGameServerClusters',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\ListGameServerClustersResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single game server cluster.
     * @param \Google\Cloud\Gaming\V1beta\GetGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGameServerCluster(\Google\Cloud\Gaming\V1beta\GetGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/GetGameServerCluster',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\GameServerCluster', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new game server cluster in a given project and location.
     * @param \Google\Cloud\Gaming\V1beta\CreateGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateGameServerCluster(\Google\Cloud\Gaming\V1beta\CreateGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/CreateGameServerCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Previews creation of a new game server cluster in a given project and
     * location.
     * @param \Google\Cloud\Gaming\V1beta\PreviewCreateGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function PreviewCreateGameServerCluster(\Google\Cloud\Gaming\V1beta\PreviewCreateGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/PreviewCreateGameServerCluster',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\PreviewCreateGameServerClusterResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single game server cluster.
     * @param \Google\Cloud\Gaming\V1beta\DeleteGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteGameServerCluster(\Google\Cloud\Gaming\V1beta\DeleteGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/DeleteGameServerCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Previews deletion of a single game server cluster.
     * @param \Google\Cloud\Gaming\V1beta\PreviewDeleteGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function PreviewDeleteGameServerCluster(\Google\Cloud\Gaming\V1beta\PreviewDeleteGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/PreviewDeleteGameServerCluster',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\PreviewDeleteGameServerClusterResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Patches a single game server cluster.
     * @param \Google\Cloud\Gaming\V1beta\UpdateGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateGameServerCluster(\Google\Cloud\Gaming\V1beta\UpdateGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/UpdateGameServerCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Previews updating a GameServerCluster.
     * @param \Google\Cloud\Gaming\V1beta\PreviewUpdateGameServerClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function PreviewUpdateGameServerCluster(\Google\Cloud\Gaming\V1beta\PreviewUpdateGameServerClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gaming.v1beta.GameServerClustersService/PreviewUpdateGameServerCluster',
        $argument,
        ['\Google\Cloud\Gaming\V1beta\PreviewUpdateGameServerClusterResponse', 'decode'],
        $metadata, $options);
    }

}
