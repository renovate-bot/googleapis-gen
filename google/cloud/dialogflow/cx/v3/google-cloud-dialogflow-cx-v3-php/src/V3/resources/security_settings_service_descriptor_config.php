<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.SecuritySettingsService' => [
            'ListSecuritySettings' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getSecuritySettings',
                ],
            ],
        ],
    ],
];
