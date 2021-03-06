// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/iam/v1beta/workload_identity_pool.proto

package com.google.iam.v1beta;

public interface UpdateWorkloadIdentityPoolRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.iam.v1beta.UpdateWorkloadIdentityPoolRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The pool to update. The `name` field is used to identify the pool.
   * </pre>
   *
   * <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the workloadIdentityPool field is set.
   */
  boolean hasWorkloadIdentityPool();
  /**
   * <pre>
   * Required. The pool to update. The `name` field is used to identify the pool.
   * </pre>
   *
   * <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The workloadIdentityPool.
   */
  com.google.iam.v1beta.WorkloadIdentityPool getWorkloadIdentityPool();
  /**
   * <pre>
   * Required. The pool to update. The `name` field is used to identify the pool.
   * </pre>
   *
   * <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.iam.v1beta.WorkloadIdentityPoolOrBuilder getWorkloadIdentityPoolOrBuilder();

  /**
   * <pre>
   * Required. The list of fields update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * Required. The list of fields update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * Required. The list of fields update.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();
}
