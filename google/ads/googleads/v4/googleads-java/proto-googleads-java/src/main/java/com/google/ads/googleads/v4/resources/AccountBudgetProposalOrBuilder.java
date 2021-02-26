// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v4/resources/account_budget_proposal.proto

package com.google.ads.googleads.v4.resources;

public interface AccountBudgetProposalOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.ads.googleads.v4.resources.AccountBudgetProposal)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Immutable. The resource name of the proposal.
   * AccountBudgetProposal resource names have the form:
   * `customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}`
   * </pre>
   *
   * <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return The resourceName.
   */
  java.lang.String getResourceName();
  /**
   * <pre>
   * Immutable. The resource name of the proposal.
   * AccountBudgetProposal resource names have the form:
   * `customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}`
   * </pre>
   *
   * <code>string resource_name = 1 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for resourceName.
   */
  com.google.protobuf.ByteString
      getResourceNameBytes();

  /**
   * <pre>
   * Output only. The ID of the proposal.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value id = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the id field is set.
   */
  boolean hasId();
  /**
   * <pre>
   * Output only. The ID of the proposal.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value id = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The id.
   */
  com.google.protobuf.Int64Value getId();
  /**
   * <pre>
   * Output only. The ID of the proposal.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value id = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.Int64ValueOrBuilder getIdOrBuilder();

  /**
   * <pre>
   * Immutable. The resource name of the billing setup associated with this proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue billing_setup = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return Whether the billingSetup field is set.
   */
  boolean hasBillingSetup();
  /**
   * <pre>
   * Immutable. The resource name of the billing setup associated with this proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue billing_setup = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return The billingSetup.
   */
  com.google.protobuf.StringValue getBillingSetup();
  /**
   * <pre>
   * Immutable. The resource name of the billing setup associated with this proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue billing_setup = 2 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   */
  com.google.protobuf.StringValueOrBuilder getBillingSetupOrBuilder();

  /**
   * <pre>
   * Immutable. The resource name of the account-level budget associated with this
   * proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue account_budget = 3 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return Whether the accountBudget field is set.
   */
  boolean hasAccountBudget();
  /**
   * <pre>
   * Immutable. The resource name of the account-level budget associated with this
   * proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue account_budget = 3 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   * @return The accountBudget.
   */
  com.google.protobuf.StringValue getAccountBudget();
  /**
   * <pre>
   * Immutable. The resource name of the account-level budget associated with this
   * proposal.
   * </pre>
   *
   * <code>.google.protobuf.StringValue account_budget = 3 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = { ... }</code>
   */
  com.google.protobuf.StringValueOrBuilder getAccountBudgetOrBuilder();

  /**
   * <pre>
   * Immutable. The type of this proposal, e.g. END to end the budget associated with this
   * proposal.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalType proposal_type = 4 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The enum numeric value on the wire for proposalType.
   */
  int getProposalTypeValue();
  /**
   * <pre>
   * Immutable. The type of this proposal, e.g. END to end the budget associated with this
   * proposal.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalType proposal_type = 4 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposalType.
   */
  com.google.ads.googleads.v4.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalType getProposalType();

  /**
   * <pre>
   * Output only. The status of this proposal.
   * When a new proposal is created, the status defaults to PENDING.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.AccountBudgetProposalStatusEnum.AccountBudgetProposalStatus status = 15 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The enum numeric value on the wire for status.
   */
  int getStatusValue();
  /**
   * <pre>
   * Output only. The status of this proposal.
   * When a new proposal is created, the status defaults to PENDING.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.AccountBudgetProposalStatusEnum.AccountBudgetProposalStatus status = 15 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The status.
   */
  com.google.ads.googleads.v4.enums.AccountBudgetProposalStatusEnum.AccountBudgetProposalStatus getStatus();

  /**
   * <pre>
   * Immutable. The name to assign to the account-level budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_name = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedName field is set.
   */
  boolean hasProposedName();
  /**
   * <pre>
   * Immutable. The name to assign to the account-level budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_name = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedName.
   */
  com.google.protobuf.StringValue getProposedName();
  /**
   * <pre>
   * Immutable. The name to assign to the account-level budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_name = 5 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.StringValueOrBuilder getProposedNameOrBuilder();

  /**
   * <pre>
   * Output only. The approved start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_start_date_time = 20 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvedStartDateTime field is set.
   */
  boolean hasApprovedStartDateTime();
  /**
   * <pre>
   * Output only. The approved start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_start_date_time = 20 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvedStartDateTime.
   */
  com.google.protobuf.StringValue getApprovedStartDateTime();
  /**
   * <pre>
   * Output only. The approved start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_start_date_time = 20 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.StringValueOrBuilder getApprovedStartDateTimeOrBuilder();

  /**
   * <pre>
   * Immutable. A purchase order number is a value that enables the user to help them
   * reference this budget in their monthly invoices.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_purchase_order_number = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedPurchaseOrderNumber field is set.
   */
  boolean hasProposedPurchaseOrderNumber();
  /**
   * <pre>
   * Immutable. A purchase order number is a value that enables the user to help them
   * reference this budget in their monthly invoices.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_purchase_order_number = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedPurchaseOrderNumber.
   */
  com.google.protobuf.StringValue getProposedPurchaseOrderNumber();
  /**
   * <pre>
   * Immutable. A purchase order number is a value that enables the user to help them
   * reference this budget in their monthly invoices.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_purchase_order_number = 12 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.StringValueOrBuilder getProposedPurchaseOrderNumberOrBuilder();

  /**
   * <pre>
   * Immutable. Notes associated with this budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_notes = 13 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedNotes field is set.
   */
  boolean hasProposedNotes();
  /**
   * <pre>
   * Immutable. Notes associated with this budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_notes = 13 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedNotes.
   */
  com.google.protobuf.StringValue getProposedNotes();
  /**
   * <pre>
   * Immutable. Notes associated with this budget.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_notes = 13 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.StringValueOrBuilder getProposedNotesOrBuilder();

  /**
   * <pre>
   * Output only. The date time when this account-level budget proposal was created, which is
   * not the same as its approval date time, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue creation_date_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the creationDateTime field is set.
   */
  boolean hasCreationDateTime();
  /**
   * <pre>
   * Output only. The date time when this account-level budget proposal was created, which is
   * not the same as its approval date time, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue creation_date_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The creationDateTime.
   */
  com.google.protobuf.StringValue getCreationDateTime();
  /**
   * <pre>
   * Output only. The date time when this account-level budget proposal was created, which is
   * not the same as its approval date time, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue creation_date_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.StringValueOrBuilder getCreationDateTimeOrBuilder();

  /**
   * <pre>
   * Output only. The date time when this account-level budget was approved, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approval_date_time = 17 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvalDateTime field is set.
   */
  boolean hasApprovalDateTime();
  /**
   * <pre>
   * Output only. The date time when this account-level budget was approved, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approval_date_time = 17 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvalDateTime.
   */
  com.google.protobuf.StringValue getApprovalDateTime();
  /**
   * <pre>
   * Output only. The date time when this account-level budget was approved, if applicable.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approval_date_time = 17 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.StringValueOrBuilder getApprovalDateTimeOrBuilder();

  /**
   * <pre>
   * Immutable. The proposed start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_start_date_time = 18 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedStartDateTime field is set.
   */
  boolean hasProposedStartDateTime();
  /**
   * <pre>
   * Immutable. The proposed start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_start_date_time = 18 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedStartDateTime.
   */
  com.google.protobuf.StringValue getProposedStartDateTime();
  /**
   * <pre>
   * Immutable. The proposed start date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_start_date_time = 18 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.StringValueOrBuilder getProposedStartDateTimeOrBuilder();

  /**
   * <pre>
   * Immutable. The proposed start date time as a well-defined type, e.g. NOW.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_start_time_type = 7 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedStartTimeType field is set.
   */
  boolean hasProposedStartTimeType();
  /**
   * <pre>
   * Immutable. The proposed start date time as a well-defined type, e.g. NOW.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_start_time_type = 7 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The enum numeric value on the wire for proposedStartTimeType.
   */
  int getProposedStartTimeTypeValue();
  /**
   * <pre>
   * Immutable. The proposed start date time as a well-defined type, e.g. NOW.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_start_time_type = 7 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedStartTimeType.
   */
  com.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType getProposedStartTimeType();

  /**
   * <pre>
   * Immutable. The proposed end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_end_date_time = 19 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedEndDateTime field is set.
   */
  boolean hasProposedEndDateTime();
  /**
   * <pre>
   * Immutable. The proposed end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_end_date_time = 19 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedEndDateTime.
   */
  com.google.protobuf.StringValue getProposedEndDateTime();
  /**
   * <pre>
   * Immutable. The proposed end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue proposed_end_date_time = 19 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.StringValueOrBuilder getProposedEndDateTimeOrBuilder();

  /**
   * <pre>
   * Immutable. The proposed end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_end_time_type = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedEndTimeType field is set.
   */
  boolean hasProposedEndTimeType();
  /**
   * <pre>
   * Immutable. The proposed end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_end_time_type = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The enum numeric value on the wire for proposedEndTimeType.
   */
  int getProposedEndTimeTypeValue();
  /**
   * <pre>
   * Immutable. The proposed end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType proposed_end_time_type = 9 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedEndTimeType.
   */
  com.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType getProposedEndTimeType();

  /**
   * <pre>
   * Output only. The approved end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_end_date_time = 21 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvedEndDateTime field is set.
   */
  boolean hasApprovedEndDateTime();
  /**
   * <pre>
   * Output only. The approved end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_end_date_time = 21 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvedEndDateTime.
   */
  com.google.protobuf.StringValue getApprovedEndDateTime();
  /**
   * <pre>
   * Output only. The approved end date time in yyyy-mm-dd hh:mm:ss format.
   * </pre>
   *
   * <code>.google.protobuf.StringValue approved_end_date_time = 21 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.StringValueOrBuilder getApprovedEndDateTimeOrBuilder();

  /**
   * <pre>
   * Output only. The approved end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType approved_end_time_type = 22 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvedEndTimeType field is set.
   */
  boolean hasApprovedEndTimeType();
  /**
   * <pre>
   * Output only. The approved end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType approved_end_time_type = 22 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The enum numeric value on the wire for approvedEndTimeType.
   */
  int getApprovedEndTimeTypeValue();
  /**
   * <pre>
   * Output only. The approved end date time as a well-defined type, e.g. FOREVER.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType approved_end_time_type = 22 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvedEndTimeType.
   */
  com.google.ads.googleads.v4.enums.TimeTypeEnum.TimeType getApprovedEndTimeType();

  /**
   * <pre>
   * Immutable. The proposed spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value proposed_spending_limit_micros = 10 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedSpendingLimitMicros field is set.
   */
  boolean hasProposedSpendingLimitMicros();
  /**
   * <pre>
   * Immutable. The proposed spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value proposed_spending_limit_micros = 10 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedSpendingLimitMicros.
   */
  com.google.protobuf.Int64Value getProposedSpendingLimitMicros();
  /**
   * <pre>
   * Immutable. The proposed spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value proposed_spending_limit_micros = 10 [(.google.api.field_behavior) = IMMUTABLE];</code>
   */
  com.google.protobuf.Int64ValueOrBuilder getProposedSpendingLimitMicrosOrBuilder();

  /**
   * <pre>
   * Immutable. The proposed spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType proposed_spending_limit_type = 11 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return Whether the proposedSpendingLimitType field is set.
   */
  boolean hasProposedSpendingLimitType();
  /**
   * <pre>
   * Immutable. The proposed spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType proposed_spending_limit_type = 11 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The enum numeric value on the wire for proposedSpendingLimitType.
   */
  int getProposedSpendingLimitTypeValue();
  /**
   * <pre>
   * Immutable. The proposed spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType proposed_spending_limit_type = 11 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The proposedSpendingLimitType.
   */
  com.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType getProposedSpendingLimitType();

  /**
   * <pre>
   * Output only. The approved spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value approved_spending_limit_micros = 23 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvedSpendingLimitMicros field is set.
   */
  boolean hasApprovedSpendingLimitMicros();
  /**
   * <pre>
   * Output only. The approved spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value approved_spending_limit_micros = 23 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvedSpendingLimitMicros.
   */
  com.google.protobuf.Int64Value getApprovedSpendingLimitMicros();
  /**
   * <pre>
   * Output only. The approved spending limit in micros.  One million is equivalent to
   * one unit.
   * </pre>
   *
   * <code>.google.protobuf.Int64Value approved_spending_limit_micros = 23 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.Int64ValueOrBuilder getApprovedSpendingLimitMicrosOrBuilder();

  /**
   * <pre>
   * Output only. The approved spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType approved_spending_limit_type = 24 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the approvedSpendingLimitType field is set.
   */
  boolean hasApprovedSpendingLimitType();
  /**
   * <pre>
   * Output only. The approved spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType approved_spending_limit_type = 24 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The enum numeric value on the wire for approvedSpendingLimitType.
   */
  int getApprovedSpendingLimitTypeValue();
  /**
   * <pre>
   * Output only. The approved spending limit as a well-defined type, e.g. INFINITE.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType approved_spending_limit_type = 24 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The approvedSpendingLimitType.
   */
  com.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitType getApprovedSpendingLimitType();

  public com.google.ads.googleads.v4.resources.AccountBudgetProposal.ProposedStartTimeCase getProposedStartTimeCase();

  public com.google.ads.googleads.v4.resources.AccountBudgetProposal.ProposedEndTimeCase getProposedEndTimeCase();

  public com.google.ads.googleads.v4.resources.AccountBudgetProposal.ApprovedEndTimeCase getApprovedEndTimeCase();

  public com.google.ads.googleads.v4.resources.AccountBudgetProposal.ProposedSpendingLimitCase getProposedSpendingLimitCase();

  public com.google.ads.googleads.v4.resources.AccountBudgetProposal.ApprovedSpendingLimitCase getApprovedSpendingLimitCase();
}
