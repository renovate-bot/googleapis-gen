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
 * Service for managing [Changelogs][google.cloud.dialogflow.cx.v3beta1.Changelog].
 */
class ChangelogsGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Returns the list of Changelogs.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListChangelogsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListChangelogs(\Google\Cloud\Dialogflow\Cx\V3beta1\ListChangelogsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Changelogs/ListChangelogs',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListChangelogsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Retrieves the specified Changelog.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetChangelogRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetChangelog(\Google\Cloud\Dialogflow\Cx\V3beta1\GetChangelogRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.Changelogs/GetChangelog',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\Changelog', 'decode'],
        $metadata, $options);
    }

}
