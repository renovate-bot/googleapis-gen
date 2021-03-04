// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/participant.proto

package com.google.cloud.dialogflow.v2;

/**
 * <pre>
 * The request message for [Participants.SuggestFaqAnswers][google.cloud.dialogflow.v2.Participants.SuggestFaqAnswers].
 * </pre>
 *
 * Protobuf type {@code google.cloud.dialogflow.v2.SuggestFaqAnswersResponse}
 */
public final class SuggestFaqAnswersResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)
    SuggestFaqAnswersResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use SuggestFaqAnswersResponse.newBuilder() to construct.
  private SuggestFaqAnswersResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private SuggestFaqAnswersResponse() {
    faqAnswers_ = java.util.Collections.emptyList();
    latestMessage_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new SuggestFaqAnswersResponse();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private SuggestFaqAnswersResponse(
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
              faqAnswers_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.FaqAnswer>();
              mutable_bitField0_ |= 0x00000001;
            }
            faqAnswers_.add(
                input.readMessage(com.google.cloud.dialogflow.v2.FaqAnswer.parser(), extensionRegistry));
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            latestMessage_ = s;
            break;
          }
          case 24: {

            contextSize_ = input.readInt32();
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
        faqAnswers_ = java.util.Collections.unmodifiableList(faqAnswers_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_SuggestFaqAnswersResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_SuggestFaqAnswersResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.class, com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.Builder.class);
  }

  public static final int FAQ_ANSWERS_FIELD_NUMBER = 1;
  private java.util.List<com.google.cloud.dialogflow.v2.FaqAnswer> faqAnswers_;
  /**
   * <pre>
   * Answers extracted from FAQ documents.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.cloud.dialogflow.v2.FaqAnswer> getFaqAnswersList() {
    return faqAnswers_;
  }
  /**
   * <pre>
   * Answers extracted from FAQ documents.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder> 
      getFaqAnswersOrBuilderList() {
    return faqAnswers_;
  }
  /**
   * <pre>
   * Answers extracted from FAQ documents.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
   */
  @java.lang.Override
  public int getFaqAnswersCount() {
    return faqAnswers_.size();
  }
  /**
   * <pre>
   * Answers extracted from FAQ documents.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.FaqAnswer getFaqAnswers(int index) {
    return faqAnswers_.get(index);
  }
  /**
   * <pre>
   * Answers extracted from FAQ documents.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder getFaqAnswersOrBuilder(
      int index) {
    return faqAnswers_.get(index);
  }

  public static final int LATEST_MESSAGE_FIELD_NUMBER = 2;
  private volatile java.lang.Object latestMessage_;
  /**
   * <pre>
   * The name of the latest conversation message used to compile
   * suggestion for.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
   * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
   * </pre>
   *
   * <code>string latest_message = 2;</code>
   * @return The latestMessage.
   */
  @java.lang.Override
  public java.lang.String getLatestMessage() {
    java.lang.Object ref = latestMessage_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      latestMessage_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The name of the latest conversation message used to compile
   * suggestion for.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
   * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
   * </pre>
   *
   * <code>string latest_message = 2;</code>
   * @return The bytes for latestMessage.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getLatestMessageBytes() {
    java.lang.Object ref = latestMessage_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      latestMessage_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CONTEXT_SIZE_FIELD_NUMBER = 3;
  private int contextSize_;
  /**
   * <pre>
   * Number of messages prior to and including
   * [latest_message][google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.latest_message] to compile the
   * suggestion. It may be smaller than the
   * [SuggestFaqAnswersRequest.context_size][google.cloud.dialogflow.v2.SuggestFaqAnswersRequest.context_size] field in the request if there
   * aren't that many messages in the conversation.
   * </pre>
   *
   * <code>int32 context_size = 3;</code>
   * @return The contextSize.
   */
  @java.lang.Override
  public int getContextSize() {
    return contextSize_;
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
    for (int i = 0; i < faqAnswers_.size(); i++) {
      output.writeMessage(1, faqAnswers_.get(i));
    }
    if (!getLatestMessageBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, latestMessage_);
    }
    if (contextSize_ != 0) {
      output.writeInt32(3, contextSize_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < faqAnswers_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, faqAnswers_.get(i));
    }
    if (!getLatestMessageBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, latestMessage_);
    }
    if (contextSize_ != 0) {
      size += com.google.protobuf.CodedOutputStream
        .computeInt32Size(3, contextSize_);
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
    if (!(obj instanceof com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)) {
      return super.equals(obj);
    }
    com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse other = (com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse) obj;

    if (!getFaqAnswersList()
        .equals(other.getFaqAnswersList())) return false;
    if (!getLatestMessage()
        .equals(other.getLatestMessage())) return false;
    if (getContextSize()
        != other.getContextSize()) return false;
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
    if (getFaqAnswersCount() > 0) {
      hash = (37 * hash) + FAQ_ANSWERS_FIELD_NUMBER;
      hash = (53 * hash) + getFaqAnswersList().hashCode();
    }
    hash = (37 * hash) + LATEST_MESSAGE_FIELD_NUMBER;
    hash = (53 * hash) + getLatestMessage().hashCode();
    hash = (37 * hash) + CONTEXT_SIZE_FIELD_NUMBER;
    hash = (53 * hash) + getContextSize();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse prototype) {
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
   * The request message for [Participants.SuggestFaqAnswers][google.cloud.dialogflow.v2.Participants.SuggestFaqAnswers].
   * </pre>
   *
   * Protobuf type {@code google.cloud.dialogflow.v2.SuggestFaqAnswersResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)
      com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_SuggestFaqAnswersResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_SuggestFaqAnswersResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.class, com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.Builder.class);
    }

    // Construct using com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.newBuilder()
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
        getFaqAnswersFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (faqAnswersBuilder_ == null) {
        faqAnswers_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        faqAnswersBuilder_.clear();
      }
      latestMessage_ = "";

      contextSize_ = 0;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_SuggestFaqAnswersResponse_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse getDefaultInstanceForType() {
      return com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse build() {
      com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse buildPartial() {
      com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse result = new com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse(this);
      int from_bitField0_ = bitField0_;
      if (faqAnswersBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          faqAnswers_ = java.util.Collections.unmodifiableList(faqAnswers_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.faqAnswers_ = faqAnswers_;
      } else {
        result.faqAnswers_ = faqAnswersBuilder_.build();
      }
      result.latestMessage_ = latestMessage_;
      result.contextSize_ = contextSize_;
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
      if (other instanceof com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse) {
        return mergeFrom((com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse other) {
      if (other == com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.getDefaultInstance()) return this;
      if (faqAnswersBuilder_ == null) {
        if (!other.faqAnswers_.isEmpty()) {
          if (faqAnswers_.isEmpty()) {
            faqAnswers_ = other.faqAnswers_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureFaqAnswersIsMutable();
            faqAnswers_.addAll(other.faqAnswers_);
          }
          onChanged();
        }
      } else {
        if (!other.faqAnswers_.isEmpty()) {
          if (faqAnswersBuilder_.isEmpty()) {
            faqAnswersBuilder_.dispose();
            faqAnswersBuilder_ = null;
            faqAnswers_ = other.faqAnswers_;
            bitField0_ = (bitField0_ & ~0x00000001);
            faqAnswersBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getFaqAnswersFieldBuilder() : null;
          } else {
            faqAnswersBuilder_.addAllMessages(other.faqAnswers_);
          }
        }
      }
      if (!other.getLatestMessage().isEmpty()) {
        latestMessage_ = other.latestMessage_;
        onChanged();
      }
      if (other.getContextSize() != 0) {
        setContextSize(other.getContextSize());
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
      com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.cloud.dialogflow.v2.FaqAnswer> faqAnswers_ =
      java.util.Collections.emptyList();
    private void ensureFaqAnswersIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        faqAnswers_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.FaqAnswer>(faqAnswers_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.FaqAnswer, com.google.cloud.dialogflow.v2.FaqAnswer.Builder, com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder> faqAnswersBuilder_;

    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.FaqAnswer> getFaqAnswersList() {
      if (faqAnswersBuilder_ == null) {
        return java.util.Collections.unmodifiableList(faqAnswers_);
      } else {
        return faqAnswersBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public int getFaqAnswersCount() {
      if (faqAnswersBuilder_ == null) {
        return faqAnswers_.size();
      } else {
        return faqAnswersBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.FaqAnswer getFaqAnswers(int index) {
      if (faqAnswersBuilder_ == null) {
        return faqAnswers_.get(index);
      } else {
        return faqAnswersBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder setFaqAnswers(
        int index, com.google.cloud.dialogflow.v2.FaqAnswer value) {
      if (faqAnswersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureFaqAnswersIsMutable();
        faqAnswers_.set(index, value);
        onChanged();
      } else {
        faqAnswersBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder setFaqAnswers(
        int index, com.google.cloud.dialogflow.v2.FaqAnswer.Builder builderForValue) {
      if (faqAnswersBuilder_ == null) {
        ensureFaqAnswersIsMutable();
        faqAnswers_.set(index, builderForValue.build());
        onChanged();
      } else {
        faqAnswersBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder addFaqAnswers(com.google.cloud.dialogflow.v2.FaqAnswer value) {
      if (faqAnswersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureFaqAnswersIsMutable();
        faqAnswers_.add(value);
        onChanged();
      } else {
        faqAnswersBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder addFaqAnswers(
        int index, com.google.cloud.dialogflow.v2.FaqAnswer value) {
      if (faqAnswersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureFaqAnswersIsMutable();
        faqAnswers_.add(index, value);
        onChanged();
      } else {
        faqAnswersBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder addFaqAnswers(
        com.google.cloud.dialogflow.v2.FaqAnswer.Builder builderForValue) {
      if (faqAnswersBuilder_ == null) {
        ensureFaqAnswersIsMutable();
        faqAnswers_.add(builderForValue.build());
        onChanged();
      } else {
        faqAnswersBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder addFaqAnswers(
        int index, com.google.cloud.dialogflow.v2.FaqAnswer.Builder builderForValue) {
      if (faqAnswersBuilder_ == null) {
        ensureFaqAnswersIsMutable();
        faqAnswers_.add(index, builderForValue.build());
        onChanged();
      } else {
        faqAnswersBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder addAllFaqAnswers(
        java.lang.Iterable<? extends com.google.cloud.dialogflow.v2.FaqAnswer> values) {
      if (faqAnswersBuilder_ == null) {
        ensureFaqAnswersIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, faqAnswers_);
        onChanged();
      } else {
        faqAnswersBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder clearFaqAnswers() {
      if (faqAnswersBuilder_ == null) {
        faqAnswers_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        faqAnswersBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public Builder removeFaqAnswers(int index) {
      if (faqAnswersBuilder_ == null) {
        ensureFaqAnswersIsMutable();
        faqAnswers_.remove(index);
        onChanged();
      } else {
        faqAnswersBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.FaqAnswer.Builder getFaqAnswersBuilder(
        int index) {
      return getFaqAnswersFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder getFaqAnswersOrBuilder(
        int index) {
      if (faqAnswersBuilder_ == null) {
        return faqAnswers_.get(index);  } else {
        return faqAnswersBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public java.util.List<? extends com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder> 
         getFaqAnswersOrBuilderList() {
      if (faqAnswersBuilder_ != null) {
        return faqAnswersBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(faqAnswers_);
      }
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.FaqAnswer.Builder addFaqAnswersBuilder() {
      return getFaqAnswersFieldBuilder().addBuilder(
          com.google.cloud.dialogflow.v2.FaqAnswer.getDefaultInstance());
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.FaqAnswer.Builder addFaqAnswersBuilder(
        int index) {
      return getFaqAnswersFieldBuilder().addBuilder(
          index, com.google.cloud.dialogflow.v2.FaqAnswer.getDefaultInstance());
    }
    /**
     * <pre>
     * Answers extracted from FAQ documents.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.FaqAnswer faq_answers = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.FaqAnswer.Builder> 
         getFaqAnswersBuilderList() {
      return getFaqAnswersFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.FaqAnswer, com.google.cloud.dialogflow.v2.FaqAnswer.Builder, com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder> 
        getFaqAnswersFieldBuilder() {
      if (faqAnswersBuilder_ == null) {
        faqAnswersBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.cloud.dialogflow.v2.FaqAnswer, com.google.cloud.dialogflow.v2.FaqAnswer.Builder, com.google.cloud.dialogflow.v2.FaqAnswerOrBuilder>(
                faqAnswers_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        faqAnswers_ = null;
      }
      return faqAnswersBuilder_;
    }

    private java.lang.Object latestMessage_ = "";
    /**
     * <pre>
     * The name of the latest conversation message used to compile
     * suggestion for.
     * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
     * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
     * </pre>
     *
     * <code>string latest_message = 2;</code>
     * @return The latestMessage.
     */
    public java.lang.String getLatestMessage() {
      java.lang.Object ref = latestMessage_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        latestMessage_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The name of the latest conversation message used to compile
     * suggestion for.
     * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
     * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
     * </pre>
     *
     * <code>string latest_message = 2;</code>
     * @return The bytes for latestMessage.
     */
    public com.google.protobuf.ByteString
        getLatestMessageBytes() {
      java.lang.Object ref = latestMessage_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        latestMessage_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The name of the latest conversation message used to compile
     * suggestion for.
     * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
     * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
     * </pre>
     *
     * <code>string latest_message = 2;</code>
     * @param value The latestMessage to set.
     * @return This builder for chaining.
     */
    public Builder setLatestMessage(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      latestMessage_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the latest conversation message used to compile
     * suggestion for.
     * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
     * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
     * </pre>
     *
     * <code>string latest_message = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearLatestMessage() {
      
      latestMessage_ = getDefaultInstance().getLatestMessage();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the latest conversation message used to compile
     * suggestion for.
     * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
     * ID&gt;/conversations/&lt;Conversation ID&gt;/messages/&lt;Message ID&gt;`.
     * </pre>
     *
     * <code>string latest_message = 2;</code>
     * @param value The bytes for latestMessage to set.
     * @return This builder for chaining.
     */
    public Builder setLatestMessageBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      latestMessage_ = value;
      onChanged();
      return this;
    }

    private int contextSize_ ;
    /**
     * <pre>
     * Number of messages prior to and including
     * [latest_message][google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.latest_message] to compile the
     * suggestion. It may be smaller than the
     * [SuggestFaqAnswersRequest.context_size][google.cloud.dialogflow.v2.SuggestFaqAnswersRequest.context_size] field in the request if there
     * aren't that many messages in the conversation.
     * </pre>
     *
     * <code>int32 context_size = 3;</code>
     * @return The contextSize.
     */
    @java.lang.Override
    public int getContextSize() {
      return contextSize_;
    }
    /**
     * <pre>
     * Number of messages prior to and including
     * [latest_message][google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.latest_message] to compile the
     * suggestion. It may be smaller than the
     * [SuggestFaqAnswersRequest.context_size][google.cloud.dialogflow.v2.SuggestFaqAnswersRequest.context_size] field in the request if there
     * aren't that many messages in the conversation.
     * </pre>
     *
     * <code>int32 context_size = 3;</code>
     * @param value The contextSize to set.
     * @return This builder for chaining.
     */
    public Builder setContextSize(int value) {
      
      contextSize_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Number of messages prior to and including
     * [latest_message][google.cloud.dialogflow.v2.SuggestFaqAnswersResponse.latest_message] to compile the
     * suggestion. It may be smaller than the
     * [SuggestFaqAnswersRequest.context_size][google.cloud.dialogflow.v2.SuggestFaqAnswersRequest.context_size] field in the request if there
     * aren't that many messages in the conversation.
     * </pre>
     *
     * <code>int32 context_size = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearContextSize() {
      
      contextSize_ = 0;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dialogflow.v2.SuggestFaqAnswersResponse)
  private static final com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse();
  }

  public static com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<SuggestFaqAnswersResponse>
      PARSER = new com.google.protobuf.AbstractParser<SuggestFaqAnswersResponse>() {
    @java.lang.Override
    public SuggestFaqAnswersResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new SuggestFaqAnswersResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<SuggestFaqAnswersResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<SuggestFaqAnswersResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dialogflow.v2.SuggestFaqAnswersResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

