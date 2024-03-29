// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/container/v1beta1/cluster_service.proto

package com.google.container.v1beta1;

public interface MonitoringComponentConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.container.v1beta1.MonitoringComponentConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Select components to collect metrics. An empty set would disable all
   * monitoring.
   * </pre>
   *
   * <code>repeated .google.container.v1beta1.MonitoringComponentConfig.Component enable_components = 1;</code>
   * @return A list containing the enableComponents.
   */
  java.util.List<com.google.container.v1beta1.MonitoringComponentConfig.Component> getEnableComponentsList();
  /**
   * <pre>
   * Select components to collect metrics. An empty set would disable all
   * monitoring.
   * </pre>
   *
   * <code>repeated .google.container.v1beta1.MonitoringComponentConfig.Component enable_components = 1;</code>
   * @return The count of enableComponents.
   */
  int getEnableComponentsCount();
  /**
   * <pre>
   * Select components to collect metrics. An empty set would disable all
   * monitoring.
   * </pre>
   *
   * <code>repeated .google.container.v1beta1.MonitoringComponentConfig.Component enable_components = 1;</code>
   * @param index The index of the element to return.
   * @return The enableComponents at the given index.
   */
  com.google.container.v1beta1.MonitoringComponentConfig.Component getEnableComponents(int index);
  /**
   * <pre>
   * Select components to collect metrics. An empty set would disable all
   * monitoring.
   * </pre>
   *
   * <code>repeated .google.container.v1beta1.MonitoringComponentConfig.Component enable_components = 1;</code>
   * @return A list containing the enum numeric values on the wire for enableComponents.
   */
  java.util.List<java.lang.Integer>
  getEnableComponentsValueList();
  /**
   * <pre>
   * Select components to collect metrics. An empty set would disable all
   * monitoring.
   * </pre>
   *
   * <code>repeated .google.container.v1beta1.MonitoringComponentConfig.Component enable_components = 1;</code>
   * @param index The index of the value to return.
   * @return The enum numeric value on the wire of enableComponents at the given index.
   */
  int getEnableComponentsValue(int index);
}
