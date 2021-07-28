<?php

return [
    'interfaces' => [
        'google.cloud.retail.v2beta.CatalogService' => [
            'GetDefaultBranch' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta/{catalog=projects/*/locations/*/catalogs/*}:getDefaultBranch',
                'placeholders' => [
                    'catalog' => [
                        'getters' => [
                            'getCatalog',
                        ],
                    ],
                ],
            ],
            'ListCatalogs' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta/{parent=projects/*/locations/*}/catalogs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'SetDefaultBranch' => [
                'method' => 'post',
                'uriTemplate' => '/v2beta/{catalog=projects/*/locations/*/catalogs/*}:setDefaultBranch',
                'body' => '*',
                'placeholders' => [
                    'catalog' => [
                        'getters' => [
                            'getCatalog',
                        ],
                    ],
                ],
            ],
            'UpdateCatalog' => [
                'method' => 'patch',
                'uriTemplate' => '/v2beta/{catalog.name=projects/*/locations/*/catalogs/*}',
                'body' => 'catalog',
                'placeholders' => [
                    'catalog.name' => [
                        'getters' => [
                            'getCatalog',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v2beta/{name=projects/*/locations/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta/{name=projects/*/locations/*/catalogs/*/operations/*}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta/{name=projects/*/locations/*/catalogs/*/branches/*/operations/*}',
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
                'uriTemplate' => '/v2beta/{name=projects/*/locations/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v2beta/{name=projects/*/locations/*/catalogs/*}/operations',
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
