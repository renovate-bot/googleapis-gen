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
namespace Google\Cloud\Asset\V1p1beta1;

/**
 * Asset service definition.
 */
class AssetServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Searches all the resources under a given accessible CRM scope
     * (project/folder/organization). This RPC gives callers
     * especially admins the ability to search all the resources under a scope,
     * even if they don't have .get permission of all the resources. Callers
     * should have cloud.assets.SearchAllResources permission on the requested
     * scope, otherwise it will be rejected.
     * @param \Google\Cloud\Asset\V1p1beta1\SearchAllResourcesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SearchAllResources(\Google\Cloud\Asset\V1p1beta1\SearchAllResourcesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p1beta1.AssetService/SearchAllResources',
        $argument,
        ['\Google\Cloud\Asset\V1p1beta1\SearchAllResourcesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Searches all the IAM policies under a given accessible CRM scope
     * (project/folder/organization). This RPC gives callers
     * especially admins the ability to search all the IAM policies under a scope,
     * even if they don't have .getIamPolicy permission of all the IAM policies.
     * Callers should have cloud.assets.SearchAllIamPolicies permission on the
     * requested scope, otherwise it will be rejected.
     * @param \Google\Cloud\Asset\V1p1beta1\SearchAllIamPoliciesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SearchAllIamPolicies(\Google\Cloud\Asset\V1p1beta1\SearchAllIamPoliciesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p1beta1.AssetService/SearchAllIamPolicies',
        $argument,
        ['\Google\Cloud\Asset\V1p1beta1\SearchAllIamPoliciesResponse', 'decode'],
        $metadata, $options);
    }

}
