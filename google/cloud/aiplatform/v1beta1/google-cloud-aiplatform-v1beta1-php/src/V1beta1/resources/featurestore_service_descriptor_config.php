<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.FeaturestoreService' => [
            'BatchCreateFeatures' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\BatchCreateFeaturesResponse',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\BatchCreateFeaturesOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'BatchReadFeatureValues' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\BatchReadFeatureValuesResponse',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\BatchReadFeatureValuesOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateEntityType' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\EntityType',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\CreateEntityTypeOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateFeature' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\Feature',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\CreateFeatureOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateFeaturestore' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\Featurestore',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\CreateFeaturestoreOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteEntityType' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\DeleteOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteFeature' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\DeleteOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteFeaturestore' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\DeleteOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ExportFeatureValues' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\ExportFeatureValuesResponse',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\ExportFeatureValuesOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ImportFeatureValues' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\ImportFeatureValuesResponse',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\ImportFeatureValuesOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateFeaturestore' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\AIPlatform\V1beta1\Featurestore',
                    'metadataReturnType' => '\Google\Cloud\AIPlatform\V1beta1\UpdateFeaturestoreOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListEntityTypes' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getEntityTypes',
                ],
            ],
            'ListFeatures' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getFeatures',
                ],
            ],
            'ListFeaturestores' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getFeaturestores',
                ],
            ],
            'SearchFeatures' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getFeatures',
                ],
            ],
        ],
    ],
];
