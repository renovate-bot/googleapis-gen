<?php

return [
    'interfaces' => [
        'google.cloud.vision.v1p2beta1.ImageAnnotator' => [
            'AsyncBatchAnnotateFiles' => [
                'method' => 'post',
                'uriTemplate' => '/v1p2beta1/files:asyncBatchAnnotate',
                'body' => '*',
            ],
            'BatchAnnotateImages' => [
                'method' => 'post',
                'uriTemplate' => '/v1p2beta1/images:annotate',
                'body' => '*',
            ],
        ],
    ],
];
