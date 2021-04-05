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
namespace Google\Cloud\Bigquery\Storage\V1alpha2;

/**
 * BigQuery Write API.
 *
 * The Write API can be used to write data to BigQuery.
 */
class BigQueryWriteGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates a write stream to the given table.
     * Additionally, every table has a special COMMITTED stream named '_default'
     * to which data can be written. This stream doesn't need to be created using
     * CreateWriteStream. It is a stream that can be used simultaneously by any
     * number of clients. Data written to this stream is considered committed as
     * soon as an acknowledgement is received.
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\CreateWriteStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateWriteStream(\Google\Cloud\Bigquery\Storage\V1alpha2\CreateWriteStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/CreateWriteStream',
        $argument,
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\WriteStream', 'decode'],
        $metadata, $options);
    }

    /**
     * Appends data to the given stream.
     *
     * If `offset` is specified, the `offset` is checked against the end of
     * stream. The server returns `OUT_OF_RANGE` in `AppendRowsResponse` if an
     * attempt is made to append to an offset beyond the current end of the stream
     * or `ALREADY_EXISTS` if user provids an `offset` that has already been
     * written to. User can retry with adjusted offset within the same RPC
     * stream. If `offset` is not specified, append happens at the end of the
     * stream.
     *
     * The response contains the offset at which the append happened. Responses
     * are received in the same order in which requests are sent. There will be
     * one response for each successful request. If the `offset` is not set in
     * response, it means append didn't happen due to some errors. If one request
     * fails, all the subsequent requests will also fail until a success request
     * is made again.
     *
     * If the stream is of `PENDING` type, data will only be available for read
     * operations after the stream is committed.
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\BidiStreamingCall
     */
    public function AppendRows($metadata = [], $options = []) {
        return $this->_bidiRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/AppendRows',
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\AppendRowsResponse','decode'],
        $metadata, $options);
    }

    /**
     * Gets a write stream.
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\GetWriteStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetWriteStream(\Google\Cloud\Bigquery\Storage\V1alpha2\GetWriteStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/GetWriteStream',
        $argument,
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\WriteStream', 'decode'],
        $metadata, $options);
    }

    /**
     * Finalize a write stream so that no new data can be appended to the
     * stream. Finalize is not supported on the '_default' stream.
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\FinalizeWriteStreamRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FinalizeWriteStream(\Google\Cloud\Bigquery\Storage\V1alpha2\FinalizeWriteStreamRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/FinalizeWriteStream',
        $argument,
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\FinalizeWriteStreamResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Atomically commits a group of `PENDING` streams that belong to the same
     * `parent` table.
     * Streams must be finalized before commit and cannot be committed multiple
     * times. Once a stream is committed, data in the stream becomes available
     * for read operations.
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\BatchCommitWriteStreamsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchCommitWriteStreams(\Google\Cloud\Bigquery\Storage\V1alpha2\BatchCommitWriteStreamsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/BatchCommitWriteStreams',
        $argument,
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\BatchCommitWriteStreamsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Flushes rows to a BUFFERED stream.
     * If users are appending rows to BUFFERED stream, flush operation is
     * required in order for the rows to become available for reading. A
     * Flush operation flushes up to any previously flushed offset in a BUFFERED
     * stream, to the offset specified in the request.
     * Flush is not supported on the _default stream, since it is not BUFFERED.
     * @param \Google\Cloud\Bigquery\Storage\V1alpha2\FlushRowsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function FlushRows(\Google\Cloud\Bigquery\Storage\V1alpha2\FlushRowsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.cloud.bigquery.storage.v1alpha2.BigQueryWrite/FlushRows',
        $argument,
        ['\Google\Cloud\Bigquery\Storage\V1alpha2\FlushRowsResponse', 'decode'],
        $metadata, $options);
    }

}
