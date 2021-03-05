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
namespace Google\Apps\Drive\Activity\V2;

/**
 * Service for querying activity on Drive items. Activity is user
 * or system action on Drive items that happened in the past. A Drive item can
 * be a file or folder, or a Team Drive.
 */
class DriveActivityServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Query past activity in Google Drive.
     * @param \Google\Apps\Drive\Activity\V2\QueryDriveActivityRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryDriveActivity(\Google\Apps\Drive\Activity\V2\QueryDriveActivityRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.apps.drive.activity.v2.DriveActivityService/QueryDriveActivity',
        $argument,
        ['\Google\Apps\Drive\Activity\V2\QueryDriveActivityResponse', 'decode'],
        $metadata, $options);
    }

}
