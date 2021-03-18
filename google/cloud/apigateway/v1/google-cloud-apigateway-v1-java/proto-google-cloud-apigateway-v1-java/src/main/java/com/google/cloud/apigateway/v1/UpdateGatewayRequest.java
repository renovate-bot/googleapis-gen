// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/apigateway/v1/apigateway.proto

package com.google.cloud.apigateway.v1;

/**
 * <pre>
 * Request message for ApiGatewayService.UpdateGateway
 * </pre>
 *
 * Protobuf type {@code google.cloud.apigateway.v1.UpdateGatewayRequest}
 */
public final class UpdateGatewayRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.apigateway.v1.UpdateGatewayRequest)
    UpdateGatewayRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use UpdateGatewayRequest.newBuilder() to construct.
  private UpdateGatewayRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private UpdateGatewayRequest() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new UpdateGatewayRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private UpdateGatewayRequest(
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
            com.google.protobuf.FieldMask.Builder subBuilder = null;
            if (updateMask_ != null) {
              subBuilder = updateMask_.toBuilder();
            }
            updateMask_ = input.readMessage(com.google.protobuf.FieldMask.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(updateMask_);
              updateMask_ = subBuilder.buildPartial();
            }

            break;
          }
          case 18: {
            com.google.cloud.apigateway.v1.Gateway.Builder subBuilder = null;
            if (gateway_ != null) {
              subBuilder = gateway_.toBuilder();
            }
            gateway_ = input.readMessage(com.google.cloud.apigateway.v1.Gateway.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(gateway_);
              gateway_ = subBuilder.buildPartial();
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
    return com.google.cloud.apigateway.v1.Apigateway.internal_static_google_cloud_apigateway_v1_UpdateGatewayRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.apigateway.v1.Apigateway.internal_static_google_cloud_apigateway_v1_UpdateGatewayRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.apigateway.v1.UpdateGatewayRequest.class, com.google.cloud.apigateway.v1.UpdateGatewayRequest.Builder.class);
  }

  public static final int UPDATE_MASK_FIELD_NUMBER = 1;
  private com.google.protobuf.FieldMask updateMask_;
  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Gateway resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   * @return Whether the updateMask field is set.
   */
  @java.lang.Override
  public boolean hasUpdateMask() {
    return updateMask_ != null;
  }
  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Gateway resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   * @return The updateMask.
   */
  @java.lang.Override
  public com.google.protobuf.FieldMask getUpdateMask() {
    return updateMask_ == null ? com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
  }
  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Gateway resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   */
  @java.lang.Override
  public com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder() {
    return getUpdateMask();
  }

  public static final int GATEWAY_FIELD_NUMBER = 2;
  private com.google.cloud.apigateway.v1.Gateway gateway_;
  /**
   * <pre>
   * Required. Gateway resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the gateway field is set.
   */
  @java.lang.Override
  public boolean hasGateway() {
    return gateway_ != null;
  }
  /**
   * <pre>
   * Required. Gateway resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The gateway.
   */
  @java.lang.Override
  public com.google.cloud.apigateway.v1.Gateway getGateway() {
    return gateway_ == null ? com.google.cloud.apigateway.v1.Gateway.getDefaultInstance() : gateway_;
  }
  /**
   * <pre>
   * Required. Gateway resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloud.apigateway.v1.GatewayOrBuilder getGatewayOrBuilder() {
    return getGateway();
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
    if (updateMask_ != null) {
      output.writeMessage(1, getUpdateMask());
    }
    if (gateway_ != null) {
      output.writeMessage(2, getGateway());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (updateMask_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getUpdateMask());
    }
    if (gateway_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getGateway());
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
    if (!(obj instanceof com.google.cloud.apigateway.v1.UpdateGatewayRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.apigateway.v1.UpdateGatewayRequest other = (com.google.cloud.apigateway.v1.UpdateGatewayRequest) obj;

    if (hasUpdateMask() != other.hasUpdateMask()) return false;
    if (hasUpdateMask()) {
      if (!getUpdateMask()
          .equals(other.getUpdateMask())) return false;
    }
    if (hasGateway() != other.hasGateway()) return false;
    if (hasGateway()) {
      if (!getGateway()
          .equals(other.getGateway())) return false;
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
    if (hasUpdateMask()) {
      hash = (37 * hash) + UPDATE_MASK_FIELD_NUMBER;
      hash = (53 * hash) + getUpdateMask().hashCode();
    }
    if (hasGateway()) {
      hash = (37 * hash) + GATEWAY_FIELD_NUMBER;
      hash = (53 * hash) + getGateway().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.apigateway.v1.UpdateGatewayRequest prototype) {
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
   * Request message for ApiGatewayService.UpdateGateway
   * </pre>
   *
   * Protobuf type {@code google.cloud.apigateway.v1.UpdateGatewayRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.apigateway.v1.UpdateGatewayRequest)
      com.google.cloud.apigateway.v1.UpdateGatewayRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.apigateway.v1.Apigateway.internal_static_google_cloud_apigateway_v1_UpdateGatewayRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.apigateway.v1.Apigateway.internal_static_google_cloud_apigateway_v1_UpdateGatewayRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.apigateway.v1.UpdateGatewayRequest.class, com.google.cloud.apigateway.v1.UpdateGatewayRequest.Builder.class);
    }

    // Construct using com.google.cloud.apigateway.v1.UpdateGatewayRequest.newBuilder()
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
      if (updateMaskBuilder_ == null) {
        updateMask_ = null;
      } else {
        updateMask_ = null;
        updateMaskBuilder_ = null;
      }
      if (gatewayBuilder_ == null) {
        gateway_ = null;
      } else {
        gateway_ = null;
        gatewayBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.apigateway.v1.Apigateway.internal_static_google_cloud_apigateway_v1_UpdateGatewayRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.apigateway.v1.UpdateGatewayRequest getDefaultInstanceForType() {
      return com.google.cloud.apigateway.v1.UpdateGatewayRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.apigateway.v1.UpdateGatewayRequest build() {
      com.google.cloud.apigateway.v1.UpdateGatewayRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.apigateway.v1.UpdateGatewayRequest buildPartial() {
      com.google.cloud.apigateway.v1.UpdateGatewayRequest result = new com.google.cloud.apigateway.v1.UpdateGatewayRequest(this);
      if (updateMaskBuilder_ == null) {
        result.updateMask_ = updateMask_;
      } else {
        result.updateMask_ = updateMaskBuilder_.build();
      }
      if (gatewayBuilder_ == null) {
        result.gateway_ = gateway_;
      } else {
        result.gateway_ = gatewayBuilder_.build();
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
      if (other instanceof com.google.cloud.apigateway.v1.UpdateGatewayRequest) {
        return mergeFrom((com.google.cloud.apigateway.v1.UpdateGatewayRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.apigateway.v1.UpdateGatewayRequest other) {
      if (other == com.google.cloud.apigateway.v1.UpdateGatewayRequest.getDefaultInstance()) return this;
      if (other.hasUpdateMask()) {
        mergeUpdateMask(other.getUpdateMask());
      }
      if (other.hasGateway()) {
        mergeGateway(other.getGateway());
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
      com.google.cloud.apigateway.v1.UpdateGatewayRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.apigateway.v1.UpdateGatewayRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.protobuf.FieldMask updateMask_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder> updateMaskBuilder_;
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     * @return Whether the updateMask field is set.
     */
    public boolean hasUpdateMask() {
      return updateMaskBuilder_ != null || updateMask_ != null;
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     * @return The updateMask.
     */
    public com.google.protobuf.FieldMask getUpdateMask() {
      if (updateMaskBuilder_ == null) {
        return updateMask_ == null ? com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
      } else {
        return updateMaskBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public Builder setUpdateMask(com.google.protobuf.FieldMask value) {
      if (updateMaskBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        updateMask_ = value;
        onChanged();
      } else {
        updateMaskBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public Builder setUpdateMask(
        com.google.protobuf.FieldMask.Builder builderForValue) {
      if (updateMaskBuilder_ == null) {
        updateMask_ = builderForValue.build();
        onChanged();
      } else {
        updateMaskBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public Builder mergeUpdateMask(com.google.protobuf.FieldMask value) {
      if (updateMaskBuilder_ == null) {
        if (updateMask_ != null) {
          updateMask_ =
            com.google.protobuf.FieldMask.newBuilder(updateMask_).mergeFrom(value).buildPartial();
        } else {
          updateMask_ = value;
        }
        onChanged();
      } else {
        updateMaskBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public Builder clearUpdateMask() {
      if (updateMaskBuilder_ == null) {
        updateMask_ = null;
        onChanged();
      } else {
        updateMask_ = null;
        updateMaskBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public com.google.protobuf.FieldMask.Builder getUpdateMaskBuilder() {
      
      onChanged();
      return getUpdateMaskFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    public com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder() {
      if (updateMaskBuilder_ != null) {
        return updateMaskBuilder_.getMessageOrBuilder();
      } else {
        return updateMask_ == null ?
            com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
      }
    }
    /**
     * <pre>
     * Field mask is used to specify the fields to be overwritten in the
     * Gateway resource by the update.
     * The fields specified in the update_mask are relative to the resource, not
     * the full request. A field will be overwritten if it is in the mask. If the
     * user does not provide a mask then all fields will be overwritten.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder> 
        getUpdateMaskFieldBuilder() {
      if (updateMaskBuilder_ == null) {
        updateMaskBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder>(
                getUpdateMask(),
                getParentForChildren(),
                isClean());
        updateMask_ = null;
      }
      return updateMaskBuilder_;
    }

    private com.google.cloud.apigateway.v1.Gateway gateway_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.apigateway.v1.Gateway, com.google.cloud.apigateway.v1.Gateway.Builder, com.google.cloud.apigateway.v1.GatewayOrBuilder> gatewayBuilder_;
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the gateway field is set.
     */
    public boolean hasGateway() {
      return gatewayBuilder_ != null || gateway_ != null;
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The gateway.
     */
    public com.google.cloud.apigateway.v1.Gateway getGateway() {
      if (gatewayBuilder_ == null) {
        return gateway_ == null ? com.google.cloud.apigateway.v1.Gateway.getDefaultInstance() : gateway_;
      } else {
        return gatewayBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setGateway(com.google.cloud.apigateway.v1.Gateway value) {
      if (gatewayBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        gateway_ = value;
        onChanged();
      } else {
        gatewayBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setGateway(
        com.google.cloud.apigateway.v1.Gateway.Builder builderForValue) {
      if (gatewayBuilder_ == null) {
        gateway_ = builderForValue.build();
        onChanged();
      } else {
        gatewayBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeGateway(com.google.cloud.apigateway.v1.Gateway value) {
      if (gatewayBuilder_ == null) {
        if (gateway_ != null) {
          gateway_ =
            com.google.cloud.apigateway.v1.Gateway.newBuilder(gateway_).mergeFrom(value).buildPartial();
        } else {
          gateway_ = value;
        }
        onChanged();
      } else {
        gatewayBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearGateway() {
      if (gatewayBuilder_ == null) {
        gateway_ = null;
        onChanged();
      } else {
        gateway_ = null;
        gatewayBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.apigateway.v1.Gateway.Builder getGatewayBuilder() {
      
      onChanged();
      return getGatewayFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.apigateway.v1.GatewayOrBuilder getGatewayOrBuilder() {
      if (gatewayBuilder_ != null) {
        return gatewayBuilder_.getMessageOrBuilder();
      } else {
        return gateway_ == null ?
            com.google.cloud.apigateway.v1.Gateway.getDefaultInstance() : gateway_;
      }
    }
    /**
     * <pre>
     * Required. Gateway resource.
     * </pre>
     *
     * <code>.google.cloud.apigateway.v1.Gateway gateway = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.apigateway.v1.Gateway, com.google.cloud.apigateway.v1.Gateway.Builder, com.google.cloud.apigateway.v1.GatewayOrBuilder> 
        getGatewayFieldBuilder() {
      if (gatewayBuilder_ == null) {
        gatewayBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.apigateway.v1.Gateway, com.google.cloud.apigateway.v1.Gateway.Builder, com.google.cloud.apigateway.v1.GatewayOrBuilder>(
                getGateway(),
                getParentForChildren(),
                isClean());
        gateway_ = null;
      }
      return gatewayBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.apigateway.v1.UpdateGatewayRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.apigateway.v1.UpdateGatewayRequest)
  private static final com.google.cloud.apigateway.v1.UpdateGatewayRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.apigateway.v1.UpdateGatewayRequest();
  }

  public static com.google.cloud.apigateway.v1.UpdateGatewayRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<UpdateGatewayRequest>
      PARSER = new com.google.protobuf.AbstractParser<UpdateGatewayRequest>() {
    @java.lang.Override
    public UpdateGatewayRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new UpdateGatewayRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<UpdateGatewayRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<UpdateGatewayRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.apigateway.v1.UpdateGatewayRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

