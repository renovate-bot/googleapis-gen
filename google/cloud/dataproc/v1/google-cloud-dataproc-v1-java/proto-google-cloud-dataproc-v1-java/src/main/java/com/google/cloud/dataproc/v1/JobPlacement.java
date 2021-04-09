// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1/jobs.proto

package com.google.cloud.dataproc.v1;

/**
 * <pre>
 * Dataproc job config.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dataproc.v1.JobPlacement}
 */
public final class JobPlacement extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dataproc.v1.JobPlacement)
    JobPlacementOrBuilder {
private static final long serialVersionUID = 0L;
  // Use JobPlacement.newBuilder() to construct.
  private JobPlacement(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private JobPlacement() {
    clusterName_ = "";
    clusterUuid_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new JobPlacement();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private JobPlacement(
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
            java.lang.String s = input.readStringRequireUtf8();

            clusterName_ = s;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            clusterUuid_ = s;
            break;
          }
          case 26: {
            if (!((mutable_bitField0_ & 0x00000001) != 0)) {
              clusterLabels_ = com.google.protobuf.MapField.newMapField(
                  ClusterLabelsDefaultEntryHolder.defaultEntry);
              mutable_bitField0_ |= 0x00000001;
            }
            com.google.protobuf.MapEntry<java.lang.String, java.lang.String>
            clusterLabels__ = input.readMessage(
                ClusterLabelsDefaultEntryHolder.defaultEntry.getParserForType(), extensionRegistry);
            clusterLabels_.getMutableMap().put(
                clusterLabels__.getKey(), clusterLabels__.getValue());
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
    return com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_descriptor;
  }

  @SuppressWarnings({"rawtypes"})
  @java.lang.Override
  protected com.google.protobuf.MapField internalGetMapField(
      int number) {
    switch (number) {
      case 3:
        return internalGetClusterLabels();
      default:
        throw new RuntimeException(
            "Invalid map field number: " + number);
    }
  }
  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dataproc.v1.JobPlacement.class, com.google.cloud.dataproc.v1.JobPlacement.Builder.class);
  }

  public static final int CLUSTER_NAME_FIELD_NUMBER = 1;
  private volatile java.lang.Object clusterName_;
  /**
   * <pre>
   * Required. The name of the cluster where the job will be submitted.
   * </pre>
   *
   * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The clusterName.
   */
  @java.lang.Override
  public java.lang.String getClusterName() {
    java.lang.Object ref = clusterName_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      clusterName_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. The name of the cluster where the job will be submitted.
   * </pre>
   *
   * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for clusterName.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getClusterNameBytes() {
    java.lang.Object ref = clusterName_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      clusterName_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CLUSTER_UUID_FIELD_NUMBER = 2;
  private volatile java.lang.Object clusterUuid_;
  /**
   * <pre>
   * Output only. A cluster UUID generated by the Dataproc service when
   * the job is submitted.
   * </pre>
   *
   * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The clusterUuid.
   */
  @java.lang.Override
  public java.lang.String getClusterUuid() {
    java.lang.Object ref = clusterUuid_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      clusterUuid_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Output only. A cluster UUID generated by the Dataproc service when
   * the job is submitted.
   * </pre>
   *
   * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for clusterUuid.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getClusterUuidBytes() {
    java.lang.Object ref = clusterUuid_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      clusterUuid_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CLUSTER_LABELS_FIELD_NUMBER = 3;
  private static final class ClusterLabelsDefaultEntryHolder {
    static final com.google.protobuf.MapEntry<
        java.lang.String, java.lang.String> defaultEntry =
            com.google.protobuf.MapEntry
            .<java.lang.String, java.lang.String>newDefaultInstance(
                com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_ClusterLabelsEntry_descriptor, 
                com.google.protobuf.WireFormat.FieldType.STRING,
                "",
                com.google.protobuf.WireFormat.FieldType.STRING,
                "");
  }
  private com.google.protobuf.MapField<
      java.lang.String, java.lang.String> clusterLabels_;
  private com.google.protobuf.MapField<java.lang.String, java.lang.String>
  internalGetClusterLabels() {
    if (clusterLabels_ == null) {
      return com.google.protobuf.MapField.emptyMapField(
          ClusterLabelsDefaultEntryHolder.defaultEntry);
    }
    return clusterLabels_;
  }

  public int getClusterLabelsCount() {
    return internalGetClusterLabels().getMap().size();
  }
  /**
   * <pre>
   * Optional. Cluster labels to identify a cluster where the job will be
   * submitted.
   * </pre>
   *
   * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   */

  @java.lang.Override
  public boolean containsClusterLabels(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    return internalGetClusterLabels().getMap().containsKey(key);
  }
  /**
   * Use {@link #getClusterLabelsMap()} instead.
   */
  @java.lang.Override
  @java.lang.Deprecated
  public java.util.Map<java.lang.String, java.lang.String> getClusterLabels() {
    return getClusterLabelsMap();
  }
  /**
   * <pre>
   * Optional. Cluster labels to identify a cluster where the job will be
   * submitted.
   * </pre>
   *
   * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   */
  @java.lang.Override

  public java.util.Map<java.lang.String, java.lang.String> getClusterLabelsMap() {
    return internalGetClusterLabels().getMap();
  }
  /**
   * <pre>
   * Optional. Cluster labels to identify a cluster where the job will be
   * submitted.
   * </pre>
   *
   * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   */
  @java.lang.Override

  public java.lang.String getClusterLabelsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, java.lang.String> map =
        internalGetClusterLabels().getMap();
    return map.containsKey(key) ? map.get(key) : defaultValue;
  }
  /**
   * <pre>
   * Optional. Cluster labels to identify a cluster where the job will be
   * submitted.
   * </pre>
   *
   * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   */
  @java.lang.Override

  public java.lang.String getClusterLabelsOrThrow(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, java.lang.String> map =
        internalGetClusterLabels().getMap();
    if (!map.containsKey(key)) {
      throw new java.lang.IllegalArgumentException();
    }
    return map.get(key);
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
    if (!getClusterNameBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, clusterName_);
    }
    if (!getClusterUuidBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, clusterUuid_);
    }
    com.google.protobuf.GeneratedMessageV3
      .serializeStringMapTo(
        output,
        internalGetClusterLabels(),
        ClusterLabelsDefaultEntryHolder.defaultEntry,
        3);
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getClusterNameBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, clusterName_);
    }
    if (!getClusterUuidBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, clusterUuid_);
    }
    for (java.util.Map.Entry<java.lang.String, java.lang.String> entry
         : internalGetClusterLabels().getMap().entrySet()) {
      com.google.protobuf.MapEntry<java.lang.String, java.lang.String>
      clusterLabels__ = ClusterLabelsDefaultEntryHolder.defaultEntry.newBuilderForType()
          .setKey(entry.getKey())
          .setValue(entry.getValue())
          .build();
      size += com.google.protobuf.CodedOutputStream
          .computeMessageSize(3, clusterLabels__);
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
    if (!(obj instanceof com.google.cloud.dataproc.v1.JobPlacement)) {
      return super.equals(obj);
    }
    com.google.cloud.dataproc.v1.JobPlacement other = (com.google.cloud.dataproc.v1.JobPlacement) obj;

    if (!getClusterName()
        .equals(other.getClusterName())) return false;
    if (!getClusterUuid()
        .equals(other.getClusterUuid())) return false;
    if (!internalGetClusterLabels().equals(
        other.internalGetClusterLabels())) return false;
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
    hash = (37 * hash) + CLUSTER_NAME_FIELD_NUMBER;
    hash = (53 * hash) + getClusterName().hashCode();
    hash = (37 * hash) + CLUSTER_UUID_FIELD_NUMBER;
    hash = (53 * hash) + getClusterUuid().hashCode();
    if (!internalGetClusterLabels().getMap().isEmpty()) {
      hash = (37 * hash) + CLUSTER_LABELS_FIELD_NUMBER;
      hash = (53 * hash) + internalGetClusterLabels().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.JobPlacement parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dataproc.v1.JobPlacement prototype) {
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
   * Dataproc job config.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dataproc.v1.JobPlacement}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dataproc.v1.JobPlacement)
      com.google.cloud.dataproc.v1.JobPlacementOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_descriptor;
    }

    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMapField(
        int number) {
      switch (number) {
        case 3:
          return internalGetClusterLabels();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMutableMapField(
        int number) {
      switch (number) {
        case 3:
          return internalGetMutableClusterLabels();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dataproc.v1.JobPlacement.class, com.google.cloud.dataproc.v1.JobPlacement.Builder.class);
    }

    // Construct using com.google.cloud.dataproc.v1.JobPlacement.newBuilder()
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
      clusterName_ = "";

      clusterUuid_ = "";

      internalGetMutableClusterLabels().clear();
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dataproc.v1.JobsProto.internal_static_google_cloud_dataproc_v1_JobPlacement_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.JobPlacement getDefaultInstanceForType() {
      return com.google.cloud.dataproc.v1.JobPlacement.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.JobPlacement build() {
      com.google.cloud.dataproc.v1.JobPlacement result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.JobPlacement buildPartial() {
      com.google.cloud.dataproc.v1.JobPlacement result = new com.google.cloud.dataproc.v1.JobPlacement(this);
      int from_bitField0_ = bitField0_;
      result.clusterName_ = clusterName_;
      result.clusterUuid_ = clusterUuid_;
      result.clusterLabels_ = internalGetClusterLabels();
      result.clusterLabels_.makeImmutable();
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
      if (other instanceof com.google.cloud.dataproc.v1.JobPlacement) {
        return mergeFrom((com.google.cloud.dataproc.v1.JobPlacement)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dataproc.v1.JobPlacement other) {
      if (other == com.google.cloud.dataproc.v1.JobPlacement.getDefaultInstance()) return this;
      if (!other.getClusterName().isEmpty()) {
        clusterName_ = other.clusterName_;
        onChanged();
      }
      if (!other.getClusterUuid().isEmpty()) {
        clusterUuid_ = other.clusterUuid_;
        onChanged();
      }
      internalGetMutableClusterLabels().mergeFrom(
          other.internalGetClusterLabels());
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
      com.google.cloud.dataproc.v1.JobPlacement parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dataproc.v1.JobPlacement) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.lang.Object clusterName_ = "";
    /**
     * <pre>
     * Required. The name of the cluster where the job will be submitted.
     * </pre>
     *
     * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The clusterName.
     */
    public java.lang.String getClusterName() {
      java.lang.Object ref = clusterName_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        clusterName_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. The name of the cluster where the job will be submitted.
     * </pre>
     *
     * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return The bytes for clusterName.
     */
    public com.google.protobuf.ByteString
        getClusterNameBytes() {
      java.lang.Object ref = clusterName_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        clusterName_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. The name of the cluster where the job will be submitted.
     * </pre>
     *
     * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The clusterName to set.
     * @return This builder for chaining.
     */
    public Builder setClusterName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      clusterName_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The name of the cluster where the job will be submitted.
     * </pre>
     *
     * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return This builder for chaining.
     */
    public Builder clearClusterName() {
      
      clusterName_ = getDefaultInstance().getClusterName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The name of the cluster where the job will be submitted.
     * </pre>
     *
     * <code>string cluster_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param value The bytes for clusterName to set.
     * @return This builder for chaining.
     */
    public Builder setClusterNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      clusterName_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object clusterUuid_ = "";
    /**
     * <pre>
     * Output only. A cluster UUID generated by the Dataproc service when
     * the job is submitted.
     * </pre>
     *
     * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return The clusterUuid.
     */
    public java.lang.String getClusterUuid() {
      java.lang.Object ref = clusterUuid_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        clusterUuid_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Output only. A cluster UUID generated by the Dataproc service when
     * the job is submitted.
     * </pre>
     *
     * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return The bytes for clusterUuid.
     */
    public com.google.protobuf.ByteString
        getClusterUuidBytes() {
      java.lang.Object ref = clusterUuid_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        clusterUuid_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Output only. A cluster UUID generated by the Dataproc service when
     * the job is submitted.
     * </pre>
     *
     * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param value The clusterUuid to set.
     * @return This builder for chaining.
     */
    public Builder setClusterUuid(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      clusterUuid_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. A cluster UUID generated by the Dataproc service when
     * the job is submitted.
     * </pre>
     *
     * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return This builder for chaining.
     */
    public Builder clearClusterUuid() {
      
      clusterUuid_ = getDefaultInstance().getClusterUuid();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. A cluster UUID generated by the Dataproc service when
     * the job is submitted.
     * </pre>
     *
     * <code>string cluster_uuid = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param value The bytes for clusterUuid to set.
     * @return This builder for chaining.
     */
    public Builder setClusterUuidBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      clusterUuid_ = value;
      onChanged();
      return this;
    }

    private com.google.protobuf.MapField<
        java.lang.String, java.lang.String> clusterLabels_;
    private com.google.protobuf.MapField<java.lang.String, java.lang.String>
    internalGetClusterLabels() {
      if (clusterLabels_ == null) {
        return com.google.protobuf.MapField.emptyMapField(
            ClusterLabelsDefaultEntryHolder.defaultEntry);
      }
      return clusterLabels_;
    }
    private com.google.protobuf.MapField<java.lang.String, java.lang.String>
    internalGetMutableClusterLabels() {
      onChanged();;
      if (clusterLabels_ == null) {
        clusterLabels_ = com.google.protobuf.MapField.newMapField(
            ClusterLabelsDefaultEntryHolder.defaultEntry);
      }
      if (!clusterLabels_.isMutable()) {
        clusterLabels_ = clusterLabels_.copy();
      }
      return clusterLabels_;
    }

    public int getClusterLabelsCount() {
      return internalGetClusterLabels().getMap().size();
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */

    @java.lang.Override
    public boolean containsClusterLabels(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      return internalGetClusterLabels().getMap().containsKey(key);
    }
    /**
     * Use {@link #getClusterLabelsMap()} instead.
     */
    @java.lang.Override
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, java.lang.String> getClusterLabels() {
      return getClusterLabelsMap();
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    @java.lang.Override

    public java.util.Map<java.lang.String, java.lang.String> getClusterLabelsMap() {
      return internalGetClusterLabels().getMap();
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    @java.lang.Override

    public java.lang.String getClusterLabelsOrDefault(
        java.lang.String key,
        java.lang.String defaultValue) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, java.lang.String> map =
          internalGetClusterLabels().getMap();
      return map.containsKey(key) ? map.get(key) : defaultValue;
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    @java.lang.Override

    public java.lang.String getClusterLabelsOrThrow(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, java.lang.String> map =
          internalGetClusterLabels().getMap();
      if (!map.containsKey(key)) {
        throw new java.lang.IllegalArgumentException();
      }
      return map.get(key);
    }

    public Builder clearClusterLabels() {
      internalGetMutableClusterLabels().getMutableMap()
          .clear();
      return this;
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */

    public Builder removeClusterLabels(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableClusterLabels().getMutableMap()
          .remove(key);
      return this;
    }
    /**
     * Use alternate mutation accessors instead.
     */
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, java.lang.String>
    getMutableClusterLabels() {
      return internalGetMutableClusterLabels().getMutableMap();
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    public Builder putClusterLabels(
        java.lang.String key,
        java.lang.String value) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      if (value == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableClusterLabels().getMutableMap()
          .put(key, value);
      return this;
    }
    /**
     * <pre>
     * Optional. Cluster labels to identify a cluster where the job will be
     * submitted.
     * </pre>
     *
     * <code>map&lt;string, string&gt; cluster_labels = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */

    public Builder putAllClusterLabels(
        java.util.Map<java.lang.String, java.lang.String> values) {
      internalGetMutableClusterLabels().getMutableMap()
          .putAll(values);
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dataproc.v1.JobPlacement)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dataproc.v1.JobPlacement)
  private static final com.google.cloud.dataproc.v1.JobPlacement DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dataproc.v1.JobPlacement();
  }

  public static com.google.cloud.dataproc.v1.JobPlacement getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<JobPlacement>
      PARSER = new com.google.protobuf.AbstractParser<JobPlacement>() {
    @java.lang.Override
    public JobPlacement parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new JobPlacement(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<JobPlacement> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<JobPlacement> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dataproc.v1.JobPlacement getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

