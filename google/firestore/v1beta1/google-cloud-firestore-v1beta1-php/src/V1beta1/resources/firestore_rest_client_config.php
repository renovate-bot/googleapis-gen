<?php

return [
    'interfaces' => [
        'google.firestore.v1beta1.Firestore' => [
            'BatchGetDocuments' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{database=projects/*/databases/*}/documents:batchGet',
                'body' => '*',
                'placeholders' => [
                    'database' => [
                        'getters' => [
                            'getDatabase',
                        ],
                    ],
                ],
            ],
            'BatchWrite' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{database=projects/*/databases/*}/documents:batchWrite',
                'body' => '*',
                'placeholders' => [
                    'database' => [
                        'getters' => [
                            'getDatabase',
                        ],
                    ],
                ],
            ],
            'BeginTransaction' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{database=projects/*/databases/*}/documents:beginTransaction',
                'body' => '*',
                'placeholders' => [
                    'database' => [
                        'getters' => [
                            'getDatabase',
                        ],
                    ],
                ],
            ],
            'Commit' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{database=projects/*/databases/*}/documents:commit',
                'body' => '*',
                'placeholders' => [
                    'database' => [
                        'getters' => [
                            'getDatabase',
                        ],
                    ],
                ],
            ],
            'CreateDocument' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents/**}/{collection_id}',
                'body' => 'document',
                'placeholders' => [
                    'collection_id' => [
                        'getters' => [
                            'getCollectionId',
                        ],
                    ],
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteDocument' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/databases/*/documents/*/**}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetDocument' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/databases/*/documents/*/**}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCollectionIds' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents}:listCollectionIds',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents/*/**}:listCollectionIds',
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
            'ListDocuments' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents/*/**}/{collection_id}',
                'placeholders' => [
                    'collection_id' => [
                        'getters' => [
                            'getCollectionId',
                        ],
                    ],
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'PartitionQuery' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents}:partitionQuery',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents/*/**}:partitionQuery',
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
            'Rollback' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{database=projects/*/databases/*}/documents:rollback',
                'body' => '*',
                'placeholders' => [
                    'database' => [
                        'getters' => [
                            'getDatabase',
                        ],
                    ],
                ],
            ],
            'RunQuery' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents}:runQuery',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1beta1/{parent=projects/*/databases/*/documents/*/**}:runQuery',
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
            'UpdateDocument' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{document.name=projects/*/databases/*/documents/*/**}',
                'body' => 'document',
                'placeholders' => [
                    'document.name' => [
                        'getters' => [
                            'getDocument',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
