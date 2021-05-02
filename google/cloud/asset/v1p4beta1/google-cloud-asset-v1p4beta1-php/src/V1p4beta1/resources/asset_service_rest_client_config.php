<?php

return [
    'interfaces' => [
        'google.cloud.asset.v1p4beta1.AssetService' => [
            'AnalyzeIamPolicy' => [
                'method' => 'get',
                'uriTemplate' => '/v1p4beta1/{analysis_query.parent=*/*}:analyzeIamPolicy',
                'placeholders' => [
                    'analysis_query.parent' => [
                        'getters' => [
                            'getAnalysisQuery',
                            'getParent',
                        ],
                    ],
                ],
            ],
            'ExportIamPolicyAnalysis' => [
                'method' => 'post',
                'uriTemplate' => '/v1p4beta1/{analysis_query.parent=*/*}:exportIamPolicyAnalysis',
                'body' => '*',
                'placeholders' => [
                    'analysis_query.parent' => [
                        'getters' => [
                            'getAnalysisQuery',
                            'getParent',
                        ],
                    ],
                ],
            ],
        ],
    ],
];
