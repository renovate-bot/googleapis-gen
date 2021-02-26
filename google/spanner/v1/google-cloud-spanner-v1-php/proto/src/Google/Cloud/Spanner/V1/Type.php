<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/spanner/v1/type.proto

namespace Google\Cloud\Spanner\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * `Type` indicates the type of a Cloud Spanner value, as might be stored in a
 * table cell or returned from an SQL query.
 *
 * Generated from protobuf message <code>google.spanner.v1.Type</code>
 */
class Type extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The [TypeCode][google.spanner.v1.TypeCode] for this type.
     *
     * Generated from protobuf field <code>.google.spanner.v1.TypeCode code = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $code = 0;
    /**
     * If [code][google.spanner.v1.Type.code] == [ARRAY][google.spanner.v1.TypeCode.ARRAY], then `array_element_type`
     * is the type of the array elements.
     *
     * Generated from protobuf field <code>.google.spanner.v1.Type array_element_type = 2;</code>
     */
    protected $array_element_type = null;
    /**
     * If [code][google.spanner.v1.Type.code] == [STRUCT][google.spanner.v1.TypeCode.STRUCT], then `struct_type`
     * provides type information for the struct's fields.
     *
     * Generated from protobuf field <code>.google.spanner.v1.StructType struct_type = 3;</code>
     */
    protected $struct_type = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $code
     *           Required. The [TypeCode][google.spanner.v1.TypeCode] for this type.
     *     @type \Google\Cloud\Spanner\V1\Type $array_element_type
     *           If [code][google.spanner.v1.Type.code] == [ARRAY][google.spanner.v1.TypeCode.ARRAY], then `array_element_type`
     *           is the type of the array elements.
     *     @type \Google\Cloud\Spanner\V1\StructType $struct_type
     *           If [code][google.spanner.v1.Type.code] == [STRUCT][google.spanner.v1.TypeCode.STRUCT], then `struct_type`
     *           provides type information for the struct's fields.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Spanner\V1\Type::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The [TypeCode][google.spanner.v1.TypeCode] for this type.
     *
     * Generated from protobuf field <code>.google.spanner.v1.TypeCode code = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return int
     */
    public function getCode()
    {
        return $this->code;
    }

    /**
     * Required. The [TypeCode][google.spanner.v1.TypeCode] for this type.
     *
     * Generated from protobuf field <code>.google.spanner.v1.TypeCode code = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param int $var
     * @return $this
     */
    public function setCode($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Spanner\V1\TypeCode::class);
        $this->code = $var;

        return $this;
    }

    /**
     * If [code][google.spanner.v1.Type.code] == [ARRAY][google.spanner.v1.TypeCode.ARRAY], then `array_element_type`
     * is the type of the array elements.
     *
     * Generated from protobuf field <code>.google.spanner.v1.Type array_element_type = 2;</code>
     * @return \Google\Cloud\Spanner\V1\Type|null
     */
    public function getArrayElementType()
    {
        return isset($this->array_element_type) ? $this->array_element_type : null;
    }

    public function hasArrayElementType()
    {
        return isset($this->array_element_type);
    }

    public function clearArrayElementType()
    {
        unset($this->array_element_type);
    }

    /**
     * If [code][google.spanner.v1.Type.code] == [ARRAY][google.spanner.v1.TypeCode.ARRAY], then `array_element_type`
     * is the type of the array elements.
     *
     * Generated from protobuf field <code>.google.spanner.v1.Type array_element_type = 2;</code>
     * @param \Google\Cloud\Spanner\V1\Type $var
     * @return $this
     */
    public function setArrayElementType($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Spanner\V1\Type::class);
        $this->array_element_type = $var;

        return $this;
    }

    /**
     * If [code][google.spanner.v1.Type.code] == [STRUCT][google.spanner.v1.TypeCode.STRUCT], then `struct_type`
     * provides type information for the struct's fields.
     *
     * Generated from protobuf field <code>.google.spanner.v1.StructType struct_type = 3;</code>
     * @return \Google\Cloud\Spanner\V1\StructType|null
     */
    public function getStructType()
    {
        return isset($this->struct_type) ? $this->struct_type : null;
    }

    public function hasStructType()
    {
        return isset($this->struct_type);
    }

    public function clearStructType()
    {
        unset($this->struct_type);
    }

    /**
     * If [code][google.spanner.v1.Type.code] == [STRUCT][google.spanner.v1.TypeCode.STRUCT], then `struct_type`
     * provides type information for the struct's fields.
     *
     * Generated from protobuf field <code>.google.spanner.v1.StructType struct_type = 3;</code>
     * @param \Google\Cloud\Spanner\V1\StructType $var
     * @return $this
     */
    public function setStructType($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Spanner\V1\StructType::class);
        $this->struct_type = $var;

        return $this;
    }

}

