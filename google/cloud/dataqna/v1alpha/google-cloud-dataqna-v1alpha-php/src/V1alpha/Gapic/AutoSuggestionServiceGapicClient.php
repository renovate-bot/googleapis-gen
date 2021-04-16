<?php
/*
 * Copyright 2021 Google LLC
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
 * https://github.com/google/googleapis/blob/master/google/cloud/dataqna/v1alpha/auto_suggestion_service.proto
 * Updates to the above are reflected here through a refresh process.
 *
 * @experimental
 */

declare(strict_types=1);

namespace Google\Cloud\DataQnA\V1alpha\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;

use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\DataQnA\V1alpha\SuggestQueriesRequest;
use Google\Cloud\DataQnA\V1alpha\SuggestQueriesResponse;

/**
 * Service Description: This stateless API provides automatic suggestions for natural language
 * queries for the data sources in the provided project and location.
 *
 * The service provides a resourceless operation `suggestQueries` that can be
 * called to get a list of suggestions for a given incomplete query and scope
 * (or list of scopes) under which the query is to be interpreted.
 *
 * There are two types of suggestions, ENTITY for single entity suggestions
 * and TEMPLATE for full sentences. By default, both types are returned.
 *
 * Example Request:
 * ```
 * GetSuggestions({
 * parent: "locations/us/projects/my-project"
 * scopes:
 * "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
 * query: "top it"
 * })
 * ```
 *
 * The service will retrieve information based on the given scope(s) and give
 * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
 * dimension for the provided scope).
 * ```
 * suggestions {
 * suggestion_info {
 * annotated_suggestion {
 * text_formatted: "top item by sum of usd_revenue_net"
 * markups {
 * type: DIMENSION
 * start_char_index: 4
 * length: 4
 * }
 * markups {
 * type: METRIC
 * start_char_index: 19
 * length: 15
 * }
 * }
 * query_matches {
 * start_char_index: 0
 * length: 6
 * }
 * }
 * suggestion_type: TEMPLATE
 * ranking_score: 0.9
 * }
 * suggestions {
 * suggestion_info {
 * annotated_suggestion {
 * text_formatted: "item"
 * markups {
 * type: DIMENSION
 * start_char_index: 4
 * length: 2
 * }
 * }
 * query_matches {
 * start_char_index: 0
 * length: 6
 * }
 * }
 * suggestion_type: ENTITY
 * ranking_score: 0.8
 * }
 * ```
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $autoSuggestionServiceClient = new AutoSuggestionServiceClient();
 * try {
 *     $formattedParent = $autoSuggestionServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     $response = $autoSuggestionServiceClient->suggestQueries($formattedParent);
 * } finally {
 *     $autoSuggestionServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 *
 * @experimental
 */
class AutoSuggestionServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dataqna.v1alpha.AutoSuggestionService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'dataqna.googleapis.com';

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

    private static $locationNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/auto_suggestion_service_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/auto_suggestion_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/auto_suggestion_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/auto_suggestion_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getLocationNameTemplate()
    {
        if (self::$locationNameTemplate == null) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a location
     * resource.
     *
     * @param string $project
     * @param string $location
     *
     * @return string The formatted location resource.
     *
     * @experimental
     */
    public static function locationName($project, $location)
    {
        return self::getLocationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - location: projects/{project}/locations/{location}
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
     *           as "<uri>:<port>". Default 'dataqna.googleapis.com:443'.
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
     * Gets a list of suggestions based on a prefix string.
     * AutoSuggestion tolerance should be less than 1 second.
     *
     * Sample code:
     * ```
     * $autoSuggestionServiceClient = new AutoSuggestionServiceClient();
     * try {
     *     $formattedParent = $autoSuggestionServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $response = $autoSuggestionServiceClient->suggestQueries($formattedParent);
     * } finally {
     *     $autoSuggestionServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent of the suggestion query is the resource denoting the project and
     *                             location.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string[] $scopes
     *           The scopes to which this search is restricted. The only supported scope
     *           pattern is
     *           `//bigquery.googleapis.com/projects/{GCP-PROJECT-ID}/datasets/{DATASET-ID}/tables/{TABLE-ID}`.
     *     @type string $query
     *           User query for which to generate suggestions. If the query is empty, zero
     *           state suggestions are returned. This allows UIs to display suggestions
     *           right away, helping the user to get a sense of what a query might look
     *           like.
     *     @type int[] $suggestionTypes
     *           The requested suggestion type. Multiple suggestion types can be
     *           requested, but there is no guarantee that the service will return
     *           suggestions for each type. Suggestions for a requested type might rank
     *           lower than suggestions for other types and the service may decide to cut
     *           these suggestions off.
     *           For allowed values, use constants defined on {@see \Google\Cloud\DataQnA\V1alpha\SuggestionType}
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\DataQnA\V1alpha\SuggestQueriesResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function suggestQueries($parent, array $optionalArgs = [])
    {
        $request = new SuggestQueriesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['scopes'])) {
            $request->setScopes($optionalArgs['scopes']);
        }

        if (isset($optionalArgs['query'])) {
            $request->setQuery($optionalArgs['query']);
        }

        if (isset($optionalArgs['suggestionTypes'])) {
            $request->setSuggestionTypes($optionalArgs['suggestionTypes']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('SuggestQueries', SuggestQueriesResponse::class, $optionalArgs, $request)->wait();
    }
}
