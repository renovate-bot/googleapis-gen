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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/page.proto
 * and updates to that file get reflected here through a refresh process.
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
use Google\Cloud\Dialogflow\Cx\V3beta1\CreatePageRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\DeletePageRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\GetPageRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListPagesRequest;
use Google\Cloud\Dialogflow\Cx\V3beta1\ListPagesResponse;
use Google\Cloud\Dialogflow\Cx\V3beta1\Page;
use Google\Cloud\Dialogflow\Cx\V3beta1\UpdatePageRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Service for managing [Pages][google.cloud.dialogflow.cx.v3beta1.Page].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $pagesClient = new PagesClient();
 * try {
 *     $formattedParent = $pagesClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $pagesClient->listPages($formattedParent);
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
 *     $pagedResponse = $pagesClient->listPages($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $pagesClient->close();
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
class PagesGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.cx.v3beta1.Pages';

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
    private static $flowNameTemplate;
    private static $pageNameTemplate;
    private static $transitionRouteGroupNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/pages_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/pages_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/pages_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/pages_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getFlowNameTemplate()
    {
        if (null == self::$flowNameTemplate) {
            self::$flowNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}');
        }

        return self::$flowNameTemplate;
    }

    private static function getPageNameTemplate()
    {
        if (null == self::$pageNameTemplate) {
            self::$pageNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}');
        }

        return self::$pageNameTemplate;
    }

    private static function getTransitionRouteGroupNameTemplate()
    {
        if (null == self::$transitionRouteGroupNameTemplate) {
            self::$transitionRouteGroupNameTemplate = new PathTemplate('projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}');
        }

        return self::$transitionRouteGroupNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'flow' => self::getFlowNameTemplate(),
                'page' => self::getPageNameTemplate(),
                'transitionRouteGroup' => self::getTransitionRouteGroupNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
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
     * a page resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $flow
     * @param string $page
     *
     * @return string The formatted page resource.
     * @experimental
     */
    public static function pageName($project, $location, $agent, $flow, $page)
    {
        return self::getPageNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'flow' => $flow,
            'page' => $page,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a transition_route_group resource.
     *
     * @param string $project
     * @param string $location
     * @param string $agent
     * @param string $flow
     * @param string $transitionRouteGroup
     *
     * @return string The formatted transition_route_group resource.
     * @experimental
     */
    public static function transitionRouteGroupName($project, $location, $agent, $flow, $transitionRouteGroup)
    {
        return self::getTransitionRouteGroupNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'agent' => $agent,
            'flow' => $flow,
            'transition_route_group' => $transitionRouteGroup,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - flow: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}
     * - page: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}
     * - transitionRouteGroup: projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}.
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
     * Returns the list of all pages in the specified flow.
     *
     * Sample code:
     * ```
     * $pagesClient = new PagesClient();
     * try {
     *     $formattedParent = $pagesClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $pagesClient->listPages($formattedParent);
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
     *     $pagedResponse = $pagesClient->listPages($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $pagesClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The flow to list all pages for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          The language to list pages for. The following fields are language
     *          dependent:
     *
     *          *  `Page.entry_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     *          *  `Page.transition_routes.trigger_fulfillment.messages`
     *          *
     *          `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
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
    public function listPages($parent, array $optionalArgs = [])
    {
        $request = new ListPagesRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }
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
            'ListPages',
            $optionalArgs,
            ListPagesResponse::class,
            $request
        );
    }

    /**
     * Retrieves the specified page.
     *
     * Sample code:
     * ```
     * $pagesClient = new PagesClient();
     * try {
     *     $formattedName = $pagesClient->pageName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]', '[PAGE]');
     *     $response = $pagesClient->getPage($formattedName);
     * } finally {
     *     $pagesClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the page.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>/pages/<Page ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          The language to retrieve the page for. The following fields are language
     *          dependent:
     *
     *          *  `Page.entry_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     *          *  `Page.transition_routes.trigger_fulfillment.messages`
     *          *
     *          `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Page
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getPage($name, array $optionalArgs = [])
    {
        $request = new GetPageRequest();
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
            'GetPage',
            Page::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a page in the specified flow.
     *
     * Sample code:
     * ```
     * $pagesClient = new PagesClient();
     * try {
     *     $formattedParent = $pagesClient->flowName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]');
     *     $page = new Page();
     *     $response = $pagesClient->createPage($formattedParent, $page);
     * } finally {
     *     $pagesClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The flow to create a page for.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/flows/<Flow ID>`.
     * @param Page   $page         Required. The page to create.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $languageCode
     *          The language of the following fields in `page`:
     *
     *          *  `Page.entry_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     *          *  `Page.transition_routes.trigger_fulfillment.messages`
     *          *
     *          `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Page
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createPage($parent, $page, array $optionalArgs = [])
    {
        $request = new CreatePageRequest();
        $request->setParent($parent);
        $request->setPage($page);
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
            'CreatePage',
            Page::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates the specified page.
     *
     * Sample code:
     * ```
     * $pagesClient = new PagesClient();
     * try {
     *     $page = new Page();
     *     $response = $pagesClient->updatePage($page);
     * } finally {
     *     $pagesClient->close();
     * }
     * ```
     *
     * @param Page  $page         Required. The page to update.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type string $languageCode
     *          The language of the following fields in `page`:
     *
     *          *  `Page.entry_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
     *          *  `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
     *          *  `Page.transition_routes.trigger_fulfillment.messages`
     *          *
     *          `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
     *
     *          If not specified, the agent's default language is used.
     *          [Many
     *          languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *          are supported.
     *          Note: languages must be enabled in the agent before they can be used.
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
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Page
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updatePage($page, array $optionalArgs = [])
    {
        $request = new UpdatePageRequest();
        $request->setPage($page);
        if (isset($optionalArgs['languageCode'])) {
            $request->setLanguageCode($optionalArgs['languageCode']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'page.name' => $request->getPage()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdatePage',
            Page::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes the specified page.
     *
     * Sample code:
     * ```
     * $pagesClient = new PagesClient();
     * try {
     *     $formattedName = $pagesClient->pageName('[PROJECT]', '[LOCATION]', '[AGENT]', '[FLOW]', '[PAGE]');
     *     $pagesClient->deletePage($formattedName);
     * } finally {
     *     $pagesClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the page to delete.
     *                             Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *                             ID>/Flows/<flow ID>/pages/<Page ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type bool $force
     *          This field has no effect for pages with no incoming transitions.
     *          For pages with incoming transitions:
     *
     *          *  If `force` is set to false, an error will be returned with message
     *             indicating the incoming transitions.
     *          *  If `force` is set to true, Dialogflow will remove the page, as well as
     *             any transitions to the page (i.e. [Target
     *             page][EventHandler.target_page] in event handlers or [Target
     *             page][TransitionRoute.target_page] in transition routes that point to
     *             this page will be cleared).
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
    public function deletePage($name, array $optionalArgs = [])
    {
        $request = new DeletePageRequest();
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
            'DeletePage',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
