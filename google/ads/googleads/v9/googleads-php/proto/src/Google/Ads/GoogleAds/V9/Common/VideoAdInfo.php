<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/common/ad_type_infos.proto

namespace Google\Ads\GoogleAds\V9\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A video ad.
 *
 * Generated from protobuf message <code>google.ads.googleads.v9.common.VideoAdInfo</code>
 */
class VideoAdInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * The YouTube video assets used for the ad.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.AdVideoAsset video = 8;</code>
     */
    protected $video = null;
    protected $format;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Ads\GoogleAds\V9\Common\AdVideoAsset $video
     *           The YouTube video assets used for the ad.
     *     @type \Google\Ads\GoogleAds\V9\Common\VideoTrueViewInStreamAdInfo $in_stream
     *           Video TrueView in-stream ad format.
     *     @type \Google\Ads\GoogleAds\V9\Common\VideoBumperInStreamAdInfo $bumper
     *           Video bumper in-stream ad format.
     *     @type \Google\Ads\GoogleAds\V9\Common\VideoOutstreamAdInfo $out_stream
     *           Video out-stream ad format.
     *     @type \Google\Ads\GoogleAds\V9\Common\VideoNonSkippableInStreamAdInfo $non_skippable
     *           Video non-skippable in-stream ad format.
     *     @type \Google\Ads\GoogleAds\V9\Common\VideoTrueViewDiscoveryAdInfo $discovery
     *           Video TrueView discovery ad format.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V9\Common\AdTypeInfos::initOnce();
        parent::__construct($data);
    }

    /**
     * The YouTube video assets used for the ad.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.AdVideoAsset video = 8;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\AdVideoAsset|null
     */
    public function getVideo()
    {
        return $this->video;
    }

    public function hasVideo()
    {
        return isset($this->video);
    }

    public function clearVideo()
    {
        unset($this->video);
    }

    /**
     * The YouTube video assets used for the ad.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.AdVideoAsset video = 8;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\AdVideoAsset $var
     * @return $this
     */
    public function setVideo($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\AdVideoAsset::class);
        $this->video = $var;

        return $this;
    }

    /**
     * Video TrueView in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoTrueViewInStreamAdInfo in_stream = 2;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\VideoTrueViewInStreamAdInfo|null
     */
    public function getInStream()
    {
        return $this->readOneof(2);
    }

    public function hasInStream()
    {
        return $this->hasOneof(2);
    }

    /**
     * Video TrueView in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoTrueViewInStreamAdInfo in_stream = 2;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\VideoTrueViewInStreamAdInfo $var
     * @return $this
     */
    public function setInStream($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\VideoTrueViewInStreamAdInfo::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Video bumper in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoBumperInStreamAdInfo bumper = 3;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\VideoBumperInStreamAdInfo|null
     */
    public function getBumper()
    {
        return $this->readOneof(3);
    }

    public function hasBumper()
    {
        return $this->hasOneof(3);
    }

    /**
     * Video bumper in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoBumperInStreamAdInfo bumper = 3;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\VideoBumperInStreamAdInfo $var
     * @return $this
     */
    public function setBumper($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\VideoBumperInStreamAdInfo::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * Video out-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoOutstreamAdInfo out_stream = 4;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\VideoOutstreamAdInfo|null
     */
    public function getOutStream()
    {
        return $this->readOneof(4);
    }

    public function hasOutStream()
    {
        return $this->hasOneof(4);
    }

    /**
     * Video out-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoOutstreamAdInfo out_stream = 4;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\VideoOutstreamAdInfo $var
     * @return $this
     */
    public function setOutStream($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\VideoOutstreamAdInfo::class);
        $this->writeOneof(4, $var);

        return $this;
    }

    /**
     * Video non-skippable in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoNonSkippableInStreamAdInfo non_skippable = 5;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\VideoNonSkippableInStreamAdInfo|null
     */
    public function getNonSkippable()
    {
        return $this->readOneof(5);
    }

    public function hasNonSkippable()
    {
        return $this->hasOneof(5);
    }

    /**
     * Video non-skippable in-stream ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoNonSkippableInStreamAdInfo non_skippable = 5;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\VideoNonSkippableInStreamAdInfo $var
     * @return $this
     */
    public function setNonSkippable($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\VideoNonSkippableInStreamAdInfo::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Video TrueView discovery ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoTrueViewDiscoveryAdInfo discovery = 6;</code>
     * @return \Google\Ads\GoogleAds\V9\Common\VideoTrueViewDiscoveryAdInfo|null
     */
    public function getDiscovery()
    {
        return $this->readOneof(6);
    }

    public function hasDiscovery()
    {
        return $this->hasOneof(6);
    }

    /**
     * Video TrueView discovery ad format.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v9.common.VideoTrueViewDiscoveryAdInfo discovery = 6;</code>
     * @param \Google\Ads\GoogleAds\V9\Common\VideoTrueViewDiscoveryAdInfo $var
     * @return $this
     */
    public function setDiscovery($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V9\Common\VideoTrueViewDiscoveryAdInfo::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getFormat()
    {
        return $this->whichOneof("format");
    }

}

