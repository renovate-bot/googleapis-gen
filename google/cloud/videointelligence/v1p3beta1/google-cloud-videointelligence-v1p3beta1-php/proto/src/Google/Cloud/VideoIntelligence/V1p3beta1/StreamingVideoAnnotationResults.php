<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/videointelligence/v1p3beta1/video_intelligence.proto

namespace Google\Cloud\VideoIntelligence\V1p3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Streaming annotation results corresponding to a portion of the video
 * that is currently being processed.
 *
 * Generated from protobuf message <code>google.cloud.videointelligence.v1p3beta1.StreamingVideoAnnotationResults</code>
 */
class StreamingVideoAnnotationResults extends \Google\Protobuf\Internal\Message
{
    /**
     * Shot annotation results. Each shot is represented as a video segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.VideoSegment shot_annotations = 1;</code>
     */
    private $shot_annotations;
    /**
     * Label annotation results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.LabelAnnotation label_annotations = 2;</code>
     */
    private $label_annotations;
    /**
     * Explicit content annotation results.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p3beta1.ExplicitContentAnnotation explicit_annotation = 3;</code>
     */
    protected $explicit_annotation = null;
    /**
     * Object tracking results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.ObjectTrackingAnnotation object_annotations = 4;</code>
     */
    private $object_annotations;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\VideoIntelligence\V1p3beta1\VideoSegment[]|\Google\Protobuf\Internal\RepeatedField $shot_annotations
     *           Shot annotation results. Each shot is represented as a video segment.
     *     @type \Google\Cloud\VideoIntelligence\V1p3beta1\LabelAnnotation[]|\Google\Protobuf\Internal\RepeatedField $label_annotations
     *           Label annotation results.
     *     @type \Google\Cloud\VideoIntelligence\V1p3beta1\ExplicitContentAnnotation $explicit_annotation
     *           Explicit content annotation results.
     *     @type \Google\Cloud\VideoIntelligence\V1p3beta1\ObjectTrackingAnnotation[]|\Google\Protobuf\Internal\RepeatedField $object_annotations
     *           Object tracking results.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Videointelligence\V1P3Beta1\VideoIntelligence::initOnce();
        parent::__construct($data);
    }

    /**
     * Shot annotation results. Each shot is represented as a video segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.VideoSegment shot_annotations = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getShotAnnotations()
    {
        return $this->shot_annotations;
    }

    /**
     * Shot annotation results. Each shot is represented as a video segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.VideoSegment shot_annotations = 1;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p3beta1\VideoSegment[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setShotAnnotations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\VideoIntelligence\V1p3beta1\VideoSegment::class);
        $this->shot_annotations = $arr;

        return $this;
    }

    /**
     * Label annotation results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.LabelAnnotation label_annotations = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getLabelAnnotations()
    {
        return $this->label_annotations;
    }

    /**
     * Label annotation results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.LabelAnnotation label_annotations = 2;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p3beta1\LabelAnnotation[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setLabelAnnotations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\VideoIntelligence\V1p3beta1\LabelAnnotation::class);
        $this->label_annotations = $arr;

        return $this;
    }

    /**
     * Explicit content annotation results.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p3beta1.ExplicitContentAnnotation explicit_annotation = 3;</code>
     * @return \Google\Cloud\VideoIntelligence\V1p3beta1\ExplicitContentAnnotation|null
     */
    public function getExplicitAnnotation()
    {
        return $this->explicit_annotation;
    }

    public function hasExplicitAnnotation()
    {
        return isset($this->explicit_annotation);
    }

    public function clearExplicitAnnotation()
    {
        unset($this->explicit_annotation);
    }

    /**
     * Explicit content annotation results.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p3beta1.ExplicitContentAnnotation explicit_annotation = 3;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p3beta1\ExplicitContentAnnotation $var
     * @return $this
     */
    public function setExplicitAnnotation($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\VideoIntelligence\V1p3beta1\ExplicitContentAnnotation::class);
        $this->explicit_annotation = $var;

        return $this;
    }

    /**
     * Object tracking results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.ObjectTrackingAnnotation object_annotations = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getObjectAnnotations()
    {
        return $this->object_annotations;
    }

    /**
     * Object tracking results.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p3beta1.ObjectTrackingAnnotation object_annotations = 4;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p3beta1\ObjectTrackingAnnotation[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setObjectAnnotations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\VideoIntelligence\V1p3beta1\ObjectTrackingAnnotation::class);
        $this->object_annotations = $arr;

        return $this;
    }

}

