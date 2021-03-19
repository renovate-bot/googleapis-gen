<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/study.proto

namespace Google\Cloud\Aiplatform\V1beta1\Study;

use UnexpectedValueException;

/**
 * Describes the Study state.
 *
 * Protobuf type <code>google.cloud.aiplatform.v1beta1.Study.State</code>
 */
class State
{
    /**
     * The study state is unspecified.
     *
     * Generated from protobuf enum <code>STATE_UNSPECIFIED = 0;</code>
     */
    const STATE_UNSPECIFIED = 0;
    /**
     * The study is active.
     *
     * Generated from protobuf enum <code>ACTIVE = 1;</code>
     */
    const ACTIVE = 1;
    /**
     * The study is stopped due to an internal error.
     *
     * Generated from protobuf enum <code>INACTIVE = 2;</code>
     */
    const INACTIVE = 2;
    /**
     * The study is done when the service exhausts the parameter search space
     * or max_trial_count is reached.
     *
     * Generated from protobuf enum <code>COMPLETED = 3;</code>
     */
    const COMPLETED = 3;

    private static $valueToName = [
        self::STATE_UNSPECIFIED => 'STATE_UNSPECIFIED',
        self::ACTIVE => 'ACTIVE',
        self::INACTIVE => 'INACTIVE',
        self::COMPLETED => 'COMPLETED',
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
class_alias(State::class, \Google\Cloud\Aiplatform\V1beta1\Study_State::class);

