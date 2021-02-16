<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.TransitionRouteGroups' => [
            'ListTransitionRouteGroups' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getTransitionRouteGroups',
                ],
            ],
        ],
    ],
];
