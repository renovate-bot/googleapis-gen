// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/vision/v1p1beta1/geometry.proto

package com.google.cloud.vision.v1p1beta1;

public final class GeometryProto {
  private GeometryProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_vision_v1p1beta1_Vertex_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_vision_v1p1beta1_Vertex_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_vision_v1p1beta1_BoundingPoly_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_vision_v1p1beta1_BoundingPoly_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_vision_v1p1beta1_Position_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_vision_v1p1beta1_Position_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n,google/cloud/vision/v1p1beta1/geometry" +
      ".proto\022\035google.cloud.vision.v1p1beta1\"\036\n" +
      "\006Vertex\022\t\n\001x\030\001 \001(\005\022\t\n\001y\030\002 \001(\005\"G\n\014Boundin" +
      "gPoly\0227\n\010vertices\030\001 \003(\0132%.google.cloud.v" +
      "ision.v1p1beta1.Vertex\"+\n\010Position\022\t\n\001x\030" +
      "\001 \001(\002\022\t\n\001y\030\002 \001(\002\022\t\n\001z\030\003 \001(\002B|\n!com.googl" +
      "e.cloud.vision.v1p1beta1B\rGeometryProtoP" +
      "\001ZCgoogle.golang.org/genproto/googleapis" +
      "/cloud/vision/v1p1beta1;vision\370\001\001b\006proto" +
      "3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
        });
    internal_static_google_cloud_vision_v1p1beta1_Vertex_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_vision_v1p1beta1_Vertex_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_vision_v1p1beta1_Vertex_descriptor,
        new java.lang.String[] { "X", "Y", });
    internal_static_google_cloud_vision_v1p1beta1_BoundingPoly_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_vision_v1p1beta1_BoundingPoly_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_vision_v1p1beta1_BoundingPoly_descriptor,
        new java.lang.String[] { "Vertices", });
    internal_static_google_cloud_vision_v1p1beta1_Position_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_vision_v1p1beta1_Position_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_vision_v1p1beta1_Position_descriptor,
        new java.lang.String[] { "X", "Y", "Z", });
  }

  // @@protoc_insertion_point(outer_class_scope)
}
