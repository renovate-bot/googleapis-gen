// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/home/enterprise/sdm/v1/smart_device_management_service.proto

package com.google.home.enterprise.sdm.v1;

/**
 * <pre>
 * Request message for SmartDeviceManagementService.ExecuteDeviceCommand
 * </pre>
 *
 * Protobuf type {@code google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest}
 */
public final class ExecuteDeviceCommandRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)
    ExecuteDeviceCommandRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ExecuteDeviceCommandRequest.newBuilder() to construct.
  private ExecuteDeviceCommandRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ExecuteDeviceCommandRequest() {
    name_ = "";
    command_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ExecuteDeviceCommandRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ExecuteDeviceCommandRequest(
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

            name_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            command_ = s;
            break;
          }
          case 26: {
            com.google.protobuf.Struct.Builder subBuilder = null;
            if (params_ != null) {
              subBuilder = params_.toBuilder();
            }
            params_ = input.readMessage(com.google.protobuf.Struct.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(params_);
              params_ = subBuilder.buildPartial();
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
    return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.internal_static_google_home_enterprise_sdm_v1_ExecuteDeviceCommandRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.internal_static_google_home_enterprise_sdm_v1_ExecuteDeviceCommandRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.class, com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.Builder.class);
  }

  public static final int NAME_FIELD_NUMBER = 1;
  private volatile java.lang.Object name_;
  /**
   * <pre>
   * The name of the device requested. For example:
   * "enterprises/XYZ/devices/123"
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  @java.lang.Override
  public java.lang.String getName() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      name_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The name of the device requested. For example:
   * "enterprises/XYZ/devices/123"
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getNameBytes() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      name_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int COMMAND_FIELD_NUMBER = 2;
  private volatile java.lang.Object command_;
  /**
   * <pre>
   * The command name to execute, represented by the fully qualified protobuf
   * message name.
   * </pre>
   *
   * <code>string command = 2;</code>
   * @return The command.
   */
  @java.lang.Override
  public java.lang.String getCommand() {
    java.lang.Object ref = command_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      command_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The command name to execute, represented by the fully qualified protobuf
   * message name.
   * </pre>
   *
   * <code>string command = 2;</code>
   * @return The bytes for command.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getCommandBytes() {
    java.lang.Object ref = command_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      command_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int PARAMS_FIELD_NUMBER = 3;
  private com.google.protobuf.Struct params_;
  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   * @return Whether the params field is set.
   */
  @java.lang.Override
  public boolean hasParams() {
    return params_ != null;
  }
  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   * @return The params.
   */
  @java.lang.Override
  public com.google.protobuf.Struct getParams() {
    return params_ == null ? com.google.protobuf.Struct.getDefaultInstance() : params_;
  }
  /**
   * <pre>
   * The command message to execute, represented as a Struct.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 3;</code>
   */
  @java.lang.Override
  public com.google.protobuf.StructOrBuilder getParamsOrBuilder() {
    return getParams();
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(name_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, name_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(command_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, command_);
    }
    if (params_ != null) {
      output.writeMessage(3, getParams());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(name_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, name_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(command_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, command_);
    }
    if (params_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, getParams());
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
    if (!(obj instanceof com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)) {
      return super.equals(obj);
    }
    com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest other = (com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest) obj;

    if (!getName()
        .equals(other.getName())) return false;
    if (!getCommand()
        .equals(other.getCommand())) return false;
    if (hasParams() != other.hasParams()) return false;
    if (hasParams()) {
      if (!getParams()
          .equals(other.getParams())) return false;
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
    hash = (37 * hash) + NAME_FIELD_NUMBER;
    hash = (53 * hash) + getName().hashCode();
    hash = (37 * hash) + COMMAND_FIELD_NUMBER;
    hash = (53 * hash) + getCommand().hashCode();
    if (hasParams()) {
      hash = (37 * hash) + PARAMS_FIELD_NUMBER;
      hash = (53 * hash) + getParams().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parseFrom(
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
  public static Builder newBuilder(com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest prototype) {
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
   * Request message for SmartDeviceManagementService.ExecuteDeviceCommand
   * </pre>
   *
   * Protobuf type {@code google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.internal_static_google_home_enterprise_sdm_v1_ExecuteDeviceCommandRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.internal_static_google_home_enterprise_sdm_v1_ExecuteDeviceCommandRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.class, com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.Builder.class);
    }

    // Construct using com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.newBuilder()
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
      name_ = "";

      command_ = "";

      if (paramsBuilder_ == null) {
        params_ = null;
      } else {
        params_ = null;
        paramsBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.internal_static_google_home_enterprise_sdm_v1_ExecuteDeviceCommandRequest_descriptor;
    }

    @java.lang.Override
    public com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest getDefaultInstanceForType() {
      return com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest build() {
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest buildPartial() {
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest result = new com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest(this);
      result.name_ = name_;
      result.command_ = command_;
      if (paramsBuilder_ == null) {
        result.params_ = params_;
      } else {
        result.params_ = paramsBuilder_.build();
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
      if (other instanceof com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest) {
        return mergeFrom((com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest other) {
      if (other == com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.getDefaultInstance()) return this;
      if (!other.getName().isEmpty()) {
        name_ = other.name_;
        onChanged();
      }
      if (!other.getCommand().isEmpty()) {
        command_ = other.command_;
        onChanged();
      }
      if (other.hasParams()) {
        mergeParams(other.getParams());
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
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object name_ = "";
    /**
     * <pre>
     * The name of the device requested. For example:
     * "enterprises/XYZ/devices/123"
     * </pre>
     *
     * <code>string name = 1;</code>
     * @return The name.
     */
    public java.lang.String getName() {
      java.lang.Object ref = name_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        name_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The name of the device requested. For example:
     * "enterprises/XYZ/devices/123"
     * </pre>
     *
     * <code>string name = 1;</code>
     * @return The bytes for name.
     */
    public com.google.protobuf.ByteString
        getNameBytes() {
      java.lang.Object ref = name_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        name_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The name of the device requested. For example:
     * "enterprises/XYZ/devices/123"
     * </pre>
     *
     * <code>string name = 1;</code>
     * @param value The name to set.
     * @return This builder for chaining.
     */
    public Builder setName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      name_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the device requested. For example:
     * "enterprises/XYZ/devices/123"
     * </pre>
     *
     * <code>string name = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearName() {
      
      name_ = getDefaultInstance().getName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the device requested. For example:
     * "enterprises/XYZ/devices/123"
     * </pre>
     *
     * <code>string name = 1;</code>
     * @param value The bytes for name to set.
     * @return This builder for chaining.
     */
    public Builder setNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      name_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object command_ = "";
    /**
     * <pre>
     * The command name to execute, represented by the fully qualified protobuf
     * message name.
     * </pre>
     *
     * <code>string command = 2;</code>
     * @return The command.
     */
    public java.lang.String getCommand() {
      java.lang.Object ref = command_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        command_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The command name to execute, represented by the fully qualified protobuf
     * message name.
     * </pre>
     *
     * <code>string command = 2;</code>
     * @return The bytes for command.
     */
    public com.google.protobuf.ByteString
        getCommandBytes() {
      java.lang.Object ref = command_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        command_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The command name to execute, represented by the fully qualified protobuf
     * message name.
     * </pre>
     *
     * <code>string command = 2;</code>
     * @param value The command to set.
     * @return This builder for chaining.
     */
    public Builder setCommand(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      command_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The command name to execute, represented by the fully qualified protobuf
     * message name.
     * </pre>
     *
     * <code>string command = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearCommand() {
      
      command_ = getDefaultInstance().getCommand();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The command name to execute, represented by the fully qualified protobuf
     * message name.
     * </pre>
     *
     * <code>string command = 2;</code>
     * @param value The bytes for command to set.
     * @return This builder for chaining.
     */
    public Builder setCommandBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      command_ = value;
      onChanged();
      return this;
    }

    private com.google.protobuf.Struct params_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Struct, com.google.protobuf.Struct.Builder, com.google.protobuf.StructOrBuilder> paramsBuilder_;
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     * @return Whether the params field is set.
     */
    public boolean hasParams() {
      return paramsBuilder_ != null || params_ != null;
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     * @return The params.
     */
    public com.google.protobuf.Struct getParams() {
      if (paramsBuilder_ == null) {
        return params_ == null ? com.google.protobuf.Struct.getDefaultInstance() : params_;
      } else {
        return paramsBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public Builder setParams(com.google.protobuf.Struct value) {
      if (paramsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        params_ = value;
        onChanged();
      } else {
        paramsBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public Builder setParams(
        com.google.protobuf.Struct.Builder builderForValue) {
      if (paramsBuilder_ == null) {
        params_ = builderForValue.build();
        onChanged();
      } else {
        paramsBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public Builder mergeParams(com.google.protobuf.Struct value) {
      if (paramsBuilder_ == null) {
        if (params_ != null) {
          params_ =
            com.google.protobuf.Struct.newBuilder(params_).mergeFrom(value).buildPartial();
        } else {
          params_ = value;
        }
        onChanged();
      } else {
        paramsBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public Builder clearParams() {
      if (paramsBuilder_ == null) {
        params_ = null;
        onChanged();
      } else {
        params_ = null;
        paramsBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public com.google.protobuf.Struct.Builder getParamsBuilder() {
      
      onChanged();
      return getParamsFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    public com.google.protobuf.StructOrBuilder getParamsOrBuilder() {
      if (paramsBuilder_ != null) {
        return paramsBuilder_.getMessageOrBuilder();
      } else {
        return params_ == null ?
            com.google.protobuf.Struct.getDefaultInstance() : params_;
      }
    }
    /**
     * <pre>
     * The command message to execute, represented as a Struct.
     * </pre>
     *
     * <code>.google.protobuf.Struct params = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Struct, com.google.protobuf.Struct.Builder, com.google.protobuf.StructOrBuilder> 
        getParamsFieldBuilder() {
      if (paramsBuilder_ == null) {
        paramsBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.protobuf.Struct, com.google.protobuf.Struct.Builder, com.google.protobuf.StructOrBuilder>(
                getParams(),
                getParentForChildren(),
                isClean());
        params_ = null;
      }
      return paramsBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)
  }

  // @@protoc_insertion_point(class_scope:google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest)
  private static final com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest();
  }

  public static com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ExecuteDeviceCommandRequest>
      PARSER = new com.google.protobuf.AbstractParser<ExecuteDeviceCommandRequest>() {
    @java.lang.Override
    public ExecuteDeviceCommandRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ExecuteDeviceCommandRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ExecuteDeviceCommandRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ExecuteDeviceCommandRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

