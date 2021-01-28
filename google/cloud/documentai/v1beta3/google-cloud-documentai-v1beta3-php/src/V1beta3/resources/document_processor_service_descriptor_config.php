<?php

return [
    'interfaces' => [
        'google.cloud.documentai.v1beta3.DocumentProcessorService' => [
            'BatchProcessDocuments' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\DocumentAI\V1beta3\BatchProcessResponse',
                    'metadataReturnType' => '\Google\Cloud\DocumentAI\V1beta3\BatchProcessMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ReviewDocument' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\DocumentAI\V1beta3\ReviewDocumentResponse',
                    'metadataReturnType' => '\Google\Cloud\DocumentAI\V1beta3\ReviewDocumentOperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
