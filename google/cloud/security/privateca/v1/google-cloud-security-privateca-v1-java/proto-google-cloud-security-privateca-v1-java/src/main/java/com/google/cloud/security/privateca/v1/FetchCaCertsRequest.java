// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/security/privateca/v1/service.proto

package com.google.cloud.security.privateca.v1;

/**
 * <pre>
 * Request message for
 * [CertificateAuthorityService.FetchCaCerts][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCaCerts].
 * </pre>
 *
 * Protobuf type {@code google.cloud.security.privateca.v1.FetchCaCertsRequest}
 */
public final class FetchCaCertsRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.security.privateca.v1.FetchCaCertsRequest)
    FetchCaCertsRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use FetchCaCertsRequest.newBuilder() to construct.
  private FetchCaCertsRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private FetchCaCertsRequest() {
    caPool_ = "";
    requestId_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new FetchCaCertsRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private FetchCaCertsRequest(
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

            caPool_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            requestId_ = s;
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
    return com.google.cloud.security.privateca.v1.PrivateCaProto.internal_static_google_cloud_security_privateca_v1_FetchCaCertsRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.security.privateca.v1.PrivateCaProto.internal_static_google_cloud_security_privateca_v1_FetchCaCertsRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.security.privateca.v1.FetchCaCertsRequest.class, com.google.cloud.security.privateca.v1.FetchCaCertsRequest.Builder.class);
  }

  public static final int CA_POOL_FIELD_NUMBER = 1;
  private volatile java.lang.Object caPool_;
  /**
   * <pre>
   * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
   * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
   * </pre>
   *
   * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The caPool.
   */
  @java.lang.Override
  public java.lang.String getCaPool() {
    java.lang.Object ref = caPool_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      caPool_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
   * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
   * </pre>
   *
   * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for caPool.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getCaPoolBytes() {
    java.lang.Object ref = caPool_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      caPool_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int REQUEST_ID_FIELD_NUMBER = 2;
  private volatile java.lang.Object requestId_;
  /**
   * <pre>
   * Optional. An ID to identify requests. Specify a unique request ID so that if you must
   * retry your request, the server will know to ignore the request if it has
   * already been completed. The server will guarantee that for at least 60
   * minutes since the first request.
   * For example, consider a situation where you make an initial request and t
   * he request times out. If you make the request again with the same request
   * ID, the server can check if original operation with the same request ID
   * was received, and if so, will ignore the second request. This prevents
   * clients from accidentally creating duplicate commitments.
   * The request ID must be a valid UUID with the exception that zero UUID is
   * not supported (00000000-0000-0000-0000-000000000000).
   * </pre>
   *
   * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The requestId.
   */
  @java.lang.Override
  public java.lang.String getRequestId() {
    java.lang.Object ref = requestId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      requestId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Optional. An ID to identify requests. Specify a unique request ID so that if you must
   * retry your request, the server will know to ignore the request if it has
   * already been completed. The server will guarantee that for at least 60
   * minutes since the first request.
   * For example, consider a situation where you make an initial request and t
   * he request times out. If you make the request again with the same request
   * ID, the server can check if original operation with the same request ID
   * was received, and if so, will ignore the second request. This prevents
   * clients from accidentally creating duplicate commitments.
   * The request ID must be a valid UUID with the exception that zero UUID is
   * not supported (00000000-0000-0000-0000-000000000000).
   * </pre>
   *
   * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The bytes for requestId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getRequestIdBytes() {
    java.lang.Object ref = requestId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      requestId_ = b;
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
    if (!getCaPoolBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, caPool_);
    }
    if (!getRequestIdBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, requestId_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getCaPoolBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, caPool_);
    }
    if (!getRequestIdBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, requestId_);
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
    if (!(obj instanceof com.google.cloud.security.privateca.v1.FetchCaCertsRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.security.privateca.v1.FetchCaCertsRequest other = (com.google.cloud.security.privateca.v1.FetchCaCertsRequest) obj;

    if (!getCaPool()
        .equals(other.getCaPool())) return false;
    if (!getRequestId()
        .equals(other.getRequestId())) return false;
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
    hash = (37 * hash) + CA_POOL_FIELD_NUMBER;
    hash = (53 * hash) + getCaPool().hashCode();
    hash = (37 * hash) + REQUEST_ID_FIELD_NUMBER;
    hash = (53 * hash) + getRequestId().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.security.privateca.v1.FetchCaCertsRequest prototype) {
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
   * Request message for
   * [CertificateAuthorityService.FetchCaCerts][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCaCerts].
   * </pre>
   *
   * Protobuf type {@code google.cloud.security.privateca.v1.FetchCaCertsRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.security.privateca.v1.FetchCaCertsRequest)
      com.google.cloud.security.privateca.v1.FetchCaCertsRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.security.privateca.v1.PrivateCaProto.internal_static_google_cloud_security_privateca_v1_FetchCaCertsRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.security.privateca.v1.PrivateCaProto.internal_static_google_cloud_security_privateca_v1_FetchCaCertsRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.security.privateca.v1.FetchCaCertsRequest.class, com.google.cloud.security.privateca.v1.FetchCaCertsRequest.Builder.class);
    }

    // Construct using com.google.cloud.security.privateca.v1.FetchCaCertsRequest.newBuilder()
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
      caPool_ = "";

      requestId_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.security.privateca.v1.PrivateCaProto.internal_static_google_cloud_security_privateca_v1_FetchCaCertsRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.security.privateca.v1.FetchCaCertsRequest getDefaultInstanceForType() {
      return com.google.cloud.security.privateca.v1.FetchCaCertsRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.security.privateca.v1.FetchCaCertsRequest build() {
      com.google.cloud.security.privateca.v1.FetchCaCertsRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.security.privateca.v1.FetchCaCertsRequest buildPartial() {
      com.google.cloud.security.privateca.v1.FetchCaCertsRequest result = new com.google.cloud.security.privateca.v1.FetchCaCertsRequest(this);
      result.caPool_ = caPool_;
      result.requestId_ = requestId_;
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
      if (other instanceof com.google.cloud.security.privateca.v1.FetchCaCertsRequest) {
        return mergeFrom((com.google.cloud.security.privateca.v1.FetchCaCertsRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.security.privateca.v1.FetchCaCertsRequest other) {
      if (other == com.google.cloud.security.privateca.v1.FetchCaCertsRequest.getDefaultInstance()) return this;
      if (!other.getCaPool().isEmpty()) {
        caPool_ = other.caPool_;
        onChanged();
      }
      if (!other.getRequestId().isEmpty()) {
        requestId_ = other.requestId_;
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
      com.google.cloud.security.privateca.v1.FetchCaCertsRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.security.privateca.v1.FetchCaCertsRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object caPool_ = "";
    /**
     * <pre>
     * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
     * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     * </pre>
     *
     * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The caPool.
     */
    public java.lang.String getCaPool() {
      java.lang.Object ref = caPool_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        caPool_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
     * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     * </pre>
     *
     * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The bytes for caPool.
     */
    public com.google.protobuf.ByteString
        getCaPoolBytes() {
      java.lang.Object ref = caPool_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        caPool_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
     * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     * </pre>
     *
     * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The caPool to set.
     * @return This builder for chaining.
     */
    public Builder setCaPool(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      caPool_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
     * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     * </pre>
     *
     * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return This builder for chaining.
     */
    public Builder clearCaPool() {
      
      caPool_ = getDefaultInstance().getCaPool();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name for the [CaPool][google.cloud.security.privateca.v1.CaPool] in the
     * format `projects/&#42;&#47;locations/&#42;&#47;caPools/&#42;`.
     * </pre>
     *
     * <code>string ca_pool = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The bytes for caPool to set.
     * @return This builder for chaining.
     */
    public Builder setCaPoolBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      caPool_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object requestId_ = "";
    /**
     * <pre>
     * Optional. An ID to identify requests. Specify a unique request ID so that if you must
     * retry your request, the server will know to ignore the request if it has
     * already been completed. The server will guarantee that for at least 60
     * minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     * </pre>
     *
     * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return The requestId.
     */
    public java.lang.String getRequestId() {
      java.lang.Object ref = requestId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        requestId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Optional. An ID to identify requests. Specify a unique request ID so that if you must
     * retry your request, the server will know to ignore the request if it has
     * already been completed. The server will guarantee that for at least 60
     * minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     * </pre>
     *
     * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return The bytes for requestId.
     */
    public com.google.protobuf.ByteString
        getRequestIdBytes() {
      java.lang.Object ref = requestId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        requestId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Optional. An ID to identify requests. Specify a unique request ID so that if you must
     * retry your request, the server will know to ignore the request if it has
     * already been completed. The server will guarantee that for at least 60
     * minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     * </pre>
     *
     * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param value The requestId to set.
     * @return This builder for chaining.
     */
    public Builder setRequestId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      requestId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. An ID to identify requests. Specify a unique request ID so that if you must
     * retry your request, the server will know to ignore the request if it has
     * already been completed. The server will guarantee that for at least 60
     * minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     * </pre>
     *
     * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return This builder for chaining.
     */
    public Builder clearRequestId() {
      
      requestId_ = getDefaultInstance().getRequestId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. An ID to identify requests. Specify a unique request ID so that if you must
     * retry your request, the server will know to ignore the request if it has
     * already been completed. The server will guarantee that for at least 60
     * minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     * </pre>
     *
     * <code>string request_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param value The bytes for requestId to set.
     * @return This builder for chaining.
     */
    public Builder setRequestIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      requestId_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.security.privateca.v1.FetchCaCertsRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.security.privateca.v1.FetchCaCertsRequest)
  private static final com.google.cloud.security.privateca.v1.FetchCaCertsRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.security.privateca.v1.FetchCaCertsRequest();
  }

  public static com.google.cloud.security.privateca.v1.FetchCaCertsRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<FetchCaCertsRequest>
      PARSER = new com.google.protobuf.AbstractParser<FetchCaCertsRequest>() {
    @java.lang.Override
    public FetchCaCertsRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new FetchCaCertsRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<FetchCaCertsRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<FetchCaCertsRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.security.privateca.v1.FetchCaCertsRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

