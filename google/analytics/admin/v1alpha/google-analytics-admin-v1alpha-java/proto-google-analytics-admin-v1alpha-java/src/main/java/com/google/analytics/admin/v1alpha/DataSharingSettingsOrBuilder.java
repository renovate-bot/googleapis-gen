// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/admin/v1alpha/resources.proto

package com.google.analytics.admin.v1alpha;

public interface DataSharingSettingsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.analytics.admin.v1alpha.DataSharingSettings)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. Resource name.
   * Format: accounts/{account}/dataSharingSettings
   * Example: "accounts/1000/dataSharingSettings"
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Output only. Resource name.
   * Format: accounts/{account}/dataSharingSettings
   * Example: "accounts/1000/dataSharingSettings"
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Allows Google support to access the data in order to help troubleshoot
   * issues.
   * </pre>
   *
   * <code>bool sharing_with_google_support_enabled = 2;</code>
   * @return The sharingWithGoogleSupportEnabled.
   */
  boolean getSharingWithGoogleSupportEnabled();

  /**
   * <pre>
   * Allows Google sales teams that are assigned to the customer to access the
   * data in order to suggest configuration changes to improve results.
   * Sales team restrictions still apply when enabled.
   * </pre>
   *
   * <code>bool sharing_with_google_assigned_sales_enabled = 3;</code>
   * @return The sharingWithGoogleAssignedSalesEnabled.
   */
  boolean getSharingWithGoogleAssignedSalesEnabled();

  /**
   * <pre>
   * Allows any of Google sales to access the data in order to suggest
   * configuration changes to improve results.
   * </pre>
   *
   * <code>bool sharing_with_google_any_sales_enabled = 4;</code>
   * @return The sharingWithGoogleAnySalesEnabled.
   */
  boolean getSharingWithGoogleAnySalesEnabled();

  /**
   * <pre>
   * Allows Google to use the data to improve other Google products or services.
   * </pre>
   *
   * <code>bool sharing_with_google_products_enabled = 5;</code>
   * @return The sharingWithGoogleProductsEnabled.
   */
  boolean getSharingWithGoogleProductsEnabled();

  /**
   * <pre>
   * Allows Google to share the data anonymously in aggregate form with others.
   * </pre>
   *
   * <code>bool sharing_with_others_enabled = 6;</code>
   * @return The sharingWithOthersEnabled.
   */
  boolean getSharingWithOthersEnabled();
}
