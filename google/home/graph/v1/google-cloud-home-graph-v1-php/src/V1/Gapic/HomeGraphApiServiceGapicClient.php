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
 * https://github.com/google/googleapis/blob/master/google/home/graph/v1/homegraph.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Home\Graph\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Home\Graph\V1\DeleteAgentUserRequest;
use Google\Home\Graph\V1\QueryRequest;
use Google\Home\Graph\V1\QueryRequestInput;
use Google\Home\Graph\V1\QueryResponse;
use Google\Home\Graph\V1\ReportStateAndNotificationRequest;
use Google\Home\Graph\V1\ReportStateAndNotificationResponse;
use Google\Home\Graph\V1\RequestSyncDevicesRequest;
use Google\Home\Graph\V1\RequestSyncDevicesResponse;
use Google\Home\Graph\V1\StateAndNotificationPayload;
use Google\Home\Graph\V1\SyncRequest;
use Google\Home\Graph\V1\SyncResponse;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Google Home Graph API service. The Home Graph service provides support for
 * accessing first-party and third-party devices stored in Google's Home Graph.
 * The Home Graph database provides contextual data about the relationships
 * between devices and the home.
 *
 * For more details, see the [Home Graph developer
 * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
 * try {
 *     $agentUserId = '';
 *     $response = $homeGraphApiServiceClient->requestSyncDevices($agentUserId);
 * } finally {
 *     $homeGraphApiServiceClient->close();
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
class HomeGraphApiServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.home.graph.v1.HomeGraphApiService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'homegraph.googleapis.com';

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
    ];
    private static $agentUserPathNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/home_graph_api_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/home_graph_api_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/home_graph_api_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/home_graph_api_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAgentUserPathNameTemplate()
    {
        if (null == self::$agentUserPathNameTemplate) {
            self::$agentUserPathNameTemplate = new PathTemplate('agentUsers/{agent_user_path=**}');
        }

        return self::$agentUserPathNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'agentUserPath' => self::getAgentUserPathNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a agent_user_path resource.
     *
     * @param string $agentUserPath
     *
     * @return string The formatted agent_user_path resource.
     * @experimental
     */
    public static function agentUserPathName($agentUserPath)
    {
        return self::getAgentUserPathNameTemplate()->render([
            'agent_user_path' => $agentUserPath,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - agentUserPath: agentUsers/{agent_user_path=**}.
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
     *           as "<uri>:<port>". Default 'homegraph.googleapis.com:443'.
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
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     *
     *
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     *
     * Sample code:
     * ```
     * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
     * try {
     *     $agentUserId = '';
     *     $response = $homeGraphApiServiceClient->requestSyncDevices($agentUserId);
     * } finally {
     *     $homeGraphApiServiceClient->close();
     * }
     * ```
     *
     * @param string $agentUserId  Required. Third-party user ID.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type bool $async
     *          Optional. If set, the request will be added to a queue and a response will
     *          be returned immediately. This enables concurrent requests for the given
     *          `agent_user_id`, but the caller will not receive any error responses.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Home\Graph\V1\RequestSyncDevicesResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function requestSyncDevices($agentUserId, array $optionalArgs = [])
    {
        $request = new RequestSyncDevicesRequest();
        $request->setAgentUserId($agentUserId);
        if (isset($optionalArgs['async'])) {
            $request->setAsync($optionalArgs['async']);
        }

        return $this->startCall(
            'RequestSyncDevices',
            RequestSyncDevicesResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     *
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     *
     * Sample code:
     * ```
     * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
     * try {
     *     $agentUserId = '';
     *     $payload = new StateAndNotificationPayload();
     *     $response = $homeGraphApiServiceClient->reportStateAndNotification($agentUserId, $payload);
     * } finally {
     *     $homeGraphApiServiceClient->close();
     * }
     * ```
     *
     * @param string                      $agentUserId  Required. Third-party user ID.
     * @param StateAndNotificationPayload $payload      Required. State of devices to update and notification metadata for devices.
     * @param array                       $optionalArgs {
     *                                                  Optional.
     *
     *     @type string $requestId
     *          Request ID used for debugging.
     *     @type string $eventId
     *          Unique identifier per event (for example, a doorbell press).
     *     @type string $followUpToken
     *          Deprecated.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Home\Graph\V1\ReportStateAndNotificationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function reportStateAndNotification($agentUserId, $payload, array $optionalArgs = [])
    {
        $request = new ReportStateAndNotificationRequest();
        $request->setAgentUserId($agentUserId);
        $request->setPayload($payload);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }
        if (isset($optionalArgs['eventId'])) {
            $request->setEventId($optionalArgs['eventId']);
        }
        if (isset($optionalArgs['followUpToken'])) {
            $request->setFollowUpToken($optionalArgs['followUpToken']);
        }

        return $this->startCall(
            'ReportStateAndNotification',
            ReportStateAndNotificationResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     *
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     *
     * Sample code:
     * ```
     * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
     * try {
     *     $formattedAgentUserId = $homeGraphApiServiceClient->agentUserPathName('[AGENT_USER_PATH]');
     *     $homeGraphApiServiceClient->deleteAgentUser($formattedAgentUserId);
     * } finally {
     *     $homeGraphApiServiceClient->close();
     * }
     * ```
     *
     * @param string $agentUserId  Required. Third-party user ID.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $requestId
     *          Request ID used for debugging.
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
    public function deleteAgentUser($agentUserId, array $optionalArgs = [])
    {
        $request = new DeleteAgentUserRequest();
        $request->setAgentUserId($agentUserId);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'agent_user_id' => $request->getAgentUserId(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteAgentUser',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     *
     * Sample code:
     * ```
     * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
     * try {
     *     $agentUserId = '';
     *     $inputs = [];
     *     $response = $homeGraphApiServiceClient->query($agentUserId, $inputs);
     * } finally {
     *     $homeGraphApiServiceClient->close();
     * }
     * ```
     *
     * @param string              $agentUserId  Required. Third-party user ID.
     * @param QueryRequestInput[] $inputs       Required. Inputs containing third-party device IDs for which to
     *                                          get the device states.
     * @param array               $optionalArgs {
     *                                          Optional.
     *
     *     @type string $requestId
     *          Request ID used for debugging.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Home\Graph\V1\QueryResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function query($agentUserId, $inputs, array $optionalArgs = [])
    {
        $request = new QueryRequest();
        $request->setAgentUserId($agentUserId);
        $request->setInputs($inputs);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        return $this->startCall(
            'Query',
            QueryResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets all the devices associated with the given third-party user.
     *
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     *
     * Sample code:
     * ```
     * $homeGraphApiServiceClient = new HomeGraphApiServiceClient();
     * try {
     *     $agentUserId = '';
     *     $response = $homeGraphApiServiceClient->sync($agentUserId);
     * } finally {
     *     $homeGraphApiServiceClient->close();
     * }
     * ```
     *
     * @param string $agentUserId  Required. Third-party user ID.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $requestId
     *          Request ID used for debugging.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Home\Graph\V1\SyncResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function sync($agentUserId, array $optionalArgs = [])
    {
        $request = new SyncRequest();
        $request->setAgentUserId($agentUserId);
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        return $this->startCall(
            'Sync',
            SyncResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
