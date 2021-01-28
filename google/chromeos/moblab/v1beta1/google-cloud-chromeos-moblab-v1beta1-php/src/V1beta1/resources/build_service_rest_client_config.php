<?php

return [
    'interfaces' => [
        'google.chromeos.moblab.v1beta1.BuildService' => [
            'ListBuilds' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=buildTargets/*/models/*}/builds',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CheckBuildStageStatus' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=buildTargets/*/models/*/builds/*/artifacts/*}:check',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'StageBuild' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=buildTargets/*/models/*/builds/*/artifacts/*}:stage',
                'body' => '*',
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
