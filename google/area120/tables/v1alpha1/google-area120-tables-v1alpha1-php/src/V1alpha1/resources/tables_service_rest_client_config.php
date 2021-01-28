<?php

return [
    'interfaces' => [
        'google.area120.tables.v1alpha1.TablesService' => [
            'GetTable' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=tables/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListTables' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/tables',
            ],
            'GetRow' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=tables/*/rows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListRows' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=tables/*}/rows',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateRow' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=tables/*}/rows',
                'body' => 'row',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchCreateRows' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=tables/*}/rows:batchCreate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateRow' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha1/{row.name=tables/*/rows/*}',
                'body' => 'row',
                'placeholders' => [
                    'row.name' => [
                        'getters' => [
                            'getRow',
                            'getName',
                        ],
                    ],
                ],
            ],
            'BatchUpdateRows' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=tables/*}/rows:batchUpdate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteRow' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=tables/*/rows/*}',
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
