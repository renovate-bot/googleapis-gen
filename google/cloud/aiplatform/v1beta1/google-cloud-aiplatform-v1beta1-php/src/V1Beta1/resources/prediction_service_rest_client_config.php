<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.PredictionService' => [
            'Predict' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{endpoint=projects/*/locations/*/endpoints/*}:predict',
                'body' => '*',
                'placeholders' => [
                    'endpoint' => [
                        'getters' => [
                            'getEndpoint',
                        ],
                    ],
                ],
            ],
            'Explain' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{endpoint=projects/*/locations/*/endpoints/*}:explain',
                'body' => '*',
                'placeholders' => [
                    'endpoint' => [
                        'getters' => [
                            'getEndpoint',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
