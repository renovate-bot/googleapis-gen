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
namespace Google\Cloud\OsConfig\V1;

/**
 * Zonal OS Config API
 *
 * The OS Config service is the server-side component that allows users to
 * manage package installations and patch jobs for Compute Engine VM instances.
 */
class OsConfigZonalServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Get inventory data for the specified VM instance. If the VM has no
     * associated inventory, the message `NOT_FOUND` is returned.
     * @param \Google\Cloud\OsConfig\V1\GetInventoryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetInventory(\Google\Cloud\OsConfig\V1\GetInventoryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1.OsConfigZonalService/GetInventory',
        $argument,
        ['\Google\Cloud\OsConfig\V1\Inventory', 'decode'],
        $metadata, $options);
    }

    /**
     * List inventory data for all VM instances in the specified zone.
     * @param \Google\Cloud\OsConfig\V1\ListInventoriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListInventories(\Google\Cloud\OsConfig\V1\ListInventoriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1.OsConfigZonalService/ListInventories',
        $argument,
        ['\Google\Cloud\OsConfig\V1\ListInventoriesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the vulnerability report for the specified VM instance. Only VMs with
     * inventory data have vulnerability reports associated with them.
     * @param \Google\Cloud\OsConfig\V1\GetVulnerabilityReportRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetVulnerabilityReport(\Google\Cloud\OsConfig\V1\GetVulnerabilityReportRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1.OsConfigZonalService/GetVulnerabilityReport',
        $argument,
        ['\Google\Cloud\OsConfig\V1\VulnerabilityReport', 'decode'],
        $metadata, $options);
    }

    /**
     * List vulnerability reports for all VM instances in the specified zone.
     * @param \Google\Cloud\OsConfig\V1\ListVulnerabilityReportsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListVulnerabilityReports(\Google\Cloud\OsConfig\V1\ListVulnerabilityReportsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.osconfig.v1.OsConfigZonalService/ListVulnerabilityReports',
        $argument,
        ['\Google\Cloud\OsConfig\V1\ListVulnerabilityReportsResponse', 'decode'],
        $metadata, $options);
    }

}
