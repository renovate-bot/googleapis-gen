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
 * Service for managing [Intents][google.cloud.dialogflow.cx.v3beta1.Intent].
 */
class IntentsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all intents in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListIntentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListIntents(\Google\Cloud\Dialogflow\Cx\V3beta1\ListIntentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Intents/ListIntents',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListIntentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified intent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\GetIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Intents/GetIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Intent', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates an intent in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Intents/CreateIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Intent', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified intent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Intents/UpdateIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Intent', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified intent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Intents/DeleteIntent',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
