<?php

return [
    'interfaces' => [
        'google.devtools.remoteworkers.v1test2.Bots' => [
            'CreateBotSession' => [
                'method' => 'post',
                'uriTemplate' => '/v1test2/{parent=**}/botSessions',
                'body' => 'bot_session',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateBotSession' => [
                'method' => 'patch',
                'uriTemplate' => '/v1test2/{name=**/botSessions/*}',
                'body' => 'bot_session',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
        ],
    ],
];
