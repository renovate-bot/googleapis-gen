<?php

return [
    'interfaces' => [
        'google.cloud.metastore.v1.DataprocMetastore' => [
            'CreateMetadataImport' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1\MetadataImport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '60000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '120000',
                    'totalPollTimeoutMillis' => '4800000',
                ],
            ],
            'CreateService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1\Service',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '60000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '120000',
                    'totalPollTimeoutMillis' => '4800000',
                ],
            ],
            'DeleteService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '10000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '60000',
                    'totalPollTimeoutMillis' => '1500000',
                ],
            ],
            'ExportMetadata' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1\MetadataExport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '60000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '120000',
                    'totalPollTimeoutMillis' => '4800000',
                ],
            ],
            'UpdateMetadataImport' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1\MetadataImport',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '60000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '120000',
                    'totalPollTimeoutMillis' => '1200000',
                ],
            ],
            'UpdateService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Metastore\V1\Service',
                    'metadataReturnType' => '\Google\Cloud\Metastore\V1\OperationMetadata',
                    'initialPollDelayMillis' => '60000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '120000',
                    'totalPollTimeoutMillis' => '3000000',
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
        ],
    ],
];
