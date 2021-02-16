<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Versions' => [
            'ListVersions' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*/flows/*}/versions',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetVersion' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateVersion' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*/flows/*}/versions',
                'body' => 'version',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateVersion' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{version.name=projects/*/locations/*/agents/*/flows/*/versions/*}',
                'body' => 'version',
                'placeholders' => [
                    'version.name' => [
                        'getters' => [
                            'getVersion',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteVersion' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'LoadVersion' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/flows/*/versions/*}:load',
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
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/operations/*}:cancel',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*/operations/*}:cancel',
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
                'uriTemplate' => '/v3/{name=projects/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v3/{name=projects/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*}/operations',
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
