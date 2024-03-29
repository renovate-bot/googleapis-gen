// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface RegionInstanceGroupManagersSetTemplateRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.RegionInstanceGroupManagersSetTemplateRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * URL of the InstanceTemplate resource from which all new instances will be created.
   * </pre>
   *
   * <code>optional string instance_template = 309248228;</code>
   * @return Whether the instanceTemplate field is set.
   */
  boolean hasInstanceTemplate();
  /**
   * <pre>
   * URL of the InstanceTemplate resource from which all new instances will be created.
   * </pre>
   *
   * <code>optional string instance_template = 309248228;</code>
   * @return The instanceTemplate.
   */
  java.lang.String getInstanceTemplate();
  /**
   * <pre>
   * URL of the InstanceTemplate resource from which all new instances will be created.
   * </pre>
   *
   * <code>optional string instance_template = 309248228;</code>
   * @return The bytes for instanceTemplate.
   */
  com.google.protobuf.ByteString
      getInstanceTemplateBytes();
}
