<?php

return [
    'interfaces' => [
        'google.cloud.notebooks.v1.ManagedNotebookService' => [
            'CreateRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ReportRuntimeEvent' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ResetRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StartRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StopRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'SwitchRuntime' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Notebooks\V1\Runtime',
                    'metadataReturnType' => '\Google\Cloud\Notebooks\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListRuntimes' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getRuntimes',
                ],
            ],
        ],
    ],
];
