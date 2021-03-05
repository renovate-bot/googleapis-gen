// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/drive/activity/v2/query_drive_activity_response.proto

package com.google.apps.drive.activity.v2;

/**
 * <pre>
 * Response message for querying Drive activity.
 * </pre>
 *
 * Protobuf type {@code google.apps.drive.activity.v2.QueryDriveActivityResponse}
 */
public final class QueryDriveActivityResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.apps.drive.activity.v2.QueryDriveActivityResponse)
    QueryDriveActivityResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use QueryDriveActivityResponse.newBuilder() to construct.
  private QueryDriveActivityResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private QueryDriveActivityResponse() {
    activities_ = java.util.Collections.emptyList();
    nextPageToken_ = "";
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new QueryDriveActivityResponse();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private QueryDriveActivityResponse(
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
              activities_ = new java.util.ArrayList<com.google.apps.drive.activity.v2.DriveActivity>();
              mutable_bitField0_ |= 0x00000001;
            }
            activities_.add(
                input.readMessage(com.google.apps.drive.activity.v2.DriveActivity.parser(), extensionRegistry));
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            nextPageToken_ = s;
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
      if (((mutable_bitField0_ & 0x00000001) != 0)) {
        activities_ = java.util.Collections.unmodifiableList(activities_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.apps.drive.activity.v2.QueryDriveActivityResponseProto.internal_static_google_apps_drive_activity_v2_QueryDriveActivityResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.apps.drive.activity.v2.QueryDriveActivityResponseProto.internal_static_google_apps_drive_activity_v2_QueryDriveActivityResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.apps.drive.activity.v2.QueryDriveActivityResponse.class, com.google.apps.drive.activity.v2.QueryDriveActivityResponse.Builder.class);
  }

  public static final int ACTIVITIES_FIELD_NUMBER = 1;
  private java.util.List<com.google.apps.drive.activity.v2.DriveActivity> activities_;
  /**
   * <pre>
   * List of activity requested.
   * </pre>
   *
   * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
   */
  @java.lang.Override
  public java.util.List<com.google.apps.drive.activity.v2.DriveActivity> getActivitiesList() {
    return activities_;
  }
  /**
   * <pre>
   * List of activity requested.
   * </pre>
   *
   * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
   */
  @java.lang.Override
  public java.util.List<? extends com.google.apps.drive.activity.v2.DriveActivityOrBuilder> 
      getActivitiesOrBuilderList() {
    return activities_;
  }
  /**
   * <pre>
   * List of activity requested.
   * </pre>
   *
   * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
   */
  @java.lang.Override
  public int getActivitiesCount() {
    return activities_.size();
  }
  /**
   * <pre>
   * List of activity requested.
   * </pre>
   *
   * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
   */
  @java.lang.Override
  public com.google.apps.drive.activity.v2.DriveActivity getActivities(int index) {
    return activities_.get(index);
  }
  /**
   * <pre>
   * List of activity requested.
   * </pre>
   *
   * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
   */
  @java.lang.Override
  public com.google.apps.drive.activity.v2.DriveActivityOrBuilder getActivitiesOrBuilder(
      int index) {
    return activities_.get(index);
  }

  public static final int NEXT_PAGE_TOKEN_FIELD_NUMBER = 2;
  private volatile java.lang.Object nextPageToken_;
  /**
   * <pre>
   * Token to retrieve the next page of results, or
   * empty if there are no more results in the list.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  @java.lang.Override
  public java.lang.String getNextPageToken() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      nextPageToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Token to retrieve the next page of results, or
   * empty if there are no more results in the list.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getNextPageTokenBytes() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      nextPageToken_ = b;
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
    for (int i = 0; i < activities_.size(); i++) {
      output.writeMessage(1, activities_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, nextPageToken_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < activities_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, activities_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, nextPageToken_);
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
    if (!(obj instanceof com.google.apps.drive.activity.v2.QueryDriveActivityResponse)) {
      return super.equals(obj);
    }
    com.google.apps.drive.activity.v2.QueryDriveActivityResponse other = (com.google.apps.drive.activity.v2.QueryDriveActivityResponse) obj;

    if (!getActivitiesList()
        .equals(other.getActivitiesList())) return false;
    if (!getNextPageToken()
        .equals(other.getNextPageToken())) return false;
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
    if (getActivitiesCount() > 0) {
      hash = (37 * hash) + ACTIVITIES_FIELD_NUMBER;
      hash = (53 * hash) + getActivitiesList().hashCode();
    }
    hash = (37 * hash) + NEXT_PAGE_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getNextPageToken().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse parseFrom(
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
  public static Builder newBuilder(com.google.apps.drive.activity.v2.QueryDriveActivityResponse prototype) {
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
   * Response message for querying Drive activity.
   * </pre>
   *
   * Protobuf type {@code google.apps.drive.activity.v2.QueryDriveActivityResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.apps.drive.activity.v2.QueryDriveActivityResponse)
      com.google.apps.drive.activity.v2.QueryDriveActivityResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.apps.drive.activity.v2.QueryDriveActivityResponseProto.internal_static_google_apps_drive_activity_v2_QueryDriveActivityResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.apps.drive.activity.v2.QueryDriveActivityResponseProto.internal_static_google_apps_drive_activity_v2_QueryDriveActivityResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.apps.drive.activity.v2.QueryDriveActivityResponse.class, com.google.apps.drive.activity.v2.QueryDriveActivityResponse.Builder.class);
    }

    // Construct using com.google.apps.drive.activity.v2.QueryDriveActivityResponse.newBuilder()
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
        getActivitiesFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (activitiesBuilder_ == null) {
        activities_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        activitiesBuilder_.clear();
      }
      nextPageToken_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.apps.drive.activity.v2.QueryDriveActivityResponseProto.internal_static_google_apps_drive_activity_v2_QueryDriveActivityResponse_descriptor;
    }

    @java.lang.Override
    public com.google.apps.drive.activity.v2.QueryDriveActivityResponse getDefaultInstanceForType() {
      return com.google.apps.drive.activity.v2.QueryDriveActivityResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.apps.drive.activity.v2.QueryDriveActivityResponse build() {
      com.google.apps.drive.activity.v2.QueryDriveActivityResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.apps.drive.activity.v2.QueryDriveActivityResponse buildPartial() {
      com.google.apps.drive.activity.v2.QueryDriveActivityResponse result = new com.google.apps.drive.activity.v2.QueryDriveActivityResponse(this);
      int from_bitField0_ = bitField0_;
      if (activitiesBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          activities_ = java.util.Collections.unmodifiableList(activities_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.activities_ = activities_;
      } else {
        result.activities_ = activitiesBuilder_.build();
      }
      result.nextPageToken_ = nextPageToken_;
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
      if (other instanceof com.google.apps.drive.activity.v2.QueryDriveActivityResponse) {
        return mergeFrom((com.google.apps.drive.activity.v2.QueryDriveActivityResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.apps.drive.activity.v2.QueryDriveActivityResponse other) {
      if (other == com.google.apps.drive.activity.v2.QueryDriveActivityResponse.getDefaultInstance()) return this;
      if (activitiesBuilder_ == null) {
        if (!other.activities_.isEmpty()) {
          if (activities_.isEmpty()) {
            activities_ = other.activities_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureActivitiesIsMutable();
            activities_.addAll(other.activities_);
          }
          onChanged();
        }
      } else {
        if (!other.activities_.isEmpty()) {
          if (activitiesBuilder_.isEmpty()) {
            activitiesBuilder_.dispose();
            activitiesBuilder_ = null;
            activities_ = other.activities_;
            bitField0_ = (bitField0_ & ~0x00000001);
            activitiesBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getActivitiesFieldBuilder() : null;
          } else {
            activitiesBuilder_.addAllMessages(other.activities_);
          }
        }
      }
      if (!other.getNextPageToken().isEmpty()) {
        nextPageToken_ = other.nextPageToken_;
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
      com.google.apps.drive.activity.v2.QueryDriveActivityResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.apps.drive.activity.v2.QueryDriveActivityResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.apps.drive.activity.v2.DriveActivity> activities_ =
      java.util.Collections.emptyList();
    private void ensureActivitiesIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        activities_ = new java.util.ArrayList<com.google.apps.drive.activity.v2.DriveActivity>(activities_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.apps.drive.activity.v2.DriveActivity, com.google.apps.drive.activity.v2.DriveActivity.Builder, com.google.apps.drive.activity.v2.DriveActivityOrBuilder> activitiesBuilder_;

    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public java.util.List<com.google.apps.drive.activity.v2.DriveActivity> getActivitiesList() {
      if (activitiesBuilder_ == null) {
        return java.util.Collections.unmodifiableList(activities_);
      } else {
        return activitiesBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public int getActivitiesCount() {
      if (activitiesBuilder_ == null) {
        return activities_.size();
      } else {
        return activitiesBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public com.google.apps.drive.activity.v2.DriveActivity getActivities(int index) {
      if (activitiesBuilder_ == null) {
        return activities_.get(index);
      } else {
        return activitiesBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder setActivities(
        int index, com.google.apps.drive.activity.v2.DriveActivity value) {
      if (activitiesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureActivitiesIsMutable();
        activities_.set(index, value);
        onChanged();
      } else {
        activitiesBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder setActivities(
        int index, com.google.apps.drive.activity.v2.DriveActivity.Builder builderForValue) {
      if (activitiesBuilder_ == null) {
        ensureActivitiesIsMutable();
        activities_.set(index, builderForValue.build());
        onChanged();
      } else {
        activitiesBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder addActivities(com.google.apps.drive.activity.v2.DriveActivity value) {
      if (activitiesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureActivitiesIsMutable();
        activities_.add(value);
        onChanged();
      } else {
        activitiesBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder addActivities(
        int index, com.google.apps.drive.activity.v2.DriveActivity value) {
      if (activitiesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureActivitiesIsMutable();
        activities_.add(index, value);
        onChanged();
      } else {
        activitiesBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder addActivities(
        com.google.apps.drive.activity.v2.DriveActivity.Builder builderForValue) {
      if (activitiesBuilder_ == null) {
        ensureActivitiesIsMutable();
        activities_.add(builderForValue.build());
        onChanged();
      } else {
        activitiesBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder addActivities(
        int index, com.google.apps.drive.activity.v2.DriveActivity.Builder builderForValue) {
      if (activitiesBuilder_ == null) {
        ensureActivitiesIsMutable();
        activities_.add(index, builderForValue.build());
        onChanged();
      } else {
        activitiesBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder addAllActivities(
        java.lang.Iterable<? extends com.google.apps.drive.activity.v2.DriveActivity> values) {
      if (activitiesBuilder_ == null) {
        ensureActivitiesIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, activities_);
        onChanged();
      } else {
        activitiesBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder clearActivities() {
      if (activitiesBuilder_ == null) {
        activities_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        activitiesBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public Builder removeActivities(int index) {
      if (activitiesBuilder_ == null) {
        ensureActivitiesIsMutable();
        activities_.remove(index);
        onChanged();
      } else {
        activitiesBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public com.google.apps.drive.activity.v2.DriveActivity.Builder getActivitiesBuilder(
        int index) {
      return getActivitiesFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public com.google.apps.drive.activity.v2.DriveActivityOrBuilder getActivitiesOrBuilder(
        int index) {
      if (activitiesBuilder_ == null) {
        return activities_.get(index);  } else {
        return activitiesBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public java.util.List<? extends com.google.apps.drive.activity.v2.DriveActivityOrBuilder> 
         getActivitiesOrBuilderList() {
      if (activitiesBuilder_ != null) {
        return activitiesBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(activities_);
      }
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public com.google.apps.drive.activity.v2.DriveActivity.Builder addActivitiesBuilder() {
      return getActivitiesFieldBuilder().addBuilder(
          com.google.apps.drive.activity.v2.DriveActivity.getDefaultInstance());
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public com.google.apps.drive.activity.v2.DriveActivity.Builder addActivitiesBuilder(
        int index) {
      return getActivitiesFieldBuilder().addBuilder(
          index, com.google.apps.drive.activity.v2.DriveActivity.getDefaultInstance());
    }
    /**
     * <pre>
     * List of activity requested.
     * </pre>
     *
     * <code>repeated .google.apps.drive.activity.v2.DriveActivity activities = 1;</code>
     */
    public java.util.List<com.google.apps.drive.activity.v2.DriveActivity.Builder> 
         getActivitiesBuilderList() {
      return getActivitiesFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.apps.drive.activity.v2.DriveActivity, com.google.apps.drive.activity.v2.DriveActivity.Builder, com.google.apps.drive.activity.v2.DriveActivityOrBuilder> 
        getActivitiesFieldBuilder() {
      if (activitiesBuilder_ == null) {
        activitiesBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.apps.drive.activity.v2.DriveActivity, com.google.apps.drive.activity.v2.DriveActivity.Builder, com.google.apps.drive.activity.v2.DriveActivityOrBuilder>(
                activities_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        activities_ = null;
      }
      return activitiesBuilder_;
    }

    private java.lang.Object nextPageToken_ = "";
    /**
     * <pre>
     * Token to retrieve the next page of results, or
     * empty if there are no more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return The nextPageToken.
     */
    public java.lang.String getNextPageToken() {
      java.lang.Object ref = nextPageToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        nextPageToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Token to retrieve the next page of results, or
     * empty if there are no more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return The bytes for nextPageToken.
     */
    public com.google.protobuf.ByteString
        getNextPageTokenBytes() {
      java.lang.Object ref = nextPageToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        nextPageToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Token to retrieve the next page of results, or
     * empty if there are no more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @param value The nextPageToken to set.
     * @return This builder for chaining.
     */
    public Builder setNextPageToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      nextPageToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Token to retrieve the next page of results, or
     * empty if there are no more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearNextPageToken() {
      
      nextPageToken_ = getDefaultInstance().getNextPageToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Token to retrieve the next page of results, or
     * empty if there are no more results in the list.
     * </pre>
     *
     * <code>string next_page_token = 2;</code>
     * @param value The bytes for nextPageToken to set.
     * @return This builder for chaining.
     */
    public Builder setNextPageTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      nextPageToken_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.apps.drive.activity.v2.QueryDriveActivityResponse)
  }

  // @@protoc_insertion_point(class_scope:google.apps.drive.activity.v2.QueryDriveActivityResponse)
  private static final com.google.apps.drive.activity.v2.QueryDriveActivityResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.apps.drive.activity.v2.QueryDriveActivityResponse();
  }

  public static com.google.apps.drive.activity.v2.QueryDriveActivityResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<QueryDriveActivityResponse>
      PARSER = new com.google.protobuf.AbstractParser<QueryDriveActivityResponse>() {
    @java.lang.Override
    public QueryDriveActivityResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new QueryDriveActivityResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<QueryDriveActivityResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<QueryDriveActivityResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.apps.drive.activity.v2.QueryDriveActivityResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

