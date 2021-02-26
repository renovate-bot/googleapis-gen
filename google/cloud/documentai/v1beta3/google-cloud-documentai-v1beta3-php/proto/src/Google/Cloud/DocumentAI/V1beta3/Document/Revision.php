<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document.proto

namespace Google\Cloud\DocumentAI\V1beta3\Document;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Contains past or forward revisions of this document.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta3.Document.Revision</code>
 */
class Revision extends \Google\Protobuf\Internal\Message
{
    /**
     * Id of the revision.  Unique within the context of the document.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     */
    protected $id = '';
    /**
     * The revisions that this revision is based on.  This can include one or
     * more parent (when documents are merged.)  This field represents the
     * index into the `revisions` field.
     *
     * Generated from protobuf field <code>repeated int32 parent = 2;</code>
     */
    private $parent;
    /**
     * The time that the revision was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     */
    protected $create_time = null;
    /**
     * Human Review information of this revision.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document.Revision.HumanReview human_review = 6;</code>
     */
    protected $human_review = null;
    protected $source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $agent
     *           If the change was made by a person specify the name or id of that
     *           person.
     *     @type string $processor
     *           If the annotation was made by processor identify the processor by its
     *           resource name.
     *     @type string $id
     *           Id of the revision.  Unique within the context of the document.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $parent
     *           The revisions that this revision is based on.  This can include one or
     *           more parent (when documents are merged.)  This field represents the
     *           index into the `revisions` field.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           The time that the revision was created.
     *     @type \Google\Cloud\DocumentAI\V1beta3\Document\Revision\HumanReview $human_review
     *           Human Review information of this revision.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta3\Document::initOnce();
        parent::__construct($data);
    }

    /**
     * If the change was made by a person specify the name or id of that
     * person.
     *
     * Generated from protobuf field <code>string agent = 4;</code>
     * @return string
     */
    public function getAgent()
    {
        return $this->readOneof(4);
    }

    public function hasAgent()
    {
        return $this->hasOneof(4);
    }

    /**
     * If the change was made by a person specify the name or id of that
     * person.
     *
     * Generated from protobuf field <code>string agent = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setAgent($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(4, $var);

        return $this;
    }

    /**
     * If the annotation was made by processor identify the processor by its
     * resource name.
     *
     * Generated from protobuf field <code>string processor = 5;</code>
     * @return string
     */
    public function getProcessor()
    {
        return $this->readOneof(5);
    }

    public function hasProcessor()
    {
        return $this->hasOneof(5);
    }

    /**
     * If the annotation was made by processor identify the processor by its
     * resource name.
     *
     * Generated from protobuf field <code>string processor = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setProcessor($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Id of the revision.  Unique within the context of the document.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Id of the revision.  Unique within the context of the document.
     *
     * Generated from protobuf field <code>string id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     * The revisions that this revision is based on.  This can include one or
     * more parent (when documents are merged.)  This field represents the
     * index into the `revisions` field.
     *
     * Generated from protobuf field <code>repeated int32 parent = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * The revisions that this revision is based on.  This can include one or
     * more parent (when documents are merged.)  This field represents the
     * index into the `revisions` field.
     *
     * Generated from protobuf field <code>repeated int32 parent = 2;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setParent($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::INT32);
        $this->parent = $arr;

        return $this;
    }

    /**
     * The time that the revision was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return isset($this->create_time) ? $this->create_time : null;
    }

    public function hasCreateTime()
    {
        return isset($this->create_time);
    }

    public function clearCreateTime()
    {
        unset($this->create_time);
    }

    /**
     * The time that the revision was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->create_time = $var;

        return $this;
    }

    /**
     * Human Review information of this revision.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document.Revision.HumanReview human_review = 6;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\Document\Revision\HumanReview|null
     */
    public function getHumanReview()
    {
        return isset($this->human_review) ? $this->human_review : null;
    }

    public function hasHumanReview()
    {
        return isset($this->human_review);
    }

    public function clearHumanReview()
    {
        unset($this->human_review);
    }

    /**
     * Human Review information of this revision.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document.Revision.HumanReview human_review = 6;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\Document\Revision\HumanReview $var
     * @return $this
     */
    public function setHumanReview($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\Document\Revision\HumanReview::class);
        $this->human_review = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getSource()
    {
        return $this->whichOneof("source");
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Revision::class, \Google\Cloud\DocumentAI\V1beta3\Document_Revision::class);

