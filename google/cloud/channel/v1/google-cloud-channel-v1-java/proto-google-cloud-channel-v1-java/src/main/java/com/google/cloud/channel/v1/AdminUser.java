// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/channel/v1/common.proto

package com.google.cloud.channel.v1;

/**
 * <pre>
 * Information needed to create an Admin User for Google Workspace.
 * </pre>
 *
 * Protobuf type {@code google.cloud.channel.v1.AdminUser}
 */
public final class AdminUser extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.channel.v1.AdminUser)
    AdminUserOrBuilder {
private static final long serialVersionUID = 0L;
  // Use AdminUser.newBuilder() to construct.
  private AdminUser(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private AdminUser() {
    email_ = "";
    givenName_ = "";
    familyName_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new AdminUser();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private AdminUser(
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

            email_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            givenName_ = s;
            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            familyName_ = s;
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
    return com.google.cloud.channel.v1.CommonProto.internal_static_google_cloud_channel_v1_AdminUser_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.channel.v1.CommonProto.internal_static_google_cloud_channel_v1_AdminUser_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.channel.v1.AdminUser.class, com.google.cloud.channel.v1.AdminUser.Builder.class);
  }

  public static final int EMAIL_FIELD_NUMBER = 1;
  private volatile java.lang.Object email_;
  /**
   * <pre>
   * Primary email of the admin user.
   * </pre>
   *
   * <code>string email = 1;</code>
   * @return The email.
   */
  @java.lang.Override
  public java.lang.String getEmail() {
    java.lang.Object ref = email_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      email_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Primary email of the admin user.
   * </pre>
   *
   * <code>string email = 1;</code>
   * @return The bytes for email.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getEmailBytes() {
    java.lang.Object ref = email_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      email_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int GIVEN_NAME_FIELD_NUMBER = 2;
  private volatile java.lang.Object givenName_;
  /**
   * <pre>
   * Given name of the admin user.
   * </pre>
   *
   * <code>string given_name = 2;</code>
   * @return The givenName.
   */
  @java.lang.Override
  public java.lang.String getGivenName() {
    java.lang.Object ref = givenName_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      givenName_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Given name of the admin user.
   * </pre>
   *
   * <code>string given_name = 2;</code>
   * @return The bytes for givenName.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getGivenNameBytes() {
    java.lang.Object ref = givenName_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      givenName_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int FAMILY_NAME_FIELD_NUMBER = 3;
  private volatile java.lang.Object familyName_;
  /**
   * <pre>
   * Family name of the admin user.
   * </pre>
   *
   * <code>string family_name = 3;</code>
   * @return The familyName.
   */
  @java.lang.Override
  public java.lang.String getFamilyName() {
    java.lang.Object ref = familyName_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      familyName_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Family name of the admin user.
   * </pre>
   *
   * <code>string family_name = 3;</code>
   * @return The bytes for familyName.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getFamilyNameBytes() {
    java.lang.Object ref = familyName_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      familyName_ = b;
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(email_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, email_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(givenName_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, givenName_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(familyName_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, familyName_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(email_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, email_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(givenName_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, givenName_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(familyName_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, familyName_);
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
    if (!(obj instanceof com.google.cloud.channel.v1.AdminUser)) {
      return super.equals(obj);
    }
    com.google.cloud.channel.v1.AdminUser other = (com.google.cloud.channel.v1.AdminUser) obj;

    if (!getEmail()
        .equals(other.getEmail())) return false;
    if (!getGivenName()
        .equals(other.getGivenName())) return false;
    if (!getFamilyName()
        .equals(other.getFamilyName())) return false;
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
    hash = (37 * hash) + EMAIL_FIELD_NUMBER;
    hash = (53 * hash) + getEmail().hashCode();
    hash = (37 * hash) + GIVEN_NAME_FIELD_NUMBER;
    hash = (53 * hash) + getGivenName().hashCode();
    hash = (37 * hash) + FAMILY_NAME_FIELD_NUMBER;
    hash = (53 * hash) + getFamilyName().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.channel.v1.AdminUser parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.channel.v1.AdminUser parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.channel.v1.AdminUser parseFrom(
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
  public static Builder newBuilder(com.google.cloud.channel.v1.AdminUser prototype) {
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
   * Information needed to create an Admin User for Google Workspace.
   * </pre>
   *
   * Protobuf type {@code google.cloud.channel.v1.AdminUser}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.channel.v1.AdminUser)
      com.google.cloud.channel.v1.AdminUserOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.channel.v1.CommonProto.internal_static_google_cloud_channel_v1_AdminUser_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.channel.v1.CommonProto.internal_static_google_cloud_channel_v1_AdminUser_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.channel.v1.AdminUser.class, com.google.cloud.channel.v1.AdminUser.Builder.class);
    }

    // Construct using com.google.cloud.channel.v1.AdminUser.newBuilder()
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
      email_ = "";

      givenName_ = "";

      familyName_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.channel.v1.CommonProto.internal_static_google_cloud_channel_v1_AdminUser_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.channel.v1.AdminUser getDefaultInstanceForType() {
      return com.google.cloud.channel.v1.AdminUser.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.channel.v1.AdminUser build() {
      com.google.cloud.channel.v1.AdminUser result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.channel.v1.AdminUser buildPartial() {
      com.google.cloud.channel.v1.AdminUser result = new com.google.cloud.channel.v1.AdminUser(this);
      result.email_ = email_;
      result.givenName_ = givenName_;
      result.familyName_ = familyName_;
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
      if (other instanceof com.google.cloud.channel.v1.AdminUser) {
        return mergeFrom((com.google.cloud.channel.v1.AdminUser)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.channel.v1.AdminUser other) {
      if (other == com.google.cloud.channel.v1.AdminUser.getDefaultInstance()) return this;
      if (!other.getEmail().isEmpty()) {
        email_ = other.email_;
        onChanged();
      }
      if (!other.getGivenName().isEmpty()) {
        givenName_ = other.givenName_;
        onChanged();
      }
      if (!other.getFamilyName().isEmpty()) {
        familyName_ = other.familyName_;
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
      com.google.cloud.channel.v1.AdminUser parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.channel.v1.AdminUser) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object email_ = "";
    /**
     * <pre>
     * Primary email of the admin user.
     * </pre>
     *
     * <code>string email = 1;</code>
     * @return The email.
     */
    public java.lang.String getEmail() {
      java.lang.Object ref = email_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        email_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Primary email of the admin user.
     * </pre>
     *
     * <code>string email = 1;</code>
     * @return The bytes for email.
     */
    public com.google.protobuf.ByteString
        getEmailBytes() {
      java.lang.Object ref = email_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        email_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Primary email of the admin user.
     * </pre>
     *
     * <code>string email = 1;</code>
     * @param value The email to set.
     * @return This builder for chaining.
     */
    public Builder setEmail(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      email_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Primary email of the admin user.
     * </pre>
     *
     * <code>string email = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearEmail() {
      
      email_ = getDefaultInstance().getEmail();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Primary email of the admin user.
     * </pre>
     *
     * <code>string email = 1;</code>
     * @param value The bytes for email to set.
     * @return This builder for chaining.
     */
    public Builder setEmailBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      email_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object givenName_ = "";
    /**
     * <pre>
     * Given name of the admin user.
     * </pre>
     *
     * <code>string given_name = 2;</code>
     * @return The givenName.
     */
    public java.lang.String getGivenName() {
      java.lang.Object ref = givenName_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        givenName_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Given name of the admin user.
     * </pre>
     *
     * <code>string given_name = 2;</code>
     * @return The bytes for givenName.
     */
    public com.google.protobuf.ByteString
        getGivenNameBytes() {
      java.lang.Object ref = givenName_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        givenName_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Given name of the admin user.
     * </pre>
     *
     * <code>string given_name = 2;</code>
     * @param value The givenName to set.
     * @return This builder for chaining.
     */
    public Builder setGivenName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      givenName_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Given name of the admin user.
     * </pre>
     *
     * <code>string given_name = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearGivenName() {
      
      givenName_ = getDefaultInstance().getGivenName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Given name of the admin user.
     * </pre>
     *
     * <code>string given_name = 2;</code>
     * @param value The bytes for givenName to set.
     * @return This builder for chaining.
     */
    public Builder setGivenNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      givenName_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object familyName_ = "";
    /**
     * <pre>
     * Family name of the admin user.
     * </pre>
     *
     * <code>string family_name = 3;</code>
     * @return The familyName.
     */
    public java.lang.String getFamilyName() {
      java.lang.Object ref = familyName_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        familyName_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Family name of the admin user.
     * </pre>
     *
     * <code>string family_name = 3;</code>
     * @return The bytes for familyName.
     */
    public com.google.protobuf.ByteString
        getFamilyNameBytes() {
      java.lang.Object ref = familyName_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        familyName_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Family name of the admin user.
     * </pre>
     *
     * <code>string family_name = 3;</code>
     * @param value The familyName to set.
     * @return This builder for chaining.
     */
    public Builder setFamilyName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      familyName_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Family name of the admin user.
     * </pre>
     *
     * <code>string family_name = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearFamilyName() {
      
      familyName_ = getDefaultInstance().getFamilyName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Family name of the admin user.
     * </pre>
     *
     * <code>string family_name = 3;</code>
     * @param value The bytes for familyName to set.
     * @return This builder for chaining.
     */
    public Builder setFamilyNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      familyName_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.channel.v1.AdminUser)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.channel.v1.AdminUser)
  private static final com.google.cloud.channel.v1.AdminUser DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.channel.v1.AdminUser();
  }

  public static com.google.cloud.channel.v1.AdminUser getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<AdminUser>
      PARSER = new com.google.protobuf.AbstractParser<AdminUser>() {
    @java.lang.Override
    public AdminUser parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new AdminUser(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<AdminUser> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<AdminUser> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.channel.v1.AdminUser getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

