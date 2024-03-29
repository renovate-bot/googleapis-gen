// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1/external_system.proto

package com.google.cloud.securitycenter.v1;

public final class ExternalSystemProto {
  private ExternalSystemProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1_ExternalSystem_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1_ExternalSystem_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n4google/cloud/securitycenter/v1/externa" +
      "l_system.proto\022\036google.cloud.securitycen" +
      "ter.v1\032\031google/api/resource.proto\032\037googl" +
      "e/protobuf/timestamp.proto\032\034google/api/a" +
      "nnotations.proto\"\340\003\n\016ExternalSystem\022\014\n\004n" +
      "ame\030\001 \001(\t\022\021\n\tassignees\030\002 \003(\t\022\024\n\014external" +
      "_uid\030\003 \001(\t\022\016\n\006status\030\004 \001(\t\022?\n\033external_s" +
      "ystem_update_time\030\005 \001(\0132\032.google.protobu" +
      "f.Timestamp:\305\002\352A\301\002\n,securitycenter.googl" +
      "eapis.com/ExternalSystem\022aorganizations/" +
      "{organization}/sources/{source}/findings" +
      "/{finding}/externalSystems/{externalsyst" +
      "em}\022Ufolders/{folder}/sources/{source}/f" +
      "indings/{finding}/externalSystems/{exter" +
      "nalsystem}\022Wprojects/{project}/sources/{" +
      "source}/findings/{finding}/externalSyste" +
      "ms/{externalsystem}B\357\001\n\"com.google.cloud" +
      ".securitycenter.v1B\023ExternalSystemProtoP" +
      "\001ZLgoogle.golang.org/genproto/googleapis" +
      "/cloud/securitycenter/v1;securitycenter\252" +
      "\002\036Google.Cloud.SecurityCenter.V1\312\002\036Googl" +
      "e\\Cloud\\SecurityCenter\\V1\352\002!Google::Clou" +
      "d::SecurityCenter::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.ResourceProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_securitycenter_v1_ExternalSystem_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_securitycenter_v1_ExternalSystem_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1_ExternalSystem_descriptor,
        new java.lang.String[] { "Name", "Assignees", "ExternalUid", "Status", "ExternalSystemUpdateTime", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.ResourceProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
