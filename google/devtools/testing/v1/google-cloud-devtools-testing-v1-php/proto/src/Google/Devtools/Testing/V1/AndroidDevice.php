<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/testing/v1/test_execution.proto

namespace Google\Devtools\Testing\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A single Android device.
 *
 * Generated from protobuf message <code>google.devtools.testing.v1.AndroidDevice</code>
 */
class AndroidDevice extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The id of the Android device to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_model_id = 1;</code>
     */
    protected $android_model_id = '';
    /**
     * Required. The id of the Android OS version to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_version_id = 2;</code>
     */
    protected $android_version_id = '';
    /**
     * Required. The locale the test device used for testing.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string locale = 3;</code>
     */
    protected $locale = '';
    /**
     * Required. How the device is oriented during the test.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string orientation = 4;</code>
     */
    protected $orientation = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $android_model_id
     *           Required. The id of the Android device to be used.
     *           Use the TestEnvironmentDiscoveryService to get supported options.
     *     @type string $android_version_id
     *           Required. The id of the Android OS version to be used.
     *           Use the TestEnvironmentDiscoveryService to get supported options.
     *     @type string $locale
     *           Required. The locale the test device used for testing.
     *           Use the TestEnvironmentDiscoveryService to get supported options.
     *     @type string $orientation
     *           Required. How the device is oriented during the test.
     *           Use the TestEnvironmentDiscoveryService to get supported options.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Testing\V1\TestExecution::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The id of the Android device to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_model_id = 1;</code>
     * @return string
     */
    public function getAndroidModelId()
    {
        return $this->android_model_id;
    }

    /**
     * Required. The id of the Android device to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_model_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setAndroidModelId($var)
    {
        GPBUtil::checkString($var, True);
        $this->android_model_id = $var;

        return $this;
    }

    /**
     * Required. The id of the Android OS version to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_version_id = 2;</code>
     * @return string
     */
    public function getAndroidVersionId()
    {
        return $this->android_version_id;
    }

    /**
     * Required. The id of the Android OS version to be used.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string android_version_id = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setAndroidVersionId($var)
    {
        GPBUtil::checkString($var, True);
        $this->android_version_id = $var;

        return $this;
    }

    /**
     * Required. The locale the test device used for testing.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string locale = 3;</code>
     * @return string
     */
    public function getLocale()
    {
        return $this->locale;
    }

    /**
     * Required. The locale the test device used for testing.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string locale = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setLocale($var)
    {
        GPBUtil::checkString($var, True);
        $this->locale = $var;

        return $this;
    }

    /**
     * Required. How the device is oriented during the test.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string orientation = 4;</code>
     * @return string
     */
    public function getOrientation()
    {
        return $this->orientation;
    }

    /**
     * Required. How the device is oriented during the test.
     * Use the TestEnvironmentDiscoveryService to get supported options.
     *
     * Generated from protobuf field <code>string orientation = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setOrientation($var)
    {
        GPBUtil::checkString($var, True);
        $this->orientation = $var;

        return $this;
    }

}

