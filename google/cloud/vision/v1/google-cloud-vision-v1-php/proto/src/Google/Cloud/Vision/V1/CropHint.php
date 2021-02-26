<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1/image_annotator.proto

namespace Google\Cloud\Vision\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Single crop hint that is used to generate a new crop when serving an image.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1.CropHint</code>
 */
class CropHint extends \Google\Protobuf\Internal\Message
{
    /**
     * The bounding polygon for the crop region. The coordinates of the bounding
     * box are in the original image's scale.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.BoundingPoly bounding_poly = 1;</code>
     */
    protected $bounding_poly = null;
    /**
     * Confidence of this being a salient region.  Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 2;</code>
     */
    protected $confidence = 0.0;
    /**
     * Fraction of importance of this salient region with respect to the original
     * image.
     *
     * Generated from protobuf field <code>float importance_fraction = 3;</code>
     */
    protected $importance_fraction = 0.0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Vision\V1\BoundingPoly $bounding_poly
     *           The bounding polygon for the crop region. The coordinates of the bounding
     *           box are in the original image's scale.
     *     @type float $confidence
     *           Confidence of this being a salient region.  Range [0, 1].
     *     @type float $importance_fraction
     *           Fraction of importance of this salient region with respect to the original
     *           image.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1\ImageAnnotator::initOnce();
        parent::__construct($data);
    }

    /**
     * The bounding polygon for the crop region. The coordinates of the bounding
     * box are in the original image's scale.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.BoundingPoly bounding_poly = 1;</code>
     * @return \Google\Cloud\Vision\V1\BoundingPoly|null
     */
    public function getBoundingPoly()
    {
        return isset($this->bounding_poly) ? $this->bounding_poly : null;
    }

    public function hasBoundingPoly()
    {
        return isset($this->bounding_poly);
    }

    public function clearBoundingPoly()
    {
        unset($this->bounding_poly);
    }

    /**
     * The bounding polygon for the crop region. The coordinates of the bounding
     * box are in the original image's scale.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1.BoundingPoly bounding_poly = 1;</code>
     * @param \Google\Cloud\Vision\V1\BoundingPoly $var
     * @return $this
     */
    public function setBoundingPoly($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1\BoundingPoly::class);
        $this->bounding_poly = $var;

        return $this;
    }

    /**
     * Confidence of this being a salient region.  Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 2;</code>
     * @return float
     */
    public function getConfidence()
    {
        return $this->confidence;
    }

    /**
     * Confidence of this being a salient region.  Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 2;</code>
     * @param float $var
     * @return $this
     */
    public function setConfidence($var)
    {
        GPBUtil::checkFloat($var);
        $this->confidence = $var;

        return $this;
    }

    /**
     * Fraction of importance of this salient region with respect to the original
     * image.
     *
     * Generated from protobuf field <code>float importance_fraction = 3;</code>
     * @return float
     */
    public function getImportanceFraction()
    {
        return $this->importance_fraction;
    }

    /**
     * Fraction of importance of this salient region with respect to the original
     * image.
     *
     * Generated from protobuf field <code>float importance_fraction = 3;</code>
     * @param float $var
     * @return $this
     */
    public function setImportanceFraction($var)
    {
        GPBUtil::checkFloat($var);
        $this->importance_fraction = $var;

        return $this;
    }

}

