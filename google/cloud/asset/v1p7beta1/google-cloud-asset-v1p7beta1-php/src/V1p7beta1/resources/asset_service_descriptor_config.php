<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p7beta1.AssetService' => [
            'ExportAssets' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Asset\V1p7beta1\ExportAssetsResponse',
                    'metadataReturnType' => '\Google\Cloud\Asset\V1p7beta1\ExportAssetsRequest',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
