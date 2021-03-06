// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/storage/v1/storage_resources.proto

package com.google.storage.v1;

public interface NotificationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.storage.v1.Notification)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The Cloud PubSub topic to which this subscription publishes. Formatted as:
   * '//pubsub.googleapis.com/projects/{project-identifier}/topics/{my-topic}'
   * </pre>
   *
   * <code>string topic = 1;</code>
   * @return The topic.
   */
  java.lang.String getTopic();
  /**
   * <pre>
   * The Cloud PubSub topic to which this subscription publishes. Formatted as:
   * '//pubsub.googleapis.com/projects/{project-identifier}/topics/{my-topic}'
   * </pre>
   *
   * <code>string topic = 1;</code>
   * @return The bytes for topic.
   */
  com.google.protobuf.ByteString
      getTopicBytes();

  /**
   * <pre>
   * If present, only send notifications about listed event types. If empty,
   * sent notifications for all event types.
   * </pre>
   *
   * <code>repeated string event_types = 2;</code>
   * @return A list containing the eventTypes.
   */
  java.util.List<java.lang.String>
      getEventTypesList();
  /**
   * <pre>
   * If present, only send notifications about listed event types. If empty,
   * sent notifications for all event types.
   * </pre>
   *
   * <code>repeated string event_types = 2;</code>
   * @return The count of eventTypes.
   */
  int getEventTypesCount();
  /**
   * <pre>
   * If present, only send notifications about listed event types. If empty,
   * sent notifications for all event types.
   * </pre>
   *
   * <code>repeated string event_types = 2;</code>
   * @param index The index of the element to return.
   * @return The eventTypes at the given index.
   */
  java.lang.String getEventTypes(int index);
  /**
   * <pre>
   * If present, only send notifications about listed event types. If empty,
   * sent notifications for all event types.
   * </pre>
   *
   * <code>repeated string event_types = 2;</code>
   * @param index The index of the value to return.
   * @return The bytes of the eventTypes at the given index.
   */
  com.google.protobuf.ByteString
      getEventTypesBytes(int index);

  /**
   * <pre>
   * An optional list of additional attributes to attach to each Cloud PubSub
   * message published for this notification subscription.
   * </pre>
   *
   * <code>map&lt;string, string&gt; custom_attributes = 3;</code>
   */
  int getCustomAttributesCount();
  /**
   * <pre>
   * An optional list of additional attributes to attach to each Cloud PubSub
   * message published for this notification subscription.
   * </pre>
   *
   * <code>map&lt;string, string&gt; custom_attributes = 3;</code>
   */
  boolean containsCustomAttributes(
      java.lang.String key);
  /**
   * Use {@link #getCustomAttributesMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getCustomAttributes();
  /**
   * <pre>
   * An optional list of additional attributes to attach to each Cloud PubSub
   * message published for this notification subscription.
   * </pre>
   *
   * <code>map&lt;string, string&gt; custom_attributes = 3;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getCustomAttributesMap();
  /**
   * <pre>
   * An optional list of additional attributes to attach to each Cloud PubSub
   * message published for this notification subscription.
   * </pre>
   *
   * <code>map&lt;string, string&gt; custom_attributes = 3;</code>
   */

  java.lang.String getCustomAttributesOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * An optional list of additional attributes to attach to each Cloud PubSub
   * message published for this notification subscription.
   * </pre>
   *
   * <code>map&lt;string, string&gt; custom_attributes = 3;</code>
   */

  java.lang.String getCustomAttributesOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * HTTP 1.1 [https://tools.ietf.org/html/rfc7232#section-2.3][Entity tag]
   * for this subscription notification.
   * </pre>
   *
   * <code>string etag = 4;</code>
   * @return The etag.
   */
  java.lang.String getEtag();
  /**
   * <pre>
   * HTTP 1.1 [https://tools.ietf.org/html/rfc7232#section-2.3][Entity tag]
   * for this subscription notification.
   * </pre>
   *
   * <code>string etag = 4;</code>
   * @return The bytes for etag.
   */
  com.google.protobuf.ByteString
      getEtagBytes();

  /**
   * <pre>
   * If present, only apply this notification configuration to object names that
   * begin with this prefix.
   * </pre>
   *
   * <code>string object_name_prefix = 5;</code>
   * @return The objectNamePrefix.
   */
  java.lang.String getObjectNamePrefix();
  /**
   * <pre>
   * If present, only apply this notification configuration to object names that
   * begin with this prefix.
   * </pre>
   *
   * <code>string object_name_prefix = 5;</code>
   * @return The bytes for objectNamePrefix.
   */
  com.google.protobuf.ByteString
      getObjectNamePrefixBytes();

  /**
   * <pre>
   * The desired content of the Payload.
   * </pre>
   *
   * <code>string payload_format = 6;</code>
   * @return The payloadFormat.
   */
  java.lang.String getPayloadFormat();
  /**
   * <pre>
   * The desired content of the Payload.
   * </pre>
   *
   * <code>string payload_format = 6;</code>
   * @return The bytes for payloadFormat.
   */
  com.google.protobuf.ByteString
      getPayloadFormatBytes();

  /**
   * <pre>
   * The ID of the notification.
   * </pre>
   *
   * <code>string id = 7;</code>
   * @return The id.
   */
  java.lang.String getId();
  /**
   * <pre>
   * The ID of the notification.
   * </pre>
   *
   * <code>string id = 7;</code>
   * @return The bytes for id.
   */
  com.google.protobuf.ByteString
      getIdBytes();
}
