// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface StatefulPolicyPreservedStateOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.StatefulPolicyPreservedState)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Disks created on the instances that will be preserved on instance delete, update, etc. This map is keyed with the device names of the disks.
   * </pre>
   *
   * <code>map&lt;string, .google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice&gt; disks = 95594102;</code>
   */
  int getDisksCount();
  /**
   * <pre>
   * Disks created on the instances that will be preserved on instance delete, update, etc. This map is keyed with the device names of the disks.
   * </pre>
   *
   * <code>map&lt;string, .google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice&gt; disks = 95594102;</code>
   */
  boolean containsDisks(
      java.lang.String key);
  /**
   * Use {@link #getDisksMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, com.google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice>
  getDisks();
  /**
   * <pre>
   * Disks created on the instances that will be preserved on instance delete, update, etc. This map is keyed with the device names of the disks.
   * </pre>
   *
   * <code>map&lt;string, .google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice&gt; disks = 95594102;</code>
   */
  java.util.Map<java.lang.String, com.google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice>
  getDisksMap();
  /**
   * <pre>
   * Disks created on the instances that will be preserved on instance delete, update, etc. This map is keyed with the device names of the disks.
   * </pre>
   *
   * <code>map&lt;string, .google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice&gt; disks = 95594102;</code>
   */

  com.google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice getDisksOrDefault(
      java.lang.String key,
      com.google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice defaultValue);
  /**
   * <pre>
   * Disks created on the instances that will be preserved on instance delete, update, etc. This map is keyed with the device names of the disks.
   * </pre>
   *
   * <code>map&lt;string, .google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice&gt; disks = 95594102;</code>
   */

  com.google.cloud.compute.v1.StatefulPolicyPreservedStateDiskDevice getDisksOrThrow(
      java.lang.String key);
}
