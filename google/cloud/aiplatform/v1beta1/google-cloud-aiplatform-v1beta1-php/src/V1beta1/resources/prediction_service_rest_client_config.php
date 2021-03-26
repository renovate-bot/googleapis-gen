<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.PredictionService' => [
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
        ],
    ],
];
