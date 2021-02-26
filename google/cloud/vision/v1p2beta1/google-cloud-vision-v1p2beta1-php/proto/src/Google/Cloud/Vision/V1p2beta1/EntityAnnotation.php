<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/vision/v1p2beta1/image_annotator.proto

namespace Google\Cloud\Vision\V1p2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Set of detected entity features.
 *
 * Generated from protobuf message <code>google.cloud.vision.v1p2beta1.EntityAnnotation</code>
 */
class EntityAnnotation extends \Google\Protobuf\Internal\Message
{
    /**
     * Opaque entity ID. Some IDs may be available in
     * [Google Knowledge Graph Search
     * API](https://developers.google.com/knowledge-graph/).
     *
     * Generated from protobuf field <code>string mid = 1;</code>
     */
    protected $mid = '';
    /**
     * The language code for the locale in which the entity textual
     * `description` is expressed.
     *
     * Generated from protobuf field <code>string locale = 2;</code>
     */
    protected $locale = '';
    /**
     * Entity textual description, expressed in its `locale` language.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     */
    protected $description = '';
    /**
     * Overall score of the result. Range [0, 1].
     *
     * Generated from protobuf field <code>float score = 4;</code>
     */
    protected $score = 0.0;
    /**
     * **Deprecated. Use `score` instead.**
     * The accuracy of the entity detection in an image.
     * For example, for an image in which the "Eiffel Tower" entity is detected,
     * this field represents the confidence that there is a tower in the query
     * image. Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 5;</code>
     */
    protected $confidence = 0.0;
    /**
     * The relevancy of the ICA (Image Content Annotation) label to the
     * image. For example, the relevancy of "tower" is likely higher to an image
     * containing the detected "Eiffel Tower" than to an image containing a
     * detected distant towering building, even though the confidence that
     * there is a tower in each image may be the same. Range [0, 1].
     *
     * Generated from protobuf field <code>float topicality = 6;</code>
     */
    protected $topicality = 0.0;
    /**
     * Image region to which this entity belongs. Not produced
     * for `LABEL_DETECTION` features.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p2beta1.BoundingPoly bounding_poly = 7;</code>
     */
    protected $bounding_poly = null;
    /**
     * The location information for the detected entity. Multiple
     * `LocationInfo` elements can be present because one location may
     * indicate the location of the scene in the image, and another location
     * may indicate the location of the place where the image was taken.
     * Location information is usually present for landmarks.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.LocationInfo locations = 8;</code>
     */
    private $locations;
    /**
     * Some entities may have optional user-supplied `Property` (name/value)
     * fields, such a score or string that qualifies the entity.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.Property properties = 9;</code>
     */
    private $properties;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $mid
     *           Opaque entity ID. Some IDs may be available in
     *           [Google Knowledge Graph Search
     *           API](https://developers.google.com/knowledge-graph/).
     *     @type string $locale
     *           The language code for the locale in which the entity textual
     *           `description` is expressed.
     *     @type string $description
     *           Entity textual description, expressed in its `locale` language.
     *     @type float $score
     *           Overall score of the result. Range [0, 1].
     *     @type float $confidence
     *           **Deprecated. Use `score` instead.**
     *           The accuracy of the entity detection in an image.
     *           For example, for an image in which the "Eiffel Tower" entity is detected,
     *           this field represents the confidence that there is a tower in the query
     *           image. Range [0, 1].
     *     @type float $topicality
     *           The relevancy of the ICA (Image Content Annotation) label to the
     *           image. For example, the relevancy of "tower" is likely higher to an image
     *           containing the detected "Eiffel Tower" than to an image containing a
     *           detected distant towering building, even though the confidence that
     *           there is a tower in each image may be the same. Range [0, 1].
     *     @type \Google\Cloud\Vision\V1p2beta1\BoundingPoly $bounding_poly
     *           Image region to which this entity belongs. Not produced
     *           for `LABEL_DETECTION` features.
     *     @type \Google\Cloud\Vision\V1p2beta1\LocationInfo[]|\Google\Protobuf\Internal\RepeatedField $locations
     *           The location information for the detected entity. Multiple
     *           `LocationInfo` elements can be present because one location may
     *           indicate the location of the scene in the image, and another location
     *           may indicate the location of the place where the image was taken.
     *           Location information is usually present for landmarks.
     *     @type \Google\Cloud\Vision\V1p2beta1\Property[]|\Google\Protobuf\Internal\RepeatedField $properties
     *           Some entities may have optional user-supplied `Property` (name/value)
     *           fields, such a score or string that qualifies the entity.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Vision\V1P2Beta1\ImageAnnotator::initOnce();
        parent::__construct($data);
    }

    /**
     * Opaque entity ID. Some IDs may be available in
     * [Google Knowledge Graph Search
     * API](https://developers.google.com/knowledge-graph/).
     *
     * Generated from protobuf field <code>string mid = 1;</code>
     * @return string
     */
    public function getMid()
    {
        return $this->mid;
    }

    /**
     * Opaque entity ID. Some IDs may be available in
     * [Google Knowledge Graph Search
     * API](https://developers.google.com/knowledge-graph/).
     *
     * Generated from protobuf field <code>string mid = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setMid($var)
    {
        GPBUtil::checkString($var, True);
        $this->mid = $var;

        return $this;
    }

    /**
     * The language code for the locale in which the entity textual
     * `description` is expressed.
     *
     * Generated from protobuf field <code>string locale = 2;</code>
     * @return string
     */
    public function getLocale()
    {
        return $this->locale;
    }

    /**
     * The language code for the locale in which the entity textual
     * `description` is expressed.
     *
     * Generated from protobuf field <code>string locale = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setLocale($var)
    {
        GPBUtil::checkString($var, True);
        $this->locale = $var;

        return $this;
    }

    /**
     * Entity textual description, expressed in its `locale` language.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Entity textual description, expressed in its `locale` language.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * Overall score of the result. Range [0, 1].
     *
     * Generated from protobuf field <code>float score = 4;</code>
     * @return float
     */
    public function getScore()
    {
        return $this->score;
    }

    /**
     * Overall score of the result. Range [0, 1].
     *
     * Generated from protobuf field <code>float score = 4;</code>
     * @param float $var
     * @return $this
     */
    public function setScore($var)
    {
        GPBUtil::checkFloat($var);
        $this->score = $var;

        return $this;
    }

    /**
     * **Deprecated. Use `score` instead.**
     * The accuracy of the entity detection in an image.
     * For example, for an image in which the "Eiffel Tower" entity is detected,
     * this field represents the confidence that there is a tower in the query
     * image. Range [0, 1].
     *
     * Generated from protobuf field <code>float confidence = 5;</code>
     * @return float
     */
    public function getConfidence()
    {
        return $this->confidence;
    }

    /**
     * **Deprecated. Use `score` instead.**
     * The accuracy of the entity detection in an image.
     * For example, for an image in which the "Eiffel Tower" entity is detected,
     * this field represents the confidence that there is a tower in the query
     * image. Range [0, 1].
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

    /**
     * The relevancy of the ICA (Image Content Annotation) label to the
     * image. For example, the relevancy of "tower" is likely higher to an image
     * containing the detected "Eiffel Tower" than to an image containing a
     * detected distant towering building, even though the confidence that
     * there is a tower in each image may be the same. Range [0, 1].
     *
     * Generated from protobuf field <code>float topicality = 6;</code>
     * @return float
     */
    public function getTopicality()
    {
        return $this->topicality;
    }

    /**
     * The relevancy of the ICA (Image Content Annotation) label to the
     * image. For example, the relevancy of "tower" is likely higher to an image
     * containing the detected "Eiffel Tower" than to an image containing a
     * detected distant towering building, even though the confidence that
     * there is a tower in each image may be the same. Range [0, 1].
     *
     * Generated from protobuf field <code>float topicality = 6;</code>
     * @param float $var
     * @return $this
     */
    public function setTopicality($var)
    {
        GPBUtil::checkFloat($var);
        $this->topicality = $var;

        return $this;
    }

    /**
     * Image region to which this entity belongs. Not produced
     * for `LABEL_DETECTION` features.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p2beta1.BoundingPoly bounding_poly = 7;</code>
     * @return \Google\Cloud\Vision\V1p2beta1\BoundingPoly|null
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
     * Image region to which this entity belongs. Not produced
     * for `LABEL_DETECTION` features.
     *
     * Generated from protobuf field <code>.google.cloud.vision.v1p2beta1.BoundingPoly bounding_poly = 7;</code>
     * @param \Google\Cloud\Vision\V1p2beta1\BoundingPoly $var
     * @return $this
     */
    public function setBoundingPoly($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Vision\V1p2beta1\BoundingPoly::class);
        $this->bounding_poly = $var;

        return $this;
    }

    /**
     * The location information for the detected entity. Multiple
     * `LocationInfo` elements can be present because one location may
     * indicate the location of the scene in the image, and another location
     * may indicate the location of the place where the image was taken.
     * Location information is usually present for landmarks.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.LocationInfo locations = 8;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getLocations()
    {
        return $this->locations;
    }

    /**
     * The location information for the detected entity. Multiple
     * `LocationInfo` elements can be present because one location may
     * indicate the location of the scene in the image, and another location
     * may indicate the location of the place where the image was taken.
     * Location information is usually present for landmarks.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.LocationInfo locations = 8;</code>
     * @param \Google\Cloud\Vision\V1p2beta1\LocationInfo[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setLocations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Vision\V1p2beta1\LocationInfo::class);
        $this->locations = $arr;

        return $this;
    }

    /**
     * Some entities may have optional user-supplied `Property` (name/value)
     * fields, such a score or string that qualifies the entity.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.Property properties = 9;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getProperties()
    {
        return $this->properties;
    }

    /**
     * Some entities may have optional user-supplied `Property` (name/value)
     * fields, such a score or string that qualifies the entity.
     *
     * Generated from protobuf field <code>repeated .google.cloud.vision.v1p2beta1.Property properties = 9;</code>
     * @param \Google\Cloud\Vision\V1p2beta1\Property[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setProperties($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Vision\V1p2beta1\Property::class);
        $this->properties = $arr;

        return $this;
    }

}

