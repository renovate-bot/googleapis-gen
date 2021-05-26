<?php

return [
    'interfaces' => [
        'google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService' => [
            'BatchCalculateEffectiveSettings' => [
                'method' => 'post',
                'uriTemplate' => '/settings/v1beta1/{parent=organizations/*}/effectiveSettings:batchCalculate',
                'body' => '*',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'BatchGetSettings' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{parent=organizations/*}/settings:batchGet',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CalculateEffectiveComponentSettings' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/components/*/effectiveSettings}:calculate',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/components/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/components/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/components/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/components/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/components/*/effectiveSettings}:calculate',
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
            'CalculateEffectiveSettings' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/effectiveSettings}:calculate',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/effectiveSettings}:calculate',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/effectiveSettings}:calculate',
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
            'GetComponentSettings' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/components/*/settings}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/components/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/components/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/components/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/components/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/components/*/settings}',
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
            'GetServiceAccount' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/serviceAccount}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetSettings' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/settings}',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/settings}',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/settings}',
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
            'ListComponents' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{parent=organizations/*}/components',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListDetectors' => [
                'method' => 'get',
                'uriTemplate' => '/settings/v1beta1/{parent=organizations/*}/detectors',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ResetComponentSettings' => [
                'method' => 'post',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/components/*/settings}:reset',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/components/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/components/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/components/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/components/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/components/*/settings}:reset',
                        'body' => '*',
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
            'ResetSettings' => [
                'method' => 'post',
                'uriTemplate' => '/settings/v1beta1/{name=organizations/*/settings}:reset',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=folders/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/locations/*/clusters/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/regions/*/clusters/*/settings}:reset',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/settings/v1beta1/{name=projects/*/zones/*/clusters/*/settings}:reset',
                        'body' => '*',
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
            'UpdateComponentSettings' => [
                'method' => 'patch',
                'uriTemplate' => '/settings/v1beta1/{component_settings.name=organizations/*/components/*/settings}',
                'body' => 'component_settings',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{component_settings.name=folders/*/components/*/settings}',
                        'body' => 'component_settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{component_settings.name=projects/*/components/*/settings}',
                        'body' => 'component_settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{component_settings.name=projects/*/locations/*/clusters/*/components/*/settings}',
                        'body' => 'component_settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{component_settings.name=projects/*/regions/*/clusters/*/components/*/settings}',
                        'body' => 'component_settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{component_settings.name=projects/*/zones/*/clusters/*/components/*/settings}',
                        'body' => 'component_settings',
                    ],
                ],
                'placeholders' => [
                    'component_settings.name' => [
                        'getters' => [
                            'getComponentSettings',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateSettings' => [
                'method' => 'patch',
                'uriTemplate' => '/settings/v1beta1/{settings.name=organizations/*/settings}',
                'body' => 'settings',
                'additionalBindings' => [
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{settings.name=folders/*/settings}',
                        'body' => 'settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{settings.name=projects/*/settings}',
                        'body' => 'settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{settings.name=projects/*/locations/*/clusters/*/settings}',
                        'body' => 'settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{settings.name=projects/*/regions/*/clusters/*/settings}',
                        'body' => 'settings',
                    ],
                    [
                        'method' => 'patch',
                        'uriTemplate' => '/settings/v1beta1/{settings.name=projects/*/zones/*/clusters/*/settings}',
                        'body' => 'settings',
                    ],
                ],
                'placeholders' => [
                    'settings.name' => [
                        'getters' => [
                            'getSettings',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
