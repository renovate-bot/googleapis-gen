<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/api/servicecontrol/v1/service_controller.proto

namespace Google\Cloud\ServiceControl\V1\CheckResponse;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Contains additional information about the check operation.
 *
 * Generated from protobuf message <code>google.api.servicecontrol.v1.CheckResponse.CheckInfo</code>
 */
class CheckInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * A list of fields and label keys that are ignored by the server.
     * The client doesn't need to send them for following requests to improve
     * performance and allow better aggregation.
     *
     * Generated from protobuf field <code>repeated string unused_arguments = 1;</code>
     */
    private $unused_arguments;
    /**
     * Consumer info of this check.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.CheckResponse.ConsumerInfo consumer_info = 2;</code>
     */
    protected $consumer_info = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $unused_arguments
     *           A list of fields and label keys that are ignored by the server.
     *           The client doesn't need to send them for following requests to improve
     *           performance and allow better aggregation.
     *     @type \Google\Cloud\ServiceControl\V1\CheckResponse\ConsumerInfo $consumer_info
     *           Consumer info of this check.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Api\Servicecontrol\V1\ServiceController::initOnce();
        parent::__construct($data);
    }

    /**
     * A list of fields and label keys that are ignored by the server.
     * The client doesn't need to send them for following requests to improve
     * performance and allow better aggregation.
     *
     * Generated from protobuf field <code>repeated string unused_arguments = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getUnusedArguments()
    {
        return $this->unused_arguments;
    }

    /**
     * A list of fields and label keys that are ignored by the server.
     * The client doesn't need to send them for following requests to improve
     * performance and allow better aggregation.
     *
     * Generated from protobuf field <code>repeated string unused_arguments = 1;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setUnusedArguments($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->unused_arguments = $arr;

        return $this;
    }

    /**
     * Consumer info of this check.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.CheckResponse.ConsumerInfo consumer_info = 2;</code>
     * @return \Google\Cloud\ServiceControl\V1\CheckResponse\ConsumerInfo|null
     */
    public function getConsumerInfo()
    {
        return isset($this->consumer_info) ? $this->consumer_info : null;
    }

    public function hasConsumerInfo()
    {
        return isset($this->consumer_info);
    }

    public function clearConsumerInfo()
    {
        unset($this->consumer_info);
    }

    /**
     * Consumer info of this check.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.CheckResponse.ConsumerInfo consumer_info = 2;</code>
     * @param \Google\Cloud\ServiceControl\V1\CheckResponse\ConsumerInfo $var
     * @return $this
     */
    public function setConsumerInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ServiceControl\V1\CheckResponse\ConsumerInfo::class);
        $this->consumer_info = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(CheckInfo::class, \Google\Cloud\ServiceControl\V1\CheckResponse_CheckInfo::class);

