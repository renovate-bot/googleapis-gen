<?php

return [
    'interfaces' => [
        'google.cloud.translation.v3beta1.TranslationService' => [
            'BatchTranslateText' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Translate\V3beta1\BatchTranslateResponse',
                    'metadataReturnType' => '\Google\Cloud\Translate\V3beta1\BatchTranslateMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateGlossary' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Translate\V3beta1\Glossary',
                    'metadataReturnType' => '\Google\Cloud\Translate\V3beta1\CreateGlossaryMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteGlossary' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Translate\V3beta1\DeleteGlossaryResponse',
                    'metadataReturnType' => '\Google\Cloud\Translate\V3beta1\DeleteGlossaryMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListGlossaries' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getGlossaries',
                ],
            ],
        ],
    ],
];
