<?php

return [
    'interfaces' => [
        'google.cloud.gaming.v1beta.GameServerConfigsService' => [
            'CreateGameServerConfig' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/gameServerDeployments/*}/configs',
                'body' => 'game_server_config',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteGameServerConfig' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/gameServerDeployments/*/configs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetGameServerConfig' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/gameServerDeployments/*/configs/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListGameServerConfigs' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/gameServerDeployments/*}/configs',
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
