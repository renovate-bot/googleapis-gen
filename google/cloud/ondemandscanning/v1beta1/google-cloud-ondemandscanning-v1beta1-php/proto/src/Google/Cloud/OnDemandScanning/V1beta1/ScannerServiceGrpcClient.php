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
namespace Google\Cloud\OnDemandScanning\V1beta1;

/**
 * The Scanner service of the On-Demand Scanning API.
 *
 * This service provides a way to find vulnerabilities for the packages in some
 * container image. A user provides a a list of packages to `AnalyzePackages`
 * and receives a list of vulnerabilities in return. The `AnalyzePackages`
 * method is asynchronous, implementing Long-running Operations to track
 * progress.
 */
class ScannerServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Initiates an analysis of the provided packages.
     * @param \Google\Cloud\OnDemandScanning\V1beta1\AnalyzePackagesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AnalyzePackages(\Google\Cloud\OnDemandScanning\V1beta1\AnalyzePackagesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.ondemandscanning.v1beta1.ScannerService/AnalyzePackages',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists vulnerabilities resulting from a successfully completed scan.
     * @param \Google\Cloud\OnDemandScanning\V1beta1\ListVulnerabilitiesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListVulnerabilities(\Google\Cloud\OnDemandScanning\V1beta1\ListVulnerabilitiesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.ondemandscanning.v1beta1.ScannerService/ListVulnerabilities',
        $argument,
        ['\Google\Cloud\OnDemandScanning\V1beta1\ListVulnerabilitiesResponse', 'decode'],
        $metadata, $options);
    }

}
