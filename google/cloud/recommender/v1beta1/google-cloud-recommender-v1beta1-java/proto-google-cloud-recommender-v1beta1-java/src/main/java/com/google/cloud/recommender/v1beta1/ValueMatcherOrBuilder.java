// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/recommender/v1beta1/recommendation.proto

package com.google.cloud.recommender.v1beta1;

public interface ValueMatcherOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.recommender.v1beta1.ValueMatcher)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * To be used for full regex matching. The regular expression is using the
   * Google RE2 syntax (https://github.com/google/re2/wiki/Syntax), so to be
   * used with RE2::FullMatch
   * </pre>
   *
   * <code>string matches_pattern = 1;</code>
   * @return Whether the matchesPattern field is set.
   */
  boolean hasMatchesPattern();
  /**
   * <pre>
   * To be used for full regex matching. The regular expression is using the
   * Google RE2 syntax (https://github.com/google/re2/wiki/Syntax), so to be
   * used with RE2::FullMatch
   * </pre>
   *
   * <code>string matches_pattern = 1;</code>
   * @return The matchesPattern.
   */
  java.lang.String getMatchesPattern();
  /**
   * <pre>
   * To be used for full regex matching. The regular expression is using the
   * Google RE2 syntax (https://github.com/google/re2/wiki/Syntax), so to be
   * used with RE2::FullMatch
   * </pre>
   *
   * <code>string matches_pattern = 1;</code>
   * @return The bytes for matchesPattern.
   */
  com.google.protobuf.ByteString
      getMatchesPatternBytes();

  public com.google.cloud.recommender.v1beta1.ValueMatcher.MatchVariantCase getMatchVariantCase();
}
