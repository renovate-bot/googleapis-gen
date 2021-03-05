<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/action.proto

namespace GPBMetadata\Google\Apps\Drive\Activity\V2;

class Action
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Actor::initOnce();
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Common::initOnce();
        \GPBMetadata\Google\Apps\Drive\Activity\V2\Target::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�%
*google/apps/drive/activity/v2/action.protogoogle.apps.drive.activity.v2*google/apps/drive/activity/v2/common.proto*google/apps/drive/activity/v2/target.protogoogle/protobuf/timestamp.proto"�
Action;
detail (2+.google.apps.drive.activity.v2.ActionDetail3
actor (2$.google.apps.drive.activity.v2.Actor5
target (2%.google.apps.drive.activity.v2.Target/
	timestamp (2.google.protobuf.TimestampH >

time_range (2(.google.apps.drive.activity.v2.TimeRangeH B
time"�
ActionDetail7
create (2%.google.apps.drive.activity.v2.CreateH 3
edit (2#.google.apps.drive.activity.v2.EditH 3
move (2#.google.apps.drive.activity.v2.MoveH 7
rename (2%.google.apps.drive.activity.v2.RenameH 7
delete (2%.google.apps.drive.activity.v2.DeleteH 9
restore (2&.google.apps.drive.activity.v2.RestoreH L
permission_change (2/.google.apps.drive.activity.v2.PermissionChangeH 9
comment (2&.google.apps.drive.activity.v2.CommentH M

dlp_change	 (27.google.apps.drive.activity.v2.DataLeakPreventionChangeH H
	reference (23.google.apps.drive.activity.v2.ApplicationReferenceH H
settings_change (2-.google.apps.drive.activity.v2.SettingsChangeH B
action_detail"�
Create8
new (2).google.apps.drive.activity.v2.Create.NewH >
upload (2,.google.apps.drive.activity.v2.Create.UploadH :
copy (2*.google.apps.drive.activity.v2.Create.CopyH 
New
UploadO
CopyG
original_object (2..google.apps.drive.activity.v2.TargetReferenceB
origin"
Edit"�
MoveE
added_parents (2..google.apps.drive.activity.v2.TargetReferenceG
removed_parents (2..google.apps.drive.activity.v2.TargetReference".
Rename
	old_title (	
	new_title (	"�
Delete8
type (2*.google.apps.drive.activity.v2.Delete.Type"=
Type
TYPE_UNSPECIFIED 	
TRASH
PERMANENT_DELETE"o
Restore9
type (2+.google.apps.drive.activity.v2.Restore.Type")
Type
TYPE_UNSPECIFIED 
UNTRASH"�
PermissionChangeD
added_permissions (2).google.apps.drive.activity.v2.PermissionF
removed_permissions (2).google.apps.drive.activity.v2.Permission"�

Permission<
role (2..google.apps.drive.activity.v2.Permission.Role3
user (2#.google.apps.drive.activity.v2.UserH 5
group (2$.google.apps.drive.activity.v2.GroupH 7
domain (2%.google.apps.drive.activity.v2.DomainH B
anyone (20.google.apps.drive.activity.v2.Permission.AnyoneH 
allow_discovery (
Anyone"�
Role
ROLE_UNSPECIFIED 	
OWNER
	ORGANIZER
FILE_ORGANIZER

EDITOR
	COMMENTER

VIEWER
PUBLISHED_VIEWERB
scope"�
Comment;
post (2+.google.apps.drive.activity.v2.Comment.PostH G

assignment (21.google.apps.drive.activity.v2.Comment.AssignmentH G

suggestion (21.google.apps.drive.activity.v2.Comment.SuggestionH <
mentioned_users (2#.google.apps.drive.activity.v2.User�
PostD
subtype (23.google.apps.drive.activity.v2.Comment.Post.Subtype"z
Subtype
SUBTYPE_UNSPECIFIED 	
ADDED
DELETED
REPLY_ADDED
REPLY_DELETED
RESOLVED
REOPENED�

AssignmentJ
subtype (29.google.apps.drive.activity.v2.Comment.Assignment.Subtype:
assigned_user (2#.google.apps.drive.activity.v2.User"�
Subtype
SUBTYPE_UNSPECIFIED 	
ADDED
DELETED
REPLY_ADDED
REPLY_DELETED
RESOLVED
REOPENED

REASSIGNED�

SuggestionJ
subtype (29.google.apps.drive.activity.v2.Comment.Suggestion.Subtype"�
Subtype
SUBTYPE_UNSPECIFIED 	
ADDED
DELETED
REPLY_ADDED
REPLY_DELETED
ACCEPTED
REJECTED
ACCEPT_DELETED	
REJECT_DELETED
B
type"�
DataLeakPreventionChangeJ
type (2<.google.apps.drive.activity.v2.DataLeakPreventionChange.Type"6
Type
TYPE_UNSPECIFIED 
FLAGGED
CLEARED"�
ApplicationReferenceF
type (28.google.apps.drive.activity.v2.ApplicationReference.Type"=
Type
UNSPECIFIED_REFERENCE_TYPE 
LINK
DISCUSS"�
SettingsChange\\
restriction_changes (2?.google.apps.drive.activity.v2.SettingsChange.RestrictionChange�
RestrictionChangeX
feature (2G.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Featured
new_restriction (2K.google.apps.drive.activity.v2.SettingsChange.RestrictionChange.Restriction"
Feature
FEATURE_UNSPECIFIED 
SHARING_OUTSIDE_DOMAIN
DIRECT_SHARING
ITEM_DUPLICATION
DRIVE_FILE_STREAM"R
Restriction
RESTRICTION_UNSPECIFIED 
UNRESTRICTED
FULLY_RESTRICTEDB�
!com.google.apps.drive.activity.v2BActionProtoPZEgoogle.golang.org/genproto/googleapis/apps/drive/activity/v2;activity�GADA�Google.Apps.Drive.Activity.V2�Google\\Apps\\Drive\\Activity\\V2bproto3'
        , true);

        static::$is_initialized = true;
    }
}

