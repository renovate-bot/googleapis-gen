// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/v1/game_server_deployments.proto

package com.google.cloud.gaming.v1;

public interface CreateGameServerDeploymentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gaming.v1.CreateGameServerDeploymentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource name, in the following form:
   * `projects/{project}/locations/{location}`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource name, in the following form:
   * `projects/{project}/locations/{location}`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The ID of the game server delpoyment resource to be created.
   * </pre>
   *
   * <code>string deployment_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The deploymentId.
   */
  java.lang.String getDeploymentId();
  /**
   * <pre>
   * Required. The ID of the game server delpoyment resource to be created.
   * </pre>
   *
   * <code>string deployment_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for deploymentId.
   */
  com.google.protobuf.ByteString
      getDeploymentIdBytes();

  /**
   * <pre>
   * Required. The game server delpoyment resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeployment game_server_deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the gameServerDeployment field is set.
   */
  boolean hasGameServerDeployment();
  /**
   * <pre>
   * Required. The game server delpoyment resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeployment game_server_deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The gameServerDeployment.
   */
  com.google.cloud.gaming.v1.GameServerDeployment getGameServerDeployment();
  /**
   * <pre>
   * Required. The game server delpoyment resource to be created.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeployment game_server_deployment = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.gaming.v1.GameServerDeploymentOrBuilder getGameServerDeploymentOrBuilder();
}
