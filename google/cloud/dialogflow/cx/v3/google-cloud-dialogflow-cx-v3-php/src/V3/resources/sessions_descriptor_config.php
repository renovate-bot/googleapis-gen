<?php

return [
    'interfaces' => [
        'google.cloud.dialogflow.cx.v3.Sessions' => [
            'StreamingDetectIntent' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'BidiStreaming',
                ],
            ],
        ],
    ],
];
