<?php

return [
    'interfaces' => [
        'ccc.hosted.marketplace.v2.CustomerLicenseService' => [
            'Get' => [
                'method' => 'get',
                'uriTemplate' => '/appsmarket/v2/customerLicense/{application_id}/{customer_id}',
                'placeholders' => [
                    'customer_id' => [
                        'getters' => [
                            'getCustomerId',
                        ],
                    ],
                    'application_id' => [
                        'getters' => [
                            'getApplicationId',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
