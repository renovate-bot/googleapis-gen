// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/testing/v1/test_execution.proto

package com.google.devtools.testing.v1;

/**
 * <pre>
 * Request to stop running all of the tests in the specified matrix.
 * </pre>
 *
 * Protobuf type {@code google.devtools.testing.v1.CancelTestMatrixRequest}
 */
public final class CancelTestMatrixRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.devtools.testing.v1.CancelTestMatrixRequest)
    CancelTestMatrixRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CancelTestMatrixRequest.newBuilder() to construct.
  private CancelTestMatrixRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CancelTestMatrixRequest() {
    projectId_ = "";
    testMatrixId_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CancelTestMatrixRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CancelTestMatrixRequest(
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
            java.lang.String s = input.readStringRequireUtf8();

            testMatrixId_ = s;
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
    return com.google.devtools.testing.v1.TestExecutionProto.internal_static_google_devtools_testing_v1_CancelTestMatrixRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.devtools.testing.v1.TestExecutionProto.internal_static_google_devtools_testing_v1_CancelTestMatrixRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.devtools.testing.v1.CancelTestMatrixRequest.class, com.google.devtools.testing.v1.CancelTestMatrixRequest.Builder.class);
  }

  public static final int PROJECT_ID_FIELD_NUMBER = 1;
  private volatile java.lang.Object projectId_;
  /**
   * <pre>
   * Cloud project that owns the test.
   * </pre>
   *
   * <code>string project_id = 1;</code>
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
   * Cloud project that owns the test.
   * </pre>
   *
   * <code>string project_id = 1;</code>
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

  public static final int TEST_MATRIX_ID_FIELD_NUMBER = 2;
  private volatile java.lang.Object testMatrixId_;
  /**
   * <pre>
   * Test matrix that will be canceled.
   * </pre>
   *
   * <code>string test_matrix_id = 2;</code>
   * @return The testMatrixId.
   */
  @java.lang.Override
  public java.lang.String getTestMatrixId() {
    java.lang.Object ref = testMatrixId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      testMatrixId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Test matrix that will be canceled.
   * </pre>
   *
   * <code>string test_matrix_id = 2;</code>
   * @return The bytes for testMatrixId.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getTestMatrixIdBytes() {
    java.lang.Object ref = testMatrixId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      testMatrixId_ = b;
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(projectId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, projectId_);
    }
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(testMatrixId_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, testMatrixId_);
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(testMatrixId_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, testMatrixId_);
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
    if (!(obj instanceof com.google.devtools.testing.v1.CancelTestMatrixRequest)) {
      return super.equals(obj);
    }
    com.google.devtools.testing.v1.CancelTestMatrixRequest other = (com.google.devtools.testing.v1.CancelTestMatrixRequest) obj;

    if (!getProjectId()
        .equals(other.getProjectId())) return false;
    if (!getTestMatrixId()
        .equals(other.getTestMatrixId())) return false;
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
    hash = (37 * hash) + PROJECT_ID_FIELD_NUMBER;
    hash = (53 * hash) + getProjectId().hashCode();
    hash = (37 * hash) + TEST_MATRIX_ID_FIELD_NUMBER;
    hash = (53 * hash) + getTestMatrixId().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.devtools.testing.v1.CancelTestMatrixRequest parseFrom(
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
  public static Builder newBuilder(com.google.devtools.testing.v1.CancelTestMatrixRequest prototype) {
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
   * Request to stop running all of the tests in the specified matrix.
   * </pre>
   *
   * Protobuf type {@code google.devtools.testing.v1.CancelTestMatrixRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.devtools.testing.v1.CancelTestMatrixRequest)
      com.google.devtools.testing.v1.CancelTestMatrixRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.devtools.testing.v1.TestExecutionProto.internal_static_google_devtools_testing_v1_CancelTestMatrixRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.devtools.testing.v1.TestExecutionProto.internal_static_google_devtools_testing_v1_CancelTestMatrixRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.devtools.testing.v1.CancelTestMatrixRequest.class, com.google.devtools.testing.v1.CancelTestMatrixRequest.Builder.class);
    }

    // Construct using com.google.devtools.testing.v1.CancelTestMatrixRequest.newBuilder()
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
      projectId_ = "";

      testMatrixId_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.devtools.testing.v1.TestExecutionProto.internal_static_google_devtools_testing_v1_CancelTestMatrixRequest_descriptor;
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.CancelTestMatrixRequest getDefaultInstanceForType() {
      return com.google.devtools.testing.v1.CancelTestMatrixRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.CancelTestMatrixRequest build() {
      com.google.devtools.testing.v1.CancelTestMatrixRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.devtools.testing.v1.CancelTestMatrixRequest buildPartial() {
      com.google.devtools.testing.v1.CancelTestMatrixRequest result = new com.google.devtools.testing.v1.CancelTestMatrixRequest(this);
      result.projectId_ = projectId_;
      result.testMatrixId_ = testMatrixId_;
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
      if (other instanceof com.google.devtools.testing.v1.CancelTestMatrixRequest) {
        return mergeFrom((com.google.devtools.testing.v1.CancelTestMatrixRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.devtools.testing.v1.CancelTestMatrixRequest other) {
      if (other == com.google.devtools.testing.v1.CancelTestMatrixRequest.getDefaultInstance()) return this;
      if (!other.getProjectId().isEmpty()) {
        projectId_ = other.projectId_;
        onChanged();
      }
      if (!other.getTestMatrixId().isEmpty()) {
        testMatrixId_ = other.testMatrixId_;
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
      com.google.devtools.testing.v1.CancelTestMatrixRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.devtools.testing.v1.CancelTestMatrixRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object projectId_ = "";
    /**
     * <pre>
     * Cloud project that owns the test.
     * </pre>
     *
     * <code>string project_id = 1;</code>
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
     * Cloud project that owns the test.
     * </pre>
     *
     * <code>string project_id = 1;</code>
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
     * Cloud project that owns the test.
     * </pre>
     *
     * <code>string project_id = 1;</code>
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
     * Cloud project that owns the test.
     * </pre>
     *
     * <code>string project_id = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearProjectId() {
      
      projectId_ = getDefaultInstance().getProjectId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Cloud project that owns the test.
     * </pre>
     *
     * <code>string project_id = 1;</code>
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

    private java.lang.Object testMatrixId_ = "";
    /**
     * <pre>
     * Test matrix that will be canceled.
     * </pre>
     *
     * <code>string test_matrix_id = 2;</code>
     * @return The testMatrixId.
     */
    public java.lang.String getTestMatrixId() {
      java.lang.Object ref = testMatrixId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        testMatrixId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Test matrix that will be canceled.
     * </pre>
     *
     * <code>string test_matrix_id = 2;</code>
     * @return The bytes for testMatrixId.
     */
    public com.google.protobuf.ByteString
        getTestMatrixIdBytes() {
      java.lang.Object ref = testMatrixId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        testMatrixId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Test matrix that will be canceled.
     * </pre>
     *
     * <code>string test_matrix_id = 2;</code>
     * @param value The testMatrixId to set.
     * @return This builder for chaining.
     */
    public Builder setTestMatrixId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      testMatrixId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Test matrix that will be canceled.
     * </pre>
     *
     * <code>string test_matrix_id = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearTestMatrixId() {
      
      testMatrixId_ = getDefaultInstance().getTestMatrixId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Test matrix that will be canceled.
     * </pre>
     *
     * <code>string test_matrix_id = 2;</code>
     * @param value The bytes for testMatrixId to set.
     * @return This builder for chaining.
     */
    public Builder setTestMatrixIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      testMatrixId_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.devtools.testing.v1.CancelTestMatrixRequest)
  }

  // @@protoc_insertion_point(class_scope:google.devtools.testing.v1.CancelTestMatrixRequest)
  private static final com.google.devtools.testing.v1.CancelTestMatrixRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.devtools.testing.v1.CancelTestMatrixRequest();
  }

  public static com.google.devtools.testing.v1.CancelTestMatrixRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CancelTestMatrixRequest>
      PARSER = new com.google.protobuf.AbstractParser<CancelTestMatrixRequest>() {
    @java.lang.Override
    public CancelTestMatrixRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CancelTestMatrixRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CancelTestMatrixRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CancelTestMatrixRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.devtools.testing.v1.CancelTestMatrixRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

