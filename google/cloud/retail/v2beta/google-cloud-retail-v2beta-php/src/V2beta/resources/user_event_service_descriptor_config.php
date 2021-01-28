<?php

return [
    'interfaces' => [
        'google.cloud.retail.v2beta.UserEventService' => [
            'PurgeUserEvents' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\PurgeUserEventsResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\PurgeMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ImportUserEvents' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\ImportUserEventsResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\ImportMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'RejoinUserEvents' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\RejoinUserEventsResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\RejoinUserEventsMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
