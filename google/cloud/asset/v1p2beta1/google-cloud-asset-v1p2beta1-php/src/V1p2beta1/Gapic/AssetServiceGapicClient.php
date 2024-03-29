<?php
/*
 * Copyright 2022 Google LLC
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
 * Generated by gapic-generator-php from the file
 * https://github.com/googleapis/googleapis/blob/master/google/cloud/asset/v1p2beta1/asset_service.proto
 * Updates to the above are reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Asset\V1p2beta1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Asset\V1p2beta1\CreateFeedRequest;
use Google\Cloud\Asset\V1p2beta1\DeleteFeedRequest;
use Google\Cloud\Asset\V1p2beta1\Feed;
use Google\Cloud\Asset\V1p2beta1\GetFeedRequest;
use Google\Cloud\Asset\V1p2beta1\ListFeedsRequest;
use Google\Cloud\Asset\V1p2beta1\ListFeedsResponse;
use Google\Cloud\Asset\V1p2beta1\UpdateFeedRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Asset service definition.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $assetServiceClient = new AssetServiceClient();
 * try {
 *     $parent = 'parent';
 *     $feedId = 'feed_id';
 *     $feed = new Feed();
 *     $response = $assetServiceClient->createFeed($parent, $feedId, $feed);
 * } finally {
 *     $assetServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assist with these names, this class includes a format method for each type of
 * name, and additionally a parseName method to extract the individual identifiers
 * contained within formatted names that are returned by the API.
 *
 * @experimental
 */
class AssetServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.asset.v1p2beta1.AssetService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'cloudasset.googleapis.com';

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
        'https://www.googleapis.com/auth/cloud-platform',
    ];

    private static $feedNameTemplate;

    private static $folderFeedNameTemplate;

    private static $organizationFeedNameTemplate;

    private static $projectFeedNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/asset_service_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/asset_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/asset_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/asset_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getFeedNameTemplate()
    {
        if (self::$feedNameTemplate == null) {
            self::$feedNameTemplate = new PathTemplate('projects/{project}/feeds/{feed}');
        }

        return self::$feedNameTemplate;
    }

    private static function getFolderFeedNameTemplate()
    {
        if (self::$folderFeedNameTemplate == null) {
            self::$folderFeedNameTemplate = new PathTemplate('folders/{folder}/feeds/{feed}');
        }

        return self::$folderFeedNameTemplate;
    }

    private static function getOrganizationFeedNameTemplate()
    {
        if (self::$organizationFeedNameTemplate == null) {
            self::$organizationFeedNameTemplate = new PathTemplate('organizations/{organization}/feeds/{feed}');
        }

        return self::$organizationFeedNameTemplate;
    }

    private static function getProjectFeedNameTemplate()
    {
        if (self::$projectFeedNameTemplate == null) {
            self::$projectFeedNameTemplate = new PathTemplate('projects/{project}/feeds/{feed}');
        }

        return self::$projectFeedNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'feed' => self::getFeedNameTemplate(),
                'folderFeed' => self::getFolderFeedNameTemplate(),
                'organizationFeed' => self::getOrganizationFeedNameTemplate(),
                'projectFeed' => self::getProjectFeedNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a feed
     * resource.
     *
     * @param string $project
     * @param string $feed
     *
     * @return string The formatted feed resource.
     *
     * @experimental
     */
    public static function feedName($project, $feed)
    {
        return self::getFeedNameTemplate()->render([
            'project' => $project,
            'feed' => $feed,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a folder_feed
     * resource.
     *
     * @param string $folder
     * @param string $feed
     *
     * @return string The formatted folder_feed resource.
     *
     * @experimental
     */
    public static function folderFeedName($folder, $feed)
    {
        return self::getFolderFeedNameTemplate()->render([
            'folder' => $folder,
            'feed' => $feed,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * organization_feed resource.
     *
     * @param string $organization
     * @param string $feed
     *
     * @return string The formatted organization_feed resource.
     *
     * @experimental
     */
    public static function organizationFeedName($organization, $feed)
    {
        return self::getOrganizationFeedNameTemplate()->render([
            'organization' => $organization,
            'feed' => $feed,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a project_feed
     * resource.
     *
     * @param string $project
     * @param string $feed
     *
     * @return string The formatted project_feed resource.
     *
     * @experimental
     */
    public static function projectFeedName($project, $feed)
    {
        return self::getProjectFeedNameTemplate()->render([
            'project' => $project,
            'feed' => $feed,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - feed: projects/{project}/feeds/{feed}
     * - folderFeed: folders/{folder}/feeds/{feed}
     * - organizationFeed: organizations/{organization}/feeds/{feed}
     * - projectFeed: projects/{project}/feeds/{feed}
     *
     * The optional $template argument can be supplied to specify a particular pattern,
     * and must match one of the templates listed above. If no $template argument is
     * provided, or if the $template argument does not match one of the templates
     * listed, then parseName will check each of the supported templates, and return
     * the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template      Optional name of template to match
     *
     * @return array An associative array from name component IDs to component values.
     *
     * @throws ValidationException If $formattedName could not be matched.
     *
     * @experimental
     */
    public static function parseName($formattedName, $template = null)
    {
        $templateMap = self::getPathTemplateMap();
        if ($template) {
            if (!isset($templateMap[$template])) {
                throw new ValidationException("Template name $template does not exist");
            }

            return $templateMap[$template]->match($formattedName);
        }

        foreach ($templateMap as $templateName => $pathTemplate) {
            try {
                return $pathTemplate->match($formattedName);
            } catch (ValidationException $ex) {
                // Swallow the exception to continue trying other path templates
            }
        }

        throw new ValidationException("Input did not match any known format. Input: $formattedName");
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *     Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'cloudasset.googleapis.com:443'.
     *     @type string|array|FetchAuthTokenInterface|CredentialsWrapper $credentials
     *           The credentials to be used by the client to authorize API calls. This option
     *           accepts either a path to a credentials file, or a decoded credentials file as a
     *           PHP array.
     *           *Advanced usage*: In addition, this option can also accept a pre-constructed
     *           {@see \Google\Auth\FetchAuthTokenInterface} object or
     *           {@see \Google\ApiCore\CredentialsWrapper} object. Note that when one of these
     *           objects are provided, any settings in $credentialsConfig will be ignored.
     *     @type array $credentialsConfig
     *           Options used to configure credentials, including auth token caching, for the
     *           client. For a full list of supporting configuration options, see
     *           {@see \Google\ApiCore\CredentialsWrapper::build()} .
     *     @type bool $disableRetries
     *           Determines whether or not retries defined by the client configuration should be
     *           disabled. Defaults to `false`.
     *     @type string|array $clientConfig
     *           Client method configuration, including retry settings. This option can be either
     *           a path to a JSON file, or a PHP array containing the decoded JSON data. By
     *           default this settings points to the default client config file, which is
     *           provided in the resources folder.
     *     @type string|TransportInterface $transport
     *           The transport used for executing network requests. May be either the string
     *           `rest` or `grpc`. Defaults to `grpc` if gRPC support is detected on the system.
     *           *Advanced usage*: Additionally, it is possible to pass in an already
     *           instantiated {@see \Google\ApiCore\Transport\TransportInterface} object. Note
     *           that when this object is provided, any settings in $transportConfig, and any
     *           $serviceAddress setting, will be ignored.
     *     @type array $transportConfig
     *           Configuration options that will be used to construct the transport. Options for
     *           each supported transport type should be passed in a key for that transport. For
     *           example:
     *           $transportConfig = [
     *               'grpc' => [...],
     *               'rest' => [...],
     *           ];
     *           See the {@see \Google\ApiCore\Transport\GrpcTransport::build()} and
     *           {@see \Google\ApiCore\Transport\RestTransport::build()} methods for the
     *           supported options.
     *     @type callable $clientCertSource
     *           A callable which returns the client cert as a string. This can be used to
     *           provide a certificate and private key to the transport layer for mTLS.
     * }
     *
     * @throws ValidationException
     *
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Creates a feed in a parent project/folder/organization to listen to its
     * asset updates.
     *
     * Sample code:
     * ```
     * $assetServiceClient = new AssetServiceClient();
     * try {
     *     $parent = 'parent';
     *     $feedId = 'feed_id';
     *     $feed = new Feed();
     *     $response = $assetServiceClient->createFeed($parent, $feedId, $feed);
     * } finally {
     *     $assetServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The name of the project/folder/organization where this feed
     *                             should be created in. It can only be an organization number (such as
     *                             "organizations/123"), a folder number (such as "folders/123"), a project ID
     *                             (such as "projects/my-project-id")", or a project number (such as
     *                             "projects/12345").
     * @param string $feedId       Required. This is the client-assigned asset feed identifier and it needs to
     *                             be unique under a specific parent project/folder/organization.
     * @param Feed   $feed         Required. The feed details. The field `name` must be empty and it will be generated
     *                             in the format of:
     *                             projects/project_number/feeds/feed_id
     *                             folders/folder_number/feeds/feed_id
     *                             organizations/organization_number/feeds/feed_id
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Asset\V1p2beta1\Feed
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createFeed($parent, $feedId, $feed, array $optionalArgs = [])
    {
        $request = new CreateFeedRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setFeedId($feedId);
        $request->setFeed($feed);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateFeed', Feed::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes an asset feed.
     *
     * Sample code:
     * ```
     * $assetServiceClient = new AssetServiceClient();
     * try {
     *     $formattedName = $assetServiceClient->feedName('[PROJECT]', '[FEED]');
     *     $assetServiceClient->deleteFeed($formattedName);
     * } finally {
     *     $assetServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the feed and it must be in the format of:
     *                             projects/project_number/feeds/feed_id
     *                             folders/folder_number/feeds/feed_id
     *                             organizations/organization_number/feeds/feed_id
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function deleteFeed($name, array $optionalArgs = [])
    {
        $request = new DeleteFeedRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteFeed', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets details about an asset feed.
     *
     * Sample code:
     * ```
     * $assetServiceClient = new AssetServiceClient();
     * try {
     *     $formattedName = $assetServiceClient->feedName('[PROJECT]', '[FEED]');
     *     $response = $assetServiceClient->getFeed($formattedName);
     * } finally {
     *     $assetServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Feed and it must be in the format of:
     *                             projects/project_number/feeds/feed_id
     *                             folders/folder_number/feeds/feed_id
     *                             organizations/organization_number/feeds/feed_id
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Asset\V1p2beta1\Feed
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getFeed($name, array $optionalArgs = [])
    {
        $request = new GetFeedRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetFeed', Feed::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists all asset feeds in a parent project/folder/organization.
     *
     * Sample code:
     * ```
     * $assetServiceClient = new AssetServiceClient();
     * try {
     *     $parent = 'parent';
     *     $response = $assetServiceClient->listFeeds($parent);
     * } finally {
     *     $assetServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent project/folder/organization whose feeds are to be
     *                             listed. It can only be using project/folder/organization number (such as
     *                             "folders/12345")", or a project ID (such as "projects/my-project-id").
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Asset\V1p2beta1\ListFeedsResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function listFeeds($parent, array $optionalArgs = [])
    {
        $request = new ListFeedsRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('ListFeeds', ListFeedsResponse::class, $optionalArgs, $request)->wait();
    }

    /**
     * Updates an asset feed configuration.
     *
     * Sample code:
     * ```
     * $assetServiceClient = new AssetServiceClient();
     * try {
     *     $feed = new Feed();
     *     $updateMask = new FieldMask();
     *     $response = $assetServiceClient->updateFeed($feed, $updateMask);
     * } finally {
     *     $assetServiceClient->close();
     * }
     * ```
     *
     * @param Feed      $feed         Required. The new values of feed details. It must match an existing feed and the
     *                                field `name` must be in the format of:
     *                                projects/project_number/feeds/feed_id or
     *                                folders/folder_number/feeds/feed_id or
     *                                organizations/organization_number/feeds/feed_id.
     * @param FieldMask $updateMask   Required. Only updates the `feed` fields indicated by this mask.
     *                                The field mask must not be empty, and it must not contain fields that
     *                                are immutable or only set by the server.
     * @param array     $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Asset\V1p2beta1\Feed
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function updateFeed($feed, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateFeedRequest();
        $requestParamHeaders = [];
        $request->setFeed($feed);
        $request->setUpdateMask($updateMask);
        $requestParamHeaders['feed.name'] = $feed->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateFeed', Feed::class, $optionalArgs, $request)->wait();
    }
}
