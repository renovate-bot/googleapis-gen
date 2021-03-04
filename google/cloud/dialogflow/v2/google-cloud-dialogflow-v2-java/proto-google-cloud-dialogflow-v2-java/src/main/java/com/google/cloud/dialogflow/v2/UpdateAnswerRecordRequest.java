// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/answer_record.proto

package com.google.cloud.dialogflow.v2;

/**
 * <pre>
 * Request message for [AnswerRecords.UpdateAnswerRecord][google.cloud.dialogflow.v2.AnswerRecords.UpdateAnswerRecord].
 * </pre>
 *
 * Protobuf type {@code google.cloud.dialogflow.v2.UpdateAnswerRecordRequest}
 */
public final class UpdateAnswerRecordRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)
    UpdateAnswerRecordRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use UpdateAnswerRecordRequest.newBuilder() to construct.
  private UpdateAnswerRecordRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private UpdateAnswerRecordRequest() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new UpdateAnswerRecordRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private UpdateAnswerRecordRequest(
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
            com.google.cloud.dialogflow.v2.AnswerRecord.Builder subBuilder = null;
            if (answerRecord_ != null) {
              subBuilder = answerRecord_.toBuilder();
            }
            answerRecord_ = input.readMessage(com.google.cloud.dialogflow.v2.AnswerRecord.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(answerRecord_);
              answerRecord_ = subBuilder.buildPartial();
            }

            break;
          }
          case 18: {
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
    return com.google.cloud.dialogflow.v2.AnswerRecordsProto.internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dialogflow.v2.AnswerRecordsProto.internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.class, com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.Builder.class);
  }

  public static final int ANSWER_RECORD_FIELD_NUMBER = 1;
  private com.google.cloud.dialogflow.v2.AnswerRecord answerRecord_;
  /**
   * <pre>
   * Required. Answer record to update.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return Whether the answerRecord field is set.
   */
  @java.lang.Override
  public boolean hasAnswerRecord() {
    return answerRecord_ != null;
  }
  /**
   * <pre>
   * Required. Answer record to update.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The answerRecord.
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.AnswerRecord getAnswerRecord() {
    return answerRecord_ == null ? com.google.cloud.dialogflow.v2.AnswerRecord.getDefaultInstance() : answerRecord_;
  }
  /**
   * <pre>
   * Required. Answer record to update.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.AnswerRecordOrBuilder getAnswerRecordOrBuilder() {
    return getAnswerRecord();
  }

  public static final int UPDATE_MASK_FIELD_NUMBER = 2;
  private com.google.protobuf.FieldMask updateMask_;
  /**
   * <pre>
   * Required. The mask to control which fields get updated.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the updateMask field is set.
   */
  @java.lang.Override
  public boolean hasUpdateMask() {
    return updateMask_ != null;
  }
  /**
   * <pre>
   * Required. The mask to control which fields get updated.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The updateMask.
   */
  @java.lang.Override
  public com.google.protobuf.FieldMask getUpdateMask() {
    return updateMask_ == null ? com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
  }
  /**
   * <pre>
   * Required. The mask to control which fields get updated.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder() {
    return getUpdateMask();
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
    if (answerRecord_ != null) {
      output.writeMessage(1, getAnswerRecord());
    }
    if (updateMask_ != null) {
      output.writeMessage(2, getUpdateMask());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (answerRecord_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getAnswerRecord());
    }
    if (updateMask_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getUpdateMask());
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
    if (!(obj instanceof com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest other = (com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest) obj;

    if (hasAnswerRecord() != other.hasAnswerRecord()) return false;
    if (hasAnswerRecord()) {
      if (!getAnswerRecord()
          .equals(other.getAnswerRecord())) return false;
    }
    if (hasUpdateMask() != other.hasUpdateMask()) return false;
    if (hasUpdateMask()) {
      if (!getUpdateMask()
          .equals(other.getUpdateMask())) return false;
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
    if (hasAnswerRecord()) {
      hash = (37 * hash) + ANSWER_RECORD_FIELD_NUMBER;
      hash = (53 * hash) + getAnswerRecord().hashCode();
    }
    if (hasUpdateMask()) {
      hash = (37 * hash) + UPDATE_MASK_FIELD_NUMBER;
      hash = (53 * hash) + getUpdateMask().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest prototype) {
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
   * Request message for [AnswerRecords.UpdateAnswerRecord][google.cloud.dialogflow.v2.AnswerRecords.UpdateAnswerRecord].
   * </pre>
   *
   * Protobuf type {@code google.cloud.dialogflow.v2.UpdateAnswerRecordRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)
      com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dialogflow.v2.AnswerRecordsProto.internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dialogflow.v2.AnswerRecordsProto.internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.class, com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.Builder.class);
    }

    // Construct using com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.newBuilder()
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
      if (answerRecordBuilder_ == null) {
        answerRecord_ = null;
      } else {
        answerRecord_ = null;
        answerRecordBuilder_ = null;
      }
      if (updateMaskBuilder_ == null) {
        updateMask_ = null;
      } else {
        updateMask_ = null;
        updateMaskBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dialogflow.v2.AnswerRecordsProto.internal_static_google_cloud_dialogflow_v2_UpdateAnswerRecordRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest getDefaultInstanceForType() {
      return com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest build() {
      com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest buildPartial() {
      com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest result = new com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest(this);
      if (answerRecordBuilder_ == null) {
        result.answerRecord_ = answerRecord_;
      } else {
        result.answerRecord_ = answerRecordBuilder_.build();
      }
      if (updateMaskBuilder_ == null) {
        result.updateMask_ = updateMask_;
      } else {
        result.updateMask_ = updateMaskBuilder_.build();
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
      if (other instanceof com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest) {
        return mergeFrom((com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest other) {
      if (other == com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest.getDefaultInstance()) return this;
      if (other.hasAnswerRecord()) {
        mergeAnswerRecord(other.getAnswerRecord());
      }
      if (other.hasUpdateMask()) {
        mergeUpdateMask(other.getUpdateMask());
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
      com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.cloud.dialogflow.v2.AnswerRecord answerRecord_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.dialogflow.v2.AnswerRecord, com.google.cloud.dialogflow.v2.AnswerRecord.Builder, com.google.cloud.dialogflow.v2.AnswerRecordOrBuilder> answerRecordBuilder_;
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return Whether the answerRecord field is set.
     */
    public boolean hasAnswerRecord() {
      return answerRecordBuilder_ != null || answerRecord_ != null;
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     * @return The answerRecord.
     */
    public com.google.cloud.dialogflow.v2.AnswerRecord getAnswerRecord() {
      if (answerRecordBuilder_ == null) {
        return answerRecord_ == null ? com.google.cloud.dialogflow.v2.AnswerRecord.getDefaultInstance() : answerRecord_;
      } else {
        return answerRecordBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public Builder setAnswerRecord(com.google.cloud.dialogflow.v2.AnswerRecord value) {
      if (answerRecordBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        answerRecord_ = value;
        onChanged();
      } else {
        answerRecordBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public Builder setAnswerRecord(
        com.google.cloud.dialogflow.v2.AnswerRecord.Builder builderForValue) {
      if (answerRecordBuilder_ == null) {
        answerRecord_ = builderForValue.build();
        onChanged();
      } else {
        answerRecordBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public Builder mergeAnswerRecord(com.google.cloud.dialogflow.v2.AnswerRecord value) {
      if (answerRecordBuilder_ == null) {
        if (answerRecord_ != null) {
          answerRecord_ =
            com.google.cloud.dialogflow.v2.AnswerRecord.newBuilder(answerRecord_).mergeFrom(value).buildPartial();
        } else {
          answerRecord_ = value;
        }
        onChanged();
      } else {
        answerRecordBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public Builder clearAnswerRecord() {
      if (answerRecordBuilder_ == null) {
        answerRecord_ = null;
        onChanged();
      } else {
        answerRecord_ = null;
        answerRecordBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public com.google.cloud.dialogflow.v2.AnswerRecord.Builder getAnswerRecordBuilder() {
      
      onChanged();
      return getAnswerRecordFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    public com.google.cloud.dialogflow.v2.AnswerRecordOrBuilder getAnswerRecordOrBuilder() {
      if (answerRecordBuilder_ != null) {
        return answerRecordBuilder_.getMessageOrBuilder();
      } else {
        return answerRecord_ == null ?
            com.google.cloud.dialogflow.v2.AnswerRecord.getDefaultInstance() : answerRecord_;
      }
    }
    /**
     * <pre>
     * Required. Answer record to update.
     * </pre>
     *
     * <code>.google.cloud.dialogflow.v2.AnswerRecord answer_record = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.dialogflow.v2.AnswerRecord, com.google.cloud.dialogflow.v2.AnswerRecord.Builder, com.google.cloud.dialogflow.v2.AnswerRecordOrBuilder> 
        getAnswerRecordFieldBuilder() {
      if (answerRecordBuilder_ == null) {
        answerRecordBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.dialogflow.v2.AnswerRecord, com.google.cloud.dialogflow.v2.AnswerRecord.Builder, com.google.cloud.dialogflow.v2.AnswerRecordOrBuilder>(
                getAnswerRecord(),
                getParentForChildren(),
                isClean());
        answerRecord_ = null;
      }
      return answerRecordBuilder_;
    }

    private com.google.protobuf.FieldMask updateMask_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder> updateMaskBuilder_;
    /**
     * <pre>
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the updateMask field is set.
     */
    public boolean hasUpdateMask() {
      return updateMaskBuilder_ != null || updateMask_ != null;
    }
    /**
     * <pre>
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.protobuf.FieldMask.Builder getUpdateMaskBuilder() {
      
      onChanged();
      return getUpdateMaskFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The mask to control which fields get updated.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dialogflow.v2.UpdateAnswerRecordRequest)
  private static final com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest();
  }

  public static com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<UpdateAnswerRecordRequest>
      PARSER = new com.google.protobuf.AbstractParser<UpdateAnswerRecordRequest>() {
    @java.lang.Override
    public UpdateAnswerRecordRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new UpdateAnswerRecordRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<UpdateAnswerRecordRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<UpdateAnswerRecordRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dialogflow.v2.UpdateAnswerRecordRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

