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
namespace Google\Monitoring\Dashboard\V1;

/**
 * Manages Stackdriver dashboards. A dashboard is an arrangement of data display
 * widgets in a specific layout.
 */
class DashboardsServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
     * This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
     * @param \Google\Monitoring\Dashboard\V1\CreateDashboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateDashboard(\Google\Monitoring\Dashboard\V1\CreateDashboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.dashboard.v1.DashboardsService/CreateDashboard',
        $argument,
        ['\Google\Monitoring\Dashboard\V1\Dashboard', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists the existing dashboards.
     *
     * This method requires the `monitoring.dashboards.list` permission
     * on the specified project. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     * @param \Google\Monitoring\Dashboard\V1\ListDashboardsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDashboards(\Google\Monitoring\Dashboard\V1\ListDashboardsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.dashboard.v1.DashboardsService/ListDashboards',
        $argument,
        ['\Google\Monitoring\Dashboard\V1\ListDashboardsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches a specific dashboard.
     *
     * This method requires the `monitoring.dashboards.get` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     * @param \Google\Monitoring\Dashboard\V1\GetDashboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetDashboard(\Google\Monitoring\Dashboard\V1\GetDashboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.dashboard.v1.DashboardsService/GetDashboard',
        $argument,
        ['\Google\Monitoring\Dashboard\V1\Dashboard', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes an existing custom dashboard.
     *
     * This method requires the `monitoring.dashboards.delete` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     * @param \Google\Monitoring\Dashboard\V1\DeleteDashboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteDashboard(\Google\Monitoring\Dashboard\V1\DeleteDashboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.dashboard.v1.DashboardsService/DeleteDashboard',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Replaces an existing custom dashboard with a new definition.
     *
     * This method requires the `monitoring.dashboards.update` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     * @param \Google\Monitoring\Dashboard\V1\UpdateDashboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateDashboard(\Google\Monitoring\Dashboard\V1\UpdateDashboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.dashboard.v1.DashboardsService/UpdateDashboard',
        $argument,
        ['\Google\Monitoring\Dashboard\V1\Dashboard', 'decode'],
        $metadata, $options);
    }

}
