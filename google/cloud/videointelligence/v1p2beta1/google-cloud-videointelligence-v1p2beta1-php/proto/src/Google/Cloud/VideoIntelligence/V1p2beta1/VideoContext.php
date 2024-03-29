<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/videointelligence/v1p2beta1/video_intelligence.proto

namespace Google\Cloud\VideoIntelligence\V1p2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Video context and/or feature-specific parameters.
 *
 * Generated from protobuf message <code>google.cloud.videointelligence.v1p2beta1.VideoContext</code>
 */
class VideoContext extends \Google\Protobuf\Internal\Message
{
    /**
     * Video segments to annotate. The segments may overlap and are not required
     * to be contiguous or span the whole video. If unspecified, each video is
     * treated as a single segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p2beta1.VideoSegment segments = 1;</code>
     */
    private $segments;
    /**
     * Config for LABEL_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.LabelDetectionConfig label_detection_config = 2;</code>
     */
    protected $label_detection_config = null;
    /**
     * Config for SHOT_CHANGE_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ShotChangeDetectionConfig shot_change_detection_config = 3;</code>
     */
    protected $shot_change_detection_config = null;
    /**
     * Config for EXPLICIT_CONTENT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ExplicitContentDetectionConfig explicit_content_detection_config = 4;</code>
     */
    protected $explicit_content_detection_config = null;
    /**
     * Config for TEXT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.TextDetectionConfig text_detection_config = 8;</code>
     */
    protected $text_detection_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\VideoIntelligence\V1p2beta1\VideoSegment[]|\Google\Protobuf\Internal\RepeatedField $segments
     *           Video segments to annotate. The segments may overlap and are not required
     *           to be contiguous or span the whole video. If unspecified, each video is
     *           treated as a single segment.
     *     @type \Google\Cloud\VideoIntelligence\V1p2beta1\LabelDetectionConfig $label_detection_config
     *           Config for LABEL_DETECTION.
     *     @type \Google\Cloud\VideoIntelligence\V1p2beta1\ShotChangeDetectionConfig $shot_change_detection_config
     *           Config for SHOT_CHANGE_DETECTION.
     *     @type \Google\Cloud\VideoIntelligence\V1p2beta1\ExplicitContentDetectionConfig $explicit_content_detection_config
     *           Config for EXPLICIT_CONTENT_DETECTION.
     *     @type \Google\Cloud\VideoIntelligence\V1p2beta1\TextDetectionConfig $text_detection_config
     *           Config for TEXT_DETECTION.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Videointelligence\V1P2Beta1\VideoIntelligence::initOnce();
        parent::__construct($data);
    }

    /**
     * Video segments to annotate. The segments may overlap and are not required
     * to be contiguous or span the whole video. If unspecified, each video is
     * treated as a single segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p2beta1.VideoSegment segments = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getSegments()
    {
        return $this->segments;
    }

    /**
     * Video segments to annotate. The segments may overlap and are not required
     * to be contiguous or span the whole video. If unspecified, each video is
     * treated as a single segment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.videointelligence.v1p2beta1.VideoSegment segments = 1;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p2beta1\VideoSegment[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setSegments($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\VideoIntelligence\V1p2beta1\VideoSegment::class);
        $this->segments = $arr;

        return $this;
    }

    /**
     * Config for LABEL_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.LabelDetectionConfig label_detection_config = 2;</code>
     * @return \Google\Cloud\VideoIntelligence\V1p2beta1\LabelDetectionConfig|null
     */
    public function getLabelDetectionConfig()
    {
        return $this->label_detection_config;
    }

    public function hasLabelDetectionConfig()
    {
        return isset($this->label_detection_config);
    }

    public function clearLabelDetectionConfig()
    {
        unset($this->label_detection_config);
    }

    /**
     * Config for LABEL_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.LabelDetectionConfig label_detection_config = 2;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p2beta1\LabelDetectionConfig $var
     * @return $this
     */
    public function setLabelDetectionConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\VideoIntelligence\V1p2beta1\LabelDetectionConfig::class);
        $this->label_detection_config = $var;

        return $this;
    }

    /**
     * Config for SHOT_CHANGE_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ShotChangeDetectionConfig shot_change_detection_config = 3;</code>
     * @return \Google\Cloud\VideoIntelligence\V1p2beta1\ShotChangeDetectionConfig|null
     */
    public function getShotChangeDetectionConfig()
    {
        return $this->shot_change_detection_config;
    }

    public function hasShotChangeDetectionConfig()
    {
        return isset($this->shot_change_detection_config);
    }

    public function clearShotChangeDetectionConfig()
    {
        unset($this->shot_change_detection_config);
    }

    /**
     * Config for SHOT_CHANGE_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ShotChangeDetectionConfig shot_change_detection_config = 3;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p2beta1\ShotChangeDetectionConfig $var
     * @return $this
     */
    public function setShotChangeDetectionConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\VideoIntelligence\V1p2beta1\ShotChangeDetectionConfig::class);
        $this->shot_change_detection_config = $var;

        return $this;
    }

    /**
     * Config for EXPLICIT_CONTENT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ExplicitContentDetectionConfig explicit_content_detection_config = 4;</code>
     * @return \Google\Cloud\VideoIntelligence\V1p2beta1\ExplicitContentDetectionConfig|null
     */
    public function getExplicitContentDetectionConfig()
    {
        return $this->explicit_content_detection_config;
    }

    public function hasExplicitContentDetectionConfig()
    {
        return isset($this->explicit_content_detection_config);
    }

    public function clearExplicitContentDetectionConfig()
    {
        unset($this->explicit_content_detection_config);
    }

    /**
     * Config for EXPLICIT_CONTENT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.ExplicitContentDetectionConfig explicit_content_detection_config = 4;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p2beta1\ExplicitContentDetectionConfig $var
     * @return $this
     */
    public function setExplicitContentDetectionConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\VideoIntelligence\V1p2beta1\ExplicitContentDetectionConfig::class);
        $this->explicit_content_detection_config = $var;

        return $this;
    }

    /**
     * Config for TEXT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.TextDetectionConfig text_detection_config = 8;</code>
     * @return \Google\Cloud\VideoIntelligence\V1p2beta1\TextDetectionConfig|null
     */
    public function getTextDetectionConfig()
    {
        return $this->text_detection_config;
    }

    public function hasTextDetectionConfig()
    {
        return isset($this->text_detection_config);
    }

    public function clearTextDetectionConfig()
    {
        unset($this->text_detection_config);
    }

    /**
     * Config for TEXT_DETECTION.
     *
     * Generated from protobuf field <code>.google.cloud.videointelligence.v1p2beta1.TextDetectionConfig text_detection_config = 8;</code>
     * @param \Google\Cloud\VideoIntelligence\V1p2beta1\TextDetectionConfig $var
     * @return $this
     */
    public function setTextDetectionConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\VideoIntelligence\V1p2beta1\TextDetectionConfig::class);
        $this->text_detection_config = $var;

        return $this;
    }

}

