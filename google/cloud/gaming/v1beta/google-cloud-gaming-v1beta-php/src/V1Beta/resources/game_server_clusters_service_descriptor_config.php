<?php

return [
    'interfaces' => [
        'google.cloud.gaming.v1beta.GameServerClustersService' => [
            'CreateGameServerCluster' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Gaming\V1beta\GameServerCluster',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteGameServerCluster' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateGameServerCluster' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Gaming\V1beta\GameServerCluster',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListGameServerClusters' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getGameServerClusters',
                ],
            ],
        ],
    ],
];
