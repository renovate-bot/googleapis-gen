// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/featurestore_online_service.proto

package com.google.cloud.aiplatform.v1;

public interface StreamingReadFeatureValuesRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.StreamingReadFeatureValuesRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the entities' type.
   * Value format:
   * `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
   * For example,
   * for a machine learning model predicting user clicks on a website, an
   * EntityType ID could be `user`.
   * </pre>
   *
   * <code>string entity_type = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The entityType.
   */
  java.lang.String getEntityType();
  /**
   * <pre>
   * Required. The resource name of the entities' type.
   * Value format:
   * `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
   * For example,
   * for a machine learning model predicting user clicks on a website, an
   * EntityType ID could be `user`.
   * </pre>
   *
   * <code>string entity_type = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for entityType.
   */
  com.google.protobuf.ByteString
      getEntityTypeBytes();

  /**
   * <pre>
   * Required. IDs of entities to read Feature values of. The maximum number of IDs is
   * 100. For example, for a machine learning model predicting user clicks on a
   * website, an entity ID could be `user_123`.
   * </pre>
   *
   * <code>repeated string entity_ids = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return A list containing the entityIds.
   */
  java.util.List<java.lang.String>
      getEntityIdsList();
  /**
   * <pre>
   * Required. IDs of entities to read Feature values of. The maximum number of IDs is
   * 100. For example, for a machine learning model predicting user clicks on a
   * website, an entity ID could be `user_123`.
   * </pre>
   *
   * <code>repeated string entity_ids = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The count of entityIds.
   */
  int getEntityIdsCount();
  /**
   * <pre>
   * Required. IDs of entities to read Feature values of. The maximum number of IDs is
   * 100. For example, for a machine learning model predicting user clicks on a
   * website, an entity ID could be `user_123`.
   * </pre>
   *
   * <code>repeated string entity_ids = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the element to return.
   * @return The entityIds at the given index.
   */
  java.lang.String getEntityIds(int index);
  /**
   * <pre>
   * Required. IDs of entities to read Feature values of. The maximum number of IDs is
   * 100. For example, for a machine learning model predicting user clicks on a
   * website, an entity ID could be `user_123`.
   * </pre>
   *
   * <code>repeated string entity_ids = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the value to return.
   * @return The bytes of the entityIds at the given index.
   */
  com.google.protobuf.ByteString
      getEntityIdsBytes(int index);

  /**
   * <pre>
   * Required. Selector choosing Features of the target EntityType. Feature IDs will be
   * deduplicated.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.FeatureSelector feature_selector = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the featureSelector field is set.
   */
  boolean hasFeatureSelector();
  /**
   * <pre>
   * Required. Selector choosing Features of the target EntityType. Feature IDs will be
   * deduplicated.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.FeatureSelector feature_selector = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The featureSelector.
   */
  com.google.cloud.aiplatform.v1.FeatureSelector getFeatureSelector();
  /**
   * <pre>
   * Required. Selector choosing Features of the target EntityType. Feature IDs will be
   * deduplicated.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.FeatureSelector feature_selector = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1.FeatureSelectorOrBuilder getFeatureSelectorOrBuilder();
}
