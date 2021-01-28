<?php

return [
    'interfaces' => [
        'google.cloud.managedidentities.v1beta1.ManagedIdentitiesService' => [
            'DeleteDomain' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateMicrosoftAdDomain' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/global}/domains',
                'body' => 'domain',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ResetAdminPassword' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}:resetAdminPassword',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListDomains' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/global}/domains',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetDomain' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateDomain' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{domain.name=projects/*/locations/global/domains/*}',
                'body' => 'domain',
                'placeholders' => [
                    'domain.name' => [
                        'getters' => [
                            'getDomain',
                            'getName',
                        ],
                    ],
                ],
            ],
            'AttachTrust' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}:attachTrust',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ReconfigureTrust' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}:reconfigureTrust',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DetachTrust' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}:detachTrust',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ValidateTrust' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/global/domains/*}:validateTrust',
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
