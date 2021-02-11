// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/billing/budgets/v1beta1/budget_model.proto

package com.google.cloud.billing.budgets.v1beta1;

public interface BudgetAmountOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.billing.budgets.v1beta1.BudgetAmount)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A specified amount to use as the budget.
   * `currency_code` is optional. If specified when creating a budget, it must
   * match the currency of the billing account. If specified when updating a
   * budget, it must match the existing budget currency_code.
   * The `currency_code` is provided on output.
   * </pre>
   *
   * <code>.google.type.Money specified_amount = 1;</code>
   * @return Whether the specifiedAmount field is set.
   */
  boolean hasSpecifiedAmount();
  /**
   * <pre>
   * A specified amount to use as the budget.
   * `currency_code` is optional. If specified when creating a budget, it must
   * match the currency of the billing account. If specified when updating a
   * budget, it must match the existing budget currency_code.
   * The `currency_code` is provided on output.
   * </pre>
   *
   * <code>.google.type.Money specified_amount = 1;</code>
   * @return The specifiedAmount.
   */
  com.google.type.Money getSpecifiedAmount();
  /**
   * <pre>
   * A specified amount to use as the budget.
   * `currency_code` is optional. If specified when creating a budget, it must
   * match the currency of the billing account. If specified when updating a
   * budget, it must match the existing budget currency_code.
   * The `currency_code` is provided on output.
   * </pre>
   *
   * <code>.google.type.Money specified_amount = 1;</code>
   */
  com.google.type.MoneyOrBuilder getSpecifiedAmountOrBuilder();

  /**
   * <pre>
   * Use the last period's actual spend as the budget for the present period.
   * </pre>
   *
   * <code>.google.cloud.billing.budgets.v1beta1.LastPeriodAmount last_period_amount = 2;</code>
   * @return Whether the lastPeriodAmount field is set.
   */
  boolean hasLastPeriodAmount();
  /**
   * <pre>
   * Use the last period's actual spend as the budget for the present period.
   * </pre>
   *
   * <code>.google.cloud.billing.budgets.v1beta1.LastPeriodAmount last_period_amount = 2;</code>
   * @return The lastPeriodAmount.
   */
  com.google.cloud.billing.budgets.v1beta1.LastPeriodAmount getLastPeriodAmount();
  /**
   * <pre>
   * Use the last period's actual spend as the budget for the present period.
   * </pre>
   *
   * <code>.google.cloud.billing.budgets.v1beta1.LastPeriodAmount last_period_amount = 2;</code>
   */
  com.google.cloud.billing.budgets.v1beta1.LastPeriodAmountOrBuilder getLastPeriodAmountOrBuilder();

  public com.google.cloud.billing.budgets.v1beta1.BudgetAmount.BudgetAmountCase getBudgetAmountCase();
}
