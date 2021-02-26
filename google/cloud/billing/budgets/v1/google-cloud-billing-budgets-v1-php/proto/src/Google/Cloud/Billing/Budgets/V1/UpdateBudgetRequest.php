<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/billing/budgets/v1/budget_service.proto

namespace Google\Cloud\Billing\Budgets\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request for UpdateBudget
 *
 * Generated from protobuf message <code>google.cloud.billing.budgets.v1.UpdateBudgetRequest</code>
 */
class UpdateBudgetRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The updated budget object.
     * The budget to update is specified by the budget name in the budget.
     *
     * Generated from protobuf field <code>.google.cloud.billing.budgets.v1.Budget budget = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $budget = null;
    /**
     * Optional. Indicates which fields in the provided budget to update.
     * Read-only fields (such as `name`) cannot be changed. If this is not
     * provided, then only fields with non-default values from the request are
     * updated. See
     * https://developers.google.com/protocol-buffers/docs/proto3#default for more
     * details about default values.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Billing\Budgets\V1\Budget $budget
     *           Required. The updated budget object.
     *           The budget to update is specified by the budget name in the budget.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Optional. Indicates which fields in the provided budget to update.
     *           Read-only fields (such as `name`) cannot be changed. If this is not
     *           provided, then only fields with non-default values from the request are
     *           updated. See
     *           https://developers.google.com/protocol-buffers/docs/proto3#default for more
     *           details about default values.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Billing\Budgets\V1\BudgetService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The updated budget object.
     * The budget to update is specified by the budget name in the budget.
     *
     * Generated from protobuf field <code>.google.cloud.billing.budgets.v1.Budget budget = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Billing\Budgets\V1\Budget|null
     */
    public function getBudget()
    {
        return isset($this->budget) ? $this->budget : null;
    }

    public function hasBudget()
    {
        return isset($this->budget);
    }

    public function clearBudget()
    {
        unset($this->budget);
    }

    /**
     * Required. The updated budget object.
     * The budget to update is specified by the budget name in the budget.
     *
     * Generated from protobuf field <code>.google.cloud.billing.budgets.v1.Budget budget = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Billing\Budgets\V1\Budget $var
     * @return $this
     */
    public function setBudget($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Billing\Budgets\V1\Budget::class);
        $this->budget = $var;

        return $this;
    }

    /**
     * Optional. Indicates which fields in the provided budget to update.
     * Read-only fields (such as `name`) cannot be changed. If this is not
     * provided, then only fields with non-default values from the request are
     * updated. See
     * https://developers.google.com/protocol-buffers/docs/proto3#default for more
     * details about default values.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Optional. Indicates which fields in the provided budget to update.
     * Read-only fields (such as `name`) cannot be changed. If this is not
     * provided, then only fields with non-default values from the request are
     * updated. See
     * https://developers.google.com/protocol-buffers/docs/proto3#default for more
     * details about default values.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

