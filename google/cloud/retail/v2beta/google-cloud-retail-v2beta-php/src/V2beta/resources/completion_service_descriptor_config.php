<?php

return [
    'interfaces' => [
        'google.cloud.retail.v2beta.CompletionService' => [
            'ImportCompletionData' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\ImportCompletionDataResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\ImportMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
