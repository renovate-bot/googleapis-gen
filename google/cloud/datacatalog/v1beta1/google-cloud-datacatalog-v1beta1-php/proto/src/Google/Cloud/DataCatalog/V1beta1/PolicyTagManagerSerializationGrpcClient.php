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
 * Policy tag manager serialization API service allows clients to manipulate
 * their taxonomies and policy tags data with serialized format.
 */
class PolicyTagManagerSerializationGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Imports all taxonomies and their policy tags to a project as new
     * taxonomies.
     *
     * This method provides a bulk taxonomy / policy tag creation using nested
     * proto structure.
     * @param \Google\Cloud\DataCatalog\V1beta1\ImportTaxonomiesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportTaxonomies(\Google\Cloud\DataCatalog\V1beta1\ImportTaxonomiesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManagerSerialization/ImportTaxonomies',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\ImportTaxonomiesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports all taxonomies and their policy tags in a project.
     *
     * This method generates SerializedTaxonomy protos with nested policy tags
     * that can be used as an input for future ImportTaxonomies calls.
     * @param \Google\Cloud\DataCatalog\V1beta1\ExportTaxonomiesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportTaxonomies(\Google\Cloud\DataCatalog\V1beta1\ExportTaxonomiesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.datacatalog.v1beta1.PolicyTagManagerSerialization/ExportTaxonomies',
        $argument,
        ['\Google\Cloud\DataCatalog\V1beta1\ExportTaxonomiesResponse', 'decode'],
        $metadata, $options);
    }

}
