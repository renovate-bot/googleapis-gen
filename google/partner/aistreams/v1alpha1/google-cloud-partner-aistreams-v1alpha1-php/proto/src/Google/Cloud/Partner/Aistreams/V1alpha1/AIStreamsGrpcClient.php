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
namespace Google\Cloud\Partner\Aistreams\V1alpha1;

/**
 * AIStreams service.
 */
class AIStreamsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists Clusters in a given project and location.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\ListClustersRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListClusters(\Google\Cloud\Partner\Aistreams\V1alpha1\ListClustersRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/ListClusters',
        $argument,
        ['\Google\Cloud\Partner\Aistreams\V1alpha1\ListClustersResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Cluster.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\GetClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetCluster(\Google\Cloud\Partner\Aistreams\V1alpha1\GetClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/GetCluster',
        $argument,
        ['\Google\Cloud\Partner\Aistreams\V1alpha1\Cluster', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Cluster in a given project and location.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\CreateClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateCluster(\Google\Cloud\Partner\Aistreams\V1alpha1\CreateClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/CreateCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the parameters of a single Cluster.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\UpdateClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateCluster(\Google\Cloud\Partner\Aistreams\V1alpha1\UpdateClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/UpdateCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single Cluster.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\DeleteClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteCluster(\Google\Cloud\Partner\Aistreams\V1alpha1\DeleteClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/DeleteCluster',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Streams in a given project, location and cluster.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\ListStreamsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListStreams(\Google\Cloud\Partner\Aistreams\V1alpha1\ListStreamsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/ListStreams',
        $argument,
        ['\Google\Cloud\Partner\Aistreams\V1alpha1\ListStreamsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Stream.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\GetStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetStream(\Google\Cloud\Partner\Aistreams\V1alpha1\GetStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/GetStream',
        $argument,
        ['\Google\Cloud\Partner\Aistreams\V1alpha1\Stream', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Stream in a given project and location.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\CreateStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateStream(\Google\Cloud\Partner\Aistreams\V1alpha1\CreateStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/CreateStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the parameters of a single Stream.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\UpdateStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateStream(\Google\Cloud\Partner\Aistreams\V1alpha1\UpdateStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/UpdateStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single Stream.
     * @param \Google\Cloud\Partner\Aistreams\V1alpha1\DeleteStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteStream(\Google\Cloud\Partner\Aistreams\V1alpha1\DeleteStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.partner.aistreams.v1alpha1.AIStreams/DeleteStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
