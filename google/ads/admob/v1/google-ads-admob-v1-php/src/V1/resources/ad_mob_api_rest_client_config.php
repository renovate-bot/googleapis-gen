<?php

return [
    'interfaces' => [
        'google.ads.admob.v1.AdMobApi' => [
            'GenerateMediationReport' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=accounts/*}/mediationReport:generate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GenerateNetworkReport' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=accounts/*}/networkReport:generate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetPublisherAccount' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=accounts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListPublisherAccounts' => [
                'method' => 'get',
                'uriTemplate' => '/v1/accounts',
            ],
        ],
    ],
];
