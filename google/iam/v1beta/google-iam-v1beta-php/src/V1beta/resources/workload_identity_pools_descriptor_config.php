<?php

return [
    'interfaces' => [
        'google.iam.v1beta.WorkloadIdentityPools' => [
            'CreateWorkloadIdentityPool' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPool',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'CreateWorkloadIdentityPoolProvider' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProvider',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProviderOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteWorkloadIdentityPool' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPool',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteWorkloadIdentityPoolProvider' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProvider',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProviderOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UndeleteWorkloadIdentityPool' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPool',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UndeleteWorkloadIdentityPoolProvider' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProvider',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProviderOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateWorkloadIdentityPool' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPool',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'UpdateWorkloadIdentityPoolProvider' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProvider',
                    'metadataReturnType' => '\Google\Iam\V1beta\WorkloadIdentityPoolProviderOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListWorkloadIdentityPoolProviders' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getWorkloadIdentityPoolProviders',
                ],
            ],
            'ListWorkloadIdentityPools' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getWorkloadIdentityPools',
                ],
            ],
        ],
    ],
];
