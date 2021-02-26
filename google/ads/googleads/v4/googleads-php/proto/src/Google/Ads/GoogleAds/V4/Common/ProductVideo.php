<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/common/ad_type_infos.proto

namespace Google\Ads\GoogleAds\V4\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Product video specific data.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.common.ProductVideo</code>
 */
class ProductVideo extends \Google\Protobuf\Internal\Message
{
    /**
     * The MediaFile resource name of a video which must be hosted on YouTube.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue product_video = 1;</code>
     */
    protected $product_video = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\StringValue $product_video
     *           The MediaFile resource name of a video which must be hosted on YouTube.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Common\AdTypeInfos::initOnce();
        parent::__construct($data);
    }

    /**
     * The MediaFile resource name of a video which must be hosted on YouTube.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue product_video = 1;</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getProductVideo()
    {
        return isset($this->product_video) ? $this->product_video : null;
    }

    public function hasProductVideo()
    {
        return isset($this->product_video);
    }

    public function clearProductVideo()
    {
        unset($this->product_video);
    }

    /**
     * Returns the unboxed value from <code>getProductVideo()</code>

     * The MediaFile resource name of a video which must be hosted on YouTube.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue product_video = 1;</code>
     * @return string|null
     */
    public function getProductVideoUnwrapped()
    {
        return $this->readWrapperValue("product_video");
    }

    /**
     * The MediaFile resource name of a video which must be hosted on YouTube.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue product_video = 1;</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setProductVideo($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->product_video = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * The MediaFile resource name of a video which must be hosted on YouTube.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue product_video = 1;</code>
     * @param string|null $var
     * @return $this
     */
    public function setProductVideoUnwrapped($var)
    {
        $this->writeWrapperValue("product_video", $var);
        return $this;}

}

