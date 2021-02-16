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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/cx/v3/agent.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\Cx\V3\Gapic;

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
use Google\Cloud\Dialogflow\Cx\V3\Agent;
use Google\Cloud\Dialogflow\Cx\V3\AgentValidationResult;
use Google\Cloud\Dialogflow\Cx\V3\CreateAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\DeleteAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\ExportAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\GetAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\GetAgentValidationResultRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListAgentsRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListAgentsResponse;
use Google\Cloud\Dialogflow\Cx\V3\RestoreAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\UpdateAgentRequest;
use Google\Cloud\Dialogflow\Cx\V3\ValidateAgentRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Agents][google.cloud.dialogflow.cx.v3.Agent].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $agentsClient = new AgentsClient();
 * try {
 *     $formattedParent = $agentsClient->locationName('[PROJECT]', '[LOCATION]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $agentsClient->listAgents($formattedParent);
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
 *     $pagedResponse = $agentsClient->listAgents($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $agentsClient->close();
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
class AgentsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3.Agents';

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
    private static $agentValidationResultNameTemplate;
    private static $flowNameTemplate;
    private static $locationNameTemplate;
    private static $securitySettingsNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/agents_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/agents_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/agents_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/agents_rest_client_config.php',
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

    private static function getAgentValidationResultNameTemplate()
    {
        if (null == self::$agentValidationResultNameTemplate) {
            self::$agentValidationResultNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/validationResult');
        }

        return self::$agentValidationResultNameTemplate;
    }

    private static function getFlowNameTemplate()
    {
        if (null == self::$flowNameTemplate) {
            self::$flowNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}');
        }

        return self::$flowNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getSecuritySettingsNameTemplate()
    {
        if (null == self::$securitySettingsNameTemplate) {
            self::$securitySettingsNameTemplate = new PathTemplate('projects/{project}/locations/{location}/securitySettings/{security_settings}');
        }

        return self::$securitySettingsNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'agent' => self::getAgentNameTemplate(),
                'agentValidationResult' => self::getAgentValidationResultNameTemplate(),
                'flow' => self::getFlowNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'securitySettings' => self::getSecuritySettingsNameTemplate(),
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
     * a agent_validation_result resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     *
     * @return string The formatted agent_validation_result resource.
     * @experimental
     */
    public static function agentValidationResultName($project, $location, $agent)
    {
        return self::getAgentValidationResultNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a flow resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $flow
     *
     * @return string The formatted flow resource.
     * @experimental
     */
    public static function flowName($project, $location, $agent, $flow)
    {
        return self::getFlowNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'flow' => $flow,
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
     * a security_settings resource.
     *
     * @param string $project
     * @param string $location
     * @param string $securitySettings
     *
     * @return string The formatted security_settings resource.
     * @experimental
     */
    public static function securitySettingsName($project, $location, $securitySettings)
    {
        return self::getSecuritySettingsNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'security_settings' => $securitySettings,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agent: projects/{project}/locations/{location}/agents/{agent}
     * - agentValidationResult: projects/{project}/locations/{location}/agents/{agent}/validationResult
     * - flow: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}
     * - location: projects/{project}/locations/{location}
     * - securitySettings: projects/{project}/locations/{location}/securitySettings/{security_settings}.
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
     * Returns the list of all agents in the specified location.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedParent = $agentsClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $agentsClient->listAgents($formattedParent);
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
     *     $pagedResponse = $agentsClient->listAgents($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The location to list all agents for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>`.
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
    public function listAgents($parent, array $optionalArgs = [])
    {
        $request = new ListAgentsRequest();
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
            'ListAgents',
            $optionalArgs,
            ListAgentsResponse::class,
            $request
        );
    }

    /**
     * Retrieves the specified agent.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $response = $agentsClient->getAgent($formattedName);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the agent.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\Agent
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getAgent($name, array $optionalArgs = [])
    {
        $request = new GetAgentRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetAgent',
            Agent::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates an agent in the specified location.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedParent = $agentsClient->locationName('[PROJECT]', '[LOCATION]');
     *     $agent = new Agent();
     *     $response = $agentsClient->createAgent($formattedParent, $agent);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The location to create a agent for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>`.
     * @param Agent  $agent        Required. The agent to create.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\Agent
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createAgent($parent, $agent, array $optionalArgs = [])
    {
        $request = new CreateAgentRequest();
        $request->setParent($parent);
        $request->setAgent($agent);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateAgent',
            Agent::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified agent.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $agent = new Agent();
     *     $response = $agentsClient->updateAgent($agent);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param Agent $agent        Required. The agent to update.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          The mask to control which fields get updated. If the mask is not present,
     *          all fields will be updated.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\Agent
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateAgent($agent, array $optionalArgs = [])
    {
        $request = new UpdateAgentRequest();
        $request->setAgent($agent);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'agent.name' => $request->getAgent()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateAgent',
            Agent::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes the specified agent.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $agentsClient->deleteAgent($formattedName);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the agent to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
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
    public function deleteAgent($name, array $optionalArgs = [])
    {
        $request = new DeleteAgentRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteAgent',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Exports the specified agent to a binary file.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $operationResponse = $agentsClient->exportAgent($formattedName);
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
     *     $operationResponse = $agentsClient->exportAgent($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $agentsClient->resumeOperation($operationName, 'exportAgent');
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
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the agent to export.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $agentUri
     *          Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
     *          export the agent to. The format of this URI must be
     *          `gs://<bucket-name>/<object-name>`.
     *          If left unspecified, the serialized agent is returned inline.
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
    public function exportAgent($name, array $optionalArgs = [])
    {
        $request = new ExportAgentRequest();
        $request->setName($name);
        if (isset($optionalArgs['agentUri'])) {
            $request->setAgentUri($optionalArgs['agentUri']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'ExportAgent',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Restores the specified agent from a binary file.
     *
     * Replaces the current agent with a new one. Note that all existing resources
     * in agent (e.g. intents, entity types, flows) will be removed.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $operationResponse = $agentsClient->restoreAgent($formattedName);
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
     *     $operationResponse = $agentsClient->restoreAgent($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $agentsClient->resumeOperation($operationName, 'restoreAgent');
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
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the agent to restore into.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $agentUri
     *          The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI
     *          to restore agent from. The format of this URI must be
     *          `gs://<bucket-name>/<object-name>`.
     *     @type string $agentContent
     *          Uncompressed raw byte content for agent.
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
    public function restoreAgent($name, array $optionalArgs = [])
    {
        $request = new RestoreAgentRequest();
        $request->setName($name);
        if (isset($optionalArgs['agentUri'])) {
            $request->setAgentUri($optionalArgs['agentUri']);
        }
        if (isset($optionalArgs['agentContent'])) {
            $request->setAgentContent($optionalArgs['agentContent']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'RestoreAgent',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Validates the specified agent and creates or updates validation results.
     * The agent in draft version is validated. Please call this API after the
     * training is completed to get the complete validation results.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $response = $agentsClient->validateAgent($formattedName);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The agent to validate.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          If not specified, the agent's default language is used.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\AgentValidationResult
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function validateAgent($name, array $optionalArgs = [])
    {
        $request = new ValidateAgentRequest();
        $request->setName($name);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ValidateAgent',
            AgentValidationResult::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the latest agent validation result. Agent validation is performed
     * when ValidateAgent is called.
     *
     * Sample code:
     * ```
     * $agentsClient = new AgentsClient();
     * try {
     *     $formattedName = $agentsClient->agentValidationResultName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $response = $agentsClient->getAgentValidationResult($formattedName);
     * } finally {
     *     $agentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The agent name.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/validationResult`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          If not specified, the agent's default language is used.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\AgentValidationResult
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getAgentValidationResult($name, array $optionalArgs = [])
    {
        $request = new GetAgentValidationResultRequest();
        $request->setName($name);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetAgentValidationResult',
            AgentValidationResult::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
