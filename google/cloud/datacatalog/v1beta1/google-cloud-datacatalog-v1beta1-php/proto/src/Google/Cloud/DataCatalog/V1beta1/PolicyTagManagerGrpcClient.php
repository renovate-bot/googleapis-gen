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
namespace Google\Cloud\DataCatalog\V1beta1;

/**
 * The policy tag manager API service allows clients to manage their taxonomies
 * and policy tags.
 */
class PolicyTagManagerGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a taxonomy in the specified project.
     * @param \Google\Cloud\DataCatalog\V1beta1\CreateTaxonomyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTaxonomy(\Google\Cloud\DataCatalog\V1beta1\CreateTaxonomyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/CreateTaxonomy',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\Taxonomy', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a taxonomy. This operation will also delete all
     * policy tags in this taxonomy along with their associated policies.
     * @param \Google\Cloud\DataCatalog\V1beta1\DeleteTaxonomyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTaxonomy(\Google\Cloud\DataCatalog\V1beta1\DeleteTaxonomyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/DeleteTaxonomy',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a taxonomy.
     * @param \Google\Cloud\DataCatalog\V1beta1\UpdateTaxonomyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTaxonomy(\Google\Cloud\DataCatalog\V1beta1\UpdateTaxonomyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/UpdateTaxonomy',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\Taxonomy', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all taxonomies in a project in a particular location that the caller
     * has permission to view.
     * @param \Google\Cloud\DataCatalog\V1beta1\ListTaxonomiesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTaxonomies(\Google\Cloud\DataCatalog\V1beta1\ListTaxonomiesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/ListTaxonomies',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\ListTaxonomiesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a taxonomy.
     * @param \Google\Cloud\DataCatalog\V1beta1\GetTaxonomyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTaxonomy(\Google\Cloud\DataCatalog\V1beta1\GetTaxonomyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/GetTaxonomy',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\Taxonomy', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a policy tag in the specified taxonomy.
     * @param \Google\Cloud\DataCatalog\V1beta1\CreatePolicyTagRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreatePolicyTag(\Google\Cloud\DataCatalog\V1beta1\CreatePolicyTagRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/CreatePolicyTag',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\PolicyTag', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a policy tag. Also deletes all of its descendant policy tags.
     * @param \Google\Cloud\DataCatalog\V1beta1\DeletePolicyTagRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeletePolicyTag(\Google\Cloud\DataCatalog\V1beta1\DeletePolicyTagRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/DeletePolicyTag',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a policy tag.
     * @param \Google\Cloud\DataCatalog\V1beta1\UpdatePolicyTagRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdatePolicyTag(\Google\Cloud\DataCatalog\V1beta1\UpdatePolicyTagRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/UpdatePolicyTag',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\PolicyTag', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all policy tags in a taxonomy.
     * @param \Google\Cloud\DataCatalog\V1beta1\ListPolicyTagsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPolicyTags(\Google\Cloud\DataCatalog\V1beta1\ListPolicyTagsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/ListPolicyTags',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\ListPolicyTagsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a policy tag.
     * @param \Google\Cloud\DataCatalog\V1beta1\GetPolicyTagRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPolicyTag(\Google\Cloud\DataCatalog\V1beta1\GetPolicyTagRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/GetPolicyTag',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\PolicyTag', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the IAM policy for a taxonomy or a policy tag.
     * @param \Google\Cloud\Iam\V1\GetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetIamPolicy(\Google\Cloud\Iam\V1\GetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/GetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the IAM policy for a taxonomy or a policy tag.
     * @param \Google\Cloud\Iam\V1\SetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetIamPolicy(\Google\Cloud\Iam\V1\SetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/SetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the permissions that a caller has on the specified taxonomy or
     * policy tag.
     * @param \Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function TestIamPermissions(\Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManager/TestIamPermissions',
        $argument,
        ['\Google\Cloud\Iam\V1\TestIamPermissionsResponse', 'decode'],
        $metadata, $options);
    }

}
