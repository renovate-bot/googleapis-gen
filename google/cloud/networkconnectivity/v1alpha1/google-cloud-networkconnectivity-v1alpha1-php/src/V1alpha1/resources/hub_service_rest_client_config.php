<?php

return [
    'interfaces' => [
        'google.cloud.location.Locations' => [
            'GetLocation' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListLocations' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*}/locations',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.cloud.networkconnectivity.v1alpha1.HubService' => [
            'ListHubs' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/global}/hubs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetHub' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/global/hubs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateHub' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/global}/hubs',
                'body' => 'hub',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateHub' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha1/{hub.name=projects/*/locations/global/hubs/*}',
                'body' => 'hub',
                'placeholders' => [
                    'hub.name' => [
                        'getters' => [
                            'getHub',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteHub' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/global/hubs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListSpokes' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/spokes',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetSpoke' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/spokes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateSpoke' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/spokes',
                'body' => 'spoke',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateSpoke' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha1/{spoke.name=projects/*/locations/*/spokes/*}',
                'body' => 'spoke',
                'placeholders' => [
                    'spoke.name' => [
                        'getters' => [
                            'getSpoke',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteSpoke' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/spokes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.iam.v1.IAMPolicy' => [
            'GetIamPolicy' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/global/hubs/*}:getIamPolicy',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/*/spokes/*}:getIamPolicy',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'SetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/global/hubs/*}:setIamPolicy',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/*/spokes/*}:setIamPolicy',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'TestIamPermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/global/hubs/*}:testIamPermissions',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1alpha1/{resource=projects/*/locations/*/spokes/*}:testIamPermissions',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/operations/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteOperation' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*}/operations',
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
