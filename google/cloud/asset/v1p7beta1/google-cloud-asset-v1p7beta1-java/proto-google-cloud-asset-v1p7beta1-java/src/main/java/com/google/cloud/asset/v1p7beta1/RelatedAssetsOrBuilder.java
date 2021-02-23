// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/asset/v1p7beta1/assets.proto

package com.google.cloud.asset.v1p7beta1;

public interface RelatedAssetsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.asset.v1p7beta1.RelatedAssets)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The detailed relation attributes.
   * </pre>
   *
   * <code>.google.cloud.asset.v1p7beta1.RelationshipAttributes relationship_attributes = 1;</code>
   * @return Whether the relationshipAttributes field is set.
   */
  boolean hasRelationshipAttributes();
  /**
   * <pre>
   * The detailed relation attributes.
   * </pre>
   *
   * <code>.google.cloud.asset.v1p7beta1.RelationshipAttributes relationship_attributes = 1;</code>
   * @return The relationshipAttributes.
   */
  com.google.cloud.asset.v1p7beta1.RelationshipAttributes getRelationshipAttributes();
  /**
   * <pre>
   * The detailed relation attributes.
   * </pre>
   *
   * <code>.google.cloud.asset.v1p7beta1.RelationshipAttributes relationship_attributes = 1;</code>
   */
  com.google.cloud.asset.v1p7beta1.RelationshipAttributesOrBuilder getRelationshipAttributesOrBuilder();

  /**
   * <pre>
   * The peer resources of the relationship.
   * </pre>
   *
   * <code>repeated .google.cloud.asset.v1p7beta1.RelatedAsset assets = 2;</code>
   */
  java.util.List<com.google.cloud.asset.v1p7beta1.RelatedAsset> 
      getAssetsList();
  /**
   * <pre>
   * The peer resources of the relationship.
   * </pre>
   *
   * <code>repeated .google.cloud.asset.v1p7beta1.RelatedAsset assets = 2;</code>
   */
  com.google.cloud.asset.v1p7beta1.RelatedAsset getAssets(int index);
  /**
   * <pre>
   * The peer resources of the relationship.
   * </pre>
   *
   * <code>repeated .google.cloud.asset.v1p7beta1.RelatedAsset assets = 2;</code>
   */
  int getAssetsCount();
  /**
   * <pre>
   * The peer resources of the relationship.
   * </pre>
   *
   * <code>repeated .google.cloud.asset.v1p7beta1.RelatedAsset assets = 2;</code>
   */
  java.util.List<? extends com.google.cloud.asset.v1p7beta1.RelatedAssetOrBuilder> 
      getAssetsOrBuilderList();
  /**
   * <pre>
   * The peer resources of the relationship.
   * </pre>
   *
   * <code>repeated .google.cloud.asset.v1p7beta1.RelatedAsset assets = 2;</code>
   */
  com.google.cloud.asset.v1p7beta1.RelatedAssetOrBuilder getAssetsOrBuilder(
      int index);
}
