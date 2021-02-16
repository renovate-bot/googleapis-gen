<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.Flows' => [
            'CreateFlow' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*}/flows',
                'body' => 'flow',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteFlow' => [
                'method' => 'delete',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListFlows' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*}/flows',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetFlow' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateFlow' => [
                'method' => 'patch',
                'uriTemplate' => '/v3beta1/{flow.name=projects/*/locations/*/agents/*/flows/*}',
                'body' => 'flow',
                'placeholders' => [
                    'flow.name' => [
                        'getters' => [
                            'getFlow',
                            'getName',
                        ],
                    ],
                ],
            ],
            'TrainFlow' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*}:train',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ValidateFlow' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*}:validate',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetFlowValidationResult' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*/validationResult}',
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
