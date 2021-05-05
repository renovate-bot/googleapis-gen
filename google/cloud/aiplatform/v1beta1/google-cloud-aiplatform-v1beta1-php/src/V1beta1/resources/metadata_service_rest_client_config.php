<?php

return [
    'interfaces' => [
        'google.cloud.aiplatform.v1beta1.MetadataService' => [
            'AddContextArtifactsAndExecutions' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:addContextArtifactsAndExecutions',
                'body' => '*',
                'placeholders' => [
                    'context' => [
                        'getters' => [
                            'getContext',
                        ],
                    ],
                ],
            ],
            'AddContextChildren' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:addContextChildren',
                'body' => '*',
                'placeholders' => [
                    'context' => [
                        'getters' => [
                            'getContext',
                        ],
                    ],
                ],
            ],
            'AddExecutionEvents' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{execution=projects/*/locations/*/metadataStores/*/executions/*}:addExecutionEvents',
                'body' => '*',
                'placeholders' => [
                    'execution' => [
                        'getters' => [
                            'getExecution',
                        ],
                    ],
                ],
            ],
            'CreateArtifact' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/artifacts',
                'body' => 'artifact',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateContext' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/contexts',
                'body' => 'context',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateExecution' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/executions',
                'body' => 'execution',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateMetadataSchema' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/metadataSchemas',
                'body' => 'metadata_schema',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'CreateMetadataStore' => [
                'method' => 'post',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/metadataStores',
                'body' => 'metadata_store',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'DeleteContext' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*/contexts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'DeleteMetadataStore' => [
                'method' => 'delete',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetArtifact' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*/artifacts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetContext' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*/contexts/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetExecution' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*/executions/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetMetadataSchema' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*/metadataSchemas/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'GetMetadataStore' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{name=projects/*/locations/*/metadataStores/*}',
                'placeholders' => [
                    'name' => [
                        'getters' => [
                            'getName',
                        ],
                    ],
                ],
            ],
            'ListArtifacts' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/artifacts',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListContexts' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/contexts',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListExecutions' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/executions',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListMetadataSchemas' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*/metadataStores/*}/metadataSchemas',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ListMetadataStores' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{parent=projects/*/locations/*}/metadataStores',
                'placeholders' => [
                    'parent' => [
                        'getters' => [
                            'getParent',
                        ],
                    ],
                ],
            ],
            'QueryArtifactLineageSubgraph' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{artifact=projects/*/locations/*/metadataStores/*/artifacts/*}:queryArtifactLineageSubgraph',
                'placeholders' => [
                    'artifact' => [
                        'getters' => [
                            'getArtifact',
                        ],
                    ],
                ],
            ],
            'QueryContextLineageSubgraph' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{context=projects/*/locations/*/metadataStores/*/contexts/*}:queryContextLineageSubgraph',
                'placeholders' => [
                    'context' => [
                        'getters' => [
                            'getContext',
                        ],
                    ],
                ],
            ],
            'QueryExecutionInputsAndOutputs' => [
                'method' => 'get',
                'uriTemplate' => '/v1beta1/{execution=projects/*/locations/*/metadataStores/*/executions/*}:queryExecutionInputsAndOutputs',
                'placeholders' => [
                    'execution' => [
                        'getters' => [
                            'getExecution',
                        ],
                    ],
                ],
            ],
            'UpdateArtifact' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{artifact.name=projects/*/locations/*/metadataStores/*/artifacts/*}',
                'body' => 'artifact',
                'placeholders' => [
                    'artifact.name' => [
                        'getters' => [
                            'getArtifact',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateContext' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{context.name=projects/*/locations/*/metadataStores/*/contexts/*}',
                'body' => 'context',
                'placeholders' => [
                    'context.name' => [
                        'getters' => [
                            'getContext',
                            'getName',
                        ],
                    ],
                ],
            ],
            'UpdateExecution' => [
                'method' => 'patch',
                'uriTemplate' => '/v1beta1/{execution.name=projects/*/locations/*/metadataStores/*/executions/*}',
                'body' => 'execution',
                'placeholders' => [
                    'execution.name' => [
                        'getters' => [
                            'getExecution',
                            'getName',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
