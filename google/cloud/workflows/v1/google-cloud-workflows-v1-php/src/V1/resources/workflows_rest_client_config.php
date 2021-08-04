<?php

return [
    'interfaces' => [
        'google.cloud.workflows.v1.Workflows' => [
            'CreateWorkflow' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/workflows',
                'body' => 'workflow',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'workflow_id',
                ],
            ],
            'DeleteWorkflow' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/workflows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetWorkflow' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/workflows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListWorkflows' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/workflows',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateWorkflow' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{workflow.name=projects/*/locations/*/workflows/*}',
                'body' => 'workflow',
                'placeholders' => [
                    'workflow.name' => [
                        'getters' => [
                            'getWorkflow',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
