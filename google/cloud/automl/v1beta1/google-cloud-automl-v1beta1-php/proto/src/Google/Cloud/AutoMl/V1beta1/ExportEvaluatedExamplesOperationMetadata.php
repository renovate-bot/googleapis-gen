<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/automl/v1beta1/operations.proto

namespace Google\Cloud\AutoMl\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Details of EvaluatedExamples operation.
 *
 * Generated from protobuf message <code>google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata</code>
 */
class ExportEvaluatedExamplesOperationMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. Information further describing the output of this evaluated
     * examples export.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata.ExportEvaluatedExamplesOutputInfo output_info = 2;</code>
     */
    protected $output_info = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata\ExportEvaluatedExamplesOutputInfo $output_info
     *           Output only. Information further describing the output of this evaluated
     *           examples export.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Automl\V1Beta1\Operations::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. Information further describing the output of this evaluated
     * examples export.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata.ExportEvaluatedExamplesOutputInfo output_info = 2;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata\ExportEvaluatedExamplesOutputInfo|null
     */
    public function getOutputInfo()
    {
        return isset($this->output_info) ? $this->output_info : null;
    }

    public function hasOutputInfo()
    {
        return isset($this->output_info);
    }

    public function clearOutputInfo()
    {
        unset($this->output_info);
    }

    /**
     * Output only. Information further describing the output of this evaluated
     * examples export.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata.ExportEvaluatedExamplesOutputInfo output_info = 2;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata\ExportEvaluatedExamplesOutputInfo $var
     * @return $this
     */
    public function setOutputInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata\ExportEvaluatedExamplesOutputInfo::class);
        $this->output_info = $var;

        return $this;
    }

}

