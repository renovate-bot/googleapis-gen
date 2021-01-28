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
namespace Google\Cloud\SecurityCenter\Settings\V1beta1;

/**
 * ## API Overview
 *
 * The SecurityCenterSettingsService is a sub-api of
 * `securitycenter.googleapis.com`. The service provides methods to manage
 * Security Center Settings, and Component Settings for GCP organizations,
 * folders, projects, and clusters.
 */
class SecurityCenterSettingsServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Retrieves the organizations service account, if it exists, otherwise it
     * creates the organization service account. This API is idempotent and
     * will only create a service account once. On subsequent calls it will
     * return the previously created service account.  SHA, SCC and CTD Infra
     * Automation will use this SA.  This SA will not have any permissions when
     * created.  The UI will provision this via IAM or the user will using
     * their own internal process. This API only creates SAs on the organization.
     * Folders are not supported and projects will use per-project SAs associated
     * with APIs enabled on a project. This API will be called by the UX
     * onboarding workflow.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\GetServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetServiceAccount(\Google\Cloud\SecurityCenter\Settings\V1beta1\GetServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetServiceAccount',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ServiceAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the Settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\GetSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\GetSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\Settings', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the Settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\UpdateSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\UpdateSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/UpdateSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\Settings', 'decode'],
        $metadata, $options);
    }

    /**
     * Reset the organization, folder or project's settings and return
     * the settings of just that resource to the default.
     *
     * Settings are present at the organization, folder, project, and cluster
     * levels. Using Reset on a sub-organization level will remove that resource's
     * override and result in the parent's settings being used (eg: if Reset on a
     * cluster, project settings will be used).
     *
     * Using Reset on organization will remove the override that was set and
     * result in default settings being used.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\ResetSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ResetSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\ResetSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ResetSettings',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a list of settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\BatchGetSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchGetSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\BatchGetSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/BatchGetSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\BatchGetSettingsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * CalculateEffectiveSettings looks up all of the Security Center
     * Settings resources in the GCP resource hierarchy, and calculates the
     * effective settings on that resource by applying the following rules:
     *  * Settings provided closer to the target resource take precedence over
     *    those further away (e.g. folder will override organization level
     *    settings).
     *  * Product defaults can be overridden at org, folder, project, and cluster
     *  levels.
     *  * Detectors will be filtered out if they belong to a billing tier the
     *  customer
     *    has not configured.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\CalculateEffectiveSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CalculateEffectiveSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\CalculateEffectiveSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/CalculateEffectiveSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\Settings', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a list of effective settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\BatchCalculateEffectiveSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchCalculateEffectiveSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\BatchCalculateEffectiveSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/BatchCalculateEffectiveSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\BatchCalculateEffectiveSettingsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the Component Settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\GetComponentSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetComponentSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\GetComponentSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetComponentSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentSettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the Component Settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\UpdateComponentSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateComponentSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\UpdateComponentSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/UpdateComponentSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentSettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Reset the organization, folder or project's component settings and return
     * the settings to the default. Settings are present at the
     * organization, folder and project levels. Using Reset for a folder or
     * project will remove the override that was set and result in the
     * organization-level settings being used.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\ResetComponentSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ResetComponentSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\ResetComponentSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ResetComponentSettings',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the Effective Component Settings.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\CalculateEffectiveComponentSettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CalculateEffectiveComponentSettings(\Google\Cloud\SecurityCenter\Settings\V1beta1\CalculateEffectiveComponentSettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/CalculateEffectiveComponentSettings',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ComponentSettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves an unordered list of available detectors.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\ListDetectorsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDetectors(\Google\Cloud\SecurityCenter\Settings\V1beta1\ListDetectorsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ListDetectors',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ListDetectorsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves an unordered list of available SCC components.
     * @param \Google\Cloud\SecurityCenter\Settings\V1beta1\ListComponentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListComponents(\Google\Cloud\SecurityCenter\Settings\V1beta1\ListComponentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ListComponents',
        $argument,
        ['\Google\Cloud\SecurityCenter\Settings\V1beta1\ListComponentsResponse', 'decode'],
        $metadata, $options);
    }

}
