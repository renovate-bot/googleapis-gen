<?php

return [
    'interfaces' => [
        'google.cloud.osconfig.v1beta.OsConfigService' => [
            'DeletePatchDeployment' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/patchDeployments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteGuestPolicy' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/guestPolicies/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExecutePatchJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*}/patchJobs:execute',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetPatchJob' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/patchJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CancelPatchJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{name=projects/*/patchJobs/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListPatchJobs' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*}/patchJobs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListPatchJobInstanceDetails' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/patchJobs/*}/instanceDetails',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreatePatchDeployment' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*}/patchDeployments',
                'body' => 'patch_deployment',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetPatchDeployment' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/patchDeployments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListPatchDeployments' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*}/patchDeployments',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateGuestPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*}/guestPolicies',
                'body' => 'guest_policy',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetGuestPolicy' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/guestPolicies/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListGuestPolicies' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*}/guestPolicies',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateGuestPolicy' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{guest_policy.name=projects/*/guestPolicies/*}',
                'body' => 'guest_policy',
                'placeholders' => [
                    'guest_policy.name' => [
                        'getters' => [
                            'getGuestPolicy',
                            'getName',
                        ],
                    ],
                ],
            ],
            'LookupEffectiveGuestPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{instance=projects/*/zones/*/instances/*}:lookupEffectiveGuestPolicy',
                'body' => '*',
                'placeholders' => [
                    'instance' => [
                        'getters' => [
                            'getInstance',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
