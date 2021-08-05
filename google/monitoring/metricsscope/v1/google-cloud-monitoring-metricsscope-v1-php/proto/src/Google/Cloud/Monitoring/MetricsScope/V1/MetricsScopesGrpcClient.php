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
namespace Google\Cloud\Monitoring\MetricsScope\V1;

/**
 * Manages Cloud Monitoring Metrics Scopes, and the monitoring of Google Cloud
 * projects and AWS accounts.
 */
class MetricsScopesGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns a specific `Metrics Scope`.
     * @param \Google\Cloud\Monitoring\MetricsScope\V1\GetMetricsScopeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetMetricsScope(\Google\Cloud\Monitoring\MetricsScope\V1\GetMetricsScopeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.metricsscope.v1.MetricsScopes/GetMetricsScope',
        $argument,
        ['\Google\Cloud\Monitoring\MetricsScope\V1\MetricsScope', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns a list of every `Metrics Scope` that a specific `MonitoredProject`
     * has been added to. The metrics scope representing the specified monitored
     * project will always be the first entry in the response.
     * @param \Google\Cloud\Monitoring\MetricsScope\V1\ListMetricsScopesByMonitoredProjectRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListMetricsScopesByMonitoredProject(\Google\Cloud\Monitoring\MetricsScope\V1\ListMetricsScopesByMonitoredProjectRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.metricsscope.v1.MetricsScopes/ListMetricsScopesByMonitoredProject',
        $argument,
        ['\Google\Cloud\Monitoring\MetricsScope\V1\ListMetricsScopesByMonitoredProjectResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a `MonitoredProject` with the given project ID
     * to the specified `Metrics Scope`.
     * @param \Google\Cloud\Monitoring\MetricsScope\V1\CreateMonitoredProjectRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateMonitoredProject(\Google\Cloud\Monitoring\MetricsScope\V1\CreateMonitoredProjectRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.metricsscope.v1.MetricsScopes/CreateMonitoredProject',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a `MonitoredProject` from the specified `Metrics Scope`.
     * @param \Google\Cloud\Monitoring\MetricsScope\V1\DeleteMonitoredProjectRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteMonitoredProject(\Google\Cloud\Monitoring\MetricsScope\V1\DeleteMonitoredProjectRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.monitoring.metricsscope.v1.MetricsScopes/DeleteMonitoredProject',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
