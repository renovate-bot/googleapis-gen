// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v4/services/offline_user_data_job_service.proto

package com.google.ads.googleads.v4.services;

/**
 * <pre>
 * Operation to be made for the AddOfflineUserDataJobOperationsRequest.
 * </pre>
 *
 * Protobuf type {@code google.ads.googleads.v4.services.OfflineUserDataJobOperation}
 */
public final class OfflineUserDataJobOperation extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.ads.googleads.v4.services.OfflineUserDataJobOperation)
    OfflineUserDataJobOperationOrBuilder {
private static final long serialVersionUID = 0L;
  // Use OfflineUserDataJobOperation.newBuilder() to construct.
  private OfflineUserDataJobOperation(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private OfflineUserDataJobOperation() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new OfflineUserDataJobOperation();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private OfflineUserDataJobOperation(
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
            com.google.ads.googleads.v4.common.UserData.Builder subBuilder = null;
            if (operationCase_ == 1) {
              subBuilder = ((com.google.ads.googleads.v4.common.UserData) operation_).toBuilder();
            }
            operation_ =
                input.readMessage(com.google.ads.googleads.v4.common.UserData.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.ads.googleads.v4.common.UserData) operation_);
              operation_ = subBuilder.buildPartial();
            }
            operationCase_ = 1;
            break;
          }
          case 18: {
            com.google.ads.googleads.v4.common.UserData.Builder subBuilder = null;
            if (operationCase_ == 2) {
              subBuilder = ((com.google.ads.googleads.v4.common.UserData) operation_).toBuilder();
            }
            operation_ =
                input.readMessage(com.google.ads.googleads.v4.common.UserData.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.ads.googleads.v4.common.UserData) operation_);
              operation_ = subBuilder.buildPartial();
            }
            operationCase_ = 2;
            break;
          }
          case 24: {
            operationCase_ = 3;
            operation_ = input.readBool();
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
    return com.google.ads.googleads.v4.services.OfflineUserDataJobServiceProto.internal_static_google_ads_googleads_v4_services_OfflineUserDataJobOperation_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.ads.googleads.v4.services.OfflineUserDataJobServiceProto.internal_static_google_ads_googleads_v4_services_OfflineUserDataJobOperation_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.class, com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.Builder.class);
  }

  private int operationCase_ = 0;
  private java.lang.Object operation_;
  public enum OperationCase
      implements com.google.protobuf.Internal.EnumLite,
          com.google.protobuf.AbstractMessage.InternalOneOfEnum {
    CREATE(1),
    REMOVE(2),
    REMOVE_ALL(3),
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
        case 3: return REMOVE_ALL;
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
   * Add the provided data to the transaction. Data cannot be retrieved after
   * being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
   * @return Whether the create field is set.
   */
  @java.lang.Override
  public boolean hasCreate() {
    return operationCase_ == 1;
  }
  /**
   * <pre>
   * Add the provided data to the transaction. Data cannot be retrieved after
   * being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
   * @return The create.
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.common.UserData getCreate() {
    if (operationCase_ == 1) {
       return (com.google.ads.googleads.v4.common.UserData) operation_;
    }
    return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
  }
  /**
   * <pre>
   * Add the provided data to the transaction. Data cannot be retrieved after
   * being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.common.UserDataOrBuilder getCreateOrBuilder() {
    if (operationCase_ == 1) {
       return (com.google.ads.googleads.v4.common.UserData) operation_;
    }
    return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
  }

  public static final int REMOVE_FIELD_NUMBER = 2;
  /**
   * <pre>
   * Remove the provided data from the transaction. Data cannot be retrieved
   * after being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
   * @return Whether the remove field is set.
   */
  @java.lang.Override
  public boolean hasRemove() {
    return operationCase_ == 2;
  }
  /**
   * <pre>
   * Remove the provided data from the transaction. Data cannot be retrieved
   * after being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
   * @return The remove.
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.common.UserData getRemove() {
    if (operationCase_ == 2) {
       return (com.google.ads.googleads.v4.common.UserData) operation_;
    }
    return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
  }
  /**
   * <pre>
   * Remove the provided data from the transaction. Data cannot be retrieved
   * after being uploaded.
   * </pre>
   *
   * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
   */
  @java.lang.Override
  public com.google.ads.googleads.v4.common.UserDataOrBuilder getRemoveOrBuilder() {
    if (operationCase_ == 2) {
       return (com.google.ads.googleads.v4.common.UserData) operation_;
    }
    return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
  }

  public static final int REMOVE_ALL_FIELD_NUMBER = 3;
  /**
   * <pre>
   * Remove all previously provided data. This is only supported for Customer
   * Match.
   * </pre>
   *
   * <code>bool remove_all = 3;</code>
   * @return Whether the removeAll field is set.
   */
  @java.lang.Override
  public boolean hasRemoveAll() {
    return operationCase_ == 3;
  }
  /**
   * <pre>
   * Remove all previously provided data. This is only supported for Customer
   * Match.
   * </pre>
   *
   * <code>bool remove_all = 3;</code>
   * @return The removeAll.
   */
  @java.lang.Override
  public boolean getRemoveAll() {
    if (operationCase_ == 3) {
      return (java.lang.Boolean) operation_;
    }
    return false;
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
      output.writeMessage(1, (com.google.ads.googleads.v4.common.UserData) operation_);
    }
    if (operationCase_ == 2) {
      output.writeMessage(2, (com.google.ads.googleads.v4.common.UserData) operation_);
    }
    if (operationCase_ == 3) {
      output.writeBool(
          3, (boolean)((java.lang.Boolean) operation_));
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
        .computeMessageSize(1, (com.google.ads.googleads.v4.common.UserData) operation_);
    }
    if (operationCase_ == 2) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, (com.google.ads.googleads.v4.common.UserData) operation_);
    }
    if (operationCase_ == 3) {
      size += com.google.protobuf.CodedOutputStream
        .computeBoolSize(
            3, (boolean)((java.lang.Boolean) operation_));
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
    if (!(obj instanceof com.google.ads.googleads.v4.services.OfflineUserDataJobOperation)) {
      return super.equals(obj);
    }
    com.google.ads.googleads.v4.services.OfflineUserDataJobOperation other = (com.google.ads.googleads.v4.services.OfflineUserDataJobOperation) obj;

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
      case 3:
        if (getRemoveAll()
            != other.getRemoveAll()) return false;
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
      case 3:
        hash = (37 * hash) + REMOVE_ALL_FIELD_NUMBER;
        hash = (53 * hash) + com.google.protobuf.Internal.hashBoolean(
            getRemoveAll());
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parseFrom(
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
  public static Builder newBuilder(com.google.ads.googleads.v4.services.OfflineUserDataJobOperation prototype) {
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
   * Operation to be made for the AddOfflineUserDataJobOperationsRequest.
   * </pre>
   *
   * Protobuf type {@code google.ads.googleads.v4.services.OfflineUserDataJobOperation}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.ads.googleads.v4.services.OfflineUserDataJobOperation)
      com.google.ads.googleads.v4.services.OfflineUserDataJobOperationOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.ads.googleads.v4.services.OfflineUserDataJobServiceProto.internal_static_google_ads_googleads_v4_services_OfflineUserDataJobOperation_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.ads.googleads.v4.services.OfflineUserDataJobServiceProto.internal_static_google_ads_googleads_v4_services_OfflineUserDataJobOperation_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.class, com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.Builder.class);
    }

    // Construct using com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.newBuilder()
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
      return com.google.ads.googleads.v4.services.OfflineUserDataJobServiceProto.internal_static_google_ads_googleads_v4_services_OfflineUserDataJobOperation_descriptor;
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.OfflineUserDataJobOperation getDefaultInstanceForType() {
      return com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.OfflineUserDataJobOperation build() {
      com.google.ads.googleads.v4.services.OfflineUserDataJobOperation result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.ads.googleads.v4.services.OfflineUserDataJobOperation buildPartial() {
      com.google.ads.googleads.v4.services.OfflineUserDataJobOperation result = new com.google.ads.googleads.v4.services.OfflineUserDataJobOperation(this);
      if (operationCase_ == 1) {
        if (createBuilder_ == null) {
          result.operation_ = operation_;
        } else {
          result.operation_ = createBuilder_.build();
        }
      }
      if (operationCase_ == 2) {
        if (removeBuilder_ == null) {
          result.operation_ = operation_;
        } else {
          result.operation_ = removeBuilder_.build();
        }
      }
      if (operationCase_ == 3) {
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
      if (other instanceof com.google.ads.googleads.v4.services.OfflineUserDataJobOperation) {
        return mergeFrom((com.google.ads.googleads.v4.services.OfflineUserDataJobOperation)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.ads.googleads.v4.services.OfflineUserDataJobOperation other) {
      if (other == com.google.ads.googleads.v4.services.OfflineUserDataJobOperation.getDefaultInstance()) return this;
      switch (other.getOperationCase()) {
        case CREATE: {
          mergeCreate(other.getCreate());
          break;
        }
        case REMOVE: {
          mergeRemove(other.getRemove());
          break;
        }
        case REMOVE_ALL: {
          setRemoveAll(other.getRemoveAll());
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
      com.google.ads.googleads.v4.services.OfflineUserDataJobOperation parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.ads.googleads.v4.services.OfflineUserDataJobOperation) e.getUnfinishedMessage();
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
        com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder> createBuilder_;
    /**
     * <pre>
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     * @return Whether the create field is set.
     */
    @java.lang.Override
    public boolean hasCreate() {
      return operationCase_ == 1;
    }
    /**
     * <pre>
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     * @return The create.
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.common.UserData getCreate() {
      if (createBuilder_ == null) {
        if (operationCase_ == 1) {
          return (com.google.ads.googleads.v4.common.UserData) operation_;
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      } else {
        if (operationCase_ == 1) {
          return createBuilder_.getMessage();
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    public Builder setCreate(com.google.ads.googleads.v4.common.UserData value) {
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
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    public Builder setCreate(
        com.google.ads.googleads.v4.common.UserData.Builder builderForValue) {
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
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    public Builder mergeCreate(com.google.ads.googleads.v4.common.UserData value) {
      if (createBuilder_ == null) {
        if (operationCase_ == 1 &&
            operation_ != com.google.ads.googleads.v4.common.UserData.getDefaultInstance()) {
          operation_ = com.google.ads.googleads.v4.common.UserData.newBuilder((com.google.ads.googleads.v4.common.UserData) operation_)
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
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
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
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    public com.google.ads.googleads.v4.common.UserData.Builder getCreateBuilder() {
      return getCreateFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.common.UserDataOrBuilder getCreateOrBuilder() {
      if ((operationCase_ == 1) && (createBuilder_ != null)) {
        return createBuilder_.getMessageOrBuilder();
      } else {
        if (operationCase_ == 1) {
          return (com.google.ads.googleads.v4.common.UserData) operation_;
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Add the provided data to the transaction. Data cannot be retrieved after
     * being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData create = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder> 
        getCreateFieldBuilder() {
      if (createBuilder_ == null) {
        if (!(operationCase_ == 1)) {
          operation_ = com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
        }
        createBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder>(
                (com.google.ads.googleads.v4.common.UserData) operation_,
                getParentForChildren(),
                isClean());
        operation_ = null;
      }
      operationCase_ = 1;
      onChanged();;
      return createBuilder_;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder> removeBuilder_;
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     * @return Whether the remove field is set.
     */
    @java.lang.Override
    public boolean hasRemove() {
      return operationCase_ == 2;
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     * @return The remove.
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.common.UserData getRemove() {
      if (removeBuilder_ == null) {
        if (operationCase_ == 2) {
          return (com.google.ads.googleads.v4.common.UserData) operation_;
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      } else {
        if (operationCase_ == 2) {
          return removeBuilder_.getMessage();
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    public Builder setRemove(com.google.ads.googleads.v4.common.UserData value) {
      if (removeBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        operation_ = value;
        onChanged();
      } else {
        removeBuilder_.setMessage(value);
      }
      operationCase_ = 2;
      return this;
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    public Builder setRemove(
        com.google.ads.googleads.v4.common.UserData.Builder builderForValue) {
      if (removeBuilder_ == null) {
        operation_ = builderForValue.build();
        onChanged();
      } else {
        removeBuilder_.setMessage(builderForValue.build());
      }
      operationCase_ = 2;
      return this;
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    public Builder mergeRemove(com.google.ads.googleads.v4.common.UserData value) {
      if (removeBuilder_ == null) {
        if (operationCase_ == 2 &&
            operation_ != com.google.ads.googleads.v4.common.UserData.getDefaultInstance()) {
          operation_ = com.google.ads.googleads.v4.common.UserData.newBuilder((com.google.ads.googleads.v4.common.UserData) operation_)
              .mergeFrom(value).buildPartial();
        } else {
          operation_ = value;
        }
        onChanged();
      } else {
        if (operationCase_ == 2) {
          removeBuilder_.mergeFrom(value);
        }
        removeBuilder_.setMessage(value);
      }
      operationCase_ = 2;
      return this;
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    public Builder clearRemove() {
      if (removeBuilder_ == null) {
        if (operationCase_ == 2) {
          operationCase_ = 0;
          operation_ = null;
          onChanged();
        }
      } else {
        if (operationCase_ == 2) {
          operationCase_ = 0;
          operation_ = null;
        }
        removeBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    public com.google.ads.googleads.v4.common.UserData.Builder getRemoveBuilder() {
      return getRemoveFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    @java.lang.Override
    public com.google.ads.googleads.v4.common.UserDataOrBuilder getRemoveOrBuilder() {
      if ((operationCase_ == 2) && (removeBuilder_ != null)) {
        return removeBuilder_.getMessageOrBuilder();
      } else {
        if (operationCase_ == 2) {
          return (com.google.ads.googleads.v4.common.UserData) operation_;
        }
        return com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Remove the provided data from the transaction. Data cannot be retrieved
     * after being uploaded.
     * </pre>
     *
     * <code>.google.ads.googleads.v4.common.UserData remove = 2;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder> 
        getRemoveFieldBuilder() {
      if (removeBuilder_ == null) {
        if (!(operationCase_ == 2)) {
          operation_ = com.google.ads.googleads.v4.common.UserData.getDefaultInstance();
        }
        removeBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.ads.googleads.v4.common.UserData, com.google.ads.googleads.v4.common.UserData.Builder, com.google.ads.googleads.v4.common.UserDataOrBuilder>(
                (com.google.ads.googleads.v4.common.UserData) operation_,
                getParentForChildren(),
                isClean());
        operation_ = null;
      }
      operationCase_ = 2;
      onChanged();;
      return removeBuilder_;
    }

    /**
     * <pre>
     * Remove all previously provided data. This is only supported for Customer
     * Match.
     * </pre>
     *
     * <code>bool remove_all = 3;</code>
     * @return Whether the removeAll field is set.
     */
    public boolean hasRemoveAll() {
      return operationCase_ == 3;
    }
    /**
     * <pre>
     * Remove all previously provided data. This is only supported for Customer
     * Match.
     * </pre>
     *
     * <code>bool remove_all = 3;</code>
     * @return The removeAll.
     */
    public boolean getRemoveAll() {
      if (operationCase_ == 3) {
        return (java.lang.Boolean) operation_;
      }
      return false;
    }
    /**
     * <pre>
     * Remove all previously provided data. This is only supported for Customer
     * Match.
     * </pre>
     *
     * <code>bool remove_all = 3;</code>
     * @param value The removeAll to set.
     * @return This builder for chaining.
     */
    public Builder setRemoveAll(boolean value) {
      operationCase_ = 3;
      operation_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Remove all previously provided data. This is only supported for Customer
     * Match.
     * </pre>
     *
     * <code>bool remove_all = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearRemoveAll() {
      if (operationCase_ == 3) {
        operationCase_ = 0;
        operation_ = null;
        onChanged();
      }
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


    // @@protoc_insertion_point(builder_scope:google.ads.googleads.v4.services.OfflineUserDataJobOperation)
  }

  // @@protoc_insertion_point(class_scope:google.ads.googleads.v4.services.OfflineUserDataJobOperation)
  private static final com.google.ads.googleads.v4.services.OfflineUserDataJobOperation DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.ads.googleads.v4.services.OfflineUserDataJobOperation();
  }

  public static com.google.ads.googleads.v4.services.OfflineUserDataJobOperation getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<OfflineUserDataJobOperation>
      PARSER = new com.google.protobuf.AbstractParser<OfflineUserDataJobOperation>() {
    @java.lang.Override
    public OfflineUserDataJobOperation parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new OfflineUserDataJobOperation(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<OfflineUserDataJobOperation> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<OfflineUserDataJobOperation> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.ads.googleads.v4.services.OfflineUserDataJobOperation getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

