<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.EndpointService' => [
            'CreateEndpoint' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/endpoints',
                'body' => 'endpoint',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteEndpoint' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/endpoints/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeployModel' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{endpoint=projects/*/locations/*/endpoints/*}:deployModel',
                'body' => '*',
                'placeholders' => [
                    'endpoint' => [
                        'getters' => [
                            'getEndpoint',
                        ],
                    ],
                ],
            ],
            'GetEndpoint' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/endpoints/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListEndpoints' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/endpoints',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UndeployModel' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{endpoint=projects/*/locations/*/endpoints/*}:undeployModel',
                'body' => '*',
                'placeholders' => [
                    'endpoint' => [
                        'getters' => [
                            'getEndpoint',
                        ],
                    ],
                ],
            ],
            'UpdateEndpoint' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{endpoint.name=projects/*/locations/*/endpoints/*}',
                'body' => 'endpoint',
                'placeholders' => [
                    'endpoint.name' => [
                        'getters' => [
                            'getEndpoint',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
