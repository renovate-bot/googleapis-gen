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
namespace Google\Cloud\Retail\V2alpha;

/**
 * Service for managing catalog configuration.
 */
class CatalogServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists all the [Catalog][google.cloud.retail.v2alpha.Catalog]s associated
     * with the project.
     * @param \Google\Cloud\Retail\V2alpha\ListCatalogsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListCatalogs(\Google\Cloud\Retail\V2alpha\ListCatalogsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2alpha.CatalogService/ListCatalogs',
        $argument,
        ['\Google\Cloud\Retail\V2alpha\ListCatalogsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the [Catalog][google.cloud.retail.v2alpha.Catalog]s.
     * @param \Google\Cloud\Retail\V2alpha\UpdateCatalogRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateCatalog(\Google\Cloud\Retail\V2alpha\UpdateCatalogRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2alpha.CatalogService/UpdateCatalog',
        $argument,
        ['\Google\Cloud\Retail\V2alpha\Catalog', 'decode'],
        $metadata, $options);
    }

}
