<?php

return [
    'interfaces' => [
        'google.monitoring.dashboard.v1.DashboardsService' => [
            'ListDashboards' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getDashboards',
                ],
            ],
        ],
    ],
];
