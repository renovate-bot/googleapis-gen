// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface AutoscalingPolicyScaleInControlOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.AutoscalingPolicyScaleInControl)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Maximum allowed number (or %) of VMs that can be deducted from the peak recommendation during the window autoscaler looks at when computing recommendations. Possibly all these VMs can be deleted at once so user service needs to be prepared to lose that many VMs in one step.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.FixedOrPercent max_scaled_in_replicas = 180710123;</code>
   * @return Whether the maxScaledInReplicas field is set.
   */
  boolean hasMaxScaledInReplicas();
  /**
   * <pre>
   * Maximum allowed number (or %) of VMs that can be deducted from the peak recommendation during the window autoscaler looks at when computing recommendations. Possibly all these VMs can be deleted at once so user service needs to be prepared to lose that many VMs in one step.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.FixedOrPercent max_scaled_in_replicas = 180710123;</code>
   * @return The maxScaledInReplicas.
   */
  com.google.cloud.compute.v1.FixedOrPercent getMaxScaledInReplicas();
  /**
   * <pre>
   * Maximum allowed number (or %) of VMs that can be deducted from the peak recommendation during the window autoscaler looks at when computing recommendations. Possibly all these VMs can be deleted at once so user service needs to be prepared to lose that many VMs in one step.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.FixedOrPercent max_scaled_in_replicas = 180710123;</code>
   */
  com.google.cloud.compute.v1.FixedOrPercentOrBuilder getMaxScaledInReplicasOrBuilder();

  /**
   * <pre>
   * How far back autoscaling looks when computing recommendations to include directives regarding slower scale in, as described above.
   * </pre>
   *
   * <code>optional int32 time_window_sec = 36405300;</code>
   * @return Whether the timeWindowSec field is set.
   */
  boolean hasTimeWindowSec();
  /**
   * <pre>
   * How far back autoscaling looks when computing recommendations to include directives regarding slower scale in, as described above.
   * </pre>
   *
   * <code>optional int32 time_window_sec = 36405300;</code>
   * @return The timeWindowSec.
   */
  int getTimeWindowSec();
}
