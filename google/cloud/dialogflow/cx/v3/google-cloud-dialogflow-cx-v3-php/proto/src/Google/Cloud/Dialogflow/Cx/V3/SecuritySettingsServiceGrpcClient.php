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
namespace Google\Cloud\Dialogflow\Cx\V3;

/**
 * Service for managing security settings for Dialogflow.
 */
class SecuritySettingsServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Create security settings in the specified location.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateSecuritySettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateSecuritySettings(\Google\Cloud\Dialogflow\Cx\V3\CreateSecuritySettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SecuritySettingsService/CreateSecuritySettings',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
     * The returned settings may be stale by up to 1 minute.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetSecuritySettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetSecuritySettings(\Google\Cloud\Dialogflow\Cx\V3\GetSecuritySettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SecuritySettingsService/GetSecuritySettings',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateSecuritySettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateSecuritySettings(\Google\Cloud\Dialogflow\Cx\V3\UpdateSecuritySettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SecuritySettingsService/UpdateSecuritySettings',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns the list of all security settings in the specified location.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListSecuritySettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListSecuritySettings(\Google\Cloud\Dialogflow\Cx\V3\ListSecuritySettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SecuritySettingsService/ListSecuritySettings',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListSecuritySettingsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteSecuritySettingsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteSecuritySettings(\Google\Cloud\Dialogflow\Cx\V3\DeleteSecuritySettingsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SecuritySettingsService/DeleteSecuritySettings',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
