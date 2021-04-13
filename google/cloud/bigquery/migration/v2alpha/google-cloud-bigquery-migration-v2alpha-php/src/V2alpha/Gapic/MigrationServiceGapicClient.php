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
 * This file was generated from the file
 * https://github.com/google/googleapis/blob/master/google/cloud/bigquery/migration/v2alpha/migration_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Bigquery\Migration\V2alpha\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Bigquery\Migration\V2alpha\CreateMigrationWorkflowRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\DeleteMigrationWorkflowRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\GetMigrationSubtaskRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\GetMigrationWorkflowRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\ListMigrationSubtasksRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\ListMigrationSubtasksResponse;
use Google\Cloud\Bigquery\Migration\V2alpha\ListMigrationWorkflowsRequest;
use Google\Cloud\Bigquery\Migration\V2alpha\ListMigrationWorkflowsResponse;
use Google\Cloud\Bigquery\Migration\V2alpha\MigrationSubtask;
use Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow;
use Google\Cloud\Bigquery\Migration\V2alpha\StartMigrationWorkflowRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service to handle EDW migrations.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $migrationServiceClient = new MigrationServiceClient();
 * try {
 *     $formattedParent = $migrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     $migrationWorkflow = new MigrationWorkflow();
 *     $response = $migrationServiceClient->createMigrationWorkflow($formattedParent, $migrationWorkflow);
 * } finally {
 *     $migrationServiceClient->close();
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
class MigrationServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.bigquery.migration.v2alpha.MigrationService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'bigquerymigration.googleapis.com';

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

    private static $migrationSubtaskNameTemplate;

    private static $migrationWorkflowNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/migration_service_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/migration_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/migration_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/migration_service_rest_client_config.php',
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

    private static function getMigrationSubtaskNameTemplate()
    {
        if (self::$migrationSubtaskNameTemplate == null) {
            self::$migrationSubtaskNameTemplate = new PathTemplate('projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}');
        }

        return self::$migrationSubtaskNameTemplate;
    }

    private static function getMigrationWorkflowNameTemplate()
    {
        if (self::$migrationWorkflowNameTemplate == null) {
            self::$migrationWorkflowNameTemplate = new PathTemplate('projects/{project}/locations/{location}/workflows/{workflow}');
        }

        return self::$migrationWorkflowNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
                'migrationSubtask' => self::getMigrationSubtaskNameTemplate(),
                'migrationWorkflow' => self::getMigrationWorkflowNameTemplate(),
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
     * Formats a string containing the fully-qualified path to represent a
     * migration_subtask resource.
     *
     * @param string $project
     * @param string $location
     * @param string $workflow
     * @param string $subtask
     *
     * @return string The formatted migration_subtask resource.
     *
     * @experimental
     */
    public static function migrationSubtaskName($project, $location, $workflow, $subtask)
    {
        return self::getMigrationSubtaskNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'workflow' => $workflow,
            'subtask' => $subtask,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * migration_workflow resource.
     *
     * @param string $project
     * @param string $location
     * @param string $workflow
     *
     * @return string The formatted migration_workflow resource.
     *
     * @experimental
     */
    public static function migrationWorkflowName($project, $location, $workflow)
    {
        return self::getMigrationWorkflowNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'workflow' => $workflow,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - location: projects/{project}/locations/{location}
     * - migrationSubtask: projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}
     * - migrationWorkflow: projects/{project}/locations/{location}/workflows/{workflow}
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
     *           as "<uri>:<port>". Default 'bigquerymigration.googleapis.com:443'.
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
     * Creates a migration workflow.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedParent = $migrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $migrationWorkflow = new MigrationWorkflow();
     *     $response = $migrationServiceClient->createMigrationWorkflow($formattedParent, $migrationWorkflow);
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string            $parent            Required. The name of the project to which this migration workflow belongs.
     *                                             Example: `projects/foo/locations/bar`
     * @param MigrationWorkflow $migrationWorkflow Required. The migration workflow to create.
     * @param array             $optionalArgs      {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createMigrationWorkflow($parent, $migrationWorkflow, array $optionalArgs = [])
    {
        $request = new CreateMigrationWorkflowRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setMigrationWorkflow($migrationWorkflow);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateMigrationWorkflow', MigrationWorkflow::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes a migration workflow by name.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedName = $migrationServiceClient->migrationWorkflowName('[PROJECT]', '[LOCATION]', '[WORKFLOW]');
     *     $migrationServiceClient->deleteMigrationWorkflow($formattedName);
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The unique identifier for the migration workflow.
     *                             Example: `projects/123/locations/us/workflows/1234`
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
    public function deleteMigrationWorkflow($name, array $optionalArgs = [])
    {
        $request = new DeleteMigrationWorkflowRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteMigrationWorkflow', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets a previously created migration subtask.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedName = $migrationServiceClient->migrationSubtaskName('[PROJECT]', '[LOCATION]', '[WORKFLOW]', '[SUBTASK]');
     *     $response = $migrationServiceClient->getMigrationSubtask($formattedName);
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The unique identifier for the migration subtask.
     *                             Example: `projects/123/locations/us/workflows/1234/subtasks/543`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $readMask
     *           Optional. The list of fields to be retrieved.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Migration\V2alpha\MigrationSubtask
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getMigrationSubtask($name, array $optionalArgs = [])
    {
        $request = new GetMigrationSubtaskRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['readMask'])) {
            $request->setReadMask($optionalArgs['readMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetMigrationSubtask', MigrationSubtask::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets a previously created migration workflow.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedName = $migrationServiceClient->migrationWorkflowName('[PROJECT]', '[LOCATION]', '[WORKFLOW]');
     *     $response = $migrationServiceClient->getMigrationWorkflow($formattedName);
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The unique identifier for the migration workflow.
     *                             Example: `projects/123/locations/us/workflows/1234`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $readMask
     *           The list of fields to be retrieved.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getMigrationWorkflow($name, array $optionalArgs = [])
    {
        $request = new GetMigrationWorkflowRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['readMask'])) {
            $request->setReadMask($optionalArgs['readMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetMigrationWorkflow', MigrationWorkflow::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists previously created migration subtasks.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedParent = $migrationServiceClient->migrationWorkflowName('[PROJECT]', '[LOCATION]', '[WORKFLOW]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $migrationServiceClient->listMigrationSubtasks($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $migrationServiceClient->listMigrationSubtasks($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The migration task of the subtasks to list.
     *                             Example: `projects/123/locations/us/workflows/1234`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $readMask
     *           Optional. The list of fields to be retrieved.
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
     *     @type string $filter
     *           Optional. The filter to apply. This can be used to get the subtasks of a specific
     *           tasks in a workflow, e.g. `migration_task = "ab012"` where `"ab012"` is the
     *           task ID (not the name in the named map).
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function listMigrationSubtasks($parent, array $optionalArgs = [])
    {
        $request = new ListMigrationSubtasksRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['readMask'])) {
            $request->setReadMask($optionalArgs['readMask']);
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

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListMigrationSubtasks', $optionalArgs, ListMigrationSubtasksResponse::class, $request);
    }

    /**
     * Lists previously created migration workflow.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedParent = $migrationServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $migrationServiceClient->listMigrationWorkflows($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $migrationServiceClient->listMigrationWorkflows($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The project and location of the migration workflows to list.
     *                             Example: `projects/123/locations/us`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $readMask
     *           The list of fields to be retrieved.
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function listMigrationWorkflows($parent, array $optionalArgs = [])
    {
        $request = new ListMigrationWorkflowsRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['readMask'])) {
            $request->setReadMask($optionalArgs['readMask']);
        }

        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListMigrationWorkflows', $optionalArgs, ListMigrationWorkflowsResponse::class, $request);
    }

    /**
     * Starts a previously created migration workflow. I.e., the state transitions
     * from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
     * An error will be signaled if the state is anything other than DRAFT or
     * RUNNING.
     *
     * Sample code:
     * ```
     * $migrationServiceClient = new MigrationServiceClient();
     * try {
     *     $formattedName = $migrationServiceClient->migrationWorkflowName('[PROJECT]', '[LOCATION]', '[WORKFLOW]');
     *     $migrationServiceClient->startMigrationWorkflow($formattedName);
     * } finally {
     *     $migrationServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The unique identifier for the migration workflow.
     *                             Example: `projects/123/locations/us/workflows/1234`
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
    public function startMigrationWorkflow($name, array $optionalArgs = [])
    {
        $request = new StartMigrationWorkflowRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('StartMigrationWorkflow', GPBEmpty::class, $optionalArgs, $request)->wait();
    }
}
