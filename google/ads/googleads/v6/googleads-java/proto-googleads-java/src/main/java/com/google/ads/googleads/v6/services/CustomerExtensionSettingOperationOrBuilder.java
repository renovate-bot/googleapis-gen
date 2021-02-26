// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v6/services/customer_extension_setting_service.proto

package com.google.ads.googleads.v6.services;

public interface CustomerExtensionSettingOperationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.ads.googleads.v6.services.CustomerExtensionSettingOperation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * FieldMask that determines which resource fields are modified in an update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * FieldMask that determines which resource fields are modified in an update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * FieldMask that determines which resource fields are modified in an update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 4;</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();

  /**
   * <pre>
   * Create operation: No resource name is expected for the new customer
   * extension setting.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting create = 1;</code>
   * @return Whether the create field is set.
   */
  boolean hasCreate();
  /**
   * <pre>
   * Create operation: No resource name is expected for the new customer
   * extension setting.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting create = 1;</code>
   * @return The create.
   */
  com.google.ads.googleads.v6.resources.CustomerExtensionSetting getCreate();
  /**
   * <pre>
   * Create operation: No resource name is expected for the new customer
   * extension setting.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting create = 1;</code>
   */
  com.google.ads.googleads.v6.resources.CustomerExtensionSettingOrBuilder getCreateOrBuilder();

  /**
   * <pre>
   * Update operation: The customer extension setting is expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting update = 2;</code>
   * @return Whether the update field is set.
   */
  boolean hasUpdate();
  /**
   * <pre>
   * Update operation: The customer extension setting is expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting update = 2;</code>
   * @return The update.
   */
  com.google.ads.googleads.v6.resources.CustomerExtensionSetting getUpdate();
  /**
   * <pre>
   * Update operation: The customer extension setting is expected to have a
   * valid resource name.
   * </pre>
   *
   * <code>.google.ads.googleads.v6.resources.CustomerExtensionSetting update = 2;</code>
   */
  com.google.ads.googleads.v6.resources.CustomerExtensionSettingOrBuilder getUpdateOrBuilder();

  /**
   * <pre>
   * Remove operation: A resource name for the removed customer extension
   * setting is expected, in this format:
   * `customers/{customer_id}/customerExtensionSettings/{extension_type}`
   * </pre>
   *
   * <code>string remove = 3;</code>
   * @return Whether the remove field is set.
   */
  boolean hasRemove();
  /**
   * <pre>
   * Remove operation: A resource name for the removed customer extension
   * setting is expected, in this format:
   * `customers/{customer_id}/customerExtensionSettings/{extension_type}`
   * </pre>
   *
   * <code>string remove = 3;</code>
   * @return The remove.
   */
  java.lang.String getRemove();
  /**
   * <pre>
   * Remove operation: A resource name for the removed customer extension
   * setting is expected, in this format:
   * `customers/{customer_id}/customerExtensionSettings/{extension_type}`
   * </pre>
   *
   * <code>string remove = 3;</code>
   * @return The bytes for remove.
   */
  com.google.protobuf.ByteString
      getRemoveBytes();

  public com.google.ads.googleads.v6.services.CustomerExtensionSettingOperation.OperationCase getOperationCase();
}
