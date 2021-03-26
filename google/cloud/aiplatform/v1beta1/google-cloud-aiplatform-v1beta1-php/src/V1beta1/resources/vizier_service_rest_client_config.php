<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.VizierService' => [
            'AddTrialMeasurement' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{trial_name=projects/*/locations/*/studies/*/trials/*}:addTrialMeasurement',
                'body' => '*',
                'placeholders' => [
                    'trial_name' => [
                        'getters' => [
                            'getTrialName',
                        ],
                    ],
                ],
            ],
            'CheckTrialEarlyStoppingState' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{trial_name=projects/*/locations/*/studies/*/trials/*}:checkTrialEarlyStoppingState',
                'body' => '*',
                'placeholders' => [
                    'trial_name' => [
                        'getters' => [
                            'getTrialName',
                        ],
                    ],
                ],
            ],
            'CompleteTrial' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*/trials/*}:complete',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateStudy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/studies',
                'body' => 'study',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateTrial' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/studies/*}/trials',
                'body' => 'trial',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteStudy' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteTrial' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*/trials/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetStudy' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetTrial' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*/trials/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListOptimalTrials' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/studies/*}/trials:listOptimalTrials',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListStudies' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/studies',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListTrials' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/studies/*}/trials',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'LookupStudy' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/studies:lookup',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'StopTrial' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/studies/*/trials/*}:stop',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'SuggestTrials' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/studies/*}/trials:suggest',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
