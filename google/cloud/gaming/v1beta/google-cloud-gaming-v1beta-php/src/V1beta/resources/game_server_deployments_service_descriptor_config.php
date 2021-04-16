<?php

return [
    'interfaces' => [
        'google.cloud.gaming.v1beta.GameServerDeploymentsService' => [
            'CreateGameServerDeployment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Gaming\V1beta\GameServerDeployment',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteGameServerDeployment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateGameServerDeployment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Gaming\V1beta\GameServerDeployment',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateGameServerDeploymentRollout' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Gaming\V1beta\GameServerDeployment',
                    'metadataReturnType' => '\Google\Cloud\Gaming\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListGameServerDeployments' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getGameServerDeployments',
                ],
            ],
        ],
    ],
];
