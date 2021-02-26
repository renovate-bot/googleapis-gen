<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/recaptchaenterprise/v1beta1/recaptchaenterprise.proto

namespace Google\Cloud\RecaptchaEnterprise\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A recaptcha assessment resource.
 *
 * Generated from protobuf message <code>google.cloud.recaptchaenterprise.v1beta1.Assessment</code>
 */
class Assessment extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The resource name for the Assessment in the format
     * "projects/{project_number}/assessments/{assessment_id}".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $name = '';
    /**
     * The event being assessed.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.Event event = 2;</code>
     */
    protected $event = null;
    /**
     * Output only. Legitimate event score from 0.0 to 1.0.
     * (1.0 means very likely legitimate traffic while 0.0 means very likely
     * non-legitimate traffic).
     *
     * Generated from protobuf field <code>float score = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $score = 0.0;
    /**
     * Output only. Properties of the provided event token.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.TokenProperties token_properties = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $token_properties = null;
    /**
     * Output only. Reasons contributing to the risk analysis verdict.
     *
     * Generated from protobuf field <code>repeated .google.cloud.recaptchaenterprise.v1beta1.Assessment.ClassificationReason reasons = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $reasons;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Output only. The resource name for the Assessment in the format
     *           "projects/{project_number}/assessments/{assessment_id}".
     *     @type \Google\Cloud\RecaptchaEnterprise\V1beta1\Event $event
     *           The event being assessed.
     *     @type float $score
     *           Output only. Legitimate event score from 0.0 to 1.0.
     *           (1.0 means very likely legitimate traffic while 0.0 means very likely
     *           non-legitimate traffic).
     *     @type \Google\Cloud\RecaptchaEnterprise\V1beta1\TokenProperties $token_properties
     *           Output only. Properties of the provided event token.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $reasons
     *           Output only. Reasons contributing to the risk analysis verdict.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Recaptchaenterprise\V1Beta1\Recaptchaenterprise::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The resource name for the Assessment in the format
     * "projects/{project_number}/assessments/{assessment_id}".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Output only. The resource name for the Assessment in the format
     * "projects/{project_number}/assessments/{assessment_id}".
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
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
     * The event being assessed.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.Event event = 2;</code>
     * @return \Google\Cloud\RecaptchaEnterprise\V1beta1\Event|null
     */
    public function getEvent()
    {
        return isset($this->event) ? $this->event : null;
    }

    public function hasEvent()
    {
        return isset($this->event);
    }

    public function clearEvent()
    {
        unset($this->event);
    }

    /**
     * The event being assessed.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.Event event = 2;</code>
     * @param \Google\Cloud\RecaptchaEnterprise\V1beta1\Event $var
     * @return $this
     */
    public function setEvent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecaptchaEnterprise\V1beta1\Event::class);
        $this->event = $var;

        return $this;
    }

    /**
     * Output only. Legitimate event score from 0.0 to 1.0.
     * (1.0 means very likely legitimate traffic while 0.0 means very likely
     * non-legitimate traffic).
     *
     * Generated from protobuf field <code>float score = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return float
     */
    public function getScore()
    {
        return $this->score;
    }

    /**
     * Output only. Legitimate event score from 0.0 to 1.0.
     * (1.0 means very likely legitimate traffic while 0.0 means very likely
     * non-legitimate traffic).
     *
     * Generated from protobuf field <code>float score = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
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
     * Output only. Properties of the provided event token.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.TokenProperties token_properties = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Cloud\RecaptchaEnterprise\V1beta1\TokenProperties|null
     */
    public function getTokenProperties()
    {
        return isset($this->token_properties) ? $this->token_properties : null;
    }

    public function hasTokenProperties()
    {
        return isset($this->token_properties);
    }

    public function clearTokenProperties()
    {
        unset($this->token_properties);
    }

    /**
     * Output only. Properties of the provided event token.
     *
     * Generated from protobuf field <code>.google.cloud.recaptchaenterprise.v1beta1.TokenProperties token_properties = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Cloud\RecaptchaEnterprise\V1beta1\TokenProperties $var
     * @return $this
     */
    public function setTokenProperties($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecaptchaEnterprise\V1beta1\TokenProperties::class);
        $this->token_properties = $var;

        return $this;
    }

    /**
     * Output only. Reasons contributing to the risk analysis verdict.
     *
     * Generated from protobuf field <code>repeated .google.cloud.recaptchaenterprise.v1beta1.Assessment.ClassificationReason reasons = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getReasons()
    {
        return $this->reasons;
    }

    /**
     * Output only. Reasons contributing to the risk analysis verdict.
     *
     * Generated from protobuf field <code>repeated .google.cloud.recaptchaenterprise.v1beta1.Assessment.ClassificationReason reasons = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setReasons($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::ENUM, \Google\Cloud\RecaptchaEnterprise\V1beta1\Assessment\ClassificationReason::class);
        $this->reasons = $arr;

        return $this;
    }

}

