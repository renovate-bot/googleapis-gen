// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/recommendationengine/v1beta1/catalog_service.proto

package com.google.cloud.recommendationengine.v1beta1;

public interface GetCatalogItemRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.recommendationengine.v1beta1.GetCatalogItemRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Full resource name of catalog item, such as
   * `projects/&#42;&#47;locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Full resource name of catalog item, such as
   * `projects/&#42;&#47;locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
