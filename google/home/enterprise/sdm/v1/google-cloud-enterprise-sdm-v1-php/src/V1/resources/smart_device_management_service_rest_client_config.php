<?php

return [
    'interfaces' => [
        'google.home.enterprise.sdm.v1.SmartDeviceManagementService' => [
            'ExecuteDeviceCommand' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=enterprises/*/devices/*}:executeCommand',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetDevice' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=enterprises/*/devices/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetRoom' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=enterprises/*/structures/*/rooms/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetStructure' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=enterprises/*/structures/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListDevices' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=enterprises/*}/devices',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListRooms' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=enterprises/*/structures/*}/rooms',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListStructures' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=enterprises/*}/structures',
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
