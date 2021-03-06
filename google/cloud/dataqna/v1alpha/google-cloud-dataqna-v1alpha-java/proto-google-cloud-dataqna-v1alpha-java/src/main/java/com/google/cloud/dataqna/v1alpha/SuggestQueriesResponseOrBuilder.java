// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataqna/v1alpha/auto_suggestion_service.proto

package com.google.cloud.dataqna.v1alpha;

public interface SuggestQueriesResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dataqna.v1alpha.SuggestQueriesResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A list of suggestions.
   * </pre>
   *
   * <code>repeated .google.cloud.dataqna.v1alpha.Suggestion suggestions = 1;</code>
   */
  java.util.List<com.google.cloud.dataqna.v1alpha.Suggestion> 
      getSuggestionsList();
  /**
   * <pre>
   * A list of suggestions.
   * </pre>
   *
   * <code>repeated .google.cloud.dataqna.v1alpha.Suggestion suggestions = 1;</code>
   */
  com.google.cloud.dataqna.v1alpha.Suggestion getSuggestions(int index);
  /**
   * <pre>
   * A list of suggestions.
   * </pre>
   *
   * <code>repeated .google.cloud.dataqna.v1alpha.Suggestion suggestions = 1;</code>
   */
  int getSuggestionsCount();
  /**
   * <pre>
   * A list of suggestions.
   * </pre>
   *
   * <code>repeated .google.cloud.dataqna.v1alpha.Suggestion suggestions = 1;</code>
   */
  java.util.List<? extends com.google.cloud.dataqna.v1alpha.SuggestionOrBuilder> 
      getSuggestionsOrBuilderList();
  /**
   * <pre>
   * A list of suggestions.
   * </pre>
   *
   * <code>repeated .google.cloud.dataqna.v1alpha.Suggestion suggestions = 1;</code>
   */
  com.google.cloud.dataqna.v1alpha.SuggestionOrBuilder getSuggestionsOrBuilder(
      int index);
}
