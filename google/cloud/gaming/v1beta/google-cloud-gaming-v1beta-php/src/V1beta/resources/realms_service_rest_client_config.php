<?php

return [
    'interfaces' => [
        'google.cloud.gaming.v1beta.RealmsService' => [
            'CreateRealm' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*}/realms',
                'body' => 'realm',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteRealm' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/realms/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetRealm' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/realms/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListRealms' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*}/realms',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'PreviewRealmUpdate' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{realm.name=projects/*/locations/*/realms/*}:previewUpdate',
                'body' => 'realm',
                'placeholders' => [
                    'realm.name' => [
                        'getters' => [
                            'getRealm',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateRealm' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{realm.name=projects/*/locations/*/realms/*}',
                'body' => 'realm',
                'placeholders' => [
                    'realm.name' => [
                        'getters' => [
                            'getRealm',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
