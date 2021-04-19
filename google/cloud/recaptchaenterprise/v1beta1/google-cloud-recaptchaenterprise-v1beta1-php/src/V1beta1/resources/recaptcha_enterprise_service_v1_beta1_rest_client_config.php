<?php

return [
    'interfaces' => [
        'google.cloud.recaptchaenterprise.v1beta1.RecaptchaEnterpriseServiceV1Beta1' => [
            'AnnotateAssessment' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{name=projects/*/assessments/*}:annotate',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateAssessment' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/assessments',
                'body' => 'assessment',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateKey' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/keys',
                'body' => 'key',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteKey' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/keys/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetKey' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/keys/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListKeys' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*}/keys',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateKey' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{key.name=projects/*/keys/*}',
                'body' => 'key',
                'placeholders' => [
                    'key.name' => [
                        'getters' => [
                            'getKey',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
