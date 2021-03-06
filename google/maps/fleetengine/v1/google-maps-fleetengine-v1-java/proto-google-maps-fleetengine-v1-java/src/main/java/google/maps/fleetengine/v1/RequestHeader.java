// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/maps/fleetengine/v1/header.proto

package google.maps.fleetengine.v1;

/**
 * <pre>
 * A RequestHeader contains fields common to all Fleet Engine RPC requests.
 * </pre>
 *
 * Protobuf type {@code maps.fleetengine.v1.RequestHeader}
 */
public final class RequestHeader extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:maps.fleetengine.v1.RequestHeader)
    RequestHeaderOrBuilder {
private static final long serialVersionUID = 0L;
  // Use RequestHeader.newBuilder() to construct.
  private RequestHeader(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private RequestHeader() {
    languageCode_ = "";
    regionCode_ = "";
    sdkVersion_ = "";
    osVersion_ = "";
    deviceModel_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new RequestHeader();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private RequestHeader(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    this();
    if (extensionRegistry == null) {
      throw new java.lang.NullPointerException();
    }
    com.google.protobuf.UnknownFieldSet.Builder unknownFields =
        com.google.protobuf.UnknownFieldSet.newBuilder();
    try {
      boolean done = false;
      while (!done) {
        int tag = input.readTag();
        switch (tag) {
          case 0:
            done = true;
            break;
          case 10: {
            java.lang.String s = input.readStringRequireUtf8();

            languageCode_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            regionCode_ = s;
            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            sdkVersion_ = s;
            break;
          }
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();

            osVersion_ = s;
            break;
          }
          case 42: {
            java.lang.String s = input.readStringRequireUtf8();

            deviceModel_ = s;
            break;
          }
          default: {
            if (!parseUnknownField(
                input, unknownFields, extensionRegistry, tag)) {
              done = true;
            }
            break;
          }
        }
      }
    } catch (com.google.protobuf.InvalidProtocolBufferException e) {
      throw e.setUnfinishedMessage(this);
    } catch (java.io.IOException e) {
      throw new com.google.protobuf.InvalidProtocolBufferException(
          e).setUnfinishedMessage(this);
    } finally {
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return google.maps.fleetengine.v1.Headers.internal_static_maps_fleetengine_v1_RequestHeader_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return google.maps.fleetengine.v1.Headers.internal_static_maps_fleetengine_v1_RequestHeader_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            google.maps.fleetengine.v1.RequestHeader.class, google.maps.fleetengine.v1.RequestHeader.Builder.class);
  }

  public static final int LANGUAGE_CODE_FIELD_NUMBER = 1;
  private volatile java.lang.Object languageCode_;
  /**
   * <pre>
   * The language requested. The external form of Google International
   * Identifiers Initiative (III) LanguageCode objects. If none is specified,
   * return a name in any language, with a preference for English if such a
   * name exists.
   * </pre>
   *
   * <code>string language_code = 1;</code>
   * @return The languageCode.
   */
  @java.lang.Override
  public java.lang.String getLanguageCode() {
    java.lang.Object ref = languageCode_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      languageCode_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The language requested. The external form of Google International
   * Identifiers Initiative (III) LanguageCode objects. If none is specified,
   * return a name in any language, with a preference for English if such a
   * name exists.
   * </pre>
   *
   * <code>string language_code = 1;</code>
   * @return The bytes for languageCode.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getLanguageCodeBytes() {
    java.lang.Object ref = languageCode_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      languageCode_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int REGION_CODE_FIELD_NUMBER = 2;
  private volatile java.lang.Object regionCode_;
  /**
   * <pre>
   * Required. CLDR region code of the region where the request originates.
   * </pre>
   *
   * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The regionCode.
   */
  @java.lang.Override
  public java.lang.String getRegionCode() {
    java.lang.Object ref = regionCode_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      regionCode_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. CLDR region code of the region where the request originates.
   * </pre>
   *
   * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for regionCode.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getRegionCodeBytes() {
    java.lang.Object ref = regionCode_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      regionCode_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int SDK_VERSION_FIELD_NUMBER = 3;
  private volatile java.lang.Object sdkVersion_;
  /**
   * <pre>
   * Version of the calling SDK, if applicable.
   * </pre>
   *
   * <code>string sdk_version = 3;</code>
   * @return The sdkVersion.
   */
  @java.lang.Override
  public java.lang.String getSdkVersion() {
    java.lang.Object ref = sdkVersion_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      sdkVersion_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Version of the calling SDK, if applicable.
   * </pre>
   *
   * <code>string sdk_version = 3;</code>
   * @return The bytes for sdkVersion.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getSdkVersionBytes() {
    java.lang.Object ref = sdkVersion_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      sdkVersion_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int OS_VERSION_FIELD_NUMBER = 4;
  private volatile java.lang.Object osVersion_;
  /**
   * <pre>
   * Version of the operating system on which the calling SDK is running.
   * </pre>
   *
   * <code>string os_version = 4;</code>
   * @return The osVersion.
   */
  @java.lang.Override
  public java.lang.String getOsVersion() {
    java.lang.Object ref = osVersion_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      osVersion_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Version of the operating system on which the calling SDK is running.
   * </pre>
   *
   * <code>string os_version = 4;</code>
   * @return The bytes for osVersion.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getOsVersionBytes() {
    java.lang.Object ref = osVersion_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      osVersion_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int DEVICE_MODEL_FIELD_NUMBER = 5;
  private volatile java.lang.Object deviceModel_;
  /**
   * <pre>
   * Model of the device on which the calling SDK is running.
   * </pre>
   *
   * <code>string device_model = 5;</code>
   * @return The deviceModel.
   */
  @java.lang.Override
  public java.lang.String getDeviceModel() {
    java.lang.Object ref = deviceModel_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      deviceModel_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Model of the device on which the calling SDK is running.
   * </pre>
   *
   * <code>string device_model = 5;</code>
   * @return The bytes for deviceModel.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getDeviceModelBytes() {
    java.lang.Object ref = deviceModel_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      deviceModel_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  private byte memoizedIsInitialized = -1;
  @java.lang.Override
  public final boolean isInitialized() {
    byte isInitialized = memoizedIsInitialized;
    if (isInitialized == 1) return true;
    if (isInitialized == 0) return false;

    memoizedIsInitialized = 1;
    return true;
  }

  @java.lang.Override
  public void writeTo(com.google.protobuf.CodedOutputStream output)
                      throws java.io.IOException {
    if (!getLanguageCodeBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, languageCode_);
    }
    if (!getRegionCodeBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, regionCode_);
    }
    if (!getSdkVersionBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, sdkVersion_);
    }
    if (!getOsVersionBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, osVersion_);
    }
    if (!getDeviceModelBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 5, deviceModel_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getLanguageCodeBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, languageCode_);
    }
    if (!getRegionCodeBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, regionCode_);
    }
    if (!getSdkVersionBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, sdkVersion_);
    }
    if (!getOsVersionBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, osVersion_);
    }
    if (!getDeviceModelBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(5, deviceModel_);
    }
    size += unknownFields.getSerializedSize();
    memoizedSize = size;
    return size;
  }

  @java.lang.Override
  public boolean equals(final java.lang.Object obj) {
    if (obj == this) {
     return true;
    }
    if (!(obj instanceof google.maps.fleetengine.v1.RequestHeader)) {
      return super.equals(obj);
    }
    google.maps.fleetengine.v1.RequestHeader other = (google.maps.fleetengine.v1.RequestHeader) obj;

    if (!getLanguageCode()
        .equals(other.getLanguageCode())) return false;
    if (!getRegionCode()
        .equals(other.getRegionCode())) return false;
    if (!getSdkVersion()
        .equals(other.getSdkVersion())) return false;
    if (!getOsVersion()
        .equals(other.getOsVersion())) return false;
    if (!getDeviceModel()
        .equals(other.getDeviceModel())) return false;
    if (!unknownFields.equals(other.unknownFields)) return false;
    return true;
  }

  @java.lang.Override
  public int hashCode() {
    if (memoizedHashCode != 0) {
      return memoizedHashCode;
    }
    int hash = 41;
    hash = (19 * hash) + getDescriptor().hashCode();
    hash = (37 * hash) + LANGUAGE_CODE_FIELD_NUMBER;
    hash = (53 * hash) + getLanguageCode().hashCode();
    hash = (37 * hash) + REGION_CODE_FIELD_NUMBER;
    hash = (53 * hash) + getRegionCode().hashCode();
    hash = (37 * hash) + SDK_VERSION_FIELD_NUMBER;
    hash = (53 * hash) + getSdkVersion().hashCode();
    hash = (37 * hash) + OS_VERSION_FIELD_NUMBER;
    hash = (53 * hash) + getOsVersion().hashCode();
    hash = (37 * hash) + DEVICE_MODEL_FIELD_NUMBER;
    hash = (53 * hash) + getDeviceModel().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static google.maps.fleetengine.v1.RequestHeader parseFrom(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }

  @java.lang.Override
  public Builder newBuilderForType() { return newBuilder(); }
  public static Builder newBuilder() {
    return DEFAULT_INSTANCE.toBuilder();
  }
  public static Builder newBuilder(google.maps.fleetengine.v1.RequestHeader prototype) {
    return DEFAULT_INSTANCE.toBuilder().mergeFrom(prototype);
  }
  @java.lang.Override
  public Builder toBuilder() {
    return this == DEFAULT_INSTANCE
        ? new Builder() : new Builder().mergeFrom(this);
  }

  @java.lang.Override
  protected Builder newBuilderForType(
      com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
    Builder builder = new Builder(parent);
    return builder;
  }
  /**
   * <pre>
   * A RequestHeader contains fields common to all Fleet Engine RPC requests.
   * </pre>
   *
   * Protobuf type {@code maps.fleetengine.v1.RequestHeader}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:maps.fleetengine.v1.RequestHeader)
      google.maps.fleetengine.v1.RequestHeaderOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return google.maps.fleetengine.v1.Headers.internal_static_maps_fleetengine_v1_RequestHeader_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return google.maps.fleetengine.v1.Headers.internal_static_maps_fleetengine_v1_RequestHeader_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              google.maps.fleetengine.v1.RequestHeader.class, google.maps.fleetengine.v1.RequestHeader.Builder.class);
    }

    // Construct using google.maps.fleetengine.v1.RequestHeader.newBuilder()
    private Builder() {
      maybeForceBuilderInitialization();
    }

    private Builder(
        com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
      super(parent);
      maybeForceBuilderInitialization();
    }
    private void maybeForceBuilderInitialization() {
      if (com.google.protobuf.GeneratedMessageV3
              .alwaysUseFieldBuilders) {
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      languageCode_ = "";

      regionCode_ = "";

      sdkVersion_ = "";

      osVersion_ = "";

      deviceModel_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return google.maps.fleetengine.v1.Headers.internal_static_maps_fleetengine_v1_RequestHeader_descriptor;
    }

    @java.lang.Override
    public google.maps.fleetengine.v1.RequestHeader getDefaultInstanceForType() {
      return google.maps.fleetengine.v1.RequestHeader.getDefaultInstance();
    }

    @java.lang.Override
    public google.maps.fleetengine.v1.RequestHeader build() {
      google.maps.fleetengine.v1.RequestHeader result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public google.maps.fleetengine.v1.RequestHeader buildPartial() {
      google.maps.fleetengine.v1.RequestHeader result = new google.maps.fleetengine.v1.RequestHeader(this);
      result.languageCode_ = languageCode_;
      result.regionCode_ = regionCode_;
      result.sdkVersion_ = sdkVersion_;
      result.osVersion_ = osVersion_;
      result.deviceModel_ = deviceModel_;
      onBuilt();
      return result;
    }

    @java.lang.Override
    public Builder clone() {
      return super.clone();
    }
    @java.lang.Override
    public Builder setField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return super.setField(field, value);
    }
    @java.lang.Override
    public Builder clearField(
        com.google.protobuf.Descriptors.FieldDescriptor field) {
      return super.clearField(field);
    }
    @java.lang.Override
    public Builder clearOneof(
        com.google.protobuf.Descriptors.OneofDescriptor oneof) {
      return super.clearOneof(oneof);
    }
    @java.lang.Override
    public Builder setRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        int index, java.lang.Object value) {
      return super.setRepeatedField(field, index, value);
    }
    @java.lang.Override
    public Builder addRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return super.addRepeatedField(field, value);
    }
    @java.lang.Override
    public Builder mergeFrom(com.google.protobuf.Message other) {
      if (other instanceof google.maps.fleetengine.v1.RequestHeader) {
        return mergeFrom((google.maps.fleetengine.v1.RequestHeader)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(google.maps.fleetengine.v1.RequestHeader other) {
      if (other == google.maps.fleetengine.v1.RequestHeader.getDefaultInstance()) return this;
      if (!other.getLanguageCode().isEmpty()) {
        languageCode_ = other.languageCode_;
        onChanged();
      }
      if (!other.getRegionCode().isEmpty()) {
        regionCode_ = other.regionCode_;
        onChanged();
      }
      if (!other.getSdkVersion().isEmpty()) {
        sdkVersion_ = other.sdkVersion_;
        onChanged();
      }
      if (!other.getOsVersion().isEmpty()) {
        osVersion_ = other.osVersion_;
        onChanged();
      }
      if (!other.getDeviceModel().isEmpty()) {
        deviceModel_ = other.deviceModel_;
        onChanged();
      }
      this.mergeUnknownFields(other.unknownFields);
      onChanged();
      return this;
    }

    @java.lang.Override
    public final boolean isInitialized() {
      return true;
    }

    @java.lang.Override
    public Builder mergeFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      google.maps.fleetengine.v1.RequestHeader parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (google.maps.fleetengine.v1.RequestHeader) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object languageCode_ = "";
    /**
     * <pre>
     * The language requested. The external form of Google International
     * Identifiers Initiative (III) LanguageCode objects. If none is specified,
     * return a name in any language, with a preference for English if such a
     * name exists.
     * </pre>
     *
     * <code>string language_code = 1;</code>
     * @return The languageCode.
     */
    public java.lang.String getLanguageCode() {
      java.lang.Object ref = languageCode_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        languageCode_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The language requested. The external form of Google International
     * Identifiers Initiative (III) LanguageCode objects. If none is specified,
     * return a name in any language, with a preference for English if such a
     * name exists.
     * </pre>
     *
     * <code>string language_code = 1;</code>
     * @return The bytes for languageCode.
     */
    public com.google.protobuf.ByteString
        getLanguageCodeBytes() {
      java.lang.Object ref = languageCode_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        languageCode_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The language requested. The external form of Google International
     * Identifiers Initiative (III) LanguageCode objects. If none is specified,
     * return a name in any language, with a preference for English if such a
     * name exists.
     * </pre>
     *
     * <code>string language_code = 1;</code>
     * @param value The languageCode to set.
     * @return This builder for chaining.
     */
    public Builder setLanguageCode(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      languageCode_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The language requested. The external form of Google International
     * Identifiers Initiative (III) LanguageCode objects. If none is specified,
     * return a name in any language, with a preference for English if such a
     * name exists.
     * </pre>
     *
     * <code>string language_code = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearLanguageCode() {
      
      languageCode_ = getDefaultInstance().getLanguageCode();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The language requested. The external form of Google International
     * Identifiers Initiative (III) LanguageCode objects. If none is specified,
     * return a name in any language, with a preference for English if such a
     * name exists.
     * </pre>
     *
     * <code>string language_code = 1;</code>
     * @param value The bytes for languageCode to set.
     * @return This builder for chaining.
     */
    public Builder setLanguageCodeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      languageCode_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object regionCode_ = "";
    /**
     * <pre>
     * Required. CLDR region code of the region where the request originates.
     * </pre>
     *
     * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The regionCode.
     */
    public java.lang.String getRegionCode() {
      java.lang.Object ref = regionCode_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        regionCode_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. CLDR region code of the region where the request originates.
     * </pre>
     *
     * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The bytes for regionCode.
     */
    public com.google.protobuf.ByteString
        getRegionCodeBytes() {
      java.lang.Object ref = regionCode_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        regionCode_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. CLDR region code of the region where the request originates.
     * </pre>
     *
     * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The regionCode to set.
     * @return This builder for chaining.
     */
    public Builder setRegionCode(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      regionCode_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. CLDR region code of the region where the request originates.
     * </pre>
     *
     * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return This builder for chaining.
     */
    public Builder clearRegionCode() {
      
      regionCode_ = getDefaultInstance().getRegionCode();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. CLDR region code of the region where the request originates.
     * </pre>
     *
     * <code>string region_code = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The bytes for regionCode to set.
     * @return This builder for chaining.
     */
    public Builder setRegionCodeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      regionCode_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object sdkVersion_ = "";
    /**
     * <pre>
     * Version of the calling SDK, if applicable.
     * </pre>
     *
     * <code>string sdk_version = 3;</code>
     * @return The sdkVersion.
     */
    public java.lang.String getSdkVersion() {
      java.lang.Object ref = sdkVersion_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        sdkVersion_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Version of the calling SDK, if applicable.
     * </pre>
     *
     * <code>string sdk_version = 3;</code>
     * @return The bytes for sdkVersion.
     */
    public com.google.protobuf.ByteString
        getSdkVersionBytes() {
      java.lang.Object ref = sdkVersion_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        sdkVersion_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Version of the calling SDK, if applicable.
     * </pre>
     *
     * <code>string sdk_version = 3;</code>
     * @param value The sdkVersion to set.
     * @return This builder for chaining.
     */
    public Builder setSdkVersion(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      sdkVersion_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Version of the calling SDK, if applicable.
     * </pre>
     *
     * <code>string sdk_version = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearSdkVersion() {
      
      sdkVersion_ = getDefaultInstance().getSdkVersion();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Version of the calling SDK, if applicable.
     * </pre>
     *
     * <code>string sdk_version = 3;</code>
     * @param value The bytes for sdkVersion to set.
     * @return This builder for chaining.
     */
    public Builder setSdkVersionBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      sdkVersion_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object osVersion_ = "";
    /**
     * <pre>
     * Version of the operating system on which the calling SDK is running.
     * </pre>
     *
     * <code>string os_version = 4;</code>
     * @return The osVersion.
     */
    public java.lang.String getOsVersion() {
      java.lang.Object ref = osVersion_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        osVersion_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Version of the operating system on which the calling SDK is running.
     * </pre>
     *
     * <code>string os_version = 4;</code>
     * @return The bytes for osVersion.
     */
    public com.google.protobuf.ByteString
        getOsVersionBytes() {
      java.lang.Object ref = osVersion_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        osVersion_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Version of the operating system on which the calling SDK is running.
     * </pre>
     *
     * <code>string os_version = 4;</code>
     * @param value The osVersion to set.
     * @return This builder for chaining.
     */
    public Builder setOsVersion(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      osVersion_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Version of the operating system on which the calling SDK is running.
     * </pre>
     *
     * <code>string os_version = 4;</code>
     * @return This builder for chaining.
     */
    public Builder clearOsVersion() {
      
      osVersion_ = getDefaultInstance().getOsVersion();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Version of the operating system on which the calling SDK is running.
     * </pre>
     *
     * <code>string os_version = 4;</code>
     * @param value The bytes for osVersion to set.
     * @return This builder for chaining.
     */
    public Builder setOsVersionBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      osVersion_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object deviceModel_ = "";
    /**
     * <pre>
     * Model of the device on which the calling SDK is running.
     * </pre>
     *
     * <code>string device_model = 5;</code>
     * @return The deviceModel.
     */
    public java.lang.String getDeviceModel() {
      java.lang.Object ref = deviceModel_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        deviceModel_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Model of the device on which the calling SDK is running.
     * </pre>
     *
     * <code>string device_model = 5;</code>
     * @return The bytes for deviceModel.
     */
    public com.google.protobuf.ByteString
        getDeviceModelBytes() {
      java.lang.Object ref = deviceModel_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        deviceModel_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Model of the device on which the calling SDK is running.
     * </pre>
     *
     * <code>string device_model = 5;</code>
     * @param value The deviceModel to set.
     * @return This builder for chaining.
     */
    public Builder setDeviceModel(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      deviceModel_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Model of the device on which the calling SDK is running.
     * </pre>
     *
     * <code>string device_model = 5;</code>
     * @return This builder for chaining.
     */
    public Builder clearDeviceModel() {
      
      deviceModel_ = getDefaultInstance().getDeviceModel();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Model of the device on which the calling SDK is running.
     * </pre>
     *
     * <code>string device_model = 5;</code>
     * @param value The bytes for deviceModel to set.
     * @return This builder for chaining.
     */
    public Builder setDeviceModelBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      deviceModel_ = value;
      onChanged();
      return this;
    }
    @java.lang.Override
    public final Builder setUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.setUnknownFields(unknownFields);
    }

    @java.lang.Override
    public final Builder mergeUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.mergeUnknownFields(unknownFields);
    }


    // @@protoc_insertion_point(builder_scope:maps.fleetengine.v1.RequestHeader)
  }

  // @@protoc_insertion_point(class_scope:maps.fleetengine.v1.RequestHeader)
  private static final google.maps.fleetengine.v1.RequestHeader DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new google.maps.fleetengine.v1.RequestHeader();
  }

  public static google.maps.fleetengine.v1.RequestHeader getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<RequestHeader>
      PARSER = new com.google.protobuf.AbstractParser<RequestHeader>() {
    @java.lang.Override
    public RequestHeader parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new RequestHeader(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<RequestHeader> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<RequestHeader> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public google.maps.fleetengine.v1.RequestHeader getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

