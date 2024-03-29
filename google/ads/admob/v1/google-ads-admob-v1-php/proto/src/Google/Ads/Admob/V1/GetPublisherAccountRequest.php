<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/admob/v1/admob_api.proto

namespace Google\Ads\Admob\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request to retrieve the specified publisher account.
 *
 * Generated from protobuf message <code>google.ads.admob.v1.GetPublisherAccountRequest</code>
 */
class GetPublisherAccountRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Resource name of the publisher account to retrieve.
     * Example: accounts/pub-9876543210987654
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Resource name of the publisher account to retrieve.
     *           Example: accounts/pub-9876543210987654
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Admob\V1\AdmobApi::initOnce();
        parent::__construct($data);
    }

    /**
     * Resource name of the publisher account to retrieve.
     * Example: accounts/pub-9876543210987654
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Resource name of the publisher account to retrieve.
     * Example: accounts/pub-9876543210987654
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

}

