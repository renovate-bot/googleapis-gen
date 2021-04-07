// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/binaryauthorization/v1beta1/service.proto

package com.google.cloud.binaryauthorization.v1beta1;

/**
 * <pre>
 * Request message for [BinauthzManagementService.UpdatePolicy][].
 * </pre>
 *
 * Protobuf type {@code google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest}
 */
public final class UpdatePolicyRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)
    UpdatePolicyRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use UpdatePolicyRequest.newBuilder() to construct.
  private UpdatePolicyRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private UpdatePolicyRequest() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new UpdatePolicyRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private UpdatePolicyRequest(
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
            com.google.cloud.binaryauthorization.v1beta1.Policy.Builder subBuilder = null;
            if (policy_ != null) {
              subBuilder = policy_.toBuilder();
            }
            policy_ = input.readMessage(com.google.cloud.binaryauthorization.v1beta1.Policy.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(policy_);
              policy_ = subBuilder.buildPartial();
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
    return com.google.cloud.binaryauthorization.v1beta1.BinaryAuthorizationServiceProto.internal_static_google_cloud_binaryauthorization_v1beta1_UpdatePolicyRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.binaryauthorization.v1beta1.BinaryAuthorizationServiceProto.internal_static_google_cloud_binaryauthorization_v1beta1_UpdatePolicyRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.class, com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.Builder.class);
  }

  public static final int POLICY_FIELD_NUMBER = 1;
  private com.google.cloud.binaryauthorization.v1beta1.Policy policy_;
  /**
   * <pre>
   * Required. A new or updated
   * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
   * service will overwrite the [policy
   * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
   * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
   * </pre>
   *
   * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the policy field is set.
   */
  @java.lang.Override
  public boolean hasPolicy() {
    return policy_ != null;
  }
  /**
   * <pre>
   * Required. A new or updated
   * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
   * service will overwrite the [policy
   * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
   * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
   * </pre>
   *
   * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The policy.
   */
  @java.lang.Override
  public com.google.cloud.binaryauthorization.v1beta1.Policy getPolicy() {
    return policy_ == null ? com.google.cloud.binaryauthorization.v1beta1.Policy.getDefaultInstance() : policy_;
  }
  /**
   * <pre>
   * Required. A new or updated
   * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
   * service will overwrite the [policy
   * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
   * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
   * </pre>
   *
   * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloud.binaryauthorization.v1beta1.PolicyOrBuilder getPolicyOrBuilder() {
    return getPolicy();
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
    if (policy_ != null) {
      output.writeMessage(1, getPolicy());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (policy_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getPolicy());
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
    if (!(obj instanceof com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest other = (com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest) obj;

    if (hasPolicy() != other.hasPolicy()) return false;
    if (hasPolicy()) {
      if (!getPolicy()
          .equals(other.getPolicy())) return false;
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
    if (hasPolicy()) {
      hash = (37 * hash) + POLICY_FIELD_NUMBER;
      hash = (53 * hash) + getPolicy().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest prototype) {
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
   * Request message for [BinauthzManagementService.UpdatePolicy][].
   * </pre>
   *
   * Protobuf type {@code google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)
      com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.binaryauthorization.v1beta1.BinaryAuthorizationServiceProto.internal_static_google_cloud_binaryauthorization_v1beta1_UpdatePolicyRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.binaryauthorization.v1beta1.BinaryAuthorizationServiceProto.internal_static_google_cloud_binaryauthorization_v1beta1_UpdatePolicyRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.class, com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.Builder.class);
    }

    // Construct using com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.newBuilder()
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
      if (policyBuilder_ == null) {
        policy_ = null;
      } else {
        policy_ = null;
        policyBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.binaryauthorization.v1beta1.BinaryAuthorizationServiceProto.internal_static_google_cloud_binaryauthorization_v1beta1_UpdatePolicyRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest getDefaultInstanceForType() {
      return com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest build() {
      com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest buildPartial() {
      com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest result = new com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest(this);
      if (policyBuilder_ == null) {
        result.policy_ = policy_;
      } else {
        result.policy_ = policyBuilder_.build();
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
      if (other instanceof com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest) {
        return mergeFrom((com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest other) {
      if (other == com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest.getDefaultInstance()) return this;
      if (other.hasPolicy()) {
        mergePolicy(other.getPolicy());
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
      com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.cloud.binaryauthorization.v1beta1.Policy policy_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.binaryauthorization.v1beta1.Policy, com.google.cloud.binaryauthorization.v1beta1.Policy.Builder, com.google.cloud.binaryauthorization.v1beta1.PolicyOrBuilder> policyBuilder_;
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the policy field is set.
     */
    public boolean hasPolicy() {
      return policyBuilder_ != null || policy_ != null;
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The policy.
     */
    public com.google.cloud.binaryauthorization.v1beta1.Policy getPolicy() {
      if (policyBuilder_ == null) {
        return policy_ == null ? com.google.cloud.binaryauthorization.v1beta1.Policy.getDefaultInstance() : policy_;
      } else {
        return policyBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setPolicy(com.google.cloud.binaryauthorization.v1beta1.Policy value) {
      if (policyBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        policy_ = value;
        onChanged();
      } else {
        policyBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setPolicy(
        com.google.cloud.binaryauthorization.v1beta1.Policy.Builder builderForValue) {
      if (policyBuilder_ == null) {
        policy_ = builderForValue.build();
        onChanged();
      } else {
        policyBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergePolicy(com.google.cloud.binaryauthorization.v1beta1.Policy value) {
      if (policyBuilder_ == null) {
        if (policy_ != null) {
          policy_ =
            com.google.cloud.binaryauthorization.v1beta1.Policy.newBuilder(policy_).mergeFrom(value).buildPartial();
        } else {
          policy_ = value;
        }
        onChanged();
      } else {
        policyBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearPolicy() {
      if (policyBuilder_ == null) {
        policy_ = null;
        onChanged();
      } else {
        policy_ = null;
        policyBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.binaryauthorization.v1beta1.Policy.Builder getPolicyBuilder() {
      
      onChanged();
      return getPolicyFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.binaryauthorization.v1beta1.PolicyOrBuilder getPolicyOrBuilder() {
      if (policyBuilder_ != null) {
        return policyBuilder_.getMessageOrBuilder();
      } else {
        return policy_ == null ?
            com.google.cloud.binaryauthorization.v1beta1.Policy.getDefaultInstance() : policy_;
      }
    }
    /**
     * <pre>
     * Required. A new or updated
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The
     * service will overwrite the [policy
     * name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the
     * resource name in the request URL, in the format `projects/&#42;&#47;policy`.
     * </pre>
     *
     * <code>.google.cloud.binaryauthorization.v1beta1.Policy policy = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.binaryauthorization.v1beta1.Policy, com.google.cloud.binaryauthorization.v1beta1.Policy.Builder, com.google.cloud.binaryauthorization.v1beta1.PolicyOrBuilder> 
        getPolicyFieldBuilder() {
      if (policyBuilder_ == null) {
        policyBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.binaryauthorization.v1beta1.Policy, com.google.cloud.binaryauthorization.v1beta1.Policy.Builder, com.google.cloud.binaryauthorization.v1beta1.PolicyOrBuilder>(
                getPolicy(),
                getParentForChildren(),
                isClean());
        policy_ = null;
      }
      return policyBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest)
  private static final com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest();
  }

  public static com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<UpdatePolicyRequest>
      PARSER = new com.google.protobuf.AbstractParser<UpdatePolicyRequest>() {
    @java.lang.Override
    public UpdatePolicyRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new UpdatePolicyRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<UpdatePolicyRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<UpdatePolicyRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.binaryauthorization.v1beta1.UpdatePolicyRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

