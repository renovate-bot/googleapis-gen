// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/answer_record.proto

package com.google.cloud.dialogflow.v2;

public final class AnswerRecordsProto {
  private AnswerRecordsProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_AnswerRecord_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_AnswerRecord_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_AnswerFeedback_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_AnswerFeedback_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_AgentAssistantFeedback_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_AgentAssistantFeedback_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_dialogflow_v2_AgentAssistantRecord_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_dialogflow_v2_AgentAssistantRecord_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n.google/cloud/dialogflow/v2/answer_reco" +
      "rd.proto\022\032google.cloud.dialogflow.v2\032\034go" +
      "ogle/api/annotations.proto\032\027google/api/c" +
      "lient.proto\032\037google/api/field_behavior.p" +
      "roto\032\031google/api/resource.proto\032,google/" +
      "cloud/dialogflow/v2/participant.proto\032\033g" +
      "oogle/protobuf/empty.proto\032 google/proto" +
      "buf/field_mask.proto\032\037google/protobuf/ti" +
      "mestamp.proto\"\361\002\n\014AnswerRecord\022\014\n\004name\030\001" +
      " \001(\t\022H\n\017answer_feedback\030\002 \001(\0132*.google.c" +
      "loud.dialogflow.v2.AnswerFeedbackB\003\340A\002\022W" +
      "\n\026agent_assistant_record\030\004 \001(\01320.google." +
      "cloud.dialogflow.v2.AgentAssistantRecord" +
      "B\003\340A\003H\000:\245\001\352A\241\001\n&dialogflow.googleapis.co" +
      "m/AnswerRecord\0220projects/{project}/answe" +
      "rRecords/{answer_record}\022Eprojects/{proj" +
      "ect}/locations/{location}/answerRecords/" +
      "{answer_record}B\010\n\006record\"\240\001\n\030ListAnswer" +
      "RecordsRequest\022>\n\006parent\030\001 \001(\tB.\340A\002\372A(\022&" +
      "dialogflow.googleapis.com/AnswerRecord\022\023" +
      "\n\006filter\030\002 \001(\tB\003\340A\002\022\026\n\tpage_size\030\003 \001(\005B\003" +
      "\340A\001\022\027\n\npage_token\030\004 \001(\tB\003\340A\001\"v\n\031ListAnsw" +
      "erRecordsResponse\022@\n\016answer_records\030\001 \003(" +
      "\0132(.google.cloud.dialogflow.v2.AnswerRec" +
      "ord\022\027\n\017next_page_token\030\002 \001(\t\"\302\001\n\031UpdateA" +
      "nswerRecordRequest\022o\n\ranswer_record\030\001 \001(" +
      "\0132(.google.cloud.dialogflow.v2.AnswerRec" +
      "ordB.\340A\002\372A(\n&dialogflow.googleapis.com/A" +
      "nswerRecord\0224\n\013update_mask\030\002 \001(\0132\032.googl" +
      "e.protobuf.FieldMaskB\003\340A\002\"\322\003\n\016AnswerFeed" +
      "back\022V\n\021correctness_level\030\001 \001(\0162;.google" +
      ".cloud.dialogflow.v2.AnswerFeedback.Corr" +
      "ectnessLevel\022]\n\037agent_assistant_detail_f" +
      "eedback\030\002 \001(\01322.google.cloud.dialogflow." +
      "v2.AgentAssistantFeedbackH\000\022\017\n\007clicked\030\003" +
      " \001(\010\022.\n\nclick_time\030\005 \001(\0132\032.google.protob" +
      "uf.Timestamp\022\021\n\tdisplayed\030\004 \001(\010\0220\n\014displ" +
      "ay_time\030\006 \001(\0132\032.google.protobuf.Timestam" +
      "p\"p\n\020CorrectnessLevel\022!\n\035CORRECTNESS_LEV" +
      "EL_UNSPECIFIED\020\000\022\017\n\013NOT_CORRECT\020\001\022\025\n\021PAR" +
      "TIALLY_CORRECT\020\002\022\021\n\rFULLY_CORRECT\020\003B\021\n\017d" +
      "etail_feedback\"\326\004\n\026AgentAssistantFeedbac" +
      "k\022a\n\020answer_relevance\030\001 \001(\0162B.google.clo" +
      "ud.dialogflow.v2.AgentAssistantFeedback." +
      "AnswerRelevanceB\003\340A\001\022i\n\024document_correct" +
      "ness\030\002 \001(\0162F.google.cloud.dialogflow.v2." +
      "AgentAssistantFeedback.DocumentCorrectne" +
      "ssB\003\340A\001\022g\n\023document_efficiency\030\003 \001(\0162E.g" +
      "oogle.cloud.dialogflow.v2.AgentAssistant" +
      "Feedback.DocumentEfficiencyB\003\340A\001\"Q\n\017Answ" +
      "erRelevance\022 \n\034ANSWER_RELEVANCE_UNSPECIF" +
      "IED\020\000\022\016\n\nIRRELEVANT\020\001\022\014\n\010RELEVANT\020\002\"W\n\023D" +
      "ocumentCorrectness\022$\n DOCUMENT_CORRECTNE" +
      "SS_UNSPECIFIED\020\000\022\r\n\tINCORRECT\020\001\022\013\n\007CORRE" +
      "CT\020\002\"Y\n\022DocumentEfficiency\022#\n\037DOCUMENT_E" +
      "FFICIENCY_UNSPECIFIED\020\000\022\017\n\013INEFFICIENT\020\001" +
      "\022\r\n\tEFFICIENT\020\002\"\267\001\n\024AgentAssistantRecord" +
      "\022S\n\031article_suggestion_answer\030\005 \001(\0132).go" +
      "ogle.cloud.dialogflow.v2.ArticleAnswerB\003" +
      "\340A\003H\000\022@\n\nfaq_answer\030\006 \001(\0132%.google.cloud" +
      ".dialogflow.v2.FaqAnswerB\003\340A\003H\000B\010\n\006answe" +
      "r2\255\005\n\rAnswerRecords\022\355\001\n\021ListAnswerRecord" +
      "s\0224.google.cloud.dialogflow.v2.ListAnswe" +
      "rRecordsRequest\0325.google.cloud.dialogflo" +
      "w.v2.ListAnswerRecordsResponse\"k\202\323\344\223\002\\\022%" +
      "/v2/{parent=projects/*}/answerRecordsZ3\022" +
      "1/v2/{parent=projects/*/locations/*}/ans" +
      "werRecords\332A\006parent\022\261\002\n\022UpdateAnswerReco" +
      "rd\0225.google.cloud.dialogflow.v2.UpdateAn" +
      "swerRecordRequest\032(.google.cloud.dialogf" +
      "low.v2.AnswerRecord\"\271\001\202\323\344\223\002\226\00123/v2/{answ" +
      "er_record.name=projects/*/answerRecords/" +
      "*}:\ranswer_recordZP2?/v2/{answer_record." +
      "name=projects/*/locations/*/answerRecord" +
      "s/*}:\ranswer_record\332A\031answer_record,upda" +
      "te_mask\032x\312A\031dialogflow.googleapis.com\322AY" +
      "https://www.googleapis.com/auth/cloud-pl" +
      "atform,https://www.googleapis.com/auth/d" +
      "ialogflowB\241\001\n\036com.google.cloud.dialogflo" +
      "w.v2B\022AnswerRecordsProtoP\001ZDgoogle.golan" +
      "g.org/genproto/googleapis/cloud/dialogfl" +
      "ow/v2;dialogflow\370\001\001\242\002\002DF\252\002\032Google.Cloud." +
      "Dialogflow.V2b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.ClientProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.cloud.dialogflow.v2.ParticipantProto.getDescriptor(),
          com.google.protobuf.EmptyProto.getDescriptor(),
          com.google.protobuf.FieldMaskProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
        });
    internal_static_google_cloud_dialogflow_v2_AnswerRecord_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_dialogflow_v2_AnswerRecord_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_AnswerRecord_descriptor,
        new java.lang.String[] { "Name", "AnswerFeedback", "AgentAssistantRecord", "Record", });
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsRequest_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsRequest_descriptor,
        new java.lang.String[] { "Parent", "Filter", "PageSize", "PageToken", });
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsResponse_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_ListAnswerRecordsResponse_descriptor,
        new java.lang.String[] { "AnswerRecords", "NextPageToken", });
    internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor,
        new java.lang.String[] { "AnswerRecord", "UpdateMask", });
    internal_static_google_cloud_dialogflow_v2_AnswerFeedback_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_cloud_dialogflow_v2_AnswerFeedback_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_AnswerFeedback_descriptor,
        new java.lang.String[] { "CorrectnessLevel", "AgentAssistantDetailFeedback", "Clicked", "ClickTime", "Displayed", "DisplayTime", "DetailFeedback", });
    internal_static_google_cloud_dialogflow_v2_AgentAssistantFeedback_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_cloud_dialogflow_v2_AgentAssistantFeedback_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_AgentAssistantFeedback_descriptor,
        new java.lang.String[] { "AnswerRelevance", "DocumentCorrectness", "DocumentEfficiency", });
    internal_static_google_cloud_dialogflow_v2_AgentAssistantRecord_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_cloud_dialogflow_v2_AgentAssistantRecord_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_dialogflow_v2_AgentAssistantRecord_descriptor,
        new java.lang.String[] { "ArticleSuggestionAnswer", "FaqAnswer", "Answer", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    registry.add(com.google.api.ClientProto.methodSignature);
    registry.add(com.google.api.ClientProto.oauthScopes);
    registry.add(com.google.api.ResourceProto.resource);
    registry.add(com.google.api.ResourceProto.resourceReference);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.ClientProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.cloud.dialogflow.v2.ParticipantProto.getDescriptor();
    com.google.protobuf.EmptyProto.getDescriptor();
    com.google.protobuf.FieldMaskProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
