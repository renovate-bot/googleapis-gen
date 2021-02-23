// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/asset/v1p7beta1/assets.proto

package com.google.cloud.asset.v1p7beta1;

/**
 * <pre>
 * The relationship attributes which include  `type`, `source_resource_type`,
 * `target_resource_type` and `action`.
 * </pre>
 *
 * Protobuf type {@code google.cloud.asset.v1p7beta1.RelationshipAttributes}
 */
public final class RelationshipAttributes extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.asset.v1p7beta1.RelationshipAttributes)
    RelationshipAttributesOrBuilder {
private static final long serialVersionUID = 0L;
  // Use RelationshipAttributes.newBuilder() to construct.
  private RelationshipAttributes(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private RelationshipAttributes() {
    type_ = "";
    sourceResourceType_ = "";
    targetResourceType_ = "";
    action_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new RelationshipAttributes();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private RelationshipAttributes(
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

            sourceResourceType_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            targetResourceType_ = s;
            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            action_ = s;
            break;
          }
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();

            type_ = s;
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
    return com.google.cloud.asset.v1p7beta1.AssetProto.internal_static_google_cloud_asset_v1p7beta1_RelationshipAttributes_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.asset.v1p7beta1.AssetProto.internal_static_google_cloud_asset_v1p7beta1_RelationshipAttributes_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.asset.v1p7beta1.RelationshipAttributes.class, com.google.cloud.asset.v1p7beta1.RelationshipAttributes.Builder.class);
  }

  public static final int TYPE_FIELD_NUMBER = 4;
  private volatile java.lang.Object type_;
  /**
   * <pre>
   * The unique identifier of the relationship type. Example:
   * `INSTANCE_TO_INSTANCEGROUP`
   * </pre>
   *
   * <code>string type = 4;</code>
   * @return The type.
   */
  @java.lang.Override
  public java.lang.String getType() {
    java.lang.Object ref = type_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      type_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The unique identifier of the relationship type. Example:
   * `INSTANCE_TO_INSTANCEGROUP`
   * </pre>
   *
   * <code>string type = 4;</code>
   * @return The bytes for type.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getTypeBytes() {
    java.lang.Object ref = type_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      type_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int SOURCE_RESOURCE_TYPE_FIELD_NUMBER = 1;
  private volatile java.lang.Object sourceResourceType_;
  /**
   * <pre>
   * The source asset type. Example: `compute.googleapis.com/Instance`
   * </pre>
   *
   * <code>string source_resource_type = 1;</code>
   * @return The sourceResourceType.
   */
  @java.lang.Override
  public java.lang.String getSourceResourceType() {
    java.lang.Object ref = sourceResourceType_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      sourceResourceType_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The source asset type. Example: `compute.googleapis.com/Instance`
   * </pre>
   *
   * <code>string source_resource_type = 1;</code>
   * @return The bytes for sourceResourceType.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getSourceResourceTypeBytes() {
    java.lang.Object ref = sourceResourceType_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      sourceResourceType_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int TARGET_RESOURCE_TYPE_FIELD_NUMBER = 2;
  private volatile java.lang.Object targetResourceType_;
  /**
   * <pre>
   * The target asset type. Example: `compute.googleapis.com/Disk`
   * </pre>
   *
   * <code>string target_resource_type = 2;</code>
   * @return The targetResourceType.
   */
  @java.lang.Override
  public java.lang.String getTargetResourceType() {
    java.lang.Object ref = targetResourceType_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      targetResourceType_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The target asset type. Example: `compute.googleapis.com/Disk`
   * </pre>
   *
   * <code>string target_resource_type = 2;</code>
   * @return The bytes for targetResourceType.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getTargetResourceTypeBytes() {
    java.lang.Object ref = targetResourceType_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      targetResourceType_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int ACTION_FIELD_NUMBER = 3;
  private volatile java.lang.Object action_;
  /**
   * <pre>
   * The detail of the relationship, e.g. `contains`, `attaches`
   * </pre>
   *
   * <code>string action = 3;</code>
   * @return The action.
   */
  @java.lang.Override
  public java.lang.String getAction() {
    java.lang.Object ref = action_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      action_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The detail of the relationship, e.g. `contains`, `attaches`
   * </pre>
   *
   * <code>string action = 3;</code>
   * @return The bytes for action.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getActionBytes() {
    java.lang.Object ref = action_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      action_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
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
    if (!getSourceResourceTypeBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, sourceResourceType_);
    }
    if (!getTargetResourceTypeBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, targetResourceType_);
    }
    if (!getActionBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, action_);
    }
    if (!getTypeBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, type_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getSourceResourceTypeBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, sourceResourceType_);
    }
    if (!getTargetResourceTypeBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, targetResourceType_);
    }
    if (!getActionBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, action_);
    }
    if (!getTypeBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, type_);
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
    if (!(obj instanceof com.google.cloud.asset.v1p7beta1.RelationshipAttributes)) {
      return super.equals(obj);
    }
    com.google.cloud.asset.v1p7beta1.RelationshipAttributes other = (com.google.cloud.asset.v1p7beta1.RelationshipAttributes) obj;

    if (!getType()
        .equals(other.getType())) return false;
    if (!getSourceResourceType()
        .equals(other.getSourceResourceType())) return false;
    if (!getTargetResourceType()
        .equals(other.getTargetResourceType())) return false;
    if (!getAction()
        .equals(other.getAction())) return false;
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
    hash = (37 * hash) + TYPE_FIELD_NUMBER;
    hash = (53 * hash) + getType().hashCode();
    hash = (37 * hash) + SOURCE_RESOURCE_TYPE_FIELD_NUMBER;
    hash = (53 * hash) + getSourceResourceType().hashCode();
    hash = (37 * hash) + TARGET_RESOURCE_TYPE_FIELD_NUMBER;
    hash = (53 * hash) + getTargetResourceType().hashCode();
    hash = (37 * hash) + ACTION_FIELD_NUMBER;
    hash = (53 * hash) + getAction().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes parseFrom(
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
  public static Builder newBuilder(com.google.cloud.asset.v1p7beta1.RelationshipAttributes prototype) {
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
   * The relationship attributes which include  `type`, `source_resource_type`,
   * `target_resource_type` and `action`.
   * </pre>
   *
   * Protobuf type {@code google.cloud.asset.v1p7beta1.RelationshipAttributes}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.asset.v1p7beta1.RelationshipAttributes)
      com.google.cloud.asset.v1p7beta1.RelationshipAttributesOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.asset.v1p7beta1.AssetProto.internal_static_google_cloud_asset_v1p7beta1_RelationshipAttributes_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.asset.v1p7beta1.AssetProto.internal_static_google_cloud_asset_v1p7beta1_RelationshipAttributes_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.asset.v1p7beta1.RelationshipAttributes.class, com.google.cloud.asset.v1p7beta1.RelationshipAttributes.Builder.class);
    }

    // Construct using com.google.cloud.asset.v1p7beta1.RelationshipAttributes.newBuilder()
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
      type_ = "";

      sourceResourceType_ = "";

      targetResourceType_ = "";

      action_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.asset.v1p7beta1.AssetProto.internal_static_google_cloud_asset_v1p7beta1_RelationshipAttributes_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.asset.v1p7beta1.RelationshipAttributes getDefaultInstanceForType() {
      return com.google.cloud.asset.v1p7beta1.RelationshipAttributes.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.asset.v1p7beta1.RelationshipAttributes build() {
      com.google.cloud.asset.v1p7beta1.RelationshipAttributes result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.asset.v1p7beta1.RelationshipAttributes buildPartial() {
      com.google.cloud.asset.v1p7beta1.RelationshipAttributes result = new com.google.cloud.asset.v1p7beta1.RelationshipAttributes(this);
      result.type_ = type_;
      result.sourceResourceType_ = sourceResourceType_;
      result.targetResourceType_ = targetResourceType_;
      result.action_ = action_;
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
      if (other instanceof com.google.cloud.asset.v1p7beta1.RelationshipAttributes) {
        return mergeFrom((com.google.cloud.asset.v1p7beta1.RelationshipAttributes)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.asset.v1p7beta1.RelationshipAttributes other) {
      if (other == com.google.cloud.asset.v1p7beta1.RelationshipAttributes.getDefaultInstance()) return this;
      if (!other.getType().isEmpty()) {
        type_ = other.type_;
        onChanged();
      }
      if (!other.getSourceResourceType().isEmpty()) {
        sourceResourceType_ = other.sourceResourceType_;
        onChanged();
      }
      if (!other.getTargetResourceType().isEmpty()) {
        targetResourceType_ = other.targetResourceType_;
        onChanged();
      }
      if (!other.getAction().isEmpty()) {
        action_ = other.action_;
        onChanged();
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
      com.google.cloud.asset.v1p7beta1.RelationshipAttributes parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.asset.v1p7beta1.RelationshipAttributes) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object type_ = "";
    /**
     * <pre>
     * The unique identifier of the relationship type. Example:
     * `INSTANCE_TO_INSTANCEGROUP`
     * </pre>
     *
     * <code>string type = 4;</code>
     * @return The type.
     */
    public java.lang.String getType() {
      java.lang.Object ref = type_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        type_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The unique identifier of the relationship type. Example:
     * `INSTANCE_TO_INSTANCEGROUP`
     * </pre>
     *
     * <code>string type = 4;</code>
     * @return The bytes for type.
     */
    public com.google.protobuf.ByteString
        getTypeBytes() {
      java.lang.Object ref = type_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        type_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The unique identifier of the relationship type. Example:
     * `INSTANCE_TO_INSTANCEGROUP`
     * </pre>
     *
     * <code>string type = 4;</code>
     * @param value The type to set.
     * @return This builder for chaining.
     */
    public Builder setType(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      type_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The unique identifier of the relationship type. Example:
     * `INSTANCE_TO_INSTANCEGROUP`
     * </pre>
     *
     * <code>string type = 4;</code>
     * @return This builder for chaining.
     */
    public Builder clearType() {
      
      type_ = getDefaultInstance().getType();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The unique identifier of the relationship type. Example:
     * `INSTANCE_TO_INSTANCEGROUP`
     * </pre>
     *
     * <code>string type = 4;</code>
     * @param value The bytes for type to set.
     * @return This builder for chaining.
     */
    public Builder setTypeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      type_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object sourceResourceType_ = "";
    /**
     * <pre>
     * The source asset type. Example: `compute.googleapis.com/Instance`
     * </pre>
     *
     * <code>string source_resource_type = 1;</code>
     * @return The sourceResourceType.
     */
    public java.lang.String getSourceResourceType() {
      java.lang.Object ref = sourceResourceType_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        sourceResourceType_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The source asset type. Example: `compute.googleapis.com/Instance`
     * </pre>
     *
     * <code>string source_resource_type = 1;</code>
     * @return The bytes for sourceResourceType.
     */
    public com.google.protobuf.ByteString
        getSourceResourceTypeBytes() {
      java.lang.Object ref = sourceResourceType_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        sourceResourceType_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The source asset type. Example: `compute.googleapis.com/Instance`
     * </pre>
     *
     * <code>string source_resource_type = 1;</code>
     * @param value The sourceResourceType to set.
     * @return This builder for chaining.
     */
    public Builder setSourceResourceType(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      sourceResourceType_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The source asset type. Example: `compute.googleapis.com/Instance`
     * </pre>
     *
     * <code>string source_resource_type = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearSourceResourceType() {
      
      sourceResourceType_ = getDefaultInstance().getSourceResourceType();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The source asset type. Example: `compute.googleapis.com/Instance`
     * </pre>
     *
     * <code>string source_resource_type = 1;</code>
     * @param value The bytes for sourceResourceType to set.
     * @return This builder for chaining.
     */
    public Builder setSourceResourceTypeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      sourceResourceType_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object targetResourceType_ = "";
    /**
     * <pre>
     * The target asset type. Example: `compute.googleapis.com/Disk`
     * </pre>
     *
     * <code>string target_resource_type = 2;</code>
     * @return The targetResourceType.
     */
    public java.lang.String getTargetResourceType() {
      java.lang.Object ref = targetResourceType_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        targetResourceType_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The target asset type. Example: `compute.googleapis.com/Disk`
     * </pre>
     *
     * <code>string target_resource_type = 2;</code>
     * @return The bytes for targetResourceType.
     */
    public com.google.protobuf.ByteString
        getTargetResourceTypeBytes() {
      java.lang.Object ref = targetResourceType_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        targetResourceType_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The target asset type. Example: `compute.googleapis.com/Disk`
     * </pre>
     *
     * <code>string target_resource_type = 2;</code>
     * @param value The targetResourceType to set.
     * @return This builder for chaining.
     */
    public Builder setTargetResourceType(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      targetResourceType_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The target asset type. Example: `compute.googleapis.com/Disk`
     * </pre>
     *
     * <code>string target_resource_type = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearTargetResourceType() {
      
      targetResourceType_ = getDefaultInstance().getTargetResourceType();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The target asset type. Example: `compute.googleapis.com/Disk`
     * </pre>
     *
     * <code>string target_resource_type = 2;</code>
     * @param value The bytes for targetResourceType to set.
     * @return This builder for chaining.
     */
    public Builder setTargetResourceTypeBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      targetResourceType_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object action_ = "";
    /**
     * <pre>
     * The detail of the relationship, e.g. `contains`, `attaches`
     * </pre>
     *
     * <code>string action = 3;</code>
     * @return The action.
     */
    public java.lang.String getAction() {
      java.lang.Object ref = action_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        action_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The detail of the relationship, e.g. `contains`, `attaches`
     * </pre>
     *
     * <code>string action = 3;</code>
     * @return The bytes for action.
     */
    public com.google.protobuf.ByteString
        getActionBytes() {
      java.lang.Object ref = action_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        action_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The detail of the relationship, e.g. `contains`, `attaches`
     * </pre>
     *
     * <code>string action = 3;</code>
     * @param value The action to set.
     * @return This builder for chaining.
     */
    public Builder setAction(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      action_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The detail of the relationship, e.g. `contains`, `attaches`
     * </pre>
     *
     * <code>string action = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearAction() {
      
      action_ = getDefaultInstance().getAction();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The detail of the relationship, e.g. `contains`, `attaches`
     * </pre>
     *
     * <code>string action = 3;</code>
     * @param value The bytes for action to set.
     * @return This builder for chaining.
     */
    public Builder setActionBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      action_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.asset.v1p7beta1.RelationshipAttributes)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.asset.v1p7beta1.RelationshipAttributes)
  private static final com.google.cloud.asset.v1p7beta1.RelationshipAttributes DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.asset.v1p7beta1.RelationshipAttributes();
  }

  public static com.google.cloud.asset.v1p7beta1.RelationshipAttributes getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<RelationshipAttributes>
      PARSER = new com.google.protobuf.AbstractParser<RelationshipAttributes>() {
    @java.lang.Override
    public RelationshipAttributes parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new RelationshipAttributes(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<RelationshipAttributes> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<RelationshipAttributes> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.asset.v1p7beta1.RelationshipAttributes getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

