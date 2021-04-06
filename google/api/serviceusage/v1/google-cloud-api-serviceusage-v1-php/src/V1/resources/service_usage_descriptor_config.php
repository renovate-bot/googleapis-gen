<?php

return [
    'interfaces' => [
        'google.api.serviceusage.v1.ServiceUsage' => [
            'BatchEnableServices' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Api\Serviceusage\V1\BatchEnableServicesResponse',
                    'metadataReturnType' => '\Google\Api\Serviceusage\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DisableService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Api\Serviceusage\V1\DisableServiceResponse',
                    'metadataReturnType' => '\Google\Api\Serviceusage\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'EnableService' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Api\Serviceusage\V1\EnableServiceResponse',
                    'metadataReturnType' => '\Google\Api\Serviceusage\V1\OperationMetadata',
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
        ],
    ],
];
