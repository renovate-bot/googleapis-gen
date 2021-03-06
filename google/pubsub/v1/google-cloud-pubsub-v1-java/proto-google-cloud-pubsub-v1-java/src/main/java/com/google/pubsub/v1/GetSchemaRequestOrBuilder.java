// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/pubsub/v1/schema.proto

package com.google.pubsub.v1;

public interface GetSchemaRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.pubsub.v1.GetSchemaRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The name of the schema to get.
   * Format is `projects/{project}/schemas/{schema}`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The name of the schema to get.
   * Format is `projects/{project}/schemas/{schema}`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The set of fields to return in the response. If not set, returns a Schema
   * with `name` and `type`, but not `definition`. Set to `FULL` to retrieve all
   * fields.
   * </pre>
   *
   * <code>.google.pubsub.v1.SchemaView view = 2;</code>
   * @return The enum numeric value on the wire for view.
   */
  int getViewValue();
  /**
   * <pre>
   * The set of fields to return in the response. If not set, returns a Schema
   * with `name` and `type`, but not `definition`. Set to `FULL` to retrieve all
   * fields.
   * </pre>
   *
   * <code>.google.pubsub.v1.SchemaView view = 2;</code>
   * @return The view.
   */
  com.google.pubsub.v1.SchemaView getView();
}
