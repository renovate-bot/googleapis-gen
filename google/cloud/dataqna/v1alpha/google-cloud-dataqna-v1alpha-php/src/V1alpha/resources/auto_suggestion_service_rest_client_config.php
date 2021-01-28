<?php

return [
    'interfaces' => [
        'google.cloud.dataqna.v1alpha.AutoSuggestionService' => [
            'SuggestQueries' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*}:suggestQueries',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
