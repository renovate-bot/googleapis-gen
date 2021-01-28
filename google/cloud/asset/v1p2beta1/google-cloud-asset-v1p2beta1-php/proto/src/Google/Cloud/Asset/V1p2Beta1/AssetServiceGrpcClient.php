<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2019 Google LLC.
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
//
namespace Google\Cloud\Asset\V1p2Beta1;

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
     * Creates a feed in a parent project/folder/organization to listen to its
     * asset updates.
     * @param \Google\Cloud\Asset\V1p2Beta1\CreateFeedRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateFeed(\Google\Cloud\Asset\V1p2Beta1\CreateFeedRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p2beta1.AssetService/CreateFeed',
        $argument,
        ['\Google\Cloud\Asset\V1p2Beta1\Feed', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets details about an asset feed.
     * @param \Google\Cloud\Asset\V1p2Beta1\GetFeedRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetFeed(\Google\Cloud\Asset\V1p2Beta1\GetFeedRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p2beta1.AssetService/GetFeed',
        $argument,
        ['\Google\Cloud\Asset\V1p2Beta1\Feed', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all asset feeds in a parent project/folder/organization.
     * @param \Google\Cloud\Asset\V1p2Beta1\ListFeedsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListFeeds(\Google\Cloud\Asset\V1p2Beta1\ListFeedsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p2beta1.AssetService/ListFeeds',
        $argument,
        ['\Google\Cloud\Asset\V1p2Beta1\ListFeedsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an asset feed configuration.
     * @param \Google\Cloud\Asset\V1p2Beta1\UpdateFeedRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateFeed(\Google\Cloud\Asset\V1p2Beta1\UpdateFeedRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p2beta1.AssetService/UpdateFeed',
        $argument,
        ['\Google\Cloud\Asset\V1p2Beta1\Feed', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes an asset feed.
     * @param \Google\Cloud\Asset\V1p2Beta1\DeleteFeedRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteFeed(\Google\Cloud\Asset\V1p2Beta1\DeleteFeedRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p2beta1.AssetService/DeleteFeed',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
