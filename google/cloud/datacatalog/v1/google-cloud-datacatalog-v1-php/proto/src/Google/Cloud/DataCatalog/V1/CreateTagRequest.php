<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1/datacatalog.proto

namespace Google\Cloud\DataCatalog\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [CreateTag][google.cloud.datacatalog.v1.DataCatalog.CreateTag].
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1.CreateTagRequest</code>
 */
class CreateTagRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the resource to attach this tag to. Tags can be
     * attached to Entries. Example:
     * * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
     * Note that this Tag and its child resources may not actually be stored in
     * the location in this name.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The tag to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.Tag tag = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $tag = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the resource to attach this tag to. Tags can be
     *           attached to Entries. Example:
     *           * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
     *           Note that this Tag and its child resources may not actually be stored in
     *           the location in this name.
     *     @type \Google\Cloud\DataCatalog\V1\Tag $tag
     *           Required. The tag to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1\Datacatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the resource to attach this tag to. Tags can be
     * attached to Entries. Example:
     * * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
     * Note that this Tag and its child resources may not actually be stored in
     * the location in this name.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the resource to attach this tag to. Tags can be
     * attached to Entries. Example:
     * * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
     * Note that this Tag and its child resources may not actually be stored in
     * the location in this name.
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
     * Required. The tag to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.Tag tag = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\DataCatalog\V1\Tag|null
     */
    public function getTag()
    {
        return isset($this->tag) ? $this->tag : null;
    }

    public function hasTag()
    {
        return isset($this->tag);
    }

    public function clearTag()
    {
        unset($this->tag);
    }

    /**
     * Required. The tag to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.Tag tag = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\DataCatalog\V1\Tag $var
     * @return $this
     */
    public function setTag($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataCatalog\V1\Tag::class);
        $this->tag = $var;

        return $this;
    }

}

