<?php

return [
    'interfaces' => [
        'google.ads.admob.v1.AdMobApi' => [
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
