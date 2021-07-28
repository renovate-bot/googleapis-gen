<?php

return [
    'interfaces' => [
        'google.cloud.retail.v2beta.ProductService' => [
            'AddFulfillmentPlaces' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\AddFulfillmentPlacesResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\AddFulfillmentPlacesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ImportProducts' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\ImportProductsResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\ImportMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'RemoveFulfillmentPlaces' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\RemoveFulfillmentPlacesResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\RemoveFulfillmentPlacesMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'SetInventory' => [
                'longRunning' => [
                    'operationReturnType' => '\Google\Cloud\Retail\V2beta\SetInventoryResponse',
                    'metadataReturnType' => '\Google\Cloud\Retail\V2beta\SetInventoryMetadata',
                    'initialPollDelayMillis' => '500',
                    'pollDelayMultiplier' => '1.5',
                    'maxPollDelayMillis' => '5000',
                    'totalPollTimeoutMillis' => '300000',
                ],
            ],
            'ListProducts' => [
                'pageStreaming' => [
                    'requestPageTokenGetMethod' => 'getPageToken',
                    'requestPageTokenSetMethod' => 'setPageToken',
                    'requestPageSizeGetMethod' => 'getPageSize',
                    'requestPageSizeSetMethod' => 'setPageSize',
                    'responsePageTokenGetMethod' => 'getNextPageToken',
                    'resourcesGetMethod' => 'getProducts',
                ],
            ],
        ],
    ],
];
