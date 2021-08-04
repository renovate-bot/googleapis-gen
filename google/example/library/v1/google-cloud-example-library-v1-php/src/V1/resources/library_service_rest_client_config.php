<?php

return [
    'interfaces' => [
        'google.example.library.v1.LibraryService' => [
            'CreateBook' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=shelves/*}/books',
                'body' => 'book',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateShelf' => [
                'method' => 'post',
                'uriTemplate' => '/v1/shelves',
                'body' => 'shelf',
            ],
            'DeleteBook' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=shelves/*/books/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteShelf' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=shelves/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetBook' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=shelves/*/books/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetShelf' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=shelves/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListBooks' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=shelves/*}/books',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListShelves' => [
                'method' => 'get',
                'uriTemplate' => '/v1/shelves',
            ],
            'MergeShelves' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=shelves/*}:merge',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'MoveBook' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=shelves/*/books/*}:move',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateBook' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{book.name=shelves/*/books/*}',
                'body' => 'book',
                'placeholders' => [
                    'book.name' => [
                        'getters' => [
                            'getBook',
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
        ],
    ],
];
