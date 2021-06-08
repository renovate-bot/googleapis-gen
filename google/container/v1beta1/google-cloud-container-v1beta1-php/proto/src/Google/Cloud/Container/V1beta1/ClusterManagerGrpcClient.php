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
namespace Google\Cloud\Container\V1beta1;

/**
 * Google Kubernetes Engine Cluster Manager v1beta1
 */
class ClusterManagerGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists all clusters owned by a project in either the specified zone or all
     * zones.
     * @param \Google\Cloud\Container\V1beta1\ListClustersRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListClusters(\Google\Cloud\Container\V1beta1\ListClustersRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/ListClusters',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ListClustersResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the details for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\GetClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetCluster(\Google\Cloud\Container\V1beta1\GetClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/GetCluster',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Cluster', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a cluster, consisting of the specified number and type of Google
     * Compute Engine instances.
     *
     * By default, the cluster is created in the project's
     * [default
     * network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
     *
     * One firewall is added for the cluster. After cluster creation,
     * the Kubelet creates routes for each node to allow the containers
     * on that node to communicate with all other instances in the
     * cluster.
     *
     * Finally, an entry is added to the project's global metadata indicating
     * which CIDR range the cluster is using.
     * @param \Google\Cloud\Container\V1beta1\CreateClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateCluster(\Google\Cloud\Container\V1beta1\CreateClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/CreateCluster',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the settings for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\UpdateClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateCluster(\Google\Cloud\Container\V1beta1\UpdateClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/UpdateCluster',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the version and/or image type of a specific node pool.
     * @param \Google\Cloud\Container\V1beta1\UpdateNodePoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateNodePool(\Google\Cloud\Container\V1beta1\UpdateNodePoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/UpdateNodePool',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the autoscaling settings of a specific node pool.
     * @param \Google\Cloud\Container\V1beta1\SetNodePoolAutoscalingRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetNodePoolAutoscaling(\Google\Cloud\Container\V1beta1\SetNodePoolAutoscalingRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetNodePoolAutoscaling',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the logging service for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\SetLoggingServiceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetLoggingService(\Google\Cloud\Container\V1beta1\SetLoggingServiceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetLoggingService',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the monitoring service for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\SetMonitoringServiceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetMonitoringService(\Google\Cloud\Container\V1beta1\SetMonitoringServiceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetMonitoringService',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the addons for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\SetAddonsConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetAddonsConfig(\Google\Cloud\Container\V1beta1\SetAddonsConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetAddonsConfig',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the locations for a specific cluster.
     * Deprecated. Use
     * [projects.locations.clusters.update](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1beta1/projects.locations.clusters/update)
     * instead.
     * @param \Google\Cloud\Container\V1beta1\SetLocationsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetLocations(\Google\Cloud\Container\V1beta1\SetLocationsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetLocations',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the master for a specific cluster.
     * @param \Google\Cloud\Container\V1beta1\UpdateMasterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateMaster(\Google\Cloud\Container\V1beta1\UpdateMasterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/UpdateMaster',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets master auth materials. Currently supports changing the admin password
     * or a specific cluster, either via password generation or explicitly setting
     * the password.
     * @param \Google\Cloud\Container\V1beta1\SetMasterAuthRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetMasterAuth(\Google\Cloud\Container\V1beta1\SetMasterAuthRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetMasterAuth',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the cluster, including the Kubernetes endpoint and all worker
     * nodes.
     *
     * Firewalls and routes that were configured during cluster creation
     * are also deleted.
     *
     * Other Google Compute Engine resources that might be in use by the cluster,
     * such as load balancer resources, are not deleted if they weren't present
     * when the cluster was initially created.
     * @param \Google\Cloud\Container\V1beta1\DeleteClusterRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteCluster(\Google\Cloud\Container\V1beta1\DeleteClusterRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/DeleteCluster',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all operations in a project in the specified zone or all zones.
     * @param \Google\Cloud\Container\V1beta1\ListOperationsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListOperations(\Google\Cloud\Container\V1beta1\ListOperationsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/ListOperations',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ListOperationsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the specified operation.
     * @param \Google\Cloud\Container\V1beta1\GetOperationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetOperation(\Google\Cloud\Container\V1beta1\GetOperationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/GetOperation',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Cancels the specified operation.
     * @param \Google\Cloud\Container\V1beta1\CancelOperationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CancelOperation(\Google\Cloud\Container\V1beta1\CancelOperationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/CancelOperation',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns configuration info about the Google Kubernetes Engine service.
     * @param \Google\Cloud\Container\V1beta1\GetServerConfigRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetServerConfig(\Google\Cloud\Container\V1beta1\GetServerConfigRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/GetServerConfig',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ServerConfig', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists the node pools for a cluster.
     * @param \Google\Cloud\Container\V1beta1\ListNodePoolsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListNodePools(\Google\Cloud\Container\V1beta1\ListNodePoolsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/ListNodePools',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ListNodePoolsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the public component of the cluster signing keys in
     * JSON Web Key format.
     * This API is not yet intended for general use, and is not available for all
     * clusters.
     * @param \Google\Cloud\Container\V1beta1\GetJSONWebKeysRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetJSONWebKeys(\Google\Cloud\Container\V1beta1\GetJSONWebKeysRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/GetJSONWebKeys',
        $argument,
        ['\Google\Cloud\Container\V1beta1\GetJSONWebKeysResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the requested node pool.
     * @param \Google\Cloud\Container\V1beta1\GetNodePoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetNodePool(\Google\Cloud\Container\V1beta1\GetNodePoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/GetNodePool',
        $argument,
        ['\Google\Cloud\Container\V1beta1\NodePool', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a node pool for a cluster.
     * @param \Google\Cloud\Container\V1beta1\CreateNodePoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateNodePool(\Google\Cloud\Container\V1beta1\CreateNodePoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/CreateNodePool',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a node pool from a cluster.
     * @param \Google\Cloud\Container\V1beta1\DeleteNodePoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteNodePool(\Google\Cloud\Container\V1beta1\DeleteNodePoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/DeleteNodePool',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Rolls back a previously Aborted or Failed NodePool upgrade.
     * This makes no changes if the last upgrade successfully completed.
     * @param \Google\Cloud\Container\V1beta1\RollbackNodePoolUpgradeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RollbackNodePoolUpgrade(\Google\Cloud\Container\V1beta1\RollbackNodePoolUpgradeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/RollbackNodePoolUpgrade',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the NodeManagement options for a node pool.
     * @param \Google\Cloud\Container\V1beta1\SetNodePoolManagementRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetNodePoolManagement(\Google\Cloud\Container\V1beta1\SetNodePoolManagementRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetNodePoolManagement',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets labels on a cluster.
     * @param \Google\Cloud\Container\V1beta1\SetLabelsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetLabels(\Google\Cloud\Container\V1beta1\SetLabelsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetLabels',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Enables or disables the ABAC authorization mechanism on a cluster.
     * @param \Google\Cloud\Container\V1beta1\SetLegacyAbacRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetLegacyAbac(\Google\Cloud\Container\V1beta1\SetLegacyAbacRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetLegacyAbac',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Starts master IP rotation.
     * @param \Google\Cloud\Container\V1beta1\StartIPRotationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartIPRotation(\Google\Cloud\Container\V1beta1\StartIPRotationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/StartIPRotation',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Completes master IP rotation.
     * @param \Google\Cloud\Container\V1beta1\CompleteIPRotationRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CompleteIPRotation(\Google\Cloud\Container\V1beta1\CompleteIPRotationRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/CompleteIPRotation',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the size for a specific node pool.
     * @param \Google\Cloud\Container\V1beta1\SetNodePoolSizeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetNodePoolSize(\Google\Cloud\Container\V1beta1\SetNodePoolSizeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetNodePoolSize',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Enables or disables Network Policy for a cluster.
     * @param \Google\Cloud\Container\V1beta1\SetNetworkPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetNetworkPolicy(\Google\Cloud\Container\V1beta1\SetNetworkPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetNetworkPolicy',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the maintenance policy for a cluster.
     * @param \Google\Cloud\Container\V1beta1\SetMaintenancePolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetMaintenancePolicy(\Google\Cloud\Container\V1beta1\SetMaintenancePolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/SetMaintenancePolicy',
        $argument,
        ['\Google\Cloud\Container\V1beta1\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists subnetworks that can be used for creating clusters in a project.
     * @param \Google\Cloud\Container\V1beta1\ListUsableSubnetworksRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListUsableSubnetworks(\Google\Cloud\Container\V1beta1\ListUsableSubnetworksRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/ListUsableSubnetworks',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ListUsableSubnetworksResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches locations that offer Google Kubernetes Engine.
     * @param \Google\Cloud\Container\V1beta1\ListLocationsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListLocations(\Google\Cloud\Container\V1beta1\ListLocationsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.container.v1beta1.ClusterManager/ListLocations',
        $argument,
        ['\Google\Cloud\Container\V1beta1\ListLocationsResponse', 'decode'],
        $metadata, $options);
    }

}
