<?php

return [
    'interfaces' => [
        'google.chromeos.moblab.v1beta1.BuildService' => [
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
            'FindMostStableBuild' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{build_target=buildTargets/*}:findMostStableBuild',
                'placeholders' => [
                    'build_target' => [
                        'getters' => [
                            'getBuildTarget',
                        ],
                    ],
                ],
            ],
            'ListBuildTargets' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/buildTargets',
            ],
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
            'ListModels' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=buildTargets/*}/models',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
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
