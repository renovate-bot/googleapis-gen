<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.PipelineService' => [
            'CreateTrainingPipeline' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/trainingPipelines',
                'body' => 'training_pipeline',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetTrainingPipeline' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/trainingPipelines/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListTrainingPipelines' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/trainingPipelines',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteTrainingPipeline' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/trainingPipelines/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CancelTrainingPipeline' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/trainingPipelines/*}:cancel',
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
