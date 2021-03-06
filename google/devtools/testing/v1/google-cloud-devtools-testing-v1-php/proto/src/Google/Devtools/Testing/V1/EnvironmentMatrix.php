<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/testing/v1/test_execution.proto

namespace Google\Devtools\Testing\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The matrix of environments in which the test is to be executed.
 *
 * Generated from protobuf message <code>google.devtools.testing.v1.EnvironmentMatrix</code>
 */
class EnvironmentMatrix extends \Google\Protobuf\Internal\Message
{
    protected $environment_matrix;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Devtools\Testing\V1\AndroidMatrix $android_matrix
     *           A matrix of Android devices.
     *     @type \Google\Devtools\Testing\V1\AndroidDeviceList $android_device_list
     *           A list of Android devices; the test will be run only on the specified
     *           devices.
     *     @type \Google\Devtools\Testing\V1\IosDeviceList $ios_device_list
     *           A list of iOS devices.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Testing\V1\TestExecution::initOnce();
        parent::__construct($data);
    }

    /**
     * A matrix of Android devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.AndroidMatrix android_matrix = 1;</code>
     * @return \Google\Devtools\Testing\V1\AndroidMatrix|null
     */
    public function getAndroidMatrix()
    {
        return $this->readOneof(1);
    }

    public function hasAndroidMatrix()
    {
        return $this->hasOneof(1);
    }

    /**
     * A matrix of Android devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.AndroidMatrix android_matrix = 1;</code>
     * @param \Google\Devtools\Testing\V1\AndroidMatrix $var
     * @return $this
     */
    public function setAndroidMatrix($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Testing\V1\AndroidMatrix::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * A list of Android devices; the test will be run only on the specified
     * devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.AndroidDeviceList android_device_list = 2;</code>
     * @return \Google\Devtools\Testing\V1\AndroidDeviceList|null
     */
    public function getAndroidDeviceList()
    {
        return $this->readOneof(2);
    }

    public function hasAndroidDeviceList()
    {
        return $this->hasOneof(2);
    }

    /**
     * A list of Android devices; the test will be run only on the specified
     * devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.AndroidDeviceList android_device_list = 2;</code>
     * @param \Google\Devtools\Testing\V1\AndroidDeviceList $var
     * @return $this
     */
    public function setAndroidDeviceList($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Testing\V1\AndroidDeviceList::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * A list of iOS devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.IosDeviceList ios_device_list = 3;</code>
     * @return \Google\Devtools\Testing\V1\IosDeviceList|null
     */
    public function getIosDeviceList()
    {
        return $this->readOneof(3);
    }

    public function hasIosDeviceList()
    {
        return $this->hasOneof(3);
    }

    /**
     * A list of iOS devices.
     *
     * Generated from protobuf field <code>.google.devtools.testing.v1.IosDeviceList ios_device_list = 3;</code>
     * @param \Google\Devtools\Testing\V1\IosDeviceList $var
     * @return $this
     */
    public function setIosDeviceList($var)
    {
        GPBUtil::checkMessage($var, \Google\Devtools\Testing\V1\IosDeviceList::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getEnvironmentMatrix()
    {
        return $this->whichOneof("environment_matrix");
    }

}

