// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/audio_config.proto

package com.google.cloud.dialogflow.v2;

public interface SpeechToTextConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2.SpeechToTextConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Optional. The speech model used in speech to text.
   * `SPEECH_MODEL_VARIANT_UNSPECIFIED`, `USE_BEST_AVAILABLE` will be treated as
   * `USE_ENHANCED`. It can be overridden in [AnalyzeContentRequest][google.cloud.dialogflow.v2.AnalyzeContentRequest] and
   * [StreamingAnalyzeContentRequest][google.cloud.dialogflow.v2.StreamingAnalyzeContentRequest] request.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2.SpeechModelVariant speech_model_variant = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The enum numeric value on the wire for speechModelVariant.
   */
  int getSpeechModelVariantValue();
  /**
   * <pre>
   * Optional. The speech model used in speech to text.
   * `SPEECH_MODEL_VARIANT_UNSPECIFIED`, `USE_BEST_AVAILABLE` will be treated as
   * `USE_ENHANCED`. It can be overridden in [AnalyzeContentRequest][google.cloud.dialogflow.v2.AnalyzeContentRequest] and
   * [StreamingAnalyzeContentRequest][google.cloud.dialogflow.v2.StreamingAnalyzeContentRequest] request.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2.SpeechModelVariant speech_model_variant = 1 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The speechModelVariant.
   */
  com.google.cloud.dialogflow.v2.SpeechModelVariant getSpeechModelVariant();
}
