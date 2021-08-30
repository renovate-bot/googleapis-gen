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
namespace Google\Cloud\GkeHub\V1alpha2;

/**
 * The GKE Hub service handles the registration of many Kubernetes
 * clusters to Google Cloud, represented with the [Membership][google.cloud.gkehub.v1alpha2.Membership] resource.
 *
 * GKE Hub is currently only available in the global region.
 *
 * **Membership management may be non-trivial:** it is recommended to use one
 * of the Google-provided client libraries or tools where possible when working
 * with Membership resources.
 */
class GkeHubGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists Memberships in a given project and location.
     * @param \Google\Cloud\GkeHub\V1alpha2\ListMembershipsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListMemberships(\Google\Cloud\GkeHub\V1alpha2\ListMembershipsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/ListMemberships',
        $argument,
        ['\Google\Cloud\GkeHub\V1alpha2\ListMembershipsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the details of a Membership.
     * @param \Google\Cloud\GkeHub\V1alpha2\GetMembershipRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetMembership(\Google\Cloud\GkeHub\V1alpha2\GetMembershipRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/GetMembership',
        $argument,
        ['\Google\Cloud\GkeHub\V1alpha2\Membership', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new Membership.
     *
     * **This is currently only supported for GKE clusters on Google Cloud**.
     * To register other clusters, follow the instructions at
     * https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
     * @param \Google\Cloud\GkeHub\V1alpha2\CreateMembershipRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateMembership(\Google\Cloud\GkeHub\V1alpha2\CreateMembershipRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/CreateMembership',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Removes a Membership.
     *
     * **This is currently only supported for GKE clusters on Google Cloud**.
     * To unregister other clusters, follow the instructions at
     * https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
     * @param \Google\Cloud\GkeHub\V1alpha2\DeleteMembershipRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteMembership(\Google\Cloud\GkeHub\V1alpha2\DeleteMembershipRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/DeleteMembership',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an existing Membership.
     * @param \Google\Cloud\GkeHub\V1alpha2\UpdateMembershipRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateMembership(\Google\Cloud\GkeHub\V1alpha2\UpdateMembershipRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/UpdateMembership',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Generates the manifest for deployment of the GKE connect agent.
     *
     * **This method is used internally by Google-provided libraries.**
     * Most clients should not need to call this method directly.
     * @param \Google\Cloud\GkeHub\V1alpha2\GenerateConnectManifestRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GenerateConnectManifest(\Google\Cloud\GkeHub\V1alpha2\GenerateConnectManifestRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/GenerateConnectManifest',
        $argument,
        ['\Google\Cloud\GkeHub\V1alpha2\GenerateConnectManifestResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Initializes the Hub in this project, which includes creating the default
     * Hub Service Account and the Hub Workload Identity Pool. Initialization is
     * optional, and happens automatically when the first Membership is created.
     *
     * InitializeHub should be called when the first Membership cannot be
     * registered without these resources. A common example is granting the Hub
     * Service Account access to another project, which requires the account to
     * exist first.
     * @param \Google\Cloud\GkeHub\V1alpha2\InitializeHubRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function InitializeHub(\Google\Cloud\GkeHub\V1alpha2\InitializeHubRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1alpha2.GkeHub/InitializeHub',
        $argument,
        ['\Google\Cloud\GkeHub\V1alpha2\InitializeHubResponse', 'decode'],
        $metadata, $options);
    }

}
