<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/streetview/publish/v1/resources.proto

namespace Google\Streetview\Publish\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Photo is used to store 360 photos along with photo metadata.
 *
 * Generated from protobuf message <code>google.streetview.publish.v1.Photo</code>
 */
class Photo extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Output only. Required when updating a photo. Output only when creating a photo.
     * Identifier for the photo, which is unique among all photos in
     * Google.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.PhotoId photo_id = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $photo_id = null;
    /**
     * Input only. Required when creating a photo. Input only. The resource URL where the
     * photo bytes are uploaded to.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.UploadRef upload_reference = 2 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     */
    protected $upload_reference = null;
    /**
     * Output only. The download URL for the photo bytes. This field is set only
     * when
     * [GetPhotoRequest.view][google.streetview.publish.v1.GetPhotoRequest.view]
     * is set to
     * [PhotoView.INCLUDE_DOWNLOAD_URL][google.streetview.publish.v1.PhotoView.INCLUDE_DOWNLOAD_URL].
     *
     * Generated from protobuf field <code>string download_url = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $download_url = '';
    /**
     * Output only. The thumbnail URL for showing a preview of the given photo.
     *
     * Generated from protobuf field <code>string thumbnail_url = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $thumbnail_url = '';
    /**
     * Output only. The share link for the photo.
     *
     * Generated from protobuf field <code>string share_link = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $share_link = '';
    /**
     * Optional. Pose of the photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Pose pose = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $pose = null;
    /**
     * Optional. Connections to other photos. A connection represents the link from this
     * photo to another photo.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Connection connections = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $connections;
    /**
     * Optional. Absolute time when the photo was captured.
     * When the photo has no exif timestamp, this is used to set a timestamp in
     * the photo metadata.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp capture_time = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $capture_time = null;
    /**
     * Output only. Time when the image was uploaded.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp upload_time = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $upload_time = null;
    /**
     * Optional. Places where this photo belongs.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Place places = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $places;
    /**
     * Output only. View count of the photo.
     *
     * Generated from protobuf field <code>int64 view_count = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $view_count = 0;
    /**
     * Output only. Status of rights transfer on this photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.TransferStatus transfer_status = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $transfer_status = 0;
    /**
     * Output only. Status in Google Maps, whether this photo was published or rejected.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.MapsPublishStatus maps_publish_status = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $maps_publish_status = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Streetview\Publish\V1\PhotoId $photo_id
     *           Required. Output only. Required when updating a photo. Output only when creating a photo.
     *           Identifier for the photo, which is unique among all photos in
     *           Google.
     *     @type \Google\Streetview\Publish\V1\UploadRef $upload_reference
     *           Input only. Required when creating a photo. Input only. The resource URL where the
     *           photo bytes are uploaded to.
     *     @type string $download_url
     *           Output only. The download URL for the photo bytes. This field is set only
     *           when
     *           [GetPhotoRequest.view][google.streetview.publish.v1.GetPhotoRequest.view]
     *           is set to
     *           [PhotoView.INCLUDE_DOWNLOAD_URL][google.streetview.publish.v1.PhotoView.INCLUDE_DOWNLOAD_URL].
     *     @type string $thumbnail_url
     *           Output only. The thumbnail URL for showing a preview of the given photo.
     *     @type string $share_link
     *           Output only. The share link for the photo.
     *     @type \Google\Streetview\Publish\V1\Pose $pose
     *           Optional. Pose of the photo.
     *     @type \Google\Streetview\Publish\V1\Connection[]|\Google\Protobuf\Internal\RepeatedField $connections
     *           Optional. Connections to other photos. A connection represents the link from this
     *           photo to another photo.
     *     @type \Google\Protobuf\Timestamp $capture_time
     *           Optional. Absolute time when the photo was captured.
     *           When the photo has no exif timestamp, this is used to set a timestamp in
     *           the photo metadata.
     *     @type \Google\Protobuf\Timestamp $upload_time
     *           Output only. Time when the image was uploaded.
     *     @type \Google\Streetview\Publish\V1\Place[]|\Google\Protobuf\Internal\RepeatedField $places
     *           Optional. Places where this photo belongs.
     *     @type int|string $view_count
     *           Output only. View count of the photo.
     *     @type int $transfer_status
     *           Output only. Status of rights transfer on this photo.
     *     @type int $maps_publish_status
     *           Output only. Status in Google Maps, whether this photo was published or rejected.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Streetview\Publish\V1\Resources::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Output only. Required when updating a photo. Output only when creating a photo.
     * Identifier for the photo, which is unique among all photos in
     * Google.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.PhotoId photo_id = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Streetview\Publish\V1\PhotoId|null
     */
    public function getPhotoId()
    {
        return $this->photo_id;
    }

    public function hasPhotoId()
    {
        return isset($this->photo_id);
    }

    public function clearPhotoId()
    {
        unset($this->photo_id);
    }

    /**
     * Required. Output only. Required when updating a photo. Output only when creating a photo.
     * Identifier for the photo, which is unique among all photos in
     * Google.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.PhotoId photo_id = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Streetview\Publish\V1\PhotoId $var
     * @return $this
     */
    public function setPhotoId($var)
    {
        GPBUtil::checkMessage($var, \Google\Streetview\Publish\V1\PhotoId::class);
        $this->photo_id = $var;

        return $this;
    }

    /**
     * Input only. Required when creating a photo. Input only. The resource URL where the
     * photo bytes are uploaded to.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.UploadRef upload_reference = 2 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     * @return \Google\Streetview\Publish\V1\UploadRef|null
     */
    public function getUploadReference()
    {
        return $this->upload_reference;
    }

    public function hasUploadReference()
    {
        return isset($this->upload_reference);
    }

    public function clearUploadReference()
    {
        unset($this->upload_reference);
    }

    /**
     * Input only. Required when creating a photo. Input only. The resource URL where the
     * photo bytes are uploaded to.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.UploadRef upload_reference = 2 [(.google.api.field_behavior) = INPUT_ONLY];</code>
     * @param \Google\Streetview\Publish\V1\UploadRef $var
     * @return $this
     */
    public function setUploadReference($var)
    {
        GPBUtil::checkMessage($var, \Google\Streetview\Publish\V1\UploadRef::class);
        $this->upload_reference = $var;

        return $this;
    }

    /**
     * Output only. The download URL for the photo bytes. This field is set only
     * when
     * [GetPhotoRequest.view][google.streetview.publish.v1.GetPhotoRequest.view]
     * is set to
     * [PhotoView.INCLUDE_DOWNLOAD_URL][google.streetview.publish.v1.PhotoView.INCLUDE_DOWNLOAD_URL].
     *
     * Generated from protobuf field <code>string download_url = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getDownloadUrl()
    {
        return $this->download_url;
    }

    /**
     * Output only. The download URL for the photo bytes. This field is set only
     * when
     * [GetPhotoRequest.view][google.streetview.publish.v1.GetPhotoRequest.view]
     * is set to
     * [PhotoView.INCLUDE_DOWNLOAD_URL][google.streetview.publish.v1.PhotoView.INCLUDE_DOWNLOAD_URL].
     *
     * Generated from protobuf field <code>string download_url = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setDownloadUrl($var)
    {
        GPBUtil::checkString($var, True);
        $this->download_url = $var;

        return $this;
    }

    /**
     * Output only. The thumbnail URL for showing a preview of the given photo.
     *
     * Generated from protobuf field <code>string thumbnail_url = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getThumbnailUrl()
    {
        return $this->thumbnail_url;
    }

    /**
     * Output only. The thumbnail URL for showing a preview of the given photo.
     *
     * Generated from protobuf field <code>string thumbnail_url = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setThumbnailUrl($var)
    {
        GPBUtil::checkString($var, True);
        $this->thumbnail_url = $var;

        return $this;
    }

    /**
     * Output only. The share link for the photo.
     *
     * Generated from protobuf field <code>string share_link = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getShareLink()
    {
        return $this->share_link;
    }

    /**
     * Output only. The share link for the photo.
     *
     * Generated from protobuf field <code>string share_link = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setShareLink($var)
    {
        GPBUtil::checkString($var, True);
        $this->share_link = $var;

        return $this;
    }

    /**
     * Optional. Pose of the photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Pose pose = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Streetview\Publish\V1\Pose|null
     */
    public function getPose()
    {
        return $this->pose;
    }

    public function hasPose()
    {
        return isset($this->pose);
    }

    public function clearPose()
    {
        unset($this->pose);
    }

    /**
     * Optional. Pose of the photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Pose pose = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Streetview\Publish\V1\Pose $var
     * @return $this
     */
    public function setPose($var)
    {
        GPBUtil::checkMessage($var, \Google\Streetview\Publish\V1\Pose::class);
        $this->pose = $var;

        return $this;
    }

    /**
     * Optional. Connections to other photos. A connection represents the link from this
     * photo to another photo.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Connection connections = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getConnections()
    {
        return $this->connections;
    }

    /**
     * Optional. Connections to other photos. A connection represents the link from this
     * photo to another photo.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Connection connections = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Streetview\Publish\V1\Connection[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setConnections($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Streetview\Publish\V1\Connection::class);
        $this->connections = $arr;

        return $this;
    }

    /**
     * Optional. Absolute time when the photo was captured.
     * When the photo has no exif timestamp, this is used to set a timestamp in
     * the photo metadata.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp capture_time = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCaptureTime()
    {
        return $this->capture_time;
    }

    public function hasCaptureTime()
    {
        return isset($this->capture_time);
    }

    public function clearCaptureTime()
    {
        unset($this->capture_time);
    }

    /**
     * Optional. Absolute time when the photo was captured.
     * When the photo has no exif timestamp, this is used to set a timestamp in
     * the photo metadata.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp capture_time = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCaptureTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->capture_time = $var;

        return $this;
    }

    /**
     * Output only. Time when the image was uploaded.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp upload_time = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUploadTime()
    {
        return $this->upload_time;
    }

    public function hasUploadTime()
    {
        return isset($this->upload_time);
    }

    public function clearUploadTime()
    {
        unset($this->upload_time);
    }

    /**
     * Output only. Time when the image was uploaded.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp upload_time = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUploadTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->upload_time = $var;

        return $this;
    }

    /**
     * Optional. Places where this photo belongs.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Place places = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getPlaces()
    {
        return $this->places;
    }

    /**
     * Optional. Places where this photo belongs.
     *
     * Generated from protobuf field <code>repeated .google.streetview.publish.v1.Place places = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Streetview\Publish\V1\Place[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setPlaces($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Streetview\Publish\V1\Place::class);
        $this->places = $arr;

        return $this;
    }

    /**
     * Output only. View count of the photo.
     *
     * Generated from protobuf field <code>int64 view_count = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string
     */
    public function getViewCount()
    {
        return $this->view_count;
    }

    /**
     * Output only. View count of the photo.
     *
     * Generated from protobuf field <code>int64 view_count = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string $var
     * @return $this
     */
    public function setViewCount($var)
    {
        GPBUtil::checkInt64($var);
        $this->view_count = $var;

        return $this;
    }

    /**
     * Output only. Status of rights transfer on this photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.TransferStatus transfer_status = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getTransferStatus()
    {
        return $this->transfer_status;
    }

    /**
     * Output only. Status of rights transfer on this photo.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.TransferStatus transfer_status = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setTransferStatus($var)
    {
        GPBUtil::checkEnum($var, \Google\Streetview\Publish\V1\Photo\TransferStatus::class);
        $this->transfer_status = $var;

        return $this;
    }

    /**
     * Output only. Status in Google Maps, whether this photo was published or rejected.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.MapsPublishStatus maps_publish_status = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getMapsPublishStatus()
    {
        return $this->maps_publish_status;
    }

    /**
     * Output only. Status in Google Maps, whether this photo was published or rejected.
     *
     * Generated from protobuf field <code>.google.streetview.publish.v1.Photo.MapsPublishStatus maps_publish_status = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setMapsPublishStatus($var)
    {
        GPBUtil::checkEnum($var, \Google\Streetview\Publish\V1\Photo\MapsPublishStatus::class);
        $this->maps_publish_status = $var;

        return $this;
    }

}

