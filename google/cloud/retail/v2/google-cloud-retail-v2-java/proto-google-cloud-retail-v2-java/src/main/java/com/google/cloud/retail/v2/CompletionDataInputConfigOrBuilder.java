// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/retail/v2/import_config.proto

package com.google.cloud.retail.v2;

public interface CompletionDataInputConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.retail.v2.CompletionDataInputConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. BigQuery input source.
   * Add the IAM permission "BigQuery Data Viewer" for
   * cloud-retail-customer-data-access&#64;system.gserviceaccount.com before
   * using this feature otherwise an error is thrown.
   * </pre>
   *
   * <code>.google.cloud.retail.v2.BigQuerySource big_query_source = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the bigQuerySource field is set.
   */
  boolean hasBigQuerySource();
  /**
   * <pre>
   * Required. BigQuery input source.
   * Add the IAM permission "BigQuery Data Viewer" for
   * cloud-retail-customer-data-access&#64;system.gserviceaccount.com before
   * using this feature otherwise an error is thrown.
   * </pre>
   *
   * <code>.google.cloud.retail.v2.BigQuerySource big_query_source = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bigQuerySource.
   */
  com.google.cloud.retail.v2.BigQuerySource getBigQuerySource();
  /**
   * <pre>
   * Required. BigQuery input source.
   * Add the IAM permission "BigQuery Data Viewer" for
   * cloud-retail-customer-data-access&#64;system.gserviceaccount.com before
   * using this feature otherwise an error is thrown.
   * </pre>
   *
   * <code>.google.cloud.retail.v2.BigQuerySource big_query_source = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.retail.v2.BigQuerySourceOrBuilder getBigQuerySourceOrBuilder();

  public com.google.cloud.retail.v2.CompletionDataInputConfig.SourceCase getSourceCase();
}
