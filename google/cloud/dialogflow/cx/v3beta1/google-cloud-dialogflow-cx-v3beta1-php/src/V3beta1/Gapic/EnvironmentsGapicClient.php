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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/environment.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\Cx\V3beta1\Gapic;

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
use Google\Cloud\Dialogflow\Cx\V3beta1\CreateEnvironmentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\DeleteEnvironmentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\Environment;
use Google\Cloud\Dialogflow\Cx\V3beta1\GetEnvironmentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListEnvironmentsRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListEnvironmentsResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\LookupEnvironmentHistoryRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\LookupEnvironmentHistoryResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\UpdateEnvironmentRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Environments][google.cloud.dialogflow.cx.v3beta1.Environment].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $environmentsClient = new EnvironmentsClient();
 * try {
 *     $formattedParent = $environmentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $environmentsClient->listEnvironments($formattedParent);
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
 *     $pagedResponse = $environmentsClient->listEnvironments($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $environmentsClient->close();
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
class EnvironmentsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3beta1.Environments';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'dialogflow.googleapis.com';

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
        'https://www.googleapis.com/auth/dialogflow',
    ];
    private static $agentNameTemplate;
    private static $environmentNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/environments_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/environments_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/environments_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/environments_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAgentNameTemplate()
    {
        if (null == self::$agentNameTemplate) {
            self::$agentNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}');
        }

        return self::$agentNameTemplate;
    }

    private static function getEnvironmentNameTemplate()
    {
        if (null == self::$environmentNameTemplate) {
            self::$environmentNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/environments/{environment}');
        }

        return self::$environmentNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'agent' => self::getAgentNameTemplate(),
                'environment' => self::getEnvironmentNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a agent resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     *
     * @return string The formatted agent resource.
     * @experimental
     */
    public static function agentName($project, $location, $agent)
    {
        return self::getAgentNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a environment resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $environment
     *
     * @return string The formatted environment resource.
     * @experimental
     */
    public static function environmentName($project, $location, $agent, $environment)
    {
        return self::getEnvironmentNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'environment' => $environment,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agent: projects/{project}/locations/{location}/agents/{agent}
     * - environment: projects/{project}/locations/{location}/agents/{agent}/environments/{environment}.
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
     *           as "<uri>:<port>". Default 'dialogflow.googleapis.com:443'.
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
     * Returns the list of all environments in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $formattedParent = $environmentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $environmentsClient->listEnvironments($formattedParent);
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
     *     $pagedResponse = $environmentsClient->listEnvironments($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The [Agent][google.cloud.dialogflow.cx.v3beta1.Agent] to list all environments for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
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
    public function listEnvironments($parent, array $optionalArgs = [])
    {
        $request = new ListEnvironmentsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListEnvironments',
            $optionalArgs,
            ListEnvironmentsResponse::class,
            $request
        );
    }

    /**
     * Retrieves the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $formattedName = $environmentsClient->environmentName('[PROJECT]', '[LOCATION]', '[AGENT]', '[ENVIRONMENT]');
     *     $response = $environmentsClient->getEnvironment($formattedName);
     * } finally {
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/environments/<Environment ID>`.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Environment
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getEnvironment($name, array $optionalArgs = [])
    {
        $request = new GetEnvironmentRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetEnvironment',
            Environment::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates an [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $formattedParent = $environmentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $environment = new Environment();
     *     $operationResponse = $environmentsClient->createEnvironment($formattedParent, $environment);
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
     *     $operationResponse = $environmentsClient->createEnvironment($formattedParent, $environment);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $environmentsClient->resumeOperation($operationName, 'createEnvironment');
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
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param string      $parent       Required. The [Agent][google.cloud.dialogflow.cx.v3beta1.Agent] to create an [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] for.
     *                                  Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param Environment $environment  Required. The environment to create.
     * @param array       $optionalArgs {
     *                                  Optional.
     *
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
    public function createEnvironment($parent, $environment, array $optionalArgs = [])
    {
        $request = new CreateEnvironmentRequest();
        $request->setParent($parent);
        $request->setEnvironment($environment);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateEnvironment',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $environment = new Environment();
     *     $updateMask = new FieldMask();
     *     $operationResponse = $environmentsClient->updateEnvironment($environment, $updateMask);
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
     *     $operationResponse = $environmentsClient->updateEnvironment($environment, $updateMask);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $environmentsClient->resumeOperation($operationName, 'updateEnvironment');
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
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param Environment $environment  Required. The environment to update.
     * @param FieldMask   $updateMask   Required. The mask to control which fields get updated.
     * @param array       $optionalArgs {
     *                                  Optional.
     *
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
    public function updateEnvironment($environment, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateEnvironmentRequest();
        $request->setEnvironment($environment);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'environment.name' => $request->getEnvironment()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateEnvironment',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $formattedName = $environmentsClient->environmentName('[PROJECT]', '[LOCATION]', '[AGENT]', '[ENVIRONMENT]');
     *     $environmentsClient->deleteEnvironment($formattedName);
     * } finally {
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/environments/<Environment ID>`.
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
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteEnvironment($name, array $optionalArgs = [])
    {
        $request = new DeleteEnvironmentRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteEnvironment',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Looks up the history of the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
     *
     * Sample code:
     * ```
     * $environmentsClient = new EnvironmentsClient();
     * try {
     *     $formattedName = $environmentsClient->environmentName('[PROJECT]', '[LOCATION]', '[AGENT]', '[ENVIRONMENT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $environmentsClient->lookupEnvironmentHistory($formattedName);
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
     *     $pagedResponse = $environmentsClient->lookupEnvironmentHistory($formattedName);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $environmentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the environment to look up the history for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/environments/<Environment ID>`.
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
    public function lookupEnvironmentHistory($name, array $optionalArgs = [])
    {
        $request = new LookupEnvironmentHistoryRequest();
        $request->setName($name);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'LookupEnvironmentHistory',
            $optionalArgs,
            LookupEnvironmentHistoryResponse::class,
            $request
        );
    }
}
