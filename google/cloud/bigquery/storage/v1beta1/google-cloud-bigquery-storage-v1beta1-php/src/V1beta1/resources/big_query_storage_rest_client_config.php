<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta1.BigQueryStorage' => [
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
                    'table_reference.project_id' => [
                        'getters' => [
                            'getTableReference',
                            'getProjectId',
                        ],
                    ],
                    'table_reference.dataset_id' => [
                        'getters' => [
                            'getTableReference',
                            'getDatasetId',
                        ],
                    ],
                ],
            ],
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
            ],
        ],
    ],
];
