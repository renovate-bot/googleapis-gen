<?php

return [
    'interfaces' => [
        'google.devtools.testing.v1.TestExecutionService' => [
            'CancelTestMatrix' => [
                'method' => 'post',
                'uriTemplate' => '/v1/projects/{project_id}/testMatrices/{test_matrix_id}:cancel',
                'placeholders' => [
                    'project_id' => [
                        'getters' => [
                            'getProjectId',
                        ],
                    ],
                    'test_matrix_id' => [
                        'getters' => [
                            'getTestMatrixId',
                        ],
                    ],
                ],
            ],
            'CreateTestMatrix' => [
                'method' => 'post',
                'uriTemplate' => '/v1/projects/{project_id}/testMatrices',
                'body' => 'test_matrix',
                'placeholders' => [
                    'project_id' => [
                        'getters' => [
                            'getProjectId',
                        ],
                    ],
                ],
            ],
            'GetTestMatrix' => [
                'method' => 'get',
                'uriTemplate' => '/v1/projects/{project_id}/testMatrices/{test_matrix_id}',
                'placeholders' => [
                    'project_id' => [
                        'getters' => [
                            'getProjectId',
                        ],
                    ],
                    'test_matrix_id' => [
                        'getters' => [
                            'getTestMatrixId',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
