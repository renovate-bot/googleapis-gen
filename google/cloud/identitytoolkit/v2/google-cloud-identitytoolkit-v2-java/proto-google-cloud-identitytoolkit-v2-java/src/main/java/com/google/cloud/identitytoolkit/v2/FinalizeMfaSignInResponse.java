// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/identitytoolkit/v2/authentication_service.proto

package com.google.cloud.identitytoolkit.v2;

/**
 * <pre>
 * FinalizeMfaSignIn response.
 * </pre>
 *
 * Protobuf type {@code google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse}
 */
public final class FinalizeMfaSignInResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)
    FinalizeMfaSignInResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use FinalizeMfaSignInResponse.newBuilder() to construct.
  private FinalizeMfaSignInResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private FinalizeMfaSignInResponse() {
    idToken_ = "";
    refreshToken_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new FinalizeMfaSignInResponse();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private FinalizeMfaSignInResponse(
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
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            refreshToken_ = s;
            break;
          }
          case 26: {
            com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder subBuilder = null;
            if (auxiliaryAuthInfoCase_ == 3) {
              subBuilder = ((com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_).toBuilder();
            }
            auxiliaryAuthInfo_ =
                input.readMessage(com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_);
              auxiliaryAuthInfo_ = subBuilder.buildPartial();
            }
            auxiliaryAuthInfoCase_ = 3;
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
    return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_FinalizeMfaSignInResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_FinalizeMfaSignInResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.class, com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.Builder.class);
  }

  private int auxiliaryAuthInfoCase_ = 0;
  private java.lang.Object auxiliaryAuthInfo_;
  public enum AuxiliaryAuthInfoCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    PHONE_AUTH_INFO(3),
    AUXILIARYAUTHINFO_NOT_SET(0);
    private final int value;
    private AuxiliaryAuthInfoCase(int value) {
      this.value = value;
    }
    /**
     * @param value The number of the enum to look for.
     * @return The enum associated with the given number.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static AuxiliaryAuthInfoCase valueOf(int value) {
      return forNumber(value);
    }

    public static AuxiliaryAuthInfoCase forNumber(int value) {
      switch (value) {
        case 3: return PHONE_AUTH_INFO;
        case 0: return AUXILIARYAUTHINFO_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public AuxiliaryAuthInfoCase
  getAuxiliaryAuthInfoCase() {
    return AuxiliaryAuthInfoCase.forNumber(
        auxiliaryAuthInfoCase_);
  }

  public static final int ID_TOKEN_FIELD_NUMBER = 1;
  private volatile java.lang.Object idToken_;
  /**
   * <pre>
   * ID token for the authenticated user.
   * </pre>
   *
   * <code>string id_token = 1;</code>
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
   * ID token for the authenticated user.
   * </pre>
   *
   * <code>string id_token = 1;</code>
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

  public static final int REFRESH_TOKEN_FIELD_NUMBER = 2;
  private volatile java.lang.Object refreshToken_;
  /**
   * <pre>
   * Refresh token for the authenticated user.
   * </pre>
   *
   * <code>string refresh_token = 2;</code>
   * @return The refreshToken.
   */
  @java.lang.Override
  public java.lang.String getRefreshToken() {
    java.lang.Object ref = refreshToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      refreshToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Refresh token for the authenticated user.
   * </pre>
   *
   * <code>string refresh_token = 2;</code>
   * @return The bytes for refreshToken.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getRefreshTokenBytes() {
    java.lang.Object ref = refreshToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      refreshToken_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int PHONE_AUTH_INFO_FIELD_NUMBER = 3;
  /**
   * <pre>
   * Extra phone auth info, including android verification proof.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
   * @return Whether the phoneAuthInfo field is set.
   */
  @java.lang.Override
  public boolean hasPhoneAuthInfo() {
    return auxiliaryAuthInfoCase_ == 3;
  }
  /**
   * <pre>
   * Extra phone auth info, including android verification proof.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
   * @return The phoneAuthInfo.
   */
  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo getPhoneAuthInfo() {
    if (auxiliaryAuthInfoCase_ == 3) {
       return (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_;
    }
    return com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
  }
  /**
   * <pre>
   * Extra phone auth info, including android verification proof.
   * </pre>
   *
   * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
   */
  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfoOrBuilder getPhoneAuthInfoOrBuilder() {
    if (auxiliaryAuthInfoCase_ == 3) {
       return (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_;
    }
    return com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(refreshToken_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, refreshToken_);
    }
    if (auxiliaryAuthInfoCase_ == 3) {
      output.writeMessage(3, (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_);
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(refreshToken_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, refreshToken_);
    }
    if (auxiliaryAuthInfoCase_ == 3) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_);
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
    if (!(obj instanceof com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)) {
      return super.equals(obj);
    }
    com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse other = (com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse) obj;

    if (!getIdToken()
        .equals(other.getIdToken())) return false;
    if (!getRefreshToken()
        .equals(other.getRefreshToken())) return false;
    if (!getAuxiliaryAuthInfoCase().equals(other.getAuxiliaryAuthInfoCase())) return false;
    switch (auxiliaryAuthInfoCase_) {
      case 3:
        if (!getPhoneAuthInfo()
            .equals(other.getPhoneAuthInfo())) return false;
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
    hash = (37 * hash) + REFRESH_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getRefreshToken().hashCode();
    switch (auxiliaryAuthInfoCase_) {
      case 3:
        hash = (37 * hash) + PHONE_AUTH_INFO_FIELD_NUMBER;
        hash = (53 * hash) + getPhoneAuthInfo().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parseFrom(
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
  public static Builder newBuilder(com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse prototype) {
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
   * FinalizeMfaSignIn response.
   * </pre>
   *
   * Protobuf type {@code google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_FinalizeMfaSignInResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_FinalizeMfaSignInResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.class, com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.Builder.class);
    }

    // Construct using com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.newBuilder()
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

      refreshToken_ = "";

      auxiliaryAuthInfoCase_ = 0;
      auxiliaryAuthInfo_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.internal_static_google_cloud_identitytoolkit_v2_FinalizeMfaSignInResponse_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse getDefaultInstanceForType() {
      return com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse build() {
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse buildPartial() {
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse result = new com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse(this);
      result.idToken_ = idToken_;
      result.refreshToken_ = refreshToken_;
      if (auxiliaryAuthInfoCase_ == 3) {
        if (phoneAuthInfoBuilder_ == null) {
          result.auxiliaryAuthInfo_ = auxiliaryAuthInfo_;
        } else {
          result.auxiliaryAuthInfo_ = phoneAuthInfoBuilder_.build();
        }
      }
      result.auxiliaryAuthInfoCase_ = auxiliaryAuthInfoCase_;
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
      if (other instanceof com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse) {
        return mergeFrom((com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse other) {
      if (other == com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.getDefaultInstance()) return this;
      if (!other.getIdToken().isEmpty()) {
        idToken_ = other.idToken_;
        onChanged();
      }
      if (!other.getRefreshToken().isEmpty()) {
        refreshToken_ = other.refreshToken_;
        onChanged();
      }
      switch (other.getAuxiliaryAuthInfoCase()) {
        case PHONE_AUTH_INFO: {
          mergePhoneAuthInfo(other.getPhoneAuthInfo());
          break;
        }
        case AUXILIARYAUTHINFO_NOT_SET: {
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
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int auxiliaryAuthInfoCase_ = 0;
    private java.lang.Object auxiliaryAuthInfo_;
    public AuxiliaryAuthInfoCase
        getAuxiliaryAuthInfoCase() {
      return AuxiliaryAuthInfoCase.forNumber(
          auxiliaryAuthInfoCase_);
    }

    public Builder clearAuxiliaryAuthInfo() {
      auxiliaryAuthInfoCase_ = 0;
      auxiliaryAuthInfo_ = null;
      onChanged();
      return this;
    }


    private java.lang.Object idToken_ = "";
    /**
     * <pre>
     * ID token for the authenticated user.
     * </pre>
     *
     * <code>string id_token = 1;</code>
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
     * ID token for the authenticated user.
     * </pre>
     *
     * <code>string id_token = 1;</code>
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
     * ID token for the authenticated user.
     * </pre>
     *
     * <code>string id_token = 1;</code>
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
     * ID token for the authenticated user.
     * </pre>
     *
     * <code>string id_token = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearIdToken() {
      
      idToken_ = getDefaultInstance().getIdToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * ID token for the authenticated user.
     * </pre>
     *
     * <code>string id_token = 1;</code>
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

    private java.lang.Object refreshToken_ = "";
    /**
     * <pre>
     * Refresh token for the authenticated user.
     * </pre>
     *
     * <code>string refresh_token = 2;</code>
     * @return The refreshToken.
     */
    public java.lang.String getRefreshToken() {
      java.lang.Object ref = refreshToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        refreshToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Refresh token for the authenticated user.
     * </pre>
     *
     * <code>string refresh_token = 2;</code>
     * @return The bytes for refreshToken.
     */
    public com.google.protobuf.ByteString
        getRefreshTokenBytes() {
      java.lang.Object ref = refreshToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        refreshToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Refresh token for the authenticated user.
     * </pre>
     *
     * <code>string refresh_token = 2;</code>
     * @param value The refreshToken to set.
     * @return This builder for chaining.
     */
    public Builder setRefreshToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      refreshToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Refresh token for the authenticated user.
     * </pre>
     *
     * <code>string refresh_token = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearRefreshToken() {
      
      refreshToken_ = getDefaultInstance().getRefreshToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Refresh token for the authenticated user.
     * </pre>
     *
     * <code>string refresh_token = 2;</code>
     * @param value The bytes for refreshToken to set.
     * @return This builder for chaining.
     */
    public Builder setRefreshTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      refreshToken_ = value;
      onChanged();
      return this;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfoOrBuilder> phoneAuthInfoBuilder_;
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     * @return Whether the phoneAuthInfo field is set.
     */
    @java.lang.Override
    public boolean hasPhoneAuthInfo() {
      return auxiliaryAuthInfoCase_ == 3;
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     * @return The phoneAuthInfo.
     */
    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo getPhoneAuthInfo() {
      if (phoneAuthInfoBuilder_ == null) {
        if (auxiliaryAuthInfoCase_ == 3) {
          return (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_;
        }
        return com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
      } else {
        if (auxiliaryAuthInfoCase_ == 3) {
          return phoneAuthInfoBuilder_.getMessage();
        }
        return com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    public Builder setPhoneAuthInfo(com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo value) {
      if (phoneAuthInfoBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        auxiliaryAuthInfo_ = value;
        onChanged();
      } else {
        phoneAuthInfoBuilder_.setMessage(value);
      }
      auxiliaryAuthInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    public Builder setPhoneAuthInfo(
        com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder builderForValue) {
      if (phoneAuthInfoBuilder_ == null) {
        auxiliaryAuthInfo_ = builderForValue.build();
        onChanged();
      } else {
        phoneAuthInfoBuilder_.setMessage(builderForValue.build());
      }
      auxiliaryAuthInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    public Builder mergePhoneAuthInfo(com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo value) {
      if (phoneAuthInfoBuilder_ == null) {
        if (auxiliaryAuthInfoCase_ == 3 &&
            auxiliaryAuthInfo_ != com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance()) {
          auxiliaryAuthInfo_ = com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.newBuilder((com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_)
              .mergeFrom(value).buildPartial();
        } else {
          auxiliaryAuthInfo_ = value;
        }
        onChanged();
      } else {
        if (auxiliaryAuthInfoCase_ == 3) {
          phoneAuthInfoBuilder_.mergeFrom(value);
        }
        phoneAuthInfoBuilder_.setMessage(value);
      }
      auxiliaryAuthInfoCase_ = 3;
      return this;
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    public Builder clearPhoneAuthInfo() {
      if (phoneAuthInfoBuilder_ == null) {
        if (auxiliaryAuthInfoCase_ == 3) {
          auxiliaryAuthInfoCase_ = 0;
          auxiliaryAuthInfo_ = null;
          onChanged();
        }
      } else {
        if (auxiliaryAuthInfoCase_ == 3) {
          auxiliaryAuthInfoCase_ = 0;
          auxiliaryAuthInfo_ = null;
        }
        phoneAuthInfoBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder getPhoneAuthInfoBuilder() {
      return getPhoneAuthInfoFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    @java.lang.Override
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfoOrBuilder getPhoneAuthInfoOrBuilder() {
      if ((auxiliaryAuthInfoCase_ == 3) && (phoneAuthInfoBuilder_ != null)) {
        return phoneAuthInfoBuilder_.getMessageOrBuilder();
      } else {
        if (auxiliaryAuthInfoCase_ == 3) {
          return (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_;
        }
        return com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Extra phone auth info, including android verification proof.
     * </pre>
     *
     * <code>.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo phone_auth_info = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfoOrBuilder> 
        getPhoneAuthInfoFieldBuilder() {
      if (phoneAuthInfoBuilder_ == null) {
        if (!(auxiliaryAuthInfoCase_ == 3)) {
          auxiliaryAuthInfo_ = com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.getDefaultInstance();
        }
        phoneAuthInfoBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo.Builder, com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfoOrBuilder>(
                (com.google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo) auxiliaryAuthInfo_,
                getParentForChildren(),
                isClean());
        auxiliaryAuthInfo_ = null;
      }
      auxiliaryAuthInfoCase_ = 3;
      onChanged();;
      return phoneAuthInfoBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse)
  private static final com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse();
  }

  public static com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<FinalizeMfaSignInResponse>
      PARSER = new com.google.protobuf.AbstractParser<FinalizeMfaSignInResponse>() {
    @java.lang.Override
    public FinalizeMfaSignInResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new FinalizeMfaSignInResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<FinalizeMfaSignInResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<FinalizeMfaSignInResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

