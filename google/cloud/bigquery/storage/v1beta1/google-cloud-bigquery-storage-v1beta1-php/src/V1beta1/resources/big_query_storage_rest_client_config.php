<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta1.BigQueryStorage' => [
            'BatchCreateReadSessionStreams' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{session.name=projects/*/sessions/*}',
                'body' => '*',
                'placeholders' => [
                    'session.name' => [
                        'getters' => [
                            'getSession',
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateReadSession' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{table_reference.project_id=projects/*}',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{table_reference.dataset_id=projects/*/datasets/*}',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'table_reference.dataset_id' => [
                        'getters' => [
                            'getTableReference',
                            'getDatasetId',
                        ],
                    ],
                    'table_reference.project_id' => [
                        'getters' => [
                            'getTableReference',
                            'getProjectId',
                        ],
                    ],
                ],
            ],
            'FinalizeStream' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{stream.name=projects/*/streams/*}',
                'body' => '*',
                'placeholders' => [
                    'stream.name' => [
                        'getters' => [
                            'getStream',
                            'getName',
                        ],
                    ],
                ],
            ],
            'ReadRows' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{read_position.stream.name=projects/*/streams/*}',
                'placeholders' => [
                    'read_position.stream.name' => [
                        'getters' => [
                            'getReadPosition',
                            'getStream',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'read_position',
                ],
            ],
            'SplitReadStream' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{original_stream.name=projects/*/streams/*}',
                'placeholders' => [
                    'original_stream.name' => [
                        'getters' => [
                            'getOriginalStream',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'original_stream',
                ],
            ],
        ],
    ],
];
