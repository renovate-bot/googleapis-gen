// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/uptime_service.proto

package com.google.monitoring.v3;

public final class UptimeServiceProto {
  private UptimeServiceProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_ListUptimeCheckConfigsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_ListUptimeCheckConfigsResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_GetUptimeCheckConfigRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_GetUptimeCheckConfigRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_CreateUptimeCheckConfigRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_CreateUptimeCheckConfigRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_UpdateUptimeCheckConfigRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_UpdateUptimeCheckConfigRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_DeleteUptimeCheckConfigRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_DeleteUptimeCheckConfigRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_ListUptimeCheckIpsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_ListUptimeCheckIpsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_monitoring_v3_ListUptimeCheckIpsResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_monitoring_v3_ListUptimeCheckIpsResponse_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n)google/monitoring/v3/uptime_service.pr" +
      "oto\022\024google.monitoring.v3\032\034google/api/an" +
      "notations.proto\032\027google/api/client.proto" +
      "\032\037google/api/field_behavior.proto\032\031googl" +
      "e/api/resource.proto\032#google/longrunning" +
      "/operations.proto\032!google/monitoring/v3/" +
      "uptime.proto\032\036google/protobuf/duration.p" +
      "roto\032\033google/protobuf/empty.proto\032 googl" +
      "e/protobuf/field_mask.proto\"\213\001\n\035ListUpti" +
      "meCheckConfigsRequest\022C\n\006parent\030\001 \001(\tB3\340" +
      "A\002\372A-\022+monitoring.googleapis.com/UptimeC" +
      "heckConfig\022\021\n\tpage_size\030\003 \001(\005\022\022\n\npage_to" +
      "ken\030\004 \001(\t\"\224\001\n\036ListUptimeCheckConfigsResp" +
      "onse\022E\n\024uptime_check_configs\030\001 \003(\0132\'.goo" +
      "gle.monitoring.v3.UptimeCheckConfig\022\027\n\017n" +
      "ext_page_token\030\002 \001(\t\022\022\n\ntotal_size\030\003 \001(\005" +
      "\"`\n\033GetUptimeCheckConfigRequest\022A\n\004name\030" +
      "\001 \001(\tB3\340A\002\372A-\n+monitoring.googleapis.com" +
      "/UptimeCheckConfig\"\260\001\n\036CreateUptimeCheck" +
      "ConfigRequest\022C\n\006parent\030\001 \001(\tB3\340A\002\372A-\022+m" +
      "onitoring.googleapis.com/UptimeCheckConf" +
      "ig\022I\n\023uptime_check_config\030\002 \001(\0132\'.google" +
      ".monitoring.v3.UptimeCheckConfigB\003\340A\002\"\234\001" +
      "\n\036UpdateUptimeCheckConfigRequest\022/\n\013upda" +
      "te_mask\030\002 \001(\0132\032.google.protobuf.FieldMas" +
      "k\022I\n\023uptime_check_config\030\003 \001(\0132\'.google." +
      "monitoring.v3.UptimeCheckConfigB\003\340A\002\"c\n\036" +
      "DeleteUptimeCheckConfigRequest\022A\n\004name\030\001" +
      " \001(\tB3\340A\002\372A-\n+monitoring.googleapis.com/" +
      "UptimeCheckConfig\"B\n\031ListUptimeCheckIpsR" +
      "equest\022\021\n\tpage_size\030\002 \001(\005\022\022\n\npage_token\030" +
      "\003 \001(\t\"t\n\032ListUptimeCheckIpsResponse\022=\n\020u" +
      "ptime_check_ips\030\001 \003(\0132#.google.monitorin" +
      "g.v3.UptimeCheckIp\022\027\n\017next_page_token\030\002 " +
      "\001(\t2\275\n\n\022UptimeCheckService\022\300\001\n\026ListUptim" +
      "eCheckConfigs\0223.google.monitoring.v3.Lis" +
      "tUptimeCheckConfigsRequest\0324.google.moni" +
      "toring.v3.ListUptimeCheckConfigsResponse" +
      "\";\202\323\344\223\002,\022*/v3/{parent=projects/*}/uptime" +
      "CheckConfigs\332A\006parent\022\255\001\n\024GetUptimeCheck" +
      "Config\0221.google.monitoring.v3.GetUptimeC" +
      "heckConfigRequest\032\'.google.monitoring.v3" +
      ".UptimeCheckConfig\"9\202\323\344\223\002,\022*/v3/{name=pr" +
      "ojects/*/uptimeCheckConfigs/*}\332A\004name\022\336\001" +
      "\n\027CreateUptimeCheckConfig\0224.google.monit" +
      "oring.v3.CreateUptimeCheckConfigRequest\032" +
      "\'.google.monitoring.v3.UptimeCheckConfig" +
      "\"d\202\323\344\223\002A\"*/v3/{parent=projects/*}/uptime" +
      "CheckConfigs:\023uptime_check_config\332A\032pare" +
      "nt,uptime_check_config\022\353\001\n\027UpdateUptimeC" +
      "heckConfig\0224.google.monitoring.v3.Update" +
      "UptimeCheckConfigRequest\032\'.google.monito" +
      "ring.v3.UptimeCheckConfig\"q\202\323\344\223\002U2>/v3/{" +
      "uptime_check_config.name=projects/*/upti" +
      "meCheckConfigs/*}:\023uptime_check_config\332A" +
      "\023uptime_check_config\022\242\001\n\027DeleteUptimeChe" +
      "ckConfig\0224.google.monitoring.v3.DeleteUp" +
      "timeCheckConfigRequest\032\026.google.protobuf" +
      ".Empty\"9\202\323\344\223\002,**/v3/{name=projects/*/upt" +
      "imeCheckConfigs/*}\332A\004name\022\223\001\n\022ListUptime" +
      "CheckIps\022/.google.monitoring.v3.ListUpti" +
      "meCheckIpsRequest\0320.google.monitoring.v3" +
      ".ListUptimeCheckIpsResponse\"\032\202\323\344\223\002\024\022\022/v3" +
      "/uptimeCheckIps\032\251\001\312A\031monitoring.googleap" +
      "is.com\322A\211\001https://www.googleapis.com/aut" +
      "h/cloud-platform,https://www.googleapis." +
      "com/auth/monitoring,https://www.googleap" +
      "is.com/auth/monitoring.readB\312\001\n\030com.goog" +
      "le.monitoring.v3B\022UptimeServiceProtoP\001Z>" +
      "google.golang.org/genproto/googleapis/mo" +
      "nitoring/v3;monitoring\252\002\032Google.Cloud.Mo" +
      "nitoring.V3\312\002\032Google\\Cloud\\Monitoring\\V3" +
      "\352\002\035Google::Cloud::Monitoring::V3b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.ClientProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.longrunning.OperationsProto.getDescriptor(),
          com.google.monitoring.v3.UptimeProto.getDescriptor(),
          com.google.protobuf.DurationProto.getDescriptor(),
          com.google.protobuf.EmptyProto.getDescriptor(),
          com.google.protobuf.FieldMaskProto.getDescriptor(),
        });
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsRequest_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_ListUptimeCheckConfigsRequest_descriptor,
        new java.lang.String[] { "Parent", "PageSize", "PageToken", });
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsResponse_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_monitoring_v3_ListUptimeCheckConfigsResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_ListUptimeCheckConfigsResponse_descriptor,
        new java.lang.String[] { "UptimeCheckConfigs", "NextPageToken", "TotalSize", });
    internal_static_google_monitoring_v3_GetUptimeCheckConfigRequest_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_monitoring_v3_GetUptimeCheckConfigRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_GetUptimeCheckConfigRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_monitoring_v3_CreateUptimeCheckConfigRequest_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_monitoring_v3_CreateUptimeCheckConfigRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_CreateUptimeCheckConfigRequest_descriptor,
        new java.lang.String[] { "Parent", "UptimeCheckConfig", });
    internal_static_google_monitoring_v3_UpdateUptimeCheckConfigRequest_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_monitoring_v3_UpdateUptimeCheckConfigRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_UpdateUptimeCheckConfigRequest_descriptor,
        new java.lang.String[] { "UpdateMask", "UptimeCheckConfig", });
    internal_static_google_monitoring_v3_DeleteUptimeCheckConfigRequest_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_monitoring_v3_DeleteUptimeCheckConfigRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_DeleteUptimeCheckConfigRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_monitoring_v3_ListUptimeCheckIpsRequest_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_monitoring_v3_ListUptimeCheckIpsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_ListUptimeCheckIpsRequest_descriptor,
        new java.lang.String[] { "PageSize", "PageToken", });
    internal_static_google_monitoring_v3_ListUptimeCheckIpsResponse_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_monitoring_v3_ListUptimeCheckIpsResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_monitoring_v3_ListUptimeCheckIpsResponse_descriptor,
        new java.lang.String[] { "UptimeCheckIps", "NextPageToken", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    registry.add(com.google.api.ClientProto.methodSignature);
    registry.add(com.google.api.ClientProto.oauthScopes);
    registry.add(com.google.api.ResourceProto.resourceReference);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.ClientProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.longrunning.OperationsProto.getDescriptor();
    com.google.monitoring.v3.UptimeProto.getDescriptor();
    com.google.protobuf.DurationProto.getDescriptor();
    com.google.protobuf.EmptyProto.getDescriptor();
    com.google.protobuf.FieldMaskProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
