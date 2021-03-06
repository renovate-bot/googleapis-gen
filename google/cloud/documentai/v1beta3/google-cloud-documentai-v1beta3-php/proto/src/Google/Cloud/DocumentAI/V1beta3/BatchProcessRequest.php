<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document_processor_service.proto

namespace Google\Cloud\DocumentAI\V1beta3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for batch process document method.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta3.BatchProcessRequest</code>
 */
class BatchProcessRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The processor resource name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * The input config for each single document in the batch process.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta3.BatchProcessRequest.BatchInputConfig input_configs = 2 [deprecated = true];</code>
     * @deprecated
     */
    private $input_configs;
    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchProcessRequest.BatchOutputConfig output_config = 3 [deprecated = true];</code>
     * @deprecated
     */
    protected $output_config = null;
    /**
     * The input documents for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchDocumentsInputConfig input_documents = 5;</code>
     */
    protected $input_documents = null;
    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.DocumentOutputConfig document_output_config = 6;</code>
     */
    protected $document_output_config = null;
    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 4;</code>
     */
    protected $skip_human_review = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The processor resource name.
     *     @type \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchInputConfig[]|\Google\Protobuf\Internal\RepeatedField $input_configs
     *           The input config for each single document in the batch process.
     *     @type \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchOutputConfig $output_config
     *           The overall output config for batch process.
     *     @type \Google\Cloud\DocumentAI\V1beta3\BatchDocumentsInputConfig $input_documents
     *           The input documents for batch process.
     *     @type \Google\Cloud\DocumentAI\V1beta3\DocumentOutputConfig $document_output_config
     *           The overall output config for batch process.
     *     @type bool $skip_human_review
     *           Whether Human Review feature should be skipped for this request. Default to
     *           false.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta3\DocumentProcessorService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The processor resource name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The processor resource name.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * The input config for each single document in the batch process.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta3.BatchProcessRequest.BatchInputConfig input_configs = 2 [deprecated = true];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     * @deprecated
     */
    public function getInputConfigs()
    {
        @trigger_error('input_configs is deprecated.', E_USER_DEPRECATED);
        return $this->input_configs;
    }

    /**
     * The input config for each single document in the batch process.
     *
     * Generated from protobuf field <code>repeated .google.cloud.documentai.v1beta3.BatchProcessRequest.BatchInputConfig input_configs = 2 [deprecated = true];</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchInputConfig[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     * @deprecated
     */
    public function setInputConfigs($var)
    {
        @trigger_error('input_configs is deprecated.', E_USER_DEPRECATED);
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchInputConfig::class);
        $this->input_configs = $arr;

        return $this;
    }

    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchProcessRequest.BatchOutputConfig output_config = 3 [deprecated = true];</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchOutputConfig|null
     * @deprecated
     */
    public function getOutputConfig()
    {
        @trigger_error('output_config is deprecated.', E_USER_DEPRECATED);
        return isset($this->output_config) ? $this->output_config : null;
    }

    public function hasOutputConfig()
    {
        @trigger_error('output_config is deprecated.', E_USER_DEPRECATED);
        return isset($this->output_config);
    }

    public function clearOutputConfig()
    {
        @trigger_error('output_config is deprecated.', E_USER_DEPRECATED);
        unset($this->output_config);
    }

    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchProcessRequest.BatchOutputConfig output_config = 3 [deprecated = true];</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchOutputConfig $var
     * @return $this
     * @deprecated
     */
    public function setOutputConfig($var)
    {
        @trigger_error('output_config is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\BatchProcessRequest\BatchOutputConfig::class);
        $this->output_config = $var;

        return $this;
    }

    /**
     * The input documents for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchDocumentsInputConfig input_documents = 5;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\BatchDocumentsInputConfig|null
     */
    public function getInputDocuments()
    {
        return isset($this->input_documents) ? $this->input_documents : null;
    }

    public function hasInputDocuments()
    {
        return isset($this->input_documents);
    }

    public function clearInputDocuments()
    {
        unset($this->input_documents);
    }

    /**
     * The input documents for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.BatchDocumentsInputConfig input_documents = 5;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\BatchDocumentsInputConfig $var
     * @return $this
     */
    public function setInputDocuments($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\BatchDocumentsInputConfig::class);
        $this->input_documents = $var;

        return $this;
    }

    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.DocumentOutputConfig document_output_config = 6;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\DocumentOutputConfig|null
     */
    public function getDocumentOutputConfig()
    {
        return isset($this->document_output_config) ? $this->document_output_config : null;
    }

    public function hasDocumentOutputConfig()
    {
        return isset($this->document_output_config);
    }

    public function clearDocumentOutputConfig()
    {
        unset($this->document_output_config);
    }

    /**
     * The overall output config for batch process.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.DocumentOutputConfig document_output_config = 6;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\DocumentOutputConfig $var
     * @return $this
     */
    public function setDocumentOutputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\DocumentOutputConfig::class);
        $this->document_output_config = $var;

        return $this;
    }

    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 4;</code>
     * @return bool
     */
    public function getSkipHumanReview()
    {
        return $this->skip_human_review;
    }

    /**
     * Whether Human Review feature should be skipped for this request. Default to
     * false.
     *
     * Generated from protobuf field <code>bool skip_human_review = 4;</code>
     * @param bool $var
     * @return $this
     */
    public function setSkipHumanReview($var)
    {
        GPBUtil::checkBool($var);
        $this->skip_human_review = $var;

        return $this;
    }

}

