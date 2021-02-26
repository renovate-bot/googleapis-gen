// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v5/services/keyword_plan_campaign_keyword_service.proto

package com.google.ads.googleads.v5.services;

public interface KeywordPlanCampaignKeywordOperationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.ads.googleads.v5.services.KeywordPlanCampaignKeywordOperation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The FieldMask that determines which resource fields are modified in an
   * update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * The FieldMask that determines which resource fields are modified in an
   * update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * The FieldMask that determines which resource fields are modified in an
   * update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();

  /**
   * <pre>
   * Create operation: No resource name is expected for the new Keyword Plan
   * campaign keyword.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword create = 1;</code>
   * @return Whether the create field is set.
   */
  boolean hasCreate();
  /**
   * <pre>
   * Create operation: No resource name is expected for the new Keyword Plan
   * campaign keyword.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword create = 1;</code>
   * @return The create.
   */
  com.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword getCreate();
  /**
   * <pre>
   * Create operation: No resource name is expected for the new Keyword Plan
   * campaign keyword.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword create = 1;</code>
   */
  com.google.ads.googleads.v5.resources.KeywordPlanCampaignKeywordOrBuilder getCreateOrBuilder();

  /**
   * <pre>
   * Update operation: The Keyword Plan campaign keyword expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword update = 2;</code>
   * @return Whether the update field is set.
   */
  boolean hasUpdate();
  /**
   * <pre>
   * Update operation: The Keyword Plan campaign keyword expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword update = 2;</code>
   * @return The update.
   */
  com.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword getUpdate();
  /**
   * <pre>
   * Update operation: The Keyword Plan campaign keyword expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword update = 2;</code>
   */
  com.google.ads.googleads.v5.resources.KeywordPlanCampaignKeywordOrBuilder getUpdateOrBuilder();

  /**
   * <pre>
   * Remove operation: A resource name for the removed Keyword Plan campaign
   * keywords expected in this format:
   * `customers/{customer_id}/keywordPlanCampaignKeywords/{kp_campaign_keyword_id}`
   * </pre>
   *
   * <code>string remove = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return Whether the remove field is set.
   */
  boolean hasRemove();
  /**
   * <pre>
   * Remove operation: A resource name for the removed Keyword Plan campaign
   * keywords expected in this format:
   * `customers/{customer_id}/keywordPlanCampaignKeywords/{kp_campaign_keyword_id}`
   * </pre>
   *
   * <code>string remove = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return The remove.
   */
  java.lang.String getRemove();
  /**
   * <pre>
   * Remove operation: A resource name for the removed Keyword Plan campaign
   * keywords expected in this format:
   * `customers/{customer_id}/keywordPlanCampaignKeywords/{kp_campaign_keyword_id}`
   * </pre>
   *
   * <code>string remove = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return The bytes for remove.
   */
  com.google.protobuf.ByteString
      getRemoveBytes();

  public com.google.ads.googleads.v5.services.KeywordPlanCampaignKeywordOperation.OperationCase getOperationCase();
}
