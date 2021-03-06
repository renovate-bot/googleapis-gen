// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/home/enterprise/sdm/v1/smart_device_management_service.proto

package com.google.home.enterprise.sdm.v1;

public interface ExecuteDeviceCommandRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The name of the device requested. For example:
   * "enterprises/XYZ/devices/123"
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The name of the device requested. For example:
   * "enterprises/XYZ/devices/123"
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The command name to execute, represented by the fully qualified protobuf
   * message name.
   * </pre>
   *
   * <code>string command = 2;</code>
   * @return The command.
   */
  java.lang.String getCommand();
  /**
   * <pre>
   * The command name to execute, represented by the fully qualified protobuf
   * message name.
   * </pre>
   *
   * <code>string command = 2;</code>
   * @return The bytes for command.
   */
  com.google.protobuf.ByteString
      getCommandBytes();

  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   * @return Whether the params field is set.
   */
  boolean hasParams();
  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   * @return The params.
   */
  com.google.protobuf.Struct getParams();
  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   */
  com.google.protobuf.StructOrBuilder getParamsOrBuilder();
}
