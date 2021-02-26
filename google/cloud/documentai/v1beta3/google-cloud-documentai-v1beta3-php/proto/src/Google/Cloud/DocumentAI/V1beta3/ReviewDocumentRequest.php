<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document_processor_service.proto

namespace Google\Cloud\DocumentAI\V1beta3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for review document method.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta3.ReviewDocumentRequest</code>
 */
class ReviewDocumentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the HumanReviewConfig that the document will be
     * reviewed with.
     *
     * Generated from protobuf field <code>string human_review_config = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $human_review_config = '';
    /**
     * The document that needs human review.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document document = 2 [deprecated = true];</code>
     * @deprecated
     */
    protected $document = null;
    protected $source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DocumentAI\V1beta3\Document $inline_document
     *           An inline document proto.
     *     @type string $human_review_config
     *           Required. The resource name of the HumanReviewConfig that the document will be
     *           reviewed with.
     *     @type \Google\Cloud\DocumentAI\V1beta3\Document $document
     *           The document that needs human review.
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
     * Required. The resource name of the HumanReviewConfig that the document will be
     * reviewed with.
     *
     * Generated from protobuf field <code>string human_review_config = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getHumanReviewConfig()
    {
        return $this->human_review_config;
    }

    /**
     * Required. The resource name of the HumanReviewConfig that the document will be
     * reviewed with.
     *
     * Generated from protobuf field <code>string human_review_config = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setHumanReviewConfig($var)
    {
        GPBUtil::checkString($var, True);
        $this->human_review_config = $var;

        return $this;
    }

    /**
     * The document that needs human review.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.Document document = 2 [deprecated = true];</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\Document|null
     * @deprecated
     */
    public function getDocument()
    {
        @trigger_error('document is deprecated.', E_USER_DEPRECATED);
        return isset($this->document) ? $this->document : null;
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
     * The document that needs human review.
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
     * @return string
     */
    public function getSource()
    {
        return $this->whichOneof("source");
    }

}

