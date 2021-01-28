<?php

return [
    'interfaces' => [
        'google.cloud.videointelligence.v1p3beta1.StreamingVideoIntelligenceService' => [
            'StreamingAnnotateVideo' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'BidiStreaming',
                ],
            ],
        ],
    ],
];
