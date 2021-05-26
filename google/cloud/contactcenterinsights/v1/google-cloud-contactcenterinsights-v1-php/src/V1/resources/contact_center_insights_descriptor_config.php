<?php

return [
    'interfaces' => [
        'google.cloud.contactcenterinsights.v1.ContactCenterInsights' => [
            'CreateAnalysis' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\ContactCenterInsights\V1\Analysis',
                    'metadataReturnType' => '\Google\Cloud\ContactCenterInsights\V1\CreateAnalysisOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ExportInsightsData' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\ContactCenterInsights\V1\ExportInsightsDataResponse',
                    'metadataReturnType' => '\Google\Cloud\ContactCenterInsights\V1\ExportInsightsDataMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListAnalyses' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getAnalyses',
                ],
            ],
            'ListConversations' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getConversations',
                ],
            ],
            'ListPhraseMatchers' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getPhraseMatchers',
                ],
            ],
        ],
    ],
];
