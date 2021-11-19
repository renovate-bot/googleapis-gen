<?php

return [
    'interfaces' => [
        'google.streetview.publish.v1.StreetViewPublishService' => [
            'BatchDeletePhotos' => [
                'method' => 'post',
                'uriTemplate' => '/v1/photos:batchDelete',
                'body' => '*',
            ],
            'BatchGetPhotos' => [
                'method' => 'get',
                'uriTemplate' => '/v1/photos:batchGet',
            ],
            'BatchUpdatePhotos' => [
                'method' => 'post',
                'uriTemplate' => '/v1/photos:batchUpdate',
                'body' => '*',
            ],
            'CreatePhoto' => [
                'method' => 'post',
                'uriTemplate' => '/v1/photo',
                'body' => 'photo',
            ],
            'DeletePhoto' => [
                'method' => 'delete',
                'uriTemplate' => '/v1/photo/{photo_id}',
                'placeholders' => [
                    'photo_id' => [
                        'getters' => [
                            'getPhotoId',
                        ],
                    ],
                ],
            ],
            'GetPhoto' => [
                'method' => 'get',
                'uriTemplate' => '/v1/photo/{photo_id}',
                'placeholders' => [
                    'photo_id' => [
                        'getters' => [
                            'getPhotoId',
                        ],
                    ],
                ],
                'queryParams' => [
                    'view',
                ],
            ],
            'ListPhotos' => [
                'method' => 'get',
                'uriTemplate' => '/v1/photos',
                'queryParams' => [
                    'view',
                ],
            ],
            'StartUpload' => [
                'method' => 'post',
                'uriTemplate' => '/v1/photo:startUpload',
                'body' => '*',
            ],
            'UpdatePhoto' => [
                'method' => 'put',
                'uriTemplate' => '/v1/photo/{photo.photo_id.id}',
                'body' => 'photo',
                'placeholders' => [
                    'photo.photo_id.id' => [
                        'getters' => [
                            'getPhoto',
                            'getPhotoId',
                            'getId',
                        ],
                    ],
                ],
                'queryParams' => [
                    'update_mask',
                ],
            ],
        ],
    ],
];
