// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/agent.proto

package com.google.cloud.dialogflow.v2beta1;

public interface SubAgentOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2beta1.SubAgent)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The project of this agent.
   * Format: `projects/&lt;Project ID&gt;` or
   *         `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
   * </pre>
   *
   * <code>string project = 1;</code>
   * @return The project.
   */
  java.lang.String getProject();
  /**
   * <pre>
   * Required. The project of this agent.
   * Format: `projects/&lt;Project ID&gt;` or
   *         `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
   * </pre>
   *
   * <code>string project = 1;</code>
   * @return The bytes for project.
   */
  com.google.protobuf.ByteString
      getProjectBytes();

  /**
   * <pre>
   * Optional. The unique identifier (`environment name` in dialogflow console)
   * of this sub-agent environment. Assumes draft environment if `environment`
   * is not set.
   * </pre>
   *
   * <code>string environment = 2;</code>
   * @return The environment.
   */
  java.lang.String getEnvironment();
  /**
   * <pre>
   * Optional. The unique identifier (`environment name` in dialogflow console)
   * of this sub-agent environment. Assumes draft environment if `environment`
   * is not set.
   * </pre>
   *
   * <code>string environment = 2;</code>
   * @return The bytes for environment.
   */
  com.google.protobuf.ByteString
      getEnvironmentBytes();
}
