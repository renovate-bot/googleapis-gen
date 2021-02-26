<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1/text_annotation.proto

namespace Google\Cloud\Vision\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Detected page from OCR.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1.Page</code>
 */
class Page extends \Google\Protobuf\Internal\Message
{
    /**
     * Additional information detected on the page.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.TextAnnotation.TextProperty property = 1;</code>
     */
    protected $property = null;
    /**
     * Page width. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 width = 2;</code>
     */
    protected $width = 0;
    /**
     * Page height. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 height = 3;</code>
     */
    protected $height = 0;
    /**
     * List of blocks of text, images etc on this page.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1.Block blocks = 4;</code>
     */
    private $blocks;
    /**
     * Confidence of the OCR results on the page. Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 5;</code>
     */
    protected $confidence = 0.0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Vision\V1\TextAnnotation\TextProperty $property
     *           Additional information detected on the page.
     *     @type int $width
     *           Page width. For PDFs the unit is points. For images (including
     *           TIFFs) the unit is pixels.
     *     @type int $height
     *           Page height. For PDFs the unit is points. For images (including
     *           TIFFs) the unit is pixels.
     *     @type \Google\Cloud\Vision\V1\Block[]|\Google\Protobuf\Internal\RepeatedField $blocks
     *           List of blocks of text, images etc on this page.
     *     @type float $confidence
     *           Confidence of the OCR results on the page. Range [0, 1].
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1\TextAnnotation::initOnce();
        parent::__construct($data);
    }

    /**
     * Additional information detected on the page.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.TextAnnotation.TextProperty property = 1;</code>
     * @return \Google\Cloud\Vision\V1\TextAnnotation\TextProperty|null
     */
    public function getProperty()
    {
        return isset($this->property) ? $this->property : null;
    }

    public function hasProperty()
    {
        return isset($this->property);
    }

    public function clearProperty()
    {
        unset($this->property);
    }

    /**
     * Additional information detected on the page.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.TextAnnotation.TextProperty property = 1;</code>
     * @param \Google\Cloud\Vision\V1\TextAnnotation\TextProperty $var
     * @return $this
     */
    public function setProperty($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1\TextAnnotation\TextProperty::class);
        $this->property = $var;

        return $this;
    }

    /**
     * Page width. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 width = 2;</code>
     * @return int
     */
    public function getWidth()
    {
        return $this->width;
    }

    /**
     * Page width. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 width = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setWidth($var)
    {
        GPBUtil::checkInt32($var);
        $this->width = $var;

        return $this;
    }

    /**
     * Page height. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 height = 3;</code>
     * @return int
     */
    public function getHeight()
    {
        return $this->height;
    }

    /**
     * Page height. For PDFs the unit is points. For images (including
     * TIFFs) the unit is pixels.
     *
     * Generated from protobuf field <code>int32 height = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setHeight($var)
    {
        GPBUtil::checkInt32($var);
        $this->height = $var;

        return $this;
    }

    /**
     * List of blocks of text, images etc on this page.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1.Block blocks = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getBlocks()
    {
        return $this->blocks;
    }

    /**
     * List of blocks of text, images etc on this page.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1.Block blocks = 4;</code>
     * @param \Google\Cloud\Vision\V1\Block[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setBlocks($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Vision\V1\Block::class);
        $this->blocks = $arr;

        return $this;
    }

    /**
     * Confidence of the OCR results on the page. Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 5;</code>
     * @return float
     */
    public function getConfidence()
    {
        return $this->confidence;
    }

    /**
     * Confidence of the OCR results on the page. Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 5;</code>
     * @param float $var
     * @return $this
     */
    public function setConfidence($var)
    {
        GPBUtil::checkFloat($var);
        $this->confidence = $var;

        return $this;
    }

}

