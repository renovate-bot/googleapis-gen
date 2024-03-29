// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/cloudbuild/v1/cloudbuild.proto

package com.google.cloudbuild.v1;

/**
 * <pre>
 * Request to create a new `BuildTrigger`.
 * </pre>
 *
 * Protobuf type {@code google.devtools.cloudbuild.v1.CreateBuildTriggerRequest}
 */
public final class CreateBuildTriggerRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.devtools.cloudbuild.v1.CreateBuildTriggerRequest)
    CreateBuildTriggerRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CreateBuildTriggerRequest.newBuilder() to construct.
  private CreateBuildTriggerRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CreateBuildTriggerRequest() {
    parent_ = "";
    projectId_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CreateBuildTriggerRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CreateBuildTriggerRequest(
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

            projectId_ = s;
            break;
          }
          case 18: {
            com.google.cloudbuild.v1.BuildTrigger.Builder subBuilder = null;
            if (trigger_ != null) {
              subBuilder = trigger_.toBuilder();
            }
            trigger_ = input.readMessage(com.google.cloudbuild.v1.BuildTrigger.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(trigger_);
              trigger_ = subBuilder.buildPartial();
            }

            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            parent_ = s;
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
    return com.google.cloudbuild.v1.Cloudbuild.internal_static_google_devtools_cloudbuild_v1_CreateBuildTriggerRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloudbuild.v1.Cloudbuild.internal_static_google_devtools_cloudbuild_v1_CreateBuildTriggerRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloudbuild.v1.CreateBuildTriggerRequest.class, com.google.cloudbuild.v1.CreateBuildTriggerRequest.Builder.class);
  }

  public static final int PARENT_FIELD_NUMBER = 3;
  private volatile java.lang.Object parent_;
  /**
   * <pre>
   * The parent resource where this trigger will be created.
   * Format: `projects/{project}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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
   * The parent resource where this trigger will be created.
   * Format: `projects/{project}/locations/{location}`
   * </pre>
   *
   * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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

  public static final int PROJECT_ID_FIELD_NUMBER = 1;
  private volatile java.lang.Object projectId_;
  /**
   * <pre>
   * Required. ID of the project for which to configure automatic builds.
   * </pre>
   *
   * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The projectId.
   */
  @java.lang.Override
  public java.lang.String getProjectId() {
    java.lang.Object ref = projectId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      projectId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. ID of the project for which to configure automatic builds.
   * </pre>
   *
   * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for projectId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getProjectIdBytes() {
    java.lang.Object ref = projectId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      projectId_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int TRIGGER_FIELD_NUMBER = 2;
  private com.google.cloudbuild.v1.BuildTrigger trigger_;
  /**
   * <pre>
   * Required. `BuildTrigger` to create.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the trigger field is set.
   */
  @java.lang.Override
  public boolean hasTrigger() {
    return trigger_ != null;
  }
  /**
   * <pre>
   * Required. `BuildTrigger` to create.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The trigger.
   */
  @java.lang.Override
  public com.google.cloudbuild.v1.BuildTrigger getTrigger() {
    return trigger_ == null ? com.google.cloudbuild.v1.BuildTrigger.getDefaultInstance() : trigger_;
  }
  /**
   * <pre>
   * Required. `BuildTrigger` to create.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  @java.lang.Override
  public com.google.cloudbuild.v1.BuildTriggerOrBuilder getTriggerOrBuilder() {
    return getTrigger();
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(projectId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, projectId_);
    }
    if (trigger_ != null) {
      output.writeMessage(2, getTrigger());
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(parent_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, parent_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(projectId_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, projectId_);
    }
    if (trigger_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getTrigger());
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(parent_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, parent_);
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
    if (!(obj instanceof com.google.cloudbuild.v1.CreateBuildTriggerRequest)) {
      return super.equals(obj);
    }
    com.google.cloudbuild.v1.CreateBuildTriggerRequest other = (com.google.cloudbuild.v1.CreateBuildTriggerRequest) obj;

    if (!getParent()
        .equals(other.getParent())) return false;
    if (!getProjectId()
        .equals(other.getProjectId())) return false;
    if (hasTrigger() != other.hasTrigger()) return false;
    if (hasTrigger()) {
      if (!getTrigger()
          .equals(other.getTrigger())) return false;
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
    hash = (37 * hash) + PROJECT_ID_FIELD_NUMBER;
    hash = (53 * hash) + getProjectId().hashCode();
    if (hasTrigger()) {
      hash = (37 * hash) + TRIGGER_FIELD_NUMBER;
      hash = (53 * hash) + getTrigger().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloudbuild.v1.CreateBuildTriggerRequest prototype) {
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
   * Request to create a new `BuildTrigger`.
   * </pre>
   *
   * Protobuf type {@code google.devtools.cloudbuild.v1.CreateBuildTriggerRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.devtools.cloudbuild.v1.CreateBuildTriggerRequest)
      com.google.cloudbuild.v1.CreateBuildTriggerRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloudbuild.v1.Cloudbuild.internal_static_google_devtools_cloudbuild_v1_CreateBuildTriggerRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloudbuild.v1.Cloudbuild.internal_static_google_devtools_cloudbuild_v1_CreateBuildTriggerRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloudbuild.v1.CreateBuildTriggerRequest.class, com.google.cloudbuild.v1.CreateBuildTriggerRequest.Builder.class);
    }

    // Construct using com.google.cloudbuild.v1.CreateBuildTriggerRequest.newBuilder()
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

      projectId_ = "";

      if (triggerBuilder_ == null) {
        trigger_ = null;
      } else {
        trigger_ = null;
        triggerBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloudbuild.v1.Cloudbuild.internal_static_google_devtools_cloudbuild_v1_CreateBuildTriggerRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloudbuild.v1.CreateBuildTriggerRequest getDefaultInstanceForType() {
      return com.google.cloudbuild.v1.CreateBuildTriggerRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloudbuild.v1.CreateBuildTriggerRequest build() {
      com.google.cloudbuild.v1.CreateBuildTriggerRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloudbuild.v1.CreateBuildTriggerRequest buildPartial() {
      com.google.cloudbuild.v1.CreateBuildTriggerRequest result = new com.google.cloudbuild.v1.CreateBuildTriggerRequest(this);
      result.parent_ = parent_;
      result.projectId_ = projectId_;
      if (triggerBuilder_ == null) {
        result.trigger_ = trigger_;
      } else {
        result.trigger_ = triggerBuilder_.build();
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
      if (other instanceof com.google.cloudbuild.v1.CreateBuildTriggerRequest) {
        return mergeFrom((com.google.cloudbuild.v1.CreateBuildTriggerRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloudbuild.v1.CreateBuildTriggerRequest other) {
      if (other == com.google.cloudbuild.v1.CreateBuildTriggerRequest.getDefaultInstance()) return this;
      if (!other.getParent().isEmpty()) {
        parent_ = other.parent_;
        onChanged();
      }
      if (!other.getProjectId().isEmpty()) {
        projectId_ = other.projectId_;
        onChanged();
      }
      if (other.hasTrigger()) {
        mergeTrigger(other.getTrigger());
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
      com.google.cloudbuild.v1.CreateBuildTriggerRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloudbuild.v1.CreateBuildTriggerRequest) e.getUnfinishedMessage();
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
     * The parent resource where this trigger will be created.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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
     * The parent resource where this trigger will be created.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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
     * The parent resource where this trigger will be created.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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
     * The parent resource where this trigger will be created.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
     * @return This builder for chaining.
     */
    public Builder clearParent() {
      
      parent_ = getDefaultInstance().getParent();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The parent resource where this trigger will be created.
     * Format: `projects/{project}/locations/{location}`
     * </pre>
     *
     * <code>string parent = 3 [(.google.api.resource_reference) = { ... }</code>
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

    private java.lang.Object projectId_ = "";
    /**
     * <pre>
     * Required. ID of the project for which to configure automatic builds.
     * </pre>
     *
     * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The projectId.
     */
    public java.lang.String getProjectId() {
      java.lang.Object ref = projectId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        projectId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. ID of the project for which to configure automatic builds.
     * </pre>
     *
     * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The bytes for projectId.
     */
    public com.google.protobuf.ByteString
        getProjectIdBytes() {
      java.lang.Object ref = projectId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        projectId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. ID of the project for which to configure automatic builds.
     * </pre>
     *
     * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The projectId to set.
     * @return This builder for chaining.
     */
    public Builder setProjectId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      projectId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. ID of the project for which to configure automatic builds.
     * </pre>
     *
     * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return This builder for chaining.
     */
    public Builder clearProjectId() {
      
      projectId_ = getDefaultInstance().getProjectId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. ID of the project for which to configure automatic builds.
     * </pre>
     *
     * <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The bytes for projectId to set.
     * @return This builder for chaining.
     */
    public Builder setProjectIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      projectId_ = value;
      onChanged();
      return this;
    }

    private com.google.cloudbuild.v1.BuildTrigger trigger_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloudbuild.v1.BuildTrigger, com.google.cloudbuild.v1.BuildTrigger.Builder, com.google.cloudbuild.v1.BuildTriggerOrBuilder> triggerBuilder_;
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return Whether the trigger field is set.
     */
    public boolean hasTrigger() {
      return triggerBuilder_ != null || trigger_ != null;
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The trigger.
     */
    public com.google.cloudbuild.v1.BuildTrigger getTrigger() {
      if (triggerBuilder_ == null) {
        return trigger_ == null ? com.google.cloudbuild.v1.BuildTrigger.getDefaultInstance() : trigger_;
      } else {
        return triggerBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setTrigger(com.google.cloudbuild.v1.BuildTrigger value) {
      if (triggerBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        trigger_ = value;
        onChanged();
      } else {
        triggerBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder setTrigger(
        com.google.cloudbuild.v1.BuildTrigger.Builder builderForValue) {
      if (triggerBuilder_ == null) {
        trigger_ = builderForValue.build();
        onChanged();
      } else {
        triggerBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder mergeTrigger(com.google.cloudbuild.v1.BuildTrigger value) {
      if (triggerBuilder_ == null) {
        if (trigger_ != null) {
          trigger_ =
            com.google.cloudbuild.v1.BuildTrigger.newBuilder(trigger_).mergeFrom(value).buildPartial();
        } else {
          trigger_ = value;
        }
        onChanged();
      } else {
        triggerBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public Builder clearTrigger() {
      if (triggerBuilder_ == null) {
        trigger_ = null;
        onChanged();
      } else {
        trigger_ = null;
        triggerBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloudbuild.v1.BuildTrigger.Builder getTriggerBuilder() {
      
      onChanged();
      return getTriggerFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    public com.google.cloudbuild.v1.BuildTriggerOrBuilder getTriggerOrBuilder() {
      if (triggerBuilder_ != null) {
        return triggerBuilder_.getMessageOrBuilder();
      } else {
        return trigger_ == null ?
            com.google.cloudbuild.v1.BuildTrigger.getDefaultInstance() : trigger_;
      }
    }
    /**
     * <pre>
     * Required. `BuildTrigger` to create.
     * </pre>
     *
     * <code>.google.devtools.cloudbuild.v1.BuildTrigger trigger = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloudbuild.v1.BuildTrigger, com.google.cloudbuild.v1.BuildTrigger.Builder, com.google.cloudbuild.v1.BuildTriggerOrBuilder> 
        getTriggerFieldBuilder() {
      if (triggerBuilder_ == null) {
        triggerBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloudbuild.v1.BuildTrigger, com.google.cloudbuild.v1.BuildTrigger.Builder, com.google.cloudbuild.v1.BuildTriggerOrBuilder>(
                getTrigger(),
                getParentForChildren(),
                isClean());
        trigger_ = null;
      }
      return triggerBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.devtools.cloudbuild.v1.CreateBuildTriggerRequest)
  }

  // @@protoc_insertion_point(class_scope:google.devtools.cloudbuild.v1.CreateBuildTriggerRequest)
  private static final com.google.cloudbuild.v1.CreateBuildTriggerRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloudbuild.v1.CreateBuildTriggerRequest();
  }

  public static com.google.cloudbuild.v1.CreateBuildTriggerRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CreateBuildTriggerRequest>
      PARSER = new com.google.protobuf.AbstractParser<CreateBuildTriggerRequest>() {
    @java.lang.Override
    public CreateBuildTriggerRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CreateBuildTriggerRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CreateBuildTriggerRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CreateBuildTriggerRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloudbuild.v1.CreateBuildTriggerRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

