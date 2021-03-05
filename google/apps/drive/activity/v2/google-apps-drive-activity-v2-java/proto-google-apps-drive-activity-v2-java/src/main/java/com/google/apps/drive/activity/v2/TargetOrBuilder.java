// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/drive/activity/v2/target.proto

package com.google.apps.drive.activity.v2;

public interface TargetOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.apps.drive.activity.v2.Target)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The target is a Drive item.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.DriveItem drive_item = 1;</code>
   * @return Whether the driveItem field is set.
   */
  boolean hasDriveItem();
  /**
   * <pre>
   * The target is a Drive item.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.DriveItem drive_item = 1;</code>
   * @return The driveItem.
   */
  com.google.apps.drive.activity.v2.DriveItem getDriveItem();
  /**
   * <pre>
   * The target is a Drive item.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.DriveItem drive_item = 1;</code>
   */
  com.google.apps.drive.activity.v2.DriveItemOrBuilder getDriveItemOrBuilder();

  /**
   * <pre>
   * The target is a shared drive.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.Drive drive = 5;</code>
   * @return Whether the drive field is set.
   */
  boolean hasDrive();
  /**
   * <pre>
   * The target is a shared drive.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.Drive drive = 5;</code>
   * @return The drive.
   */
  com.google.apps.drive.activity.v2.Drive getDrive();
  /**
   * <pre>
   * The target is a shared drive.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.Drive drive = 5;</code>
   */
  com.google.apps.drive.activity.v2.DriveOrBuilder getDriveOrBuilder();

  /**
   * <pre>
   * The target is a comment on a Drive file.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.FileComment file_comment = 3;</code>
   * @return Whether the fileComment field is set.
   */
  boolean hasFileComment();
  /**
   * <pre>
   * The target is a comment on a Drive file.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.FileComment file_comment = 3;</code>
   * @return The fileComment.
   */
  com.google.apps.drive.activity.v2.FileComment getFileComment();
  /**
   * <pre>
   * The target is a comment on a Drive file.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.FileComment file_comment = 3;</code>
   */
  com.google.apps.drive.activity.v2.FileCommentOrBuilder getFileCommentOrBuilder();

  /**
   * <pre>
   * This field is deprecated; please use the `drive` field instead.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.TeamDrive team_drive = 2 [deprecated = true];</code>
   * @return Whether the teamDrive field is set.
   */
  @java.lang.Deprecated boolean hasTeamDrive();
  /**
   * <pre>
   * This field is deprecated; please use the `drive` field instead.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.TeamDrive team_drive = 2 [deprecated = true];</code>
   * @return The teamDrive.
   */
  @java.lang.Deprecated com.google.apps.drive.activity.v2.TeamDrive getTeamDrive();
  /**
   * <pre>
   * This field is deprecated; please use the `drive` field instead.
   * </pre>
   *
   * <code>.google.apps.drive.activity.v2.TeamDrive team_drive = 2 [deprecated = true];</code>
   */
  @java.lang.Deprecated com.google.apps.drive.activity.v2.TeamDriveOrBuilder getTeamDriveOrBuilder();

  public com.google.apps.drive.activity.v2.Target.ObjectCase getObjectCase();
}
