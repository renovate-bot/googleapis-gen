// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/participant.proto

package com.google.cloud.dialogflow.v2beta1;

/**
 * <pre>
 * Represents the natural language speech audio to be processed.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dialogflow.v2beta1.InputAudio}
 */
public final class InputAudio extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dialogflow.v2beta1.InputAudio)
    InputAudioOrBuilder {
private static final long serialVersionUID = 0L;
  // Use InputAudio.newBuilder() to construct.
  private InputAudio(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private InputAudio() {
    audio_ = com.google.protobuf.ByteString.EMPTY;
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new InputAudio();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private InputAudio(
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
            com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder subBuilder = null;
            if (config_ != null) {
              subBuilder = config_.toBuilder();
            }
            config_ = input.readMessage(com.google.cloud.dialogflow.v2beta1.InputAudioConfig.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(config_);
              config_ = subBuilder.buildPartial();
            }

            break;
          }
          case 18: {

            audio_ = input.readBytes();
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
    return com.google.cloud.dialogflow.v2beta1.ParticipantProto.internal_static_google_cloud_dialogflow_v2beta1_InputAudio_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dialogflow.v2beta1.ParticipantProto.internal_static_google_cloud_dialogflow_v2beta1_InputAudio_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dialogflow.v2beta1.InputAudio.class, com.google.cloud.dialogflow.v2beta1.InputAudio.Builder.class);
  }

  public static final int CONFIG_FIELD_NUMBER = 1;
  private com.google.cloud.dialogflow.v2beta1.InputAudioConfig config_;
  /**
   * <pre>
   * Required. Instructs the speech recognizer how to process the speech audio.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
   * @return Whether the config field is set.
   */
  @java.lang.Override
  public boolean hasConfig() {
    return config_ != null;
  }
  /**
   * <pre>
   * Required. Instructs the speech recognizer how to process the speech audio.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
   * @return The config.
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2beta1.InputAudioConfig getConfig() {
    return config_ == null ? com.google.cloud.dialogflow.v2beta1.InputAudioConfig.getDefaultInstance() : config_;
  }
  /**
   * <pre>
   * Required. Instructs the speech recognizer how to process the speech audio.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2beta1.InputAudioConfigOrBuilder getConfigOrBuilder() {
    return getConfig();
  }

  public static final int AUDIO_FIELD_NUMBER = 2;
  private com.google.protobuf.ByteString audio_;
  /**
   * <pre>
   * Required. The natural language speech audio to be processed.
   * A single request can contain up to 1 minute of speech audio data.
   * The transcribed text cannot contain more than 256 bytes.
   * </pre>
   *
   * <code>bytes audio = 2;</code>
   * @return The audio.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString getAudio() {
    return audio_;
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
    if (config_ != null) {
      output.writeMessage(1, getConfig());
    }
    if (!audio_.isEmpty()) {
      output.writeBytes(2, audio_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (config_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getConfig());
    }
    if (!audio_.isEmpty()) {
      size += com.google.protobuf.CodedOutputStream
        .computeBytesSize(2, audio_);
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
    if (!(obj instanceof com.google.cloud.dialogflow.v2beta1.InputAudio)) {
      return super.equals(obj);
    }
    com.google.cloud.dialogflow.v2beta1.InputAudio other = (com.google.cloud.dialogflow.v2beta1.InputAudio) obj;

    if (hasConfig() != other.hasConfig()) return false;
    if (hasConfig()) {
      if (!getConfig()
          .equals(other.getConfig())) return false;
    }
    if (!getAudio()
        .equals(other.getAudio())) return false;
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
    if (hasConfig()) {
      hash = (37 * hash) + CONFIG_FIELD_NUMBER;
      hash = (53 * hash) + getConfig().hashCode();
    }
    hash = (37 * hash) + AUDIO_FIELD_NUMBER;
    hash = (53 * hash) + getAudio().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2beta1.InputAudio parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dialogflow.v2beta1.InputAudio prototype) {
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
   * Represents the natural language speech audio to be processed.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dialogflow.v2beta1.InputAudio}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dialogflow.v2beta1.InputAudio)
      com.google.cloud.dialogflow.v2beta1.InputAudioOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dialogflow.v2beta1.ParticipantProto.internal_static_google_cloud_dialogflow_v2beta1_InputAudio_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dialogflow.v2beta1.ParticipantProto.internal_static_google_cloud_dialogflow_v2beta1_InputAudio_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dialogflow.v2beta1.InputAudio.class, com.google.cloud.dialogflow.v2beta1.InputAudio.Builder.class);
    }

    // Construct using com.google.cloud.dialogflow.v2beta1.InputAudio.newBuilder()
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
      if (configBuilder_ == null) {
        config_ = null;
      } else {
        config_ = null;
        configBuilder_ = null;
      }
      audio_ = com.google.protobuf.ByteString.EMPTY;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dialogflow.v2beta1.ParticipantProto.internal_static_google_cloud_dialogflow_v2beta1_InputAudio_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2beta1.InputAudio getDefaultInstanceForType() {
      return com.google.cloud.dialogflow.v2beta1.InputAudio.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2beta1.InputAudio build() {
      com.google.cloud.dialogflow.v2beta1.InputAudio result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2beta1.InputAudio buildPartial() {
      com.google.cloud.dialogflow.v2beta1.InputAudio result = new com.google.cloud.dialogflow.v2beta1.InputAudio(this);
      if (configBuilder_ == null) {
        result.config_ = config_;
      } else {
        result.config_ = configBuilder_.build();
      }
      result.audio_ = audio_;
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
      if (other instanceof com.google.cloud.dialogflow.v2beta1.InputAudio) {
        return mergeFrom((com.google.cloud.dialogflow.v2beta1.InputAudio)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dialogflow.v2beta1.InputAudio other) {
      if (other == com.google.cloud.dialogflow.v2beta1.InputAudio.getDefaultInstance()) return this;
      if (other.hasConfig()) {
        mergeConfig(other.getConfig());
      }
      if (other.getAudio() != com.google.protobuf.ByteString.EMPTY) {
        setAudio(other.getAudio());
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
      com.google.cloud.dialogflow.v2beta1.InputAudio parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dialogflow.v2beta1.InputAudio) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.cloud.dialogflow.v2beta1.InputAudioConfig config_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.dialogflow.v2beta1.InputAudioConfig, com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder, com.google.cloud.dialogflow.v2beta1.InputAudioConfigOrBuilder> configBuilder_;
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     * @return Whether the config field is set.
     */
    public boolean hasConfig() {
      return configBuilder_ != null || config_ != null;
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     * @return The config.
     */
    public com.google.cloud.dialogflow.v2beta1.InputAudioConfig getConfig() {
      if (configBuilder_ == null) {
        return config_ == null ? com.google.cloud.dialogflow.v2beta1.InputAudioConfig.getDefaultInstance() : config_;
      } else {
        return configBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public Builder setConfig(com.google.cloud.dialogflow.v2beta1.InputAudioConfig value) {
      if (configBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        config_ = value;
        onChanged();
      } else {
        configBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public Builder setConfig(
        com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder builderForValue) {
      if (configBuilder_ == null) {
        config_ = builderForValue.build();
        onChanged();
      } else {
        configBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public Builder mergeConfig(com.google.cloud.dialogflow.v2beta1.InputAudioConfig value) {
      if (configBuilder_ == null) {
        if (config_ != null) {
          config_ =
            com.google.cloud.dialogflow.v2beta1.InputAudioConfig.newBuilder(config_).mergeFrom(value).buildPartial();
        } else {
          config_ = value;
        }
        onChanged();
      } else {
        configBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public Builder clearConfig() {
      if (configBuilder_ == null) {
        config_ = null;
        onChanged();
      } else {
        config_ = null;
        configBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder getConfigBuilder() {
      
      onChanged();
      return getConfigFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    public com.google.cloud.dialogflow.v2beta1.InputAudioConfigOrBuilder getConfigOrBuilder() {
      if (configBuilder_ != null) {
        return configBuilder_.getMessageOrBuilder();
      } else {
        return config_ == null ?
            com.google.cloud.dialogflow.v2beta1.InputAudioConfig.getDefaultInstance() : config_;
      }
    }
    /**
     * <pre>
     * Required. Instructs the speech recognizer how to process the speech audio.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2beta1.InputAudioConfig config = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.dialogflow.v2beta1.InputAudioConfig, com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder, com.google.cloud.dialogflow.v2beta1.InputAudioConfigOrBuilder> 
        getConfigFieldBuilder() {
      if (configBuilder_ == null) {
        configBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.dialogflow.v2beta1.InputAudioConfig, com.google.cloud.dialogflow.v2beta1.InputAudioConfig.Builder, com.google.cloud.dialogflow.v2beta1.InputAudioConfigOrBuilder>(
                getConfig(),
                getParentForChildren(),
                isClean());
        config_ = null;
      }
      return configBuilder_;
    }

    private com.google.protobuf.ByteString audio_ = com.google.protobuf.ByteString.EMPTY;
    /**
     * <pre>
     * Required. The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The transcribed text cannot contain more than 256 bytes.
     * </pre>
     *
     * <code>bytes audio = 2;</code>
     * @return The audio.
     */
    @java.lang.Override
    public com.google.protobuf.ByteString getAudio() {
      return audio_;
    }
    /**
     * <pre>
     * Required. The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The transcribed text cannot contain more than 256 bytes.
     * </pre>
     *
     * <code>bytes audio = 2;</code>
     * @param value The audio to set.
     * @return This builder for chaining.
     */
    public Builder setAudio(com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      audio_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The transcribed text cannot contain more than 256 bytes.
     * </pre>
     *
     * <code>bytes audio = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearAudio() {
      
      audio_ = getDefaultInstance().getAudio();
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dialogflow.v2beta1.InputAudio)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dialogflow.v2beta1.InputAudio)
  private static final com.google.cloud.dialogflow.v2beta1.InputAudio DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dialogflow.v2beta1.InputAudio();
  }

  public static com.google.cloud.dialogflow.v2beta1.InputAudio getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<InputAudio>
      PARSER = new com.google.protobuf.AbstractParser<InputAudio>() {
    @java.lang.Override
    public InputAudio parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new InputAudio(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<InputAudio> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<InputAudio> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dialogflow.v2beta1.InputAudio getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

