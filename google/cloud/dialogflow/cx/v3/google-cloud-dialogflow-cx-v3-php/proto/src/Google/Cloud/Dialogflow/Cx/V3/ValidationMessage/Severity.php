<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/validation_message.proto

namespace Google\Cloud\Dialogflow\Cx\V3\ValidationMessage;

use UnexpectedValueException;

/**
 * Severity level.
 *
 * Protobuf type <code>google.cloud.dialogflow.cx.v3.ValidationMessage.Severity</code>
 */
class Severity
{
    /**
     * Unspecified.
     *
     * Generated from protobuf enum <code>SEVERITY_UNSPECIFIED = 0;</code>
     */
    const SEVERITY_UNSPECIFIED = 0;
    /**
     * The agent doesn't follow Dialogflow best practices.
     *
     * Generated from protobuf enum <code>INFO = 1;</code>
     */
    const INFO = 1;
    /**
     * The agent may not behave as expected.
     *
     * Generated from protobuf enum <code>WARNING = 2;</code>
     */
    const WARNING = 2;
    /**
     * The agent may experience failures.
     *
     * Generated from protobuf enum <code>ERROR = 3;</code>
     */
    const ERROR = 3;

    private static $valueToName = [
        self::SEVERITY_UNSPECIFIED => 'SEVERITY_UNSPECIFIED',
        self::INFO => 'INFO',
        self::WARNING => 'WARNING',
        self::ERROR => 'ERROR',
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
class_alias(Severity::class, \Google\Cloud\Dialogflow\Cx\V3\ValidationMessage_Severity::class);
