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
 * Service for managing [Test Cases][google.cloud.dialogflow.cx.v3.TestCase] and
 * [Test Case Results][google.cloud.dialogflow.cx.v3.TestCaseResult].
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
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTestCases(\Google\Cloud\Dialogflow\Cx\V3\ListTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/ListTestCases',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListTestCasesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Batch deletes test cases.
     * @param \Google\Cloud\Dialogflow\Cx\V3\BatchDeleteTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchDeleteTestCases(\Google\Cloud\Dialogflow\Cx\V3\BatchDeleteTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/BatchDeleteTestCases',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTestCase(\Google\Cloud\Dialogflow\Cx\V3\GetTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/GetTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a test case for the given agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CreateTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTestCase(\Google\Cloud\Dialogflow\Cx\V3\CreateTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/CreateTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the specified test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3\UpdateTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTestCase(\Google\Cloud\Dialogflow\Cx\V3\UpdateTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/UpdateTestCase',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\TestCase', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a test case run.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [RunTestCaseMetadata][google.cloud.dialogflow.cx.v3.RunTestCaseMetadata]
     * - `response`: [RunTestCaseResponse][google.cloud.dialogflow.cx.v3.RunTestCaseResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\RunTestCaseRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function RunTestCase(\Google\Cloud\Dialogflow\Cx\V3\RunTestCaseRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/RunTestCase',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Kicks off a batch run of test cases.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [BatchRunTestCasesMetadata][google.cloud.dialogflow.cx.v3.BatchRunTestCasesMetadata]
     * - `response`: [BatchRunTestCasesResponse][google.cloud.dialogflow.cx.v3.BatchRunTestCasesResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\BatchRunTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchRunTestCases(\Google\Cloud\Dialogflow\Cx\V3\BatchRunTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/BatchRunTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Calculates the test coverage for an agent.
     * @param \Google\Cloud\Dialogflow\Cx\V3\CalculateCoverageRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CalculateCoverage(\Google\Cloud\Dialogflow\Cx\V3\CalculateCoverageRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/CalculateCoverage',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\CalculateCoverageResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Imports the test cases from a Cloud Storage bucket or a local file. It
     * always creates new test cases and won't overwite any existing ones. The
     * provided ID in the imported test case is neglected.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [ImportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ImportTestCasesMetadata]
     * - `response`: [ImportTestCasesResponse][google.cloud.dialogflow.cx.v3.ImportTestCasesResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\ImportTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportTestCases(\Google\Cloud\Dialogflow\Cx\V3\ImportTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/ImportTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports the test cases under the agent to a Cloud Storage bucket or a local
     * file. Filter can be applied to export a subset of test cases.
     *
     * This method is a [long-running
     * operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
     * The returned `Operation` type has the following method-specific fields:
     *
     * - `metadata`: [ExportTestCasesMetadata][google.cloud.dialogflow.cx.v3.ExportTestCasesMetadata]
     * - `response`: [ExportTestCasesResponse][google.cloud.dialogflow.cx.v3.ExportTestCasesResponse]
     * @param \Google\Cloud\Dialogflow\Cx\V3\ExportTestCasesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportTestCases(\Google\Cloud\Dialogflow\Cx\V3\ExportTestCasesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/ExportTestCases',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Fetches a list of results for a given test case.
     * @param \Google\Cloud\Dialogflow\Cx\V3\ListTestCaseResultsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTestCaseResults(\Google\Cloud\Dialogflow\Cx\V3\ListTestCaseResultsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/ListTestCaseResults',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\ListTestCaseResultsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a test case result.
     * @param \Google\Cloud\Dialogflow\Cx\V3\GetTestCaseResultRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTestCaseResult(\Google\Cloud\Dialogflow\Cx\V3\GetTestCaseResultRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dialogflow.cx.v3.TestCases/GetTestCaseResult',
        $argument,
        ['\Google\Cloud\Dialogflow\Cx\V3\TestCaseResult', 'decode'],
        $metadata, $options);
    }

}
