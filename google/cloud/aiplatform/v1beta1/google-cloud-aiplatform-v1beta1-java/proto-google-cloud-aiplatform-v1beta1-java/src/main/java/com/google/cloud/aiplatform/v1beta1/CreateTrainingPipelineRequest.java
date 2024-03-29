// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/pipeline_service.proto

package com.google.cloud.aiplatform.v1beta1;

/**
 * <pre>
 * Request message for [PipelineService.CreateTrainingPipeline][google.cloud.aiplatform.v1beta1.PipelineService.CreateTrainingPipeline].
 * </pre>
 *
 * Protobuf type {@code google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest}
 */
public final class CreateTrainingPipelineRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)
    CreateTrainingPipelineRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CreateTrainingPipelineRequest.newBuilder() to construct.
  private CreateTrainingPipelineRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CreateTrainingPipelineRequest() {
    parent_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CreateTrainingPipelineRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CreateTrainingPipelineRequest(
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

            parent_ = s;
            break;
          }
          case 18: {
            com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder subBuilder = null;
            if (trainingPipeline_ != null) {
              subBuilder = trainingPipeline_.toBuilder();
            }
            trainingPipeline_ = input.readMessage(com.google.cloud.aiplatform.v1beta1.TrainingPipeline.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(trainingPipeline_);
              trainingPipeline_ = subBuilder.buildPartial();
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
    return com.google.cloud.aiplatform.v1beta1.PipelineServiceProto.internal_static_google_cloud_aiplatform_v1beta1_CreateTrainingPipelineRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.aiplatform.v1beta1.PipelineServiceProto.internal_static_google_cloud_aiplatform_v1beta1_CreateTrainingPipelineRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.class, com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.Builder.class);
  }

  public static final int PARENT_FIELD_NUMBER = 1;
  private volatile java.lang.Object parent_;
  /**
   * <pre>
   * Required. The resource name of the Location to create the TrainingPipeline in.
   * Format: `projects/{project}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  @java.lang.Override
  public java.lang.String getParent() {
    java.lang.Object ref = parent_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      parent_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. The resource name of the Location to create the TrainingPipeline in.
   * Format: `projects/{project}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getParentBytes() {
    java.lang.Object ref = parent_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      parent_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int TRAINING_PIPELINE_FIELD_NUMBER = 2;
  private com.google.cloud.aiplatform.v1beta1.TrainingPipeline trainingPipeline_;
  /**
   * <pre>
   * Required. The TrainingPipeline to create.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the trainingPipeline field is set.
   */
  @java.lang.Override
  public boolean hasTrainingPipeline() {
    return trainingPipeline_ != null;
  }
  /**
   * <pre>
   * Required. The TrainingPipeline to create.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The trainingPipeline.
   */
  @java.lang.Override
  public com.google.cloud.aiplatform.v1beta1.TrainingPipeline getTrainingPipeline() {
    return trainingPipeline_ == null ? com.google.cloud.aiplatform.v1beta1.TrainingPipeline.getDefaultInstance() : trainingPipeline_;
  }
  /**
   * <pre>
   * Required. The TrainingPipeline to create.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloud.aiplatform.v1beta1.TrainingPipelineOrBuilder getTrainingPipelineOrBuilder() {
    return getTrainingPipeline();
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(parent_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, parent_);
    }
    if (trainingPipeline_ != null) {
      output.writeMessage(2, getTrainingPipeline());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(parent_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, parent_);
    }
    if (trainingPipeline_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getTrainingPipeline());
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
    if (!(obj instanceof com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest other = (com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest) obj;

    if (!getParent()
        .equals(other.getParent())) return false;
    if (hasTrainingPipeline() != other.hasTrainingPipeline()) return false;
    if (hasTrainingPipeline()) {
      if (!getTrainingPipeline()
          .equals(other.getTrainingPipeline())) return false;
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
    hash = (37 * hash) + PARENT_FIELD_NUMBER;
    hash = (53 * hash) + getParent().hashCode();
    if (hasTrainingPipeline()) {
      hash = (37 * hash) + TRAINING_PIPELINE_FIELD_NUMBER;
      hash = (53 * hash) + getTrainingPipeline().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest prototype) {
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
   * Request message for [PipelineService.CreateTrainingPipeline][google.cloud.aiplatform.v1beta1.PipelineService.CreateTrainingPipeline].
   * </pre>
   *
   * Protobuf type {@code google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)
      com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.aiplatform.v1beta1.PipelineServiceProto.internal_static_google_cloud_aiplatform_v1beta1_CreateTrainingPipelineRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.aiplatform.v1beta1.PipelineServiceProto.internal_static_google_cloud_aiplatform_v1beta1_CreateTrainingPipelineRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.class, com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.Builder.class);
    }

    // Construct using com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.newBuilder()
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
      parent_ = "";

      if (trainingPipelineBuilder_ == null) {
        trainingPipeline_ = null;
      } else {
        trainingPipeline_ = null;
        trainingPipelineBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.aiplatform.v1beta1.PipelineServiceProto.internal_static_google_cloud_aiplatform_v1beta1_CreateTrainingPipelineRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest getDefaultInstanceForType() {
      return com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest build() {
      com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest buildPartial() {
      com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest result = new com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest(this);
      result.parent_ = parent_;
      if (trainingPipelineBuilder_ == null) {
        result.trainingPipeline_ = trainingPipeline_;
      } else {
        result.trainingPipeline_ = trainingPipelineBuilder_.build();
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
      if (other instanceof com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest) {
        return mergeFrom((com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest other) {
      if (other == com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest.getDefaultInstance()) return this;
      if (!other.getParent().isEmpty()) {
        parent_ = other.parent_;
        onChanged();
      }
      if (other.hasTrainingPipeline()) {
        mergeTrainingPipeline(other.getTrainingPipeline());
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
      com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object parent_ = "";
    /**
     * <pre>
     * Required. The resource name of the Location to create the TrainingPipeline in.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The parent.
     */
    public java.lang.String getParent() {
      java.lang.Object ref = parent_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        parent_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name of the Location to create the TrainingPipeline in.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The bytes for parent.
     */
    public com.google.protobuf.ByteString
        getParentBytes() {
      java.lang.Object ref = parent_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        parent_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name of the Location to create the TrainingPipeline in.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The parent to set.
     * @return This builder for chaining.
     */
    public Builder setParent(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      parent_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name of the Location to create the TrainingPipeline in.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return This builder for chaining.
     */
    public Builder clearParent() {
      
      parent_ = getDefaultInstance().getParent();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name of the Location to create the TrainingPipeline in.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @param value The bytes for parent to set.
     * @return This builder for chaining.
     */
    public Builder setParentBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      parent_ = value;
      onChanged();
      return this;
    }

    private com.google.cloud.aiplatform.v1beta1.TrainingPipeline trainingPipeline_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.aiplatform.v1beta1.TrainingPipeline, com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder, com.google.cloud.aiplatform.v1beta1.TrainingPipelineOrBuilder> trainingPipelineBuilder_;
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the trainingPipeline field is set.
     */
    public boolean hasTrainingPipeline() {
      return trainingPipelineBuilder_ != null || trainingPipeline_ != null;
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The trainingPipeline.
     */
    public com.google.cloud.aiplatform.v1beta1.TrainingPipeline getTrainingPipeline() {
      if (trainingPipelineBuilder_ == null) {
        return trainingPipeline_ == null ? com.google.cloud.aiplatform.v1beta1.TrainingPipeline.getDefaultInstance() : trainingPipeline_;
      } else {
        return trainingPipelineBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setTrainingPipeline(com.google.cloud.aiplatform.v1beta1.TrainingPipeline value) {
      if (trainingPipelineBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        trainingPipeline_ = value;
        onChanged();
      } else {
        trainingPipelineBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setTrainingPipeline(
        com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder builderForValue) {
      if (trainingPipelineBuilder_ == null) {
        trainingPipeline_ = builderForValue.build();
        onChanged();
      } else {
        trainingPipelineBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeTrainingPipeline(com.google.cloud.aiplatform.v1beta1.TrainingPipeline value) {
      if (trainingPipelineBuilder_ == null) {
        if (trainingPipeline_ != null) {
          trainingPipeline_ =
            com.google.cloud.aiplatform.v1beta1.TrainingPipeline.newBuilder(trainingPipeline_).mergeFrom(value).buildPartial();
        } else {
          trainingPipeline_ = value;
        }
        onChanged();
      } else {
        trainingPipelineBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearTrainingPipeline() {
      if (trainingPipelineBuilder_ == null) {
        trainingPipeline_ = null;
        onChanged();
      } else {
        trainingPipeline_ = null;
        trainingPipelineBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder getTrainingPipelineBuilder() {
      
      onChanged();
      return getTrainingPipelineFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.aiplatform.v1beta1.TrainingPipelineOrBuilder getTrainingPipelineOrBuilder() {
      if (trainingPipelineBuilder_ != null) {
        return trainingPipelineBuilder_.getMessageOrBuilder();
      } else {
        return trainingPipeline_ == null ?
            com.google.cloud.aiplatform.v1beta1.TrainingPipeline.getDefaultInstance() : trainingPipeline_;
      }
    }
    /**
     * <pre>
     * Required. The TrainingPipeline to create.
     * </pre>
     *
     * <code>.google.cloud.aiplatform.v1beta1.TrainingPipeline training_pipeline = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.aiplatform.v1beta1.TrainingPipeline, com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder, com.google.cloud.aiplatform.v1beta1.TrainingPipelineOrBuilder> 
        getTrainingPipelineFieldBuilder() {
      if (trainingPipelineBuilder_ == null) {
        trainingPipelineBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.aiplatform.v1beta1.TrainingPipeline, com.google.cloud.aiplatform.v1beta1.TrainingPipeline.Builder, com.google.cloud.aiplatform.v1beta1.TrainingPipelineOrBuilder>(
                getTrainingPipeline(),
                getParentForChildren(),
                isClean());
        trainingPipeline_ = null;
      }
      return trainingPipelineBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest)
  private static final com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest();
  }

  public static com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CreateTrainingPipelineRequest>
      PARSER = new com.google.protobuf.AbstractParser<CreateTrainingPipelineRequest>() {
    @java.lang.Override
    public CreateTrainingPipelineRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CreateTrainingPipelineRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CreateTrainingPipelineRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CreateTrainingPipelineRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.aiplatform.v1beta1.CreateTrainingPipelineRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

