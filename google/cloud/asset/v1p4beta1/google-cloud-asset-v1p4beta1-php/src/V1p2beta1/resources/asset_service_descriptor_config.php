<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p4beta1.AssetService' => [
            'ExportIamPolicyAnalysis' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Asset\V1p4beta1\ExportIamPolicyAnalysisResponse',
                    'metadataReturnType' => '\Google\Cloud\Asset\V1p4beta1\ExportIamPolicyAnalysisRequest',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
