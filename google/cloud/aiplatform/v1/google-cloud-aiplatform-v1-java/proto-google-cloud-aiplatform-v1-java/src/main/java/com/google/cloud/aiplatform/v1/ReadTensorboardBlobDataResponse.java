// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/tensorboard_service.proto

package com.google.cloud.aiplatform.v1;

/**
 * <pre>
 * Response message for [TensorboardService.ReadTensorboardBlobData][google.cloud.aiplatform.v1.TensorboardService.ReadTensorboardBlobData].
 * </pre>
 *
 * Protobuf type {@code google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse}
 */
public final class ReadTensorboardBlobDataResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)
    ReadTensorboardBlobDataResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ReadTensorboardBlobDataResponse.newBuilder() to construct.
  private ReadTensorboardBlobDataResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ReadTensorboardBlobDataResponse() {
    blobs_ = java.util.Collections.emptyList();
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ReadTensorboardBlobDataResponse();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ReadTensorboardBlobDataResponse(
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
          case 10: {
            if (!((mutable_bitField0_ & 0x00000001) != 0)) {
              blobs_ = new java.util.ArrayList<com.google.cloud.aiplatform.v1.TensorboardBlob>();
              mutable_bitField0_ |= 0x00000001;
            }
            blobs_.add(
                input.readMessage(com.google.cloud.aiplatform.v1.TensorboardBlob.parser(), extensionRegistry));
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
      if (((mutable_bitField0_ & 0x00000001) != 0)) {
        blobs_ = java.util.Collections.unmodifiableList(blobs_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.aiplatform.v1.TensorboardServiceProto.internal_static_google_cloud_aiplatform_v1_ReadTensorboardBlobDataResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.aiplatform.v1.TensorboardServiceProto.internal_static_google_cloud_aiplatform_v1_ReadTensorboardBlobDataResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.class, com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.Builder.class);
  }

  public static final int BLOBS_FIELD_NUMBER = 1;
  private java.util.List<com.google.cloud.aiplatform.v1.TensorboardBlob> blobs_;
  /**
   * <pre>
   * Blob messages containing blob bytes.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.cloud.aiplatform.v1.TensorboardBlob> getBlobsList() {
    return blobs_;
  }
  /**
   * <pre>
   * Blob messages containing blob bytes.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder> 
      getBlobsOrBuilderList() {
    return blobs_;
  }
  /**
   * <pre>
   * Blob messages containing blob bytes.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
   */
  @java.lang.Override
  public int getBlobsCount() {
    return blobs_.size();
  }
  /**
   * <pre>
   * Blob messages containing blob bytes.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.aiplatform.v1.TensorboardBlob getBlobs(int index) {
    return blobs_.get(index);
  }
  /**
   * <pre>
   * Blob messages containing blob bytes.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder getBlobsOrBuilder(
      int index) {
    return blobs_.get(index);
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
    for (int i = 0; i < blobs_.size(); i++) {
      output.writeMessage(1, blobs_.get(i));
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < blobs_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, blobs_.get(i));
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
    if (!(obj instanceof com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)) {
      return super.equals(obj);
    }
    com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse other = (com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse) obj;

    if (!getBlobsList()
        .equals(other.getBlobsList())) return false;
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
    if (getBlobsCount() > 0) {
      hash = (37 * hash) + BLOBS_FIELD_NUMBER;
      hash = (53 * hash) + getBlobsList().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parseFrom(
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
  public static Builder newBuilder(com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse prototype) {
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
   * Response message for [TensorboardService.ReadTensorboardBlobData][google.cloud.aiplatform.v1.TensorboardService.ReadTensorboardBlobData].
   * </pre>
   *
   * Protobuf type {@code google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)
      com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.aiplatform.v1.TensorboardServiceProto.internal_static_google_cloud_aiplatform_v1_ReadTensorboardBlobDataResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.aiplatform.v1.TensorboardServiceProto.internal_static_google_cloud_aiplatform_v1_ReadTensorboardBlobDataResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.class, com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.Builder.class);
    }

    // Construct using com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.newBuilder()
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
        getBlobsFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (blobsBuilder_ == null) {
        blobs_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        blobsBuilder_.clear();
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.aiplatform.v1.TensorboardServiceProto.internal_static_google_cloud_aiplatform_v1_ReadTensorboardBlobDataResponse_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse getDefaultInstanceForType() {
      return com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse build() {
      com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse buildPartial() {
      com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse result = new com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse(this);
      int from_bitField0_ = bitField0_;
      if (blobsBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          blobs_ = java.util.Collections.unmodifiableList(blobs_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.blobs_ = blobs_;
      } else {
        result.blobs_ = blobsBuilder_.build();
      }
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
      if (other instanceof com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse) {
        return mergeFrom((com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse other) {
      if (other == com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse.getDefaultInstance()) return this;
      if (blobsBuilder_ == null) {
        if (!other.blobs_.isEmpty()) {
          if (blobs_.isEmpty()) {
            blobs_ = other.blobs_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureBlobsIsMutable();
            blobs_.addAll(other.blobs_);
          }
          onChanged();
        }
      } else {
        if (!other.blobs_.isEmpty()) {
          if (blobsBuilder_.isEmpty()) {
            blobsBuilder_.dispose();
            blobsBuilder_ = null;
            blobs_ = other.blobs_;
            bitField0_ = (bitField0_ & ~0x00000001);
            blobsBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getBlobsFieldBuilder() : null;
          } else {
            blobsBuilder_.addAllMessages(other.blobs_);
          }
        }
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
      com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.cloud.aiplatform.v1.TensorboardBlob> blobs_ =
      java.util.Collections.emptyList();
    private void ensureBlobsIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        blobs_ = new java.util.ArrayList<com.google.cloud.aiplatform.v1.TensorboardBlob>(blobs_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.aiplatform.v1.TensorboardBlob, com.google.cloud.aiplatform.v1.TensorboardBlob.Builder, com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder> blobsBuilder_;

    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public java.util.List<com.google.cloud.aiplatform.v1.TensorboardBlob> getBlobsList() {
      if (blobsBuilder_ == null) {
        return java.util.Collections.unmodifiableList(blobs_);
      } else {
        return blobsBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public int getBlobsCount() {
      if (blobsBuilder_ == null) {
        return blobs_.size();
      } else {
        return blobsBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public com.google.cloud.aiplatform.v1.TensorboardBlob getBlobs(int index) {
      if (blobsBuilder_ == null) {
        return blobs_.get(index);
      } else {
        return blobsBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder setBlobs(
        int index, com.google.cloud.aiplatform.v1.TensorboardBlob value) {
      if (blobsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureBlobsIsMutable();
        blobs_.set(index, value);
        onChanged();
      } else {
        blobsBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder setBlobs(
        int index, com.google.cloud.aiplatform.v1.TensorboardBlob.Builder builderForValue) {
      if (blobsBuilder_ == null) {
        ensureBlobsIsMutable();
        blobs_.set(index, builderForValue.build());
        onChanged();
      } else {
        blobsBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder addBlobs(com.google.cloud.aiplatform.v1.TensorboardBlob value) {
      if (blobsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureBlobsIsMutable();
        blobs_.add(value);
        onChanged();
      } else {
        blobsBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder addBlobs(
        int index, com.google.cloud.aiplatform.v1.TensorboardBlob value) {
      if (blobsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureBlobsIsMutable();
        blobs_.add(index, value);
        onChanged();
      } else {
        blobsBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder addBlobs(
        com.google.cloud.aiplatform.v1.TensorboardBlob.Builder builderForValue) {
      if (blobsBuilder_ == null) {
        ensureBlobsIsMutable();
        blobs_.add(builderForValue.build());
        onChanged();
      } else {
        blobsBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder addBlobs(
        int index, com.google.cloud.aiplatform.v1.TensorboardBlob.Builder builderForValue) {
      if (blobsBuilder_ == null) {
        ensureBlobsIsMutable();
        blobs_.add(index, builderForValue.build());
        onChanged();
      } else {
        blobsBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder addAllBlobs(
        java.lang.Iterable<? extends com.google.cloud.aiplatform.v1.TensorboardBlob> values) {
      if (blobsBuilder_ == null) {
        ensureBlobsIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, blobs_);
        onChanged();
      } else {
        blobsBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder clearBlobs() {
      if (blobsBuilder_ == null) {
        blobs_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        blobsBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public Builder removeBlobs(int index) {
      if (blobsBuilder_ == null) {
        ensureBlobsIsMutable();
        blobs_.remove(index);
        onChanged();
      } else {
        blobsBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public com.google.cloud.aiplatform.v1.TensorboardBlob.Builder getBlobsBuilder(
        int index) {
      return getBlobsFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder getBlobsOrBuilder(
        int index) {
      if (blobsBuilder_ == null) {
        return blobs_.get(index);  } else {
        return blobsBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public java.util.List<? extends com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder> 
         getBlobsOrBuilderList() {
      if (blobsBuilder_ != null) {
        return blobsBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(blobs_);
      }
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public com.google.cloud.aiplatform.v1.TensorboardBlob.Builder addBlobsBuilder() {
      return getBlobsFieldBuilder().addBuilder(
          com.google.cloud.aiplatform.v1.TensorboardBlob.getDefaultInstance());
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public com.google.cloud.aiplatform.v1.TensorboardBlob.Builder addBlobsBuilder(
        int index) {
      return getBlobsFieldBuilder().addBuilder(
          index, com.google.cloud.aiplatform.v1.TensorboardBlob.getDefaultInstance());
    }
    /**
     * <pre>
     * Blob messages containing blob bytes.
     * </pre>
     *
     * <code>repeated .google.cloud.aiplatform.v1.TensorboardBlob blobs = 1;</code>
     */
    public java.util.List<com.google.cloud.aiplatform.v1.TensorboardBlob.Builder> 
         getBlobsBuilderList() {
      return getBlobsFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.aiplatform.v1.TensorboardBlob, com.google.cloud.aiplatform.v1.TensorboardBlob.Builder, com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder> 
        getBlobsFieldBuilder() {
      if (blobsBuilder_ == null) {
        blobsBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.cloud.aiplatform.v1.TensorboardBlob, com.google.cloud.aiplatform.v1.TensorboardBlob.Builder, com.google.cloud.aiplatform.v1.TensorboardBlobOrBuilder>(
                blobs_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        blobs_ = null;
      }
      return blobsBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse)
  private static final com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse();
  }

  public static com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ReadTensorboardBlobDataResponse>
      PARSER = new com.google.protobuf.AbstractParser<ReadTensorboardBlobDataResponse>() {
    @java.lang.Override
    public ReadTensorboardBlobDataResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ReadTensorboardBlobDataResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ReadTensorboardBlobDataResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ReadTensorboardBlobDataResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.aiplatform.v1.ReadTensorboardBlobDataResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

