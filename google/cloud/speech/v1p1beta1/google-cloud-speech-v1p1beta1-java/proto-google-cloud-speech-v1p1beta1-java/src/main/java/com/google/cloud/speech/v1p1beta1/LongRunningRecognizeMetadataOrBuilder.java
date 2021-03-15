// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/speech/v1p1beta1/cloud_speech.proto

package com.google.cloud.speech.v1p1beta1;

public interface LongRunningRecognizeMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.speech.v1p1beta1.LongRunningRecognizeMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Approximate percentage of audio processed thus far. Guaranteed to be 100
   * when the audio is fully processed and the results are available.
   * </pre>
   *
   * <code>int32 progress_percent = 1;</code>
   * @return The progressPercent.
   */
  int getProgressPercent();

  /**
   * <pre>
   * Time when the request was received.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 2;</code>
   * @return Whether the startTime field is set.
   */
  boolean hasStartTime();
  /**
   * <pre>
   * Time when the request was received.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 2;</code>
   * @return The startTime.
   */
  com.google.protobuf.Timestamp getStartTime();
  /**
   * <pre>
   * Time when the request was received.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 2;</code>
   */
  com.google.protobuf.TimestampOrBuilder getStartTimeOrBuilder();

  /**
   * <pre>
   * Time of the most recent processing update.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp last_update_time = 3;</code>
   * @return Whether the lastUpdateTime field is set.
   */
  boolean hasLastUpdateTime();
  /**
   * <pre>
   * Time of the most recent processing update.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp last_update_time = 3;</code>
   * @return The lastUpdateTime.
   */
  com.google.protobuf.Timestamp getLastUpdateTime();
  /**
   * <pre>
   * Time of the most recent processing update.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp last_update_time = 3;</code>
   */
  com.google.protobuf.TimestampOrBuilder getLastUpdateTimeOrBuilder();

  /**
   * <pre>
   * Output only. The URI of the audio file being transcribed. Empty if the audio was sent
   * as byte content.
   * </pre>
   *
   * <code>string uri = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The uri.
   */
  java.lang.String getUri();
  /**
   * <pre>
   * Output only. The URI of the audio file being transcribed. Empty if the audio was sent
   * as byte content.
   * </pre>
   *
   * <code>string uri = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for uri.
   */
  com.google.protobuf.ByteString
      getUriBytes();

  /**
   * <pre>
   * Output only. A copy of the TranscriptOutputConfig if it was set in the request.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.TranscriptOutputConfig output_config = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the outputConfig field is set.
   */
  boolean hasOutputConfig();
  /**
   * <pre>
   * Output only. A copy of the TranscriptOutputConfig if it was set in the request.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.TranscriptOutputConfig output_config = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The outputConfig.
   */
  com.google.cloud.speech.v1p1beta1.TranscriptOutputConfig getOutputConfig();
  /**
   * <pre>
   * Output only. A copy of the TranscriptOutputConfig if it was set in the request.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.TranscriptOutputConfig output_config = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.speech.v1p1beta1.TranscriptOutputConfigOrBuilder getOutputConfigOrBuilder();
}
