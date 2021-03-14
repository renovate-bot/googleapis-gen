<?php

return [
    'interfaces' => [
        'google.appengine.v1.Firewall' => [
            'ListIngressRules' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=apps/*}/firewall/ingressRules',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchUpdateIngressRules' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=apps/*/firewall/ingressRules}:batchUpdate',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateIngressRule' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=apps/*}/firewall/ingressRules',
                'body' => 'rule',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetIngressRule' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=apps/*/firewall/ingressRules/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateIngressRule' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{name=apps/*/firewall/ingressRules/*}',
                'body' => 'rule',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteIngressRule' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=apps/*/firewall/ingressRules/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.cloud.location.Locations' => [
            'GetLocation' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=apps/*/locations/*}',
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
                'uriTemplate' => '/v1/{name=apps/*}/locations',
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
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=apps/*/operations/*}',
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
                'uriTemplate' => '/v1/{name=apps/*}/operations',
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
