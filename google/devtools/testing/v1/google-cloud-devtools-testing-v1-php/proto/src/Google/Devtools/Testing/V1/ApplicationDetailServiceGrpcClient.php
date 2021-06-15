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
namespace Google\Devtools\Testing\V1;

/**
 * A service which parses input applications and returns details that can be
 * useful in the context of testing.
 */
class ApplicationDetailServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets the details of an Android application APK.
     * @param \Google\Devtools\Testing\V1\GetApkDetailsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetApkDetails(\Google\Devtools\Testing\V1\GetApkDetailsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.devtools.testing.v1.ApplicationDetailService/GetApkDetails',
        $argument,
        ['\Google\Devtools\Testing\V1\GetApkDetailsResponse', 'decode'],
        $metadata, $options);
    }

}
