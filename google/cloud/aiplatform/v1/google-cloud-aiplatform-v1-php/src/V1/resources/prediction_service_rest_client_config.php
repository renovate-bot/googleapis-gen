<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.PredictionService' => [
            'Predict' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{endpoint=projects/*/locations/*/endpoints/*}:predict',
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
