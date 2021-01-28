<?php

return [
    'interfaces' => [
        'google.cloud.domains.v1alpha2.Domains' => [
            'SearchDomains' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha2/{location=projects/*/locations/*}/registrations:searchDomains',
                'placeholders' => [
                    'location' => [
                        'getters' => [
                            'getLocation',
                        ],
                    ],
                ],
            ],
            'RetrieveRegisterParameters' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha2/{location=projects/*/locations/*}/registrations:retrieveRegisterParameters',
                'placeholders' => [
                    'location' => [
                        'getters' => [
                            'getLocation',
                        ],
                    ],
                ],
            ],
            'RegisterDomain' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{parent=projects/*/locations/*}/registrations:register',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListRegistrations' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha2/{parent=projects/*/locations/*}/registrations',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetRegistration' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha2/{name=projects/*/locations/*/registrations/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateRegistration' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha2/{registration.name=projects/*/locations/*/registrations/*}',
                'body' => 'registration',
                'placeholders' => [
                    'registration.name' => [
                        'getters' => [
                            'getRegistration',
                            'getName',
                        ],
                    ],
                ],
            ],
            'ConfigureManagementSettings' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{registration=projects/*/locations/*/registrations/*}:configureManagementSettings',
                'body' => '*',
                'placeholders' => [
                    'registration' => [
                        'getters' => [
                            'getRegistration',
                        ],
                    ],
                ],
            ],
            'ConfigureDnsSettings' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{registration=projects/*/locations/*/registrations/*}:configureDnsSettings',
                'body' => '*',
                'placeholders' => [
                    'registration' => [
                        'getters' => [
                            'getRegistration',
                        ],
                    ],
                ],
            ],
            'ConfigureContactSettings' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{registration=projects/*/locations/*/registrations/*}:configureContactSettings',
                'body' => '*',
                'placeholders' => [
                    'registration' => [
                        'getters' => [
                            'getRegistration',
                        ],
                    ],
                ],
            ],
            'ExportRegistration' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{name=projects/*/locations/*/registrations/*}:export',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteRegistration' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha2/{name=projects/*/locations/*/registrations/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'RetrieveAuthorizationCode' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha2/{registration=projects/*/locations/*/registrations/*}:retrieveAuthorizationCode',
                'placeholders' => [
                    'registration' => [
                        'getters' => [
                            'getRegistration',
                        ],
                    ],
                ],
            ],
            'ResetAuthorizationCode' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha2/{registration=projects/*/locations/*/registrations/*}:resetAuthorizationCode',
                'body' => '*',
                'placeholders' => [
                    'registration' => [
                        'getters' => [
                            'getRegistration',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
