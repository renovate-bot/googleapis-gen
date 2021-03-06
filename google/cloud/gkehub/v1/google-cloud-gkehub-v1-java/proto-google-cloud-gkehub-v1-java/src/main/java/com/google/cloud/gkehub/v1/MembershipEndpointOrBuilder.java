// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gkehub/v1/membership.proto

package com.google.cloud.gkehub.v1;

public interface MembershipEndpointOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gkehub.v1.MembershipEndpoint)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Optional. GKE-specific information. Only present if this Membership is a GKE cluster.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.GkeCluster gke_cluster = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return Whether the gkeCluster field is set.
   */
  boolean hasGkeCluster();
  /**
   * <pre>
   * Optional. GKE-specific information. Only present if this Membership is a GKE cluster.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.GkeCluster gke_cluster = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The gkeCluster.
   */
  com.google.cloud.gkehub.v1.GkeCluster getGkeCluster();
  /**
   * <pre>
   * Optional. GKE-specific information. Only present if this Membership is a GKE cluster.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.GkeCluster gke_cluster = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
   */
  com.google.cloud.gkehub.v1.GkeClusterOrBuilder getGkeClusterOrBuilder();

  /**
   * <pre>
   * Output only. Useful Kubernetes-specific metadata.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.KubernetesMetadata kubernetes_metadata = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the kubernetesMetadata field is set.
   */
  boolean hasKubernetesMetadata();
  /**
   * <pre>
   * Output only. Useful Kubernetes-specific metadata.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.KubernetesMetadata kubernetes_metadata = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The kubernetesMetadata.
   */
  com.google.cloud.gkehub.v1.KubernetesMetadata getKubernetesMetadata();
  /**
   * <pre>
   * Output only. Useful Kubernetes-specific metadata.
   * </pre>
   *
   * <code>.google.cloud.gkehub.v1.KubernetesMetadata kubernetes_metadata = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.gkehub.v1.KubernetesMetadataOrBuilder getKubernetesMetadataOrBuilder();
}
