// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/metastore/v1alpha/metastore.proto

package com.google.cloud.metastore.v1alpha;

/**
 * <pre>
 * A securely stored value.
 * </pre>
 *
 * Protobuf type {@code google.cloud.metastore.v1alpha.Secret}
 */
public final class Secret extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.metastore.v1alpha.Secret)
    SecretOrBuilder {
private static final long serialVersionUID = 0L;
  // Use Secret.newBuilder() to construct.
  private Secret(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private Secret() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new Secret();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private Secret(
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
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();
            valueCase_ = 2;
            value_ = s;
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
    return com.google.cloud.metastore.v1alpha.MetastoreProto.internal_static_google_cloud_metastore_v1alpha_Secret_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.metastore.v1alpha.MetastoreProto.internal_static_google_cloud_metastore_v1alpha_Secret_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.metastore.v1alpha.Secret.class, com.google.cloud.metastore.v1alpha.Secret.Builder.class);
  }

  private int valueCase_ = 0;
  private java.lang.Object value_;
  public enum ValueCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    CLOUD_SECRET(2),
    VALUE_NOT_SET(0);
    private final int value;
    private ValueCase(int value) {
      this.value = value;
    }
    /**
     * @param value The number of the enum to look for.
     * @return The enum associated with the given number.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static ValueCase valueOf(int value) {
      return forNumber(value);
    }

    public static ValueCase forNumber(int value) {
      switch (value) {
        case 2: return CLOUD_SECRET;
        case 0: return VALUE_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public ValueCase
  getValueCase() {
    return ValueCase.forNumber(
        valueCase_);
  }

  public static final int CLOUD_SECRET_FIELD_NUMBER = 2;
  /**
   * <pre>
   * The relative resource name of a Secret Manager secret version, in the
   * following form:
   * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
   * </pre>
   *
   * <code>string cloud_secret = 2;</code>
   * @return Whether the cloudSecret field is set.
   */
  public boolean hasCloudSecret() {
    return valueCase_ == 2;
  }
  /**
   * <pre>
   * The relative resource name of a Secret Manager secret version, in the
   * following form:
   * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
   * </pre>
   *
   * <code>string cloud_secret = 2;</code>
   * @return The cloudSecret.
   */
  public java.lang.String getCloudSecret() {
    java.lang.Object ref = "";
    if (valueCase_ == 2) {
      ref = value_;
    }
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      if (valueCase_ == 2) {
        value_ = s;
      }
      return s;
    }
  }
  /**
   * <pre>
   * The relative resource name of a Secret Manager secret version, in the
   * following form:
   * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
   * </pre>
   *
   * <code>string cloud_secret = 2;</code>
   * @return The bytes for cloudSecret.
   */
  public com.google.protobuf.ByteString
      getCloudSecretBytes() {
    java.lang.Object ref = "";
    if (valueCase_ == 2) {
      ref = value_;
    }
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      if (valueCase_ == 2) {
        value_ = b;
      }
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
    if (valueCase_ == 2) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, value_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (valueCase_ == 2) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, value_);
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
    if (!(obj instanceof com.google.cloud.metastore.v1alpha.Secret)) {
      return super.equals(obj);
    }
    com.google.cloud.metastore.v1alpha.Secret other = (com.google.cloud.metastore.v1alpha.Secret) obj;

    if (!getValueCase().equals(other.getValueCase())) return false;
    switch (valueCase_) {
      case 2:
        if (!getCloudSecret()
            .equals(other.getCloudSecret())) return false;
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
    switch (valueCase_) {
      case 2:
        hash = (37 * hash) + CLOUD_SECRET_FIELD_NUMBER;
        hash = (53 * hash) + getCloudSecret().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.metastore.v1alpha.Secret parseFrom(
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
  public static Builder newBuilder(com.google.cloud.metastore.v1alpha.Secret prototype) {
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
   * A securely stored value.
   * </pre>
   *
   * Protobuf type {@code google.cloud.metastore.v1alpha.Secret}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.metastore.v1alpha.Secret)
      com.google.cloud.metastore.v1alpha.SecretOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.metastore.v1alpha.MetastoreProto.internal_static_google_cloud_metastore_v1alpha_Secret_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.metastore.v1alpha.MetastoreProto.internal_static_google_cloud_metastore_v1alpha_Secret_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.metastore.v1alpha.Secret.class, com.google.cloud.metastore.v1alpha.Secret.Builder.class);
    }

    // Construct using com.google.cloud.metastore.v1alpha.Secret.newBuilder()
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
      valueCase_ = 0;
      value_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.metastore.v1alpha.MetastoreProto.internal_static_google_cloud_metastore_v1alpha_Secret_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.metastore.v1alpha.Secret getDefaultInstanceForType() {
      return com.google.cloud.metastore.v1alpha.Secret.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.metastore.v1alpha.Secret build() {
      com.google.cloud.metastore.v1alpha.Secret result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.metastore.v1alpha.Secret buildPartial() {
      com.google.cloud.metastore.v1alpha.Secret result = new com.google.cloud.metastore.v1alpha.Secret(this);
      if (valueCase_ == 2) {
        result.value_ = value_;
      }
      result.valueCase_ = valueCase_;
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
      if (other instanceof com.google.cloud.metastore.v1alpha.Secret) {
        return mergeFrom((com.google.cloud.metastore.v1alpha.Secret)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.metastore.v1alpha.Secret other) {
      if (other == com.google.cloud.metastore.v1alpha.Secret.getDefaultInstance()) return this;
      switch (other.getValueCase()) {
        case CLOUD_SECRET: {
          valueCase_ = 2;
          value_ = other.value_;
          onChanged();
          break;
        }
        case VALUE_NOT_SET: {
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
      com.google.cloud.metastore.v1alpha.Secret parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.metastore.v1alpha.Secret) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int valueCase_ = 0;
    private java.lang.Object value_;
    public ValueCase
        getValueCase() {
      return ValueCase.forNumber(
          valueCase_);
    }

    public Builder clearValue() {
      valueCase_ = 0;
      value_ = null;
      onChanged();
      return this;
    }


    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @return Whether the cloudSecret field is set.
     */
    @java.lang.Override
    public boolean hasCloudSecret() {
      return valueCase_ == 2;
    }
    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @return The cloudSecret.
     */
    @java.lang.Override
    public java.lang.String getCloudSecret() {
      java.lang.Object ref = "";
      if (valueCase_ == 2) {
        ref = value_;
      }
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        if (valueCase_ == 2) {
          value_ = s;
        }
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @return The bytes for cloudSecret.
     */
    @java.lang.Override
    public com.google.protobuf.ByteString
        getCloudSecretBytes() {
      java.lang.Object ref = "";
      if (valueCase_ == 2) {
        ref = value_;
      }
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        if (valueCase_ == 2) {
          value_ = b;
        }
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @param value The cloudSecret to set.
     * @return This builder for chaining.
     */
    public Builder setCloudSecret(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  valueCase_ = 2;
      value_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearCloudSecret() {
      if (valueCase_ == 2) {
        valueCase_ = 0;
        value_ = null;
        onChanged();
      }
      return this;
    }
    /**
     * <pre>
     * The relative resource name of a Secret Manager secret version, in the
     * following form:
     * `projects/{project_number}/secrets/{secret_id}/versions/{version_id}`.
     * </pre>
     *
     * <code>string cloud_secret = 2;</code>
     * @param value The bytes for cloudSecret to set.
     * @return This builder for chaining.
     */
    public Builder setCloudSecretBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      valueCase_ = 2;
      value_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.metastore.v1alpha.Secret)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.metastore.v1alpha.Secret)
  private static final com.google.cloud.metastore.v1alpha.Secret DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.metastore.v1alpha.Secret();
  }

  public static com.google.cloud.metastore.v1alpha.Secret getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<Secret>
      PARSER = new com.google.protobuf.AbstractParser<Secret>() {
    @java.lang.Override
    public Secret parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new Secret(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<Secret> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<Secret> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.metastore.v1alpha.Secret getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

