<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Webhooks' => [
            'ListWebhooks' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getWebhooks',
                ],
            ],
        ],
    ],
];
