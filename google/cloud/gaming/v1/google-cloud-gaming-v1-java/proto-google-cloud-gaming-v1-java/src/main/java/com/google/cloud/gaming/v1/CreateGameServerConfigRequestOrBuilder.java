// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/v1/game_server_configs.proto

package com.google.cloud.gaming.v1;

public interface CreateGameServerConfigRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gaming.v1.CreateGameServerConfigRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource name, in the following form:
   * `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource name, in the following form:
   * `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The ID of the game server config resource to be created.
   * </pre>
   *
   * <code>string config_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The configId.
   */
  java.lang.String getConfigId();
  /**
   * <pre>
   * Required. The ID of the game server config resource to be created.
   * </pre>
   *
   * <code>string config_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for configId.
   */
  com.google.protobuf.ByteString
      getConfigIdBytes();

  /**
   * <pre>
   * Required. The game server config resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the gameServerConfig field is set.
   */
  boolean hasGameServerConfig();
  /**
   * <pre>
   * Required. The game server config resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The gameServerConfig.
   */
  com.google.cloud.gaming.v1.GameServerConfig getGameServerConfig();
  /**
   * <pre>
   * Required. The game server config resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerConfig game_server_config = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.gaming.v1.GameServerConfigOrBuilder getGameServerConfigOrBuilder();
}
