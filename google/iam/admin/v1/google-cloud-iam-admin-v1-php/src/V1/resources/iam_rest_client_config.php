<?php

return [
    'interfaces' => [
        'google.iam.admin.v1.IAM' => [
            'ListServiceAccounts' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*}/serviceAccounts',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetServiceAccount' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateServiceAccount' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*}/serviceAccounts',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateServiceAccount' => [
                'method' => 'put',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteServiceAccount' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListServiceAccountKeys' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}/keys',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetServiceAccountKey' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*/keys/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateServiceAccountKey' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}/keys',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteServiceAccountKey' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*/keys/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'SignBlob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}:signBlob',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'SignJwt' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/serviceAccounts/*}:signJwt',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{resource=projects/*/serviceAccounts/*}:getIamPolicy',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'SetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{resource=projects/*/serviceAccounts/*}:setIamPolicy',
                'body' => '*',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'TestIamPermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{resource=projects/*/serviceAccounts/*}:testIamPermissions',
                'body' => '*',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'QueryGrantableRoles' => [
                'method' => 'post',
                'uriTemplate' => '/v1/roles:queryGrantableRoles',
                'body' => '*',
            ],
            'ListRoles' => [
                'method' => 'get',
                'uriTemplate' => '/v1/roles',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{parent=organizations/*}/roles',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{parent=projects/*}/roles',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetRole' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=roles/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{name=organizations/*/roles/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{name=projects/*/roles/*}',
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
            'CreateRole' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=organizations/*}/roles',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{parent=projects/*}/roles',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateRole' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{name=organizations/*/roles/*}',
                'body' => 'role',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v1/{name=projects/*/roles/*}',
                        'body' => 'role',
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
            'DeleteRole' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=organizations/*/roles/*}',
                'additionalBindings' => [
                    [
                        'method' => 'delete',
                        'uriTemplate' => '/v1/{name=projects/*/roles/*}',
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
            'UndeleteRole' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=organizations/*/roles/*}:undelete',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{name=projects/*/roles/*}:undelete',
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
            'QueryTestablePermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v1/permissions:queryTestablePermissions',
                'body' => '*',
            ],
        ],
    ],
];
