<?php

return [
    'interfaces' => [
        'google.cloud.datastream.v1alpha1.Datastream' => [
            'CreateConnectionProfile' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/connectionProfiles',
                'body' => 'connection_profile',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'connection_profile_id',
                ],
            ],
            'CreatePrivateConnection' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/privateConnections',
                'body' => 'private_connection',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'private_connection_id',
                ],
            ],
            'CreateRoute' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*/privateConnections/*}/routes',
                'body' => 'route',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'route_id',
                ],
            ],
            'CreateStream' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/streams',
                'body' => 'stream',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'stream_id',
                ],
            ],
            'DeleteConnectionProfile' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/connectionProfiles/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeletePrivateConnection' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/privateConnections/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteRoute' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/privateConnections/*/routes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteStream' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/streams/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DiscoverConnectionProfile' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/connectionProfiles:discover',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'FetchErrors' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha1/{stream=projects/*/locations/*/streams/*}:fetchErrors',
                'body' => '*',
                'placeholders' => [
                    'stream' => [
                        'getters' => [
                            'getStream',
                        ],
                    ],
                ],
            ],
            'FetchStaticIps' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*}:fetchStaticIps',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetConnectionProfile' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/connectionProfiles/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetPrivateConnection' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/privateConnections/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetRoute' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/privateConnections/*/routes/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetStream' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{name=projects/*/locations/*/streams/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListConnectionProfiles' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/connectionProfiles',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListPrivateConnections' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/privateConnections',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListRoutes' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*/privateConnections/*}/routes',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListStreams' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha1/{parent=projects/*/locations/*}/streams',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateConnectionProfile' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha1/{connection_profile.name=projects/*/locations/*/connectionProfiles/*}',
                'body' => 'connection_profile',
                'placeholders' => [
                    'connection_profile.name' => [
                        'getters' => [
                            'getConnectionProfile',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateStream' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha1/{stream.name=projects/*/locations/*/streams/*}',
                'body' => 'stream',
                'placeholders' => [
                    'stream.name' => [
                        'getters' => [
                            'getStream',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
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
