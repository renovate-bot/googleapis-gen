// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/testing/v1/test_environment_discovery.proto

package com.google.devtools.testing.v1;

public interface IosVersionOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.testing.v1.IosVersion)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * An opaque id for this iOS version.
   * Use this id to invoke the TestExecutionService.
   * </pre>
   *
   * <code>string id = 1;</code>
   * @return The id.
   */
  java.lang.String getId();
  /**
   * <pre>
   * An opaque id for this iOS version.
   * Use this id to invoke the TestExecutionService.
   * </pre>
   *
   * <code>string id = 1;</code>
   * @return The bytes for id.
   */
  com.google.protobuf.ByteString
      getIdBytes();

  /**
   * <pre>
   * An integer representing the major iOS version.
   * Examples: "8", "9".
   * </pre>
   *
   * <code>int32 major_version = 2;</code>
   * @return The majorVersion.
   */
  int getMajorVersion();

  /**
   * <pre>
   * An integer representing the minor iOS version.
   * Examples: "1", "2".
   * </pre>
   *
   * <code>int32 minor_version = 4;</code>
   * @return The minorVersion.
   */
  int getMinorVersion();

  /**
   * <pre>
   * Tags for this dimension.
   * Examples: "default", "preview", "deprecated".
   * </pre>
   *
   * <code>repeated string tags = 3;</code>
   * @return A list containing the tags.
   */
  java.util.List<java.lang.String>
      getTagsList();
  /**
   * <pre>
   * Tags for this dimension.
   * Examples: "default", "preview", "deprecated".
   * </pre>
   *
   * <code>repeated string tags = 3;</code>
   * @return The count of tags.
   */
  int getTagsCount();
  /**
   * <pre>
   * Tags for this dimension.
   * Examples: "default", "preview", "deprecated".
   * </pre>
   *
   * <code>repeated string tags = 3;</code>
   * @param index The index of the element to return.
   * @return The tags at the given index.
   */
  java.lang.String getTags(int index);
  /**
   * <pre>
   * Tags for this dimension.
   * Examples: "default", "preview", "deprecated".
   * </pre>
   *
   * <code>repeated string tags = 3;</code>
   * @param index The index of the value to return.
   * @return The bytes of the tags at the given index.
   */
  com.google.protobuf.ByteString
      getTagsBytes(int index);

  /**
   * <pre>
   * The available Xcode versions for this version.
   * </pre>
   *
   * <code>repeated string supported_xcode_version_ids = 5;</code>
   * @return A list containing the supportedXcodeVersionIds.
   */
  java.util.List<java.lang.String>
      getSupportedXcodeVersionIdsList();
  /**
   * <pre>
   * The available Xcode versions for this version.
   * </pre>
   *
   * <code>repeated string supported_xcode_version_ids = 5;</code>
   * @return The count of supportedXcodeVersionIds.
   */
  int getSupportedXcodeVersionIdsCount();
  /**
   * <pre>
   * The available Xcode versions for this version.
   * </pre>
   *
   * <code>repeated string supported_xcode_version_ids = 5;</code>
   * @param index The index of the element to return.
   * @return The supportedXcodeVersionIds at the given index.
   */
  java.lang.String getSupportedXcodeVersionIds(int index);
  /**
   * <pre>
   * The available Xcode versions for this version.
   * </pre>
   *
   * <code>repeated string supported_xcode_version_ids = 5;</code>
   * @param index The index of the value to return.
   * @return The bytes of the supportedXcodeVersionIds at the given index.
   */
  com.google.protobuf.ByteString
      getSupportedXcodeVersionIdsBytes(int index);
}
