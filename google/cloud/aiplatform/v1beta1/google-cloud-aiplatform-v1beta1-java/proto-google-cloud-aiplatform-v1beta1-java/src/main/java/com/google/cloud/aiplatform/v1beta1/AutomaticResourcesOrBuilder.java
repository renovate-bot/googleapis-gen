// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/machine_resources.proto

package com.google.cloud.aiplatform.v1beta1;

public interface AutomaticResourcesOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1beta1.AutomaticResources)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Immutable. The minimum number of replicas this DeployedModel will be always deployed
   * on. If traffic against it increases, it may dynamically be deployed onto
   * more replicas up to [max_replica_count][google.cloud.aiplatform.v1beta1.AutomaticResources.max_replica_count], and as traffic decreases, some
   * of these extra replicas may be freed.
   * If the requested value is too large, the deployment will error.
   * </pre>
   *
   * <code>int32 min_replica_count = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The minReplicaCount.
   */
  int getMinReplicaCount();

  /**
   * <pre>
   * Immutable. The maximum number of replicas this DeployedModel may be deployed on when
   * the traffic against it increases. If the requested value is too large,
   * the deployment will error, but if deployment succeeds then the ability
   * to scale the model to that many replicas is guaranteed (barring service
   * outages). If traffic against the DeployedModel increases beyond what its
   * replicas at maximum may handle, a portion of the traffic will be dropped.
   * If this value is not provided, a no upper bound for scaling under heavy
   * traffic will be assume, though AI Platform may be unable to scale beyond
   * certain replica number.
   * </pre>
   *
   * <code>int32 max_replica_count = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
   * @return The maxReplicaCount.
   */
  int getMaxReplicaCount();
}
