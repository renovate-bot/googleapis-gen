<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/home/graph/v1/homegraph.proto

namespace Google\Home\Graph\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Payload containing the state and notification information for devices.
 *
 * Generated from protobuf message <code>google.home.graph.v1.StateAndNotificationPayload</code>
 */
class StateAndNotificationPayload extends \Google\Protobuf\Internal\Message
{
    /**
     * The devices for updating state and sending notifications.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.ReportStateAndNotificationDevice devices = 1;</code>
     */
    protected $devices = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Home\Graph\V1\ReportStateAndNotificationDevice $devices
     *           The devices for updating state and sending notifications.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Home\Graph\V1\Homegraph::initOnce();
        parent::__construct($data);
    }

    /**
     * The devices for updating state and sending notifications.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.ReportStateAndNotificationDevice devices = 1;</code>
     * @return \Google\Home\Graph\V1\ReportStateAndNotificationDevice|null
     */
    public function getDevices()
    {
        return $this->devices;
    }

    public function hasDevices()
    {
        return isset($this->devices);
    }

    public function clearDevices()
    {
        unset($this->devices);
    }

    /**
     * The devices for updating state and sending notifications.
     *
     * Generated from protobuf field <code>.google.home.graph.v1.ReportStateAndNotificationDevice devices = 1;</code>
     * @param \Google\Home\Graph\V1\ReportStateAndNotificationDevice $var
     * @return $this
     */
    public function setDevices($var)
    {
        GPBUtil::checkMessage($var, \Google\Home\Graph\V1\ReportStateAndNotificationDevice::class);
        $this->devices = $var;

        return $this;
    }

}

