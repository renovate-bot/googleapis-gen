// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/v1/game_server_deployments.proto

package com.google.cloud.gaming.v1;

public interface UpdateGameServerDeploymentRolloutRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gaming.v1.UpdateGameServerDeploymentRolloutRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The game server delpoyment rollout to be updated.
   * Only fields specified in update_mask are updated.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeploymentRollout rollout = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the rollout field is set.
   */
  boolean hasRollout();
  /**
   * <pre>
   * Required. The game server delpoyment rollout to be updated.
   * Only fields specified in update_mask are updated.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeploymentRollout rollout = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The rollout.
   */
  com.google.cloud.gaming.v1.GameServerDeploymentRollout getRollout();
  /**
   * <pre>
   * Required. The game server delpoyment rollout to be updated.
   * Only fields specified in update_mask are updated.
   * </pre>
   *
   * <code>.google.cloud.gaming.v1.GameServerDeploymentRollout rollout = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.gaming.v1.GameServerDeploymentRolloutOrBuilder getRolloutOrBuilder();

  /**
   * <pre>
   * Required. Mask of fields to update. At least one path must be supplied in
   * this field. For the `FieldMask` definition, see
   * https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * Required. Mask of fields to update. At least one path must be supplied in
   * this field. For the `FieldMask` definition, see
   * https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * Required. Mask of fields to update. At least one path must be supplied in
   * this field. For the `FieldMask` definition, see
   * https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();
}
