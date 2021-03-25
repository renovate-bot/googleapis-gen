<?php

return [
    'interfaces' => [
        'google.area120.tables.v1alpha1.TablesService' => [
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
            'BatchDeleteRows' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=tables/*}/rows:batchDelete',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
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
            'GetWorkspace' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=workspaces/*}',
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
            'ListTables' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/tables',
            ],
            'ListWorkspaces' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/workspaces',
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
        ],
    ],
];
