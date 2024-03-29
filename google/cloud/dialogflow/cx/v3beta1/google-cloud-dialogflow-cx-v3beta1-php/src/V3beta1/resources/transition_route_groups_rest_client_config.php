<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups' => [
            'CreateTransitionRouteGroup' => [
                'method' => 'post',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*/flows/*}/transitionRouteGroups',
                'body' => 'transition_route_group',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteTransitionRouteGroup' => [
                'method' => 'delete',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*/transitionRouteGroups/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetTransitionRouteGroup' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/agents/*/flows/*/transitionRouteGroups/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListTransitionRouteGroups' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{parent=projects/*/locations/*/agents/*/flows/*}/transitionRouteGroups',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateTransitionRouteGroup' => [
                'method' => 'patch',
                'uriTemplate' => '/v3beta1/{transition_route_group.name=projects/*/locations/*/agents/*/flows/*/transitionRouteGroups/*}',
                'body' => 'transition_route_group',
                'placeholders' => [
                    'transition_route_group.name' => [
                        'getters' => [
                            'getTransitionRouteGroup',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.cloud.location.Locations' => [
            'GetLocation' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/locations/*}',
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
                'uriTemplate' => '/v3beta1/{name=projects/*}/locations',
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
                'uriTemplate' => '/v3beta1/{name=projects/*/operations/*}:cancel',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/operations/*}:cancel',
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
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v3beta1/{name=projects/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v3beta1/{name=projects/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3beta1/{name=projects/*/locations/*}/operations',
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
