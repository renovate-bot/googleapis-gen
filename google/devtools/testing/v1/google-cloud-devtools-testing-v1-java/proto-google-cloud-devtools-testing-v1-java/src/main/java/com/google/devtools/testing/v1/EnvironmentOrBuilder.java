// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/testing/v1/test_execution.proto

package com.google.devtools.testing.v1;

public interface EnvironmentOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.testing.v1.Environment)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * An Android device which must be used with an Android test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.AndroidDevice android_device = 1;</code>
   * @return Whether the androidDevice field is set.
   */
  boolean hasAndroidDevice();
  /**
   * <pre>
   * An Android device which must be used with an Android test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.AndroidDevice android_device = 1;</code>
   * @return The androidDevice.
   */
  com.google.devtools.testing.v1.AndroidDevice getAndroidDevice();
  /**
   * <pre>
   * An Android device which must be used with an Android test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.AndroidDevice android_device = 1;</code>
   */
  com.google.devtools.testing.v1.AndroidDeviceOrBuilder getAndroidDeviceOrBuilder();

  /**
   * <pre>
   * An iOS device which must be used with an iOS test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.IosDevice ios_device = 2;</code>
   * @return Whether the iosDevice field is set.
   */
  boolean hasIosDevice();
  /**
   * <pre>
   * An iOS device which must be used with an iOS test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.IosDevice ios_device = 2;</code>
   * @return The iosDevice.
   */
  com.google.devtools.testing.v1.IosDevice getIosDevice();
  /**
   * <pre>
   * An iOS device which must be used with an iOS test.
   * </pre>
   *
   * <code>.google.devtools.testing.v1.IosDevice ios_device = 2;</code>
   */
  com.google.devtools.testing.v1.IosDeviceOrBuilder getIosDeviceOrBuilder();

  public com.google.devtools.testing.v1.Environment.EnvironmentCase getEnvironmentCase();
}
