<?php

return [
    'interfaces' => [
        'google.cloud.resourcemanager.v3.TagKeys' => [
            'ListTagKeys' => [
                'method' => 'get',
                'uriTemplate' => '/v3/tagKeys',
            ],
            'GetTagKey' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=tagKeys/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateTagKey' => [
                'method' => 'post',
                'uriTemplate' => '/v3/tagKeys',
                'body' => 'tag_key',
            ],
            'UpdateTagKey' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{tag_key.name=tagKeys/*}',
                'body' => 'tag_key',
                'placeholders' => [
                    'tag_key.name' => [
                        'getters' => [
                            'getTagKey',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteTagKey' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=tagKeys/*}',
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
                'uriTemplate' => '/v3/{resource=tagKeys/*}:getIamPolicy',
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
                'uriTemplate' => '/v3/{resource=tagKeys/*}:setIamPolicy',
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
                'uriTemplate' => '/v3/{resource=tagKeys/*}:testIamPermissions',
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
