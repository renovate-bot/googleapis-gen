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
 * Service for managing [Test Cases][google.cloud.dialogflow.cx.v3beta1.TestCase] and
 * [Test Case Results][google.cloud.dialogflow.cx.v3beta1.TestCaseResult].
 */
class TestCasesGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Fetches a list of test cases for a given agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTestCases(\Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/ListTestCases',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCasesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Batch deletes test cases.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\BatchDeleteTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchDeleteTestCases(\Google\Cloud\Dialogflow\Cx\V3beta1\BatchDeleteTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/BatchDeleteTestCases',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTestCase(\Google\Cloud\Dialogflow\Cx\V3beta1\GetTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/GetTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a test case for the given agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CreateTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTestCase(\Google\Cloud\Dialogflow\Cx\V3beta1\CreateTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/CreateTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\UpdateTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTestCase(\Google\Cloud\Dialogflow\Cx\V3beta1\UpdateTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/UpdateTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a test case run.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\RunTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RunTestCase(\Google\Cloud\Dialogflow\Cx\V3beta1\RunTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/RunTestCase',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a batch run of test cases.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\BatchRunTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchRunTestCases(\Google\Cloud\Dialogflow\Cx\V3beta1\BatchRunTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/BatchRunTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Calculates the test coverage for an agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\CalculateCoverageRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CalculateCoverage(\Google\Cloud\Dialogflow\Cx\V3beta1\CalculateCoverageRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/CalculateCoverage',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\CalculateCoverageResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Imports the test cases from a Cloud Storage bucket or a local file. It
     * always creates new test cases and won't overwite any existing ones. The
     * provided ID in the imported test case is neglected.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ImportTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportTestCases(\Google\Cloud\Dialogflow\Cx\V3beta1\ImportTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/ImportTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports the test cases under the agent to a Cloud Storage bucket or a local
     * file. Filter can be applied to export a subset of test cases.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ExportTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportTestCases(\Google\Cloud\Dialogflow\Cx\V3beta1\ExportTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/ExportTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches a list of results for a given test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCaseResultsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTestCaseResults(\Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCaseResultsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/ListTestCaseResults',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\ListTestCaseResultsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a test case result.
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\GetTestCaseResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTestCaseResult(\Google\Cloud\Dialogflow\Cx\V3beta1\GetTestCaseResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3beta1.TestCases/GetTestCaseResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3beta1\TestCaseResult', 'decode'],
        $metadata, $options);
    }

}
