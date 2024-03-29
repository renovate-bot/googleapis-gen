// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/speech/v1p1beta1/cloud_speech_adaptation.proto

package com.google.cloud.speech.v1p1beta1;

public interface CreatePhraseSetRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.speech.v1p1beta1.CreatePhraseSetRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource where this phrase set will be created. Format:
   * `projects/{project}/locations/{location}/phraseSets`
   * Speech-to-Text supports three locations: `global`, `us` (US North America),
   * and `eu` (Europe). If you are calling the `speech.googleapis.com`
   * endpoint, use the `global` location. To specify a region, use a
   * [regional endpoint](/speech-to-text/docs/endpoints) with matching `us` or
   * `eu` location value.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource where this phrase set will be created. Format:
   * `projects/{project}/locations/{location}/phraseSets`
   * Speech-to-Text supports three locations: `global`, `us` (US North America),
   * and `eu` (Europe). If you are calling the `speech.googleapis.com`
   * endpoint, use the `global` location. To specify a region, use a
   * [regional endpoint](/speech-to-text/docs/endpoints) with matching `us` or
   * `eu` location value.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The ID to use for the phrase set, which will become the final
   * component of the phrase set's resource name.
   * This value should be 4-63 characters, and valid characters
   * are /[a-z][0-9]-/.
   * </pre>
   *
   * <code>string phrase_set_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The phraseSetId.
   */
  java.lang.String getPhraseSetId();
  /**
   * <pre>
   * Required. The ID to use for the phrase set, which will become the final
   * component of the phrase set's resource name.
   * This value should be 4-63 characters, and valid characters
   * are /[a-z][0-9]-/.
   * </pre>
   *
   * <code>string phrase_set_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for phraseSetId.
   */
  com.google.protobuf.ByteString
      getPhraseSetIdBytes();

  /**
   * <pre>
   * Required. The phrase set to create.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.PhraseSet phrase_set = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the phraseSet field is set.
   */
  boolean hasPhraseSet();
  /**
   * <pre>
   * Required. The phrase set to create.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.PhraseSet phrase_set = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The phraseSet.
   */
  com.google.cloud.speech.v1p1beta1.PhraseSet getPhraseSet();
  /**
   * <pre>
   * Required. The phrase set to create.
   * </pre>
   *
   * <code>.google.cloud.speech.v1p1beta1.PhraseSet phrase_set = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.speech.v1p1beta1.PhraseSetOrBuilder getPhraseSetOrBuilder();
}
