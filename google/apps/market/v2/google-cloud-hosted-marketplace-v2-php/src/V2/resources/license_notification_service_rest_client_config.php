<?php

return [
    'interfaces' => [
        'ccc.hosted.marketplace.v2.LicenseNotificationService' => [
            'List' => [
                'method' => 'get',
                'uriTemplate' => '/appsmarket/v2/licenseNotification/{application_id}',
                'body' => '*',
                'placeholders' => [
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
