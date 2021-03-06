<?php

return [
    'interfaces' => [
        'ccc.hosted.marketplace.v2.CustomerLicenseService' => [
            'Get' => [
                'method' => 'get',
                'uriTemplate' => '/appsmarket/v2/customerLicense/{application_id}/{customer_id}',
                'placeholders' => [
                    'application_id' => [
                        'getters' => [
                            'getApplicationId',
                        ],
                    ],
                    'customer_id' => [
                        'getters' => [
                            'getCustomerId',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
