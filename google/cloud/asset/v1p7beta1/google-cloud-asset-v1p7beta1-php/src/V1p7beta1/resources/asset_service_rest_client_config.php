<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p7beta1.AssetService' => [
            'ExportAssets' => [
                'method' => 'post',
                'uriTemplate' => '/v1p7beta1/{parent=*/*}:exportAssets',
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
