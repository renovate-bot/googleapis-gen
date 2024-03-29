// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/identitytoolkit/v2/account_management_service.proto

package com.google.cloud.identitytoolkit.v2;

/**
 * <pre>
 * Sends MFA enrollment verification SMS for a user.
 * </pre>
 *
 * Protobuf type {@code google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest}
 */
public final class StartMfaEnrollmentRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)
    StartMfaEnrollmentRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use StartMfaEnrollmentRequest.newBuilder() to construct.
  private StartMfaEnrollmentRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private StartMfaEnrollmentRequest() {
    idToken_ = "";
    tenantId_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new StartMfaEnrollmentRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private StartMfaEnrollmentRequest(
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

            idToken_ = s;
            break;
          }
          case 26: {
            com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder subBuilder = null;
            if (enrollmentInfoCase_ == 3) {
              subBuilder = ((com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_).toBuilder();
            }
            enrollmentInfo_ =
                input.readMessage(com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_);
              enrollmentInfo_ = subBuilder.buildPartial();
            }
            enrollmentInfoCase_ = 3;
            break;
          }
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();

            tenantId_ = s;
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
    return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_StartMfaEnrollmentRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_StartMfaEnrollmentRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.class, com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.Builder.class);
  }

  private int enrollmentInfoCase_ = 0;
  private java.lang.Object enrollmentInfo_;
  public enum EnrollmentInfoCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    PHONE_ENROLLMENT_INFO(3),
    ENROLLMENTINFO_NOT_SET(0);
    private final int value;
    private EnrollmentInfoCase(int value) {
      this.value = value;
    }
    /**
     * @param value The number of the enum to look for.
     * @return The enum associated with the given number.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static EnrollmentInfoCase valueOf(int value) {
      return forNumber(value);
    }

    public static EnrollmentInfoCase forNumber(int value) {
      switch (value) {
        case 3: return PHONE_ENROLLMENT_INFO;
        case 0: return ENROLLMENTINFO_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public EnrollmentInfoCase
  getEnrollmentInfoCase() {
    return EnrollmentInfoCase.forNumber(
        enrollmentInfoCase_);
  }

  public static final int ID_TOKEN_FIELD_NUMBER = 1;
  private volatile java.lang.Object idToken_;
  /**
   * <pre>
   * Required. User's ID token.
   * </pre>
   *
   * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The idToken.
   */
  @java.lang.Override
  public java.lang.String getIdToken() {
    java.lang.Object ref = idToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      idToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. User's ID token.
   * </pre>
   *
   * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for idToken.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getIdTokenBytes() {
    java.lang.Object ref = idToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      idToken_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int PHONE_ENROLLMENT_INFO_FIELD_NUMBER = 3;
  /**
   * <pre>
   * Verification info to authorize sending an SMS for phone verification.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
   * @return Whether the phoneEnrollmentInfo field is set.
   */
  @java.lang.Override
  public boolean hasPhoneEnrollmentInfo() {
    return enrollmentInfoCase_ == 3;
  }
  /**
   * <pre>
   * Verification info to authorize sending an SMS for phone verification.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
   * @return The phoneEnrollmentInfo.
   */
  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo getPhoneEnrollmentInfo() {
    if (enrollmentInfoCase_ == 3) {
       return (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_;
    }
    return com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
  }
  /**
   * <pre>
   * Verification info to authorize sending an SMS for phone verification.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
   */
  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfoOrBuilder getPhoneEnrollmentInfoOrBuilder() {
    if (enrollmentInfoCase_ == 3) {
       return (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_;
    }
    return com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
  }

  public static final int TENANT_ID_FIELD_NUMBER = 4;
  private volatile java.lang.Object tenantId_;
  /**
   * <pre>
   * The ID of the Identity Platform tenant that the user enrolling MFA belongs
   * to. If not set, the user belongs to the default Identity Platform project.
   * </pre>
   *
   * <code>string tenant_id = 4;</code>
   * @return The tenantId.
   */
  @java.lang.Override
  public java.lang.String getTenantId() {
    java.lang.Object ref = tenantId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      tenantId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The ID of the Identity Platform tenant that the user enrolling MFA belongs
   * to. If not set, the user belongs to the default Identity Platform project.
   * </pre>
   *
   * <code>string tenant_id = 4;</code>
   * @return The bytes for tenantId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getTenantIdBytes() {
    java.lang.Object ref = tenantId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      tenantId_ = b;
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(idToken_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, idToken_);
    }
    if (enrollmentInfoCase_ == 3) {
      output.writeMessage(3, (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(tenantId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, tenantId_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(idToken_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, idToken_);
    }
    if (enrollmentInfoCase_ == 3) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(tenantId_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, tenantId_);
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
    if (!(obj instanceof com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest other = (com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest) obj;

    if (!getIdToken()
        .equals(other.getIdToken())) return false;
    if (!getTenantId()
        .equals(other.getTenantId())) return false;
    if (!getEnrollmentInfoCase().equals(other.getEnrollmentInfoCase())) return false;
    switch (enrollmentInfoCase_) {
      case 3:
        if (!getPhoneEnrollmentInfo()
            .equals(other.getPhoneEnrollmentInfo())) return false;
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
    hash = (37 * hash) + ID_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getIdToken().hashCode();
    hash = (37 * hash) + TENANT_ID_FIELD_NUMBER;
    hash = (53 * hash) + getTenantId().hashCode();
    switch (enrollmentInfoCase_) {
      case 3:
        hash = (37 * hash) + PHONE_ENROLLMENT_INFO_FIELD_NUMBER;
        hash = (53 * hash) + getPhoneEnrollmentInfo().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest prototype) {
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
   * Sends MFA enrollment verification SMS for a user.
   * </pre>
   *
   * Protobuf type {@code google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_StartMfaEnrollmentRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_StartMfaEnrollmentRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.class, com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.Builder.class);
    }

    // Construct using com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.newBuilder()
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
      idToken_ = "";

      tenantId_ = "";

      enrollmentInfoCase_ = 0;
      enrollmentInfo_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_StartMfaEnrollmentRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest getDefaultInstanceForType() {
      return com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest build() {
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest buildPartial() {
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest result = new com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest(this);
      result.idToken_ = idToken_;
      if (enrollmentInfoCase_ == 3) {
        if (phoneEnrollmentInfoBuilder_ == null) {
          result.enrollmentInfo_ = enrollmentInfo_;
        } else {
          result.enrollmentInfo_ = phoneEnrollmentInfoBuilder_.build();
        }
      }
      result.tenantId_ = tenantId_;
      result.enrollmentInfoCase_ = enrollmentInfoCase_;
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
      if (other instanceof com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest) {
        return mergeFrom((com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest other) {
      if (other == com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.getDefaultInstance()) return this;
      if (!other.getIdToken().isEmpty()) {
        idToken_ = other.idToken_;
        onChanged();
      }
      if (!other.getTenantId().isEmpty()) {
        tenantId_ = other.tenantId_;
        onChanged();
      }
      switch (other.getEnrollmentInfoCase()) {
        case PHONE_ENROLLMENT_INFO: {
          mergePhoneEnrollmentInfo(other.getPhoneEnrollmentInfo());
          break;
        }
        case ENROLLMENTINFO_NOT_SET: {
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
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int enrollmentInfoCase_ = 0;
    private java.lang.Object enrollmentInfo_;
    public EnrollmentInfoCase
        getEnrollmentInfoCase() {
      return EnrollmentInfoCase.forNumber(
          enrollmentInfoCase_);
    }

    public Builder clearEnrollmentInfo() {
      enrollmentInfoCase_ = 0;
      enrollmentInfo_ = null;
      onChanged();
      return this;
    }


    private java.lang.Object idToken_ = "";
    /**
     * <pre>
     * Required. User's ID token.
     * </pre>
     *
     * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The idToken.
     */
    public java.lang.String getIdToken() {
      java.lang.Object ref = idToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        idToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. User's ID token.
     * </pre>
     *
     * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The bytes for idToken.
     */
    public com.google.protobuf.ByteString
        getIdTokenBytes() {
      java.lang.Object ref = idToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        idToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. User's ID token.
     * </pre>
     *
     * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The idToken to set.
     * @return This builder for chaining.
     */
    public Builder setIdToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      idToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. User's ID token.
     * </pre>
     *
     * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return This builder for chaining.
     */
    public Builder clearIdToken() {
      
      idToken_ = getDefaultInstance().getIdToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. User's ID token.
     * </pre>
     *
     * <code>string id_token = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The bytes for idToken to set.
     * @return This builder for chaining.
     */
    public Builder setIdTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      idToken_ = value;
      onChanged();
      return this;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfoOrBuilder> phoneEnrollmentInfoBuilder_;
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     * @return Whether the phoneEnrollmentInfo field is set.
     */
    @java.lang.Override
    public boolean hasPhoneEnrollmentInfo() {
      return enrollmentInfoCase_ == 3;
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     * @return The phoneEnrollmentInfo.
     */
    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo getPhoneEnrollmentInfo() {
      if (phoneEnrollmentInfoBuilder_ == null) {
        if (enrollmentInfoCase_ == 3) {
          return (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_;
        }
        return com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
      } else {
        if (enrollmentInfoCase_ == 3) {
          return phoneEnrollmentInfoBuilder_.getMessage();
        }
        return com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    public Builder setPhoneEnrollmentInfo(com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo value) {
      if (phoneEnrollmentInfoBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        enrollmentInfo_ = value;
        onChanged();
      } else {
        phoneEnrollmentInfoBuilder_.setMessage(value);
      }
      enrollmentInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    public Builder setPhoneEnrollmentInfo(
        com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder builderForValue) {
      if (phoneEnrollmentInfoBuilder_ == null) {
        enrollmentInfo_ = builderForValue.build();
        onChanged();
      } else {
        phoneEnrollmentInfoBuilder_.setMessage(builderForValue.build());
      }
      enrollmentInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    public Builder mergePhoneEnrollmentInfo(com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo value) {
      if (phoneEnrollmentInfoBuilder_ == null) {
        if (enrollmentInfoCase_ == 3 &&
            enrollmentInfo_ != com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance()) {
          enrollmentInfo_ = com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.newBuilder((com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_)
              .mergeFrom(value).buildPartial();
        } else {
          enrollmentInfo_ = value;
        }
        onChanged();
      } else {
        if (enrollmentInfoCase_ == 3) {
          phoneEnrollmentInfoBuilder_.mergeFrom(value);
        }
        phoneEnrollmentInfoBuilder_.setMessage(value);
      }
      enrollmentInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    public Builder clearPhoneEnrollmentInfo() {
      if (phoneEnrollmentInfoBuilder_ == null) {
        if (enrollmentInfoCase_ == 3) {
          enrollmentInfoCase_ = 0;
          enrollmentInfo_ = null;
          onChanged();
        }
      } else {
        if (enrollmentInfoCase_ == 3) {
          enrollmentInfoCase_ = 0;
          enrollmentInfo_ = null;
        }
        phoneEnrollmentInfoBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    public com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder getPhoneEnrollmentInfoBuilder() {
      return getPhoneEnrollmentInfoFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfoOrBuilder getPhoneEnrollmentInfoOrBuilder() {
      if ((enrollmentInfoCase_ == 3) && (phoneEnrollmentInfoBuilder_ != null)) {
        return phoneEnrollmentInfoBuilder_.getMessageOrBuilder();
      } else {
        if (enrollmentInfoCase_ == 3) {
          return (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_;
        }
        return com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Verification info to authorize sending an SMS for phone verification.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo phone_enrollment_info = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfoOrBuilder> 
        getPhoneEnrollmentInfoFieldBuilder() {
      if (phoneEnrollmentInfoBuilder_ == null) {
        if (!(enrollmentInfoCase_ == 3)) {
          enrollmentInfo_ = com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.getDefaultInstance();
        }
        phoneEnrollmentInfoBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo.Builder, com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfoOrBuilder>(
                (com.google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo) enrollmentInfo_,
                getParentForChildren(),
                isClean());
        enrollmentInfo_ = null;
      }
      enrollmentInfoCase_ = 3;
      onChanged();;
      return phoneEnrollmentInfoBuilder_;
    }

    private java.lang.Object tenantId_ = "";
    /**
     * <pre>
     * The ID of the Identity Platform tenant that the user enrolling MFA belongs
     * to. If not set, the user belongs to the default Identity Platform project.
     * </pre>
     *
     * <code>string tenant_id = 4;</code>
     * @return The tenantId.
     */
    public java.lang.String getTenantId() {
      java.lang.Object ref = tenantId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        tenantId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The ID of the Identity Platform tenant that the user enrolling MFA belongs
     * to. If not set, the user belongs to the default Identity Platform project.
     * </pre>
     *
     * <code>string tenant_id = 4;</code>
     * @return The bytes for tenantId.
     */
    public com.google.protobuf.ByteString
        getTenantIdBytes() {
      java.lang.Object ref = tenantId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        tenantId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The ID of the Identity Platform tenant that the user enrolling MFA belongs
     * to. If not set, the user belongs to the default Identity Platform project.
     * </pre>
     *
     * <code>string tenant_id = 4;</code>
     * @param value The tenantId to set.
     * @return This builder for chaining.
     */
    public Builder setTenantId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      tenantId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The ID of the Identity Platform tenant that the user enrolling MFA belongs
     * to. If not set, the user belongs to the default Identity Platform project.
     * </pre>
     *
     * <code>string tenant_id = 4;</code>
     * @return This builder for chaining.
     */
    public Builder clearTenantId() {
      
      tenantId_ = getDefaultInstance().getTenantId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The ID of the Identity Platform tenant that the user enrolling MFA belongs
     * to. If not set, the user belongs to the default Identity Platform project.
     * </pre>
     *
     * <code>string tenant_id = 4;</code>
     * @param value The bytes for tenantId to set.
     * @return This builder for chaining.
     */
    public Builder setTenantIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      tenantId_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest)
  private static final com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest();
  }

  public static com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<StartMfaEnrollmentRequest>
      PARSER = new com.google.protobuf.AbstractParser<StartMfaEnrollmentRequest>() {
    @java.lang.Override
    public StartMfaEnrollmentRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new StartMfaEnrollmentRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<StartMfaEnrollmentRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<StartMfaEnrollmentRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

