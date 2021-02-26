<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/automl/v1/operations.proto

namespace Google\Cloud\AutoMl\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Details of BatchPredict operation.
 *
 * Generated from protobuf message <code>google.cloud.automl.v1.BatchPredictOperationMetadata</code>
 */
class BatchPredictOperationMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The input config that was given upon starting this
     * batch predict operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictInputConfig input_config = 1;</code>
     */
    protected $input_config = null;
    /**
     * Output only. Information further describing this batch predict's output.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictOperationMetadata.BatchPredictOutputInfo output_info = 2;</code>
     */
    protected $output_info = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\AutoMl\V1\BatchPredictInputConfig $input_config
     *           Output only. The input config that was given upon starting this
     *           batch predict operation.
     *     @type \Google\Cloud\AutoMl\V1\BatchPredictOperationMetadata\BatchPredictOutputInfo $output_info
     *           Output only. Information further describing this batch predict's output.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Automl\V1\Operations::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The input config that was given upon starting this
     * batch predict operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictInputConfig input_config = 1;</code>
     * @return \Google\Cloud\AutoMl\V1\BatchPredictInputConfig|null
     */
    public function getInputConfig()
    {
        return isset($this->input_config) ? $this->input_config : null;
    }

    public function hasInputConfig()
    {
        return isset($this->input_config);
    }

    public function clearInputConfig()
    {
        unset($this->input_config);
    }

    /**
     * Output only. The input config that was given upon starting this
     * batch predict operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictInputConfig input_config = 1;</code>
     * @param \Google\Cloud\AutoMl\V1\BatchPredictInputConfig $var
     * @return $this
     */
    public function setInputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1\BatchPredictInputConfig::class);
        $this->input_config = $var;

        return $this;
    }

    /**
     * Output only. Information further describing this batch predict's output.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictOperationMetadata.BatchPredictOutputInfo output_info = 2;</code>
     * @return \Google\Cloud\AutoMl\V1\BatchPredictOperationMetadata\BatchPredictOutputInfo|null
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
     * Output only. Information further describing this batch predict's output.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1.BatchPredictOperationMetadata.BatchPredictOutputInfo output_info = 2;</code>
     * @param \Google\Cloud\AutoMl\V1\BatchPredictOperationMetadata\BatchPredictOutputInfo $var
     * @return $this
     */
    public function setOutputInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1\BatchPredictOperationMetadata\BatchPredictOutputInfo::class);
        $this->output_info = $var;

        return $this;
    }

}

