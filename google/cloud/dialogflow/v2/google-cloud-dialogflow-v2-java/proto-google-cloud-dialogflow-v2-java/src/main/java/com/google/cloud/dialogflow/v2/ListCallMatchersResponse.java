// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/conversation.proto

package com.google.cloud.dialogflow.v2;

/**
 * <pre>
 * The response message for [Conversations.ListCallMatchers][google.cloud.dialogflow.v2.Conversations.ListCallMatchers].
 * </pre>
 *
 * Protobuf type {@code google.cloud.dialogflow.v2.ListCallMatchersResponse}
 */
public final class ListCallMatchersResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dialogflow.v2.ListCallMatchersResponse)
    ListCallMatchersResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ListCallMatchersResponse.newBuilder() to construct.
  private ListCallMatchersResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ListCallMatchersResponse() {
    callMatchers_ = java.util.Collections.emptyList();
    nextPageToken_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ListCallMatchersResponse();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ListCallMatchersResponse(
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
              callMatchers_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.CallMatcher>();
              mutable_bitField0_ |= 0x00000001;
            }
            callMatchers_.add(
                input.readMessage(com.google.cloud.dialogflow.v2.CallMatcher.parser(), extensionRegistry));
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            nextPageToken_ = s;
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
        callMatchers_ = java.util.Collections.unmodifiableList(callMatchers_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.dialogflow.v2.ConversationProto.internal_static_google_cloud_dialogflow_v2_ListCallMatchersResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dialogflow.v2.ConversationProto.internal_static_google_cloud_dialogflow_v2_ListCallMatchersResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dialogflow.v2.ListCallMatchersResponse.class, com.google.cloud.dialogflow.v2.ListCallMatchersResponse.Builder.class);
  }

  public static final int CALL_MATCHERS_FIELD_NUMBER = 1;
  private java.util.List<com.google.cloud.dialogflow.v2.CallMatcher> callMatchers_;
  /**
   * <pre>
   * The list of call matchers. There is a maximum number of items
   * returned based on the page_size field in the request.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.cloud.dialogflow.v2.CallMatcher> getCallMatchersList() {
    return callMatchers_;
  }
  /**
   * <pre>
   * The list of call matchers. There is a maximum number of items
   * returned based on the page_size field in the request.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.cloud.dialogflow.v2.CallMatcherOrBuilder> 
      getCallMatchersOrBuilderList() {
    return callMatchers_;
  }
  /**
   * <pre>
   * The list of call matchers. There is a maximum number of items
   * returned based on the page_size field in the request.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
   */
  @java.lang.Override
  public int getCallMatchersCount() {
    return callMatchers_.size();
  }
  /**
   * <pre>
   * The list of call matchers. There is a maximum number of items
   * returned based on the page_size field in the request.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.CallMatcher getCallMatchers(int index) {
    return callMatchers_.get(index);
  }
  /**
   * <pre>
   * The list of call matchers. There is a maximum number of items
   * returned based on the page_size field in the request.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.CallMatcherOrBuilder getCallMatchersOrBuilder(
      int index) {
    return callMatchers_.get(index);
  }

  public static final int NEXT_PAGE_TOKEN_FIELD_NUMBER = 2;
  private volatile java.lang.Object nextPageToken_;
  /**
   * <pre>
   * Token to retrieve the next page of results or empty if there are no
   * more results in the list.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  @java.lang.Override
  public java.lang.String getNextPageToken() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      nextPageToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Token to retrieve the next page of results or empty if there are no
   * more results in the list.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getNextPageTokenBytes() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      nextPageToken_ = b;
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
    for (int i = 0; i < callMatchers_.size(); i++) {
      output.writeMessage(1, callMatchers_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, nextPageToken_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < callMatchers_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, callMatchers_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, nextPageToken_);
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
    if (!(obj instanceof com.google.cloud.dialogflow.v2.ListCallMatchersResponse)) {
      return super.equals(obj);
    }
    com.google.cloud.dialogflow.v2.ListCallMatchersResponse other = (com.google.cloud.dialogflow.v2.ListCallMatchersResponse) obj;

    if (!getCallMatchersList()
        .equals(other.getCallMatchersList())) return false;
    if (!getNextPageToken()
        .equals(other.getNextPageToken())) return false;
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
    if (getCallMatchersCount() > 0) {
      hash = (37 * hash) + CALL_MATCHERS_FIELD_NUMBER;
      hash = (53 * hash) + getCallMatchersList().hashCode();
    }
    hash = (37 * hash) + NEXT_PAGE_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getNextPageToken().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dialogflow.v2.ListCallMatchersResponse prototype) {
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
   * The response message for [Conversations.ListCallMatchers][google.cloud.dialogflow.v2.Conversations.ListCallMatchers].
   * </pre>
   *
   * Protobuf type {@code google.cloud.dialogflow.v2.ListCallMatchersResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dialogflow.v2.ListCallMatchersResponse)
      com.google.cloud.dialogflow.v2.ListCallMatchersResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dialogflow.v2.ConversationProto.internal_static_google_cloud_dialogflow_v2_ListCallMatchersResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dialogflow.v2.ConversationProto.internal_static_google_cloud_dialogflow_v2_ListCallMatchersResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dialogflow.v2.ListCallMatchersResponse.class, com.google.cloud.dialogflow.v2.ListCallMatchersResponse.Builder.class);
    }

    // Construct using com.google.cloud.dialogflow.v2.ListCallMatchersResponse.newBuilder()
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
        getCallMatchersFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (callMatchersBuilder_ == null) {
        callMatchers_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        callMatchersBuilder_.clear();
      }
      nextPageToken_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dialogflow.v2.ConversationProto.internal_static_google_cloud_dialogflow_v2_ListCallMatchersResponse_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.ListCallMatchersResponse getDefaultInstanceForType() {
      return com.google.cloud.dialogflow.v2.ListCallMatchersResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.ListCallMatchersResponse build() {
      com.google.cloud.dialogflow.v2.ListCallMatchersResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.ListCallMatchersResponse buildPartial() {
      com.google.cloud.dialogflow.v2.ListCallMatchersResponse result = new com.google.cloud.dialogflow.v2.ListCallMatchersResponse(this);
      int from_bitField0_ = bitField0_;
      if (callMatchersBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          callMatchers_ = java.util.Collections.unmodifiableList(callMatchers_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.callMatchers_ = callMatchers_;
      } else {
        result.callMatchers_ = callMatchersBuilder_.build();
      }
      result.nextPageToken_ = nextPageToken_;
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
      if (other instanceof com.google.cloud.dialogflow.v2.ListCallMatchersResponse) {
        return mergeFrom((com.google.cloud.dialogflow.v2.ListCallMatchersResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dialogflow.v2.ListCallMatchersResponse other) {
      if (other == com.google.cloud.dialogflow.v2.ListCallMatchersResponse.getDefaultInstance()) return this;
      if (callMatchersBuilder_ == null) {
        if (!other.callMatchers_.isEmpty()) {
          if (callMatchers_.isEmpty()) {
            callMatchers_ = other.callMatchers_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureCallMatchersIsMutable();
            callMatchers_.addAll(other.callMatchers_);
          }
          onChanged();
        }
      } else {
        if (!other.callMatchers_.isEmpty()) {
          if (callMatchersBuilder_.isEmpty()) {
            callMatchersBuilder_.dispose();
            callMatchersBuilder_ = null;
            callMatchers_ = other.callMatchers_;
            bitField0_ = (bitField0_ & ~0x00000001);
            callMatchersBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getCallMatchersFieldBuilder() : null;
          } else {
            callMatchersBuilder_.addAllMessages(other.callMatchers_);
          }
        }
      }
      if (!other.getNextPageToken().isEmpty()) {
        nextPageToken_ = other.nextPageToken_;
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
      com.google.cloud.dialogflow.v2.ListCallMatchersResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dialogflow.v2.ListCallMatchersResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.cloud.dialogflow.v2.CallMatcher> callMatchers_ =
      java.util.Collections.emptyList();
    private void ensureCallMatchersIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        callMatchers_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.CallMatcher>(callMatchers_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.CallMatcher, com.google.cloud.dialogflow.v2.CallMatcher.Builder, com.google.cloud.dialogflow.v2.CallMatcherOrBuilder> callMatchersBuilder_;

    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.CallMatcher> getCallMatchersList() {
      if (callMatchersBuilder_ == null) {
        return java.util.Collections.unmodifiableList(callMatchers_);
      } else {
        return callMatchersBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public int getCallMatchersCount() {
      if (callMatchersBuilder_ == null) {
        return callMatchers_.size();
      } else {
        return callMatchersBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.CallMatcher getCallMatchers(int index) {
      if (callMatchersBuilder_ == null) {
        return callMatchers_.get(index);
      } else {
        return callMatchersBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder setCallMatchers(
        int index, com.google.cloud.dialogflow.v2.CallMatcher value) {
      if (callMatchersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureCallMatchersIsMutable();
        callMatchers_.set(index, value);
        onChanged();
      } else {
        callMatchersBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder setCallMatchers(
        int index, com.google.cloud.dialogflow.v2.CallMatcher.Builder builderForValue) {
      if (callMatchersBuilder_ == null) {
        ensureCallMatchersIsMutable();
        callMatchers_.set(index, builderForValue.build());
        onChanged();
      } else {
        callMatchersBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder addCallMatchers(com.google.cloud.dialogflow.v2.CallMatcher value) {
      if (callMatchersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureCallMatchersIsMutable();
        callMatchers_.add(value);
        onChanged();
      } else {
        callMatchersBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder addCallMatchers(
        int index, com.google.cloud.dialogflow.v2.CallMatcher value) {
      if (callMatchersBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureCallMatchersIsMutable();
        callMatchers_.add(index, value);
        onChanged();
      } else {
        callMatchersBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder addCallMatchers(
        com.google.cloud.dialogflow.v2.CallMatcher.Builder builderForValue) {
      if (callMatchersBuilder_ == null) {
        ensureCallMatchersIsMutable();
        callMatchers_.add(builderForValue.build());
        onChanged();
      } else {
        callMatchersBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder addCallMatchers(
        int index, com.google.cloud.dialogflow.v2.CallMatcher.Builder builderForValue) {
      if (callMatchersBuilder_ == null) {
        ensureCallMatchersIsMutable();
        callMatchers_.add(index, builderForValue.build());
        onChanged();
      } else {
        callMatchersBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder addAllCallMatchers(
        java.lang.Iterable<? extends com.google.cloud.dialogflow.v2.CallMatcher> values) {
      if (callMatchersBuilder_ == null) {
        ensureCallMatchersIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, callMatchers_);
        onChanged();
      } else {
        callMatchersBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder clearCallMatchers() {
      if (callMatchersBuilder_ == null) {
        callMatchers_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        callMatchersBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public Builder removeCallMatchers(int index) {
      if (callMatchersBuilder_ == null) {
        ensureCallMatchersIsMutable();
        callMatchers_.remove(index);
        onChanged();
      } else {
        callMatchersBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.CallMatcher.Builder getCallMatchersBuilder(
        int index) {
      return getCallMatchersFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.CallMatcherOrBuilder getCallMatchersOrBuilder(
        int index) {
      if (callMatchersBuilder_ == null) {
        return callMatchers_.get(index);  } else {
        return callMatchersBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public java.util.List<? extends com.google.cloud.dialogflow.v2.CallMatcherOrBuilder> 
         getCallMatchersOrBuilderList() {
      if (callMatchersBuilder_ != null) {
        return callMatchersBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(callMatchers_);
      }
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.CallMatcher.Builder addCallMatchersBuilder() {
      return getCallMatchersFieldBuilder().addBuilder(
          com.google.cloud.dialogflow.v2.CallMatcher.getDefaultInstance());
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.CallMatcher.Builder addCallMatchersBuilder(
        int index) {
      return getCallMatchersFieldBuilder().addBuilder(
          index, com.google.cloud.dialogflow.v2.CallMatcher.getDefaultInstance());
    }
    /**
     * <pre>
     * The list of call matchers. There is a maximum number of items
     * returned based on the page_size field in the request.
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.CallMatcher call_matchers = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.CallMatcher.Builder> 
         getCallMatchersBuilderList() {
      return getCallMatchersFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.CallMatcher, com.google.cloud.dialogflow.v2.CallMatcher.Builder, com.google.cloud.dialogflow.v2.CallMatcherOrBuilder> 
        getCallMatchersFieldBuilder() {
      if (callMatchersBuilder_ == null) {
        callMatchersBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.cloud.dialogflow.v2.CallMatcher, com.google.cloud.dialogflow.v2.CallMatcher.Builder, com.google.cloud.dialogflow.v2.CallMatcherOrBuilder>(
                callMatchers_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        callMatchers_ = null;
      }
      return callMatchersBuilder_;
    }

    private java.lang.Object nextPageToken_ = "";
    /**
     * <pre>
     * Token to retrieve the next page of results or empty if there are no
     * more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return The nextPageToken.
     */
    public java.lang.String getNextPageToken() {
      java.lang.Object ref = nextPageToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        nextPageToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Token to retrieve the next page of results or empty if there are no
     * more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return The bytes for nextPageToken.
     */
    public com.google.protobuf.ByteString
        getNextPageTokenBytes() {
      java.lang.Object ref = nextPageToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        nextPageToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Token to retrieve the next page of results or empty if there are no
     * more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @param value The nextPageToken to set.
     * @return This builder for chaining.
     */
    public Builder setNextPageToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      nextPageToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Token to retrieve the next page of results or empty if there are no
     * more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearNextPageToken() {
      
      nextPageToken_ = getDefaultInstance().getNextPageToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Token to retrieve the next page of results or empty if there are no
     * more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @param value The bytes for nextPageToken to set.
     * @return This builder for chaining.
     */
    public Builder setNextPageTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      nextPageToken_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dialogflow.v2.ListCallMatchersResponse)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dialogflow.v2.ListCallMatchersResponse)
  private static final com.google.cloud.dialogflow.v2.ListCallMatchersResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dialogflow.v2.ListCallMatchersResponse();
  }

  public static com.google.cloud.dialogflow.v2.ListCallMatchersResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ListCallMatchersResponse>
      PARSER = new com.google.protobuf.AbstractParser<ListCallMatchersResponse>() {
    @java.lang.Override
    public ListCallMatchersResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ListCallMatchersResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ListCallMatchersResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ListCallMatchersResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dialogflow.v2.ListCallMatchersResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

