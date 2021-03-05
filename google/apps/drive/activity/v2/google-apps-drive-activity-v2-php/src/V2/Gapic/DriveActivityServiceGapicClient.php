<?php
/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 * GENERATED CODE WARNING
 * This file was generated from the file
 * https://github.com/google/googleapis/blob/master/google/apps/drive/activity/v2/drive_activity_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Apps\Drive\Activity\V2\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Apps\Drive\Activity\V2\ConsolidationStrategy;
use Google\Apps\Drive\Activity\V2\QueryDriveActivityRequest;
use Google\Apps\Drive\Activity\V2\QueryDriveActivityResponse;
use Google\Auth\FetchAuthTokenInterface;

/**
 * Service Description: Service for querying activity on Drive items. Activity is user
 * or system action on Drive items that happened in the past. A Drive item can
 * be a file or folder, or a Team Drive.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $driveActivityServiceClient = new DriveActivityServiceClient();
 * try {
 *     // Iterate over pages of elements
 *     $pagedResponse = $driveActivityServiceClient->queryDriveActivity();
 *     foreach ($pagedResponse->iteratePages() as $page) {
 *         foreach ($page as $element) {
 *             // doSomethingWith($element);
 *         }
 *     }
 *
 *
 *     // Alternatively:
 *
 *     // Iterate through all elements
 *     $pagedResponse = $driveActivityServiceClient->queryDriveActivity();
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $driveActivityServiceClient->close();
 * }
 * ```
 *
 * @experimental
 */
class DriveActivityServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.apps.drive.activity.v2.DriveActivityService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'driveactivity.googleapis.com';

    /**
     * The default port of the service.
     */
    const DEFAULT_SERVICE_PORT = 443;

    /**
     * The name of the code generator, to be included in the agent header.
     */
    const CODEGEN_NAME = 'gapic';

    /**
     * The default scopes required by the service.
     */
    public static $serviceScopes = [
        'https://www.googleapis.com/auth/drive.activity',
        'https://www.googleapis.com/auth/drive.activity.readonly',
    ];

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/drive_activity_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/drive_activity_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/drive_activity_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/drive_activity_service_rest_client_config.php',
                ],
            ],
        ];
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'driveactivity.googleapis.com:443'.
     *     @type string|array|FetchAuthTokenInterface|CredentialsWrapper $credentials
     *           The credentials to be used by the client to authorize API calls. This option
     *           accepts either a path to a credentials file, or a decoded credentials file as a
     *           PHP array.
     *           *Advanced usage*: In addition, this option can also accept a pre-constructed
     *           {@see \Google\Auth\FetchAuthTokenInterface} object or
     *           {@see \Google\ApiCore\CredentialsWrapper} object. Note that when one of these
     *           objects are provided, any settings in $credentialsConfig will be ignored.
     *     @type array $credentialsConfig
     *           Options used to configure credentials, including auth token caching, for the client.
     *           For a full list of supporting configuration options, see
     *           {@see \Google\ApiCore\CredentialsWrapper::build()}.
     *     @type bool $disableRetries
     *           Determines whether or not retries defined by the client configuration should be
     *           disabled. Defaults to `false`.
     *     @type string|array $clientConfig
     *           Client method configuration, including retry settings. This option can be either a
     *           path to a JSON file, or a PHP array containing the decoded JSON data.
     *           By default this settings points to the default client config file, which is provided
     *           in the resources folder.
     *     @type string|TransportInterface $transport
     *           The transport used for executing network requests. May be either the string `rest`
     *           or `grpc`. Defaults to `grpc` if gRPC support is detected on the system.
     *           *Advanced usage*: Additionally, it is possible to pass in an already instantiated
     *           {@see \Google\ApiCore\Transport\TransportInterface} object. Note that when this
     *           object is provided, any settings in $transportConfig, and any $serviceAddress
     *           setting, will be ignored.
     *     @type array $transportConfig
     *           Configuration options that will be used to construct the transport. Options for
     *           each supported transport type should be passed in a key for that transport. For
     *           example:
     *           $transportConfig = [
     *               'grpc' => [...],
     *               'rest' => [...]
     *           ];
     *           See the {@see \Google\ApiCore\Transport\GrpcTransport::build()} and
     *           {@see \Google\ApiCore\Transport\RestTransport::build()} methods for the
     *           supported options.
     * }
     *
     * @throws ValidationException
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Query past activity in Google Drive.
     *
     * Sample code:
     * ```
     * $driveActivityServiceClient = new DriveActivityServiceClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $driveActivityServiceClient->queryDriveActivity();
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $driveActivityServiceClient->queryDriveActivity();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $driveActivityServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $itemName
     *          Return activities for this Drive item. The format is
     *          `items/ITEM_ID`.
     *     @type string $ancestorName
     *          Return activities for this Drive folder and all children and descendants.
     *          The format is `items/ITEM_ID`.
     *     @type ConsolidationStrategy $consolidationStrategy
     *          Details on how to consolidate related actions that make up the activity. If
     *          not set, then related actions are not consolidated.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $filter
     *          The filtering for items returned from this query request. The format of the
     *          filter string is a sequence of expressions, joined by an optional "AND",
     *          where each expression is of the form "field operator value".
     *
     *          Supported fields:
     *
     *            - `time`: Uses numerical operators on date values either in
     *              terms of milliseconds since Jan 1, 1970 or in RFC 3339 format.
     *              Examples:
     *                - `time > 1452409200000 AND time <= 1492812924310`
     *                - `time >= "2016-01-10T01:02:03-05:00"`
     *
     *            - `detail.action_detail_case`: Uses the "has" operator (:) and
     *              either a singular value or a list of allowed action types enclosed in
     *              parentheses.
     *              Examples:
     *                - `detail.action_detail_case: RENAME`
     *                - `detail.action_detail_case:(CREATE EDIT)`
     *                - `-detail.action_detail_case:MOVE`
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function queryDriveActivity(array $optionalArgs = [])
    {
        $request = new QueryDriveActivityRequest();
        if (isset($optionalArgs['itemName'])) {
            $request->setItemName($optionalArgs['itemName']);
        }
        if (isset($optionalArgs['ancestorName'])) {
            $request->setAncestorName($optionalArgs['ancestorName']);
        }
        if (isset($optionalArgs['consolidationStrategy'])) {
            $request->setConsolidationStrategy($optionalArgs['consolidationStrategy']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        return $this->getPagedListResponse(
            'QueryDriveActivity',
            $optionalArgs,
            QueryDriveActivityResponse::class,
            $request
        );
    }
}
