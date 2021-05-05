<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.FeaturestoreOnlineServingService' => [
            'ReadFeatureValues' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{entity_type=projects/*/locations/*/featurestores/*/entityTypes/*}:readFeatureValues',
                'body' => '*',
                'placeholders' => [
                    'entity_type' => [
                        'getters' => [
                            'getEntityType',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
