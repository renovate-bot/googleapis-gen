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
namespace Google\Cloud\Retail\V2alpha;

/**
 * Auto-completion service for retail.
 *
 * This feature is only available for users who have Retail Search enabled.
 * Please submit a form [here](https://cloud.google.com/contact) to contact
 * cloud sales if you are interested in using Retail Search.
 */
class CompletionServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Completes the specified prefix with keyword suggestions.
     *
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * @param \Google\Cloud\Retail\V2alpha\CompleteQueryRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CompleteQuery(\Google\Cloud\Retail\V2alpha\CompleteQueryRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2alpha.CompletionService/CompleteQuery',
        $argument,
        ['\Google\Cloud\Retail\V2alpha\CompleteQueryResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Bulk import of processed completion dataset.
     *
     * Request processing may be synchronous. Partial updating is not supported.
     *
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * @param \Google\Cloud\Retail\V2alpha\ImportCompletionDataRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ImportCompletionData(\Google\Cloud\Retail\V2alpha\ImportCompletionDataRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.retail.v2alpha.CompletionService/ImportCompletionData',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
