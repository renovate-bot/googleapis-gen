// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/storage/v1/storage.proto

package com.google.storage.v1;

public interface StartResumableWriteRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.storage.v1.StartResumableWriteRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The destination bucket, object, and metadata, as well as any preconditions.
   * </pre>
   *
   * <code>.google.storage.v1.InsertObjectSpec insert_object_spec = 1;</code>
   * @return Whether the insertObjectSpec field is set.
   */
  boolean hasInsertObjectSpec();
  /**
   * <pre>
   * The destination bucket, object, and metadata, as well as any preconditions.
   * </pre>
   *
   * <code>.google.storage.v1.InsertObjectSpec insert_object_spec = 1;</code>
   * @return The insertObjectSpec.
   */
  com.google.storage.v1.InsertObjectSpec getInsertObjectSpec();
  /**
   * <pre>
   * The destination bucket, object, and metadata, as well as any preconditions.
   * </pre>
   *
   * <code>.google.storage.v1.InsertObjectSpec insert_object_spec = 1;</code>
   */
  com.google.storage.v1.InsertObjectSpecOrBuilder getInsertObjectSpecOrBuilder();

  /**
   * <pre>
   * A set of parameters common to Storage API requests concerning an object.
   * </pre>
   *
   * <code>.google.storage.v1.CommonObjectRequestParams common_object_request_params = 3;</code>
   * @return Whether the commonObjectRequestParams field is set.
   */
  boolean hasCommonObjectRequestParams();
  /**
   * <pre>
   * A set of parameters common to Storage API requests concerning an object.
   * </pre>
   *
   * <code>.google.storage.v1.CommonObjectRequestParams common_object_request_params = 3;</code>
   * @return The commonObjectRequestParams.
   */
  com.google.storage.v1.CommonObjectRequestParams getCommonObjectRequestParams();
  /**
   * <pre>
   * A set of parameters common to Storage API requests concerning an object.
   * </pre>
   *
   * <code>.google.storage.v1.CommonObjectRequestParams common_object_request_params = 3;</code>
   */
  com.google.storage.v1.CommonObjectRequestParamsOrBuilder getCommonObjectRequestParamsOrBuilder();

  /**
   * <pre>
   * A set of parameters common to all Storage API requests.
   * </pre>
   *
   * <code>.google.storage.v1.CommonRequestParams common_request_params = 4;</code>
   * @return Whether the commonRequestParams field is set.
   */
  boolean hasCommonRequestParams();
  /**
   * <pre>
   * A set of parameters common to all Storage API requests.
   * </pre>
   *
   * <code>.google.storage.v1.CommonRequestParams common_request_params = 4;</code>
   * @return The commonRequestParams.
   */
  com.google.storage.v1.CommonRequestParams getCommonRequestParams();
  /**
   * <pre>
   * A set of parameters common to all Storage API requests.
   * </pre>
   *
   * <code>.google.storage.v1.CommonRequestParams common_request_params = 4;</code>
   */
  com.google.storage.v1.CommonRequestParamsOrBuilder getCommonRequestParamsOrBuilder();
}
