// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datacatalog/v1/usage.proto

package com.google.cloud.datacatalog.v1;

public final class Usage {
  private Usage() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_datacatalog_v1_UsageStats_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_datacatalog_v1_UsageStats_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_datacatalog_v1_UsageSignal_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_datacatalog_v1_UsageSignal_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_datacatalog_v1_UsageSignal_UsageWithinTimeRangeEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_datacatalog_v1_UsageSignal_UsageWithinTimeRangeEntry_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\'google/cloud/datacatalog/v1/usage.prot" +
      "o\022\033google.cloud.datacatalog.v1\032\037google/p" +
      "rotobuf/timestamp.proto\"\221\001\n\nUsageStats\022\031" +
      "\n\021total_completions\030\001 \001(\002\022\026\n\016total_failu" +
      "res\030\002 \001(\002\022\033\n\023total_cancellations\030\003 \001(\002\0223" +
      "\n+total_execution_time_for_completions_m" +
      "illis\030\004 \001(\002\"\211\002\n\013UsageSignal\022/\n\013update_ti" +
      "me\030\001 \001(\0132\032.google.protobuf.Timestamp\022c\n\027" +
      "usage_within_time_range\030\002 \003(\0132B.google.c" +
      "loud.datacatalog.v1.UsageSignal.UsageWit" +
      "hinTimeRangeEntry\032d\n\031UsageWithinTimeRang" +
      "eEntry\022\013\n\003key\030\001 \001(\t\0226\n\005value\030\002 \001(\0132\'.goo" +
      "gle.cloud.datacatalog.v1.UsageStats:\0028\001B" +
      "\313\001\n\037com.google.cloud.datacatalog.v1P\001ZFg" +
      "oogle.golang.org/genproto/googleapis/clo" +
      "ud/datacatalog/v1;datacatalog\370\001\001\252\002\033Googl" +
      "e.Cloud.DataCatalog.V1\312\002\033Google\\Cloud\\Da" +
      "taCatalog\\V1\352\002\036Google::Cloud::DataCatalo" +
      "g::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.protobuf.TimestampProto.getDescriptor(),
        });
    internal_static_google_cloud_datacatalog_v1_UsageStats_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_datacatalog_v1_UsageStats_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_datacatalog_v1_UsageStats_descriptor,
        new java.lang.String[] { "TotalCompletions", "TotalFailures", "TotalCancellations", "TotalExecutionTimeForCompletionsMillis", });
    internal_static_google_cloud_datacatalog_v1_UsageSignal_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_datacatalog_v1_UsageSignal_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_datacatalog_v1_UsageSignal_descriptor,
        new java.lang.String[] { "UpdateTime", "UsageWithinTimeRange", });
    internal_static_google_cloud_datacatalog_v1_UsageSignal_UsageWithinTimeRangeEntry_descriptor =
      internal_static_google_cloud_datacatalog_v1_UsageSignal_descriptor.getNestedTypes().get(0);
    internal_static_google_cloud_datacatalog_v1_UsageSignal_UsageWithinTimeRangeEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_datacatalog_v1_UsageSignal_UsageWithinTimeRangeEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    com.google.protobuf.TimestampProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
