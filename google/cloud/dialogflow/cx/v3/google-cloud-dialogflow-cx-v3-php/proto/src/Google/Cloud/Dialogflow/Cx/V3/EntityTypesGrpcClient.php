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
 * Service for managing [EntityTypes][google.cloud.dialogflow.cx.v3.EntityType].
 */
class EntityTypesGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all entity types in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListEntityTypesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListEntityTypes(\Google\Cloud\Dialogflow\Cx\V3\ListEntityTypesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.EntityTypes/ListEntityTypes',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListEntityTypesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetEntityType(\Google\Cloud\Dialogflow\Cx\V3\GetEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.EntityTypes/GetEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\EntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an entity type in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateEntityType(\Google\Cloud\Dialogflow\Cx\V3\CreateEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.EntityTypes/CreateEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\EntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateEntityType(\Google\Cloud\Dialogflow\Cx\V3\UpdateEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.EntityTypes/UpdateEntityType',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\EntityType', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified entity type.
     * @param \Google\Cloud\Dialogflow\Cx\V3\DeleteEntityTypeRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteEntityType(\Google\Cloud\Dialogflow\Cx\V3\DeleteEntityTypeRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.EntityTypes/DeleteEntityType',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
