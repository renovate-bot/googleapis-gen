// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/container/v1/cluster_service.proto

package com.google.container.v1;

public interface ShieldedInstanceConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.container.v1.ShieldedInstanceConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Defines whether the instance has Secure Boot enabled.
   * Secure Boot helps ensure that the system only runs authentic software by
   * verifying the digital signature of all boot components, and halting the
   * boot process if signature verification fails.
   * </pre>
   *
   * <code>bool enable_secure_boot = 1;</code>
   * @return The enableSecureBoot.
   */
  boolean getEnableSecureBoot();

  /**
   * <pre>
   * Defines whether the instance has integrity monitoring enabled.
   * Enables monitoring and attestation of the boot integrity of the instance.
   * The attestation is performed against the integrity policy baseline. This
   * baseline is initially derived from the implicitly trusted boot image when
   * the instance is created.
   * </pre>
   *
   * <code>bool enable_integrity_monitoring = 2;</code>
   * @return The enableIntegrityMonitoring.
   */
  boolean getEnableIntegrityMonitoring();
}
