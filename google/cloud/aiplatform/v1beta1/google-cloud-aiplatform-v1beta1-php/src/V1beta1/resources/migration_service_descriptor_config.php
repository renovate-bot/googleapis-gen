<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.MigrationService' => [
            'BatchMigrateResources' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\BatchMigrateResourcesResponse',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\BatchMigrateResourcesOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'SearchMigratableResources' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getMigratableResources',
                ],
            ],
        ],
    ],
];
