// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v9/resources/asset_group_listing_group_filter.proto

package com.google.ads.googleads.v9.resources;

public final class AssetGroupListingGroupFilterProto {
  private AssetGroupListingGroupFilterProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_AssetGroupListingGroupFilter_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_AssetGroupListingGroupFilter_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBiddingCategory_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBiddingCategory_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBrand_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBrand_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductChannel_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductChannel_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCustomAttribute_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCustomAttribute_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCondition_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCondition_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductItemId_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductItemId_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductType_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductType_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\nHgoogle/ads/googleads/v9/resources/asse" +
      "t_group_listing_group_filter.proto\022!goog" +
      "le.ads.googleads.v9.resources\032Ogoogle/ad" +
      "s/googleads/v9/enums/listing_group_filte" +
      "r_bidding_category_level.proto\032Ogoogle/a" +
      "ds/googleads/v9/enums/listing_group_filt" +
      "er_custom_attribute_index.proto\032Hgoogle/" +
      "ads/googleads/v9/enums/listing_group_fil" +
      "ter_product_channel.proto\032Jgoogle/ads/go" +
      "ogleads/v9/enums/listing_group_filter_pr" +
      "oduct_condition.proto\032Kgoogle/ads/google" +
      "ads/v9/enums/listing_group_filter_produc" +
      "t_type_level.proto\032Bgoogle/ads/googleads" +
      "/v9/enums/listing_group_filter_type_enum" +
      ".proto\032Agoogle/ads/googleads/v9/enums/li" +
      "sting_group_filter_vertical.proto\032\037googl" +
      "e/api/field_behavior.proto\032\031google/api/r" +
      "esource.proto\032\034google/api/annotations.pr" +
      "oto\"\365\005\n\034AssetGroupListingGroupFilter\022T\n\r" +
      "resource_name\030\001 \001(\tB=\340A\005\372A7\n5googleads.g" +
      "oogleapis.com/AssetGroupListingGroupFilt" +
      "er\022@\n\013asset_group\030\002 \001(\tB+\340A\005\372A%\n#googlea" +
      "ds.googleapis.com/AssetGroup\022\017\n\002id\030\003 \001(\003" +
      "B\003\340A\003\022c\n\004type\030\004 \001(\0162P.google.ads.googlea" +
      "ds.v9.enums.ListingGroupFilterTypeEnum.L" +
      "istingGroupFilterTypeB\003\340A\005\022o\n\010vertical\030\005" +
      " \001(\0162X.google.ads.googleads.v9.enums.Lis" +
      "tingGroupFilterVerticalEnum.ListingGroup" +
      "FilterVerticalB\003\340A\005\022R\n\ncase_value\030\006 \001(\0132" +
      ">.google.ads.googleads.v9.resources.List" +
      "ingGroupFilterDimension\022b\n\033parent_listin" +
      "g_group_filter\030\007 \001(\tB=\340A\005\372A7\n5googleads." +
      "googleapis.com/AssetGroupListingGroupFil" +
      "ter:\235\001\352A\231\001\n5googleads.googleapis.com/Ass" +
      "etGroupListingGroupFilter\022`customers/{cu" +
      "stomer_id}/assetGroupListingGroupFilters" +
      "/{asset_group_id}~{listing_group_filter_" +
      "id}\"\271\r\n\033ListingGroupFilterDimension\022y\n\030p" +
      "roduct_bidding_category\030\001 \001(\0132U.google.a" +
      "ds.googleads.v9.resources.ListingGroupFi" +
      "lterDimension.ProductBiddingCategoryH\000\022d" +
      "\n\rproduct_brand\030\002 \001(\0132K.google.ads.googl" +
      "eads.v9.resources.ListingGroupFilterDime" +
      "nsion.ProductBrandH\000\022h\n\017product_channel\030" +
      "\003 \001(\0132M.google.ads.googleads.v9.resource" +
      "s.ListingGroupFilterDimension.ProductCha" +
      "nnelH\000\022l\n\021product_condition\030\004 \001(\0132O.goog" +
      "le.ads.googleads.v9.resources.ListingGro" +
      "upFilterDimension.ProductConditionH\000\022y\n\030" +
      "product_custom_attribute\030\005 \001(\0132U.google." +
      "ads.googleads.v9.resources.ListingGroupF" +
      "ilterDimension.ProductCustomAttributeH\000\022" +
      "g\n\017product_item_id\030\006 \001(\0132L.google.ads.go" +
      "ogleads.v9.resources.ListingGroupFilterD" +
      "imension.ProductItemIdH\000\022b\n\014product_type" +
      "\030\007 \001(\0132J.google.ads.googleads.v9.resourc" +
      "es.ListingGroupFilterDimension.ProductTy" +
      "peH\000\032\261\001\n\026ProductBiddingCategory\022\017\n\002id\030\001 " +
      "\001(\003H\000\210\001\001\022\177\n\005level\030\002 \001(\0162p.google.ads.goo" +
      "gleads.v9.enums.ListingGroupFilterBiddin" +
      "gCategoryLevelEnum.ListingGroupFilterBid" +
      "dingCategoryLevelB\005\n\003_id\032,\n\014ProductBrand" +
      "\022\022\n\005value\030\001 \001(\tH\000\210\001\001B\010\n\006_value\032\207\001\n\016Produ" +
      "ctChannel\022u\n\007channel\030\001 \001(\0162d.google.ads." +
      "googleads.v9.enums.ListingGroupFilterPro" +
      "ductChannelEnum.ListingGroupFilterProduc" +
      "tChannel\032\267\001\n\026ProductCustomAttribute\022\022\n\005v" +
      "alue\030\001 \001(\tH\000\210\001\001\022\177\n\005index\030\002 \001(\0162p.google." +
      "ads.googleads.v9.enums.ListingGroupFilte" +
      "rCustomAttributeIndexEnum.ListingGroupFi" +
      "lterCustomAttributeIndexB\010\n\006_value\032\217\001\n\020P" +
      "roductCondition\022{\n\tcondition\030\001 \001(\0162h.goo" +
      "gle.ads.googleads.v9.enums.ListingGroupF" +
      "ilterProductConditionEnum.ListingGroupFi" +
      "lterProductCondition\032-\n\rProductItemId\022\022\n" +
      "\005value\030\001 \001(\tH\000\210\001\001B\010\n\006_value\032\244\001\n\013ProductT" +
      "ype\022\022\n\005value\030\001 \001(\tH\000\210\001\001\022w\n\005level\030\002 \001(\0162h" +
      ".google.ads.googleads.v9.enums.ListingGr" +
      "oupFilterProductTypeLevelEnum.ListingGro" +
      "upFilterProductTypeLevelB\010\n\006_valueB\013\n\tdi" +
      "mensionB\216\002\n%com.google.ads.googleads.v9." +
      "resourcesB!AssetGroupListingGroupFilterP" +
      "rotoP\001ZJgoogle.golang.org/genproto/googl" +
      "eapis/ads/googleads/v9/resources;resourc" +
      "es\242\002\003GAA\252\002!Google.Ads.GoogleAds.V9.Resou" +
      "rces\312\002!Google\\Ads\\GoogleAds\\V9\\Resources" +
      "\352\002%Google::Ads::GoogleAds::V9::Resources" +
      "b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.ads.googleads.v9.enums.ListingGroupFilterBiddingCategoryLevelProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterCustomAttributeIndexProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterProductChannelProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterProductConditionProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterProductTypeLevelProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterTypeEnumProto.getDescriptor(),
          com.google.ads.googleads.v9.enums.ListingGroupFilterVerticalProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_ads_googleads_v9_resources_AssetGroupListingGroupFilter_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_ads_googleads_v9_resources_AssetGroupListingGroupFilter_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_AssetGroupListingGroupFilter_descriptor,
        new java.lang.String[] { "ResourceName", "AssetGroup", "Id", "Type", "Vertical", "CaseValue", "ParentListingGroupFilter", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor,
        new java.lang.String[] { "ProductBiddingCategory", "ProductBrand", "ProductChannel", "ProductCondition", "ProductCustomAttribute", "ProductItemId", "ProductType", "Dimension", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBiddingCategory_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(0);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBiddingCategory_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBiddingCategory_descriptor,
        new java.lang.String[] { "Id", "Level", "Id", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBrand_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(1);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBrand_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductBrand_descriptor,
        new java.lang.String[] { "Value", "Value", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductChannel_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(2);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductChannel_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductChannel_descriptor,
        new java.lang.String[] { "Channel", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCustomAttribute_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(3);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCustomAttribute_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCustomAttribute_descriptor,
        new java.lang.String[] { "Value", "Index", "Value", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCondition_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(4);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCondition_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductCondition_descriptor,
        new java.lang.String[] { "Condition", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductItemId_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(5);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductItemId_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductItemId_descriptor,
        new java.lang.String[] { "Value", "Value", });
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductType_descriptor =
      internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_descriptor.getNestedTypes().get(6);
    internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductType_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_ads_googleads_v9_resources_ListingGroupFilterDimension_ProductType_descriptor,
        new java.lang.String[] { "Value", "Level", "Value", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    registry.add(com.google.api.ResourceProto.resourceReference);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.ads.googleads.v9.enums.ListingGroupFilterBiddingCategoryLevelProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterCustomAttributeIndexProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterProductChannelProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterProductConditionProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterProductTypeLevelProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterTypeEnumProto.getDescriptor();
    com.google.ads.googleads.v9.enums.ListingGroupFilterVerticalProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
