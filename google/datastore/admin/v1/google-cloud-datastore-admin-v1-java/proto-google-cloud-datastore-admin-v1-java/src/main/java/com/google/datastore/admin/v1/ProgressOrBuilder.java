// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/datastore/admin/v1/datastore_admin.proto

package com.google.datastore.admin.v1;

public interface ProgressOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.datastore.admin.v1.Progress)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The amount of work that has been completed. Note that this may be greater
   * than work_estimated.
   * </pre>
   *
   * <code>int64 work_completed = 1;</code>
   * @return The workCompleted.
   */
  long getWorkCompleted();

  /**
   * <pre>
   * An estimate of how much work needs to be performed. May be zero if the
   * work estimate is unavailable.
   * </pre>
   *
   * <code>int64 work_estimated = 2;</code>
   * @return The workEstimated.
   */
  long getWorkEstimated();
}
