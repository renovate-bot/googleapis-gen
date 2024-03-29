// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/featurestore_service.proto

package com.google.cloud.aiplatform.v1;

public interface ImportFeatureValuesResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.ImportFeatureValuesResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Number of entities that have been imported by the operation.
   * </pre>
   *
   * <code>int64 imported_entity_count = 1;</code>
   * @return The importedEntityCount.
   */
  long getImportedEntityCount();

  /**
   * <pre>
   * Number of Feature values that have been imported by the operation.
   * </pre>
   *
   * <code>int64 imported_feature_value_count = 2;</code>
   * @return The importedFeatureValueCount.
   */
  long getImportedFeatureValueCount();

  /**
   * <pre>
   * The number of rows in input source that weren't imported due to either
   * * Not having any featureValues.
   * * Having a null entityId.
   * * Having a null timestamp.
   * * Not being parsable (applicable for CSV sources).
   * </pre>
   *
   * <code>int64 invalid_row_count = 6;</code>
   * @return The invalidRowCount.
   */
  long getInvalidRowCount();
}
