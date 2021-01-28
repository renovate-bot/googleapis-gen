<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1beta2.BigQueryRead' => [
            'ReadRows' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'ServerStreaming',
                ],
            ],
        ],
    ],
];
