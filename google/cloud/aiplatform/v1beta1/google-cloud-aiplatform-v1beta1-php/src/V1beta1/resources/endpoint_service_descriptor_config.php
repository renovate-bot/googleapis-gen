<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.EndpointService' => [
            'CreateEndpoint' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\Endpoint',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\CreateEndpointOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteEndpoint' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\DeleteOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeployModel' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\DeployModelResponse',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\DeployModelOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UndeployModel' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Aiplatform\V1beta1\UndeployModelResponse',
                    'metadataReturnType' => '\Google\Cloud\Aiplatform\V1beta1\UndeployModelOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListEndpoints' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getEndpoints',
                ],
            ],
        ],
    ],
];
