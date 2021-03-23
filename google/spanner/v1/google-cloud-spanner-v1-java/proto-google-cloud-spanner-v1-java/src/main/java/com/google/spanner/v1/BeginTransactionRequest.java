// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/spanner/v1/spanner.proto

package com.google.spanner.v1;

/**
 * <pre>
 * The request for [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction].
 * </pre>
 *
 * Protobuf type {@code google.spanner.v1.BeginTransactionRequest}
 */
public final class BeginTransactionRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.spanner.v1.BeginTransactionRequest)
    BeginTransactionRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use BeginTransactionRequest.newBuilder() to construct.
  private BeginTransactionRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private BeginTransactionRequest() {
    session_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new BeginTransactionRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private BeginTransactionRequest(
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

            session_ = s;
            break;
          }
          case 18: {
            com.google.spanner.v1.TransactionOptions.Builder subBuilder = null;
            if (options_ != null) {
              subBuilder = options_.toBuilder();
            }
            options_ = input.readMessage(com.google.spanner.v1.TransactionOptions.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(options_);
              options_ = subBuilder.buildPartial();
            }

            break;
          }
          case 26: {
            com.google.spanner.v1.RequestOptions.Builder subBuilder = null;
            if (requestOptions_ != null) {
              subBuilder = requestOptions_.toBuilder();
            }
            requestOptions_ = input.readMessage(com.google.spanner.v1.RequestOptions.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(requestOptions_);
              requestOptions_ = subBuilder.buildPartial();
            }

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
    return com.google.spanner.v1.SpannerProto.internal_static_google_spanner_v1_BeginTransactionRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.spanner.v1.SpannerProto.internal_static_google_spanner_v1_BeginTransactionRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.spanner.v1.BeginTransactionRequest.class, com.google.spanner.v1.BeginTransactionRequest.Builder.class);
  }

  public static final int SESSION_FIELD_NUMBER = 1;
  private volatile java.lang.Object session_;
  /**
   * <pre>
   * Required. The session in which the transaction runs.
   * </pre>
   *
   * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The session.
   */
  @java.lang.Override
  public java.lang.String getSession() {
    java.lang.Object ref = session_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      session_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. The session in which the transaction runs.
   * </pre>
   *
   * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for session.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getSessionBytes() {
    java.lang.Object ref = session_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      session_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int OPTIONS_FIELD_NUMBER = 2;
  private com.google.spanner.v1.TransactionOptions options_;
  /**
   * <pre>
   * Required. Options for the new transaction.
   * </pre>
   *
   * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the options field is set.
   */
  @java.lang.Override
  public boolean hasOptions() {
    return options_ != null;
  }
  /**
   * <pre>
   * Required. Options for the new transaction.
   * </pre>
   *
   * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The options.
   */
  @java.lang.Override
  public com.google.spanner.v1.TransactionOptions getOptions() {
    return options_ == null ? com.google.spanner.v1.TransactionOptions.getDefaultInstance() : options_;
  }
  /**
   * <pre>
   * Required. Options for the new transaction.
   * </pre>
   *
   * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.spanner.v1.TransactionOptionsOrBuilder getOptionsOrBuilder() {
    return getOptions();
  }

  public static final int REQUEST_OPTIONS_FIELD_NUMBER = 3;
  private com.google.spanner.v1.RequestOptions requestOptions_;
  /**
   * <pre>
   * Common options for this request.
   * Priority is ignored for this request. Setting the priority in this
   * request_options struct will not do anything. To set the priority for a
   * transaction, set it on the reads and writes that are part of this
   * transaction instead.
   * </pre>
   *
   * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
   * @return Whether the requestOptions field is set.
   */
  @java.lang.Override
  public boolean hasRequestOptions() {
    return requestOptions_ != null;
  }
  /**
   * <pre>
   * Common options for this request.
   * Priority is ignored for this request. Setting the priority in this
   * request_options struct will not do anything. To set the priority for a
   * transaction, set it on the reads and writes that are part of this
   * transaction instead.
   * </pre>
   *
   * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
   * @return The requestOptions.
   */
  @java.lang.Override
  public com.google.spanner.v1.RequestOptions getRequestOptions() {
    return requestOptions_ == null ? com.google.spanner.v1.RequestOptions.getDefaultInstance() : requestOptions_;
  }
  /**
   * <pre>
   * Common options for this request.
   * Priority is ignored for this request. Setting the priority in this
   * request_options struct will not do anything. To set the priority for a
   * transaction, set it on the reads and writes that are part of this
   * transaction instead.
   * </pre>
   *
   * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
   */
  @java.lang.Override
  public com.google.spanner.v1.RequestOptionsOrBuilder getRequestOptionsOrBuilder() {
    return getRequestOptions();
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
    if (!getSessionBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, session_);
    }
    if (options_ != null) {
      output.writeMessage(2, getOptions());
    }
    if (requestOptions_ != null) {
      output.writeMessage(3, getRequestOptions());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getSessionBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, session_);
    }
    if (options_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getOptions());
    }
    if (requestOptions_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, getRequestOptions());
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
    if (!(obj instanceof com.google.spanner.v1.BeginTransactionRequest)) {
      return super.equals(obj);
    }
    com.google.spanner.v1.BeginTransactionRequest other = (com.google.spanner.v1.BeginTransactionRequest) obj;

    if (!getSession()
        .equals(other.getSession())) return false;
    if (hasOptions() != other.hasOptions()) return false;
    if (hasOptions()) {
      if (!getOptions()
          .equals(other.getOptions())) return false;
    }
    if (hasRequestOptions() != other.hasRequestOptions()) return false;
    if (hasRequestOptions()) {
      if (!getRequestOptions()
          .equals(other.getRequestOptions())) return false;
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
    hash = (37 * hash) + SESSION_FIELD_NUMBER;
    hash = (53 * hash) + getSession().hashCode();
    if (hasOptions()) {
      hash = (37 * hash) + OPTIONS_FIELD_NUMBER;
      hash = (53 * hash) + getOptions().hashCode();
    }
    if (hasRequestOptions()) {
      hash = (37 * hash) + REQUEST_OPTIONS_FIELD_NUMBER;
      hash = (53 * hash) + getRequestOptions().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.spanner.v1.BeginTransactionRequest parseFrom(
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
  public static Builder newBuilder(com.google.spanner.v1.BeginTransactionRequest prototype) {
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
   * The request for [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction].
   * </pre>
   *
   * Protobuf type {@code google.spanner.v1.BeginTransactionRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.spanner.v1.BeginTransactionRequest)
      com.google.spanner.v1.BeginTransactionRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.spanner.v1.SpannerProto.internal_static_google_spanner_v1_BeginTransactionRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.spanner.v1.SpannerProto.internal_static_google_spanner_v1_BeginTransactionRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.spanner.v1.BeginTransactionRequest.class, com.google.spanner.v1.BeginTransactionRequest.Builder.class);
    }

    // Construct using com.google.spanner.v1.BeginTransactionRequest.newBuilder()
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
      session_ = "";

      if (optionsBuilder_ == null) {
        options_ = null;
      } else {
        options_ = null;
        optionsBuilder_ = null;
      }
      if (requestOptionsBuilder_ == null) {
        requestOptions_ = null;
      } else {
        requestOptions_ = null;
        requestOptionsBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.spanner.v1.SpannerProto.internal_static_google_spanner_v1_BeginTransactionRequest_descriptor;
    }

    @java.lang.Override
    public com.google.spanner.v1.BeginTransactionRequest getDefaultInstanceForType() {
      return com.google.spanner.v1.BeginTransactionRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.spanner.v1.BeginTransactionRequest build() {
      com.google.spanner.v1.BeginTransactionRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.spanner.v1.BeginTransactionRequest buildPartial() {
      com.google.spanner.v1.BeginTransactionRequest result = new com.google.spanner.v1.BeginTransactionRequest(this);
      result.session_ = session_;
      if (optionsBuilder_ == null) {
        result.options_ = options_;
      } else {
        result.options_ = optionsBuilder_.build();
      }
      if (requestOptionsBuilder_ == null) {
        result.requestOptions_ = requestOptions_;
      } else {
        result.requestOptions_ = requestOptionsBuilder_.build();
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
      if (other instanceof com.google.spanner.v1.BeginTransactionRequest) {
        return mergeFrom((com.google.spanner.v1.BeginTransactionRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.spanner.v1.BeginTransactionRequest other) {
      if (other == com.google.spanner.v1.BeginTransactionRequest.getDefaultInstance()) return this;
      if (!other.getSession().isEmpty()) {
        session_ = other.session_;
        onChanged();
      }
      if (other.hasOptions()) {
        mergeOptions(other.getOptions());
      }
      if (other.hasRequestOptions()) {
        mergeRequestOptions(other.getRequestOptions());
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
      com.google.spanner.v1.BeginTransactionRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.spanner.v1.BeginTransactionRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object session_ = "";
    /**
     * <pre>
     * Required. The session in which the transaction runs.
     * </pre>
     *
     * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The session.
     */
    public java.lang.String getSession() {
      java.lang.Object ref = session_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        session_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. The session in which the transaction runs.
     * </pre>
     *
     * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The bytes for session.
     */
    public com.google.protobuf.ByteString
        getSessionBytes() {
      java.lang.Object ref = session_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        session_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. The session in which the transaction runs.
     * </pre>
     *
     * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The session to set.
     * @return This builder for chaining.
     */
    public Builder setSession(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      session_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The session in which the transaction runs.
     * </pre>
     *
     * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return This builder for chaining.
     */
    public Builder clearSession() {
      
      session_ = getDefaultInstance().getSession();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The session in which the transaction runs.
     * </pre>
     *
     * <code>string session = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The bytes for session to set.
     * @return This builder for chaining.
     */
    public Builder setSessionBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      session_ = value;
      onChanged();
      return this;
    }

    private com.google.spanner.v1.TransactionOptions options_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.spanner.v1.TransactionOptions, com.google.spanner.v1.TransactionOptions.Builder, com.google.spanner.v1.TransactionOptionsOrBuilder> optionsBuilder_;
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the options field is set.
     */
    public boolean hasOptions() {
      return optionsBuilder_ != null || options_ != null;
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The options.
     */
    public com.google.spanner.v1.TransactionOptions getOptions() {
      if (optionsBuilder_ == null) {
        return options_ == null ? com.google.spanner.v1.TransactionOptions.getDefaultInstance() : options_;
      } else {
        return optionsBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setOptions(com.google.spanner.v1.TransactionOptions value) {
      if (optionsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        options_ = value;
        onChanged();
      } else {
        optionsBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setOptions(
        com.google.spanner.v1.TransactionOptions.Builder builderForValue) {
      if (optionsBuilder_ == null) {
        options_ = builderForValue.build();
        onChanged();
      } else {
        optionsBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeOptions(com.google.spanner.v1.TransactionOptions value) {
      if (optionsBuilder_ == null) {
        if (options_ != null) {
          options_ =
            com.google.spanner.v1.TransactionOptions.newBuilder(options_).mergeFrom(value).buildPartial();
        } else {
          options_ = value;
        }
        onChanged();
      } else {
        optionsBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearOptions() {
      if (optionsBuilder_ == null) {
        options_ = null;
        onChanged();
      } else {
        options_ = null;
        optionsBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.spanner.v1.TransactionOptions.Builder getOptionsBuilder() {
      
      onChanged();
      return getOptionsFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.spanner.v1.TransactionOptionsOrBuilder getOptionsOrBuilder() {
      if (optionsBuilder_ != null) {
        return optionsBuilder_.getMessageOrBuilder();
      } else {
        return options_ == null ?
            com.google.spanner.v1.TransactionOptions.getDefaultInstance() : options_;
      }
    }
    /**
     * <pre>
     * Required. Options for the new transaction.
     * </pre>
     *
     * <code>.google.spanner.v1.TransactionOptions options = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.spanner.v1.TransactionOptions, com.google.spanner.v1.TransactionOptions.Builder, com.google.spanner.v1.TransactionOptionsOrBuilder> 
        getOptionsFieldBuilder() {
      if (optionsBuilder_ == null) {
        optionsBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.spanner.v1.TransactionOptions, com.google.spanner.v1.TransactionOptions.Builder, com.google.spanner.v1.TransactionOptionsOrBuilder>(
                getOptions(),
                getParentForChildren(),
                isClean());
        options_ = null;
      }
      return optionsBuilder_;
    }

    private com.google.spanner.v1.RequestOptions requestOptions_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.spanner.v1.RequestOptions, com.google.spanner.v1.RequestOptions.Builder, com.google.spanner.v1.RequestOptionsOrBuilder> requestOptionsBuilder_;
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     * @return Whether the requestOptions field is set.
     */
    public boolean hasRequestOptions() {
      return requestOptionsBuilder_ != null || requestOptions_ != null;
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     * @return The requestOptions.
     */
    public com.google.spanner.v1.RequestOptions getRequestOptions() {
      if (requestOptionsBuilder_ == null) {
        return requestOptions_ == null ? com.google.spanner.v1.RequestOptions.getDefaultInstance() : requestOptions_;
      } else {
        return requestOptionsBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public Builder setRequestOptions(com.google.spanner.v1.RequestOptions value) {
      if (requestOptionsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        requestOptions_ = value;
        onChanged();
      } else {
        requestOptionsBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public Builder setRequestOptions(
        com.google.spanner.v1.RequestOptions.Builder builderForValue) {
      if (requestOptionsBuilder_ == null) {
        requestOptions_ = builderForValue.build();
        onChanged();
      } else {
        requestOptionsBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public Builder mergeRequestOptions(com.google.spanner.v1.RequestOptions value) {
      if (requestOptionsBuilder_ == null) {
        if (requestOptions_ != null) {
          requestOptions_ =
            com.google.spanner.v1.RequestOptions.newBuilder(requestOptions_).mergeFrom(value).buildPartial();
        } else {
          requestOptions_ = value;
        }
        onChanged();
      } else {
        requestOptionsBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public Builder clearRequestOptions() {
      if (requestOptionsBuilder_ == null) {
        requestOptions_ = null;
        onChanged();
      } else {
        requestOptions_ = null;
        requestOptionsBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public com.google.spanner.v1.RequestOptions.Builder getRequestOptionsBuilder() {
      
      onChanged();
      return getRequestOptionsFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    public com.google.spanner.v1.RequestOptionsOrBuilder getRequestOptionsOrBuilder() {
      if (requestOptionsBuilder_ != null) {
        return requestOptionsBuilder_.getMessageOrBuilder();
      } else {
        return requestOptions_ == null ?
            com.google.spanner.v1.RequestOptions.getDefaultInstance() : requestOptions_;
      }
    }
    /**
     * <pre>
     * Common options for this request.
     * Priority is ignored for this request. Setting the priority in this
     * request_options struct will not do anything. To set the priority for a
     * transaction, set it on the reads and writes that are part of this
     * transaction instead.
     * </pre>
     *
     * <code>.google.spanner.v1.RequestOptions request_options = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.spanner.v1.RequestOptions, com.google.spanner.v1.RequestOptions.Builder, com.google.spanner.v1.RequestOptionsOrBuilder> 
        getRequestOptionsFieldBuilder() {
      if (requestOptionsBuilder_ == null) {
        requestOptionsBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.spanner.v1.RequestOptions, com.google.spanner.v1.RequestOptions.Builder, com.google.spanner.v1.RequestOptionsOrBuilder>(
                getRequestOptions(),
                getParentForChildren(),
                isClean());
        requestOptions_ = null;
      }
      return requestOptionsBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.spanner.v1.BeginTransactionRequest)
  }

  // @@protoc_insertion_point(class_scope:google.spanner.v1.BeginTransactionRequest)
  private static final com.google.spanner.v1.BeginTransactionRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.spanner.v1.BeginTransactionRequest();
  }

  public static com.google.spanner.v1.BeginTransactionRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<BeginTransactionRequest>
      PARSER = new com.google.protobuf.AbstractParser<BeginTransactionRequest>() {
    @java.lang.Override
    public BeginTransactionRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new BeginTransactionRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<BeginTransactionRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<BeginTransactionRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.spanner.v1.BeginTransactionRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

