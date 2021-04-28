<?php

return [
    'interfaces' => [
        'google.cloud.vision.v1p3beta1.ImageAnnotator' => [
            'AsyncBatchAnnotateFiles' => [
                'method' => 'post',
                'uriTemplate' => '/v1p3beta1/files:asyncBatchAnnotate',
                'body' => '*',
            ],
            'BatchAnnotateImages' => [
                'method' => 'post',
                'uriTemplate' => '/v1p3beta1/images:annotate',
                'body' => '*',
            ],
        ],
        'google.longrunning.Operations' => [
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{name=locations/*/operations/*}',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
