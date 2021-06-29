<?php

return [
    'interfaces' => [
        'google.cloud.orchestration.airflow.service.v1beta1.Environments' => [
            'CheckUpgrade' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\CheckUpgradeResponse',
                    'metadataReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateEnvironment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\Environment',
                    'metadataReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteEnvironment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'RestartWebServer' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\Environment',
                    'metadataReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateEnvironment' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\Environment',
                    'metadataReturnType' => '\Google\Cloud\Orchestration\Airflow\Service\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListEnvironments' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getEnvironments',
                ],
            ],
        ],
    ],
];
