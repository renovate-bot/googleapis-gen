<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Changelogs' => [
            'ListChangelogs' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getChangelogs',
                ],
            ],
        ],
    ],
];
