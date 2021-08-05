<?php

return [
    'interfaces' => [
        'google.monitoring.metricsscope.v1.MetricsScopes' => [
            'CreateMonitoredProject' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Monitoring\MetricsScope\V1\MonitoredProject',
                    'metadataReturnType' => '\Google\Cloud\Monitoring\MetricsScope\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'DeleteMonitoredProject' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Protobuf\GPBEmpty',
                    'metadataReturnType' => '\Google\Cloud\Monitoring\MetricsScope\V1\OperationMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
        ],
    ],
];
