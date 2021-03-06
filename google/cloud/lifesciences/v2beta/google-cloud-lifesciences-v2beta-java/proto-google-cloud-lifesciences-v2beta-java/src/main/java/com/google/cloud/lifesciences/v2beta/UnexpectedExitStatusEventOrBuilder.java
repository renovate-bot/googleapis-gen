// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/lifesciences/v2beta/workflows.proto

package com.google.cloud.lifesciences.v2beta;

public interface UnexpectedExitStatusEventOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.lifesciences.v2beta.UnexpectedExitStatusEvent)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The numeric ID of the action that started the container.
   * </pre>
   *
   * <code>int32 action_id = 1;</code>
   * @return The actionId.
   */
  int getActionId();

  /**
   * <pre>
   * The exit status of the container.
   * </pre>
   *
   * <code>int32 exit_status = 2;</code>
   * @return The exitStatus.
   */
  int getExitStatus();
}
