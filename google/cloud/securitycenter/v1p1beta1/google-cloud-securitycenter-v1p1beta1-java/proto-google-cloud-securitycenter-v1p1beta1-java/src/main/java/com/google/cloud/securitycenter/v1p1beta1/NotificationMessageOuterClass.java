// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1p1beta1/notification_message.proto

package com.google.cloud.securitycenter.v1p1beta1;

public final class NotificationMessageOuterClass {
  private NotificationMessageOuterClass() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1p1beta1_NotificationMessage_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1p1beta1_NotificationMessage_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n@google/cloud/securitycenter/v1p1beta1/" +
      "notification_message.proto\022%google.cloud" +
      ".securitycenter.v1p1beta1\0323google/cloud/" +
      "securitycenter/v1p1beta1/finding.proto\0324" +
      "google/cloud/securitycenter/v1p1beta1/re" +
      "source.proto\032\034google/api/annotations.pro" +
      "to\"\306\001\n\023NotificationMessage\022 \n\030notificati" +
      "on_config_name\030\001 \001(\t\022A\n\007finding\030\002 \001(\0132.." +
      "google.cloud.securitycenter.v1p1beta1.Fi" +
      "ndingH\000\022A\n\010resource\030\003 \001(\0132/.google.cloud" +
      ".securitycenter.v1p1beta1.ResourceB\007\n\005ev" +
      "entB\375\001\n)com.google.cloud.securitycenter." +
      "v1p1beta1P\001ZSgoogle.golang.org/genproto/" +
      "googleapis/cloud/securitycenter/v1p1beta" +
      "1;securitycenter\252\002%Google.Cloud.Security" +
      "Center.V1P1Beta1\312\002%Google\\Cloud\\Security" +
      "Center\\V1p1beta1\352\002(Google::Cloud::Securi" +
      "tyCenter::V1p1beta1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.cloud.securitycenter.v1p1beta1.FindingOuterClass.getDescriptor(),
          com.google.cloud.securitycenter.v1p1beta1.ResourceProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_securitycenter_v1p1beta1_NotificationMessage_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_securitycenter_v1p1beta1_NotificationMessage_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1p1beta1_NotificationMessage_descriptor,
        new java.lang.String[] { "NotificationConfigName", "Finding", "Resource", "Event", });
    com.google.cloud.securitycenter.v1p1beta1.FindingOuterClass.getDescriptor();
    com.google.cloud.securitycenter.v1p1beta1.ResourceProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
