<?php

return [
    'interfaces' => [
        'google.cloud.osconfig.v1alpha.OsConfigZonalService' => [
            'CreateOSPolicyAssignment' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*}/osPolicyAssignments',
                'body' => 'os_policy_assignment',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
                'queryParams' => [
                    'os_policy_assignment_id',
                ],
            ],
            'DeleteOSPolicyAssignment' => [
                'method' => 'delete',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetInstanceOSPoliciesCompliance' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/instanceOSPoliciesCompliances/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetInventory' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/instances/*/inventory}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetOSPolicyAssignment' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetVulnerabilityReport' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/instances/*/vulnerabilityReport}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListInstanceOSPoliciesCompliances' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*}/instanceOSPoliciesCompliances',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListInventories' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*/instances/*}/inventories',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListOSPolicyAssignmentRevisions' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*}:listRevisions',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListOSPolicyAssignments' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*}/osPolicyAssignments',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListVulnerabilityReports' => [
                'method' => 'get',
                'uriTemplate' => '/v1alpha/{parent=projects/*/locations/*/instances/*}/vulnerabilityReports',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateOSPolicyAssignment' => [
                'method' => 'patch',
                'uriTemplate' => '/v1alpha/{os_policy_assignment.name=projects/*/locations/*/osPolicyAssignments/*}',
                'body' => 'os_policy_assignment',
                'placeholders' => [
                    'os_policy_assignment.name' => [
                        'getters' => [
                            'getOsPolicyAssignment',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*/operations/*}:cancel',
                'body' => '*',
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
                'uriTemplate' => '/v1alpha/{name=projects/*/locations/*/osPolicyAssignments/*/operations/*}',
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
