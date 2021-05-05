<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.IndexService' => [
            'CreateIndex' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/indexes',
                'body' => 'index',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteIndex' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/indexes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetIndex' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/indexes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListIndexes' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/indexes',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateIndex' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{index.name=projects/*/locations/*/indexes/*}',
                'body' => 'index',
                'placeholders' => [
                    'index.name' => [
                        'getters' => [
                            'getIndex',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
