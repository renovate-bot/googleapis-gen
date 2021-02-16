<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.Pages' => [
            'ListPages' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*/flows/*}/pages',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetPage' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*/pages/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreatePage' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*/flows/*}/pages',
                'body' => 'page',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdatePage' => [
                'method' => 'patch',
                'uriTemplate' => '/v3beta1/{page.name=projects/*/locations/*/agents/*/flows/*/pages/*}',
                'body' => 'page',
                'placeholders' => [
                    'page.name' => [
                        'getters' => [
                            'getPage',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeletePage' => [
                'method' => 'delete',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*/pages/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/operations/*}:cancel',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/operations/*}:cancel',
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
                'uriTemplate' => '/v3beta1/{name=projects/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v3beta1/{name=projects/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*}/operations',
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