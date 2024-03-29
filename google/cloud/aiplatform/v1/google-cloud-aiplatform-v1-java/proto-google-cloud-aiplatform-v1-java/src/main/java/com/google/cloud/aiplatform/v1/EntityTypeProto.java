// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/entity_type.proto

package com.google.cloud.aiplatform.v1;

public final class EntityTypeProto {
  private EntityTypeProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1_EntityType_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1_EntityType_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1_EntityType_LabelsEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1_EntityType_LabelsEntry_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n,google/cloud/aiplatform/v1/entity_type" +
      ".proto\022\032google.cloud.aiplatform.v1\032\037goog" +
      "le/api/field_behavior.proto\032\031google/api/" +
      "resource.proto\032(google/cloud/aiplatform/" +
      "v1/feature.proto\032\037google/protobuf/timest" +
      "amp.proto\032\034google/api/annotations.proto\"" +
      "\275\003\n\nEntityType\022\021\n\004name\030\001 \001(\tB\003\340A\005\022\030\n\013des" +
      "cription\030\002 \001(\tB\003\340A\001\0224\n\013create_time\030\003 \001(\013" +
      "2\032.google.protobuf.TimestampB\003\340A\003\0224\n\013upd" +
      "ate_time\030\004 \001(\0132\032.google.protobuf.Timesta" +
      "mpB\003\340A\003\022G\n\006labels\030\006 \003(\01322.google.cloud.a" +
      "iplatform.v1.EntityType.LabelsEntryB\003\340A\001" +
      "\022\021\n\004etag\030\007 \001(\tB\003\340A\001\032-\n\013LabelsEntry\022\013\n\003ke" +
      "y\030\001 \001(\t\022\r\n\005value\030\002 \001(\t:\0028\001:\212\001\352A\206\001\n$aipla" +
      "tform.googleapis.com/EntityType\022^project" +
      "s/{project}/locations/{location}/feature" +
      "stores/{featurestore}/entityTypes/{entit" +
      "y_type}B\323\001\n\036com.google.cloud.aiplatform." +
      "v1B\017EntityTypeProtoP\001ZDgoogle.golang.org" +
      "/genproto/googleapis/cloud/aiplatform/v1" +
      ";aiplatform\252\002\032Google.Cloud.AIPlatform.V1" +
      "\312\002\032Google\\Cloud\\AIPlatform\\V1\352\002\035Google::" +
      "Cloud::AIPlatform::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.cloud.aiplatform.v1.FeatureProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_aiplatform_v1_EntityType_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_aiplatform_v1_EntityType_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1_EntityType_descriptor,
        new java.lang.String[] { "Name", "Description", "CreateTime", "UpdateTime", "Labels", "Etag", });
    internal_static_google_cloud_aiplatform_v1_EntityType_LabelsEntry_descriptor =
      internal_static_google_cloud_aiplatform_v1_EntityType_descriptor.getNestedTypes().get(0);
    internal_static_google_cloud_aiplatform_v1_EntityType_LabelsEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1_EntityType_LabelsEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.cloud.aiplatform.v1.FeatureProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
