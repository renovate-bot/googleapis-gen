<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/documentai/v1beta3/document_processor_service.proto

namespace Google\Cloud\DocumentAI\V1beta3\BatchProcessMetadata;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The status of a each individual document in the batch process.
 *
 * Generated from protobuf message <code>google.cloud.documentai.v1beta3.BatchProcessMetadata.IndividualProcessStatus</code>
 */
class IndividualProcessStatus extends \Google\Protobuf\Internal\Message
{
    /**
     * The source of the document, same as the [input_gcs_source] field in the
     * request when the batch process started. The batch process is started by
     * take snapshot of that document, since a user can move or change that
     * document during the process.
     *
     * Generated from protobuf field <code>string input_gcs_source = 1;</code>
     */
    protected $input_gcs_source = '';
    /**
     * The status of the processing of the document.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     */
    protected $status = null;
    /**
     * The output_gcs_destination (in the request as 'output_gcs_destination')
     * of the processed document if it was successful, otherwise empty.
     *
     * Generated from protobuf field <code>string output_gcs_destination = 3;</code>
     */
    protected $output_gcs_destination = '';
    /**
     * The name of the operation triggered by the processed document. If the
     * human review process is not triggered, this field will be empty. It has
     * the same response type and metadata as the long running operation
     * returned by ReviewDocument method.
     *
     * Generated from protobuf field <code>string human_review_operation = 4 [deprecated = true];</code>
     * @deprecated
     */
    protected $human_review_operation = '';
    /**
     * The status of human review on the processed document.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.HumanReviewStatus human_review_status = 5;</code>
     */
    protected $human_review_status = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $input_gcs_source
     *           The source of the document, same as the [input_gcs_source] field in the
     *           request when the batch process started. The batch process is started by
     *           take snapshot of that document, since a user can move or change that
     *           document during the process.
     *     @type \Google\Rpc\Status $status
     *           The status of the processing of the document.
     *     @type string $output_gcs_destination
     *           The output_gcs_destination (in the request as 'output_gcs_destination')
     *           of the processed document if it was successful, otherwise empty.
     *     @type string $human_review_operation
     *           The name of the operation triggered by the processed document. If the
     *           human review process is not triggered, this field will be empty. It has
     *           the same response type and metadata as the long running operation
     *           returned by ReviewDocument method.
     *     @type \Google\Cloud\DocumentAI\V1beta3\HumanReviewStatus $human_review_status
     *           The status of human review on the processed document.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Documentai\V1Beta3\DocumentProcessorService::initOnce();
        parent::__construct($data);
    }

    /**
     * The source of the document, same as the [input_gcs_source] field in the
     * request when the batch process started. The batch process is started by
     * take snapshot of that document, since a user can move or change that
     * document during the process.
     *
     * Generated from protobuf field <code>string input_gcs_source = 1;</code>
     * @return string
     */
    public function getInputGcsSource()
    {
        return $this->input_gcs_source;
    }

    /**
     * The source of the document, same as the [input_gcs_source] field in the
     * request when the batch process started. The batch process is started by
     * take snapshot of that document, since a user can move or change that
     * document during the process.
     *
     * Generated from protobuf field <code>string input_gcs_source = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setInputGcsSource($var)
    {
        GPBUtil::checkString($var, True);
        $this->input_gcs_source = $var;

        return $this;
    }

    /**
     * The status of the processing of the document.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getStatus()
    {
        return $this->status;
    }

    public function hasStatus()
    {
        return isset($this->status);
    }

    public function clearStatus()
    {
        unset($this->status);
    }

    /**
     * The status of the processing of the document.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->status = $var;

        return $this;
    }

    /**
     * The output_gcs_destination (in the request as 'output_gcs_destination')
     * of the processed document if it was successful, otherwise empty.
     *
     * Generated from protobuf field <code>string output_gcs_destination = 3;</code>
     * @return string
     */
    public function getOutputGcsDestination()
    {
        return $this->output_gcs_destination;
    }

    /**
     * The output_gcs_destination (in the request as 'output_gcs_destination')
     * of the processed document if it was successful, otherwise empty.
     *
     * Generated from protobuf field <code>string output_gcs_destination = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setOutputGcsDestination($var)
    {
        GPBUtil::checkString($var, True);
        $this->output_gcs_destination = $var;

        return $this;
    }

    /**
     * The name of the operation triggered by the processed document. If the
     * human review process is not triggered, this field will be empty. It has
     * the same response type and metadata as the long running operation
     * returned by ReviewDocument method.
     *
     * Generated from protobuf field <code>string human_review_operation = 4 [deprecated = true];</code>
     * @return string
     * @deprecated
     */
    public function getHumanReviewOperation()
    {
        @trigger_error('human_review_operation is deprecated.', E_USER_DEPRECATED);
        return $this->human_review_operation;
    }

    /**
     * The name of the operation triggered by the processed document. If the
     * human review process is not triggered, this field will be empty. It has
     * the same response type and metadata as the long running operation
     * returned by ReviewDocument method.
     *
     * Generated from protobuf field <code>string human_review_operation = 4 [deprecated = true];</code>
     * @param string $var
     * @return $this
     * @deprecated
     */
    public function setHumanReviewOperation($var)
    {
        @trigger_error('human_review_operation is deprecated.', E_USER_DEPRECATED);
        GPBUtil::checkString($var, True);
        $this->human_review_operation = $var;

        return $this;
    }

    /**
     * The status of human review on the processed document.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.HumanReviewStatus human_review_status = 5;</code>
     * @return \Google\Cloud\DocumentAI\V1beta3\HumanReviewStatus|null
     */
    public function getHumanReviewStatus()
    {
        return $this->human_review_status;
    }

    public function hasHumanReviewStatus()
    {
        return isset($this->human_review_status);
    }

    public function clearHumanReviewStatus()
    {
        unset($this->human_review_status);
    }

    /**
     * The status of human review on the processed document.
     *
     * Generated from protobuf field <code>.google.cloud.documentai.v1beta3.HumanReviewStatus human_review_status = 5;</code>
     * @param \Google\Cloud\DocumentAI\V1beta3\HumanReviewStatus $var
     * @return $this
     */
    public function setHumanReviewStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DocumentAI\V1beta3\HumanReviewStatus::class);
        $this->human_review_status = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(IndividualProcessStatus::class, \Google\Cloud\DocumentAI\V1beta3\BatchProcessMetadata_IndividualProcessStatus::class);

