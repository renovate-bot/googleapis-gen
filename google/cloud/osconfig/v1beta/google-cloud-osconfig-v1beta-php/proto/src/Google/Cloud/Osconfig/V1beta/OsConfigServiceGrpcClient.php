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
namespace Google\Cloud\Osconfig\V1beta;

/**
 * OS Config API
 *
 * The OS Config service is a server-side component that you can use to
 * manage package installations and patch jobs for virtual machine instances.
 */
class OsConfigServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Patch VM instances by creating and running a patch job.
     * @param \Google\Cloud\Osconfig\V1beta\ExecutePatchJobRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExecutePatchJob(\Google\Cloud\Osconfig\V1beta\ExecutePatchJobRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/ExecutePatchJob',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\PatchJob', 'decode'],
        $metadata, $options);
    }

    /**
     * Get the patch job. This can be used to track the progress of an
     * ongoing patch job or review the details of completed jobs.
     * @param \Google\Cloud\Osconfig\V1beta\GetPatchJobRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPatchJob(\Google\Cloud\Osconfig\V1beta\GetPatchJobRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/GetPatchJob',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\PatchJob', 'decode'],
        $metadata, $options);
    }

    /**
     * Cancel a patch job. The patch job must be active. Canceled patch jobs
     * cannot be restarted.
     * @param \Google\Cloud\Osconfig\V1beta\CancelPatchJobRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CancelPatchJob(\Google\Cloud\Osconfig\V1beta\CancelPatchJobRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/CancelPatchJob',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\PatchJob', 'decode'],
        $metadata, $options);
    }

    /**
     * Get a list of patch jobs.
     * @param \Google\Cloud\Osconfig\V1beta\ListPatchJobsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPatchJobs(\Google\Cloud\Osconfig\V1beta\ListPatchJobsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchJobs',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\ListPatchJobsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Get a list of instance details for a given patch job.
     * @param \Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPatchJobInstanceDetails(\Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchJobInstanceDetails',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Create an OS Config patch deployment.
     * @param \Google\Cloud\Osconfig\V1beta\CreatePatchDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreatePatchDeployment(\Google\Cloud\Osconfig\V1beta\CreatePatchDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/CreatePatchDeployment',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\PatchDeployment', 'decode'],
        $metadata, $options);
    }

    /**
     * Get an OS Config patch deployment.
     * @param \Google\Cloud\Osconfig\V1beta\GetPatchDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPatchDeployment(\Google\Cloud\Osconfig\V1beta\GetPatchDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/GetPatchDeployment',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\PatchDeployment', 'decode'],
        $metadata, $options);
    }

    /**
     * Get a page of OS Config patch deployments.
     * @param \Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPatchDeployments(\Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/ListPatchDeployments',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Delete an OS Config patch deployment.
     * @param \Google\Cloud\Osconfig\V1beta\DeletePatchDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeletePatchDeployment(\Google\Cloud\Osconfig\V1beta\DeletePatchDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/DeletePatchDeployment',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Create an OS Config guest policy.
     * @param \Google\Cloud\Osconfig\V1beta\CreateGuestPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateGuestPolicy(\Google\Cloud\Osconfig\V1beta\CreateGuestPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/CreateGuestPolicy',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\GuestPolicy', 'decode'],
        $metadata, $options);
    }

    /**
     * Get an OS Config guest policy.
     * @param \Google\Cloud\Osconfig\V1beta\GetGuestPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetGuestPolicy(\Google\Cloud\Osconfig\V1beta\GetGuestPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/GetGuestPolicy',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\GuestPolicy', 'decode'],
        $metadata, $options);
    }

    /**
     * Get a page of OS Config guest policies.
     * @param \Google\Cloud\Osconfig\V1beta\ListGuestPoliciesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListGuestPolicies(\Google\Cloud\Osconfig\V1beta\ListGuestPoliciesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/ListGuestPolicies',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\ListGuestPoliciesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Update an OS Config guest policy.
     * @param \Google\Cloud\Osconfig\V1beta\UpdateGuestPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateGuestPolicy(\Google\Cloud\Osconfig\V1beta\UpdateGuestPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/UpdateGuestPolicy',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\GuestPolicy', 'decode'],
        $metadata, $options);
    }

    /**
     * Delete an OS Config guest policy.
     * @param \Google\Cloud\Osconfig\V1beta\DeleteGuestPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteGuestPolicy(\Google\Cloud\Osconfig\V1beta\DeleteGuestPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/DeleteGuestPolicy',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     * @param \Google\Cloud\Osconfig\V1beta\LookupEffectiveGuestPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LookupEffectiveGuestPolicy(\Google\Cloud\Osconfig\V1beta\LookupEffectiveGuestPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1beta.OsConfigService/LookupEffectiveGuestPolicy',
        $argument,
        ['\Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy', 'decode'],
        $metadata, $options);
    }

}
