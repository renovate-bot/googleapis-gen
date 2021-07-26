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
namespace Google\Cloud\NetworkServices\V1beta1;

/**
 */
class NetworkServicesGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists EndpointPolicies in a given project and location.
     * @param \Google\Cloud\NetworkServices\V1beta1\ListEndpointPoliciesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListEndpointPolicies(\Google\Cloud\NetworkServices\V1beta1\ListEndpointPoliciesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkservices.v1beta1.NetworkServices/ListEndpointPolicies',
        $argument,
        ['\Google\Cloud\NetworkServices\V1beta1\ListEndpointPoliciesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single EndpointPolicy.
     * @param \Google\Cloud\NetworkServices\V1beta1\GetEndpointPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetEndpointPolicy(\Google\Cloud\NetworkServices\V1beta1\GetEndpointPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkservices.v1beta1.NetworkServices/GetEndpointPolicy',
        $argument,
        ['\Google\Cloud\NetworkServices\V1beta1\EndpointPolicy', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new EndpointPolicy in a given project and location.
     * @param \Google\Cloud\NetworkServices\V1beta1\CreateEndpointPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateEndpointPolicy(\Google\Cloud\NetworkServices\V1beta1\CreateEndpointPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkservices.v1beta1.NetworkServices/CreateEndpointPolicy',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the parameters of a single EndpointPolicy.
     * @param \Google\Cloud\NetworkServices\V1beta1\UpdateEndpointPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateEndpointPolicy(\Google\Cloud\NetworkServices\V1beta1\UpdateEndpointPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkservices.v1beta1.NetworkServices/UpdateEndpointPolicy',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single EndpointPolicy.
     * @param \Google\Cloud\NetworkServices\V1beta1\DeleteEndpointPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteEndpointPolicy(\Google\Cloud\NetworkServices\V1beta1\DeleteEndpointPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.networkservices.v1beta1.NetworkServices/DeleteEndpointPolicy',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
