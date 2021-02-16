<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.SessionEntityTypes' => [
            'ListSessionEntityTypes' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getSessionEntityTypes',
                ],
            ],
        ],
    ],
];
