<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.TestCases' => [
            'RunTestCase' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\RunTestCaseResponse',
                    'metadataReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\RunTestCaseMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'BatchRunTestCases' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\BatchRunTestCasesResponse',
                    'metadataReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\BatchRunTestCasesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ImportTestCases' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\ImportTestCasesResponse',
                    'metadataReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\ImportTestCasesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ExportTestCases' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\ExportTestCasesResponse',
                    'metadataReturnType' => '\Google\Cloud\Dialogflow\Cx\V3\ExportTestCasesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListTestCases' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getTestCases',
                ],
            ],
            'ListTestCaseResults' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getTestCaseResults',
                ],
            ],
        ],
    ],
];
