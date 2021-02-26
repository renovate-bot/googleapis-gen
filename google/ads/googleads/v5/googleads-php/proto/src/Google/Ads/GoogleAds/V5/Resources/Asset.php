<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/asset.proto

namespace Google\Ads\GoogleAds\V5\Resources;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Asset is a part of an ad which can be shared across multiple ads.
 * It can be an image (ImageAsset), a video (YoutubeVideoAsset), etc.
 *
 * Generated from protobuf message <code>google.ads.googleads.v5.resources.Asset</code>
 */
class Asset extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. The resource name of the asset.
     * Asset resource names have the form:
     * `customers/{customer_id}/assets/{asset_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $resource_name = '';
    /**
     * Output only. The ID of the asset.
     *
     * Generated from protobuf field <code>int64 id = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $id = null;
    /**
     * Optional name of the asset.
     *
     * Generated from protobuf field <code>string name = 12;</code>
     */
    protected $name = null;
    /**
     * Output only. Type of the asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.AssetTypeEnum.AssetType type = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $type = 0;
    protected $asset_data;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $resource_name
     *           Immutable. The resource name of the asset.
     *           Asset resource names have the form:
     *           `customers/{customer_id}/assets/{asset_id}`
     *     @type int|string $id
     *           Output only. The ID of the asset.
     *     @type string $name
     *           Optional name of the asset.
     *     @type int $type
     *           Output only. Type of the asset.
     *     @type \Google\Ads\GoogleAds\V5\Common\YoutubeVideoAsset $youtube_video_asset
     *           Immutable. A YouTube video asset.
     *     @type \Google\Ads\GoogleAds\V5\Common\MediaBundleAsset $media_bundle_asset
     *           Immutable. A media bundle asset.
     *     @type \Google\Ads\GoogleAds\V5\Common\ImageAsset $image_asset
     *           Output only. An image asset.
     *     @type \Google\Ads\GoogleAds\V5\Common\TextAsset $text_asset
     *           Output only. A text asset.
     *     @type \Google\Ads\GoogleAds\V5\Common\BookOnGoogleAsset $book_on_google_asset
     *           A book on google asset.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V5\Resources\Asset::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. The resource name of the asset.
     * Asset resource names have the form:
     * `customers/{customer_id}/assets/{asset_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getResourceName()
    {
        return $this->resource_name;
    }

    /**
     * Immutable. The resource name of the asset.
     * Asset resource names have the form:
     * `customers/{customer_id}/assets/{asset_id}`
     *
     * Generated from protobuf field <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->resource_name = $var;

        return $this;
    }

    /**
     * Output only. The ID of the asset.
     *
     * Generated from protobuf field <code>int64 id = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int|string
     */
    public function getId()
    {
        return isset($this->id) ? $this->id : 0;
    }

    public function hasId()
    {
        return isset($this->id);
    }

    public function clearId()
    {
        unset($this->id);
    }

    /**
     * Output only. The ID of the asset.
     *
     * Generated from protobuf field <code>int64 id = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int|string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkInt64($var);
        $this->id = $var;

        return $this;
    }

    /**
     * Optional name of the asset.
     *
     * Generated from protobuf field <code>string name = 12;</code>
     * @return string
     */
    public function getName()
    {
        return isset($this->name) ? $this->name : '';
    }

    public function hasName()
    {
        return isset($this->name);
    }

    public function clearName()
    {
        unset($this->name);
    }

    /**
     * Optional name of the asset.
     *
     * Generated from protobuf field <code>string name = 12;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Output only. Type of the asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.AssetTypeEnum.AssetType type = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * Output only. Type of the asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.enums.AssetTypeEnum.AssetType type = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkEnum($var, \Google\Ads\GoogleAds\V5\Enums\AssetTypeEnum\AssetType::class);
        $this->type = $var;

        return $this;
    }

    /**
     * Immutable. A YouTube video asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.YoutubeVideoAsset youtube_video_asset = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\YoutubeVideoAsset|null
     */
    public function getYoutubeVideoAsset()
    {
        return $this->readOneof(5);
    }

    public function hasYoutubeVideoAsset()
    {
        return $this->hasOneof(5);
    }

    /**
     * Immutable. A YouTube video asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.YoutubeVideoAsset youtube_video_asset = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\YoutubeVideoAsset $var
     * @return $this
     */
    public function setYoutubeVideoAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\YoutubeVideoAsset::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Immutable. A media bundle asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.MediaBundleAsset media_bundle_asset = 6 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\MediaBundleAsset|null
     */
    public function getMediaBundleAsset()
    {
        return $this->readOneof(6);
    }

    public function hasMediaBundleAsset()
    {
        return $this->hasOneof(6);
    }

    /**
     * Immutable. A media bundle asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.MediaBundleAsset media_bundle_asset = 6 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\MediaBundleAsset $var
     * @return $this
     */
    public function setMediaBundleAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\MediaBundleAsset::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * Output only. An image asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ImageAsset image_asset = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\ImageAsset|null
     */
    public function getImageAsset()
    {
        return $this->readOneof(7);
    }

    public function hasImageAsset()
    {
        return $this->hasOneof(7);
    }

    /**
     * Output only. An image asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.ImageAsset image_asset = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\ImageAsset $var
     * @return $this
     */
    public function setImageAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\ImageAsset::class);
        $this->writeOneof(7, $var);

        return $this;
    }

    /**
     * Output only. A text asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.TextAsset text_asset = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Ads\GoogleAds\V5\Common\TextAsset|null
     */
    public function getTextAsset()
    {
        return $this->readOneof(8);
    }

    public function hasTextAsset()
    {
        return $this->hasOneof(8);
    }

    /**
     * Output only. A text asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.TextAsset text_asset = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Ads\GoogleAds\V5\Common\TextAsset $var
     * @return $this
     */
    public function setTextAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\TextAsset::class);
        $this->writeOneof(8, $var);

        return $this;
    }

    /**
     * A book on google asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.BookOnGoogleAsset book_on_google_asset = 10;</code>
     * @return \Google\Ads\GoogleAds\V5\Common\BookOnGoogleAsset|null
     */
    public function getBookOnGoogleAsset()
    {
        return $this->readOneof(10);
    }

    public function hasBookOnGoogleAsset()
    {
        return $this->hasOneof(10);
    }

    /**
     * A book on google asset.
     *
     * Generated from protobuf field <code>.google.ads.googleads.v5.common.BookOnGoogleAsset book_on_google_asset = 10;</code>
     * @param \Google\Ads\GoogleAds\V5\Common\BookOnGoogleAsset $var
     * @return $this
     */
    public function setBookOnGoogleAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Ads\GoogleAds\V5\Common\BookOnGoogleAsset::class);
        $this->writeOneof(10, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getAssetData()
    {
        return $this->whichOneof("asset_data");
    }

}

