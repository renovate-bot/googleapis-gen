<?php

return [
    'interfaces' => [
        'google.cloud.binaryauthorization.v1.BinauthzManagementServiceV1' => [
            'ListAttestors' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getAttestors',
                ],
            ],
        ],
    ],
];
