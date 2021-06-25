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
namespace Google\Cloud\GkeHub\V1beta;

/**
 * The GKE Hub service handles the registration of many Kubernetes clusters to
 * Google Cloud, and the management of multi-cluster features over those
 * clusters.
 *
 * The GKE Hub service operates on the following resources:
 *
 * * [Membership][google.cloud.gkehub.v1beta.Membership]
 * * [Feature][google.cloud.gkehub.v1beta.Feature]
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
     * Lists Features in a given project and location.
     * @param \Google\Cloud\GkeHub\V1beta\ListFeaturesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListFeatures(\Google\Cloud\GkeHub\V1beta\ListFeaturesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1beta.GkeHub/ListFeatures',
        $argument,
        ['\Google\Cloud\GkeHub\V1beta\ListFeaturesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details of a single Feature.
     * @param \Google\Cloud\GkeHub\V1beta\GetFeatureRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFeature(\Google\Cloud\GkeHub\V1beta\GetFeatureRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1beta.GkeHub/GetFeature',
        $argument,
        ['\Google\Cloud\GkeHub\V1beta\Feature', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a new Feature.
     * @param \Google\Cloud\GkeHub\V1beta\CreateFeatureRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateFeature(\Google\Cloud\GkeHub\V1beta\CreateFeatureRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1beta.GkeHub/CreateFeature',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Removes a Feature.
     * @param \Google\Cloud\GkeHub\V1beta\DeleteFeatureRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteFeature(\Google\Cloud\GkeHub\V1beta\DeleteFeatureRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1beta.GkeHub/DeleteFeature',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an existing Feature.
     * @param \Google\Cloud\GkeHub\V1beta\UpdateFeatureRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateFeature(\Google\Cloud\GkeHub\V1beta\UpdateFeatureRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.gkehub.v1beta.GkeHub/UpdateFeature',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
