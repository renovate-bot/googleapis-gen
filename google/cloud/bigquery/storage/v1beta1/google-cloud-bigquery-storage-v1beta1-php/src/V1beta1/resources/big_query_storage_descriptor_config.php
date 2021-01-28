<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta1.BigQueryStorage' => [
            'ReadRows' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'ServerStreaming',
                ],
            ],
        ],
    ],
];
