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
namespace Google\Storage\V2;

/**
 * Manages Google Cloud Storage resources.
 */
class StorageGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Retrieves an object's metadata.
     * @param \Google\Storage\V2\GetObjectRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetObject(\Google\Storage\V2\GetObjectRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.storage.v2.Storage/GetObject',
        $argument,
        ['\Google\Storage\V2\Object', 'decode'],
        $metadata, $options);
    }

    /**
     * Reads an object's data.
     * @param \Google\Storage\V2\ReadObjectRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\ServerStreamingCall
     */
    public function ReadObject(\Google\Storage\V2\ReadObjectRequest $argument,
      $metadata = [], $options = []) {
        return $this->_serverStreamRequest('/google.storage.v2.Storage/ReadObject',
        $argument,
        ['\Google\Storage\V2\ReadObjectResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Stores a new object and metadata.
     *
     * An object can be written either in a single message stream or in a
     * resumable sequence of message streams. To write using a single stream,
     * the client should include in the first message of the stream an
     * `WriteObjectSpec` describing the destination bucket, object, and any
     * preconditions. Additionally, the final message must set 'finish_write' to
     * true, or else it is an error.
     *
     * For a resumable write, the client should instead call
     * `StartResumableWrite()` and provide that method an `WriteObjectSpec.`
     * They should then attach the returned `upload_id` to the first message of
     * each following call to `Create`. If there is an error or the connection is
     * broken during the resumable `Create()`, the client should check the status
     * of the `Create()` by calling `QueryWriteStatus()` and continue writing from
     * the returned `committed_size`. This may be less than the amount of data the
     * client previously sent.
     *
     * The service will not view the object as complete until the client has
     * sent a `WriteObjectRequest` with `finish_write` set to `true`. Sending any
     * requests on a stream after sending a request with `finish_write` set to
     * `true` will cause an error. The client **should** check the response it
     * receives to determine how much data the service was able to commit and
     * whether the service views the object as complete.
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\ClientStreamingCall
     */
    public function WriteObject($metadata = [], $options = []) {
        return $this->_clientStreamRequest('/google.storage.v2.Storage/WriteObject',
        ['\Google\Storage\V2\WriteObjectResponse','decode'],
        $metadata, $options);
    }

    /**
     * Starts a resumable write. How long the write operation remains valid, and
     * what happens when the write operation becomes invalid, are
     * service-dependent.
     * @param \Google\Storage\V2\StartResumableWriteRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartResumableWrite(\Google\Storage\V2\StartResumableWriteRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.storage.v2.Storage/StartResumableWrite',
        $argument,
        ['\Google\Storage\V2\StartResumableWriteResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Determines the `committed_size` for an object that is being written, which
     * can then be used as the `write_offset` for the next `Write()` call.
     *
     * If the object does not exist (i.e., the object has been deleted, or the
     * first `Write()` has not yet reached the service), this method returns the
     * error `NOT_FOUND`.
     *
     * The client **may** call `QueryWriteStatus()` at any time to determine how
     * much data has been processed for this object. This is useful if the
     * client is buffering data and needs to know which data can be safely
     * evicted. For any sequence of `QueryWriteStatus()` calls for a given
     * object name, the sequence of returned `committed_size` values will be
     * non-decreasing.
     * @param \Google\Storage\V2\QueryWriteStatusRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryWriteStatus(\Google\Storage\V2\QueryWriteStatusRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.storage.v2.Storage/QueryWriteStatus',
        $argument,
        ['\Google\Storage\V2\QueryWriteStatusResponse', 'decode'],
        $metadata, $options);
    }

}
