<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/automl/v1beta1/tables.proto

namespace Google\Cloud\AutoMl\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Model metadata specific to AutoML Tables.
 *
 * Generated from protobuf message <code>google.cloud.automl.v1beta1.TablesModelMetadata</code>
 */
class TablesModelMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Column spec of the dataset's primary table's column the model is
     * predicting. Snapshotted when model creation started.
     * Only 3 fields are used:
     * name - May be set on CreateModel, if it's not then the ColumnSpec
     *        corresponding to the current target_column_spec_id of the dataset
     *        the model is trained from is used.
     *        If neither is set, CreateModel will error.
     * display_name - Output only.
     * data_type - Output only.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ColumnSpec target_column_spec = 2;</code>
     */
    protected $target_column_spec = null;
    /**
     * Column specs of the dataset's primary table's columns, on which
     * the model is trained and which are used as the input for predictions.
     * The
     * [target_column][google.cloud.automl.v1beta1.TablesModelMetadata.target_column_spec]
     * as well as, according to dataset's state upon model creation,
     * [weight_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.weight_column_spec_id],
     * and
     * [ml_use_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.ml_use_column_spec_id]
     * must never be included here.
     * Only 3 fields are used:
     * * name - May be set on CreateModel, if set only the columns specified are
     *   used, otherwise all primary table's columns (except the ones listed
     *   above) are used for the training and prediction input.
     * * display_name - Output only.
     * * data_type - Output only.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.ColumnSpec input_feature_column_specs = 3;</code>
     */
    private $input_feature_column_specs;
    /**
     * Objective function the model is optimizing towards. The training process
     * creates a model that maximizes/minimizes the value of the objective
     * function over the validation set.
     * The supported optimization objectives depend on the prediction type.
     * If the field is not set, a default objective function is used.
     * CLASSIFICATION_BINARY:
     *   "MAXIMIZE_AU_ROC" (default) - Maximize the area under the receiver
     *                                 operating characteristic (ROC) curve.
     *   "MINIMIZE_LOG_LOSS" - Minimize log loss.
     *   "MAXIMIZE_AU_PRC" - Maximize the area under the precision-recall curve.
     *   "MAXIMIZE_PRECISION_AT_RECALL" - Maximize precision for a specified
     *                                   recall value.
     *   "MAXIMIZE_RECALL_AT_PRECISION" - Maximize recall for a specified
     *                                    precision value.
     * CLASSIFICATION_MULTI_CLASS :
     *   "MINIMIZE_LOG_LOSS" (default) - Minimize log loss.
     * REGRESSION:
     *   "MINIMIZE_RMSE" (default) - Minimize root-mean-squared error (RMSE).
     *   "MINIMIZE_MAE" - Minimize mean-absolute error (MAE).
     *   "MINIMIZE_RMSLE" - Minimize root-mean-squared log error (RMSLE).
     *
     * Generated from protobuf field <code>string optimization_objective = 4;</code>
     */
    protected $optimization_objective = '';
    /**
     * Output only. Auxiliary information for each of the
     * input_feature_column_specs with respect to this particular model.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.TablesModelColumnInfo tables_model_column_info = 5;</code>
     */
    private $tables_model_column_info;
    /**
     * Required. The train budget of creating this model, expressed in milli node
     * hours i.e. 1,000 value in this field means 1 node hour.
     * The training cost of the model will not exceed this budget. The final cost
     * will be attempted to be close to the budget, though may end up being (even)
     * noticeably smaller - at the backend's discretion. This especially may
     * happen when further model training ceases to provide any improvements.
     * If the budget is set to a value known to be insufficient to train a
     * model for the given dataset, the training won't be attempted and
     * will error.
     * The train budget must be between 1,000 and 72,000 milli node hours,
     * inclusive.
     *
     * Generated from protobuf field <code>int64 train_budget_milli_node_hours = 6;</code>
     */
    protected $train_budget_milli_node_hours = 0;
    /**
     * Output only. The actual training cost of the model, expressed in milli
     * node hours, i.e. 1,000 value in this field means 1 node hour. Guaranteed
     * to not exceed the train budget.
     *
     * Generated from protobuf field <code>int64 train_cost_milli_node_hours = 7;</code>
     */
    protected $train_cost_milli_node_hours = 0;
    /**
     * Use the entire training budget. This disables the early stopping feature.
     * By default, the early stopping feature is enabled, which means that AutoML
     * Tables might stop training before the entire training budget has been used.
     *
     * Generated from protobuf field <code>bool disable_early_stopping = 12;</code>
     */
    protected $disable_early_stopping = false;
    protected $additional_optimization_objective_config;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type float $optimization_objective_recall_value
     *           Required when optimization_objective is "MAXIMIZE_PRECISION_AT_RECALL".
     *           Must be between 0 and 1, inclusive.
     *     @type float $optimization_objective_precision_value
     *           Required when optimization_objective is "MAXIMIZE_RECALL_AT_PRECISION".
     *           Must be between 0 and 1, inclusive.
     *     @type \Google\Cloud\AutoMl\V1beta1\ColumnSpec $target_column_spec
     *           Column spec of the dataset's primary table's column the model is
     *           predicting. Snapshotted when model creation started.
     *           Only 3 fields are used:
     *           name - May be set on CreateModel, if it's not then the ColumnSpec
     *                  corresponding to the current target_column_spec_id of the dataset
     *                  the model is trained from is used.
     *                  If neither is set, CreateModel will error.
     *           display_name - Output only.
     *           data_type - Output only.
     *     @type \Google\Cloud\AutoMl\V1beta1\ColumnSpec[]|\Google\Protobuf\Internal\RepeatedField $input_feature_column_specs
     *           Column specs of the dataset's primary table's columns, on which
     *           the model is trained and which are used as the input for predictions.
     *           The
     *           [target_column][google.cloud.automl.v1beta1.TablesModelMetadata.target_column_spec]
     *           as well as, according to dataset's state upon model creation,
     *           [weight_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.weight_column_spec_id],
     *           and
     *           [ml_use_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.ml_use_column_spec_id]
     *           must never be included here.
     *           Only 3 fields are used:
     *           * name - May be set on CreateModel, if set only the columns specified are
     *             used, otherwise all primary table's columns (except the ones listed
     *             above) are used for the training and prediction input.
     *           * display_name - Output only.
     *           * data_type - Output only.
     *     @type string $optimization_objective
     *           Objective function the model is optimizing towards. The training process
     *           creates a model that maximizes/minimizes the value of the objective
     *           function over the validation set.
     *           The supported optimization objectives depend on the prediction type.
     *           If the field is not set, a default objective function is used.
     *           CLASSIFICATION_BINARY:
     *             "MAXIMIZE_AU_ROC" (default) - Maximize the area under the receiver
     *                                           operating characteristic (ROC) curve.
     *             "MINIMIZE_LOG_LOSS" - Minimize log loss.
     *             "MAXIMIZE_AU_PRC" - Maximize the area under the precision-recall curve.
     *             "MAXIMIZE_PRECISION_AT_RECALL" - Maximize precision for a specified
     *                                             recall value.
     *             "MAXIMIZE_RECALL_AT_PRECISION" - Maximize recall for a specified
     *                                              precision value.
     *           CLASSIFICATION_MULTI_CLASS :
     *             "MINIMIZE_LOG_LOSS" (default) - Minimize log loss.
     *           REGRESSION:
     *             "MINIMIZE_RMSE" (default) - Minimize root-mean-squared error (RMSE).
     *             "MINIMIZE_MAE" - Minimize mean-absolute error (MAE).
     *             "MINIMIZE_RMSLE" - Minimize root-mean-squared log error (RMSLE).
     *     @type \Google\Cloud\AutoMl\V1beta1\TablesModelColumnInfo[]|\Google\Protobuf\Internal\RepeatedField $tables_model_column_info
     *           Output only. Auxiliary information for each of the
     *           input_feature_column_specs with respect to this particular model.
     *     @type int|string $train_budget_milli_node_hours
     *           Required. The train budget of creating this model, expressed in milli node
     *           hours i.e. 1,000 value in this field means 1 node hour.
     *           The training cost of the model will not exceed this budget. The final cost
     *           will be attempted to be close to the budget, though may end up being (even)
     *           noticeably smaller - at the backend's discretion. This especially may
     *           happen when further model training ceases to provide any improvements.
     *           If the budget is set to a value known to be insufficient to train a
     *           model for the given dataset, the training won't be attempted and
     *           will error.
     *           The train budget must be between 1,000 and 72,000 milli node hours,
     *           inclusive.
     *     @type int|string $train_cost_milli_node_hours
     *           Output only. The actual training cost of the model, expressed in milli
     *           node hours, i.e. 1,000 value in this field means 1 node hour. Guaranteed
     *           to not exceed the train budget.
     *     @type bool $disable_early_stopping
     *           Use the entire training budget. This disables the early stopping feature.
     *           By default, the early stopping feature is enabled, which means that AutoML
     *           Tables might stop training before the entire training budget has been used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Automl\V1Beta1\Tables::initOnce();
        parent::__construct($data);
    }

    /**
     * Required when optimization_objective is "MAXIMIZE_PRECISION_AT_RECALL".
     * Must be between 0 and 1, inclusive.
     *
     * Generated from protobuf field <code>float optimization_objective_recall_value = 17;</code>
     * @return float
     */
    public function getOptimizationObjectiveRecallValue()
    {
        return $this->readOneof(17);
    }

    public function hasOptimizationObjectiveRecallValue()
    {
        return $this->hasOneof(17);
    }

    /**
     * Required when optimization_objective is "MAXIMIZE_PRECISION_AT_RECALL".
     * Must be between 0 and 1, inclusive.
     *
     * Generated from protobuf field <code>float optimization_objective_recall_value = 17;</code>
     * @param float $var
     * @return $this
     */
    public function setOptimizationObjectiveRecallValue($var)
    {
        GPBUtil::checkFloat($var);
        $this->writeOneof(17, $var);

        return $this;
    }

    /**
     * Required when optimization_objective is "MAXIMIZE_RECALL_AT_PRECISION".
     * Must be between 0 and 1, inclusive.
     *
     * Generated from protobuf field <code>float optimization_objective_precision_value = 18;</code>
     * @return float
     */
    public function getOptimizationObjectivePrecisionValue()
    {
        return $this->readOneof(18);
    }

    public function hasOptimizationObjectivePrecisionValue()
    {
        return $this->hasOneof(18);
    }

    /**
     * Required when optimization_objective is "MAXIMIZE_RECALL_AT_PRECISION".
     * Must be between 0 and 1, inclusive.
     *
     * Generated from protobuf field <code>float optimization_objective_precision_value = 18;</code>
     * @param float $var
     * @return $this
     */
    public function setOptimizationObjectivePrecisionValue($var)
    {
        GPBUtil::checkFloat($var);
        $this->writeOneof(18, $var);

        return $this;
    }

    /**
     * Column spec of the dataset's primary table's column the model is
     * predicting. Snapshotted when model creation started.
     * Only 3 fields are used:
     * name - May be set on CreateModel, if it's not then the ColumnSpec
     *        corresponding to the current target_column_spec_id of the dataset
     *        the model is trained from is used.
     *        If neither is set, CreateModel will error.
     * display_name - Output only.
     * data_type - Output only.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ColumnSpec target_column_spec = 2;</code>
     * @return \Google\Cloud\AutoMl\V1beta1\ColumnSpec|null
     */
    public function getTargetColumnSpec()
    {
        return isset($this->target_column_spec) ? $this->target_column_spec : null;
    }

    public function hasTargetColumnSpec()
    {
        return isset($this->target_column_spec);
    }

    public function clearTargetColumnSpec()
    {
        unset($this->target_column_spec);
    }

    /**
     * Column spec of the dataset's primary table's column the model is
     * predicting. Snapshotted when model creation started.
     * Only 3 fields are used:
     * name - May be set on CreateModel, if it's not then the ColumnSpec
     *        corresponding to the current target_column_spec_id of the dataset
     *        the model is trained from is used.
     *        If neither is set, CreateModel will error.
     * display_name - Output only.
     * data_type - Output only.
     *
     * Generated from protobuf field <code>.google.cloud.automl.v1beta1.ColumnSpec target_column_spec = 2;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ColumnSpec $var
     * @return $this
     */
    public function setTargetColumnSpec($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\AutoMl\V1beta1\ColumnSpec::class);
        $this->target_column_spec = $var;

        return $this;
    }

    /**
     * Column specs of the dataset's primary table's columns, on which
     * the model is trained and which are used as the input for predictions.
     * The
     * [target_column][google.cloud.automl.v1beta1.TablesModelMetadata.target_column_spec]
     * as well as, according to dataset's state upon model creation,
     * [weight_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.weight_column_spec_id],
     * and
     * [ml_use_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.ml_use_column_spec_id]
     * must never be included here.
     * Only 3 fields are used:
     * * name - May be set on CreateModel, if set only the columns specified are
     *   used, otherwise all primary table's columns (except the ones listed
     *   above) are used for the training and prediction input.
     * * display_name - Output only.
     * * data_type - Output only.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.ColumnSpec input_feature_column_specs = 3;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getInputFeatureColumnSpecs()
    {
        return $this->input_feature_column_specs;
    }

    /**
     * Column specs of the dataset's primary table's columns, on which
     * the model is trained and which are used as the input for predictions.
     * The
     * [target_column][google.cloud.automl.v1beta1.TablesModelMetadata.target_column_spec]
     * as well as, according to dataset's state upon model creation,
     * [weight_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.weight_column_spec_id],
     * and
     * [ml_use_column][google.cloud.automl.v1beta1.TablesDatasetMetadata.ml_use_column_spec_id]
     * must never be included here.
     * Only 3 fields are used:
     * * name - May be set on CreateModel, if set only the columns specified are
     *   used, otherwise all primary table's columns (except the ones listed
     *   above) are used for the training and prediction input.
     * * display_name - Output only.
     * * data_type - Output only.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.ColumnSpec input_feature_column_specs = 3;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\ColumnSpec[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setInputFeatureColumnSpecs($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\AutoMl\V1beta1\ColumnSpec::class);
        $this->input_feature_column_specs = $arr;

        return $this;
    }

    /**
     * Objective function the model is optimizing towards. The training process
     * creates a model that maximizes/minimizes the value of the objective
     * function over the validation set.
     * The supported optimization objectives depend on the prediction type.
     * If the field is not set, a default objective function is used.
     * CLASSIFICATION_BINARY:
     *   "MAXIMIZE_AU_ROC" (default) - Maximize the area under the receiver
     *                                 operating characteristic (ROC) curve.
     *   "MINIMIZE_LOG_LOSS" - Minimize log loss.
     *   "MAXIMIZE_AU_PRC" - Maximize the area under the precision-recall curve.
     *   "MAXIMIZE_PRECISION_AT_RECALL" - Maximize precision for a specified
     *                                   recall value.
     *   "MAXIMIZE_RECALL_AT_PRECISION" - Maximize recall for a specified
     *                                    precision value.
     * CLASSIFICATION_MULTI_CLASS :
     *   "MINIMIZE_LOG_LOSS" (default) - Minimize log loss.
     * REGRESSION:
     *   "MINIMIZE_RMSE" (default) - Minimize root-mean-squared error (RMSE).
     *   "MINIMIZE_MAE" - Minimize mean-absolute error (MAE).
     *   "MINIMIZE_RMSLE" - Minimize root-mean-squared log error (RMSLE).
     *
     * Generated from protobuf field <code>string optimization_objective = 4;</code>
     * @return string
     */
    public function getOptimizationObjective()
    {
        return $this->optimization_objective;
    }

    /**
     * Objective function the model is optimizing towards. The training process
     * creates a model that maximizes/minimizes the value of the objective
     * function over the validation set.
     * The supported optimization objectives depend on the prediction type.
     * If the field is not set, a default objective function is used.
     * CLASSIFICATION_BINARY:
     *   "MAXIMIZE_AU_ROC" (default) - Maximize the area under the receiver
     *                                 operating characteristic (ROC) curve.
     *   "MINIMIZE_LOG_LOSS" - Minimize log loss.
     *   "MAXIMIZE_AU_PRC" - Maximize the area under the precision-recall curve.
     *   "MAXIMIZE_PRECISION_AT_RECALL" - Maximize precision for a specified
     *                                   recall value.
     *   "MAXIMIZE_RECALL_AT_PRECISION" - Maximize recall for a specified
     *                                    precision value.
     * CLASSIFICATION_MULTI_CLASS :
     *   "MINIMIZE_LOG_LOSS" (default) - Minimize log loss.
     * REGRESSION:
     *   "MINIMIZE_RMSE" (default) - Minimize root-mean-squared error (RMSE).
     *   "MINIMIZE_MAE" - Minimize mean-absolute error (MAE).
     *   "MINIMIZE_RMSLE" - Minimize root-mean-squared log error (RMSLE).
     *
     * Generated from protobuf field <code>string optimization_objective = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setOptimizationObjective($var)
    {
        GPBUtil::checkString($var, True);
        $this->optimization_objective = $var;

        return $this;
    }

    /**
     * Output only. Auxiliary information for each of the
     * input_feature_column_specs with respect to this particular model.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.TablesModelColumnInfo tables_model_column_info = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTablesModelColumnInfo()
    {
        return $this->tables_model_column_info;
    }

    /**
     * Output only. Auxiliary information for each of the
     * input_feature_column_specs with respect to this particular model.
     *
     * Generated from protobuf field <code>repeated .google.cloud.automl.v1beta1.TablesModelColumnInfo tables_model_column_info = 5;</code>
     * @param \Google\Cloud\AutoMl\V1beta1\TablesModelColumnInfo[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTablesModelColumnInfo($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\AutoMl\V1beta1\TablesModelColumnInfo::class);
        $this->tables_model_column_info = $arr;

        return $this;
    }

    /**
     * Required. The train budget of creating this model, expressed in milli node
     * hours i.e. 1,000 value in this field means 1 node hour.
     * The training cost of the model will not exceed this budget. The final cost
     * will be attempted to be close to the budget, though may end up being (even)
     * noticeably smaller - at the backend's discretion. This especially may
     * happen when further model training ceases to provide any improvements.
     * If the budget is set to a value known to be insufficient to train a
     * model for the given dataset, the training won't be attempted and
     * will error.
     * The train budget must be between 1,000 and 72,000 milli node hours,
     * inclusive.
     *
     * Generated from protobuf field <code>int64 train_budget_milli_node_hours = 6;</code>
     * @return int|string
     */
    public function getTrainBudgetMilliNodeHours()
    {
        return $this->train_budget_milli_node_hours;
    }

    /**
     * Required. The train budget of creating this model, expressed in milli node
     * hours i.e. 1,000 value in this field means 1 node hour.
     * The training cost of the model will not exceed this budget. The final cost
     * will be attempted to be close to the budget, though may end up being (even)
     * noticeably smaller - at the backend's discretion. This especially may
     * happen when further model training ceases to provide any improvements.
     * If the budget is set to a value known to be insufficient to train a
     * model for the given dataset, the training won't be attempted and
     * will error.
     * The train budget must be between 1,000 and 72,000 milli node hours,
     * inclusive.
     *
     * Generated from protobuf field <code>int64 train_budget_milli_node_hours = 6;</code>
     * @param int|string $var
     * @return $this
     */
    public function setTrainBudgetMilliNodeHours($var)
    {
        GPBUtil::checkInt64($var);
        $this->train_budget_milli_node_hours = $var;

        return $this;
    }

    /**
     * Output only. The actual training cost of the model, expressed in milli
     * node hours, i.e. 1,000 value in this field means 1 node hour. Guaranteed
     * to not exceed the train budget.
     *
     * Generated from protobuf field <code>int64 train_cost_milli_node_hours = 7;</code>
     * @return int|string
     */
    public function getTrainCostMilliNodeHours()
    {
        return $this->train_cost_milli_node_hours;
    }

    /**
     * Output only. The actual training cost of the model, expressed in milli
     * node hours, i.e. 1,000 value in this field means 1 node hour. Guaranteed
     * to not exceed the train budget.
     *
     * Generated from protobuf field <code>int64 train_cost_milli_node_hours = 7;</code>
     * @param int|string $var
     * @return $this
     */
    public function setTrainCostMilliNodeHours($var)
    {
        GPBUtil::checkInt64($var);
        $this->train_cost_milli_node_hours = $var;

        return $this;
    }

    /**
     * Use the entire training budget. This disables the early stopping feature.
     * By default, the early stopping feature is enabled, which means that AutoML
     * Tables might stop training before the entire training budget has been used.
     *
     * Generated from protobuf field <code>bool disable_early_stopping = 12;</code>
     * @return bool
     */
    public function getDisableEarlyStopping()
    {
        return $this->disable_early_stopping;
    }

    /**
     * Use the entire training budget. This disables the early stopping feature.
     * By default, the early stopping feature is enabled, which means that AutoML
     * Tables might stop training before the entire training budget has been used.
     *
     * Generated from protobuf field <code>bool disable_early_stopping = 12;</code>
     * @param bool $var
     * @return $this
     */
    public function setDisableEarlyStopping($var)
    {
        GPBUtil::checkBool($var);
        $this->disable_early_stopping = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getAdditionalOptimizationObjectiveConfig()
    {
        return $this->whichOneof("additional_optimization_objective_config");
    }

}

