// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gaming/allocationendpoint/v1alpha/allocation_endpoint.proto

package com.google.cloud.gaming.allocationendpoint.v1alpha;

/**
 * <pre>
 * GameServerSelector used for finding a GameServer with matching labels.
 * </pre>
 *
 * Protobuf type {@code google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector}
 */
public final class GameServerSelector extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)
    GameServerSelectorOrBuilder {
private static final long serialVersionUID = 0L;
  // Use GameServerSelector.newBuilder() to construct.
  private GameServerSelector(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private GameServerSelector() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new GameServerSelector();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private GameServerSelector(
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
              matchLabels_ = com.google.protobuf.MapField.newMapField(
                  MatchLabelsDefaultEntryHolder.defaultEntry);
              mutable_bitField0_ |= 0x00000001;
            }
            com.google.protobuf.MapEntry<java.lang.String, java.lang.String>
            matchLabels__ = input.readMessage(
                MatchLabelsDefaultEntryHolder.defaultEntry.getParserForType(), extensionRegistry);
            matchLabels_.getMutableMap().put(
                matchLabels__.getKey(), matchLabels__.getValue());
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
    return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_descriptor;
  }

  @SuppressWarnings({"rawtypes"})
  @java.lang.Override
  protected com.google.protobuf.MapField internalGetMapField(
      int number) {
    switch (number) {
      case 1:
        return internalGetMatchLabels();
      default:
        throw new RuntimeException(
            "Invalid map field number: " + number);
    }
  }
  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.class, com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.Builder.class);
  }

  public static final int MATCH_LABELS_FIELD_NUMBER = 1;
  private static final class MatchLabelsDefaultEntryHolder {
    static final com.google.protobuf.MapEntry<
        java.lang.String, java.lang.String> defaultEntry =
            com.google.protobuf.MapEntry
            .<java.lang.String, java.lang.String>newDefaultInstance(
                com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_MatchLabelsEntry_descriptor, 
                com.google.protobuf.WireFormat.FieldType.STRING,
                "",
                com.google.protobuf.WireFormat.FieldType.STRING,
                "");
  }
  private com.google.protobuf.MapField<
      java.lang.String, java.lang.String> matchLabels_;
  private com.google.protobuf.MapField<java.lang.String, java.lang.String>
  internalGetMatchLabels() {
    if (matchLabels_ == null) {
      return com.google.protobuf.MapField.emptyMapField(
          MatchLabelsDefaultEntryHolder.defaultEntry);
    }
    return matchLabels_;
  }

  public int getMatchLabelsCount() {
    return internalGetMatchLabels().getMap().size();
  }
  /**
   * <pre>
   * Labels to match.
   * </pre>
   *
   * <code>map&lt;string, string&gt; match_labels = 1;</code>
   */

  @java.lang.Override
  public boolean containsMatchLabels(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    return internalGetMatchLabels().getMap().containsKey(key);
  }
  /**
   * Use {@link #getMatchLabelsMap()} instead.
   */
  @java.lang.Override
  @java.lang.Deprecated
  public java.util.Map<java.lang.String, java.lang.String> getMatchLabels() {
    return getMatchLabelsMap();
  }
  /**
   * <pre>
   * Labels to match.
   * </pre>
   *
   * <code>map&lt;string, string&gt; match_labels = 1;</code>
   */
  @java.lang.Override

  public java.util.Map<java.lang.String, java.lang.String> getMatchLabelsMap() {
    return internalGetMatchLabels().getMap();
  }
  /**
   * <pre>
   * Labels to match.
   * </pre>
   *
   * <code>map&lt;string, string&gt; match_labels = 1;</code>
   */
  @java.lang.Override

  public java.lang.String getMatchLabelsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, java.lang.String> map =
        internalGetMatchLabels().getMap();
    return map.containsKey(key) ? map.get(key) : defaultValue;
  }
  /**
   * <pre>
   * Labels to match.
   * </pre>
   *
   * <code>map&lt;string, string&gt; match_labels = 1;</code>
   */
  @java.lang.Override

  public java.lang.String getMatchLabelsOrThrow(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, java.lang.String> map =
        internalGetMatchLabels().getMap();
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
    com.google.protobuf.GeneratedMessageV3
      .serializeStringMapTo(
        output,
        internalGetMatchLabels(),
        MatchLabelsDefaultEntryHolder.defaultEntry,
        1);
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (java.util.Map.Entry<java.lang.String, java.lang.String> entry
         : internalGetMatchLabels().getMap().entrySet()) {
      com.google.protobuf.MapEntry<java.lang.String, java.lang.String>
      matchLabels__ = MatchLabelsDefaultEntryHolder.defaultEntry.newBuilderForType()
          .setKey(entry.getKey())
          .setValue(entry.getValue())
          .build();
      size += com.google.protobuf.CodedOutputStream
          .computeMessageSize(1, matchLabels__);
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
    if (!(obj instanceof com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)) {
      return super.equals(obj);
    }
    com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector other = (com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector) obj;

    if (!internalGetMatchLabels().equals(
        other.internalGetMatchLabels())) return false;
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
    if (!internalGetMatchLabels().getMap().isEmpty()) {
      hash = (37 * hash) + MATCH_LABELS_FIELD_NUMBER;
      hash = (53 * hash) + internalGetMatchLabels().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parseFrom(
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
  public static Builder newBuilder(com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector prototype) {
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
   * GameServerSelector used for finding a GameServer with matching labels.
   * </pre>
   *
   * Protobuf type {@code google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)
      com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelectorOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_descriptor;
    }

    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMapField(
        int number) {
      switch (number) {
        case 1:
          return internalGetMatchLabels();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMutableMapField(
        int number) {
      switch (number) {
        case 1:
          return internalGetMutableMatchLabels();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.class, com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.Builder.class);
    }

    // Construct using com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.newBuilder()
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
      internalGetMutableMatchLabels().clear();
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.internal_static_google_cloud_gaming_allocationendpoint_v1alpha_GameServerSelector_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector getDefaultInstanceForType() {
      return com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector build() {
      com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector buildPartial() {
      com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector result = new com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector(this);
      int from_bitField0_ = bitField0_;
      result.matchLabels_ = internalGetMatchLabels();
      result.matchLabels_.makeImmutable();
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
      if (other instanceof com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector) {
        return mergeFrom((com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector other) {
      if (other == com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector.getDefaultInstance()) return this;
      internalGetMutableMatchLabels().mergeFrom(
          other.internalGetMatchLabels());
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
      com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private com.google.protobuf.MapField<
        java.lang.String, java.lang.String> matchLabels_;
    private com.google.protobuf.MapField<java.lang.String, java.lang.String>
    internalGetMatchLabels() {
      if (matchLabels_ == null) {
        return com.google.protobuf.MapField.emptyMapField(
            MatchLabelsDefaultEntryHolder.defaultEntry);
      }
      return matchLabels_;
    }
    private com.google.protobuf.MapField<java.lang.String, java.lang.String>
    internalGetMutableMatchLabels() {
      onChanged();;
      if (matchLabels_ == null) {
        matchLabels_ = com.google.protobuf.MapField.newMapField(
            MatchLabelsDefaultEntryHolder.defaultEntry);
      }
      if (!matchLabels_.isMutable()) {
        matchLabels_ = matchLabels_.copy();
      }
      return matchLabels_;
    }

    public int getMatchLabelsCount() {
      return internalGetMatchLabels().getMap().size();
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */

    @java.lang.Override
    public boolean containsMatchLabels(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      return internalGetMatchLabels().getMap().containsKey(key);
    }
    /**
     * Use {@link #getMatchLabelsMap()} instead.
     */
    @java.lang.Override
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, java.lang.String> getMatchLabels() {
      return getMatchLabelsMap();
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */
    @java.lang.Override

    public java.util.Map<java.lang.String, java.lang.String> getMatchLabelsMap() {
      return internalGetMatchLabels().getMap();
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */
    @java.lang.Override

    public java.lang.String getMatchLabelsOrDefault(
        java.lang.String key,
        java.lang.String defaultValue) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, java.lang.String> map =
          internalGetMatchLabels().getMap();
      return map.containsKey(key) ? map.get(key) : defaultValue;
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */
    @java.lang.Override

    public java.lang.String getMatchLabelsOrThrow(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, java.lang.String> map =
          internalGetMatchLabels().getMap();
      if (!map.containsKey(key)) {
        throw new java.lang.IllegalArgumentException();
      }
      return map.get(key);
    }

    public Builder clearMatchLabels() {
      internalGetMutableMatchLabels().getMutableMap()
          .clear();
      return this;
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */

    public Builder removeMatchLabels(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableMatchLabels().getMutableMap()
          .remove(key);
      return this;
    }
    /**
     * Use alternate mutation accessors instead.
     */
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, java.lang.String>
    getMutableMatchLabels() {
      return internalGetMutableMatchLabels().getMutableMap();
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */
    public Builder putMatchLabels(
        java.lang.String key,
        java.lang.String value) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      if (value == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableMatchLabels().getMutableMap()
          .put(key, value);
      return this;
    }
    /**
     * <pre>
     * Labels to match.
     * </pre>
     *
     * <code>map&lt;string, string&gt; match_labels = 1;</code>
     */

    public Builder putAllMatchLabels(
        java.util.Map<java.lang.String, java.lang.String> values) {
      internalGetMutableMatchLabels().getMutableMap()
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


    // @@protoc_insertion_point(builder_scope:google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector)
  private static final com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector();
  }

  public static com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<GameServerSelector>
      PARSER = new com.google.protobuf.AbstractParser<GameServerSelector>() {
    @java.lang.Override
    public GameServerSelector parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new GameServerSelector(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<GameServerSelector> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<GameServerSelector> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.gaming.allocationendpoint.v1alpha.GameServerSelector getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

