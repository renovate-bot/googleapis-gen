<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/explanation.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Specification of Model explanation.
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.ExplanationSpec</code>
 */
class ExplanationSpec extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Parameters that configure explaining of the Model's predictions.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationParameters parameters = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $parameters = null;
    /**
     * Required. Metadata describing the Model's input and output for explanation.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationMetadata metadata = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $metadata = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Aiplatform\V1beta1\ExplanationParameters $parameters
     *           Required. Parameters that configure explaining of the Model's predictions.
     *     @type \Google\Cloud\Aiplatform\V1beta1\ExplanationMetadata $metadata
     *           Required. Metadata describing the Model's input and output for explanation.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Explanation::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Parameters that configure explaining of the Model's predictions.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationParameters parameters = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Aiplatform\V1beta1\ExplanationParameters|null
     */
    public function getParameters()
    {
        return isset($this->parameters) ? $this->parameters : null;
    }

    public function hasParameters()
    {
        return isset($this->parameters);
    }

    public function clearParameters()
    {
        unset($this->parameters);
    }

    /**
     * Required. Parameters that configure explaining of the Model's predictions.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationParameters parameters = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\ExplanationParameters $var
     * @return $this
     */
    public function setParameters($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Aiplatform\V1beta1\ExplanationParameters::class);
        $this->parameters = $var;

        return $this;
    }

    /**
     * Required. Metadata describing the Model's input and output for explanation.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationMetadata metadata = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Aiplatform\V1beta1\ExplanationMetadata|null
     */
    public function getMetadata()
    {
        return isset($this->metadata) ? $this->metadata : null;
    }

    public function hasMetadata()
    {
        return isset($this->metadata);
    }

    public function clearMetadata()
    {
        unset($this->metadata);
    }

    /**
     * Required. Metadata describing the Model's input and output for explanation.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.ExplanationMetadata metadata = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\ExplanationMetadata $var
     * @return $this
     */
    public function setMetadata($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Aiplatform\V1beta1\ExplanationMetadata::class);
        $this->metadata = $var;

        return $this;
    }

}

