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
namespace Google\Cloud\Tpu\V2alpha1;

/**
 * Manages TPU nodes and other resources
 *
 * TPU API v2alpha1
 */
class TpuGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists nodes.
     * @param \Google\Cloud\Tpu\V2alpha1\ListNodesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListNodes(\Google\Cloud\Tpu\V2alpha1\ListNodesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/ListNodes',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\ListNodesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the details of a node.
     * @param \Google\Cloud\Tpu\V2alpha1\GetNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetNode(\Google\Cloud\Tpu\V2alpha1\GetNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/GetNode',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\Node', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a node.
     * @param \Google\Cloud\Tpu\V2alpha1\CreateNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateNode(\Google\Cloud\Tpu\V2alpha1\CreateNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/CreateNode',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a node.
     * @param \Google\Cloud\Tpu\V2alpha1\DeleteNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteNode(\Google\Cloud\Tpu\V2alpha1\DeleteNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/DeleteNode',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Stops a node. This operation is only available with single TPU nodes.
     * @param \Google\Cloud\Tpu\V2alpha1\StopNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StopNode(\Google\Cloud\Tpu\V2alpha1\StopNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/StopNode',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Starts a node.
     * @param \Google\Cloud\Tpu\V2alpha1\StartNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartNode(\Google\Cloud\Tpu\V2alpha1\StartNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/StartNode',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the configurations of a node.
     * @param \Google\Cloud\Tpu\V2alpha1\UpdateNodeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateNode(\Google\Cloud\Tpu\V2alpha1\UpdateNodeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/UpdateNode',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Generates the Cloud TPU service identity for the project.
     * @param \Google\Cloud\Tpu\V2alpha1\GenerateServiceIdentityRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GenerateServiceIdentity(\Google\Cloud\Tpu\V2alpha1\GenerateServiceIdentityRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/GenerateServiceIdentity',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\GenerateServiceIdentityResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists accelerator types supported by this API.
     * @param \Google\Cloud\Tpu\V2alpha1\ListAcceleratorTypesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListAcceleratorTypes(\Google\Cloud\Tpu\V2alpha1\ListAcceleratorTypesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/ListAcceleratorTypes',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\ListAcceleratorTypesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets AcceleratorType.
     * @param \Google\Cloud\Tpu\V2alpha1\GetAcceleratorTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetAcceleratorType(\Google\Cloud\Tpu\V2alpha1\GetAcceleratorTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/GetAcceleratorType',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\AcceleratorType', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists runtime versions supported by this API.
     * @param \Google\Cloud\Tpu\V2alpha1\ListRuntimeVersionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRuntimeVersions(\Google\Cloud\Tpu\V2alpha1\ListRuntimeVersionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/ListRuntimeVersions',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\ListRuntimeVersionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a runtime version.
     * @param \Google\Cloud\Tpu\V2alpha1\GetRuntimeVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRuntimeVersion(\Google\Cloud\Tpu\V2alpha1\GetRuntimeVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/GetRuntimeVersion',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\RuntimeVersion', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the guest attributes for the node.
     * @param \Google\Cloud\Tpu\V2alpha1\GetGuestAttributesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGuestAttributes(\Google\Cloud\Tpu\V2alpha1\GetGuestAttributesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.tpu.v2alpha1.Tpu/GetGuestAttributes',
        $argument,
        ['\Google\Cloud\Tpu\V2alpha1\GetGuestAttributesResponse', 'decode'],
        $metadata, $options);
    }

}
