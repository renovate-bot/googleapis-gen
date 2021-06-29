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
namespace Google\Cloud\DataFusion\V1beta1;

/**
 * Service for creating and managing Data Fusion instances.
 * Data Fusion enables ETL developers to build code-free, data integration
 * pipelines via a point-and-click UI.
 */
class DataFusionGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists possible versions for Data Fusion instances in the specified project
     * and location.
     * @param \Google\Cloud\DataFusion\V1beta1\ListAvailableVersionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListAvailableVersions(\Google\Cloud\DataFusion\V1beta1\ListAvailableVersionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/ListAvailableVersions',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\ListAvailableVersionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Data Fusion instances in the specified project and location.
     * @param \Google\Cloud\DataFusion\V1beta1\ListInstancesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListInstances(\Google\Cloud\DataFusion\V1beta1\ListInstancesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/ListInstances',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\ListInstancesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Data Fusion instance.
     * @param \Google\Cloud\DataFusion\V1beta1\GetInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetInstance(\Google\Cloud\DataFusion\V1beta1\GetInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/GetInstance',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\Instance', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Data Fusion instance in the specified project and location.
     * @param \Google\Cloud\DataFusion\V1beta1\CreateInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateInstance(\Google\Cloud\DataFusion\V1beta1\CreateInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/CreateInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a single Data Fusion instance.
     * @param \Google\Cloud\DataFusion\V1beta1\DeleteInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteInstance(\Google\Cloud\DataFusion\V1beta1\DeleteInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/DeleteInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a single Data Fusion instance.
     * @param \Google\Cloud\DataFusion\V1beta1\UpdateInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateInstance(\Google\Cloud\DataFusion\V1beta1\UpdateInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/UpdateInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Restart a single Data Fusion instance.
     * At the end of an operation instance is fully restarted.
     * @param \Google\Cloud\DataFusion\V1beta1\RestartInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RestartInstance(\Google\Cloud\DataFusion\V1beta1\RestartInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/RestartInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Upgrade a single Data Fusion instance.
     * At the end of an operation instance is fully upgraded.
     * @param \Google\Cloud\DataFusion\V1beta1\UpgradeInstanceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpgradeInstance(\Google\Cloud\DataFusion\V1beta1\UpgradeInstanceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/UpgradeInstance',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Remove IAM policy that is currently set on the given resource.
     * @param \Google\Cloud\DataFusion\V1beta1\RemoveIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RemoveIamPolicy(\Google\Cloud\DataFusion\V1beta1\RemoveIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/RemoveIamPolicy',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\RemoveIamPolicyResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * List namespaces in a given instance
     * @param \Google\Cloud\DataFusion\V1beta1\ListNamespacesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListNamespaces(\Google\Cloud\DataFusion\V1beta1\ListNamespacesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/ListNamespaces',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\ListNamespacesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Add DNS peering on the given resource.
     * @param \Google\Cloud\DataFusion\V1beta1\AddDnsPeeringRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AddDnsPeering(\Google\Cloud\DataFusion\V1beta1\AddDnsPeeringRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/AddDnsPeering',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\AddDnsPeeringResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Remove DNS peering on the given resource.
     * @param \Google\Cloud\DataFusion\V1beta1\RemoveDnsPeeringRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RemoveDnsPeering(\Google\Cloud\DataFusion\V1beta1\RemoveDnsPeeringRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/RemoveDnsPeering',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\RemoveDnsPeeringResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * List DNS peering for a given resource.
     * @param \Google\Cloud\DataFusion\V1beta1\ListDnsPeeringsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDnsPeerings(\Google\Cloud\DataFusion\V1beta1\ListDnsPeeringsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datafusion.v1beta1.DataFusion/ListDnsPeerings',
        $argument,
        ['\Google\Cloud\DataFusion\V1beta1\ListDnsPeeringsResponse', 'decode'],
        $metadata, $options);
    }

}
