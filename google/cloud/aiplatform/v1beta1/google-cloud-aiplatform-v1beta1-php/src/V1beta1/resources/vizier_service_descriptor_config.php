<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.VizierService' => [
            'CheckTrialEarlyStoppingState' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateResponse',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateMetatdata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'SuggestTrials' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\SuggestTrialsResponse',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\SuggestTrialsMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListStudies' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getStudies',
                ],
            ],
            'ListTrials' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getTrials',
                ],
            ],
        ],
    ],
];
