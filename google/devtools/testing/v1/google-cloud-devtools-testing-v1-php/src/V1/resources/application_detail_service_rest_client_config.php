<?php

return [
    'interfaces' => [
        'google.devtools.testing.v1.ApplicationDetailService' => [
            'GetApkDetails' => [
                'method' => 'post',
                'uriTemplate' => '/v1/applicationDetailService/getApkDetails',
                'body' => 'location',
            ],
        ],
    ],
];
