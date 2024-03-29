<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document_processor_service.proto

namespace Google\Cloud\DocumentAI\V1beta3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for the process document method.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta3.ProcessRequest</code>
 */
class ProcessRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The processor resource name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * The document payload, the [content] and [mime_type] fields must be set.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document document = 2 [deprecated = true];</code>
     * @deprecated
     */
    protected $document = null;
    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 3;</code>
     */
    protected $skip_human_review = false;
    protected $source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DocumentAI\V1beta3\Document $inline_document
     *           An inline document proto.
     *     @type \Google\Cloud\DocumentAI\V1beta3\RawDocument $raw_document
     *           A raw document content (bytes).
     *     @type string $name
     *           Required. The processor resource name.
     *     @type \Google\Cloud\DocumentAI\V1beta3\Document $document
     *           The document payload, the [content] and [mime_type] fields must be set.
     *     @type bool $skip_human_review
     *           Whether Human Review feature should be skipped for this request. Default to
     *           false.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta3\DocumentProcessorService::initOnce();
        parent::__construct($data);
    }

    /**
     * An inline document proto.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document inline_document = 4;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\Document|null
     */
    public function getInlineDocument()
    {
        return $this->readOneof(4);
    }

    public function hasInlineDocument()
    {
        return $this->hasOneof(4);
    }

    /**
     * An inline document proto.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document inline_document = 4;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\Document $var
     * @return $this
     */
    public function setInlineDocument($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\Document::class);
        $this->writeOneof(4, $var);

        return $this;
    }

    /**
     * A raw document content (bytes).
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.RawDocument raw_document = 5;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\RawDocument|null
     */
    public function getRawDocument()
    {
        return $this->readOneof(5);
    }

    public function hasRawDocument()
    {
        return $this->hasOneof(5);
    }

    /**
     * A raw document content (bytes).
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.RawDocument raw_document = 5;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\RawDocument $var
     * @return $this
     */
    public function setRawDocument($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\RawDocument::class);
        $this->writeOneof(5, $var);

        return $this;
    }

    /**
     * Required. The processor resource name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The processor resource name.
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
     * The document payload, the [content] and [mime_type] fields must be set.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document document = 2 [deprecated = true];</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\Document|null
     * @deprecated
     */
    public function getDocument()
    {
        @trigger_error('document is deprecated.', E_USER_DEPRECATED);
        return $this->document;
    }

    public function hasDocument()
    {
        @trigger_error('document is deprecated.', E_USER_DEPRECATED);
        return isset($this->document);
    }

    public function clearDocument()
    {
        @trigger_error('document is deprecated.', E_USER_DEPRECATED);
        unset($this->document);
    }

    /**
     * The document payload, the [content] and [mime_type] fields must be set.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document document = 2 [deprecated = true];</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\Document $var
     * @return $this
     * @deprecated
     */
    public function setDocument($var)
    {
        @trigger_error('document is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\Document::class);
        $this->document = $var;

        return $this;
    }

    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 3;</code>
     * @return bool
     */
    public function getSkipHumanReview()
    {
        return $this->skip_human_review;
    }

    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setSkipHumanReview($var)
    {
        GPBUtil::checkBool($var);
        $this->skip_human_review = $var;

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

