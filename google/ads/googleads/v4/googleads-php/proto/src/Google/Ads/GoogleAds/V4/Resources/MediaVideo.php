<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/media_file.proto

namespace Google\Ads\GoogleAds\V4\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Encapsulates a Video.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.MediaVideo</code>
 */
class MediaVideo extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The duration of the Video in milliseconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value ad_duration_millis = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $ad_duration_millis = null;
    /**
     * Immutable. The YouTube video ID (as seen in YouTube URLs).
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue youtube_video_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $youtube_video_id = null;
    /**
     * Output only. The Advertising Digital Identification code for this video, as defined by
     * the American Association of Advertising Agencies, used mainly for
     * television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue advertising_id_code = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $advertising_id_code = null;
    /**
     * Output only. The Industry Standard Commercial Identifier code for this video, used
     * mainly for television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue isci_code = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $isci_code = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Int64Value $ad_duration_millis
     *           Output only. The duration of the Video in milliseconds.
     *     @type \Google\Protobuf\StringValue $youtube_video_id
     *           Immutable. The YouTube video ID (as seen in YouTube URLs).
     *     @type \Google\Protobuf\StringValue $advertising_id_code
     *           Output only. The Advertising Digital Identification code for this video, as defined by
     *           the American Association of Advertising Agencies, used mainly for
     *           television commercials.
     *     @type \Google\Protobuf\StringValue $isci_code
     *           Output only. The Industry Standard Commercial Identifier code for this video, used
     *           mainly for television commercials.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\MediaFile::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The duration of the Video in milliseconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value ad_duration_millis = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getAdDurationMillis()
    {
        return isset($this->ad_duration_millis) ? $this->ad_duration_millis : null;
    }

    public function hasAdDurationMillis()
    {
        return isset($this->ad_duration_millis);
    }

    public function clearAdDurationMillis()
    {
        unset($this->ad_duration_millis);
    }

    /**
     * Returns the unboxed value from <code>getAdDurationMillis()</code>

     * Output only. The duration of the Video in milliseconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value ad_duration_millis = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string|null
     */
    public function getAdDurationMillisUnwrapped()
    {
        return $this->readWrapperValue("ad_duration_millis");
    }

    /**
     * Output only. The duration of the Video in milliseconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value ad_duration_millis = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setAdDurationMillis($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->ad_duration_millis = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Output only. The duration of the Video in milliseconds.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value ad_duration_millis = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setAdDurationMillisUnwrapped($var)
    {
        $this->writeWrapperValue("ad_duration_millis", $var);
        return $this;}

    /**
     * Immutable. The YouTube video ID (as seen in YouTube URLs).
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue youtube_video_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getYoutubeVideoId()
    {
        return isset($this->youtube_video_id) ? $this->youtube_video_id : null;
    }

    public function hasYoutubeVideoId()
    {
        return isset($this->youtube_video_id);
    }

    public function clearYoutubeVideoId()
    {
        unset($this->youtube_video_id);
    }

    /**
     * Returns the unboxed value from <code>getYoutubeVideoId()</code>

     * Immutable. The YouTube video ID (as seen in YouTube URLs).
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue youtube_video_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string|null
     */
    public function getYoutubeVideoIdUnwrapped()
    {
        return $this->readWrapperValue("youtube_video_id");
    }

    /**
     * Immutable. The YouTube video ID (as seen in YouTube URLs).
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue youtube_video_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setYoutubeVideoId($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->youtube_video_id = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Immutable. The YouTube video ID (as seen in YouTube URLs).
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue youtube_video_id = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string|null $var
     * @return $this
     */
    public function setYoutubeVideoIdUnwrapped($var)
    {
        $this->writeWrapperValue("youtube_video_id", $var);
        return $this;}

    /**
     * Output only. The Advertising Digital Identification code for this video, as defined by
     * the American Association of Advertising Agencies, used mainly for
     * television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue advertising_id_code = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getAdvertisingIdCode()
    {
        return isset($this->advertising_id_code) ? $this->advertising_id_code : null;
    }

    public function hasAdvertisingIdCode()
    {
        return isset($this->advertising_id_code);
    }

    public function clearAdvertisingIdCode()
    {
        unset($this->advertising_id_code);
    }

    /**
     * Returns the unboxed value from <code>getAdvertisingIdCode()</code>

     * Output only. The Advertising Digital Identification code for this video, as defined by
     * the American Association of Advertising Agencies, used mainly for
     * television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue advertising_id_code = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string|null
     */
    public function getAdvertisingIdCodeUnwrapped()
    {
        return $this->readWrapperValue("advertising_id_code");
    }

    /**
     * Output only. The Advertising Digital Identification code for this video, as defined by
     * the American Association of Advertising Agencies, used mainly for
     * television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue advertising_id_code = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setAdvertisingIdCode($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->advertising_id_code = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Output only. The Advertising Digital Identification code for this video, as defined by
     * the American Association of Advertising Agencies, used mainly for
     * television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue advertising_id_code = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string|null $var
     * @return $this
     */
    public function setAdvertisingIdCodeUnwrapped($var)
    {
        $this->writeWrapperValue("advertising_id_code", $var);
        return $this;}

    /**
     * Output only. The Industry Standard Commercial Identifier code for this video, used
     * mainly for television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue isci_code = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getIsciCode()
    {
        return isset($this->isci_code) ? $this->isci_code : null;
    }

    public function hasIsciCode()
    {
        return isset($this->isci_code);
    }

    public function clearIsciCode()
    {
        unset($this->isci_code);
    }

    /**
     * Returns the unboxed value from <code>getIsciCode()</code>

     * Output only. The Industry Standard Commercial Identifier code for this video, used
     * mainly for television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue isci_code = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string|null
     */
    public function getIsciCodeUnwrapped()
    {
        return $this->readWrapperValue("isci_code");
    }

    /**
     * Output only. The Industry Standard Commercial Identifier code for this video, used
     * mainly for television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue isci_code = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setIsciCode($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->isci_code = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Output only. The Industry Standard Commercial Identifier code for this video, used
     * mainly for television commercials.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue isci_code = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string|null $var
     * @return $this
     */
    public function setIsciCodeUnwrapped($var)
    {
        $this->writeWrapperValue("isci_code", $var);
        return $this;}

}

