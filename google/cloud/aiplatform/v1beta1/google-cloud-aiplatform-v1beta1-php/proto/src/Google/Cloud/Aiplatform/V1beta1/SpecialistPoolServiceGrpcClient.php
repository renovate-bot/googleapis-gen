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
 * A service for creating and managing Customer SpecialistPools.
 * When customers start Data Labeling jobs, they can reuse/create Specialist
 * Pools to bring their own Specialists to label the data.
 * Customers can add/remove Managers for the Specialist Pool on Cloud console,
 * then Managers will get email notifications to manage Specialists and tasks on
 * CrowdCompute console.
 */
class SpecialistPoolServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a SpecialistPool.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateSpecialistPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateSpecialistPool(\Google\Cloud\Aiplatform\V1beta1\CreateSpecialistPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.SpecialistPoolService/CreateSpecialistPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a SpecialistPool.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetSpecialistPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetSpecialistPool(\Google\Cloud\Aiplatform\V1beta1\GetSpecialistPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.SpecialistPoolService/GetSpecialistPool',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\SpecialistPool', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists SpecialistPools in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListSpecialistPoolsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListSpecialistPools(\Google\Cloud\Aiplatform\V1beta1\ListSpecialistPoolsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.SpecialistPoolService/ListSpecialistPools',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListSpecialistPoolsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a SpecialistPool as well as all Specialists in the pool.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteSpecialistPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteSpecialistPool(\Google\Cloud\Aiplatform\V1beta1\DeleteSpecialistPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.SpecialistPoolService/DeleteSpecialistPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a SpecialistPool.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateSpecialistPoolRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateSpecialistPool(\Google\Cloud\Aiplatform\V1beta1\UpdateSpecialistPoolRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.SpecialistPoolService/UpdateSpecialistPool',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

}
