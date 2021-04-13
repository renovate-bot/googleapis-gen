<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.migration.v2alpha.MigrationService' => [
            'CreateMigrationWorkflow' => [
                'method' => 'post',
                'uriTemplate' => '/v2alpha/{parent=projects/*/locations/*}/workflows',
                'body' => 'migration_workflow',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteMigrationWorkflow' => [
                'method' => 'delete',
                'uriTemplate' => '/v2alpha/{name=projects/*/locations/*/workflows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetMigrationSubtask' => [
                'method' => 'get',
                'uriTemplate' => '/v2alpha/{name=projects/*/locations/*/workflows/*/subtasks/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetMigrationWorkflow' => [
                'method' => 'get',
                'uriTemplate' => '/v2alpha/{name=projects/*/locations/*/workflows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListMigrationSubtasks' => [
                'method' => 'get',
                'uriTemplate' => '/v2alpha/{parent=projects/*/locations/*/workflows/*}/subtasks',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListMigrationWorkflows' => [
                'method' => 'get',
                'uriTemplate' => '/v2alpha/{parent=projects/*/locations/*}/workflows',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'StartMigrationWorkflow' => [
                'method' => 'post',
                'uriTemplate' => '/v2alpha/{name=projects/*/locations/*/workflows/*}:start',
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
