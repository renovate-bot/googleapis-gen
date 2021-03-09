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
 * https://github.com/google/googleapis/blob/master/google/cloud/metastore/v1beta/metastore.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Metastore\V1Beta\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\LongRunning\OperationsClient;
use Google\ApiCore\OperationResponse;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Metastore\V1beta\Backup;
use Google\Cloud\Metastore\V1beta\CreateBackupRequest;
use Google\Cloud\Metastore\V1beta\CreateMetadataImportRequest;
use Google\Cloud\Metastore\V1beta\CreateServiceRequest;
use Google\Cloud\Metastore\V1beta\DatabaseDumpSpec\Type;
use Google\Cloud\Metastore\V1beta\DeleteBackupRequest;
use Google\Cloud\Metastore\V1beta\DeleteServiceRequest;
use Google\Cloud\Metastore\V1beta\ExportMetadataRequest;
use Google\Cloud\Metastore\V1beta\GetBackupRequest;
use Google\Cloud\Metastore\V1beta\GetMetadataImportRequest;
use Google\Cloud\Metastore\V1beta\GetServiceRequest;
use Google\Cloud\Metastore\V1beta\ListBackupsRequest;
use Google\Cloud\Metastore\V1beta\ListBackupsResponse;
use Google\Cloud\Metastore\V1beta\ListMetadataImportsRequest;
use Google\Cloud\Metastore\V1beta\ListMetadataImportsResponse;
use Google\Cloud\Metastore\V1beta\ListServicesRequest;
use Google\Cloud\Metastore\V1beta\ListServicesResponse;
use Google\Cloud\Metastore\V1beta\MetadataImport;
use Google\Cloud\Metastore\V1beta\Restore;
use Google\Cloud\Metastore\V1beta\RestoreServiceRequest;
use Google\Cloud\Metastore\V1beta\Restore\RestoreType;
use Google\Cloud\Metastore\V1beta\Service;
use Google\Cloud\Metastore\V1beta\UpdateMetadataImportRequest;
use Google\Cloud\Metastore\V1beta\UpdateServiceRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;

/**
 * Service Description: Configures and manages metastore services.
 * Metastore services are fully managed, highly available, auto-scaled,
 * auto-healing, OSS-native deployments of technical metadata management
 * software. Each metastore service exposes a network endpoint through which
 * metadata queries are served. Metadata queries can originate from a variety
 * of sources, including Apache Hive, Apache Presto, and Apache Spark.
 *
 * The Dataproc Metastore API defines the following resource model:
 *
 * * The service works with a collection of Google Cloud projects, named:
 * `/projects/*`
 * * Each project has a collection of available locations, named: `/locations/*`
 *   (a location must refer to a Google Cloud `region`)
 * * Each location has a collection of services, named: `/services/*`
 * * Dataproc Metastore services are resources with names of the form:
 *
 *   `/projects/{project_number}/locations/{location_id}/services/{service_id}`.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $dataprocMetastoreClient = new DataprocMetastoreClient();
 * try {
 *     $formattedParent = $dataprocMetastoreClient->locationName('[PROJECT]', '[LOCATION]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $dataprocMetastoreClient->listServices($formattedParent);
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
 *     $pagedResponse = $dataprocMetastoreClient->listServices($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $dataprocMetastoreClient->close();
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
class DataprocMetastoreGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.metastore.v1beta.DataprocMetastore';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'metastore.googleapis.com';

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
    private static $backupNameTemplate;
    private static $locationNameTemplate;
    private static $metadataImportNameTemplate;
    private static $networkNameTemplate;
    private static $serviceNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/dataproc_metastore_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/dataproc_metastore_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/dataproc_metastore_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/dataproc_metastore_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getBackupNameTemplate()
    {
        if (null == self::$backupNameTemplate) {
            self::$backupNameTemplate = new PathTemplate('projects/{project}/locations/{location}/services/{service}/backups/{backup}');
        }

        return self::$backupNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getMetadataImportNameTemplate()
    {
        if (null == self::$metadataImportNameTemplate) {
            self::$metadataImportNameTemplate = new PathTemplate('projects/{project}/locations/{location}/services/{service}/metadataImports/{metadata_import}');
        }

        return self::$metadataImportNameTemplate;
    }

    private static function getNetworkNameTemplate()
    {
        if (null == self::$networkNameTemplate) {
            self::$networkNameTemplate = new PathTemplate('projects/{project}/global/networks/{network}');
        }

        return self::$networkNameTemplate;
    }

    private static function getServiceNameTemplate()
    {
        if (null == self::$serviceNameTemplate) {
            self::$serviceNameTemplate = new PathTemplate('projects/{project}/locations/{location}/services/{service}');
        }

        return self::$serviceNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'backup' => self::getBackupNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'metadataImport' => self::getMetadataImportNameTemplate(),
                'network' => self::getNetworkNameTemplate(),
                'service' => self::getServiceNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a backup resource.
     *
     * @param string $project
     * @param string $location
     * @param string $service
     * @param string $backup
     *
     * @return string The formatted backup resource.
     * @experimental
     */
    public static function backupName($project, $location, $service, $backup)
    {
        return self::getBackupNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'service' => $service,
            'backup' => $backup,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a location resource.
     *
     * @param string $project
     * @param string $location
     *
     * @return string The formatted location resource.
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
     * Formats a string containing the fully-qualified path to represent
     * a metadata_import resource.
     *
     * @param string $project
     * @param string $location
     * @param string $service
     * @param string $metadataImport
     *
     * @return string The formatted metadata_import resource.
     * @experimental
     */
    public static function metadataImportName($project, $location, $service, $metadataImport)
    {
        return self::getMetadataImportNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'service' => $service,
            'metadata_import' => $metadataImport,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a network resource.
     *
     * @param string $project
     * @param string $network
     *
     * @return string The formatted network resource.
     * @experimental
     */
    public static function networkName($project, $network)
    {
        return self::getNetworkNameTemplate()->render([
            'project' => $project,
            'network' => $network,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a service resource.
     *
     * @param string $project
     * @param string $location
     * @param string $service
     *
     * @return string The formatted service resource.
     * @experimental
     */
    public static function serviceName($project, $location, $service)
    {
        return self::getServiceNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'service' => $service,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - backup: projects/{project}/locations/{location}/services/{service}/backups/{backup}
     * - location: projects/{project}/locations/{location}
     * - metadataImport: projects/{project}/locations/{location}/services/{service}/metadataImports/{metadata_import}
     * - network: projects/{project}/global/networks/{network}
     * - service: projects/{project}/locations/{location}/services/{service}.
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
     * Return an OperationsClient object with the same endpoint as $this.
     *
     * @return OperationsClient
     * @experimental
     */
    public function getOperationsClient()
    {
        return $this->operationsClient;
    }

    /**
     * Resume an existing long running operation that was previously started
     * by a long running API method. If $methodName is not provided, or does
     * not match a long running API method, then the operation can still be
     * resumed, but the OperationResponse object will not deserialize the
     * final response.
     *
     * @param string $operationName The name of the long running operation
     * @param string $methodName    The name of the method used to start the operation
     *
     * @return OperationResponse
     * @experimental
     */
    public function resumeOperation($operationName, $methodName = null)
    {
        $options = isset($this->descriptors[$methodName]['longRunning'])
            ? $this->descriptors[$methodName]['longRunning']
            : [];
        $operation = new OperationResponse($operationName, $this->getOperationsClient(), $options);
        $operation->reload();

        return $operation;
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'metastore.googleapis.com:443'.
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
        $this->operationsClient = $this->createOperationsClient($clientOptions);
    }

    /**
     * Lists services in a project and location.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dataprocMetastoreClient->listServices($formattedParent);
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
     *     $pagedResponse = $dataprocMetastoreClient->listServices($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the location of metastore services to
     *                       list, in the following form:
     *
     * `projects/{project_number}/locations/{location_id}`.
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
     *     @type string $filter
     *          Optional. The filter to apply to list results.
     *     @type string $orderBy
     *          Optional. Specify the ordering of results as described in [Sorting
     *          Order](https://cloud.google.com/apis/design/design_patterns#sorting_order).
     *          If not specified, the results will be sorted in the default order.
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
    public function listServices($parent, array $optionalArgs = [])
    {
        $request = new ListServicesRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }
        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListServices',
            $optionalArgs,
            ListServicesResponse::class,
            $request
        );
    }

    /**
     * Gets the details of a single service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedName = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $response = $dataprocMetastoreClient->getService($formattedName);
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $name Required. The relative resource name of the metastore service to retrieve, in the
     *                     following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}`.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Metastore\V1beta\Service
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getService($name, array $optionalArgs = [])
    {
        $request = new GetServiceRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetService',
            Service::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a metastore service in a project and location.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->locationName('[PROJECT]', '[LOCATION]');
     *     $serviceId = '';
     *     $service = new Service();
     *     $operationResponse = $dataprocMetastoreClient->createService($formattedParent, $serviceId, $service);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->createService($formattedParent, $serviceId, $service);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'createService');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the location in which to create a metastore
     *                       service, in the following form:
     *
     * `projects/{project_number}/locations/{location_id}`.
     * @param string $serviceId Required. The ID of the metastore service, which is used as the final
     *                          component of the metastore service's name.
     *
     * This value must be between 2 and 63 characters long inclusive, begin with a
     * letter, end with a letter or number, and consist of alpha-numeric
     * ASCII characters or hyphens.
     * @param Service $service      Required. The Metastore service to create. The `name` field is
     *                              ignored. The ID of the created metastore service must be provided in
     *                              the request's `service_id` field.
     * @param array   $optionalArgs {
     *                              Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createService($parent, $serviceId, $service, array $optionalArgs = [])
    {
        $request = new CreateServiceRequest();
        $request->setParent($parent);
        $request->setServiceId($serviceId);
        $request->setService($service);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateService',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the parameters of a single service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $updateMask = new FieldMask();
     *     $service = new Service();
     *     $operationResponse = $dataprocMetastoreClient->updateService($updateMask, $service);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->updateService($updateMask, $service);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'updateService');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param FieldMask $updateMask Required. A field mask used to specify the fields to be overwritten in the
     *                              metastore service resource by the update.
     *                              Fields specified in the `update_mask` are relative to the resource (not
     *                              to the full request). A field is overwritten if it is in the mask.
     * @param Service   $service    Required. The metastore service to update. The server only merges fields
     *                              in the service if they are specified in `update_mask`.
     *
     * The metastore service's `name` field is used to identify the metastore
     * service to be updated.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateService($updateMask, $service, array $optionalArgs = [])
    {
        $request = new UpdateServiceRequest();
        $request->setUpdateMask($updateMask);
        $request->setService($service);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'service.name' => $request->getService()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateService',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedName = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $operationResponse = $dataprocMetastoreClient->deleteService($formattedName);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         // operation succeeded and returns no value
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->deleteService($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'deleteService');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       // operation succeeded and returns no value
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $name Required. The relative resource name of the metastore service to delete, in the
     *                     following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}`.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteService($name, array $optionalArgs = [])
    {
        $request = new DeleteServiceRequest();
        $request->setName($name);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteService',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Lists imports in a service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dataprocMetastoreClient->listMetadataImports($formattedParent);
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
     *     $pagedResponse = $dataprocMetastoreClient->listMetadataImports($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the service whose metadata imports to
     *                       list, in the following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports`.
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
     *     @type string $filter
     *          Optional. The filter to apply to list results.
     *     @type string $orderBy
     *          Optional. Specify the ordering of results as described in [Sorting
     *          Order](https://cloud.google.com/apis/design/design_patterns#sorting_order).
     *          If not specified, the results will be sorted in the default order.
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
    public function listMetadataImports($parent, array $optionalArgs = [])
    {
        $request = new ListMetadataImportsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }
        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListMetadataImports',
            $optionalArgs,
            ListMetadataImportsResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single import.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedName = $dataprocMetastoreClient->metadataImportName('[PROJECT]', '[LOCATION]', '[SERVICE]', '[METADATA_IMPORT]');
     *     $response = $dataprocMetastoreClient->getMetadataImport($formattedName);
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $name Required. The relative resource name of the metadata import to retrieve, in the
     *                     following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Metastore\V1beta\MetadataImport
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getMetadataImport($name, array $optionalArgs = [])
    {
        $request = new GetMetadataImportRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetMetadataImport',
            MetadataImport::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new MetadataImport in a given project and location.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $metadataImportId = '';
     *     $metadataImport = new MetadataImport();
     *     $operationResponse = $dataprocMetastoreClient->createMetadataImport($formattedParent, $metadataImportId, $metadataImport);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->createMetadataImport($formattedParent, $metadataImportId, $metadataImport);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'createMetadataImport');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the service in which to create a metastore
     *                       import, in the following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}`
     * @param string $metadataImportId Required. The ID of the metadata import, which is used as the final component of the
     *                                 metadata import's name.
     *
     * This value must be between 1 and 64 characters long, begin with a letter,
     * end with a letter or number, and consist of alpha-numeric ASCII characters
     * or hyphens.
     * @param MetadataImport $metadataImport Required. The metadata import to create. The `name` field is ignored. The ID of the
     *                                       created metadata import must be provided in the request's
     *                                       `metadata_import_id` field.
     * @param array          $optionalArgs   {
     *                                       Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createMetadataImport($parent, $metadataImportId, $metadataImport, array $optionalArgs = [])
    {
        $request = new CreateMetadataImportRequest();
        $request->setParent($parent);
        $request->setMetadataImportId($metadataImportId);
        $request->setMetadataImport($metadataImport);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateMetadataImport',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates a single import.
     * Only the description field of MetadataImport is supported to be updated.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $updateMask = new FieldMask();
     *     $metadataImport = new MetadataImport();
     *     $operationResponse = $dataprocMetastoreClient->updateMetadataImport($updateMask, $metadataImport);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->updateMetadataImport($updateMask, $metadataImport);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'updateMetadataImport');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param FieldMask      $updateMask     Required. A field mask used to specify the fields to be overwritten in the
     *                                       metadata import resource by the update.
     *                                       Fields specified in the `update_mask` are relative to the resource (not
     *                                       to the full request). A field is overwritten if it is in the mask.
     * @param MetadataImport $metadataImport Required. The metadata import to update. The server only merges fields
     *                                       in the import if they are specified in `update_mask`.
     *
     * The metadata import's `name` field is used to identify the metastore
     * import to be updated.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateMetadataImport($updateMask, $metadataImport, array $optionalArgs = [])
    {
        $request = new UpdateMetadataImportRequest();
        $request->setUpdateMask($updateMask);
        $request->setMetadataImport($metadataImport);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'metadata_import.name' => $request->getMetadataImport()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateMetadataImport',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Exports metadata from a service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedService = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $operationResponse = $dataprocMetastoreClient->exportMetadata($formattedService);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->exportMetadata($formattedService);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'exportMetadata');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $service Required. The relative resource name of the metastore service to run export, in the
     *                        following form:
     *
     * `projects/{project_id}/locations/{location_id}/services/{service_id}`
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $destinationGcsFolder
     *          A Cloud Storage URI of a folder, in the format
     *          `gs://<bucket_name>/<path_inside_bucket>`. A sub-folder
     *          `<export_folder>` containing exported files will be created below it.
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format).
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type int $databaseDumpType
     *          Optional. The type of the database dump. If unspecified, defaults to `MYSQL`.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Metastore\V1beta\DatabaseDumpSpec\Type}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function exportMetadata($service, array $optionalArgs = [])
    {
        $request = new ExportMetadataRequest();
        $request->setService($service);
        if (isset($optionalArgs['destinationGcsFolder'])) {
            $request->setDestinationGcsFolder($optionalArgs['destinationGcsFolder']);
        }
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }
        if (isset($optionalArgs['databaseDumpType'])) {
            $request->setDatabaseDumpType($optionalArgs['databaseDumpType']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'service' => $request->getService(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'ExportMetadata',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Restores a service from a backup.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedService = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $formattedBackup = $dataprocMetastoreClient->backupName('[PROJECT]', '[LOCATION]', '[SERVICE]', '[BACKUP]');
     *     $operationResponse = $dataprocMetastoreClient->restoreService($formattedService, $formattedBackup);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->restoreService($formattedService, $formattedBackup);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'restoreService');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $service Required. The relative resource name of the metastore service to run restore, in the
     *                        following form:
     *
     * `projects/{project_id}/locations/{location_id}/services/{service_id}`
     * @param string $backup Required. The relative resource name of the metastore service backup to restore
     *                       from, in the following form:
     *
     * `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type int $restoreType
     *          Optional. The type of restore. If unspecified, defaults to `METADATA_ONLY`.
     *          For allowed values, use constants defined on {@see \Google\Cloud\Metastore\V1beta\Restore\RestoreType}
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format).
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function restoreService($service, $backup, array $optionalArgs = [])
    {
        $request = new RestoreServiceRequest();
        $request->setService($service);
        $request->setBackup($backup);
        if (isset($optionalArgs['restoreType'])) {
            $request->setRestoreType($optionalArgs['restoreType']);
        }
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'service' => $request->getService(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'RestoreService',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Lists backups in a service.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dataprocMetastoreClient->listBackups($formattedParent);
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
     *     $pagedResponse = $dataprocMetastoreClient->listBackups($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the service whose backups to
     *                       list, in the following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}/backups`.
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
     *     @type string $filter
     *          Optional. The filter to apply to list results.
     *     @type string $orderBy
     *          Optional. Specify the ordering of results as described in [Sorting
     *          Order](https://cloud.google.com/apis/design/design_patterns#sorting_order).
     *          If not specified, the results will be sorted in the default order.
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
    public function listBackups($parent, array $optionalArgs = [])
    {
        $request = new ListBackupsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }
        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListBackups',
            $optionalArgs,
            ListBackupsResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single backup.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedName = $dataprocMetastoreClient->backupName('[PROJECT]', '[LOCATION]', '[SERVICE]', '[BACKUP]');
     *     $response = $dataprocMetastoreClient->getBackup($formattedName);
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $name Required. The relative resource name of the backup to retrieve, in the
     *                     following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Metastore\V1beta\Backup
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getBackup($name, array $optionalArgs = [])
    {
        $request = new GetBackupRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetBackup',
            Backup::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new Backup in a given project and location.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedParent = $dataprocMetastoreClient->serviceName('[PROJECT]', '[LOCATION]', '[SERVICE]');
     *     $backupId = '';
     *     $backup = new Backup();
     *     $operationResponse = $dataprocMetastoreClient->createBackup($formattedParent, $backupId, $backup);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->createBackup($formattedParent, $backupId, $backup);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'createBackup');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The relative resource name of the service in which to create a backup
     *                       of the following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}`
     * @param string $backupId Required. The ID of the backup, which is used as the final component of the
     *                         backup's name.
     *
     * This value must be between 1 and 64 characters long, begin with a letter,
     * end with a letter or number, and consist of alpha-numeric ASCII characters
     * or hyphens.
     * @param Backup $backup       Required. The backup to create. The `name` field is ignored. The ID of the created
     *                             backup must be provided in the request's `backup_id` field.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createBackup($parent, $backupId, $backup, array $optionalArgs = [])
    {
        $request = new CreateBackupRequest();
        $request->setParent($parent);
        $request->setBackupId($backupId);
        $request->setBackup($backup);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateBackup',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single backup.
     *
     * Sample code:
     * ```
     * $dataprocMetastoreClient = new DataprocMetastoreClient();
     * try {
     *     $formattedName = $dataprocMetastoreClient->backupName('[PROJECT]', '[LOCATION]', '[SERVICE]', '[BACKUP]');
     *     $operationResponse = $dataprocMetastoreClient->deleteBackup($formattedName);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         // operation succeeded and returns no value
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $dataprocMetastoreClient->deleteBackup($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataprocMetastoreClient->resumeOperation($operationName, 'deleteBackup');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       // operation succeeded and returns no value
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $dataprocMetastoreClient->close();
     * }
     * ```
     *
     * @param string $name Required. The relative resource name of the backup to delete, in the
     *                     following form:
     *
     * `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $requestId
     *          Optional. A request ID. Specify a unique request ID to allow the server to ignore the
     *          request if it has completed. The server will ignore subsequent requests
     *          that provide a duplicate request ID for at least 60 minutes after the first
     *          request.
     *
     *          For example, if an initial request times out, followed by another request
     *          with the same request ID, the server ignores the second request to prevent
     *          the creation of duplicate commitments.
     *
     *          The request ID must be a valid
     *          [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
     *          A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteBackup($name, array $optionalArgs = [])
    {
        $request = new DeleteBackupRequest();
        $request->setName($name);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteBackup',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }
}
