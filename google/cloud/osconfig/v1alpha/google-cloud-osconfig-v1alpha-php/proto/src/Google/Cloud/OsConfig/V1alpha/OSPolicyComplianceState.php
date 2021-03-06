<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/v1alpha/config_common.proto

namespace Google\Cloud\OsConfig\V1alpha;

use UnexpectedValueException;

/**
 * Supported OSPolicy compliance states.
 *
 * Protobuf type <code>google.cloud.osconfig.v1alpha.OSPolicyComplianceState</code>
 */
class OSPolicyComplianceState
{
    /**
     * Default value. This value is unused.
     *
     * Generated from protobuf enum <code>OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED = 0;</code>
     */
    const OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED = 0;
    /**
     * Compliant state.
     *
     * Generated from protobuf enum <code>COMPLIANT = 1;</code>
     */
    const COMPLIANT = 1;
    /**
     * Non-compliant state
     *
     * Generated from protobuf enum <code>NON_COMPLIANT = 2;</code>
     */
    const NON_COMPLIANT = 2;
    /**
     * Unknown compliance state.
     *
     * Generated from protobuf enum <code>UNKNOWN = 3;</code>
     */
    const UNKNOWN = 3;
    /**
     * No applicable OS policies were found for the instance.
     * This state is only applicable to the instance.
     *
     * Generated from protobuf enum <code>NO_OS_POLICIES_APPLICABLE = 4;</code>
     */
    const NO_OS_POLICIES_APPLICABLE = 4;

    private static $valueToName = [
        self::OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED => 'OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED',
        self::COMPLIANT => 'COMPLIANT',
        self::NON_COMPLIANT => 'NON_COMPLIANT',
        self::UNKNOWN => 'UNKNOWN',
        self::NO_OS_POLICIES_APPLICABLE => 'NO_OS_POLICIES_APPLICABLE',
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

