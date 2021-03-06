<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/websecurityscanner/v1alpha/scan_config.proto

namespace GPBMetadata\Google\Cloud\Websecurityscanner\V1Alpha;

class ScanConfig
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Websecurityscanner\V1Alpha\ScanRun::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/cloud/websecurityscanner/v1alpha/scan_config.proto\'google.cloud.websecurityscanner.v1alphagoogle/api/resource.proto6google/cloud/websecurityscanner/v1alpha/scan_run.protogoogle/protobuf/timestamp.proto"�


ScanConfig
name (	
display_name (	B�A
max_qps (
starting_urls (	B�AZ
authentication (2B.google.cloud.websecurityscanner.v1alpha.ScanConfig.AuthenticationQ

user_agent (2=.google.cloud.websecurityscanner.v1alpha.ScanConfig.UserAgent
blacklist_patterns (	N
schedule (2<.google.cloud.websecurityscanner.v1alpha.ScanConfig.Schedule\\
target_platforms	 (2B.google.cloud.websecurityscanner.v1alpha.ScanConfig.TargetPlatformD

latest_run (20.google.cloud.websecurityscanner.v1alpha.ScanRun�
Authenticationj
google_account (2P.google.cloud.websecurityscanner.v1alpha.ScanConfig.Authentication.GoogleAccountH j
custom_account (2P.google.cloud.websecurityscanner.v1alpha.ScanConfig.Authentication.CustomAccountH @
GoogleAccount
username (	B�A
password (	B�A�AX
CustomAccount
username (	B�A
password (	B�A�A
	login_url (	B�AB
authenticationb
Schedule1
schedule_time (2.google.protobuf.Timestamp#
interval_duration_days (B�A"`
	UserAgent
USER_AGENT_UNSPECIFIED 
CHROME_LINUX
CHROME_ANDROID
SAFARI_IPHONE"N
TargetPlatform
TARGET_PLATFORM_UNSPECIFIED 

APP_ENGINE
COMPUTE:_�A\\
,websecurityscanner.googleapis.com/ScanConfig,projects/{project}/scanConfigs/{scan_config}B�
+com.google.cloud.websecurityscanner.v1alphaBScanConfigProtoPZYgoogle.golang.org/genproto/googleapis/cloud/websecurityscanner/v1alpha;websecurityscannerbproto3'
        , true);

        static::$is_initialized = true;
    }
}

