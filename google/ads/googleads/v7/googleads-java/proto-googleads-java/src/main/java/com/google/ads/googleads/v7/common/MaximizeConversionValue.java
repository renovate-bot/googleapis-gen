// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v7/common/bidding.proto

package com.google.ads.googleads.v7.common;

/**
 * <pre>
 * An automated bidding strategy to help get the most conversion value for your
 * campaigns while spending your budget.
 * </pre>
 *
 * Protobuf type {@code google.ads.googleads.v7.common.MaximizeConversionValue}
 */
public final class MaximizeConversionValue extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.ads.googleads.v7.common.MaximizeConversionValue)
    MaximizeConversionValueOrBuilder {
private static final long serialVersionUID = 0L;
  // Use MaximizeConversionValue.newBuilder() to construct.
  private MaximizeConversionValue(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private MaximizeConversionValue() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new MaximizeConversionValue();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private MaximizeConversionValue(
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
          case 17: {
            bitField0_ |= 0x00000001;
            targetRoas_ = input.readDouble();
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
    return com.google.ads.googleads.v7.common.BiddingProto.internal_static_google_ads_googleads_v7_common_MaximizeConversionValue_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.ads.googleads.v7.common.BiddingProto.internal_static_google_ads_googleads_v7_common_MaximizeConversionValue_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.ads.googleads.v7.common.MaximizeConversionValue.class, com.google.ads.googleads.v7.common.MaximizeConversionValue.Builder.class);
  }

  private int bitField0_;
  public static final int TARGET_ROAS_FIELD_NUMBER = 2;
  private double targetRoas_;
  /**
   * <pre>
   * The target return on ad spend (ROAS) option. If set, the bid strategy will
   * maximize revenue while averaging the target return on ad spend. If the
   * target ROAS is high, the bid strategy may not be able to spend the full
   * budget. If the target ROAS is not set, the bid strategy will aim to
   * achieve the highest possible ROAS for the budget.
   * </pre>
   *
   * <code>optional double target_roas = 2;</code>
   * @return Whether the targetRoas field is set.
   */
  @java.lang.Override
  public boolean hasTargetRoas() {
    return ((bitField0_ & 0x00000001) != 0);
  }
  /**
   * <pre>
   * The target return on ad spend (ROAS) option. If set, the bid strategy will
   * maximize revenue while averaging the target return on ad spend. If the
   * target ROAS is high, the bid strategy may not be able to spend the full
   * budget. If the target ROAS is not set, the bid strategy will aim to
   * achieve the highest possible ROAS for the budget.
   * </pre>
   *
   * <code>optional double target_roas = 2;</code>
   * @return The targetRoas.
   */
  @java.lang.Override
  public double getTargetRoas() {
    return targetRoas_;
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
      output.writeDouble(2, targetRoas_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (((bitField0_ & 0x00000001) != 0)) {
      size += com.google.protobuf.CodedOutputStream
        .computeDoubleSize(2, targetRoas_);
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
    if (!(obj instanceof com.google.ads.googleads.v7.common.MaximizeConversionValue)) {
      return super.equals(obj);
    }
    com.google.ads.googleads.v7.common.MaximizeConversionValue other = (com.google.ads.googleads.v7.common.MaximizeConversionValue) obj;

    if (hasTargetRoas() != other.hasTargetRoas()) return false;
    if (hasTargetRoas()) {
      if (java.lang.Double.doubleToLongBits(getTargetRoas())
          != java.lang.Double.doubleToLongBits(
              other.getTargetRoas())) return false;
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
    if (hasTargetRoas()) {
      hash = (37 * hash) + TARGET_ROAS_FIELD_NUMBER;
      hash = (53 * hash) + com.google.protobuf.Internal.hashLong(
          java.lang.Double.doubleToLongBits(getTargetRoas()));
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v7.common.MaximizeConversionValue parseFrom(
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
  public static Builder newBuilder(com.google.ads.googleads.v7.common.MaximizeConversionValue prototype) {
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
   * An automated bidding strategy to help get the most conversion value for your
   * campaigns while spending your budget.
   * </pre>
   *
   * Protobuf type {@code google.ads.googleads.v7.common.MaximizeConversionValue}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.ads.googleads.v7.common.MaximizeConversionValue)
      com.google.ads.googleads.v7.common.MaximizeConversionValueOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.ads.googleads.v7.common.BiddingProto.internal_static_google_ads_googleads_v7_common_MaximizeConversionValue_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.ads.googleads.v7.common.BiddingProto.internal_static_google_ads_googleads_v7_common_MaximizeConversionValue_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.ads.googleads.v7.common.MaximizeConversionValue.class, com.google.ads.googleads.v7.common.MaximizeConversionValue.Builder.class);
    }

    // Construct using com.google.ads.googleads.v7.common.MaximizeConversionValue.newBuilder()
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
      targetRoas_ = 0D;
      bitField0_ = (bitField0_ & ~0x00000001);
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.ads.googleads.v7.common.BiddingProto.internal_static_google_ads_googleads_v7_common_MaximizeConversionValue_descriptor;
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.common.MaximizeConversionValue getDefaultInstanceForType() {
      return com.google.ads.googleads.v7.common.MaximizeConversionValue.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.common.MaximizeConversionValue build() {
      com.google.ads.googleads.v7.common.MaximizeConversionValue result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.ads.googleads.v7.common.MaximizeConversionValue buildPartial() {
      com.google.ads.googleads.v7.common.MaximizeConversionValue result = new com.google.ads.googleads.v7.common.MaximizeConversionValue(this);
      int from_bitField0_ = bitField0_;
      int to_bitField0_ = 0;
      if (((from_bitField0_ & 0x00000001) != 0)) {
        result.targetRoas_ = targetRoas_;
        to_bitField0_ |= 0x00000001;
      }
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
      if (other instanceof com.google.ads.googleads.v7.common.MaximizeConversionValue) {
        return mergeFrom((com.google.ads.googleads.v7.common.MaximizeConversionValue)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.ads.googleads.v7.common.MaximizeConversionValue other) {
      if (other == com.google.ads.googleads.v7.common.MaximizeConversionValue.getDefaultInstance()) return this;
      if (other.hasTargetRoas()) {
        setTargetRoas(other.getTargetRoas());
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
      com.google.ads.googleads.v7.common.MaximizeConversionValue parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.ads.googleads.v7.common.MaximizeConversionValue) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private double targetRoas_ ;
    /**
     * <pre>
     * The target return on ad spend (ROAS) option. If set, the bid strategy will
     * maximize revenue while averaging the target return on ad spend. If the
     * target ROAS is high, the bid strategy may not be able to spend the full
     * budget. If the target ROAS is not set, the bid strategy will aim to
     * achieve the highest possible ROAS for the budget.
     * </pre>
     *
     * <code>optional double target_roas = 2;</code>
     * @return Whether the targetRoas field is set.
     */
    @java.lang.Override
    public boolean hasTargetRoas() {
      return ((bitField0_ & 0x00000001) != 0);
    }
    /**
     * <pre>
     * The target return on ad spend (ROAS) option. If set, the bid strategy will
     * maximize revenue while averaging the target return on ad spend. If the
     * target ROAS is high, the bid strategy may not be able to spend the full
     * budget. If the target ROAS is not set, the bid strategy will aim to
     * achieve the highest possible ROAS for the budget.
     * </pre>
     *
     * <code>optional double target_roas = 2;</code>
     * @return The targetRoas.
     */
    @java.lang.Override
    public double getTargetRoas() {
      return targetRoas_;
    }
    /**
     * <pre>
     * The target return on ad spend (ROAS) option. If set, the bid strategy will
     * maximize revenue while averaging the target return on ad spend. If the
     * target ROAS is high, the bid strategy may not be able to spend the full
     * budget. If the target ROAS is not set, the bid strategy will aim to
     * achieve the highest possible ROAS for the budget.
     * </pre>
     *
     * <code>optional double target_roas = 2;</code>
     * @param value The targetRoas to set.
     * @return This builder for chaining.
     */
    public Builder setTargetRoas(double value) {
      bitField0_ |= 0x00000001;
      targetRoas_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The target return on ad spend (ROAS) option. If set, the bid strategy will
     * maximize revenue while averaging the target return on ad spend. If the
     * target ROAS is high, the bid strategy may not be able to spend the full
     * budget. If the target ROAS is not set, the bid strategy will aim to
     * achieve the highest possible ROAS for the budget.
     * </pre>
     *
     * <code>optional double target_roas = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearTargetRoas() {
      bitField0_ = (bitField0_ & ~0x00000001);
      targetRoas_ = 0D;
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


    // @@protoc_insertion_point(builder_scope:google.ads.googleads.v7.common.MaximizeConversionValue)
  }

  // @@protoc_insertion_point(class_scope:google.ads.googleads.v7.common.MaximizeConversionValue)
  private static final com.google.ads.googleads.v7.common.MaximizeConversionValue DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.ads.googleads.v7.common.MaximizeConversionValue();
  }

  public static com.google.ads.googleads.v7.common.MaximizeConversionValue getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<MaximizeConversionValue>
      PARSER = new com.google.protobuf.AbstractParser<MaximizeConversionValue>() {
    @java.lang.Override
    public MaximizeConversionValue parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new MaximizeConversionValue(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<MaximizeConversionValue> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<MaximizeConversionValue> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.ads.googleads.v7.common.MaximizeConversionValue getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

