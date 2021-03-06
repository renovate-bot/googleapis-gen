<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/chromeos/moblab/v1beta1/build_service.proto

namespace Google\Chromeos\Moblab\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for listing build targets.
 *
 * Generated from protobuf message <code>google.chromeos.moblab.v1beta1.ListBuildTargetsRequest</code>
 */
class ListBuildTargetsRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Optional. The number of build targets to return in a page.
     *
     * Generated from protobuf field <code>int32 page_size = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_size = 0;
    /**
     * Optional. A page token, received from a previous `ListBuildTargets` call. Provide
     * this to retrieve the subsequent page.
     *
     * Generated from protobuf field <code>string page_token = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $page_size
     *           Optional. The number of build targets to return in a page.
     *     @type string $page_token
     *           Optional. A page token, received from a previous `ListBuildTargets` call. Provide
     *           this to retrieve the subsequent page.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Chromeos\Moblab\V1Beta1\BuildService::initOnce();
        parent::__construct($data);
    }

    /**
     * Optional. The number of build targets to return in a page.
     *
     * Generated from protobuf field <code>int32 page_size = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Optional. The number of build targets to return in a page.
     *
     * Generated from protobuf field <code>int32 page_size = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param int $var
     * @return $this
     */
    public function setPageSize($var)
    {
        GPBUtil::checkInt32($var);
        $this->page_size = $var;

        return $this;
    }

    /**
     * Optional. A page token, received from a previous `ListBuildTargets` call. Provide
     * this to retrieve the subsequent page.
     *
     * Generated from protobuf field <code>string page_token = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Optional. A page token, received from a previous `ListBuildTargets` call. Provide
     * this to retrieve the subsequent page.
     *
     * Generated from protobuf field <code>string page_token = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->page_token = $var;

        return $this;
    }

}

