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
 * Service for managing [Deployments][google.cloud.dialogflow.cx.v3.Deployment].
 */
class DeploymentsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of all deployments in the specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListDeploymentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListDeployments(\Google\Cloud\Dialogflow\Cx\V3\ListDeploymentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Deployments/ListDeployments',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListDeploymentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetDeploymentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetDeployment(\Google\Cloud\Dialogflow\Cx\V3\GetDeploymentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.Deployments/GetDeployment',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\Deployment', 'decode'],
        $metadata, $options);
    }

}
