// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/market/v2/resources.proto

package com.google.ccc.hosted.marketplace.v2;

public interface UserLicenseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:ccc.hosted.marketplace.v2.UserLicense)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The type of API resource. This is always appsmarket#userLicense.
   * </pre>
   *
   * <code>string kind = 1;</code>
   * @return The kind.
   */
  java.lang.String getKind();
  /**
   * <pre>
   * The type of API resource. This is always appsmarket#userLicense.
   * </pre>
   *
   * <code>string kind = 1;</code>
   * @return The bytes for kind.
   */
  com.google.protobuf.ByteString
      getKindBytes();

  /**
   * <pre>
   * The domain administrator has activated the application for this domain.
   * </pre>
   *
   * <code>bool enabled = 2;</code>
   * @return The enabled.
   */
  boolean getEnabled();

  /**
   * <pre>
   * The user's licensing status. One of:
   * - `ACTIVE`: The user has a valid license and should be permitted to use the
   * application.
   * - `UNLICENSED`: The administrator of this user's domain never assigned a
   * seat for the application to this user.
   * - `EXPIRED`: The administrator assigned a seat to this user, but the
   * license is expired.
   * </pre>
   *
   * <code>string state = 3;</code>
   * @return The state.
   */
  java.lang.String getState();
  /**
   * <pre>
   * The user's licensing status. One of:
   * - `ACTIVE`: The user has a valid license and should be permitted to use the
   * application.
   * - `UNLICENSED`: The administrator of this user's domain never assigned a
   * seat for the application to this user.
   * - `EXPIRED`: The administrator assigned a seat to this user, but the
   * license is expired.
   * </pre>
   *
   * <code>string state = 3;</code>
   * @return The bytes for state.
   */
  com.google.protobuf.ByteString
      getStateBytes();

  /**
   * <pre>
   * (Deprecated)
   * </pre>
   *
   * <code>string edition_id = 4 [deprecated = true];</code>
   * @return The editionId.
   */
  @java.lang.Deprecated java.lang.String getEditionId();
  /**
   * <pre>
   * (Deprecated)
   * </pre>
   *
   * <code>string edition_id = 4 [deprecated = true];</code>
   * @return The bytes for editionId.
   */
  @java.lang.Deprecated com.google.protobuf.ByteString
      getEditionIdBytes();

  /**
   * <pre>
   * The domain name of the user.
   * </pre>
   *
   * <code>string customer_id = 5;</code>
   * @return The customerId.
   */
  java.lang.String getCustomerId();
  /**
   * <pre>
   * The domain name of the user.
   * </pre>
   *
   * <code>string customer_id = 5;</code>
   * @return The bytes for customerId.
   */
  com.google.protobuf.ByteString
      getCustomerIdBytes();

  /**
   * <pre>
   * The ID of the application corresponding to the license query.
   * </pre>
   *
   * <code>string application_id = 6;</code>
   * @return The applicationId.
   */
  java.lang.String getApplicationId();
  /**
   * <pre>
   * The ID of the application corresponding to the license query.
   * </pre>
   *
   * <code>string application_id = 6;</code>
   * @return The bytes for applicationId.
   */
  com.google.protobuf.ByteString
      getApplicationIdBytes();

  /**
   * <pre>
   * The ID of user license.
   * </pre>
   *
   * <code>string id = 101;</code>
   * @return The id.
   */
  java.lang.String getId();
  /**
   * <pre>
   * The ID of user license.
   * </pre>
   *
   * <code>string id = 101;</code>
   * @return The bytes for id.
   */
  com.google.protobuf.ByteString
      getIdBytes();

  /**
   * <pre>
   * The email address of the user.
   * </pre>
   *
   * <code>string user_id = 102;</code>
   * @return The userId.
   */
  java.lang.String getUserId();
  /**
   * <pre>
   * The email address of the user.
   * </pre>
   *
   * <code>string user_id = 102;</code>
   * @return The bytes for userId.
   */
  com.google.protobuf.ByteString
      getUserIdBytes();
}
