<?php

return [
    'interfaces' => [
        'google.maps.playablelocations.v3.PlayableLocations' => [
            'SamplePlayableLocations' => [
                'method' => 'post',
                'uriTemplate' => '/v3:samplePlayableLocations',
                'body' => '*',
            ],
            'LogPlayerReports' => [
                'method' => 'post',
                'uriTemplate' => '/v3:logPlayerReports',
                'body' => '*',
            ],
            'LogImpressions' => [
                'method' => 'post',
                'uriTemplate' => '/v3:logImpressions',
                'body' => '*',
            ],
        ],
    ],
];
