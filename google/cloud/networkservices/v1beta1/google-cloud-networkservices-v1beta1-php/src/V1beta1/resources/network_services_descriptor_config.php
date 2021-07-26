<?php

return [
    'interfaces' => [
        'google.cloud.networkservices.v1beta1.NetworkServices' => [
            'CreateEndpointPolicy' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\NetworkServices\V1beta1\EndpointPolicy',
                    'metadataReturnType' => '\Google\Cloud\NetworkServices\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteEndpointPolicy' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\NetworkServices\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateEndpointPolicy' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\NetworkServices\V1beta1\EndpointPolicy',
                    'metadataReturnType' => '\Google\Cloud\NetworkServices\V1beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListEndpointPolicies' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getEndpointPolicies',
                ],
            ],
        ],
    ],
];
