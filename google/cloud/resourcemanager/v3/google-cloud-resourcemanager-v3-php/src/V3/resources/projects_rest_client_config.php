<?php

return [
    'interfaces' => [
        'google.cloud.resourcemanager.v3.Projects' => [
            'GetProject' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListProjects' => [
                'method' => 'get',
                'uriTemplate' => '/v3/projects',
            ],
            'SearchProjects' => [
                'method' => 'get',
                'uriTemplate' => '/v3/projects:search',
            ],
            'CreateProject' => [
                'method' => 'post',
                'uriTemplate' => '/v3/projects',
                'body' => 'project',
            ],
            'UpdateProject' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{project.name=projects/*}',
                'body' => 'project',
                'placeholders' => [
                    'project.name' => [
                        'getters' => [
                            'getProject',
                            'getName',
                        ],
                    ],
                ],
            ],
            'MoveProject' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*}:move',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteProject' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=projects/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UndeleteProject' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*}:undelete',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{resource=projects/*}:getIamPolicy',
                'body' => '*',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'SetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{resource=projects/*}:setIamPolicy',
                'body' => '*',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'TestIamPermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{resource=projects/*}:testIamPermissions',
                'body' => '*',
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=operations/**}',
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
