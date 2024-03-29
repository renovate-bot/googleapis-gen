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
 * https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/intent.proto
 * Updates to the above are reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\Cx\V3beta1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Dialogflow\Cx\V3beta1\CreateIntentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\DeleteIntentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\GetIntentRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\Intent;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListIntentsRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListIntentsResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\UpdateIntentRequest;
use Google\Protobuf\FieldMask;

use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Intents][google.cloud.dialogflow.cx.v3beta1.Intent].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $intentsClient = new IntentsClient();
 * try {
 *     $formattedParent = $intentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
 *     $intent = new Intent();
 *     $response = $intentsClient->createIntent($formattedParent, $intent);
 * } finally {
 *     $intentsClient->close();
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
class IntentsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3beta1.Intents';

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

    private static $intentNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/intents_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/intents_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/intents_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/intents_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAgentNameTemplate()
    {
        if (self::$agentNameTemplate == null) {
            self::$agentNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}');
        }

        return self::$agentNameTemplate;
    }

    private static function getIntentNameTemplate()
    {
        if (self::$intentNameTemplate == null) {
            self::$intentNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/intents/{intent}');
        }

        return self::$intentNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'agent' => self::getAgentNameTemplate(),
                'intent' => self::getIntentNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a agent
     * resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     *
     * @return string The formatted agent resource.
     *
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
     * Formats a string containing the fully-qualified path to represent a intent
     * resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $intent
     *
     * @return string The formatted intent resource.
     *
     * @experimental
     */
    public static function intentName($project, $location, $agent, $intent)
    {
        return self::getIntentNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'intent' => $intent,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agent: projects/{project}/locations/{location}/agents/{agent}
     * - intent: projects/{project}/locations/{location}/agents/{agent}/intents/{intent}
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
     * Creates an intent in the specified agent.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     *
     * Sample code:
     * ```
     * $intentsClient = new IntentsClient();
     * try {
     *     $formattedParent = $intentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $intent = new Intent();
     *     $response = $intentsClient->createIntent($formattedParent, $intent);
     * } finally {
     *     $intentsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The agent to create an intent for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param Intent $intent       Required. The intent to create.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $languageCode
     *           The language of the following fields in `intent`:
     *
     *           *   `Intent.training_phrases.parts.text`
     *
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Intent
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createIntent($parent, $intent, array $optionalArgs = [])
    {
        $request = new CreateIntentRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setIntent($intent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateIntent', Intent::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes the specified intent.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     *
     * Sample code:
     * ```
     * $intentsClient = new IntentsClient();
     * try {
     *     $formattedName = $intentsClient->intentName('[PROJECT]', '[LOCATION]', '[AGENT]', '[INTENT]');
     *     $intentsClient->deleteIntent($formattedName);
     * } finally {
     *     $intentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the intent to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/intents/<Intent ID>`.
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
    public function deleteIntent($name, array $optionalArgs = [])
    {
        $request = new DeleteIntentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteIntent', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Retrieves the specified intent.
     *
     * Sample code:
     * ```
     * $intentsClient = new IntentsClient();
     * try {
     *     $formattedName = $intentsClient->intentName('[PROJECT]', '[LOCATION]', '[AGENT]', '[INTENT]');
     *     $response = $intentsClient->getIntent($formattedName);
     * } finally {
     *     $intentsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the intent.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/intents/<Intent ID>`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $languageCode
     *           The language to retrieve the intent for. The following fields are language
     *           dependent:
     *
     *           *   `Intent.training_phrases.parts.text`
     *
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Intent
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getIntent($name, array $optionalArgs = [])
    {
        $request = new GetIntentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetIntent', Intent::class, $optionalArgs, $request)->wait();
    }

    /**
     * Returns the list of all intents in the specified agent.
     *
     * Sample code:
     * ```
     * $intentsClient = new IntentsClient();
     * try {
     *     $formattedParent = $intentsClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $intentsClient->listIntents($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $intentsClient->listIntents($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $intentsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The agent to list all intents for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $languageCode
     *           The language to list intents for. The following fields are language
     *           dependent:
     *
     *           *   `Intent.training_phrases.parts.text`
     *
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     *     @type int $intentView
     *           The resource view to apply to the returned intent.
     *           For allowed values, use constants defined on {@see \Google\Cloud\Dialogflow\Cx\V3beta1\IntentView}
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
    public function listIntents($parent, array $optionalArgs = [])
    {
        $request = new ListIntentsRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        if (isset($optionalArgs['intentView'])) {
            $request->setIntentView($optionalArgs['intentView']);
        }

        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListIntents', $optionalArgs, ListIntentsResponse::class, $request);
    }

    /**
     * Updates the specified intent.
     *
     * Note: You should always train a flow prior to sending it queries. See the
     * [training
     * documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
     *
     * Sample code:
     * ```
     * $intentsClient = new IntentsClient();
     * try {
     *     $intent = new Intent();
     *     $response = $intentsClient->updateIntent($intent);
     * } finally {
     *     $intentsClient->close();
     * }
     * ```
     *
     * @param Intent $intent       Required. The intent to update.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $languageCode
     *           The language of the following fields in `intent`:
     *
     *           *   `Intent.training_phrases.parts.text`
     *
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     *     @type FieldMask $updateMask
     *           The mask to control which fields get updated. If the mask is not present,
     *           all fields will be updated.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Intent
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function updateIntent($intent, array $optionalArgs = [])
    {
        $request = new UpdateIntentRequest();
        $requestParamHeaders = [];
        $request->setIntent($intent);
        $requestParamHeaders['intent.name'] = $intent->getName();
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }

        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateIntent', Intent::class, $optionalArgs, $request)->wait();
    }
}
