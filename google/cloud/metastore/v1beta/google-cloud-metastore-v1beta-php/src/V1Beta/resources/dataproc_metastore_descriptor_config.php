<?php

return [
    'interfaces' => [
        'google.cloud.metastore.v1beta.DataprocMetastore' => [
            'CreateService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\Service',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\Service',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateMetadataImport' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\MetadataImport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateMetadataImport' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\MetadataImport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ExportMetadata' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\MetadataExport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'RestoreService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\Restore',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateBackup' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1beta\Backup',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteBackup' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1beta\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListServices' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getServices',
                ],
            ],
            'ListMetadataImports' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getMetadataImports',
                ],
            ],
            'ListBackups' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getBackups',
                ],
            ],
        ],
    ],
];
