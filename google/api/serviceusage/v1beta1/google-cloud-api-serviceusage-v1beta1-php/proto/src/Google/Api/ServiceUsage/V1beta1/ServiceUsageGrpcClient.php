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
namespace Google\Api\ServiceUsage\V1beta1;

/**
 * [Service Usage API](/service-usage/docs/overview)
 */
class ServiceUsageGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Enables a service so that it can be used with a project.
     *
     * Operation response type: `google.protobuf.Empty`
     * @param \Google\Api\ServiceUsage\V1beta1\EnableServiceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function EnableService(\Google\Api\ServiceUsage\V1beta1\EnableServiceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/EnableService',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Disables a service so that it can no longer be used with a project.
     * This prevents unintended usage that may cause unexpected billing
     * charges or security leaks.
     *
     * It is not valid to call the disable method on a service that is not
     * currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
     * the target service is not currently enabled.
     *
     * Operation response type: `google.protobuf.Empty`
     * @param \Google\Api\ServiceUsage\V1beta1\DisableServiceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DisableService(\Google\Api\ServiceUsage\V1beta1\DisableServiceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/DisableService',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the service configuration and enabled state for a given service.
     * @param \Google\Api\ServiceUsage\V1beta1\GetServiceRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetService(\Google\Api\ServiceUsage\V1beta1\GetServiceRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/GetService',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\Service', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all services available to the specified project, and the current
     * state of those services with respect to the project. The list includes
     * all public services, all services for which the calling user has the
     * `servicemanagement.services.bind` permission, and all services that have
     * already been enabled on the project. The list can be filtered to
     * only include services in a specific state, for example to only include
     * services enabled on the project.
     * @param \Google\Api\ServiceUsage\V1beta1\ListServicesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListServices(\Google\Api\ServiceUsage\V1beta1\ListServicesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ListServices',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ListServicesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Enables multiple services on a project. The operation is atomic: if
     * enabling any service fails, then the entire batch fails, and no state
     * changes occur.
     *
     * Operation response type: `google.protobuf.Empty`
     * @param \Google\Api\ServiceUsage\V1beta1\BatchEnableServicesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchEnableServices(\Google\Api\ServiceUsage\V1beta1\BatchEnableServicesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/BatchEnableServices',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a summary of all quota information visible to the service
     * consumer, organized by service metric. Each metric includes information
     * about all of its defined limits. Each limit includes the limit
     * configuration (quota unit, preciseness, default value), the current
     * effective limit value, and all of the overrides applied to the limit.
     * @param \Google\Api\ServiceUsage\V1beta1\ListConsumerQuotaMetricsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListConsumerQuotaMetrics(\Google\Api\ServiceUsage\V1beta1\ListConsumerQuotaMetricsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ListConsumerQuotaMetrics',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ListConsumerQuotaMetricsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a summary of quota information for a specific quota metric
     * @param \Google\Api\ServiceUsage\V1beta1\GetConsumerQuotaMetricRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetConsumerQuotaMetric(\Google\Api\ServiceUsage\V1beta1\GetConsumerQuotaMetricRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/GetConsumerQuotaMetric',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ConsumerQuotaMetric', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves a summary of quota information for a specific quota limit.
     * @param \Google\Api\ServiceUsage\V1beta1\GetConsumerQuotaLimitRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetConsumerQuotaLimit(\Google\Api\ServiceUsage\V1beta1\GetConsumerQuotaLimitRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/GetConsumerQuotaLimit',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ConsumerQuotaLimit', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an admin override.
     * An admin override is applied by an administrator of a parent folder or
     * parent organization of the consumer receiving the override. An admin
     * override is intended to limit the amount of quota the consumer can use out
     * of the total quota pool allocated to all children of the folder or
     * organization.
     * @param \Google\Api\ServiceUsage\V1beta1\CreateAdminOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateAdminOverride(\Google\Api\ServiceUsage\V1beta1\CreateAdminOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/CreateAdminOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates an admin override.
     * @param \Google\Api\ServiceUsage\V1beta1\UpdateAdminOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateAdminOverride(\Google\Api\ServiceUsage\V1beta1\UpdateAdminOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/UpdateAdminOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes an admin override.
     * @param \Google\Api\ServiceUsage\V1beta1\DeleteAdminOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteAdminOverride(\Google\Api\ServiceUsage\V1beta1\DeleteAdminOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/DeleteAdminOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all admin overrides on this limit.
     * @param \Google\Api\ServiceUsage\V1beta1\ListAdminOverridesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListAdminOverrides(\Google\Api\ServiceUsage\V1beta1\ListAdminOverridesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ListAdminOverrides',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ListAdminOverridesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates or updates multiple admin overrides atomically, all on the
     * same consumer, but on many different metrics or limits.
     * The name field in the quota override message should not be set.
     * @param \Google\Api\ServiceUsage\V1beta1\ImportAdminOverridesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportAdminOverrides(\Google\Api\ServiceUsage\V1beta1\ImportAdminOverridesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ImportAdminOverrides',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a consumer override.
     * A consumer override is applied to the consumer on its own authority to
     * limit its own quota usage. Consumer overrides cannot be used to grant more
     * quota than would be allowed by admin overrides, producer overrides, or the
     * default limit of the service.
     * @param \Google\Api\ServiceUsage\V1beta1\CreateConsumerOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateConsumerOverride(\Google\Api\ServiceUsage\V1beta1\CreateConsumerOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/CreateConsumerOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a consumer override.
     * @param \Google\Api\ServiceUsage\V1beta1\UpdateConsumerOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateConsumerOverride(\Google\Api\ServiceUsage\V1beta1\UpdateConsumerOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/UpdateConsumerOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a consumer override.
     * @param \Google\Api\ServiceUsage\V1beta1\DeleteConsumerOverrideRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteConsumerOverride(\Google\Api\ServiceUsage\V1beta1\DeleteConsumerOverrideRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/DeleteConsumerOverride',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all consumer overrides on this limit.
     * @param \Google\Api\ServiceUsage\V1beta1\ListConsumerOverridesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListConsumerOverrides(\Google\Api\ServiceUsage\V1beta1\ListConsumerOverridesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ListConsumerOverrides',
        $argument,
        ['\Google\Api\ServiceUsage\V1beta1\ListConsumerOverridesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates or updates multiple consumer overrides atomically, all on the
     * same consumer, but on many different metrics or limits.
     * The name field in the quota override message should not be set.
     * @param \Google\Api\ServiceUsage\V1beta1\ImportConsumerOverridesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportConsumerOverrides(\Google\Api\ServiceUsage\V1beta1\ImportConsumerOverridesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/ImportConsumerOverrides',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Generates service identity for service.
     * @param \Google\Api\ServiceUsage\V1beta1\GenerateServiceIdentityRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GenerateServiceIdentity(\Google\Api\ServiceUsage\V1beta1\GenerateServiceIdentityRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.api.serviceusage.v1beta1.ServiceUsage/GenerateServiceIdentity',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
