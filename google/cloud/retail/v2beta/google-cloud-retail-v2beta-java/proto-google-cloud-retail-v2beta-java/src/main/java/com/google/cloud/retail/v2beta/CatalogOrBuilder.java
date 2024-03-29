// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/retail/v2beta/catalog.proto

package com.google.cloud.retail.v2beta;

public interface CatalogOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.retail.v2beta.Catalog)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Immutable. The fully qualified resource name of the catalog.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Immutable. The fully qualified resource name of the catalog.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Required. Immutable. The catalog display name.
   * This field must be a UTF-8 encoded string with a length limit of 128
   * characters. Otherwise, an INVALID_ARGUMENT error is returned.
   * </pre>
   *
   * <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * Required. Immutable. The catalog display name.
   * This field must be a UTF-8 encoded string with a length limit of 128
   * characters. Otherwise, an INVALID_ARGUMENT error is returned.
   * </pre>
   *
   * <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * Required. The product level configuration.
   * </pre>
   *
   * <code>.google.cloud.retail.v2beta.ProductLevelConfig product_level_config = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the productLevelConfig field is set.
   */
  boolean hasProductLevelConfig();
  /**
   * <pre>
   * Required. The product level configuration.
   * </pre>
   *
   * <code>.google.cloud.retail.v2beta.ProductLevelConfig product_level_config = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The productLevelConfig.
   */
  com.google.cloud.retail.v2beta.ProductLevelConfig getProductLevelConfig();
  /**
   * <pre>
   * Required. The product level configuration.
   * </pre>
   *
   * <code>.google.cloud.retail.v2beta.ProductLevelConfig product_level_config = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.retail.v2beta.ProductLevelConfigOrBuilder getProductLevelConfigOrBuilder();
}
