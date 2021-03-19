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
namespace Google\Cloud\Aiplatform\V1beta1;

/**
 * Cloud AI Platform Vizier API.
 *
 * Vizier service is a GCP service to solve blackbox optimization problems,
 * such as tuning machine learning hyperparameters and searching over deep
 * learning architectures.
 */
class VizierServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a Study. A resource name will be generated after creation of the
     * Study.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateStudyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateStudy(\Google\Cloud\Aiplatform\V1beta1\CreateStudyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/CreateStudy',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Study', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a Study by name.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetStudyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetStudy(\Google\Cloud\Aiplatform\V1beta1\GetStudyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/GetStudy',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Study', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all the studies in a region for an associated project.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListStudiesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListStudies(\Google\Cloud\Aiplatform\V1beta1\ListStudiesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/ListStudies',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListStudiesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a Study.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteStudyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteStudy(\Google\Cloud\Aiplatform\V1beta1\DeleteStudyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/DeleteStudy',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Looks a study up using the user-defined display_name field instead of the
     * fully qualified resource name.
     * @param \Google\Cloud\Aiplatform\V1beta1\LookupStudyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LookupStudy(\Google\Cloud\Aiplatform\V1beta1\LookupStudyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/LookupStudy',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Study', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds one or more Trials to a Study, with parameter values
     * suggested by AI Platform Vizier. Returns a long-running
     * operation associated with the generation of Trial suggestions.
     * When this long-running operation succeeds, it will contain
     * a [SuggestTrialsResponse][google.cloud.ml.v1.SuggestTrialsResponse].
     * @param \Google\Cloud\Aiplatform\V1beta1\SuggestTrialsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SuggestTrials(\Google\Cloud\Aiplatform\V1beta1\SuggestTrialsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/SuggestTrials',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a user provided Trial to a Study.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTrialRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTrial(\Google\Cloud\Aiplatform\V1beta1\CreateTrialRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/CreateTrial',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Trial', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a Trial.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTrialRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTrial(\Google\Cloud\Aiplatform\V1beta1\GetTrialRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/GetTrial',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Trial', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists the Trials associated with a Study.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTrialsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTrials(\Google\Cloud\Aiplatform\V1beta1\ListTrialsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/ListTrials',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTrialsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Adds a measurement of the objective metrics to a Trial. This measurement
     * is assumed to have been taken before the Trial is complete.
     * @param \Google\Cloud\Aiplatform\V1beta1\AddTrialMeasurementRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function AddTrialMeasurement(\Google\Cloud\Aiplatform\V1beta1\AddTrialMeasurementRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/AddTrialMeasurement',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Trial', 'decode'],
        $metadata, $options);
    }

    /**
     * Marks a Trial as complete.
     * @param \Google\Cloud\Aiplatform\V1beta1\CompleteTrialRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CompleteTrial(\Google\Cloud\Aiplatform\V1beta1\CompleteTrialRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/CompleteTrial',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Trial', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a Trial.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTrialRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTrial(\Google\Cloud\Aiplatform\V1beta1\DeleteTrialRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/DeleteTrial',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Checks  whether a Trial should stop or not. Returns a
     * long-running operation. When the operation is successful,
     * it will contain a
     * [CheckTrialEarlyStoppingStateResponse][google.cloud.ml.v1.CheckTrialEarlyStoppingStateResponse].
     * @param \Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CheckTrialEarlyStoppingState(\Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/CheckTrialEarlyStoppingState',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Stops a Trial.
     * @param \Google\Cloud\Aiplatform\V1beta1\StopTrialRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StopTrial(\Google\Cloud\Aiplatform\V1beta1\StopTrialRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/StopTrial',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Trial', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists the pareto-optimal Trials for multi-objective Study or the
     * optimal Trials for single-objective Study. The definition of
     * pareto-optimal can be checked in wiki page.
     * https://en.wikipedia.org/wiki/Pareto_efficiency
     * @param \Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListOptimalTrials(\Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.VizierService/ListOptimalTrials',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsResponse', 'decode'],
        $metadata, $options);
    }

}
