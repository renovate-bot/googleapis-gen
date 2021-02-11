// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gsuiteaddons/v1/gsuiteaddons.proto

package com.google.cloud.gsuiteaddons.v1;

/**
 * <pre>
 * Request message to create or replace a deployment.
 * </pre>
 *
 * Protobuf type {@code google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest}
 */
public final class ReplaceDeploymentRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)
    ReplaceDeploymentRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ReplaceDeploymentRequest.newBuilder() to construct.
  private ReplaceDeploymentRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ReplaceDeploymentRequest() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ReplaceDeploymentRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ReplaceDeploymentRequest(
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
            com.google.cloud.gsuiteaddons.v1.Deployment.Builder subBuilder = null;
            if (deployment_ != null) {
              subBuilder = deployment_.toBuilder();
            }
            deployment_ = input.readMessage(com.google.cloud.gsuiteaddons.v1.Deployment.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(deployment_);
              deployment_ = subBuilder.buildPartial();
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
    return com.google.cloud.gsuiteaddons.v1.GSuiteAddOnsProto.internal_static_google_cloud_gsuiteaddons_v1_ReplaceDeploymentRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.gsuiteaddons.v1.GSuiteAddOnsProto.internal_static_google_cloud_gsuiteaddons_v1_ReplaceDeploymentRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.class, com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.Builder.class);
  }

  public static final int DEPLOYMENT_FIELD_NUMBER = 2;
  private com.google.cloud.gsuiteaddons.v1.Deployment deployment_;
  /**
   * <pre>
   * Required. The deployment to create or replace.
   * </pre>
   *
   * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the deployment field is set.
   */
  @java.lang.Override
  public boolean hasDeployment() {
    return deployment_ != null;
  }
  /**
   * <pre>
   * Required. The deployment to create or replace.
   * </pre>
   *
   * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The deployment.
   */
  @java.lang.Override
  public com.google.cloud.gsuiteaddons.v1.Deployment getDeployment() {
    return deployment_ == null ? com.google.cloud.gsuiteaddons.v1.Deployment.getDefaultInstance() : deployment_;
  }
  /**
   * <pre>
   * Required. The deployment to create or replace.
   * </pre>
   *
   * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloud.gsuiteaddons.v1.DeploymentOrBuilder getDeploymentOrBuilder() {
    return getDeployment();
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
    if (deployment_ != null) {
      output.writeMessage(2, getDeployment());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (deployment_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getDeployment());
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
    if (!(obj instanceof com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest other = (com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest) obj;

    if (hasDeployment() != other.hasDeployment()) return false;
    if (hasDeployment()) {
      if (!getDeployment()
          .equals(other.getDeployment())) return false;
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
    if (hasDeployment()) {
      hash = (37 * hash) + DEPLOYMENT_FIELD_NUMBER;
      hash = (53 * hash) + getDeployment().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest prototype) {
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
   * Request message to create or replace a deployment.
   * </pre>
   *
   * Protobuf type {@code google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)
      com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.gsuiteaddons.v1.GSuiteAddOnsProto.internal_static_google_cloud_gsuiteaddons_v1_ReplaceDeploymentRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.gsuiteaddons.v1.GSuiteAddOnsProto.internal_static_google_cloud_gsuiteaddons_v1_ReplaceDeploymentRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.class, com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.Builder.class);
    }

    // Construct using com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.newBuilder()
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
      if (deploymentBuilder_ == null) {
        deployment_ = null;
      } else {
        deployment_ = null;
        deploymentBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.gsuiteaddons.v1.GSuiteAddOnsProto.internal_static_google_cloud_gsuiteaddons_v1_ReplaceDeploymentRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest getDefaultInstanceForType() {
      return com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest build() {
      com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest buildPartial() {
      com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest result = new com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest(this);
      if (deploymentBuilder_ == null) {
        result.deployment_ = deployment_;
      } else {
        result.deployment_ = deploymentBuilder_.build();
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
      if (other instanceof com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest) {
        return mergeFrom((com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest other) {
      if (other == com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest.getDefaultInstance()) return this;
      if (other.hasDeployment()) {
        mergeDeployment(other.getDeployment());
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
      com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.cloud.gsuiteaddons.v1.Deployment deployment_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.gsuiteaddons.v1.Deployment, com.google.cloud.gsuiteaddons.v1.Deployment.Builder, com.google.cloud.gsuiteaddons.v1.DeploymentOrBuilder> deploymentBuilder_;
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the deployment field is set.
     */
    public boolean hasDeployment() {
      return deploymentBuilder_ != null || deployment_ != null;
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The deployment.
     */
    public com.google.cloud.gsuiteaddons.v1.Deployment getDeployment() {
      if (deploymentBuilder_ == null) {
        return deployment_ == null ? com.google.cloud.gsuiteaddons.v1.Deployment.getDefaultInstance() : deployment_;
      } else {
        return deploymentBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setDeployment(com.google.cloud.gsuiteaddons.v1.Deployment value) {
      if (deploymentBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        deployment_ = value;
        onChanged();
      } else {
        deploymentBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setDeployment(
        com.google.cloud.gsuiteaddons.v1.Deployment.Builder builderForValue) {
      if (deploymentBuilder_ == null) {
        deployment_ = builderForValue.build();
        onChanged();
      } else {
        deploymentBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeDeployment(com.google.cloud.gsuiteaddons.v1.Deployment value) {
      if (deploymentBuilder_ == null) {
        if (deployment_ != null) {
          deployment_ =
            com.google.cloud.gsuiteaddons.v1.Deployment.newBuilder(deployment_).mergeFrom(value).buildPartial();
        } else {
          deployment_ = value;
        }
        onChanged();
      } else {
        deploymentBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearDeployment() {
      if (deploymentBuilder_ == null) {
        deployment_ = null;
        onChanged();
      } else {
        deployment_ = null;
        deploymentBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.gsuiteaddons.v1.Deployment.Builder getDeploymentBuilder() {
      
      onChanged();
      return getDeploymentFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.gsuiteaddons.v1.DeploymentOrBuilder getDeploymentOrBuilder() {
      if (deploymentBuilder_ != null) {
        return deploymentBuilder_.getMessageOrBuilder();
      } else {
        return deployment_ == null ?
            com.google.cloud.gsuiteaddons.v1.Deployment.getDefaultInstance() : deployment_;
      }
    }
    /**
     * <pre>
     * Required. The deployment to create or replace.
     * </pre>
     *
     * <code>.google.cloud.gsuiteaddons.v1.Deployment deployment = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.gsuiteaddons.v1.Deployment, com.google.cloud.gsuiteaddons.v1.Deployment.Builder, com.google.cloud.gsuiteaddons.v1.DeploymentOrBuilder> 
        getDeploymentFieldBuilder() {
      if (deploymentBuilder_ == null) {
        deploymentBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.gsuiteaddons.v1.Deployment, com.google.cloud.gsuiteaddons.v1.Deployment.Builder, com.google.cloud.gsuiteaddons.v1.DeploymentOrBuilder>(
                getDeployment(),
                getParentForChildren(),
                isClean());
        deployment_ = null;
      }
      return deploymentBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest)
  private static final com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest();
  }

  public static com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ReplaceDeploymentRequest>
      PARSER = new com.google.protobuf.AbstractParser<ReplaceDeploymentRequest>() {
    @java.lang.Override
    public ReplaceDeploymentRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ReplaceDeploymentRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ReplaceDeploymentRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ReplaceDeploymentRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.gsuiteaddons.v1.ReplaceDeploymentRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

