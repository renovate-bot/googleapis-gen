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
namespace Google\Cloud\Retail\V2beta;

/**
 * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
 * information of the customer's website.
 */
class ProductServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a [Product][google.cloud.retail.v2beta.Product].
     * @param \Google\Cloud\Retail\V2beta\CreateProductRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateProduct(\Google\Cloud\Retail\V2beta\CreateProductRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2beta.ProductService/CreateProduct',
        $argument,
        ['\Google\Cloud\Retail\V2beta\Product', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a [Product][google.cloud.retail.v2beta.Product].
     * @param \Google\Cloud\Retail\V2beta\GetProductRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetProduct(\Google\Cloud\Retail\V2beta\GetProductRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2beta.ProductService/GetProduct',
        $argument,
        ['\Google\Cloud\Retail\V2beta\Product', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a [Product][google.cloud.retail.v2beta.Product].
     * @param \Google\Cloud\Retail\V2beta\UpdateProductRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateProduct(\Google\Cloud\Retail\V2beta\UpdateProductRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2beta.ProductService/UpdateProduct',
        $argument,
        ['\Google\Cloud\Retail\V2beta\Product', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a [Product][google.cloud.retail.v2beta.Product].
     * @param \Google\Cloud\Retail\V2beta\DeleteProductRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteProduct(\Google\Cloud\Retail\V2beta\DeleteProductRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2beta.ProductService/DeleteProduct',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Bulk import of multiple [Product][google.cloud.retail.v2beta.Product]s.
     *
     * Request processing may be synchronous. No partial updating is supported.
     * Non-existing items are created.
     *
     * Note that it is possible for a subset of the
     * [Product][google.cloud.retail.v2beta.Product]s to be successfully updated.
     * @param \Google\Cloud\Retail\V2beta\ImportProductsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportProducts(\Google\Cloud\Retail\V2beta\ImportProductsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2beta.ProductService/ImportProducts',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
