<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Webhooks' => [
            'ListWebhooks' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*}/webhooks',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetWebhook' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/webhooks/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateWebhook' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{parent=projects/*/locations/*/agents/*}/webhooks',
                'body' => 'webhook',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateWebhook' => [
                'method' => 'patch',
                'uriTemplate' => '/v3/{webhook.name=projects/*/locations/*/agents/*/webhooks/*}',
                'body' => 'webhook',
                'placeholders' => [
                    'webhook.name' => [
                        'getters' => [
                            'getWebhook',
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteWebhook' => [
                'method' => 'delete',
                'uriTemplate' => '/v3/{name=projects/*/locations/*/agents/*/webhooks/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v3/{name=projects/*/operations/*}:cancel',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*/operations/*}:cancel',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetOperation' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*/operations/*}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*/operations/*}',
                    ],
                ],
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListOperations' => [
                'method' => 'get',
                'uriTemplate' => '/v3/{name=projects/*}/operations',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v3/{name=projects/*/locations/*}/operations',
                    ],
                ],
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
