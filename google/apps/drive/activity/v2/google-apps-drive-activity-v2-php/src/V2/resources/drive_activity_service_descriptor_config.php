<?php

return [
    'interfaces' => [
        'google.apps.drive.activity.v2.DriveActivityService' => [
            'QueryDriveActivity' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getActivities',
                ],
            ],
        ],
    ],
];
