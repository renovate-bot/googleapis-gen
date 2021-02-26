<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1beta1/datacatalog.proto

namespace Google\Cloud\DataCatalog\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [CreateEntryGroup][google.cloud.datacatalog.v1beta1.DataCatalog.CreateEntryGroup].
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1beta1.CreateEntryGroupRequest</code>
 */
class CreateEntryGroupRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the project this entry group is in. Example:
     * * projects/{project_id}/locations/{location}
     * Note that this EntryGroup and its child resources may not actually be
     * stored in the location in this name.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The id of the entry group to create.
     * The id must begin with a letter or underscore, contain only English
     * letters, numbers and underscores, and be at most 64 characters.
     *
     * Generated from protobuf field <code>string entry_group_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $entry_group_id = '';
    /**
     * The entry group to create. Defaults to an empty entry group.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.EntryGroup entry_group = 2;</code>
     */
    protected $entry_group = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the project this entry group is in. Example:
     *           * projects/{project_id}/locations/{location}
     *           Note that this EntryGroup and its child resources may not actually be
     *           stored in the location in this name.
     *     @type string $entry_group_id
     *           Required. The id of the entry group to create.
     *           The id must begin with a letter or underscore, contain only English
     *           letters, numbers and underscores, and be at most 64 characters.
     *     @type \Google\Cloud\DataCatalog\V1beta1\EntryGroup $entry_group
     *           The entry group to create. Defaults to an empty entry group.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1Beta1\Datacatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the project this entry group is in. Example:
     * * projects/{project_id}/locations/{location}
     * Note that this EntryGroup and its child resources may not actually be
     * stored in the location in this name.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the project this entry group is in. Example:
     * * projects/{project_id}/locations/{location}
     * Note that this EntryGroup and its child resources may not actually be
     * stored in the location in this name.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. The id of the entry group to create.
     * The id must begin with a letter or underscore, contain only English
     * letters, numbers and underscores, and be at most 64 characters.
     *
     * Generated from protobuf field <code>string entry_group_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getEntryGroupId()
    {
        return $this->entry_group_id;
    }

    /**
     * Required. The id of the entry group to create.
     * The id must begin with a letter or underscore, contain only English
     * letters, numbers and underscores, and be at most 64 characters.
     *
     * Generated from protobuf field <code>string entry_group_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setEntryGroupId($var)
    {
        GPBUtil::checkString($var, True);
        $this->entry_group_id = $var;

        return $this;
    }

    /**
     * The entry group to create. Defaults to an empty entry group.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.EntryGroup entry_group = 2;</code>
     * @return \Google\Cloud\DataCatalog\V1beta1\EntryGroup|null
     */
    public function getEntryGroup()
    {
        return isset($this->entry_group) ? $this->entry_group : null;
    }

    public function hasEntryGroup()
    {
        return isset($this->entry_group);
    }

    public function clearEntryGroup()
    {
        unset($this->entry_group);
    }

    /**
     * The entry group to create. Defaults to an empty entry group.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1beta1.EntryGroup entry_group = 2;</code>
     * @param \Google\Cloud\DataCatalog\V1beta1\EntryGroup $var
     * @return $this
     */
    public function setEntryGroup($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataCatalog\V1beta1\EntryGroup::class);
        $this->entry_group = $var;

        return $this;
    }

}

