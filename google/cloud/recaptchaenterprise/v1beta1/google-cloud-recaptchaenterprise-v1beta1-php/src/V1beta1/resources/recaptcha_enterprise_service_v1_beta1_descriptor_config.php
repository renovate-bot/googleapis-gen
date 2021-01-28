<?php

return [
    'interfaces' => [
        'google.cloud.recaptchaenterprise.v1beta1.RecaptchaEnterpriseServiceV1Beta1' => [
            'ListKeys' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getKeys',
                ],
            ],
        ],
    ],
];
