<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/automl/v1beta1/operations.proto

namespace Google\Cloud\AutoMl\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Metadata used across all long running operations returned by AutoML API.
 *
 * Generated from protobuf message <code>google.cloud.automl.v1beta1.OperationMetadata</code>
 */
class OperationMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. Progress of operation. Range: [0, 100].
     * Not used currently.
     *
     * Generated from protobuf field <code>int32 progress_percent = 13;</code>
     */
    protected $progress_percent = 0;
    /**
     * Output only. Partial failures encountered.
     * E.g. single files that couldn't be read.
     * This field should never exceed 20 entries.
     * Status details field will contain standard GCP error details.
     *
     * Generated from protobuf field <code>repeated .google.rpc.Status partial_failures = 2;</code>
     */
    private $partial_failures;
    /**
     * Output only. Time when the operation was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     */
    protected $create_time = null;
    /**
     * Output only. Time when the operation was updated for the last time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4;</code>
     */
    protected $update_time = null;
    protected $details;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\AutoMl\V1beta1\DeleteOperationMetadata $delete_details
     *           Details of a Delete operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\DeployModelOperationMetadata $deploy_model_details
     *           Details of a DeployModel operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\UndeployModelOperationMetadata $undeploy_model_details
     *           Details of an UndeployModel operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\CreateModelOperationMetadata $create_model_details
     *           Details of CreateModel operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\ImportDataOperationMetadata $import_data_details
     *           Details of ImportData operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\BatchPredictOperationMetadata $batch_predict_details
     *           Details of BatchPredict operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\ExportDataOperationMetadata $export_data_details
     *           Details of ExportData operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\ExportModelOperationMetadata $export_model_details
     *           Details of ExportModel operation.
     *     @type \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata $export_evaluated_examples_details
     *           Details of ExportEvaluatedExamples operation.
     *     @type int $progress_percent
     *           Output only. Progress of operation. Range: [0, 100].
     *           Not used currently.
     *     @type \Google\Rpc\Status[]|\Google\Protobuf\Internal\RepeatedField $partial_failures
     *           Output only. Partial failures encountered.
     *           E.g. single files that couldn't be read.
     *           This field should never exceed 20 entries.
     *           Status details field will contain standard GCP error details.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Output only. Time when the operation was created.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Output only. Time when the operation was updated for the last time.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Automl\V1Beta1\Operations::initOnce();
        parent::__construct($data);
    }

    /**
     * Details of a Delete operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.DeleteOperationMetadata delete_details = 8;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\DeleteOperationMetadata|null
     */
    public function getDeleteDetails()
    {
        return $this->readOneof(8);
    }

    public function hasDeleteDetails()
    {
        return $this->hasOneof(8);
    }

    /**
     * Details of a Delete operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.DeleteOperationMetadata delete_details = 8;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\DeleteOperationMetadata $var
     * @return $this
     */
    public function setDeleteDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\DeleteOperationMetadata::class);
        $this->writeOneof(8, $var);

        return $this;
    }

    /**
     * Details of a DeployModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.DeployModelOperationMetadata deploy_model_details = 24;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\DeployModelOperationMetadata|null
     */
    public function getDeployModelDetails()
    {
        return $this->readOneof(24);
    }

    public function hasDeployModelDetails()
    {
        return $this->hasOneof(24);
    }

    /**
     * Details of a DeployModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.DeployModelOperationMetadata deploy_model_details = 24;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\DeployModelOperationMetadata $var
     * @return $this
     */
    public function setDeployModelDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\DeployModelOperationMetadata::class);
        $this->writeOneof(24, $var);

        return $this;
    }

    /**
     * Details of an UndeployModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.UndeployModelOperationMetadata undeploy_model_details = 25;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\UndeployModelOperationMetadata|null
     */
    public function getUndeployModelDetails()
    {
        return $this->readOneof(25);
    }

    public function hasUndeployModelDetails()
    {
        return $this->hasOneof(25);
    }

    /**
     * Details of an UndeployModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.UndeployModelOperationMetadata undeploy_model_details = 25;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\UndeployModelOperationMetadata $var
     * @return $this
     */
    public function setUndeployModelDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\UndeployModelOperationMetadata::class);
        $this->writeOneof(25, $var);

        return $this;
    }

    /**
     * Details of CreateModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.CreateModelOperationMetadata create_model_details = 10;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\CreateModelOperationMetadata|null
     */
    public function getCreateModelDetails()
    {
        return $this->readOneof(10);
    }

    public function hasCreateModelDetails()
    {
        return $this->hasOneof(10);
    }

    /**
     * Details of CreateModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.CreateModelOperationMetadata create_model_details = 10;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\CreateModelOperationMetadata $var
     * @return $this
     */
    public function setCreateModelDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\CreateModelOperationMetadata::class);
        $this->writeOneof(10, $var);

        return $this;
    }

    /**
     * Details of ImportData operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ImportDataOperationMetadata import_data_details = 15;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ImportDataOperationMetadata|null
     */
    public function getImportDataDetails()
    {
        return $this->readOneof(15);
    }

    public function hasImportDataDetails()
    {
        return $this->hasOneof(15);
    }

    /**
     * Details of ImportData operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ImportDataOperationMetadata import_data_details = 15;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ImportDataOperationMetadata $var
     * @return $this
     */
    public function setImportDataDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ImportDataOperationMetadata::class);
        $this->writeOneof(15, $var);

        return $this;
    }

    /**
     * Details of BatchPredict operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.BatchPredictOperationMetadata batch_predict_details = 16;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\BatchPredictOperationMetadata|null
     */
    public function getBatchPredictDetails()
    {
        return $this->readOneof(16);
    }

    public function hasBatchPredictDetails()
    {
        return $this->hasOneof(16);
    }

    /**
     * Details of BatchPredict operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.BatchPredictOperationMetadata batch_predict_details = 16;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\BatchPredictOperationMetadata $var
     * @return $this
     */
    public function setBatchPredictDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\BatchPredictOperationMetadata::class);
        $this->writeOneof(16, $var);

        return $this;
    }

    /**
     * Details of ExportData operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportDataOperationMetadata export_data_details = 21;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ExportDataOperationMetadata|null
     */
    public function getExportDataDetails()
    {
        return $this->readOneof(21);
    }

    public function hasExportDataDetails()
    {
        return $this->hasOneof(21);
    }

    /**
     * Details of ExportData operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportDataOperationMetadata export_data_details = 21;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ExportDataOperationMetadata $var
     * @return $this
     */
    public function setExportDataDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ExportDataOperationMetadata::class);
        $this->writeOneof(21, $var);

        return $this;
    }

    /**
     * Details of ExportModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportModelOperationMetadata export_model_details = 22;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ExportModelOperationMetadata|null
     */
    public function getExportModelDetails()
    {
        return $this->readOneof(22);
    }

    public function hasExportModelDetails()
    {
        return $this->hasOneof(22);
    }

    /**
     * Details of ExportModel operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportModelOperationMetadata export_model_details = 22;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ExportModelOperationMetadata $var
     * @return $this
     */
    public function setExportModelDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ExportModelOperationMetadata::class);
        $this->writeOneof(22, $var);

        return $this;
    }

    /**
     * Details of ExportEvaluatedExamples operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata export_evaluated_examples_details = 26;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata|null
     */
    public function getExportEvaluatedExamplesDetails()
    {
        return $this->readOneof(26);
    }

    public function hasExportEvaluatedExamplesDetails()
    {
        return $this->hasOneof(26);
    }

    /**
     * Details of ExportEvaluatedExamples operation.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ExportEvaluatedExamplesOperationMetadata export_evaluated_examples_details = 26;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata $var
     * @return $this
     */
    public function setExportEvaluatedExamplesDetails($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ExportEvaluatedExamplesOperationMetadata::class);
        $this->writeOneof(26, $var);

        return $this;
    }

    /**
     * Output only. Progress of operation. Range: [0, 100].
     * Not used currently.
     *
     * Generated from protobuf field <code>int32 progress_percent = 13;</code>
     * @return int
     */
    public function getProgressPercent()
    {
        return $this->progress_percent;
    }

    /**
     * Output only. Progress of operation. Range: [0, 100].
     * Not used currently.
     *
     * Generated from protobuf field <code>int32 progress_percent = 13;</code>
     * @param int $var
     * @return $this
     */
    public function setProgressPercent($var)
    {
        GPBUtil::checkInt32($var);
        $this->progress_percent = $var;

        return $this;
    }

    /**
     * Output only. Partial failures encountered.
     * E.g. single files that couldn't be read.
     * This field should never exceed 20 entries.
     * Status details field will contain standard GCP error details.
     *
     * Generated from protobuf field <code>repeated .google.rpc.Status partial_failures = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getPartialFailures()
    {
        return $this->partial_failures;
    }

    /**
     * Output only. Partial failures encountered.
     * E.g. single files that couldn't be read.
     * This field should never exceed 20 entries.
     * Status details field will contain standard GCP error details.
     *
     * Generated from protobuf field <code>repeated .google.rpc.Status partial_failures = 2;</code>
     * @param \Google\Rpc\Status[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setPartialFailures($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Rpc\Status::class);
        $this->partial_failures = $arr;

        return $this;
    }

    /**
     * Output only. Time when the operation was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return isset($this->create_time) ? $this->create_time : null;
    }

    public function hasCreateTime()
    {
        return isset($this->create_time);
    }

    public function clearCreateTime()
    {
        unset($this->create_time);
    }

    /**
     * Output only. Time when the operation was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->create_time = $var;

        return $this;
    }

    /**
     * Output only. Time when the operation was updated for the last time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUpdateTime()
    {
        return isset($this->update_time) ? $this->update_time : null;
    }

    public function hasUpdateTime()
    {
        return isset($this->update_time);
    }

    public function clearUpdateTime()
    {
        unset($this->update_time);
    }

    /**
     * Output only. Time when the operation was updated for the last time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 4;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getDetails()
    {
        return $this->whichOneof("details");
    }

}

