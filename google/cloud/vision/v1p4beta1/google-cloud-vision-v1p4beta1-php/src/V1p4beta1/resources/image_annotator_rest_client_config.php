<?php

return [
    'interfaces' => [
        'google.cloud.vision.v1p4beta1.ImageAnnotator' => [
            'AsyncBatchAnnotateImages' => [
                'method' => 'post',
                'uriTemplate' => '/v1p4beta1/images:asyncBatchAnnotate',
                'body' => '*',
            ],
            'AsyncBatchAnnotateFiles' => [
                'method' => 'post',
                'uriTemplate' => '/v1p4beta1/files:asyncBatchAnnotate',
                'body' => '*',
            ],
            'BatchAnnotateImages' => [
                'method' => 'post',
                'uriTemplate' => '/v1p4beta1/images:annotate',
                'body' => '*',
            ],
            'BatchAnnotateFiles' => [
                'method' => 'post',
                'uriTemplate' => '/v1p4beta1/files:annotate',
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
