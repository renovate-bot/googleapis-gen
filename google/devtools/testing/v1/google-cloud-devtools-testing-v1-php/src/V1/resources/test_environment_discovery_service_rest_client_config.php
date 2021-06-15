<?php

return [
    'interfaces' => [
        'google.devtools.testing.v1.TestEnvironmentDiscoveryService' => [
            'GetTestEnvironmentCatalog' => [
                'method' => 'get',
                'uriTemplate' => '/v1/testEnvironmentCatalog/{environment_type}',
                'placeholders' => [
                    'environment_type' => [
                        'getters' => [
                            'getEnvironmentType',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
