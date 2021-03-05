<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/action.proto

namespace Google\Apps\Drive\Activity\V2\Comment\Assignment;

use UnexpectedValueException;

/**
 * More detailed information about the change.
 *
 * Protobuf type <code>google.apps.drive.activity.v2.Comment.Assignment.Subtype</code>
 */
class Subtype
{
    /**
     * Subtype not available.
     *
     * Generated from protobuf enum <code>SUBTYPE_UNSPECIFIED = 0;</code>
     */
    const SUBTYPE_UNSPECIFIED = 0;
    /**
     * An assignment was added.
     *
     * Generated from protobuf enum <code>ADDED = 1;</code>
     */
    const ADDED = 1;
    /**
     * An assignment was deleted.
     *
     * Generated from protobuf enum <code>DELETED = 2;</code>
     */
    const DELETED = 2;
    /**
     * An assignment reply was added.
     *
     * Generated from protobuf enum <code>REPLY_ADDED = 3;</code>
     */
    const REPLY_ADDED = 3;
    /**
     * An assignment reply was deleted.
     *
     * Generated from protobuf enum <code>REPLY_DELETED = 4;</code>
     */
    const REPLY_DELETED = 4;
    /**
     * An assignment was resolved.
     *
     * Generated from protobuf enum <code>RESOLVED = 5;</code>
     */
    const RESOLVED = 5;
    /**
     * A resolved assignment was reopened.
     *
     * Generated from protobuf enum <code>REOPENED = 6;</code>
     */
    const REOPENED = 6;
    /**
     * An assignment was reassigned.
     *
     * Generated from protobuf enum <code>REASSIGNED = 7;</code>
     */
    const REASSIGNED = 7;

    private static $valueToName = [
        self::SUBTYPE_UNSPECIFIED => 'SUBTYPE_UNSPECIFIED',
        self::ADDED => 'ADDED',
        self::DELETED => 'DELETED',
        self::REPLY_ADDED => 'REPLY_ADDED',
        self::REPLY_DELETED => 'REPLY_DELETED',
        self::RESOLVED => 'RESOLVED',
        self::REOPENED => 'REOPENED',
        self::REASSIGNED => 'REASSIGNED',
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
class_alias(Subtype::class, \Google\Apps\Drive\Activity\V2\Comment_Assignment_Subtype::class);

