<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1.MigrationService' => [
            'SearchMigratableResources' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/migratableResources:search',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchMigrateResources' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/migratableResources:batchMigrate',
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
