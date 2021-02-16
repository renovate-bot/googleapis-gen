<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Agents' => [
            'ListAgents' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*}/agents',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetAgent' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*}/agents',
                'body' => 'agent',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateAgent' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{agent.name=projects/*/locations/*/agents/*}',
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
            'DeleteAgent' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*}',
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
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*}:export',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'RestoreAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*}:restore',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ValidateAgent' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*}:validate',
                'body' => '*',
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
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/validationResult}',
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
