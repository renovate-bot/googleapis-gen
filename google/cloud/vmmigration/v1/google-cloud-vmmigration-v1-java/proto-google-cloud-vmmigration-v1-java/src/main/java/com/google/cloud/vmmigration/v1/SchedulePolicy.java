// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/vmmigration/v1/vmmigration.proto

package com.google.cloud.vmmigration.v1;

/**
 * <pre>
 * A policy for scheduling replications.
 * </pre>
 *
 * Protobuf type {@code google.cloud.vmmigration.v1.SchedulePolicy}
 */
public final class SchedulePolicy extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.vmmigration.v1.SchedulePolicy)
    SchedulePolicyOrBuilder {
private static final long serialVersionUID = 0L;
  // Use SchedulePolicy.newBuilder() to construct.
  private SchedulePolicy(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private SchedulePolicy() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new SchedulePolicy();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private SchedulePolicy(
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
            com.google.protobuf.Duration.Builder subBuilder = null;
            if (idleDuration_ != null) {
              subBuilder = idleDuration_.toBuilder();
            }
            idleDuration_ = input.readMessage(com.google.protobuf.Duration.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(idleDuration_);
              idleDuration_ = subBuilder.buildPartial();
            }

            break;
          }
          case 16: {

            skipOsAdaptation_ = input.readBool();
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
    return com.google.cloud.vmmigration.v1.VmMigrationProto.internal_static_google_cloud_vmmigration_v1_SchedulePolicy_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.vmmigration.v1.VmMigrationProto.internal_static_google_cloud_vmmigration_v1_SchedulePolicy_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.vmmigration.v1.SchedulePolicy.class, com.google.cloud.vmmigration.v1.SchedulePolicy.Builder.class);
  }

  public static final int IDLE_DURATION_FIELD_NUMBER = 1;
  private com.google.protobuf.Duration idleDuration_;
  /**
   * <pre>
   * The idle duration between replication stages.
   * </pre>
   *
   * <code>.google.protobuf.Duration idle_duration = 1;</code>
   * @return Whether the idleDuration field is set.
   */
  @java.lang.Override
  public boolean hasIdleDuration() {
    return idleDuration_ != null;
  }
  /**
   * <pre>
   * The idle duration between replication stages.
   * </pre>
   *
   * <code>.google.protobuf.Duration idle_duration = 1;</code>
   * @return The idleDuration.
   */
  @java.lang.Override
  public com.google.protobuf.Duration getIdleDuration() {
    return idleDuration_ == null ? com.google.protobuf.Duration.getDefaultInstance() : idleDuration_;
  }
  /**
   * <pre>
   * The idle duration between replication stages.
   * </pre>
   *
   * <code>.google.protobuf.Duration idle_duration = 1;</code>
   */
  @java.lang.Override
  public com.google.protobuf.DurationOrBuilder getIdleDurationOrBuilder() {
    return getIdleDuration();
  }

  public static final int SKIP_OS_ADAPTATION_FIELD_NUMBER = 2;
  private boolean skipOsAdaptation_;
  /**
   * <pre>
   * A flag to indicate whether to skip OS adaptation during the replication
   * sync. OS adaptation is a process where the VM's operating system undergoes
   * changes and adaptations to fully function on Compute Engine.
   * </pre>
   *
   * <code>bool skip_os_adaptation = 2;</code>
   * @return The skipOsAdaptation.
   */
  @java.lang.Override
  public boolean getSkipOsAdaptation() {
    return skipOsAdaptation_;
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
    if (idleDuration_ != null) {
      output.writeMessage(1, getIdleDuration());
    }
    if (skipOsAdaptation_ != false) {
      output.writeBool(2, skipOsAdaptation_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (idleDuration_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getIdleDuration());
    }
    if (skipOsAdaptation_ != false) {
      size += com.google.protobuf.CodedOutputStream
        .computeBoolSize(2, skipOsAdaptation_);
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
    if (!(obj instanceof com.google.cloud.vmmigration.v1.SchedulePolicy)) {
      return super.equals(obj);
    }
    com.google.cloud.vmmigration.v1.SchedulePolicy other = (com.google.cloud.vmmigration.v1.SchedulePolicy) obj;

    if (hasIdleDuration() != other.hasIdleDuration()) return false;
    if (hasIdleDuration()) {
      if (!getIdleDuration()
          .equals(other.getIdleDuration())) return false;
    }
    if (getSkipOsAdaptation()
        != other.getSkipOsAdaptation()) return false;
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
    if (hasIdleDuration()) {
      hash = (37 * hash) + IDLE_DURATION_FIELD_NUMBER;
      hash = (53 * hash) + getIdleDuration().hashCode();
    }
    hash = (37 * hash) + SKIP_OS_ADAPTATION_FIELD_NUMBER;
    hash = (53 * hash) + com.google.protobuf.Internal.hashBoolean(
        getSkipOsAdaptation());
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.vmmigration.v1.SchedulePolicy parseFrom(
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
  public static Builder newBuilder(com.google.cloud.vmmigration.v1.SchedulePolicy prototype) {
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
   * A policy for scheduling replications.
   * </pre>
   *
   * Protobuf type {@code google.cloud.vmmigration.v1.SchedulePolicy}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.vmmigration.v1.SchedulePolicy)
      com.google.cloud.vmmigration.v1.SchedulePolicyOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.vmmigration.v1.VmMigrationProto.internal_static_google_cloud_vmmigration_v1_SchedulePolicy_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.vmmigration.v1.VmMigrationProto.internal_static_google_cloud_vmmigration_v1_SchedulePolicy_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.vmmigration.v1.SchedulePolicy.class, com.google.cloud.vmmigration.v1.SchedulePolicy.Builder.class);
    }

    // Construct using com.google.cloud.vmmigration.v1.SchedulePolicy.newBuilder()
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
      if (idleDurationBuilder_ == null) {
        idleDuration_ = null;
      } else {
        idleDuration_ = null;
        idleDurationBuilder_ = null;
      }
      skipOsAdaptation_ = false;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.vmmigration.v1.VmMigrationProto.internal_static_google_cloud_vmmigration_v1_SchedulePolicy_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.vmmigration.v1.SchedulePolicy getDefaultInstanceForType() {
      return com.google.cloud.vmmigration.v1.SchedulePolicy.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.vmmigration.v1.SchedulePolicy build() {
      com.google.cloud.vmmigration.v1.SchedulePolicy result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.vmmigration.v1.SchedulePolicy buildPartial() {
      com.google.cloud.vmmigration.v1.SchedulePolicy result = new com.google.cloud.vmmigration.v1.SchedulePolicy(this);
      if (idleDurationBuilder_ == null) {
        result.idleDuration_ = idleDuration_;
      } else {
        result.idleDuration_ = idleDurationBuilder_.build();
      }
      result.skipOsAdaptation_ = skipOsAdaptation_;
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
      if (other instanceof com.google.cloud.vmmigration.v1.SchedulePolicy) {
        return mergeFrom((com.google.cloud.vmmigration.v1.SchedulePolicy)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.vmmigration.v1.SchedulePolicy other) {
      if (other == com.google.cloud.vmmigration.v1.SchedulePolicy.getDefaultInstance()) return this;
      if (other.hasIdleDuration()) {
        mergeIdleDuration(other.getIdleDuration());
      }
      if (other.getSkipOsAdaptation() != false) {
        setSkipOsAdaptation(other.getSkipOsAdaptation());
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
      com.google.cloud.vmmigration.v1.SchedulePolicy parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.vmmigration.v1.SchedulePolicy) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.protobuf.Duration idleDuration_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Duration, com.google.protobuf.Duration.Builder, com.google.protobuf.DurationOrBuilder> idleDurationBuilder_;
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     * @return Whether the idleDuration field is set.
     */
    public boolean hasIdleDuration() {
      return idleDurationBuilder_ != null || idleDuration_ != null;
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     * @return The idleDuration.
     */
    public com.google.protobuf.Duration getIdleDuration() {
      if (idleDurationBuilder_ == null) {
        return idleDuration_ == null ? com.google.protobuf.Duration.getDefaultInstance() : idleDuration_;
      } else {
        return idleDurationBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public Builder setIdleDuration(com.google.protobuf.Duration value) {
      if (idleDurationBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        idleDuration_ = value;
        onChanged();
      } else {
        idleDurationBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public Builder setIdleDuration(
        com.google.protobuf.Duration.Builder builderForValue) {
      if (idleDurationBuilder_ == null) {
        idleDuration_ = builderForValue.build();
        onChanged();
      } else {
        idleDurationBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public Builder mergeIdleDuration(com.google.protobuf.Duration value) {
      if (idleDurationBuilder_ == null) {
        if (idleDuration_ != null) {
          idleDuration_ =
            com.google.protobuf.Duration.newBuilder(idleDuration_).mergeFrom(value).buildPartial();
        } else {
          idleDuration_ = value;
        }
        onChanged();
      } else {
        idleDurationBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public Builder clearIdleDuration() {
      if (idleDurationBuilder_ == null) {
        idleDuration_ = null;
        onChanged();
      } else {
        idleDuration_ = null;
        idleDurationBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public com.google.protobuf.Duration.Builder getIdleDurationBuilder() {
      
      onChanged();
      return getIdleDurationFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    public com.google.protobuf.DurationOrBuilder getIdleDurationOrBuilder() {
      if (idleDurationBuilder_ != null) {
        return idleDurationBuilder_.getMessageOrBuilder();
      } else {
        return idleDuration_ == null ?
            com.google.protobuf.Duration.getDefaultInstance() : idleDuration_;
      }
    }
    /**
     * <pre>
     * The idle duration between replication stages.
     * </pre>
     *
     * <code>.google.protobuf.Duration idle_duration = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Duration, com.google.protobuf.Duration.Builder, com.google.protobuf.DurationOrBuilder> 
        getIdleDurationFieldBuilder() {
      if (idleDurationBuilder_ == null) {
        idleDurationBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.protobuf.Duration, com.google.protobuf.Duration.Builder, com.google.protobuf.DurationOrBuilder>(
                getIdleDuration(),
                getParentForChildren(),
                isClean());
        idleDuration_ = null;
      }
      return idleDurationBuilder_;
    }

    private boolean skipOsAdaptation_ ;
    /**
     * <pre>
     * A flag to indicate whether to skip OS adaptation during the replication
     * sync. OS adaptation is a process where the VM's operating system undergoes
     * changes and adaptations to fully function on Compute Engine.
     * </pre>
     *
     * <code>bool skip_os_adaptation = 2;</code>
     * @return The skipOsAdaptation.
     */
    @java.lang.Override
    public boolean getSkipOsAdaptation() {
      return skipOsAdaptation_;
    }
    /**
     * <pre>
     * A flag to indicate whether to skip OS adaptation during the replication
     * sync. OS adaptation is a process where the VM's operating system undergoes
     * changes and adaptations to fully function on Compute Engine.
     * </pre>
     *
     * <code>bool skip_os_adaptation = 2;</code>
     * @param value The skipOsAdaptation to set.
     * @return This builder for chaining.
     */
    public Builder setSkipOsAdaptation(boolean value) {
      
      skipOsAdaptation_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * A flag to indicate whether to skip OS adaptation during the replication
     * sync. OS adaptation is a process where the VM's operating system undergoes
     * changes and adaptations to fully function on Compute Engine.
     * </pre>
     *
     * <code>bool skip_os_adaptation = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearSkipOsAdaptation() {
      
      skipOsAdaptation_ = false;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.vmmigration.v1.SchedulePolicy)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.vmmigration.v1.SchedulePolicy)
  private static final com.google.cloud.vmmigration.v1.SchedulePolicy DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.vmmigration.v1.SchedulePolicy();
  }

  public static com.google.cloud.vmmigration.v1.SchedulePolicy getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<SchedulePolicy>
      PARSER = new com.google.protobuf.AbstractParser<SchedulePolicy>() {
    @java.lang.Override
    public SchedulePolicy parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new SchedulePolicy(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<SchedulePolicy> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<SchedulePolicy> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.vmmigration.v1.SchedulePolicy getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

