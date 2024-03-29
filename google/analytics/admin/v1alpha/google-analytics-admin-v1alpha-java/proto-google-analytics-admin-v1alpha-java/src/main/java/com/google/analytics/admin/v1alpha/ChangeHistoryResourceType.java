// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/admin/v1alpha/resources.proto

package com.google.analytics.admin.v1alpha;

/**
 * <pre>
 * Types of resources whose changes may be returned from change history.
 * </pre>
 *
 * Protobuf enum {@code google.analytics.admin.v1alpha.ChangeHistoryResourceType}
 */
public enum ChangeHistoryResourceType
    implements com.google.protobuf.ProtocolMessageEnum {
  /**
   * <pre>
   * Resource type unknown or not specified.
   * </pre>
   *
   * <code>CHANGE_HISTORY_RESOURCE_TYPE_UNSPECIFIED = 0;</code>
   */
  CHANGE_HISTORY_RESOURCE_TYPE_UNSPECIFIED(0),
  /**
   * <pre>
   * Account resource
   * </pre>
   *
   * <code>ACCOUNT = 1;</code>
   */
  ACCOUNT(1),
  /**
   * <pre>
   * Property resource
   * </pre>
   *
   * <code>PROPERTY = 2;</code>
   */
  PROPERTY(2),
  /**
   * <pre>
   * WebDataStream resource
   * </pre>
   *
   * <code>WEB_DATA_STREAM = 3;</code>
   */
  WEB_DATA_STREAM(3),
  /**
   * <pre>
   * AndroidAppDataStream resource
   * </pre>
   *
   * <code>ANDROID_APP_DATA_STREAM = 4;</code>
   */
  ANDROID_APP_DATA_STREAM(4),
  /**
   * <pre>
   * IosAppDataStream resource
   * </pre>
   *
   * <code>IOS_APP_DATA_STREAM = 5;</code>
   */
  IOS_APP_DATA_STREAM(5),
  /**
   * <pre>
   * FirebaseLink resource
   * </pre>
   *
   * <code>FIREBASE_LINK = 6;</code>
   */
  FIREBASE_LINK(6),
  /**
   * <pre>
   * GoogleAdsLink resource
   * </pre>
   *
   * <code>GOOGLE_ADS_LINK = 7;</code>
   */
  GOOGLE_ADS_LINK(7),
  /**
   * <pre>
   * GoogleSignalsSettings resource
   * </pre>
   *
   * <code>GOOGLE_SIGNALS_SETTINGS = 8;</code>
   */
  GOOGLE_SIGNALS_SETTINGS(8),
  /**
   * <pre>
   * ConversionEvent resource
   * </pre>
   *
   * <code>CONVERSION_EVENT = 9;</code>
   */
  CONVERSION_EVENT(9),
  /**
   * <pre>
   * MeasurementProtocolSecret resource
   * </pre>
   *
   * <code>MEASUREMENT_PROTOCOL_SECRET = 10;</code>
   */
  MEASUREMENT_PROTOCOL_SECRET(10),
  /**
   * <pre>
   * CustomDimension resource
   * </pre>
   *
   * <code>CUSTOM_DIMENSION = 11;</code>
   */
  CUSTOM_DIMENSION(11),
  /**
   * <pre>
   * CustomMetric resource
   * </pre>
   *
   * <code>CUSTOM_METRIC = 12;</code>
   */
  CUSTOM_METRIC(12),
  /**
   * <pre>
   * DataRetentionSettings resource
   * </pre>
   *
   * <code>DATA_RETENTION_SETTINGS = 13;</code>
   */
  DATA_RETENTION_SETTINGS(13),
  /**
   * <pre>
   * DisplayVideo360AdvertiserLink resource
   * </pre>
   *
   * <code>DISPLAY_VIDEO_360_ADVERTISER_LINK = 14;</code>
   */
  DISPLAY_VIDEO_360_ADVERTISER_LINK(14),
  /**
   * <pre>
   * DisplayVideo360AdvertiserLinkProposal resource
   * </pre>
   *
   * <code>DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL = 15;</code>
   */
  DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL(15),
  UNRECOGNIZED(-1),
  ;

  /**
   * <pre>
   * Resource type unknown or not specified.
   * </pre>
   *
   * <code>CHANGE_HISTORY_RESOURCE_TYPE_UNSPECIFIED = 0;</code>
   */
  public static final int CHANGE_HISTORY_RESOURCE_TYPE_UNSPECIFIED_VALUE = 0;
  /**
   * <pre>
   * Account resource
   * </pre>
   *
   * <code>ACCOUNT = 1;</code>
   */
  public static final int ACCOUNT_VALUE = 1;
  /**
   * <pre>
   * Property resource
   * </pre>
   *
   * <code>PROPERTY = 2;</code>
   */
  public static final int PROPERTY_VALUE = 2;
  /**
   * <pre>
   * WebDataStream resource
   * </pre>
   *
   * <code>WEB_DATA_STREAM = 3;</code>
   */
  public static final int WEB_DATA_STREAM_VALUE = 3;
  /**
   * <pre>
   * AndroidAppDataStream resource
   * </pre>
   *
   * <code>ANDROID_APP_DATA_STREAM = 4;</code>
   */
  public static final int ANDROID_APP_DATA_STREAM_VALUE = 4;
  /**
   * <pre>
   * IosAppDataStream resource
   * </pre>
   *
   * <code>IOS_APP_DATA_STREAM = 5;</code>
   */
  public static final int IOS_APP_DATA_STREAM_VALUE = 5;
  /**
   * <pre>
   * FirebaseLink resource
   * </pre>
   *
   * <code>FIREBASE_LINK = 6;</code>
   */
  public static final int FIREBASE_LINK_VALUE = 6;
  /**
   * <pre>
   * GoogleAdsLink resource
   * </pre>
   *
   * <code>GOOGLE_ADS_LINK = 7;</code>
   */
  public static final int GOOGLE_ADS_LINK_VALUE = 7;
  /**
   * <pre>
   * GoogleSignalsSettings resource
   * </pre>
   *
   * <code>GOOGLE_SIGNALS_SETTINGS = 8;</code>
   */
  public static final int GOOGLE_SIGNALS_SETTINGS_VALUE = 8;
  /**
   * <pre>
   * ConversionEvent resource
   * </pre>
   *
   * <code>CONVERSION_EVENT = 9;</code>
   */
  public static final int CONVERSION_EVENT_VALUE = 9;
  /**
   * <pre>
   * MeasurementProtocolSecret resource
   * </pre>
   *
   * <code>MEASUREMENT_PROTOCOL_SECRET = 10;</code>
   */
  public static final int MEASUREMENT_PROTOCOL_SECRET_VALUE = 10;
  /**
   * <pre>
   * CustomDimension resource
   * </pre>
   *
   * <code>CUSTOM_DIMENSION = 11;</code>
   */
  public static final int CUSTOM_DIMENSION_VALUE = 11;
  /**
   * <pre>
   * CustomMetric resource
   * </pre>
   *
   * <code>CUSTOM_METRIC = 12;</code>
   */
  public static final int CUSTOM_METRIC_VALUE = 12;
  /**
   * <pre>
   * DataRetentionSettings resource
   * </pre>
   *
   * <code>DATA_RETENTION_SETTINGS = 13;</code>
   */
  public static final int DATA_RETENTION_SETTINGS_VALUE = 13;
  /**
   * <pre>
   * DisplayVideo360AdvertiserLink resource
   * </pre>
   *
   * <code>DISPLAY_VIDEO_360_ADVERTISER_LINK = 14;</code>
   */
  public static final int DISPLAY_VIDEO_360_ADVERTISER_LINK_VALUE = 14;
  /**
   * <pre>
   * DisplayVideo360AdvertiserLinkProposal resource
   * </pre>
   *
   * <code>DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL = 15;</code>
   */
  public static final int DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL_VALUE = 15;


  public final int getNumber() {
    if (this == UNRECOGNIZED) {
      throw new java.lang.IllegalArgumentException(
          "Can't get the number of an unknown enum value.");
    }
    return value;
  }

  /**
   * @param value The numeric wire value of the corresponding enum entry.
   * @return The enum associated with the given numeric wire value.
   * @deprecated Use {@link #forNumber(int)} instead.
   */
  @java.lang.Deprecated
  public static ChangeHistoryResourceType valueOf(int value) {
    return forNumber(value);
  }

  /**
   * @param value The numeric wire value of the corresponding enum entry.
   * @return The enum associated with the given numeric wire value.
   */
  public static ChangeHistoryResourceType forNumber(int value) {
    switch (value) {
      case 0: return CHANGE_HISTORY_RESOURCE_TYPE_UNSPECIFIED;
      case 1: return ACCOUNT;
      case 2: return PROPERTY;
      case 3: return WEB_DATA_STREAM;
      case 4: return ANDROID_APP_DATA_STREAM;
      case 5: return IOS_APP_DATA_STREAM;
      case 6: return FIREBASE_LINK;
      case 7: return GOOGLE_ADS_LINK;
      case 8: return GOOGLE_SIGNALS_SETTINGS;
      case 9: return CONVERSION_EVENT;
      case 10: return MEASUREMENT_PROTOCOL_SECRET;
      case 11: return CUSTOM_DIMENSION;
      case 12: return CUSTOM_METRIC;
      case 13: return DATA_RETENTION_SETTINGS;
      case 14: return DISPLAY_VIDEO_360_ADVERTISER_LINK;
      case 15: return DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL;
      default: return null;
    }
  }

  public static com.google.protobuf.Internal.EnumLiteMap<ChangeHistoryResourceType>
      internalGetValueMap() {
    return internalValueMap;
  }
  private static final com.google.protobuf.Internal.EnumLiteMap<
      ChangeHistoryResourceType> internalValueMap =
        new com.google.protobuf.Internal.EnumLiteMap<ChangeHistoryResourceType>() {
          public ChangeHistoryResourceType findValueByNumber(int number) {
            return ChangeHistoryResourceType.forNumber(number);
          }
        };

  public final com.google.protobuf.Descriptors.EnumValueDescriptor
      getValueDescriptor() {
    if (this == UNRECOGNIZED) {
      throw new java.lang.IllegalStateException(
          "Can't get the descriptor of an unrecognized enum value.");
    }
    return getDescriptor().getValues().get(ordinal());
  }
  public final com.google.protobuf.Descriptors.EnumDescriptor
      getDescriptorForType() {
    return getDescriptor();
  }
  public static final com.google.protobuf.Descriptors.EnumDescriptor
      getDescriptor() {
    return com.google.analytics.admin.v1alpha.ResourcesProto.getDescriptor().getEnumTypes().get(4);
  }

  private static final ChangeHistoryResourceType[] VALUES = values();

  public static ChangeHistoryResourceType valueOf(
      com.google.protobuf.Descriptors.EnumValueDescriptor desc) {
    if (desc.getType() != getDescriptor()) {
      throw new java.lang.IllegalArgumentException(
        "EnumValueDescriptor is not for this type.");
    }
    if (desc.getIndex() == -1) {
      return UNRECOGNIZED;
    }
    return VALUES[desc.getIndex()];
  }

  private final int value;

  private ChangeHistoryResourceType(int value) {
    this.value = value;
  }

  // @@protoc_insertion_point(enum_scope:google.analytics.admin.v1alpha.ChangeHistoryResourceType)
}

