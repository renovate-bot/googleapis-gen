<?php

return [
    'interfaces' => [
        'google.monitoring.metricsscope.v1.MetricsScopes' => [
            'CreateMonitoredProject' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=locations/global/metricsScopes/*}/projects',
                'body' => 'monitored_project',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteMonitoredProject' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=locations/global/metricsScopes/*/projects/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetMetricsScope' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=locations/global/metricsScopes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListMetricsScopesByMonitoredProject' => [
                'method' => 'get',
                'uriTemplate' => '/v1/locations/global/metricsScopes:listMetricsScopesByMonitoredProject',
            ],
        ],
    ],
];
