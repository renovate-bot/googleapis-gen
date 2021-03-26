<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.DatasetService' => [
            'CreateDataset' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/datasets',
                'body' => 'dataset',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteDataset' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/datasets/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExportData' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/datasets/*}:export',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetAnnotationSpec' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/datasets/*/annotationSpecs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetDataset' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/datasets/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ImportData' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/datasets/*}:import',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListAnnotations' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/datasets/*/dataItems/*}/annotations',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListDataItems' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/datasets/*}/dataItems',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListDatasets' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/datasets',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateDataset' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{dataset.name=projects/*/locations/*/datasets/*}',
                'body' => 'dataset',
                'placeholders' => [
                    'dataset.name' => [
                        'getters' => [
                            'getDataset',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
