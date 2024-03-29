// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/retail/v2alpha/catalog.proto

package com.google.cloud.retail.v2alpha;

public final class CatalogProto {
  private CatalogProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_retail_v2alpha_ProductLevelConfig_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_retail_v2alpha_ProductLevelConfig_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLink_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_retail_v2alpha_MerchantCenterLink_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLinkingConfig_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_retail_v2alpha_MerchantCenterLinkingConfig_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_retail_v2alpha_Catalog_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_retail_v2alpha_Catalog_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n)google/cloud/retail/v2alpha/catalog.pr" +
      "oto\022\033google.cloud.retail.v2alpha\032\034google" +
      "/api/annotations.proto\032\037google/api/field" +
      "_behavior.proto\032\031google/api/resource.pro" +
      "to\032(google/cloud/retail/v2alpha/common.p" +
      "roto\032/google/cloud/retail/v2alpha/import" +
      "_config.proto\"^\n\022ProductLevelConfig\022\036\n\026i" +
      "ngestion_product_type\030\001 \001(\t\022(\n merchant_" +
      "center_product_id_field\030\002 \001(\t\"f\n\022Merchan" +
      "tCenterLink\022\'\n\032merchant_center_account_i" +
      "d\030\001 \001(\003B\003\340A\002\022\021\n\tbranch_id\030\002 \001(\t\022\024\n\014desti" +
      "nations\030\003 \003(\t\"]\n\033MerchantCenterLinkingCo" +
      "nfig\022>\n\005links\030\001 \003(\0132/.google.cloud.retai" +
      "l.v2alpha.MerchantCenterLink\"\323\002\n\007Catalog" +
      "\022\024\n\004name\030\001 \001(\tB\006\340A\002\340A\005\022\034\n\014display_name\030\002" +
      " \001(\tB\006\340A\002\340A\005\022R\n\024product_level_config\030\004 \001" +
      "(\0132/.google.cloud.retail.v2alpha.Product" +
      "LevelConfigB\003\340A\002\022`\n\036merchant_center_link" +
      "ing_config\030\006 \001(\01328.google.cloud.retail.v" +
      "2alpha.MerchantCenterLinkingConfig:^\352A[\n" +
      "\035retail.googleapis.com/Catalog\022:projects" +
      "/{project}/locations/{location}/catalogs" +
      "/{catalog}B\332\001\n\037com.google.cloud.retail.v" +
      "2alphaB\014CatalogProtoP\001ZAgoogle.golang.or" +
      "g/genproto/googleapis/cloud/retail/v2alp" +
      "ha;retail\242\002\006RETAIL\252\002\033Google.Cloud.Retail" +
      ".V2Alpha\312\002\033Google\\Cloud\\Retail\\V2alpha\352\002" +
      "\036Google::Cloud::Retail::V2alphab\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.cloud.retail.v2alpha.CommonProto.getDescriptor(),
          com.google.cloud.retail.v2alpha.ImportConfigProto.getDescriptor(),
        });
    internal_static_google_cloud_retail_v2alpha_ProductLevelConfig_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_retail_v2alpha_ProductLevelConfig_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_retail_v2alpha_ProductLevelConfig_descriptor,
        new java.lang.String[] { "IngestionProductType", "MerchantCenterProductIdField", });
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLink_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLink_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_retail_v2alpha_MerchantCenterLink_descriptor,
        new java.lang.String[] { "MerchantCenterAccountId", "BranchId", "Destinations", });
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLinkingConfig_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_retail_v2alpha_MerchantCenterLinkingConfig_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_retail_v2alpha_MerchantCenterLinkingConfig_descriptor,
        new java.lang.String[] { "Links", });
    internal_static_google_cloud_retail_v2alpha_Catalog_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_cloud_retail_v2alpha_Catalog_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_retail_v2alpha_Catalog_descriptor,
        new java.lang.String[] { "Name", "DisplayName", "ProductLevelConfig", "MerchantCenterLinkingConfig", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.cloud.retail.v2alpha.CommonProto.getDescriptor();
    com.google.cloud.retail.v2alpha.ImportConfigProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
