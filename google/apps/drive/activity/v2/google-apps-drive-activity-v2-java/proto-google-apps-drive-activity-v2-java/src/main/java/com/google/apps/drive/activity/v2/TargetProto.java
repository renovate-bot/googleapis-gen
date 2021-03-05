// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/drive/activity/v2/target.proto

package com.google.apps.drive.activity.v2;

public final class TargetProto {
  private TargetProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_Target_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_Target_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_TargetReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_TargetReference_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_FileComment_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_FileComment_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItem_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItem_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItem_File_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItem_File_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItem_Folder_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItem_Folder_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFile_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItem_DriveFile_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFolder_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItem_DriveFolder_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_Owner_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_Owner_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_TeamDrive_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_TeamDrive_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_Drive_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_Drive_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveItemReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveItemReference_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_TeamDriveReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_TeamDriveReference_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_apps_drive_activity_v2_DriveReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_apps_drive_activity_v2_DriveReference_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n*google/apps/drive/activity/v2/target.p" +
      "roto\022\035google.apps.drive.activity.v2\032)goo" +
      "gle/apps/drive/activity/v2/actor.proto\032*" +
      "google/apps/drive/activity/v2/common.pro" +
      "to\"\217\002\n\006Target\022>\n\ndrive_item\030\001 \001(\0132(.goog" +
      "le.apps.drive.activity.v2.DriveItemH\000\0225\n" +
      "\005drive\030\005 \001(\0132$.google.apps.drive.activit" +
      "y.v2.DriveH\000\022B\n\014file_comment\030\003 \001(\0132*.goo" +
      "gle.apps.drive.activity.v2.FileCommentH\000" +
      "\022@\n\nteam_drive\030\002 \001(\0132(.google.apps.drive" +
      ".activity.v2.TeamDriveB\002\030\001B\010\n\006object\"\357\001\n" +
      "\017TargetReference\022G\n\ndrive_item\030\001 \001(\01321.g" +
      "oogle.apps.drive.activity.v2.DriveItemRe" +
      "ferenceH\000\022>\n\005drive\030\003 \001(\0132-.google.apps.d" +
      "rive.activity.v2.DriveReferenceH\000\022I\n\ntea" +
      "m_drive\030\002 \001(\01321.google.apps.drive.activi" +
      "ty.v2.TeamDriveReferenceB\002\030\001B\010\n\006object\"\234" +
      "\001\n\013FileComment\022\031\n\021legacy_comment_id\030\001 \001(" +
      "\t\022\034\n\024legacy_discussion_id\030\002 \001(\t\022\032\n\022link_" +
      "to_discussion\030\003 \001(\t\0228\n\006parent\030\004 \001(\0132(.go" +
      "ogle.apps.drive.activity.v2.DriveItem\"\234\006" +
      "\n\tDriveItem\022\014\n\004name\030\001 \001(\t\022\r\n\005title\030\002 \001(\t" +
      "\022?\n\004file\030\003 \001(\0132-.google.apps.drive.activ" +
      "ity.v2.DriveItem.FileB\002\030\001\022C\n\006folder\030\004 \001(" +
      "\0132/.google.apps.drive.activity.v2.DriveI" +
      "tem.FolderB\002\030\001\022H\n\ndrive_file\030\010 \001(\01322.goo" +
      "gle.apps.drive.activity.v2.DriveItem.Dri" +
      "veFileH\000\022L\n\014drive_folder\030\t \001(\01324.google." +
      "apps.drive.activity.v2.DriveItem.DriveFo" +
      "lderH\000\022\021\n\tmime_type\030\006 \001(\t\0223\n\005owner\030\007 \001(\013" +
      "2$.google.apps.drive.activity.v2.Owner\032\n" +
      "\n\004File:\002\030\001\032\257\001\n\006Folder\022B\n\004type\030\006 \001(\01624.go" +
      "ogle.apps.drive.activity.v2.DriveItem.Fo" +
      "lder.Type\"]\n\004Type\022\024\n\020TYPE_UNSPECIFIED\020\000\022" +
      "\021\n\rMY_DRIVE_ROOT\020\001\022\023\n\017TEAM_DRIVE_ROOT\020\002\022" +
      "\023\n\017STANDARD_FOLDER\020\003\032\002\030\001:\002\030\001\032\013\n\tDriveFil" +
      "e\032\263\001\n\013DriveFolder\022G\n\004type\030\006 \001(\01629.google" +
      ".apps.drive.activity.v2.DriveItem.DriveF" +
      "older.Type\"[\n\004Type\022\024\n\020TYPE_UNSPECIFIED\020\000" +
      "\022\021\n\rMY_DRIVE_ROOT\020\001\022\025\n\021SHARED_DRIVE_ROOT" +
      "\020\002\022\023\n\017STANDARD_FOLDER\020\003B\013\n\titem_type\"\207\002\n" +
      "\005Owner\0223\n\004user\030\001 \001(\0132#.google.apps.drive" +
      ".activity.v2.UserH\000\022>\n\005drive\030\004 \001(\0132-.goo" +
      "gle.apps.drive.activity.v2.DriveReferenc" +
      "eH\000\022I\n\nteam_drive\030\002 \001(\01321.google.apps.dr" +
      "ive.activity.v2.TeamDriveReferenceB\002\030\001\0225" +
      "\n\006domain\030\003 \001(\0132%.google.apps.drive.activ" +
      "ity.v2.DomainB\007\n\005owner\"d\n\tTeamDrive\022\014\n\004n" +
      "ame\030\001 \001(\t\022\r\n\005title\030\002 \001(\t\0226\n\004root\030\003 \001(\0132(" +
      ".google.apps.drive.activity.v2.DriveItem" +
      ":\002\030\001\"\\\n\005Drive\022\014\n\004name\030\001 \001(\t\022\r\n\005title\030\002 \001" +
      "(\t\0226\n\004root\030\003 \001(\0132(.google.apps.drive.act" +
      "ivity.v2.DriveItem\"\334\002\n\022DriveItemReferenc" +
      "e\022\014\n\004name\030\001 \001(\t\022\r\n\005title\030\002 \001(\t\022?\n\004file\030\003" +
      " \001(\0132-.google.apps.drive.activity.v2.Dri" +
      "veItem.FileB\002\030\001\022C\n\006folder\030\004 \001(\0132/.google" +
      ".apps.drive.activity.v2.DriveItem.Folder" +
      "B\002\030\001\022H\n\ndrive_file\030\010 \001(\01322.google.apps.d" +
      "rive.activity.v2.DriveItem.DriveFileH\000\022L" +
      "\n\014drive_folder\030\t \001(\01324.google.apps.drive" +
      ".activity.v2.DriveItem.DriveFolderH\000B\013\n\t" +
      "item_type\"5\n\022TeamDriveReference\022\014\n\004name\030" +
      "\001 \001(\t\022\r\n\005title\030\002 \001(\t:\002\030\001\"-\n\016DriveReferen" +
      "ce\022\014\n\004name\030\001 \001(\t\022\r\n\005title\030\002 \001(\tB\300\001\n!com." +
      "google.apps.drive.activity.v2B\013TargetPro" +
      "toP\001ZEgoogle.golang.org/genproto/googlea" +
      "pis/apps/drive/activity/v2;activity\242\002\004GA" +
      "DA\252\002\035Google.Apps.Drive.Activity.V2\312\002\035Goo" +
      "gle\\Apps\\Drive\\Activity\\V2b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.apps.drive.activity.v2.ActorProto.getDescriptor(),
          com.google.apps.drive.activity.v2.CommonProto.getDescriptor(),
        });
    internal_static_google_apps_drive_activity_v2_Target_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_apps_drive_activity_v2_Target_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_Target_descriptor,
        new java.lang.String[] { "DriveItem", "Drive", "FileComment", "TeamDrive", "Object", });
    internal_static_google_apps_drive_activity_v2_TargetReference_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_apps_drive_activity_v2_TargetReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_TargetReference_descriptor,
        new java.lang.String[] { "DriveItem", "Drive", "TeamDrive", "Object", });
    internal_static_google_apps_drive_activity_v2_FileComment_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_apps_drive_activity_v2_FileComment_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_FileComment_descriptor,
        new java.lang.String[] { "LegacyCommentId", "LegacyDiscussionId", "LinkToDiscussion", "Parent", });
    internal_static_google_apps_drive_activity_v2_DriveItem_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_apps_drive_activity_v2_DriveItem_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItem_descriptor,
        new java.lang.String[] { "Name", "Title", "File", "Folder", "DriveFile", "DriveFolder", "MimeType", "Owner", "ItemType", });
    internal_static_google_apps_drive_activity_v2_DriveItem_File_descriptor =
      internal_static_google_apps_drive_activity_v2_DriveItem_descriptor.getNestedTypes().get(0);
    internal_static_google_apps_drive_activity_v2_DriveItem_File_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItem_File_descriptor,
        new java.lang.String[] { });
    internal_static_google_apps_drive_activity_v2_DriveItem_Folder_descriptor =
      internal_static_google_apps_drive_activity_v2_DriveItem_descriptor.getNestedTypes().get(1);
    internal_static_google_apps_drive_activity_v2_DriveItem_Folder_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItem_Folder_descriptor,
        new java.lang.String[] { "Type", });
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFile_descriptor =
      internal_static_google_apps_drive_activity_v2_DriveItem_descriptor.getNestedTypes().get(2);
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFile_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItem_DriveFile_descriptor,
        new java.lang.String[] { });
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFolder_descriptor =
      internal_static_google_apps_drive_activity_v2_DriveItem_descriptor.getNestedTypes().get(3);
    internal_static_google_apps_drive_activity_v2_DriveItem_DriveFolder_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItem_DriveFolder_descriptor,
        new java.lang.String[] { "Type", });
    internal_static_google_apps_drive_activity_v2_Owner_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_apps_drive_activity_v2_Owner_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_Owner_descriptor,
        new java.lang.String[] { "User", "Drive", "TeamDrive", "Domain", "Owner", });
    internal_static_google_apps_drive_activity_v2_TeamDrive_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_apps_drive_activity_v2_TeamDrive_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_TeamDrive_descriptor,
        new java.lang.String[] { "Name", "Title", "Root", });
    internal_static_google_apps_drive_activity_v2_Drive_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_apps_drive_activity_v2_Drive_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_Drive_descriptor,
        new java.lang.String[] { "Name", "Title", "Root", });
    internal_static_google_apps_drive_activity_v2_DriveItemReference_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_apps_drive_activity_v2_DriveItemReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveItemReference_descriptor,
        new java.lang.String[] { "Name", "Title", "File", "Folder", "DriveFile", "DriveFolder", "ItemType", });
    internal_static_google_apps_drive_activity_v2_TeamDriveReference_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_google_apps_drive_activity_v2_TeamDriveReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_TeamDriveReference_descriptor,
        new java.lang.String[] { "Name", "Title", });
    internal_static_google_apps_drive_activity_v2_DriveReference_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_google_apps_drive_activity_v2_DriveReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_apps_drive_activity_v2_DriveReference_descriptor,
        new java.lang.String[] { "Name", "Title", });
    com.google.apps.drive.activity.v2.ActorProto.getDescriptor();
    com.google.apps.drive.activity.v2.CommonProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
