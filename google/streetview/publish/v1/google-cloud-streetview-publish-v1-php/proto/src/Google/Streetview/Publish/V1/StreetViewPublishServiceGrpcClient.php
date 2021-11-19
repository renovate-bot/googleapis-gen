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
namespace Google\Streetview\Publish\V1;

/**
 * Definition of the service that backs the Street View Publish API.
 *
 * Publishes and connects user-contributed photos on Street View.
 */
class StreetViewPublishServiceGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Creates an upload session to start uploading photo bytes.  The method uses
     * the upload URL of the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
     * the [Photo][google.streetview.publish.v1.Photo].
     *
     * In addition to the photo requirements shown in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604,
     * the photo must meet the following requirements:
     *
     * * Photo Sphere XMP metadata must be included in the photo metadata. See
     * https://developers.google.com/streetview/spherical-metadata for the
     * required fields.
     * * The pixel size of the photo must meet the size requirements listed in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604, and
     * the photo must be a full 360 horizontally.
     *
     * After the upload completes, the method uses
     * [UploadRef][google.streetview.publish.v1.UploadRef] with
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * to create the [Photo][google.streetview.publish.v1.Photo] object entry.
     * @param \Google\Protobuf\GPBEmpty $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function StartUpload(\Google\Protobuf\GPBEmpty $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/StartUpload',
        $argument,
        ['\Google\Streetview\Publish\V1\UploadRef', 'decode'],
        $metadata, $options);
    }

    /**
     * After the client finishes uploading the photo with the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef],
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
     * Street View on Google Maps.
     *
     * Currently, the only way to set heading, pitch, and roll in CreatePhoto is
     * through the [Photo Sphere XMP
     * metadata](https://developers.google.com/streetview/spherical-metadata) in
     * the photo bytes. CreatePhoto ignores the  `pose.heading`, `pose.pitch`,
     * `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
     *
     * This method returns the following error codes:
     *
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed or if
     * the uploaded photo is not a 360 photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload reference does not exist.
     * * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED] if the account has reached the
     * storage limit.
     * @param \Google\Streetview\Publish\V1\CreatePhotoRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreatePhoto(\Google\Streetview\Publish\V1\CreatePhotoRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/CreatePhoto',
        $argument,
        ['\Google\Streetview\Publish\V1\Photo', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo].
     *
     * This method returns the following error codes:
     *
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested [Photo][google.streetview.publish.v1.Photo].
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
     * [Photo][google.streetview.publish.v1.Photo] does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * @param \Google\Streetview\Publish\V1\GetPhotoRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetPhoto(\Google\Streetview\Publish\V1\GetPhotoRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/GetPhoto',
        $argument,
        ['\Google\Streetview\Publish\V1\Photo', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo] batch.
     *
     * Note that if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
     * See
     * [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
     * for specific failures that can occur per photo.
     * @param \Google\Streetview\Publish\V1\BatchGetPhotosRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchGetPhotos(\Google\Streetview\Publish\V1\BatchGetPhotosRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/BatchGetPhotos',
        $argument,
        ['\Google\Streetview\Publish\V1\BatchGetPhotosResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
     * the user.
     *
     * > Note: Recently created photos that are still
     * being indexed are not returned in the response.
     * @param \Google\Streetview\Publish\V1\ListPhotosRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListPhotos(\Google\Streetview\Publish\V1\ListPhotosRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/ListPhotos',
        $argument,
        ['\Google\Streetview\Publish\V1\ListPhotosResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of a
     * photo is not supported.
     *
     * Only the fields specified in the
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     *
     * This method returns the following error codes:
     *
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested photo does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * @param \Google\Streetview\Publish\V1\UpdatePhotoRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdatePhoto(\Google\Streetview\Publish\V1\UpdatePhotoRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/UpdatePhoto',
        $argument,
        ['\Google\Streetview\Publish\V1\Photo', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of photos
     * is not supported.
     *
     * Note that if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
     * See
     * [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
     * for specific failures that can occur per photo.
     *
     * Only the fields specified in
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     *
     * The number of
     * [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
     * messages in a
     * [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
     * must not exceed 20.
     *
     * > Note: To update
     * [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
     * [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
     * filled as well. Otherwise, the request will fail.
     * @param \Google\Streetview\Publish\V1\BatchUpdatePhotosRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchUpdatePhotos(\Google\Streetview\Publish\V1\BatchUpdatePhotosRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/BatchUpdatePhotos',
        $argument,
        ['\Google\Streetview\Publish\V1\BatchUpdatePhotosResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
     *
     * This method returns the following error codes:
     *
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID does not exist.
     * @param \Google\Streetview\Publish\V1\DeletePhotoRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeletePhoto(\Google\Streetview\Publish\V1\DeletePhotoRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/DeletePhoto',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
     * metadata.
     *
     * Note that if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
     * See
     * [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
     * for specific failures that can occur per photo.
     * @param \Google\Streetview\Publish\V1\BatchDeletePhotosRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function BatchDeletePhotos(\Google\Streetview\Publish\V1\BatchDeletePhotosRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.streetview.publish.v1.StreetViewPublishService/BatchDeletePhotos',
        $argument,
        ['\Google\Streetview\Publish\V1\BatchDeletePhotosResponse', 'decode'],
        $metadata, $options);
    }

}
