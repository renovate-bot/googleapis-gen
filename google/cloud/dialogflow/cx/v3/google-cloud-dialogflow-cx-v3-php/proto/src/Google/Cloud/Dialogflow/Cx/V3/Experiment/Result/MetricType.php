<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/experiment.proto

namespace Google\Cloud\Dialogflow\Cx\V3\Experiment\Result;

use UnexpectedValueException;

/**
 * Types of ratio-based metric for Dialogflow experiment.
 *
 * Protobuf type <code>google.cloud.dialogflow.cx.v3.Experiment.Result.MetricType</code>
 */
class MetricType
{
    /**
     * Metric unspecified.
     *
     * Generated from protobuf enum <code>METRIC_UNSPECIFIED = 0;</code>
     */
    const METRIC_UNSPECIFIED = 0;
    /**
     * Percentage of contained sessions without user calling back in 24 hours.
     *
     * Generated from protobuf enum <code>CONTAINED_SESSION_NO_CALLBACK_RATE = 1;</code>
     */
    const CONTAINED_SESSION_NO_CALLBACK_RATE = 1;
    /**
     * Percentage of sessions that were handed to a human agent.
     *
     * Generated from protobuf enum <code>LIVE_AGENT_HANDOFF_RATE = 2;</code>
     */
    const LIVE_AGENT_HANDOFF_RATE = 2;
    /**
     * Percentage of sessions with the same user calling back.
     *
     * Generated from protobuf enum <code>CALLBACK_SESSION_RATE = 3;</code>
     */
    const CALLBACK_SESSION_RATE = 3;
    /**
     * Percentage of sessions where user hung up.
     *
     * Generated from protobuf enum <code>ABANDONED_SESSION_RATE = 4;</code>
     */
    const ABANDONED_SESSION_RATE = 4;
    /**
     * Percentage of sessions reached Dialogflow 'END_PAGE' or
     * 'END_SESSION'.
     *
     * Generated from protobuf enum <code>SESSION_END_RATE = 5;</code>
     */
    const SESSION_END_RATE = 5;

    private static $valueToName = [
        self::METRIC_UNSPECIFIED => 'METRIC_UNSPECIFIED',
        self::CONTAINED_SESSION_NO_CALLBACK_RATE => 'CONTAINED_SESSION_NO_CALLBACK_RATE',
        self::LIVE_AGENT_HANDOFF_RATE => 'LIVE_AGENT_HANDOFF_RATE',
        self::CALLBACK_SESSION_RATE => 'CALLBACK_SESSION_RATE',
        self::ABANDONED_SESSION_RATE => 'ABANDONED_SESSION_RATE',
        self::SESSION_END_RATE => 'SESSION_END_RATE',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(MetricType::class, \Google\Cloud\Dialogflow\Cx\V3\Experiment_Result_MetricType::class);

