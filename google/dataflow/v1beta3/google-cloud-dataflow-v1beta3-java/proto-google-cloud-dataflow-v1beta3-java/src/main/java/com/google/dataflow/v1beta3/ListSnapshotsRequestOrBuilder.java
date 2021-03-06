// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/dataflow/v1beta3/snapshots.proto

package com.google.dataflow.v1beta3;

public interface ListSnapshotsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.dataflow.v1beta3.ListSnapshotsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The project ID to list snapshots for.
   * </pre>
   *
   * <code>string project_id = 1;</code>
   * @return The projectId.
   */
  java.lang.String getProjectId();
  /**
   * <pre>
   * The project ID to list snapshots for.
   * </pre>
   *
   * <code>string project_id = 1;</code>
   * @return The bytes for projectId.
   */
  com.google.protobuf.ByteString
      getProjectIdBytes();

  /**
   * <pre>
   * If specified, list snapshots created from this job.
   * </pre>
   *
   * <code>string job_id = 3;</code>
   * @return The jobId.
   */
  java.lang.String getJobId();
  /**
   * <pre>
   * If specified, list snapshots created from this job.
   * </pre>
   *
   * <code>string job_id = 3;</code>
   * @return The bytes for jobId.
   */
  com.google.protobuf.ByteString
      getJobIdBytes();

  /**
   * <pre>
   * The location to list snapshots in.
   * </pre>
   *
   * <code>string location = 2;</code>
   * @return The location.
   */
  java.lang.String getLocation();
  /**
   * <pre>
   * The location to list snapshots in.
   * </pre>
   *
   * <code>string location = 2;</code>
   * @return The bytes for location.
   */
  com.google.protobuf.ByteString
      getLocationBytes();
}
