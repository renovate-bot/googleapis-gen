<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document.proto

namespace Google\Cloud\DocumentAI\V1beta3\Document\Provenance;

use UnexpectedValueException;

/**
 * If a processor or agent does an explicit operation on existing elements.
 *
 * Protobuf type <code>google.cloud.documentai.v1beta3.Document.Provenance.OperationType</code>
 */
class OperationType
{
    /**
     * Operation type unspecified.
     *
     * Generated from protobuf enum <code>OPERATION_TYPE_UNSPECIFIED = 0;</code>
     */
    const OPERATION_TYPE_UNSPECIFIED = 0;
    /**
     * Add an element.  Implicit if no `parents` are set for the provenance.
     *
     * Generated from protobuf enum <code>ADD = 1;</code>
     */
    const ADD = 1;
    /**
     * The element is removed.  No `parents` should be set.
     *
     * Generated from protobuf enum <code>REMOVE = 2;</code>
     */
    const REMOVE = 2;
    /**
     * Explicitly replaces the element(s) identified by `parents`.
     *
     * Generated from protobuf enum <code>REPLACE = 3;</code>
     */
    const REPLACE = 3;
    /**
     * Element is requested for human review.
     *
     * Generated from protobuf enum <code>EVAL_REQUESTED = 4;</code>
     */
    const EVAL_REQUESTED = 4;
    /**
     * Element is reviewed and approved at human review, confidence will be
     * set to 1.0.
     *
     * Generated from protobuf enum <code>EVAL_APPROVED = 5;</code>
     */
    const EVAL_APPROVED = 5;
    /**
     * Element is skipped in the validation process.
     *
     * Generated from protobuf enum <code>EVAL_SKIPPED = 6;</code>
     */
    const EVAL_SKIPPED = 6;

    private static $valueToName = [
        self::OPERATION_TYPE_UNSPECIFIED => 'OPERATION_TYPE_UNSPECIFIED',
        self::ADD => 'ADD',
        self::REMOVE => 'REMOVE',
        self::REPLACE => 'REPLACE',
        self::EVAL_REQUESTED => 'EVAL_REQUESTED',
        self::EVAL_APPROVED => 'EVAL_APPROVED',
        self::EVAL_SKIPPED => 'EVAL_SKIPPED',
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
class_alias(OperationType::class, \Google\Cloud\DocumentAI\V1beta3\Document_Provenance_OperationType::class);

