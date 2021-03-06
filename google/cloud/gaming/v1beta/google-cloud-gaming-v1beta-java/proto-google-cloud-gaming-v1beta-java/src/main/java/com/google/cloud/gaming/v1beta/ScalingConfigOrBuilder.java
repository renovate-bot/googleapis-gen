// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/v1beta/game_server_configs.proto

package com.google.cloud.gaming.v1beta;

public interface ScalingConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gaming.v1beta.ScalingConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The name of the Scaling Config
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The name of the Scaling Config
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Required. Agones fleet autoscaler spec. Example spec:
   * https://agones.dev/site/docs/reference/fleetautoscaler/
   * </pre>
   *
   * <code>string fleet_autoscaler_spec = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The fleetAutoscalerSpec.
   */
  java.lang.String getFleetAutoscalerSpec();
  /**
   * <pre>
   * Required. Agones fleet autoscaler spec. Example spec:
   * https://agones.dev/site/docs/reference/fleetautoscaler/
   * </pre>
   *
   * <code>string fleet_autoscaler_spec = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for fleetAutoscalerSpec.
   */
  com.google.protobuf.ByteString
      getFleetAutoscalerSpecBytes();

  /**
   * <pre>
   * Labels used to identify the game server clusters to which this Agones
   * scaling config applies. A game server cluster is subject to this Agones
   * scaling config if its labels match any of the selector entries.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.LabelSelector selectors = 4;</code>
   */
  java.util.List<com.google.cloud.gaming.v1beta.LabelSelector> 
      getSelectorsList();
  /**
   * <pre>
   * Labels used to identify the game server clusters to which this Agones
   * scaling config applies. A game server cluster is subject to this Agones
   * scaling config if its labels match any of the selector entries.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.LabelSelector selectors = 4;</code>
   */
  com.google.cloud.gaming.v1beta.LabelSelector getSelectors(int index);
  /**
   * <pre>
   * Labels used to identify the game server clusters to which this Agones
   * scaling config applies. A game server cluster is subject to this Agones
   * scaling config if its labels match any of the selector entries.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.LabelSelector selectors = 4;</code>
   */
  int getSelectorsCount();
  /**
   * <pre>
   * Labels used to identify the game server clusters to which this Agones
   * scaling config applies. A game server cluster is subject to this Agones
   * scaling config if its labels match any of the selector entries.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.LabelSelector selectors = 4;</code>
   */
  java.util.List<? extends com.google.cloud.gaming.v1beta.LabelSelectorOrBuilder> 
      getSelectorsOrBuilderList();
  /**
   * <pre>
   * Labels used to identify the game server clusters to which this Agones
   * scaling config applies. A game server cluster is subject to this Agones
   * scaling config if its labels match any of the selector entries.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.LabelSelector selectors = 4;</code>
   */
  com.google.cloud.gaming.v1beta.LabelSelectorOrBuilder getSelectorsOrBuilder(
      int index);

  /**
   * <pre>
   * The schedules to which this Scaling Config applies.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.Schedule schedules = 5;</code>
   */
  java.util.List<com.google.cloud.gaming.v1beta.Schedule> 
      getSchedulesList();
  /**
   * <pre>
   * The schedules to which this Scaling Config applies.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.Schedule schedules = 5;</code>
   */
  com.google.cloud.gaming.v1beta.Schedule getSchedules(int index);
  /**
   * <pre>
   * The schedules to which this Scaling Config applies.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.Schedule schedules = 5;</code>
   */
  int getSchedulesCount();
  /**
   * <pre>
   * The schedules to which this Scaling Config applies.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.Schedule schedules = 5;</code>
   */
  java.util.List<? extends com.google.cloud.gaming.v1beta.ScheduleOrBuilder> 
      getSchedulesOrBuilderList();
  /**
   * <pre>
   * The schedules to which this Scaling Config applies.
   * </pre>
   *
   * <code>repeated .google.cloud.gaming.v1beta.Schedule schedules = 5;</code>
   */
  com.google.cloud.gaming.v1beta.ScheduleOrBuilder getSchedulesOrBuilder(
      int index);
}
