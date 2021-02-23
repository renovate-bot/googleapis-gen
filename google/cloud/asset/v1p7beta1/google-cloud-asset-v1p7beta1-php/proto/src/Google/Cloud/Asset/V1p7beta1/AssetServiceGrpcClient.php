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
namespace Google\Cloud\Asset\V1p7beta1;

/**
 * Asset service definition.
 */
class AssetServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Exports assets with time and resource types to a given Cloud Storage
     * location/BigQuery table. For Cloud Storage location destinations, the
     * output format is newline-delimited JSON. Each line represents a
     * [google.cloud.asset.v1p7beta1.Asset][google.cloud.asset.v1p7beta1.Asset] in
     * the JSON format; for BigQuery table destinations, the output table stores
     * the fields in asset proto as columns. This API implements the
     * [google.longrunning.Operation][google.longrunning.Operation] API , which
     * allows you to keep track of the export. We recommend intervals of at least
     * 2 seconds with exponential retry to poll the export operation result. For
     * regular-size resource parent, the export operation usually finishes within
     * 5 minutes.
     * @param \Google\Cloud\Asset\V1p7beta1\ExportAssetsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportAssets(\Google\Cloud\Asset\V1p7beta1\ExportAssetsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p7beta1.AssetService/ExportAssets',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
