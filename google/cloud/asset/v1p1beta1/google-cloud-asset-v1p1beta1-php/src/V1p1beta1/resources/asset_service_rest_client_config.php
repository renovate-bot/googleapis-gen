<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p1beta1.AssetService' => [
            'SearchAllIamPolicies' => [
                'method' => 'get',
                'uriTemplate' => '/v1p1beta1/{scope=*/*}/iamPolicies:searchAll',
                'placeholders' => [
                    'scope' => [
                        'getters' => [
                            'getScope',
                        ],
                    ],
                ],
            ],
            'SearchAllResources' => [
                'method' => 'get',
                'uriTemplate' => '/v1p1beta1/{scope=*/*}/resources:searchAll',
                'placeholders' => [
                    'scope' => [
                        'getters' => [
                            'getScope',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
