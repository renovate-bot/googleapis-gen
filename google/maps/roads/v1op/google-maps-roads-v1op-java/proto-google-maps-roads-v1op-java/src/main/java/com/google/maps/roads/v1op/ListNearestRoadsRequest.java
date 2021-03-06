// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/maps/roads/v1op/roads.proto

package com.google.maps.roads.v1op;

/**
 * <pre>
 * A request to the ListNearestRoads method, requesting that a sequence of
 * points be snapped individually to the road segment that each is closest to.
 * </pre>
 *
 * Protobuf type {@code google.maps.roads.v1op.ListNearestRoadsRequest}
 */
public final class ListNearestRoadsRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.maps.roads.v1op.ListNearestRoadsRequest)
    ListNearestRoadsRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ListNearestRoadsRequest.newBuilder() to construct.
  private ListNearestRoadsRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ListNearestRoadsRequest() {
    points_ = "";
    travelMode_ = 0;
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new ListNearestRoadsRequest();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ListNearestRoadsRequest(
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

            points_ = s;
            break;
          }
          case 16: {
            int rawValue = input.readEnum();

            travelMode_ = rawValue;
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
    return com.google.maps.roads.v1op.RoadsProto.internal_static_google_maps_roads_v1op_ListNearestRoadsRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.maps.roads.v1op.RoadsProto.internal_static_google_maps_roads_v1op_ListNearestRoadsRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.maps.roads.v1op.ListNearestRoadsRequest.class, com.google.maps.roads.v1op.ListNearestRoadsRequest.Builder.class);
  }

  public static final int POINTS_FIELD_NUMBER = 1;
  private volatile java.lang.Object points_;
  /**
   * <pre>
   * The points to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string points = 1;</code>
   * @return The points.
   */
  @java.lang.Override
  public java.lang.String getPoints() {
    java.lang.Object ref = points_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      points_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The points to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string points = 1;</code>
   * @return The bytes for points.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getPointsBytes() {
    java.lang.Object ref = points_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      points_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int TRAVEL_MODE_FIELD_NUMBER = 2;
  private int travelMode_;
  /**
   * <pre>
   * The type of travel being tracked. This will constrain the roads we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
   * @return The enum numeric value on the wire for travelMode.
   */
  @java.lang.Override public int getTravelModeValue() {
    return travelMode_;
  }
  /**
   * <pre>
   * The type of travel being tracked. This will constrain the roads we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
   * @return The travelMode.
   */
  @java.lang.Override public com.google.maps.roads.v1op.TravelMode getTravelMode() {
    @SuppressWarnings("deprecation")
    com.google.maps.roads.v1op.TravelMode result = com.google.maps.roads.v1op.TravelMode.valueOf(travelMode_);
    return result == null ? com.google.maps.roads.v1op.TravelMode.UNRECOGNIZED : result;
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
    if (!getPointsBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, points_);
    }
    if (travelMode_ != com.google.maps.roads.v1op.TravelMode.TRAVEL_MODE_UNSPECIFIED.getNumber()) {
      output.writeEnum(2, travelMode_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getPointsBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, points_);
    }
    if (travelMode_ != com.google.maps.roads.v1op.TravelMode.TRAVEL_MODE_UNSPECIFIED.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(2, travelMode_);
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
    if (!(obj instanceof com.google.maps.roads.v1op.ListNearestRoadsRequest)) {
      return super.equals(obj);
    }
    com.google.maps.roads.v1op.ListNearestRoadsRequest other = (com.google.maps.roads.v1op.ListNearestRoadsRequest) obj;

    if (!getPoints()
        .equals(other.getPoints())) return false;
    if (travelMode_ != other.travelMode_) return false;
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
    hash = (37 * hash) + POINTS_FIELD_NUMBER;
    hash = (53 * hash) + getPoints().hashCode();
    hash = (37 * hash) + TRAVEL_MODE_FIELD_NUMBER;
    hash = (53 * hash) + travelMode_;
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.maps.roads.v1op.ListNearestRoadsRequest parseFrom(
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
  public static Builder newBuilder(com.google.maps.roads.v1op.ListNearestRoadsRequest prototype) {
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
   * A request to the ListNearestRoads method, requesting that a sequence of
   * points be snapped individually to the road segment that each is closest to.
   * </pre>
   *
   * Protobuf type {@code google.maps.roads.v1op.ListNearestRoadsRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.maps.roads.v1op.ListNearestRoadsRequest)
      com.google.maps.roads.v1op.ListNearestRoadsRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.maps.roads.v1op.RoadsProto.internal_static_google_maps_roads_v1op_ListNearestRoadsRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.maps.roads.v1op.RoadsProto.internal_static_google_maps_roads_v1op_ListNearestRoadsRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.maps.roads.v1op.ListNearestRoadsRequest.class, com.google.maps.roads.v1op.ListNearestRoadsRequest.Builder.class);
    }

    // Construct using com.google.maps.roads.v1op.ListNearestRoadsRequest.newBuilder()
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
      points_ = "";

      travelMode_ = 0;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.maps.roads.v1op.RoadsProto.internal_static_google_maps_roads_v1op_ListNearestRoadsRequest_descriptor;
    }

    @java.lang.Override
    public com.google.maps.roads.v1op.ListNearestRoadsRequest getDefaultInstanceForType() {
      return com.google.maps.roads.v1op.ListNearestRoadsRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.maps.roads.v1op.ListNearestRoadsRequest build() {
      com.google.maps.roads.v1op.ListNearestRoadsRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.maps.roads.v1op.ListNearestRoadsRequest buildPartial() {
      com.google.maps.roads.v1op.ListNearestRoadsRequest result = new com.google.maps.roads.v1op.ListNearestRoadsRequest(this);
      result.points_ = points_;
      result.travelMode_ = travelMode_;
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
      if (other instanceof com.google.maps.roads.v1op.ListNearestRoadsRequest) {
        return mergeFrom((com.google.maps.roads.v1op.ListNearestRoadsRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.maps.roads.v1op.ListNearestRoadsRequest other) {
      if (other == com.google.maps.roads.v1op.ListNearestRoadsRequest.getDefaultInstance()) return this;
      if (!other.getPoints().isEmpty()) {
        points_ = other.points_;
        onChanged();
      }
      if (other.travelMode_ != 0) {
        setTravelModeValue(other.getTravelModeValue());
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
      com.google.maps.roads.v1op.ListNearestRoadsRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.maps.roads.v1op.ListNearestRoadsRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object points_ = "";
    /**
     * <pre>
     * The points to be snapped as a series of lat, lng points. Specified as
     * a string of the format: lat,lng|lat,lng|...
     * </pre>
     *
     * <code>string points = 1;</code>
     * @return The points.
     */
    public java.lang.String getPoints() {
      java.lang.Object ref = points_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        points_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The points to be snapped as a series of lat, lng points. Specified as
     * a string of the format: lat,lng|lat,lng|...
     * </pre>
     *
     * <code>string points = 1;</code>
     * @return The bytes for points.
     */
    public com.google.protobuf.ByteString
        getPointsBytes() {
      java.lang.Object ref = points_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        points_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The points to be snapped as a series of lat, lng points. Specified as
     * a string of the format: lat,lng|lat,lng|...
     * </pre>
     *
     * <code>string points = 1;</code>
     * @param value The points to set.
     * @return This builder for chaining.
     */
    public Builder setPoints(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      points_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The points to be snapped as a series of lat, lng points. Specified as
     * a string of the format: lat,lng|lat,lng|...
     * </pre>
     *
     * <code>string points = 1;</code>
     * @return This builder for chaining.
     */
    public Builder clearPoints() {
      
      points_ = getDefaultInstance().getPoints();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The points to be snapped as a series of lat, lng points. Specified as
     * a string of the format: lat,lng|lat,lng|...
     * </pre>
     *
     * <code>string points = 1;</code>
     * @param value The bytes for points to set.
     * @return This builder for chaining.
     */
    public Builder setPointsBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      points_ = value;
      onChanged();
      return this;
    }

    private int travelMode_ = 0;
    /**
     * <pre>
     * The type of travel being tracked. This will constrain the roads we snap to.
     * </pre>
     *
     * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
     * @return The enum numeric value on the wire for travelMode.
     */
    @java.lang.Override public int getTravelModeValue() {
      return travelMode_;
    }
    /**
     * <pre>
     * The type of travel being tracked. This will constrain the roads we snap to.
     * </pre>
     *
     * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
     * @param value The enum numeric value on the wire for travelMode to set.
     * @return This builder for chaining.
     */
    public Builder setTravelModeValue(int value) {
      
      travelMode_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The type of travel being tracked. This will constrain the roads we snap to.
     * </pre>
     *
     * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
     * @return The travelMode.
     */
    @java.lang.Override
    public com.google.maps.roads.v1op.TravelMode getTravelMode() {
      @SuppressWarnings("deprecation")
      com.google.maps.roads.v1op.TravelMode result = com.google.maps.roads.v1op.TravelMode.valueOf(travelMode_);
      return result == null ? com.google.maps.roads.v1op.TravelMode.UNRECOGNIZED : result;
    }
    /**
     * <pre>
     * The type of travel being tracked. This will constrain the roads we snap to.
     * </pre>
     *
     * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
     * @param value The travelMode to set.
     * @return This builder for chaining.
     */
    public Builder setTravelMode(com.google.maps.roads.v1op.TravelMode value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      travelMode_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The type of travel being tracked. This will constrain the roads we snap to.
     * </pre>
     *
     * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearTravelMode() {
      
      travelMode_ = 0;
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


    // @@protoc_insertion_point(builder_scope:google.maps.roads.v1op.ListNearestRoadsRequest)
  }

  // @@protoc_insertion_point(class_scope:google.maps.roads.v1op.ListNearestRoadsRequest)
  private static final com.google.maps.roads.v1op.ListNearestRoadsRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.maps.roads.v1op.ListNearestRoadsRequest();
  }

  public static com.google.maps.roads.v1op.ListNearestRoadsRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ListNearestRoadsRequest>
      PARSER = new com.google.protobuf.AbstractParser<ListNearestRoadsRequest>() {
    @java.lang.Override
    public ListNearestRoadsRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ListNearestRoadsRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ListNearestRoadsRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ListNearestRoadsRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.maps.roads.v1op.ListNearestRoadsRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

