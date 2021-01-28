<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2020 Google LLC
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
namespace Google\Cloud\Asset\V1p4beta1;

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
     * Analyzes IAM policies based on the specified request. Returns
     * a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
     * @param \Google\Cloud\Asset\V1p4beta1\AnalyzeIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AnalyzeIamPolicy(\Google\Cloud\Asset\V1p4beta1\AnalyzeIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p4beta1.AssetService/AnalyzeIamPolicy',
        $argument,
        ['\Google\Cloud\Asset\V1p4beta1\AnalyzeIamPolicyResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports IAM policy analysis based on the specified request. This API
     * implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
     * track of the export. The metadata contains the request to help callers to
     * map responses to requests.
     * @param \Google\Cloud\Asset\V1p4beta1\ExportIamPolicyAnalysisRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportIamPolicyAnalysis(\Google\Cloud\Asset\V1p4beta1\ExportIamPolicyAnalysisRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.asset.v1p4beta1.AssetService/ExportIamPolicyAnalysis',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
