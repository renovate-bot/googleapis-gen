<?php

return [
    'interfaces' => [
        'google.cloud.bigquery.storage.v1alpha2.BigQueryWrite' => [
            'AppendRows' => [
                'grpcStreaming' => [
                    'grpcStreamingType' => 'BidiStreaming',
                ],
            ],
        ],
    ],
];
