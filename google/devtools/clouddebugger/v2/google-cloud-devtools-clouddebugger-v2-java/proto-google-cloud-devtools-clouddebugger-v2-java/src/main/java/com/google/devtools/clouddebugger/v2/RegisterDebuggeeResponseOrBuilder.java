// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/clouddebugger/v2/controller.proto

package com.google.devtools.clouddebugger.v2;

public interface RegisterDebuggeeResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.clouddebugger.v2.RegisterDebuggeeResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Debuggee resource.
   * The field `id` is guaranteed to be set (in addition to the echoed fields).
   * If the field `is_disabled` is set to `true`, the agent should disable
   * itself by removing all breakpoints and detaching from the application.
   * It should however continue to poll `RegisterDebuggee` until reenabled.
   * </pre>
   *
   * <code>.google.devtools.clouddebugger.v2.Debuggee debuggee = 1;</code>
   * @return Whether the debuggee field is set.
   */
  boolean hasDebuggee();
  /**
   * <pre>
   * Debuggee resource.
   * The field `id` is guaranteed to be set (in addition to the echoed fields).
   * If the field `is_disabled` is set to `true`, the agent should disable
   * itself by removing all breakpoints and detaching from the application.
   * It should however continue to poll `RegisterDebuggee` until reenabled.
   * </pre>
   *
   * <code>.google.devtools.clouddebugger.v2.Debuggee debuggee = 1;</code>
   * @return The debuggee.
   */
  com.google.devtools.clouddebugger.v2.Debuggee getDebuggee();
  /**
   * <pre>
   * Debuggee resource.
   * The field `id` is guaranteed to be set (in addition to the echoed fields).
   * If the field `is_disabled` is set to `true`, the agent should disable
   * itself by removing all breakpoints and detaching from the application.
   * It should however continue to poll `RegisterDebuggee` until reenabled.
   * </pre>
   *
   * <code>.google.devtools.clouddebugger.v2.Debuggee debuggee = 1;</code>
   */
  com.google.devtools.clouddebugger.v2.DebuggeeOrBuilder getDebuggeeOrBuilder();
}
