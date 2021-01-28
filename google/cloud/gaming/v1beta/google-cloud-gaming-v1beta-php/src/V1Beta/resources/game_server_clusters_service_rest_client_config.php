<?php

return [
    'interfaces' => [
        'google.cloud.gaming.v1beta.GameServerClustersService' => [
            'ListGameServerClusters' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/realms/*}/gameServerClusters',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetGameServerCluster' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/realms/*/gameServerClusters/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateGameServerCluster' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/realms/*}/gameServerClusters',
                'body' => 'game_server_cluster',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'PreviewCreateGameServerCluster' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta/{parent=projects/*/locations/*/realms/*}/gameServerClusters:previewCreate',
                'body' => 'game_server_cluster',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteGameServerCluster' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/realms/*/gameServerClusters/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'PreviewDeleteGameServerCluster' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta/{name=projects/*/locations/*/realms/*/gameServerClusters/*}:previewDelete',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateGameServerCluster' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{game_server_cluster.name=projects/*/locations/*/realms/*/gameServerClusters/*}',
                'body' => 'game_server_cluster',
                'placeholders' => [
                    'game_server_cluster.name' => [
                        'getters' => [
                            'getGameServerCluster',
                            'getName',
                        ],
                    ],
                ],
            ],
            'PreviewUpdateGameServerCluster' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta/{game_server_cluster.name=projects/*/locations/*/realms/*/gameServerClusters/*}:previewUpdate',
                'body' => 'game_server_cluster',
                'placeholders' => [
                    'game_server_cluster.name' => [
                        'getters' => [
                            'getGameServerCluster',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
