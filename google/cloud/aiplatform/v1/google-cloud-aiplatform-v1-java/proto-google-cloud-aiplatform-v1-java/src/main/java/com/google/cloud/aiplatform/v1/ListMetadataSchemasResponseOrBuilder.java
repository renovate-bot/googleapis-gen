// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/metadata_service.proto

package com.google.cloud.aiplatform.v1;

public interface ListMetadataSchemasResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.ListMetadataSchemasResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The MetadataSchemas found for the MetadataStore.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.MetadataSchema metadata_schemas = 1;</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1.MetadataSchema> 
      getMetadataSchemasList();
  /**
   * <pre>
   * The MetadataSchemas found for the MetadataStore.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.MetadataSchema metadata_schemas = 1;</code>
   */
  com.google.cloud.aiplatform.v1.MetadataSchema getMetadataSchemas(int index);
  /**
   * <pre>
   * The MetadataSchemas found for the MetadataStore.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.MetadataSchema metadata_schemas = 1;</code>
   */
  int getMetadataSchemasCount();
  /**
   * <pre>
   * The MetadataSchemas found for the MetadataStore.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.MetadataSchema metadata_schemas = 1;</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1.MetadataSchemaOrBuilder> 
      getMetadataSchemasOrBuilderList();
  /**
   * <pre>
   * The MetadataSchemas found for the MetadataStore.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.MetadataSchema metadata_schemas = 1;</code>
   */
  com.google.cloud.aiplatform.v1.MetadataSchemaOrBuilder getMetadataSchemasOrBuilder(
      int index);

  /**
   * <pre>
   * A token, which can be sent as
   * [ListMetadataSchemasRequest.page_token][google.cloud.aiplatform.v1.ListMetadataSchemasRequest.page_token] to retrieve the next
   * page. If this field is not populated, there are no subsequent pages.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token, which can be sent as
   * [ListMetadataSchemasRequest.page_token][google.cloud.aiplatform.v1.ListMetadataSchemasRequest.page_token] to retrieve the next
   * page. If this field is not populated, there are no subsequent pages.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
