<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/drive_activity_service.proto

namespace GPBMetadata\Google\Apps\Drive\Activity\V2;

class DriveActivityService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Apps\Drive\Activity\V2\QueryDriveActivityRequest::initOnce();
        \GPBMetadata\Google\Apps\Drive\Activity\V2\QueryDriveActivityResponse::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
:google/apps/drive/activity/v2/drive_activity_service.protogoogle.apps.drive.activity.v2@google/apps/drive/activity/v2/query_drive_activity_request.protoAgoogle/apps/drive/activity/v2/query_drive_activity_response.protogoogle/api/client.proto2�
DriveActivityService�
QueryDriveActivity8.google.apps.drive.activity.v2.QueryDriveActivityRequest9.google.apps.drive.activity.v2.QueryDriveActivityResponse"���"/v2/activity:query:*��Adriveactivity.googleapis.com�Afhttps://www.googleapis.com/auth/drive.activity,https://www.googleapis.com/auth/drive.activity.readonlyB�
!com.google.apps.drive.activity.v2BDriveActivityServiceProtoPZEgoogle.golang.org/genproto/googleapis/apps/drive/activity/v2;activity�GADA�Google.Apps.Drive.Activity.V2�Google\\Apps\\Drive\\Activity\\V2bproto3'
        , true);

        static::$is_initialized = true;
    }
}

