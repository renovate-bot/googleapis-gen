// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/oslogin/v1beta/oslogin.proto

package com.google.cloud.oslogin.v1beta;

public interface ImportSshPublicKeyResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.oslogin.v1beta.ImportSshPublicKeyResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The login profile information for the user.
   * </pre>
   *
   * <code>.google.cloud.oslogin.v1beta.LoginProfile login_profile = 1;</code>
   * @return Whether the loginProfile field is set.
   */
  boolean hasLoginProfile();
  /**
   * <pre>
   * The login profile information for the user.
   * </pre>
   *
   * <code>.google.cloud.oslogin.v1beta.LoginProfile login_profile = 1;</code>
   * @return The loginProfile.
   */
  com.google.cloud.oslogin.v1beta.LoginProfile getLoginProfile();
  /**
   * <pre>
   * The login profile information for the user.
   * </pre>
   *
   * <code>.google.cloud.oslogin.v1beta.LoginProfile login_profile = 1;</code>
   */
  com.google.cloud.oslogin.v1beta.LoginProfileOrBuilder getLoginProfileOrBuilder();
}
