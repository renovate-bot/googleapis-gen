<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Experiments' => [
            'ListExperiments' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*/environments/*}/experiments',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetExperiment' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/environments/*/experiments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateExperiment' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*/environments/*}/experiments',
                'body' => 'experiment',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateExperiment' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{experiment.name=projects/*/locations/*/agents/*/environments/*/experiments/*}',
                'body' => 'experiment',
                'placeholders' => [
                    'experiment.name' => [
                        'getters' => [
                            'getExperiment',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteExperiment' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/environments/*/experiments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'StartExperiment' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/environments/*/experiments/*}:start',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'StopExperiment' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/environments/*/experiments/*}:stop',
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
