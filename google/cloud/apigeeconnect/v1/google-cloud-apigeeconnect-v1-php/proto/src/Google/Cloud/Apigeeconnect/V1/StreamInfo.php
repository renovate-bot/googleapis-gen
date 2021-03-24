<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/apigeeconnect/v1/tether.proto

namespace Google\Cloud\Apigeeconnect\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The Information of bi-directional stream.
 *
 * Generated from protobuf message <code>google.cloud.apigeeconnect.v1.StreamInfo</code>
 */
class StreamInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Unique identifier for the stream.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     */
    protected $id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $id
     *           Unique identifier for the stream.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Apigeeconnect\V1\Tether::initOnce();
        parent::__construct($data);
    }

    /**
     * Unique identifier for the stream.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Unique identifier for the stream.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

}

