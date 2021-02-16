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
namespace Google\Cloud\Dialogflow\Cx\V3beta1;

/**
 * Service for managing [TransitionRouteGroups][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup].
 */
class TransitionRouteGroupsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all transition route groups in the specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListTransitionRouteGroupsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTransitionRouteGroups(\Google\Cloud\Dialogflow\Cx\V3beta1\ListTransitionRouteGroupsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups/ListTransitionRouteGroups',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListTransitionRouteGroupsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetTransitionRouteGroupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTransitionRouteGroup(\Google\Cloud\Dialogflow\Cx\V3beta1\GetTransitionRouteGroupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups/GetTransitionRouteGroup',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup] in the specified flow.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateTransitionRouteGroupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTransitionRouteGroup(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateTransitionRouteGroupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups/CreateTransitionRouteGroup',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateTransitionRouteGroupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTransitionRouteGroup(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateTransitionRouteGroupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups/UpdateTransitionRouteGroup',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TransitionRouteGroup', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroup].
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteTransitionRouteGroupRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTransitionRouteGroup(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteTransitionRouteGroupRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups/DeleteTransitionRouteGroup',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
