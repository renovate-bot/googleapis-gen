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
 * Service for managing [Versions][google.cloud.dialogflow.cx.v3.Version].
 */
class VersionsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListVersionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListVersions(\Google\Cloud\Dialogflow\Cx\V3\ListVersionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/ListVersions',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListVersionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [Version][google.cloud.dialogflow.cx.v3.Version].
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetVersion(\Google\Cloud\Dialogflow\Cx\V3\GetVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/GetVersion',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Version', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a [Version][google.cloud.dialogflow.cx.v3.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3.Flow].
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [CreateVersionOperationMetadata][google.cloud.dialogflow.cx.v3.CreateVersionOperationMetadata]
     * - `response`: [Version][google.cloud.dialogflow.cx.v3.Version]
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateVersion(\Google\Cloud\Dialogflow\Cx\V3\CreateVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/CreateVersion',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [Version][google.cloud.dialogflow.cx.v3.Version].
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateVersion(\Google\Cloud\Dialogflow\Cx\V3\UpdateVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/UpdateVersion',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Version', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [Version][google.cloud.dialogflow.cx.v3.Version].
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteVersion(\Google\Cloud\Dialogflow\Cx\V3\DeleteVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/DeleteVersion',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Loads resources in the specified version to the draft flow.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: An empty [Struct
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
     * - `response`: An [Empty
     *   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
     * @param \Google\Cloud\Dialogflow\Cx\V3\LoadVersionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LoadVersion(\Google\Cloud\Dialogflow\Cx\V3\LoadVersionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/LoadVersion',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Compares the specified base version with target version.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CompareVersionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CompareVersions(\Google\Cloud\Dialogflow\Cx\V3\CompareVersionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Versions/CompareVersions',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\CompareVersionsResponse', 'decode'],
        $metadata, $options);
    }

}
