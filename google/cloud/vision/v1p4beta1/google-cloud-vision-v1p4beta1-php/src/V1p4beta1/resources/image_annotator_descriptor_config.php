<?php

return [
    'interfaces' => [
        'google.cloud.vision.v1p4beta1.ImageAnnotator' => [
            'AsyncBatchAnnotateFiles' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Vision\V1p4beta1\AsyncBatchAnnotateFilesResponse',
                    'metadataReturnType' => '\Google\Cloud\Vision\V1p4beta1\OperationMetadata',
                    'initialPollDelayMillis' => '20000',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '45000',
                    'totalPollTimeoutMillis' => '86400000',
                ],
            ],
            'AsyncBatchAnnotateImages' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Vision\V1p4beta1\AsyncBatchAnnotateImagesResponse',
                    'metadataReturnType' => '\Google\Cloud\Vision\V1p4beta1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
