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
namespace Google\Iam\V1beta;

/**
 * Manages WorkloadIdentityPools.
 */
class WorkloadIdentityPoolsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists all non-deleted
     * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
     * project. If `show_deleted` is set to `true`, then deleted pools are also
     * listed.
     * @param \Google\Iam\V1beta\ListWorkloadIdentityPoolsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListWorkloadIdentityPools(\Google\Iam\V1beta\ListWorkloadIdentityPoolsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/ListWorkloadIdentityPools',
        $argument,
        ['\Google\Iam\V1beta\ListWorkloadIdentityPoolsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets an individual
     * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     * @param \Google\Iam\V1beta\GetWorkloadIdentityPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetWorkloadIdentityPool(\Google\Iam\V1beta\GetWorkloadIdentityPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/GetWorkloadIdentityPool',
        $argument,
        ['\Google\Iam\V1beta\WorkloadIdentityPool', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new
     * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     *
     * You cannot reuse the name of a deleted pool until 30 days after deletion.
     * @param \Google\Iam\V1beta\CreateWorkloadIdentityPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateWorkloadIdentityPool(\Google\Iam\V1beta\CreateWorkloadIdentityPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/CreateWorkloadIdentityPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an existing
     * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     * @param \Google\Iam\V1beta\UpdateWorkloadIdentityPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateWorkloadIdentityPool(\Google\Iam\V1beta\UpdateWorkloadIdentityPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/UpdateWorkloadIdentityPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a
     * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     *
     * You cannot use a deleted pool to exchange external
     * credentials for Google Cloud credentials. However, deletion does
     * not revoke credentials that have already been issued.
     * Credentials issued for a deleted pool do not grant access to resources.
     * If the pool is undeleted, and the credentials are not expired, they
     * grant access again.
     * You can undelete a pool for 30 days. After 30 days, deletion is
     * permanent.
     * You cannot update deleted pools. However, you can view and list them.
     * @param \Google\Iam\V1beta\DeleteWorkloadIdentityPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteWorkloadIdentityPool(\Google\Iam\V1beta\DeleteWorkloadIdentityPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/DeleteWorkloadIdentityPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool],
     * as long as it was deleted fewer than 30 days ago.
     * @param \Google\Iam\V1beta\UndeleteWorkloadIdentityPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UndeleteWorkloadIdentityPool(\Google\Iam\V1beta\UndeleteWorkloadIdentityPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/UndeleteWorkloadIdentityPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all non-deleted
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s
     * in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     * If `show_deleted` is set to `true`, then deleted providers are also listed.
     * @param \Google\Iam\V1beta\ListWorkloadIdentityPoolProvidersRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListWorkloadIdentityPoolProviders(\Google\Iam\V1beta\ListWorkloadIdentityPoolProvidersRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/ListWorkloadIdentityPoolProviders',
        $argument,
        ['\Google\Iam\V1beta\ListWorkloadIdentityPoolProvidersResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets an individual
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
     * @param \Google\Iam\V1beta\GetWorkloadIdentityPoolProviderRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetWorkloadIdentityPoolProvider(\Google\Iam\V1beta\GetWorkloadIdentityPoolProviderRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/GetWorkloadIdentityPoolProvider',
        $argument,
        ['\Google\Iam\V1beta\WorkloadIdentityPoolProvider', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]
     * in a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
     *
     * You cannot reuse the name of a deleted provider until 30 days after
     * deletion.
     * @param \Google\Iam\V1beta\CreateWorkloadIdentityPoolProviderRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateWorkloadIdentityPoolProvider(\Google\Iam\V1beta\CreateWorkloadIdentityPoolProviderRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/CreateWorkloadIdentityPoolProvider',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an existing
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
     * @param \Google\Iam\V1beta\UpdateWorkloadIdentityPoolProviderRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateWorkloadIdentityPoolProvider(\Google\Iam\V1beta\UpdateWorkloadIdentityPoolProviderRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/UpdateWorkloadIdentityPoolProvider',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
     * Deleting a provider does not revoke credentials that have already been
     * issued; they continue to grant access.
     * You can undelete a provider for 30 days. After 30 days, deletion is
     * permanent.
     * You cannot update deleted providers. However, you can view and list them.
     * @param \Google\Iam\V1beta\DeleteWorkloadIdentityPoolProviderRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteWorkloadIdentityPoolProvider(\Google\Iam\V1beta\DeleteWorkloadIdentityPoolProviderRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/DeleteWorkloadIdentityPoolProvider',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Undeletes a
     * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider],
     * as long as it was deleted fewer than 30 days ago.
     * @param \Google\Iam\V1beta\UndeleteWorkloadIdentityPoolProviderRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UndeleteWorkloadIdentityPoolProvider(\Google\Iam\V1beta\UndeleteWorkloadIdentityPoolProviderRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.v1beta.WorkloadIdentityPools/UndeleteWorkloadIdentityPoolProvider',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
