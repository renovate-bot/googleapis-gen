<?php

return [
    'interfaces' => [
        'google.storage.v2.Storage' => [
            'ReadObject' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'ServerStreaming',
                ],
            ],
            'WriteObject' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'ClientStreaming',
                ],
            ],
        ],
    ],
];
