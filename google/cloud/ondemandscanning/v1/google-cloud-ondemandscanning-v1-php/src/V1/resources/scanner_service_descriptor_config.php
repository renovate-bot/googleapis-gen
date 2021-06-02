<?php

return [
    'interfaces' => [
        'google.cloud.ondemandscanning.v1.ScannerService' => [
            'AnalyzePackages' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\OnDemandScanning\V1\AnalyzePackagesResponse',
                    'metadataReturnType' => '\Google\Cloud\OnDemandScanning\V1\AnalyzePackagesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListVulnerabilities' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getOccurrences',
                ],
            ],
        ],
    ],
];
