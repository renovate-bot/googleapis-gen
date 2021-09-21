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
namespace Google\Chromeos\Moblab\V1beta1;

/**
 * Manages Chrome OS build services.
 */
class BuildServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists all build targets that a user has access to.
     * @param \Google\Chromeos\Moblab\V1beta1\ListBuildTargetsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListBuildTargets(\Google\Chromeos\Moblab\V1beta1\ListBuildTargetsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/ListBuildTargets',
        $argument,
        ['\Google\Chromeos\Moblab\V1beta1\ListBuildTargetsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all models for the given build target.
     * @param \Google\Chromeos\Moblab\V1beta1\ListModelsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListModels(\Google\Chromeos\Moblab\V1beta1\ListModelsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/ListModels',
        $argument,
        ['\Google\Chromeos\Moblab\V1beta1\ListModelsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all builds for the given build target and model in descending order
     * for the milestones and build versions.
     * @param \Google\Chromeos\Moblab\V1beta1\ListBuildsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListBuilds(\Google\Chromeos\Moblab\V1beta1\ListBuildsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/ListBuilds',
        $argument,
        ['\Google\Chromeos\Moblab\V1beta1\ListBuildsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Checks the stage status for a given build artifact in a partner Google
     * Cloud Storage bucket.
     * @param \Google\Chromeos\Moblab\V1beta1\CheckBuildStageStatusRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CheckBuildStageStatus(\Google\Chromeos\Moblab\V1beta1\CheckBuildStageStatusRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/CheckBuildStageStatus',
        $argument,
        ['\Google\Chromeos\Moblab\V1beta1\CheckBuildStageStatusResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Stages a given build artifact from a internal Google Cloud Storage bucket
     * to a partner Google Cloud Storage bucket. If any of objects has already
     * been copied, it will overwrite the previous objects. Operation <response:
     * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
     *            metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]>
     * @param \Google\Chromeos\Moblab\V1beta1\StageBuildRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StageBuild(\Google\Chromeos\Moblab\V1beta1\StageBuildRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/StageBuild',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Finds the most stable build for the given build target. The definition of
     * the most stable build is determined by evaluating the following rules in
     * order until one is true. If none are true, then there is no stable build
     * and it will return an empty response.
     *
     * Evaluation rules:
     *   1. Stable channel build with label “Live”
     *   2. Beta channel build with label “Live”
     *   3. Dev channel build with label “Live”
     *   4. Most recent stable channel build with build status Pass
     *   5. Most recent beta channel build with build status Pass
     *   6. Most recent dev channel build with build status Pass
     * @param \Google\Chromeos\Moblab\V1beta1\FindMostStableBuildRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FindMostStableBuild(\Google\Chromeos\Moblab\V1beta1\FindMostStableBuildRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.chromeos.moblab.v1beta1.BuildService/FindMostStableBuild',
        $argument,
        ['\Google\Chromeos\Moblab\V1beta1\FindMostStableBuildResponse', 'decode'],
        $metadata, $options);
    }

}
