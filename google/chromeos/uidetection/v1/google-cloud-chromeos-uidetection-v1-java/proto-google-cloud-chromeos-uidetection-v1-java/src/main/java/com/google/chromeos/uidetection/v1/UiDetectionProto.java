// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/chromeos/uidetection/v1/ui_detection.proto

package com.google.chromeos.uidetection.v1;

public final class UiDetectionProto {
  private UiDetectionProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_UiDetectionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_UiDetectionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_DetectionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_DetectionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_WordDetectionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_WordDetectionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_TextBlockDetectionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_TextBlockDetectionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_CustomIconDetectionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_CustomIconDetectionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_UiDetectionResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_UiDetectionResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_chromeos_uidetection_v1_BoundingBox_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_chromeos_uidetection_v1_BoundingBox_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n1google/chromeos/uidetection/v1/ui_dete" +
      "ction.proto\022\036google.chromeos.uidetection" +
      ".v1\032\034google/api/annotations.proto\032\037googl" +
      "e/api/field_behavior.proto\032\027google/api/c" +
      "lient.proto\"t\n\022UiDetectionRequest\022\026\n\tima" +
      "ge_png\030\001 \001(\014B\003\340A\002\022F\n\007request\030\002 \001(\01320.goo" +
      "gle.chromeos.uidetection.v1.DetectionReq" +
      "uestB\003\340A\002\"\314\002\n\020DetectionRequest\022V\n\026word_d" +
      "etection_request\030\001 \001(\01324.google.chromeos" +
      ".uidetection.v1.WordDetectionRequestH\000\022a" +
      "\n\034text_block_detection_request\030\002 \001(\01329.g" +
      "oogle.chromeos.uidetection.v1.TextBlockD" +
      "etectionRequestH\000\022c\n\035custom_icon_detecti" +
      "on_request\030\003 \001(\0132:.google.chromeos.uidet" +
      "ection.v1.CustomIconDetectionRequestH\000B\030" +
      "\n\026detection_request_type\")\n\024WordDetectio" +
      "nRequest\022\021\n\004word\030\001 \001(\tB\003\340A\002\"/\n\031TextBlock" +
      "DetectionRequest\022\022\n\005words\030\001 \003(\tB\003\340A\002\"3\n\032" +
      "CustomIconDetectionRequest\022\025\n\010icon_png\030\001" +
      " \001(\014B\003\340A\002\"Z\n\023UiDetectionResponse\022C\n\016boun" +
      "ding_boxes\030\001 \003(\0132+.google.chromeos.uidet" +
      "ection.v1.BoundingBox\"U\n\013BoundingBox\022\014\n\004" +
      "text\030\001 \001(\t\022\013\n\003top\030\002 \001(\005\022\014\n\004left\030\003 \001(\005\022\016\n" +
      "\006bottom\030\004 \001(\005\022\r\n\005right\030\005 \001(\0052\337\001\n\022UiDetec" +
      "tionService\022\241\001\n\020ExecuteDetection\0222.googl" +
      "e.chromeos.uidetection.v1.UiDetectionReq" +
      "uest\0323.google.chromeos.uidetection.v1.Ui" +
      "DetectionResponse\"$\202\323\344\223\002\036\022\034/v1/executeDe" +
      "tection:execute\032%\312A\"chromeosuidetection." +
      "googleapis.comB\203\001\n\"com.google.chromeos.u" +
      "idetection.v1B\020UiDetectionProtoP\001ZIgoogl" +
      "e.golang.org/genproto/googleapis/chromeo" +
      "s/uidetection/v1;uidetectionb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ClientProto.getDescriptor(),
        });
    internal_static_google_chromeos_uidetection_v1_UiDetectionRequest_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_chromeos_uidetection_v1_UiDetectionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_UiDetectionRequest_descriptor,
        new java.lang.String[] { "ImagePng", "Request", });
    internal_static_google_chromeos_uidetection_v1_DetectionRequest_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_chromeos_uidetection_v1_DetectionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_DetectionRequest_descriptor,
        new java.lang.String[] { "WordDetectionRequest", "TextBlockDetectionRequest", "CustomIconDetectionRequest", "DetectionRequestType", });
    internal_static_google_chromeos_uidetection_v1_WordDetectionRequest_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_chromeos_uidetection_v1_WordDetectionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_WordDetectionRequest_descriptor,
        new java.lang.String[] { "Word", });
    internal_static_google_chromeos_uidetection_v1_TextBlockDetectionRequest_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_chromeos_uidetection_v1_TextBlockDetectionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_TextBlockDetectionRequest_descriptor,
        new java.lang.String[] { "Words", });
    internal_static_google_chromeos_uidetection_v1_CustomIconDetectionRequest_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_chromeos_uidetection_v1_CustomIconDetectionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_CustomIconDetectionRequest_descriptor,
        new java.lang.String[] { "IconPng", });
    internal_static_google_chromeos_uidetection_v1_UiDetectionResponse_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_chromeos_uidetection_v1_UiDetectionResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_UiDetectionResponse_descriptor,
        new java.lang.String[] { "BoundingBoxes", });
    internal_static_google_chromeos_uidetection_v1_BoundingBox_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_chromeos_uidetection_v1_BoundingBox_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_chromeos_uidetection_v1_BoundingBox_descriptor,
        new java.lang.String[] { "Text", "Top", "Left", "Bottom", "Right", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ClientProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
