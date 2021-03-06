// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: grafeas/v1/deployment.proto

package io.grafeas.v1;

public interface DeploymentNoteOrBuilder extends
    // @@protoc_insertion_point(interface_extends:grafeas.v1.DeploymentNote)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Resource URI for the artifact being deployed.
   * </pre>
   *
   * <code>repeated string resource_uri = 1;</code>
   * @return A list containing the resourceUri.
   */
  java.util.List<java.lang.String>
      getResourceUriList();
  /**
   * <pre>
   * Required. Resource URI for the artifact being deployed.
   * </pre>
   *
   * <code>repeated string resource_uri = 1;</code>
   * @return The count of resourceUri.
   */
  int getResourceUriCount();
  /**
   * <pre>
   * Required. Resource URI for the artifact being deployed.
   * </pre>
   *
   * <code>repeated string resource_uri = 1;</code>
   * @param index The index of the element to return.
   * @return The resourceUri at the given index.
   */
  java.lang.String getResourceUri(int index);
  /**
   * <pre>
   * Required. Resource URI for the artifact being deployed.
   * </pre>
   *
   * <code>repeated string resource_uri = 1;</code>
   * @param index The index of the value to return.
   * @return The bytes of the resourceUri at the given index.
   */
  com.google.protobuf.ByteString
      getResourceUriBytes(int index);
}
