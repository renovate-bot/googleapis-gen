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
 * Service for managing [Webhooks][google.cloud.dialogflow.cx.v3beta1.Webhook].
 */
class WebhooksGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all webhooks in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListWebhooksRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListWebhooks(\Google\Cloud\Dialogflow\Cx\V3beta1\ListWebhooksRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Webhooks/ListWebhooks',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListWebhooksResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified webhook.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetWebhookRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetWebhook(\Google\Cloud\Dialogflow\Cx\V3beta1\GetWebhookRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Webhooks/GetWebhook',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Webhook', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a webhook in the specified agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateWebhookRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateWebhook(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateWebhookRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Webhooks/CreateWebhook',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Webhook', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified webhook.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateWebhookRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateWebhook(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateWebhookRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Webhooks/UpdateWebhook',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Webhook', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes the specified webhook.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\DeleteWebhookRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteWebhook(\Google\Cloud\Dialogflow\Cx\V3beta1\DeleteWebhookRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Webhooks/DeleteWebhook',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

}
