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
 * Service for managing [SessionEntityTypes][google.cloud.dialogflow.cx.v3.SessionEntityType].
 */
class SessionEntityTypesGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all session entity types in the specified session.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListSessionEntityTypesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListSessionEntityTypes(\Google\Cloud\Dialogflow\Cx\V3\ListSessionEntityTypesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SessionEntityTypes/ListSessionEntityTypes',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListSessionEntityTypesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified session entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetSessionEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetSessionEntityType(\Google\Cloud\Dialogflow\Cx\V3\GetSessionEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SessionEntityTypes/GetSessionEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SessionEntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a session entity type.
     *
     * If the specified session entity type already exists, overrides the
     * session entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateSessionEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateSessionEntityType(\Google\Cloud\Dialogflow\Cx\V3\CreateSessionEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SessionEntityTypes/CreateSessionEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SessionEntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified session entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateSessionEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateSessionEntityType(\Google\Cloud\Dialogflow\Cx\V3\UpdateSessionEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SessionEntityTypes/UpdateSessionEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\SessionEntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified session entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteSessionEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteSessionEntityType(\Google\Cloud\Dialogflow\Cx\V3\DeleteSessionEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.SessionEntityTypes/DeleteSessionEntityType',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
