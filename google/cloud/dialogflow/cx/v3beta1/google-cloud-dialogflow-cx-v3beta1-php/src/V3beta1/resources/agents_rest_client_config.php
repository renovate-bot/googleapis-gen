<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.Agents' => [
            'CreateAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*}/agents',
                'body' => 'agent',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteAgent' => [
                'method' => 'delete',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExportAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*}:export',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetAgent' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetAgentValidationResult' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/validationResult}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListAgents' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*}/agents',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'RestoreAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*}:restore',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateAgent' => [
                'method' => 'patch',
                'uriTemplate' => '/v3beta1/{agent.name=projects/*/locations/*/agents/*}',
                'body' => 'agent',
                'placeholders' => [
                    'agent.name' => [
                        'getters' => [
                            'getAgent',
                            'getName',
                        ],
                    ],
                ],
            ],
            'ValidateAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*}:validate',
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
