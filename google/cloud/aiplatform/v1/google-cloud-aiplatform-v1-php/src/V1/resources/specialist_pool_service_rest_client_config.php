<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.SpecialistPoolService' => [
            'CreateSpecialistPool' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/specialistPools',
                'body' => 'specialist_pool',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteSpecialistPool' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/specialistPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetSpecialistPool' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/specialistPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListSpecialistPools' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/specialistPools',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateSpecialistPool' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{specialist_pool.name=projects/*/locations/*/specialistPools/*}',
                'body' => 'specialist_pool',
                'placeholders' => [
                    'specialist_pool.name' => [
                        'getters' => [
                            'getSpecialistPool',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
