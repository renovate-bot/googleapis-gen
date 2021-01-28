<?php

return [
    'interfaces' => [
        'google.cloud.dataqna.v1alpha.QuestionService' => [
            'GetQuestion' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/questions/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateQuestion' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*}/questions',
                'body' => 'question',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ExecuteQuestion' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/questions/*}:execute',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetUserFeedback' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/questions/*/userFeedback}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateUserFeedback' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha/{user_feedback.name=projects/*/locations/*/questions/*/userFeedback}',
                'body' => 'user_feedback',
                'placeholders' => [
                    'user_feedback.name' => [
                        'getters' => [
                            'getUserFeedback',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
