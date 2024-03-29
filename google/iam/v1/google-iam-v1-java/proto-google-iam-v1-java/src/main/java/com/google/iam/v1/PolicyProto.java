// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/iam/v1/policy.proto

package com.google.iam.v1;

public final class PolicyProto {
  private PolicyProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_iam_v1_Policy_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_iam_v1_Policy_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_iam_v1_Binding_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_iam_v1_Binding_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_iam_v1_PolicyDelta_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_iam_v1_PolicyDelta_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_iam_v1_BindingDelta_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_iam_v1_BindingDelta_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_iam_v1_AuditConfigDelta_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_iam_v1_AuditConfigDelta_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\032google/iam/v1/policy.proto\022\rgoogle.iam" +
      ".v1\032\026google/type/expr.proto\032\034google/api/" +
      "annotations.proto\"Q\n\006Policy\022\017\n\007version\030\001" +
      " \001(\005\022(\n\010bindings\030\004 \003(\0132\026.google.iam.v1.B" +
      "inding\022\014\n\004etag\030\003 \001(\014\"N\n\007Binding\022\014\n\004role\030" +
      "\001 \001(\t\022\017\n\007members\030\002 \003(\t\022$\n\tcondition\030\003 \001(" +
      "\0132\021.google.type.Expr\"\200\001\n\013PolicyDelta\0223\n\016" +
      "binding_deltas\030\001 \003(\0132\033.google.iam.v1.Bin" +
      "dingDelta\022<\n\023audit_config_deltas\030\002 \003(\0132\037" +
      ".google.iam.v1.AuditConfigDelta\"\275\001\n\014Bind" +
      "ingDelta\0222\n\006action\030\001 \001(\0162\".google.iam.v1" +
      ".BindingDelta.Action\022\014\n\004role\030\002 \001(\t\022\016\n\006me" +
      "mber\030\003 \001(\t\022$\n\tcondition\030\004 \001(\0132\021.google.t" +
      "ype.Expr\"5\n\006Action\022\026\n\022ACTION_UNSPECIFIED" +
      "\020\000\022\007\n\003ADD\020\001\022\n\n\006REMOVE\020\002\"\275\001\n\020AuditConfigD" +
      "elta\0226\n\006action\030\001 \001(\0162&.google.iam.v1.Aud" +
      "itConfigDelta.Action\022\017\n\007service\030\002 \001(\t\022\027\n" +
      "\017exempted_member\030\003 \001(\t\022\020\n\010log_type\030\004 \001(\t" +
      "\"5\n\006Action\022\026\n\022ACTION_UNSPECIFIED\020\000\022\007\n\003AD" +
      "D\020\001\022\n\n\006REMOVE\020\002B\203\001\n\021com.google.iam.v1B\013P" +
      "olicyProtoP\001Z0google.golang.org/genproto" +
      "/googleapis/iam/v1;iam\370\001\001\252\002\023Google.Cloud" +
      ".Iam.V1\312\002\023Google\\Cloud\\Iam\\V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.type.ExprProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_iam_v1_Policy_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_iam_v1_Policy_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_iam_v1_Policy_descriptor,
        new java.lang.String[] { "Version", "Bindings", "Etag", });
    internal_static_google_iam_v1_Binding_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_iam_v1_Binding_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_iam_v1_Binding_descriptor,
        new java.lang.String[] { "Role", "Members", "Condition", });
    internal_static_google_iam_v1_PolicyDelta_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_iam_v1_PolicyDelta_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_iam_v1_PolicyDelta_descriptor,
        new java.lang.String[] { "BindingDeltas", "AuditConfigDeltas", });
    internal_static_google_iam_v1_BindingDelta_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_iam_v1_BindingDelta_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_iam_v1_BindingDelta_descriptor,
        new java.lang.String[] { "Action", "Role", "Member", "Condition", });
    internal_static_google_iam_v1_AuditConfigDelta_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_iam_v1_AuditConfigDelta_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_iam_v1_AuditConfigDelta_descriptor,
        new java.lang.String[] { "Action", "Service", "ExemptedMember", "LogType", });
    com.google.type.ExprProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
