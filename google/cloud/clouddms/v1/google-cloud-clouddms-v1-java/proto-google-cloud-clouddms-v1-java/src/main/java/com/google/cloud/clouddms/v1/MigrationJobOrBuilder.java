// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/clouddms/v1/clouddms_resources.proto

package com.google.cloud.clouddms.v1;

public interface MigrationJobOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.clouddms.v1.MigrationJob)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The name (URI) of this migration job resource, in the form of:
   * projects/{project}/locations/{location}/instances/{instance}.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The name (URI) of this migration job resource, in the form of:
   * projects/{project}/locations/{location}/instances/{instance}.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was created.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the createTime field is set.
   */
  boolean hasCreateTime();
  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was created.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The createTime.
   */
  com.google.protobuf.Timestamp getCreateTime();
  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was created.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getCreateTimeOrBuilder();

  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was last updated.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the updateTime field is set.
   */
  boolean hasUpdateTime();
  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was last updated.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The updateTime.
   */
  com.google.protobuf.Timestamp getUpdateTime();
  /**
   * <pre>
   * Output only. The timestamp when the migration job resource was last updated.
   * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
   * Example: "2014-10-02T15:01:23.045123456Z".
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getUpdateTimeOrBuilder();

  /**
   * <pre>
   * The resource labels for migration job to use to annotate any related
   * underlying resources such as Compute Engine VMs. An object containing a
   * list of "key": "value" pairs.
   * Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  int getLabelsCount();
  /**
   * <pre>
   * The resource labels for migration job to use to annotate any related
   * underlying resources such as Compute Engine VMs. An object containing a
   * list of "key": "value" pairs.
   * Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  boolean containsLabels(
      java.lang.String key);
  /**
   * Use {@link #getLabelsMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getLabels();
  /**
   * <pre>
   * The resource labels for migration job to use to annotate any related
   * underlying resources such as Compute Engine VMs. An object containing a
   * list of "key": "value" pairs.
   * Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getLabelsMap();
  /**
   * <pre>
   * The resource labels for migration job to use to annotate any related
   * underlying resources such as Compute Engine VMs. An object containing a
   * list of "key": "value" pairs.
   * Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */

  java.lang.String getLabelsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * The resource labels for migration job to use to annotate any related
   * underlying resources such as Compute Engine VMs. An object containing a
   * list of "key": "value" pairs.
   * Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */

  java.lang.String getLabelsOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * The migration job display name.
   * </pre>
   *
   * <code>string display_name = 5;</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * The migration job display name.
   * </pre>
   *
   * <code>string display_name = 5;</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * The current migration job state.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.State state = 6;</code>
   * @return The enum numeric value on the wire for state.
   */
  int getStateValue();
  /**
   * <pre>
   * The current migration job state.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.State state = 6;</code>
   * @return The state.
   */
  com.google.cloud.clouddms.v1.MigrationJob.State getState();

  /**
   * <pre>
   * Output only. The current migration job phase.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.Phase phase = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The enum numeric value on the wire for phase.
   */
  int getPhaseValue();
  /**
   * <pre>
   * Output only. The current migration job phase.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.Phase phase = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The phase.
   */
  com.google.cloud.clouddms.v1.MigrationJob.Phase getPhase();

  /**
   * <pre>
   * Required. The migration job type.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.Type type = 8 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The enum numeric value on the wire for type.
   */
  int getTypeValue();
  /**
   * <pre>
   * Required. The migration job type.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.MigrationJob.Type type = 8 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The type.
   */
  com.google.cloud.clouddms.v1.MigrationJob.Type getType();

  /**
   * <pre>
   * The path to the dump file in Google Cloud Storage,
   * in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
   * </pre>
   *
   * <code>string dump_path = 9;</code>
   * @return The dumpPath.
   */
  java.lang.String getDumpPath();
  /**
   * <pre>
   * The path to the dump file in Google Cloud Storage,
   * in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
   * </pre>
   *
   * <code>string dump_path = 9;</code>
   * @return The bytes for dumpPath.
   */
  com.google.protobuf.ByteString
      getDumpPathBytes();

  /**
   * <pre>
   * Required. The resource name (URI) of the source connection profile.
   * </pre>
   *
   * <code>string source = 10 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The source.
   */
  java.lang.String getSource();
  /**
   * <pre>
   * Required. The resource name (URI) of the source connection profile.
   * </pre>
   *
   * <code>string source = 10 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for source.
   */
  com.google.protobuf.ByteString
      getSourceBytes();

  /**
   * <pre>
   * Required. The resource name (URI) of the destination connection profile.
   * </pre>
   *
   * <code>string destination = 11 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The destination.
   */
  java.lang.String getDestination();
  /**
   * <pre>
   * Required. The resource name (URI) of the destination connection profile.
   * </pre>
   *
   * <code>string destination = 11 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for destination.
   */
  com.google.protobuf.ByteString
      getDestinationBytes();

  /**
   * <pre>
   * The details needed to communicate to the source over Reverse SSH
   * tunnel connectivity.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.ReverseSshConnectivity reverse_ssh_connectivity = 101;</code>
   * @return Whether the reverseSshConnectivity field is set.
   */
  boolean hasReverseSshConnectivity();
  /**
   * <pre>
   * The details needed to communicate to the source over Reverse SSH
   * tunnel connectivity.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.ReverseSshConnectivity reverse_ssh_connectivity = 101;</code>
   * @return The reverseSshConnectivity.
   */
  com.google.cloud.clouddms.v1.ReverseSshConnectivity getReverseSshConnectivity();
  /**
   * <pre>
   * The details needed to communicate to the source over Reverse SSH
   * tunnel connectivity.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.ReverseSshConnectivity reverse_ssh_connectivity = 101;</code>
   */
  com.google.cloud.clouddms.v1.ReverseSshConnectivityOrBuilder getReverseSshConnectivityOrBuilder();

  /**
   * <pre>
   * The details of the VPC network that the source database is located in.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.VpcPeeringConnectivity vpc_peering_connectivity = 102;</code>
   * @return Whether the vpcPeeringConnectivity field is set.
   */
  boolean hasVpcPeeringConnectivity();
  /**
   * <pre>
   * The details of the VPC network that the source database is located in.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.VpcPeeringConnectivity vpc_peering_connectivity = 102;</code>
   * @return The vpcPeeringConnectivity.
   */
  com.google.cloud.clouddms.v1.VpcPeeringConnectivity getVpcPeeringConnectivity();
  /**
   * <pre>
   * The details of the VPC network that the source database is located in.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.VpcPeeringConnectivity vpc_peering_connectivity = 102;</code>
   */
  com.google.cloud.clouddms.v1.VpcPeeringConnectivityOrBuilder getVpcPeeringConnectivityOrBuilder();

  /**
   * <pre>
   * static ip connectivity data (default, no additional details needed).
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.StaticIpConnectivity static_ip_connectivity = 103;</code>
   * @return Whether the staticIpConnectivity field is set.
   */
  boolean hasStaticIpConnectivity();
  /**
   * <pre>
   * static ip connectivity data (default, no additional details needed).
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.StaticIpConnectivity static_ip_connectivity = 103;</code>
   * @return The staticIpConnectivity.
   */
  com.google.cloud.clouddms.v1.StaticIpConnectivity getStaticIpConnectivity();
  /**
   * <pre>
   * static ip connectivity data (default, no additional details needed).
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.StaticIpConnectivity static_ip_connectivity = 103;</code>
   */
  com.google.cloud.clouddms.v1.StaticIpConnectivityOrBuilder getStaticIpConnectivityOrBuilder();

  /**
   * <pre>
   * Output only. The duration of the migration job (in seconds). A duration in seconds
   * with up to nine fractional digits, terminated by 's'. Example: "3.5s".
   * </pre>
   *
   * <code>.google.protobuf.Duration duration = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the duration field is set.
   */
  boolean hasDuration();
  /**
   * <pre>
   * Output only. The duration of the migration job (in seconds). A duration in seconds
   * with up to nine fractional digits, terminated by 's'. Example: "3.5s".
   * </pre>
   *
   * <code>.google.protobuf.Duration duration = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The duration.
   */
  com.google.protobuf.Duration getDuration();
  /**
   * <pre>
   * Output only. The duration of the migration job (in seconds). A duration in seconds
   * with up to nine fractional digits, terminated by 's'. Example: "3.5s".
   * </pre>
   *
   * <code>.google.protobuf.Duration duration = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.DurationOrBuilder getDurationOrBuilder();

  /**
   * <pre>
   * Output only. The error details in case of state FAILED.
   * </pre>
   *
   * <code>.google.rpc.Status error = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the error field is set.
   */
  boolean hasError();
  /**
   * <pre>
   * Output only. The error details in case of state FAILED.
   * </pre>
   *
   * <code>.google.rpc.Status error = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The error.
   */
  com.google.rpc.Status getError();
  /**
   * <pre>
   * Output only. The error details in case of state FAILED.
   * </pre>
   *
   * <code>.google.rpc.Status error = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.rpc.StatusOrBuilder getErrorOrBuilder();

  /**
   * <pre>
   * The database engine type and provider of the source.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType source_database = 14;</code>
   * @return Whether the sourceDatabase field is set.
   */
  boolean hasSourceDatabase();
  /**
   * <pre>
   * The database engine type and provider of the source.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType source_database = 14;</code>
   * @return The sourceDatabase.
   */
  com.google.cloud.clouddms.v1.DatabaseType getSourceDatabase();
  /**
   * <pre>
   * The database engine type and provider of the source.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType source_database = 14;</code>
   */
  com.google.cloud.clouddms.v1.DatabaseTypeOrBuilder getSourceDatabaseOrBuilder();

  /**
   * <pre>
   * The database engine type and provider of the destination.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType destination_database = 15;</code>
   * @return Whether the destinationDatabase field is set.
   */
  boolean hasDestinationDatabase();
  /**
   * <pre>
   * The database engine type and provider of the destination.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType destination_database = 15;</code>
   * @return The destinationDatabase.
   */
  com.google.cloud.clouddms.v1.DatabaseType getDestinationDatabase();
  /**
   * <pre>
   * The database engine type and provider of the destination.
   * </pre>
   *
   * <code>.google.cloud.clouddms.v1.DatabaseType destination_database = 15;</code>
   */
  com.google.cloud.clouddms.v1.DatabaseTypeOrBuilder getDestinationDatabaseOrBuilder();

  /**
   * <pre>
   * Output only. If the migration job is completed, the time when it was completed.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the endTime field is set.
   */
  boolean hasEndTime();
  /**
   * <pre>
   * Output only. If the migration job is completed, the time when it was completed.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The endTime.
   */
  com.google.protobuf.Timestamp getEndTime();
  /**
   * <pre>
   * Output only. If the migration job is completed, the time when it was completed.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 16 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getEndTimeOrBuilder();

  public com.google.cloud.clouddms.v1.MigrationJob.ConnectivityCase getConnectivityCase();
}
