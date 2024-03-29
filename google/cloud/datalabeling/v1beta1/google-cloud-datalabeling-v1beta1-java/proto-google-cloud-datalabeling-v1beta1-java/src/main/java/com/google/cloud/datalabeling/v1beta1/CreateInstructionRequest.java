// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datalabeling/v1beta1/data_labeling_service.proto

package com.google.cloud.datalabeling.v1beta1;

/**
 * <pre>
 * Request message for CreateInstruction.
 * </pre>
 *
 * Protobuf type {@code google.cloud.datalabeling.v1beta1.CreateInstructionRequest}
 */
public final class CreateInstructionRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.datalabeling.v1beta1.CreateInstructionRequest)
    CreateInstructionRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CreateInstructionRequest.newBuilder() to construct.
  private CreateInstructionRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CreateInstructionRequest() {
    parent_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CreateInstructionRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CreateInstructionRequest(
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
            com.google.cloud.datalabeling.v1beta1.Instruction.Builder subBuilder = null;
            if (instruction_ != null) {
              subBuilder = instruction_.toBuilder();
            }
            instruction_ = input.readMessage(com.google.cloud.datalabeling.v1beta1.Instruction.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(instruction_);
              instruction_ = subBuilder.buildPartial();
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
    return com.google.cloud.datalabeling.v1beta1.DataLabelingServiceOuterClass.internal_static_google_cloud_datalabeling_v1beta1_CreateInstructionRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.datalabeling.v1beta1.DataLabelingServiceOuterClass.internal_static_google_cloud_datalabeling_v1beta1_CreateInstructionRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.class, com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.Builder.class);
  }

  public static final int PARENT_FIELD_NUMBER = 1;
  private volatile java.lang.Object parent_;
  /**
   * <pre>
   * Required. Instruction resource parent, format:
   * projects/{project_id}
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
   * Required. Instruction resource parent, format:
   * projects/{project_id}
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

  public static final int INSTRUCTION_FIELD_NUMBER = 2;
  private com.google.cloud.datalabeling.v1beta1.Instruction instruction_;
  /**
   * <pre>
   * Required. Instruction of how to perform the labeling task.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the instruction field is set.
   */
  @java.lang.Override
  public boolean hasInstruction() {
    return instruction_ != null;
  }
  /**
   * <pre>
   * Required. Instruction of how to perform the labeling task.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The instruction.
   */
  @java.lang.Override
  public com.google.cloud.datalabeling.v1beta1.Instruction getInstruction() {
    return instruction_ == null ? com.google.cloud.datalabeling.v1beta1.Instruction.getDefaultInstance() : instruction_;
  }
  /**
   * <pre>
   * Required. Instruction of how to perform the labeling task.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloud.datalabeling.v1beta1.InstructionOrBuilder getInstructionOrBuilder() {
    return getInstruction();
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
    if (instruction_ != null) {
      output.writeMessage(2, getInstruction());
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
    if (instruction_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getInstruction());
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
    if (!(obj instanceof com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest other = (com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest) obj;

    if (!getParent()
        .equals(other.getParent())) return false;
    if (hasInstruction() != other.hasInstruction()) return false;
    if (hasInstruction()) {
      if (!getInstruction()
          .equals(other.getInstruction())) return false;
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
    if (hasInstruction()) {
      hash = (37 * hash) + INSTRUCTION_FIELD_NUMBER;
      hash = (53 * hash) + getInstruction().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest prototype) {
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
   * Request message for CreateInstruction.
   * </pre>
   *
   * Protobuf type {@code google.cloud.datalabeling.v1beta1.CreateInstructionRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.datalabeling.v1beta1.CreateInstructionRequest)
      com.google.cloud.datalabeling.v1beta1.CreateInstructionRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.datalabeling.v1beta1.DataLabelingServiceOuterClass.internal_static_google_cloud_datalabeling_v1beta1_CreateInstructionRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.datalabeling.v1beta1.DataLabelingServiceOuterClass.internal_static_google_cloud_datalabeling_v1beta1_CreateInstructionRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.class, com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.Builder.class);
    }

    // Construct using com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.newBuilder()
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

      if (instructionBuilder_ == null) {
        instruction_ = null;
      } else {
        instruction_ = null;
        instructionBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.datalabeling.v1beta1.DataLabelingServiceOuterClass.internal_static_google_cloud_datalabeling_v1beta1_CreateInstructionRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest getDefaultInstanceForType() {
      return com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest build() {
      com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest buildPartial() {
      com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest result = new com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest(this);
      result.parent_ = parent_;
      if (instructionBuilder_ == null) {
        result.instruction_ = instruction_;
      } else {
        result.instruction_ = instructionBuilder_.build();
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
      if (other instanceof com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest) {
        return mergeFrom((com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest other) {
      if (other == com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest.getDefaultInstance()) return this;
      if (!other.getParent().isEmpty()) {
        parent_ = other.parent_;
        onChanged();
      }
      if (other.hasInstruction()) {
        mergeInstruction(other.getInstruction());
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
      com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest) e.getUnfinishedMessage();
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
     * Required. Instruction resource parent, format:
     * projects/{project_id}
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
     * Required. Instruction resource parent, format:
     * projects/{project_id}
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
     * Required. Instruction resource parent, format:
     * projects/{project_id}
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
     * Required. Instruction resource parent, format:
     * projects/{project_id}
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
     * Required. Instruction resource parent, format:
     * projects/{project_id}
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

    private com.google.cloud.datalabeling.v1beta1.Instruction instruction_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.datalabeling.v1beta1.Instruction, com.google.cloud.datalabeling.v1beta1.Instruction.Builder, com.google.cloud.datalabeling.v1beta1.InstructionOrBuilder> instructionBuilder_;
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the instruction field is set.
     */
    public boolean hasInstruction() {
      return instructionBuilder_ != null || instruction_ != null;
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The instruction.
     */
    public com.google.cloud.datalabeling.v1beta1.Instruction getInstruction() {
      if (instructionBuilder_ == null) {
        return instruction_ == null ? com.google.cloud.datalabeling.v1beta1.Instruction.getDefaultInstance() : instruction_;
      } else {
        return instructionBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setInstruction(com.google.cloud.datalabeling.v1beta1.Instruction value) {
      if (instructionBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        instruction_ = value;
        onChanged();
      } else {
        instructionBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setInstruction(
        com.google.cloud.datalabeling.v1beta1.Instruction.Builder builderForValue) {
      if (instructionBuilder_ == null) {
        instruction_ = builderForValue.build();
        onChanged();
      } else {
        instructionBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeInstruction(com.google.cloud.datalabeling.v1beta1.Instruction value) {
      if (instructionBuilder_ == null) {
        if (instruction_ != null) {
          instruction_ =
            com.google.cloud.datalabeling.v1beta1.Instruction.newBuilder(instruction_).mergeFrom(value).buildPartial();
        } else {
          instruction_ = value;
        }
        onChanged();
      } else {
        instructionBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearInstruction() {
      if (instructionBuilder_ == null) {
        instruction_ = null;
        onChanged();
      } else {
        instruction_ = null;
        instructionBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.datalabeling.v1beta1.Instruction.Builder getInstructionBuilder() {
      
      onChanged();
      return getInstructionFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloud.datalabeling.v1beta1.InstructionOrBuilder getInstructionOrBuilder() {
      if (instructionBuilder_ != null) {
        return instructionBuilder_.getMessageOrBuilder();
      } else {
        return instruction_ == null ?
            com.google.cloud.datalabeling.v1beta1.Instruction.getDefaultInstance() : instruction_;
      }
    }
    /**
     * <pre>
     * Required. Instruction of how to perform the labeling task.
     * </pre>
     *
     * <code>.google.cloud.datalabeling.v1beta1.Instruction instruction = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.datalabeling.v1beta1.Instruction, com.google.cloud.datalabeling.v1beta1.Instruction.Builder, com.google.cloud.datalabeling.v1beta1.InstructionOrBuilder> 
        getInstructionFieldBuilder() {
      if (instructionBuilder_ == null) {
        instructionBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.datalabeling.v1beta1.Instruction, com.google.cloud.datalabeling.v1beta1.Instruction.Builder, com.google.cloud.datalabeling.v1beta1.InstructionOrBuilder>(
                getInstruction(),
                getParentForChildren(),
                isClean());
        instruction_ = null;
      }
      return instructionBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.datalabeling.v1beta1.CreateInstructionRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.datalabeling.v1beta1.CreateInstructionRequest)
  private static final com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest();
  }

  public static com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CreateInstructionRequest>
      PARSER = new com.google.protobuf.AbstractParser<CreateInstructionRequest>() {
    @java.lang.Override
    public CreateInstructionRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CreateInstructionRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CreateInstructionRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CreateInstructionRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.datalabeling.v1beta1.CreateInstructionRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

