<?php

return [
    'interfaces' => [
        'google.cloud.binaryauthorization.v1beta1.BinauthzManagementServiceV1Beta1' => [
            'GetPolicy' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/policy}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdatePolicy' => [
                'method' => 'put',
                'uriTemplate' => '/v1beta1/{policy.name=projects/*/policy}',
                'body' => 'policy',
                'placeholders' => [
                    'policy.name' => [
                        'getters' => [
                            'getPolicy',
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateAttestor' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/attestors',
                'body' => 'attestor',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetAttestor' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/attestors/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateAttestor' => [
                'method' => 'put',
                'uriTemplate' => '/v1beta1/{attestor.name=projects/*/attestors/*}',
                'body' => 'attestor',
                'placeholders' => [
                    'attestor.name' => [
                        'getters' => [
                            'getAttestor',
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListAttestors' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/attestors',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteAttestor' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/attestors/*}',
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
