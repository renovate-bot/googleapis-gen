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
namespace Google\Cloud\DataQnA\V1alpha;

/**
 * Service to interpret natural language queries.
 * The service allows to create `Question` resources that are interpreted and
 * are filled with one or more interpretations if the question could be
 * interpreted. Once a `Question` resource is created and has at least one
 * interpretation, an interpretation can be chosen for execution, which
 * triggers a query to the backend (for BigQuery, it will create a job).
 * Upon successful execution of that interpretation, backend specific
 * information will be returned so that the client can retrieve the results
 * from the backend.
 *
 * The `Question` resources are named `projects/&#42;/locations/&#42;/questions/*`.
 *
 * The `Question` resource has a singletion sub-resource `UserFeedback` named
 * `projects/&#42;/locations/&#42;/questions/&#42;/userFeedback`, which allows access to
 * user feedback.
 */
class QuestionServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Gets a previously created question.
     * @param \Google\Cloud\DataQnA\V1alpha\GetQuestionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetQuestion(\Google\Cloud\DataQnA\V1alpha\GetQuestionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dataqna.v1alpha.QuestionService/GetQuestion',
        $argument,
        ['\Google\Cloud\DataQnA\V1alpha\Question', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a question.
     * @param \Google\Cloud\DataQnA\V1alpha\CreateQuestionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateQuestion(\Google\Cloud\DataQnA\V1alpha\CreateQuestionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dataqna.v1alpha.QuestionService/CreateQuestion',
        $argument,
        ['\Google\Cloud\DataQnA\V1alpha\Question', 'decode'],
        $metadata, $options);
    }

    /**
     * Executes an interpretation.
     * @param \Google\Cloud\DataQnA\V1alpha\ExecuteQuestionRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExecuteQuestion(\Google\Cloud\DataQnA\V1alpha\ExecuteQuestionRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dataqna.v1alpha.QuestionService/ExecuteQuestion',
        $argument,
        ['\Google\Cloud\DataQnA\V1alpha\Question', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets previously created user feedback.
     * @param \Google\Cloud\DataQnA\V1alpha\GetUserFeedbackRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetUserFeedback(\Google\Cloud\DataQnA\V1alpha\GetUserFeedbackRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dataqna.v1alpha.QuestionService/GetUserFeedback',
        $argument,
        ['\Google\Cloud\DataQnA\V1alpha\UserFeedback', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates user feedback. This creates user feedback if there was none before
     * (upsert).
     * @param \Google\Cloud\DataQnA\V1alpha\UpdateUserFeedbackRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateUserFeedback(\Google\Cloud\DataQnA\V1alpha\UpdateUserFeedbackRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.dataqna.v1alpha.QuestionService/UpdateUserFeedback',
        $argument,
        ['\Google\Cloud\DataQnA\V1alpha\UserFeedback', 'decode'],
        $metadata, $options);
    }

}
