<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.Experiments' => [
            'ListExperiments' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getExperiments',
                ],
            ],
        ],
    ],
];
