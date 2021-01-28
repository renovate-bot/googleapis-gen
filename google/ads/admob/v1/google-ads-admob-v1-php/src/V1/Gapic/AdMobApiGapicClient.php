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
 * https://github.com/google/googleapis/blob/master/google/ads/admob/v1/admob_api.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Ads\Admob\V1\Gapic;

use Google\Ads\Admob\V1\GenerateMediationReportRequest;
use Google\Ads\Admob\V1\GenerateMediationReportResponse;
use Google\Ads\Admob\V1\GenerateNetworkReportRequest;
use Google\Ads\Admob\V1\GenerateNetworkReportResponse;
use Google\Ads\Admob\V1\GetPublisherAccountRequest;
use Google\Ads\Admob\V1\ListPublisherAccountsRequest;
use Google\Ads\Admob\V1\ListPublisherAccountsResponse;
use Google\Ads\Admob\V1\MediationReportSpec;
use Google\Ads\Admob\V1\NetworkReportSpec;
use Google\Ads\Admob\V1\PublisherAccount;
use Google\ApiCore\ApiException;
use Google\ApiCore\Call;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;

/**
 * Service Description: The AdMob API allows AdMob publishers programmatically get information about
 * their AdMob account.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $adMobApiClient = new AdMobApiClient();
 * try {
 *     $formattedName = $adMobApiClient->accountName('[ACCOUNT]');
 *     $response = $adMobApiClient->getPublisherAccount($formattedName);
 * } finally {
 *     $adMobApiClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To assist
 * with these names, this class includes a format method for each type of name, and additionally
 * a parseName method to extract the individual identifiers contained within formatted names
 * that are returned by the API.
 *
 * @experimental
 */
class AdMobApiGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.ads.admob.v1.AdMobApi';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'admob.googleapis.com';

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
        'https://www.googleapis.com/auth/admob.report',
    ];
    private static $accountNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/ad_mob_api_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/ad_mob_api_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/ad_mob_api_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/ad_mob_api_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAccountNameTemplate()
    {
        if (null == self::$accountNameTemplate) {
            self::$accountNameTemplate = new PathTemplate('accounts/{account}');
        }

        return self::$accountNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'account' => self::getAccountNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a account resource.
     *
     * @param string $account
     *
     * @return string The formatted account resource.
     * @experimental
     */
    public static function accountName($account)
    {
        return self::getAccountNameTemplate()->render([
            'account' => $account,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - account: accounts/{account}.
     *
     * The optional $template argument can be supplied to specify a particular pattern, and must
     * match one of the templates listed above. If no $template argument is provided, or if the
     * $template argument does not match one of the templates listed, then parseName will check
     * each of the supported templates, and return the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template      Optional name of template to match
     *
     * @return array An associative array from name component IDs to component values.
     *
     * @throws ValidationException If $formattedName could not be matched.
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
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'admob.googleapis.com:443'.
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
     * Gets information about the specified AdMob publisher account.
     *
     * Sample code:
     * ```
     * $adMobApiClient = new AdMobApiClient();
     * try {
     *     $formattedName = $adMobApiClient->accountName('[ACCOUNT]');
     *     $response = $adMobApiClient->getPublisherAccount($formattedName);
     * } finally {
     *     $adMobApiClient->close();
     * }
     * ```
     *
     * @param string $name         Resource name of the publisher account to retrieve.
     *                             Example: accounts/pub-9876543210987654
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Ads\Admob\V1\PublisherAccount
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getPublisherAccount($name, array $optionalArgs = [])
    {
        $request = new GetPublisherAccountRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetPublisherAccount',
            PublisherAccount::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     *
     * Sample code:
     * ```
     * $adMobApiClient = new AdMobApiClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $adMobApiClient->listPublisherAccounts();
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
     *     $pagedResponse = $adMobApiClient->listPublisherAccounts();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $adMobApiClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
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
    public function listPublisherAccounts(array $optionalArgs = [])
    {
        $request = new ListPublisherAccountsRequest();
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        return $this->getPagedListResponse(
            'ListPublisherAccounts',
            $optionalArgs,
            ListPublisherAccountsResponse::class,
            $request
        );
    }

    /**
     * Generates an AdMob Network report based on the provided report
     * specification.
     *
     * Sample code:
     * ```
     * $adMobApiClient = new AdMobApiClient();
     * try {
     *     $formattedParent = $adMobApiClient->accountName('[ACCOUNT]');
     *     $reportSpec = new NetworkReportSpec();
     *     // Read all responses until the stream is complete
     *     $stream = $adMobApiClient->generateNetworkReport($formattedParent, $reportSpec);
     *     foreach ($stream->readAll() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $adMobApiClient->close();
     * }
     * ```
     *
     * @param string            $parent       Resource name of the account to generate the report for.
     *                                        Example: accounts/pub-9876543210987654
     * @param NetworkReportSpec $reportSpec   Network report specification.
     * @param array             $optionalArgs {
     *                                        Optional.
     *
     *     @type int $timeoutMillis
     *          Timeout to use for this call.
     * }
     *
     * @return \Google\ApiCore\ServerStream
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function generateNetworkReport($parent, $reportSpec, array $optionalArgs = [])
    {
        $request = new GenerateNetworkReportRequest();
        $request->setParent($parent);
        $request->setReportSpec($reportSpec);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GenerateNetworkReport',
            GenerateNetworkReportResponse::class,
            $optionalArgs,
            $request,
            Call::SERVER_STREAMING_CALL
        );
    }

    /**
     * Generates an AdMob Mediation report based on the provided report
     * specification.
     *
     * Sample code:
     * ```
     * $adMobApiClient = new AdMobApiClient();
     * try {
     *     $formattedParent = $adMobApiClient->accountName('[ACCOUNT]');
     *     $reportSpec = new MediationReportSpec();
     *     // Read all responses until the stream is complete
     *     $stream = $adMobApiClient->generateMediationReport($formattedParent, $reportSpec);
     *     foreach ($stream->readAll() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $adMobApiClient->close();
     * }
     * ```
     *
     * @param string              $parent       Resource name of the account to generate the report for.
     *                                          Example: accounts/pub-9876543210987654
     * @param MediationReportSpec $reportSpec   Network report specification.
     * @param array               $optionalArgs {
     *                                          Optional.
     *
     *     @type int $timeoutMillis
     *          Timeout to use for this call.
     * }
     *
     * @return \Google\ApiCore\ServerStream
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function generateMediationReport($parent, $reportSpec, array $optionalArgs = [])
    {
        $request = new GenerateMediationReportRequest();
        $request->setParent($parent);
        $request->setReportSpec($reportSpec);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GenerateMediationReport',
            GenerateMediationReportResponse::class,
            $optionalArgs,
            $request,
            Call::SERVER_STREAMING_CALL
        );
    }
}
