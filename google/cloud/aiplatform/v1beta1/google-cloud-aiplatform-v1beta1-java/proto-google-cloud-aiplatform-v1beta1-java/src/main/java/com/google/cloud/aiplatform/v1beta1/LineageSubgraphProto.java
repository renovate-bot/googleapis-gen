// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/lineage_subgraph.proto

package com.google.cloud.aiplatform.v1beta1;

public final class LineageSubgraphProto {
  private LineageSubgraphProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1beta1_LineageSubgraph_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1beta1_LineageSubgraph_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n6google/cloud/aiplatform/v1beta1/lineag" +
      "e_subgraph.proto\022\037google.cloud.aiplatfor" +
      "m.v1beta1\032.google/cloud/aiplatform/v1bet" +
      "a1/artifact.proto\032+google/cloud/aiplatfo" +
      "rm/v1beta1/event.proto\032/google/cloud/aip" +
      "latform/v1beta1/execution.proto\032\034google/" +
      "api/annotations.proto\"\307\001\n\017LineageSubgrap" +
      "h\022<\n\tartifacts\030\001 \003(\0132).google.cloud.aipl" +
      "atform.v1beta1.Artifact\022>\n\nexecutions\030\002 " +
      "\003(\0132*.google.cloud.aiplatform.v1beta1.Ex" +
      "ecution\0226\n\006events\030\003 \003(\0132&.google.cloud.a" +
      "iplatform.v1beta1.EventB\361\001\n#com.google.c" +
      "loud.aiplatform.v1beta1B\024LineageSubgraph" +
      "ProtoP\001ZIgoogle.golang.org/genproto/goog" +
      "leapis/cloud/aiplatform/v1beta1;aiplatfo" +
      "rm\252\002\037Google.Cloud.AIPlatform.V1Beta1\312\002\037G" +
      "oogle\\Cloud\\AIPlatform\\V1beta1\352\002\"Google:" +
      ":Cloud::AIPlatform::V1beta1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.cloud.aiplatform.v1beta1.ArtifactProto.getDescriptor(),
          com.google.cloud.aiplatform.v1beta1.EventProto.getDescriptor(),
          com.google.cloud.aiplatform.v1beta1.ExecutionProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_aiplatform_v1beta1_LineageSubgraph_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_aiplatform_v1beta1_LineageSubgraph_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1beta1_LineageSubgraph_descriptor,
        new java.lang.String[] { "Artifacts", "Executions", "Events", });
    com.google.cloud.aiplatform.v1beta1.ArtifactProto.getDescriptor();
    com.google.cloud.aiplatform.v1beta1.EventProto.getDescriptor();
    com.google.cloud.aiplatform.v1beta1.ExecutionProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
