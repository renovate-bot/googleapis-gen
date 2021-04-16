<?php

return [
    'interfaces' => [
        'google.api.serviceusage.v1beta1.ServiceUsage' => [
            'BatchEnableServices' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*}/services:batchEnable',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateAdminOverride' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*/consumerQuotaMetrics/*/limits/*}/adminOverrides',
                'body' => 'override',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateConsumerOverride' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*/consumerQuotaMetrics/*/limits/*}/consumerOverrides',
                'body' => 'override',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteAdminOverride' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*/limits/*/adminOverrides/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteConsumerOverride' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*/limits/*/consumerOverrides/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DisableService' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*}:disable',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'EnableService' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*}:enable',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GenerateServiceIdentity' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*}:generateServiceIdentity',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetConsumerQuotaLimit' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*/limits/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetConsumerQuotaMetric' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetService' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ImportAdminOverrides' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*}/consumerQuotaMetrics:importAdminOverrides',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ImportConsumerOverrides' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*}/consumerQuotaMetrics:importConsumerOverrides',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListAdminOverrides' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*/consumerQuotaMetrics/*/limits/*}/adminOverrides',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListConsumerOverrides' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*/consumerQuotaMetrics/*/limits/*}/consumerOverrides',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListConsumerQuotaMetrics' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=*/*/services/*}/consumerQuotaMetrics',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListServices' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=*/*}/services',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateAdminOverride' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*/limits/*/adminOverrides/*}',
                'body' => 'override',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateConsumerOverride' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{name=*/*/services/*/consumerQuotaMetrics/*/limits/*/consumerOverrides/*}',
                'body' => 'override',
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
                'uriTemplate' => '/v1beta1/{name=operations/*}',
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
                'uriTemplate' => '/v1beta1/operations',
            ],
        ],
    ],
];
