<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/apps/drive/activity/v2/common.proto

namespace GPBMetadata\Google\Apps\Drive\Activity\V2;

class Common
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
*google/apps/drive/activity/v2/common.protogoogle.apps.drive.activity.v2"i
	TimeRange.

start_time (2.google.protobuf.Timestamp,
end_time (2.google.protobuf.Timestamp"%
Group
email (	
title (	")
Domain
name (	
	legacy_id (	B�
!com.google.apps.drive.activity.v2BCommonProtoPZEgoogle.golang.org/genproto/googleapis/apps/drive/activity/v2;activity�GADA�Google.Apps.Drive.Activity.V2�Google\\Apps\\Drive\\Activity\\V2bproto3'
        , true);

        static::$is_initialized = true;
    }
}

