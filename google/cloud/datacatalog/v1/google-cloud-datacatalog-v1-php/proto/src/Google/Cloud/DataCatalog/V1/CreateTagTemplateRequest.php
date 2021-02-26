<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1/datacatalog.proto

namespace Google\Cloud\DataCatalog\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for
 * [CreateTagTemplate][google.cloud.datacatalog.v1.DataCatalog.CreateTagTemplate].
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1.CreateTagTemplateRequest</code>
 */
class CreateTagTemplateRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the project and the template location
     * [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
     * Example:
     * * projects/{project_id}/locations/us-central1
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The id of the tag template to create.
     *
     * Generated from protobuf field <code>string tag_template_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $tag_template_id = '';
    /**
     * Required. The tag template to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.TagTemplate tag_template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $tag_template = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The name of the project and the template location
     *           [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
     *           Example:
     *           * projects/{project_id}/locations/us-central1
     *     @type string $tag_template_id
     *           Required. The id of the tag template to create.
     *     @type \Google\Cloud\DataCatalog\V1\TagTemplate $tag_template
     *           Required. The tag template to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1\Datacatalog::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the project and the template location
     * [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
     * Example:
     * * projects/{project_id}/locations/us-central1
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The name of the project and the template location
     * [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
     * Example:
     * * projects/{project_id}/locations/us-central1
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
     * Required. The id of the tag template to create.
     *
     * Generated from protobuf field <code>string tag_template_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getTagTemplateId()
    {
        return $this->tag_template_id;
    }

    /**
     * Required. The id of the tag template to create.
     *
     * Generated from protobuf field <code>string tag_template_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setTagTemplateId($var)
    {
        GPBUtil::checkString($var, True);
        $this->tag_template_id = $var;

        return $this;
    }

    /**
     * Required. The tag template to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.TagTemplate tag_template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\DataCatalog\V1\TagTemplate|null
     */
    public function getTagTemplate()
    {
        return isset($this->tag_template) ? $this->tag_template : null;
    }

    public function hasTagTemplate()
    {
        return isset($this->tag_template);
    }

    public function clearTagTemplate()
    {
        unset($this->tag_template);
    }

    /**
     * Required. The tag template to create.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.TagTemplate tag_template = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\DataCatalog\V1\TagTemplate $var
     * @return $this
     */
    public function setTagTemplate($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataCatalog\V1\TagTemplate::class);
        $this->tag_template = $var;

        return $this;
    }

}

