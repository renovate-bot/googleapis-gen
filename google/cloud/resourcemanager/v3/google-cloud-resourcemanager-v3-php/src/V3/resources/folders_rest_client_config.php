<?php

return [
    'interfaces' => [
        'google.cloud.resourcemanager.v3.Folders' => [
            'GetFolder' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=folders/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListFolders' => [
                'method' => 'get',
                'uriTemplate' => '/v3/folders',
            ],
            'SearchFolders' => [
                'method' => 'get',
                'uriTemplate' => '/v3/folders:search',
            ],
            'CreateFolder' => [
                'method' => 'post',
                'uriTemplate' => '/v3/folders',
                'body' => 'folder',
            ],
            'UpdateFolder' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{folder.name=folders/*}',
                'body' => 'folder',
                'placeholders' => [
                    'folder.name' => [
                        'getters' => [
                            'getFolder',
                            'getName',
                        ],
                    ],
                ],
            ],
            'MoveFolder' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=folders/*}:move',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteFolder' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=folders/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UndeleteFolder' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=folders/*}:undelete',
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
                'uriTemplate' => '/v3/{resource=folders/*}:getIamPolicy',
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
                'uriTemplate' => '/v3/{resource=folders/*}:setIamPolicy',
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
                'uriTemplate' => '/v3/{resource=folders/*}:testIamPermissions',
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
