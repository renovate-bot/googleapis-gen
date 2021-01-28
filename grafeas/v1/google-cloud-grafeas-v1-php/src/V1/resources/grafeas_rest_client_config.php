<?php

return [
    'interfaces' => [
        'grafeas.v1.Grafeas' => [
            'GetOccurrence' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/occurrences/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListOccurrences' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*}/occurrences',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteOccurrence' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/occurrences/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateOccurrence' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*}/occurrences',
                'body' => 'occurrence',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchCreateOccurrences' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*}/occurrences:batchCreate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateOccurrence' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{name=projects/*/occurrences/*}',
                'body' => 'occurrence',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetOccurrenceNote' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/occurrences/*}/notes',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetNote' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/notes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListNotes' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*}/notes',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteNote' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/notes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateNote' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*}/notes',
                'body' => 'note',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchCreateNotes' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*}/notes:batchCreate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateNote' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{name=projects/*/notes/*}',
                'body' => 'note',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListNoteOccurrences' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/notes/*}/occurrences',
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
