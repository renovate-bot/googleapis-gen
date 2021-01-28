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
 * https://github.com/google/googleapis/blob/master/google/cloud/websecurityscanner/v1/web_security_scanner.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\WebSecurityScanner\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\WebSecurityScanner\V1\CreateScanConfigRequest;
use Google\Cloud\WebSecurityScanner\V1\DeleteScanConfigRequest;
use Google\Cloud\WebSecurityScanner\V1\Finding;
use Google\Cloud\WebSecurityScanner\V1\GetFindingRequest;
use Google\Cloud\WebSecurityScanner\V1\GetScanConfigRequest;
use Google\Cloud\WebSecurityScanner\V1\GetScanRunRequest;
use Google\Cloud\WebSecurityScanner\V1\ListCrawledUrlsRequest;
use Google\Cloud\WebSecurityScanner\V1\ListCrawledUrlsResponse;
use Google\Cloud\WebSecurityScanner\V1\ListFindingTypeStatsRequest;
use Google\Cloud\WebSecurityScanner\V1\ListFindingTypeStatsResponse;
use Google\Cloud\WebSecurityScanner\V1\ListFindingsRequest;
use Google\Cloud\WebSecurityScanner\V1\ListFindingsResponse;
use Google\Cloud\WebSecurityScanner\V1\ListScanConfigsRequest;
use Google\Cloud\WebSecurityScanner\V1\ListScanConfigsResponse;
use Google\Cloud\WebSecurityScanner\V1\ListScanRunsRequest;
use Google\Cloud\WebSecurityScanner\V1\ListScanRunsResponse;
use Google\Cloud\WebSecurityScanner\V1\ScanConfig;
use Google\Cloud\WebSecurityScanner\V1\ScanRun;
use Google\Cloud\WebSecurityScanner\V1\StartScanRunRequest;
use Google\Cloud\WebSecurityScanner\V1\StopScanRunRequest;
use Google\Cloud\WebSecurityScanner\V1\UpdateScanConfigRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Web Security Scanner Service identifies security vulnerabilities in web
 * applications hosted on Google Cloud. It crawls your application, and
 * attempts to exercise as many user inputs and event handlers as possible.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $webSecurityScannerClient = new WebSecurityScannerClient();
 * try {
 *     $response = $webSecurityScannerClient->createScanConfig();
 * } finally {
 *     $webSecurityScannerClient->close();
 * }
 * ```
 *
 * @experimental
 */
class WebSecurityScannerGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.websecurityscanner.v1.WebSecurityScanner';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'websecurityscanner.googleapis.com';

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

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/web_security_scanner_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/web_security_scanner_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/web_security_scanner_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/web_security_scanner_rest_client_config.php',
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
     *           as "<uri>:<port>". Default 'websecurityscanner.googleapis.com:443'.
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
     * Creates a new ScanConfig.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->createScanConfig();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name where the scan is created, which should be a
     *          project resource name in the format 'projects/{projectId}'.
     *     @type ScanConfig $scanConfig
     *          Required. The ScanConfig to be created.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createScanConfig(array $optionalArgs = [])
    {
        $request = new CreateScanConfigRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['scanConfig'])) {
            $request->setScanConfig($optionalArgs['scanConfig']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateScanConfig',
            ScanConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes an existing ScanConfig and its child resources.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $webSecurityScannerClient->deleteScanConfig();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the ScanConfig to be deleted. The name follows the
     *          format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteScanConfig(array $optionalArgs = [])
    {
        $request = new DeleteScanConfigRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteScanConfig',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a ScanConfig.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->getScanConfig();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the ScanConfig to be returned. The name follows the
     *          format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getScanConfig(array $optionalArgs = [])
    {
        $request = new GetScanConfigRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetScanConfig',
            ScanConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists ScanConfigs under a given project.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $webSecurityScannerClient->listScanConfigs();
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
     *     $pagedResponse = $webSecurityScannerClient->listScanConfigs();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name, which should be a project resource name in the
     *          format 'projects/{projectId}'.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listScanConfigs(array $optionalArgs = [])
    {
        $request = new ListScanConfigsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListScanConfigs',
            $optionalArgs,
            ListScanConfigsResponse::class,
            $request
        );
    }

    /**
     * Updates a ScanConfig. This method support partial update of a ScanConfig.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->updateScanConfig();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type ScanConfig $scanConfig
     *          Required. The ScanConfig to be updated. The name field must be set to identify the
     *          resource to be updated. The values of fields not covered by the mask
     *          will be ignored.
     *     @type FieldMask $updateMask
     *          Required. The update mask applies to the resource. For the `FieldMask` definition,
     *          see
     *          https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateScanConfig(array $optionalArgs = [])
    {
        $request = new UpdateScanConfigRequest();
        if (isset($optionalArgs['scanConfig'])) {
            $request->setScanConfig($optionalArgs['scanConfig']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'scan_config.name' => $request->getScanConfig()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateScanConfig',
            ScanConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Start a ScanRun according to the given ScanConfig.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->startScanRun();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the ScanConfig to be used. The name follows the
     *          format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanRun
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function startScanRun(array $optionalArgs = [])
    {
        $request = new StartScanRunRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'StartScanRun',
            ScanRun::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a ScanRun.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->getScanRun();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the ScanRun to be returned. The name follows the
     *          format of
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanRun
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getScanRun(array $optionalArgs = [])
    {
        $request = new GetScanRunRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetScanRun',
            ScanRun::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
     * stop time.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $webSecurityScannerClient->listScanRuns();
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
     *     $pagedResponse = $webSecurityScannerClient->listScanRuns();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name, which should be a scan resource name in the
     *          format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listScanRuns(array $optionalArgs = [])
    {
        $request = new ListScanRunsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListScanRuns',
            $optionalArgs,
            ListScanRunsResponse::class,
            $request
        );
    }

    /**
     * Stops a ScanRun. The stopped ScanRun is returned.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->stopScanRun();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the ScanRun to be stopped. The name follows the
     *          format of
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ScanRun
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function stopScanRun(array $optionalArgs = [])
    {
        $request = new StopScanRunRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'StopScanRun',
            ScanRun::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * List CrawledUrls under a given ScanRun.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $webSecurityScannerClient->listCrawledUrls();
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
     *     $pagedResponse = $webSecurityScannerClient->listCrawledUrls();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name, which should be a scan run resource name in the
     *          format
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listCrawledUrls(array $optionalArgs = [])
    {
        $request = new ListCrawledUrlsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListCrawledUrls',
            $optionalArgs,
            ListCrawledUrlsResponse::class,
            $request
        );
    }

    /**
     * Gets a Finding.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->getFinding();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Required. The resource name of the Finding to be returned. The name follows the
     *          format of
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\Finding
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getFinding(array $optionalArgs = [])
    {
        $request = new GetFindingRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetFinding',
            Finding::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * List Findings under a given ScanRun.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $webSecurityScannerClient->listFindings();
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
     *     $pagedResponse = $webSecurityScannerClient->listFindings();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name, which should be a scan run resource name in the
     *          format
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
     *     @type string $filter
     *          The filter expression. The expression must be in the format: <field>
     *          <operator> <value>.
     *          Supported field: 'finding_type'.
     *          Supported operator: '='.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listFindings(array $optionalArgs = [])
    {
        $request = new ListFindingsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListFindings',
            $optionalArgs,
            ListFindingsResponse::class,
            $request
        );
    }

    /**
     * List all FindingTypeStats under a given ScanRun.
     *
     * Sample code:
     * ```
     * $webSecurityScannerClient = new WebSecurityScannerClient();
     * try {
     *     $response = $webSecurityScannerClient->listFindingTypeStats();
     * } finally {
     *     $webSecurityScannerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $parent
     *          Required. The parent resource name, which should be a scan run resource name in the
     *          format
     *          'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\WebSecurityScanner\V1\ListFindingTypeStatsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listFindingTypeStats(array $optionalArgs = [])
    {
        $request = new ListFindingTypeStatsRequest();
        if (isset($optionalArgs['parent'])) {
            $request->setParent($optionalArgs['parent']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ListFindingTypeStats',
            ListFindingTypeStatsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
