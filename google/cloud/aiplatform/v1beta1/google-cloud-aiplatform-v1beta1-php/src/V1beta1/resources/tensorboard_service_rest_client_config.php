<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.TensorboardService' => [
            'CreateTensorboard' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/tensorboards',
                'body' => 'tensorboard',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateTensorboardExperiment' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*}/experiments',
                'body' => 'tensorboard_experiment',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateTensorboardRun' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs',
                'body' => 'tensorboard_run',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateTensorboardTimeSeries' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}/timeSeries',
                'body' => 'tensorboard_time_series',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteTensorboard' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteTensorboardExperiment' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteTensorboardRun' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteTensorboardTimeSeries' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExportTensorboardTimeSeriesData' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{tensorboard_time_series=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:exportTensorboardTimeSeries',
                'body' => '*',
                'placeholders' => [
                    'tensorboard_time_series' => [
                        'getters' => [
                            'getTensorboardTimeSeries',
                        ],
                    ],
                ],
            ],
            'GetTensorboard' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetTensorboardExperiment' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetTensorboardRun' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetTensorboardTimeSeries' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListTensorboardExperiments' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*}/experiments',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListTensorboardRuns' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*}/runs',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListTensorboardTimeSeries' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}/timeSeries',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListTensorboards' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/tensorboards',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ReadTensorboardTimeSeriesData' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{tensorboard_time_series=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}:read',
                'placeholders' => [
                    'tensorboard_time_series' => [
                        'getters' => [
                            'getTensorboardTimeSeries',
                        ],
                    ],
                ],
            ],
            'UpdateTensorboard' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{tensorboard.name=projects/*/locations/*/tensorboards/*}',
                'body' => 'tensorboard',
                'placeholders' => [
                    'tensorboard.name' => [
                        'getters' => [
                            'getTensorboard',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateTensorboardExperiment' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{tensorboard_experiment.name=projects/*/locations/*/tensorboards/*/experiments/*}',
                'body' => 'tensorboard_experiment',
                'placeholders' => [
                    'tensorboard_experiment.name' => [
                        'getters' => [
                            'getTensorboardExperiment',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateTensorboardRun' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{tensorboard_run.name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}',
                'body' => 'tensorboard_run',
                'placeholders' => [
                    'tensorboard_run.name' => [
                        'getters' => [
                            'getTensorboardRun',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateTensorboardTimeSeries' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{tensorboard_time_series.name=projects/*/locations/*/tensorboards/*/experiments/*/runs/*/timeSeries/*}',
                'body' => 'tensorboard_time_series',
                'placeholders' => [
                    'tensorboard_time_series.name' => [
                        'getters' => [
                            'getTensorboardTimeSeries',
                            'getName',
                        ],
                    ],
                ],
            ],
            'WriteTensorboardRunData' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{tensorboard_run=projects/*/locations/*/tensorboards/*/experiments/*/runs/*}:write',
                'body' => '*',
                'placeholders' => [
                    'tensorboard_run' => [
                        'getters' => [
                            'getTensorboardRun',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
