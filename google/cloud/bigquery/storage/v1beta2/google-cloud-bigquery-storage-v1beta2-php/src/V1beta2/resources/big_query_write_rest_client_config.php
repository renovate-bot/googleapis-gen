<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta2.BigQueryWrite' => [
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
                'queryParams' => [
                    'write_streams',
                ],
            ],
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
        ],
    ],
];
