<?php

return [
    'interfaces' => [
        'google.apps.drive.activity.v2.DriveActivityService' => [
            'QueryDriveActivity' => [
                'method' => 'post',
                'uriTemplate' => '/v2/activity:query',
                'body' => '*',
            ],
        ],
    ],
];
