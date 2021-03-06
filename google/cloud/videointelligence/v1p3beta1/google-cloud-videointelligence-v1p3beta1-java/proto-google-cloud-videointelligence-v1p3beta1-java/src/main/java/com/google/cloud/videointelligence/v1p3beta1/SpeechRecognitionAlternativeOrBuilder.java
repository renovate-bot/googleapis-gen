// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/videointelligence/v1p3beta1/video_intelligence.proto

package com.google.cloud.videointelligence.v1p3beta1;

public interface SpeechRecognitionAlternativeOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.videointelligence.v1p3beta1.SpeechRecognitionAlternative)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Transcript text representing the words that the user spoke.
   * </pre>
   *
   * <code>string transcript = 1;</code>
   * @return The transcript.
   */
  java.lang.String getTranscript();
  /**
   * <pre>
   * Transcript text representing the words that the user spoke.
   * </pre>
   *
   * <code>string transcript = 1;</code>
   * @return The bytes for transcript.
   */
  com.google.protobuf.ByteString
      getTranscriptBytes();

  /**
   * <pre>
   * Output only. The confidence estimate between 0.0 and 1.0. A higher number
   * indicates an estimated greater likelihood that the recognized words are
   * correct. This field is set only for the top alternative.
   * This field is not guaranteed to be accurate and users should not rely on it
   * to be always provided.
   * The default of 0.0 is a sentinel value indicating `confidence` was not set.
   * </pre>
   *
   * <code>float confidence = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The confidence.
   */
  float getConfidence();

  /**
   * <pre>
   * Output only. A list of word-specific information for each recognized word.
   * Note: When `enable_speaker_diarization` is set to true, you will see all
   * the words from the beginning of the audio.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p3beta1.WordInfo words = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.util.List<com.google.cloud.videointelligence.v1p3beta1.WordInfo> 
      getWordsList();
  /**
   * <pre>
   * Output only. A list of word-specific information for each recognized word.
   * Note: When `enable_speaker_diarization` is set to true, you will see all
   * the words from the beginning of the audio.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p3beta1.WordInfo words = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.videointelligence.v1p3beta1.WordInfo getWords(int index);
  /**
   * <pre>
   * Output only. A list of word-specific information for each recognized word.
   * Note: When `enable_speaker_diarization` is set to true, you will see all
   * the words from the beginning of the audio.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p3beta1.WordInfo words = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  int getWordsCount();
  /**
   * <pre>
   * Output only. A list of word-specific information for each recognized word.
   * Note: When `enable_speaker_diarization` is set to true, you will see all
   * the words from the beginning of the audio.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p3beta1.WordInfo words = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.util.List<? extends com.google.cloud.videointelligence.v1p3beta1.WordInfoOrBuilder> 
      getWordsOrBuilderList();
  /**
   * <pre>
   * Output only. A list of word-specific information for each recognized word.
   * Note: When `enable_speaker_diarization` is set to true, you will see all
   * the words from the beginning of the audio.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p3beta1.WordInfo words = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.videointelligence.v1p3beta1.WordInfoOrBuilder getWordsOrBuilder(
      int index);
}
