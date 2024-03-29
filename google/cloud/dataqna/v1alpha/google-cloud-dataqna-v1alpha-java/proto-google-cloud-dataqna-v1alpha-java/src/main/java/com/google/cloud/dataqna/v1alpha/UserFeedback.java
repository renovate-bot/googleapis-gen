// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataqna/v1alpha/user_feedback.proto

package com.google.cloud.dataqna.v1alpha;

/**
 * <pre>
 * Feedback provided by a user.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dataqna.v1alpha.UserFeedback}
 */
public final class UserFeedback extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dataqna.v1alpha.UserFeedback)
    UserFeedbackOrBuilder {
private static final long serialVersionUID = 0L;
  // Use UserFeedback.newBuilder() to construct.
  private UserFeedback(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private UserFeedback() {
    name_ = "";
    freeFormFeedback_ = "";
    rating_ = 0;
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new UserFeedback();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private UserFeedback(
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

            freeFormFeedback_ = s;
            break;
          }
          case 24: {
            int rawValue = input.readEnum();

            rating_ = rawValue;
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
    return com.google.cloud.dataqna.v1alpha.UserFeedbackProto.internal_static_google_cloud_dataqna_v1alpha_UserFeedback_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dataqna.v1alpha.UserFeedbackProto.internal_static_google_cloud_dataqna_v1alpha_UserFeedback_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dataqna.v1alpha.UserFeedback.class, com.google.cloud.dataqna.v1alpha.UserFeedback.Builder.class);
  }

  /**
   * <pre>
   * Enumeration of feedback ratings.
   * </pre>
   *
   * Protobuf enum {@code google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating}
   */
  public enum UserFeedbackRating
      implements com.google.protobuf.ProtocolMessageEnum {
    /**
     * <pre>
     * No rating was specified.
     * </pre>
     *
     * <code>USER_FEEDBACK_RATING_UNSPECIFIED = 0;</code>
     */
    USER_FEEDBACK_RATING_UNSPECIFIED(0),
    /**
     * <pre>
     * The user provided positive feedback.
     * </pre>
     *
     * <code>POSITIVE = 1;</code>
     */
    POSITIVE(1),
    /**
     * <pre>
     * The user provided negative feedback.
     * </pre>
     *
     * <code>NEGATIVE = 2;</code>
     */
    NEGATIVE(2),
    UNRECOGNIZED(-1),
    ;

    /**
     * <pre>
     * No rating was specified.
     * </pre>
     *
     * <code>USER_FEEDBACK_RATING_UNSPECIFIED = 0;</code>
     */
    public static final int USER_FEEDBACK_RATING_UNSPECIFIED_VALUE = 0;
    /**
     * <pre>
     * The user provided positive feedback.
     * </pre>
     *
     * <code>POSITIVE = 1;</code>
     */
    public static final int POSITIVE_VALUE = 1;
    /**
     * <pre>
     * The user provided negative feedback.
     * </pre>
     *
     * <code>NEGATIVE = 2;</code>
     */
    public static final int NEGATIVE_VALUE = 2;


    public final int getNumber() {
      if (this == UNRECOGNIZED) {
        throw new java.lang.IllegalArgumentException(
            "Can't get the number of an unknown enum value.");
      }
      return value;
    }

    /**
     * @param value The numeric wire value of the corresponding enum entry.
     * @return The enum associated with the given numeric wire value.
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static UserFeedbackRating valueOf(int value) {
      return forNumber(value);
    }

    /**
     * @param value The numeric wire value of the corresponding enum entry.
     * @return The enum associated with the given numeric wire value.
     */
    public static UserFeedbackRating forNumber(int value) {
      switch (value) {
        case 0: return USER_FEEDBACK_RATING_UNSPECIFIED;
        case 1: return POSITIVE;
        case 2: return NEGATIVE;
        default: return null;
      }
    }

    public static com.google.protobuf.Internal.EnumLiteMap<UserFeedbackRating>
        internalGetValueMap() {
      return internalValueMap;
    }
    private static final com.google.protobuf.Internal.EnumLiteMap<
        UserFeedbackRating> internalValueMap =
          new com.google.protobuf.Internal.EnumLiteMap<UserFeedbackRating>() {
            public UserFeedbackRating findValueByNumber(int number) {
              return UserFeedbackRating.forNumber(number);
            }
          };

    public final com.google.protobuf.Descriptors.EnumValueDescriptor
        getValueDescriptor() {
      if (this == UNRECOGNIZED) {
        throw new java.lang.IllegalStateException(
            "Can't get the descriptor of an unrecognized enum value.");
      }
      return getDescriptor().getValues().get(ordinal());
    }
    public final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptorForType() {
      return getDescriptor();
    }
    public static final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptor() {
      return com.google.cloud.dataqna.v1alpha.UserFeedback.getDescriptor().getEnumTypes().get(0);
    }

    private static final UserFeedbackRating[] VALUES = values();

    public static UserFeedbackRating valueOf(
        com.google.protobuf.Descriptors.EnumValueDescriptor desc) {
      if (desc.getType() != getDescriptor()) {
        throw new java.lang.IllegalArgumentException(
          "EnumValueDescriptor is not for this type.");
      }
      if (desc.getIndex() == -1) {
        return UNRECOGNIZED;
      }
      return VALUES[desc.getIndex()];
    }

    private final int value;

    private UserFeedbackRating(int value) {
      this.value = value;
    }

    // @@protoc_insertion_point(enum_scope:google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating)
  }

  public static final int NAME_FIELD_NUMBER = 1;
  private volatile java.lang.Object name_;
  /**
   * <pre>
   * Required. The unique identifier for the user feedback.
   * User feedback is a singleton resource on a Question.
   * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
   * Required. The unique identifier for the user feedback.
   * User feedback is a singleton resource on a Question.
   * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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

  public static final int FREE_FORM_FEEDBACK_FIELD_NUMBER = 2;
  private volatile java.lang.Object freeFormFeedback_;
  /**
   * <pre>
   * Free form user feedback, such as a text box.
   * </pre>
   *
   * <code>string free_form_feedback = 2;</code>
   * @return The freeFormFeedback.
   */
  @java.lang.Override
  public java.lang.String getFreeFormFeedback() {
    java.lang.Object ref = freeFormFeedback_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      freeFormFeedback_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Free form user feedback, such as a text box.
   * </pre>
   *
   * <code>string free_form_feedback = 2;</code>
   * @return The bytes for freeFormFeedback.
   */
  @java.lang.Override
  public com.google.protobuf.ByteString
      getFreeFormFeedbackBytes() {
    java.lang.Object ref = freeFormFeedback_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      freeFormFeedback_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int RATING_FIELD_NUMBER = 3;
  private int rating_;
  /**
   * <pre>
   * The user feedback rating
   * </pre>
   *
   * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
   * @return The enum numeric value on the wire for rating.
   */
  @java.lang.Override public int getRatingValue() {
    return rating_;
  }
  /**
   * <pre>
   * The user feedback rating
   * </pre>
   *
   * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
   * @return The rating.
   */
  @java.lang.Override public com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating getRating() {
    @SuppressWarnings("deprecation")
    com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating result = com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.valueOf(rating_);
    return result == null ? com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.UNRECOGNIZED : result;
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(freeFormFeedback_)) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, freeFormFeedback_);
    }
    if (rating_ != com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.USER_FEEDBACK_RATING_UNSPECIFIED.getNumber()) {
      output.writeEnum(3, rating_);
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
    if (!com.google.protobuf.GeneratedMessageV3.isStringEmpty(freeFormFeedback_)) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, freeFormFeedback_);
    }
    if (rating_ != com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.USER_FEEDBACK_RATING_UNSPECIFIED.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(3, rating_);
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
    if (!(obj instanceof com.google.cloud.dataqna.v1alpha.UserFeedback)) {
      return super.equals(obj);
    }
    com.google.cloud.dataqna.v1alpha.UserFeedback other = (com.google.cloud.dataqna.v1alpha.UserFeedback) obj;

    if (!getName()
        .equals(other.getName())) return false;
    if (!getFreeFormFeedback()
        .equals(other.getFreeFormFeedback())) return false;
    if (rating_ != other.rating_) return false;
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
    hash = (37 * hash) + FREE_FORM_FEEDBACK_FIELD_NUMBER;
    hash = (53 * hash) + getFreeFormFeedback().hashCode();
    hash = (37 * hash) + RATING_FIELD_NUMBER;
    hash = (53 * hash) + rating_;
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataqna.v1alpha.UserFeedback parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dataqna.v1alpha.UserFeedback prototype) {
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
   * Feedback provided by a user.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dataqna.v1alpha.UserFeedback}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dataqna.v1alpha.UserFeedback)
      com.google.cloud.dataqna.v1alpha.UserFeedbackOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dataqna.v1alpha.UserFeedbackProto.internal_static_google_cloud_dataqna_v1alpha_UserFeedback_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dataqna.v1alpha.UserFeedbackProto.internal_static_google_cloud_dataqna_v1alpha_UserFeedback_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dataqna.v1alpha.UserFeedback.class, com.google.cloud.dataqna.v1alpha.UserFeedback.Builder.class);
    }

    // Construct using com.google.cloud.dataqna.v1alpha.UserFeedback.newBuilder()
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

      freeFormFeedback_ = "";

      rating_ = 0;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dataqna.v1alpha.UserFeedbackProto.internal_static_google_cloud_dataqna_v1alpha_UserFeedback_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dataqna.v1alpha.UserFeedback getDefaultInstanceForType() {
      return com.google.cloud.dataqna.v1alpha.UserFeedback.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dataqna.v1alpha.UserFeedback build() {
      com.google.cloud.dataqna.v1alpha.UserFeedback result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dataqna.v1alpha.UserFeedback buildPartial() {
      com.google.cloud.dataqna.v1alpha.UserFeedback result = new com.google.cloud.dataqna.v1alpha.UserFeedback(this);
      result.name_ = name_;
      result.freeFormFeedback_ = freeFormFeedback_;
      result.rating_ = rating_;
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
      if (other instanceof com.google.cloud.dataqna.v1alpha.UserFeedback) {
        return mergeFrom((com.google.cloud.dataqna.v1alpha.UserFeedback)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dataqna.v1alpha.UserFeedback other) {
      if (other == com.google.cloud.dataqna.v1alpha.UserFeedback.getDefaultInstance()) return this;
      if (!other.getName().isEmpty()) {
        name_ = other.name_;
        onChanged();
      }
      if (!other.getFreeFormFeedback().isEmpty()) {
        freeFormFeedback_ = other.freeFormFeedback_;
        onChanged();
      }
      if (other.rating_ != 0) {
        setRatingValue(other.getRatingValue());
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
      com.google.cloud.dataqna.v1alpha.UserFeedback parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dataqna.v1alpha.UserFeedback) e.getUnfinishedMessage();
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
     * Required. The unique identifier for the user feedback.
     * User feedback is a singleton resource on a Question.
     * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
     * </pre>
     *
     * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The unique identifier for the user feedback.
     * User feedback is a singleton resource on a Question.
     * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
     * </pre>
     *
     * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The unique identifier for the user feedback.
     * User feedback is a singleton resource on a Question.
     * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
     * </pre>
     *
     * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The unique identifier for the user feedback.
     * User feedback is a singleton resource on a Question.
     * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
     * </pre>
     *
     * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return This builder for chaining.
     */
    public Builder clearName() {
      
      name_ = getDefaultInstance().getName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The unique identifier for the user feedback.
     * User feedback is a singleton resource on a Question.
     * Example: `projects/foo/locations/bar/questions/1234/userFeedback`
     * </pre>
     *
     * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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

    private java.lang.Object freeFormFeedback_ = "";
    /**
     * <pre>
     * Free form user feedback, such as a text box.
     * </pre>
     *
     * <code>string free_form_feedback = 2;</code>
     * @return The freeFormFeedback.
     */
    public java.lang.String getFreeFormFeedback() {
      java.lang.Object ref = freeFormFeedback_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        freeFormFeedback_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Free form user feedback, such as a text box.
     * </pre>
     *
     * <code>string free_form_feedback = 2;</code>
     * @return The bytes for freeFormFeedback.
     */
    public com.google.protobuf.ByteString
        getFreeFormFeedbackBytes() {
      java.lang.Object ref = freeFormFeedback_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        freeFormFeedback_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Free form user feedback, such as a text box.
     * </pre>
     *
     * <code>string free_form_feedback = 2;</code>
     * @param value The freeFormFeedback to set.
     * @return This builder for chaining.
     */
    public Builder setFreeFormFeedback(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      freeFormFeedback_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Free form user feedback, such as a text box.
     * </pre>
     *
     * <code>string free_form_feedback = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearFreeFormFeedback() {
      
      freeFormFeedback_ = getDefaultInstance().getFreeFormFeedback();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Free form user feedback, such as a text box.
     * </pre>
     *
     * <code>string free_form_feedback = 2;</code>
     * @param value The bytes for freeFormFeedback to set.
     * @return This builder for chaining.
     */
    public Builder setFreeFormFeedbackBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      freeFormFeedback_ = value;
      onChanged();
      return this;
    }

    private int rating_ = 0;
    /**
     * <pre>
     * The user feedback rating
     * </pre>
     *
     * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
     * @return The enum numeric value on the wire for rating.
     */
    @java.lang.Override public int getRatingValue() {
      return rating_;
    }
    /**
     * <pre>
     * The user feedback rating
     * </pre>
     *
     * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
     * @param value The enum numeric value on the wire for rating to set.
     * @return This builder for chaining.
     */
    public Builder setRatingValue(int value) {
      
      rating_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The user feedback rating
     * </pre>
     *
     * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
     * @return The rating.
     */
    @java.lang.Override
    public com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating getRating() {
      @SuppressWarnings("deprecation")
      com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating result = com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.valueOf(rating_);
      return result == null ? com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating.UNRECOGNIZED : result;
    }
    /**
     * <pre>
     * The user feedback rating
     * </pre>
     *
     * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
     * @param value The rating to set.
     * @return This builder for chaining.
     */
    public Builder setRating(com.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      rating_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The user feedback rating
     * </pre>
     *
     * <code>.google.cloud.dataqna.v1alpha.UserFeedback.UserFeedbackRating rating = 3;</code>
     * @return This builder for chaining.
     */
    public Builder clearRating() {
      
      rating_ = 0;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dataqna.v1alpha.UserFeedback)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dataqna.v1alpha.UserFeedback)
  private static final com.google.cloud.dataqna.v1alpha.UserFeedback DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dataqna.v1alpha.UserFeedback();
  }

  public static com.google.cloud.dataqna.v1alpha.UserFeedback getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<UserFeedback>
      PARSER = new com.google.protobuf.AbstractParser<UserFeedback>() {
    @java.lang.Override
    public UserFeedback parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new UserFeedback(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<UserFeedback> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<UserFeedback> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dataqna.v1alpha.UserFeedback getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

