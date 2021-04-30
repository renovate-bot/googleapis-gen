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
 * A session represents an interaction with a user. You retrieve user input
 * and pass it to the
 * [DetectIntent][google.cloud.dialogflow.cx.v3beta1.Sessions.DetectIntent]
 * method to determine user intent and respond.
 */
class SessionsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Processes a natural language query and returns structured, actionable data
     * as a result. This method is not idempotent, because it may cause session
     * entity types to be updated, which in turn might affect results of future
     * queries.
     *
     * Note: Always use agent versions for production traffic.
     * See [Versions and
     * environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DetectIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DetectIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\DetectIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Sessions/DetectIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\DetectIntentResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Processes a natural language query in audio format in a streaming fashion
     * and returns structured, actionable data as a result. This method is only
     * available via the gRPC API (not REST).
     *
     * Note: Always use agent versions for production traffic.
     * See [Versions and
     * environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\BidiStreamingCall
     */
    public function StreamingDetectIntent($metadata = [], $options = []) {
        return $this->_bidiRequest('/google.cloud.dialogflow.cx.v3beta1.Sessions/StreamingDetectIntent',
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\StreamingDetectIntentResponse','decode'],
        $metadata, $options);
    }

    /**
     * Returns preliminary intent match results, doesn't change the session
     * status.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\MatchIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function MatchIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\MatchIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Sessions/MatchIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\MatchIntentResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Fulfills a matched intent returned by
     * [MatchIntent][google.cloud.dialogflow.cx.v3beta1.Sessions.MatchIntent].
     * Must be called after
     * [MatchIntent][google.cloud.dialogflow.cx.v3beta1.Sessions.MatchIntent],
     * with input from
     * [MatchIntentResponse][google.cloud.dialogflow.cx.v3beta1.MatchIntentResponse].
     * Otherwise, the behavior is undefined.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\FulfillIntentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FulfillIntent(\Google\Cloud\Dialogflow\Cx\V3beta1\FulfillIntentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Sessions/FulfillIntent',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\FulfillIntentResponse', 'decode'],
        $metadata, $options);
    }

}
