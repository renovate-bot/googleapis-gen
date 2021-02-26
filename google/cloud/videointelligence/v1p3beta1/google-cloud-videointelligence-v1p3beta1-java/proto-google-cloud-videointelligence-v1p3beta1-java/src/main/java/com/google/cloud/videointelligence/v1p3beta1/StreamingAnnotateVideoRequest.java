// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/videointelligence/v1p3beta1/video_intelligence.proto

package com.google.cloud.videointelligence.v1p3beta1;

/**
 * <pre>
 * The top-level message sent by the client for the `StreamingAnnotateVideo`
 * method. Multiple `StreamingAnnotateVideoRequest` messages are sent.
 * The first message must only contain a `StreamingVideoConfig` message.
 * All subsequent messages must only contain `input_content` data.
 * </pre>
 *
 * Protobuf type {@code google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest}
 */
public final class StreamingAnnotateVideoRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)
    StreamingAnnotateVideoRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use StreamingAnnotateVideoRequest.newBuilder() to construct.
  private StreamingAnnotateVideoRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private StreamingAnnotateVideoRequest() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new StreamingAnnotateVideoRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private StreamingAnnotateVideoRequest(
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
            com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder subBuilder = null;
            if (streamingRequestCase_ == 1) {
              subBuilder = ((com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_).toBuilder();
            }
            streamingRequest_ =
                input.readMessage(com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_);
              streamingRequest_ = subBuilder.buildPartial();
            }
            streamingRequestCase_ = 1;
            break;
          }
          case 18: {
            streamingRequestCase_ = 2;
            streamingRequest_ = input.readBytes();
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
    return com.google.cloud.videointelligence.v1p3beta1.VideoIntelligenceServiceProto.internal_static_google_cloud_videointelligence_v1p3beta1_StreamingAnnotateVideoRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.videointelligence.v1p3beta1.VideoIntelligenceServiceProto.internal_static_google_cloud_videointelligence_v1p3beta1_StreamingAnnotateVideoRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.class, com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.Builder.class);
  }

  private int streamingRequestCase_ = 0;
  private java.lang.Object streamingRequest_;
  public enum StreamingRequestCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    VIDEO_CONFIG(1),
    INPUT_CONTENT(2),
    STREAMINGREQUEST_NOT_SET(0);
    private final int value;
    private StreamingRequestCase(int value) {
      this.value = value;
    }
    /**
     * @param value The number of the enum to look for.
     * @return The enum associated with the given number.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static StreamingRequestCase valueOf(int value) {
      return forNumber(value);
    }

    public static StreamingRequestCase forNumber(int value) {
      switch (value) {
        case 1: return VIDEO_CONFIG;
        case 2: return INPUT_CONTENT;
        case 0: return STREAMINGREQUEST_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public StreamingRequestCase
  getStreamingRequestCase() {
    return StreamingRequestCase.forNumber(
        streamingRequestCase_);
  }

  public static final int VIDEO_CONFIG_FIELD_NUMBER = 1;
  /**
   * <pre>
   * Provides information to the annotator, specifing how to process the
   * request. The first `AnnotateStreamingVideoRequest` message must only
   * contain a `video_config` message.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
   * @return Whether the videoConfig field is set.
   */
  @java.lang.Override
  public boolean hasVideoConfig() {
    return streamingRequestCase_ == 1;
  }
  /**
   * <pre>
   * Provides information to the annotator, specifing how to process the
   * request. The first `AnnotateStreamingVideoRequest` message must only
   * contain a `video_config` message.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
   * @return The videoConfig.
   */
  @java.lang.Override
  public com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig getVideoConfig() {
    if (streamingRequestCase_ == 1) {
       return (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_;
    }
    return com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
  }
  /**
   * <pre>
   * Provides information to the annotator, specifing how to process the
   * request. The first `AnnotateStreamingVideoRequest` message must only
   * contain a `video_config` message.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfigOrBuilder getVideoConfigOrBuilder() {
    if (streamingRequestCase_ == 1) {
       return (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_;
    }
    return com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
  }

  public static final int INPUT_CONTENT_FIELD_NUMBER = 2;
  /**
   * <pre>
   * The video data to be annotated. Chunks of video data are sequentially
   * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
   * `StreamingAnnotateVideoRequest` message containing only
   * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
   * messages must only contain `input_content` field.
   * Note: as with all bytes fields, protobuffers use a pure binary
   * representation (not base64).
   * </pre>
   *
   * <code>bytes input_content = 2;</code>
   * @return Whether the inputContent field is set.
   */
  @java.lang.Override
  public boolean hasInputContent() {
    return streamingRequestCase_ == 2;
  }
  /**
   * <pre>
   * The video data to be annotated. Chunks of video data are sequentially
   * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
   * `StreamingAnnotateVideoRequest` message containing only
   * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
   * messages must only contain `input_content` field.
   * Note: as with all bytes fields, protobuffers use a pure binary
   * representation (not base64).
   * </pre>
   *
   * <code>bytes input_content = 2;</code>
   * @return The inputContent.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString getInputContent() {
    if (streamingRequestCase_ == 2) {
      return (com.google.protobuf.ByteString) streamingRequest_;
    }
    return com.google.protobuf.ByteString.EMPTY;
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
    if (streamingRequestCase_ == 1) {
      output.writeMessage(1, (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_);
    }
    if (streamingRequestCase_ == 2) {
      output.writeBytes(
          2, (com.google.protobuf.ByteString) streamingRequest_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (streamingRequestCase_ == 1) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_);
    }
    if (streamingRequestCase_ == 2) {
      size += com.google.protobuf.CodedOutputStream
        .computeBytesSize(
            2, (com.google.protobuf.ByteString) streamingRequest_);
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
    if (!(obj instanceof com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest other = (com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest) obj;

    if (!getStreamingRequestCase().equals(other.getStreamingRequestCase())) return false;
    switch (streamingRequestCase_) {
      case 1:
        if (!getVideoConfig()
            .equals(other.getVideoConfig())) return false;
        break;
      case 2:
        if (!getInputContent()
            .equals(other.getInputContent())) return false;
        break;
      case 0:
      default:
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
    switch (streamingRequestCase_) {
      case 1:
        hash = (37 * hash) + VIDEO_CONFIG_FIELD_NUMBER;
        hash = (53 * hash) + getVideoConfig().hashCode();
        break;
      case 2:
        hash = (37 * hash) + INPUT_CONTENT_FIELD_NUMBER;
        hash = (53 * hash) + getInputContent().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest prototype) {
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
   * The top-level message sent by the client for the `StreamingAnnotateVideo`
   * method. Multiple `StreamingAnnotateVideoRequest` messages are sent.
   * The first message must only contain a `StreamingVideoConfig` message.
   * All subsequent messages must only contain `input_content` data.
   * </pre>
   *
   * Protobuf type {@code google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)
      com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.videointelligence.v1p3beta1.VideoIntelligenceServiceProto.internal_static_google_cloud_videointelligence_v1p3beta1_StreamingAnnotateVideoRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.videointelligence.v1p3beta1.VideoIntelligenceServiceProto.internal_static_google_cloud_videointelligence_v1p3beta1_StreamingAnnotateVideoRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.class, com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.Builder.class);
    }

    // Construct using com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.newBuilder()
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
      streamingRequestCase_ = 0;
      streamingRequest_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.videointelligence.v1p3beta1.VideoIntelligenceServiceProto.internal_static_google_cloud_videointelligence_v1p3beta1_StreamingAnnotateVideoRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest getDefaultInstanceForType() {
      return com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest build() {
      com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest buildPartial() {
      com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest result = new com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest(this);
      if (streamingRequestCase_ == 1) {
        if (videoConfigBuilder_ == null) {
          result.streamingRequest_ = streamingRequest_;
        } else {
          result.streamingRequest_ = videoConfigBuilder_.build();
        }
      }
      if (streamingRequestCase_ == 2) {
        result.streamingRequest_ = streamingRequest_;
      }
      result.streamingRequestCase_ = streamingRequestCase_;
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
      if (other instanceof com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest) {
        return mergeFrom((com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest other) {
      if (other == com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest.getDefaultInstance()) return this;
      switch (other.getStreamingRequestCase()) {
        case VIDEO_CONFIG: {
          mergeVideoConfig(other.getVideoConfig());
          break;
        }
        case INPUT_CONTENT: {
          setInputContent(other.getInputContent());
          break;
        }
        case STREAMINGREQUEST_NOT_SET: {
          break;
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
      com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int streamingRequestCase_ = 0;
    private java.lang.Object streamingRequest_;
    public StreamingRequestCase
        getStreamingRequestCase() {
      return StreamingRequestCase.forNumber(
          streamingRequestCase_);
    }

    public Builder clearStreamingRequest() {
      streamingRequestCase_ = 0;
      streamingRequest_ = null;
      onChanged();
      return this;
    }


    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfigOrBuilder> videoConfigBuilder_;
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     * @return Whether the videoConfig field is set.
     */
    @java.lang.Override
    public boolean hasVideoConfig() {
      return streamingRequestCase_ == 1;
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     * @return The videoConfig.
     */
    @java.lang.Override
    public com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig getVideoConfig() {
      if (videoConfigBuilder_ == null) {
        if (streamingRequestCase_ == 1) {
          return (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_;
        }
        return com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
      } else {
        if (streamingRequestCase_ == 1) {
          return videoConfigBuilder_.getMessage();
        }
        return com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    public Builder setVideoConfig(com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig value) {
      if (videoConfigBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        streamingRequest_ = value;
        onChanged();
      } else {
        videoConfigBuilder_.setMessage(value);
      }
      streamingRequestCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    public Builder setVideoConfig(
        com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder builderForValue) {
      if (videoConfigBuilder_ == null) {
        streamingRequest_ = builderForValue.build();
        onChanged();
      } else {
        videoConfigBuilder_.setMessage(builderForValue.build());
      }
      streamingRequestCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    public Builder mergeVideoConfig(com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig value) {
      if (videoConfigBuilder_ == null) {
        if (streamingRequestCase_ == 1 &&
            streamingRequest_ != com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance()) {
          streamingRequest_ = com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.newBuilder((com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_)
              .mergeFrom(value).buildPartial();
        } else {
          streamingRequest_ = value;
        }
        onChanged();
      } else {
        if (streamingRequestCase_ == 1) {
          videoConfigBuilder_.mergeFrom(value);
        }
        videoConfigBuilder_.setMessage(value);
      }
      streamingRequestCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    public Builder clearVideoConfig() {
      if (videoConfigBuilder_ == null) {
        if (streamingRequestCase_ == 1) {
          streamingRequestCase_ = 0;
          streamingRequest_ = null;
          onChanged();
        }
      } else {
        if (streamingRequestCase_ == 1) {
          streamingRequestCase_ = 0;
          streamingRequest_ = null;
        }
        videoConfigBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    public com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder getVideoConfigBuilder() {
      return getVideoConfigFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    @java.lang.Override
    public com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfigOrBuilder getVideoConfigOrBuilder() {
      if ((streamingRequestCase_ == 1) && (videoConfigBuilder_ != null)) {
        return videoConfigBuilder_.getMessageOrBuilder();
      } else {
        if (streamingRequestCase_ == 1) {
          return (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_;
        }
        return com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Provides information to the annotator, specifing how to process the
     * request. The first `AnnotateStreamingVideoRequest` message must only
     * contain a `video_config` message.
     * </pre>
     *
     * <code>.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig video_config = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfigOrBuilder> 
        getVideoConfigFieldBuilder() {
      if (videoConfigBuilder_ == null) {
        if (!(streamingRequestCase_ == 1)) {
          streamingRequest_ = com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.getDefaultInstance();
        }
        videoConfigBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig.Builder, com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfigOrBuilder>(
                (com.google.cloud.videointelligence.v1p3beta1.StreamingVideoConfig) streamingRequest_,
                getParentForChildren(),
                isClean());
        streamingRequest_ = null;
      }
      streamingRequestCase_ = 1;
      onChanged();;
      return videoConfigBuilder_;
    }

    /**
     * <pre>
     * The video data to be annotated. Chunks of video data are sequentially
     * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
     * `StreamingAnnotateVideoRequest` message containing only
     * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
     * messages must only contain `input_content` field.
     * Note: as with all bytes fields, protobuffers use a pure binary
     * representation (not base64).
     * </pre>
     *
     * <code>bytes input_content = 2;</code>
     * @return Whether the inputContent field is set.
     */
    public boolean hasInputContent() {
      return streamingRequestCase_ == 2;
    }
    /**
     * <pre>
     * The video data to be annotated. Chunks of video data are sequentially
     * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
     * `StreamingAnnotateVideoRequest` message containing only
     * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
     * messages must only contain `input_content` field.
     * Note: as with all bytes fields, protobuffers use a pure binary
     * representation (not base64).
     * </pre>
     *
     * <code>bytes input_content = 2;</code>
     * @return The inputContent.
     */
    public com.google.protobuf.ByteString getInputContent() {
      if (streamingRequestCase_ == 2) {
        return (com.google.protobuf.ByteString) streamingRequest_;
      }
      return com.google.protobuf.ByteString.EMPTY;
    }
    /**
     * <pre>
     * The video data to be annotated. Chunks of video data are sequentially
     * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
     * `StreamingAnnotateVideoRequest` message containing only
     * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
     * messages must only contain `input_content` field.
     * Note: as with all bytes fields, protobuffers use a pure binary
     * representation (not base64).
     * </pre>
     *
     * <code>bytes input_content = 2;</code>
     * @param value The inputContent to set.
     * @return This builder for chaining.
     */
    public Builder setInputContent(com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  streamingRequestCase_ = 2;
      streamingRequest_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The video data to be annotated. Chunks of video data are sequentially
     * sent in `StreamingAnnotateVideoRequest` messages. Except the initial
     * `StreamingAnnotateVideoRequest` message containing only
     * `video_config`, all subsequent `AnnotateStreamingVideoRequest`
     * messages must only contain `input_content` field.
     * Note: as with all bytes fields, protobuffers use a pure binary
     * representation (not base64).
     * </pre>
     *
     * <code>bytes input_content = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearInputContent() {
      if (streamingRequestCase_ == 2) {
        streamingRequestCase_ = 0;
        streamingRequest_ = null;
        onChanged();
      }
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


    // @@protoc_insertion_point(builder_scope:google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest)
  private static final com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest();
  }

  public static com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<StreamingAnnotateVideoRequest>
      PARSER = new com.google.protobuf.AbstractParser<StreamingAnnotateVideoRequest>() {
    @java.lang.Override
    public StreamingAnnotateVideoRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new StreamingAnnotateVideoRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<StreamingAnnotateVideoRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<StreamingAnnotateVideoRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.videointelligence.v1p3beta1.StreamingAnnotateVideoRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

