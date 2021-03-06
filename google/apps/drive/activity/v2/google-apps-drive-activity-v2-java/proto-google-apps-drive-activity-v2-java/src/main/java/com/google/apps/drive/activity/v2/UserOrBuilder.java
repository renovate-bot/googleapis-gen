// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/drive/activity/v2/actor.proto

package com.google.apps.drive.activity.v2;

public interface UserOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.apps.drive.activity.v2.User)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A known user.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.KnownUser known_user = 2;</code>
   * @return Whether the knownUser field is set.
   */
  boolean hasKnownUser();
  /**
   * <pre>
   * A known user.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.KnownUser known_user = 2;</code>
   * @return The knownUser.
   */
  com.google.apps.drive.activity.v2.User.KnownUser getKnownUser();
  /**
   * <pre>
   * A known user.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.KnownUser known_user = 2;</code>
   */
  com.google.apps.drive.activity.v2.User.KnownUserOrBuilder getKnownUserOrBuilder();

  /**
   * <pre>
   * A user whose account has since been deleted.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.DeletedUser deleted_user = 3;</code>
   * @return Whether the deletedUser field is set.
   */
  boolean hasDeletedUser();
  /**
   * <pre>
   * A user whose account has since been deleted.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.DeletedUser deleted_user = 3;</code>
   * @return The deletedUser.
   */
  com.google.apps.drive.activity.v2.User.DeletedUser getDeletedUser();
  /**
   * <pre>
   * A user whose account has since been deleted.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.DeletedUser deleted_user = 3;</code>
   */
  com.google.apps.drive.activity.v2.User.DeletedUserOrBuilder getDeletedUserOrBuilder();

  /**
   * <pre>
   * A user about whom nothing is currently known.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.UnknownUser unknown_user = 4;</code>
   * @return Whether the unknownUser field is set.
   */
  boolean hasUnknownUser();
  /**
   * <pre>
   * A user about whom nothing is currently known.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.UnknownUser unknown_user = 4;</code>
   * @return The unknownUser.
   */
  com.google.apps.drive.activity.v2.User.UnknownUser getUnknownUser();
  /**
   * <pre>
   * A user about whom nothing is currently known.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.User.UnknownUser unknown_user = 4;</code>
   */
  com.google.apps.drive.activity.v2.User.UnknownUserOrBuilder getUnknownUserOrBuilder();

  public com.google.apps.drive.activity.v2.User.TypeCase getTypeCase();
}
