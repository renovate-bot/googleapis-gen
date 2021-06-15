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
namespace Google\Devtools\Testing\V1;

/**
 * Service for discovering environments supported by the TestExecutionService.
 *
 * Over time the TestService may add or remove devices or configuration options
 * (e.g., when new devices and APIs are released).  Clients should check here
 * periodically to discover what options are supported.
 *
 * It defines the following resource model:
 *
 * - The API a collection of [TestEnvironmentCatalog]
 *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
 *   `testEnvironmentCatalog/*`
 *
 * - Each TestEnvironmentCatalog resource describes a set of supported
 *   environments.
 *
 * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
 *   describes supported Android devices. It contains lists of supported
 *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
 *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
 *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
 *   Each AndroidModel contains a list of Versions it supports. All
 *   models support all locales and orientations described by the
 *   AndroidRuntimeConfiguration
 *
 * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
 *   describes supported iOS devices. It contains lists of supported
 *   [IosModels][google.devtools.test.v1.IosModel] and
 *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
 *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
 *   Each IosModel contains a list of Versions it supports. All
 *   models support all locales and orientations described by the
 *   IosRuntimeConfiguration.
 */
class TestEnvironmentDiscoveryServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets the catalog of supported test environments.
     *
     * May return any of the following canonical error codes:
     *
     * - INVALID_ARGUMENT - if the request is malformed
     * - NOT_FOUND - if the environment type does not exist
     * - INTERNAL - if an internal error occurred
     * @param \Google\Devtools\Testing\V1\GetTestEnvironmentCatalogRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTestEnvironmentCatalog(\Google\Devtools\Testing\V1\GetTestEnvironmentCatalogRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.testing.v1.TestEnvironmentDiscoveryService/GetTestEnvironmentCatalog',
        $argument,
        ['\Google\Devtools\Testing\V1\TestEnvironmentCatalog', 'decode'],
        $metadata, $options);
    }

}
