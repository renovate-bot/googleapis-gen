// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/datatransfer/v1/transfer.proto

package com.google.cloud.bigquery.datatransfer.v1;

public final class TransferProto {
  private TransferProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_EmailPreferences_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_EmailPreferences_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n4google/cloud/bigquery/datatransfer/v1/" +
      "transfer.proto\022%google.cloud.bigquery.da" +
      "tatransfer.v1\032\037google/api/field_behavior" +
      ".proto\032\031google/api/resource.proto\032\034googl" +
      "e/protobuf/struct.proto\032\037google/protobuf" +
      "/timestamp.proto\032\027google/rpc/status.prot" +
      "o\"0\n\020EmailPreferences\022\034\n\024enable_failure_" +
      "email\030\001 \001(\010\"\220\001\n\017ScheduleOptions\022\037\n\027disab" +
      "le_auto_scheduling\030\003 \001(\010\022.\n\nstart_time\030\001" +
      " \001(\0132\032.google.protobuf.Timestamp\022,\n\010end_" +
      "time\030\002 \001(\0132\032.google.protobuf.Timestamp\"\327" +
      "\006\n\016TransferConfig\022\014\n\004name\030\001 \001(\t\022 \n\026desti" +
      "nation_dataset_id\030\002 \001(\tH\000\022\024\n\014display_nam" +
      "e\030\003 \001(\t\022\026\n\016data_source_id\030\005 \001(\t\022\'\n\006param" +
      "s\030\t \001(\0132\027.google.protobuf.Struct\022\020\n\010sche" +
      "dule\030\007 \001(\t\022P\n\020schedule_options\030\030 \001(\01326.g" +
      "oogle.cloud.bigquery.datatransfer.v1.Sch" +
      "eduleOptions\022 \n\030data_refresh_window_days" +
      "\030\014 \001(\005\022\020\n\010disabled\030\r \001(\010\0224\n\013update_time\030" +
      "\004 \001(\0132\032.google.protobuf.TimestampB\003\340A\003\0226" +
      "\n\rnext_run_time\030\010 \001(\0132\032.google.protobuf." +
      "TimestampB\003\340A\003\022H\n\005state\030\n \001(\01624.google.c" +
      "loud.bigquery.datatransfer.v1.TransferSt" +
      "ateB\003\340A\003\022\017\n\007user_id\030\013 \001(\003\022\033\n\016dataset_reg" +
      "ion\030\016 \001(\tB\003\340A\003\022!\n\031notification_pubsub_to" +
      "pic\030\017 \001(\t\022R\n\021email_preferences\030\022 \001(\01327.g" +
      "oogle.cloud.bigquery.datatransfer.v1.Ema" +
      "ilPreferences:\271\001\352A\265\001\n2bigquerydatatransf" +
      "er.googleapis.com/TransferConfig\0224projec" +
      "ts/{project}/transferConfigs/{transfer_c" +
      "onfig}\022Iprojects/{project}/locations/{lo" +
      "cation}/transferConfigs/{transfer_config" +
      "}B\r\n\013destination\"\372\006\n\013TransferRun\022\014\n\004name" +
      "\030\001 \001(\t\0221\n\rschedule_time\030\003 \001(\0132\032.google.p" +
      "rotobuf.Timestamp\022,\n\010run_time\030\n \001(\0132\032.go" +
      "ogle.protobuf.Timestamp\022(\n\014error_status\030" +
      "\025 \001(\0132\022.google.rpc.Status\0223\n\nstart_time\030" +
      "\004 \001(\0132\032.google.protobuf.TimestampB\003\340A\003\0221" +
      "\n\010end_time\030\005 \001(\0132\032.google.protobuf.Times" +
      "tampB\003\340A\003\0224\n\013update_time\030\006 \001(\0132\032.google." +
      "protobuf.TimestampB\003\340A\003\022,\n\006params\030\t \001(\0132" +
      "\027.google.protobuf.StructB\003\340A\003\022%\n\026destina" +
      "tion_dataset_id\030\002 \001(\tB\003\340A\003H\000\022\033\n\016data_sou" +
      "rce_id\030\007 \001(\tB\003\340A\003\022C\n\005state\030\010 \001(\01624.googl" +
      "e.cloud.bigquery.datatransfer.v1.Transfe" +
      "rState\022\017\n\007user_id\030\013 \001(\003\022\025\n\010schedule\030\014 \001(" +
      "\tB\003\340A\003\022&\n\031notification_pubsub_topic\030\027 \001(" +
      "\tB\003\340A\003\022W\n\021email_preferences\030\031 \001(\01327.goog" +
      "le.cloud.bigquery.datatransfer.v1.EmailP" +
      "referencesB\003\340A\003:\304\001\352A\300\001\n\'bigquerydatatran" +
      "sfer.googleapis.com/Run\022?projects/{proje" +
      "ct}/transferConfigs/{transfer_config}/ru" +
      "ns/{run}\022Tprojects/{project}/locations/{" +
      "location}/transferConfigs/{transfer_conf" +
      "ig}/runs/{run}B\r\n\013destination\"\212\002\n\017Transf" +
      "erMessage\0220\n\014message_time\030\001 \001(\0132\032.google" +
      ".protobuf.Timestamp\022X\n\010severity\030\002 \001(\0162F." +
      "google.cloud.bigquery.datatransfer.v1.Tr" +
      "ansferMessage.MessageSeverity\022\024\n\014message" +
      "_text\030\003 \001(\t\"U\n\017MessageSeverity\022 \n\034MESSAG" +
      "E_SEVERITY_UNSPECIFIED\020\000\022\010\n\004INFO\020\001\022\013\n\007WA" +
      "RNING\020\002\022\t\n\005ERROR\020\003*K\n\014TransferType\022\035\n\031TR" +
      "ANSFER_TYPE_UNSPECIFIED\020\000\022\t\n\005BATCH\020\001\022\r\n\t" +
      "STREAMING\020\002\032\002\030\001*s\n\rTransferState\022\036\n\032TRAN" +
      "SFER_STATE_UNSPECIFIED\020\000\022\013\n\007PENDING\020\002\022\013\n" +
      "\007RUNNING\020\003\022\r\n\tSUCCEEDED\020\004\022\n\n\006FAILED\020\005\022\r\n" +
      "\tCANCELLED\020\006B\223\002\n)com.google.cloud.bigque" +
      "ry.datatransfer.v1B\rTransferProtoP\001ZQgoo" +
      "gle.golang.org/genproto/googleapis/cloud" +
      "/bigquery/datatransfer/v1;datatransfer\242\002" +
      "\005GCBDT\252\002%Google.Cloud.BigQuery.DataTrans" +
      "fer.V1\312\002%Google\\Cloud\\BigQuery\\DataTrans" +
      "fer\\V1\352\002)Google::Cloud::Bigquery::DataTr" +
      "ansfer::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.protobuf.StructProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.rpc.StatusProto.getDescriptor(),
        });
    internal_static_google_cloud_bigquery_datatransfer_v1_EmailPreferences_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_bigquery_datatransfer_v1_EmailPreferences_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_EmailPreferences_descriptor,
        new java.lang.String[] { "EnableFailureEmail", });
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor,
        new java.lang.String[] { "DisableAutoScheduling", "StartTime", "EndTime", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor,
        new java.lang.String[] { "Name", "DestinationDatasetId", "DisplayName", "DataSourceId", "Params", "Schedule", "ScheduleOptions", "DataRefreshWindowDays", "Disabled", "UpdateTime", "NextRunTime", "State", "UserId", "DatasetRegion", "NotificationPubsubTopic", "EmailPreferences", "Destination", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor,
        new java.lang.String[] { "Name", "ScheduleTime", "RunTime", "ErrorStatus", "StartTime", "EndTime", "UpdateTime", "Params", "DestinationDatasetId", "DataSourceId", "State", "UserId", "Schedule", "NotificationPubsubTopic", "EmailPreferences", "Destination", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor,
        new java.lang.String[] { "MessageTime", "Severity", "MessageText", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.protobuf.StructProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.rpc.StatusProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
