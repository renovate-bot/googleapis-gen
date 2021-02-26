// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v4/services/ad_group_criterion_label_service.proto

package com.google.ads.googleads.v4.services;

/**
 * <pre>
 * A single operation (create, remove) on an ad group criterion label.
 * </pre>
 *
 * Protobuf type {@code google.ads.googleads.v4.services.AdGroupCriterionLabelOperation}
 */
public final class AdGroupCriterionLabelOperation extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)
    AdGroupCriterionLabelOperationOrBuilder {
private static final long serialVersionUID = 0L;
  // Use AdGroupCriterionLabelOperation.newBuilder() to construct.
  private AdGroupCriterionLabelOperation(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private AdGroupCriterionLabelOperation() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new AdGroupCriterionLabelOperation();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private AdGroupCriterionLabelOperation(
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
            com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder subBuilder = null;
            if (operationCase_ == 1) {
              subBuilder = ((com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_).toBuilder();
            }
            operation_ =
                input.readMessage(com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_);
              operation_ = subBuilder.buildPartial();
            }
            operationCase_ = 1;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();
            operationCase_ = 2;
            operation_ = s;
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
    return com.google.ads.googleads.v4.services.AdGroupCriterionLabelServiceProto.internal_static_google_ads_googleads_v4_services_AdGroupCriterionLabelOperation_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.ads.googleads.v4.services.AdGroupCriterionLabelServiceProto.internal_static_google_ads_googleads_v4_services_AdGroupCriterionLabelOperation_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.class, com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.Builder.class);
  }

  private int operationCase_ = 0;
  private java.lang.Object operation_;
  public enum OperationCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    CREATE(1),
    REMOVE(2),
    OPERATION_NOT_SET(0);
    private final int value;
    private OperationCase(int value) {
      this.value = value;
    }
    /**
     * @param value The number of the enum to look for.
     * @return The enum associated with the given number.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static OperationCase valueOf(int value) {
      return forNumber(value);
    }

    public static OperationCase forNumber(int value) {
      switch (value) {
        case 1: return CREATE;
        case 2: return REMOVE;
        case 0: return OPERATION_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public OperationCase
  getOperationCase() {
    return OperationCase.forNumber(
        operationCase_);
  }

  public static final int CREATE_FIELD_NUMBER = 1;
  /**
   * <pre>
   * Create operation: No resource name is expected for the new ad group
   * label.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
   * @return Whether the create field is set.
   */
  @java.lang.Override
  public boolean hasCreate() {
    return operationCase_ == 1;
  }
  /**
   * <pre>
   * Create operation: No resource name is expected for the new ad group
   * label.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
   * @return The create.
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.resources.AdGroupCriterionLabel getCreate() {
    if (operationCase_ == 1) {
       return (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_;
    }
    return com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
  }
  /**
   * <pre>
   * Create operation: No resource name is expected for the new ad group
   * label.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.resources.AdGroupCriterionLabelOrBuilder getCreateOrBuilder() {
    if (operationCase_ == 1) {
       return (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_;
    }
    return com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
  }

  public static final int REMOVE_FIELD_NUMBER = 2;
  /**
   * <pre>
   * Remove operation: A resource name for the ad group criterion label
   * being removed, in this format:
   * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
   * </pre>
   *
   * <code>string remove = 2;</code>
   * @return Whether the remove field is set.
   */
  public boolean hasRemove() {
    return operationCase_ == 2;
  }
  /**
   * <pre>
   * Remove operation: A resource name for the ad group criterion label
   * being removed, in this format:
   * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
   * </pre>
   *
   * <code>string remove = 2;</code>
   * @return The remove.
   */
  public java.lang.String getRemove() {
    java.lang.Object ref = "";
    if (operationCase_ == 2) {
      ref = operation_;
    }
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      if (operationCase_ == 2) {
        operation_ = s;
      }
      return s;
    }
  }
  /**
   * <pre>
   * Remove operation: A resource name for the ad group criterion label
   * being removed, in this format:
   * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
   * </pre>
   *
   * <code>string remove = 2;</code>
   * @return The bytes for remove.
   */
  public com.google.protobuf.ByteString
      getRemoveBytes() {
    java.lang.Object ref = "";
    if (operationCase_ == 2) {
      ref = operation_;
    }
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      if (operationCase_ == 2) {
        operation_ = b;
      }
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
    if (operationCase_ == 1) {
      output.writeMessage(1, (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_);
    }
    if (operationCase_ == 2) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, operation_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (operationCase_ == 1) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_);
    }
    if (operationCase_ == 2) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, operation_);
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
    if (!(obj instanceof com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)) {
      return super.equals(obj);
    }
    com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation other = (com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation) obj;

    if (!getOperationCase().equals(other.getOperationCase())) return false;
    switch (operationCase_) {
      case 1:
        if (!getCreate()
            .equals(other.getCreate())) return false;
        break;
      case 2:
        if (!getRemove()
            .equals(other.getRemove())) return false;
        break;
      case 0:
      default:
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
    switch (operationCase_) {
      case 1:
        hash = (37 * hash) + CREATE_FIELD_NUMBER;
        hash = (53 * hash) + getCreate().hashCode();
        break;
      case 2:
        hash = (37 * hash) + REMOVE_FIELD_NUMBER;
        hash = (53 * hash) + getRemove().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parseFrom(
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
  public static Builder newBuilder(com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation prototype) {
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
   * A single operation (create, remove) on an ad group criterion label.
   * </pre>
   *
   * Protobuf type {@code google.ads.googleads.v4.services.AdGroupCriterionLabelOperation}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)
      com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperationOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.ads.googleads.v4.services.AdGroupCriterionLabelServiceProto.internal_static_google_ads_googleads_v4_services_AdGroupCriterionLabelOperation_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.ads.googleads.v4.services.AdGroupCriterionLabelServiceProto.internal_static_google_ads_googleads_v4_services_AdGroupCriterionLabelOperation_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.class, com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.Builder.class);
    }

    // Construct using com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.newBuilder()
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
      operationCase_ = 0;
      operation_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.ads.googleads.v4.services.AdGroupCriterionLabelServiceProto.internal_static_google_ads_googleads_v4_services_AdGroupCriterionLabelOperation_descriptor;
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation getDefaultInstanceForType() {
      return com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation build() {
      com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation buildPartial() {
      com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation result = new com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation(this);
      if (operationCase_ == 1) {
        if (createBuilder_ == null) {
          result.operation_ = operation_;
        } else {
          result.operation_ = createBuilder_.build();
        }
      }
      if (operationCase_ == 2) {
        result.operation_ = operation_;
      }
      result.operationCase_ = operationCase_;
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
      if (other instanceof com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation) {
        return mergeFrom((com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation other) {
      if (other == com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation.getDefaultInstance()) return this;
      switch (other.getOperationCase()) {
        case CREATE: {
          mergeCreate(other.getCreate());
          break;
        }
        case REMOVE: {
          operationCase_ = 2;
          operation_ = other.operation_;
          onChanged();
          break;
        }
        case OPERATION_NOT_SET: {
          break;
        }
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
      com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int operationCase_ = 0;
    private java.lang.Object operation_;
    public OperationCase
        getOperationCase() {
      return OperationCase.forNumber(
          operationCase_);
    }

    public Builder clearOperation() {
      operationCase_ = 0;
      operation_ = null;
      onChanged();
      return this;
    }


    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.ads.googleads.v4.resources.AdGroupCriterionLabel, com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder, com.google.ads.googleads.v4.resources.AdGroupCriterionLabelOrBuilder> createBuilder_;
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     * @return Whether the create field is set.
     */
    @java.lang.Override
    public boolean hasCreate() {
      return operationCase_ == 1;
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     * @return The create.
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.resources.AdGroupCriterionLabel getCreate() {
      if (createBuilder_ == null) {
        if (operationCase_ == 1) {
          return (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_;
        }
        return com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
      } else {
        if (operationCase_ == 1) {
          return createBuilder_.getMessage();
        }
        return com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    public Builder setCreate(com.google.ads.googleads.v4.resources.AdGroupCriterionLabel value) {
      if (createBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        operation_ = value;
        onChanged();
      } else {
        createBuilder_.setMessage(value);
      }
      operationCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    public Builder setCreate(
        com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder builderForValue) {
      if (createBuilder_ == null) {
        operation_ = builderForValue.build();
        onChanged();
      } else {
        createBuilder_.setMessage(builderForValue.build());
      }
      operationCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    public Builder mergeCreate(com.google.ads.googleads.v4.resources.AdGroupCriterionLabel value) {
      if (createBuilder_ == null) {
        if (operationCase_ == 1 &&
            operation_ != com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance()) {
          operation_ = com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.newBuilder((com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_)
              .mergeFrom(value).buildPartial();
        } else {
          operation_ = value;
        }
        onChanged();
      } else {
        if (operationCase_ == 1) {
          createBuilder_.mergeFrom(value);
        }
        createBuilder_.setMessage(value);
      }
      operationCase_ = 1;
      return this;
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    public Builder clearCreate() {
      if (createBuilder_ == null) {
        if (operationCase_ == 1) {
          operationCase_ = 0;
          operation_ = null;
          onChanged();
        }
      } else {
        if (operationCase_ == 1) {
          operationCase_ = 0;
          operation_ = null;
        }
        createBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    public com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder getCreateBuilder() {
      return getCreateFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.resources.AdGroupCriterionLabelOrBuilder getCreateOrBuilder() {
      if ((operationCase_ == 1) && (createBuilder_ != null)) {
        return createBuilder_.getMessageOrBuilder();
      } else {
        if (operationCase_ == 1) {
          return (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_;
        }
        return com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Create operation: No resource name is expected for the new ad group
     * label.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.resources.AdGroupCriterionLabel create = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.ads.googleads.v4.resources.AdGroupCriterionLabel, com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder, com.google.ads.googleads.v4.resources.AdGroupCriterionLabelOrBuilder> 
        getCreateFieldBuilder() {
      if (createBuilder_ == null) {
        if (!(operationCase_ == 1)) {
          operation_ = com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.getDefaultInstance();
        }
        createBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.ads.googleads.v4.resources.AdGroupCriterionLabel, com.google.ads.googleads.v4.resources.AdGroupCriterionLabel.Builder, com.google.ads.googleads.v4.resources.AdGroupCriterionLabelOrBuilder>(
                (com.google.ads.googleads.v4.resources.AdGroupCriterionLabel) operation_,
                getParentForChildren(),
                isClean());
        operation_ = null;
      }
      operationCase_ = 1;
      onChanged();;
      return createBuilder_;
    }

    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @return Whether the remove field is set.
     */
    @java.lang.Override
    public boolean hasRemove() {
      return operationCase_ == 2;
    }
    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @return The remove.
     */
    @java.lang.Override
    public java.lang.String getRemove() {
      java.lang.Object ref = "";
      if (operationCase_ == 2) {
        ref = operation_;
      }
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        if (operationCase_ == 2) {
          operation_ = s;
        }
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @return The bytes for remove.
     */
    @java.lang.Override
    public com.google.protobuf.ByteString
        getRemoveBytes() {
      java.lang.Object ref = "";
      if (operationCase_ == 2) {
        ref = operation_;
      }
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        if (operationCase_ == 2) {
          operation_ = b;
        }
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @param value The remove to set.
     * @return This builder for chaining.
     */
    public Builder setRemove(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  operationCase_ = 2;
      operation_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearRemove() {
      if (operationCase_ == 2) {
        operationCase_ = 0;
        operation_ = null;
        onChanged();
      }
      return this;
    }
    /**
     * <pre>
     * Remove operation: A resource name for the ad group criterion label
     * being removed, in this format:
     * `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
     * </pre>
     *
     * <code>string remove = 2;</code>
     * @param value The bytes for remove to set.
     * @return This builder for chaining.
     */
    public Builder setRemoveBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      operationCase_ = 2;
      operation_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)
  }

  // @@protoc_insertion_point(class_scope:google.ads.googleads.v4.services.AdGroupCriterionLabelOperation)
  private static final com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation();
  }

  public static com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<AdGroupCriterionLabelOperation>
      PARSER = new com.google.protobuf.AbstractParser<AdGroupCriterionLabelOperation>() {
    @java.lang.Override
    public AdGroupCriterionLabelOperation parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new AdGroupCriterionLabelOperation(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<AdGroupCriterionLabelOperation> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<AdGroupCriterionLabelOperation> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.ads.googleads.v4.services.AdGroupCriterionLabelOperation getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

