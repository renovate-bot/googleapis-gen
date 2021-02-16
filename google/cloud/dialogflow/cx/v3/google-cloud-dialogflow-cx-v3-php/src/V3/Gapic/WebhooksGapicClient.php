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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/cx/v3/webhook.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\Cx\V3\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Dialogflow\Cx\V3\CreateWebhookRequest;
use Google\Cloud\Dialogflow\Cx\V3\DeleteWebhookRequest;
use Google\Cloud\Dialogflow\Cx\V3\GetWebhookRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListWebhooksRequest;
use Google\Cloud\Dialogflow\Cx\V3\ListWebhooksResponse;
use Google\Cloud\Dialogflow\Cx\V3\UpdateWebhookRequest;
use Google\Cloud\Dialogflow\Cx\V3\Webhook;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Webhooks][google.cloud.dialogflow.cx.v3.Webhook].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $webhooksClient = new WebhooksClient();
 * try {
 *     $formattedParent = $webhooksClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $webhooksClient->listWebhooks($formattedParent);
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
 *     $pagedResponse = $webhooksClient->listWebhooks($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $webhooksClient->close();
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
class WebhooksGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3.Webhooks';

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
    private static $webhookNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/webhooks_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/webhooks_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/webhooks_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/webhooks_rest_client_config.php',
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

    private static function getWebhookNameTemplate()
    {
        if (null == self::$webhookNameTemplate) {
            self::$webhookNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}');
        }

        return self::$webhookNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'agent' => self::getAgentNameTemplate(),
                'webhook' => self::getWebhookNameTemplate(),
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
     * a webhook resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $webhook
     *
     * @return string The formatted webhook resource.
     * @experimental
     */
    public static function webhookName($project, $location, $agent, $webhook)
    {
        return self::getWebhookNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'webhook' => $webhook,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agent: projects/{project}/locations/{location}/agents/{agent}
     * - webhook: projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}.
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
    }

    /**
     * Returns the list of all webhooks in the specified agent.
     *
     * Sample code:
     * ```
     * $webhooksClient = new WebhooksClient();
     * try {
     *     $formattedParent = $webhooksClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $webhooksClient->listWebhooks($formattedParent);
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
     *     $pagedResponse = $webhooksClient->listWebhooks($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $webhooksClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The agent to list all webhooks for.
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
    public function listWebhooks($parent, array $optionalArgs = [])
    {
        $request = new ListWebhooksRequest();
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
            'ListWebhooks',
            $optionalArgs,
            ListWebhooksResponse::class,
            $request
        );
    }

    /**
     * Retrieves the specified webhook.
     *
     * Sample code:
     * ```
     * $webhooksClient = new WebhooksClient();
     * try {
     *     $formattedName = $webhooksClient->webhookName('[PROJECT]', '[LOCATION]', '[AGENT]', '[WEBHOOK]');
     *     $response = $webhooksClient->getWebhook($formattedName);
     * } finally {
     *     $webhooksClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the webhook.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/webhooks/<Webhook ID>`.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\Webhook
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getWebhook($name, array $optionalArgs = [])
    {
        $request = new GetWebhookRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetWebhook',
            Webhook::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a webhook in the specified agent.
     *
     * Sample code:
     * ```
     * $webhooksClient = new WebhooksClient();
     * try {
     *     $formattedParent = $webhooksClient->agentName('[PROJECT]', '[LOCATION]', '[AGENT]');
     *     $webhook = new Webhook();
     *     $response = $webhooksClient->createWebhook($formattedParent, $webhook);
     * } finally {
     *     $webhooksClient->close();
     * }
     * ```
     *
     * @param string  $parent       Required. The agent to create a webhook for.
     *                              Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     * @param Webhook $webhook      Required. The webhook to create.
     * @param array   $optionalArgs {
     *                              Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\Cx\V3\Webhook
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createWebhook($parent, $webhook, array $optionalArgs = [])
    {
        $request = new CreateWebhookRequest();
        $request->setParent($parent);
        $request->setWebhook($webhook);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateWebhook',
            Webhook::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified webhook.
     *
     * Sample code:
     * ```
     * $webhooksClient = new WebhooksClient();
     * try {
     *     $webhook = new Webhook();
     *     $response = $webhooksClient->updateWebhook($webhook);
     * } finally {
     *     $webhooksClient->close();
     * }
     * ```
     *
     * @param Webhook $webhook      Required. The webhook to update.
     * @param array   $optionalArgs {
     *                              Optional.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3\Webhook
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateWebhook($webhook, array $optionalArgs = [])
    {
        $request = new UpdateWebhookRequest();
        $request->setWebhook($webhook);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'webhook.name' => $request->getWebhook()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateWebhook',
            Webhook::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes the specified webhook.
     *
     * Sample code:
     * ```
     * $webhooksClient = new WebhooksClient();
     * try {
     *     $formattedName = $webhooksClient->webhookName('[PROJECT]', '[LOCATION]', '[AGENT]', '[WEBHOOK]');
     *     $webhooksClient->deleteWebhook($formattedName);
     * } finally {
     *     $webhooksClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the webhook to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/webhooks/<Webhook ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type bool $force
     *          This field has no effect for webhook not being used.
     *          For webhooks that are used by pages/flows/transition route groups:
     *
     *          *  If `force` is set to false, an error will be returned with message
     *             indicating the referenced resources.
     *          *  If `force` is set to true, Dialogflow will remove the webhook, as well
     *             as any references to the webhook (i.e. [Webhook][google.cloud.dialogflow.cx.v3.Fulfillment.webhook]
     *             and [tag][google.cloud.dialogflow.cx.v3.Fulfillment.tag]in fulfillments that point to this webhook
     *             will be removed).
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
    public function deleteWebhook($name, array $optionalArgs = [])
    {
        $request = new DeleteWebhookRequest();
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
            'DeleteWebhook',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
