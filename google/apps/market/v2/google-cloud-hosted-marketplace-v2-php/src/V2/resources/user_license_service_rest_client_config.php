<?php

return [
    'interfaces' => [
        'ccc.hosted.marketplace.v2.UserLicenseService' => [
            'Get' => [
                'method' => 'get',
                'uriTemplate' => '/appsmarket/v2/userLicense/{application_id}/{user_id}',
                'placeholders' => [
                    'user_id' => [
                        'getters' => [
                            'getUserId',
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
