// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/partner/aistreams/v1alpha1/aistreams.proto

package com.google.partner.aistreams.v1alpha1;

public final class AIStreamsProto {
  private AIStreamsProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_Cluster_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_Cluster_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_Cluster_LabelsEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_Cluster_LabelsEntry_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_ListClustersRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_ListClustersRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_ListClustersResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_ListClustersResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_GetClusterRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_GetClusterRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_CreateClusterRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_CreateClusterRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_UpdateClusterRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_UpdateClusterRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_DeleteClusterRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_DeleteClusterRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_Stream_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_Stream_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_Stream_LabelsEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_Stream_LabelsEntry_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_ListStreamsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_ListStreamsResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_GetStreamRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_GetStreamRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_CreateStreamRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_CreateStreamRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_UpdateStreamRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_UpdateStreamRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_DeleteStreamRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_DeleteStreamRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_partner_aistreams_v1alpha1_OperationMetadata_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_partner_aistreams_v1alpha1_OperationMetadata_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n1google/partner/aistreams/v1alpha1/aist" +
      "reams.proto\022!google.partner.aistreams.v1" +
      "alpha1\032\034google/api/annotations.proto\032\027go" +
      "ogle/api/client.proto\032\037google/api/field_" +
      "behavior.proto\032\031google/api/resource.prot" +
      "o\032#google/longrunning/operations.proto\032 " +
      "google/protobuf/field_mask.proto\032\037google" +
      "/protobuf/timestamp.proto\"\226\003\n\007Cluster\022\014\n" +
      "\004name\030\001 \001(\t\0224\n\013create_time\030\002 \001(\0132\032.googl" +
      "e.protobuf.TimestampB\003\340A\003\0224\n\013update_time" +
      "\030\003 \001(\0132\032.google.protobuf.TimestampB\003\340A\003\022" +
      "F\n\006labels\030\004 \003(\01326.google.partner.aistrea" +
      "ms.v1alpha1.Cluster.LabelsEntry\022\030\n\013certi" +
      "ficate\030\005 \001(\tB\003\340A\003\022\035\n\020service_endpoint\030\006 " +
      "\001(\tB\003\340A\003\032-\n\013LabelsEntry\022\013\n\003key\030\001 \001(\t\022\r\n\005" +
      "value\030\002 \001(\t:\0028\001:a\352A^\n aistreams.googleap" +
      "is.com/Cluster\022:projects/{project}/locat" +
      "ions/{location}/clusters/{cluster}\"\231\001\n\023L" +
      "istClustersRequest\0229\n\006parent\030\001 \001(\tB)\340A\002\372" +
      "A#\n!locations.googleapis.com/Location\022\021\n" +
      "\tpage_size\030\002 \001(\005\022\022\n\npage_token\030\003 \001(\t\022\016\n\006" +
      "filter\030\004 \001(\t\022\020\n\010order_by\030\005 \001(\t\"\202\001\n\024ListC" +
      "lustersResponse\022<\n\010clusters\030\001 \003(\0132*.goog" +
      "le.partner.aistreams.v1alpha1.Cluster\022\027\n" +
      "\017next_page_token\030\002 \001(\t\022\023\n\013unreachable\030\003 " +
      "\003(\t\"K\n\021GetClusterRequest\0226\n\004name\030\001 \001(\tB(" +
      "\340A\002\372A\"\n aistreams.googleapis.com/Cluster" +
      "\"\305\001\n\024CreateClusterRequest\0229\n\006parent\030\001 \001(" +
      "\tB)\340A\002\372A#\n!locations.googleapis.com/Loca" +
      "tion\022\027\n\ncluster_id\030\002 \001(\tB\003\340A\002\022@\n\007cluster" +
      "\030\003 \001(\0132*.google.partner.aistreams.v1alph" +
      "a1.ClusterB\003\340A\002\022\027\n\nrequest_id\030\004 \001(\tB\003\340A\001" +
      "\"\247\001\n\024UpdateClusterRequest\0224\n\013update_mask" +
      "\030\001 \001(\0132\032.google.protobuf.FieldMaskB\003\340A\002\022" +
      "@\n\007cluster\030\002 \001(\0132*.google.partner.aistre" +
      "ams.v1alpha1.ClusterB\003\340A\002\022\027\n\nrequest_id\030" +
      "\003 \001(\tB\003\340A\001\"g\n\024DeleteClusterRequest\0226\n\004na" +
      "me\030\001 \001(\tB(\340A\002\372A\"\n aistreams.googleapis.c" +
      "om/Cluster\022\027\n\nrequest_id\030\002 \001(\tB\003\340A\001\"\353\002\n\006" +
      "Stream\022\014\n\004name\030\001 \001(\t\0224\n\013create_time\030\002 \001(" +
      "\0132\032.google.protobuf.TimestampB\003\340A\003\0224\n\013up" +
      "date_time\030\003 \001(\0132\032.google.protobuf.Timest" +
      "ampB\003\340A\003\022E\n\006labels\030\004 \003(\01325.google.partne" +
      "r.aistreams.v1alpha1.Stream.LabelsEntry\032" +
      "-\n\013LabelsEntry\022\013\n\003key\030\001 \001(\t\022\r\n\005value\030\002 \001" +
      "(\t:\0028\001:q\352An\n\037aistreams.googleapis.com/St" +
      "ream\022Kprojects/{project}/locations/{loca" +
      "tion}/clusters/{cluster}/streams/{stream" +
      "}\"\227\001\n\022ListStreamsRequest\0228\n\006parent\030\001 \001(\t" +
      "B(\340A\002\372A\"\n aistreams.googleapis.com/Clust" +
      "er\022\021\n\tpage_size\030\002 \001(\005\022\022\n\npage_token\030\003 \001(" +
      "\t\022\016\n\006filter\030\004 \001(\t\022\020\n\010order_by\030\005 \001(\t\"\177\n\023L" +
      "istStreamsResponse\022:\n\007streams\030\001 \003(\0132).go" +
      "ogle.partner.aistreams.v1alpha1.Stream\022\027" +
      "\n\017next_page_token\030\002 \001(\t\022\023\n\013unreachable\030\003" +
      " \003(\t\"I\n\020GetStreamRequest\0225\n\004name\030\001 \001(\tB\'" +
      "\340A\002\372A!\n\037aistreams.googleapis.com/Stream\"" +
      "\300\001\n\023CreateStreamRequest\0228\n\006parent\030\001 \001(\tB" +
      "(\340A\002\372A\"\n aistreams.googleapis.com/Cluste" +
      "r\022\026\n\tstream_id\030\002 \001(\tB\003\340A\002\022>\n\006stream\030\003 \001(" +
      "\0132).google.partner.aistreams.v1alpha1.St" +
      "reamB\003\340A\002\022\027\n\nrequest_id\030\004 \001(\tB\003\340A\001\"\244\001\n\023U" +
      "pdateStreamRequest\0224\n\013update_mask\030\001 \001(\0132" +
      "\032.google.protobuf.FieldMaskB\003\340A\002\022>\n\006stre" +
      "am\030\002 \001(\0132).google.partner.aistreams.v1al" +
      "pha1.StreamB\003\340A\002\022\027\n\nrequest_id\030\003 \001(\tB\003\340A" +
      "\001\"e\n\023DeleteStreamRequest\0225\n\004name\030\001 \001(\tB\'" +
      "\340A\002\372A!\n\037aistreams.googleapis.com/Stream\022" +
      "\027\n\nrequest_id\030\002 \001(\tB\003\340A\001\"\200\002\n\021OperationMe" +
      "tadata\0224\n\013create_time\030\001 \001(\0132\032.google.pro" +
      "tobuf.TimestampB\003\340A\003\0221\n\010end_time\030\002 \001(\0132\032" +
      ".google.protobuf.TimestampB\003\340A\003\022\023\n\006targe" +
      "t\030\003 \001(\tB\003\340A\003\022\021\n\004verb\030\004 \001(\tB\003\340A\003\022\033\n\016statu" +
      "s_message\030\005 \001(\tB\003\340A\003\022#\n\026requested_cancel" +
      "lation\030\006 \001(\010B\003\340A\003\022\030\n\013api_version\030\007 \001(\tB\003" +
      "\340A\0032\320\021\n\tAIStreams\022\304\001\n\014ListClusters\0226.goo" +
      "gle.partner.aistreams.v1alpha1.ListClust" +
      "ersRequest\0327.google.partner.aistreams.v1" +
      "alpha1.ListClustersResponse\"C\202\323\344\223\0024\0222/v1" +
      "alpha1/{parent=projects/*/locations/*}/c" +
      "lusters\332A\006parent\022\261\001\n\nGetCluster\0224.google" +
      ".partner.aistreams.v1alpha1.GetClusterRe" +
      "quest\032*.google.partner.aistreams.v1alpha" +
      "1.Cluster\"A\202\323\344\223\0024\0222/v1alpha1/{name=proje" +
      "cts/*/locations/*/clusters/*}\332A\004name\022\347\001\n" +
      "\rCreateCluster\0227.google.partner.aistream" +
      "s.v1alpha1.CreateClusterRequest\032\035.google" +
      ".longrunning.Operation\"~\202\323\344\223\002=\"2/v1alpha" +
      "1/{parent=projects/*/locations/*}/cluste" +
      "rs:\007cluster\332A\031parent,cluster,cluster_id\312" +
      "A\034\n\007Cluster\022\021OperationMetadata\022\352\001\n\rUpdat" +
      "eCluster\0227.google.partner.aistreams.v1al" +
      "pha1.UpdateClusterRequest\032\035.google.longr" +
      "unning.Operation\"\200\001\202\323\344\223\002E2:/v1alpha1/{cl" +
      "uster.name=projects/*/locations/*/cluste" +
      "rs/*}:\007cluster\332A\023cluster,update_mask\312A\034\n" +
      "\007Cluster\022\021OperationMetadata\022\327\001\n\rDeleteCl" +
      "uster\0227.google.partner.aistreams.v1alpha" +
      "1.DeleteClusterRequest\032\035.google.longrunn" +
      "ing.Operation\"n\202\323\344\223\0024*2/v1alpha1/{name=p" +
      "rojects/*/locations/*/clusters/*}\332A\004name" +
      "\312A*\n\025google.protobuf.Empty\022\021OperationMet" +
      "adata\022\313\001\n\013ListStreams\0225.google.partner.a" +
      "istreams.v1alpha1.ListStreamsRequest\0326.g" +
      "oogle.partner.aistreams.v1alpha1.ListStr" +
      "eamsResponse\"M\202\323\344\223\002>\022</v1alpha1/{parent=" +
      "projects/*/locations/*/clusters/*}/strea" +
      "ms\332A\006parent\022\270\001\n\tGetStream\0223.google.partn" +
      "er.aistreams.v1alpha1.GetStreamRequest\032)" +
      ".google.partner.aistreams.v1alpha1.Strea" +
      "m\"K\202\323\344\223\002>\022</v1alpha1/{name=projects/*/lo" +
      "cations/*/clusters/*/streams/*}\332A\004name\022\354" +
      "\001\n\014CreateStream\0226.google.partner.aistrea" +
      "ms.v1alpha1.CreateStreamRequest\032\035.google" +
      ".longrunning.Operation\"\204\001\202\323\344\223\002F\"</v1alph" +
      "a1/{parent=projects/*/locations/*/cluste" +
      "rs/*}/streams:\006stream\332A\027parent,stream,st" +
      "ream_id\312A\033\n\006Stream\022\021OperationMetadata\022\356\001" +
      "\n\014UpdateStream\0226.google.partner.aistream" +
      "s.v1alpha1.UpdateStreamRequest\032\035.google." +
      "longrunning.Operation\"\206\001\202\323\344\223\002M2C/v1alpha" +
      "1/{stream.name=projects/*/locations/*/cl" +
      "usters/*/streams/*}:\006stream\332A\022stream,upd" +
      "ate_mask\312A\033\n\006Stream\022\021OperationMetadata\022\337" +
      "\001\n\014DeleteStream\0226.google.partner.aistrea" +
      "ms.v1alpha1.DeleteStreamRequest\032\035.google" +
      ".longrunning.Operation\"x\202\323\344\223\002>*</v1alpha" +
      "1/{name=projects/*/locations/*/clusters/" +
      "*/streams/*}\332A\004name\312A*\n\025google.protobuf." +
      "Empty\022\021OperationMetadata\032L\312A\030aistreams.g" +
      "oogleapis.com\322A.https://www.googleapis.c" +
      "om/auth/cloud-platformB\262\001\n%com.google.pa" +
      "rtner.aistreams.v1alpha1B\016AIStreamsProto" +
      "P\001ZJgoogle.golang.org/genproto/googleapi" +
      "s/partner/aistreams/v1alpha1;aistreams\370\001" +
      "\001\312\002\'Google\\Cloud\\Partner\\Aistreams\\V1alp" +
      "ha1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.ClientProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.longrunning.OperationsProto.getDescriptor(),
          com.google.protobuf.FieldMaskProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
        });
    internal_static_google_partner_aistreams_v1alpha1_Cluster_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_partner_aistreams_v1alpha1_Cluster_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_Cluster_descriptor,
        new java.lang.String[] { "Name", "CreateTime", "UpdateTime", "Labels", "Certificate", "ServiceEndpoint", });
    internal_static_google_partner_aistreams_v1alpha1_Cluster_LabelsEntry_descriptor =
      internal_static_google_partner_aistreams_v1alpha1_Cluster_descriptor.getNestedTypes().get(0);
    internal_static_google_partner_aistreams_v1alpha1_Cluster_LabelsEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_Cluster_LabelsEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    internal_static_google_partner_aistreams_v1alpha1_ListClustersRequest_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_partner_aistreams_v1alpha1_ListClustersRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_ListClustersRequest_descriptor,
        new java.lang.String[] { "Parent", "PageSize", "PageToken", "Filter", "OrderBy", });
    internal_static_google_partner_aistreams_v1alpha1_ListClustersResponse_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_partner_aistreams_v1alpha1_ListClustersResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_ListClustersResponse_descriptor,
        new java.lang.String[] { "Clusters", "NextPageToken", "Unreachable", });
    internal_static_google_partner_aistreams_v1alpha1_GetClusterRequest_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_partner_aistreams_v1alpha1_GetClusterRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_GetClusterRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_partner_aistreams_v1alpha1_CreateClusterRequest_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_partner_aistreams_v1alpha1_CreateClusterRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_CreateClusterRequest_descriptor,
        new java.lang.String[] { "Parent", "ClusterId", "Cluster", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_UpdateClusterRequest_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_partner_aistreams_v1alpha1_UpdateClusterRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_UpdateClusterRequest_descriptor,
        new java.lang.String[] { "UpdateMask", "Cluster", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_DeleteClusterRequest_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_partner_aistreams_v1alpha1_DeleteClusterRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_DeleteClusterRequest_descriptor,
        new java.lang.String[] { "Name", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_Stream_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_partner_aistreams_v1alpha1_Stream_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_Stream_descriptor,
        new java.lang.String[] { "Name", "CreateTime", "UpdateTime", "Labels", });
    internal_static_google_partner_aistreams_v1alpha1_Stream_LabelsEntry_descriptor =
      internal_static_google_partner_aistreams_v1alpha1_Stream_descriptor.getNestedTypes().get(0);
    internal_static_google_partner_aistreams_v1alpha1_Stream_LabelsEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_Stream_LabelsEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsRequest_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_ListStreamsRequest_descriptor,
        new java.lang.String[] { "Parent", "PageSize", "PageToken", "Filter", "OrderBy", });
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsResponse_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_google_partner_aistreams_v1alpha1_ListStreamsResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_ListStreamsResponse_descriptor,
        new java.lang.String[] { "Streams", "NextPageToken", "Unreachable", });
    internal_static_google_partner_aistreams_v1alpha1_GetStreamRequest_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_google_partner_aistreams_v1alpha1_GetStreamRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_GetStreamRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_partner_aistreams_v1alpha1_CreateStreamRequest_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_google_partner_aistreams_v1alpha1_CreateStreamRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_CreateStreamRequest_descriptor,
        new java.lang.String[] { "Parent", "StreamId", "Stream", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_UpdateStreamRequest_descriptor =
      getDescriptor().getMessageTypes().get(12);
    internal_static_google_partner_aistreams_v1alpha1_UpdateStreamRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_UpdateStreamRequest_descriptor,
        new java.lang.String[] { "UpdateMask", "Stream", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_DeleteStreamRequest_descriptor =
      getDescriptor().getMessageTypes().get(13);
    internal_static_google_partner_aistreams_v1alpha1_DeleteStreamRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_DeleteStreamRequest_descriptor,
        new java.lang.String[] { "Name", "RequestId", });
    internal_static_google_partner_aistreams_v1alpha1_OperationMetadata_descriptor =
      getDescriptor().getMessageTypes().get(14);
    internal_static_google_partner_aistreams_v1alpha1_OperationMetadata_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_partner_aistreams_v1alpha1_OperationMetadata_descriptor,
        new java.lang.String[] { "CreateTime", "EndTime", "Target", "Verb", "StatusMessage", "RequestedCancellation", "ApiVersion", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    registry.add(com.google.api.ClientProto.methodSignature);
    registry.add(com.google.api.ClientProto.oauthScopes);
    registry.add(com.google.api.ResourceProto.resource);
    registry.add(com.google.api.ResourceProto.resourceReference);
    registry.add(com.google.longrunning.OperationsProto.operationInfo);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.ClientProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.longrunning.OperationsProto.getDescriptor();
    com.google.protobuf.FieldMaskProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
