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
 * https://github.com/google/googleapis/blob/master/google/cloud/clouddms/v1/clouddms.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Clouddms\V1\Gapic;

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
use Google\Cloud\Clouddms\V1\ConnectionProfile;
use Google\Cloud\Clouddms\V1\CreateConnectionProfileRequest;
use Google\Cloud\Clouddms\V1\CreateMigrationJobRequest;
use Google\Cloud\Clouddms\V1\DeleteConnectionProfileRequest;
use Google\Cloud\Clouddms\V1\DeleteMigrationJobRequest;
use Google\Cloud\Clouddms\V1\GenerateSshScriptRequest;
use Google\Cloud\Clouddms\V1\GetConnectionProfileRequest;
use Google\Cloud\Clouddms\V1\GetMigrationJobRequest;
use Google\Cloud\Clouddms\V1\ListConnectionProfilesRequest;
use Google\Cloud\Clouddms\V1\ListConnectionProfilesResponse;
use Google\Cloud\Clouddms\V1\ListMigrationJobsRequest;
use Google\Cloud\Clouddms\V1\ListMigrationJobsResponse;
use Google\Cloud\Clouddms\V1\MigrationJob;
use Google\Cloud\Clouddms\V1\PromoteMigrationJobRequest;
use Google\Cloud\Clouddms\V1\RestartMigrationJobRequest;
use Google\Cloud\Clouddms\V1\ResumeMigrationJobRequest;
use Google\Cloud\Clouddms\V1\SshScript;
use Google\Cloud\Clouddms\V1\StartMigrationJobRequest;
use Google\Cloud\Clouddms\V1\StopMigrationJobRequest;
use Google\Cloud\Clouddms\V1\UpdateConnectionProfileRequest;
use Google\Cloud\Clouddms\V1\UpdateMigrationJobRequest;
use Google\Cloud\Clouddms\V1\VerifyMigrationJobRequest;
use Google\Cloud\Clouddms\V1\VmCreationConfig;
use Google\Cloud\Clouddms\V1\VmSelectionConfig;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;

/**
 * Service Description: Database Migration service.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $dataMigrationServiceClient = new DataMigrationServiceClient();
 * try {
 *     $formattedParent = $dataMigrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $dataMigrationServiceClient->listMigrationJobs($formattedParent);
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
 *     $pagedResponse = $dataMigrationServiceClient->listMigrationJobs($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $dataMigrationServiceClient->close();
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
class DataMigrationServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.clouddms.v1.DataMigrationService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'datamigration.googleapis.com';

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
    private static $connectionProfileNameTemplate;
    private static $locationNameTemplate;
    private static $migrationJobNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/data_migration_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/data_migration_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/data_migration_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/data_migration_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getConnectionProfileNameTemplate()
    {
        if (null == self::$connectionProfileNameTemplate) {
            self::$connectionProfileNameTemplate = new PathTemplate('projects/{project}/locations/{location}/connectionProfiles/{connection_profile}');
        }

        return self::$connectionProfileNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getMigrationJobNameTemplate()
    {
        if (null == self::$migrationJobNameTemplate) {
            self::$migrationJobNameTemplate = new PathTemplate('projects/{project}/locations/{location}/migrationJobs/{migration_job}');
        }

        return self::$migrationJobNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'connectionProfile' => self::getConnectionProfileNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'migrationJob' => self::getMigrationJobNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a connection_profile resource.
     *
     * @param string $project
     * @param string $location
     * @param string $connectionProfile
     *
     * @return string The formatted connection_profile resource.
     * @experimental
     */
    public static function connectionProfileName($project, $location, $connectionProfile)
    {
        return self::getConnectionProfileNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'connection_profile' => $connectionProfile,
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
     * a migration_job resource.
     *
     * @param string $project
     * @param string $location
     * @param string $migrationJob
     *
     * @return string The formatted migration_job resource.
     * @experimental
     */
    public static function migrationJobName($project, $location, $migrationJob)
    {
        return self::getMigrationJobNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'migration_job' => $migrationJob,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - connectionProfile: projects/{project}/locations/{location}/connectionProfiles/{connection_profile}
     * - location: projects/{project}/locations/{location}
     * - migrationJob: projects/{project}/locations/{location}/migrationJobs/{migration_job}.
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
     *           as "<uri>:<port>". Default 'datamigration.googleapis.com:443'.
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
     * Lists migration jobs in a given project and location.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedParent = $dataMigrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dataMigrationServiceClient->listMigrationJobs($formattedParent);
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
     *     $pagedResponse = $dataMigrationServiceClient->listMigrationJobs($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent, which owns this collection of migrationJobs.
     * @param array  $optionalArgs {
     *                             Optional.
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
     *          A filter expression that filters migration jobs listed in the response.
     *          The expression must specify the field name, a comparison operator, and the
     *          value that you want to use for filtering. The value must be a string,
     *          a number, or a boolean. The comparison operator must be
     *          either =, !=, >, or <. For example, list migration jobs created this year
     *          by specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z.**
     *          You can also filter nested fields. For example, you could specify
     *          **reverseSshConnectivity.vmIp = "1.2.3.4"** to select all migration
     *          jobs connecting through the specific SSH tunnel bastion.
     *     @type string $orderBy
     *          Sort the results based on the migration job name.
     *          Valid values are: "name", "name asc", and "name desc".
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
    public function listMigrationJobs($parent, array $optionalArgs = [])
    {
        $request = new ListMigrationJobsRequest();
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
            'ListMigrationJobs',
            $optionalArgs,
            ListMigrationJobsResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single migration job.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedName = $dataMigrationServiceClient->migrationJobName('[PROJECT]', '[LOCATION]', '[MIGRATION_JOB]');
     *     $response = $dataMigrationServiceClient->getMigrationJob($formattedName);
     * } finally {
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the migration job resource to get.
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
     * @return \Google\Cloud\Clouddms\V1\MigrationJob
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getMigrationJob($name, array $optionalArgs = [])
    {
        $request = new GetMigrationJobRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetMigrationJob',
            MigrationJob::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new migration job in a given project and location.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedParent = $dataMigrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $migrationJobId = '';
     *     $migrationJob = new MigrationJob();
     *     $operationResponse = $dataMigrationServiceClient->createMigrationJob($formattedParent, $migrationJobId, $migrationJob);
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
     *     $operationResponse = $dataMigrationServiceClient->createMigrationJob($formattedParent, $migrationJobId, $migrationJob);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'createMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string       $parent         Required. The parent, which owns this collection of migration jobs.
     * @param string       $migrationJobId Required. The ID of the instance to create.
     * @param MigrationJob $migrationJob   Required. Represents a [migration
     *                                     job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
     *                                     object.
     * @param array        $optionalArgs   {
     *                                     Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
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
    public function createMigrationJob($parent, $migrationJobId, $migrationJob, array $optionalArgs = [])
    {
        $request = new CreateMigrationJobRequest();
        $request->setParent($parent);
        $request->setMigrationJobId($migrationJobId);
        $request->setMigrationJob($migrationJob);
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
            'CreateMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the parameters of a single migration job.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $updateMask = new FieldMask();
     *     $migrationJob = new MigrationJob();
     *     $operationResponse = $dataMigrationServiceClient->updateMigrationJob($updateMask, $migrationJob);
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
     *     $operationResponse = $dataMigrationServiceClient->updateMigrationJob($updateMask, $migrationJob);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'updateMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param FieldMask    $updateMask   Required. Field mask is used to specify the fields to be overwritten in the
     *                                   migration job resource by the update.
     * @param MigrationJob $migrationJob Required. The migration job parameters to update.
     * @param array        $optionalArgs {
     *                                   Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
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
    public function updateMigrationJob($updateMask, $migrationJob, array $optionalArgs = [])
    {
        $request = new UpdateMigrationJobRequest();
        $request->setUpdateMask($updateMask);
        $request->setMigrationJob($migrationJob);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'migration_job.name' => $request->getMigrationJob()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single migration job.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedName = $dataMigrationServiceClient->migrationJobName('[PROJECT]', '[LOCATION]', '[MIGRATION_JOB]');
     *     $operationResponse = $dataMigrationServiceClient->deleteMigrationJob($formattedName);
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
     *     $operationResponse = $dataMigrationServiceClient->deleteMigrationJob($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'deleteMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the migration job resource to delete.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
     *     @type bool $force
     *          The destination CloudSQL connection profile is always deleted with the
     *          migration job. In case of force delete, the destination CloudSQL replica
     *          database is also deleted.
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
    public function deleteMigrationJob($name, array $optionalArgs = [])
    {
        $request = new DeleteMigrationJobRequest();
        $request->setName($name);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }
        if (isset($optionalArgs['force'])) {
            $request->setForce($optionalArgs['force']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Start an already created migration job.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->startMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->startMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'startMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to start.
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
    public function startMigrationJob(array $optionalArgs = [])
    {
        $request = new StartMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'StartMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Stops a running migration job.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->stopMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->stopMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'stopMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to stop.
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
    public function stopMigrationJob(array $optionalArgs = [])
    {
        $request = new StopMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'StopMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Resume a migration job that is currently stopped and is resumable (was
     * stopped during CDC phase).
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->resumeMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->resumeMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'resumeMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to resume.
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
    public function resumeMigrationJob(array $optionalArgs = [])
    {
        $request = new ResumeMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'ResumeMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Promote a migration job, stopping replication to the destination and
     * promoting the destination to be a standalone database.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->promoteMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->promoteMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'promoteMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to promote.
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
    public function promoteMigrationJob(array $optionalArgs = [])
    {
        $request = new PromoteMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'PromoteMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Verify a migration job, making sure the destination can reach the source
     * and that all configuration and prerequisites are met.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->verifyMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->verifyMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'verifyMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to verify.
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
    public function verifyMigrationJob(array $optionalArgs = [])
    {
        $request = new VerifyMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'VerifyMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Restart a stopped or failed migration job, resetting the destination
     * instance to its original state and starting the migration process from
     * scratch.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $operationResponse = $dataMigrationServiceClient->restartMigrationJob();
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
     *     $operationResponse = $dataMigrationServiceClient->restartMigrationJob();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'restartMigrationJob');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $name
     *          Name of the migration job resource to restart.
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
    public function restartMigrationJob(array $optionalArgs = [])
    {
        $request = new RestartMigrationJobRequest();
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'RestartMigrationJob',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Generate a SSH configuration script to configure the reverse SSH
     * connectivity.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $vm = '';
     *     $response = $dataMigrationServiceClient->generateSshScript($vm);
     * } finally {
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $vm           Required. Bastion VM Instance name to use or to create.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $migrationJob
     *          Name of the migration job resource to generate the SSH script.
     *     @type VmCreationConfig $vmCreationConfig
     *          The VM creation configuration
     *     @type VmSelectionConfig $vmSelectionConfig
     *          The VM selection configuration
     *     @type int $vmPort
     *          The port that will be open on the bastion host
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Clouddms\V1\SshScript
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function generateSshScript($vm, array $optionalArgs = [])
    {
        $request = new GenerateSshScriptRequest();
        $request->setVm($vm);
        if (isset($optionalArgs['migrationJob'])) {
            $request->setMigrationJob($optionalArgs['migrationJob']);
        }
        if (isset($optionalArgs['vmCreationConfig'])) {
            $request->setVmCreationConfig($optionalArgs['vmCreationConfig']);
        }
        if (isset($optionalArgs['vmSelectionConfig'])) {
            $request->setVmSelectionConfig($optionalArgs['vmSelectionConfig']);
        }
        if (isset($optionalArgs['vmPort'])) {
            $request->setVmPort($optionalArgs['vmPort']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'migration_job' => $request->getMigrationJob(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GenerateSshScript',
            SshScript::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Retrieve a list of all connection profiles in a given project and location.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedParent = $dataMigrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dataMigrationServiceClient->listConnectionProfiles($formattedParent);
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
     *     $pagedResponse = $dataMigrationServiceClient->listConnectionProfiles($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent, which owns this collection of connection profiles.
     * @param array  $optionalArgs {
     *                             Optional.
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
     *          A filter expression that filters connection profiles listed in the
     *          response. The expression must specify the field name, a comparison
     *          operator, and the value that you want to use for filtering. The value must
     *          be a string, a number, or a boolean. The comparison operator must be either
     *          =, !=, >, or <. For example, list connection profiles created this year by
     *          specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z**. You can
     *          also filter nested fields. For example, you could specify **mySql.username
     *          = %lt;my_username%gt;** to list all connection profiles configured to
     *          connect with a specific username.
     *     @type string $orderBy
     *          the order by fields for the result.
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
    public function listConnectionProfiles($parent, array $optionalArgs = [])
    {
        $request = new ListConnectionProfilesRequest();
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
            'ListConnectionProfiles',
            $optionalArgs,
            ListConnectionProfilesResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single connection profile.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedName = $dataMigrationServiceClient->connectionProfileName('[PROJECT]', '[LOCATION]', '[CONNECTION_PROFILE]');
     *     $response = $dataMigrationServiceClient->getConnectionProfile($formattedName);
     * } finally {
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the connection profile resource to get.
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
     * @return \Google\Cloud\Clouddms\V1\ConnectionProfile
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getConnectionProfile($name, array $optionalArgs = [])
    {
        $request = new GetConnectionProfileRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetConnectionProfile',
            ConnectionProfile::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new connection profile in a given project and location.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedParent = $dataMigrationServiceClient->connectionProfileName('[PROJECT]', '[LOCATION]', '[CONNECTION_PROFILE]');
     *     $connectionProfileId = '';
     *     $connectionProfile = new ConnectionProfile();
     *     $operationResponse = $dataMigrationServiceClient->createConnectionProfile($formattedParent, $connectionProfileId, $connectionProfile);
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
     *     $operationResponse = $dataMigrationServiceClient->createConnectionProfile($formattedParent, $connectionProfileId, $connectionProfile);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'createConnectionProfile');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string            $parent              Required. The parent, which owns this collection of connection profiles.
     * @param string            $connectionProfileId Required. The connection profile identifier.
     * @param ConnectionProfile $connectionProfile   Required. The create request body including the connection profile data
     * @param array             $optionalArgs        {
     *                                               Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
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
    public function createConnectionProfile($parent, $connectionProfileId, $connectionProfile, array $optionalArgs = [])
    {
        $request = new CreateConnectionProfileRequest();
        $request->setParent($parent);
        $request->setConnectionProfileId($connectionProfileId);
        $request->setConnectionProfile($connectionProfile);
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
            'CreateConnectionProfile',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Update the configuration of a single connection profile.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $updateMask = new FieldMask();
     *     $connectionProfile = new ConnectionProfile();
     *     $operationResponse = $dataMigrationServiceClient->updateConnectionProfile($updateMask, $connectionProfile);
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
     *     $operationResponse = $dataMigrationServiceClient->updateConnectionProfile($updateMask, $connectionProfile);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'updateConnectionProfile');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param FieldMask         $updateMask        Required. Field mask is used to specify the fields to be overwritten in the
     *                                             connection profile resource by the update.
     * @param ConnectionProfile $connectionProfile Required. The connection profile parameters to update.
     * @param array             $optionalArgs      {
     *                                             Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
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
    public function updateConnectionProfile($updateMask, $connectionProfile, array $optionalArgs = [])
    {
        $request = new UpdateConnectionProfileRequest();
        $request->setUpdateMask($updateMask);
        $request->setConnectionProfile($connectionProfile);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'connection_profile.name' => $request->getConnectionProfile()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateConnectionProfile',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single Database Migration Service connection profile.
     * A connection profile can only be deleted if it is not in use by any
     * active migration jobs.
     *
     * Sample code:
     * ```
     * $dataMigrationServiceClient = new DataMigrationServiceClient();
     * try {
     *     $formattedName = $dataMigrationServiceClient->connectionProfileName('[PROJECT]', '[LOCATION]', '[CONNECTION_PROFILE]');
     *     $operationResponse = $dataMigrationServiceClient->deleteConnectionProfile($formattedName);
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
     *     $operationResponse = $dataMigrationServiceClient->deleteConnectionProfile($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $dataMigrationServiceClient->resumeOperation($operationName, 'deleteConnectionProfile');
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
     *     $dataMigrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the connection profile resource to delete.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $requestId
     *          A unique id used to identify the request. If the server receives two
     *          requests with the same id, then the second request will be ignored.
     *
     *          It is recommended to always set this value to a UUID.
     *
     *          The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
     *          (_), and hyphens (-). The maximum length is 40 characters.
     *     @type bool $force
     *          In case of force delete, the CloudSQL replica database is also deleted
     *          (only for CloudSQL connection profile).
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
    public function deleteConnectionProfile($name, array $optionalArgs = [])
    {
        $request = new DeleteConnectionProfileRequest();
        $request->setName($name);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }
        if (isset($optionalArgs['force'])) {
            $request->setForce($optionalArgs['force']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteConnectionProfile',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }
}
