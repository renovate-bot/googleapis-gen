// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/identity/accesscontextmanager/v1/access_level.proto

package com.google.identity.accesscontextmanager.v1;

public interface OsConstraintOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.identity.accesscontextmanager.v1.OsConstraint)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The allowed OS type.
   * </pre>
   *
   * <code>.google.identity.accesscontextmanager.type.OsType os_type = 1;</code>
   * @return The enum numeric value on the wire for osType.
   */
  int getOsTypeValue();
  /**
   * <pre>
   * Required. The allowed OS type.
   * </pre>
   *
   * <code>.google.identity.accesscontextmanager.type.OsType os_type = 1;</code>
   * @return The osType.
   */
  com.google.identity.accesscontextmanager.type.OsType getOsType();

  /**
   * <pre>
   * The minimum allowed OS version. If not set, any version of this OS
   * satisfies the constraint. Format: `"major.minor.patch"`.
   * Examples: `"10.5.301"`, `"9.2.1"`.
   * </pre>
   *
   * <code>string minimum_version = 2;</code>
   * @return The minimumVersion.
   */
  java.lang.String getMinimumVersion();
  /**
   * <pre>
   * The minimum allowed OS version. If not set, any version of this OS
   * satisfies the constraint. Format: `"major.minor.patch"`.
   * Examples: `"10.5.301"`, `"9.2.1"`.
   * </pre>
   *
   * <code>string minimum_version = 2;</code>
   * @return The bytes for minimumVersion.
   */
  com.google.protobuf.ByteString
      getMinimumVersionBytes();

  /**
   * <pre>
   * Only allows requests from devices with a verified Chrome OS.
   * Verifications includes requirements that the device is enterprise-managed,
   * conformant to domain policies, and the caller has permission to call
   * the API targeted by the request.
   * </pre>
   *
   * <code>bool require_verified_chrome_os = 3;</code>
   * @return The requireVerifiedChromeOs.
   */
  boolean getRequireVerifiedChromeOs();
}
