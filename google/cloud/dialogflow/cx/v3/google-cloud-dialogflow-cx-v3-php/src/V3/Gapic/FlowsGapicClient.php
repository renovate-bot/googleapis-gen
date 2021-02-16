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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/cx/v3/flow.proto
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
use Google\Cloud\Dialogflow\Cx\V3\CreateFlowRequest;
use Google\Cloud\Dialogflow\Cx\V3\DeleteFlowRequest;
use Google\Cloud\Dialogflow\Cx\V3\Flow;
use Google\Cloud\Dialogflow\Cx\V3\FlowValidationResult;
use Google\Cloud\Dialogflow\Cx\V3\GetFlowRequest;
use Google\Cloud\Dialogflow\Cx\V3\GetFlowValidationResultRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListFlowsRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListFlowsResponse;
use Google\Cloud\Dialogflow\Cx\V3\TrainFlowRequest;
use Google\Cloud\Dialogflow\Cx\V3\UpdateFlowRequest;
use Google\Cloud\Dialogflow\Cx\V3\ValidateFlowRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Flows][google.cloud.dialogflow.cx.v3.Flow].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $flowsClient = new FlowsClient();
 * try {
 *     $formattedParent = $flowsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
 *     $flow = new Flow();
 *     $response = $flowsClient->createFlow($formattedParent, $flow);
 * } finally {
 *     $flowsClient->close();
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
class FlowsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3.Flows';

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
    private static $flowNameTemplate;
    private static $flowValidationResultNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/flows_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/flows_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/flows_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/flows_rest_client_config.php',
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

    private static function getFlowNameTemplate()
    {
        if (null == self::$flowNameTemplate) {
            self::$flowNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}');
        }

        return self::$flowNameTemplate;
    }

    private static function getFlowValidationResultNameTemplate()
    {
        if (null == self::$flowValidationResultNameTemplate) {
            self::$flowValidationResultNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/validationResult');
        }

        return self::$flowValidationResultNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'agent' => self::getAgentNameTemplate(),
                'flow' => self::getFlowNameTemplate(),
                'flowValidationResult' => self::getFlowValidationResultNameTemplate(),
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
     * a flow_validation_result resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $flow
     *
     * @return string The formatted flow_validation_result resource.
     * @experimental
     */
    public static function flowValidationResultName($project, $location, $agent, $flow)
    {
        return self::getFlowValidationResultNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'flow' => $flow,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agent: projects/{project}/locations/{location}/agents/{agent}
     * - flow: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}
     * - flowValidationResult: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/validationResult.
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
     * Creates a flow in the specified agent.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedParent = $flowsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $flow = new Flow();
     *     $response = $flowsClient->createFlow($formattedParent, $flow);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The agent to create a flow for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param Flow   $flow         Required. The flow to create.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          The language of the following fields in `flow`:
     *
     *          *  `Flow.event_handlers.trigger_fulfillment.messages`
     *          *  `Flow.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\Flow
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createFlow($parent, $flow, array $optionalArgs = [])
    {
        $request = new CreateFlowRequest();
        $request->setParent($parent);
        $request->setFlow($flow);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateFlow',
            Flow::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a specified flow.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedName = $flowsClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $flowsClient->deleteFlow($formattedName);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the flow to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type bool $force
     *          This field has no effect for flows with no incoming transitions.
     *          For flows with incoming transitions:
     *
     *          *  If `force` is set to false, an error will be returned with message
     *             indicating the incoming transitions.
     *          *  If `force` is set to true, Dialogflow will remove the flow, as well as
     *             any transitions to the flow (i.e. [Target
     *             flow][EventHandler.target_flow] in event handlers or [Target
     *             flow][TransitionRoute.target_flow] in transition routes that point to
     *             this flow will be cleared).
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
    public function deleteFlow($name, array $optionalArgs = [])
    {
        $request = new DeleteFlowRequest();
        $request->setName($name);
        if (isset($optionalArgs['force'])) {
            $request->setForce($optionalArgs['force']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteFlow',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns the list of all flows in the specified agent.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedParent = $flowsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $flowsClient->listFlows($formattedParent);
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
     *     $pagedResponse = $flowsClient->listFlows($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The agent containing the flows.
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
     *     @type string $languageCode
     *          The language to list flows for. The following fields are language
     *          dependent:
     *
     *          *  `Flow.event_handlers.trigger_fulfillment.messages`
     *          *  `Flow.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
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
    public function listFlows($parent, array $optionalArgs = [])
    {
        $request = new ListFlowsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListFlows',
            $optionalArgs,
            ListFlowsResponse::class,
            $request
        );
    }

    /**
     * Retrieves the specified flow.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedName = $flowsClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $response = $flowsClient->getFlow($formattedName);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the flow to get.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          The language to retrieve the flow for. The following fields are language
     *          dependent:
     *
     *          *  `Flow.event_handlers.trigger_fulfillment.messages`
     *          *  `Flow.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\Flow
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getFlow($name, array $optionalArgs = [])
    {
        $request = new GetFlowRequest();
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
            'GetFlow',
            Flow::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified flow.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $flow = new Flow();
     *     $updateMask = new FieldMask();
     *     $response = $flowsClient->updateFlow($flow, $updateMask);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param Flow      $flow         Required. The flow to update.
     * @param FieldMask $updateMask   Required. The mask to control which fields get updated. If `update_mask` is not
     *                                specified, an error will be returned.
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type string $languageCode
     *          The language of the following fields in `flow`:
     *
     *          *  `Flow.event_handlers.trigger_fulfillment.messages`
     *          *  `Flow.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\Flow
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateFlow($flow, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateFlowRequest();
        $request->setFlow($flow);
        $request->setUpdateMask($updateMask);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'flow.name' => $request->getFlow()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateFlow',
            Flow::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Trains the specified flow. Note that only the flow in 'draft' environment
     * is trained.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedName = $flowsClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $operationResponse = $flowsClient->trainFlow($formattedName);
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
     *     $operationResponse = $flowsClient->trainFlow($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $flowsClient->resumeOperation($operationName, 'trainFlow');
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
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The flow to train.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
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
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function trainFlow($name, array $optionalArgs = [])
    {
        $request = new TrainFlowRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'TrainFlow',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Validates the specified flow and creates or updates validation results.
     * Please call this API after the training is completed to get the complete
     * validation results.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedName = $flowsClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $response = $flowsClient->validateFlow($formattedName);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The flow to validate.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\FlowValidationResult
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function validateFlow($name, array $optionalArgs = [])
    {
        $request = new ValidateFlowRequest();
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
            'ValidateFlow',
            FlowValidationResult::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the latest flow validation result. Flow validation is performed
     * when ValidateFlow is called.
     *
     * Sample code:
     * ```
     * $flowsClient = new FlowsClient();
     * try {
     *     $formattedName = $flowsClient->flowValidationResultName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $response = $flowsClient->getFlowValidationResult($formattedName);
     * } finally {
     *     $flowsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The flow name.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>/validationResult`.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\FlowValidationResult
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getFlowValidationResult($name, array $optionalArgs = [])
    {
        $request = new GetFlowValidationResultRequest();
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
            'GetFlowValidationResult',
            FlowValidationResult::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
