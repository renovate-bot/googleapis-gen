// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v7/services/conversion_upload_service.proto

package com.google.ads.googleads.v7.services;

/**
 * <pre>
 * Identifying information for a successfully processed ClickConversion.
 * </pre>
 *
 * Protobuf type {@code google.ads.googleads.v7.services.ClickConversionResult}
 */
public final class ClickConversionResult extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.ads.googleads.v7.services.ClickConversionResult)
    ClickConversionResultOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ClickConversionResult.newBuilder() to construct.
  private ClickConversionResult(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ClickConversionResult() {
    gclid_ = "";
    conversionAction_ = "";
    conversionDateTime_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ClickConversionResult();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ClickConversionResult(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    this();
    if (extensionRegistry == null) {
      throw new java.lang.NullPointerException();
    }
    int mutable_bitField0_ = 0;
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
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();
            bitField0_ |= 0x00000001;
            gclid_ = s;
            break;
          }
          case 42: {
            java.lang.String s = input.readStringRequireUtf8();
            bitField0_ |= 0x00000002;
            conversionAction_ = s;
            break;
          }
          case 50: {
            java.lang.String s = input.readStringRequireUtf8();
            bitField0_ |= 0x00000004;
            conversionDateTime_ = s;
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
    return com.google.ads.googleads.v7.services.ConversionUploadServiceProto.internal_static_google_ads_googleads_v7_services_ClickConversionResult_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.ads.googleads.v7.services.ConversionUploadServiceProto.internal_static_google_ads_googleads_v7_services_ClickConversionResult_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.ads.googleads.v7.services.ClickConversionResult.class, com.google.ads.googleads.v7.services.ClickConversionResult.Builder.class);
  }

  private int bitField0_;
  public static final int GCLID_FIELD_NUMBER = 4;
  private volatile java.lang.Object gclid_;
  /**
   * <pre>
   * The Google Click ID (gclid) associated with this conversion.
   * </pre>
   *
   * <code>optional string gclid = 4;</code>
   * @return Whether the gclid field is set.
   */
  @java.lang.Override
  public boolean hasGclid() {
    return ((bitField0_ & 0x00000001) != 0);
  }
  /**
   * <pre>
   * The Google Click ID (gclid) associated with this conversion.
   * </pre>
   *
   * <code>optional string gclid = 4;</code>
   * @return The gclid.
   */
  @java.lang.Override
  public java.lang.String getGclid() {
    java.lang.Object ref = gclid_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      gclid_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The Google Click ID (gclid) associated with this conversion.
   * </pre>
   *
   * <code>optional string gclid = 4;</code>
   * @return The bytes for gclid.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getGclidBytes() {
    java.lang.Object ref = gclid_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      gclid_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CONVERSION_ACTION_FIELD_NUMBER = 5;
  private volatile java.lang.Object conversionAction_;
  /**
   * <pre>
   * Resource name of the conversion action associated with this conversion.
   * </pre>
   *
   * <code>optional string conversion_action = 5;</code>
   * @return Whether the conversionAction field is set.
   */
  @java.lang.Override
  public boolean hasConversionAction() {
    return ((bitField0_ & 0x00000002) != 0);
  }
  /**
   * <pre>
   * Resource name of the conversion action associated with this conversion.
   * </pre>
   *
   * <code>optional string conversion_action = 5;</code>
   * @return The conversionAction.
   */
  @java.lang.Override
  public java.lang.String getConversionAction() {
    java.lang.Object ref = conversionAction_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      conversionAction_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Resource name of the conversion action associated with this conversion.
   * </pre>
   *
   * <code>optional string conversion_action = 5;</code>
   * @return The bytes for conversionAction.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getConversionActionBytes() {
    java.lang.Object ref = conversionAction_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      conversionAction_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CONVERSION_DATE_TIME_FIELD_NUMBER = 6;
  private volatile java.lang.Object conversionDateTime_;
  /**
   * <pre>
   * The date time at which the conversion occurred. The format is
   * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
   * </pre>
   *
   * <code>optional string conversion_date_time = 6;</code>
   * @return Whether the conversionDateTime field is set.
   */
  @java.lang.Override
  public boolean hasConversionDateTime() {
    return ((bitField0_ & 0x00000004) != 0);
  }
  /**
   * <pre>
   * The date time at which the conversion occurred. The format is
   * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
   * </pre>
   *
   * <code>optional string conversion_date_time = 6;</code>
   * @return The conversionDateTime.
   */
  @java.lang.Override
  public java.lang.String getConversionDateTime() {
    java.lang.Object ref = conversionDateTime_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      conversionDateTime_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The date time at which the conversion occurred. The format is
   * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
   * </pre>
   *
   * <code>optional string conversion_date_time = 6;</code>
   * @return The bytes for conversionDateTime.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getConversionDateTimeBytes() {
    java.lang.Object ref = conversionDateTime_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      conversionDateTime_ = b;
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
    if (((bitField0_ & 0x00000001) != 0)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, gclid_);
    }
    if (((bitField0_ & 0x00000002) != 0)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 5, conversionAction_);
    }
    if (((bitField0_ & 0x00000004) != 0)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 6, conversionDateTime_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (((bitField0_ & 0x00000001) != 0)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, gclid_);
    }
    if (((bitField0_ & 0x00000002) != 0)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(5, conversionAction_);
    }
    if (((bitField0_ & 0x00000004) != 0)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(6, conversionDateTime_);
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
    if (!(obj instanceof com.google.ads.googleads.v7.services.ClickConversionResult)) {
      return super.equals(obj);
    }
    com.google.ads.googleads.v7.services.ClickConversionResult other = (com.google.ads.googleads.v7.services.ClickConversionResult) obj;

    if (hasGclid() != other.hasGclid()) return false;
    if (hasGclid()) {
      if (!getGclid()
          .equals(other.getGclid())) return false;
    }
    if (hasConversionAction() != other.hasConversionAction()) return false;
    if (hasConversionAction()) {
      if (!getConversionAction()
          .equals(other.getConversionAction())) return false;
    }
    if (hasConversionDateTime() != other.hasConversionDateTime()) return false;
    if (hasConversionDateTime()) {
      if (!getConversionDateTime()
          .equals(other.getConversionDateTime())) return false;
    }
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
    if (hasGclid()) {
      hash = (37 * hash) + GCLID_FIELD_NUMBER;
      hash = (53 * hash) + getGclid().hashCode();
    }
    if (hasConversionAction()) {
      hash = (37 * hash) + CONVERSION_ACTION_FIELD_NUMBER;
      hash = (53 * hash) + getConversionAction().hashCode();
    }
    if (hasConversionDateTime()) {
      hash = (37 * hash) + CONVERSION_DATE_TIME_FIELD_NUMBER;
      hash = (53 * hash) + getConversionDateTime().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.services.ClickConversionResult parseFrom(
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
  public static Builder newBuilder(com.google.ads.googleads.v7.services.ClickConversionResult prototype) {
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
   * Identifying information for a successfully processed ClickConversion.
   * </pre>
   *
   * Protobuf type {@code google.ads.googleads.v7.services.ClickConversionResult}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.ads.googleads.v7.services.ClickConversionResult)
      com.google.ads.googleads.v7.services.ClickConversionResultOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.ads.googleads.v7.services.ConversionUploadServiceProto.internal_static_google_ads_googleads_v7_services_ClickConversionResult_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.ads.googleads.v7.services.ConversionUploadServiceProto.internal_static_google_ads_googleads_v7_services_ClickConversionResult_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.ads.googleads.v7.services.ClickConversionResult.class, com.google.ads.googleads.v7.services.ClickConversionResult.Builder.class);
    }

    // Construct using com.google.ads.googleads.v7.services.ClickConversionResult.newBuilder()
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
      gclid_ = "";
      bitField0_ = (bitField0_ & ~0x00000001);
      conversionAction_ = "";
      bitField0_ = (bitField0_ & ~0x00000002);
      conversionDateTime_ = "";
      bitField0_ = (bitField0_ & ~0x00000004);
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.ads.googleads.v7.services.ConversionUploadServiceProto.internal_static_google_ads_googleads_v7_services_ClickConversionResult_descriptor;
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.services.ClickConversionResult getDefaultInstanceForType() {
      return com.google.ads.googleads.v7.services.ClickConversionResult.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.services.ClickConversionResult build() {
      com.google.ads.googleads.v7.services.ClickConversionResult result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.services.ClickConversionResult buildPartial() {
      com.google.ads.googleads.v7.services.ClickConversionResult result = new com.google.ads.googleads.v7.services.ClickConversionResult(this);
      int from_bitField0_ = bitField0_;
      int to_bitField0_ = 0;
      if (((from_bitField0_ & 0x00000001) != 0)) {
        to_bitField0_ |= 0x00000001;
      }
      result.gclid_ = gclid_;
      if (((from_bitField0_ & 0x00000002) != 0)) {
        to_bitField0_ |= 0x00000002;
      }
      result.conversionAction_ = conversionAction_;
      if (((from_bitField0_ & 0x00000004) != 0)) {
        to_bitField0_ |= 0x00000004;
      }
      result.conversionDateTime_ = conversionDateTime_;
      result.bitField0_ = to_bitField0_;
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
      if (other instanceof com.google.ads.googleads.v7.services.ClickConversionResult) {
        return mergeFrom((com.google.ads.googleads.v7.services.ClickConversionResult)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.ads.googleads.v7.services.ClickConversionResult other) {
      if (other == com.google.ads.googleads.v7.services.ClickConversionResult.getDefaultInstance()) return this;
      if (other.hasGclid()) {
        bitField0_ |= 0x00000001;
        gclid_ = other.gclid_;
        onChanged();
      }
      if (other.hasConversionAction()) {
        bitField0_ |= 0x00000002;
        conversionAction_ = other.conversionAction_;
        onChanged();
      }
      if (other.hasConversionDateTime()) {
        bitField0_ |= 0x00000004;
        conversionDateTime_ = other.conversionDateTime_;
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
      com.google.ads.googleads.v7.services.ClickConversionResult parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.ads.googleads.v7.services.ClickConversionResult) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.lang.Object gclid_ = "";
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @return Whether the gclid field is set.
     */
    public boolean hasGclid() {
      return ((bitField0_ & 0x00000001) != 0);
    }
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @return The gclid.
     */
    public java.lang.String getGclid() {
      java.lang.Object ref = gclid_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        gclid_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @return The bytes for gclid.
     */
    public com.google.protobuf.ByteString
        getGclidBytes() {
      java.lang.Object ref = gclid_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        gclid_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @param value The gclid to set.
     * @return This builder for chaining.
     */
    public Builder setGclid(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  bitField0_ |= 0x00000001;
      gclid_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @return This builder for chaining.
     */
    public Builder clearGclid() {
      bitField0_ = (bitField0_ & ~0x00000001);
      gclid_ = getDefaultInstance().getGclid();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The Google Click ID (gclid) associated with this conversion.
     * </pre>
     *
     * <code>optional string gclid = 4;</code>
     * @param value The bytes for gclid to set.
     * @return This builder for chaining.
     */
    public Builder setGclidBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      bitField0_ |= 0x00000001;
      gclid_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object conversionAction_ = "";
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @return Whether the conversionAction field is set.
     */
    public boolean hasConversionAction() {
      return ((bitField0_ & 0x00000002) != 0);
    }
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @return The conversionAction.
     */
    public java.lang.String getConversionAction() {
      java.lang.Object ref = conversionAction_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        conversionAction_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @return The bytes for conversionAction.
     */
    public com.google.protobuf.ByteString
        getConversionActionBytes() {
      java.lang.Object ref = conversionAction_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        conversionAction_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @param value The conversionAction to set.
     * @return This builder for chaining.
     */
    public Builder setConversionAction(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  bitField0_ |= 0x00000002;
      conversionAction_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @return This builder for chaining.
     */
    public Builder clearConversionAction() {
      bitField0_ = (bitField0_ & ~0x00000002);
      conversionAction_ = getDefaultInstance().getConversionAction();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Resource name of the conversion action associated with this conversion.
     * </pre>
     *
     * <code>optional string conversion_action = 5;</code>
     * @param value The bytes for conversionAction to set.
     * @return This builder for chaining.
     */
    public Builder setConversionActionBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      bitField0_ |= 0x00000002;
      conversionAction_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object conversionDateTime_ = "";
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @return Whether the conversionDateTime field is set.
     */
    public boolean hasConversionDateTime() {
      return ((bitField0_ & 0x00000004) != 0);
    }
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @return The conversionDateTime.
     */
    public java.lang.String getConversionDateTime() {
      java.lang.Object ref = conversionDateTime_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        conversionDateTime_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @return The bytes for conversionDateTime.
     */
    public com.google.protobuf.ByteString
        getConversionDateTimeBytes() {
      java.lang.Object ref = conversionDateTime_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        conversionDateTime_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @param value The conversionDateTime to set.
     * @return This builder for chaining.
     */
    public Builder setConversionDateTime(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  bitField0_ |= 0x00000004;
      conversionDateTime_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @return This builder for chaining.
     */
    public Builder clearConversionDateTime() {
      bitField0_ = (bitField0_ & ~0x00000004);
      conversionDateTime_ = getDefaultInstance().getConversionDateTime();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The date time at which the conversion occurred. The format is
     * "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. “2019-01-01 12:32:45-08:00”.
     * </pre>
     *
     * <code>optional string conversion_date_time = 6;</code>
     * @param value The bytes for conversionDateTime to set.
     * @return This builder for chaining.
     */
    public Builder setConversionDateTimeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      bitField0_ |= 0x00000004;
      conversionDateTime_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.ads.googleads.v7.services.ClickConversionResult)
  }

  // @@protoc_insertion_point(class_scope:google.ads.googleads.v7.services.ClickConversionResult)
  private static final com.google.ads.googleads.v7.services.ClickConversionResult DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.ads.googleads.v7.services.ClickConversionResult();
  }

  public static com.google.ads.googleads.v7.services.ClickConversionResult getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ClickConversionResult>
      PARSER = new com.google.protobuf.AbstractParser<ClickConversionResult>() {
    @java.lang.Override
    public ClickConversionResult parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ClickConversionResult(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ClickConversionResult> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ClickConversionResult> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.ads.googleads.v7.services.ClickConversionResult getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

