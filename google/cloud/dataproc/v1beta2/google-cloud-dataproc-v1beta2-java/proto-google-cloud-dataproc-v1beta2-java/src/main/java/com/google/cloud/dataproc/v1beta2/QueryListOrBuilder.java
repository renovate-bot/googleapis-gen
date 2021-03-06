// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1beta2/jobs.proto

package com.google.cloud.dataproc.v1beta2;

public interface QueryListOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dataproc.v1beta2.QueryList)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The queries to execute. You do not need to terminate a query
   * with a semicolon. Multiple queries can be specified in one string
   * by separating each with a semicolon. Here is an example of an Cloud
   * Dataproc API snippet that uses a QueryList to specify a HiveJob:
   *     "hiveJob": {
   *       "queryList": {
   *         "queries": [
   *           "query1",
   *           "query2",
   *           "query3;query4",
   *         ]
   *       }
   *     }
   * </pre>
   *
   * <code>repeated string queries = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return A list containing the queries.
   */
  java.util.List<java.lang.String>
      getQueriesList();
  /**
   * <pre>
   * Required. The queries to execute. You do not need to terminate a query
   * with a semicolon. Multiple queries can be specified in one string
   * by separating each with a semicolon. Here is an example of an Cloud
   * Dataproc API snippet that uses a QueryList to specify a HiveJob:
   *     "hiveJob": {
   *       "queryList": {
   *         "queries": [
   *           "query1",
   *           "query2",
   *           "query3;query4",
   *         ]
   *       }
   *     }
   * </pre>
   *
   * <code>repeated string queries = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The count of queries.
   */
  int getQueriesCount();
  /**
   * <pre>
   * Required. The queries to execute. You do not need to terminate a query
   * with a semicolon. Multiple queries can be specified in one string
   * by separating each with a semicolon. Here is an example of an Cloud
   * Dataproc API snippet that uses a QueryList to specify a HiveJob:
   *     "hiveJob": {
   *       "queryList": {
   *         "queries": [
   *           "query1",
   *           "query2",
   *           "query3;query4",
   *         ]
   *       }
   *     }
   * </pre>
   *
   * <code>repeated string queries = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the element to return.
   * @return The queries at the given index.
   */
  java.lang.String getQueries(int index);
  /**
   * <pre>
   * Required. The queries to execute. You do not need to terminate a query
   * with a semicolon. Multiple queries can be specified in one string
   * by separating each with a semicolon. Here is an example of an Cloud
   * Dataproc API snippet that uses a QueryList to specify a HiveJob:
   *     "hiveJob": {
   *       "queryList": {
   *         "queries": [
   *           "query1",
   *           "query2",
   *           "query3;query4",
   *         ]
   *       }
   *     }
   * </pre>
   *
   * <code>repeated string queries = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the value to return.
   * @return The bytes of the queries at the given index.
   */
  com.google.protobuf.ByteString
      getQueriesBytes(int index);
}
