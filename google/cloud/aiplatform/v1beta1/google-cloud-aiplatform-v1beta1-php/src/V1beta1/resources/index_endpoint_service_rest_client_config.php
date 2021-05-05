<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.IndexEndpointService' => [
            'CreateIndexEndpoint' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/indexEndpoints',
                'body' => 'index_endpoint',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteIndexEndpoint' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/indexEndpoints/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeployIndex' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{index_endpoint=projects/*/locations/*/indexEndpoints/*}:deployIndex',
                'body' => '*',
                'placeholders' => [
                    'index_endpoint' => [
                        'getters' => [
                            'getIndexEndpoint',
                        ],
                    ],
                ],
            ],
            'GetIndexEndpoint' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/indexEndpoints/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListIndexEndpoints' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/indexEndpoints',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UndeployIndex' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{index_endpoint=projects/*/locations/*/indexEndpoints/*}:undeployIndex',
                'body' => '*',
                'placeholders' => [
                    'index_endpoint' => [
                        'getters' => [
                            'getIndexEndpoint',
                        ],
                    ],
                ],
            ],
            'UpdateIndexEndpoint' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{index_endpoint.name=projects/*/locations/*/indexEndpoints/*}',
                'body' => 'index_endpoint',
                'placeholders' => [
                    'index_endpoint.name' => [
                        'getters' => [
                            'getIndexEndpoint',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
