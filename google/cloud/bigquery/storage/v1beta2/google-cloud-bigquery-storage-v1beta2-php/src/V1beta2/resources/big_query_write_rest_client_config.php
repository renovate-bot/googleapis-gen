<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta2.BigQueryWrite' => [
            'CreateWriteStream' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta2/{parent=projects/*/datasets/*/tables/*}',
                'body' => 'write_stream',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetWriteStream' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta2/{name=projects/*/datasets/*/tables/*/streams/*}',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'FinalizeWriteStream' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta2/{name=projects/*/datasets/*/tables/*/streams/*}',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'BatchCommitWriteStreams' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta2/{parent=projects/*/datasets/*/tables/*}',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'FlushRows' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta2/{write_stream=projects/*/datasets/*/tables/*/streams/*}',
                'body' => '*',
                'placeholders' => [
                    'write_stream' => [
                        'getters' => [
                            'getWriteStream',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
