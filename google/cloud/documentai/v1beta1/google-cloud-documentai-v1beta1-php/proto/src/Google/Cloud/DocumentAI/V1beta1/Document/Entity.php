<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta1/document.proto

namespace Google\Cloud\DocumentAI\V1beta1\Document;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A phrase in the text that is a known entity type, such as a person, an
 * organization, or location.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta1.Document.Entity</code>
 */
class Entity extends \Google\Protobuf\Internal\Message
{
    /**
     * Provenance of the entity.
     * Text anchor indexing into the
     * [Document.text][google.cloud.documentai.v1beta1.Document.text].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta1.Document.TextAnchor text_anchor = 1;</code>
     */
    protected $text_anchor = null;
    /**
     * Entity type from a schema e.g. `Address`.
     *
     * Generated from protobuf field <code>string type = 2;</code>
     */
    protected $type = '';
    /**
     * Text value in the document e.g. `1600 Amphitheatre Pkwy`.
     *
     * Generated from protobuf field <code>string mention_text = 3;</code>
     */
    protected $mention_text = '';
    /**
     * Canonical mention name. This will be a unique value in the entity list
     * for this document.
     *
     * Generated from protobuf field <code>string mention_id = 4;</code>
     */
    protected $mention_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DocumentAI\V1beta1\Document\TextAnchor $text_anchor
     *           Provenance of the entity.
     *           Text anchor indexing into the
     *           [Document.text][google.cloud.documentai.v1beta1.Document.text].
     *     @type string $type
     *           Entity type from a schema e.g. `Address`.
     *     @type string $mention_text
     *           Text value in the document e.g. `1600 Amphitheatre Pkwy`.
     *     @type string $mention_id
     *           Canonical mention name. This will be a unique value in the entity list
     *           for this document.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta1\Document::initOnce();
        parent::__construct($data);
    }

    /**
     * Provenance of the entity.
     * Text anchor indexing into the
     * [Document.text][google.cloud.documentai.v1beta1.Document.text].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta1.Document.TextAnchor text_anchor = 1;</code>
     * @return \Google\Cloud\DocumentAI\V1beta1\Document\TextAnchor|null
     */
    public function getTextAnchor()
    {
        return isset($this->text_anchor) ? $this->text_anchor : null;
    }

    public function hasTextAnchor()
    {
        return isset($this->text_anchor);
    }

    public function clearTextAnchor()
    {
        unset($this->text_anchor);
    }

    /**
     * Provenance of the entity.
     * Text anchor indexing into the
     * [Document.text][google.cloud.documentai.v1beta1.Document.text].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta1.Document.TextAnchor text_anchor = 1;</code>
     * @param \Google\Cloud\DocumentAI\V1beta1\Document\TextAnchor $var
     * @return $this
     */
    public function setTextAnchor($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta1\Document\TextAnchor::class);
        $this->text_anchor = $var;

        return $this;
    }

    /**
     * Entity type from a schema e.g. `Address`.
     *
     * Generated from protobuf field <code>string type = 2;</code>
     * @return string
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * Entity type from a schema e.g. `Address`.
     *
     * Generated from protobuf field <code>string type = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setType($var)
    {
        GPBUtil::checkString($var, True);
        $this->type = $var;

        return $this;
    }

    /**
     * Text value in the document e.g. `1600 Amphitheatre Pkwy`.
     *
     * Generated from protobuf field <code>string mention_text = 3;</code>
     * @return string
     */
    public function getMentionText()
    {
        return $this->mention_text;
    }

    /**
     * Text value in the document e.g. `1600 Amphitheatre Pkwy`.
     *
     * Generated from protobuf field <code>string mention_text = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setMentionText($var)
    {
        GPBUtil::checkString($var, True);
        $this->mention_text = $var;

        return $this;
    }

    /**
     * Canonical mention name. This will be a unique value in the entity list
     * for this document.
     *
     * Generated from protobuf field <code>string mention_id = 4;</code>
     * @return string
     */
    public function getMentionId()
    {
        return $this->mention_id;
    }

    /**
     * Canonical mention name. This will be a unique value in the entity list
     * for this document.
     *
     * Generated from protobuf field <code>string mention_id = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setMentionId($var)
    {
        GPBUtil::checkString($var, True);
        $this->mention_id = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Entity::class, \Google\Cloud\DocumentAI\V1beta1\Document_Entity::class);

