<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta2/document.proto

namespace Google\Cloud\DocumentAI\V1beta2\Document\Page;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A collection of tokens that a human would perceive as a line.
 * Does not cross column boundaries, can be horizontal, vertical, etc.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta2.Document.Page.Line</code>
 */
class Line extends \Google\Protobuf\Internal\Message
{
    /**
     * [Layout][google.cloud.documentai.v1beta2.Document.Page.Layout] for [Line][google.cloud.documentai.v1beta2.Document.Page.Line].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta2.Document.Page.Layout layout = 1;</code>
     */
    protected $layout = null;
    /**
     * A list of detected languages together with confidence.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta2.Document.Page.DetectedLanguage detected_languages = 2;</code>
     */
    private $detected_languages;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DocumentAI\V1beta2\Document\Page\Layout $layout
     *           [Layout][google.cloud.documentai.v1beta2.Document.Page.Layout] for [Line][google.cloud.documentai.v1beta2.Document.Page.Line].
     *     @type \Google\Cloud\DocumentAI\V1beta2\Document\Page\DetectedLanguage[]|\Google\Protobuf\Internal\RepeatedField $detected_languages
     *           A list of detected languages together with confidence.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta2\Document::initOnce();
        parent::__construct($data);
    }

    /**
     * [Layout][google.cloud.documentai.v1beta2.Document.Page.Layout] for [Line][google.cloud.documentai.v1beta2.Document.Page.Line].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta2.Document.Page.Layout layout = 1;</code>
     * @return \Google\Cloud\DocumentAI\V1beta2\Document\Page\Layout|null
     */
    public function getLayout()
    {
        return isset($this->layout) ? $this->layout : null;
    }

    public function hasLayout()
    {
        return isset($this->layout);
    }

    public function clearLayout()
    {
        unset($this->layout);
    }

    /**
     * [Layout][google.cloud.documentai.v1beta2.Document.Page.Layout] for [Line][google.cloud.documentai.v1beta2.Document.Page.Line].
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta2.Document.Page.Layout layout = 1;</code>
     * @param \Google\Cloud\DocumentAI\V1beta2\Document\Page\Layout $var
     * @return $this
     */
    public function setLayout($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta2\Document\Page\Layout::class);
        $this->layout = $var;

        return $this;
    }

    /**
     * A list of detected languages together with confidence.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta2.Document.Page.DetectedLanguage detected_languages = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getDetectedLanguages()
    {
        return $this->detected_languages;
    }

    /**
     * A list of detected languages together with confidence.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta2.Document.Page.DetectedLanguage detected_languages = 2;</code>
     * @param \Google\Cloud\DocumentAI\V1beta2\Document\Page\DetectedLanguage[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setDetectedLanguages($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\DocumentAI\V1beta2\Document\Page\DetectedLanguage::class);
        $this->detected_languages = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Line::class, \Google\Cloud\DocumentAI\V1beta2\Document_Page_Line::class);

