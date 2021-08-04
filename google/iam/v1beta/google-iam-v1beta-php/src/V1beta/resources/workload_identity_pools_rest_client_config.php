<?php

return [
    'interfaces' => [
        'google.iam.v1beta.WorkloadIdentityPools' => [
            'CreateWorkloadIdentityPool' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*}/workloadIdentityPools',
                'body' => 'workload_identity_pool',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'workload_identity_pool_id',
                ],
            ],
            'CreateWorkloadIdentityPoolProvider' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/workloadIdentityPools/*}/providers',
                'body' => 'workload_identity_pool_provider',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'workload_identity_pool_provider_id',
                ],
            ],
            'DeleteWorkloadIdentityPool' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteWorkloadIdentityPoolProvider' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetWorkloadIdentityPool' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetWorkloadIdentityPoolProvider' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListWorkloadIdentityPoolProviders' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/workloadIdentityPools/*}/providers',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListWorkloadIdentityPools' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*}/workloadIdentityPools',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UndeleteWorkloadIdentityPool' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*}:undelete',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UndeleteWorkloadIdentityPoolProvider' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*}:undelete',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateWorkloadIdentityPool' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{workload_identity_pool.name=projects/*/locations/*/workloadIdentityPools/*}',
                'body' => 'workload_identity_pool',
                'placeholders' => [
                    'workload_identity_pool.name' => [
                        'getters' => [
                            'getWorkloadIdentityPool',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
            'UpdateWorkloadIdentityPoolProvider' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{workload_identity_pool_provider.name=projects/*/locations/*/workloadIdentityPools/*/providers/*}',
                'body' => 'workload_identity_pool_provider',
                'placeholders' => [
                    'workload_identity_pool_provider.name' => [
                        'getters' => [
                            'getWorkloadIdentityPoolProvider',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/operations/*}:cancel',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*/operations/*}:cancel',
                        'body' => '*',
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
            'DeleteOperation' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*/operations/*}',
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
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*/operations/*}',
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
            'ListOperations' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1beta/{name=projects/*/locations/*/workloadIdentityPools/*/providers/*}/operations',
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
