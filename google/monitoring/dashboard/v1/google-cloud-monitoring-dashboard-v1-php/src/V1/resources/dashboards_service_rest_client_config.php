<?php

return [
    'interfaces' => [
        'google.monitoring.dashboard.v1.DashboardsService' => [
            'CreateDashboard' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*}/dashboards',
                'body' => 'dashboard',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteDashboard' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/dashboards/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetDashboard' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/dashboards/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListDashboards' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*}/dashboards',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateDashboard' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{dashboard.name=projects/*/dashboards/*}',
                'body' => 'dashboard',
                'placeholders' => [
                    'dashboard.name' => [
                        'getters' => [
                            'getDashboard',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
