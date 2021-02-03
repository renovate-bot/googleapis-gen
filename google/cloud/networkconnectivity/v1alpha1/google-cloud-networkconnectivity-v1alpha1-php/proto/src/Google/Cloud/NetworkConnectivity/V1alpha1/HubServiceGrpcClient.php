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
namespace Google\Cloud\NetworkConnectivity\V1alpha1;

/**
 * Network Connectivity Center is a hub-and-spoke abstraction for
 * network connectivity management in Google Cloud. It reduces
 * operational complexity through a simple, centralized connectivity management
 * model.
 */
class HubServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists Hubs in a given project and location.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\ListHubsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListHubs(\Google\Cloud\NetworkConnectivity\V1alpha1\ListHubsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/ListHubs',
        $argument,
        ['\Google\Cloud\NetworkConnectivity\V1alpha1\ListHubsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Hub.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\GetHubRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetHub(\Google\Cloud\NetworkConnectivity\V1alpha1\GetHubRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/GetHub',
        $argument,
        ['\Google\Cloud\NetworkConnectivity\V1alpha1\Hub', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Hub in a given project and location.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\CreateHubRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateHub(\Google\Cloud\NetworkConnectivity\V1alpha1\CreateHubRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/CreateHub',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the parameters of a single Hub.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\UpdateHubRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateHub(\Google\Cloud\NetworkConnectivity\V1alpha1\UpdateHubRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/UpdateHub',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single Hub.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\DeleteHubRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteHub(\Google\Cloud\NetworkConnectivity\V1alpha1\DeleteHubRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/DeleteHub',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Spokes in a given project and location.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\ListSpokesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListSpokes(\Google\Cloud\NetworkConnectivity\V1alpha1\ListSpokesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/ListSpokes',
        $argument,
        ['\Google\Cloud\NetworkConnectivity\V1alpha1\ListSpokesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Spoke.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\GetSpokeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetSpoke(\Google\Cloud\NetworkConnectivity\V1alpha1\GetSpokeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/GetSpoke',
        $argument,
        ['\Google\Cloud\NetworkConnectivity\V1alpha1\Spoke', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Spoke in a given project and location.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\CreateSpokeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateSpoke(\Google\Cloud\NetworkConnectivity\V1alpha1\CreateSpokeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/CreateSpoke',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the parameters of a single Spoke.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\UpdateSpokeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateSpoke(\Google\Cloud\NetworkConnectivity\V1alpha1\UpdateSpokeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/UpdateSpoke',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single Spoke.
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\DeleteSpokeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteSpoke(\Google\Cloud\NetworkConnectivity\V1alpha1\DeleteSpokeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkconnectivity.v1alpha1.HubService/DeleteSpoke',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
