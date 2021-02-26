<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1beta1/datacatalog.proto

namespace Google\Cloud\DataCatalog\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [GetEntryGroup][google.cloud.datacatalog.v1beta1.DataCatalog.GetEntryGroup].
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1beta1.GetEntryGroupRequest</code>
 */
class GetEntryGroupRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the entry group. For example,
     * `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * The fields to return. If not set or empty, all fields are returned.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     */
    protected $read_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the entry group. For example,
     *           `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
     *     @type \Google\Protobuf\FieldMask $read_mask
     *           The fields to return. If not set or empty, all fields are returned.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1Beta1\Datacatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the entry group. For example,
     * `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the entry group. For example,
     * `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * The fields to return. If not set or empty, all fields are returned.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getReadMask()
    {
        return isset($this->read_mask) ? $this->read_mask : null;
    }

    public function hasReadMask()
    {
        return isset($this->read_mask);
    }

    public function clearReadMask()
    {
        unset($this->read_mask);
    }

    /**
     * The fields to return. If not set or empty, all fields are returned.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask read_mask = 2;</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setReadMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->read_mask = $var;

        return $this;
    }

}

