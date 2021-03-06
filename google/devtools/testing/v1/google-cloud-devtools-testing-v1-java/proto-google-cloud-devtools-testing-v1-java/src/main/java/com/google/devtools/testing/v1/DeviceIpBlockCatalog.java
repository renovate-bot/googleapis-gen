// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/testing/v1/test_environment_discovery.proto

package com.google.devtools.testing.v1;

/**
 * <pre>
 * List of IP blocks used by the Firebase Test Lab
 * </pre>
 *
 * Protobuf type {@code google.devtools.testing.v1.DeviceIpBlockCatalog}
 */
public final class DeviceIpBlockCatalog extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.devtools.testing.v1.DeviceIpBlockCatalog)
    DeviceIpBlockCatalogOrBuilder {
private static final long serialVersionUID = 0L;
  // Use DeviceIpBlockCatalog.newBuilder() to construct.
  private DeviceIpBlockCatalog(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private DeviceIpBlockCatalog() {
    ipBlocks_ = java.util.Collections.emptyList();
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new DeviceIpBlockCatalog();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private DeviceIpBlockCatalog(
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
              ipBlocks_ = new java.util.ArrayList<com.google.devtools.testing.v1.DeviceIpBlock>();
              mutable_bitField0_ |= 0x00000001;
            }
            ipBlocks_.add(
                input.readMessage(com.google.devtools.testing.v1.DeviceIpBlock.parser(), extensionRegistry));
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
        ipBlocks_ = java.util.Collections.unmodifiableList(ipBlocks_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.internal_static_google_devtools_testing_v1_DeviceIpBlockCatalog_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.internal_static_google_devtools_testing_v1_DeviceIpBlockCatalog_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.devtools.testing.v1.DeviceIpBlockCatalog.class, com.google.devtools.testing.v1.DeviceIpBlockCatalog.Builder.class);
  }

  public static final int IP_BLOCKS_FIELD_NUMBER = 1;
  private java.util.List<com.google.devtools.testing.v1.DeviceIpBlock> ipBlocks_;
  /**
   * <pre>
   * The device IP blocks used by Firebase Test Lab
   * </pre>
   *
   * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.devtools.testing.v1.DeviceIpBlock> getIpBlocksList() {
    return ipBlocks_;
  }
  /**
   * <pre>
   * The device IP blocks used by Firebase Test Lab
   * </pre>
   *
   * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.devtools.testing.v1.DeviceIpBlockOrBuilder> 
      getIpBlocksOrBuilderList() {
    return ipBlocks_;
  }
  /**
   * <pre>
   * The device IP blocks used by Firebase Test Lab
   * </pre>
   *
   * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
   */
  @java.lang.Override
  public int getIpBlocksCount() {
    return ipBlocks_.size();
  }
  /**
   * <pre>
   * The device IP blocks used by Firebase Test Lab
   * </pre>
   *
   * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
   */
  @java.lang.Override
  public com.google.devtools.testing.v1.DeviceIpBlock getIpBlocks(int index) {
    return ipBlocks_.get(index);
  }
  /**
   * <pre>
   * The device IP blocks used by Firebase Test Lab
   * </pre>
   *
   * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
   */
  @java.lang.Override
  public com.google.devtools.testing.v1.DeviceIpBlockOrBuilder getIpBlocksOrBuilder(
      int index) {
    return ipBlocks_.get(index);
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
    for (int i = 0; i < ipBlocks_.size(); i++) {
      output.writeMessage(1, ipBlocks_.get(i));
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < ipBlocks_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, ipBlocks_.get(i));
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
    if (!(obj instanceof com.google.devtools.testing.v1.DeviceIpBlockCatalog)) {
      return super.equals(obj);
    }
    com.google.devtools.testing.v1.DeviceIpBlockCatalog other = (com.google.devtools.testing.v1.DeviceIpBlockCatalog) obj;

    if (!getIpBlocksList()
        .equals(other.getIpBlocksList())) return false;
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
    if (getIpBlocksCount() > 0) {
      hash = (37 * hash) + IP_BLOCKS_FIELD_NUMBER;
      hash = (53 * hash) + getIpBlocksList().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog parseFrom(
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
  public static Builder newBuilder(com.google.devtools.testing.v1.DeviceIpBlockCatalog prototype) {
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
   * List of IP blocks used by the Firebase Test Lab
   * </pre>
   *
   * Protobuf type {@code google.devtools.testing.v1.DeviceIpBlockCatalog}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.devtools.testing.v1.DeviceIpBlockCatalog)
      com.google.devtools.testing.v1.DeviceIpBlockCatalogOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.internal_static_google_devtools_testing_v1_DeviceIpBlockCatalog_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.internal_static_google_devtools_testing_v1_DeviceIpBlockCatalog_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.devtools.testing.v1.DeviceIpBlockCatalog.class, com.google.devtools.testing.v1.DeviceIpBlockCatalog.Builder.class);
    }

    // Construct using com.google.devtools.testing.v1.DeviceIpBlockCatalog.newBuilder()
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
        getIpBlocksFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (ipBlocksBuilder_ == null) {
        ipBlocks_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        ipBlocksBuilder_.clear();
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.internal_static_google_devtools_testing_v1_DeviceIpBlockCatalog_descriptor;
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.DeviceIpBlockCatalog getDefaultInstanceForType() {
      return com.google.devtools.testing.v1.DeviceIpBlockCatalog.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.DeviceIpBlockCatalog build() {
      com.google.devtools.testing.v1.DeviceIpBlockCatalog result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.DeviceIpBlockCatalog buildPartial() {
      com.google.devtools.testing.v1.DeviceIpBlockCatalog result = new com.google.devtools.testing.v1.DeviceIpBlockCatalog(this);
      int from_bitField0_ = bitField0_;
      if (ipBlocksBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          ipBlocks_ = java.util.Collections.unmodifiableList(ipBlocks_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.ipBlocks_ = ipBlocks_;
      } else {
        result.ipBlocks_ = ipBlocksBuilder_.build();
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
      if (other instanceof com.google.devtools.testing.v1.DeviceIpBlockCatalog) {
        return mergeFrom((com.google.devtools.testing.v1.DeviceIpBlockCatalog)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.devtools.testing.v1.DeviceIpBlockCatalog other) {
      if (other == com.google.devtools.testing.v1.DeviceIpBlockCatalog.getDefaultInstance()) return this;
      if (ipBlocksBuilder_ == null) {
        if (!other.ipBlocks_.isEmpty()) {
          if (ipBlocks_.isEmpty()) {
            ipBlocks_ = other.ipBlocks_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureIpBlocksIsMutable();
            ipBlocks_.addAll(other.ipBlocks_);
          }
          onChanged();
        }
      } else {
        if (!other.ipBlocks_.isEmpty()) {
          if (ipBlocksBuilder_.isEmpty()) {
            ipBlocksBuilder_.dispose();
            ipBlocksBuilder_ = null;
            ipBlocks_ = other.ipBlocks_;
            bitField0_ = (bitField0_ & ~0x00000001);
            ipBlocksBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getIpBlocksFieldBuilder() : null;
          } else {
            ipBlocksBuilder_.addAllMessages(other.ipBlocks_);
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
      com.google.devtools.testing.v1.DeviceIpBlockCatalog parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.devtools.testing.v1.DeviceIpBlockCatalog) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.devtools.testing.v1.DeviceIpBlock> ipBlocks_ =
      java.util.Collections.emptyList();
    private void ensureIpBlocksIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        ipBlocks_ = new java.util.ArrayList<com.google.devtools.testing.v1.DeviceIpBlock>(ipBlocks_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.devtools.testing.v1.DeviceIpBlock, com.google.devtools.testing.v1.DeviceIpBlock.Builder, com.google.devtools.testing.v1.DeviceIpBlockOrBuilder> ipBlocksBuilder_;

    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public java.util.List<com.google.devtools.testing.v1.DeviceIpBlock> getIpBlocksList() {
      if (ipBlocksBuilder_ == null) {
        return java.util.Collections.unmodifiableList(ipBlocks_);
      } else {
        return ipBlocksBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public int getIpBlocksCount() {
      if (ipBlocksBuilder_ == null) {
        return ipBlocks_.size();
      } else {
        return ipBlocksBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public com.google.devtools.testing.v1.DeviceIpBlock getIpBlocks(int index) {
      if (ipBlocksBuilder_ == null) {
        return ipBlocks_.get(index);
      } else {
        return ipBlocksBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder setIpBlocks(
        int index, com.google.devtools.testing.v1.DeviceIpBlock value) {
      if (ipBlocksBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureIpBlocksIsMutable();
        ipBlocks_.set(index, value);
        onChanged();
      } else {
        ipBlocksBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder setIpBlocks(
        int index, com.google.devtools.testing.v1.DeviceIpBlock.Builder builderForValue) {
      if (ipBlocksBuilder_ == null) {
        ensureIpBlocksIsMutable();
        ipBlocks_.set(index, builderForValue.build());
        onChanged();
      } else {
        ipBlocksBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder addIpBlocks(com.google.devtools.testing.v1.DeviceIpBlock value) {
      if (ipBlocksBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureIpBlocksIsMutable();
        ipBlocks_.add(value);
        onChanged();
      } else {
        ipBlocksBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder addIpBlocks(
        int index, com.google.devtools.testing.v1.DeviceIpBlock value) {
      if (ipBlocksBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureIpBlocksIsMutable();
        ipBlocks_.add(index, value);
        onChanged();
      } else {
        ipBlocksBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder addIpBlocks(
        com.google.devtools.testing.v1.DeviceIpBlock.Builder builderForValue) {
      if (ipBlocksBuilder_ == null) {
        ensureIpBlocksIsMutable();
        ipBlocks_.add(builderForValue.build());
        onChanged();
      } else {
        ipBlocksBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder addIpBlocks(
        int index, com.google.devtools.testing.v1.DeviceIpBlock.Builder builderForValue) {
      if (ipBlocksBuilder_ == null) {
        ensureIpBlocksIsMutable();
        ipBlocks_.add(index, builderForValue.build());
        onChanged();
      } else {
        ipBlocksBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder addAllIpBlocks(
        java.lang.Iterable<? extends com.google.devtools.testing.v1.DeviceIpBlock> values) {
      if (ipBlocksBuilder_ == null) {
        ensureIpBlocksIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, ipBlocks_);
        onChanged();
      } else {
        ipBlocksBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder clearIpBlocks() {
      if (ipBlocksBuilder_ == null) {
        ipBlocks_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        ipBlocksBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public Builder removeIpBlocks(int index) {
      if (ipBlocksBuilder_ == null) {
        ensureIpBlocksIsMutable();
        ipBlocks_.remove(index);
        onChanged();
      } else {
        ipBlocksBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public com.google.devtools.testing.v1.DeviceIpBlock.Builder getIpBlocksBuilder(
        int index) {
      return getIpBlocksFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public com.google.devtools.testing.v1.DeviceIpBlockOrBuilder getIpBlocksOrBuilder(
        int index) {
      if (ipBlocksBuilder_ == null) {
        return ipBlocks_.get(index);  } else {
        return ipBlocksBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public java.util.List<? extends com.google.devtools.testing.v1.DeviceIpBlockOrBuilder> 
         getIpBlocksOrBuilderList() {
      if (ipBlocksBuilder_ != null) {
        return ipBlocksBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(ipBlocks_);
      }
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public com.google.devtools.testing.v1.DeviceIpBlock.Builder addIpBlocksBuilder() {
      return getIpBlocksFieldBuilder().addBuilder(
          com.google.devtools.testing.v1.DeviceIpBlock.getDefaultInstance());
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public com.google.devtools.testing.v1.DeviceIpBlock.Builder addIpBlocksBuilder(
        int index) {
      return getIpBlocksFieldBuilder().addBuilder(
          index, com.google.devtools.testing.v1.DeviceIpBlock.getDefaultInstance());
    }
    /**
     * <pre>
     * The device IP blocks used by Firebase Test Lab
     * </pre>
     *
     * <code>repeated .google.devtools.testing.v1.DeviceIpBlock ip_blocks = 1;</code>
     */
    public java.util.List<com.google.devtools.testing.v1.DeviceIpBlock.Builder> 
         getIpBlocksBuilderList() {
      return getIpBlocksFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.devtools.testing.v1.DeviceIpBlock, com.google.devtools.testing.v1.DeviceIpBlock.Builder, com.google.devtools.testing.v1.DeviceIpBlockOrBuilder> 
        getIpBlocksFieldBuilder() {
      if (ipBlocksBuilder_ == null) {
        ipBlocksBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.devtools.testing.v1.DeviceIpBlock, com.google.devtools.testing.v1.DeviceIpBlock.Builder, com.google.devtools.testing.v1.DeviceIpBlockOrBuilder>(
                ipBlocks_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        ipBlocks_ = null;
      }
      return ipBlocksBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.devtools.testing.v1.DeviceIpBlockCatalog)
  }

  // @@protoc_insertion_point(class_scope:google.devtools.testing.v1.DeviceIpBlockCatalog)
  private static final com.google.devtools.testing.v1.DeviceIpBlockCatalog DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.devtools.testing.v1.DeviceIpBlockCatalog();
  }

  public static com.google.devtools.testing.v1.DeviceIpBlockCatalog getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<DeviceIpBlockCatalog>
      PARSER = new com.google.protobuf.AbstractParser<DeviceIpBlockCatalog>() {
    @java.lang.Override
    public DeviceIpBlockCatalog parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new DeviceIpBlockCatalog(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<DeviceIpBlockCatalog> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<DeviceIpBlockCatalog> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.devtools.testing.v1.DeviceIpBlockCatalog getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

