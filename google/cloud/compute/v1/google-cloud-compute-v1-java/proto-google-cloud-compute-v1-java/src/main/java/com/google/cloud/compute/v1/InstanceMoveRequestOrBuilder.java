// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface InstanceMoveRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.InstanceMoveRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The URL of the destination zone to move the instance. This can be a full or partial URL. For example, the following are all valid URLs to a zone: - https://www.googleapis.com/compute/v1/projects/project/zones/zone - projects/project/zones/zone - zones/zone 
   * </pre>
   *
   * <code>optional string destination_zone = 131854653;</code>
   * @return Whether the destinationZone field is set.
   */
  boolean hasDestinationZone();
  /**
   * <pre>
   * The URL of the destination zone to move the instance. This can be a full or partial URL. For example, the following are all valid URLs to a zone: - https://www.googleapis.com/compute/v1/projects/project/zones/zone - projects/project/zones/zone - zones/zone 
   * </pre>
   *
   * <code>optional string destination_zone = 131854653;</code>
   * @return The destinationZone.
   */
  java.lang.String getDestinationZone();
  /**
   * <pre>
   * The URL of the destination zone to move the instance. This can be a full or partial URL. For example, the following are all valid URLs to a zone: - https://www.googleapis.com/compute/v1/projects/project/zones/zone - projects/project/zones/zone - zones/zone 
   * </pre>
   *
   * <code>optional string destination_zone = 131854653;</code>
   * @return The bytes for destinationZone.
   */
  com.google.protobuf.ByteString
      getDestinationZoneBytes();

  /**
   * <pre>
   * The URL of the target instance to move. This can be a full or partial URL. For example, the following are all valid URLs to an instance: - https://www.googleapis.com/compute/v1/projects/project/zones/zone /instances/instance - projects/project/zones/zone/instances/instance - zones/zone/instances/instance 
   * </pre>
   *
   * <code>optional string target_instance = 289769347;</code>
   * @return Whether the targetInstance field is set.
   */
  boolean hasTargetInstance();
  /**
   * <pre>
   * The URL of the target instance to move. This can be a full or partial URL. For example, the following are all valid URLs to an instance: - https://www.googleapis.com/compute/v1/projects/project/zones/zone /instances/instance - projects/project/zones/zone/instances/instance - zones/zone/instances/instance 
   * </pre>
   *
   * <code>optional string target_instance = 289769347;</code>
   * @return The targetInstance.
   */
  java.lang.String getTargetInstance();
  /**
   * <pre>
   * The URL of the target instance to move. This can be a full or partial URL. For example, the following are all valid URLs to an instance: - https://www.googleapis.com/compute/v1/projects/project/zones/zone /instances/instance - projects/project/zones/zone/instances/instance - zones/zone/instances/instance 
   * </pre>
   *
   * <code>optional string target_instance = 289769347;</code>
   * @return The bytes for targetInstance.
   */
  com.google.protobuf.ByteString
      getTargetInstanceBytes();
}
