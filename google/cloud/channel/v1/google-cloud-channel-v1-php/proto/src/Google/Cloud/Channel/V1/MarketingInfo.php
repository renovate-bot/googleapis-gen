<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/channel/v1/products.proto

namespace Google\Cloud\Channel\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents the marketing information for a Product, SKU or Offer.
 *
 * Generated from protobuf message <code>google.cloud.channel.v1.MarketingInfo</code>
 */
class MarketingInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Human readable name.
     *
     * Generated from protobuf field <code>string display_name = 1;</code>
     */
    protected $display_name = '';
    /**
     * Human readable description. Description can contain HTML.
     *
     * Generated from protobuf field <code>string description = 2;</code>
     */
    protected $description = '';
    /**
     * Default logo.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.Media default_logo = 3;</code>
     */
    protected $default_logo = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $display_name
     *           Human readable name.
     *     @type string $description
     *           Human readable description. Description can contain HTML.
     *     @type \Google\Cloud\Channel\V1\Media $default_logo
     *           Default logo.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Channel\V1\Products::initOnce();
        parent::__construct($data);
    }

    /**
     * Human readable name.
     *
     * Generated from protobuf field <code>string display_name = 1;</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Human readable name.
     *
     * Generated from protobuf field <code>string display_name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * Human readable description. Description can contain HTML.
     *
     * Generated from protobuf field <code>string description = 2;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Human readable description. Description can contain HTML.
     *
     * Generated from protobuf field <code>string description = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * Default logo.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.Media default_logo = 3;</code>
     * @return \Google\Cloud\Channel\V1\Media|null
     */
    public function getDefaultLogo()
    {
        return isset($this->default_logo) ? $this->default_logo : null;
    }

    public function hasDefaultLogo()
    {
        return isset($this->default_logo);
    }

    public function clearDefaultLogo()
    {
        unset($this->default_logo);
    }

    /**
     * Default logo.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.Media default_logo = 3;</code>
     * @param \Google\Cloud\Channel\V1\Media $var
     * @return $this
     */
    public function setDefaultLogo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Channel\V1\Media::class);
        $this->default_logo = $var;

        return $this;
    }

}

