<?php

return [
    'interfaces' => [
        'google.example.library.v1.LibraryService' => [
            'CreateShelf' => [
                'method' => 'post',
                'uriTemplate' => '/v1/shelves',
                'body' => 'shelf',
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
            'ListShelves' => [
                'method' => 'get',
                'uriTemplate' => '/v1/shelves',
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
        ],
    ],
];
