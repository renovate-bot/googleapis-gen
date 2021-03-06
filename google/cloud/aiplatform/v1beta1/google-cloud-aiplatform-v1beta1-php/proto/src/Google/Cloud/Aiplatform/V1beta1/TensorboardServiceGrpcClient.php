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
 * TensorboardService
 */
class TensorboardServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a Tensorboard.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTensorboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTensorboard(\Google\Cloud\Aiplatform\V1beta1\CreateTensorboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/CreateTensorboard',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a Tensorboard.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTensorboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTensorboard(\Google\Cloud\Aiplatform\V1beta1\GetTensorboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/GetTensorboard',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\Tensorboard', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a Tensorboard.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTensorboard(\Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/UpdateTensorboard',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists Tensorboards in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTensorboardsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTensorboards(\Google\Cloud\Aiplatform\V1beta1\ListTensorboardsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ListTensorboards',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTensorboardsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a Tensorboard.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTensorboard(\Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/DeleteTensorboard',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a TensorboardExperiment.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTensorboardExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTensorboardExperiment(\Google\Cloud\Aiplatform\V1beta1\CreateTensorboardExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/CreateTensorboardExperiment',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardExperiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a TensorboardExperiment.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTensorboardExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTensorboardExperiment(\Google\Cloud\Aiplatform\V1beta1\GetTensorboardExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/GetTensorboardExperiment',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardExperiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a TensorboardExperiment.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTensorboardExperiment(\Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/UpdateTensorboardExperiment',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardExperiment', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists TensorboardExperiments in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTensorboardExperimentsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTensorboardExperiments(\Google\Cloud\Aiplatform\V1beta1\ListTensorboardExperimentsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ListTensorboardExperiments',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTensorboardExperimentsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a TensorboardExperiment.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardExperimentRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTensorboardExperiment(\Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardExperimentRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/DeleteTensorboardExperiment',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a TensorboardRun.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTensorboardRunRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTensorboardRun(\Google\Cloud\Aiplatform\V1beta1\CreateTensorboardRunRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/CreateTensorboardRun',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardRun', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a TensorboardRun.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTensorboardRunRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTensorboardRun(\Google\Cloud\Aiplatform\V1beta1\GetTensorboardRunRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/GetTensorboardRun',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardRun', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a TensorboardRun.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardRunRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTensorboardRun(\Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardRunRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/UpdateTensorboardRun',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardRun', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists TensorboardRuns in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTensorboardRunsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTensorboardRuns(\Google\Cloud\Aiplatform\V1beta1\ListTensorboardRunsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ListTensorboardRuns',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTensorboardRunsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a TensorboardRun.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardRunRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTensorboardRun(\Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardRunRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/DeleteTensorboardRun',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a TensorboardTimeSeries.
     * @param \Google\Cloud\Aiplatform\V1beta1\CreateTensorboardTimeSeriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateTensorboardTimeSeries(\Google\Cloud\Aiplatform\V1beta1\CreateTensorboardTimeSeriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/CreateTensorboardTimeSeries',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardTimeSeries', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a TensorboardTimeSeries.
     * @param \Google\Cloud\Aiplatform\V1beta1\GetTensorboardTimeSeriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetTensorboardTimeSeries(\Google\Cloud\Aiplatform\V1beta1\GetTensorboardTimeSeriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/GetTensorboardTimeSeries',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardTimeSeries', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates a TensorboardTimeSeries.
     * @param \Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardTimeSeriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateTensorboardTimeSeries(\Google\Cloud\Aiplatform\V1beta1\UpdateTensorboardTimeSeriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/UpdateTensorboardTimeSeries',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\TensorboardTimeSeries', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists TensorboardTimeSeries in a Location.
     * @param \Google\Cloud\Aiplatform\V1beta1\ListTensorboardTimeSeriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListTensorboardTimeSeries(\Google\Cloud\Aiplatform\V1beta1\ListTensorboardTimeSeriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ListTensorboardTimeSeries',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ListTensorboardTimeSeriesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a TensorboardTimeSeries.
     * @param \Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardTimeSeriesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteTensorboardTimeSeries(\Google\Cloud\Aiplatform\V1beta1\DeleteTensorboardTimeSeriesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/DeleteTensorboardTimeSeries',
        $argument,
        ['\Google\LongRunning\Operation', 'decode'],
        $metadata, $options);
    }

    /**
     * Reads a TensorboardTimeSeries' data. Data is returned in paginated
     * responses. By default, if the number of data points stored is less than
     * 1000, all data will be returned. Otherwise, 1000 data points will be
     * randomly selected from this time series and returned. This value can be
     * changed by changing max_data_points.
     * @param \Google\Cloud\Aiplatform\V1beta1\ReadTensorboardTimeSeriesDataRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ReadTensorboardTimeSeriesData(\Google\Cloud\Aiplatform\V1beta1\ReadTensorboardTimeSeriesDataRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ReadTensorboardTimeSeriesData',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ReadTensorboardTimeSeriesDataResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets bytes of TensorboardBlobs.
     * This is to allow reading blob data stored in consumer project's Cloud
     * Storage bucket without users having to obtain Cloud Storage access
     * permission.
     * @param \Google\Cloud\Aiplatform\V1beta1\ReadTensorboardBlobDataRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\ServerStreamingCall
     */
    public function ReadTensorboardBlobData(\Google\Cloud\Aiplatform\V1beta1\ReadTensorboardBlobDataRequest $argument,
      $metadata = [], $options = []) {
        return $this->_serverStreamRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ReadTensorboardBlobData',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ReadTensorboardBlobDataResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Write time series data points into multiple TensorboardTimeSeries under
     * a TensorboardRun. If any data fail to be ingested, an error will be
     * returned.
     * @param \Google\Cloud\Aiplatform\V1beta1\WriteTensorboardRunDataRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function WriteTensorboardRunData(\Google\Cloud\Aiplatform\V1beta1\WriteTensorboardRunDataRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/WriteTensorboardRunData',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\WriteTensorboardRunDataResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Exports a TensorboardTimeSeries' data. Data is returned in paginated
     * responses.
     * @param \Google\Cloud\Aiplatform\V1beta1\ExportTensorboardTimeSeriesDataRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ExportTensorboardTimeSeriesData(\Google\Cloud\Aiplatform\V1beta1\ExportTensorboardTimeSeriesDataRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.aiplatform.v1beta1.TensorboardService/ExportTensorboardTimeSeriesData',
        $argument,
        ['\Google\Cloud\Aiplatform\V1beta1\ExportTensorboardTimeSeriesDataResponse', 'decode'],
        $metadata, $options);
    }

}
