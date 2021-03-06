// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gkehub/v1beta/configmanagement/configmanagement.proto

package com.google.cloud.gkehub.configmanagement.v1beta;

public interface GatekeeperDeploymentStateOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gkehub.configmanagement.v1beta.GatekeeperDeploymentState)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Status of gatekeeper-controller-manager pod.
   * </pre>
   *
   * <code>.google.cloud.gkehub.configmanagement.v1beta.DeploymentState gatekeeper_controller_manager_state = 1;</code>
   * @return The enum numeric value on the wire for gatekeeperControllerManagerState.
   */
  int getGatekeeperControllerManagerStateValue();
  /**
   * <pre>
   * Status of gatekeeper-controller-manager pod.
   * </pre>
   *
   * <code>.google.cloud.gkehub.configmanagement.v1beta.DeploymentState gatekeeper_controller_manager_state = 1;</code>
   * @return The gatekeeperControllerManagerState.
   */
  com.google.cloud.gkehub.configmanagement.v1beta.DeploymentState getGatekeeperControllerManagerState();

  /**
   * <pre>
   * Status of gatekeeper-audit deployment.
   * </pre>
   *
   * <code>.google.cloud.gkehub.configmanagement.v1beta.DeploymentState gatekeeper_audit = 2;</code>
   * @return The enum numeric value on the wire for gatekeeperAudit.
   */
  int getGatekeeperAuditValue();
  /**
   * <pre>
   * Status of gatekeeper-audit deployment.
   * </pre>
   *
   * <code>.google.cloud.gkehub.configmanagement.v1beta.DeploymentState gatekeeper_audit = 2;</code>
   * @return The gatekeeperAudit.
   */
  com.google.cloud.gkehub.configmanagement.v1beta.DeploymentState getGatekeeperAudit();
}
