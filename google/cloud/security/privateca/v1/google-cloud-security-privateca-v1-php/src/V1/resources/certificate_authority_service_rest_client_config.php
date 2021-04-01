<?php

return [
    'interfaces' => [
        'google.cloud.location.Locations' => [
            'GetLocation' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListLocations' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*}/locations',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.cloud.security.privateca.v1.CertificateAuthorityService' => [
            'CreateCertificate' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/caPools/*}/certificates',
                'body' => 'certificate',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'GetCertificate' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificates/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCertificates' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/caPools/*}/certificates',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'RevokeCertificate' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificates/*}:revoke',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateCertificate' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{certificate.name=projects/*/locations/*/caPools/*/certificates/*}',
                'body' => 'certificate',
                'placeholders' => [
                    'certificate.name' => [
                        'getters' => [
                            'getCertificate',
                            'getName',
                        ],
                    ],
                ],
            ],
            'ActivateCertificateAuthority' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}:activate',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateCertificateAuthority' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/caPools/*}/certificateAuthorities',
                'body' => 'certificate_authority',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DisableCertificateAuthority' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}:disable',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'EnableCertificateAuthority' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}:enable',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'FetchCertificateAuthorityCsr' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}:fetch',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetCertificateAuthority' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCertificateAuthorities' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/caPools/*}/certificateAuthorities',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UndeleteCertificateAuthority' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}:undelete',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteCertificateAuthority' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateCertificateAuthority' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{certificate_authority.name=projects/*/locations/*/caPools/*/certificateAuthorities/*}',
                'body' => 'certificate_authority',
                'placeholders' => [
                    'certificate_authority.name' => [
                        'getters' => [
                            'getCertificateAuthority',
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateCaPool' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/caPools',
                'body' => 'ca_pool',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateCaPool' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{ca_pool.name=projects/*/locations/*/caPools/*}',
                'body' => 'ca_pool',
                'placeholders' => [
                    'ca_pool.name' => [
                        'getters' => [
                            'getCaPool',
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetCaPool' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCaPools' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/caPools',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteCaPool' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'FetchCaCerts' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{ca_pool=projects/*/locations/*/caPools/*}:fetchCaCerts',
                'body' => '*',
                'placeholders' => [
                    'ca_pool' => [
                        'getters' => [
                            'getCaPool',
                        ],
                    ],
                ],
            ],
            'GetCertificateRevocationList' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCertificateRevocationLists' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*/caPools/*/certificateAuthorities/*}/certificateRevocationLists',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateCertificateRevocationList' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{certificate_revocation_list.name=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}',
                'body' => 'certificate_revocation_list',
                'placeholders' => [
                    'certificate_revocation_list.name' => [
                        'getters' => [
                            'getCertificateRevocationList',
                            'getName',
                        ],
                    ],
                ],
            ],
            'CreateCertificateTemplate' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/certificateTemplates',
                'body' => 'certificate_template',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteCertificateTemplate' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/certificateTemplates/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetCertificateTemplate' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/certificateTemplates/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListCertificateTemplates' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{parent=projects/*/locations/*}/certificateTemplates',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'UpdateCertificateTemplate' => [
                'method' => 'patch',
                'uriTemplate' => '/v1/{certificate_template.name=projects/*/locations/*/certificateTemplates/*}',
                'body' => 'certificate_template',
                'placeholders' => [
                    'certificate_template.name' => [
                        'getters' => [
                            'getCertificateTemplate',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
        'google.iam.v1.IAMPolicy' => [
            'GetIamPolicy' => [
                'method' => 'get',
                'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*}:getIamPolicy',
                'additionalBindings' => [
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/certificateTemplates/*}:getIamPolicy',
                    ],
                    [
                        'method' => 'get',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:getIamPolicy',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'SetIamPolicy' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*}:setIamPolicy',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/certificateTemplates/*}:setIamPolicy',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:setIamPolicy',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
            'TestIamPermissions' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*}:testIamPermissions',
                'body' => '*',
                'additionalBindings' => [
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/certificateTemplates/*}:testIamPermissions',
                        'body' => '*',
                    ],
                    [
                        'method' => 'post',
                        'uriTemplate' => '/v1/{resource=projects/*/locations/*/caPools/*/certificateAuthorities/*/certificateRevocationLists/*}:testIamPermissions',
                        'body' => '*',
                    ],
                ],
                'placeholders' => [
                    'resource' => [
                        'getters' => [
                            'getResource',
                        ],
                    ],
                ],
            ],
        ],
        'google.longrunning.Operations' => [
            'CancelOperation' => [
                'method' => 'post',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/operations/*}:cancel',
                'body' => '*',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteOperation' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v1/{name=projects/*/locations/*/operations/*}',
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
                'uriTemplate' => '/v1/{name=projects/*/locations/*}/operations',
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
