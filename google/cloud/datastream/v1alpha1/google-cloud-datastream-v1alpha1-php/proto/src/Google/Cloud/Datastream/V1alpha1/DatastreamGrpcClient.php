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
namespace Google\Cloud\Datastream\V1alpha1;

/**
 * Datastream service
 */
class DatastreamGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Use this method to list connection profiles created in a project and
     * location.
     * @param \Google\Cloud\Datastream\V1alpha1\ListConnectionProfilesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListConnectionProfiles(\Google\Cloud\Datastream\V1alpha1\ListConnectionProfilesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/ListConnectionProfiles',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\ListConnectionProfilesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to get details about a connection profile.
     * @param \Google\Cloud\Datastream\V1alpha1\GetConnectionProfileRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetConnectionProfile(\Google\Cloud\Datastream\V1alpha1\GetConnectionProfileRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/GetConnectionProfile',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\ConnectionProfile', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to create a connection profile in a project and location.
     * @param \Google\Cloud\Datastream\V1alpha1\CreateConnectionProfileRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateConnectionProfile(\Google\Cloud\Datastream\V1alpha1\CreateConnectionProfileRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/CreateConnectionProfile',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to update the parameters of a connection profile.
     * @param \Google\Cloud\Datastream\V1alpha1\UpdateConnectionProfileRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateConnectionProfile(\Google\Cloud\Datastream\V1alpha1\UpdateConnectionProfileRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/UpdateConnectionProfile',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to delete a connection profile..
     * @param \Google\Cloud\Datastream\V1alpha1\DeleteConnectionProfileRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteConnectionProfile(\Google\Cloud\Datastream\V1alpha1\DeleteConnectionProfileRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/DeleteConnectionProfile',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to discover a connection profile.
     * The discover API call exposes the data objects and metadata belonging to
     * the profile. Typically, a request returns children data objects under a
     * parent data object that's optionally supplied in the request.
     * @param \Google\Cloud\Datastream\V1alpha1\DiscoverConnectionProfileRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DiscoverConnectionProfile(\Google\Cloud\Datastream\V1alpha1\DiscoverConnectionProfileRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/DiscoverConnectionProfile',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\DiscoverConnectionProfileResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to list streams in a project and location.
     * @param \Google\Cloud\Datastream\V1alpha1\ListStreamsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListStreams(\Google\Cloud\Datastream\V1alpha1\ListStreamsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/ListStreams',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\ListStreamsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to get details about a stream.
     * @param \Google\Cloud\Datastream\V1alpha1\GetStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetStream(\Google\Cloud\Datastream\V1alpha1\GetStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/GetStream',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\Stream', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to create a stream.
     * @param \Google\Cloud\Datastream\V1alpha1\CreateStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateStream(\Google\Cloud\Datastream\V1alpha1\CreateStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/CreateStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to update the configuration of a stream.
     * @param \Google\Cloud\Datastream\V1alpha1\UpdateStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateStream(\Google\Cloud\Datastream\V1alpha1\UpdateStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/UpdateStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to delete a stream.
     * @param \Google\Cloud\Datastream\V1alpha1\DeleteStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteStream(\Google\Cloud\Datastream\V1alpha1\DeleteStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/DeleteStream',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to fetch any errors associated with a stream.
     * @param \Google\Cloud\Datastream\V1alpha1\FetchErrorsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FetchErrors(\Google\Cloud\Datastream\V1alpha1\FetchErrorsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/FetchErrors',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * The FetchStaticIps API call exposes the static ips used by Datastream.
     * Typically, a request returns children data objects under
     * a parent data object that's optionally supplied in the request.
     * @param \Google\Cloud\Datastream\V1alpha1\FetchStaticIpsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FetchStaticIps(\Google\Cloud\Datastream\V1alpha1\FetchStaticIpsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/FetchStaticIps',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\FetchStaticIpsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to create a private connectivity configuration.
     * @param \Google\Cloud\Datastream\V1alpha1\CreatePrivateConnectionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreatePrivateConnection(\Google\Cloud\Datastream\V1alpha1\CreatePrivateConnectionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/CreatePrivateConnection',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to get details about a private connectivity configuration.
     * @param \Google\Cloud\Datastream\V1alpha1\GetPrivateConnectionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPrivateConnection(\Google\Cloud\Datastream\V1alpha1\GetPrivateConnectionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/GetPrivateConnection',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\PrivateConnection', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to list private connectivity configurations in a project
     * and location.
     * @param \Google\Cloud\Datastream\V1alpha1\ListPrivateConnectionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPrivateConnections(\Google\Cloud\Datastream\V1alpha1\ListPrivateConnectionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/ListPrivateConnections',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\ListPrivateConnectionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to delete a private connectivity configuration.
     * @param \Google\Cloud\Datastream\V1alpha1\DeletePrivateConnectionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeletePrivateConnection(\Google\Cloud\Datastream\V1alpha1\DeletePrivateConnectionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/DeletePrivateConnection',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to create a route for a private connectivity in a project
     * and location.
     * @param \Google\Cloud\Datastream\V1alpha1\CreateRouteRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateRoute(\Google\Cloud\Datastream\V1alpha1\CreateRouteRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/CreateRoute',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to get details about a route.
     * @param \Google\Cloud\Datastream\V1alpha1\GetRouteRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRoute(\Google\Cloud\Datastream\V1alpha1\GetRouteRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/GetRoute',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\Route', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to list routes created for a private connectivity in a
     * project and location.
     * @param \Google\Cloud\Datastream\V1alpha1\ListRoutesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRoutes(\Google\Cloud\Datastream\V1alpha1\ListRoutesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/ListRoutes',
        $argument,
        ['\Google\Cloud\Datastream\V1alpha1\ListRoutesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Use this method to delete a route.
     * @param \Google\Cloud\Datastream\V1alpha1\DeleteRouteRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteRoute(\Google\Cloud\Datastream\V1alpha1\DeleteRouteRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datastream.v1alpha1.Datastream/DeleteRoute',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
