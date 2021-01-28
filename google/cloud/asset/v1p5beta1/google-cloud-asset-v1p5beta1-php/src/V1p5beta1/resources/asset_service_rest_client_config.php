<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p5beta1.AssetService' => [
            'ListAssets' => [
                'method' => 'get',
                'uriTemplate' => '/v1p5beta1/{parent=*/*}/assets',
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
