<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.JobService' => [
            'CancelBatchPredictionJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/batchPredictionJobs/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CancelCustomJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/customJobs/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CancelDataLabelingJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/dataLabelingJobs/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CancelHyperparameterTuningJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/hyperparameterTuningJobs/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateBatchPredictionJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/batchPredictionJobs',
                'body' => 'batch_prediction_job',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateCustomJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/customJobs',
                'body' => 'custom_job',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateDataLabelingJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/dataLabelingJobs',
                'body' => 'data_labeling_job',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateHyperparameterTuningJob' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/hyperparameterTuningJobs',
                'body' => 'hyperparameter_tuning_job',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteBatchPredictionJob' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/batchPredictionJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteCustomJob' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/customJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteDataLabelingJob' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/dataLabelingJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteHyperparameterTuningJob' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/hyperparameterTuningJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetBatchPredictionJob' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/batchPredictionJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetCustomJob' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/customJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetDataLabelingJob' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/dataLabelingJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetHyperparameterTuningJob' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/hyperparameterTuningJobs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListBatchPredictionJobs' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/batchPredictionJobs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListCustomJobs' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/customJobs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListDataLabelingJobs' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/dataLabelingJobs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListHyperparameterTuningJobs' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/hyperparameterTuningJobs',
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
