// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/market/v2/services.proto

package com.google.ccc.hosted.marketplace.v2;

/**
 * Protobuf type {@code ccc.hosted.marketplace.v2.CustomerLicenseGetRequest}
 */
public final class CustomerLicenseGetRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)
    CustomerLicenseGetRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CustomerLicenseGetRequest.newBuilder() to construct.
  private CustomerLicenseGetRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CustomerLicenseGetRequest() {
    applicationId_ = "";
    customerId_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CustomerLicenseGetRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CustomerLicenseGetRequest(
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

            applicationId_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            customerId_ = s;
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
    return com.google.ccc.hosted.marketplace.v2.ServiceProto.internal_static_ccc_hosted_marketplace_v2_CustomerLicenseGetRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.ccc.hosted.marketplace.v2.ServiceProto.internal_static_ccc_hosted_marketplace_v2_CustomerLicenseGetRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.class, com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.Builder.class);
  }

  public static final int APPLICATION_ID_FIELD_NUMBER = 1;
  private volatile java.lang.Object applicationId_;
  /**
   * <pre>
   * Application Id
   * </pre>
   *
   * <code>string application_id = 1;</code>
   * @return The applicationId.
   */
  @java.lang.Override
  public java.lang.String getApplicationId() {
    java.lang.Object ref = applicationId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      applicationId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Application Id
   * </pre>
   *
   * <code>string application_id = 1;</code>
   * @return The bytes for applicationId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getApplicationIdBytes() {
    java.lang.Object ref = applicationId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      applicationId_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CUSTOMER_ID_FIELD_NUMBER = 2;
  private volatile java.lang.Object customerId_;
  /**
   * <pre>
   * Customer Id
   * </pre>
   *
   * <code>string customer_id = 2;</code>
   * @return The customerId.
   */
  @java.lang.Override
  public java.lang.String getCustomerId() {
    java.lang.Object ref = customerId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      customerId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Customer Id
   * </pre>
   *
   * <code>string customer_id = 2;</code>
   * @return The bytes for customerId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getCustomerIdBytes() {
    java.lang.Object ref = customerId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      customerId_ = b;
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(applicationId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, applicationId_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(customerId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, customerId_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(applicationId_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, applicationId_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(customerId_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, customerId_);
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
    if (!(obj instanceof com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)) {
      return super.equals(obj);
    }
    com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest other = (com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest) obj;

    if (!getApplicationId()
        .equals(other.getApplicationId())) return false;
    if (!getCustomerId()
        .equals(other.getCustomerId())) return false;
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
    hash = (37 * hash) + APPLICATION_ID_FIELD_NUMBER;
    hash = (53 * hash) + getApplicationId().hashCode();
    hash = (37 * hash) + CUSTOMER_ID_FIELD_NUMBER;
    hash = (53 * hash) + getCustomerId().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parseFrom(
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
  public static Builder newBuilder(com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest prototype) {
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
   * Protobuf type {@code ccc.hosted.marketplace.v2.CustomerLicenseGetRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)
      com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.internal_static_ccc_hosted_marketplace_v2_CustomerLicenseGetRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.internal_static_ccc_hosted_marketplace_v2_CustomerLicenseGetRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.class, com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.Builder.class);
    }

    // Construct using com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.newBuilder()
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
      applicationId_ = "";

      customerId_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.internal_static_ccc_hosted_marketplace_v2_CustomerLicenseGetRequest_descriptor;
    }

    @java.lang.Override
    public com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest getDefaultInstanceForType() {
      return com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest build() {
      com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest buildPartial() {
      com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest result = new com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest(this);
      result.applicationId_ = applicationId_;
      result.customerId_ = customerId_;
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
      if (other instanceof com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest) {
        return mergeFrom((com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest other) {
      if (other == com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.getDefaultInstance()) return this;
      if (!other.getApplicationId().isEmpty()) {
        applicationId_ = other.applicationId_;
        onChanged();
      }
      if (!other.getCustomerId().isEmpty()) {
        customerId_ = other.customerId_;
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
      com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object applicationId_ = "";
    /**
     * <pre>
     * Application Id
     * </pre>
     *
     * <code>string application_id = 1;</code>
     * @return The applicationId.
     */
    public java.lang.String getApplicationId() {
      java.lang.Object ref = applicationId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        applicationId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Application Id
     * </pre>
     *
     * <code>string application_id = 1;</code>
     * @return The bytes for applicationId.
     */
    public com.google.protobuf.ByteString
        getApplicationIdBytes() {
      java.lang.Object ref = applicationId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        applicationId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Application Id
     * </pre>
     *
     * <code>string application_id = 1;</code>
     * @param value The applicationId to set.
     * @return This builder for chaining.
     */
    public Builder setApplicationId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      applicationId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Application Id
     * </pre>
     *
     * <code>string application_id = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearApplicationId() {
      
      applicationId_ = getDefaultInstance().getApplicationId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Application Id
     * </pre>
     *
     * <code>string application_id = 1;</code>
     * @param value The bytes for applicationId to set.
     * @return This builder for chaining.
     */
    public Builder setApplicationIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      applicationId_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object customerId_ = "";
    /**
     * <pre>
     * Customer Id
     * </pre>
     *
     * <code>string customer_id = 2;</code>
     * @return The customerId.
     */
    public java.lang.String getCustomerId() {
      java.lang.Object ref = customerId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        customerId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Customer Id
     * </pre>
     *
     * <code>string customer_id = 2;</code>
     * @return The bytes for customerId.
     */
    public com.google.protobuf.ByteString
        getCustomerIdBytes() {
      java.lang.Object ref = customerId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        customerId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Customer Id
     * </pre>
     *
     * <code>string customer_id = 2;</code>
     * @param value The customerId to set.
     * @return This builder for chaining.
     */
    public Builder setCustomerId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      customerId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Customer Id
     * </pre>
     *
     * <code>string customer_id = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearCustomerId() {
      
      customerId_ = getDefaultInstance().getCustomerId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Customer Id
     * </pre>
     *
     * <code>string customer_id = 2;</code>
     * @param value The bytes for customerId to set.
     * @return This builder for chaining.
     */
    public Builder setCustomerIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      customerId_ = value;
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


    // @@protoc_insertion_point(builder_scope:ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)
  }

  // @@protoc_insertion_point(class_scope:ccc.hosted.marketplace.v2.CustomerLicenseGetRequest)
  private static final com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest();
  }

  public static com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CustomerLicenseGetRequest>
      PARSER = new com.google.protobuf.AbstractParser<CustomerLicenseGetRequest>() {
    @java.lang.Override
    public CustomerLicenseGetRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CustomerLicenseGetRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CustomerLicenseGetRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CustomerLicenseGetRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

