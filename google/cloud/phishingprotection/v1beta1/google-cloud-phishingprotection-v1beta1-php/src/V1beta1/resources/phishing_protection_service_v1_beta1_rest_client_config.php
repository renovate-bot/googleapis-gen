<?php

return [
    'interfaces' => [
        'google.cloud.phishingprotection.v1beta1.PhishingProtectionServiceV1Beta1' => [
            'ReportPhishing' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/phishing:report',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
