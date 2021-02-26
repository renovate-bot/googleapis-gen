<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/shell/v1/cloudshell.proto

namespace Google\Cloud\Shell\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Message included in the response field of operations returned from
 * [StartEnvironment][google.cloud.shell.v1.CloudShellService.StartEnvironment]
 * once the operation is complete.
 *
 * Generated from protobuf message <code>google.cloud.shell.v1.StartEnvironmentResponse</code>
 */
class StartEnvironmentResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Environment that was started.
     *
     * Generated from protobuf field <code>.google.cloud.shell.v1.Environment environment = 1;</code>
     */
    protected $environment = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Shell\V1\Environment $environment
     *           Environment that was started.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Shell\V1\Cloudshell::initOnce();
        parent::__construct($data);
    }

    /**
     * Environment that was started.
     *
     * Generated from protobuf field <code>.google.cloud.shell.v1.Environment environment = 1;</code>
     * @return \Google\Cloud\Shell\V1\Environment|null
     */
    public function getEnvironment()
    {
        return isset($this->environment) ? $this->environment : null;
    }

    public function hasEnvironment()
    {
        return isset($this->environment);
    }

    public function clearEnvironment()
    {
        unset($this->environment);
    }

    /**
     * Environment that was started.
     *
     * Generated from protobuf field <code>.google.cloud.shell.v1.Environment environment = 1;</code>
     * @param \Google\Cloud\Shell\V1\Environment $var
     * @return $this
     */
    public function setEnvironment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Shell\V1\Environment::class);
        $this->environment = $var;

        return $this;
    }

}

