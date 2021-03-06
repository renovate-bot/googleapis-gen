// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/documentai/v1/operation_metadata.proto

package com.google.cloud.documentai.v1;

public final class OperationMetadataProto {
  private OperationMetadataProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_documentai_v1_CommonOperationMetadata_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_documentai_v1_CommonOperationMetadata_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n3google/cloud/documentai/v1/operation_m" +
      "etadata.proto\022\032google.cloud.documentai.v" +
      "1\032\037google/protobuf/timestamp.proto\032\034goog" +
      "le/api/annotations.proto\"\303\002\n\027CommonOpera" +
      "tionMetadata\022H\n\005state\030\001 \001(\01629.google.clo" +
      "ud.documentai.v1.CommonOperationMetadata" +
      ".State\022\025\n\rstate_message\030\002 \001(\t\022/\n\013create_" +
      "time\030\003 \001(\0132\032.google.protobuf.Timestamp\022/" +
      "\n\013update_time\030\004 \001(\0132\032.google.protobuf.Ti" +
      "mestamp\"e\n\005State\022\025\n\021STATE_UNSPECIFIED\020\000\022" +
      "\013\n\007RUNNING\020\001\022\016\n\nCANCELLING\020\002\022\r\n\tSUCCEEDE" +
      "D\020\003\022\n\n\006FAILED\020\004\022\r\n\tCANCELLED\020\005B\332\001\n\036com.g" +
      "oogle.cloud.documentai.v1B\026OperationMeta" +
      "dataProtoP\001ZDgoogle.golang.org/genproto/" +
      "googleapis/cloud/documentai/v1;documenta" +
      "i\252\002\032Google.Cloud.DocumentAI.V1\312\002\032Google\\" +
      "Cloud\\DocumentAI\\V1\352\002\035Google::Cloud::Doc" +
      "umentAI::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_documentai_v1_CommonOperationMetadata_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_documentai_v1_CommonOperationMetadata_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_documentai_v1_CommonOperationMetadata_descriptor,
        new java.lang.String[] { "State", "StateMessage", "CreateTime", "UpdateTime", });
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
