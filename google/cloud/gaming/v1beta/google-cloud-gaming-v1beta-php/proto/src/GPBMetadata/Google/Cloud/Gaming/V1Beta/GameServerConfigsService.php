<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/gaming/v1beta/game_server_configs_service.proto

namespace GPBMetadata\Google\Cloud\Gaming\V1Beta;

class GameServerConfigsService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Cloud\Gaming\V1Beta\GameServerConfigs::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
<google/cloud/gaming/v1beta/game_server_configs_service.protogoogle.cloud.gaming.v1betagoogle/api/client.proto4google/cloud/gaming/v1beta/game_server_configs.proto#google/longrunning/operations.proto2�
GameServerConfigsService�
ListGameServerConfigs8.google.cloud.gaming.v1beta.ListGameServerConfigsRequest9.google.cloud.gaming.v1beta.ListGameServerConfigsResponse"X���IG/v1beta/{parent=projects/*/locations/*/gameServerDeployments/*}/configs�Aparent�
GetGameServerConfig6.google.cloud.gaming.v1beta.GetGameServerConfigRequest,.google.cloud.gaming.v1beta.GameServerConfig"V���IG/v1beta/{name=projects/*/locations/*/gameServerDeployments/*/configs/*}�Aname�
CreateGameServerConfig9.google.cloud.gaming.v1beta.CreateGameServerConfigRequest.google.longrunning.Operation"����]"G/v1beta/{parent=projects/*/locations/*/gameServerDeployments/*}/configs:game_server_config�Aparent,game_server_config�A%
GameServerConfigOperationMetadata�
DeleteGameServerConfig9.google.cloud.gaming.v1beta.DeleteGameServerConfigRequest.google.longrunning.Operation"����I*G/v1beta/{name=projects/*/locations/*/gameServerDeployments/*/configs/*}�Aname�A*
google.protobuf.EmptyOperationMetadataO�Agameservices.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
com.google.cloud.gaming.v1betaPZ@google.golang.org/genproto/googleapis/cloud/gaming/v1beta;gaming�Google\\Cloud\\Gaming\\V1betabproto3'
        , true);

        static::$is_initialized = true;
    }
}

