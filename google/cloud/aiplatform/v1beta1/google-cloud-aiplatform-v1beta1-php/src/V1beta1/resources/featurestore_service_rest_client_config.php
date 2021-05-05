<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.FeaturestoreService' => [
            'BatchCreateFeatures' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/featurestores/*/entityTypes/*}/features:batchCreate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchReadFeatureValues' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{featurestore=projects/*/locations/*/featurestores/*}:batchReadFeatureValues',
                'body' => '*',
                'placeholders' => [
                    'featurestore' => [
                        'getters' => [
                            'getFeaturestore',
                        ],
                    ],
                ],
            ],
            'CreateEntityType' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/featurestores/*}/entityTypes',
                'body' => 'entity_type',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateFeature' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/featurestores/*/entityTypes/*}/features',
                'body' => 'feature',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateFeaturestore' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/featurestores',
                'body' => 'featurestore',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteEntityType' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*/entityTypes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteFeature' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*/entityTypes/*/features/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteFeaturestore' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExportFeatureValues' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{entity_type=projects/*/locations/*/featurestores/*/entityTypes/*}:exportFeatureValues',
                'body' => '*',
                'placeholders' => [
                    'entity_type' => [
                        'getters' => [
                            'getEntityType',
                        ],
                    ],
                ],
            ],
            'GetEntityType' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*/entityTypes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetFeature' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*/entityTypes/*/features/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetFeaturestore' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/featurestores/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ImportFeatureValues' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{entity_type=projects/*/locations/*/featurestores/*/entityTypes/*}:importFeatureValues',
                'body' => '*',
                'placeholders' => [
                    'entity_type' => [
                        'getters' => [
                            'getEntityType',
                        ],
                    ],
                ],
            ],
            'ListEntityTypes' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/featurestores/*}/entityTypes',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListFeatures' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/featurestores/*/entityTypes/*}/features',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListFeaturestores' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/featurestores',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'SearchFeatures' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{location=projects/*/locations/*}/featurestores:searchFeatures',
                'placeholders' => [
                    'location' => [
                        'getters' => [
                            'getLocation',
                        ],
                    ],
                ],
            ],
            'UpdateEntityType' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{entity_type.name=projects/*/locations/*/featurestores/*/entityTypes/*}',
                'body' => 'entity_type',
                'placeholders' => [
                    'entity_type.name' => [
                        'getters' => [
                            'getEntityType',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateFeature' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{feature.name=projects/*/locations/*/featurestores/*/entityTypes/*/features/*}',
                'body' => 'feature',
                'placeholders' => [
                    'feature.name' => [
                        'getters' => [
                            'getFeature',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateFeaturestore' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{featurestore.name=projects/*/locations/*/featurestores/*}',
                'body' => 'featurestore',
                'placeholders' => [
                    'featurestore.name' => [
                        'getters' => [
                            'getFeaturestore',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
