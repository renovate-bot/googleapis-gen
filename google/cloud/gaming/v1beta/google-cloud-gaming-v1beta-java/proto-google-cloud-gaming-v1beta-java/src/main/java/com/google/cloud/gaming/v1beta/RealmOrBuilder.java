// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/v1beta/realms.proto

package com.google.cloud.gaming.v1beta;

public interface RealmOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gaming.v1beta.Realm)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The resource name of the realm. Uses the form:
   * `projects/{project}/locations/{location}/realms/{realm}`. For
   * example, `projects/my-project/locations/{location}/realms/my-realm`.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The resource name of the realm. Uses the form:
   * `projects/{project}/locations/{location}/realms/{realm}`. For
   * example, `projects/my-project/locations/{location}/realms/my-realm`.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Output only. The creation time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the createTime field is set.
   */
  boolean hasCreateTime();
  /**
   * <pre>
   * Output only. The creation time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The createTime.
   */
  com.google.protobuf.Timestamp getCreateTime();
  /**
   * <pre>
   * Output only. The creation time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getCreateTimeOrBuilder();

  /**
   * <pre>
   * Output only. The last-modified time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the updateTime field is set.
   */
  boolean hasUpdateTime();
  /**
   * <pre>
   * Output only. The last-modified time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The updateTime.
   */
  com.google.protobuf.Timestamp getUpdateTime();
  /**
   * <pre>
   * Output only. The last-modified time.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getUpdateTimeOrBuilder();

  /**
   * <pre>
   * The labels associated with this realm. Each label is a key-value pair.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  int getLabelsCount();
  /**
   * <pre>
   * The labels associated with this realm. Each label is a key-value pair.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  boolean containsLabels(
      java.lang.String key);
  /**
   * Use {@link #getLabelsMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getLabels();
  /**
   * <pre>
   * The labels associated with this realm. Each label is a key-value pair.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getLabelsMap();
  /**
   * <pre>
   * The labels associated with this realm. Each label is a key-value pair.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */

  java.lang.String getLabelsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * The labels associated with this realm. Each label is a key-value pair.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 4;</code>
   */

  java.lang.String getLabelsOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * Required. Time zone where all policies targeting this realm are evaluated.
   * The value of this field must be from the IANA time zone database:
   * https://www.iana.org/time-zones.
   * </pre>
   *
   * <code>string time_zone = 6 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The timeZone.
   */
  java.lang.String getTimeZone();
  /**
   * <pre>
   * Required. Time zone where all policies targeting this realm are evaluated.
   * The value of this field must be from the IANA time zone database:
   * https://www.iana.org/time-zones.
   * </pre>
   *
   * <code>string time_zone = 6 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for timeZone.
   */
  com.google.protobuf.ByteString
      getTimeZoneBytes();

  /**
   * <pre>
   * ETag of the resource.
   * </pre>
   *
   * <code>string etag = 7;</code>
   * @return The etag.
   */
  java.lang.String getEtag();
  /**
   * <pre>
   * ETag of the resource.
   * </pre>
   *
   * <code>string etag = 7;</code>
   * @return The bytes for etag.
   */
  com.google.protobuf.ByteString
      getEtagBytes();

  /**
   * <pre>
   * Human readable description of the realm.
   * </pre>
   *
   * <code>string description = 8;</code>
   * @return The description.
   */
  java.lang.String getDescription();
  /**
   * <pre>
   * Human readable description of the realm.
   * </pre>
   *
   * <code>string description = 8;</code>
   * @return The bytes for description.
   */
  com.google.protobuf.ByteString
      getDescriptionBytes();
}
