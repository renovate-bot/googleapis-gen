// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v7/common/ad_type_infos.proto

package com.google.ads.googleads.v7.common;

public interface VideoTrueViewInStreamAdInfoOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.ads.googleads.v7.common.VideoTrueViewInStreamAdInfo)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Label on the CTA (call-to-action) button taking the user to the video ad's
   * final URL.
   * Required for TrueView for action campaigns, optional otherwise.
   * </pre>
   *
   * <code>optional string action_button_label = 4;</code>
   * @return Whether the actionButtonLabel field is set.
   */
  boolean hasActionButtonLabel();
  /**
   * <pre>
   * Label on the CTA (call-to-action) button taking the user to the video ad's
   * final URL.
   * Required for TrueView for action campaigns, optional otherwise.
   * </pre>
   *
   * <code>optional string action_button_label = 4;</code>
   * @return The actionButtonLabel.
   */
  java.lang.String getActionButtonLabel();
  /**
   * <pre>
   * Label on the CTA (call-to-action) button taking the user to the video ad's
   * final URL.
   * Required for TrueView for action campaigns, optional otherwise.
   * </pre>
   *
   * <code>optional string action_button_label = 4;</code>
   * @return The bytes for actionButtonLabel.
   */
  com.google.protobuf.ByteString
      getActionButtonLabelBytes();

  /**
   * <pre>
   * Additional text displayed with the CTA (call-to-action) button to give
   * context and encourage clicking on the button.
   * </pre>
   *
   * <code>optional string action_headline = 5;</code>
   * @return Whether the actionHeadline field is set.
   */
  boolean hasActionHeadline();
  /**
   * <pre>
   * Additional text displayed with the CTA (call-to-action) button to give
   * context and encourage clicking on the button.
   * </pre>
   *
   * <code>optional string action_headline = 5;</code>
   * @return The actionHeadline.
   */
  java.lang.String getActionHeadline();
  /**
   * <pre>
   * Additional text displayed with the CTA (call-to-action) button to give
   * context and encourage clicking on the button.
   * </pre>
   *
   * <code>optional string action_headline = 5;</code>
   * @return The bytes for actionHeadline.
   */
  com.google.protobuf.ByteString
      getActionHeadlineBytes();

  /**
   * <pre>
   * The MediaFile resource name of the companion banner used with the ad.
   * </pre>
   *
   * <code>optional string companion_banner = 6;</code>
   * @return Whether the companionBanner field is set.
   */
  boolean hasCompanionBanner();
  /**
   * <pre>
   * The MediaFile resource name of the companion banner used with the ad.
   * </pre>
   *
   * <code>optional string companion_banner = 6;</code>
   * @return The companionBanner.
   */
  java.lang.String getCompanionBanner();
  /**
   * <pre>
   * The MediaFile resource name of the companion banner used with the ad.
   * </pre>
   *
   * <code>optional string companion_banner = 6;</code>
   * @return The bytes for companionBanner.
   */
  com.google.protobuf.ByteString
      getCompanionBannerBytes();
}
