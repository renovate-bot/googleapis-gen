<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.v2beta1.Participants' => [
            'AnalyzeContent' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{participant=projects/*/conversations/*/participants/*}:analyzeContent',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{participant=projects/*/locations/*/conversations/*/participants/*}:analyzeContent',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'participant' => [
                        'getters' => [
                            'getParticipant',
                        ],
                    ],
                ],
            ],
            'CompileSuggestion' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:compile',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateParticipant' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*}/participants',
                'body' => 'participant',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{parent=projects/*/locations/*/conversations/*}/participants',
                        'body' => 'participant',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetParticipant' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta1/{name=projects/*/conversations/*/participants/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta1/{name=projects/*/locations/*/conversations/*/participants/*}',
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
            'ListParticipants' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*}/participants',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta1/{parent=projects/*/locations/*/conversations/*}/participants',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListSuggestions' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'SuggestArticles' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestArticles',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestArticles',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'SuggestFaqAnswers' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestFaqAnswers',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestFaqAnswers',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'SuggestSmartReplies' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{parent=projects/*/conversations/*/participants/*}/suggestions:suggestSmartReplies',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{parent=projects/*/locations/*/conversations/*/participants/*}/suggestions:suggestSmartReplies',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateParticipant' => [
                'method' => 'patch',
                'uriTemplate' => '/v2beta1/{participant.name=projects/*/conversations/*/participants/*}',
                'body' => 'participant',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/v2beta1/{participant.name=projects/*/locations/*/conversations/*/participants/*}',
                        'body' => 'participant',
                        'queryParams' => [
                            'update_mask',
                        ],
                    ],
                ],
                'placeholders' => [
                    'participant.name' => [
                        'getters' => [
                            'getParticipant',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta1/{name=projects/*/operations/*}:cancel',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v2beta1/{name=projects/*/locations/*/operations/*}:cancel',
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
                'uriTemplate' => '/v2beta1/{name=projects/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v2beta1/{name=projects/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta1/{name=projects/*/locations/*}/operations',
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
