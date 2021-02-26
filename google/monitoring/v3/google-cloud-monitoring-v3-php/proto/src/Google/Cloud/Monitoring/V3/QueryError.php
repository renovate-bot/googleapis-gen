<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/metric.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An error associated with a query in the time series query language format.
 *
 * Generated from protobuf message <code>google.monitoring.v3.QueryError</code>
 */
class QueryError extends \Google\Protobuf\Internal\Message
{
    /**
     * The location of the time series query language text that this error applies
     * to.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.TextLocator locator = 1;</code>
     */
    protected $locator = null;
    /**
     * The error message.
     *
     * Generated from protobuf field <code>string message = 2;</code>
     */
    protected $message = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Monitoring\V3\TextLocator $locator
     *           The location of the time series query language text that this error applies
     *           to.
     *     @type string $message
     *           The error message.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\Metric::initOnce();
        parent::__construct($data);
    }

    /**
     * The location of the time series query language text that this error applies
     * to.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.TextLocator locator = 1;</code>
     * @return \Google\Cloud\Monitoring\V3\TextLocator|null
     */
    public function getLocator()
    {
        return isset($this->locator) ? $this->locator : null;
    }

    public function hasLocator()
    {
        return isset($this->locator);
    }

    public function clearLocator()
    {
        unset($this->locator);
    }

    /**
     * The location of the time series query language text that this error applies
     * to.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.TextLocator locator = 1;</code>
     * @param \Google\Cloud\Monitoring\V3\TextLocator $var
     * @return $this
     */
    public function setLocator($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\TextLocator::class);
        $this->locator = $var;

        return $this;
    }

    /**
     * The error message.
     *
     * Generated from protobuf field <code>string message = 2;</code>
     * @return string
     */
    public function getMessage()
    {
        return $this->message;
    }

    /**
     * The error message.
     *
     * Generated from protobuf field <code>string message = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setMessage($var)
    {
        GPBUtil::checkString($var, True);
        $this->message = $var;

        return $this;
    }

}

