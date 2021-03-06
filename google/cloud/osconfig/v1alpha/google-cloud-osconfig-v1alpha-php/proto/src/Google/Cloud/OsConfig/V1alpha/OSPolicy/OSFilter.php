<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/v1alpha/os_policy.proto

namespace Google\Cloud\OsConfig\V1alpha\OSPolicy;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The `OSFilter` is used to specify the OS filtering criteria for the
 * resource group.
 *
 * Generated from protobuf message <code>google.cloud.osconfig.v1alpha.OSPolicy.OSFilter</code>
 */
class OSFilter extends \Google\Protobuf\Internal\Message
{
    /**
     * This should match OS short name emitted by the OS inventory agent.
     * An empty value matches any OS.
     *
     * Generated from protobuf field <code>string os_short_name = 1;</code>
     */
    protected $os_short_name = '';
    /**
     * This value should match the version emitted by the OS inventory
     * agent.
     * Prefix matches are supported if asterisk(*) is provided as the
     * last character. For example, to match all versions with a major
     * version of `7`, specify the following value for this field `7.*`
     *
     * Generated from protobuf field <code>string os_version = 2;</code>
     */
    protected $os_version = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $os_short_name
     *           This should match OS short name emitted by the OS inventory agent.
     *           An empty value matches any OS.
     *     @type string $os_version
     *           This value should match the version emitted by the OS inventory
     *           agent.
     *           Prefix matches are supported if asterisk(*) is provided as the
     *           last character. For example, to match all versions with a major
     *           version of `7`, specify the following value for this field `7.*`
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Osconfig\V1Alpha\OsPolicy::initOnce();
        parent::__construct($data);
    }

    /**
     * This should match OS short name emitted by the OS inventory agent.
     * An empty value matches any OS.
     *
     * Generated from protobuf field <code>string os_short_name = 1;</code>
     * @return string
     */
    public function getOsShortName()
    {
        return $this->os_short_name;
    }

    /**
     * This should match OS short name emitted by the OS inventory agent.
     * An empty value matches any OS.
     *
     * Generated from protobuf field <code>string os_short_name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setOsShortName($var)
    {
        GPBUtil::checkString($var, True);
        $this->os_short_name = $var;

        return $this;
    }

    /**
     * This value should match the version emitted by the OS inventory
     * agent.
     * Prefix matches are supported if asterisk(*) is provided as the
     * last character. For example, to match all versions with a major
     * version of `7`, specify the following value for this field `7.*`
     *
     * Generated from protobuf field <code>string os_version = 2;</code>
     * @return string
     */
    public function getOsVersion()
    {
        return $this->os_version;
    }

    /**
     * This value should match the version emitted by the OS inventory
     * agent.
     * Prefix matches are supported if asterisk(*) is provided as the
     * last character. For example, to match all versions with a major
     * version of `7`, specify the following value for this field `7.*`
     *
     * Generated from protobuf field <code>string os_version = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setOsVersion($var)
    {
        GPBUtil::checkString($var, True);
        $this->os_version = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(OSFilter::class, \Google\Cloud\OsConfig\V1alpha\OSPolicy_OSFilter::class);

