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
 * https://github.com/google/googleapis/blob/master/google/monitoring/dashboard/v1/dashboards_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Monitoring\Dashboard\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Monitoring\Dashboard\V1\CreateDashboardRequest;
use Google\Monitoring\Dashboard\V1\Dashboard;
use Google\Monitoring\Dashboard\V1\DeleteDashboardRequest;
use Google\Monitoring\Dashboard\V1\GetDashboardRequest;
use Google\Monitoring\Dashboard\V1\ListDashboardsRequest;
use Google\Monitoring\Dashboard\V1\ListDashboardsResponse;
use Google\Monitoring\Dashboard\V1\UpdateDashboardRequest;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Manages Stackdriver dashboards. A dashboard is an arrangement of data display
 * widgets in a specific layout.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $dashboardsServiceClient = new DashboardsServiceClient();
 * try {
 *     $parent = '';
 *     $dashboard = new Dashboard();
 *     $response = $dashboardsServiceClient->createDashboard($parent, $dashboard);
 * } finally {
 *     $dashboardsServiceClient->close();
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
class DashboardsServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.monitoring.dashboard.v1.DashboardsService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'monitoring.googleapis.com';

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
        'https://www.googleapis.com/auth/monitoring',
        'https://www.googleapis.com/auth/monitoring.read',
        'https://www.googleapis.com/auth/monitoring.write',
    ];
    private static $dashboardNameTemplate;
    private static $projectNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/dashboards_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/dashboards_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/dashboards_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/dashboards_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getDashboardNameTemplate()
    {
        if (null == self::$dashboardNameTemplate) {
            self::$dashboardNameTemplate = new PathTemplate('projects/{project}/dashboards/{dashboard}');
        }

        return self::$dashboardNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (null == self::$projectNameTemplate) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'dashboard' => self::getDashboardNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a dashboard resource.
     *
     * @param string $project
     * @param string $dashboard
     *
     * @return string The formatted dashboard resource.
     * @experimental
     */
    public static function dashboardName($project, $dashboard)
    {
        return self::getDashboardNameTemplate()->render([
            'project' => $project,
            'dashboard' => $dashboard,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project resource.
     *
     * @param string $project
     *
     * @return string The formatted project resource.
     * @experimental
     */
    public static function projectName($project)
    {
        return self::getProjectNameTemplate()->render([
            'project' => $project,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - dashboard: projects/{project}/dashboards/{dashboard}
     * - project: projects/{project}.
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
     *           as "<uri>:<port>". Default 'monitoring.googleapis.com:443'.
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
     * Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](https://cloud.google.com/monitoring/dashboards/api-dashboard).
     * This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](https://cloud.google.com/iam).
     *
     * Sample code:
     * ```
     * $dashboardsServiceClient = new DashboardsServiceClient();
     * try {
     *     $parent = '';
     *     $dashboard = new Dashboard();
     *     $response = $dashboardsServiceClient->createDashboard($parent, $dashboard);
     * } finally {
     *     $dashboardsServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The project on which to execute the request. The format is:
     *
     *     projects/[PROJECT_ID_OR_NUMBER]
     *
     * The `[PROJECT_ID_OR_NUMBER]` must match the dashboard resource name.
     * @param Dashboard $dashboard    Required. The initial dashboard specification.
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Monitoring\Dashboard\V1\Dashboard
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createDashboard($parent, $dashboard, array $optionalArgs = [])
    {
        $request = new CreateDashboardRequest();
        $request->setParent($parent);
        $request->setDashboard($dashboard);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateDashboard',
            Dashboard::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists the existing dashboards.
     *
     * This method requires the `monitoring.dashboards.list` permission
     * on the specified project. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     *
     * Sample code:
     * ```
     * $dashboardsServiceClient = new DashboardsServiceClient();
     * try {
     *     $formattedParent = $dashboardsServiceClient->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $dashboardsServiceClient->listDashboards($formattedParent);
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
     *     $pagedResponse = $dashboardsServiceClient->listDashboards($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $dashboardsServiceClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The scope of the dashboards to list. The format is:
     *
     *     projects/[PROJECT_ID_OR_NUMBER]
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
    public function listDashboards($parent, array $optionalArgs = [])
    {
        $request = new ListDashboardsRequest();
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
            'ListDashboards',
            $optionalArgs,
            ListDashboardsResponse::class,
            $request
        );
    }

    /**
     * Fetches a specific dashboard.
     *
     * This method requires the `monitoring.dashboards.get` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     *
     * Sample code:
     * ```
     * $dashboardsServiceClient = new DashboardsServiceClient();
     * try {
     *     $formattedName = $dashboardsServiceClient->dashboardName('[PROJECT]', '[DASHBOARD]');
     *     $response = $dashboardsServiceClient->getDashboard($formattedName);
     * } finally {
     *     $dashboardsServiceClient->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the Dashboard. The format is one of:
     *
     *  -  `dashboards/[DASHBOARD_ID]` (for system dashboards)
     *  -  `projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID]`
     *       (for custom dashboards).
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
     * @return \Google\Monitoring\Dashboard\V1\Dashboard
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getDashboard($name, array $optionalArgs = [])
    {
        $request = new GetDashboardRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetDashboard',
            Dashboard::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes an existing custom dashboard.
     *
     * This method requires the `monitoring.dashboards.delete` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     *
     * Sample code:
     * ```
     * $dashboardsServiceClient = new DashboardsServiceClient();
     * try {
     *     $formattedName = $dashboardsServiceClient->dashboardName('[PROJECT]', '[DASHBOARD]');
     *     $dashboardsServiceClient->deleteDashboard($formattedName);
     * } finally {
     *     $dashboardsServiceClient->close();
     * }
     * ```
     *
     * @param string $name Required. The resource name of the Dashboard. The format is:
     *
     *     projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID]
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
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteDashboard($name, array $optionalArgs = [])
    {
        $request = new DeleteDashboardRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteDashboard',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Replaces an existing custom dashboard with a new definition.
     *
     * This method requires the `monitoring.dashboards.update` permission
     * on the specified dashboard. For more information, see
     * [Cloud Identity and Access Management](https://cloud.google.com/iam).
     *
     * Sample code:
     * ```
     * $dashboardsServiceClient = new DashboardsServiceClient();
     * try {
     *     $dashboard = new Dashboard();
     *     $response = $dashboardsServiceClient->updateDashboard($dashboard);
     * } finally {
     *     $dashboardsServiceClient->close();
     * }
     * ```
     *
     * @param Dashboard $dashboard    Required. The dashboard that will replace the existing dashboard.
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Monitoring\Dashboard\V1\Dashboard
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateDashboard($dashboard, array $optionalArgs = [])
    {
        $request = new UpdateDashboardRequest();
        $request->setDashboard($dashboard);

        $requestParams = new RequestParamsHeaderDescriptor([
          'dashboard.name' => $request->getDashboard()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateDashboard',
            Dashboard::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
