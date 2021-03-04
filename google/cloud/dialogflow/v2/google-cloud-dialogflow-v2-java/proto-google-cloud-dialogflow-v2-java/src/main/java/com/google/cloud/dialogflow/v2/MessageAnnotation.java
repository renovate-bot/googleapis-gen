// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/participant.proto

package com.google.cloud.dialogflow.v2;

/**
 * <pre>
 * Represents the result of annotation for the message.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dialogflow.v2.MessageAnnotation}
 */
public final class MessageAnnotation extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dialogflow.v2.MessageAnnotation)
    MessageAnnotationOrBuilder {
private static final long serialVersionUID = 0L;
  // Use MessageAnnotation.newBuilder() to construct.
  private MessageAnnotation(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private MessageAnnotation() {
    parts_ = java.util.Collections.emptyList();
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new MessageAnnotation();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private MessageAnnotation(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    this();
    if (extensionRegistry == null) {
      throw new java.lang.NullPointerException();
    }
    int mutable_bitField0_ = 0;
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
            if (!((mutable_bitField0_ & 0x00000001) != 0)) {
              parts_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.AnnotatedMessagePart>();
              mutable_bitField0_ |= 0x00000001;
            }
            parts_.add(
                input.readMessage(com.google.cloud.dialogflow.v2.AnnotatedMessagePart.parser(), extensionRegistry));
            break;
          }
          case 16: {

            containEntities_ = input.readBool();
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
      if (((mutable_bitField0_ & 0x00000001) != 0)) {
        parts_ = java.util.Collections.unmodifiableList(parts_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_MessageAnnotation_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_MessageAnnotation_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dialogflow.v2.MessageAnnotation.class, com.google.cloud.dialogflow.v2.MessageAnnotation.Builder.class);
  }

  public static final int PARTS_FIELD_NUMBER = 1;
  private java.util.List<com.google.cloud.dialogflow.v2.AnnotatedMessagePart> parts_;
  /**
   * <pre>
   * The collection of annotated message parts ordered by their
   * position in the message. You can recover the annotated message by
   * concatenating [AnnotatedMessagePart.text].
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.cloud.dialogflow.v2.AnnotatedMessagePart> getPartsList() {
    return parts_;
  }
  /**
   * <pre>
   * The collection of annotated message parts ordered by their
   * position in the message. You can recover the annotated message by
   * concatenating [AnnotatedMessagePart.text].
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder> 
      getPartsOrBuilderList() {
    return parts_;
  }
  /**
   * <pre>
   * The collection of annotated message parts ordered by their
   * position in the message. You can recover the annotated message by
   * concatenating [AnnotatedMessagePart.text].
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
   */
  @java.lang.Override
  public int getPartsCount() {
    return parts_.size();
  }
  /**
   * <pre>
   * The collection of annotated message parts ordered by their
   * position in the message. You can recover the annotated message by
   * concatenating [AnnotatedMessagePart.text].
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.AnnotatedMessagePart getParts(int index) {
    return parts_.get(index);
  }
  /**
   * <pre>
   * The collection of annotated message parts ordered by their
   * position in the message. You can recover the annotated message by
   * concatenating [AnnotatedMessagePart.text].
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
   */
  @java.lang.Override
  public com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder getPartsOrBuilder(
      int index) {
    return parts_.get(index);
  }

  public static final int CONTAIN_ENTITIES_FIELD_NUMBER = 2;
  private boolean containEntities_;
  /**
   * <pre>
   * Indicates whether the text message contains entities.
   * </pre>
   *
   * <code>bool contain_entities = 2;</code>
   * @return The containEntities.
   */
  @java.lang.Override
  public boolean getContainEntities() {
    return containEntities_;
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
    for (int i = 0; i < parts_.size(); i++) {
      output.writeMessage(1, parts_.get(i));
    }
    if (containEntities_ != false) {
      output.writeBool(2, containEntities_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < parts_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, parts_.get(i));
    }
    if (containEntities_ != false) {
      size += com.google.protobuf.CodedOutputStream
        .computeBoolSize(2, containEntities_);
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
    if (!(obj instanceof com.google.cloud.dialogflow.v2.MessageAnnotation)) {
      return super.equals(obj);
    }
    com.google.cloud.dialogflow.v2.MessageAnnotation other = (com.google.cloud.dialogflow.v2.MessageAnnotation) obj;

    if (!getPartsList()
        .equals(other.getPartsList())) return false;
    if (getContainEntities()
        != other.getContainEntities()) return false;
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
    if (getPartsCount() > 0) {
      hash = (37 * hash) + PARTS_FIELD_NUMBER;
      hash = (53 * hash) + getPartsList().hashCode();
    }
    hash = (37 * hash) + CONTAIN_ENTITIES_FIELD_NUMBER;
    hash = (53 * hash) + com.google.protobuf.Internal.hashBoolean(
        getContainEntities());
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dialogflow.v2.MessageAnnotation parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dialogflow.v2.MessageAnnotation prototype) {
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
   * Represents the result of annotation for the message.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dialogflow.v2.MessageAnnotation}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dialogflow.v2.MessageAnnotation)
      com.google.cloud.dialogflow.v2.MessageAnnotationOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_MessageAnnotation_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_MessageAnnotation_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dialogflow.v2.MessageAnnotation.class, com.google.cloud.dialogflow.v2.MessageAnnotation.Builder.class);
    }

    // Construct using com.google.cloud.dialogflow.v2.MessageAnnotation.newBuilder()
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
        getPartsFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (partsBuilder_ == null) {
        parts_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        partsBuilder_.clear();
      }
      containEntities_ = false;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dialogflow.v2.ParticipantProto.internal_static_google_cloud_dialogflow_v2_MessageAnnotation_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.MessageAnnotation getDefaultInstanceForType() {
      return com.google.cloud.dialogflow.v2.MessageAnnotation.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.MessageAnnotation build() {
      com.google.cloud.dialogflow.v2.MessageAnnotation result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dialogflow.v2.MessageAnnotation buildPartial() {
      com.google.cloud.dialogflow.v2.MessageAnnotation result = new com.google.cloud.dialogflow.v2.MessageAnnotation(this);
      int from_bitField0_ = bitField0_;
      if (partsBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          parts_ = java.util.Collections.unmodifiableList(parts_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.parts_ = parts_;
      } else {
        result.parts_ = partsBuilder_.build();
      }
      result.containEntities_ = containEntities_;
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
      if (other instanceof com.google.cloud.dialogflow.v2.MessageAnnotation) {
        return mergeFrom((com.google.cloud.dialogflow.v2.MessageAnnotation)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dialogflow.v2.MessageAnnotation other) {
      if (other == com.google.cloud.dialogflow.v2.MessageAnnotation.getDefaultInstance()) return this;
      if (partsBuilder_ == null) {
        if (!other.parts_.isEmpty()) {
          if (parts_.isEmpty()) {
            parts_ = other.parts_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensurePartsIsMutable();
            parts_.addAll(other.parts_);
          }
          onChanged();
        }
      } else {
        if (!other.parts_.isEmpty()) {
          if (partsBuilder_.isEmpty()) {
            partsBuilder_.dispose();
            partsBuilder_ = null;
            parts_ = other.parts_;
            bitField0_ = (bitField0_ & ~0x00000001);
            partsBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getPartsFieldBuilder() : null;
          } else {
            partsBuilder_.addAllMessages(other.parts_);
          }
        }
      }
      if (other.getContainEntities() != false) {
        setContainEntities(other.getContainEntities());
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
      com.google.cloud.dialogflow.v2.MessageAnnotation parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dialogflow.v2.MessageAnnotation) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.cloud.dialogflow.v2.AnnotatedMessagePart> parts_ =
      java.util.Collections.emptyList();
    private void ensurePartsIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        parts_ = new java.util.ArrayList<com.google.cloud.dialogflow.v2.AnnotatedMessagePart>(parts_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.AnnotatedMessagePart, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder, com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder> partsBuilder_;

    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.AnnotatedMessagePart> getPartsList() {
      if (partsBuilder_ == null) {
        return java.util.Collections.unmodifiableList(parts_);
      } else {
        return partsBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public int getPartsCount() {
      if (partsBuilder_ == null) {
        return parts_.size();
      } else {
        return partsBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.AnnotatedMessagePart getParts(int index) {
      if (partsBuilder_ == null) {
        return parts_.get(index);
      } else {
        return partsBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder setParts(
        int index, com.google.cloud.dialogflow.v2.AnnotatedMessagePart value) {
      if (partsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensurePartsIsMutable();
        parts_.set(index, value);
        onChanged();
      } else {
        partsBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder setParts(
        int index, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder builderForValue) {
      if (partsBuilder_ == null) {
        ensurePartsIsMutable();
        parts_.set(index, builderForValue.build());
        onChanged();
      } else {
        partsBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder addParts(com.google.cloud.dialogflow.v2.AnnotatedMessagePart value) {
      if (partsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensurePartsIsMutable();
        parts_.add(value);
        onChanged();
      } else {
        partsBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder addParts(
        int index, com.google.cloud.dialogflow.v2.AnnotatedMessagePart value) {
      if (partsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensurePartsIsMutable();
        parts_.add(index, value);
        onChanged();
      } else {
        partsBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder addParts(
        com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder builderForValue) {
      if (partsBuilder_ == null) {
        ensurePartsIsMutable();
        parts_.add(builderForValue.build());
        onChanged();
      } else {
        partsBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder addParts(
        int index, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder builderForValue) {
      if (partsBuilder_ == null) {
        ensurePartsIsMutable();
        parts_.add(index, builderForValue.build());
        onChanged();
      } else {
        partsBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder addAllParts(
        java.lang.Iterable<? extends com.google.cloud.dialogflow.v2.AnnotatedMessagePart> values) {
      if (partsBuilder_ == null) {
        ensurePartsIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, parts_);
        onChanged();
      } else {
        partsBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder clearParts() {
      if (partsBuilder_ == null) {
        parts_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        partsBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public Builder removeParts(int index) {
      if (partsBuilder_ == null) {
        ensurePartsIsMutable();
        parts_.remove(index);
        onChanged();
      } else {
        partsBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder getPartsBuilder(
        int index) {
      return getPartsFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder getPartsOrBuilder(
        int index) {
      if (partsBuilder_ == null) {
        return parts_.get(index);  } else {
        return partsBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public java.util.List<? extends com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder> 
         getPartsOrBuilderList() {
      if (partsBuilder_ != null) {
        return partsBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(parts_);
      }
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder addPartsBuilder() {
      return getPartsFieldBuilder().addBuilder(
          com.google.cloud.dialogflow.v2.AnnotatedMessagePart.getDefaultInstance());
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder addPartsBuilder(
        int index) {
      return getPartsFieldBuilder().addBuilder(
          index, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.getDefaultInstance());
    }
    /**
     * <pre>
     * The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     * </pre>
     *
     * <code>repeated .google.cloud.dialogflow.v2.AnnotatedMessagePart parts = 1;</code>
     */
    public java.util.List<com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder> 
         getPartsBuilderList() {
      return getPartsFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dialogflow.v2.AnnotatedMessagePart, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder, com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder> 
        getPartsFieldBuilder() {
      if (partsBuilder_ == null) {
        partsBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.cloud.dialogflow.v2.AnnotatedMessagePart, com.google.cloud.dialogflow.v2.AnnotatedMessagePart.Builder, com.google.cloud.dialogflow.v2.AnnotatedMessagePartOrBuilder>(
                parts_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        parts_ = null;
      }
      return partsBuilder_;
    }

    private boolean containEntities_ ;
    /**
     * <pre>
     * Indicates whether the text message contains entities.
     * </pre>
     *
     * <code>bool contain_entities = 2;</code>
     * @return The containEntities.
     */
    @java.lang.Override
    public boolean getContainEntities() {
      return containEntities_;
    }
    /**
     * <pre>
     * Indicates whether the text message contains entities.
     * </pre>
     *
     * <code>bool contain_entities = 2;</code>
     * @param value The containEntities to set.
     * @return This builder for chaining.
     */
    public Builder setContainEntities(boolean value) {
      
      containEntities_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Indicates whether the text message contains entities.
     * </pre>
     *
     * <code>bool contain_entities = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearContainEntities() {
      
      containEntities_ = false;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dialogflow.v2.MessageAnnotation)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dialogflow.v2.MessageAnnotation)
  private static final com.google.cloud.dialogflow.v2.MessageAnnotation DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dialogflow.v2.MessageAnnotation();
  }

  public static com.google.cloud.dialogflow.v2.MessageAnnotation getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<MessageAnnotation>
      PARSER = new com.google.protobuf.AbstractParser<MessageAnnotation>() {
    @java.lang.Override
    public MessageAnnotation parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new MessageAnnotation(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<MessageAnnotation> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<MessageAnnotation> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dialogflow.v2.MessageAnnotation getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

