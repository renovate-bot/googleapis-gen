<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.ModelService' => [
            'UploadModel' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/models:upload',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetModel' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/models/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListModels' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/models',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateModel' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{model.name=projects/*/locations/*/models/*}',
                'body' => 'model',
                'placeholders' => [
                    'model.name' => [
                        'getters' => [
                            'getModel',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteModel' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/models/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ExportModel' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/models/*}:export',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetModelEvaluation' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/models/*/evaluations/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListModelEvaluations' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/models/*}/evaluations',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetModelEvaluationSlice' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/models/*/evaluations/*/slices/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListModelEvaluationSlices' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/models/*/evaluations/*}/slices',
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
