<?php

return [
    'interfaces' => [
        'google.cloud.clouddms.v1.DataMigrationService' => [
            'CreateMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StartMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StopMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ResumeMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'PromoteMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'VerifyMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'RestartMigrationJob' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\MigrationJob',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateConnectionProfile' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\ConnectionProfile',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateConnectionProfile' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Clouddms\V1\ConnectionProfile',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteConnectionProfile' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Clouddms\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListMigrationJobs' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getMigrationJobs',
                ],
            ],
            'ListConnectionProfiles' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getConnectionProfiles',
                ],
            ],
        ],
    ],
];
