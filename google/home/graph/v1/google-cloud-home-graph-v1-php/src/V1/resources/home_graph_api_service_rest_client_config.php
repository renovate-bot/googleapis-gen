<?php

return [
    'interfaces' => [
        'google.home.graph.v1.HomeGraphApiService' => [
            'DeleteAgentUser' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{agent_user_id=agentUsers/**}',
                'placeholders' => [
                    'agent_user_id' => [
                        'getters' => [
                            'getAgentUserId',
                        ],
                    ],
                ],
            ],
            'Query' => [
                'method' => 'post',
                'uriTemplate' => '/v1/devices:query',
                'body' => '*',
            ],
            'ReportStateAndNotification' => [
                'method' => 'post',
                'uriTemplate' => '/v1/devices:reportStateAndNotification',
                'body' => '*',
            ],
            'RequestSyncDevices' => [
                'method' => 'post',
                'uriTemplate' => '/v1/devices:requestSync',
                'body' => '*',
            ],
            'Sync' => [
                'method' => 'post',
                'uriTemplate' => '/v1/devices:sync',
                'body' => '*',
            ],
        ],
    ],
];
