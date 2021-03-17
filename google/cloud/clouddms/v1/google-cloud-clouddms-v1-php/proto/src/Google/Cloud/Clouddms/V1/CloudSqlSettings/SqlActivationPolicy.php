<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/clouddms/v1/clouddms_resources.proto

namespace Google\Cloud\Clouddms\V1\CloudSqlSettings;

use UnexpectedValueException;

/**
 * Specifies when the instance should be activated.
 *
 * Protobuf type <code>google.cloud.clouddms.v1.CloudSqlSettings.SqlActivationPolicy</code>
 */
class SqlActivationPolicy
{
    /**
     * unspecified policy.
     *
     * Generated from protobuf enum <code>SQL_ACTIVATION_POLICY_UNSPECIFIED = 0;</code>
     */
    const SQL_ACTIVATION_POLICY_UNSPECIFIED = 0;
    /**
     * The instance is always up and running.
     *
     * Generated from protobuf enum <code>ALWAYS = 1;</code>
     */
    const ALWAYS = 1;
    /**
     * The instance should never spin up.
     *
     * Generated from protobuf enum <code>NEVER = 2;</code>
     */
    const NEVER = 2;

    private static $valueToName = [
        self::SQL_ACTIVATION_POLICY_UNSPECIFIED => 'SQL_ACTIVATION_POLICY_UNSPECIFIED',
        self::ALWAYS => 'ALWAYS',
        self::NEVER => 'NEVER',
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
class_alias(SqlActivationPolicy::class, \Google\Cloud\Clouddms\V1\CloudSqlSettings_SqlActivationPolicy::class);

