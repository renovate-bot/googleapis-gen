// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/data/v1beta/data.proto

package com.google.analytics.data.v1beta;

/**
 * <pre>
 * Optional settings of a cohort report.
 * </pre>
 *
 * Protobuf type {@code google.analytics.data.v1beta.CohortReportSettings}
 */
public final class CohortReportSettings extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.analytics.data.v1beta.CohortReportSettings)
    CohortReportSettingsOrBuilder {
private static final long serialVersionUID = 0L;
  // Use CohortReportSettings.newBuilder() to construct.
  private CohortReportSettings(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private CohortReportSettings() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new CohortReportSettings();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private CohortReportSettings(
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
          case 8: {

            accumulate_ = input.readBool();
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
    return com.google.analytics.data.v1beta.ReportingApiProto.internal_static_google_analytics_data_v1beta_CohortReportSettings_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.analytics.data.v1beta.ReportingApiProto.internal_static_google_analytics_data_v1beta_CohortReportSettings_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.analytics.data.v1beta.CohortReportSettings.class, com.google.analytics.data.v1beta.CohortReportSettings.Builder.class);
  }

  public static final int ACCUMULATE_FIELD_NUMBER = 1;
  private boolean accumulate_;
  /**
   * <pre>
   * If true, accumulates the result from first touch day to the end day. Not
   * supported in `RunReportRequest`.
   * </pre>
   *
   * <code>bool accumulate = 1;</code>
   * @return The accumulate.
   */
  @java.lang.Override
  public boolean getAccumulate() {
    return accumulate_;
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
    if (accumulate_ != false) {
      output.writeBool(1, accumulate_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (accumulate_ != false) {
      size += com.google.protobuf.CodedOutputStream
        .computeBoolSize(1, accumulate_);
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
    if (!(obj instanceof com.google.analytics.data.v1beta.CohortReportSettings)) {
      return super.equals(obj);
    }
    com.google.analytics.data.v1beta.CohortReportSettings other = (com.google.analytics.data.v1beta.CohortReportSettings) obj;

    if (getAccumulate()
        != other.getAccumulate()) return false;
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
    hash = (37 * hash) + ACCUMULATE_FIELD_NUMBER;
    hash = (53 * hash) + com.google.protobuf.Internal.hashBoolean(
        getAccumulate());
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.analytics.data.v1beta.CohortReportSettings parseFrom(
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
  public static Builder newBuilder(com.google.analytics.data.v1beta.CohortReportSettings prototype) {
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
   * Optional settings of a cohort report.
   * </pre>
   *
   * Protobuf type {@code google.analytics.data.v1beta.CohortReportSettings}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.analytics.data.v1beta.CohortReportSettings)
      com.google.analytics.data.v1beta.CohortReportSettingsOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.analytics.data.v1beta.ReportingApiProto.internal_static_google_analytics_data_v1beta_CohortReportSettings_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.analytics.data.v1beta.ReportingApiProto.internal_static_google_analytics_data_v1beta_CohortReportSettings_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.analytics.data.v1beta.CohortReportSettings.class, com.google.analytics.data.v1beta.CohortReportSettings.Builder.class);
    }

    // Construct using com.google.analytics.data.v1beta.CohortReportSettings.newBuilder()
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
      accumulate_ = false;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.analytics.data.v1beta.ReportingApiProto.internal_static_google_analytics_data_v1beta_CohortReportSettings_descriptor;
    }

    @java.lang.Override
    public com.google.analytics.data.v1beta.CohortReportSettings getDefaultInstanceForType() {
      return com.google.analytics.data.v1beta.CohortReportSettings.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.analytics.data.v1beta.CohortReportSettings build() {
      com.google.analytics.data.v1beta.CohortReportSettings result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.analytics.data.v1beta.CohortReportSettings buildPartial() {
      com.google.analytics.data.v1beta.CohortReportSettings result = new com.google.analytics.data.v1beta.CohortReportSettings(this);
      result.accumulate_ = accumulate_;
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
      if (other instanceof com.google.analytics.data.v1beta.CohortReportSettings) {
        return mergeFrom((com.google.analytics.data.v1beta.CohortReportSettings)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.analytics.data.v1beta.CohortReportSettings other) {
      if (other == com.google.analytics.data.v1beta.CohortReportSettings.getDefaultInstance()) return this;
      if (other.getAccumulate() != false) {
        setAccumulate(other.getAccumulate());
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
      com.google.analytics.data.v1beta.CohortReportSettings parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.analytics.data.v1beta.CohortReportSettings) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private boolean accumulate_ ;
    /**
     * <pre>
     * If true, accumulates the result from first touch day to the end day. Not
     * supported in `RunReportRequest`.
     * </pre>
     *
     * <code>bool accumulate = 1;</code>
     * @return The accumulate.
     */
    @java.lang.Override
    public boolean getAccumulate() {
      return accumulate_;
    }
    /**
     * <pre>
     * If true, accumulates the result from first touch day to the end day. Not
     * supported in `RunReportRequest`.
     * </pre>
     *
     * <code>bool accumulate = 1;</code>
     * @param value The accumulate to set.
     * @return This builder for chaining.
     */
    public Builder setAccumulate(boolean value) {
      
      accumulate_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * If true, accumulates the result from first touch day to the end day. Not
     * supported in `RunReportRequest`.
     * </pre>
     *
     * <code>bool accumulate = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearAccumulate() {
      
      accumulate_ = false;
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


    // @@protoc_insertion_point(builder_scope:google.analytics.data.v1beta.CohortReportSettings)
  }

  // @@protoc_insertion_point(class_scope:google.analytics.data.v1beta.CohortReportSettings)
  private static final com.google.analytics.data.v1beta.CohortReportSettings DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.analytics.data.v1beta.CohortReportSettings();
  }

  public static com.google.analytics.data.v1beta.CohortReportSettings getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<CohortReportSettings>
      PARSER = new com.google.protobuf.AbstractParser<CohortReportSettings>() {
    @java.lang.Override
    public CohortReportSettings parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new CohortReportSettings(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<CohortReportSettings> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<CohortReportSettings> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.analytics.data.v1beta.CohortReportSettings getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

