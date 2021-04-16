<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/game_server_configs.proto

namespace GPBMetadata\Google\Cloud\Gaming\V1Beta;

class GameServerConfigs
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\Common::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
4google/cloud/gaming/v1beta/game_server_configs.protogoogle.cloud.gaming.v1betagoogle/api/resource.proto\'google/cloud/gaming/v1beta/common.protogoogle/protobuf/timestamp.protogoogle/api/annotations.proto"�
ListGameServerConfigsRequestD
parent (	B4�A�A.,gameservices.googleapis.com/GameServerConfig
	page_size (B�A

page_token (	B�A
filter (	B�A
order_by (	B�A"�
ListGameServerConfigsResponseI
game_server_configs (2,.google.cloud.gaming.v1beta.GameServerConfig
next_page_token (	
unreachable (	"`
GetGameServerConfigRequestB
name (	B4�A�A.
,gameservices.googleapis.com/GameServerConfig"�
CreateGameServerConfigRequestD
parent (	B4�A�A.,gameservices.googleapis.com/GameServerConfig
	config_id (	B�AM
game_server_config (2,.google.cloud.gaming.v1beta.GameServerConfigB�A"c
DeleteGameServerConfigRequestB
name (	B4�A�A.
,gameservices.googleapis.com/GameServerConfig"�
ScalingConfig
name (	B�A"
fleet_autoscaler_spec (	B�A<
	selectors (2).google.cloud.gaming.v1beta.LabelSelector7
	schedules (2$.google.cloud.gaming.v1beta.Schedule"/
FleetConfig

fleet_spec (	
name (	"�
GameServerConfig
name (	4
create_time (2.google.protobuf.TimestampB�A4
update_time (2.google.protobuf.TimestampB�AH
labels (28.google.cloud.gaming.v1beta.GameServerConfig.LabelsEntry>
fleet_configs (2\'.google.cloud.gaming.v1beta.FleetConfigB
scaling_configs (2).google.cloud.gaming.v1beta.ScalingConfig
description (	-
LabelsEntry
key (	
value (	:8:��A�
,gameservices.googleapis.com/GameServerConfig[projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}B�
com.google.cloud.gaming.v1betaPZ@google.golang.org/genproto/googleapis/cloud/gaming/v1beta;gaming�Google\\Cloud\\Gaming\\V1betabproto3'
        , true);

        static::$is_initialized = true;
    }
}

