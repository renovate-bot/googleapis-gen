<?php

return [
    'interfaces' => [
        'google.cloud.tpu.v2alpha1.Tpu' => [
            'CreateNode' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Tpu\V2alpha1\Node',
                    'metadataReturnType' => '\Google\Cloud\Tpu\V2alpha1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteNode' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Tpu\V2alpha1\Node',
                    'metadataReturnType' => '\Google\Cloud\Tpu\V2alpha1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StartNode' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Tpu\V2alpha1\Node',
                    'metadataReturnType' => '\Google\Cloud\Tpu\V2alpha1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'StopNode' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Tpu\V2alpha1\Node',
                    'metadataReturnType' => '\Google\Cloud\Tpu\V2alpha1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateNode' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Tpu\V2alpha1\Node',
                    'metadataReturnType' => '\Google\Cloud\Tpu\V2alpha1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListAcceleratorTypes' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getAcceleratorTypes',
                ],
            ],
            'ListNodes' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getNodes',
                ],
            ],
            'ListRuntimeVersions' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getRuntimeVersions',
                ],
            ],
        ],
    ],
];
