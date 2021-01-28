<?php

return [
    'interfaces' => [
        'google.devtools.cloudtrace.v1.TraceService' => [
            'ListTraces' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getTraces',
                ],
            ],
        ],
    ],
];
