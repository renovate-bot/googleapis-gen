<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.Pages' => [
            'ListPages' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getPages',
                ],
            ],
        ],
    ],
];
